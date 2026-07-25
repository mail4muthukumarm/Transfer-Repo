// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.AlphabetBar
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public class AlphabetBar : UserControl
{
  private IContainer components;
  private LinkLabel LinkLabel1;
  private LinkLabel LinkLabel2;
  private LinkLabel LinkLabel3;
  private LinkLabel LinkLabel4;
  private LinkLabel LinkLabel5;
  private LinkLabel LinkLabel6;
  private LinkLabel LinkLabel7;
  private LinkLabel LinkLabel8;
  private LinkLabel LinkLabel9;
  private LinkLabel LinkLabel10;
  private LinkLabel LinkLabel11;
  private LinkLabel LinkLabel12;
  private LinkLabel LinkLabel13;
  private LinkLabel LinkLabel14;
  private LinkLabel LinkLabel15;
  private LinkLabel LinkLabel16;
  private LinkLabel LinkLabel17;
  private LinkLabel LinkLabel18;
  private LinkLabel LinkLabel19;
  private LinkLabel LinkLabel20;
  private LinkLabel LinkLabel21;
  private LinkLabel LinkLabel22;
  private LinkLabel LinkLabel23;
  private LinkLabel LinkLabel24;
  private LinkLabel LinkLabel25;
  private LinkLabel LinkLabel26;

  public AlphabetBar()
  {
    this.Load += new EventHandler(this.AlphabetBar_Load);
    this.InitializeComponent();
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.LinkLabel1 = new LinkLabel();
    this.LinkLabel2 = new LinkLabel();
    this.LinkLabel3 = new LinkLabel();
    this.LinkLabel4 = new LinkLabel();
    this.LinkLabel5 = new LinkLabel();
    this.LinkLabel6 = new LinkLabel();
    this.LinkLabel7 = new LinkLabel();
    this.LinkLabel8 = new LinkLabel();
    this.LinkLabel9 = new LinkLabel();
    this.LinkLabel10 = new LinkLabel();
    this.LinkLabel11 = new LinkLabel();
    this.LinkLabel12 = new LinkLabel();
    this.LinkLabel13 = new LinkLabel();
    this.LinkLabel14 = new LinkLabel();
    this.LinkLabel15 = new LinkLabel();
    this.LinkLabel16 = new LinkLabel();
    this.LinkLabel17 = new LinkLabel();
    this.LinkLabel18 = new LinkLabel();
    this.LinkLabel19 = new LinkLabel();
    this.LinkLabel20 = new LinkLabel();
    this.LinkLabel21 = new LinkLabel();
    this.LinkLabel22 = new LinkLabel();
    this.LinkLabel23 = new LinkLabel();
    this.LinkLabel24 = new LinkLabel();
    this.LinkLabel25 = new LinkLabel();
    this.LinkLabel26 = new LinkLabel();
    this.SuspendLayout();
    this.LinkLabel1.Location = new Point(4, 0);
    this.LinkLabel1.Name = "LinkLabel1";
    this.LinkLabel1.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel1.TabIndex = 0;
    this.LinkLabel1.TabStop = true;
    this.LinkLabel1.Text = "A";
    this.LinkLabel2.Location = new Point(20, 0);
    this.LinkLabel2.Name = "LinkLabel2";
    this.LinkLabel2.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel2.TabIndex = 1;
    this.LinkLabel2.TabStop = true;
    this.LinkLabel2.Text = "B";
    this.LinkLabel3.Location = new Point(36, 0);
    this.LinkLabel3.Name = "LinkLabel3";
    this.LinkLabel3.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel3.TabIndex = 2;
    this.LinkLabel3.TabStop = true;
    this.LinkLabel3.Text = "C";
    this.LinkLabel4.Location = new Point(52, 0);
    this.LinkLabel4.Name = "LinkLabel4";
    this.LinkLabel4.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel4.TabIndex = 3;
    this.LinkLabel4.TabStop = true;
    this.LinkLabel4.Text = "D";
    this.LinkLabel5.Location = new Point(68, 0);
    this.LinkLabel5.Name = "LinkLabel5";
    this.LinkLabel5.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel5.TabIndex = 4;
    this.LinkLabel5.TabStop = true;
    this.LinkLabel5.Text = "E";
    this.LinkLabel6.Location = new Point(84, 0);
    this.LinkLabel6.Name = "LinkLabel6";
    this.LinkLabel6.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel6.TabIndex = 5;
    this.LinkLabel6.TabStop = true;
    this.LinkLabel6.Text = "F";
    this.LinkLabel7.Location = new Point(100, 0);
    this.LinkLabel7.Name = "LinkLabel7";
    this.LinkLabel7.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel7.TabIndex = 6;
    this.LinkLabel7.TabStop = true;
    this.LinkLabel7.Text = "G";
    this.LinkLabel8.Location = new Point(116, 0);
    this.LinkLabel8.Name = "LinkLabel8";
    this.LinkLabel8.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel8.TabIndex = 7;
    this.LinkLabel8.TabStop = true;
    this.LinkLabel8.Text = "H";
    this.LinkLabel9.Location = new Point(132, 0);
    this.LinkLabel9.Name = "LinkLabel9";
    this.LinkLabel9.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel9.TabIndex = 8;
    this.LinkLabel9.TabStop = true;
    this.LinkLabel9.Text = "I";
    this.LinkLabel10.Location = new Point(148, 0);
    this.LinkLabel10.Name = "LinkLabel10";
    this.LinkLabel10.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel10.TabIndex = 9;
    this.LinkLabel10.TabStop = true;
    this.LinkLabel10.Text = "J";
    this.LinkLabel11.Location = new Point(164, 0);
    this.LinkLabel11.Name = "LinkLabel11";
    this.LinkLabel11.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel11.TabIndex = 10;
    this.LinkLabel11.TabStop = true;
    this.LinkLabel11.Text = "K";
    this.LinkLabel12.Location = new Point(180, 0);
    this.LinkLabel12.Name = "LinkLabel12";
    this.LinkLabel12.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel12.TabIndex = 11;
    this.LinkLabel12.TabStop = true;
    this.LinkLabel12.Text = "L";
    this.LinkLabel13.Location = new Point(196, 0);
    this.LinkLabel13.Name = "LinkLabel13";
    this.LinkLabel13.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel13.TabIndex = 12;
    this.LinkLabel13.TabStop = true;
    this.LinkLabel13.Text = "M";
    this.LinkLabel14.Location = new Point(212, 0);
    this.LinkLabel14.Name = "LinkLabel14";
    this.LinkLabel14.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel14.TabIndex = 13;
    this.LinkLabel14.TabStop = true;
    this.LinkLabel14.Text = "N";
    this.LinkLabel15.Location = new Point(228, 0);
    this.LinkLabel15.Name = "LinkLabel15";
    this.LinkLabel15.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel15.TabIndex = 14;
    this.LinkLabel15.TabStop = true;
    this.LinkLabel15.Text = "O";
    this.LinkLabel16.Location = new Point(244, 0);
    this.LinkLabel16.Name = "LinkLabel16";
    this.LinkLabel16.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel16.TabIndex = 15;
    this.LinkLabel16.TabStop = true;
    this.LinkLabel16.Text = "P";
    this.LinkLabel17.Location = new Point(260, 0);
    this.LinkLabel17.Name = "LinkLabel17";
    this.LinkLabel17.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel17.TabIndex = 16 /*0x10*/;
    this.LinkLabel17.TabStop = true;
    this.LinkLabel17.Text = "Q";
    this.LinkLabel18.Location = new Point(276, 0);
    this.LinkLabel18.Name = "LinkLabel18";
    this.LinkLabel18.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel18.TabIndex = 17;
    this.LinkLabel18.TabStop = true;
    this.LinkLabel18.Text = "R";
    this.LinkLabel19.Location = new Point(292, 0);
    this.LinkLabel19.Name = "LinkLabel19";
    this.LinkLabel19.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel19.TabIndex = 18;
    this.LinkLabel19.TabStop = true;
    this.LinkLabel19.Text = "S";
    this.LinkLabel20.Location = new Point(308, 0);
    this.LinkLabel20.Name = "LinkLabel20";
    this.LinkLabel20.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel20.TabIndex = 19;
    this.LinkLabel20.TabStop = true;
    this.LinkLabel20.Text = "T";
    this.LinkLabel21.Location = new Point(324, 0);
    this.LinkLabel21.Name = "LinkLabel21";
    this.LinkLabel21.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel21.TabIndex = 20;
    this.LinkLabel21.TabStop = true;
    this.LinkLabel21.Text = "U";
    this.LinkLabel22.Location = new Point(340, 0);
    this.LinkLabel22.Name = "LinkLabel22";
    this.LinkLabel22.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel22.TabIndex = 21;
    this.LinkLabel22.TabStop = true;
    this.LinkLabel22.Text = "V";
    this.LinkLabel23.Location = new Point(356, 0);
    this.LinkLabel23.Name = "LinkLabel23";
    this.LinkLabel23.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel23.TabIndex = 22;
    this.LinkLabel23.TabStop = true;
    this.LinkLabel23.Text = "W";
    this.LinkLabel24.Location = new Point(372, 0);
    this.LinkLabel24.Name = "LinkLabel24";
    this.LinkLabel24.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel24.TabIndex = 23;
    this.LinkLabel24.TabStop = true;
    this.LinkLabel24.Text = "X";
    this.LinkLabel25.Location = new Point(388, 0);
    this.LinkLabel25.Name = "LinkLabel25";
    this.LinkLabel25.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel25.TabIndex = 24;
    this.LinkLabel25.TabStop = true;
    this.LinkLabel25.Text = "Y";
    this.LinkLabel26.Location = new Point(404, 0);
    this.LinkLabel26.Name = "LinkLabel26";
    this.LinkLabel26.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.LinkLabel26.TabIndex = 25;
    this.LinkLabel26.TabStop = true;
    this.LinkLabel26.Text = "Z";
    this.Controls.Add((Control) this.LinkLabel26);
    this.Controls.Add((Control) this.LinkLabel25);
    this.Controls.Add((Control) this.LinkLabel24);
    this.Controls.Add((Control) this.LinkLabel23);
    this.Controls.Add((Control) this.LinkLabel22);
    this.Controls.Add((Control) this.LinkLabel21);
    this.Controls.Add((Control) this.LinkLabel20);
    this.Controls.Add((Control) this.LinkLabel19);
    this.Controls.Add((Control) this.LinkLabel18);
    this.Controls.Add((Control) this.LinkLabel17);
    this.Controls.Add((Control) this.LinkLabel16);
    this.Controls.Add((Control) this.LinkLabel15);
    this.Controls.Add((Control) this.LinkLabel14);
    this.Controls.Add((Control) this.LinkLabel13);
    this.Controls.Add((Control) this.LinkLabel12);
    this.Controls.Add((Control) this.LinkLabel11);
    this.Controls.Add((Control) this.LinkLabel10);
    this.Controls.Add((Control) this.LinkLabel9);
    this.Controls.Add((Control) this.LinkLabel8);
    this.Controls.Add((Control) this.LinkLabel7);
    this.Controls.Add((Control) this.LinkLabel6);
    this.Controls.Add((Control) this.LinkLabel5);
    this.Controls.Add((Control) this.LinkLabel4);
    this.Controls.Add((Control) this.LinkLabel3);
    this.Controls.Add((Control) this.LinkLabel2);
    this.Controls.Add((Control) this.LinkLabel1);
    this.Name = nameof (AlphabetBar);
    this.Size = new Size(424, 16 /*0x10*/);
    this.ResumeLayout(false);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      try
      {
        foreach (Control control in this.Controls)
        {
          if (control is LinkLabel linkLabel)
            linkLabel.LinkClicked -= new LinkLabelLinkClickedEventHandler(this.LinkClicked);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (this.components != null)
        this.components.Dispose();
    }
    base.Dispose(disposing);
  }

  public event AlphabetBar.LetterClickedEventHandler LetterClicked;

  private void AlphabetBar_Load(object sender, EventArgs e)
  {
    try
    {
      foreach (Control control in this.Controls)
      {
        if (control is LinkLabel linkLabel)
          linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LinkClicked);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    AlphabetBar.LetterClickedEventHandler letterClickedEvent = this.LetterClickedEvent;
    if (letterClickedEvent == null)
      return;
    letterClickedEvent(RuntimeHelpers.GetObjectValue(sender), new LetterClickedEventArgs(((LinkLabel) sender).Text));
  }

  public delegate void LetterClickedEventHandler(object sender, LetterClickedEventArgs e);
}
