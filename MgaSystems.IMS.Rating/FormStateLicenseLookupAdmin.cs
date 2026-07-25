// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormStateLicenseLookupAdmin
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
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
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormStateLicenseLookupAdmin : Form
{
  private IContainer components;
  private Guid _userGuid;

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
    UltraGridBand ultraGridBand = new UltraGridBand("lstLicenseValidationStates", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Lookup");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.ugAvail = new UltraGrid();
    this.ds = new dsDriverRenewal();
    ((ISupportInitialize) this.ugAvail).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.ugAvail).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugAvail).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugAvail).DataMember = "lstLicenseValidationStates";
    ((UltraGridBase) this.ugAvail).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugAvail).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 2;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 141;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 0;
    ultraGridColumn2.Width = 316;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Width = 129;
    ultraGridBand.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.ugAvail).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugAvail).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugAvail).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugAvail).Location = new Point(11, 10);
    ((Control) this.ugAvail).Margin = new Padding(1);
    ((Control) this.ugAvail).Name = "ugAvail";
    ((Control) this.ugAvail).Size = new Size(447, 574);
    ((Control) this.ugAvail).TabIndex = 14;
    ((Control) this.ugAvail).Text = " - Available Lookup States - ";
    ((UltraControlBase) this.ugAvail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugAvail).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsDriverRenewal";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(468, 594);
    this.Controls.Add((Control) this.ugAvail);
    this.Name = nameof (FormStateLicenseLookupAdmin);
    this.Text = "Admin State License Lookup";
    ((ISupportInitialize) this.ugAvail).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  private virtual UltraGrid ugAvail
  {
    get => this._ugAvail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler = new CellEventHandler(this.ugAvail_CellChange);
      UltraGrid ugAvail1 = this._ugAvail;
      if (ugAvail1 != null)
        ugAvail1.CellChange -= cellEventHandler;
      this._ugAvail = value;
      UltraGrid ugAvail2 = this._ugAvail;
      if (ugAvail2 == null)
        return;
      ugAvail2.CellChange += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsDriverRenewal ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormStateLicenseLookupAdmin()
  {
    this.Load += new EventHandler(this.FormStateLicenseLookupAdmin_Load);
    this.InitializeComponent();
    this._userGuid = CurrentUser.Instance.UserGUID;
  }

  private void FormStateLicenseLookupAdmin_Load(object sender, EventArgs e)
  {
    string[] strArray = new string[2]
    {
      "lstLicenseValidationStates",
      "tblDriverLicenseValidationStates"
    };
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, strArray, CommandType.Text, "SELECT StateID, State from lstStates ORDER BY State; select StateID from tblDriverLicenseValidationStates");
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    this.ugAvail.CellChange -= new CellEventHandler(this.ugAvail_CellChange);
    try
    {
      try
      {
        foreach (dsDriverRenewal.lstLicenseValidationStatesRow row in this.ds.lstLicenseValidationStates.Rows)
        {
          if (this.ds.tblDriverLicenseValidationStates.FindByStateID(row.StateID) != null)
            row.Lookup = true;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    finally
    {
      this.ugAvail.CellChange += new CellEventHandler(this.ugAvail_CellChange);
    }
  }

  private void ugAvail_CellChange(object sender, CellEventArgs e)
  {
    if (e.Cell == null || e.Cell.Row == null || e.Cell.Value == null)
      return;
    if (!e.Cell.Column.Key.Equals("Lookup"))
      return;
    try
    {
      Cursor.Current = Cursors.WaitCursor;
      string empty = string.Empty;
      string str = e.Cell.Row.Cells["StateID"].Value.ToString();
      if ((bool) e.Cell.Value)
      {
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblDriverLicenseValidationStates WHERE StateID=@ST", new object[2]
        {
          (object) "@ST",
          (object) str
        });
        CurrentUser.Instance.LogAction($"Driver License Validation Lookup States -  Removed {str}", this._userGuid);
      }
      else
      {
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblDriverLicenseValidationStates(StateID) VALUES (@ST)", new object[2]
        {
          (object) "@ST",
          (object) str
        });
        CurrentUser.Instance.LogAction($"Driver License Validation Lookup States -  Added {str}", this._userGuid);
      }
      ((UltraGridBase) this.ugAvail).UpdateData();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
    }
  }
}
