// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormViewADRRecord
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
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
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormViewADRRecord : Form
{
  private IContainer components;
  private int _driverID;

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
    UltraGridBand ultraGridBand = new UltraGridBand("tblADR", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ADR_ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("DriverID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("AccountID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Purpose");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ProductID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("OrderDate");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Reference");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Control");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Valid");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ReklamiErrorCode");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ErrorCode");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ErrorDescription");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ResultBlob");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Routing");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("TrackingNumber");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("BillCode");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Host");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Line");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("FirstName");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("LastName");
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
    this.ugDrivers = new UltraGrid();
    this.ds = new dsDriverInfo();
    ((ISupportInitialize) this.ugDrivers).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.ugDrivers).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugDrivers).DataMember = "tblADR";
    ((UltraGridBase) this.ugDrivers).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn5.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Product ID";
    ultraGridColumn6.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Order Date";
    ultraGridColumn7.Header.VisiblePosition = 8;
    ultraGridColumn8.Header.VisiblePosition = 9;
    ultraGridColumn9.Header.VisiblePosition = 10;
    ultraGridColumn10.Header.VisiblePosition = 11;
    ultraGridColumn11.Header.VisiblePosition = 12;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Error Code";
    ultraGridColumn12.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Error Description";
    ultraGridColumn13.Header.VisiblePosition = 14;
    ultraGridColumn14.Header.VisiblePosition = 15;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn15.Header.VisiblePosition = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Tracking #";
    ultraGridColumn16.Header.VisiblePosition = 17;
    ultraGridColumn17.Header.VisiblePosition = 18;
    ultraGridColumn18.Header.VisiblePosition = 19;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "License #";
    ultraGridColumn19.Header.VisiblePosition = 20;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn20.Header.VisiblePosition = 21;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "First Name";
    ultraGridColumn21.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Last Name";
    ultraGridColumn22.Header.VisiblePosition = 5;
    ultraGridBand.Columns.AddRange(new object[22]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
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
    ((UltraGridBase) this.ugDrivers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugDrivers).Location = new Point(12, 12);
    ((Control) this.ugDrivers).Name = "ugDrivers";
    ((Control) this.ugDrivers).Size = new Size(648, 534);
    ((Control) this.ugDrivers).TabIndex = 2;
    ((Control) this.ugDrivers).Text = "Available ADRs";
    ((UltraControlBase) this.ugDrivers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugDrivers).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsDriverInfo";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(672, 558);
    this.Controls.Add((Control) this.ugDrivers);
    this.Name = nameof (FormViewADRRecord);
    this.Text = "ADR Record";
    ((ISupportInitialize) this.ugDrivers).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("ugDrivers")]
  protected virtual UltraGrid ugDrivers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsDriverInfo ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormViewADRRecord(int driverID)
  {
    this.Load += new EventHandler(this.FormViewADRRecord_Load);
    this.InitializeComponent();
    this._driverID = driverID;
  }

  private void FormViewADRRecord_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblADR"
    }, CommandType.Text, "SELECT AccountID, Purpose, ProductID, OrderDate, Reference, Control, Valid, ReklamiErrorCode,  ErrorCode, ErrorDescription, ResultBlob, Routing, TrackingNumber, BillCode,   Host, LicenseNumber,  Line, FirstName, LastName  FROM tblDriverADRInfo WITH (NOLOCK)  WHERE DriverID = @DR", new object[2]
    {
      (object) "@DR",
      (object) this._driverID
    });
  }
}
