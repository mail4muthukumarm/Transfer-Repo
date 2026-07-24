// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ErrorHandling.frmShowDatasetError
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.ErrorHandling;

public sealed class frmShowDatasetError : Form
{
  private IContainer components;
  private ListView ListView1;
  private ColumnHeader colTable;
  private ColumnHeader colError;
  private PictureBox PictureBox1;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private DataSet _ds;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (frmShowDatasetError));
    this.ListView1 = new ListView();
    this.colTable = new ColumnHeader();
    this.colError = new ColumnHeader();
    this.PictureBox1 = new PictureBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.SuspendLayout();
    this.ListView1.BackColor = Color.White;
    this.ListView1.BorderStyle = BorderStyle.FixedSingle;
    this.ListView1.Columns.AddRange(new ColumnHeader[2]
    {
      this.colTable,
      this.colError
    });
    this.ListView1.Dock = DockStyle.Bottom;
    this.ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
    this.ListView1.Location = new Point(0, 101);
    this.ListView1.MultiSelect = false;
    this.ListView1.Name = "ListView1";
    this.ListView1.Size = new Size(616, 136);
    this.ListView1.TabIndex = 0;
    this.ListView1.View = View.Details;
    this.colTable.Text = "Table";
    this.colTable.Width = 230;
    this.colError.Text = "Error";
    this.colError.Width = 381;
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(8, 8);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(96 /*0x60*/, 88);
    this.PictureBox1.TabIndex = 2;
    this.PictureBox1.TabStop = false;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 15f);
    this.Label1.Location = new Point(112 /*0x70*/, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(211, 28);
    this.Label1.TabIndex = 3;
    this.Label1.Text = "An Error Has Occurred";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(112 /*0x70*/, 40);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(223, 17);
    this.Label2.TabIndex = 4;
    this.Label2.Text = "The IMS has encountered unexpected data.";
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(112 /*0x70*/, 64 /*0x40*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(381, 17);
    this.Label3.TabIndex = 5;
    this.Label3.Text = "The following information will help technical support diagnose the problem:";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(616, 237);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) this.ListView1);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (frmShowDatasetError);
    this.Text = "Dataset Error Viewer";
    this.ResumeLayout(false);
  }

  public frmShowDatasetError(DataSet ds)
  {
    this.Load += new EventHandler(this.frmShowDatasetError_Load);
    this.InitializeComponent();
    this._ds = ds;
  }

  private void frmShowDatasetError_Load(object sender, EventArgs e)
  {
    try
    {
      foreach (DataTable table in (InternalDataCollectionBase) this._ds.Tables)
      {
        if (table.HasErrors)
        {
          DataRow[] errors = table.GetErrors();
          int index = 0;
          while (index < errors.Length)
          {
            DataRow dataRow = errors[index];
            this.ListView1.Items.Add(new ListViewItem()
            {
              Text = dataRow.Table.TableName,
              SubItems = {
                dataRow.RowError
              }
            });
            checked { ++index; }
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }
}
