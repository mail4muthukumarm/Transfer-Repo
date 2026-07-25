// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.frmSelectOneOptionPerLine
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public class frmSelectOneOptionPerLine : Form
{
  private IContainer components;
  private Label Label1;
  private SqlConnection cn;
  private List<Guid> _quoteOptionGuids;
  private Guid _quoteGuid;
  private Dictionary<Guid, string> _optionDescriptionDictionary;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
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

  [field: AccessedThroughProperty("ds")]
  protected virtual dsSelectOneOptionPerLine ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaGroupBox1")]
  internal virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOptionDescription")]
  internal virtual Label lblOptionDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid dgOptions
  {
    get => this._dgOptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler1 = new CellEventHandler(this.dgOptions_CellChange);
      ClickCellEventHandler cellEventHandler2 = new ClickCellEventHandler(this.dgOptions_ClickCell);
      UltraGrid dgOptions1 = this._dgOptions;
      if (dgOptions1 != null)
      {
        dgOptions1.CellChange -= cellEventHandler1;
        dgOptions1.ClickCell -= cellEventHandler2;
      }
      this._dgOptions = value;
      UltraGrid dgOptions2 = this._dgOptions;
      if (dgOptions2 == null)
        return;
      dgOptions2.CellChange += cellEventHandler1;
      dgOptions2.ClickCell += cellEventHandler2;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LineName");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CompanyLocationCode");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("FK_tblQuoteOptions_lstLines");
    UltraGridBand ultraGridBand2 = new UltraGridBand("FK_tblQuoteOptions_lstLines", 0);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("QuoteOptionGUID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Premium");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("TotalFees");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Selected");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Bound");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("CompanyLocationCode");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance14 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSelectOneOptionPerLine));
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    this.dgOptions = new UltraGrid();
    this.ds = new dsSelectOneOptionPerLine();
    this.Label1 = new Label();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.cn = new SqlConnection();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.lblOptionDescription = new Label();
    ((ISupportInitialize) this.dgOptions).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.dgOptions).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgOptions).DataSource = (object) this.ds.lstLines;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgOptions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Line";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 461;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 386;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 102;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 118;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn6.Format = "c";
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn6.Header).TextOrientation = new TextOrientationInfo(0, (TextFlowDirection) 0);
    ultraGridColumn6.Header.VisiblePosition = 2;
    ultraGridColumn6.Width = 129;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance5;
    ultraGridColumn7.Format = "c";
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Fees";
    ultraGridColumn7.Header.VisiblePosition = 3;
    ultraGridColumn7.Width = 178;
    ultraGridColumn8.Header.VisiblePosition = 4;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 165;
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Width = 87;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Bind";
    ultraGridColumn10.Header.VisiblePosition = 5;
    ultraGridColumn10.Width = 48 /*0x30*/;
    ultraGridColumn11.Header.VisiblePosition = 6;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 143;
    ultraGridBand2.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11
    });
    ((UltraGridBase) this.dgOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgOptions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance7.BackColor = Color.LightSteelBlue;
    appearance7.FontData.SizeInPoints = 10f;
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.dgOptions).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance11.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance11;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance13.BackColor = Color.Transparent;
    appearance13.ForeColor = Color.Black;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgOptions).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgOptions).Location = new Point(8, 40);
    ((Control) this.dgOptions).Name = "dgOptions";
    ((Control) this.dgOptions).Size = new Size(482, 266);
    ((Control) this.dgOptions).TabIndex = 0;
    ((UltraControlBase) this.dgOptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgOptions).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsSelectOneOptionPerLine";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 16 /*0x10*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(381, 13);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Please select one quote option from each of the lines of business show below:";
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance14.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance18.Image"));
    appearance14.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance14;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(626, 312);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 2;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance15.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance19.Image"));
    appearance15.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance15;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(578, 312);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 3;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.cn.ConnectionString = "workstation id=ALIENWARE;packet size=4096;user id=mgasystems;data source=\"167.206.82.38\";persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    ((Control) this.MgaGroupBox1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    appearance16.BackColor = Color.FromArgb(239, 247, 253);
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance16;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lblOptionDescription);
    appearance17.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance17;
    ((Control) this.MgaGroupBox1).Location = new Point(499, 40);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(166, 266);
    ((Control) this.MgaGroupBox1).TabIndex = 4;
    this.MgaGroupBox1.Text = "Detail";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.lblOptionDescription.BackColor = Color.Transparent;
    this.lblOptionDescription.Dock = DockStyle.Fill;
    this.lblOptionDescription.Location = new Point(2, 19);
    this.lblOptionDescription.Name = "lblOptionDescription";
    this.lblOptionDescription.Size = new Size(162, 245);
    this.lblOptionDescription.TabIndex = 0;
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(674, 358);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.dgOptions);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmSelectOneOptionPerLine);
    this.Text = "Option Selection";
    ((ISupportInitialize) this.dgOptions).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmSelectOneOptionPerLine(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.frmSelectOneOptionPerLine_Load);
    this._quoteOptionGuids = new List<Guid>();
    this._optionDescriptionDictionary = new Dictionary<Guid, string>();
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this.cn.ConnectionString = DefaultDatabase.ConnectionString;
    this.FillData(this._quoteGuid);
    this.DataFillCompleted(this.ds);
  }

  public Guid[] QuoteOptionGuids
  {
    get => this._quoteOptionGuids.Count != 0 ? this._quoteOptionGuids.ToArray() : (Guid[]) null;
  }

  public virtual bool IsOnlyOneOptionPerLine
  {
    get
    {
      return Utility.IsNull<int>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(nameof (IsOnlyOneOptionPerLine), new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      })), 0) == 0;
    }
  }

  private void frmSelectOneOptionPerLine_Load(object sender, EventArgs e)
  {
    ((UltraGridBase) this.dgOptions).Rows.ExpandAll(true);
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    ((UltraGridBase) this.dgOptions).UpdateData();
    try
    {
      foreach (dsSelectOneOptionPerLine.lstLinesRow lstLine in (TypedTableBase<dsSelectOneOptionPerLine.lstLinesRow>) this.ds.lstLines)
      {
        if (this.ds.tblQuoteOptions.Select($"LineGuid='{lstLine.LineGUID.ToString()}' AND Selected=1").Length == 0)
        {
          int num = (int) MessageBox.Show($"Please select an option for {lstLine.LineName}.", "Missing Option", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          return;
        }
      }
    }
    finally
    {
      IEnumerator<dsSelectOneOptionPerLine.lstLinesRow> enumerator;
      enumerator?.Dispose();
    }
    try
    {
      foreach (dsSelectOneOptionPerLine.tblQuoteOptionsRow tblQuoteOption in (TypedTableBase<dsSelectOneOptionPerLine.tblQuoteOptionsRow>) this.ds.tblQuoteOptions)
      {
        if (tblQuoteOption.Selected)
        {
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteOptions SET Bound=1 WHERE QuoteOptionGuid = @QOG", new object[2]
          {
            (object) "@QOG",
            (object) tblQuoteOption.QuoteOptionGUID
          });
          this._quoteOptionGuids.Add(tblQuoteOption.QuoteOptionGUID);
        }
      }
    }
    finally
    {
      IEnumerator<dsSelectOneOptionPerLine.tblQuoteOptionsRow> enumerator;
      enumerator?.Dispose();
    }
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void dgOptions_CellChange(object sender, CellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "Selected", false) != 0)
      return;
    if (Conversions.ToBoolean(e.Cell.Text))
    {
      Guid guid = (Guid) e.Cell.Row.Cells["LineGuid"].Value;
      foreach (UltraGridRow row in ((UltraGridBase) this.dgOptions).Rows)
      {
        if (row.Cells["LineGuid"].Value.Equals((object) guid))
        {
          for (UltraGridRow sibling = row.GetChild((ChildRow) 0).GetSibling((SiblingRow) 0); sibling != null; sibling = sibling.GetSibling((SiblingRow) 2))
            sibling.Appearance.Reset();
          break;
        }
      }
      DataRow[] dataRowArray = this.ds.tblQuoteOptions.Select($"LineGuid='{guid.ToString()}'");
      int index = 0;
      while (index < dataRowArray.Length)
      {
        ((dsSelectOneOptionPerLine.tblQuoteOptionsRow) dataRowArray[index]).Selected = false;
        checked { ++index; }
      }
      e.Cell.Row.Appearance.BackColor = Color.LightYellow;
      e.Cell.Value = (object) true;
    }
    else
      e.Cell.Row.Appearance.Reset();
  }

  private void FillData(Guid quoteGuid)
  {
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
      {
        "lstLines",
        "tblQuoteOptions"
      }, "spGetOptionsPerLine", new object[2]
      {
        (object) "@QuoteGuid",
        (object) quoteGuid
      });
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    try
    {
      foreach (dsSelectOneOptionPerLine.tblQuoteOptionsRow row in this.ds.tblQuoteOptions.Rows)
      {
        if (row.Bound)
          row.Selected = true;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  protected virtual void DataFillCompleted(dsSelectOneOptionPerLine dataset)
  {
  }

  public void AutoSave()
  {
    if (this.AutoSaveFirstOption())
    {
      bool flag = false;
      try
      {
        foreach (dsSelectOneOptionPerLine.tblQuoteOptionsRow tblQuoteOption in (TypedTableBase<dsSelectOneOptionPerLine.tblQuoteOptionsRow>) this.ds.tblQuoteOptions)
        {
          if (tblQuoteOption.Selected)
          {
            flag = true;
            break;
          }
        }
      }
      finally
      {
        IEnumerator<dsSelectOneOptionPerLine.tblQuoteOptionsRow> enumerator;
        enumerator?.Dispose();
      }
      if (!flag)
        this.ds.tblQuoteOptions[0].Selected = true;
    }
    else
    {
      if (!this.IsOnlyOneOptionPerLine)
        throw new InvalidOperationException("AutoSave can't be called when not IsOnlyOneOptionPerLine");
      try
      {
        foreach (dsSelectOneOptionPerLine.lstLinesRow lstLine in (TypedTableBase<dsSelectOneOptionPerLine.lstLinesRow>) this.ds.lstLines)
        {
          dsSelectOneOptionPerLine.tblQuoteOptionsDataTable tblQuoteOptions1 = this.ds.tblQuoteOptions;
          string[] strArray = new string[5]
          {
            "LineGuid='",
            null,
            null,
            null,
            null
          };
          Guid lineGuid = lstLine.LineGUID;
          strArray[1] = lineGuid.ToString();
          strArray[2] = "' AND CompanyLocationCode = ";
          strArray[3] = Conversions.ToString(lstLine.CompanyLocationCode);
          strArray[4] = " AND Bound = 1";
          string filterExpression1 = string.Concat(strArray);
          dsSelectOneOptionPerLine.tblQuoteOptionsRow[] tblQuoteOptionsRowArray1 = (dsSelectOneOptionPerLine.tblQuoteOptionsRow[]) tblQuoteOptions1.Select(filterExpression1);
          if (tblQuoteOptionsRowArray1.Length > 1)
            throw new InvalidOperationException("Should only be one bound option per line at this point");
          if (tblQuoteOptionsRowArray1.Length == 0)
          {
            dsSelectOneOptionPerLine.tblQuoteOptionsDataTable tblQuoteOptions2 = this.ds.tblQuoteOptions;
            lineGuid = lstLine.LineGUID;
            string filterExpression2 = $"LineGuid='{lineGuid.ToString()}' AND CompanyLocationCode = {Conversions.ToString(lstLine.CompanyLocationCode)}";
            dsSelectOneOptionPerLine.tblQuoteOptionsRow[] tblQuoteOptionsRowArray2 = (dsSelectOneOptionPerLine.tblQuoteOptionsRow[]) tblQuoteOptions2.Select(filterExpression2);
            if (tblQuoteOptionsRowArray2.Length > 1)
              throw new InvalidOperationException("Should only be one unbound option for this line at this point");
            tblQuoteOptionsRowArray2[0].Selected = true;
          }
          else
            tblQuoteOptionsRowArray1[0].Selected = true;
        }
      }
      finally
      {
        IEnumerator<dsSelectOneOptionPerLine.lstLinesRow> enumerator;
        enumerator?.Dispose();
      }
    }
    this.btnSave_Click((object) this, EventArgs.Empty);
  }

  public virtual bool AutoSaveFirstOption() => false;

  private void dgOptions_ClickCell(object sender, ClickCellEventArgs e)
  {
    this.UpdateOptionDetail();
  }

  private void UpdateOptionDetail()
  {
    this.lblOptionDescription.Text = string.Empty;
    if (((UltraGridBase) this.dgOptions).ActiveRow == null)
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      MDIControls.Instance.StatusBarText = "Reading premium value from rater...";
      Guid guid = (Guid) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["QuoteOptionGuid"].Value;
      string empty = string.Empty;
      if (this._optionDescriptionDictionary.TryGetValue(guid, out empty))
      {
        this.lblOptionDescription.Text = empty;
      }
      else
      {
        int? nullable = DefaultDatabase.ExecuteFunction<int?>("dbo.GetRaterIDUsedOnOption", new object[2]
        {
          (object) "@quoteOptionGuid",
          (object) guid
        });
        if (!nullable.HasValue)
        {
          this.lblOptionDescription.Text = "Could not determine the rater used on the quote option";
          this._optionDescriptionDictionary.Add(guid, this.lblOptionDescription.Text);
        }
        else
        {
          IRater rater = RaterFactory.GetRater(nullable.Value);
          if (rater == null)
          {
            this.lblOptionDescription.Text = "Could not associate a rater to this quote. Please contact your system admin.";
            this._optionDescriptionDictionary.Add(guid, this.lblOptionDescription.Text);
          }
          else
          {
            QuoteOption quoteOption = new QuoteOption(guid);
            if (!DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT dbo.GetQuoteOptionCompanyLineGuid(@quoteOptionID)", new object[2]
            {
              (object) "@quoteOptionID",
              (object) quoteOption.QuoteOptionID
            }).HasValue)
              return;
            rater.InitializeState(this._quoteGuid, quoteOption.CompanyLineGuid);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(rater.GetOptionDescription(guid));
            this.lblOptionDescription.Text = stringBuilder.ToString();
            this._optionDescriptionDictionary.Add(guid, this.lblOptionDescription.Text);
          }
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
      MDIControls.Instance.StatusBarText = string.Empty;
    }
  }
}
