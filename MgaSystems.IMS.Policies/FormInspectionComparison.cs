// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormInspectionComparison
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormInspectionComparison : Form
{
  private IContainer components;
  private readonly Quote _q;

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
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
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
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("dtLocations", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Zip");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Construction");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("SqFootage");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("YearBuilt");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("NumberOfStories");
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance29 = new Appearance();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.txtSqFoot2 = new MGATextBox();
    this.txtSqFoot1 = new MGATextBox();
    this.txtBuilt2 = new MGATextBox();
    this.txtBuilt1 = new MGATextBox();
    this.txtStories2 = new MGATextBox();
    this.txtStories1 = new MGATextBox();
    this.txtConstruction2 = new MGATextBox();
    this.txtConstruction1 = new MGATextBox();
    this.lstIMSExposure = new MGAListBox();
    this.lstInspExposure = new MGAListBox();
    this.MgaTextBox1 = new MGATextBox();
    this.MgaTextBox2 = new MGATextBox();
    this.MgaTextBox3 = new MGATextBox();
    this.MgaTextBox4 = new MGATextBox();
    this.txtRoofAge2 = new MGATextBox();
    this.txtRoofAge1 = new MGATextBox();
    this.MgaTextBox7 = new MGATextBox();
    this.MgaTextBox8 = new MGATextBox();
    this.MgaTextBox9 = new MGATextBox();
    this.MgaTextBox10 = new MGATextBox();
    this.MgaTextBox11 = new MGATextBox();
    this.MgaTextBox12 = new MGATextBox();
    this.ugLocations = new UltraGrid();
    this.ds = new dsCompareInspect();
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    Label label5 = new Label();
    Label label6 = new Label();
    Label label7 = new Label();
    Label label8 = new Label();
    Label label9 = new Label();
    Label label10 = new Label();
    Label label11 = new Label();
    Label label12 = new Label();
    ((ISupportInitialize) this.txtSqFoot2).BeginInit();
    ((ISupportInitialize) this.txtSqFoot1).BeginInit();
    ((ISupportInitialize) this.txtBuilt2).BeginInit();
    ((ISupportInitialize) this.txtBuilt1).BeginInit();
    ((ISupportInitialize) this.txtStories2).BeginInit();
    ((ISupportInitialize) this.txtStories1).BeginInit();
    ((ISupportInitialize) this.txtConstruction2).BeginInit();
    ((ISupportInitialize) this.txtConstruction1).BeginInit();
    ((ISupportInitialize) this.lstIMSExposure).BeginInit();
    ((ISupportInitialize) this.lstInspExposure).BeginInit();
    ((ISupportInitialize) this.MgaTextBox1).BeginInit();
    ((ISupportInitialize) this.MgaTextBox2).BeginInit();
    ((ISupportInitialize) this.MgaTextBox3).BeginInit();
    ((ISupportInitialize) this.MgaTextBox4).BeginInit();
    ((ISupportInitialize) this.txtRoofAge2).BeginInit();
    ((ISupportInitialize) this.txtRoofAge1).BeginInit();
    ((ISupportInitialize) this.MgaTextBox7).BeginInit();
    ((ISupportInitialize) this.MgaTextBox8).BeginInit();
    ((ISupportInitialize) this.MgaTextBox9).BeginInit();
    ((ISupportInitialize) this.MgaTextBox10).BeginInit();
    ((ISupportInitialize) this.MgaTextBox11).BeginInit();
    ((ISupportInitialize) this.MgaTextBox12).BeginInit();
    ((ISupportInitialize) this.ugLocations).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label1.AutoSize = true;
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(50, 389);
    label1.Name = "Label7";
    label1.Size = new Size(86, 13);
    label1.TabIndex = 244;
    label1.Text = "Square Footage:";
    label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label2.AutoSize = true;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(50, 414);
    label2.Name = "Label19";
    label2.Size = new Size(55, 13);
    label2.TabIndex = 272;
    label2.Text = "Year Built:";
    label2.TextAlign = ContentAlignment.MiddleRight;
    label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label3.AutoSize = true;
    label3.BackColor = Color.Transparent;
    label3.Location = new Point(50, 439);
    label3.Name = "Label16";
    label3.Size = new Size(52, 13);
    label3.TabIndex = 287;
    label3.Text = "# Stories:";
    label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label4.AutoSize = true;
    label4.BackColor = Color.Transparent;
    label4.Location = new Point(50, 464);
    label4.Name = "Label13";
    label4.Size = new Size(69, 13);
    label4.TabIndex = 290;
    label4.Text = "Construction:";
    label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label5.AutoSize = true;
    label5.BackColor = Color.Transparent;
    label5.Location = new Point(12, 484);
    label5.Name = "Label4";
    label5.Size = new Size(76, 13);
    label5.TabIndex = 295;
    label5.Text = "IMS Exposure:";
    label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label6.AutoSize = true;
    label6.BackColor = Color.Transparent;
    label6.Location = new Point(353, 484);
    label6.Name = "Label5";
    label6.Size = new Size(106, 13);
    label6.TabIndex = 296;
    label6.Text = "Inspection Exposure:";
    label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label7.AutoSize = true;
    label7.BackColor = Color.Transparent;
    label7.Location = new Point(50, 239);
    label7.Name = "Label6";
    label7.Size = new Size(40, 13);
    label7.TabIndex = 297;
    label7.Text = "Straps:";
    label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label8.AutoSize = true;
    label8.BackColor = Color.Transparent;
    label8.Location = new Point(50, 264);
    label8.Name = "Label8";
    label8.Size = new Size(49, 13);
    label8.TabIndex = 300;
    label8.Text = "Shutters:";
    label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label9.AutoSize = true;
    label9.BackColor = Color.Transparent;
    label9.Location = new Point(50, 289);
    label9.Name = "Label9";
    label9.Size = new Size(55, 13);
    label9.TabIndex = 303;
    label9.Text = "Roof Age:";
    label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label10.AutoSize = true;
    label10.BackColor = Color.Transparent;
    label10.Location = new Point(50, 314);
    label10.Name = "Label10";
    label10.Size = new Size(67, 13);
    label10.TabIndex = 306;
    label10.Text = "Roof Shape:";
    label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label11.AutoSize = true;
    label11.BackColor = Color.Transparent;
    label11.Location = new Point(50, 339);
    label11.Name = "Label11";
    label11.Size = new Size(56, 13);
    label11.TabIndex = 309;
    label11.Text = "Tree Risk:";
    label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label12.AutoSize = true;
    label12.BackColor = Color.Transparent;
    label12.Location = new Point(50, 364);
    label12.Name = "Label12";
    label12.Size = new Size(87, 13);
    label12.TabIndex = 312;
    label12.Text = "Other Structures:";
    this.Label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Microsoft Sans Serif", 10.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(478, 213);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(121, 17);
    this.Label3.TabIndex = 243;
    this.Label3.Text = "Inspection Data";
    this.Label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Microsoft Sans Serif", 10.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(340, 213);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(33, 17);
    this.Label2.TabIndex = 242;
    this.Label2.Text = "VS.";
    this.Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Microsoft Sans Serif", 10.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(129, 213);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(83, 17);
    this.Label1.TabIndex = 241;
    this.Label1.Text = "IMS Data  ";
    ((Control) this.txtSqFoot2).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSqFoot2).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtSqFoot2).BackColor = Color.White;
    ((Control) this.txtSqFoot2).Location = new Point(505, 386);
    ((TextEditorControlBase) this.txtSqFoot2).MaxLength = 7;
    this.txtSqFoot2.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtSqFoot2).Name = "txtSqFoot2";
    ((Control) this.txtSqFoot2).Size = new Size(56, 19);
    ((Control) this.txtSqFoot2).TabIndex = 246;
    ((Control) this.txtSqFoot2).Tag = (object) "insp";
    ((UltraControlBase) this.txtSqFoot2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSqFoot2).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtSqFoot1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSqFoot1).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtSqFoot1).BackColor = Color.White;
    ((Control) this.txtSqFoot1).Location = new Point(141, 386);
    ((TextEditorControlBase) this.txtSqFoot1).MaxLength = 7;
    this.txtSqFoot1.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtSqFoot1).Name = "txtSqFoot1";
    ((Control) this.txtSqFoot1).Size = new Size(56, 19);
    ((Control) this.txtSqFoot1).TabIndex = 245;
    ((Control) this.txtSqFoot1).Tag = (object) "base";
    ((UltraControlBase) this.txtSqFoot1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSqFoot1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtBuilt2).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtBuilt2).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtBuilt2).BackColor = Color.White;
    ((Control) this.txtBuilt2).Location = new Point(505, 411);
    ((TextEditorControlBase) this.txtBuilt2).MaxLength = 4;
    this.txtBuilt2.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtBuilt2).Name = "txtBuilt2";
    ((Control) this.txtBuilt2).Size = new Size(56, 19);
    ((Control) this.txtBuilt2).TabIndex = 282;
    ((Control) this.txtBuilt2).Tag = (object) "insp";
    ((UltraControlBase) this.txtBuilt2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtBuilt2).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtBuilt1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtBuilt1).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtBuilt1).BackColor = Color.White;
    ((Control) this.txtBuilt1).Location = new Point(141, 411);
    ((TextEditorControlBase) this.txtBuilt1).MaxLength = 4;
    this.txtBuilt1.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtBuilt1).Name = "txtBuilt1";
    ((Control) this.txtBuilt1).Size = new Size(56, 19);
    ((Control) this.txtBuilt1).TabIndex = 273;
    ((Control) this.txtBuilt1).Tag = (object) "base";
    ((UltraControlBase) this.txtBuilt1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtBuilt1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtStories2).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtStories2).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtStories2).BackColor = Color.White;
    ((Control) this.txtStories2).Location = new Point(505, 436);
    ((TextEditorControlBase) this.txtStories2).MaxLength = 2;
    this.txtStories2.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtStories2).Name = "txtStories2";
    ((Control) this.txtStories2).Size = new Size(56, 19);
    ((Control) this.txtStories2).TabIndex = 289;
    ((Control) this.txtStories2).Tag = (object) "n";
    ((UltraControlBase) this.txtStories2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtStories2).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtStories1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtStories1).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.txtStories1).BackColor = Color.White;
    ((Control) this.txtStories1).Location = new Point(141, 436);
    ((TextEditorControlBase) this.txtStories1).MaxLength = 2;
    this.txtStories1.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtStories1).Name = "txtStories1";
    ((Control) this.txtStories1).Size = new Size(56, 19);
    ((Control) this.txtStories1).TabIndex = 288;
    ((Control) this.txtStories1).Tag = (object) "base";
    ((UltraControlBase) this.txtStories1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtStories1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtConstruction2).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtConstruction2).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.txtConstruction2).BackColor = Color.White;
    ((Control) this.txtConstruction2).Location = new Point(505, 461);
    ((TextEditorControlBase) this.txtConstruction2).MaxLength = 2;
    this.txtConstruction2.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtConstruction2).Name = "txtConstruction2";
    ((Control) this.txtConstruction2).Size = new Size(178, 19);
    ((Control) this.txtConstruction2).TabIndex = 292;
    ((Control) this.txtConstruction2).Tag = (object) "insp";
    ((UltraControlBase) this.txtConstruction2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtConstruction2).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtConstruction1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtConstruction1).Appearance = (AppearanceBase) appearance8;
    ((TextEditorControlBase) this.txtConstruction1).BackColor = Color.White;
    ((Control) this.txtConstruction1).Location = new Point(141, 461);
    ((TextEditorControlBase) this.txtConstruction1).MaxLength = 2;
    this.txtConstruction1.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtConstruction1).Name = "txtConstruction1";
    ((Control) this.txtConstruction1).Size = new Size(178, 19);
    ((Control) this.txtConstruction1).TabIndex = 291;
    ((Control) this.txtConstruction1).Tag = (object) "base";
    ((UltraControlBase) this.txtConstruction1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtConstruction1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.lstIMSExposure).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.lstIMSExposure).Location = new Point(12, 509);
    ((Control) this.lstIMSExposure).Name = "lstIMSExposure";
    ((Control) this.lstIMSExposure).Size = new Size(307, 158);
    ((Control) this.lstIMSExposure).TabIndex = 293;
    ((Control) this.lstInspExposure).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((Control) this.lstInspExposure).Location = new Point(382, 509);
    ((Control) this.lstInspExposure).Name = "lstInspExposure";
    ((Control) this.lstInspExposure).Size = new Size(307, 158);
    ((Control) this.lstInspExposure).TabIndex = 294;
    ((Control) this.MgaTextBox1).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox1).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.MgaTextBox1).BackColor = Color.White;
    ((Control) this.MgaTextBox1).Location = new Point(505, 236);
    ((TextEditorControlBase) this.MgaTextBox1).MaxLength = 7;
    this.MgaTextBox1.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox1).Name = "MgaTextBox1";
    ((Control) this.MgaTextBox1).Size = new Size(56, 19);
    ((Control) this.MgaTextBox1).TabIndex = 299;
    ((Control) this.MgaTextBox1).Tag = (object) "insp";
    ((UltraControlBase) this.MgaTextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaTextBox2).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox2).Appearance = (AppearanceBase) appearance10;
    ((TextEditorControlBase) this.MgaTextBox2).BackColor = Color.White;
    ((Control) this.MgaTextBox2).Location = new Point(142, 236);
    ((TextEditorControlBase) this.MgaTextBox2).MaxLength = 7;
    this.MgaTextBox2.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox2).Name = "MgaTextBox2";
    ((Control) this.MgaTextBox2).Size = new Size(56, 19);
    ((Control) this.MgaTextBox2).TabIndex = 298;
    ((Control) this.MgaTextBox2).Tag = (object) "base";
    ((UltraControlBase) this.MgaTextBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox2).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaTextBox3).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox3).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.MgaTextBox3).BackColor = Color.White;
    ((Control) this.MgaTextBox3).Location = new Point(505, 261);
    ((TextEditorControlBase) this.MgaTextBox3).MaxLength = 7;
    this.MgaTextBox3.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox3).Name = "MgaTextBox3";
    ((Control) this.MgaTextBox3).Size = new Size(56, 19);
    ((Control) this.MgaTextBox3).TabIndex = 302;
    ((Control) this.MgaTextBox3).Tag = (object) "insp";
    ((UltraControlBase) this.MgaTextBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox3).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaTextBox4).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox4).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.MgaTextBox4).BackColor = Color.White;
    ((Control) this.MgaTextBox4).Location = new Point(141, 261);
    ((TextEditorControlBase) this.MgaTextBox4).MaxLength = 7;
    this.MgaTextBox4.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox4).Name = "MgaTextBox4";
    ((Control) this.MgaTextBox4).Size = new Size(56, 19);
    ((Control) this.MgaTextBox4).TabIndex = 301;
    ((Control) this.MgaTextBox4).Tag = (object) "base";
    ((UltraControlBase) this.MgaTextBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox4).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtRoofAge2).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtRoofAge2).Appearance = (AppearanceBase) appearance13;
    ((TextEditorControlBase) this.txtRoofAge2).BackColor = Color.White;
    ((Control) this.txtRoofAge2).Location = new Point(505, 286);
    ((TextEditorControlBase) this.txtRoofAge2).MaxLength = 7;
    this.txtRoofAge2.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtRoofAge2).Name = "txtRoofAge2";
    ((Control) this.txtRoofAge2).Size = new Size(56, 19);
    ((Control) this.txtRoofAge2).TabIndex = 305;
    ((Control) this.txtRoofAge2).Tag = (object) "insp";
    ((UltraControlBase) this.txtRoofAge2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRoofAge2).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtRoofAge1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtRoofAge1).Appearance = (AppearanceBase) appearance14;
    ((TextEditorControlBase) this.txtRoofAge1).BackColor = Color.White;
    ((Control) this.txtRoofAge1).Location = new Point(141, 286);
    ((TextEditorControlBase) this.txtRoofAge1).MaxLength = 7;
    this.txtRoofAge1.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtRoofAge1).Name = "txtRoofAge1";
    ((Control) this.txtRoofAge1).Size = new Size(56, 19);
    ((Control) this.txtRoofAge1).TabIndex = 304;
    ((Control) this.txtRoofAge1).Tag = (object) "base";
    ((UltraControlBase) this.txtRoofAge1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtRoofAge1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaTextBox7).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance15.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox7).Appearance = (AppearanceBase) appearance15;
    ((TextEditorControlBase) this.MgaTextBox7).BackColor = Color.White;
    ((Control) this.MgaTextBox7).Location = new Point(505, 311);
    ((TextEditorControlBase) this.MgaTextBox7).MaxLength = 7;
    this.MgaTextBox7.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox7).Name = "MgaTextBox7";
    ((Control) this.MgaTextBox7).Size = new Size(56, 19);
    ((Control) this.MgaTextBox7).TabIndex = 308;
    ((Control) this.MgaTextBox7).Tag = (object) "insp";
    ((UltraControlBase) this.MgaTextBox7).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox7).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaTextBox8).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox8).Appearance = (AppearanceBase) appearance16;
    ((TextEditorControlBase) this.MgaTextBox8).BackColor = Color.White;
    ((Control) this.MgaTextBox8).Location = new Point(142, 311);
    ((TextEditorControlBase) this.MgaTextBox8).MaxLength = 7;
    this.MgaTextBox8.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox8).Name = "MgaTextBox8";
    ((Control) this.MgaTextBox8).Size = new Size(56, 19);
    ((Control) this.MgaTextBox8).TabIndex = 307;
    ((Control) this.MgaTextBox8).Tag = (object) "base";
    ((UltraControlBase) this.MgaTextBox8).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox8).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaTextBox9).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox9).Appearance = (AppearanceBase) appearance17;
    ((TextEditorControlBase) this.MgaTextBox9).BackColor = Color.White;
    ((Control) this.MgaTextBox9).Location = new Point(505, 336);
    ((TextEditorControlBase) this.MgaTextBox9).MaxLength = 7;
    this.MgaTextBox9.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox9).Name = "MgaTextBox9";
    ((Control) this.MgaTextBox9).Size = new Size(56, 19);
    ((Control) this.MgaTextBox9).TabIndex = 311;
    ((Control) this.MgaTextBox9).Tag = (object) "insp";
    ((UltraControlBase) this.MgaTextBox9).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox9).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaTextBox10).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance18.BackColor = Color.White;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance18.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox10).Appearance = (AppearanceBase) appearance18;
    ((TextEditorControlBase) this.MgaTextBox10).BackColor = Color.White;
    ((Control) this.MgaTextBox10).Location = new Point(142, 336);
    ((TextEditorControlBase) this.MgaTextBox10).MaxLength = 7;
    this.MgaTextBox10.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox10).Name = "MgaTextBox10";
    ((Control) this.MgaTextBox10).Size = new Size(56, 19);
    ((Control) this.MgaTextBox10).TabIndex = 310;
    ((Control) this.MgaTextBox10).Tag = (object) "base";
    ((UltraControlBase) this.MgaTextBox10).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox10).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaTextBox11).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance19.BackColor = Color.White;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox11).Appearance = (AppearanceBase) appearance19;
    ((TextEditorControlBase) this.MgaTextBox11).BackColor = Color.White;
    ((Control) this.MgaTextBox11).Location = new Point(505, 361);
    ((TextEditorControlBase) this.MgaTextBox11).MaxLength = 7;
    this.MgaTextBox11.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox11).Name = "MgaTextBox11";
    ((Control) this.MgaTextBox11).Size = new Size(56, 19);
    ((Control) this.MgaTextBox11).TabIndex = 314;
    ((Control) this.MgaTextBox11).Tag = (object) "insp";
    ((UltraControlBase) this.MgaTextBox11).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox11).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaTextBox12).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance20.BackColor = Color.White;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox12).Appearance = (AppearanceBase) appearance20;
    ((TextEditorControlBase) this.MgaTextBox12).BackColor = Color.White;
    ((Control) this.MgaTextBox12).Location = new Point(142, 361);
    ((TextEditorControlBase) this.MgaTextBox12).MaxLength = 7;
    this.MgaTextBox12.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox12).Name = "MgaTextBox12";
    ((Control) this.MgaTextBox12).Size = new Size(56, 19);
    ((Control) this.MgaTextBox12).TabIndex = 313;
    ((Control) this.MgaTextBox12).Tag = (object) "base";
    ((UltraControlBase) this.MgaTextBox12).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox12).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ugLocations).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugLocations).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugLocations).DataMember = "dtLocations";
    ((UltraGridBase) this.ugLocations).DataSource = (object) this.ds;
    appearance21.BackColor = Color.White;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Appearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.ugLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 106;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Address";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 190;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 8;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 165;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn5.Width = 71;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.Header.VisiblePosition = 6;
    ultraGridColumn6.Width = 49;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.Header.VisiblePosition = 4;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 114;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 9;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 8;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.Header.VisiblePosition = 10;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 64 /*0x40*/;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "# of Stories";
    ultraGridColumn11.Header.VisiblePosition = 9;
    ultraGridColumn11.Width = 94;
    ultraGridBand.Columns.AddRange(new object[11]
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
      (object) ultraGridColumn11
    });
    ((UltraGridBase) this.ugLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugLocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance22.BackColor = Color.LightSteelBlue;
    appearance22.FontData.SizeInPoints = 10f;
    appearance22.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocations).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance22;
    appearance23.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance23.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance24.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance24;
    appearance25.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance26.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance26;
    appearance27.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance28.BackColor = Color.Transparent;
    appearance28.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance28;
    appearance29.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance29;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugLocations).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugLocations).Location = new Point(12, 12);
    ((Control) this.ugLocations).Name = "ugLocations";
    ((Control) this.ugLocations).Size = new Size(677, 195);
    ((Control) this.ugLocations).TabIndex = 2;
    ((Control) this.ugLocations).Text = "Locations";
    ((UltraControlBase) this.ugLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugLocations).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompareInspect";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(701, 678);
    this.Controls.Add((Control) this.MgaTextBox11);
    this.Controls.Add((Control) this.MgaTextBox12);
    this.Controls.Add((Control) label12);
    this.Controls.Add((Control) this.MgaTextBox9);
    this.Controls.Add((Control) this.MgaTextBox10);
    this.Controls.Add((Control) label11);
    this.Controls.Add((Control) this.MgaTextBox7);
    this.Controls.Add((Control) this.MgaTextBox8);
    this.Controls.Add((Control) label10);
    this.Controls.Add((Control) this.txtRoofAge2);
    this.Controls.Add((Control) this.txtRoofAge1);
    this.Controls.Add((Control) label9);
    this.Controls.Add((Control) this.MgaTextBox3);
    this.Controls.Add((Control) this.MgaTextBox4);
    this.Controls.Add((Control) label8);
    this.Controls.Add((Control) this.MgaTextBox1);
    this.Controls.Add((Control) this.MgaTextBox2);
    this.Controls.Add((Control) label7);
    this.Controls.Add((Control) label6);
    this.Controls.Add((Control) label5);
    this.Controls.Add((Control) this.lstInspExposure);
    this.Controls.Add((Control) this.lstIMSExposure);
    this.Controls.Add((Control) this.txtConstruction2);
    this.Controls.Add((Control) this.txtConstruction1);
    this.Controls.Add((Control) label4);
    this.Controls.Add((Control) this.txtStories2);
    this.Controls.Add((Control) this.txtStories1);
    this.Controls.Add((Control) label3);
    this.Controls.Add((Control) this.txtBuilt2);
    this.Controls.Add((Control) this.txtBuilt1);
    this.Controls.Add((Control) label2);
    this.Controls.Add((Control) this.txtSqFoot2);
    this.Controls.Add((Control) this.txtSqFoot1);
    this.Controls.Add((Control) label1);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.ugLocations);
    this.Name = nameof (FormInspectionComparison);
    this.Text = "Inspection Comparison";
    ((ISupportInitialize) this.txtSqFoot2).EndInit();
    ((ISupportInitialize) this.txtSqFoot1).EndInit();
    ((ISupportInitialize) this.txtBuilt2).EndInit();
    ((ISupportInitialize) this.txtBuilt1).EndInit();
    ((ISupportInitialize) this.txtStories2).EndInit();
    ((ISupportInitialize) this.txtStories1).EndInit();
    ((ISupportInitialize) this.txtConstruction2).EndInit();
    ((ISupportInitialize) this.txtConstruction1).EndInit();
    ((ISupportInitialize) this.lstIMSExposure).EndInit();
    ((ISupportInitialize) this.lstInspExposure).EndInit();
    ((ISupportInitialize) this.MgaTextBox1).EndInit();
    ((ISupportInitialize) this.MgaTextBox2).EndInit();
    ((ISupportInitialize) this.MgaTextBox3).EndInit();
    ((ISupportInitialize) this.MgaTextBox4).EndInit();
    ((ISupportInitialize) this.txtRoofAge2).EndInit();
    ((ISupportInitialize) this.txtRoofAge1).EndInit();
    ((ISupportInitialize) this.MgaTextBox7).EndInit();
    ((ISupportInitialize) this.MgaTextBox8).EndInit();
    ((ISupportInitialize) this.MgaTextBox9).EndInit();
    ((ISupportInitialize) this.MgaTextBox10).EndInit();
    ((ISupportInitialize) this.MgaTextBox11).EndInit();
    ((ISupportInitialize) this.MgaTextBox12).EndInit();
    ((ISupportInitialize) this.ugLocations).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSqFoot2")]
  private virtual MGATextBox txtSqFoot2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSqFoot1")]
  private virtual MGATextBox txtSqFoot1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBuilt2")]
  protected virtual MGATextBox txtBuilt2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBuilt1")]
  protected virtual MGATextBox txtBuilt1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtStories2")]
  private virtual MGATextBox txtStories2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtStories1")]
  private virtual MGATextBox txtStories1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtConstruction2")]
  private virtual MGATextBox txtConstruction2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtConstruction1")]
  private virtual MGATextBox txtConstruction1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCompareInspect ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lstIMSExposure")]
  private virtual MGAListBox lstIMSExposure { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lstInspExposure")]
  private virtual MGAListBox lstInspExposure { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid ugLocations
  {
    get => this._ugLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugLocations_AfterRowActivate);
      UltraGrid ugLocations1 = this._ugLocations;
      if (ugLocations1 != null)
        ugLocations1.AfterRowActivate -= eventHandler;
      this._ugLocations = value;
      UltraGrid ugLocations2 = this._ugLocations;
      if (ugLocations2 == null)
        return;
      ugLocations2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("MgaTextBox1")]
  private virtual MGATextBox MgaTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox2")]
  private virtual MGATextBox MgaTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox3")]
  private virtual MGATextBox MgaTextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox4")]
  private virtual MGATextBox MgaTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRoofAge2")]
  private virtual MGATextBox txtRoofAge2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRoofAge1")]
  private virtual MGATextBox txtRoofAge1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox7")]
  private virtual MGATextBox MgaTextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox8")]
  private virtual MGATextBox MgaTextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox9")]
  private virtual MGATextBox MgaTextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox10")]
  private virtual MGATextBox MgaTextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox11")]
  private virtual MGATextBox MgaTextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox12")]
  private virtual MGATextBox MgaTextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormInspectionComparison(Quote quote)
  {
    this.Load += new EventHandler(this.FormInspectionComparison_Load);
    this.InitializeComponent();
    this._q = quote;
  }

  private void FormInspectionComparison_Load(object sender, EventArgs e)
  {
    object obj = (object) null;
    if (this._q.UsingNetRate)
      obj = (object) this._q.LineGuid;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblNetRateInspectionInfo"
    }, CommandType.Text, "SELECT DISTINCT LocationID, PremesisID, ExposureID, QuoteID FROM tblNetRateInspectionInfo WITH (NOLOCK) WHERE ControlNo = @CN", new object[2]
    {
      (object) "@CN",
      (object) this._q.ControlNo
    });
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblInspectionsData"
    }, CommandType.Text, "SELECT CustTraceID, YearBuilt, RoofCover, ElectricalDate, RoofDate, HeatingDate, PlumbingDate FROM tblInspectionsData WITH (NOLOCK)");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstConstructionTypes"
    }, CommandType.Text, "SELECT ConstructionTypeID, Type FROM lstConstructionTypes ORDER BY Type");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dtLocations"
    }, "dbo.spCompareImsAndInspLocations", new object[4]
    {
      (object) "@quoteID",
      (object) this._q.QuoteID,
      (object) "@lineGuid",
      obj
    });
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblUnderwritingLocations"
    }, CommandType.Text, "SELECT LocationID, RoofingYear, Stories FROM tblUnderwritingLocations WITH (NOLOCK) WHERE QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) this._q.QuoteGuid
    });
  }

  private void NullifyValues()
  {
    try
    {
      foreach (Control control in this.Controls)
      {
        if (control is MGATextBox mgaTextBox)
          ((TextEditorControlBase) mgaTextBox).Text = string.Empty;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void FillLocation(int locationID)
  {
    if (this.ds.dtLocations.Select("LocationID = " + Conversions.ToString(locationID)).Length == 0)
      return;
    dsCompareInspect.dtLocationsRow dtLocationsRow = (dsCompareInspect.dtLocationsRow) this.ds.dtLocations.Select("LocationID = " + Conversions.ToString(locationID))[0];
    if (!dtLocationsRow.IsConstructionNull())
    {
      if (Versioned.IsNumeric((object) dtLocationsRow.Construction))
        ((TextEditorControlBase) this.txtConstruction1).Text = this.ds.lstConstructionTypes.FindByConstructionTypeID(Conversions.ToByte(dtLocationsRow.Construction)).Type;
      else
        ((TextEditorControlBase) this.txtConstruction1).Text = dtLocationsRow.Construction;
    }
    if (!dtLocationsRow.IsSqFootageNull())
      ((TextEditorControlBase) this.txtSqFoot1).Text = dtLocationsRow.SqFootage;
    if (!dtLocationsRow.IsYearBuiltNull())
      ((TextEditorControlBase) this.txtBuilt1).Text = dtLocationsRow.YearBuilt;
    if (dtLocationsRow.IsNumberOfStoriesNull())
      return;
    ((TextEditorControlBase) this.txtStories1).Text = dtLocationsRow.NumberOfStories;
  }

  private void ugLocations_AfterRowActivate(object sender, EventArgs e)
  {
    this.NullifyValues();
    if (((UltraGridBase) this.ugLocations).ActiveRow == null)
      return;
    int integer = Conversions.ToInteger(((UltraGridBase) this.ugLocations).ActiveRow.Cells["LocationID"].Value);
    this.FillLocation(integer);
    if (this.ds.tblNetRateInspectionInfo.Select("LocationID = " + Conversions.ToString(integer)).Length > 0)
    {
      dsCompareInspect.tblNetRateInspectionInfoRow inspectionInfoRow = (dsCompareInspect.tblNetRateInspectionInfoRow) this.ds.tblNetRateInspectionInfo.Select("LocationID = " + Conversions.ToString(integer))[0];
      if ((!inspectionInfoRow.IsExposureIDNull() || inspectionInfoRow.IsPremesisIDNull()) && !inspectionInfoRow.IsExposureIDNull())
        inspectionInfoRow.IsPremesisIDNull();
    }
    this.FillInspData(integer);
    dsCompareInspect.tblUnderwritingLocationsRow byLocationId = this.ds.tblUnderwritingLocations.FindByLocationID(integer);
    if (byLocationId == null)
      return;
    if (!byLocationId.IsRoofingYearNull())
      ((TextEditorControlBase) this.txtRoofAge1).Text = byLocationId.RoofingYear.ToString();
    if (byLocationId.IsStoriesNull())
      return;
    ((TextEditorControlBase) this.txtStories1).Text = byLocationId.Stories.ToString();
  }

  private void FillInspData(int locationID)
  {
    if (this.ds.tblInspectionsData.Select("CustTraceID =" + Conversions.ToString(locationID)).Length == 0)
      return;
    dsCompareInspect.tblInspectionsDataRow inspectionsDataRow = (dsCompareInspect.tblInspectionsDataRow) this.ds.tblInspectionsData.Select("CustTraceID =" + Conversions.ToString(locationID))[0];
    if (!inspectionsDataRow.IsYearBuiltNull())
      ((TextEditorControlBase) this.txtBuilt2).Text = inspectionsDataRow.YearBuilt.ToString();
    if (inspectionsDataRow.IsRoofDateNull())
      return;
    ((TextEditorControlBase) this.txtRoofAge2).Text = inspectionsDataRow.RoofDate.ToString();
  }
}
