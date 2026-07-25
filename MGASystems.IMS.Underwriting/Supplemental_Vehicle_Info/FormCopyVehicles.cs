// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Supplemental_Vehicle_Info.FormCopyVehicles
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Underwriting.Supplemental_Vehicle_Info;

public class FormCopyVehicles : Form
{
  private Guid _quoteGuid;
  private IContainer components;
  protected MGATextBox txtControlNos;
  protected UltraGrid ugVehicles;
  private dsSuppVehInfo ds;
  protected Label label1;
  protected Button btnCopy;

  public FormCopyVehicles(Guid quoteGuid)
  {
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
  }

  private bool IsValidCopy()
  {
    bool flag1 = true;
    if (((Control) this.txtControlNos).Text.Replace(" ", string.Empty).Length == 0)
    {
      flag1 = false;
      int num = (int) MessageBox.Show("No control #s entered to copied vehicle information.", "No Control #s Entered", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    bool flag2 = false;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugVehicles).Rows)
    {
      if (row.Cells["CopyOver"].Value != null && row.Cells["CopyOver"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["CopyOver"].Value))
      {
        flag2 = true;
        break;
      }
    }
    if (!flag2)
    {
      flag1 = false;
      int num = (int) MessageBox.Show("At least one vehicle must be selected to copy.", "No Vehicle Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    return flag1;
  }

  private string GetVehicles()
  {
    string vehicles = string.Empty;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugVehicles).Rows)
    {
      if (row.Cells["CopyOver"].Value != null && row.Cells["CopyOver"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["CopyOver"].Value))
        vehicles = $"{vehicles},{row.Cells["ID"].Value.ToString()}";
    }
    return vehicles;
  }

  private void btnCopy_Click(object sender, EventArgs e)
  {
    if (!this.IsValidCopy())
      return;
    string vehicles = this.GetVehicles();
    string[] strArray = ((Control) this.txtControlNos).Text.Split(",".ToCharArray());
    int result = int.MinValue;
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      foreach (string s in strArray)
      {
        if (int.TryParse(s, out result))
        {
          num1 = (int) DefaultDatabase.ExecuteScalar("spCopyVehicleSupplementalInformation", new object[6]
          {
            (object) "@CurrentQuoteGuid",
            (object) this._quoteGuid,
            (object) "@ControlNo",
            (object) result,
            (object) "@VehicleIDs",
            (object) vehicles
          });
          ++num3;
        }
        num2 += num1;
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    int num4 = (int) MessageBox.Show($"A total of {num2.ToString()} vehicle(s) copied over to {num3.ToString()} policies.", "Vehicle Copy Statistics", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.Close();
  }

  private void FormCopyVehicles_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dt"
    }, "spGetCopySupplementalVehicle", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid
    });
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
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("dt", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("VIN");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Year");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Make");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Model");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Deleted");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CopyOver");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    this.txtControlNos = new MGATextBox();
    this.label1 = new Label();
    this.ugVehicles = new UltraGrid();
    this.ds = new dsSuppVehInfo();
    this.btnCopy = new Button();
    ((ISupportInitialize) this.txtControlNos).BeginInit();
    ((ISupportInitialize) this.ugVehicles).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtControlNos).Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtControlNos).BackColor = Color.White;
    ((Control) this.txtControlNos).Location = new Point(12, 42);
    ((TextEditorControlBase) this.txtControlNos).MaxLength = 50;
    this.txtControlNos.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtControlNos).Name = "txtControlNos";
    ((Control) this.txtControlNos).Size = new Size(465, 19);
    ((Control) this.txtControlNos).TabIndex = 8;
    ((UltraControlBase) this.txtControlNos).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtControlNos).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(12, 17);
    this.label1.Name = "label1";
    this.label1.Size = new Size(198, 13);
    this.label1.TabIndex = 9;
    this.label1.Text = "Enter Control #s (Separated by Commas)";
    ((Control) this.ugVehicles).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.ugVehicles).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugVehicles).DataMember = "dt";
    ((UltraGridBase) this.ugVehicles).DataSource = (object) this.ds;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 49;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 5;
    ultraGridColumn2.Width = 143;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 83;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 208 /*0xD0*/;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 219;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 1;
    ultraGridColumn6.Width = 49;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Copy";
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Width = 47;
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
    ((UltraGridBase) this.ugVehicles).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugVehicles).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance3).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance3).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BackColor = Color.Transparent;
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance10).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugVehicles).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugVehicles).Location = new Point(12, 67);
    ((Control) this.ugVehicles).Name = "ugVehicles";
    ((Control) this.ugVehicles).Size = new Size(751, 275);
    ((Control) this.ugVehicles).TabIndex = 10;
    ((Control) this.ugVehicles).Text = "Copy Vehicle Information";
    ((UltraControlBase) this.ugVehicles).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugVehicles).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsSuppVehInfo";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.btnCopy.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCopy.Location = new Point(367, 348);
    this.btnCopy.Name = "btnCopy";
    this.btnCopy.Size = new Size(55, 45);
    this.btnCopy.TabIndex = 11;
    this.btnCopy.Text = "Copy";
    this.btnCopy.UseVisualStyleBackColor = true;
    this.btnCopy.Click += new EventHandler(this.btnCopy_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(775, 399);
    this.Controls.Add((Control) this.btnCopy);
    this.Controls.Add((Control) this.ugVehicles);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.txtControlNos);
    this.Name = nameof (FormCopyVehicles);
    this.Text = "Copy Vehicles";
    this.Load += new EventHandler(this.FormCopyVehicles_Load);
    ((ISupportInitialize) this.txtControlNos).EndInit();
    ((ISupportInitialize) this.ugVehicles).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
