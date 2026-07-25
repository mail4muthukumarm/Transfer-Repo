// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormPredominantContactClass
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

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
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormPredominantContactClass : Form
{
  private IContainer components;
  private readonly Guid _producerContactGuid;

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
    this.lstDominantContactClass = new MGACheckedListBox();
    this.ds = new dsPredominantClass();
    ((ISupportInitialize) this.lstDominantContactClass).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.lstDominantContactClass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstDominantContactClass.CheckOnClick = true;
    this.lstDominantContactClass.Location = new Point(12, 12);
    this.lstDominantContactClass.MGAStyle = MGAStyles.Blue;
    this.lstDominantContactClass.Name = "lstDominantContactClass";
    this.lstDominantContactClass.Size = new Size(401, 304);
    this.lstDominantContactClass.TabIndex = 13;
    this.ds.DataSetName = "dsPredominantClass";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(421, 340);
    this.Controls.Add((Control) this.lstDominantContactClass);
    this.Name = nameof (FormPredominantContactClass);
    this.Text = "Predominant Contact Class";
    ((ISupportInitialize) this.lstDominantContactClass).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  private virtual MGACheckedListBox lstDominantContactClass
  {
    get => this._lstDominantContactClass;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.lstDominantContactClass_ItemCheck);
      MGACheckedListBox dominantContactClass1 = this._lstDominantContactClass;
      if (dominantContactClass1 != null)
        dominantContactClass1.ItemCheck -= checkEventHandler;
      this._lstDominantContactClass = value;
      MGACheckedListBox dominantContactClass2 = this._lstDominantContactClass;
      if (dominantContactClass2 == null)
        return;
      dominantContactClass2.ItemCheck += checkEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsPredominantClass ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormPredominantContactClass(Guid producerContactGuid)
  {
    this.Load += new EventHandler(this.FormPredominantContactClass_Load);
    this.InitializeComponent();
    this._producerContactGuid = producerContactGuid;
  }

  private void FormPredominantContactClass_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstPredominantContactClass"
    }, CommandType.Text, "SELECT ClassID, Class FROM lstPredominantContactClass");
    this.lstDominantContactClass.DataSource = (object) this.ds.lstPredominantContactClass;
    this.lstDominantContactClass.DisplayMember = this.ds.lstPredominantContactClass.ClassColumn.ColumnName;
    this.lstDominantContactClass.ValueMember = this.ds.lstPredominantContactClass.ClassIDColumn.ColumnName;
    this.LoadClasses();
    this.FillClassesListbox();
  }

  private void LoadClasses()
  {
    this.ds.tblPredominantContactClass.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblPredominantContactClass"
    }, CommandType.Text, "SELECT ClassID FROM tblPredominantContactClass WHERE ProducerContactGUID = @CG", new object[2]
    {
      (object) "@CG",
      (object) this._producerContactGuid
    });
  }

  private void FillClassesListbox()
  {
    this.lstDominantContactClass.ItemCheck -= new ItemCheckEventHandler(this.lstDominantContactClass_ItemCheck);
    int num1 = this.lstDominantContactClass.Items.Count - 1;
    for (int index = 0; index <= num1; ++index)
      this.lstDominantContactClass.SetItemChecked(index, false);
    try
    {
      foreach (dsPredominantClass.tblPredominantContactClassRow row1 in this.ds.tblPredominantContactClass.Rows)
      {
        int num2 = this.lstDominantContactClass.Items.Count - 1;
        for (int index = 0; index <= num2; ++index)
        {
          dsPredominantClass.lstPredominantContactClassRow row2 = (dsPredominantClass.lstPredominantContactClassRow) ((DataRowView) this.lstDominantContactClass.Items[index]).Row;
          if (row1.ClassID == row2.ClassID)
            this.lstDominantContactClass.SetItemChecked(index, true);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.lstDominantContactClass.ItemCheck += new ItemCheckEventHandler(this.lstDominantContactClass_ItemCheck);
  }

  private void lstDominantContactClass_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    int classId = ((dsPredominantClass.lstPredominantContactClassRow) ((DataRowView) this.lstDominantContactClass.Items[this.lstDominantContactClass.SelectedIndex]).Row).ClassID;
    if (e.CurrentValue == CheckState.Unchecked)
      DefaultDatabase.ExecuteNonQuery("dbo.spUpdatePredominantContactClass", new object[6]
      {
        (object) "@classID",
        (object) classId,
        (object) "@ProducerContactGUID",
        (object) this._producerContactGuid,
        (object) "@operType",
        (object) "I"
      });
    else
      DefaultDatabase.ExecuteNonQuery("dbo.spUpdatePredominantContactClass", new object[6]
      {
        (object) "@classID",
        (object) classId,
        (object) "@ProducerContactGUID",
        (object) this._producerContactGuid,
        (object) "@operType",
        (object) "D"
      });
  }
}
