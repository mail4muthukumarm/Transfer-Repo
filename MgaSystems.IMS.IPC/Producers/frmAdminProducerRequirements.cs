// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Producers.frmAdminProducerRequirements
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Producers;

public sealed class frmAdminProducerRequirements : Form
{
  private IContainer components;
  private dsAdminProducerRequirements ds;

  public frmAdminProducerRequirements()
  {
    this.Load += new EventHandler(this.frmAdminProducerRequirements_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid UltraGrid1
  {
    get => this._UltraGrid1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UltraGrid1_AfterRowActivate);
      UltraGrid ultraGrid1_1 = this._UltraGrid1;
      if (ultraGrid1_1 != null)
        ultraGrid1_1.AfterRowActivate -= eventHandler;
      this._UltraGrid1 = value;
      UltraGrid ultraGrid1_2 = this._UltraGrid1;
      if (ultraGrid1_2 == null)
        return;
      ultraGrid1_2.AfterRowActivate += eventHandler;
    }
  }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.ClickingEdit -= cancelEventHandler2;
        dbSave1.ClickingNew -= cancelEventHandler3;
        dbSave1.ClickingSave -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler2;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.ClickingEdit += cancelEventHandler2;
      dbSave2.ClickingNew += cancelEventHandler3;
      dbSave2.ClickingSave += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("txtDescription")]
  protected virtual MGATextBox txtDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnReq")]
  private virtual Panel pnReq { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAutomationCode")]
  protected virtual MGATextBox txtAutomationCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("lstProducerRequirements", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ProducerRequirementListID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("AutomationCode");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("SystemDefined");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    this.UltraGrid1 = new UltraGrid();
    this.ds = new dsAdminProducerRequirements();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.txtDescription = new MGATextBox();
    this.pnReq = new Panel();
    this.Label1 = new Label();
    this.Label5 = new Label();
    this.txtAutomationCode = new MGATextBox();
    this.err = new ErrorProvider(this.components);
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    this.pnReq.SuspendLayout();
    ((ISupportInitialize) this.txtAutomationCode).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds.lstProducerRequirements;
    appearance1.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.WhiteSmoke;
    appearance2.BorderColor = Color.WhiteSmoke;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ultraGridBand.AddButtonCaption = "New Requirement";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 206;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Requirement Name";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 386;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 228;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = SystemColors.ActiveBorder;
    appearance4.BackColor2 = SystemColors.ControlDark;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance4;
    appearance5.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance5;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance6.BackColor = SystemColors.ControlLightLight;
    appearance6.BackColor2 = SystemColors.Control;
    appearance6.BackGradientStyle = (GradientStyle) 3;
    appearance6.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.MaxRowScrollRegions = 1;
    appearance7.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance9.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance10.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.WhiteSmoke;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectorAppearance = (AppearanceBase) appearance11;
    ((Control) this.UltraGrid1).Location = new Point(12, 12);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(510, 329);
    ((Control) this.UltraGrid1).TabIndex = 0;
    ((UltraControlBase) this.UltraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAdminProducerRequirements";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(410, 417);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 1;
    ((Control) this.txtDescription).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescription).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.txtDescription).BackColor = Color.White;
    ((Control) this.txtDescription).DataBindings.Add(new Binding("Text", (object) this.ds, "lstProducerRequirements.Description", true));
    ((Control) this.txtDescription).Location = new Point(106, 11);
    ((Control) this.txtDescription).MaximumSize = new Size(400, 21);
    ((TextEditorControlBase) this.txtDescription).MaxLength = 50;
    this.txtDescription.MGAStyle = MGAStyles.Blue;
    this.txtDescription.Multiline = true;
    ((Control) this.txtDescription).Name = "txtDescription";
    ((Control) this.txtDescription).Size = new Size(257, 21);
    ((Control) this.txtDescription).TabIndex = 2;
    ((UltraControlBase) this.txtDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescription).UseOsThemes = (DefaultableBoolean) 2;
    this.pnReq.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.pnReq.BackColor = Color.Transparent;
    this.pnReq.BorderStyle = BorderStyle.Fixed3D;
    this.pnReq.Controls.Add((Control) this.Label1);
    this.pnReq.Controls.Add((Control) this.Label5);
    this.pnReq.Controls.Add((Control) this.txtAutomationCode);
    this.pnReq.Controls.Add((Control) this.txtDescription);
    this.pnReq.Location = new Point(12, 356);
    this.pnReq.Name = "pnReq";
    this.pnReq.Size = new Size(380, 101);
    this.pnReq.TabIndex = 213;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(9, 59);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(91, 13);
    this.Label1.TabIndex = 29;
    this.Label1.Text = "Automation Code:";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(37, 15);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(63 /*0x3F*/, 13);
    this.Label5.TabIndex = 28;
    this.Label5.Text = "Description:";
    ((Control) this.txtAutomationCode).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAutomationCode).Appearance = (AppearanceBase) appearance13;
    ((TextEditorControlBase) this.txtAutomationCode).BackColor = Color.White;
    ((Control) this.txtAutomationCode).DataBindings.Add(new Binding("Text", (object) this.ds, "lstProducerRequirements.AutomationCode", true));
    ((Control) this.txtAutomationCode).Location = new Point(106, 56);
    ((Control) this.txtAutomationCode).MaximumSize = new Size(400, 21);
    ((TextEditorControlBase) this.txtAutomationCode).MaxLength = 5;
    this.txtAutomationCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAutomationCode).Name = "txtAutomationCode";
    ((Control) this.txtAutomationCode).Size = new Size(85, 19);
    ((Control) this.txtAutomationCode).TabIndex = 2;
    ((UltraControlBase) this.txtAutomationCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAutomationCode).UseOsThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(532, 469);
    this.Controls.Add((Control) this.pnReq);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.UltraGrid1);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmAdminProducerRequirements);
    this.Text = "Producer Requirements";
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.txtDescription).EndInit();
    this.pnReq.ResumeLayout(false);
    this.pnReq.PerformLayout();
    ((ISupportInitialize) this.txtAutomationCode).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
  }

  private void frmAdminProducerRequirements_Load(object sender, EventArgs e)
  {
    this.FillRequirements();
    this.SetSaveState();
  }

  private void FillRequirements()
  {
    this.ds.lstProducerRequirements.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstProducerRequirements"
    }, CommandType.Text, "SELECT ProducerRequirementListID, Description, AutomationCode FROM lstProducerRequirements ORDER BY Description");
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.lstProducerRequirements.TableName];
  }

  private void SetSaveState()
  {
    if (this.ds.lstProducerRequirements.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void SetControlsEnabled(bool enabled) => this.pnReq.Enabled = enabled;

  private bool ValidateForm()
  {
    bool flag = true;
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtDescription).Text))
    {
      this.err.SetError((Control) this.txtDescription, "Please enter a value");
      flag = false;
    }
    return flag;
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.lstProducerRequirements.RejectChanges();
    this.SetSaveState();
    this.SetControlsEnabled(false);
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
    {
      int num = (int) MessageBox.Show("Please select a valid row in the grid", "Select valid Row", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else if (MessageBox.Show("Are you sure you want to delete this requirement?", "Delete Producer Requirement?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
    {
      e.Cancel = true;
    }
    else
    {
      this.ds.lstProducerRequirements[this.bmb.Position].Delete();
      this.Cursor = MgaCursors.WaitCursor;
      try
      {
        this.UpdateProducerRequirements();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        bool flag = true;
        if (exception.Message.Contains("FK_tblProducerRequirements_lstProducerRequirementList"))
        {
          int num = (int) MessageBox.Show("This requirement is in use on a producer and cannot be deleted.", "Cannot Delete. Requirement In Use.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          flag = false;
        }
        else if (exception.Message.Contains("You can not delete system defined producer requirements."))
        {
          int num = (int) MessageBox.Show("This requirement is system defined, Automation Code assigned, and cannot be deleted.", "Cannot Delete. System Defined Requirement.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          flag = false;
        }
        if (!flag)
        {
          this.FillRequirements();
          e.Cancel = true;
          ProjectData.ClearProjectError();
          return;
        }
        throw;
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
      this.SetControlsEnabled(false);
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    this.SetControlsEnabled(true);
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    dsAdminProducerRequirements.lstProducerRequirementsRow row = this.ds.lstProducerRequirements.NewlstProducerRequirementsRow();
    row.AutomationCode = "0";
    row.Description = string.Empty;
    this.ds.lstProducerRequirements.AddlstProducerRequirementsRow(row);
    this.bmb.Position = this.ds.lstProducerRequirements.Count - 1;
    this.SetControlsEnabled(true);
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidateForm())
    {
      e.Cancel = true;
    }
    else
    {
      if (!this.ds.lstProducerRequirements[this.bmb.Position].IsAutomationCodeNull() && this.ds.lstProducerRequirements[this.bmb.Position].AutomationCode.Replace(" ", string.Empty).Length == 0)
        this.ds.lstProducerRequirements[this.bmb.Position].SetAutomationCodeNull();
      this.bmb.EndCurrentEdit();
      this.Cursor = MgaCursors.WaitCursor;
      try
      {
        this.UpdateProducerRequirements();
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
      this.SetControlsEnabled(false);
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    bool enabled = this.dbSave.UIState == UIState.Editing;
    ((Control) this.UltraGrid1).Enabled = !enabled;
    this.SetControlsEnabled(enabled);
    if (enabled)
      return;
    if (this.ds.lstProducerRequirements.Count == 0)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void UltraGrid1_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.UltraGrid1).ActiveRow == null)
      return;
    Database.MoveTo((object) (int) ((UltraGridBase) this.UltraGrid1).ActiveRow.Cells["ProducerRequirementListID"].Value, this.ds.lstProducerRequirements.ProducerRequirementListIDColumn.ColumnName, (DataTable) this.ds.lstProducerRequirements, this.bmb);
  }

  private void UpdateProducerRequirements()
  {
    using (DbDataAdapter dbDataAdapter = DefaultDatabase.BuildDataAdapter((DataTable) this.ds.lstProducerRequirements, "dbo.InsertProducerRequirements", "dbo.UpdateProducerRequirements", "dbo.DeleteProducerRequirements", true, 30, (DbTransaction) null))
      DefaultDatabase.DataAdapterUpdate(dbDataAdapter, (DataTable) this.ds.lstProducerRequirements);
  }
}
