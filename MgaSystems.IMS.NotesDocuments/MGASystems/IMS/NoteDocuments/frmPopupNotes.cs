// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmPopupNotes
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.InfragisticsExtensions.Editors;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmPopupNotes : Form, IPopupNoteForm
{
  private Guid _controlGuid;
  private Guid _entityGuid;
  private IContainer components;
  private dsPolicyPopups DsPolicyPopups;

  internal virtual BackgroundWorker BackgroundWorker
  {
    get => this._BackgroundWorker;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker_DoWork);
      RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
      BackgroundWorker backgroundWorker1 = this._BackgroundWorker;
      if (backgroundWorker1 != null)
      {
        backgroundWorker1.DoWork -= workEventHandler;
        backgroundWorker1.RunWorkerCompleted -= completedEventHandler;
      }
      this._BackgroundWorker = value;
      BackgroundWorker backgroundWorker2 = this._BackgroundWorker;
      if (backgroundWorker2 == null)
        return;
      backgroundWorker2.DoWork += workEventHandler;
      backgroundWorker2.RunWorkerCompleted += completedEventHandler;
    }
  }

  public frmPopupNotes(Guid controlGuid, Guid entityGuid)
  {
    this.Load += new EventHandler(this.frmPopupNotes_Load);
    this.InitializeComponent();
    this._controlGuid = controlGuid;
    this._entityGuid = entityGuid;
  }

  private virtual UltraGrid MgaGrid1
  {
    get => this._MgaGrid1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MgaGrid1_Click);
      UltraGrid mgaGrid1_1 = this._MgaGrid1;
      if (mgaGrid1_1 != null)
        ((Control) mgaGrid1_1).Click -= eventHandler;
      this._MgaGrid1 = value;
      UltraGrid mgaGrid1_2 = this._MgaGrid1;
      if (mgaGrid1_2 == null)
        return;
      ((Control) mgaGrid1_2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblNoteEntries", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CreatedDate");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Body");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPopupNotes));
    this.MgaGrid1 = new UltraGrid();
    this.DsPolicyPopups = new dsPolicyPopups();
    this.PictureBox1 = new PictureBox();
    this.Label1 = new Label();
    this.BackgroundWorker = new BackgroundWorker();
    ((ISupportInitialize) this.MgaGrid1).BeginInit();
    this.DsPolicyPopups.BeginInit();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.MgaGrid1).DataSource = (object) this.DsPolicyPopups.tblNoteEntries;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Format = "d";
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Created";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 83;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Note";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 459;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.MgaGrid1).Location = new Point(9, 64 /*0x40*/);
    ((Control) this.MgaGrid1).Name = "MgaGrid1";
    ((Control) this.MgaGrid1).Size = new Size(544, 136);
    ((Control) this.MgaGrid1).TabIndex = 0;
    ((UltraControlBase) this.MgaGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaGrid1).UseOsThemes = (DefaultableBoolean) 2;
    this.DsPolicyPopups.DataSetName = "dsPolicyPopups";
    this.DsPolicyPopups.Locale = new CultureInfo("en-US");
    this.DsPolicyPopups.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(8, 8);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(56, 48 /*0x30*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox1.TabIndex = 1;
    this.PictureBox1.TabStop = false;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 10f);
    this.Label1.Location = new Point(72, 24);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(368, 17);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "The following important notes are associated with this item:";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(562, 208 /*0xD0*/);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) this.MgaGrid1);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Location = new Point(10, 10);
    this.Name = nameof (frmPopupNotes);
    this.StartPosition = FormStartPosition.Manual;
    this.Text = "Pop-Up Notes";
    this.TopMost = true;
    ((ISupportInitialize) this.MgaGrid1).EndInit();
    this.DsPolicyPopups.EndInit();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "parent")]
  public void ShowPopup()
  {
    ((UltraGridBase) this.MgaGrid1).DataSource = (object) null;
    this.BackgroundWorker.RunWorkerAsync();
  }

  private void AddGuidParam(
    Dictionary<string, DbParameter> parameters,
    string paramName,
    Guid paramValue)
  {
    if (paramValue.Equals(Guid.Empty))
      return;
    parameters.Add(paramName, DefaultDatabase.CreateParameter(ParameterDirection.Input, paramName, (object) paramValue));
  }

  private static void SizeGrid(UltraGrid ug)
  {
    if (((UltraGridBase) ug).Rows.Count == 0)
      ((Control) ug).Height = 0;
    else
      ((Control) ug).Height = ((UltraGridBase) ug).Rows[0].Height * ((UltraGridBase) ug).Rows.Count;
    if (((Control) ug).Height <= 0)
      return;
    UltraGrid ultraGrid;
    int num = ((Control) (ultraGrid = ug)).Height + (((UltraGridBase) ug).Rows[0].Height * 2 + 20);
    ((Control) ultraGrid).Height = num;
  }

  private void MgaGrid1_Click(object sender, EventArgs e)
  {
    UIElement lastElementEntered = ((ControlUIElementBase) ((UltraGridBase) this.MgaGrid1).DisplayLayout.UIElement).LastElementEntered;
    if (lastElementEntered == null)
      return;
    UIElement ancestor = lastElementEntered.GetAncestor(typeof (CellUIElement));
    if (ancestor == null)
      return;
    UltraGridCell context = (UltraGridCell) ancestor.GetContext(typeof (UltraGridCell));
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Column.Key, "Body", false) != 0)
      return;
    ObjectFactory instance = ObjectFactory.Instance;
    Type baseType = typeof (NoteOverrideInformation);
    object[] objArray1 = new object[2]
    {
      (object) "viewing popup note",
      null
    };
    object[] objArray2 = new object[2];
    object obj1 = context.Row.Cells["NoteGuid"].Value;
    objArray2[0] = (object) (obj1 != null ? (Guid) obj1 : new Guid());
    object obj2 = context.Row.Cells["EntryGuid"].Value;
    objArray2[1] = (object) (obj2 != null ? (Guid) obj2 : new Guid());
    objArray1[1] = (object) objArray2;
    if (instance.CreateObjectEX(baseType, objArray1) is NoteOverrideInformation objectEx && objectEx.CancelOperation)
    {
      objectEx.PerformOverrideAction();
    }
    else
    {
      Note_System.UIInteractiveNoteManipulator uiInteractive = Note_System.Instance.UIInteractive;
      object obj3 = context.Row.Cells["NoteGuid"].Value;
      Guid noteGUID = obj3 != null ? (Guid) obj3 : new Guid();
      uiInteractive.ViewNote(noteGUID);
    }
  }

  private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
  {
    try
    {
      Dictionary<string, DbParameter> parameters = new Dictionary<string, DbParameter>();
      this.AddGuidParam(parameters, "@controlGuid", this._controlGuid);
      this.AddGuidParam(parameters, "@entityGuid", this._entityGuid);
      if (parameters.Count <= 0)
        return;
      DefaultDatabase.LoadDataTable((DataTable) this.DsPolicyPopups.tblNoteEntries, CommandType.StoredProcedure, "NoteSystem_FetchPopupNotes", (CommandArgumentType) 2, new object[1]
      {
        (object) parameters
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    if (this.DsPolicyPopups.tblNoteEntries.Count <= 0)
      return;
    if (this.Parent == null)
      this.Show();
    else
      this.Show((IWin32Window) this.Parent);
  }

  private void frmPopupNotes_Load(object sender, EventArgs e)
  {
    ((UltraGridBase) this.MgaGrid1).DataSource = (object) this.DsPolicyPopups.tblNoteEntries;
    HyperlinkEditor hyperlinkEditor = new HyperlinkEditor();
    ColumnsCollection columns = ((UltraGridBase) this.MgaGrid1).DisplayLayout.Bands[0].Columns;
    columns["Body"].Editor = (EmbeddableEditorBase) hyperlinkEditor;
    ((HeaderBase) columns["Body"].Header).Caption = "Content (click to open note)";
    columns["NoteGuid"].Hidden = true;
    columns["EntryGuid"].Hidden = true;
    ((HeaderBase) columns["CreatedDate"].Header).Caption = "Date";
    columns["CreatedDate"].Format = "d";
    columns["CreatedDate"].Width = 40;
    ((UltraGridBase) this.MgaGrid1).DisplayLayout.Override.ActiveRowAppearance.Reset();
    frmPopupNotes.SizeGrid(this.MgaGrid1);
    this.Height = ((Control) this.MgaGrid1).Bottom + 80 /*0x50*/;
    ((Control) this.MgaGrid1).Enabled = true;
  }
}
