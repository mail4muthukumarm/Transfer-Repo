// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.frmPolicyPrintTypes
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
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
namespace MGASystems.IMS.DocumentAutomation;

public sealed class frmPolicyPrintTypes : Form
{
  private IContainer components;
  private Label Label1;
  private bool _saved;
  private bool _isPreview;
  private bool _isReprint;
  private int _batchIssuePrintTypeID;
  private int _batchQuoteId;
  private bool _setDefaultType;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("printTypes")]
  internal virtual UltraOptionSet printTypes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PrintNowOrBatch")]
  internal virtual UltraOptionSet PrintNowOrBatch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPrintOptions")]
  private virtual Label lblPrintOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    Appearance appearance = new Appearance();
    ValueListItem valueListItem1 = new ValueListItem();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPolicyPrintTypes));
    ValueListItem valueListItem2 = new ValueListItem();
    ValueListItem valueListItem3 = new ValueListItem();
    this.Label1 = new Label();
    this.btnOK = new MGAButton();
    this.printTypes = new UltraOptionSet();
    this.PictureBox1 = new PictureBox();
    this.PrintNowOrBatch = new UltraOptionSet();
    this.lblPrintOptions = new Label();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.printTypes).BeginInit();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.PrintNowOrBatch).BeginInit();
    this.SuspendLayout();
    this.Label1.Location = new Point(62, 12);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(174, 49);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Please select what version of the policy you would like to print:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.btnOK).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance.BackColor = Color.Gainsboro;
    appearance.BackColor2 = Color.White;
    appearance.BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance;
    ((Control) this.btnOK).Location = new Point(82, 262);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(68, 24);
    ((Control) this.btnOK).TabIndex = 2;
    ((ControlBase) this.btnOK).Text = "OK";
    this.btnOK.UseOSThemes = (DefaultableBoolean) 2;
    this.printTypes.BorderStyle = (UIElementBorderStyle) 1;
    this.printTypes.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem1.DataValue = (object) "Default Item";
    valueListItem1.DisplayText = "Default Item";
    this.printTypes.Items.AddRange(new ValueListItem[1]
    {
      valueListItem1
    });
    ((Control) this.printTypes).Location = new Point(38, 77);
    ((Control) this.printTypes).Name = "printTypes";
    ((Control) this.printTypes).Size = new Size(187, 101);
    ((Control) this.printTypes).TabIndex = 3;
    ((UltraControlBase) this.printTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.printTypes).UseOsThemes = (DefaultableBoolean) 2;
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(12, 12);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(44, 49);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 4;
    this.PictureBox1.TabStop = false;
    this.PrintNowOrBatch.BorderStyle = (UIElementBorderStyle) 1;
    this.PrintNowOrBatch.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem2.CheckState = CheckState.Checked;
    valueListItem2.DataValue = (object) "Default Item";
    valueListItem2.DisplayText = "Issue Now";
    ((SubObjectBase) valueListItem2).Tag = (object) "1";
    valueListItem3.DataValue = (object) "ValueListItem1";
    valueListItem3.DisplayText = "Batch (Queued for Sentinel)";
    ((SubObjectBase) valueListItem3).Tag = (object) "0";
    this.PrintNowOrBatch.Items.AddRange(new ValueListItem[2]
    {
      valueListItem2,
      valueListItem3
    });
    ((Control) this.PrintNowOrBatch).Location = new Point(38, 219);
    ((Control) this.PrintNowOrBatch).Name = "PrintNowOrBatch";
    ((Control) this.PrintNowOrBatch).Size = new Size(198, 37);
    ((Control) this.PrintNowOrBatch).TabIndex = 5;
    ((UltraControlBase) this.PrintNowOrBatch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.PrintNowOrBatch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.PrintNowOrBatch).Visible = false;
    this.lblPrintOptions.Location = new Point(35, 181);
    this.lblPrintOptions.Name = "lblPrintOptions";
    this.lblPrintOptions.Size = new Size(179, 35);
    this.lblPrintOptions.TabIndex = 6;
    this.lblPrintOptions.Text = "When should the selected version be issued?";
    this.lblPrintOptions.TextAlign = ContentAlignment.MiddleLeft;
    this.lblPrintOptions.Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(242, 292);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.lblPrintOptions);
    this.Controls.Add((Control) this.PrintNowOrBatch);
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) this.printTypes);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmPolicyPrintTypes);
    this.Text = "Policy Printing Options";
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.printTypes).EndInit();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.PrintNowOrBatch).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmPolicyPrintTypes(bool isPreview)
  {
    this.Load += new EventHandler(this.frmPolicyPrintTypes_Load);
    this._batchIssuePrintTypeID = -1;
    this._setDefaultType = false;
    this.InitializeComponent();
    this._isPreview = isPreview;
    this._isReprint = false;
    if (!isPreview)
      return;
    this.Label1.Text = "Please select the version of the policy you would like to preview:";
  }

  public frmPolicyPrintTypes(bool isPreview, int BatchQuoteID)
    : this(isPreview, false, BatchQuoteID)
  {
  }

  public frmPolicyPrintTypes(bool isPreview, bool isReprint, int BatchQuoteID)
  {
    this.Load += new EventHandler(this.frmPolicyPrintTypes_Load);
    this._batchIssuePrintTypeID = -1;
    this._setDefaultType = false;
    this.InitializeComponent();
    this._isPreview = isPreview;
    this._isReprint = isReprint;
    this._batchQuoteId = BatchQuoteID;
    if (!isPreview)
      return;
    this.Label1.Text = "Please select the version of the policy you would like to preview:";
  }

  public bool Saved => this._saved;

  public int PrintTypeID => Conversions.ToInteger(this.printTypes.Value);

  public int BatchIssuePrintTypeID => this._batchIssuePrintTypeID;

  private void frmPolicyPrintTypes_Load(object sender, EventArgs e)
  {
    this._setDefaultType = SystemSettings.KeyExists("DefaultPrintType");
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT PrintTypeID, PrintType FROM lstPolicyPrintTypes ORDER BY PrintType");
    this.printTypes.Items.Clear();
    try
    {
      foreach (DataRow row in dataTable.Rows)
        this.printTypes.Items.Add(new ValueListItem(RuntimeHelpers.GetObjectValue(row[0]), (string) row[1]));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (!this._isPreview && !this._isReprint && SystemSettings.KeyExists("SupportBatchIssuance") && SystemSettings.GetBoolSetting("SupportBatchIssuance"))
    {
      this.lblPrintOptions.Visible = true;
      ((Control) this.PrintNowOrBatch).Visible = true;
      this.PrintNowOrBatch.CheckedIndex = 0;
    }
    this.SetDefaultPrintType();
    this.AutoSave();
  }

  private void SetDefaultPrintType()
  {
    if (!this._setDefaultType)
      return;
    int int32 = Convert.ToInt32(SystemSettings.GetNumericSetting("DefaultPrintType"));
    foreach (ValueListItem valueListItem in this.printTypes.Items)
    {
      if (Conversions.ToInteger(valueListItem.DataValue) == int32)
      {
        this.printTypes.CheckedItem = valueListItem;
        break;
      }
    }
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    if (this.printTypes.CheckedIndex == -1)
    {
      int num1 = (int) MessageBox.Show("Please select an item from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (((Control) this.PrintNowOrBatch).Visible)
      {
        if (this.PrintNowOrBatch.CheckedIndex == -1)
        {
          int num2 = (int) MessageBox.Show("Please select whether to Print Now or Batch the selections.", "No Print", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          return;
        }
        if (this.PrintNowOrBatch.CheckedIndex == 1)
        {
          this._batchIssuePrintTypeID = this.PrintTypeID;
          DefaultDatabase.ExecuteNonQuery("spBulkIssuance_SetPrintType", new object[4]
          {
            (object) "@QuoteID",
            (object) this._batchQuoteId,
            (object) "@BatchIssuePrintTypeID",
            (object) this._batchIssuePrintTypeID
          });
        }
        else
          DefaultDatabase.ExecuteNonQuery("spBulkIssuance_ClearBatchIssuance", new object[2]
          {
            (object) "@QuoteID",
            (object) this._batchQuoteId
          });
      }
      this._saved = true;
      this.Close();
    }
  }

  private void AutoSave()
  {
    if (!this._setDefaultType || !SystemSettings.KeyExists("AutoSaveAndClosePolicyPrintType") || !SystemSettings.GetBoolSetting("AutoSaveAndClosePolicyPrintType"))
      return;
    this.btnOK_Click((object) null, EventArgs.Empty);
  }
}
