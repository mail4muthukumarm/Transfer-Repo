// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormCompanyLineRequirements
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

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
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class FormCompanyLineRequirements : Form
{
  private IContainer components;

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormCompanyLineRequirements));
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstBindingRequirements", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("BindingRequirementID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("BindingRequirement");
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblCompanyLineRequirementsAdmin", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("BindingRequirementID", -1, (object) "ddRequirements");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("StoredProcName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ID");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    this.lnkCancelRequirement = new LinkLabel();
    this.lnkAddRequirement = new LinkLabel();
    this.btnSave = new MGAButton();
    this.ddRequirements = new UltraDropDown();
    this.ds = new dsRequirements();
    this.ugRequirements = new UltraGrid();
    this.btnAddRequirementsAdmin = new MGAButton();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.ddRequirements).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ugRequirements).BeginInit();
    ((ISupportInitialize) this.btnAddRequirementsAdmin).BeginInit();
    this.SuspendLayout();
    this.lnkCancelRequirement.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCancelRequirement.AutoSize = true;
    this.lnkCancelRequirement.Location = new Point(12, 465);
    this.lnkCancelRequirement.Name = "lnkCancelRequirement";
    this.lnkCancelRequirement.Size = new Size(170, 13);
    this.lnkCancelRequirement.TabIndex = 6;
    this.lnkCancelRequirement.TabStop = true;
    this.lnkCancelRequirement.Text = "Cancel Requirement / Stored Proc";
    this.lnkAddRequirement.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAddRequirement.AutoSize = true;
    this.lnkAddRequirement.Location = new Point(12, 432);
    this.lnkAddRequirement.Name = "lnkAddRequirement";
    this.lnkAddRequirement.Size = new Size(156, 13);
    this.lnkAddRequirement.TabIndex = 5;
    this.lnkAddRequirement.TabStop = true;
    this.lnkAddRequirement.Text = "Add Requirement / Stored Proc";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 1;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnSave).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnSave).Location = new Point(506, 435);
    ((Control) this.btnSave).Name = "btnSave";
    ((ControlBase) this.btnSave).Padding = new Size(5, 0);
    ((Control) this.btnSave).Size = new Size(85, 40);
    ((Control) this.btnSave).TabIndex = 327;
    ((ControlBase) this.btnSave).Text = "Save";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ddRequirements).DataMember = "lstBindingRequirements";
    ((UltraGridBase) this.ddRequirements).DataSource = (object) this.ds;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddRequirements).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ddRequirements).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Requirement";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ddRequirements).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ddRequirements).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddRequirements).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddRequirements).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddRequirements).DisplayMember = "BindingRequirement";
    ((UltraDropDownBase) this.ddRequirements).DropDownWidth = 350;
    ((Control) this.ddRequirements).Location = new Point(204, 112 /*0x70*/);
    ((Control) this.ddRequirements).Name = "ddRequirements";
    ((Control) this.ddRequirements).Size = new Size(184, 72);
    ((Control) this.ddRequirements).TabIndex = 328;
    ((UltraControlBase) this.ddRequirements).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddRequirements).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddRequirements).ValueMember = "BindingRequirementID";
    ((Control) this.ddRequirements).Visible = false;
    this.ds.DataSetName = "dsRequirements";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ugRequirements).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugRequirements).DataMember = "tblCompanyLineRequirementsAdmin";
    ((UltraGridBase) this.ugRequirements).DataSource = (object) this.ds;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Requirement";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Style = (ColumnStyle) 6;
    ultraGridColumn3.Width = 292;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Stored Procedure";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 264;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 125;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.ugRequirements).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugRequirements).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.WhiteSmoke;
    appearance11.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugRequirements).Location = new Point(15, 12);
    ((Control) this.ugRequirements).Name = "ugRequirements";
    ((Control) this.ugRequirements).Size = new Size(577, 402);
    ((Control) this.ugRequirements).TabIndex = 308;
    ((UltraControlBase) this.ugRequirements).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugRequirements).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnAddRequirementsAdmin).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance13.BackColor = Color.FromArgb(248, 248, 248);
    appearance13.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance13.BackGradientStyle = (GradientStyle) 2;
    appearance13.BorderColor = Color.DarkGray;
    appearance13.ImageHAlign = (HAlign) 1;
    appearance13.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnAddRequirementsAdmin).Appearance = (AppearanceBase) appearance13;
    ((Control) this.btnAddRequirementsAdmin).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnAddRequirementsAdmin).Location = new Point(189, 426);
    ((Control) this.btnAddRequirementsAdmin).Name = "btnAddRequirementsAdmin";
    ((ControlBase) this.btnAddRequirementsAdmin).Padding = new Size(5, 0);
    ((Control) this.btnAddRequirementsAdmin).Size = new Size(170, 27);
    ((Control) this.btnAddRequirementsAdmin).TabIndex = 329;
    ((ControlBase) this.btnAddRequirementsAdmin).Text = "Requirements Admin ...";
    this.btnAddRequirementsAdmin.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(604, 487);
    this.Controls.Add((Control) this.btnAddRequirementsAdmin);
    this.Controls.Add((Control) this.ddRequirements);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.ugRequirements);
    this.Controls.Add((Control) this.lnkCancelRequirement);
    this.Controls.Add((Control) this.lnkAddRequirement);
    this.Name = nameof (FormCompanyLineRequirements);
    this.Text = "Company / Line Requirements";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.ddRequirements).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ugRequirements).EndInit();
    ((ISupportInitialize) this.btnAddRequirementsAdmin).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual LinkLabel lnkCancelRequirement
  {
    get => this._lnkCancelRequirement;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCancelRequirement_LinkClicked);
      LinkLabel cancelRequirement1 = this._lnkCancelRequirement;
      if (cancelRequirement1 != null)
        cancelRequirement1.LinkClicked -= clickedEventHandler;
      this._lnkCancelRequirement = value;
      LinkLabel cancelRequirement2 = this._lnkCancelRequirement;
      if (cancelRequirement2 == null)
        return;
      cancelRequirement2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkAddRequirement
  {
    get => this._lnkAddRequirement;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddRequirement_LinkClicked);
      LinkLabel lnkAddRequirement1 = this._lnkAddRequirement;
      if (lnkAddRequirement1 != null)
        lnkAddRequirement1.LinkClicked -= clickedEventHandler;
      this._lnkAddRequirement = value;
      LinkLabel lnkAddRequirement2 = this._lnkAddRequirement;
      if (lnkAddRequirement2 == null)
        return;
      lnkAddRequirement2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ugRequirements")]
  private virtual UltraGrid ugRequirements { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ddRequirements")]
  private virtual UltraDropDown ddRequirements { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsRequirements ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnAddRequirementsAdmin
  {
    get => this._btnAddRequirementsAdmin;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAddRequirementsAdmin_Click);
      MGAButton requirementsAdmin1 = this._btnAddRequirementsAdmin;
      if (requirementsAdmin1 != null)
        ((Control) requirementsAdmin1).Click -= eventHandler;
      this._btnAddRequirementsAdmin = value;
      MGAButton requirementsAdmin2 = this._btnAddRequirementsAdmin;
      if (requirementsAdmin2 == null)
        return;
      ((Control) requirementsAdmin2).Click += eventHandler;
    }
  }

  public FormCompanyLineRequirements()
  {
    this.Load += new EventHandler(this.FormCompanyLineRequirements_Load);
    this.InitializeComponent();
  }

  private void FormCompanyLineRequirements_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
    {
      "lstBindingRequirements",
      "tblCompanyLineRequirementsAdmin"
    }, "spGetRequirementAdminData");
  }

  private bool IsValidStoredProcedureName(string sProc)
  {
    bool flag1 = true;
    string str = sProc;
    int index = 0;
    bool flag2;
    while (index < str.Length)
    {
      if (str[index].Equals(' '))
      {
        flag2 = false;
        goto label_6;
      }
      checked { ++index; }
    }
    flag2 = flag1;
label_6:
    return flag2;
  }

  private bool IsValidFormData()
  {
    bool flag = true;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugRequirements).Rows)
    {
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["BindingRequirementID"].Value)))
      {
        flag = false;
        int num = (int) MessageBox.Show("Please enter a value for requirement", "Requirement Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      }
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["StoredProcName"].Value)))
      {
        flag = false;
        int num = (int) MessageBox.Show("Please enter a value for stored procedure", "Stored Procedure Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      }
      if (row.Cells["StoredProcName"].Value.ToString().ToString().Replace(" ", string.Empty).Length == 0)
      {
        flag = false;
        int num = (int) MessageBox.Show("Please enter a valid value for stored procedure", "Stored Procedure Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      }
      if (!this.IsValidStoredProcedureName(row.Cells["StoredProcName"].Value.ToString()))
      {
        flag = false;
        int num = (int) MessageBox.Show("Please enter a valid value for stored procedure name.\n\nA space is not valid in a stored procedure's name", "Invalid Stored Procedure Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
      }
    }
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.IsValidFormData())
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.UpdateProgramCodes();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this.Close();
  }

  private void lnkAddRequirement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Bands[0].AddNew();
  }

  private void lnkCancelRequirement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ds.tblCompanyLineRequirementsAdmin.RejectChanges();
    ((UltraGridBase) this.ugRequirements).UpdateData();
    this.ds.tblCompanyLineRequirementsAdmin.RejectChanges();
    ((UltraGridBase) this.ugRequirements).UpdateData();
  }

  private void btnAddRequirementsAdmin_Click(object sender, EventArgs e)
  {
    FormSettings.ShowFormDialog(typeof (FormRequirements));
    this.ds.lstBindingRequirements.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstBindingRequirements"
    }, CommandType.Text, "SELECT BindingRequirementID, BindingRequirement FROM lstBindingRequirements WITH (NOLOCK) ORDER BY BindingRequirement");
  }

  protected virtual void UpdateProgramCodes()
  {
    using (DbDataAdapter dbDataAdapter = DefaultDatabase.BuildDataAdapter((DataTable) this.ds.tblCompanyLineRequirementsAdmin, "dbo.InsertCompanyLineRequirementsAdmin", "dbo.UpdateCompanyLineRequirementsAdmin", "dbo.DeleteCompanyLineRequirementsAdmin", true, 30, (DbTransaction) null))
      DefaultDatabase.DataAdapterUpdate(dbDataAdapter, (DataTable) this.ds.tblCompanyLineRequirementsAdmin);
  }
}
