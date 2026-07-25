// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.AffidavitNumbering.frmViewExistingAffidavitNumbers
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.AffidavitNumbering;

public sealed class frmViewExistingAffidavitNumbers : Form
{
  private IContainer components;
  private UltraGrid ug;
  private dsViewExistingAffidavitNumbers ds;
  private readonly int _controlNo;

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblQuoteAffidavitNumbers", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("AffidavitNumber");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("QuoteID");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.ug = new UltraGrid();
    this.ds = new dsViewExistingAffidavitNumbers();
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.ug).DataSource = (object) this.ds.tblQuoteAffidavitNumbers;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 122;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Affidavit #";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 126;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 48 /*0x30*/;
    ultraGridBand.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ug).Dock = DockStyle.Fill;
    ((Control) this.ug).Location = new Point(0, 0);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(250, 168);
    ((Control) this.ug).TabIndex = 0;
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsViewExistingAffidavitNumbers";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(250, 168);
    this.Controls.Add((Control) this.ug);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmViewExistingAffidavitNumbers);
    this.ShowInTaskbar = false;
    this.Text = "Existing Affidavit Numbers";
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  public frmViewExistingAffidavitNumbers(int controlNo)
  {
    this.Load += new EventHandler(this.frmViewExistingAffidavitNumbers_Load);
    this.Closing += new CancelEventHandler(this.frmViewExistingAffidavitNumbers_Closing);
    this.InitializeComponent();
    this._controlNo = controlNo;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void frmViewExistingAffidavitNumbers_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblQuoteAffidavitNumbers"
    }, CommandType.Text, "SELECT tblQuoteAffidavitNumbers.StateID, tblQuoteAffidavitNumbers.AffidavitNumber, tblQuoteAffidavitNumbers.QuoteID FROM tblQuoteAffidavitNumbers  INNER JOIN tblQuotes On tblQuoteAffidavitNumbers.QuoteID = tblQuotes.QuoteID WHERE (tblQuotes.ControlNo = @ControlNo)", new object[2]
    {
      (object) "@ControlNo",
      (object) this._controlNo
    });
  }

  private void frmViewExistingAffidavitNumbers_Closing(object sender, CancelEventArgs e)
  {
    this.ug.PerformAction((UltraGridAction) 44);
    ((UltraControlBase) this.ug).EndUpdate();
    bool flag = false;
    try
    {
      foreach (dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow quoteAffidavitNumber in (TypedTableBase<dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow>) this.ds.tblQuoteAffidavitNumbers)
      {
        if (quoteAffidavitNumber["AffidavitNumber", DataRowVersion.Original] != DBNull.Value && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(quoteAffidavitNumber["AffidavitNumber", DataRowVersion.Original].ToString(), quoteAffidavitNumber.AffidavitNumber, false) != 0)
        {
          flag = true;
          break;
        }
      }
    }
    finally
    {
      IEnumerator<dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow> enumerator;
      enumerator?.Dispose();
    }
    if (!flag)
      return;
    if (MessageBox.Show("One or more affidavit numbers have been edited.\n\nDo you want to save the changes?", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      foreach (dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow quoteAffidavitNumber in (TypedTableBase<dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow>) this.ds.tblQuoteAffidavitNumbers)
      {
        if (quoteAffidavitNumber["AffidavitNumber", DataRowVersion.Original] != DBNull.Value && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(quoteAffidavitNumber["AffidavitNumber", DataRowVersion.Original].ToString(), quoteAffidavitNumber.AffidavitNumber, false) != 0)
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteAffidavitNumbers SET AffidavitNumber = @AffidavitNumber WHERE QuoteID = @QuoteID AND StateID = @StateID", new object[6]
          {
            (object) "@AffidavitNumber",
            (object) quoteAffidavitNumber.AffidavitNumber,
            (object) "@QuoteID",
            (object) quoteAffidavitNumber.QuoteID,
            (object) "@StateID",
            (object) quoteAffidavitNumber.StateID
          });
      }
    }
    finally
    {
      IEnumerator<dsViewExistingAffidavitNumbers.tblQuoteAffidavitNumbersRow> enumerator;
      enumerator?.Dispose();
    }
  }
}
