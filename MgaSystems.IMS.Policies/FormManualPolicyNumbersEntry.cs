// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormManualPolicyNumbersEntry
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.BusinessObjects;
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
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormManualPolicyNumbersEntry : Form
{
  private IContainer components;
  private Guid _quoteGuid;
  private bool _isMultiCompanyLine;

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
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("dt", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CompanyLIne");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("DetailLine");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("UpdatePolicyNumber");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.dg = new UltraGrid();
    this.ds = new dsManualPolicyNumberEntry();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.dg).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(875, 392);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(42, 42);
    ((Control) this.btnCancel).TabIndex = 9;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(826, 392);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(42, 42);
    ((Control) this.btnSave).TabIndex = 8;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.dg).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dg).DataMember = "dt";
    ((UltraGridBase) this.dg).DataSource = (object) this.ds;
    appearance3.FontData.BoldAsString = "False";
    appearance3.FontData.UnderlineAsString = "True";
    ((SpecialBoxBase) ((UltraGridBase) this.dg).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.dg).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.dg).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dg).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dg).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.AddButtonCaption = "Add ... Program Code";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 335;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Company / LIne / Sate";
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 529;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Policy #";
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Width = 203;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Detail  Line";
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 55;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Save Pol  #";
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 97;
    ultraGridBand.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ultraGridBand.Override.AllowAddNew = (AllowAddNew) 1;
    ultraGridBand.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dg).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dg).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = Color.LightSteelBlue;
    appearance5.FontData.SizeInPoints = 10f;
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dg).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dg).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dg).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance11.BackColor = Color.Transparent;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    ((Control) this.dg).Font = new Font("Tahoma", 8.25f);
    ((Control) this.dg).Location = new Point(12, 12);
    ((Control) this.dg).Name = "dg";
    ((Control) this.dg).Size = new Size(905, 353);
    ((Control) this.dg).TabIndex = 30;
    ((Control) this.dg).Text = "Company / Line / State - Policy #s Assignment";
    ((UltraControlBase) this.dg).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dg).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsManualPolicyNumberEntry";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(929, 446);
    this.Controls.Add((Control) this.dg);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Name = nameof (FormManualPolicyNumbersEntry);
    this.Text = "Manual Policy NumbersEntry";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.dg).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  private virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dg")]
  protected virtual UltraGrid dg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsManualPolicyNumberEntry ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormManualPolicyNumbersEntry(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.FormManualPolicyNumbersEntry_Load);
    this._isMultiCompanyLine = false;
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
  }

  private void FormManualPolicyNumbersEntry_Load(object sender, EventArgs e)
  {
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) instance.Undo;
    this._isMultiCompanyLine = new Quote(this._quoteGuid).IsMultiCompanyPolicy;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dt"
    }, CommandType.Text, "SELECT Q.CompanyLineGuid, CL.CompanyLine, Q.PolicyNumber, 0 AS DetailLine, 1 AS UpdatePolicyNumber FROM tblQuotes Q WITH (NOLOCK) INNER JOIN tblCompanyLines CL WITH (NOLOCK) ON CL.CompanyLineGuid = Q.CompanyLineGuid WHERE QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) this._quoteGuid
    });
    if (!this._isMultiCompanyLine)
      return;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dt"
    }, CommandType.Text, "SELECT QD.CompanyLineGuid, CL.CompanyLine, QD.PolicyNumber, 1 AS DetailLine,1 AS UpdatePolicyNumber FROM tblQuoteDetails QD WITH (NOLOCK) INNER JOIN tblCompanyLines CL WITH (NOLOCK) ON CL.CompanyLineGuid = QD.CompanyLineGuid WHERE QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) this._quoteGuid
    });
  }

  private bool IsValidData()
  {
    bool flag;
    if (!this._isMultiCompanyLine)
    {
      try
      {
        foreach (dsManualPolicyNumberEntry.dtRow row in this.ds.dt.Rows)
        {
          if (row.IsPolicyNumberNull())
          {
            int num = (int) MessageBox.Show("Policy # cannot be empty", "Empty Policy #", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            flag = false;
            goto label_11;
          }
          if (row.PolicyNumber.Replace(" ", string.Empty).Length == 0)
          {
            int num = (int) MessageBox.Show("Policy # cannot be blank spaces", "Blank Policy #", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            flag = false;
            goto label_11;
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
    flag = true;
label_11:
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.IsValidData())
      return;
    string empty = string.Empty;
    try
    {
      foreach (dsManualPolicyNumberEntry.dtRow row in this.ds.dt.Rows)
      {
        if (!row.IsUpdatePolicyNumberNull() && row.UpdatePolicyNumber && !row.IsPolicyNumberNull())
        {
          if (row.DetailLine)
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteDetails SET PolicyNumber=@PN, PolicyNumberIndex=0, PolicyNumberRuleID=NULL WHERE QuoteGuid=@QG AND CompanyLineGuid=@CLG", new object[6]
            {
              (object) "@PN",
              (object) row.PolicyNumber,
              (object) "@QG",
              (object) this._quoteGuid,
              (object) "@CLG",
              (object) row.CompanyLineGuid
            });
          else
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET PolicyNumber=@PN, PolicyNumberIndex=0, PolicyNumberRuleID=NULL WHERE QuoteGuid=@QG", new object[4]
            {
              (object) "@PN",
              (object) row.PolicyNumber,
              (object) "@QG",
              (object) this._quoteGuid
            });
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();
}
