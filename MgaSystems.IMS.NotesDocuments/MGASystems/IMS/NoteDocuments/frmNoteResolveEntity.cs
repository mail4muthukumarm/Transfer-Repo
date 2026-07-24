// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmNoteResolveEntity
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win.Misc;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmNoteResolveEntity : Form
{
  private IContainer components;
  private Label Label1;
  private PictureBox PictureBox1;
  private Label Label2;
  private ImageList ImageList1;
  private DataRow _activeEntityRow;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual ListView ListView1
  {
    get => this._ListView1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ListView1_SelectedIndexChanged);
      ListView listView1_1 = this._ListView1;
      if (listView1_1 != null)
        listView1_1.SelectedIndexChanged -= eventHandler;
      this._ListView1 = value;
      ListView listView1_2 = this._ListView1;
      if (listView1_2 == null)
        return;
      listView1_2.SelectedIndexChanged += eventHandler;
    }
  }

  private virtual MGAButton btnOK
  {
    get => this._btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOK_Click);
      MGAButton btnOk1 = this._btnOK;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOK = value;
      MGAButton btnOk2 = this._btnOK;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ResourceManager resourceManager = new ResourceManager(typeof (frmNoteResolveEntity));
    ListViewItem listViewItem1 = new ListViewItem("Bob's Plumming", 0);
    ListViewItem listViewItem2 = new ListViewItem("Jill's Water Transport", 0);
    this.Label1 = new Label();
    this.PictureBox1 = new PictureBox();
    this.Label2 = new Label();
    this.ListView1 = new ListView();
    this.ImageList1 = new ImageList(this.components);
    this.btnOK = new MGAButton();
    ((ISupportInitialize) this.btnOK).BeginInit();
    this.SuspendLayout();
    this.Label1.Location = new Point(88, 24);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(304, 64 /*0x40*/);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "More than one entity has been detected as being associated to this note. Please choose the entity you wish to mark as the active association for this note session.";
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(8, 8);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 1;
    this.PictureBox1.TabStop = false;
    this.Label2.BackColor = Color.LightSteelBlue;
    this.Label2.Location = new Point(88, 0);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(312, 24);
    this.Label2.TabIndex = 2;
    this.ListView1.BackColor = Color.White;
    this.ListView1.BorderStyle = BorderStyle.None;
    this.ListView1.ForeColor = Color.Black;
    this.ListView1.Items.AddRange(new ListViewItem[2]
    {
      listViewItem1,
      listViewItem2
    });
    this.ListView1.Location = new Point(88, 72);
    this.ListView1.Name = "ListView1";
    this.ListView1.Size = new Size(288, 64 /*0x40*/);
    this.ListView1.SmallImageList = this.ImageList1;
    this.ListView1.TabIndex = 3;
    this.ListView1.View = View.List;
    this.ImageList1.ImageSize = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    ((Control) this.btnOK).Enabled = false;
    ((Control) this.btnOK).Location = new Point(296, 144 /*0x90*/);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnOK).TabIndex = 4;
    ((ControlBase) this.btnOK).Text = "&OK";
    this.AcceptButton = (IButtonControl) this.btnOK;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(386, 184);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ListView1);
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (frmNoteResolveEntity);
    this.Text = "Active Entity Selection";
    ((ISupportInitialize) this.btnOK).EndInit();
    this.ResumeLayout(false);
  }

  public frmNoteResolveEntity()
  {
    this.InitializeComponent();
    this.ListView1.Clear();
  }

  public void AddEntity(DataRow row, string entityName)
  {
    this.ListView1.Items.Add(new ListViewItem(entityName, 0)
    {
      Tag = (object) row
    });
  }

  private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
  {
    ((Control) this.btnOK).Enabled = true;
    if (this.ListView1.SelectedItems.Count <= 0)
      return;
    this._activeEntityRow = (DataRow) this.ListView1.SelectedItems[0].Tag;
  }

  public DataRow ActiveEntityRow => this._activeEntityRow;

  private void btnOK_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.OK;
    this.Close();
  }
}
