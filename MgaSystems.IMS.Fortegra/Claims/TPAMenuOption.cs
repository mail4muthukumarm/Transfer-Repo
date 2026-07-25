// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Claims.TPAMenuOption
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Claims;

public class TPAMenuOption : UserControl
{
  private IContainer components;
  private MGASimpleComboBox comboClaimTPA;
  private Label label1;

  [Browsable(false)]
  public int SelectedClaimTPAId
  {
    get
    {
      int selectedClaimTpaId = -1;
      if (((UltraDropDownBase) this.comboClaimTPA).SelectedRow != null)
        selectedClaimTpaId = (int) ((UltraDropDownBase) this.comboClaimTPA).SelectedRow.Cells["TPAID"].Value;
      return selectedClaimTpaId;
    }
  }

  [Browsable(false)]
  public string SelectedClaimTPAName
  {
    get
    {
      string empty = string.Empty;
      if (((UltraDropDownBase) this.comboClaimTPA).SelectedRow != null)
        empty = ((UltraDropDownBase) this.comboClaimTPA).SelectedRow.Cells["tpa_name"].Value.ToString();
      return empty;
    }
  }

  [Browsable(false)]
  public bool ClaimTPASelected => ((UltraDropDownBase) this.comboClaimTPA).SelectedRow != null;

  [Browsable(true)]
  public int ComboBoxWidth
  {
    set => ((Control) this.comboClaimTPA).Width = value;
    get => ((Control) this.comboClaimTPA).Width;
  }

  public TPAMenuOption() => this.InitializeComponent();

  public void LoadClaimTPAs()
  {
    ((UltraGridBase) this.comboClaimTPA).DataSource = (object) DefaultDatabase.ExecuteDataTable("Fortegra_GetClaimTPAList");
    ((UltraDropDownBase) this.comboClaimTPA).ValueMember = "tpaid";
    ((UltraDropDownBase) this.comboClaimTPA).DisplayMember = "tpa_name";
  }

  private void TPAMenuOption_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadClaimTPAs();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.comboClaimTPA = new MGASimpleComboBox();
    this.label1 = new Label();
    ((ISupportInitialize) this.comboClaimTPA).BeginInit();
    this.SuspendLayout();
    ((Control) this.comboClaimTPA).Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.comboClaimTPA.BorderStyle = (UIElementBorderStyle) 4;
    this.comboClaimTPA.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboClaimTPA).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboClaimTPA).Location = new Point(6, 19);
    this.comboClaimTPA.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboClaimTPA).Name = "comboClaimTPA";
    ((Control) this.comboClaimTPA).Size = new Size(284, 21);
    ((Control) this.comboClaimTPA).TabIndex = 5;
    ((UltraControlBase) this.comboClaimTPA).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimTPA).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 8.25f);
    this.label1.Location = new Point(3, 4);
    this.label1.Name = "label1";
    this.label1.Size = new Size(58, 13);
    this.label1.TabIndex = 4;
    this.label1.Text = "Claim TPA:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.comboClaimTPA);
    this.Controls.Add((Control) this.label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (TPAMenuOption);
    this.Size = new Size(293, 48 /*0x30*/);
    this.Load += new EventHandler(this.TPAMenuOption_Load);
    ((ISupportInitialize) this.comboClaimTPA).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
