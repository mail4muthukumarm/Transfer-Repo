// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormOvernigtOrders
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormOvernigtOrders : Form
{
  private IContainer components;
  private int _controlNo;

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
    UltraGridBand ultraGridBand = new UltraGridBand("dt", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("FirstName");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LastName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("DOB");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("StateID", -1, (object) "uddState");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("DriverID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Process");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("RecordID");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormOvernigtOrders));
    this.btnQuery = new MGAButton();
    this.lnkSelectAll = new LinkLabel();
    this.lnkDeSelect = new LinkLabel();
    this.ugDrivers = new UltraGrid();
    this.ds = new dsDriverRenewal();
    this.panelProcessingOvernightDrivers = new UltraGroupBox();
    this.spinner = new PictureBox();
    this.labelSearchText = new Label();
    Label label = new Label();
    ((ISupportInitialize) this.btnQuery).BeginInit();
    ((ISupportInitialize) this.ugDrivers).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.panelProcessingOvernightDrivers).BeginInit();
    ((Control) this.panelProcessingOvernightDrivers).SuspendLayout();
    ((ISupportInitialize) this.spinner).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnQuery).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnQuery).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnQuery).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((ControlBase) this.btnQuery).ImageSize = new Size(24, 24);
    ((Control) this.btnQuery).Location = new Point(655, 641);
    ((Control) this.btnQuery).Name = "btnQuery";
    ((Control) this.btnQuery).Size = new Size(54, 36);
    ((Control) this.btnQuery).TabIndex = 294;
    this.btnQuery.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.BackColor = Color.Transparent;
    this.lnkSelectAll.Location = new Point(9, 619);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(94, 13);
    this.lnkSelectAll.TabIndex = 295;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All Records";
    this.lnkDeSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelect.AutoSize = true;
    this.lnkDeSelect.BackColor = Color.Transparent;
    this.lnkDeSelect.Location = new Point(9, 660);
    this.lnkDeSelect.Name = "lnkDeSelect";
    this.lnkDeSelect.Size = new Size(111, 13);
    this.lnkDeSelect.TabIndex = 296;
    this.lnkDeSelect.TabStop = true;
    this.lnkDeSelect.Text = "De-Select All Records";
    ((Control) this.ugDrivers).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugDrivers).DataMember = "dt";
    ((UltraGridBase) this.ugDrivers).DataSource = (object) this.ds;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "First Name";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 2;
    ultraGridColumn1.Width = 160 /*0xA0*/;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Last Name";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 3;
    ultraGridColumn2.Width = 160 /*0xA0*/;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 4;
    ultraGridColumn3.Width = 80 /*0x50*/;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "License #";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 125;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn5.Style = (ColumnStyle) 6;
    ultraGridColumn5.Width = 65;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 0;
    ultraGridColumn6.Hidden = true;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridBand.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.ugDrivers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance3.BackColor = Color.LightSteelBlue;
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.WhiteSmoke;
    appearance10.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugDrivers).Location = new Point(12, 12);
    ((Control) this.ugDrivers).Name = "ugDrivers";
    ((Control) this.ugDrivers).Size = new Size(697, 586);
    ((Control) this.ugDrivers).TabIndex = 2;
    ((UltraControlBase) this.ugDrivers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugDrivers).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsDriverRenewal";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.panelProcessingOvernightDrivers.BackColorInternal = Color.White;
    appearance12.BorderColor = Color.Gray;
    this.panelProcessingOvernightDrivers.ContentAreaAppearance = (AppearanceBase) appearance12;
    ((Control) this.panelProcessingOvernightDrivers).Controls.Add((Control) this.spinner);
    ((Control) this.panelProcessingOvernightDrivers).Controls.Add((Control) this.labelSearchText);
    ((Control) this.panelProcessingOvernightDrivers).Controls.Add((Control) label);
    ((Control) this.panelProcessingOvernightDrivers).ForeColor = Color.Black;
    ((Control) this.panelProcessingOvernightDrivers).Location = new Point(180, 201);
    ((Control) this.panelProcessingOvernightDrivers).Name = "panelProcessingOvernightDrivers";
    ((Control) this.panelProcessingOvernightDrivers).Size = new Size(370, 140);
    ((Control) this.panelProcessingOvernightDrivers).TabIndex = 297;
    this.spinner.Image = (Image) componentResourceManager.GetObject("spinner.Image");
    this.spinner.Location = new Point(128 /*0x80*/, 81);
    this.spinner.Name = "spinner";
    this.spinner.Size = new Size(72, 44);
    this.spinner.SizeMode = PictureBoxSizeMode.Zoom;
    this.spinner.TabIndex = 116;
    this.spinner.TabStop = false;
    this.labelSearchText.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.labelSearchText.Location = new Point(10, 52);
    this.labelSearchText.Name = "labelSearchText";
    this.labelSearchText.Size = new Size(319, 19);
    this.labelSearchText.TabIndex = 3;
    this.labelSearchText.Text = "Processing '[NAME]' Record ...";
    this.labelSearchText.TextAlign = ContentAlignment.MiddleCenter;
    label.AutoSize = true;
    label.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label.Location = new Point(22, 19);
    label.Name = "Label27";
    label.Size = new Size(324, 19);
    label.TabIndex = 1;
    label.Text = "Processing Overnight Drivers ... Please Wait.";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(721, 682);
    this.Controls.Add((Control) this.panelProcessingOvernightDrivers);
    this.Controls.Add((Control) this.lnkDeSelect);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.btnQuery);
    this.Controls.Add((Control) this.ugDrivers);
    this.Name = nameof (FormOvernigtOrders);
    this.Text = "Overnigt Orders";
    ((ISupportInitialize) this.btnQuery).EndInit();
    ((ISupportInitialize) this.ugDrivers).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.panelProcessingOvernightDrivers).EndInit();
    ((Control) this.panelProcessingOvernightDrivers).ResumeLayout(false);
    ((Control) this.panelProcessingOvernightDrivers).PerformLayout();
    ((ISupportInitialize) this.spinner).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("ugDrivers")]
  protected virtual UltraGrid ugDrivers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsDriverRenewal ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnQuery
  {
    get => this._btnQuery;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnQuery_Click);
      MGAButton btnQuery1 = this._btnQuery;
      if (btnQuery1 != null)
        ((Control) btnQuery1).Click -= eventHandler;
      this._btnQuery = value;
      MGAButton btnQuery2 = this._btnQuery;
      if (btnQuery2 == null)
        return;
      ((Control) btnQuery2).Click += eventHandler;
    }
  }

  protected virtual LinkLabel lnkSelectAll
  {
    get => this._lnkSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
      LinkLabel lnkSelectAll1 = this._lnkSelectAll;
      if (lnkSelectAll1 != null)
        lnkSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAll = value;
      LinkLabel lnkSelectAll2 = this._lnkSelectAll;
      if (lnkSelectAll2 == null)
        return;
      lnkSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkDeSelect
  {
    get => this._lnkDeSelect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelect_LinkClicked);
      LinkLabel lnkDeSelect1 = this._lnkDeSelect;
      if (lnkDeSelect1 != null)
        lnkDeSelect1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelect = value;
      LinkLabel lnkDeSelect2 = this._lnkDeSelect;
      if (lnkDeSelect2 == null)
        return;
      lnkDeSelect2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("panelProcessingOvernightDrivers")]
  private virtual UltraGroupBox panelProcessingOvernightDrivers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("spinner")]
  public virtual PictureBox spinner { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelSearchText")]
  private virtual Label labelSearchText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormOvernigtOrders(int controlNo)
  {
    this.Load += new EventHandler(this.FormOvernigtOrders_Load);
    this.InitializeComponent();
    this._controlNo = controlNo;
  }

  private void FormOvernigtOrders_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnQuery).Appearance.Image = (object) ImageCache.Instance.Save;
    this.Text = $"{this.Text} for Control # {this._controlNo.ToString()}";
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ID, DriverRecord FROM tblOvernightDriverRecord WHERE RetrievedOrder=0");
    ((Control) this.panelProcessingOvernightDrivers).Visible = true;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      try
      {
        foreach (DataRow row1 in dataTable.Rows)
        {
          if (row1["DriverRecord"] != DBNull.Value)
          {
            string str = row1["DriverRecord"].ToString();
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            int minValue = int.MinValue;
            string licenseString = FormDriversInfo.GetLicenseString(str);
            FormDriversInfo.DetermineDriverFromHtmlResults(str, ref empty1, ref empty2, ref minValue, licenseString);
            if (!string.IsNullOrEmpty(empty1) && !string.IsNullOrEmpty(empty2) && minValue != int.MinValue)
            {
              DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT ControlNo, DOB, StateID  FROM tblDriverInfo WITH (NOLOCK) WHERE DriverID = @D", new object[2]
              {
                (object) "@D",
                (object) minValue
              });
              if ((dataRow == null || dataRow["ControlNo"] != DBNull.Value) && Conversions.ToInteger(dataRow["ControlNo"]) == this._controlNo && this.ds.dt.FindByDriverID(minValue) == null)
              {
                this.labelSearchText.Text = $"Retrieving overnight info for '[{empty1} {empty2}]' ...";
                dsDriverRenewal.dtRow row2 = this.ds.dt.NewdtRow();
                row2.DriverID = minValue;
                row2.FirstName = empty1;
                row2.LastName = empty2;
                row2.LicenseNumber = licenseString;
                if (dataRow["DOB"] != DBNull.Value)
                  row2.DOB = Conversions.ToDate(dataRow["DOB"]);
                if (dataRow["StateID"] != DBNull.Value)
                  row2.StateID = dataRow["StateID"].ToString();
                row2.RecordID = Conversions.ToInteger(row1["ID"]);
                row2.Process = false;
                this.ds.dt.AdddtRow(row2);
              }
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
    }
    finally
    {
      ((Control) this.panelProcessingOvernightDrivers).Visible = false;
      this.Cursor = MgaCursors.Default;
    }
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Bands[0].Columns["FirstName"].SortIndicator = (SortIndicator) 1;
  }

  private void btnQuery_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("Continue and process overnight orders?", "Process Overnight Orders?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    if (this.ds.dt.Select("Process=1").Length == 0)
    {
      int num = (int) MessageBox.Show("In order to continue, you must select as least one overnight order to process", "No Order Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      Quote docSupport = Quote.FromControlNo(this._controlNo);
      try
      {
        ((Control) this.panelProcessingOvernightDrivers).Visible = true;
        string str1 = "select DriverRecord from tblOvernightDriverRecord with (nolock) where ID=@ID";
        try
        {
          foreach (dsDriverRenewal.dtRow row in this.ds.dt.Rows)
          {
            if (!row.IsProcessNull() && row.Process)
            {
              this.labelSearchText.Text = $"Processing '[{row.FirstName} {row.LastName}]' overnight record ...";
              string str2 = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, str1, new object[2]
              {
                (object) "@ID",
                (object) row.RecordID
              });
              this.ProcessOvernightDriverStatus(str2, row.DriverID);
              string path = $"{MGATempFolder.MGATempPath}{row.FirstName}-{row.LastName}-ADR.html";
              if (File.Exists(path))
                File.Delete(path);
              using (MemoryStream memoryStream = new MemoryStream(Encoding.ASCII.GetBytes(str2)))
              {
                byte[] array = memoryStream.ToArray();
                File.WriteAllBytes(path, array);
              }
              int folderId = int.MinValue;
              if (MGASystems.Common.SystemSettings.KeyExists("ADRDocumentFolderID"))
                folderId = Convert.ToInt32(MGASystems.Common.SystemSettings.GetNumericSetting("ADRDocumentFolderID"));
              if (folderId == int.MinValue)
                DocumentManager.BeginFileAddWithBind(path, (ISupportDocumentSystem) docSupport, string.Empty);
              else
                DocumentManager.BeginFileAddWithBind(path, folderId, (ISupportDocumentSystem) docSupport, string.Empty);
              DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblOvernightDriverRecord SET RetrievedOrder = 1 WHERE ID=@ID", new object[2]
              {
                (object) "@ID",
                (object) row.RecordID
              });
            }
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
        ((Control) this.panelProcessingOvernightDrivers).Visible = false;
      }
    }
  }

  private void ProcessOvernightDriverStatus(string xmlResultString, int driverID)
  {
    if (driverID == int.MinValue || xmlResultString.Length == 0)
      return;
    int num1 = int.MinValue;
    int num2 = int.MinValue;
    if (MGASystems.Common.SystemSettings.KeyExists("ADRPassStatusID"))
      num1 = Convert.ToInt32(MGASystems.Common.SystemSettings.GetNumericSetting("ADRPassStatusID"));
    if (MGASystems.Common.SystemSettings.KeyExists("ADRFailStatusID"))
      num2 = Convert.ToInt32(MGASystems.Common.SystemSettings.GetNumericSetting("ADRFailStatusID"));
    if (num1 == int.MinValue || num2 == int.MinValue)
      return;
    int num3 = num2;
    string str1 = "UPDATE tblDriverInfo SET StatusID=@ST, ADRResults = @DR WHERE DriverID=@DID";
    string str2 = "<CompanyClass>";
    string str3 = "</CompanyClass>";
    if (!xmlResultString.Contains(str2) || !xmlResultString.Contains(str3))
      return;
    int startIndex = xmlResultString.IndexOf(str2) + str2.Length;
    int num4 = xmlResultString.IndexOf(str3, startIndex);
    string str4 = xmlResultString.Substring(startIndex, num4 - startIndex);
    if (str4.ToLower().Equals("pass"))
      num3 = num1;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, str1, new object[6]
    {
      (object) "@ST",
      (object) num3,
      (object) "@DR",
      (object) str4,
      (object) "@DID",
      (object) driverID
    });
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetRowSelection(true);
  }

  private void SetRowSelection(bool selection)
  {
    try
    {
      foreach (dsDriverRenewal.dtRow row in this.ds.dt.Rows)
        row.Process = selection;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void lnkDeSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetRowSelection(false);
  }
}
