// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Claims.Fortegra_FormClaimExcelFileMappings
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Services.ExcelImport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Claims;

public class Fortegra_FormClaimExcelFileMappings : FormExcelFileMappings
{
  private IContainer components;
  private Label labelTPAName;

  private int TpaId { get; set; }

  private string TpaName { get; set; }

  public Fortegra_FormClaimExcelFileMappings(
    List<ExcelImportMapping> imsMappings,
    DataTable excelColumnNames,
    string mappingType)
    : base(imsMappings, excelColumnNames, mappingType)
  {
    this.InitializeComponent();
  }

  public Fortegra_FormClaimExcelFileMappings(
    List<ExcelImportMapping> imsMappings,
    DataTable excelColumnNames,
    string mappingType,
    int tpaID,
    string tpaName)
    : base(imsMappings, excelColumnNames, mappingType)
  {
    this.InitializeComponent();
    this.TpaId = tpaID;
    this.TpaName = tpaName;
  }

  private void Fortegra_FormClaimExcelFileMappings_Load(object sender, EventArgs e)
  {
    this.labelTPAName.Text = "Mappings For: " + this.TpaName;
  }

  protected override void Save()
  {
    if (!this.ValidateFieldMappings())
      return;
    this.SetMappingExcelValues();
    if (this.checkRememberMappings.Checked)
    {
      using (MemoryStream serializationStream = new MemoryStream())
      {
        new BinaryFormatter().Serialize((Stream) serializationStream, (object) this.Mappings);
        this.SerializeMappings("dbo.Fortegra_ClearUserExcelFileMappings", new object[6]
        {
          (object) "@userGuid",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@mappingType",
          this.MappingType == string.Empty ? (object) "Default Mapping" : (object) this.MappingType,
          (object) "@tpaId",
          (object) this.TpaId
        }, "dbo.Fortegra_InsertExcelFileMappings", new object[8]
        {
          (object) "@mapping",
          (object) serializationStream.ToArray(),
          (object) "@mappingType",
          this.MappingType == string.Empty ? (object) "Default Mapping" : (object) this.MappingType,
          (object) "@userGuid",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@tpaId",
          (object) this.TpaId
        });
      }
    }
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  protected override void DeserializeMappings()
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("dbo.Fortegra_GetExcelFileMappings", new object[6]
    {
      (object) "@mappingType",
      this.MappingType == string.Empty ? (object) "Default Mapping" : (object) this.MappingType,
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@tpaId",
      (object) this.TpaId
    });
    if (dataRow == null || dataRow.Table == null || dataRow.Table.Columns.Count == 0 || dataRow.Table.Rows.Count == 0 || MessageBox.Show($"The system has found mappings saved for the mapping type '{this.MappingType}', do you want to use the saved mappings?", "Restore Saved Mappings?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    MemoryStream serializationStream = new MemoryStream(dataRow[0] as byte[]);
    try
    {
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      serializationStream.Position = 0L;
      this.Mappings.Clear();
      List<ExcelImportMapping> mappings = binaryFormatter.Deserialize((Stream) serializationStream) as List<ExcelImportMapping>;
      IEnumerable<ExcelImportMapping> excelImportMappings = this.Mappings.AsEnumerable<ExcelImportMapping>().Where<ExcelImportMapping>((System.Func<ExcelImportMapping, bool>) (mappings1 => !mappings.Select<ExcelImportMapping, string>((System.Func<ExcelImportMapping, string>) (mappings2 => mappings2.MappingName)).ToList<string>().Contains(mappings1.MappingName)));
      List<ExcelImportMapping> excelImportMappingList = new List<ExcelImportMapping>();
      foreach (ExcelImportMapping excelImportMapping in excelImportMappings)
        excelImportMappingList.Add(excelImportMapping);
      this.Mappings.Clear();
      foreach (ExcelImportMapping excelImportMapping in mappings)
        this.Mappings.Add(excelImportMapping);
      if (excelImportMappingList.Count > 0)
      {
        foreach (ExcelImportMapping excelImportMapping in excelImportMappingList)
          this.Mappings.Add(excelImportMapping);
      }
      this.SetCurrentMappings();
    }
    finally
    {
      serializationStream.Dispose();
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.labelTPAName = new Label();
    ((ISupportInitialize) this.buttonSaveMappings).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.SuspendLayout();
    ((Control) this.buttonSaveMappings).Location = new Point(171, 368);
    ((Control) this.buttonCancel).Location = new Point(293, 368);
    this.checkRememberMappings.Location = new Point(4, 374);
    this.labelTPAName.AutoSize = true;
    this.labelTPAName.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    this.labelTPAName.ForeColor = Color.SteelBlue;
    this.labelTPAName.Location = new Point(4, 406);
    this.labelTPAName.Name = "labelTPAName";
    this.labelTPAName.Size = new Size(41, 13);
    this.labelTPAName.TabIndex = 20;
    this.labelTPAName.Text = "label1";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(382, 428);
    this.Controls.Add((Control) this.labelTPAName);
    this.Name = nameof (Fortegra_FormClaimExcelFileMappings);
    this.Text = "Excel File Mappings (Fortegra)";
    this.Load += new EventHandler(this.Fortegra_FormClaimExcelFileMappings_Load);
    this.Controls.SetChildIndex((Control) this.buttonCancel, 0);
    this.Controls.SetChildIndex((Control) this.checkRememberMappings, 0);
    this.Controls.SetChildIndex((Control) this.buttonSaveMappings, 0);
    this.Controls.SetChildIndex((Control) this.labelTPAName, 0);
    ((ISupportInitialize) this.buttonSaveMappings).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
