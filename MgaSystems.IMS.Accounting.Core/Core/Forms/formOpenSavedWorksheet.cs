// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formOpenSavedWorksheet
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class formOpenSavedWorksheet : AccountingNoteDocumentSupport
{
  private EllipsePanel panelListView;
  private ListView listViewSavedWorksheets;
  private EllipsePanel ellipsePanel1;
  private EllipsePanel ellipsePanel2;
  private System.ComponentModel.Container components;

  public formOpenSavedWorksheet() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.panelListView = new EllipsePanel();
    this.listViewSavedWorksheets = new ListView();
    this.ellipsePanel1 = new EllipsePanel();
    this.ellipsePanel2 = new EllipsePanel();
    this.panelListView.SuspendLayout();
    this.ellipsePanel1.SuspendLayout();
    this.SuspendLayout();
    this.panelListView.BackColor = Color.White;
    this.panelListView.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelListView.Controls.Add((Control) this.listViewSavedWorksheets);
    this.panelListView.CornerOffset = 1;
    this.panelListView.Location = new Point(8, 8);
    this.panelListView.Name = "panelListView";
    this.panelListView.Size = new Size(448, 216);
    this.panelListView.TabIndex = 0;
    this.listViewSavedWorksheets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.listViewSavedWorksheets.BorderStyle = BorderStyle.None;
    this.listViewSavedWorksheets.Location = new Point(8, 8);
    this.listViewSavedWorksheets.Name = "listViewSavedWorksheets";
    this.listViewSavedWorksheets.Size = new Size(433, 205);
    this.listViewSavedWorksheets.TabIndex = 0;
    this.ellipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel1.Controls.Add((Control) this.panelListView);
    this.ellipsePanel1.CornerOffset = 1;
    this.ellipsePanel1.Location = new Point(8, 8);
    this.ellipsePanel1.Name = "ellipsePanel1";
    this.ellipsePanel1.Size = new Size(464, 232);
    this.ellipsePanel1.TabIndex = 1;
    this.ellipsePanel2.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel2.CornerOffset = 1;
    this.ellipsePanel2.Location = new Point(8, 248);
    this.ellipsePanel2.Name = "ellipsePanel2";
    this.ellipsePanel2.Size = new Size(464, 56);
    this.ellipsePanel2.TabIndex = 2;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(480, 310);
    this.Controls.Add((Control) this.ellipsePanel2);
    this.Controls.Add((Control) this.ellipsePanel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (formOpenSavedWorksheet);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Saved Worksheets";
    this.panelListView.ResumeLayout(false);
    this.ellipsePanel1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
