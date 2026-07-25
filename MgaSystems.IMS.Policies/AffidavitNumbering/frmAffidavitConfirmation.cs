// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.AffidavitNumbering.frmAffidavitConfirmation
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.AffidavitNumbering;

public sealed class frmAffidavitConfirmation : Form
{
  private IContainer components;
  private Label Label1;
  private UltraGrid dgAffidavits;
  private DbDataAdapter da;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private dsAffidavitConfirmation ds;
  private int _quoteID;
  private bool _isEndorsement;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblQuoteAffidavitNumbers", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("AffidavitNumber");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("AffidavitNumberIndex");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("QuoteID");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAffidavitConfirmation));
    Appearance appearance9 = new Appearance();
    this.Label1 = new Label();
    this.dgAffidavits = new UltraGrid();
    this.ds = new dsAffidavitConfirmation();
    this.da = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.btnSave = new MGAButton();
    ((ISupportInitialize) this.dgAffidavits).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.SuspendLayout();
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(448, 34);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "The following affidavit numbers were generated for this policy.  If any of the numbers are incorrect, you may edit them.";
    ((UltraGridBase) this.dgAffidavits).DataSource = (object) this.ds.tblQuoteAffidavitNumbers;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "State";
    ultraGridColumn1.Header.VisiblePosition = 1;
    ultraGridColumn1.Width = 85;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Affidavit #";
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 210;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 126;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Quote ID";
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn4.Width = 151;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgAffidavits).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgAffidavits).Location = new Point(12, 57);
    ((Control) this.dgAffidavits).Name = "dgAffidavits";
    ((Control) this.dgAffidavits).Size = new Size(448, 158);
    ((Control) this.dgAffidavits).TabIndex = 1;
    ((UltraControlBase) this.dgAffidavits).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgAffidavits).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAffidavitConfirmation";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.da.DeleteCommand = this.DbDeleteCommand1;
    this.da.InsertCommand = this.DbInsertCommand1;
    this.da.SelectCommand = this.DbSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteAffidavitNumbers", new DataColumnMapping[4]
      {
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("AffidavitNumber", "AffidavitNumber"),
        new DataColumnMapping("AffidavitNumberIndex", "AffidavitNumberIndex"),
        new DataColumnMapping("QuoteID", "QuoteID")
      })
    });
    this.da.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = componentResourceManager.GetString("DbDeleteCommand1.CommandText");
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[4]
    {
      DefaultDatabase.CreateParameter("@Original_QuoteID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_StateID", SqlDbType.VarChar, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AffidavitNumber", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AffidavitNumber", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AffidavitNumberIndex", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AffidavitNumberIndex", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = "INSERT INTO tblQuoteAffidavitNumbers(StateID, AffidavitNumber, AffidavitNumberIndex, QuoteID) VALUES (@StateID, @AffidavitNumber, @AffidavitNumberIndex, @QuoteID)";
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[4]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.VarChar, 2, "StateID"),
      DefaultDatabase.CreateParameter("@AffidavitNumber", SqlDbType.VarChar, 50, "AffidavitNumber"),
      DefaultDatabase.CreateParameter("@AffidavitNumberIndex", SqlDbType.Int, 4, "AffidavitNumberIndex"),
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.DbSelectCommand1.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[8]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.VarChar, 2, "StateID"),
      DefaultDatabase.CreateParameter("@AffidavitNumber", SqlDbType.VarChar, 50, "AffidavitNumber"),
      DefaultDatabase.CreateParameter("@AffidavitNumberIndex", SqlDbType.Int, 4, "AffidavitNumberIndex"),
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      DefaultDatabase.CreateParameter("@Original_QuoteID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_StateID", SqlDbType.VarChar, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AffidavitNumber", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AffidavitNumber", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AffidavitNumberIndex", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AffidavitNumberIndex", DataRowVersion.Original, (object) null)
    });
    appearance9.ImageHAlign = (HAlign) 2;
    appearance9.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance9;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(216, 235);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 2;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(468, 287);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.dgAffidavits);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmAffidavitConfirmation);
    this.Text = "Affidavit Confirmation";
    ((ISupportInitialize) this.dgAffidavits).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ResumeLayout(false);
  }

  public frmAffidavitConfirmation(int quoteID, bool isEndorsement)
  {
    this.Load += new EventHandler(this.frmAffidavitConfirmation_Load);
    this.InitializeComponent();
    this._quoteID = quoteID;
    this._isEndorsement = isEndorsement;
  }

  private void frmAffidavitConfirmation_Load(object sender, EventArgs e)
  {
    Utility.SetDataAdapterConnections(this.da, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    if (!this._isEndorsement)
    {
      ((UltraGridBase) this.dgAffidavits).DisplayLayout.Bands[0].Columns["QuoteID"].Hidden = true;
      this.da.SelectCommand.Parameters["@quoteID"].Value = (object) this._quoteID;
      DefaultDatabase.DataAdapterFill(this.da, (DataTable) this.ds.tblQuoteAffidavitNumbers);
    }
    else
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblQuoteAffidavitNumbers"
      }, CommandType.Text, "SELECT A.StateID, CASE WHEN Exportable = 1 THEN @A WHEN TaxExempt = 1 THEN @B ELSE AffidavitNumber END AS AffidavitNumber, AffidavitNumberIndex, A.QuoteID FROM tblQuoteAffidavitNumbers A INNER JOIN tblQuotes Q WITH (NOLOCK) ON Q.QuoteID = A.QuoteID WHERE Q.ControlNo = @CN", new object[6]
      {
        (object) "@CN",
        (object) new Quote(this._quoteID).ControlNo,
        (object) "@A",
        (object) "Exportable",
        (object) "@B",
        (object) "Tax Exempt"
      });
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    ((UltraGridBase) this.dgAffidavits).UpdateData();
    if (this.ds.HasChanges())
      DefaultDatabase.DataAdapterUpdate(this.da, (DataTable) this.ds.tblQuoteAffidavitNumbers);
    this.Close();
  }
}
