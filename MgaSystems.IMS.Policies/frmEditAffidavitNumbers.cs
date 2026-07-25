// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmEditAffidavitNumbers
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class frmEditAffidavitNumbers : Form
{
  private IContainer components;
  private UltraGrid ugAffidavitNumbers;
  private dsEditAffidavitNumbers ds;
  private DbDataAdapter daEditAffidavitNumbers;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private int _controlNo;

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

  private virtual MGAButton btnDelete
  {
    get => this._btnDelete;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDelete_Click);
      MGAButton btnDelete1 = this._btnDelete;
      if (btnDelete1 != null)
        ((Control) btnDelete1).Click -= eventHandler;
      this._btnDelete = value;
      MGAButton btnDelete2 = this._btnDelete;
      if (btnDelete2 == null)
        return;
      ((Control) btnDelete2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblQuoteAffidavitNumbers", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("QuoteID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("AffidavitNumber");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("AffidavitNumberIndex");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Exportable");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("TaxExempt");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEditAffidavitNumbers));
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    this.ugAffidavitNumbers = new UltraGrid();
    this.ds = new dsEditAffidavitNumbers();
    this.daEditAffidavitNumbers = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.btnDelete = new MGAButton();
    ((ISupportInitialize) this.ugAffidavitNumbers).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnDelete).BeginInit();
    this.SuspendLayout();
    ((Control) this.ugAffidavitNumbers).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugAffidavitNumbers).DataSource = (object) this.ds.tblQuoteAffidavitNumbers;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 82;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "State";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 74;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Affidavit Number";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 230;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Affidavit Number Index";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.MaskInput = "999999999";
    ultraGridColumn4.Width = 147;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 98;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Tax Exempt";
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 86;
    ultraGridBand.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance3.BorderColor = Color.Gainsboro;
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance5.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.Gainsboro;
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance7.BackColor = Color.Transparent;
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugAffidavitNumbers).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugAffidavitNumbers).Location = new Point(0, 0);
    ((Control) this.ugAffidavitNumbers).Name = "ugAffidavitNumbers";
    ((Control) this.ugAffidavitNumbers).Size = new Size(656, 248);
    ((Control) this.ugAffidavitNumbers).TabIndex = 17;
    this.ugAffidavitNumbers.UpdateMode = (UpdateMode) 3;
    ((UltraControlBase) this.ugAffidavitNumbers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugAffidavitNumbers).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsEditAffidavitNumbers";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.daEditAffidavitNumbers.DeleteCommand = this.DbDeleteCommand1;
    this.daEditAffidavitNumbers.InsertCommand = this.DbInsertCommand1;
    this.daEditAffidavitNumbers.SelectCommand = this.DbSelectCommand1;
    this.daEditAffidavitNumbers.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteAffidavitNumbers", new DataColumnMapping[6]
      {
        new DataColumnMapping("QuoteID", "QuoteID"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("AffidavitNumber", "AffidavitNumber"),
        new DataColumnMapping("AffidavitNumberIndex", "AffidavitNumberIndex"),
        new DataColumnMapping("Exportable", "Exportable"),
        new DataColumnMapping("TaxExempt", "TaxExempt")
      })
    });
    this.daEditAffidavitNumbers.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = "DELETE FROM dbo.tblQuoteAffidavitNumbers WHERE (QuoteID = @Original_QuoteID) AND (StateID = @Original_StateID)";
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@Original_QuoteID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_StateID", SqlDbType.VarChar, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[6]
    {
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.VarChar, 2, "StateID"),
      DefaultDatabase.CreateParameter("@AffidavitNumber", SqlDbType.VarChar, 50, "AffidavitNumber"),
      DefaultDatabase.CreateParameter("@AffidavitNumberIndex", SqlDbType.Int, 4, "AffidavitNumberIndex"),
      DefaultDatabase.CreateParameter("@Exportable", SqlDbType.Bit, 1, "Exportable"),
      DefaultDatabase.CreateParameter("@TaxExempt", SqlDbType.Bit, 1, "TaxExempt")
    });
    this.DbSelectCommand1.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@ControlNo", SqlDbType.Int, 4, "ControlNo")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[8]
    {
      DefaultDatabase.CreateParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.VarChar, 2, "StateID"),
      DefaultDatabase.CreateParameter("@AffidavitNumber", SqlDbType.VarChar, 50, "AffidavitNumber"),
      DefaultDatabase.CreateParameter("@AffidavitNumberIndex", SqlDbType.Int, 4, "AffidavitNumberIndex"),
      DefaultDatabase.CreateParameter("@Exportable", SqlDbType.Bit, 1, "Exportable"),
      DefaultDatabase.CreateParameter("@TaxExempt", SqlDbType.Bit, 1, "TaxExempt"),
      DefaultDatabase.CreateParameter("@Original_QuoteID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_StateID", SqlDbType.VarChar, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null)
    });
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance8.BackColor = Color.FromArgb(248, 248, 248);
    appearance8.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance8.BackGradientStyle = (GradientStyle) 2;
    appearance8.BorderColor = Color.DarkGray;
    appearance8.ImageHAlign = (HAlign) 2;
    appearance8.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance8;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((Control) this.btnSave).Location = new Point(512 /*0x0200*/, 264);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 33;
    ((Control) this.btnSave).Tag = (object) "KeepEnabled";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance9.BackColor = Color.FromArgb(248, 248, 248);
    appearance9.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.BorderColor = Color.DarkGray;
    appearance9.ImageHAlign = (HAlign) 2;
    appearance9.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance9;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((Control) this.btnCancel).Location = new Point(560, 264);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 34;
    ((Control) this.btnCancel).Tag = (object) "KeepEnabled";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnDelete).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance10.BackColor = Color.FromArgb(248, 248, 248);
    appearance10.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance10.BackGradientStyle = (GradientStyle) 2;
    appearance10.BorderColor = Color.DarkGray;
    appearance10.ImageHAlign = (HAlign) 2;
    appearance10.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnDelete).Appearance = (AppearanceBase) appearance10;
    ((ControlBase) this.btnDelete).ImageSize = new Size(24, 24);
    ((Control) this.btnDelete).Location = new Point(608, 264);
    ((Control) this.btnDelete).Name = "btnDelete";
    ((Control) this.btnDelete).Size = new Size(40, 40);
    ((Control) this.btnDelete).TabIndex = 35;
    ((Control) this.btnDelete).Tag = (object) "KeepEnabled";
    this.btnDelete.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(656, 310);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.ugAffidavitNumbers);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmEditAffidavitNumbers);
    this.Text = "Edit Affidavit Numbers";
    ((ISupportInitialize) this.ugAffidavitNumbers).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnDelete).EndInit();
    this.ResumeLayout(false);
  }

  public frmEditAffidavitNumbers()
  {
    this.Load += new EventHandler(this.frmEditAffidavitNumbers_Load);
    this.InitializeComponent();
  }

  public frmEditAffidavitNumbers(int controlNo)
  {
    this.Load += new EventHandler(this.frmEditAffidavitNumbers_Load);
    this.InitializeComponent();
    this._controlNo = controlNo;
  }

  private void frmEditAffidavitNumbers_Load(object sender, EventArgs e)
  {
    Utility.SetDataAdapterConnections(this.daEditAffidavitNumbers, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    ((ControlBase) this.btnDelete).Appearance.Image = (object) ImageCache.Instance.Delete;
    this.daEditAffidavitNumbers.SelectCommand.Parameters["@ControlNo"].Value = (object) this._controlNo;
    try
    {
      DefaultDatabase.DataAdapterFill(this.daEditAffidavitNumbers, (DataTable) this.ds.tblQuoteAffidavitNumbers);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors(this.ds.tblQuoteAffidavitNumbers.DataSet, ex);
      ProjectData.ClearProjectError();
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateAffidavitNumberIndex())
      return;
    DefaultDatabase.DataAdapterUpdate(this.daEditAffidavitNumbers, (DataTable) this.ds.tblQuoteAffidavitNumbers);
    this.Close();
  }

  private bool ValidateAffidavitNumberIndex()
  {
    bool flag;
    try
    {
      foreach (dsEditAffidavitNumbers.tblQuoteAffidavitNumbersRow row in this.ds.tblQuoteAffidavitNumbers.Rows)
      {
        if (row.AffidavitNumberIndex != 0)
        {
          string[] strArray = row.AffidavitNumber.Split("-".ToCharArray());
          if (Versioned.IsNumeric((object) strArray[0]) && row.AffidavitNumberIndex != Conversions.ToInteger(strArray[0]))
          {
            int num = (int) MessageBox.Show("The affidavit number index and affidavit number do not match.", "Incorrect Affidavit Index", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            flag = false;
            goto label_9;
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    flag = true;
label_9:
    return flag;
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ugAffidavitNumbers).ActiveRow == null)
      return;
    ((UltraGridBase) this.ugAffidavitNumbers).ActiveRow.Delete();
    DefaultDatabase.DataAdapterUpdate(this.daEditAffidavitNumbers, (DataTable) this.ds.tblQuoteAffidavitNumbers);
  }
}
