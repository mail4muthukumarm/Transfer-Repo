// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Lines_Risk_Description.FormRiskDescriptionByLines
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace MGASystems.IMS.Underwriting.Lines_Risk_Description;

public class FormRiskDescriptionByLines : Form
{
  private Guid _quoteGuid;
  private BindingManagerBase _bmb;
  private IContainer components;
  private UltraGrid ug;
  private MGASystems.Tools.DBSaveUI.DBSaveUI dbSave;
  private MGATextBox txtRiskDescription;
  private MGAComboBox cboLines;
  private Label lblLimit;
  private Label label1;
  private dsDetailsLineDesc ds;
  protected SqlConnection cnSql;
  internal ErrorProvider err;
  private SqlDataAdapter da;
  private SqlCommand sqlCommand1;
  private SqlCommand sqlCommand2;
  private SqlCommand sqlCommand3;
  private SqlCommand sqlCommand4;
  private UltraDropDown ddLines;

  public FormRiskDescriptionByLines(Guid quoteGuid)
  {
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
  }

  private void FormRiskDescriptionByLines_Load(object sender, EventArgs e)
  {
    this.cnSql.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._bmb = this.BindingContext[(object) this.ds, this.ds.tblQuoteDetailsLinesDescription.TableName];
    string[] strArray = new string[2]
    {
      "tblQuoteDetailsLinesDescription",
      "lstLines"
    };
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, strArray, "dbo.spGetQuoteDetailsLineDesc", new object[2]
      {
        (object) "@quoteGuid",
        (object) this._quoteGuid
      });
    }
    catch (ConstraintException ex)
    {
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
    }
    this.SetChangeState();
    this.EnableControls(false);
    this._bmb.Position = this.ds.tblQuoteDetailsLinesDescription.Count - 1;
  }

  private void SetChangeState()
  {
    if (this.ds.tblQuoteDetailsLinesDescription.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void EnableControls(bool enable)
  {
    foreach (Control control in (ArrangedElementCollection) this.Controls)
    {
      if (control is MGAComboBox mgaComboBox)
        ((Control) mgaComboBox).Enabled = enable;
      if (control is MGATextBox mgaTextBox)
        ((Control) mgaTextBox).Enabled = enable;
      if (control is UltraGrid ultraGrid)
        ((Control) ultraGrid).Enabled = !enable;
    }
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.tblQuoteDetailsLinesDescription.RejectChanges();
    this.SetChangeState();
    this.EnableControls(false);
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e) => this.EnableControls(true);

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    this.EnableControls(true);
    dsDetailsLineDesc.tblQuoteDetailsLinesDescriptionRow row = this.ds.tblQuoteDetailsLinesDescription.NewtblQuoteDetailsLinesDescriptionRow();
    row.QuoteGuid = this._quoteGuid;
    this.ds.tblQuoteDetailsLinesDescription.AddtblQuoteDetailsLinesDescriptionRow(row);
    this._bmb.Position = this.ds.tblQuoteDetailsLinesDescription.Count - 1;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this._bmb.Position == -1)
      e.Cancel = true;
    else if (!this.ValidData())
    {
      e.Cancel = true;
    }
    else
    {
      this._bmb.EndCurrentEdit();
      this.da.Update((DataTable) this.ds.tblQuoteDetailsLinesDescription);
      this.EnableControls(false);
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this._bmb.Position == -1)
    {
      int num = (int) MessageBox.Show("Please select a row in the grid to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else if (MessageBox.Show("Continue with deletion of the current row?", "Continue Delete", MessageBoxButtons.YesNo) == DialogResult.No)
    {
      e.Cancel = true;
      this.EnableControls(false);
    }
    else
    {
      this.ds.tblQuoteDetailsLinesDescription[this._bmb.Position].Delete();
      this.da.Update((DataTable) this.ds.tblQuoteDetailsLinesDescription);
      this.EnableControls(false);
      this.SetChangeState();
    }
  }

  private bool ValidData()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboLines, string.Empty);
    this.err.SetError((Control) this.txtRiskDescription, string.Empty);
    if (this.cboLines.Value == null && this.cboLines.Value != DBNull.Value)
    {
      flag = false;
      this.err.SetError((Control) this.cboLines, "Please select a value");
    }
    if (((Control) this.txtRiskDescription).Text.Replace(" ", string.Empty).Length == 0)
    {
      flag = false;
      this.err.SetError((Control) this.txtRiskDescription, "Please enter line description.");
    }
    return flag;
  }

  private void ug_AfterRowActivate(object sender, EventArgs e)
  {
    if (this._bmb.Position < 0 || ((UltraGridBase) this.ug).ActiveRow == null)
      return;
    Database.MoveTo((object) (int) ((UltraGridBase) this.ug).ActiveRow.Cells["LineDescID"].Value, this.ds.tblQuoteDetailsLinesDescription.LineDescIDColumn.ColumnName, (DataTable) this.ds.tblQuoteDetailsLinesDescription, this._bmb);
  }

  private void cboLines_BeforeDropDown(object sender, CancelEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.cboLines).Rows)
    {
      row.Hidden = false;
      if (row.Cells["LineGUID"].Value != DBNull.Value && row.Cells["LineGUID"].Value != null && this.ds.tblQuoteDetailsLinesDescription.Select($"LineGuid='{((Guid) row.Cells["LineGUID"].Value).ToString()}'").Length != 0)
        row.Hidden = true;
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineName");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormRiskDescriptionByLines));
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblQuoteDetailsLinesDescription", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LineDescID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LineGuid", -1, (object) "ddLines");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("QuoteGuid");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("LineName");
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.txtRiskDescription = new MGATextBox();
    this.ds = new dsDetailsLineDesc();
    this.cboLines = new MGAComboBox();
    this.lblLimit = new Label();
    this.label1 = new Label();
    this.cnSql = new SqlConnection();
    this.err = new ErrorProvider(this.components);
    this.da = new SqlDataAdapter();
    this.sqlCommand1 = new SqlCommand();
    this.sqlCommand2 = new SqlCommand();
    this.sqlCommand3 = new SqlCommand();
    this.sqlCommand4 = new SqlCommand();
    this.ug = new UltraGrid();
    this.ddLines = new UltraDropDown();
    ((ISupportInitialize) this.txtRiskDescription).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboLines).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ug).BeginInit();
    ((ISupportInitialize) this.ddLines).BeginInit();
    this.SuspendLayout();
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(552, 436);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 2;
    this.dbSave.ClickingNew += new CancelEventHandler(this.dbSave_ClickingNew);
    this.dbSave.ClickingEdit += new CancelEventHandler(this.dbSave_ClickingEdit);
    this.dbSave.ClickingSave += new CancelEventHandler(this.dbSave_ClickingSave);
    this.dbSave.ClickingDelete += new CancelEventHandler(this.dbSave_ClickingDelete);
    this.dbSave.ClickedCancel += new EventHandler(this.dbSave_ClickedCancel);
    this.txtRiskDescription.AcceptsTab = true;
    ((Control) this.txtRiskDescription).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtRiskDescription).Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtRiskDescription).BackColor = Color.White;
    ((Control) this.txtRiskDescription).DataBindings.Add(new Binding("Text", (object) this.ds, "tblQuoteDetailsLinesDescription.Description", true));
    ((Control) this.txtRiskDescription).Location = new Point(12, 290);
    ((TextEditorControlBase) this.txtRiskDescription).MaxLength = 8000;
    this.txtRiskDescription.MGAStyle = MGAStyles.Blue;
    this.txtRiskDescription.Multiline = true;
    ((Control) this.txtRiskDescription).Name = "txtRiskDescription";
    ((Control) this.txtRiskDescription).Size = new Size(652, 140);
    ((Control) this.txtRiskDescription).TabIndex = 1;
    ((Control) this.txtRiskDescription).Tag = (object) "";
    ((UltraControlBase) this.txtRiskDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRiskDescription).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsDetailsLineDesc";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.cboLines).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.cboLines.BorderStyle = (UIElementBorderStyle) 4;
    this.cboLines.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboLines).DataBindings.Add(new Binding("Value", (object) this.ds, "tblQuoteDetailsLinesDescription.LineGuid", true));
    ((UltraGridBase) this.cboLines).DataMember = "lstLines";
    ((UltraGridBase) this.cboLines).DataSource = (object) this.ds;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb(78, 122, 171);
    this.cboLines.DisplayLayout.Appearance = (AppearanceBase) appearance2;
    this.cboLines.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 238;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 93;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.cboLines.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboLines.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboLines.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboLines.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BorderColor = Color.White;
    this.cboLines.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance4;
    this.cboLines.DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    this.cboLines.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance5;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboLines.DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraDropDownBase) this.cboLines).DisplayMember = "LineName";
    this.cboLines.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLines).DropDownWidth = 350;
    ((Control) this.cboLines).Location = new Point(12, 242);
    this.cboLines.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLines).Name = "cboLines";
    ((Control) this.cboLines).Size = new Size(274, 20);
    ((Control) this.cboLines).TabIndex = 0;
    ((UltraControlBase) this.cboLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLines).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLines).ValueMember = "LineGUID";
    this.cboLines.BeforeDropDown += new CancelEventHandler(this.cboLines_BeforeDropDown);
    this.lblLimit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblLimit.BackColor = Color.Transparent;
    this.lblLimit.Location = new Point(9, 265);
    this.lblLimit.Name = "lblLimit";
    this.lblLimit.Size = new Size(110, 22);
    this.lblLimit.TabIndex = 232;
    this.lblLimit.Text = "Line Description:";
    this.lblLimit.TextAlign = ContentAlignment.MiddleLeft;
    this.label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(9, 218);
    this.label1.Name = "label1";
    this.label1.Size = new Size(47, 22);
    this.label1.TabIndex = 233;
    this.label1.Text = "Lines:";
    this.label1.TextAlign = ContentAlignment.MiddleLeft;
    this.cnSql.ConnectionString = "Data Source=MGASYSTEMS;Initial Catalog=IMS;Integrated Security=True";
    this.cnSql.FireInfoMessageEventOnUserErrors = false;
    this.err.ContainerControl = (ContainerControl) this;
    this.da.DeleteCommand = this.sqlCommand1;
    this.da.InsertCommand = this.sqlCommand2;
    this.da.SelectCommand = this.sqlCommand3;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteDetailsLinesDescription", new DataColumnMapping[4]
      {
        new DataColumnMapping("LineDescID", "LineDescID"),
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("QuoteGuid", "QuoteGuid")
      })
    });
    this.da.UpdateCommand = this.sqlCommand4;
    this.sqlCommand1.CommandText = "DELETE FROM [dbo].[tblQuoteDetailsLinesDescription] WHERE (([LineDescID] = @Original_LineDescID))";
    this.sqlCommand1.Connection = this.cnSql;
    this.sqlCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_LineDescID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineDescID", DataRowVersion.Original, (object) null)
    });
    this.sqlCommand2.CommandText = componentResourceManager.GetString("sqlCommand2.CommandText");
    this.sqlCommand2.Connection = this.cnSql;
    this.sqlCommand2.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 0, "LineGuid"),
      new SqlParameter("@Description", SqlDbType.VarChar, 0, "Description"),
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 0, "QuoteGuid")
    });
    this.sqlCommand3.CommandText = "SELECT     LineDescID, LineGuid, Description, QuoteGuid\r\nFROM         dbo.tblQuoteDetailsLinesDescription\r\nWHERE     (QuoteGuid = @quoteGuid)";
    this.sqlCommand3.Connection = this.cnSql;
    this.sqlCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@quoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid")
    });
    this.sqlCommand4.CommandText = componentResourceManager.GetString("sqlCommand4.CommandText");
    this.sqlCommand4.Connection = this.cnSql;
    this.sqlCommand4.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 0, "LineGuid"),
      new SqlParameter("@Description", SqlDbType.VarChar, 0, "Description"),
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 0, "QuoteGuid"),
      new SqlParameter("@Original_LineDescID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "LineDescID", DataRowVersion.Original, (object) null),
      new SqlParameter("@LineDescID", SqlDbType.Int, 4, "LineDescID")
    });
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.ug).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ug).DataMember = "tblQuoteDetailsLinesDescription";
    ((UltraGridBase) this.ug).DataSource = (object) this.ds;
    ((UltraGridBase) this.ug).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand2.AddButtonCaption = "Exposures";
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 1;
    ultraGridColumn4.Style = (ColumnStyle) 6;
    ultraGridColumn4.Width = 180;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 2;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 3;
    ultraGridColumn6.Hidden = true;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance7).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance7).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((AppearanceBase) appearance9).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance13).BackColor = Color.Transparent;
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance14).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.ug).Location = new Point(12, 9);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(652, 203);
    ((Control) this.ug).TabIndex = 220;
    ((Control) this.ug).Text = "Available Risk Description by Lines";
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ug.AfterRowActivate += new EventHandler(this.ug_AfterRowActivate);
    ((UltraGridBase) this.ddLines).DataMember = "lstLines";
    ((UltraGridBase) this.ddLines).DataSource = (object) this.ds;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 0;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 1;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.ddLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddLines).DisplayMember = "LineName";
    ((UltraDropDownBase) this.ddLines).DropDownWidth = 250;
    ((Control) this.ddLines).Location = new Point(391, 218);
    ((Control) this.ddLines).Name = "ddLines";
    ((Control) this.ddLines).Size = new Size(174, 47);
    ((Control) this.ddLines).TabIndex = 243;
    ((UltraDropDownBase) this.ddLines).ValueMember = "LineGUID";
    ((Control) this.ddLines).Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(676, 488);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.lblLimit);
    this.Controls.Add((Control) this.cboLines);
    this.Controls.Add((Control) this.txtRiskDescription);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.ug);
    this.Controls.Add((Control) this.ddLines);
    this.Name = nameof (FormRiskDescriptionByLines);
    this.Text = "Risk Description By Lines";
    this.Load += new EventHandler(this.FormRiskDescriptionByLines_Load);
    ((ISupportInitialize) this.txtRiskDescription).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboLines).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ug).EndInit();
    ((ISupportInitialize) this.ddLines).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
