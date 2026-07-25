// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.frmQuoteDetailRaterConfig
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class frmQuoteDetailRaterConfig : Form
{
  private IContainer components;
  private Label Label1;
  private Label Label2;
  private dsQuoteDetailRaters ds;
  private ErrorProvider err;
  private Label Label3;
  private readonly Guid _quoteGuid;
  private readonly Guid _companyLineGuid;
  private IRater _rater;
  private bool _saved;
  private bool _formFullyLoaded;

  protected virtual MGASimpleComboBox cboRaters
  {
    get => this._cboRaters;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboRaters_ValueChanged);
      MGASimpleComboBox cboRaters1 = this._cboRaters;
      if (cboRaters1 != null)
        cboRaters1.ValueChanged -= eventHandler;
      this._cboRaters = value;
      MGASimpleComboBox cboRaters2 = this._cboRaters;
      if (cboRaters2 == null)
        return;
      cboRaters2.ValueChanged += eventHandler;
    }
  }

  protected virtual MGASimpleComboBox cboFactorSet
  {
    get => this._cboFactorSet;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboFactorSet_BeforeDropDown);
      MGASimpleComboBox cboFactorSet1 = this._cboFactorSet;
      if (cboFactorSet1 != null)
        cboFactorSet1.BeforeDropDown -= cancelEventHandler;
      this._cboFactorSet = value;
      MGASimpleComboBox cboFactorSet2 = this._cboFactorSet;
      if (cboFactorSet2 == null)
        return;
      cboFactorSet2.BeforeDropDown += cancelEventHandler;
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.cboRaters = new MGASimpleComboBox();
    this.ds = new dsQuoteDetailRaters();
    this.cboFactorSet = new MGASimpleComboBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.btnSave = new MGAButton();
    this.err = new ErrorProvider(this.components);
    this.btnCancel = new MGAButton();
    this.Label3 = new Label();
    ((ISupportInitialize) this.cboRaters).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboFactorSet).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    this.cboRaters.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboRaters).DataSource = (object) this.ds.lstRatingTypes;
    ((UltraDropDownBase) this.cboRaters).DisplayMember = "RatingType";
    this.cboRaters.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboRaters).DropDownWidth = 400;
    ((Control) this.cboRaters).Location = new Point(84, 31 /*0x1F*/);
    this.cboRaters.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboRaters).Name = "cboRaters";
    ((Control) this.cboRaters).Size = new Size(350, 21);
    ((Control) this.cboRaters).TabIndex = 0;
    ((UltraControlBase) this.cboRaters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboRaters).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboRaters).ValueMember = "RatingTypeID";
    this.ds.DataSetName = "dsQuoteDetailRaters";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cboFactorSet.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboFactorSet).DataSource = (object) this.ds.tblFactorSets;
    ((UltraDropDownBase) this.cboFactorSet).DisplayMember = "Title";
    this.cboFactorSet.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboFactorSet).DropDownWidth = 400;
    ((Control) this.cboFactorSet).Location = new Point(84, 61);
    this.cboFactorSet.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboFactorSet).Name = "cboFactorSet";
    ((Control) this.cboFactorSet).Size = new Size(350, 21);
    ((Control) this.cboFactorSet).TabIndex = 1;
    ((UltraControlBase) this.cboFactorSet).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboFactorSet).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboFactorSet).ValueMember = "FactorSetGUID";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(14, 35);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(38, 13);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "Rater:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(14, 65);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(61, 13);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Factor Set:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnSave).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(345, 101);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 4;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(394, 101);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 5;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(14, 7);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(379, 13);
    this.Label3.TabIndex = 6;
    this.Label3.Text = "Please select the rater and factor set you would like to use to rate this policy:";
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.FromArgb(250, 250, 250);
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(463, 155);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.cboFactorSet);
    this.Controls.Add((Control) this.cboRaters);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.Name = nameof (frmQuoteDetailRaterConfig);
    this.ShowInTaskbar = false;
    this.Text = "Rater Selection";
    ((ISupportInitialize) this.cboRaters).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboFactorSet).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public Guid FactorSetGuid
  {
    get
    {
      Guid factorSetGuid;
      if (this._formFullyLoaded && this.cboFactorSet != null && this.cboFactorSet.Value != null && this.cboFactorSet.Value != DBNull.Value)
        factorSetGuid = (Guid) this.cboFactorSet.Value;
      if (factorSetGuid.Equals(Guid.Empty) && !this._formFullyLoaded && this.ds.tblFactorSets.Count == 1)
        factorSetGuid = this.ds.tblFactorSets[0].FactorSetGUID;
      return factorSetGuid;
    }
  }

  public bool Saved => this._saved;

  public int RatersAvailable => this.ds.lstRatingTypes.Rows.Count;

  public int FactorSetsAvailable => this.ds.tblFactorSets.Rows.Count;

  public IRater Rater
  {
    get
    {
      if (this._rater == null)
        this._rater = RaterFactory.GetRater(!this.Visible ? this.ds.lstRatingTypes[0].RatingTypeID : Conversions.ToInteger(this.cboRaters.Value));
      return this._rater;
    }
  }

  public int RaterId => ((RaterBase) this.Rater).RaterID;

  public frmQuoteDetailRaterConfig(Guid quoteGuid, Guid companyLineGuid)
  {
    this.Load += new EventHandler(this.frmQuoteDetailRaterConfig_Load);
    this._formFullyLoaded = false;
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._companyLineGuid = companyLineGuid;
  }

  private void frmQuoteDetailRaterConfig_Load(object sender, EventArgs e)
  {
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) instance.Undo;
    if (this.ds.lstRatingTypes.Rows.Count == 0)
      this.GetData();
    this._formFullyLoaded = true;
  }

  public void GetData()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstRatingTypes"
    }, CommandType.Text, "SELECT lstRatingTypes.RatingType, lstRatingTypes.RatingTypeID FROM lstRatingTypes INNER JOIN tblCompanyRaters ON lstRatingTypes.RatingTypeID = tblCompanyRaters.RatingTypeID WHERE (lstRatingTypes.Hidden = 0) AND tblCompanyRaters.CompanyLineGuid=@CompanyLineGuid", new object[2]
    {
      (object) "@CompanyLineGuid",
      (object) this._companyLineGuid
    });
    this.cboRaters_ValueChanged((object) null, (EventArgs) null);
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT RaterID, FactorSetGuid FROM tblQuoteDetails WHERE QuoteGuid=@QuoteGuid AND CompanyLineGuid=@CompanyLineGuid", new object[4]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid,
      (object) "@CompanyLineGuid",
      (object) this._companyLineGuid
    });
    if (dataRow == null)
      return;
    object objectValue1 = RuntimeHelpers.GetObjectValue(dataRow["RaterID"]);
    object objectValue2 = RuntimeHelpers.GetObjectValue(dataRow["FactorSetGuid"]);
    if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue1)))
      this.cboRaters.Value = (object) Conversions.ToInteger(objectValue1);
    if (objectValue2 == DBNull.Value)
      return;
    this.cboFactorSet.Value = (object) (Guid) objectValue2;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (this.cboRaters.SelectedIndex == -1 && this.Visible)
    {
      this.err.SetError((Control) this.cboRaters, "Please select a rater from the list.");
    }
    else
    {
      this.err.SetError((Control) this.cboRaters, string.Empty);
      if (this.Rater == null)
      {
        this.Cursor = MgaCursors.Default;
        int num = (int) MessageBox.Show("Could not locate a rater for this policy.\n\nPlease contact your system admin.", "No Rater Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        this._rater = this.Rater;
        if (this.cboFactorSet.Value == null && this.Rater is IRaterWithFactorSet)
        {
          this.err.SetError((Control) this.cboFactorSet, "Please select a factor set from the list.");
        }
        else
        {
          this.err.SetError((Control) this.cboFactorSet, string.Empty);
          if (this.Rater is IRaterWithFactorSet)
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteDetails SET RaterID=@RID, FactorSetGuid=@FSG WHERE CompanyLineGuid=@CLG AND QuoteGuid=@QG", new object[8]
            {
              (object) "@RID",
              (object) this.RaterId,
              (object) "@FSG",
              this.cboFactorSet.Value,
              (object) "@CLG",
              (object) this._companyLineGuid,
              (object) "@QG",
              (object) this._quoteGuid
            });
          else
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteDetails SET RaterID=NULL, FactorSetGuid=@FSG WHERE CompanyLineGuid=@CLG AND QuoteGuid=@QG", new object[8]
            {
              (object) "@RID",
              (object) this.RaterId,
              (object) "@FSG",
              this.cboFactorSet.Value,
              (object) "@CLG",
              (object) this._companyLineGuid,
              (object) "@QG",
              (object) this._quoteGuid
            });
          this._saved = true;
          this.Close();
        }
      }
    }
  }

  public void SaveData() => this.btnSave_Click((object) null, (EventArgs) null);

  private void cboRaters_ValueChanged(object sender, EventArgs e)
  {
    this._rater = (IRater) null;
    if (this.ds.lstRatingTypes.Rows.Count == 0)
      return;
    int num = Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.cboRaters.Value)) ? (int) this.cboRaters.Value : this.ds.lstRatingTypes[0].RatingTypeID;
    this.ds.tblFactorSets.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblFactorSets"
    }, "dbo.GetCompanyFactorSets", new object[4]
    {
      (object) "@CompanyLineGuid",
      (object) this._companyLineGuid,
      (object) "@raterID",
      (object) num
    });
    if (SystemSettings.KeyExists("ShowFactorSetEffectiveDates") && SystemSettings.GetBoolSetting("ShowFactorSetEffectiveDates") && this.ds.tblFactorSets.Columns.Contains("EffectiveDate"))
    {
      if (this.ds.tblFactorSets.Columns.Contains("Title"))
      {
        try
        {
          foreach (DataRow tblFactorSet in (TypedTableBase<dsQuoteDetailRaters.tblFactorSetsRow>) this.ds.tblFactorSets)
          {
            if (tblFactorSet["EffectiveDate"] != null && tblFactorSet["Title"] != null)
              tblFactorSet["Title"] = (object) $"{tblFactorSet["Title"].ToString()} ({((DateTime) tblFactorSet["EffectiveDate"]).ToString("M/d/yy")})";
          }
        }
        finally
        {
          IEnumerator<dsQuoteDetailRaters.tblFactorSetsRow> enumerator;
          enumerator?.Dispose();
        }
        ((UltraGridBase) this.cboFactorSet).DataSource = (object) this.ds.tblFactorSets.Select("", "EffectiveDate DESC");
      }
    }
    ((Control) this.cboFactorSet).Enabled = this.ds.tblFactorSets.Count > 0;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._rater != null)
        this._rater.Dispose();
    }
    base.Dispose(disposing);
  }

  private void cboFactorSet_BeforeDropDown(object sender, CancelEventArgs e)
  {
    this.HandleBeforeFactorSetDropDown(e);
  }

  protected virtual void HandleBeforeFactorSetDropDown(CancelEventArgs e)
  {
  }
}
