// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.FormInspectionLineCode
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[DesignerGenerated]
public class FormInspectionLineCode : Form
{
  private IContainer components;
  private string _tableName;
  private bool _clickingNew;
  private bool _clickingEdit;
  private int _currentID;

  public FormInspectionLineCode()
  {
    this.Load += new EventHandler(this.FormInspectionLineCode_Load);
    this._tableName = string.Empty;
    this._clickingNew = false;
    this._clickingEdit = false;
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("dtCodes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LineCode");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Description");
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LIneGUID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LineName");
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("dt", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("InspectionLineGuid", -1, (object) "ddLines");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("LIneCode", -1, (object) "ddCode");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.gb = new UltraGroupBox();
    this.err = new ErrorProvider(this.components);
    this.ddCode = new UltraDropDown();
    this.ds = new dsInspectionLineCode();
    this.ddLines = new UltraDropDown();
    this.cboLine = new MGASimpleComboBox();
    this.cboCodes = new MGASimpleComboBox();
    this.ug = new UltraGrid();
    Label label1 = new Label();
    Label label2 = new Label();
    ((ISupportInitialize) this.gb).BeginInit();
    ((Control) this.gb).SuspendLayout();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ddCode).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddLines).BeginInit();
    ((ISupportInitialize) this.cboLine).BeginInit();
    ((ISupportInitialize) this.cboCodes).BeginInit();
    ((ISupportInitialize) this.ug).BeginInit();
    this.SuspendLayout();
    label1.AutoSize = true;
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(15, 17);
    label1.Name = "Label3";
    label1.Size = new Size(52, 13);
    label1.TabIndex = 4;
    label1.Text = "IMS Line:";
    label1.TextAlign = ContentAlignment.MiddleRight;
    label2.AutoSize = true;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(15, 52);
    label2.Name = "Label1";
    label2.Size = new Size(82, 13);
    label2.TabIndex = 0;
    label2.Text = "Inspection Line:";
    label2.TextAlign = ContentAlignment.MiddleRight;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(371, 396);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 3;
    ((Control) this.gb).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.gb.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.gb).Controls.Add((Control) this.cboLine);
    ((Control) this.gb).Controls.Add((Control) label1);
    ((Control) this.gb).Controls.Add((Control) this.cboCodes);
    ((Control) this.gb).Controls.Add((Control) label2);
    ((Control) this.gb).Enabled = false;
    ((Control) this.gb).Location = new Point(10, 310);
    ((Control) this.gb).Name = "gb";
    ((Control) this.gb).Size = new Size(477, 80 /*0x50*/);
    ((Control) this.gb).TabIndex = 5;
    this.err.ContainerControl = (ContainerControl) this;
    ((UltraGridBase) this.ddCode).DataMember = "dtCodes";
    ((UltraGridBase) this.ddCode).DataSource = (object) this.ds;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ddCode).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraDropDownBase) this.ddCode).DisplayMember = "Description";
    ((Control) this.ddCode).Location = new Point(114, 97);
    ((Control) this.ddCode).Name = "ddCode";
    ((Control) this.ddCode).Size = new Size(168, 40);
    ((Control) this.ddCode).TabIndex = 8;
    ((UltraDropDownBase) this.ddCode).ValueMember = "LineCode";
    ((Control) this.ddCode).Visible = false;
    this.ds.DataSetName = "dsInspectionLineCode";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.ddLines).DataMember = "lstLines";
    ((UltraGridBase) this.ddLines).DataSource = (object) this.ds;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ddLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddLines).DisplayMember = "LineName";
    ((Control) this.ddLines).Location = new Point(114, 155);
    ((Control) this.ddLines).Name = "ddLines";
    ((Control) this.ddLines).Size = new Size(168, 40);
    ((Control) this.ddLines).TabIndex = 7;
    ((UltraDropDownBase) this.ddLines).ValueMember = "LIneGUID";
    ((Control) this.ddLines).Visible = false;
    this.cboLine.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboLine).DataMember = "lstLines";
    ((UltraGridBase) this.cboLine).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboLine).DisplayMember = "LineName";
    this.cboLine.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboLine).Location = new Point(103, 13);
    this.cboLine.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLine).Name = "cboLine";
    ((Control) this.cboLine).Size = new Size(332, 20);
    ((Control) this.cboLine).TabIndex = 5;
    ((UltraControlBase) this.cboLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLine).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLine).ValueMember = "LIneGUID";
    this.cboCodes.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboCodes).DataMember = "dtCodes";
    ((UltraGridBase) this.cboCodes).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboCodes).DisplayMember = "Description";
    this.cboCodes.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCodes).Location = new Point(103, 48 /*0x30*/);
    this.cboCodes.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCodes).Name = "cboCodes";
    ((Control) this.cboCodes).Size = new Size(332, 20);
    ((Control) this.cboCodes).TabIndex = 1;
    ((UltraControlBase) this.cboCodes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCodes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCodes).ValueMember = "LineCode";
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ug).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ug).DataMember = "dt";
    ((UltraGridBase) this.ug).DataSource = (object) this.ds;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 63 /*0x3F*/;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Line of Business";
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Style = (ColumnStyle) 6;
    ultraGridColumn6.Width = 332;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Inspection Line";
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Style = (ColumnStyle) 6;
    ultraGridColumn7.Width = 141;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ug).Location = new Point(12, 12);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(475, 292);
    ((Control) this.ug).TabIndex = 4;
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(499, 448);
    this.Controls.Add((Control) this.ddCode);
    this.Controls.Add((Control) this.ddLines);
    this.Controls.Add((Control) this.gb);
    this.Controls.Add((Control) this.ug);
    this.Controls.Add((Control) this.dbSave);
    this.Name = nameof (FormInspectionLineCode);
    this.Text = "Inspection Line Code";
    ((ISupportInitialize) this.gb).EndInit();
    ((Control) this.gb).ResumeLayout(false);
    ((Control) this.gb).PerformLayout();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ddCode).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddLines).EndInit();
    ((ISupportInitialize) this.cboLine).EndInit();
    ((ISupportInitialize) this.cboCodes).EndInit();
    ((ISupportInitialize) this.ug).EndInit();
    this.ResumeLayout(false);
  }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedNew);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedCancel);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedNew -= eventHandler1;
        dbSave1.ClickingEdit -= cancelEventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler3;
        dbSave1.ClickedCancel -= eventHandler2;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedNew += eventHandler1;
      dbSave2.ClickingEdit += cancelEventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.ClickingSave += cancelEventHandler3;
      dbSave2.ClickedCancel += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("gb")]
  private virtual UltraGroupBox gb { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLine")]
  private virtual MGASimpleComboBox cboLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboCodes")]
  private virtual MGASimpleComboBox cboCodes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid ug
  {
    get => this._ug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ug_AfterRowActivate);
      UltraGrid ug1 = this._ug;
      if (ug1 != null)
        ug1.AfterRowActivate -= eventHandler;
      this._ug = value;
      UltraGrid ug2 = this._ug;
      if (ug2 == null)
        return;
      ug2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsInspectionLineCode ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddLines")]
  private virtual UltraDropDown ddLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddCode")]
  private virtual UltraDropDown ddCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void FormInspectionLineCode_Load(object sender, EventArgs e)
  {
    if (SystemSettings.KeyExists("InspectionLineCodeTableName"))
      this._tableName = SystemSettings.GetStringSetting("InspectionLineCodeTableName");
    if (this._tableName.Equals(string.Empty))
      throw new InvalidOperationException("Inspections Request. Missing system setting 'InspectionLineCodeTableName'.");
    string str = $"SELECT ID, InspectionLineGuid, LineCode FROM {this._tableName} WITH (NOLOCK)";
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "dt"
      }, CommandType.Text, str);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstLines"
    }, CommandType.Text, "SELECT LineGUID, LineName FROM lstLines ORDER BY LineName");
    this.ds.dtCodes.AdddtCodesRow("AUTO", "Auto");
    this.ds.dtCodes.AdddtCodesRow("GLIB", "General Liability");
    this.ds.dtCodes.AdddtCodesRow("PROP", "Property");
    this.ds.dtCodes.AdddtCodesRow("WCOMP", "Workers Comp");
  }

  private bool IsValidData()
  {
    this.err.SetError((Control) this.cboCodes, string.Empty);
    this.err.SetError((Control) this.cboLine, string.Empty);
    bool flag = true;
    if (string.IsNullOrEmpty(this.cboCodes.Text))
    {
      flag = false;
      this.err.SetError((Control) this.cboCodes, "Please select a value");
    }
    if (string.IsNullOrEmpty(this.cboLine.Text))
    {
      flag = false;
      this.err.SetError((Control) this.cboLine, "Please select a value");
    }
    return flag;
  }

  private void SetUpdateAction(bool isNew, bool isEditing)
  {
    this._clickingNew = isNew;
    this._clickingEdit = isEditing;
    if (isEditing || isNew)
    {
      ((Control) this.ug).Enabled = false;
      ((Control) this.gb).Enabled = true;
    }
    else
    {
      ((Control) this.ug).Enabled = true;
      ((Control) this.gb).Enabled = false;
    }
    if (isNew)
    {
      ((Control) this.cboCodes).Enabled = true;
      ((Control) this.cboLine).Enabled = true;
    }
    else
    {
      if (!isEditing)
        return;
      ((Control) this.cboLine).Enabled = false;
      ((Control) this.cboCodes).Enabled = true;
    }
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    this.cboCodes.Value = (object) null;
    this.cboLine.Value = (object) null;
    this.SetUpdateAction(true, false);
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    this.SetUpdateAction(false, true);
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    this.SetUpdateAction(false, false);
    if (((UltraGridBase) this.ug).ActiveRow == null)
    {
      this.cboCodes.Value = (object) null;
      this.cboLine.Value = (object) null;
      this.SetSaveState();
      e.Cancel = true;
    }
    else if (DialogResult.Yes != MessageBox.Show("Continue with the deletion of this record?", "Continue Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
    {
      e.Cancel = true;
    }
    else
    {
      Guid InspectionLineGuid = (Guid) ((UltraGridBase) this.ug).ActiveRow.Cells["InspectionLineGuid"].Value;
      this.ds.dt.FindByInspectionLineGuid(InspectionLineGuid).Delete();
      this.ds.AcceptChanges();
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, $"DELETE FROM {this._tableName} WHERE InspectionLineGuid=@InspectionLineGuid ", new object[2]
      {
        (object) "@InspectionLineGuid",
        (object) InspectionLineGuid
      });
      e.Cancel = true;
      this.ug_AfterRowActivate((object) null, EventArgs.Empty);
      this.SetSaveState();
    }
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    // ISSUE: unable to decompile the method.
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.dt.RejectChanges();
    this.SetUpdateAction(false, false);
    this.SetSaveState();
    this.SetActiveRow(((UltraGridBase) this.ug).Rows.Count - 1);
  }

  private void SetActiveRow(int rowIndex)
  {
    if (rowIndex < 0)
      return;
    ((UltraGridBase) this.ug).ActiveRow = ((UltraGridBase) this.ug).Rows[rowIndex];
    this.ug_AfterRowActivate((object) null, EventArgs.Empty);
  }

  private void SetSaveState()
  {
    if (this.ds.dt.Rows.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void ug_AfterRowActivate(object sender, EventArgs e)
  {
    this.cboCodes.Value = (object) null;
    this.cboLine.Value = (object) null;
    this.SetSaveState();
    this._currentID = int.MinValue;
    if (((UltraGridBase) this.ug).ActiveRow == null)
      return;
    this._currentID = Conversions.ToInteger(((UltraGridBase) this.ug).ActiveRow.Cells["ID"].Value);
    if (((UltraGridBase) this.ug).ActiveRow.Cells["InspectionLineGuid"].Value != DBNull.Value && ((UltraGridBase) this.ug).ActiveRow.Cells["InspectionLineGuid"].Value != null)
      this.cboLine.Value = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ug).ActiveRow.Cells["InspectionLineGuid"].Value);
    if (((UltraGridBase) this.ug).ActiveRow.Cells["LIneCode"].Value == DBNull.Value || ((UltraGridBase) this.ug).ActiveRow.Cells["LIneCode"].Value == null)
      return;
    this.cboCodes.Value = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ug).ActiveRow.Cells["LIneCode"].Value);
  }
}
