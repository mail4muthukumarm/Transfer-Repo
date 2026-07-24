// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.FormTaskAdmin
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Tools;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class FormTaskAdmin : Form
{
  private IContainer components;

  public FormTaskAdmin() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("MgaGroupBox1")]
  internal virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grdTasks")]
  internal virtual MGAGrid grdTasks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (FormTaskAdmin));
    this.MgaGroupBox1 = new MGAGroupBox();
    this.grdTasks = new MGAGrid();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.grdTasks).BeginInit();
    this.SuspendLayout();
    ((Control) this.MgaGroupBox1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.Appearance = (AppearanceBase) appearance1;
    this.MgaGroupBox1.BackColor = Color.FromArgb(239, 247, 253);
    appearance2.BackColor = Color.FromArgb(239, 247, 253);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.grdTasks);
    appearance3.AlphaLevel = (short) 230;
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.ForeColor = Color.White;
    appearance3.ImageAlpha = (Alpha) 2;
    appearance3.ImageBackground = (Image) resourceManager.GetObject("Appearance3.ImageBackground");
    appearance3.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.MgaGroupBox1).Location = new Point(8, 8);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(720, 456);
    this.MgaGroupBox1.SupportThemes = false;
    ((Control) this.MgaGroupBox1).TabIndex = 0;
    this.MgaGroupBox1.Text = "Tasks";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.grdTasks).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.grdTasks).Location = new Point(8, 32 /*0x20*/);
    ((Control) this.grdTasks).Name = "grdTasks";
    ((Control) this.grdTasks).Size = new Size(704, 408);
    ((Control) this.grdTasks).TabIndex = 0;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(736, 590);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (FormTaskAdmin);
    this.Text = "Task Administrator";
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.grdTasks).EndInit();
    this.ResumeLayout(false);
  }
}
