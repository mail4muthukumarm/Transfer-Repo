// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormCompanyLineLoggingInfo
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Data;
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
public class FormCompanyLineLoggingInfo : Form
{
  private IContainer components;
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
    UltraGridBand ultraGridBand = new UltraGridBand("dtLogging", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Name_LastFirst");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Action");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ActionDate");
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
    this.ugCompanyLogging = new UltraGrid();
    this.ds = new dsCompanyLineLogInfo();
    this.txtAction = new TextBox();
    ((ISupportInitialize) this.ugCompanyLogging).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.ugCompanyLogging).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugCompanyLogging).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugCompanyLogging).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "User";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 188;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 633;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Date";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 55;
    ultraGridBand.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ultraGridBand.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 2;
    ultraGridBand.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugCompanyLogging).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugCompanyLogging).Location = new Point(12, 12);
    ((Control) this.ugCompanyLogging).Name = "ugCompanyLogging";
    ((Control) this.ugCompanyLogging).Size = new Size(934, 471);
    ((Control) this.ugCompanyLogging).TabIndex = 60;
    ((Control) this.ugCompanyLogging).Text = "Company / Line Logging Information";
    ((UltraControlBase) this.ugCompanyLogging).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugCompanyLogging).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompanyLineLogInfo";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.txtAction.Location = new Point(12, 489);
    this.txtAction.Multiline = true;
    this.txtAction.Name = "txtAction";
    this.txtAction.Size = new Size(934, 43);
    this.txtAction.TabIndex = 61;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(958, 537);
    this.Controls.Add((Control) this.txtAction);
    this.Controls.Add((Control) this.ugCompanyLogging);
    this.Name = nameof (FormCompanyLineLoggingInfo);
    this.Text = "Company / Line ";
    ((ISupportInitialize) this.ugCompanyLogging).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private virtual UltraGrid ugCompanyLogging
  {
    get => this._ugCompanyLogging;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UgCompanyLogging_AfterRowActivate);
      UltraGrid ugCompanyLogging1 = this._ugCompanyLogging;
      if (ugCompanyLogging1 != null)
        ugCompanyLogging1.AfterRowActivate -= eventHandler;
      this._ugCompanyLogging = value;
      UltraGrid ugCompanyLogging2 = this._ugCompanyLogging;
      if (ugCompanyLogging2 == null)
        return;
      ugCompanyLogging2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCompanyLineLogInfo ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAction")]
  private virtual TextBox txtAction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormCompanyLineLoggingInfo(int companyLineID)
  {
    this.Load += new EventHandler(this.FormCompanyLineLoggingInfo_Load);
    this.InitializeComponent();
    this._companyLine = new CompanyLine(companyLineID);
  }

  private void FormCompanyLineLoggingInfo_Load(object sender, EventArgs e)
  {
    this.Text = $"Logging Information for '{this._companyLine.CompanyLineState}'";
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dtLogging"
    }, "dbo.GetCompanyLineLoggingInfo", new object[4]
    {
      (object) "@companyLineGuid",
      (object) this._companyLine.CompanyLineGuid,
      (object) "@companyLineID",
      (object) this._companyLine.CompanyLineID
    });
  }

  private void UgCompanyLogging_AfterRowActivate(object sender, EventArgs e)
  {
    this.txtAction.Text = string.Empty;
    if (((UltraGridBase) this.ugCompanyLogging).ActiveRow == null || Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugCompanyLogging).ActiveRow.Cells["Action"].Value)))
      return;
    this.txtAction.Text = ((UltraGridBase) this.ugCompanyLogging).ActiveRow.Cells["Action"].Value.ToString();
  }
}
