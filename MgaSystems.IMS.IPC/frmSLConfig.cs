// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.frmSLConfig
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
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
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class frmSLConfig : Form
{
  private IContainer components;
  private int _companyFeeId;
  private string _stateId;
  protected DataTable _dtStates;
  private string lastHeader;

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
    UltraGridBand ultraGridBand = new UltraGridBand("Band 0", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Exclude");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("HomeState");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("StateID");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    this.btnSave = new MGAButton();
    this.ugStates = new UltraGrid();
    this.btnUndo = new MGAButton();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.ugStates).BeginInit();
    ((ISupportInitialize) this.btnUndo).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnSave).Location = new Point(261, 261);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnSave).TabIndex = 5;
    ((ControlBase) this.btnSave).Text = "&Save && Close";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.ugStates).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugStates).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ugStates).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 104;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Style = (ColumnStyle) 3;
    ultraGridColumn2.Width = 112 /*0x70*/;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Home State";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Style = (ColumnStyle) 3;
    ultraGridColumn3.Width = 110;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 78;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugStates).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugStates).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugStates).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugStates).Location = new Point(12, 12);
    ((Control) this.ugStates).Name = "ugStates";
    ((Control) this.ugStates).Size = new Size(345, 243);
    ((Control) this.ugStates).TabIndex = 6;
    ((UltraControlBase) this.ugStates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugStates).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnUndo).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance11.BackColor = Color.FromArgb(248, 248, 248);
    appearance11.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance11.BackGradientStyle = (GradientStyle) 2;
    appearance11.BorderColor = Color.DarkGray;
    appearance11.ImageHAlign = (HAlign) 2;
    appearance11.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnUndo).Appearance = (AppearanceBase) appearance11;
    ((Control) this.btnUndo).Location = new Point(12, 261);
    ((Control) this.btnUndo).Name = "btnUndo";
    ((Control) this.btnUndo).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnUndo).TabIndex = 5;
    ((ControlBase) this.btnUndo).Text = "&Undo Changes";
    this.btnUndo.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(369, 297);
    this.Controls.Add((Control) this.ugStates);
    this.Controls.Add((Control) this.btnUndo);
    this.Controls.Add((Control) this.btnSave);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSLConfig);
    this.Text = "Surplus Lines Config";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.ugStates).EndInit();
    ((ISupportInitialize) this.btnUndo).EndInit();
    this.ResumeLayout(false);
  }

  protected internal virtual MGAButton btnSave
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

  protected internal virtual UltraGrid ugStates
  {
    get => this._ugStates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler = new CellEventHandler(this.ugStates_CellChange);
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.ugStates_MouseUp);
      UltraGrid ugStates1 = this._ugStates;
      if (ugStates1 != null)
      {
        ugStates1.CellChange -= cellEventHandler;
        ((Control) ugStates1).MouseUp -= mouseEventHandler;
      }
      this._ugStates = value;
      UltraGrid ugStates2 = this._ugStates;
      if (ugStates2 == null)
        return;
      ugStates2.CellChange += cellEventHandler;
      ((Control) ugStates2).MouseUp += mouseEventHandler;
    }
  }

  protected internal virtual MGAButton btnUndo
  {
    get => this._btnUndo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUndo_Click);
      MGAButton btnUndo1 = this._btnUndo;
      if (btnUndo1 != null)
        ((Control) btnUndo1).Click -= eventHandler;
      this._btnUndo = value;
      MGAButton btnUndo2 = this._btnUndo;
      if (btnUndo2 == null)
        return;
      ((Control) btnUndo2).Click += eventHandler;
    }
  }

  public frmSLConfig(int companyFeeId, string stateId)
  {
    this.Load += new EventHandler(this.frmSLConfig_Load);
    this.lastHeader = string.Empty;
    this.InitializeComponent();
    this._companyFeeId = companyFeeId;
    this._stateId = stateId;
  }

  public frmSLConfig()
  {
    this.Load += new EventHandler(this.frmSLConfig_Load);
    this.lastHeader = string.Empty;
    this.InitializeComponent();
  }

  private void frmSLConfig_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this._dtStates = DefaultDatabase.ExecuteDataTable("spSLConfigLoad", new object[2]
    {
      (object) "@CompanyFeeId",
      (object) this._companyFeeId
    });
    this._dtStates.AcceptChanges();
    ((UltraGridBase) this.ugStates).DataSource = (object) this._dtStates;
    ((UltraGridBase) this.ugStates).DataBind();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblSLConfig WHERE CompanyFeeId = @CompanyFeeId", new object[2]
    {
      (object) "@CompanyFeeId",
      (object) this._companyFeeId
    });
    try
    {
      foreach (DataRow row in this._dtStates.Rows)
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblSLConfig (CompanyFeeId, StateId, HomeState, Exclude) VALUES (@CompanyFeeId, @StateId, @HomeState, @Exclude) ", new object[8]
        {
          (object) "@CompanyFeeId",
          (object) this._companyFeeId,
          (object) "@StateId",
          row["StateId"],
          (object) "@HomeState",
          row["HomeState"],
          (object) "@Exclude",
          row["Exclude"]
        });
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.Close();
  }

  private void ugStates_CellChange(object sender, CellEventArgs e)
  {
    this.ugStates.PerformAction((UltraGridAction) 47);
    bool flag = (bool) e.Cell.Value;
    if (!flag)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "Exclude", false) == 0)
      e.Cell.Row.Cells["HomeState"].Value = (object) !flag;
    else
      e.Cell.Row.Cells["Exclude"].Value = (object) !flag;
  }

  private void ugStates_MouseUp(object sender, MouseEventArgs e)
  {
    UltraGrid ultraGrid = (UltraGrid) sender;
    if (!(((ControlUIElementBase) ((UltraGridBase) ultraGrid).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (ColumnHeader)) is ColumnHeader context) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((HeaderBase) context).Column.Key, "Exclude", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((HeaderBase) context).Column.Key, "HomeState", false) != 0)
      return;
    bool flag = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((HeaderBase) context).Column.Key, this.lastHeader, false) != 0;
    UltraGridColumn column = ((UltraGridBase) ultraGrid).DisplayLayout.Bands[0].Columns[Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((HeaderBase) context).Column.Key, "Exclude", false) == 0 ? "HomeState" : "Exclude"];
    this.lastHeader = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lastHeader, ((HeaderBase) context).Column.Key, false) == 0 ? string.Empty : ((HeaderBase) context).Column.Key;
    foreach (UltraGridRow row in ((UltraGridBase) ultraGrid).Rows)
    {
      row.Cells[((HeaderBase) context).Column].Value = (object) flag;
      row.Cells[column].Value = (object) false;
    }
  }

  private void btnUndo_Click(object sender, EventArgs e)
  {
    this._dtStates.RejectChanges();
    this.lastHeader = string.Empty;
    ((UltraGridBase) this.ugStates).Refresh();
  }
}
