// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormRequirements
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class FormRequirements : Form
{
  private IContainer components;

  public FormRequirements()
  {
    this.Load += new EventHandler(this.FormRequirements_Load);
    this.InitializeComponent();
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("lstBindingRequirements", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("BindingRequirementID", -1, (object) "ddRequirements");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("BindingRequirement");
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
    Appearance appearance11 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormRequirements));
    this.ugRequirements = new UltraGrid();
    this.ds = new dsRequirements();
    this.btnSave = new MGAButton();
    this.lnkCancelRequirement = new LinkLabel();
    this.lnkAddRequirement = new LinkLabel();
    ((ISupportInitialize) this.ugRequirements).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.SuspendLayout();
    ((Control) this.ugRequirements).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugRequirements).DataMember = "lstBindingRequirements";
    ((UltraGridBase) this.ugRequirements).DataSource = (object) this.ds;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Style = (ColumnStyle) 6;
    ultraGridColumn1.Width = 268;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Requirement";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 419;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ugRequirements).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugRequirements).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugRequirements).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugRequirements).Location = new Point(12, 12);
    ((Control) this.ugRequirements).Name = "ugRequirements";
    ((Control) this.ugRequirements).Size = new Size(440, 368);
    ((Control) this.ugRequirements).TabIndex = 309;
    ((Control) this.ugRequirements).Text = "Available Requirements";
    ((UltraControlBase) this.ugRequirements).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugRequirements).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsRequirements";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance11.BackColor = Color.FromArgb(248, 248, 248);
    appearance11.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance11.BackGradientStyle = (GradientStyle) 2;
    appearance11.BorderColor = Color.DarkGray;
    appearance11.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance11.Image"));
    appearance11.ImageHAlign = (HAlign) 1;
    appearance11.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance11;
    ((Control) this.btnSave).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnSave).Location = new Point(367, 414);
    ((Control) this.btnSave).Name = "btnSave";
    ((ControlBase) this.btnSave).Padding = new Size(5, 0);
    ((Control) this.btnSave).Size = new Size(85, 40);
    ((Control) this.btnSave).TabIndex = 330;
    ((ControlBase) this.btnSave).Text = "Save";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkCancelRequirement.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCancelRequirement.AutoSize = true;
    this.lnkCancelRequirement.Location = new Point(9, 441);
    this.lnkCancelRequirement.Name = "lnkCancelRequirement";
    this.lnkCancelRequirement.Size = new Size(103, 13);
    this.lnkCancelRequirement.TabIndex = 329;
    this.lnkCancelRequirement.TabStop = true;
    this.lnkCancelRequirement.Text = "Cancel Requirement";
    this.lnkAddRequirement.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAddRequirement.AutoSize = true;
    this.lnkAddRequirement.Location = new Point(9, 401);
    this.lnkAddRequirement.Name = "lnkAddRequirement";
    this.lnkAddRequirement.Size = new Size(89, 13);
    this.lnkAddRequirement.TabIndex = 328;
    this.lnkAddRequirement.TabStop = true;
    this.lnkAddRequirement.Text = "Add Requirement";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(464, 466);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lnkCancelRequirement);
    this.Controls.Add((Control) this.lnkAddRequirement);
    this.Controls.Add((Control) this.ugRequirements);
    this.Name = nameof (FormRequirements);
    this.Text = "Requirements Administration";
    ((ISupportInitialize) this.ugRequirements).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("ugRequirements")]
  private virtual UltraGrid ugRequirements { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  internal virtual LinkLabel lnkCancelRequirement
  {
    get => this._lnkCancelRequirement;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCancelRequirement_LinkClicked);
      LinkLabel cancelRequirement1 = this._lnkCancelRequirement;
      if (cancelRequirement1 != null)
        cancelRequirement1.LinkClicked -= clickedEventHandler;
      this._lnkCancelRequirement = value;
      LinkLabel cancelRequirement2 = this._lnkCancelRequirement;
      if (cancelRequirement2 == null)
        return;
      cancelRequirement2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkAddRequirement
  {
    get => this._lnkAddRequirement;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddRequirement_LinkClicked);
      LinkLabel lnkAddRequirement1 = this._lnkAddRequirement;
      if (lnkAddRequirement1 != null)
        lnkAddRequirement1.LinkClicked -= clickedEventHandler;
      this._lnkAddRequirement = value;
      LinkLabel lnkAddRequirement2 = this._lnkAddRequirement;
      if (lnkAddRequirement2 == null)
        return;
      lnkAddRequirement2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsRequirements ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void lnkAddRequirement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ((UltraGridBase) this.ugRequirements).DisplayLayout.Bands[0].AddNew();
  }

  private void FormRequirements_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstBindingRequirements"
    }, CommandType.Text, "SELECT BindingRequirementID, BindingRequirement FROM lstBindingRequirements ORDER BY BindingRequirement");
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugRequirements).Rows)
    {
      if (row.Cells["BindingRequirement"].Value == DBNull.Value || row.Cells["BindingRequirement"].Value == null)
      {
        int num = (int) MessageBox.Show("Please enter a requirement", "Missing Requirement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
    }
    string str = string.Empty;
    try
    {
      foreach (dsRequirements.lstBindingRequirementsRow row in this.ds.lstBindingRequirements.Rows)
      {
        if (row.RowState == DataRowState.Deleted)
          str = $"{str}{row["BindingRequirement", DataRowVersion.Original].ToString()}\n";
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.UpdateRequirements();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      if (ex.Message.Contains("FK_tblCompanyLineBindingRequirements_lstBindingRequirements"))
      {
        int num = (int) MessageBox.Show("One or more of the following requirement(s) has already been applied and cannot be deleted ... \n\n" + str, "Requirements Applied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
      else
        throw;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this.Close();
  }

  private void lnkCancelRequirement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ds.lstBindingRequirements.RejectChanges();
    ((UltraGridBase) this.ugRequirements).UpdateData();
    this.ds.lstBindingRequirements.RejectChanges();
    ((UltraGridBase) this.ugRequirements).UpdateData();
  }

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

  private void UpdateRequirements()
  {
    using (DbDataAdapter dbDataAdapter = DefaultDatabase.BuildDataAdapter((DataTable) this.ds.lstBindingRequirements, "dbo.InsertRequirements", "dbo.UpdateRequirements", "dbo.DeleteRequirements", true, 30, (DbTransaction) null))
      DefaultDatabase.DataAdapterUpdate(dbDataAdapter, (DataTable) this.ds.lstBindingRequirements);
  }
}
