// Decompiled with JetBrains decompiler
// Type: frmClearCarriers
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.InsuredsProducersCompanies.Companies;
using MGASystems.IMS.InsuredsProducersCompanies.Companies.Intermediaries;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.NoteDocuments.Email;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.IMS.Underwriting.Quote_Clearance;
using MGASystems.InfragisticsExtensions.Editors;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#nullable disable
public class frmClearCarriers : Form
{
  protected Guid _quoteGuid = Guid.Empty;
  private Guid _lineGuid = Guid.Empty;
  private string _stateID = string.Empty;
  private Guid _controlGuid = Guid.Empty;
  private readonly int _newStatus;
  private Dictionary<Guid, ClearanceDocName> _wordDocs = new Dictionary<Guid, ClearanceDocName>();
  private Dictionary<Guid, string> _arrCCList = new Dictionary<Guid, string>();
  private Dictionary<Guid, string> _arrEmailList = new Dictionary<Guid, string>();
  private HyperlinkEditor _hlkAdd = new HyperlinkEditor();
  private HyperlinkEditor _hlkRemove = new HyperlinkEditor();
  protected List<Guid> _newlyCreatedQuoteGuids = new List<Guid>();
  private bool _useEmailTemplate;
  private readonly Guid _currentCompanyLocationGuid;
  private IContainer components;
  private MGATextBox txtSearch;
  private MGAButton btnSearch;
  private MGAButton btnClearSearch;
  private MGAButton btnSubmit;
  private dsClearCarriers ds;
  private Label label3;
  private LinkLabel lnkAddContact;
  private UltraDropDown ddEmailCC;
  private LinkLabel lnkClearAllCarriersSelected;
  protected ErrorProvider err;
  protected UltraGrid dgAvailableCarriers;
  protected UltraGrid dgCarriersSelected;
  private MGAButton btnCurrentCarrier;

  public frmClearCarriers(Guid quoteGuid, int newStatus)
  {
    this.InitializeComponent();
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
    ((ControlBase) this.btnClearSearch).Appearance.Image = (object) ImageCache.Instance.Undo;
    this.Quote = new Quote(quoteGuid);
    this._quoteGuid = quoteGuid;
    this._newStatus = newStatus;
    this._currentCompanyLocationGuid = this.Quote.CompanyLocationGuid;
  }

  public frmClearCarriers() => this.InitializeComponent();

  public Quote Quote { get; }

  public object TemplateID { get; set; }

  public List<Guid> NewlyCreatedQuoteGuids => this._newlyCreatedQuoteGuids;

