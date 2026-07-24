// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formLoadWorksheet
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
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
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class formLoadWorksheet : AccountingNoteDocumentSupport
{
  private EllipsePanel ellipsePanel2;
  private MGAButton buttonCancel;
  private MGAButton buttonOpen;
  private ImageList imageList1;
  private EllipsePanel ellipsePanel1;
  private EllipsePanel panelListView;
  private Label labelLoading;
  private ListView listViewSavedWorksheets;
  private ContextMenu contextMenu1;
  private MenuItem menuDeleteWorksheet;
  private IContainer components;
  private object _worksheet;
  private formLoadWorksheet.WorksheetType _worksheetType;
  private int _worksheetId;
  private bool _isBulk;

  public formLoadWorksheet(formLoadWorksheet.WorksheetType worksheetType)
  {
    this.InitializeComponent();
    this._worksheetType = worksheetType;
    this.LoadSavedWorksheets();
  }

  public object Worksheet => this._worksheet;

  public int WorksheetId => this._worksheetId;

  public bool IsBulk => this._isBulk;

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
    ResourceManager resourceManager = new ResourceManager(typeof (formLoadWorksheet));
    this.ellipsePanel2 = new EllipsePanel();
    this.buttonCancel = new MGAButton();
    this.buttonOpen = new MGAButton();
    this.imageList1 = new ImageList(this.components);
    this.ellipsePanel1 = new EllipsePanel();
    this.panelListView = new EllipsePanel();
    this.labelLoading = new Label();
    this.listViewSavedWorksheets = new ListView();
    this.contextMenu1 = new ContextMenu();
    this.menuDeleteWorksheet = new MenuItem();
    this.ellipsePanel2.SuspendLayout();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonOpen).BeginInit();
    this.ellipsePanel1.SuspendLayout();
    this.panelListView.SuspendLayout();
    this.SuspendLayout();
    this.ellipsePanel2.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel2.Controls.Add((Control) this.buttonCancel);
    this.ellipsePanel2.Controls.Add((Control) this.buttonOpen);
    this.ellipsePanel2.CornerOffset = 1;
    this.ellipsePanel2.Location = new Point(3, 271);
    this.ellipsePanel2.Name = "ellipsePanel2";
    this.ellipsePanel2.Size = new Size(480, 40);
    this.ellipsePanel2.TabIndex = 3;
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
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonOpen).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.buttonOpen).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonOpen).Location = new Point(304, 8);
    ((Control) this.buttonOpen).Name = "buttonOpen";
    ((Control) this.buttonOpen).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonOpen).TabIndex = 2;
    ((Control) this.buttonOpen).Text = "&Open";
    ((Control) this.buttonOpen).Click += new EventHandler(this.buttonOpen_Click);
    this.imageList1.ImageSize = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.imageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("imageList1.ImageStream");
    this.imageList1.TransparentColor = Color.Transparent;
    this.ellipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel1.Controls.Add((Control) this.panelListView);
    this.ellipsePanel1.CornerOffset = 1;
    this.ellipsePanel1.Location = new Point(3, 3);
    this.ellipsePanel1.Name = "ellipsePanel1";
    this.ellipsePanel1.Size = new Size(480, 264);
    this.ellipsePanel1.TabIndex = 2;
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
    this.listViewSavedWorksheets.DoubleClick += new EventHandler(this.listViewSavedWorksheets_DoubleClick);
    this.contextMenu1.MenuItems.AddRange(new MenuItem[1]
    {
      this.menuDeleteWorksheet
    });
    this.menuDeleteWorksheet.Index = 0;
    this.menuDeleteWorksheet.Text = "Delete Worksheet";
    this.menuDeleteWorksheet.Click += new EventHandler(this.menuDeleteWorksheet_Click);
    this.AcceptButton = (IButtonControl) this.buttonOpen;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(486, 314);
    this.Controls.Add((Control) this.ellipsePanel1);
    this.Controls.Add((Control) this.ellipsePanel2);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.Name = nameof (formLoadWorksheet);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Load Worksheet";
    this.ellipsePanel2.ResumeLayout(false);
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonOpen).EndInit();
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
        case formLoadWorksheet.WorksheetType.Payable:
          sqlCommand.CommandText = "spFin_GetPayableWorksheets";
          break;
        case formLoadWorksheet.WorksheetType.Receivable:
          sqlCommand.CommandText = "spFin_GetReceivableWorksheets";
          break;
        case formLoadWorksheet.WorksheetType.Accounting:
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

  private void LoadWorksheetObject(int entryId, bool isBulk)
  {
    this._worksheetId = entryId;
    this._isBulk = isBulk;
    using (SqlCommand sqlCommand = new SqlCommand())
    {
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
      sqlCommand.Parameters.AddWithValue("@entryid", (object) entryId);
      sqlCommand.Parameters.AddWithValue("@isBulk", (object) this._isBulk);
      switch (this._worksheetType)
      {
        case formLoadWorksheet.WorksheetType.Payable:
          sqlCommand.CommandText = "spfin_GetPayableWorksheet";
          break;
        case formLoadWorksheet.WorksheetType.Receivable:
          sqlCommand.CommandText = "spfin_GetReceivableWorksheet";
          break;
        case formLoadWorksheet.WorksheetType.Accounting:
          sqlCommand.CommandText = "spFin_GetAccountingWorksheet";
          break;
      }
      sqlCommand.Connection.Open();
      SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);
      MemoryStream serializationStream = new MemoryStream();
      byte[] numArray = (byte[]) null;
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
      if (sqlDataReader.Read())
      {
        byte[] buffer = (byte[]) sqlDataReader.GetValue(0);
        serializationStream.Write(buffer, 0, buffer.Length);
        serializationStream.Position = 0L;
        AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(Utility.LoadComponentAssembly);
        switch (this._worksheetType)
        {
          case formLoadWorksheet.WorksheetType.Payable:
            this._worksheet = binaryFormatter.Deserialize((Stream) serializationStream);
            break;
          case formLoadWorksheet.WorksheetType.Receivable:
            this._worksheet = binaryFormatter.Deserialize((Stream) serializationStream);
            break;
          case formLoadWorksheet.WorksheetType.Accounting:
            this._worksheet = binaryFormatter.Deserialize((Stream) serializationStream);
            break;
        }
        AppDomain.CurrentDomain.AssemblyResolve -= new ResolveEventHandler(Utility.LoadComponentAssembly);
        serializationStream.Close();
      }
      numArray = (byte[]) null;
      sqlDataReader.Close();
    }
  }

  private void buttonOpen_Click(object sender, EventArgs e) => this.OpenWorksheet();

  private void menuDeleteWorksheet_Click(object sender, EventArgs e) => this.DeleteWorksheet();

  private void DeleteWorksheet()
  {
    if (this.listViewSavedWorksheets.SelectedItems.Count == 0 || MessageBox.Show("This will permanently delete the specified worksheet, do you wish to continue?", "Permanently Delete Worksheet?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    string entryString = this.listViewSavedWorksheets.SelectedItems[0].Tag.ToString();
    int worksheetEntryId = this.GetWorksheetEntryId(entryString);
    bool isBulk = this.IsBulkWorksheet(entryString);
    switch (this._worksheetType)
    {
      case formLoadWorksheet.WorksheetType.Payable:
        Utility.DeletePayablesWorksheet(worksheetEntryId);
        break;
      case formLoadWorksheet.WorksheetType.Receivable:
        Utility.DeleteReceivableWorksheet(worksheetEntryId);
        break;
      case formLoadWorksheet.WorksheetType.Accounting:
        Utility.DeleteAccountingWorksheet(worksheetEntryId, isBulk);
        break;
    }
    this.LoadSavedWorksheets();
  }

  private void listViewSavedWorksheets_KeyDown(object sender, KeyEventArgs e)
  {
    if (this.listViewSavedWorksheets.SelectedItems.Count == 0 || e.KeyCode != Keys.Delete)
      return;
    this.DeleteWorksheet();
  }

  private void listViewSavedWorksheets_DoubleClick(object sender, EventArgs e)
  {
    this.OpenWorksheet();
  }

  private void OpenWorksheet()
  {
    if (this.listViewSavedWorksheets.SelectedItems.Count == 0)
      return;
    string entryString = this.listViewSavedWorksheets.SelectedItems[0].Tag.ToString();
    this.LoadWorksheetObject(this.GetWorksheetEntryId(entryString), this.IsBulkWorksheet(entryString));
    if (this._worksheet == null)
      return;
    this.DialogResult = DialogResult.OK;
    this.Close();
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
    Accounting,
  }
}
