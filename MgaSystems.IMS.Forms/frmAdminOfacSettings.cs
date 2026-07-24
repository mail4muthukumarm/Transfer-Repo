// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmAdminOfacSettings
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
[TestForm]
public class frmAdminOfacSettings : FormBase
{
  private IContainer components;
  public const string OfacSettingsResource = "{72659027-825A-4769-8AD2-F50D7BC5EBB1}";

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
    this.dsOfac = new dsOfacManagement();
    this.dsOfac.BeginInit();
    this.SuspendLayout();
    this.dsOfac.DataSetName = "dsOfacManagement";
    this.dsOfac.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(800, 450);
    this.Name = nameof (frmAdminOfacSettings);
    this.Text = "OFAC System Settings";
    this.dsOfac.EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("dsOfac")]
  internal virtual dsOfacManagement dsOfac { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmAdminOfacSettings()
  {
    this.Load += new EventHandler(this.frmAdminOfacSettings_Load);
    this.InitializeComponent();
  }

  private void frmAdminOfacSettings_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    DefaultDatabase.LoadDataTable((DataTable) this.dsOfac.OfacSettings, CommandType.Text, "SELECT OfacTypeID, OfacName, SortOrder, ServiceURL, ServiceUsername, ServicePassword, ServiceConfiguration FROM dbo.tblOFACSettings");
    try
    {
      foreach (dsOfacManagement.OfacSettingsRow ofacSetting in (TypedTableBase<dsOfacManagement.OfacSettingsRow>) this.dsOfac.OfacSettings)
      {
        XDocument xdocument = XDocument.Parse(ofacSetting.ServiceConfiguration);
        try
        {
          foreach (XElement descendant in xdocument.Element((XName) "Settings").Descendants())
            this.dsOfac.SettingConfigs.AddSettingConfigsRow(ofacSetting, descendant.Name.LocalName, descendant.Value);
        }
        finally
        {
          IEnumerator<XElement> enumerator;
          enumerator?.Dispose();
        }
      }
    }
    finally
    {
      IEnumerator<dsOfacManagement.OfacSettingsRow> enumerator;
      enumerator?.Dispose();
    }
    this.dsOfac.AcceptChanges();
  }
}
