// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formCloseAccountingPeriod
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

[SecureResource("{7BB4E1A8-F44D-49d6-913A-494A8C63FA46}", "Re-Open Prior Accounting Period Rights", "Users with these rights are given the ability to re-open prior closed accounting periods.", "Accounting")]
public class formCloseAccountingPeriod : AccountingNoteDocumentSupport
{
  private UltraExplorerBar ultraExplorerBar1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
  private MGAButton buttonSaveSettings;
  private MGAButton buttonCancel;
  private dsClosedAccountingPeriods dsClosedAccountingPeriods1;
  protected UltraGrid gridAccountingPeriods;
  protected SqlDataAdapter daGetAccountingLocks;
  private SqlCommand sqlSelectCommand1;
  private SqlConnection FormDataConnection;
  private System.ComponentModel.Container components;

  public formCloseAccountingPeriod()
  {
    this.InitializeComponent();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.LoadAccountingLocks();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("AccountingPeriods", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("GlCompanyId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Location", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ClosedBy", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ClosedOn", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CloseDate", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("NewCloseDate", 0);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("NewUWCloseDate", 1);
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formCloseAccountingPeriod));
    Appearance appearance15 = new Appearance();
    this.ultraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.gridAccountingPeriods = new UltraGrid();
    this.dsClosedAccountingPeriods1 = new dsClosedAccountingPeriods();
    this.ultraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.buttonCancel = new MGAButton();
    this.buttonSaveSettings = new MGAButton();
    this.ultraExplorerBar1 = new UltraExplorerBar();
    this.daGetAccountingLocks = new SqlDataAdapter();
    this.sqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    ((Control) this.ultraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.gridAccountingPeriods).BeginInit();
    this.dsClosedAccountingPeriods1.BeginInit();
    ((Control) this.ultraExplorerBarContainerControl2).SuspendLayout();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSaveSettings).BeginInit();
    ((ISupportInitialize) this.ultraExplorerBar1).BeginInit();
    ((Control) this.ultraExplorerBar1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.gridAccountingPeriods);
    ((Control) this.ultraExplorerBarContainerControl1).Location = new Point(18, 14);
    ((Control) this.ultraExplorerBarContainerControl1).Name = "ultraExplorerBarContainerControl1";
    ((Control) this.ultraExplorerBarContainerControl1).Size = new Size(1060, 208 /*0xD0*/);
    ((Control) this.ultraExplorerBarContainerControl1).TabIndex = 0;
    ((UltraGridBase) this.gridAccountingPeriods).DataSource = (object) this.dsClosedAccountingPeriods1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Office Location";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 285;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Closed By";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 173;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ultraGridColumn4.Format = "d";
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Closed On";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 182;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ultraGridColumn5.Format = "d";
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Close Date";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 185;
    ((AppearanceBase) appearance2).BackColor = Color.LightSteelBlue;
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn6.DataType = typeof (DateTime);
    ultraGridColumn6.Format = "d";
    ((AppearanceBase) appearance3).FontData.BoldAsString = "True";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "New Close Date";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Width = 115;
    ((AppearanceBase) appearance4).BackColor = Color.LightSteelBlue;
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn7.DataType = typeof (DateTime);
    ultraGridColumn7.Format = "d";
    ((AppearanceBase) appearance5).FontData.BoldAsString = "True";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "New UW Close Date";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Width = 118;
    ultraGridBand.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance6).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((Control) this.gridAccountingPeriods).Dock = DockStyle.Fill;
    ((Control) this.gridAccountingPeriods).Location = new Point(0, 0);
    ((Control) this.gridAccountingPeriods).Name = "gridAccountingPeriods";
    ((Control) this.gridAccountingPeriods).Size = new Size(1060, 208 /*0xD0*/);
    ((Control) this.gridAccountingPeriods).TabIndex = 0;
    this.gridAccountingPeriods.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridAccountingPeriods).UseOsThemes = (DefaultableBoolean) 2;
    this.gridAccountingPeriods.InitializeRow += new InitializeRowEventHandler(this.gridAccountingPeriods_InitializeRow);
    this.gridAccountingPeriods.BeforeRowUpdate += new CancelableRowEventHandler(this.gridAccountingPeriods_BeforeRowUpdate);
    this.dsClosedAccountingPeriods1.DataSetName = "dsClosedAccountingPeriods";
    this.dsClosedAccountingPeriods1.Locale = new CultureInfo("en-US");
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.buttonCancel);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.buttonSaveSettings);
    ((Control) this.ultraExplorerBarContainerControl2).Location = new Point(18, 253);
    ((Control) this.ultraExplorerBarContainerControl2).Name = "ultraExplorerBarContainerControl2";
    ((Control) this.ultraExplorerBarContainerControl2).Size = new Size(1060, 34);
    ((Control) this.ultraExplorerBarContainerControl2).TabIndex = 1;
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance10).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance10).BackColor2 = Color.White;
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance10;
    ((Control) this.buttonCancel).Location = new Point(919, 0);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(136, 32 /*0x20*/);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((Control) this.buttonSaveSettings).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance11).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance11).BackColor2 = Color.White;
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.buttonSaveSettings).Appearance = (AppearanceBase) appearance11;
    ((Control) this.buttonSaveSettings).Location = new Point(775, 0);
    ((Control) this.buttonSaveSettings).Name = "buttonSaveSettings";
    ((Control) this.buttonSaveSettings).Size = new Size(136, 32 /*0x20*/);
    ((Control) this.buttonSaveSettings).TabIndex = 0;
    ((Control) this.buttonSaveSettings).Text = "Save Accounting Periods";
    ((UltraControlBase) this.buttonSaveSettings).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSaveSettings).Click += new EventHandler(this.buttonSaveSettings_Click);
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).BackColor2 = Color.White;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.Appearance = (AppearanceBase) appearance12;
    this.ultraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.ultraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl1);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl2);
    ((Control) this.ultraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
    explorerBarGroup1.Settings.ContainerHeight = 210;
    explorerBarGroup1.Settings.HeaderVisible = (DefaultableBoolean) 2;
    ((UltraExplorerBarSettingsBase) explorerBarGroup1.Settings).MaxLines = 100;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "Payee Information";
    explorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
    explorerBarGroup2.Settings.ContainerHeight = 36;
    explorerBarGroup2.Settings.HeaderVisible = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "Expense Schedule";
    this.ultraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[2]
    {
      explorerBarGroup1,
      explorerBarGroup2
    });
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance13).BackColor2 = Color.FromArgb(239, 247, 253);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance14).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance14).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance14).BorderColor = Color.White;
    ((AppearanceBase) appearance14).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance14).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance14).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance14).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance14).ImageBackground = (Image) componentResourceManager.GetObject("appearance14.ImageBackground");
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance15;
    this.ultraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.ultraExplorerBar1.GroupSpacing = 10;
    ((Control) this.ultraExplorerBar1).Location = new Point(0, 0);
    this.ultraExplorerBar1.Margins.Bottom = 4;
    this.ultraExplorerBar1.Margins.Left = 4;
    this.ultraExplorerBar1.Margins.Right = 4;
    this.ultraExplorerBar1.Margins.Top = 4;
    ((Control) this.ultraExplorerBar1).Name = "ultraExplorerBar1";
    this.ultraExplorerBar1.NavigationAllowGroupReorder = false;
    this.ultraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.ultraExplorerBar1).Size = new Size(1089, 304);
    ((Control) this.ultraExplorerBar1).TabIndex = 0;
    this.ultraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.daGetAccountingLocks.SelectCommand = this.sqlSelectCommand1;
    this.daGetAccountingLocks.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetAccountingLocks", new DataColumnMapping[5]
      {
        new DataColumnMapping("GlCompanyId", "GlCompanyId"),
        new DataColumnMapping("Location", "Location"),
        new DataColumnMapping("ClosedBy", "ClosedBy"),
        new DataColumnMapping("ClosedOn", "ClosedOn"),
        new DataColumnMapping("ClosedDate", "ClosedDate")
      })
    });
    this.sqlSelectCommand1.CommandText = "[spFin_GetAccountingLocks]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.FormDataConnection;
    this.sqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(1089, 304);
    this.Controls.Add((Control) this.ultraExplorerBar1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (formCloseAccountingPeriod);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Accounting Periods";
    ((Control) this.ultraExplorerBarContainerControl1).ResumeLayout(false);
    ((ISupportInitialize) this.gridAccountingPeriods).EndInit();
    this.dsClosedAccountingPeriods1.EndInit();
    ((Control) this.ultraExplorerBarContainerControl2).ResumeLayout(false);
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSaveSettings).EndInit();
    ((ISupportInitialize) this.ultraExplorerBar1).EndInit();
    ((Control) this.ultraExplorerBar1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void gridAccountingPeriods_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (!e.Row.Cells["ClosedBy"].Value.Equals((object) DBNull.Value) && ((AppearanceBase) e.Row.Appearance).FontData.Bold != 1 || e.Row.Cells["NewCloseDate"].Value == null)
      return;
    e.Row.Cells["ClosedBy"].Value = (object) CurrentUser.Instance.UserName;
    e.Row.Cells["ClosedOn"].Value = (object) DateTime.Now;
    e.Row.Cells["CloseDate"].Value = e.Row.Cells["NewCloseDate"].Value;
    ((AppearanceBase) e.Row.CellAppearance).FontData.Bold = (DefaultableBoolean) 1;
  }

  private void buttonSaveSettings_Click(object sender, EventArgs e)
  {
    if (!this.SaveLockSettings())
      return;
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void gridAccountingPeriods_InitializeRow(object sender, InitializeRowEventArgs e)
  {
  }

  private void gridAccountingPeriods_CellChange(object sender, CellEventArgs e)
  {
    this.gridAccountingPeriods.CellChange -= new CellEventHandler(this.gridAccountingPeriods_CellChange);
    foreach (UltraGridRow row in ((UltraGridBase) this.gridAccountingPeriods).Rows)
    {
      string text = row.Cells["newclosedate"].Text;
      DateTime result;
      if (text.Length > 0 && e.Cell == row.Cells["newclosedate"] && DateTime.TryParse(text, out result) && result > DateTime.Now && MessageBox.Show("You have selected the Accounting Period Close Date to be a future date. Press OK to continue or cancel to undo changes", "Accounting Period Close Date", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
        row.Cells["newclosedate"].CancelUpdate();
    }
    this.gridAccountingPeriods.CellChange += new CellEventHandler(this.gridAccountingPeriods_CellChange);
  }

  public virtual void LoadAccountingLocks()
  {
    this.daGetAccountingLocks.Fill((DataTable) this.dsClosedAccountingPeriods1.AccountingPeriods);
    this.FormatGrid();
  }

  protected void FormatGrid()
  {
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Bands[0].Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Bands[0].Override.RowFilterMode = (RowFilterMode) 1;
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Bands[0].Columns["uwclosedate"].Width = 185;
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Bands[0].Columns["uwclosedate"].Format = "d";
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Bands[0].Columns["uwclosedate"].CellActivation = (Activation) 3;
    ((HeaderBase) ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Bands[0].Columns["uwclosedate"].Header).Caption = "UW Close Date";
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Bands[0].Columns["newclosedate"].Width = 175;
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Bands[0].Columns["newclosedate"].Format = "d";
    ((HeaderBase) ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Bands[0].Columns["newclosedate"].Header).Caption = "New Acct Close Date";
    ((HeaderBase) ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Bands[0].Columns["CloseDate"].Header).Caption = "Acct Close Date";
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Bands[0].Columns["CloseDate"].Format = "d";
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Bands[0].Columns["newuwclosedate"].Width = 175;
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Bands[0].Columns["newuwclosedate"].Format = "d";
    this.gridAccountingPeriods.CellChange += new CellEventHandler(this.gridAccountingPeriods_CellChange);
    ((UltraGridBase) this.gridAccountingPeriods).DisplayLayout.Bands[0].Override.HeaderClickAction = (HeaderClickAction) 2;
  }

  protected virtual bool SaveLockSettings()
  {
    bool flag = false;
    using (SqlCommand sqlCommand = new SqlCommand("spFin_InsertAccountingLock", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Connection.Open();
      sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
      try
      {
        foreach (UltraGridRow row in ((UltraGridBase) this.gridAccountingPeriods).Rows)
        {
          if (row.Cells["newclosedate"].Value != null && !row.Cells["newclosedate"].Value.Equals((object) DBNull.Value))
          {
            if (Convert.ToDateTime(row.Cells["newclosedate"].Value.ToString()) < Convert.ToDateTime(row.Cells["closedate"].Value.ToString()) && !SecurityManager.Instance.AssertPermission("{7BB4E1A8-F44D-49d6-913A-494A8C63FA46}"))
            {
              flag = true;
            }
            else
            {
              sqlCommand.Parameters.Clear();
              sqlCommand.Parameters.AddWithValue("@closeDate", (object) Convert.ToDateTime(row.Cells["newclosedate"].Value.ToString()));
              sqlCommand.Parameters.AddWithValue("@glcompanyid", (object) int.Parse(row.Cells["glcompanyid"].Value.ToString()));
              sqlCommand.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
              if (row.Cells["newuwclosedate"].Value != DBNull.Value && row.Cells["newuwclosedate"].Value != null)
                sqlCommand.Parameters.AddWithValue("@uwcloseDate", (object) Convert.ToDateTime(row.Cells["newuwclosedate"].Value.ToString()));
              sqlCommand.ExecuteNonQuery();
              StringBuilder stringBuilder = new StringBuilder();
              stringBuilder.Append("Accounting period changed. ");
              stringBuilder.Append(row.Cells["location"].Value.ToString());
              if (row.Cells["closedate"].Value != DBNull.Value && row.Cells["closedate"].Value != null)
              {
                stringBuilder.Append(" Setting Accounting Close Date from ");
                stringBuilder.Append(row.Cells["closedate"].Value.ToString());
                stringBuilder.Append(" to ");
                stringBuilder.Append(row.Cells["newclosedate"].Value.ToString());
                stringBuilder.Append(".");
              }
              else
              {
                stringBuilder.Append(" Setting Accounting Close Date to ");
                stringBuilder.Append(row.Cells["newclosedate"].Value.ToString());
                stringBuilder.Append(".");
              }
              if (row.Cells["newuwclosedate"].Value != DBNull.Value && row.Cells["newuwclosedate"].Value != null)
              {
                stringBuilder.Append(" Setting UW Close Date:");
                stringBuilder.Append(row.Cells["uwcloseDate"].Value.ToString());
                stringBuilder.Append(".");
              }
              CurrentUser.Instance.LogAction(stringBuilder.ToString(), "Accounting Logs");
            }
          }
          else if (row.Cells["newuwclosedate"].Value != null && !row.Cells["newuwclosedate"].Value.Equals((object) DBNull.Value))
          {
            int num = (int) MessageBox.Show("You must specify an accounting period close date.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            sqlCommand.Transaction.Rollback();
            return false;
          }
        }
        if (flag)
        {
          int num = (int) MessageBox.Show("One or more of the closing periods you were trying to set were before the previous closing period. You user account does not have permission to complete this operation. These closing periods were not saved.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          sqlCommand.Transaction.Rollback();
          return false;
        }
        sqlCommand.Transaction.Commit();
        return true;
      }
      catch (SqlException ex)
      {
        if (sqlCommand.Transaction != null)
          sqlCommand.Transaction.Rollback();
        int num = (int) MessageBox.Show("An error has occurred while trying to save the specified closed accounting periods. " + ex.Errors[0].Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return false;
      }
    }
  }
}
