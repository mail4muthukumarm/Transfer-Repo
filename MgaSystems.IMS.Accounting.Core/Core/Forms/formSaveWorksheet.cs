// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formSaveWorksheet
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class formSaveWorksheet : AccountingNoteDocumentSupport
{
  private EllipsePanel ellipsePanel2;
  private EllipsePanel ellipsePanel1;
  private EllipsePanel panelListView;
  private ListView listViewSavedWorksheets;
  private Label label1;
  private MGATextBox textFileName;
  private MGAButton buttonSave;
  private MGAButton buttonCancel;
  private ImageList imageList1;
  private Label labelLoading;
  private ContextMenu contextMenu1;
  private MenuItem menuDeleteWorksheet;
  private IContainer components;
  private object _worksheet;
  private formSaveWorksheet.WorksheetType _worksheetType;
  protected int _entryId;
  public bool IsBulk;
  public string dataImportXML = string.Empty;

  public formSaveWorksheet() => this.InitializeComponent();

  public formSaveWorksheet(formSaveWorksheet.WorksheetType worksheetType, object worksheetObject)
  {
    this.InitializeComponent();
    this._worksheetType = worksheetType;
    this._worksheet = worksheetObject;
    this.LoadSavedWorksheets();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (formSaveWorksheet));
    this.ellipsePanel2 = new EllipsePanel();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.label1 = new Label();
    this.textFileName = new MGATextBox();
    this.ellipsePanel1 = new EllipsePanel();
    this.panelListView = new EllipsePanel();
    this.labelLoading = new Label();
    this.listViewSavedWorksheets = new ListView();
    this.imageList1 = new ImageList(this.components);
    this.contextMenu1 = new ContextMenu();
    this.menuDeleteWorksheet = new MenuItem();
    this.ellipsePanel2.SuspendLayout();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.textFileName).BeginInit();
    this.ellipsePanel1.SuspendLayout();
    this.panelListView.SuspendLayout();
    this.SuspendLayout();
    this.ellipsePanel2.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel2.Controls.Add((Control) this.buttonCancel);
    this.ellipsePanel2.Controls.Add((Control) this.buttonSave);
    this.ellipsePanel2.Controls.Add((Control) this.label1);
    this.ellipsePanel2.Controls.Add((Control) this.textFileName);
    this.ellipsePanel2.CornerOffset = 1;
    this.ellipsePanel2.Location = new Point(4, 272);
    this.ellipsePanel2.Name = "ellipsePanel2";
    this.ellipsePanel2.Size = new Size(480, 40);
    this.ellipsePanel2.TabIndex = 1;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(392, 8);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonCancel).TabIndex = 3;
    ((Control) this.buttonCancel).Text = "&Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.buttonSave).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonSave).Location = new Point(304, 8);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonSave).TabIndex = 2;
    ((Control) this.buttonSave).Text = "&Save";
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    this.label1.AutoSize = true;
    this.label1.Location = new Point(8, 10);
    this.label1.Name = "label1";
    this.label1.Size = new Size(56, 16 /*0x10*/);
    this.label1.TabIndex = 0;
    this.label1.Text = "File Name:";
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb(78, 122, 171);
    ((TextEditorControlBase) this.textFileName).Appearance = (AppearanceBase) appearance3;
    ((Control) this.textFileName).Location = new Point(64 /*0x40*/, 10);
    this.textFileName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textFileName).Name = "textFileName";
    ((Control) this.textFileName).Size = new Size(232, 20);
    ((Control) this.textFileName).TabIndex = 1;
    this.ellipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel1.Controls.Add((Control) this.panelListView);
    this.ellipsePanel1.CornerOffset = 1;
    this.ellipsePanel1.Location = new Point(4, 4);
    this.ellipsePanel1.Name = "ellipsePanel1";
    this.ellipsePanel1.Size = new Size(480, 264);
    this.ellipsePanel1.TabIndex = 0;
    this.panelListView.BackColor = Color.White;
    this.panelListView.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelListView.Controls.Add((Control) this.labelLoading);
    this.panelListView.Controls.Add((Control) this.listViewSavedWorksheets);
    this.panelListView.CornerOffset = 1;
    this.panelListView.Location = new Point(8, 8);
    this.panelListView.Name = "panelListView";
    this.panelListView.Size = new Size(464, 248);
    this.panelListView.TabIndex = 0;
    this.labelLoading.Location = new Point(16 /*0x10*/, 112 /*0x70*/);
    this.labelLoading.Name = "labelLoading";
    this.labelLoading.Size = new Size(432, 23);
    this.labelLoading.TabIndex = 1;
    this.labelLoading.Text = "Loading saved worksheets...";
    this.labelLoading.TextAlign = ContentAlignment.MiddleCenter;
    this.listViewSavedWorksheets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.listViewSavedWorksheets.BorderStyle = BorderStyle.None;
    this.listViewSavedWorksheets.ContextMenu = this.contextMenu1;
    this.listViewSavedWorksheets.LargeImageList = this.imageList1;
    this.listViewSavedWorksheets.Location = new Point(8, 8);
    this.listViewSavedWorksheets.Name = "listViewSavedWorksheets";
    this.listViewSavedWorksheets.Size = new Size(449, 237);
    this.listViewSavedWorksheets.SmallImageList = this.imageList1;
    this.listViewSavedWorksheets.TabIndex = 0;
    this.listViewSavedWorksheets.View = View.List;
    this.listViewSavedWorksheets.KeyDown += new KeyEventHandler(this.listViewSavedWorksheets_KeyDown);
    this.listViewSavedWorksheets.Click += new EventHandler(this.listViewSavedWorksheets_Click);
    this.imageList1.ImageSize = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.imageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("imageList1.ImageStream");
    this.imageList1.TransparentColor = Color.Transparent;
    this.contextMenu1.MenuItems.AddRange(new MenuItem[1]
    {
      this.menuDeleteWorksheet
    });
    this.menuDeleteWorksheet.Index = 0;
    this.menuDeleteWorksheet.Text = "Delete Worksheet";
    this.menuDeleteWorksheet.Click += new EventHandler(this.menuDeleteWorksheet_Click);
    this.AcceptButton = (IButtonControl) this.buttonSave;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(488, 316);
    this.Controls.Add((Control) this.ellipsePanel2);
    this.Controls.Add((Control) this.ellipsePanel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.Name = nameof (formSaveWorksheet);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Save Worksheet";
    this.ellipsePanel2.ResumeLayout(false);
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.textFileName).EndInit();
    this.ellipsePanel1.ResumeLayout(false);
    this.panelListView.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void LoadSavedWorksheets()
  {
    using (SqlCommand sqlCommand = new SqlCommand())
    {
      this.listViewSavedWorksheets.Items.Clear();
      this.labelLoading.Visible = true;
      sqlCommand.Connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
      sqlCommand.CommandType = CommandType.StoredProcedure;
      switch (this._worksheetType)
      {
        case formSaveWorksheet.WorksheetType.Payable:
          sqlCommand.CommandText = "spFin_GetPayableWorksheets";
          break;
        case formSaveWorksheet.WorksheetType.Receivable:
          sqlCommand.CommandText = "spFin_GetReceivableWorksheets";
          break;
        case formSaveWorksheet.WorksheetType.PayableReceivable:
          sqlCommand.CommandText = "spfin_GetAccountingWorksheets";
          break;
      }
      sqlCommand.Connection.Open();
      using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
      {
        while (sqlDataReader.Read())
          this.listViewSavedWorksheets.Items.Add(new ListViewItem(sqlDataReader["worksheetname"].ToString(), 1)
          {
            Tag = (object) $"{sqlDataReader["entryid"].ToString()}-{sqlDataReader["isbulk"].ToString()}"
          });
      }
    }
    this.labelLoading.Visible = false;
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void SaveWorksheet()
  {
    bool flag1 = false;
    bool flag2 = this.ItemNameExists(((Control) this.textFileName).Text);
    if (flag2)
    {
      this._entryId = this.GetExistingKey(((Control) this.textFileName).Text);
      flag1 = MessageBox.Show("A worksheet with the same name already exists, do you wish to overwrite it with this one?", "Overwrite Existsing Worksheet?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }
    else
      this._entryId = 0;
    this.DoSaveWorkSheet(flag2 & flag1, this._entryId);
  }

  protected virtual void DoSaveWorkSheet(bool overWrite, int entryId)
  {
    using (SqlCommand sqlCommand = new SqlCommand("spFin_InsertAccountingWorksheet", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      MemoryStream serializationStream = new MemoryStream();
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
      binaryFormatter.Context = new StreamingContext(StreamingContextStates.Persistence);
      binaryFormatter.Serialize((Stream) serializationStream, this._worksheet);
      serializationStream.Position = 0L;
      this._worksheet = (object) null;
      this._worksheet = binaryFormatter.Deserialize((Stream) serializationStream);
      serializationStream.Flush();
      serializationStream.Position = 0L;
      byte[] array = serializationStream.ToArray();
      serializationStream.Close();
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Parameters.AddWithValue("@worksheetname", (object) ((Control) this.textFileName).Text);
      sqlCommand.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
      sqlCommand.Parameters.AddWithValue("@info", (object) array);
      sqlCommand.Parameters.AddWithValue("@isBulk", (object) this.IsBulk);
      sqlCommand.Parameters.AddWithValue("@importXML", (object) this.dataImportXML);
      if (overWrite && entryId != 0)
        sqlCommand.Parameters.AddWithValue("@entryId", (object) entryId);
      sqlCommand.Connection.Open();
      entryId = (int) sqlCommand.ExecuteScalar();
      this._entryId = entryId;
    }
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (((Control) this.textFileName).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must enter a file name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
      this.SaveWorksheet();
  }

  private bool ItemNameExists(string itemName)
  {
    bool flag = false;
    foreach (ListViewItem listViewItem in this.listViewSavedWorksheets.Items)
    {
      if (listViewItem.Text.Trim().ToUpper().Equals(itemName.Trim().ToUpper()))
      {
        flag = true;
        break;
      }
    }
    return flag;
  }

  private int GetExistingKey(string itemName)
  {
    int existingKey = 0;
    foreach (ListViewItem listViewItem in this.listViewSavedWorksheets.Items)
    {
      if (listViewItem.Text.Trim().ToUpper().Equals(itemName.Trim().ToUpper()))
      {
        existingKey = this.GetWorksheetEntryId(listViewItem.Tag.ToString());
        break;
      }
    }
    return existingKey;
  }

  private void menuDeleteWorksheet_Click(object sender, EventArgs e)
  {
    this.DeleteWorksheet();
    this.LoadSavedWorksheets();
  }

  private void DeleteWorksheet()
  {
    if (this.listViewSavedWorksheets.SelectedItems.Count == 0 || MessageBox.Show("This will permanently delete the specified worksheet, do you wish to continue?", "Permanently Delete Worksheet?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    int worksheetEntryId = this.GetWorksheetEntryId(this.listViewSavedWorksheets.SelectedItems[0].Tag.ToString());
    bool isBulk = this.IsBulkWorksheet(this.listViewSavedWorksheets.SelectedItems[0].Tag.ToString());
    switch (this._worksheetType)
    {
      case formSaveWorksheet.WorksheetType.Payable:
        Utility.DeletePayablesWorksheet(worksheetEntryId);
        break;
      case formSaveWorksheet.WorksheetType.Receivable:
        Utility.DeleteReceivableWorksheet(worksheetEntryId);
        break;
      case formSaveWorksheet.WorksheetType.PayableReceivable:
        Utility.DeleteAccountingWorksheet(worksheetEntryId, isBulk);
        break;
    }
  }

  private void listViewSavedWorksheets_KeyDown(object sender, KeyEventArgs e)
  {
    if (this.listViewSavedWorksheets.SelectedItems.Count == 0 || e.KeyCode != Keys.Delete)
      return;
    this.DeleteWorksheet();
  }

  private void listViewSavedWorksheets_Click(object sender, EventArgs e)
  {
    if (this.listViewSavedWorksheets.SelectedItems.Count == 0)
      return;
    ((Control) this.textFileName).Text = this.listViewSavedWorksheets.SelectedItems[0].Text;
  }

  private int GetWorksheetEntryId(string entryString)
  {
    int length = entryString.IndexOf("-");
    return int.Parse(entryString.Substring(0, length));
  }

  private bool IsBulkWorksheet(string entryString)
  {
    int num = entryString.IndexOf("-");
    return !(entryString.Substring(num + 1, entryString.Length - (num + 1)) == "False");
  }

  public enum WorksheetType
  {
    Payable,
    Receivable,
    PayableReceivable,
  }
}
