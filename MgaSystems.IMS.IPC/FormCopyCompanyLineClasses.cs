// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormCopyCompanyLineClasses
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.InsuredsProducersCompanies.Companies;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormCopyCompanyLineClasses : Form
{
  private IContainer components;
  private int _CurrentCompanyLineID;
  private CompanyLine _companyLine;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Parent");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Select");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("dtCodes", -1);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ClassCodeID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ClassCode");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ClassCodeDescription");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("DefaultGLExposureUnit");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Access");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Select");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance17 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormCopyCompanyLineClasses));
    this.ugStates = new UltraGrid();
    this.ds = new dsCompanyLineClasses();
    this.ugClasses = new UltraGrid();
    this.lnkDeSelectAllStates = new LinkLabel();
    this.lnkSelectAllStates = new LinkLabel();
    this.lnkDeSelectAllClassCodes = new LinkLabel();
    this.lnkSelectAllClassCodes = new LinkLabel();
    this.btnCopy = new MGAButton();
    ((ISupportInitialize) this.ugStates).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ugClasses).BeginInit();
    ((ISupportInitialize) this.btnCopy).BeginInit();
    this.SuspendLayout();
    ((Control) this.ugStates).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ugStates).DataMember = "lstStates";
    ((UltraGridBase) this.ugStates).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugStates).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugStates).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 89;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 122;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 69;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 60;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 54;
    ultraGridBand1.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugStates).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugStates).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugStates).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraGridBase) this.ugStates).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugStates).Location = new Point(607, 12);
    ((Control) this.ugStates).Name = "ugStates";
    ((Control) this.ugStates).Size = new Size(238, 616);
    ((Control) this.ugStates).TabIndex = 217;
    ((Control) this.ugStates).Text = "Available States";
    ((UltraControlBase) this.ugStates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugStates).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompanyLineClasses";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ugClasses).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugClasses).DataMember = "dtCodes";
    ((UltraGridBase) this.ugClasses).DataSource = (object) this.ds;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugClasses).DisplayLayout.Appearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugClasses).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn6.Header.VisiblePosition = 0;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 106;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Class Code";
    ultraGridColumn7.Header.VisiblePosition = 1;
    ultraGridColumn7.Width = 114;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Class Code Description";
    ultraGridColumn8.Header.VisiblePosition = 2;
    ultraGridColumn8.Width = 209;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Default GL Exposure Unit";
    ultraGridColumn9.Header.VisiblePosition = 3;
    ultraGridColumn9.Width = 159;
    ultraGridColumn10.Header.VisiblePosition = 4;
    ultraGridColumn10.Width = 61;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Copy";
    ultraGridColumn11.Header.VisiblePosition = 5;
    ultraGridColumn11.Width = 54;
    ultraGridBand2.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11
    });
    ultraGridBand2.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugClasses).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugClasses).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance10.BackColor = Color.LightSteelBlue;
    appearance10.FontData.SizeInPoints = 10f;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ugClasses).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ugClasses).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugClasses).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugClasses).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugClasses).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ugClasses).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugClasses).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance14.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugClasses).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance14;
    appearance15.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugClasses).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ugClasses).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.Transparent;
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.ugClasses).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugClasses).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.ugClasses).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugClasses).Location = new Point(12, 12);
    ((Control) this.ugClasses).Name = "ugClasses";
    ((Control) this.ugClasses).Size = new Size(599, 616);
    ((Control) this.ugClasses).TabIndex = 218;
    ((Control) this.ugClasses).Text = "Available Class Codes";
    ((UltraControlBase) this.ugClasses).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugClasses).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkDeSelectAllStates.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAllStates.AutoSize = true;
    this.lnkDeSelectAllStates.BackColor = Color.Transparent;
    this.lnkDeSelectAllStates.Location = new Point(419, 664);
    this.lnkDeSelectAllStates.Name = "lnkDeSelectAllStates";
    this.lnkDeSelectAllStates.Size = new Size(110, 13);
    this.lnkDeSelectAllStates.TabIndex = 220;
    this.lnkDeSelectAllStates.TabStop = true;
    this.lnkDeSelectAllStates.Text = "De-Select  - All States";
    this.lnkSelectAllStates.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAllStates.AutoSize = true;
    this.lnkSelectAllStates.BackColor = Color.Transparent;
    this.lnkSelectAllStates.Location = new Point(419, 637);
    this.lnkSelectAllStates.Name = "lnkSelectAllStates";
    this.lnkSelectAllStates.Size = new Size(93, 13);
    this.lnkSelectAllStates.TabIndex = 219;
    this.lnkSelectAllStates.TabStop = true;
    this.lnkSelectAllStates.Text = "Select All  - States";
    this.lnkDeSelectAllClassCodes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAllClassCodes.AutoSize = true;
    this.lnkDeSelectAllClassCodes.BackColor = Color.Transparent;
    this.lnkDeSelectAllClassCodes.Location = new Point(12, 664);
    this.lnkDeSelectAllClassCodes.Name = "lnkDeSelectAllClassCodes";
    this.lnkDeSelectAllClassCodes.Size = new Size(135, 13);
    this.lnkDeSelectAllClassCodes.TabIndex = 222;
    this.lnkDeSelectAllClassCodes.TabStop = true;
    this.lnkDeSelectAllClassCodes.Text = "De-Select All - Class Codes";
    this.lnkSelectAllClassCodes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAllClassCodes.AutoSize = true;
    this.lnkSelectAllClassCodes.BackColor = Color.Transparent;
    this.lnkSelectAllClassCodes.Location = new Point(12, 637);
    this.lnkSelectAllClassCodes.Name = "lnkSelectAllClassCodes";
    this.lnkSelectAllClassCodes.Size = new Size(118, 13);
    this.lnkSelectAllClassCodes.TabIndex = 221;
    this.lnkSelectAllClassCodes.TabStop = true;
    this.lnkSelectAllClassCodes.Text = "Select All - Class Codes";
    ((Control) this.btnCopy).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance17.BackColor = SystemColors.ActiveBorder;
    appearance17.BackColor2 = SystemColors.ControlDark;
    appearance17.BackGradientStyle = (GradientStyle) 2;
    appearance17.BorderColor = SystemColors.Window;
    appearance17.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance17.Image"));
    appearance17.ImageHAlign = (HAlign) 1;
    appearance17.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCopy).Appearance = (AppearanceBase) appearance17;
    ((Control) this.btnCopy).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnCopy).Location = new Point(748, 637);
    ((Control) this.btnCopy).Name = "btnCopy";
    ((ControlBase) this.btnCopy).Padding = new Size(5, 0);
    ((Control) this.btnCopy).Size = new Size(97, 40);
    ((Control) this.btnCopy).TabIndex = 223;
    ((ControlBase) this.btnCopy).Text = "Copy";
    this.btnCopy.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(857, 686);
    this.Controls.Add((Control) this.btnCopy);
    this.Controls.Add((Control) this.lnkDeSelectAllClassCodes);
    this.Controls.Add((Control) this.lnkSelectAllClassCodes);
    this.Controls.Add((Control) this.lnkDeSelectAllStates);
    this.Controls.Add((Control) this.lnkSelectAllStates);
    this.Controls.Add((Control) this.ugClasses);
    this.Controls.Add((Control) this.ugStates);
    this.Name = nameof (FormCopyCompanyLineClasses);
    this.Text = "Copy Company Line Class Codes";
    ((ISupportInitialize) this.ugStates).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ugClasses).EndInit();
    ((ISupportInitialize) this.btnCopy).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("ugStates")]
  private virtual UltraGrid ugStates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCompanyLineClasses ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugClasses")]
  private virtual UltraGrid ugClasses { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkDeSelectAllStates
  {
    get => this._lnkDeSelectAllStates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAllStates_LinkClicked);
      LinkLabel deSelectAllStates1 = this._lnkDeSelectAllStates;
      if (deSelectAllStates1 != null)
        deSelectAllStates1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAllStates = value;
      LinkLabel deSelectAllStates2 = this._lnkDeSelectAllStates;
      if (deSelectAllStates2 == null)
        return;
      deSelectAllStates2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkSelectAllStates
  {
    get => this._lnkSelectAllStates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAllStates_LinkClicked);
      LinkLabel lnkSelectAllStates1 = this._lnkSelectAllStates;
      if (lnkSelectAllStates1 != null)
        lnkSelectAllStates1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAllStates = value;
      LinkLabel lnkSelectAllStates2 = this._lnkSelectAllStates;
      if (lnkSelectAllStates2 == null)
        return;
      lnkSelectAllStates2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkDeSelectAllClassCodes
  {
    get => this._lnkDeSelectAllClassCodes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAllClassCodes_LinkClicked);
      LinkLabel selectAllClassCodes1 = this._lnkDeSelectAllClassCodes;
      if (selectAllClassCodes1 != null)
        selectAllClassCodes1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAllClassCodes = value;
      LinkLabel selectAllClassCodes2 = this._lnkDeSelectAllClassCodes;
      if (selectAllClassCodes2 == null)
        return;
      selectAllClassCodes2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkSelectAllClassCodes
  {
    get => this._lnkSelectAllClassCodes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAllClassCodes_LinkClicked);
      LinkLabel selectAllClassCodes1 = this._lnkSelectAllClassCodes;
      if (selectAllClassCodes1 != null)
        selectAllClassCodes1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAllClassCodes = value;
      LinkLabel selectAllClassCodes2 = this._lnkSelectAllClassCodes;
      if (selectAllClassCodes2 == null)
        return;
      selectAllClassCodes2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGAButton btnCopy
  {
    get => this._btnCopy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCopy_Click);
      MGAButton btnCopy1 = this._btnCopy;
      if (btnCopy1 != null)
        ((Control) btnCopy1).Click -= eventHandler;
      this._btnCopy = value;
      MGAButton btnCopy2 = this._btnCopy;
      if (btnCopy2 == null)
        return;
      ((Control) btnCopy2).Click += eventHandler;
    }
  }

  public FormCopyCompanyLineClasses(int currentCompanyLineID)
  {
    this.Load += new EventHandler(this.FormCopyCompanyLineClasses_Load);
    this.InitializeComponent();
    this._CurrentCompanyLineID = currentCompanyLineID;
    this._companyLine = new CompanyLine(currentCompanyLineID);
  }

  private void FormCopyCompanyLineClasses_Load(object sender, EventArgs e)
  {
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
      {
        "lstStates",
        "dtCodes"
      }, "GetCopyCompanyLineClassesData", new object[2]
      {
        (object) "@CompanyLineGuid",
        (object) this._companyLine.CompanyLineGuid
      });
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    ((Control) this.ugClasses).Text = $"{((Control) this.ugClasses).Text} for [ {this._companyLine.CompanyLineState} ]";
  }

  private void lnkSelectAllStates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetStateSelection(true);
  }

  private void lnkDeSelectAllStates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetStateSelection(false);
  }

  private void lnkSelectAllClassCodes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetClassSelection(true);
  }

  private void lnkDeSelectAllClassCodes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetClassSelection(false);
  }

  private void SetStateSelection(bool selectVal)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugStates).Rows)
      row.Cells["Select"].Value = (object) selectVal;
  }

  private void SetClassSelection(bool selectVal)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugClasses).Rows)
      row.Cells["Select"].Value = (object) selectVal;
  }

  private void btnCopy_Click(object sender, EventArgs e)
  {
    string str1 = string.Empty;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugStates).Rows)
    {
      if (row.Cells["Select"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["Select"].Value))
        str1 = $"{str1}{row.Cells["CompanyLineID"].Value.ToString()},";
    }
    if (str1.Equals(string.Empty))
    {
      int num1 = (int) MessageBox.Show("No item has been selected from the list of available states", "No State Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      string str2 = string.Empty;
      foreach (UltraGridRow row in ((UltraGridBase) this.ugClasses).Rows)
      {
        if (row.Cells["Select"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["Select"].Value))
          str2 = $"{str2}{row.Cells["ClassCodeID"].Value.ToString()},";
      }
      if (str2.Equals(string.Empty))
      {
        int num2 = (int) MessageBox.Show("No item has been selected from the list of available class codes", "No Class Code Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
        DefaultDatabase.ExecuteNonQuery("CopyCompanyClasses", new object[6]
        {
          (object) "@FromCompanyLineID",
          (object) this._CurrentCompanyLineID,
          (object) "@companyLineIDstr",
          (object) str1,
          (object) "@classCodeIDstr",
          (object) str2
        });
    }
  }
}
