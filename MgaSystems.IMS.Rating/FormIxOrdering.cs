// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormIxOrdering
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormIxOrdering : FormBase
{
  private IContainer components;
  private readonly dsDriverInfo _dsDrivers;

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
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("dtIIX", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("DriverID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("RequestType", -1, (object) "ddTypes");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("FirstName", -1, (object) null, 0, (SortIndicator) 2, false);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("MiddleName");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("LastName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("DOB");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Suffix");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstIIXMVRTypes", -1);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Type");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Description");
    this.btnContinue = new Button();
    this.ugDriversOrder = new UltraGrid();
    this.ds = new dsDriverInfo();
    this.lnkMvrType = new LinkLabel();
    this.ddTypes = new UltraDropDown();
    this.rbXml = new RadioButton();
    this.groupFormat = new GroupBox();
    this.rbBoth = new RadioButton();
    this.rbPDF = new RadioButton();
    ((ISupportInitialize) this.ugDriversOrder).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddTypes).BeginInit();
    this.groupFormat.SuspendLayout();
    this.SuspendLayout();
    this.btnContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.btnContinue.DialogResult = DialogResult.OK;
    this.btnContinue.Location = new Point(808, 490);
    this.btnContinue.Name = "btnContinue";
    this.btnContinue.Size = new Size(75, 23);
    this.btnContinue.TabIndex = 13;
    this.btnContinue.Text = "Continue";
    this.btnContinue.UseVisualStyleBackColor = true;
    ((Control) this.ugDriversOrder).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugDriversOrder).DataMember = "dtIIX";
    ((UltraGridBase) this.ugDriversOrder).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Style = (ColumnStyle) 6;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "License #";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 136;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "First";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 182;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Middle";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 140;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Last";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 140;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 85;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 64 /*0x40*/;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridBand1.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugDriversOrder).Location = new Point(12, 57);
    ((Control) this.ugDriversOrder).Name = "ugDriversOrder";
    ((Control) this.ugDriversOrder).Size = new Size(871, 409);
    ((Control) this.ugDriversOrder).TabIndex = 67;
    ((UltraControlBase) this.ugDriversOrder).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugDriversOrder).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsDriverInfo";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkMvrType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lnkMvrType.AutoSize = true;
    this.lnkMvrType.BackColor = Color.Transparent;
    this.lnkMvrType.Location = new Point(314, 28);
    this.lnkMvrType.Name = "lnkMvrType";
    this.lnkMvrType.Size = new Size(165, 13);
    this.lnkMvrType.TabIndex = 206;
    this.lnkMvrType.TabStop = true;
    this.lnkMvrType.Text = "Admin - IIX MVRs Request Types";
    ((UltraGridBase) this.ddTypes).DataMember = "lstIIXMVRTypes";
    ((UltraGridBase) this.ddTypes).DataSource = (object) this.ds;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddTypes).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ultraGridBand2.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 0;
    ultraGridColumn10.Hidden = true;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 1;
    ultraGridColumn11.Hidden = true;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 2;
    ultraGridColumn12.Width = 45;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 3;
    ultraGridColumn13.Width = 200;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13
    });
    ((UltraGridBase) this.ddTypes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddTypes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddTypes).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddTypes).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddTypes).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddTypes).DisplayMember = "Type";
    ((UltraDropDownBase) this.ddTypes).DropDownWidth = 300;
    ((Control) this.ddTypes).Location = new Point(347, 104);
    ((Control) this.ddTypes).Name = "ddTypes";
    ((Control) this.ddTypes).Size = new Size(269, 73);
    ((Control) this.ddTypes).TabIndex = 207;
    ((UltraDropDownBase) this.ddTypes).ValueMember = "Type";
    ((Control) this.ddTypes).Visible = false;
    this.rbXml.AutoSize = true;
    this.rbXml.Checked = true;
    this.rbXml.Location = new Point(16 /*0x10*/, 19);
    this.rbXml.Name = "rbXml";
    this.rbXml.Size = new Size(47, 17);
    this.rbXml.TabIndex = 208 /*0xD0*/;
    this.rbXml.TabStop = true;
    this.rbXml.Tag = (object) "XML";
    this.rbXml.Text = "XML";
    this.rbXml.UseVisualStyleBackColor = true;
    this.groupFormat.BackColor = Color.Transparent;
    this.groupFormat.Controls.Add((Control) this.rbBoth);
    this.groupFormat.Controls.Add((Control) this.rbPDF);
    this.groupFormat.Controls.Add((Control) this.rbXml);
    this.groupFormat.Location = new Point(12, 9);
    this.groupFormat.Name = "groupFormat";
    this.groupFormat.Size = new Size(200, 42);
    this.groupFormat.TabIndex = 209;
    this.groupFormat.TabStop = false;
    this.groupFormat.Text = "Result Format";
    this.rbBoth.AutoSize = true;
    this.rbBoth.Location = new Point(130, 19);
    this.rbBoth.Name = "rbBoth";
    this.rbBoth.Size = new Size(47, 17);
    this.rbBoth.TabIndex = 210;
    this.rbBoth.Tag = (object) "BOTH";
    this.rbBoth.Text = "Both";
    this.rbBoth.UseVisualStyleBackColor = true;
    this.rbPDF.AutoSize = true;
    this.rbPDF.Location = new Point(78, 19);
    this.rbPDF.Name = "rbPDF";
    this.rbPDF.Size = new Size(46, 17);
    this.rbPDF.TabIndex = 209;
    this.rbPDF.Tag = (object) "PDF";
    this.rbPDF.Text = "PDF";
    this.rbPDF.UseVisualStyleBackColor = true;
    this.AcceptButton = (IButtonControl) this.btnContinue;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(895, 525);
    this.Controls.Add((Control) this.groupFormat);
    this.Controls.Add((Control) this.ddTypes);
    this.Controls.Add((Control) this.lnkMvrType);
    this.Controls.Add((Control) this.ugDriversOrder);
    this.Controls.Add((Control) this.btnContinue);
    this.Name = nameof (FormIxOrdering);
    this.Text = "IIX - Ordering MVRs";
    ((ISupportInitialize) this.ugDriversOrder).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddTypes).EndInit();
    this.groupFormat.ResumeLayout(false);
    this.groupFormat.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button btnContinue
  {
    get => this._btnContinue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnContinue_Click);
      Button btnContinue1 = this._btnContinue;
      if (btnContinue1 != null)
        btnContinue1.Click -= eventHandler;
      this._btnContinue = value;
      Button btnContinue2 = this._btnContinue;
      if (btnContinue2 == null)
        return;
      btnContinue2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ugDriversOrder")]
  protected virtual UltraGrid ugDriversOrder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkMvrType
  {
    get => this._lnkMvrType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkMvrType_LinkClicked);
      LinkLabel lnkMvrType1 = this._lnkMvrType;
      if (lnkMvrType1 != null)
        lnkMvrType1.LinkClicked -= clickedEventHandler;
      this._lnkMvrType = value;
      LinkLabel lnkMvrType2 = this._lnkMvrType;
      if (lnkMvrType2 == null)
        return;
      lnkMvrType2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsDriverInfo ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraDropDown ddTypes
  {
    get => this._ddTypes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.ddTypes_BeforeDropDown);
      UltraDropDown ddTypes1 = this._ddTypes;
      if (ddTypes1 != null)
        ddTypes1.BeforeDropDown -= cancelEventHandler;
      this._ddTypes = value;
      UltraDropDown ddTypes2 = this._ddTypes;
      if (ddTypes2 == null)
        return;
      ddTypes2.BeforeDropDown += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("groupFormat")]
  protected virtual GroupBox groupFormat { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbXml")]
  protected virtual RadioButton rbXml { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbBoth")]
  protected virtual RadioButton rbBoth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbPDF")]
  protected virtual RadioButton rbPDF { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public bool ContinueProcess { get; }

  public dsDriverInfo.dtIIXDataTable ProcessTable => this.ds.dtIIX;

  public string ReportFormat => this.SelectedRadioButton?.Tag is string tag ? tag : "BOTH";

  private RadioButton SelectedRadioButton
  {
    get
    {
      IEnumerable<RadioButton> source = this.groupFormat.Controls.OfType<RadioButton>();
      System.Func<RadioButton, bool> predicate;
      if (FormIxOrdering._Closure\u0024__.\u0024I48\u002D0 != null)
        predicate = FormIxOrdering._Closure\u0024__.\u0024I48\u002D0;
      else
        FormIxOrdering._Closure\u0024__.\u0024I48\u002D0 = predicate = (System.Func<RadioButton, bool>) ([SpecialName] (rb) => rb.Checked);
      return source.FirstOrDefault<RadioButton>(predicate);
    }
  }

  protected FormIxOrdering()
  {
    this.Load += new EventHandler(this.FormIxOrdering_Load);
    this.InitializeComponent();
  }

  public FormIxOrdering(int controlNo, Guid quoteGuid, dsDriverInfo dsDrivers)
    : this()
  {
    this._dsDrivers = dsDrivers;
  }

  private void FormIxOrdering_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      this.ds.lstIIXMVRTypes.TableName
    }, CommandType.Text, "SELECT ID, StateID, Type, Description FROM dbo.lstIIXMVRTypes");
    try
    {
      foreach (dsDriverInfo.tblDriverInfoRow row1 in this._dsDrivers.tblDriverInfo.Rows)
      {
        if (!row1.IsADRNull() && row1.ADR && row1.RowState != DataRowState.Added)
        {
          dsDriverInfo.dtIIXRow row2 = this.ds.dtIIX.NewdtIIXRow();
          row2.DriverID = (int) row1.DriverID;
          row2.LicenseNumber = row1.LicenseNumber;
          row2.FirstName = row1.FirstName;
          row2.LastName = row1.LastName;
          row2.DOB = row1.DOB;
          row2.StateID = row1.StateID;
          DataRow[] dataRowArray = this.ds.lstIIXMVRTypes.Select($"StateID='{row1.StateID}'");
          int index = 0;
          if (index < dataRowArray.Length)
          {
            dsDriverInfo.lstIIXMVRTypesRow lstIixmvrTypesRow = (dsDriverInfo.lstIIXMVRTypesRow) dataRowArray[index];
            row2.RequestType = lstIixmvrTypesRow.Type;
          }
          this.ds.dtIIX.AdddtIIXRow(row2);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void btnContinue_Click(object sender, EventArgs e)
  {
    if (!this.ValidData())
      return;
    // ISSUE: reference to a compiler-generated field
    this._ContinueProcess = this.ds.dtIIX.Count > 0;
    this.Close();
  }

  private bool ValidData()
  {
    int num1 = 1;
    bool flag;
    try
    {
      foreach (dsDriverInfo.dtIIXRow row in this.ds.dtIIX.Rows)
      {
        if (row.IsFirstNameNull())
        {
          int num2 = (int) MessageBox.Show($"Row # {num1.ToString()} is missing First Name.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_16;
        }
        if (row.IsLastNameNull())
        {
          int num3 = (int) MessageBox.Show($"Row # {num1.ToString()} is missing Last Name.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_16;
        }
        if (row.IsRequestTypeNull())
        {
          int num4 = (int) MessageBox.Show($"Row # {num1.ToString()} is missing Request Type.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_16;
        }
        string str = string.Format($"See driver '{{0}} {{1}} '{Environment.NewLine}{Environment.NewLine}", (object) row.FirstName, (object) row.LastName);
        if (row.IsLicenseNumberNull())
        {
          int num5 = (int) MessageBox.Show(str + "Driver is missing license #", "Missing License #", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_16;
        }
        ++num1;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    flag = true;
label_16:
    return flag;
  }

  private void lnkMvrType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowFormDialog<FormIxMvrTypes>();
  }

  private void ddTypes_BeforeDropDown(object sender, CancelEventArgs e)
  {
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugDriversOrder).ActiveRow.Cells["StateID"].Value)))
      return;
    string str = ((UltraGridBase) this.ugDriversOrder).ActiveRow.Cells["StateID"].Value.ToString();
    foreach (UltraGridRow row in ((UltraGridBase) this.ddTypes).Rows)
      row.Hidden = !row.Cells["StateID"].Value.ToString().Equals(str);
  }
}