  private void frmClearCarriers_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT StateID, LineGuid FROM dbo.tblQuotes WITH (NOLOCK) WHERE QuoteGuid=@QuoteGuid", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid
    });
    if (row.IsNull("StateID"))
      throw new InvalidOperationException("[frmClearCarriers_Load]. Could not determine the state for this quote!");
    this._lineGuid = !row.IsNull("LineGuid") ? row.Field<Guid>("LineGuid") : throw new InvalidOperationException("[frmClearCarriers_Load]. Could not determine the line of business for this quote!");
    this._stateID = row.Field<string>("StateID");
    this._useEmailTemplate = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ClearCarriers.UseEmailTemplate");
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.Bands[0].Columns["Remove"].Editor = (EmbeddableEditorBase) this._hlkRemove;
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.Bands[0].Columns["Add"].Editor = (EmbeddableEditorBase) this._hlkAdd;
    this._hlkRemove.HyperLinkOpening += new CancelEventHandler(this._hlkRemove_HyperLinkOpening);
    this._hlkAdd.HyperLinkOpening += new CancelEventHandler(this._hlkAdd_HyperLinkOpening);
    this.LoadClientData();
    this._newlyCreatedQuoteGuids.Clear();
    ((Control) this.btnCurrentCarrier).Visible = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Admin.ClearCarriers.ShowCurrentCarrierButton");
  }

  protected virtual void LoadClientData()
  {
  }

  public void _hlkRemove_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    if (Utility.IsNull(((UltraGridBase) this.dgCarriersSelected).ActiveRow.Cells["CompanyLocationGUID"].Value))
      return;
    Guid CompanyLocationGUID = (Guid) ((UltraGridBase) this.dgCarriersSelected).ActiveRow.Cells["CompanyLocationGUID"].Value;
    Guid CompanyContactGUID = (Guid) ((UltraGridBase) this.dgCarriersSelected).ActiveRow.Cells["CompanyContactGUID"].Value;
    dsClearCarriers.CompanyAndContactSelectedRow companyContactGuid = this.ds.CompanyAndContactSelected.FindByCompanyLocationGUIDCompanyContactGUID(CompanyLocationGUID, CompanyContactGUID);
    if (companyContactGuid == null)
      return;
    if (this.ds.CompanyAndContactInfo.FindByCompanyContactGUIDCompanyLocationGUID(CompanyContactGUID, CompanyLocationGUID) != null)
      return;
    try
    {
      this.Cursor = Cursors.WaitCursor;
      dsClearCarriers.CompanyAndContactInfoRow row = this.ds.CompanyAndContactInfo.NewCompanyAndContactInfoRow();
      row.CompanyLocationGUID = companyContactGuid.CompanyLocationGUID;
      row.CompanyContactGUID = companyContactGuid.CompanyContactGUID;
      row.ContactName = companyContactGuid.ContactName;
      row.City = companyContactGuid.IsCityNull() ? string.Empty : companyContactGuid.City;
      row.State = companyContactGuid.IsStateNull() ? string.Empty : companyContactGuid.State;
      row.CompanyGroup = companyContactGuid.IsCompanyGroupNull() ? string.Empty : companyContactGuid.CompanyGroup;
      row.LocationName = companyContactGuid.IsLocationNameNull() ? string.Empty : companyContactGuid.LocationName;
      row.Email = companyContactGuid.IsEmailNull() ? string.Empty : companyContactGuid.Email;
      this.ds.CompanyAndContactInfo.AddCompanyAndContactInfoRow(row);
      this.ds.CompanyAndContactSelected.RemoveCompanyAndContactSelectedRow(companyContactGuid);
    }
    catch (Exception ex)
    {
      ErrorHandler.HandleError(ex);
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  public void _hlkAdd_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    if (Utility.IsNull(((UltraGridBase) this.dgAvailableCarriers).ActiveRow.Cells["CompanyLocationGUID"].Value))
      return;
    Guid CompanyLocationGUID = (Guid) ((UltraGridBase) this.dgAvailableCarriers).ActiveRow.Cells["CompanyLocationGUID"].Value;
    Guid CompanyContactGUID = (Guid) ((UltraGridBase) this.dgAvailableCarriers).ActiveRow.Cells["CompanyContactGUID"].Value;
    dsClearCarriers.CompanyAndContactInfoRow companyLocationGuid = this.ds.CompanyAndContactInfo.FindByCompanyContactGUIDCompanyLocationGUID(CompanyContactGUID, CompanyLocationGUID);
    if (companyLocationGuid == null)
      return;
    if (this.ds.CompanyAndContactSelected.FindByCompanyLocationGUIDCompanyContactGUID(CompanyLocationGUID, CompanyContactGUID) != null)
    {
      this.ds.CompanyAndContactInfo.RemoveCompanyAndContactInfoRow(companyLocationGuid);
    }
    else
    {
      try
      {
        this.Cursor = Cursors.WaitCursor;
        dsClearCarriers.CompanyAndContactSelectedRow contactSelectedRow = this.ds.CompanyAndContactSelected.NewCompanyAndContactSelectedRow();
        contactSelectedRow.CompanyLocationGUID = companyLocationGuid.CompanyLocationGUID;
        contactSelectedRow.CompanyContactGUID = companyLocationGuid.CompanyContactGUID;
        contactSelectedRow.ContactName = companyLocationGuid.ContactName;
        contactSelectedRow.City = companyLocationGuid.IsCityNull() ? string.Empty : companyLocationGuid.City;
        contactSelectedRow.State = companyLocationGuid.IsStateNull() ? string.Empty : companyLocationGuid.State;
        contactSelectedRow.CompanyGroup = companyLocationGuid.IsCompanyGroupNull() ? string.Empty : companyLocationGuid.CompanyGroup;
        contactSelectedRow.LocationName = companyLocationGuid.IsLocationNameNull() ? string.Empty : companyLocationGuid.LocationName;
        contactSelectedRow.Email = companyLocationGuid.IsEmailNull() ? string.Empty : companyLocationGuid.Email;
        this.FillClientSelectedCarrierCols(contactSelectedRow, companyLocationGuid);
        this.ds.CompanyAndContactSelected.AddCompanyAndContactSelectedRow(contactSelectedRow);
        this.ds.CompanyAndContactInfo.RemoveCompanyAndContactInfoRow(companyLocationGuid);
      }
      catch (Exception ex)
      {
        ErrorHandler.HandleError(ex);
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
    }
  }

  protected virtual void FillClientSelectedCarrierCols(
    dsClearCarriers.CompanyAndContactSelectedRow drSelect,
    dsClearCarriers.CompanyAndContactInfoRow dr)
  {
  }

  private void btnClearSearch_Click(object sender, EventArgs e)
  {
    ((Control) this.txtSearch).Text = string.Empty;
    this.ds.CompanyAndContactInfo.Rows.Clear();
  }

  private bool ValidSearch()
  {
    bool flag = true;
    if (((Control) this.txtSearch).Text.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.txtSearch, "Please enter a search criteria");
      flag = false;
    }
    return flag;
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    if (!this.ValidSearch())
      return;
    string setting = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("ClearCarriers.CompanyAndContactProcName", "dbo.spGetCompanyAndContactInfo");
    this.ds.CompanyAndContactInfo.Rows.Clear();
    string str = string.Empty;
    if (((Control) this.txtSearch).Text.Replace(" ", string.Empty).Length > 0)
      str = ((Control) this.txtSearch).Text;
    try
    {
      this.Cursor = Cursors.WaitCursor;
      DefaultDatabase.LoadDataTable((DataTable) this.ds.CompanyAndContactInfo, CommandType.StoredProcedure, setting, new object[6]
      {
        (object) "@StateID",
        (object) this._stateID,
        (object) "@LineGuid",
        (object) this._lineGuid,
        (object) "@SearchText",
        (object) str
      });
    }
    catch (Exception ex)
    {
      ErrorHandler.HandleError(ex);
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void ddEmailCC_BeforeDropDown(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.dgCarriersSelected).ActiveRow == null)
    {
      this.ds.EmailCC.DefaultView.RowFilter = string.Empty;
    }
    else
    {
      Guid g = (Guid) ((UltraGridBase) this.dgCarriersSelected).ActiveRow.Cells["CompanyLocationGUID"].Value;
      int length = this.ds.EmailCC.Select($"CompanyLocationGUID = '{g.ToString()}'").Length;
      if (this.ds.EmailCC.Select($"CompanyLocationGUID <> '{g.ToString()}'").Length > 0)
      {
        for (int index = this.ds.EmailCC.Rows.Count - 1; index >= 0; --index)
        {
          DataRow row = this.ds.EmailCC.Rows[index];
          if (!row.Field<Guid>("CompanyLocationGuid").Equals(g))
            this.ds.EmailCC.Rows.Remove(row);
        }
      }
      if (length != 0)
        return;
      DefaultDatabase.LoadDataTable((DataTable) this.ds.EmailCC, CommandType.StoredProcedure, "dbo.spGetCompanyContactsEmailInfo", new object[2]
      {
        (object) "@CompanyLocationGuid",
        (object) g
      });
    }
  }

  private void btnClearSelected_Click(object sender, EventArgs e)
  {
    this.ds.CompanyAndContactSelected.Rows.Clear();
  }

  private void lnkAddContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.dgAvailableCarriers).ActiveRow == null || ((UltraGridBase) this.dgAvailableCarriers).ActiveRow.Cells["CompanyLocationGuid"].Value == DBNull.Value)
      return;
    Guid guid = (Guid) ((UltraGridBase) this.dgAvailableCarriers).ActiveRow.Cells["CompanyLocationGuid"].Value;
    object obj = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT IntermediaryGuid FROM dbo.tblCompanyLocations WHERE CompanyLocationGuid = @compGuid", new object[2]
    {
      (object) "@compGuid",
      (object) guid
    });
    if (Utility.IsNull(obj))
      MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmCompanyContacts), (object) guid);
    else
      MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmIntermediaryContacts), (object) DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT IntermediaryID FROM dbo.tblIntermediaries WHERE IntermediaryGuid = @intMedGuid", new object[2]
      {
        (object) "@intMedGuid",
        (object) (Guid) obj
      }));
  }

  protected virtual bool ValidForm()
  {
    bool flag = true;
    this._arrCCList.Clear();
    this._arrEmailList.Clear();
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.dgCarriersSelected).Rows).Count == 0)
    {
      int num = (int) MessageBox.Show("Please select at least one carrier.", "No Carrier Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    if (flag)
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.dgCarriersSelected).Rows)
      {
        string empty1 = string.Empty;
        if (row.Cells["CompanyLocationGuid"].Value == DBNull.Value || row.Cells["CompanyContactGUID"].Value == DBNull.Value)
        {
          int num = (int) MessageBox.Show("Company Location and Company Contact are required fields.", "Empty Company Location / Company Contact", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          break;
        }
        string empty2 = string.Empty;
        Guid key = (Guid) row.Cells["CompanyContactGUID"].Value;
        if (row.Cells["Email"].Value != DBNull.Value)
          empty2 = (string) row.Cells["Email"].Value;
        if (row.Cells["EmailCC"].Value != DBNull.Value)
          empty1 = row.Cells["EmailCC"].Value.ToString();
        if (!this._arrEmailList.ContainsKey(key))
          this._arrEmailList.Add(key, empty2);
        if (!this._arrCCList.ContainsKey(key))
          this._arrCCList.Add(key, empty1);
        Guid companyLocationGuid = (Guid) row.Cells["CompanyLocationGuid"].Value;
        if (!DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT CompanyLineID FROM dbo.tblCompanyLines WITH (NOLOCK) WHERE  (CompanyLocationGuid = @CLG) AND (LineGUID = @LG) AND (StateID = @ST)", new object[6]
        {
          (object) "@CLG",
          (object) companyLocationGuid,
          (object) "@LG",
          (object) this._lineGuid,
          (object) "@ST",
          (object) this._stateID
        }).HasValue)
        {
          int num = (int) MessageBox.Show($"The company / line{Environment.NewLine}{Environment.NewLine}{new MGASystems.BusinessObjects.CompanyLocation(companyLocationGuid).LocationName}  / {this.Quote.LineName} / {this._stateID}{Environment.NewLine}{Environment.NewLine} does not exist.", "Company / Line Not Exists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          break;
        }
      }
    }
    if (!flag)
    {
      this._arrCCList.Clear();
      this._arrEmailList.Clear();
    }
    return flag;
  }

  private void btnSubmit_Click(object sender, EventArgs e)
  {
    if (!this.ValidForm())
      return;
    this.CreateQuotes();
    this.Client_OnSubmit();
  }

  protected virtual void Client_OnSubmit()
  {
  }

  protected virtual void CreateQuotes() => this.CreateQuotes(string.Empty);

  protected virtual void CreateQuotes(string templateDocFileName)
  {
    Quote objectEx = (Quote) ObjectFactory.Instance.CreateObjectEX(typeof (Quote), (object) this._quoteGuid);
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuotes SET QuoteStatusID=@QuoteStatusID WHERE QuoteGuid=@QuoteGuid", new object[4]
    {
      (object) "@QuoteStatusID",
      (object) this._newStatus,
      (object) "@QuoteGUID",
      (object) this.Quote.QuoteGuid
    });
    List<Guid> newQuoteGuids = new List<Guid>();
    Guid empty1 = Guid.Empty;
    Guid empty2 = Guid.Empty;
    Dictionary<Guid, Guid> dictionary = new Dictionary<Guid, Guid>();
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append("Location(s):");
    int num1 = 0;
    this._newlyCreatedQuoteGuids.Clear();
    foreach (UltraGridRow row1 in ((UltraGridBase) this.dgCarriersSelected).Rows)
    {
      if (!Utility.IsNull(row1.Cells["CompanyLocationGUID"].Value))
      {
        Guid guid = (Guid) row1.Cells["CompanyLocationGUID"].Value;
        Guid newQuoteGuid = this.Quote.QuoteGuid;
        Guid newCompanyContactGuid = (Guid) row1.Cells["CompanyContactGUID"].Value;
        if (!objectEx.CompanyLocationGuid.Equals(guid))
        {
          objectEx.NewCompanyLocationGuid = guid;
          objectEx.NewCompanyContactGuid = newCompanyContactGuid;
          newQuoteGuid = objectEx.Copy();
          this.ConfigureQuote(objectEx, ref newQuoteGuid, ref newCompanyContactGuid);
          this.ConfigureQuoteOnClient(objectEx, ref newQuoteGuid, ref newCompanyContactGuid, guid);
          DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "dbo.QuoteEditData_GetPolicyParticipants", new object[2]
          {
            (object) "@CompanyLineGuid",
            (object) new CompanyLine(guid, objectEx.LineGuid, objectEx.StateID).CompanyLineGuid
          });
          if (dataTable.Rows.Count > 2)
          {
            Guid producerLocationGuid = objectEx.ProducerLocationGuid;
            ProducerLocation producerLocation = new ProducerLocation(producerLocationGuid);
            Guid empty3 = Guid.Empty;
            bool isRenewal = objectEx.IsRenewal;
            string empty4 = string.Empty;
            foreach (DataRow row2 in (InternalDataCollectionBase) dataTable.Rows)
            {
              Guid companyLineGuid = row2.Field<Guid>("CompanyLineGuid");
              short num2 = (short) row2["TermsOfPayment"];
              CompanyLine companyLine = new CompanyLine(companyLineGuid);
              Decimal commission1 = producerLocation.GetCommission(companyLineGuid, isRenewal, objectEx.EffectiveDate, (SqlTransaction) null, (object) objectEx.PolicyTypeID, (object) null, objectEx.QuotingLocationGuid);
              Decimal commission2 = companyLine.GetCommission(isRenewal, producerLocationGuid, commission1, objectEx.EffectiveDate, objectEx.PolicyTypeID, (SqlTransaction) null, Guid.Empty, (object) null, objectEx.QuotingLocationGuid);
              DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT TOP 1 CompanyContactGUID FROM dbo.tblCompanyContacts WHERE (CompanyLocationGuid= @cGuid)", new object[2]
              {
                (object) "@cGuid",
                (object) guid
              });
              if (dataRow != null && dataRow[0] != DBNull.Value)
                empty3 = (Guid) dataRow["CompanyContactGuid"];
              if (!empty3.Equals(Guid.Empty))
                DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO dbo.tblQuoteDetails(QuoteGuid,CompanyLineGuid,TermsOfPayment,CompanyCommission, ProducerCommission,CompanyContactGuid) VALUES (@qGuid,@clGuid,@top,@compComm,@prodComm,@cContGuid)", new object[12]
                {
                  (object) "@qGuid",
                  (object) newQuoteGuid,
                  (object) "@clGuid",
                  (object) companyLineGuid,
                  (object) "@top",
                  (object) num2,
                  (object) "@compComm",
                  (object) commission2,
                  (object) "@prodComm",
                  (object) commission1,
                  (object) "@cContGuid",
                  (object) empty3
                });
            }
          }
          newQuoteGuids.Add(newQuoteGuid);
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteFilingProducers SET InHouse = @Inhouse WHERE QuoteID = @QID", new object[4]
          {
            (object) "@Inhouse",
            (object) true,
            (object) "@QID",
            (object) new Quote(newQuoteGuid).QuoteID
          });
          this._newlyCreatedQuoteGuids.Add(newQuoteGuid);
          this.Tag = (object) $"{this.Tag}/{newQuoteGuid}";
        }
        else
        {
          string empty5 = string.Empty;
          MGASystems.BusinessObjects.CompanyLocation companyLocation = new MGASystems.BusinessObjects.CompanyLocation(guid);
          string str = companyLocation.LocationName;
          if (companyLocation.UsingIntermediary)
          {
            str = $"{str} via {DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT IntermediaryName FROM dbo.tblIntermediaries WITH (NOLOCK) WHERE IntermediaryGuid=@IG", new object[2]
            {
              (object) "@IG",
              (object) companyLocation.IntermediaryGuid
            })}";
            ++num1;
          }
          stringBuilder.Append($"{Environment.NewLine}{Environment.NewLine}{str} {Environment.NewLine}{Environment.NewLine}");
        }
        if (!string.IsNullOrEmpty(templateDocFileName))
        {
          string mergeDocument = new DocumentHandling((int) this.TemplateID).CreateMergeDocument(templateDocFileName, (object) this.Quote.QuoteGuid);
          string empty6 = string.Empty;
          string docSystem = frmClearCarriers.SendToDocSystem(newQuoteGuid, mergeDocument);
          if (!this._wordDocs.ContainsKey(newCompanyContactGuid))
            this._wordDocs.Add(newCompanyContactGuid, new ClearanceDocName(docSystem, newQuoteGuid));
        }
        else if (!this._wordDocs.ContainsKey(newCompanyContactGuid))
          this._wordDocs.Add(newCompanyContactGuid, new ClearanceDocName(string.Empty, newQuoteGuid));
        if (!dictionary.ContainsKey(newQuoteGuid))
          dictionary.Add(newQuoteGuid, newCompanyContactGuid);
      }
    }
    if (num1 > 0)
    {
      string str1 = "is";
      string str2 = "was";
      if (num1 > 1)
      {
        str1 = "are";
        str2 = "were";
      }
      stringBuilder.Append($"{str1} the same as that on the quote and {str2} not submitted to market.");
      int num3 = (int) MessageBox.Show(stringBuilder.ToString(), "Location(s) Not Submitted To Market", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    if (newQuoteGuids.Count > 0 && MessageBox.Show("Do you want to compose emails now?", "Compose Emails", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      this.CreateEmails(objectEx, newQuoteGuids);
    foreach (Guid quoteGuid in newQuoteGuids)
    {
      Guid[] associatedToEntity = DocumentManager.GetDocumentsAssociatedToEntity(objectEx.ControlGuid);
      Quote docSupport = new Quote(quoteGuid);
      foreach (Guid documentGuid in associatedToEntity)
        DocumentManager.BindDocument(documentGuid, (ISupportDocumentSystem) docSupport);
      List<Guid> guidList = new List<Guid>();
      foreach (DataRow row in (InternalDataCollectionBase) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "dbo.GetEntityAssociatedDocuments", new object[4]
      {
        (object) "@DocumentStoreGuid",
        null,
        (object) "@ControlGuid",
        (object) objectEx.ControlGuid
      }).Rows)
        guidList.Add(new Guid(row[0].ToString()));
      if (guidList.Count > 0)
      {
        for (int index = 0; index < guidList.Count; ++index)
          DocumentManager.BindDocument(guidList[index], (ISupportDocumentSystem) docSupport);
      }
      Note_System.Instance.NonInteractive.DuplicateNotesByControlGuid(this._controlGuid, docSupport.ControlGuid);
    }
    this.Close();
  }

  [Obsolete("Use ConfigureQuoteOnClient")]
  protected virtual void ConfigureQuote(
    Quote q,
    ref Guid newQuoteGuid,
    ref Guid newCompanyContactGuid)
  {
  }

  protected virtual void ConfigureQuoteOnClient(
    Quote q,
    ref Guid newQuoteGuid,
    ref Guid newCompanyContactGuid,
    Guid newCompanyLocationGuid)
  {
    if (!MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ClearanceCarriers.ConfigureNewQuote"))
      return;
    DefaultDatabase.ExecuteNonQuery("spConfigureSubmitMarketQuotes", new object[12]
    {
      (object) "@NewQuoteGuid",
      (object) newQuoteGuid,
      (object) "@OldQuoteGuid",
      (object) q.QuoteGuid,
      (object) "@OldCompanyLocationGuid",
      (object) q.CompanyLocationGuid,
      (object) "@NewCompanyContactGuid",
      (object) newCompanyContactGuid,
      (object) "@NewCompanyLocationGuid",
      (object) newCompanyLocationGuid,
      (object) "@IsParentLine",
      (object) q.CompanyLine.IsParentLine
    });
  }

  protected virtual object GetTemplateID() => (object) null;

  private static string SendToDocSystem(Guid quoteGuid, string fileName)
  {
    Quote docSupport = new Quote(quoteGuid);
    string docSystem = $"{fileName.Replace(Path.GetFileName(fileName), string.Empty)}Submission_{docSupport.ControlNo}.doc";
    File.Copy(fileName, docSystem, true);
    DocumentManager.FileAddWithBind(docSystem, 18, "Proposal_To_" + docSupport.CompanyLocation.LocationName, (ISupportDocumentSystem) docSupport, false);
    return docSystem;
  }

  private void CreateEmails(Quote q, List<Guid> newQuoteGuids)
  {
    AdditionalDocumentInfo addDocInfo = (AdditionalDocumentInfo) null;
    new AddDocumentsService().GetAdditionalDocuments(q, newQuoteGuids, (Action<AdditionalDocumentInfo>) (r => addDocInfo = r));
    foreach (KeyValuePair<Guid, ClearanceDocName> wordDoc in this._wordDocs)
    {
      ClearanceDocName clearanceDocName = wordDoc.Value;
      Guid key = wordDoc.Key;
      string str = string.Empty;
      object obj = (object) null;
      if (this._arrEmailList.ContainsKey(wordDoc.Key))
        str = this._arrEmailList[wordDoc.Key];
      if (this._arrCCList.ContainsKey(wordDoc.Key))
        obj = (object) this._arrCCList[wordDoc.Key];
      List<string> stringList1 = new List<string>();
      List<string> stringList2 = new List<string>();
      if (str != string.Empty)
        stringList1.Add(str);
      if (obj is string)
        stringList2.Add(obj.ToString());
      string empty = string.Empty;
      Guid associatedQuoteGuid = clearanceDocName.AssociatedQuoteGuid;
      Quote docSupport = (Quote) null;
      if (!associatedQuoteGuid.Equals(Guid.Empty))
      {
        docSupport = new Quote(associatedQuoteGuid);
        empty = docSupport.ControlNo.ToString();
      }
      string subject = !string.IsNullOrEmpty(empty) ? $"{q.InsuredPolicyName} - Control # {empty}, New Submission" : $"{q.InsuredPolicyName} - Control # {q.ControlNo}, New Submission";
      List<string> stringList3 = new List<string>();
      if (!string.IsNullOrEmpty(clearanceDocName.FileName))
        stringList3.Add(CompanyDocumentAutomation.ConvertWordDocToPDF(clearanceDocName.FileName));
      if (addDocInfo != null && addDocInfo.DocumentFileNames != null && addDocInfo.DocumentFileNames.Count > 0)
      {
        foreach (string documentFileName in addDocInfo.DocumentFileNames)
          stringList3.Add(documentFileName);
      }
      UI.Send((ISupportDocumentSystem) docSupport, stringList3.ToArray(), stringList1.ToArray(), subject, stringList2.ToArray(), this.GetEmailBody(associatedQuoteGuid));
    }
  }

  private void lnkClearAllCarriersSelected_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    foreach (dsClearCarriers.CompanyAndContactSelectedRow row1 in (InternalDataCollectionBase) this.ds.CompanyAndContactSelected.Rows)
    {
      dsClearCarriers.CompanyAndContactInfoRow row2 = this.ds.CompanyAndContactInfo.NewCompanyAndContactInfoRow();
      row2.CompanyContactGUID = row1.CompanyContactGUID;
      row2.CompanyLocationGUID = row1.CompanyLocationGUID;
      row2.City = row1.IsCityNull() ? string.Empty : row1.City;
      row2.State = row1.IsStateNull() ? string.Empty : row1.State;
      row2.CompanyGroup = row1.IsCompanyGroupNull() ? string.Empty : row1.CompanyGroup;
      row2.ContactName = row1.ContactName;
      row2.Email = row1.IsEmailNull() ? string.Empty : row1.Email;
      row2.LocationName = row1.IsLocationNameNull() ? string.Empty : row1.LocationName;
      this.ds.CompanyAndContactInfo.AddCompanyAndContactInfoRow(row2);
    }
    this.ds.CompanyAndContactSelected.Rows.Clear();
  }

  private void txtSearch_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSearch_Click((object) this, EventArgs.Empty);
  }

  private string GetEmailBody(Guid quoteGuid)
  {
    if (!this._useEmailTemplate || quoteGuid.Equals(Guid.Empty))
      return string.Empty;
    Guid? nullable1 = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT EventGuid FROM lstQuoteStatus WITH (NOLOCK) WHERE QuoteStatusID = @QS", new object[2]
    {
      (object) "@QS",
      (object) this._newStatus
    });
    if (!nullable1.HasValue)
      return string.Empty;
    Quote quote = new Quote(quoteGuid);
    int? nullable2 = DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT da.TemplateID FROM  dbo.tblCompanyAutomationDocuments da WITH (NOLOCK) INNER JOIN dbo.tblDocumentTemplates dt WITH (NOLOCK) ON dt.TemplateID = da.TemplateID WHERE dt.IsEmail = 1 AND da.AutomationEventGuid = @EG AND da.CompanyLineGuid = @CLG", new object[4]
    {
      (object) "@EG",
      (object) nullable1.Value,
      (object) "@CLG",
      (object) quote.CompanyLineGuid
    });
    return !nullable2.HasValue ? string.Empty : new DocumentHandling(nullable2.Value).GenerateEmailBody(quoteGuid);
  }

  private void btnCurrentCarrier_Click(object sender, EventArgs e)
  {
    if (!this.ValidateEntry())
      return;
    if (this.ds.CurrentCarrierAndContactInfo.Rows.Count == 0)
      this.FillCurrentCarrierContactInfo();
    this.AddCurrentCarrier();
  }

  private bool ValidateEntry()
  {
    if (((IEnumerable<UltraGridRow>) ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.dgCarriersSelected).Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (clg => clg.Cells["CompanyLocationGuid"].Value.Equals((object) this._currentCompanyLocationGuid))).ToArray<UltraGridRow>()).Count<UltraGridRow>() > 1)
    {
      int num = (int) MessageBox.Show("Current carrier is already selected.", "Current Carrier Already Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      return false;
    }
    if (((IEnumerable<UltraGridRow>) ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.dgAvailableCarriers).Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (clg => clg.Cells["CompanyLocationGuid"].Value.Equals((object) this._currentCompanyLocationGuid))).ToArray<UltraGridRow>()).Count<UltraGridRow>() <= 1)
      return true;
    int num1 = (int) MessageBox.Show("Current carrier is available for selection.", "Current Carrier Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    return false;
  }

  private void FillCurrentCarrierContactInfo()
  {
    try
    {
      this.Cursor = Cursors.WaitCursor;
      DefaultDatabase.LoadDataTable((DataTable) this.ds.CurrentCarrierAndContactInfo, "dbo.spGetClearCarrierContactInfo", new object[8]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid,
        (object) "@CompanyLocationGuid",
        (object) this._currentCompanyLocationGuid,
        (object) "@StateID",
        (object) this._stateID,
        (object) "@LineGuid",
        (object) this._lineGuid
      });
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void AddCurrentCarrier()
  {
    dsClearCarriers.CurrentCarrierAndContactInfoRow andContactInfoRow = this.ds.CurrentCarrierAndContactInfo[0];
    if (this.ds.CompanyAndContactInfo.FindByCompanyContactGUIDCompanyLocationGUID(andContactInfoRow.CompanyContactGUID, andContactInfoRow.CompanyLocationGUID) != null)
    {
      int num = (int) MessageBox.Show("Current carrier is already available for selection.", "Current Carrier Already Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      dsClearCarriers.CompanyAndContactInfoRow row = this.ds.CompanyAndContactInfo.NewCompanyAndContactInfoRow();
      row.CompanyContactGUID = andContactInfoRow.CompanyContactGUID;
      row.CompanyLocationGUID = andContactInfoRow.CompanyLocationGUID;
      row.ContactName = andContactInfoRow.ContactName;
      row.City = !andContactInfoRow.IsCityNull() ? andContactInfoRow.City : string.Empty;
      row.State = !andContactInfoRow.IsStateNull() ? andContactInfoRow.State : string.Empty;
      row.CompanyGroup = !andContactInfoRow.IsCompanyGroupNull() ? andContactInfoRow.CompanyGroup : string.Empty;
      row.LocationName = !andContactInfoRow.IsLocationNameNull() ? andContactInfoRow.LocationName : string.Empty;
      row.Email = !andContactInfoRow.IsEmailNull() ? andContactInfoRow.Email : string.Empty;
      this.ds.CompanyAndContactInfo.AddCompanyAndContactInfoRow(row);
      ((UltraGridBase) this.dgAvailableCarriers).UpdateData();
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("EmailCC", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Contact");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CompanyLocationGUID");
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("CompanyAndContactSelected", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CompanyContactGUID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyLocationGUID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ContactName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CompanyGroup");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("LocationName");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("EmailCC", -1, (object) "ddEmailCC");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Remove");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("State");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance14 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("CompanyAndContactInfo", -1);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("CompanyContactGUID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("CompanyLocationGUID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("ContactName");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("CompanyGroup");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("LocationName");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Add");
    Appearance appearance15 = new Appearance();
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("State");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance23 = new Appearance();
    this.txtSearch = new MGATextBox();
    this.btnSearch = new MGAButton();
    this.btnClearSearch = new MGAButton();
    this.btnSubmit = new MGAButton();
    this.label3 = new Label();
    this.lnkAddContact = new LinkLabel();
    this.err = new ErrorProvider(this.components);
    this.lnkClearAllCarriersSelected = new LinkLabel();
    this.ds = new dsClearCarriers();
    this.ddEmailCC = new UltraDropDown();
    this.dgCarriersSelected = new UltraGrid();
    this.dgAvailableCarriers = new UltraGrid();
    this.btnCurrentCarrier = new MGAButton();
    ((ISupportInitialize) this.txtSearch).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.btnClearSearch).BeginInit();
    ((ISupportInitialize) this.btnSubmit).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddEmailCC).BeginInit();
    ((ISupportInitialize) this.dgCarriersSelected).BeginInit();
    ((ISupportInitialize) this.dgAvailableCarriers).BeginInit();
    ((ISupportInitialize) this.btnCurrentCarrier).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSearch).Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtSearch).BackColor = Color.White;
    ((Control) this.txtSearch).Location = new Point(342, 15);
    ((TextEditorControlBase) this.txtSearch).MaxLength = 60;
    this.txtSearch.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSearch).Name = "txtSearch";
    ((Control) this.txtSearch).Size = new Size(231, 19);
    ((Control) this.txtSearch).TabIndex = 30;
    ((UltraControlBase) this.txtSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSearch).UseOsThemes = (DefaultableBoolean) 2;
    this.txtSearch.WordWrap = false;
    ((Control) this.txtSearch).KeyDown += new KeyEventHandler(this.txtSearch_KeyDown);
    ((Control) this.btnSearch).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSearch).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSearch).Location = new Point(594, 8);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 35);
    ((Control) this.btnSearch).TabIndex = 206;
    ((UltraControlBase) this.btnSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSearch).Click += new EventHandler(this.btnSearch_Click);
    ((Control) this.btnClearSearch).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnClearSearch).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnClearSearch).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnClearSearch).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnClearSearch).Location = new Point(655, 8);
    ((Control) this.btnClearSearch).Name = "btnClearSearch";
    ((Control) this.btnClearSearch).Size = new Size(40, 35);
    ((Control) this.btnClearSearch).TabIndex = 205;
    ((UltraControlBase) this.btnClearSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnClearSearch).Click += new EventHandler(this.btnClearSearch_Click);
    ((Control) this.btnSubmit).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance4).ImageHAlign = (HAlign) 3;
    ((ControlBase) this.btnSubmit).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnSubmit).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnSubmit).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSubmit).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSubmit).Location = new Point(626, 454);
    ((Control) this.btnSubmit).Name = "btnSubmit";
    ((ControlBase) this.btnSubmit).Padding = new Size(5, 0);
    ((Control) this.btnSubmit).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.btnSubmit).TabIndex = 209;
    ((Control) this.btnSubmit).Text = "Submit";
    ((UltraControlBase) this.btnSubmit).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSubmit).Click += new EventHandler(this.btnSubmit_Click);
    this.label3.AutoSize = true;
    this.label3.Location = new Point(2, 15);
    this.label3.Name = "label3";
    this.label3.Size = new Size(313, 13);
    this.label3.TabIndex = 210;
    this.label3.Text = "Search by company name, group, contact name or email address";
    this.lnkAddContact.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lnkAddContact.Location = new Point(492, 240 /*0xF0*/);
    this.lnkAddContact.Name = "lnkAddContact";
    this.lnkAddContact.Size = new Size(246, 23);
    this.lnkAddContact.TabIndex = 212;
    this.lnkAddContact.TabStop = true;
    this.lnkAddContact.Text = "Add a contact to the selected company location";
    this.lnkAddContact.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkAddContact_LinkClicked);
    this.err.ContainerControl = (ContainerControl) this;
    this.lnkClearAllCarriersSelected.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkClearAllCarriersSelected.Location = new Point(465, 468);
    this.lnkClearAllCarriersSelected.Name = "lnkClearAllCarriersSelected";
    this.lnkClearAllCarriersSelected.Size = new Size(148, 23);
    this.lnkClearAllCarriersSelected.TabIndex = 214;
    this.lnkClearAllCarriersSelected.TabStop = true;
    this.lnkClearAllCarriersSelected.Text = "Clear All Carriers Selected";
    this.lnkClearAllCarriersSelected.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkClearAllCarriersSelected_LinkClicked);
    this.ds.DataSetName = "dsClearCarriers";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ddEmailCC).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddEmailCC).DataMember = "EmailCC";
    ((UltraGridBase) this.ddEmailCC).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 1;
    ultraGridColumn1.Width = 250;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 0;
    ultraGridColumn2.Width = 150;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.ddEmailCC).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraDropDownBase) this.ddEmailCC).DropDownWidth = 400;
    ((Control) this.ddEmailCC).Location = new Point(271, 260);
    ((Control) this.ddEmailCC).Name = "ddEmailCC";
    ((Control) this.ddEmailCC).Size = new Size(121, 93);
    ((Control) this.ddEmailCC).TabIndex = 213;
    ((Control) this.ddEmailCC).Text = "UltraDropDown2";
    ((Control) this.ddEmailCC).Visible = false;
    this.ddEmailCC.BeforeDropDown += new CancelEventHandler(this.ddEmailCC_BeforeDropDown);
    ((Control) this.dgCarriersSelected).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgCarriersSelected).DataMember = "CompanyAndContactSelected";
    ((UltraGridBase) this.dgCarriersSelected).DataSource = (object) this.ds;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 1;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 71;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 270;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Contact Name";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 2;
    ultraGridColumn6.Width = 99;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Group";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 4;
    ultraGridColumn7.Width = 89;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Company Location";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 3;
    ultraGridColumn8.Width = 194;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Email Address";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 7;
    ultraGridColumn9.Width = 118;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "CC To";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 8;
    ultraGridColumn10.Style = (ColumnStyle) 6;
    ultraGridColumn10.Width = 71;
    ((AppearanceBase) appearance6).FontData.UnderlineAsString = "True";
    ((AppearanceBase) appearance6).ForeColor = Color.Blue;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Center";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 9;
    ultraGridColumn11.Width = 48 /*0x30*/;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 5;
    ultraGridColumn12.Width = 69;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 6;
    ultraGridColumn13.Width = 37;
    ultraGridBand2.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13
    });
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance7).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance7).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance9).BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance13).BackColor = Color.Transparent;
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.Override.SelectTypeRow = (SelectType) 2;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgCarriersSelected).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.dgCarriersSelected).Font = new Font("Tahoma", 8.25f);
    ((Control) this.dgCarriersSelected).Location = new Point(8, 266);
    ((Control) this.dgCarriersSelected).Name = "dgCarriersSelected";
    ((Control) this.dgCarriersSelected).Size = new Size(727, 182);
    ((Control) this.dgCarriersSelected).TabIndex = 207;
    ((Control) this.dgCarriersSelected).Text = "Carriers Selected";
    ((UltraControlBase) this.dgCarriersSelected).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgCarriersSelected).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.dgAvailableCarriers).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgAvailableCarriers).DataMember = "CompanyAndContactInfo";
    ((UltraGridBase) this.dgAvailableCarriers).DataSource = (object) this.ds;
    ((AppearanceBase) appearance14).BackColor = Color.White;
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.Appearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 1;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 71;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 0;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 270;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Contact Name";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 2;
    ultraGridColumn16.Width = 90;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Group";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 4;
    ultraGridColumn17.Width = 114;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Company Location";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 3;
    ultraGridColumn18.Width = 216;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Email Address";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 7;
    ultraGridColumn19.Width = 125;
    ((AppearanceBase) appearance15).FontData.UnderlineAsString = "True";
    ((AppearanceBase) appearance15).ForeColor = Color.Blue;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Center";
    ultraGridColumn20.CellAppearance = (AppearanceBase) appearance15;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 8;
    ultraGridColumn20.Width = 46;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 5;
    ultraGridColumn21.Width = 88;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 6;
    ultraGridColumn22.Width = 46;
    ultraGridBand3.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22
    });
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance16).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance16).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance16).ForeColor = Color.Black;
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance17).ForeColor = Color.Black;
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance18).BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance22).BackColor = Color.Transparent;
    ((AppearanceBase) appearance22).ForeColor = Color.Black;
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance22;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgAvailableCarriers).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.dgAvailableCarriers).Font = new Font("Tahoma", 8.25f);
    ((Control) this.dgAvailableCarriers).Location = new Point(8, 49);
    ((Control) this.dgAvailableCarriers).Name = "dgAvailableCarriers";
    ((Control) this.dgAvailableCarriers).Size = new Size(727, 186);
    ((Control) this.dgAvailableCarriers).TabIndex = 28;
    ((Control) this.dgAvailableCarriers).Text = "Carriers And Contacts";
    ((UltraControlBase) this.dgAvailableCarriers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgAvailableCarriers).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCurrentCarrier).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance23).ImageHAlign = (HAlign) 3;
    ((ControlBase) this.btnCurrentCarrier).Appearance = (AppearanceBase) appearance23;
    ((Control) this.btnCurrentCarrier).Font = new Font("Tahoma", 8.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnCurrentCarrier).ImageSize = new Size(12, 12);
    ((ControlBase) this.btnCurrentCarrier).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCurrentCarrier).Location = new Point(8, 465);
    ((Control) this.btnCurrentCarrier).Name = "btnCurrentCarrier";
    ((ControlBase) this.btnCurrentCarrier).Padding = new Size(5, 0);
    ((Control) this.btnCurrentCarrier).Size = new Size(145, 26);
    ((Control) this.btnCurrentCarrier).TabIndex = 215;
    ((Control) this.btnCurrentCarrier).Text = "Include Current Carrier";
    ((UltraControlBase) this.btnCurrentCarrier).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCurrentCarrier).Click += new EventHandler(this.btnCurrentCarrier_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(742, 500);
    this.Controls.Add((Control) this.btnCurrentCarrier);
    this.Controls.Add((Control) this.lnkClearAllCarriersSelected);
    this.Controls.Add((Control) this.ddEmailCC);
    this.Controls.Add((Control) this.lnkAddContact);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.btnSubmit);
    this.Controls.Add((Control) this.dgCarriersSelected);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.btnClearSearch);
    this.Controls.Add((Control) this.txtSearch);
    this.Controls.Add((Control) this.dgAvailableCarriers);
    this.Name = nameof (frmClearCarriers);
    this.Text = "Clear Carriers";
    this.Load += new EventHandler(this.frmClearCarriers_Load);
    ((ISupportInitialize) this.txtSearch).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.btnClearSearch).EndInit();
    ((ISupportInitialize) this.btnSubmit).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddEmailCC).EndInit();
    ((ISupportInitialize) this.dgCarriersSelected).EndInit();
    ((ISupportInitialize) this.dgAvailableCarriers).EndInit();
    ((ISupportInitialize) this.btnCurrentCarrier).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
