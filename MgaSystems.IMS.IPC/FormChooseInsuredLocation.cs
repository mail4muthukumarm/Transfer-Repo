// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormChooseInsuredLocation
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using MGASystems.IMS.InsuredsProducersCompanies.Insureds;
using MGASystems.Tools.BaseClasses;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public sealed class FormChooseInsuredLocation : MGABaseForm
{
  private IContainer components;
  private dsInsured.tblInsuredLocationsDataTable _locationsTable;
  private dsInsured.tblInsuredsDataTable _insuredTable;
  private Guid _insuredLocGuid;

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
    Appearance appearance = new Appearance();
    this.optionsInsuredLocations = new UltraOptionSet();
    this.Label1 = new Label();
    ((ISupportInitialize) this.optionsInsuredLocations).BeginInit();
    this.SuspendLayout();
    ((Control) this.optionsInsuredLocations).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance.BackColorDisabled = Color.Transparent;
    this.optionsInsuredLocations.Appearance = (AppearanceBase) appearance;
    this.optionsInsuredLocations.BackColor = Color.Transparent;
    this.optionsInsuredLocations.BackColorInternal = Color.Transparent;
    this.optionsInsuredLocations.BorderStyle = (UIElementBorderStyle) 1;
    ((Control) this.optionsInsuredLocations).Location = new Point(15, 28);
    ((Control) this.optionsInsuredLocations).Name = "optionsInsuredLocations";
    ((Control) this.optionsInsuredLocations).Size = new Size(577, 110);
    ((Control) this.optionsInsuredLocations).TabIndex = 9;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Tahoma", 9.25f);
    this.Label1.Location = new Point(12, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(379, 16 /*0x10*/);
    this.Label1.TabIndex = 10;
    this.Label1.Text = "A primary location is required.   Select the new primary location:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(595, 150);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.optionsInsuredLocations);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
    this.Name = nameof (FormChooseInsuredLocation);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Choose An Insured Location To Mark As Primary";
    ((ISupportInitialize) this.optionsInsuredLocations).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("optionsInsuredLocations")]
  private virtual UltraOptionSet optionsInsuredLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormChooseInsuredLocation(
    dsInsured.tblInsuredLocationsDataTable locationTable,
    dsInsured.tblInsuredsDataTable insuredTable,
    Guid insuredLocationGuid)
  {
    this.FormClosing += new FormClosingEventHandler(this.FormChooseInsuredLocation_FormClosing);
    this.Load += new EventHandler(this.FormChooseInsuredLocation_Load);
    this.InitializeComponent();
    this._locationsTable = locationTable;
    this._insuredLocGuid = insuredLocationGuid;
    this._insuredTable = insuredTable;
  }

  private void FormChooseInsuredLocation_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (this.optionsInsuredLocations.CheckedItem != null)
      return;
    int num = (int) MessageBox.Show("Please choose a location to be designated as the primary location", "Primary Location Not Choosen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    e.Cancel = true;
  }

  private void FormChooseInsuredLocation_Load(object sender, EventArgs e)
  {
    try
    {
      foreach (dsInsured.tblInsuredLocationsRow row in this._locationsTable.Rows)
      {
        if (!row.InsuredLocationGuid.Equals(this._insuredLocGuid))
        {
          dsInsured.tblInsuredsRow byInsuredGuid = this._insuredTable.FindByInsuredGuid(row.InsuredGuid);
          string empty = string.Empty;
          string str1 = string.Empty;
          string str2;
          if (!byInsuredGuid.PolicyName.Equals(row.Name))
          {
            string str3 = empty + byInsuredGuid.PolicyName;
            if (!byInsuredGuid.IsDBANull())
              str3 = $"{str3}' DBA '{byInsuredGuid.DBA}";
            str2 = $"{str3} ({row.Name})";
          }
          else
            str2 = byInsuredGuid.PolicyName;
          if (!row.IsAddress1Null())
            str1 = $"{str1}ADDRESS:{row.Address1}";
          if (!row.IsCityNull())
            str1 = $"{str1}, {row.City}";
          if (!row.IsStateNull())
            str1 = $"{str1}, {row.State}";
          this.optionsInsuredLocations.Items.Add((object) row.InsuredLocationGuid, $"{str1} NAME:{str2}");
          this.Height += 12;
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

  public Guid LocationChosen() => (Guid) this.optionsInsuredLocations.CheckedItem.DataValue;
}
