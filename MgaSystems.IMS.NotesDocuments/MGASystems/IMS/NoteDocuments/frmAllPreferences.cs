// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmAllPreferences
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.NoteDocuments.Serialization;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
[SecureResource("{4CFAA8DA-73F9-41b9-BA6E-E03972211D63}", "Preferences Screen", "Controls all user preferences. Should be used with caution by power users only", "Preferences")]
public class frmAllPreferences : Form
{
  [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "Member")]
  [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", MessageId = "Member")]
  public const string SECURITYID_PREFERENCES = "{4CFAA8DA-73F9-41b9-BA6E-E03972211D63}";
  private IContainer components;
  private int _col0Width;

  public frmAllPreferences()
  {
    this.Load += new EventHandler(this.frmAllPreferences_Load);
    this._col0Width = -1;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid UltraGrid1
  {
    get => this._UltraGrid1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.UltraGrid1_InitializeLayout);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.UltraGrid1_InitializeRow);
      EventHandler eventHandler = new EventHandler(this.UltraGrid1_DoubleClick);
      UltraGrid ultraGrid1_1 = this._UltraGrid1;
      if (ultraGrid1_1 != null)
      {
        ultraGrid1_1.InitializeLayout -= layoutEventHandler;
        ultraGrid1_1.InitializeRow -= initializeRowEventHandler;
        ((Control) ultraGrid1_1).DoubleClick -= eventHandler;
      }
      this._UltraGrid1 = value;
      UltraGrid ultraGrid1_2 = this._UltraGrid1;
      if (ultraGrid1_2 == null)
        return;
      ultraGrid1_2.InitializeLayout += layoutEventHandler;
      ultraGrid1_2.InitializeRow += initializeRowEventHandler;
      ((Control) ultraGrid1_2).DoubleClick += eventHandler;
    }
  }

  private virtual ContextMenu ContextMenu1
  {
    get => this._ContextMenu1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ContextMenu1_Popup);
      ContextMenu contextMenu1_1 = this._ContextMenu1;
      if (contextMenu1_1 != null)
        contextMenu1_1.Popup -= eventHandler;
      this._ContextMenu1 = value;
      ContextMenu contextMenu1_2 = this._ContextMenu1;
      if (contextMenu1_2 == null)
        return;
      contextMenu1_2.Popup += eventHandler;
    }
  }

  private virtual MenuItem mnuReset
  {
    get => this._mnuReset;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuReset_Click);
      MenuItem mnuReset1 = this._mnuReset;
      if (mnuReset1 != null)
        mnuReset1.Click -= eventHandler;
      this._mnuReset = value;
      MenuItem mnuReset2 = this._mnuReset;
      if (mnuReset2 == null)
        return;
      mnuReset2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuAdjust
  {
    get => this._mnuAdjust;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuAdjust_Click);
      MenuItem mnuAdjust1 = this._mnuAdjust;
      if (mnuAdjust1 != null)
        mnuAdjust1.Click -= eventHandler;
      this._mnuAdjust = value;
      MenuItem mnuAdjust2 = this._mnuAdjust;
      if (mnuAdjust2 == null)
        return;
      mnuAdjust2.Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.UltraGrid1 = new UltraGrid();
    this.ContextMenu1 = new ContextMenu();
    this.mnuReset = new MenuItem();
    this.mnuAdjust = new MenuItem();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraGrid1).ContextMenu = this.ContextMenu1;
    ((Control) this.UltraGrid1).Dock = DockStyle.Fill;
    ((Control) this.UltraGrid1).Location = new Point(0, 0);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(848, 558);
    ((Control) this.UltraGrid1).TabIndex = 0;
    this.ContextMenu1.MenuItems.AddRange(new MenuItem[2]
    {
      this.mnuReset,
      this.mnuAdjust
    });
    this.mnuReset.Index = 0;
    this.mnuReset.Text = "Reset";
    this.mnuAdjust.Index = 1;
    this.mnuAdjust.Text = "Modify";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(848, 558);
    this.Controls.Add((Control) this.UltraGrid1);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (frmAllPreferences);
    this.Text = "IMS Configuration";
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.ResumeLayout(false);
  }

  private void frmAllPreferences_Load(object sender, EventArgs e)
  {
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) Preferences.CurrentPreferencesTable;
    int num = (int) MessageBox.Show("Incorrectly setting preferences can cause unusual or unwanted behavior in the system. Please use extreme caution.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
  }

  private void UltraGrid1_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    UltraGridLayout layout = e.Layout;
    UltraGridBand band = layout.Bands[0];
    UltraGridOverride ultraGridOverride1 = band.Override;
    ultraGridOverride1.CellClickAction = (CellClickAction) 2;
    ultraGridOverride1.HeaderClickAction = (HeaderClickAction) 2;
    band.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    if (this._col0Width == -1)
      this._col0Width = e.Layout.Bands[0].Columns[0].Width * 2;
    band.Columns[0].Width = this._col0Width;
    ((HeaderBase) band.Columns[0].Header).Caption = "Preference Name";
    ((HeaderBase) band.Columns[1].Header).Caption = "Status";
    ((HeaderBase) band.Columns[2].Header).Caption = "Type";
    ((HeaderBase) band.Columns[3].Header).Caption = "Value";
    band.Columns[4].Hidden = true;
    band.Columns[5].Hidden = true;
    UltraGridOverride ultraGridOverride2 = layout.Override;
    ultraGridOverride2.BorderStyleRow = (UIElementBorderStyle) 1;
    ultraGridOverride2.BorderStyleCell = (UIElementBorderStyle) 1;
    ultraGridOverride2.AllowColMoving = (AllowColMoving) 1;
    ultraGridOverride2.RowSelectors = (DefaultableBoolean) 2;
    ultraGridOverride2.AllowUpdate = (DefaultableBoolean) 2;
    layout.Appearance.BackColor = Color.White;
    layout.BorderStyle = (UIElementBorderStyle) 1;
  }

  private void UltraGrid1_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (Operators.CompareString(Conversions.ToString(e.Row.Cells["Status"].Value), "default", false) == 0)
      return;
    e.Row.Appearance.FontData.Bold = (DefaultableBoolean) 1;
  }

  private string AdjustValue(string preferenceName)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(Preferences.GetPreference(preferenceName));
    object obj;
    if (objectValue is bool)
    {
      obj = (object) !Conversions.ToBoolean(objectValue);
      Preferences.SetPreference(preferenceName, RuntimeHelpers.GetObjectValue(obj));
    }
    else
    {
      obj = RuntimeHelpers.GetObjectValue(objectValue);
      string str = objectValue.ToString();
      using (frmModifyPreference modifyPreference = new frmModifyPreference(preferenceName, objectValue.GetType().ToString(), str))
      {
        if (modifyPreference.ShowDialog((IWin32Window) this) == DialogResult.OK)
        {
          if (modifyPreference.IsModified)
          {
            Preferences.SetPreference(preferenceName, RuntimeHelpers.GetObjectValue(Preferences.TranslatePreferenceValueStringToObject(modifyPreference.NewValue, objectValue.GetType().ToString())));
            obj = (object) modifyPreference.NewValue;
          }
        }
      }
    }
    return obj.ToString();
  }

  private static bool IsToggle(string preferenceName)
  {
    return RuntimeHelpers.GetObjectValue(Preferences.GetPreference(preferenceName)) is bool;
  }

  private void UltraGrid1_DoubleClick(object sender, EventArgs e)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(((ControlUIElementBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridRow), true));
    if (objectValue == null)
      return;
    UltraGridRow ultraGridRow = (UltraGridRow) objectValue;
    string preferenceName = Conversions.ToString(ultraGridRow.Cells["Preference"].Value);
    string Right1 = Conversions.ToString(ultraGridRow.Cells["Value"].Value);
    string Right2 = Conversions.ToString(ultraGridRow.Cells["Default"].Value);
    string Left = this.AdjustValue(preferenceName);
    if (Operators.CompareString(Left, Right1, false) == 0)
      return;
    ultraGridRow.Cells["Value"].Value = (object) Left;
    if (Operators.CompareString(Left, Right2, false) == 0)
      ultraGridRow.Appearance.FontData.Bold = (DefaultableBoolean) 2;
    else
      ultraGridRow.Appearance.FontData.Bold = (DefaultableBoolean) 1;
  }

  private void ContextMenu1_Popup(object sender, EventArgs e)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(((ControlUIElementBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridRow), true));
    if (objectValue != null)
    {
      UltraGridRow ultraGridRow = (UltraGridRow) objectValue;
      string preferenceName = Conversions.ToString(ultraGridRow.Cells["Preference"].Value);
      this.mnuReset.Enabled = Operators.CompareString(Conversions.ToString(ultraGridRow.Cells["Value"].Value), Conversions.ToString(ultraGridRow.Cells["Default"].Value), false) != 0;
      this.mnuAdjust.Visible = true;
      this.mnuAdjust.Text = !frmAllPreferences.IsToggle(preferenceName) ? "Modify" : "Toggle";
      this.mnuReset.Text = "Reset";
    }
    else
    {
      this.mnuReset.Enabled = true;
      this.mnuReset.Text = "Reset All Preferences";
      this.mnuAdjust.Visible = false;
    }
  }

  private void mnuReset_Click(object sender, EventArgs e)
  {
    string preferenceName = this.UltraGrid1.Selected.Rows[0].Cells["Preference"].Value.ToString();
    string Right = this.UltraGrid1.Selected.Rows[0].Cells["Value"].Value.ToString();
    string Left = this.UltraGrid1.Selected.Rows[0].Cells["Default"].Value.ToString();
    if (Operators.CompareString(Left, Right, false) != 0)
    {
      this.UltraGrid1.Selected.Rows[0].Cells["Value"].Value = (object) Left;
      this.UltraGrid1.Selected.Rows[0].Appearance.FontData.Bold = (DefaultableBoolean) 2;
      Preferences.ResetPreference(preferenceName);
    }
    else
    {
      Preferences.ResetPreferences();
      ((UltraGridBase) this.UltraGrid1).DataSource = (object) Preferences.CurrentPreferencesTable;
    }
  }

  private void mnuAdjust_Click(object sender, EventArgs e)
  {
    string preferenceName = this.UltraGrid1.Selected.Rows[0].Cells["Preference"].Value.ToString();
    string Right1 = this.UltraGrid1.Selected.Rows[0].Cells["Value"].Value.ToString();
    string Right2 = this.UltraGrid1.Selected.Rows[0].Cells["Default"].Value.ToString();
    string Left = this.AdjustValue(preferenceName);
    if (Operators.CompareString(Left, Right1, false) == 0)
      return;
    this.UltraGrid1.Selected.Rows[0].Cells["Value"].Value = (object) Left;
    if (Operators.CompareString(Left, Right2, false) == 0)
      this.UltraGrid1.Selected.Rows[0].Appearance.FontData.Bold = (DefaultableBoolean) 2;
    else
      this.UltraGrid1.Selected.Rows[0].Appearance.FontData.Bold = (DefaultableBoolean) 1;
  }
}
