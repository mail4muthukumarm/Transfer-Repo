// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.frmSelectEntity
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

public sealed class frmSelectEntity : Form
{
  private IContainer components;
  private Label Label1;
  private Label Label2;
  private SqlConnection cnSQL;
  private dsSelectEntity ds;
  private Label lblLimitedResults;
  private bool _internalOnly;

  public frmSelectEntity()
  {
    this.Load += new EventHandler(this.frmSelectEntity_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGATextBox txtSearch
  {
    get => this._txtSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSearch_KeyDown);
      MGATextBox txtSearch1 = this._txtSearch;
      if (txtSearch1 != null)
        ((Control) txtSearch1).KeyDown -= keyEventHandler;
      this._txtSearch = value;
      MGATextBox txtSearch2 = this._txtSearch;
      if (txtSearch2 == null)
        return;
      ((Control) txtSearch2).KeyDown += keyEventHandler;
    }
  }

  private virtual MGAButton btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearch_Click);
      MGAButton btnSearch1 = this._btnSearch;
      if (btnSearch1 != null)
        ((Control) btnSearch1).Click -= eventHandler;
      this._btnSearch = value;
      MGAButton btnSearch2 = this._btnSearch;
      if (btnSearch2 == null)
        return;
      ((Control) btnSearch2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnGo
  {
    get => this._btnGo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGo_Click);
      MGAButton btnGo1 = this._btnGo;
      if (btnGo1 != null)
        ((Control) btnGo1).Click -= eventHandler;
      this._btnGo = value;
      MGAButton btnGo2 = this._btnGo;
      if (btnGo2 == null)
        return;
      ((Control) btnGo2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cboEntityTypes")]
  private virtual MGASimpleComboBox cboEntityTypes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAListBox lstResults
  {
    get => this._lstResults;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lstResults_DoubleClick);
      MGAListBox lstResults1 = this._lstResults;
      if (lstResults1 != null)
        lstResults1.DoubleClick -= eventHandler;
      this._lstResults = value;
      MGAListBox lstResults2 = this._lstResults;
      if (lstResults2 == null)
        return;
      lstResults2.DoubleClick += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (frmSelectEntity));
    this.lstResults = new MGAListBox();
    this.ds = new dsSelectEntity();
    this.txtSearch = new MGATextBox();
    this.Label1 = new Label();
    this.btnSearch = new MGAButton();
    this.btnGo = new MGAButton();
    this.Label2 = new Label();
    this.cboEntityTypes = new MGASimpleComboBox();
    this.cnSQL = new SqlConnection();
    this.lblLimitedResults = new Label();
    ((ISupportInitialize) this.lstResults).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtSearch).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.btnGo).BeginInit();
    ((ISupportInitialize) this.cboEntityTypes).BeginInit();
    this.SuspendLayout();
    this.lstResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstResults.DataSource = (object) this.ds.Results;
    this.lstResults.DisplayMember = "Display";
    this.lstResults.Location = new Point(7, 77);
    this.lstResults.Name = "lstResults";
    this.lstResults.Size = new Size(301, 288);
    this.lstResults.TabIndex = 4;
    this.lstResults.ValueMember = "Value";
    this.ds.DataSetName = "dsSelectEntity";
    this.ds.Locale = new CultureInfo("en-US");
    ((Control) this.txtSearch).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BorderColor = Color.Gray;
    ((TextEditorControlBase) this.txtSearch).Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtSearch).Location = new Point(63 /*0x3F*/, 45);
    ((Control) this.txtSearch).Name = "txtSearch";
    ((Control) this.txtSearch).Size = new Size(189, 20);
    ((Control) this.txtSearch).TabIndex = 25;
    this.Label1.Location = new Point(21, 48 /*0x30*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(42, 14);
    this.Label1.TabIndex = 24;
    this.Label1.Text = "Name:";
    ((Control) this.btnSearch).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnSearch).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSearch).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSearch).Location = new Point(266, 25);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).TabIndex = 23;
    ((Control) this.btnGo).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.Gainsboro;
    appearance3.BackColor2 = Color.White;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.Gray;
    appearance3.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnGo).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.btnGo).DialogResult = DialogResult.Cancel;
    ((Control) this.btnGo).Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnGo).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnGo).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnGo).Location = new Point(266, 378);
    ((Control) this.btnGo).Name = "btnGo";
    ((Control) this.btnGo).TabIndex = 21;
    this.Label2.Location = new Point(14, 17);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(42, 14);
    this.Label2.TabIndex = 26;
    this.Label2.Text = "Type:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.cboEntityTypes).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboEntityTypes.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboEntityTypes).DataSource = (object) this.ds.lstEntityTypes;
    ((UltraDropDownBase) this.cboEntityTypes).DisplayMember = "Description";
    this.cboEntityTypes.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboEntityTypes).Location = new Point(63 /*0x3F*/, 14);
    ((Control) this.cboEntityTypes).Name = "cboEntityTypes";
    ((Control) this.cboEntityTypes).Size = new Size(189, 20);
    ((Control) this.cboEntityTypes).TabIndex = 27;
    ((UltraDropDownBase) this.cboEntityTypes).ValueMember = "EntityTypeID";
    this.cnSQL.ConnectionString = "workstation id=PSARNOWSKI;packet size=4096;user id=mgasystems;data source=\"10.0.0.3\";persist security info=False;initial catalog=IMS";
    this.lblLimitedResults.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblLimitedResults.ForeColor = Color.Red;
    this.lblLimitedResults.Location = new Point(28, 378);
    this.lblLimitedResults.Name = "lblLimitedResults";
    this.lblLimitedResults.Size = new Size(140, 21);
    this.lblLimitedResults.TabIndex = 28;
    this.lblLimitedResults.Text = "Limiting to top 100 results.";
    this.lblLimitedResults.Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnGo;
    this.ClientSize = new Size(314, 428);
    this.Controls.Add((Control) this.cboEntityTypes);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.lblLimitedResults);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtSearch);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnGo);
    this.Controls.Add((Control) this.lstResults);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.Name = nameof (frmSelectEntity);
    this.Text = "Entity Selection";
    ((ISupportInitialize) this.lstResults).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.txtSearch).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.btnGo).EndInit();
    ((ISupportInitialize) this.cboEntityTypes).EndInit();
    this.ResumeLayout(false);
  }

  public bool InternalOnly
  {
    get => this._internalOnly;
    set => this._internalOnly = value;
  }

  public string EntityType => this.cboEntityTypes.Text;

  public string EntityTypeID => this.cboEntityTypes.Value.ToString();

  public Guid EntityGuid
  {
    get
    {
      return this.lstResults.SelectedItem != null ? ((dsSelectEntity.ResultsRow) ((DataRowView) this.lstResults.SelectedItem).Row).Value : Guid.Empty;
    }
  }

  public string EntityName
  {
    get
    {
      return this.lstResults.SelectedItem != null ? ((dsSelectEntity.ResultsRow) ((DataRowView) this.lstResults.SelectedItem).Row).Display : string.Empty;
    }
  }

  private void frmSelectEntity_Load(object sender, EventArgs e)
  {
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnGo).Appearance.Image = (object) instance.Forward;
    ((ControlBase) this.btnSearch).Appearance.Image = (object) instance.Search;
    string str = "SELECT EntityTypeID, Description FROM lstEntityTypes";
    if (this._internalOnly)
      str += " WHERE InternalEntity=1";
    DefaultDatabase.LoadDataTable((DataTable) this.ds.lstEntityTypes, CommandType.Text, str + " ORDER BY Description");
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    if (this.cboEntityTypes.Value == null)
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    SqlCommand selectCommand = new SqlCommand($"SELECT EntityNameField, EntityTable, EntityGuidField, whereClause FROM lstEntityTypes WHERE EntityTypeID='{this.cboEntityTypes.Value.ToString()}'", this.cnSQL);
    try
    {
      this.cnSQL.Open();
      SqlDataReader sqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
      sqlDataReader.Read();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sqlDataReader["whereClause"].ToString(), string.Empty, false) == 0)
        selectCommand.CommandText = $"SELECT DISTINCT TOP 100 {sqlDataReader["EntityNameField"].ToString()} AS Display, {sqlDataReader["EntityGuidField"].ToString()} AS Value FROM {sqlDataReader["EntityTable"].ToString()}";
      else
        selectCommand.CommandText = $"SELECT DISTINCT TOP 100 {sqlDataReader["EntityNameField"].ToString()} AS Display, {sqlDataReader["EntityGuidField"].ToString()} AS Value FROM {sqlDataReader["EntityTable"].ToString()} {sqlDataReader["whereClause"].ToString()}";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtSearch).Text, string.Empty, false) != 0)
      {
        SqlCommand sqlCommand;
        string str = $"{(sqlCommand = selectCommand).CommandText}{Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sqlDataReader["whereClause"].ToString(), string.Empty, false) == 0, (object) " WHERE ", (object) " AND ").ToString()}{sqlDataReader["EntityNameField"].ToString()} LIKE '%{((TextEditorControlBase) this.txtSearch).Text.Replace("'", "''")}%'";
        sqlCommand.CommandText = str;
      }
      SqlCommand sqlCommand1;
      string str1 = $"{(sqlCommand1 = selectCommand).CommandText} ORDER BY {sqlDataReader["EntityNameField"].ToString()}";
      sqlCommand1.CommandText = str1;
      sqlDataReader.Close();
      SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
      try
      {
        this.ds.Results.Clear();
        Database.SafeDataAdapterFill(dataAdapter, (DataTable) this.ds.Results);
      }
      finally
      {
        dataAdapter.Dispose();
      }
    }
    finally
    {
      Utility.Dump((DbCommand) selectCommand);
      this.cnSQL.Close();
      selectCommand.Dispose();
      Cursor.Current = MgaCursors.Default;
    }
    if (this.lstResults.Items.Count < 100)
      return;
    if (CurrentUser.Instance.UsingXP)
      BalloonTip.ShowEditTip((Control) this.txtSearch, "Limiting Results", "More than 100 results were returned.\n\nPlease specify a better search criteria to limit the results.", BalloonTip.BalloonTipIcons.Info);
    else
      this.lblLimitedResults.Visible = true;
  }

  private void btnGo_Click(object sender, EventArgs e) => this.Close();

  private void txtSearch_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSearch_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
  }

  private void lstResults_DoubleClick(object sender, EventArgs e)
  {
    this.btnGo_Click(RuntimeHelpers.GetObjectValue(sender), e);
  }
}
