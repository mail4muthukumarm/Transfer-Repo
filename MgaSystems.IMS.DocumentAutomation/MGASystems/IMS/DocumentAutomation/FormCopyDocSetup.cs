// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.FormCopyDocSetup
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

[DesignerGenerated]
internal class FormCopyDocSetup : Form
{
  private IContainer components;

  public FormCopyDocSetup() => this.InitializeComponent();

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
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.Label2 = new Label();
    this.lstCompanyLines = new MGACheckedListBox();
    this.lnkDeselectCompanyLine = new LinkLabel();
    this.lnkSelectCompanyLines = new LinkLabel();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.cnSQL = new SqlConnection();
    this.da = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.ds = new dsCopyDocSetup();
    ((ISupportInitialize) this.lstCompanyLines).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.Label2.Location = new Point(3, 9);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(435, 25);
    this.Label2.TabIndex = 11;
    this.Label2.Text = "Please select the Company /  lines you would like to copy this automation event setup to:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    this.lstCompanyLines.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstCompanyLines.CheckOnClick = true;
    this.lstCompanyLines.Location = new Point(6, 48 /*0x30*/);
    this.lstCompanyLines.Name = "lstCompanyLines";
    this.lstCompanyLines.Size = new Size(443, 379);
    this.lstCompanyLines.TabIndex = 10;
    this.lnkDeselectCompanyLine.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeselectCompanyLine.AutoSize = true;
    this.lnkDeselectCompanyLine.Location = new Point(3, 461);
    this.lnkDeselectCompanyLine.Name = "lnkDeselectCompanyLine";
    this.lnkDeselectCompanyLine.Size = new Size(149, 13);
    this.lnkDeselectCompanyLine.TabIndex = 13;
    this.lnkDeselectCompanyLine.TabStop = true;
    this.lnkDeselectCompanyLine.Text = "De-select All Company / Lines";
    this.lnkSelectCompanyLines.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectCompanyLines.AutoSize = true;
    this.lnkSelectCompanyLines.Location = new Point(3, 430);
    this.lnkSelectCompanyLines.Name = "lnkSelectCompanyLines";
    this.lnkSelectCompanyLines.Size = new Size(134, 13);
    this.lnkSelectCompanyLines.TabIndex = 12;
    this.lnkSelectCompanyLines.TabStop = true;
    this.lnkSelectCompanyLines.Text = "Select All Company / Lines";
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(409, 439);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 15;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(360, 439);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 14;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.cnSQL.ConnectionString = "Data Source=TEAMMGA;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[2]
    {
      new DataTableMapping("Table", "lstStates", new DataColumnMapping[2]
      {
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("State", "State")
      }),
      new DataTableMapping("Table1", "lstLines", new DataColumnMapping[2]
      {
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("LineName", "LineName")
      })
    });
    this.SqlSelectCommand1.CommandText = "[GetCompanyLinesToCopyAutoEvents]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@companyLineGuid", SqlDbType.UniqueIdentifier),
      new SqlParameter("@systemEventGuid", SqlDbType.UniqueIdentifier),
      new SqlParameter("@templateID", SqlDbType.Int),
      new SqlParameter("@automationReportGuid", SqlDbType.UniqueIdentifier)
    });
    this.ds.DataSetName = "dsCopyDocSetup";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(460, 486);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lnkDeselectCompanyLine);
    this.Controls.Add((Control) this.lnkSelectCompanyLines);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.lstCompanyLines);
    this.Name = nameof (FormCopyDocSetup);
    this.Text = "Copy Document Automation Setups";
    ((ISupportInitialize) this.lstCompanyLines).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lstCompanyLines")]
  internal virtual MGACheckedListBox lstCompanyLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lnkDeselectCompanyLine")]
  internal virtual LinkLabel lnkDeselectCompanyLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lnkSelectCompanyLines")]
  internal virtual LinkLabel lnkSelectCompanyLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnCancel")]
  private virtual MGAButton btnCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnSave")]
  private virtual MGAButton btnSave { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cnSQL")]
  private virtual SqlConnection cnSQL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("da")]
  internal virtual SqlDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCopyDocSetup ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
