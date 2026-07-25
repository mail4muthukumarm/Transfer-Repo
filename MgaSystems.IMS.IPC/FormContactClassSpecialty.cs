// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormContactClassSpecialty
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
public class FormContactClassSpecialty : Form
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
    this.lstContactClassSpecialty = new MGACheckedListBox();
    this.ds = new dsContactClassSpecialty();
    ((ISupportInitialize) this.lstContactClassSpecialty).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.lstContactClassSpecialty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstContactClassSpecialty.CheckOnClick = true;
    this.lstContactClassSpecialty.Location = new Point(12, 12);
    this.lstContactClassSpecialty.MGAStyle = MGAStyles.Blue;
    this.lstContactClassSpecialty.Name = "lstContactClassSpecialty";
    this.lstContactClassSpecialty.Size = new Size(424, 379);
    this.lstContactClassSpecialty.TabIndex = 14;
    this.ds.DataSetName = "dsContactClassSpecialty";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(448, 414);
    this.Controls.Add((Control) this.lstContactClassSpecialty);
    this.Name = nameof (FormContactClassSpecialty);
    this.Text = "Contact Class Specialty";
    ((ISupportInitialize) this.lstContactClassSpecialty).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  private virtual MGACheckedListBox lstContactClassSpecialty
  {
    get => this._lstContactClassSpecialty;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.lstDominantContactClass_ItemCheck);
      MGACheckedListBox contactClassSpecialty1 = this._lstContactClassSpecialty;
      if (contactClassSpecialty1 != null)
        contactClassSpecialty1.ItemCheck -= checkEventHandler;
      this._lstContactClassSpecialty = value;
      MGACheckedListBox contactClassSpecialty2 = this._lstContactClassSpecialty;
      if (contactClassSpecialty2 == null)
        return;
      contactClassSpecialty2.ItemCheck += checkEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsContactClassSpecialty ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormContactClassSpecialty(Guid producerContactGuid)
  {
    this.Load += new EventHandler(this.FormPredominantContactClass_Load);
    this._producerContactGuid = Guid.Empty;
    this.InitializeComponent();
    this._producerContactGuid = producerContactGuid;
  }

  private void FormPredominantContactClass_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstContactClassSpecialty"
    }, CommandType.Text, "SELECT ClassSpecialtyID, Specialty FROM lstContactClassSpecialty");
    this.lstContactClassSpecialty.DataSource = (object) this.ds.lstContactClassSpecialty;
    this.lstContactClassSpecialty.DisplayMember = this.ds.lstContactClassSpecialty.SpecialtyColumn.ColumnName;
    this.lstContactClassSpecialty.ValueMember = this.ds.lstContactClassSpecialty.ClassSpecialtyIDColumn.ColumnName;
    this.LoadClasses();
    this.FillClassesListbox();
  }

  private void LoadClasses()
  {
    this.ds.tblContactClassSpecialty.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblContactClassSpecialty"
    }, CommandType.Text, "SELECT ClassSpecialtyID FROM tblContactClassSpecialty WHERE ProducerContactGUID = @CG", new object[2]
    {
      (object) "@CG",
      (object) this._producerContactGuid
    });
  }

  private void FillClassesListbox()
  {
    this.lstContactClassSpecialty.ItemCheck -= new ItemCheckEventHandler(this.lstDominantContactClass_ItemCheck);
    int num1 = this.lstContactClassSpecialty.Items.Count - 1;
    for (int index = 0; index <= num1; ++index)
      this.lstContactClassSpecialty.SetItemChecked(index, false);
    try
    {
      foreach (dsContactClassSpecialty.tblContactClassSpecialtyRow row1 in this.ds.tblContactClassSpecialty.Rows)
      {
        int num2 = this.lstContactClassSpecialty.Items.Count - 1;
        for (int index = 0; index <= num2; ++index)
        {
          dsContactClassSpecialty.lstContactClassSpecialtyRow row2 = (dsContactClassSpecialty.lstContactClassSpecialtyRow) ((DataRowView) this.lstContactClassSpecialty.Items[index]).Row;
          if (row1.ClassSpecialtyID == row2.ClassSpecialtyID)
            this.lstContactClassSpecialty.SetItemChecked(index, true);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.lstContactClassSpecialty.ItemCheck += new ItemCheckEventHandler(this.lstDominantContactClass_ItemCheck);
  }

  private void lstDominantContactClass_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    int classSpecialtyId = ((dsContactClassSpecialty.lstContactClassSpecialtyRow) ((DataRowView) this.lstContactClassSpecialty.Items[this.lstContactClassSpecialty.SelectedIndex]).Row).ClassSpecialtyID;
    if (e.CurrentValue == CheckState.Unchecked)
      DefaultDatabase.ExecuteNonQuery("dbo.spUpdateSpecialtyContactClass", new object[6]
      {
        (object) "@classSpecialtyID",
        (object) classSpecialtyId,
        (object) "@ProducerContactGUID",
        (object) this._producerContactGuid,
        (object) "@operType",
        (object) "I"
      });
    else
      DefaultDatabase.ExecuteNonQuery("dbo.spUpdateSpecialtyContactClass", new object[6]
      {
        (object) "@classSpecialtyID",
        (object) classSpecialtyId,
        (object) "@ProducerContactGUID",
        (object) this._producerContactGuid,
        (object) "@operType",
        (object) "D"
      });
  }
}
