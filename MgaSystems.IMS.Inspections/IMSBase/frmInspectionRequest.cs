// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.IMSBase.frmInspectionRequest
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Web.Services.Protocols;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.IMSBase;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmInspectionRequest : Form
{
  private IContainer components;
  private SqlDataAdapter da;
  private SqlCommand SqlSelectCommand1;
  private SqlConnection cn;
  private Guid _quoteGuid;
  private Guid _lineGuid;
  private string _storedProc;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("UltraGrid1")]
  protected virtual UltraGrid UltraGrid1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsInspectionRequest ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnRequestInspection
  {
    get => this._btnRequestInspection;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRequestInspection_Click);
      MGAButton requestInspection1 = this._btnRequestInspection;
      if (requestInspection1 != null)
        ((Control) requestInspection1).Click -= eventHandler;
      this._btnRequestInspection = value;
      MGAButton requestInspection2 = this._btnRequestInspection;
      if (requestInspection2 == null)
        return;
      ((Control) requestInspection2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("RequestInspections", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("InspectionCompany");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Roof");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("InspectionCompanyID");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    this.UltraGrid1 = new UltraGrid();
    this.ds = new dsInspectionRequest();
    this.btnRequestInspection = new MGAButton();
    this.da = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnRequestInspection).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraGrid1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.UltraGrid1).Cursor = Cursors.Hand;
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds.RequestInspections;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 256 /*0x0100*/;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 109;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Inspection Company";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 195;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ultraGridColumn5.Header.VisiblePosition = 3;
    ultraGridColumn5.Width = 48 /*0x30*/;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridBand.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellClickAction = (CellClickAction) 3;
    appearance4.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance5.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance7.BackColor = Color.Transparent;
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.WhiteSmoke;
    appearance8.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.UltraGrid1).Location = new Point(8, 8);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(592, 128 /*0x80*/);
    ((Control) this.UltraGrid1).TabIndex = 0;
    this.ds.DataSetName = "dsInspectionRequest";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnRequestInspection).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance10.BackColor = Color.FromArgb(229, 229, 229);
    appearance10.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance10.BackGradientStyle = (GradientStyle) 2;
    appearance10.BorderColor = Color.Gray;
    ((ControlBase) this.btnRequestInspection).Appearance = (AppearanceBase) appearance10;
    ((Control) this.btnRequestInspection).Location = new Point(480, 144 /*0x90*/);
    ((Control) this.btnRequestInspection).Name = "btnRequestInspection";
    ((Control) this.btnRequestInspection).Size = new Size(120, 24);
    ((Control) this.btnRequestInspection).TabIndex = 1;
    ((ControlBase) this.btnRequestInspection).Text = "Request Inspections";
    this.btnRequestInspection.UseOSThemes = (DefaultableBoolean) 2;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "ShowInspectionLocations", new DataColumnMapping[3]
      {
        new DataColumnMapping("InspectionCompany", "InspectionCompany"),
        new DataColumnMapping("Location", "Location"),
        new DataColumnMapping("QuoteGuid", "QuoteGuid")
      })
    });
    this.SqlSelectCommand1.CommandText = "[ShowInspectionLocations]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@quoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/)
    });
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(608, 174);
    this.Controls.Add((Control) this.btnRequestInspection);
    this.Controls.Add((Control) this.UltraGrid1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmInspectionRequest);
    this.Text = "Request Inspections";
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnRequestInspection).EndInit();
    this.ResumeLayout(false);
  }

  public string LocationsStoredProcedure
  {
    get
    {
      if (this._storedProc.Equals(string.Empty))
        this._storedProc = this.GetInspectionLocationsSql();
      return this._storedProc;
    }
  }

  public frmInspectionRequest(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.frmInspectionRequest_Load);
    this._storedProc = string.Empty;
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
  }

  public frmInspectionRequest(Guid quoteGuid, Guid lineGuid)
  {
    this.Load += new EventHandler(this.frmInspectionRequest_Load);
    this._storedProc = string.Empty;
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._lineGuid = lineGuid;
  }

  protected virtual string GetInspectionLocationsSql() => "dbo.ShowInspectionLocations";

  private void frmInspectionRequest_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    frmInspectionRequest.LoadBaseLocations(this.LocationsStoredProcedure, this.ds, this._quoteGuid);
    ((Control) this.btnRequestInspection).Enabled = this.ds.RequestInspections.Count > 0;
    this.AfterFormLoad();
  }

  public static void LoadBaseLocations(
    string locationStoredProc,
    dsInspectionRequest tmpds,
    Guid tmpQuoteGuid)
  {
    DefaultDatabase.LoadDataSet((DataSet) tmpds, new string[1]
    {
      "RequestInspections"
    }, locationStoredProc, new object[2]
    {
      (object) "@quoteGuid",
      (object) tmpQuoteGuid
    });
  }

  public static void LoadBaseLocations(
    dsInspectionRequest tmpds,
    Guid tmpQuoteGuid,
    int locationID)
  {
    DefaultDatabase.LoadDataSet((DataSet) tmpds, new string[1]
    {
      "RequestInspections"
    }, "ShowSingleInspectionLocation", new object[4]
    {
      (object) "@quoteGuid",
      (object) tmpQuoteGuid,
      (object) "@LocationID",
      (object) locationID
    });
  }

  protected virtual bool IsValidForm() => true;

  protected virtual void SaveData()
  {
  }

  private void btnRequestInspection_Click(object sender, EventArgs e)
  {
    if (!this.IsValidForm())
      return;
    Cursor.Current = Cursors.WaitCursor;
    ((Control) this.btnRequestInspection).Enabled = false;
    InspectionRequest objectEx = (InspectionRequest) ObjectFactory.Instance.CreateObjectEX(typeof (InspectionRequest), (object) this._quoteGuid);
    try
    {
      objectEx.LineGuid = this._lineGuid;
      objectEx.BaseInspectionGrid = this.UltraGrid1;
      InspectionRequest.BlackBoxMode = false;
      objectEx.InspectionMethod = (object) this.SetInspectionMethod();
      this.UpdateDueDates();
      this.SaveData();
      objectEx.Send();
      this.Close();
    }
    catch (SoapException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("The inspection that you are trying to request failed.", "Inspection Request Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
      ((Control) this.btnRequestInspection).Enabled = true;
    }
  }

  private void UpdateDueDates()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.UltraGrid1).Rows)
    {
      if (row.Cells["DueDate"].Value != null && row.Cells["DueDate"].Value != DBNull.Value)
        DefaultDatabase.ExecuteNonQuery("UpdateInspectionLocationDueDates", new object[4]
        {
          (object) "@DueDate",
          (object) Conversions.ToDate(row.Cells["DueDate"].Value),
          (object) "@LocationID",
          (object) Conversions.ToInteger(row.Cells["LocationID"].Value)
        });
    }
  }

  protected virtual void AfterFormLoad()
  {
  }

  protected virtual byte SetInspectionMethod() => 1;
}
