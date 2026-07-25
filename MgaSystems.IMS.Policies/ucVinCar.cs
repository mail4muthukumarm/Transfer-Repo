// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.ucVinCar
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class ucVinCar : UserControl
{
  private IContainer components;

  public ucVinCar() => this.InitializeComponent();

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
    this.GroupBox1 = new GroupBox();
    this.txtTransmissionType = new Label();
    this.lblMSRP = new Label();
    this.Label12 = new Label();
    this.lblABSvv = new Label();
    this.lblCapacityvv = new Label();
    this.lblBrakeTypevv = new Label();
    this.lblGrossWtvv = new Label();
    this.lblCurbWtvv = new Label();
    this.lblFuelTypevv = new Label();
    this.lblEnginevv = new Label();
    this.Label9 = new Label();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.lblVinvv = new Label();
    this.lblMakevv = new Label();
    this.lblModelvv = new Label();
    this.lblYearVV = new Label();
    this.GroupBox2 = new GroupBox();
    this.lbEquipment = new ListBox();
    this.GroupBox3 = new GroupBox();
    this.Label10 = new Label();
    this.lblVin = new Label();
    this.lblMake = new Label();
    this.lblModel = new Label();
    this.lblYear = new Label();
    this.GroupBox1.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.SuspendLayout();
    this.GroupBox1.BackColor = Color.Transparent;
    this.GroupBox1.Controls.Add((Control) this.txtTransmissionType);
    this.GroupBox1.Controls.Add((Control) this.lblMSRP);
    this.GroupBox1.Controls.Add((Control) this.Label12);
    this.GroupBox1.Controls.Add((Control) this.lblABSvv);
    this.GroupBox1.Controls.Add((Control) this.lblCapacityvv);
    this.GroupBox1.Controls.Add((Control) this.lblBrakeTypevv);
    this.GroupBox1.Controls.Add((Control) this.lblGrossWtvv);
    this.GroupBox1.Controls.Add((Control) this.lblCurbWtvv);
    this.GroupBox1.Controls.Add((Control) this.lblFuelTypevv);
    this.GroupBox1.Controls.Add((Control) this.lblEnginevv);
    this.GroupBox1.Controls.Add((Control) this.Label9);
    this.GroupBox1.Controls.Add((Control) this.Label8);
    this.GroupBox1.Controls.Add((Control) this.Label7);
    this.GroupBox1.Controls.Add((Control) this.Label6);
    this.GroupBox1.Controls.Add((Control) this.Label5);
    this.GroupBox1.Controls.Add((Control) this.Label4);
    this.GroupBox1.Controls.Add((Control) this.Label3);
    this.GroupBox1.Controls.Add((Control) this.Label2);
    this.GroupBox1.Controls.Add((Control) this.Label1);
    this.GroupBox1.Controls.Add((Control) this.lblVinvv);
    this.GroupBox1.Controls.Add((Control) this.lblMakevv);
    this.GroupBox1.Controls.Add((Control) this.lblModelvv);
    this.GroupBox1.Controls.Add((Control) this.lblYearVV);
    this.GroupBox1.Font = new Font("Tahoma", 8.25f);
    this.GroupBox1.Location = new Point(11, 65);
    this.GroupBox1.Name = "GroupBox1";
    this.GroupBox1.Size = new Size(354, 183);
    this.GroupBox1.TabIndex = 7;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Verified Information";
    this.txtTransmissionType.Location = new Point(116, 123);
    this.txtTransmissionType.Name = "txtTransmissionType";
    this.txtTransmissionType.Size = new Size(228, 30);
    this.txtTransmissionType.TabIndex = 32 /*0x20*/;
    this.txtTransmissionType.Text = "Label11";
    this.lblMSRP.AutoSize = true;
    this.lblMSRP.Location = new Point(199, 39);
    this.lblMSRP.MinimumSize = new Size(150, 0);
    this.lblMSRP.Name = "lblMSRP";
    this.lblMSRP.Size = new Size(150, 13);
    this.lblMSRP.TabIndex = 31 /*0x1F*/;
    this.lblMSRP.Text = "Label1";
    this.Label12.AutoSize = true;
    this.Label12.ForeColor = Color.RoyalBlue;
    this.Label12.Location = new Point(159, 39);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(34, 13);
    this.Label12.TabIndex = 30;
    this.Label12.Text = "MSRP";
    this.lblABSvv.AutoSize = true;
    this.lblABSvv.Location = new Point(77, 102);
    this.lblABSvv.MinimumSize = new Size(40, 0);
    this.lblABSvv.Name = "lblABSvv";
    this.lblABSvv.Size = new Size(40, 13);
    this.lblABSvv.TabIndex = 29;
    this.lblABSvv.Text = "Label1";
    this.lblCapacityvv.AutoSize = true;
    this.lblCapacityvv.Location = new Point(107, 81);
    this.lblCapacityvv.MinimumSize = new Size(40, 0);
    this.lblCapacityvv.Name = "lblCapacityvv";
    this.lblCapacityvv.Size = new Size(40, 13);
    this.lblCapacityvv.TabIndex = 22;
    this.lblCapacityvv.Text = "Label1";
    this.lblBrakeTypevv.AutoSize = true;
    this.lblBrakeTypevv.Location = new Point(76, 60);
    this.lblBrakeTypevv.MinimumSize = new Size(70, 0);
    this.lblBrakeTypevv.Name = "lblBrakeTypevv";
    this.lblBrakeTypevv.Size = new Size(70, 13);
    this.lblBrakeTypevv.TabIndex = 28;
    this.lblBrakeTypevv.Text = "Label1";
    this.lblGrossWtvv.AutoSize = true;
    this.lblGrossWtvv.Location = new Point(248, 102);
    this.lblGrossWtvv.MinimumSize = new Size(70, 0);
    this.lblGrossWtvv.Name = "lblGrossWtvv";
    this.lblGrossWtvv.Size = new Size(70, 13);
    this.lblGrossWtvv.TabIndex = 27;
    this.lblGrossWtvv.Text = "Label1";
    this.lblCurbWtvv.AutoSize = true;
    this.lblCurbWtvv.Location = new Point(248, 81);
    this.lblCurbWtvv.MinimumSize = new Size(70, 0);
    this.lblCurbWtvv.Name = "lblCurbWtvv";
    this.lblCurbWtvv.Size = new Size(70, 13);
    this.lblCurbWtvv.TabIndex = 26;
    this.lblCurbWtvv.Text = "Label1";
    this.lblFuelTypevv.AutoSize = true;
    this.lblFuelTypevv.Location = new Point(248, 60);
    this.lblFuelTypevv.MinimumSize = new Size(100, 0);
    this.lblFuelTypevv.Name = "lblFuelTypevv";
    this.lblFuelTypevv.Size = new Size(100, 13);
    this.lblFuelTypevv.TabIndex = 24;
    this.lblFuelTypevv.Text = "Label1";
    this.lblEnginevv.AutoSize = true;
    this.lblEnginevv.Location = new Point(78, 157);
    this.lblEnginevv.MinimumSize = new Size(100, 0);
    this.lblEnginevv.Name = "lblEnginevv";
    this.lblEnginevv.Size = new Size(100, 13);
    this.lblEnginevv.TabIndex = 23;
    this.lblEnginevv.Text = "Label1";
    this.Label9.AutoSize = true;
    this.Label9.ForeColor = Color.RoyalBlue;
    this.Label9.Location = new Point(6, 102);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(64 /*0x40*/, 13);
    this.Label9.TabIndex = 21;
    this.Label9.Text = "ABS System";
    this.Label8.AutoSize = true;
    this.Label8.ForeColor = Color.RoyalBlue;
    this.Label8.Location = new Point(9, 60);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(61, 13);
    this.Label8.TabIndex = 20;
    this.Label8.Text = "Brake Type";
    this.Label7.AutoSize = true;
    this.Label7.ForeColor = Color.RoyalBlue;
    this.Label7.Location = new Point(6, 123);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(95, 13);
    this.Label7.TabIndex = 19;
    this.Label7.Text = "Transmission Type";
    this.Label6.AutoSize = true;
    this.Label6.ForeColor = Color.RoyalBlue;
    this.Label6.Location = new Point(139, 102);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(107, 13);
    this.Label6.TabIndex = 18;
    this.Label6.Text = "Gross Vehicle Weight";
    this.Label5.AutoSize = true;
    this.Label5.ForeColor = Color.RoyalBlue;
    this.Label5.Location = new Point(153, 81);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(93, 13);
    this.Label5.TabIndex = 17;
    this.Label5.Text = "Base Curb Weight";
    this.Label4.AutoSize = true;
    this.Label4.ForeColor = Color.RoyalBlue;
    this.Label4.Location = new Point(183, 60);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(54, 13);
    this.Label4.TabIndex = 16 /*0x10*/;
    this.Label4.Text = "Fuel Type";
    this.Label3.AutoSize = true;
    this.Label3.ForeColor = Color.RoyalBlue;
    this.Label3.Location = new Point(6, 81);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(102, 13);
    this.Label3.TabIndex = 15;
    this.Label3.Text = "Passenger Capacity";
    this.Label2.AutoSize = true;
    this.Label2.ForeColor = Color.RoyalBlue;
    this.Label2.Location = new Point(6, 39);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(94, 13);
    this.Label2.TabIndex = 14;
    this.Label2.Text = "Valid VIN Number?";
    this.Label1.AutoSize = true;
    this.Label1.ForeColor = Color.RoyalBlue;
    this.Label1.Location = new Point(6, 157);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(66, 13);
    this.Label1.TabIndex = 13;
    this.Label1.Text = "Engine Type";
    this.lblVinvv.Location = new Point(113, 39);
    this.lblVinvv.MinimumSize = new Size(50, 13);
    this.lblVinvv.Name = "lblVinvv";
    this.lblVinvv.Size = new Size(50, 13);
    this.lblVinvv.TabIndex = 12;
    this.lblVinvv.Text = "Label5";
    this.lblMakevv.AutoSize = true;
    this.lblMakevv.Location = new Point(65, 16 /*0x10*/);
    this.lblMakevv.MinimumSize = new Size(100, 0);
    this.lblMakevv.Name = "lblMakevv";
    this.lblMakevv.Size = new Size(100, 13);
    this.lblMakevv.TabIndex = 11;
    this.lblMakevv.Text = "Label1";
    this.lblModelvv.AutoSize = true;
    this.lblModelvv.Location = new Point(169, 16 /*0x10*/);
    this.lblModelvv.MinimumSize = new Size(100, 0);
    this.lblModelvv.Name = "lblModelvv";
    this.lblModelvv.Size = new Size(100, 13);
    this.lblModelvv.TabIndex = 10;
    this.lblModelvv.Text = "Label1";
    this.lblYearVV.AutoSize = true;
    this.lblYearVV.Location = new Point(6, 16 /*0x10*/);
    this.lblYearVV.Name = "lblYearVV";
    this.lblYearVV.Size = new Size(38, 13);
    this.lblYearVV.TabIndex = 9;
    this.lblYearVV.Text = "Label1";
    this.GroupBox2.Controls.Add((Control) this.lbEquipment);
    this.GroupBox2.Location = new Point(371, 6);
    this.GroupBox2.Name = "GroupBox2";
    this.GroupBox2.Size = new Size(234, 242);
    this.GroupBox2.TabIndex = 8;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Additional Features";
    this.lbEquipment.Font = new Font("Tahoma", 8.25f);
    this.lbEquipment.FormattingEnabled = true;
    this.lbEquipment.Location = new Point(6, 14);
    this.lbEquipment.Name = "lbEquipment";
    this.lbEquipment.Size = new Size(222, 225);
    this.lbEquipment.TabIndex = 7;
    this.GroupBox3.BackColor = Color.Transparent;
    this.GroupBox3.Controls.Add((Control) this.Label10);
    this.GroupBox3.Controls.Add((Control) this.lblVin);
    this.GroupBox3.Controls.Add((Control) this.lblMake);
    this.GroupBox3.Controls.Add((Control) this.lblModel);
    this.GroupBox3.Controls.Add((Control) this.lblYear);
    this.GroupBox3.Font = new Font("Tahoma", 8.25f);
    this.GroupBox3.Location = new Point(13, 5);
    this.GroupBox3.Name = "GroupBox3";
    this.GroupBox3.Size = new Size(352, 54);
    this.GroupBox3.TabIndex = 9;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Vehicle";
    this.Label10.AutoSize = true;
    this.Label10.ForeColor = Color.Black;
    this.Label10.Location = new Point(6, 31 /*0x1F*/);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(64 /*0x40*/, 13);
    this.Label10.TabIndex = 23;
    this.Label10.Text = "VIN Number";
    this.lblVin.AutoSize = true;
    this.lblVin.Location = new Point(75, 31 /*0x1F*/);
    this.lblVin.MinimumSize = new Size(100, 0);
    this.lblVin.Name = "lblVin";
    this.lblVin.Size = new Size(100, 13);
    this.lblVin.TabIndex = 22;
    this.lblVin.Text = "Label1";
    this.lblMake.AutoSize = true;
    this.lblMake.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMake.Location = new Point(51, 15);
    this.lblMake.MinimumSize = new Size(100, 0);
    this.lblMake.Name = "lblMake";
    this.lblMake.Size = new Size(100, 13);
    this.lblMake.TabIndex = 21;
    this.lblMake.Text = "Label1";
    this.lblModel.AutoSize = true;
    this.lblModel.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblModel.Location = new Point(155, 15);
    this.lblModel.MinimumSize = new Size(100, 0);
    this.lblModel.Name = "lblModel";
    this.lblModel.Size = new Size(100, 13);
    this.lblModel.TabIndex = 20;
    this.lblModel.Text = "Label1";
    this.lblYear.AutoSize = true;
    this.lblYear.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblYear.Location = new Point(6, 15);
    this.lblYear.Name = "lblYear";
    this.lblYear.Size = new Size(45, 13);
    this.lblYear.TabIndex = 19;
    this.lblYear.Text = "Label1";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.GroupBox1);
    this.Name = nameof (ucVinCar);
    this.Size = new Size(608, 259);
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("GroupBox1")]
  internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblVinvv")]
  internal virtual Label lblVinvv { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMakevv")]
  internal virtual Label lblMakevv { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblModelvv")]
  internal virtual Label lblModelvv { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblYearVV")]
  internal virtual Label lblYearVV { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCapacityvv")]
  internal virtual Label lblCapacityvv { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblEnginevv")]
  internal virtual Label lblEnginevv { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblFuelTypevv")]
  internal virtual Label lblFuelTypevv { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCurbWtvv")]
  internal virtual Label lblCurbWtvv { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblGrossWtvv")]
  internal virtual Label lblGrossWtvv { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBrakeTypevv")]
  internal virtual Label lblBrakeTypevv { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblABSvv")]
  internal virtual Label lblABSvv { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox2")]
  internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lbEquipment")]
  internal virtual ListBox lbEquipment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox3")]
  internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblVin")]
  internal virtual Label lblVin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMake")]
  internal virtual Label lblMake { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblModel")]
  internal virtual Label lblModel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblYear")]
  internal virtual Label lblYear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMSRP")]
  internal virtual Label lblMSRP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtTransmissionType")]
  internal virtual Label txtTransmissionType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
