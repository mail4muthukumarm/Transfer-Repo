// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.GeneralLiabilityDec_subB
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public sealed class GeneralLiabilityDec_subB : SectionReport
{
  public GeneralLiabilityDec_subB() => this.InitializeComponent();

  public GeneralLiabilityDec_subB(DataTable dt)
  {
    this.InitializeComponent();
    if (dt.Rows.Count < 1)
    {
      DataRow row = dt.NewRow();
      dt.Rows.Add(row);
    }
    this.DataSource = (object) dt;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (GeneralLiabilityDec_subB));
    this.Detail = new Detail();
    this.label76 = new Label();
    this.textBox3 = new TextBox();
    this.textBox1 = new TextBox();
    this.textBox2 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.textBox6 = new TextBox();
    this.textBox7 = new TextBox();
    this.textBox8 = new TextBox();
    this.GroupHeader1 = new GroupHeader();
    this.label7 = new Label();
    this.label73 = new Label();
    this.label2 = new Label();
    this.label1 = new Label();
    this.Label3 = new Label();
    this.label71 = new Label();
    this.label9 = new Label();
    this.label8 = new Label();
    this.label11 = new Label();
    this.label12 = new Label();
    this.label13 = new Label();
    this.label14 = new Label();
    this.label15 = new Label();
    this.label18 = new Label();
    this.label10 = new Label();
    this.label17 = new Label();
    this.label16 = new Label();
    this.label6 = new Label();
    this.label5 = new Label();
    this.label4 = new Label();
    this.GroupFooter1 = new GroupFooter();
    this.label70 = new Label();
    ((ISupportInitialize) this.label76).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this.textBox8).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.label73).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.label71).BeginInit();
    ((ISupportInitialize) this.label9).BeginInit();
    ((ISupportInitialize) this.label8).BeginInit();
    ((ISupportInitialize) this.label11).BeginInit();
    ((ISupportInitialize) this.label12).BeginInit();
    ((ISupportInitialize) this.label13).BeginInit();
    ((ISupportInitialize) this.label14).BeginInit();
    ((ISupportInitialize) this.label15).BeginInit();
    ((ISupportInitialize) this.label18).BeginInit();
    ((ISupportInitialize) this.label10).BeginInit();
    ((ISupportInitialize) this.label17).BeginInit();
    ((ISupportInitialize) this.label16).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label4).BeginInit();
    ((ISupportInitialize) this.label70).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnDirection = (ColumnDirection) 1;
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.label76,
      (ARControl) this.textBox3,
      (ARControl) this.textBox1,
      (ARControl) this.textBox2,
      (ARControl) this.textBox4,
      (ARControl) this.textBox5,
      (ARControl) this.textBox6,
      (ARControl) this.textBox7,
      (ARControl) this.textBox8
    });
    ((Section) this.Detail).Height = 0.1979167f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.label76).Border.BottomColor = Color.Black;
    ((ARControl) this.label76).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label76).Border.LeftColor = Color.Black;
    ((ARControl) this.label76).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label76).Border.RightColor = Color.Black;
    ((ARControl) this.label76).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label76).Border.TopColor = Color.Black;
    ((ARControl) this.label76).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label76).Height = 3f / 16f;
    this.label76.HyperLink = (string) null;
    ((ARControl) this.label76).Left = 0.0f;
    ((ARControl) this.label76).Name = "label76";
    this.label76.Style = "font-size: 11pt; font-family: Times New Roman; ";
    this.label76.Text = "        ";
    ((ARControl) this.label76).Top = 0.0f;
    ((ARControl) this.label76).Width = 7.75f;
    ((ARControl) this.textBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.RightColor = Color.Black;
    ((ARControl) this.textBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox3).Border.TopColor = Color.Black;
    ((ARControl) this.textBox3).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox3.CanGrow = false;
    ((ARControl) this.textBox3).DataField = "LocationNumber";
    ((ARControl) this.textBox3).Height = 3f / 16f;
    ((ARControl) this.textBox3).Left = 0.125f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.Style = "font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.textBox3.Text = (string) null;
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 13f / 16f;
    ((ARControl) this.textBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.RightColor = Color.Black;
    ((ARControl) this.textBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.TopColor = Color.Black;
    ((ARControl) this.textBox1).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox1.CanGrow = false;
    ((ARControl) this.textBox1).DataField = "ProdPremium";
    ((ARControl) this.textBox1).Height = 3f / 16f;
    ((ARControl) this.textBox1).Left = 113f / 16f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.Style = "font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.textBox1.Text = (string) null;
    ((ARControl) this.textBox1).Top = 0.0f;
    ((ARControl) this.textBox1).Width = 9f / 16f;
    ((ARControl) this.textBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.RightColor = Color.Black;
    ((ARControl) this.textBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox2).Border.TopColor = Color.Black;
    ((ARControl) this.textBox2).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox2.CanGrow = false;
    ((ARControl) this.textBox2).DataField = "Classification";
    ((ARControl) this.textBox2).Height = 3f / 16f;
    ((ARControl) this.textBox2).Left = 1.125f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.Style = "font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.textBox2.Text = (string) null;
    ((ARControl) this.textBox2).Top = 0.0f;
    ((ARControl) this.textBox2).Width = 21f / 16f;
    ((ARControl) this.textBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.RightColor = Color.Black;
    ((ARControl) this.textBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox4).Border.TopColor = Color.Black;
    ((ARControl) this.textBox4).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox4.CanGrow = false;
    ((ARControl) this.textBox4).DataField = "CodeNo";
    ((ARControl) this.textBox4).Height = 3f / 16f;
    ((ARControl) this.textBox4).Left = 41f / 16f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.Style = "font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.textBox4.Text = (string) null;
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 0.625f;
    ((ARControl) this.textBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.RightColor = Color.Black;
    ((ARControl) this.textBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox5).Border.TopColor = Color.Black;
    ((ARControl) this.textBox5).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox5.CanGrow = false;
    ((ARControl) this.textBox5).DataField = "PremiumBase";
    ((ARControl) this.textBox5).Height = 3f / 16f;
    ((ARControl) this.textBox5).Left = 3.375f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.Style = "font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.textBox5.Text = (string) null;
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 1f;
    ((ARControl) this.textBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.RightColor = Color.Black;
    ((ARControl) this.textBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox6).Border.TopColor = Color.Black;
    ((ARControl) this.textBox6).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox6.CanGrow = false;
    ((ARControl) this.textBox6).DataField = "PremRate";
    ((ARControl) this.textBox6).Height = 3f / 16f;
    ((ARControl) this.textBox6).Left = 71f / 16f;
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.Style = "font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.textBox6.Text = (string) null;
    ((ARControl) this.textBox6).Top = 0.0f;
    ((ARControl) this.textBox6).Width = 11f / 16f;
    ((ARControl) this.textBox7).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).Border.RightColor = Color.Black;
    ((ARControl) this.textBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox7).Border.TopColor = Color.Black;
    ((ARControl) this.textBox7).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox7.CanGrow = false;
    ((ARControl) this.textBox7).DataField = "ProdRate";
    ((ARControl) this.textBox7).Height = 3f / 16f;
    ((ARControl) this.textBox7).Left = 83f / 16f;
    ((ARControl) this.textBox7).Name = "textBox7";
    this.textBox7.Style = "font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.textBox7.Text = (string) null;
    ((ARControl) this.textBox7).Top = 0.0f;
    ((ARControl) this.textBox7).Width = 13f / 16f;
    ((ARControl) this.textBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.RightColor = Color.Black;
    ((ARControl) this.textBox8).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox8).Border.TopColor = Color.Black;
    ((ARControl) this.textBox8).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox8.CanGrow = false;
    ((ARControl) this.textBox8).DataField = "PremPremium";
    ((ARControl) this.textBox8).Height = 3f / 16f;
    ((ARControl) this.textBox8).Left = 97f / 16f;
    ((ARControl) this.textBox8).Name = "textBox8";
    this.textBox8.Style = "font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.textBox8.Text = (string) null;
    ((ARControl) this.textBox8).Top = 0.0f;
    ((ARControl) this.textBox8).Width = 13f / 16f;
    ((Section) this.GroupHeader1).Controls.AddRange(new ARControl[20]
    {
      (ARControl) this.label7,
      (ARControl) this.label73,
      (ARControl) this.label2,
      (ARControl) this.label1,
      (ARControl) this.Label3,
      (ARControl) this.label71,
      (ARControl) this.label9,
      (ARControl) this.label8,
      (ARControl) this.label11,
      (ARControl) this.label12,
      (ARControl) this.label13,
      (ARControl) this.label14,
      (ARControl) this.label15,
      (ARControl) this.label18,
      (ARControl) this.label10,
      (ARControl) this.label17,
      (ARControl) this.label16,
      (ARControl) this.label6,
      (ARControl) this.label5,
      (ARControl) this.label4
    });
    this.GroupHeader1.Height = 0.75f;
    ((Section) this.GroupHeader1).Name = "GroupHeader1";
    ((ARControl) this.label7).Border.BottomColor = Color.Black;
    ((ARControl) this.label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Border.LeftColor = Color.Black;
    ((ARControl) this.label7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label7).Border.RightColor = Color.Black;
    ((ARControl) this.label7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label7).Border.TopColor = Color.Black;
    ((ARControl) this.label7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Height = 0.375f;
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Left = 0.0f;
    ((ARControl) this.label7).Name = "label7";
    this.label7.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label7.Text = "NUMBER";
    ((ARControl) this.label7).Top = 0.375f;
    ((ARControl) this.label7).Width = 15f / 16f;
    ((ARControl) this.label73).Border.BottomColor = Color.Black;
    ((ARControl) this.label73).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label73).Border.LeftColor = Color.Black;
    ((ARControl) this.label73).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label73).Border.RightColor = Color.Black;
    ((ARControl) this.label73).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label73).Border.TopColor = Color.Black;
    ((ARControl) this.label73).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label73).Height = 3f / 16f;
    this.label73.HyperLink = (string) null;
    ((ARControl) this.label73).Left = 0.0f;
    ((ARControl) this.label73).Name = "label73";
    this.label73.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label73.Text = "CLASSIFICATION AND PREMIUM";
    ((ARControl) this.label73).Top = 0.0f;
    ((ARControl) this.label73).Width = 7.75f;
    ((ARControl) this.label2).Border.BottomColor = Color.Black;
    ((ARControl) this.label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label2).Border.LeftColor = Color.Black;
    ((ARControl) this.label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label2).Border.RightColor = Color.Black;
    ((ARControl) this.label2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label2).Border.TopColor = Color.Black;
    ((ARControl) this.label2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label2).Height = 3f / 16f;
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Left = 39f / 16f;
    ((ARControl) this.label2).Name = "label2";
    this.label2.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label2.Text = "CODE";
    ((ARControl) this.label2).Top = 3f / 16f;
    ((ARControl) this.label2).Width = 0.75f;
    ((ARControl) this.label1).Border.BottomColor = Color.Black;
    ((ARControl) this.label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.LeftColor = Color.Black;
    ((ARControl) this.label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.RightColor = Color.Black;
    ((ARControl) this.label1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label1).Border.TopColor = Color.Black;
    ((ARControl) this.label1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label1).Height = 3f / 16f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 1f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label1.Text = "CLASSIFICATION";
    ((ARControl) this.label1).Top = 3f / 16f;
    ((ARControl) this.label1).Width = 23f / 16f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 0.0f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.Label3.Text = "LOCATION";
    ((ARControl) this.Label3).Top = 3f / 16f;
    ((ARControl) this.Label3).Width = 15f / 16f;
    ((ARControl) this.label71).Border.BottomColor = Color.Black;
    ((ARControl) this.label71).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label71).Border.LeftColor = Color.Black;
    ((ARControl) this.label71).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label71).Border.RightColor = Color.Black;
    ((ARControl) this.label71).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label71).Border.TopColor = Color.Black;
    ((ARControl) this.label71).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label71).Height = 3f / 16f;
    this.label71.HyperLink = (string) null;
    ((ARControl) this.label71).Left = 0.0f;
    ((ARControl) this.label71).Name = "label71";
    this.label71.Style = "font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label71.Text = "";
    ((ARControl) this.label71).Top = 9f / 16f;
    ((ARControl) this.label71).Width = 7.75f;
    ((ARControl) this.label9).Border.BottomColor = Color.Black;
    ((ARControl) this.label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label9).Border.LeftColor = Color.Black;
    ((ARControl) this.label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label9).Border.RightColor = Color.Black;
    ((ARControl) this.label9).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label9).Border.TopColor = Color.Black;
    ((ARControl) this.label9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label9).Height = 0.375f;
    this.label9.HyperLink = (string) null;
    ((ARControl) this.label9).Left = 39f / 16f;
    ((ARControl) this.label9).Name = "label9";
    this.label9.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label9.Text = "NO.";
    ((ARControl) this.label9).Top = 0.375f;
    ((ARControl) this.label9).Width = 0.75f;
    ((ARControl) this.label8).Border.BottomColor = Color.Black;
    ((ARControl) this.label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Border.LeftColor = Color.Black;
    ((ARControl) this.label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Border.RightColor = Color.Black;
    ((ARControl) this.label8).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label8).Border.TopColor = Color.Black;
    ((ARControl) this.label8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Height = 0.375f;
    this.label8.HyperLink = (string) null;
    ((ARControl) this.label8).Left = 1f;
    ((ARControl) this.label8).Name = "label8";
    this.label8.Style = "text-align: center; font-weight: normal; font-size: 11pt; font-family: Times New Roman; ";
    this.label8.Text = "";
    ((ARControl) this.label8).Top = 0.375f;
    ((ARControl) this.label8).Width = 23f / 16f;
    ((ARControl) this.label11).Border.BottomColor = Color.Black;
    ((ARControl) this.label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label11).Border.LeftColor = Color.Black;
    ((ARControl) this.label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label11).Border.RightColor = Color.Black;
    ((ARControl) this.label11).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label11).Border.TopColor = Color.Black;
    ((ARControl) this.label11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label11).Height = 3f / 16f;
    this.label11.HyperLink = (string) null;
    ((ARControl) this.label11).Left = 4.375f;
    ((ARControl) this.label11).Name = "label11";
    this.label11.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label11.Text = "Prem/";
    ((ARControl) this.label11).Top = 0.375f;
    ((ARControl) this.label11).Width = 0.75f;
    ((ARControl) this.label12).Border.BottomColor = Color.Black;
    ((ARControl) this.label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label12).Border.LeftColor = Color.Black;
    ((ARControl) this.label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label12).Border.RightColor = Color.Black;
    ((ARControl) this.label12).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label12).Border.TopColor = Color.Black;
    ((ARControl) this.label12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label12).Height = 3f / 16f;
    this.label12.HyperLink = (string) null;
    ((ARControl) this.label12).Left = 4.375f;
    ((ARControl) this.label12).Name = "label12";
    this.label12.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label12.Text = "Ops";
    ((ARControl) this.label12).Top = 9f / 16f;
    ((ARControl) this.label12).Width = 0.75f;
    ((ARControl) this.label13).Border.BottomColor = Color.Black;
    ((ARControl) this.label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label13).Border.LeftColor = Color.Black;
    ((ARControl) this.label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label13).Border.RightColor = Color.Black;
    ((ARControl) this.label13).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label13).Border.TopColor = Color.Black;
    ((ARControl) this.label13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label13).Height = 3f / 16f;
    this.label13.HyperLink = (string) null;
    ((ARControl) this.label13).Left = 83f / 16f;
    ((ARControl) this.label13).Name = "label13";
    this.label13.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label13.Text = "Prod/Comp";
    ((ARControl) this.label13).Top = 0.375f;
    ((ARControl) this.label13).Width = 13f / 16f;
    ((ARControl) this.label14).Border.BottomColor = Color.Black;
    ((ARControl) this.label14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label14).Border.LeftColor = Color.Black;
    ((ARControl) this.label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label14).Border.RightColor = Color.Black;
    ((ARControl) this.label14).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label14).Border.TopColor = Color.Black;
    ((ARControl) this.label14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label14).Height = 3f / 16f;
    this.label14.HyperLink = (string) null;
    ((ARControl) this.label14).Left = 5.25f;
    ((ARControl) this.label14).Name = "label14";
    this.label14.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label14.Text = "Ops";
    ((ARControl) this.label14).Top = 9f / 16f;
    ((ARControl) this.label14).Width = 0.75f;
    ((ARControl) this.label15).Border.BottomColor = Color.Black;
    ((ARControl) this.label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label15).Border.LeftColor = Color.Black;
    ((ARControl) this.label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label15).Border.RightColor = Color.Black;
    ((ARControl) this.label15).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label15).Border.TopColor = Color.Black;
    ((ARControl) this.label15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label15).Height = 3f / 16f;
    this.label15.HyperLink = (string) null;
    ((ARControl) this.label15).Left = 7f;
    ((ARControl) this.label15).Name = "label15";
    this.label15.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label15.Text = "Ops";
    ((ARControl) this.label15).Top = 9f / 16f;
    ((ARControl) this.label15).Width = 0.75f;
    ((ARControl) this.label18).Border.BottomColor = Color.Black;
    ((ARControl) this.label18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label18).Border.LeftColor = Color.Black;
    ((ARControl) this.label18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label18).Border.RightColor = Color.Black;
    ((ARControl) this.label18).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label18).Border.TopColor = Color.Black;
    ((ARControl) this.label18).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label18).Height = 3f / 16f;
    this.label18.HyperLink = (string) null;
    ((ARControl) this.label18).Left = 6.125f;
    ((ARControl) this.label18).Name = "label18";
    this.label18.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label18.Text = "Ops";
    ((ARControl) this.label18).Top = 9f / 16f;
    ((ARControl) this.label18).Width = 0.75f;
    ((ARControl) this.label10).Border.BottomColor = Color.Black;
    ((ARControl) this.label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label10).Border.LeftColor = Color.Black;
    ((ARControl) this.label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label10).Border.RightColor = Color.Black;
    ((ARControl) this.label10).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label10).Border.TopColor = Color.Black;
    ((ARControl) this.label10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label10).Height = 0.375f;
    this.label10.HyperLink = (string) null;
    ((ARControl) this.label10).Left = 3.25f;
    ((ARControl) this.label10).Name = "label10";
    this.label10.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label10.Text = "BASE";
    ((ARControl) this.label10).Top = 0.375f;
    ((ARControl) this.label10).Width = 1.125f;
    ((ARControl) this.label17).Border.BottomColor = Color.Black;
    ((ARControl) this.label17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label17).Border.LeftColor = Color.Black;
    ((ARControl) this.label17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label17).Border.RightColor = Color.Black;
    ((ARControl) this.label17).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label17).Border.TopColor = Color.Black;
    ((ARControl) this.label17).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label17).Height = 3f / 16f;
    this.label17.HyperLink = (string) null;
    ((ARControl) this.label17).Left = 6.875f;
    ((ARControl) this.label17).Name = "label17";
    this.label17.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label17.Text = "Prod/Comp";
    ((ARControl) this.label17).Top = 0.375f;
    ((ARControl) this.label17).Width = 0.875f;
    ((ARControl) this.label16).Border.BottomColor = Color.Black;
    ((ARControl) this.label16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label16).Border.LeftColor = Color.Black;
    ((ARControl) this.label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label16).Border.RightColor = Color.Black;
    ((ARControl) this.label16).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label16).Border.TopColor = Color.Black;
    ((ARControl) this.label16).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label16).Height = 3f / 16f;
    this.label16.HyperLink = (string) null;
    ((ARControl) this.label16).Left = 6.125f;
    ((ARControl) this.label16).Name = "label16";
    this.label16.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label16.Text = "Prem/";
    ((ARControl) this.label16).Top = 0.375f;
    ((ARControl) this.label16).Width = 0.75f;
    ((ARControl) this.label6).Border.BottomColor = Color.Black;
    ((ARControl) this.label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label6).Border.LeftColor = Color.Black;
    ((ARControl) this.label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Border.RightColor = Color.Black;
    ((ARControl) this.label6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label6).Border.TopColor = Color.Black;
    ((ARControl) this.label6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label6).Height = 3f / 16f;
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Left = 6f;
    ((ARControl) this.label6).Name = "label6";
    this.label6.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label6.Text = "ADVANCE PREMIUM";
    ((ARControl) this.label6).Top = 3f / 16f;
    ((ARControl) this.label6).Width = 1.75f;
    ((ARControl) this.label5).Border.BottomColor = Color.Black;
    ((ARControl) this.label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label5).Border.LeftColor = Color.Black;
    ((ARControl) this.label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.RightColor = Color.Black;
    ((ARControl) this.label5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label5).Border.TopColor = Color.Black;
    ((ARControl) this.label5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label5).Height = 3f / 16f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 4.375f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label5.Text = "RATE";
    ((ARControl) this.label5).Top = 3f / 16f;
    ((ARControl) this.label5).Width = 1.625f;
    ((ARControl) this.label4).Border.BottomColor = Color.Black;
    ((ARControl) this.label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Border.LeftColor = Color.Black;
    ((ARControl) this.label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Border.RightColor = Color.Black;
    ((ARControl) this.label4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label4).Border.TopColor = Color.Black;
    ((ARControl) this.label4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label4).Height = 3f / 16f;
    this.label4.HyperLink = (string) null;
    ((ARControl) this.label4).Left = 3.25f;
    ((ARControl) this.label4).Name = "label4";
    this.label4.Style = "text-align: center; font-weight: bold; font-size: 11pt; font-family: Times New Roman; ";
    this.label4.Text = "PREMIUM";
    ((ARControl) this.label4).Top = 3f / 16f;
    ((ARControl) this.label4).Width = 1.125f;
    ((Section) this.GroupFooter1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.label70
    });
    this.GroupFooter1.Height = 1f / 32f;
    ((Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.label70).Border.BottomColor = Color.Black;
    ((ARControl) this.label70).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label70).Border.LeftColor = Color.Black;
    ((ARControl) this.label70).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label70).Border.RightColor = Color.Black;
    ((ARControl) this.label70).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label70).Border.TopColor = Color.Black;
    ((ARControl) this.label70).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label70).Height = 0.01f;
    this.label70.HyperLink = (string) null;
    ((ARControl) this.label70).Left = 0.0f;
    ((ARControl) this.label70).Name = "label70";
    this.label70.Style = "text-align: left; font-size: 11pt; font-family: Times New Roman; ";
    this.label70.Text = "";
    ((ARControl) this.label70).Top = 0.0f;
    ((ARControl) this.label70).Width = 7.75f;
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((Section) this.GroupHeader1);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.GroupFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.label76).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this.textBox8).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.label73).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.label71).EndInit();
    ((ISupportInitialize) this.label9).EndInit();
    ((ISupportInitialize) this.label8).EndInit();
    ((ISupportInitialize) this.label11).EndInit();
    ((ISupportInitialize) this.label12).EndInit();
    ((ISupportInitialize) this.label13).EndInit();
    ((ISupportInitialize) this.label14).EndInit();
    ((ISupportInitialize) this.label15).EndInit();
    ((ISupportInitialize) this.label18).EndInit();
    ((ISupportInitialize) this.label10).EndInit();
    ((ISupportInitialize) this.label17).EndInit();
    ((ISupportInitialize) this.label16).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label4).EndInit();
    ((ISupportInitialize) this.label70).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void GroupHeader1_Format(object sender, EventArgs e)
  {
  }

  internal virtual GroupHeader GroupHeader1
  {
    get => this._GroupHeader1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.GroupHeader1_Format);
      GroupHeader groupHeader1_1 = this._GroupHeader1;
      if (groupHeader1_1 != null)
        ((Section) groupHeader1_1).Format -= eventHandler;
      this._GroupHeader1 = value;
      GroupHeader groupHeader1_2 = this._GroupHeader1;
      if (groupHeader1_2 == null)
        return;
      ((Section) groupHeader1_2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("textBox3")]
  private virtual TextBox textBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label76")]
  private virtual Label label76 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox1")]
  private virtual TextBox textBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox2")]
  private virtual TextBox textBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox4")]
  private virtual TextBox textBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox5")]
  private virtual TextBox textBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox6")]
  private virtual TextBox textBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox7")]
  private virtual TextBox textBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox8")]
  private virtual TextBox textBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label7")]
  private virtual Label label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label73")]
  private virtual Label label73 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label2")]
  private virtual Label label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label1")]
  private virtual Label label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label71")]
  private virtual Label label71 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label9")]
  private virtual Label label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label8")]
  private virtual Label label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label11")]
  private virtual Label label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label12")]
  private virtual Label label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label13")]
  private virtual Label label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label14")]
  private virtual Label label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label15")]
  private virtual Label label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label18")]
  private virtual Label label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label10")]
  private virtual Label label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label17")]
  private virtual Label label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label16")]
  private virtual Label label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label6")]
  private virtual Label label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label5")]
  private virtual Label label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label4")]
  private virtual Label label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label70")]
  private virtual Label label70 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  internal virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
