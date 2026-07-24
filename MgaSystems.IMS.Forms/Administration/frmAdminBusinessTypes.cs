// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Administration.frmAdminBusinessTypes
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Administration;

[SecureResource("{B2D03DD8-3123-46e8-9A8F-0A750F2AFED0}", "Access Business Types", "Controls access to the Business Types Screen.", "Users")]
public class frmAdminBusinessTypes : Form
{
  private IContainer components;
  private UltraTextEditor txtShow;
  private Label lblShow;
  private readonly string _tableName;
  private readonly string _displayMember;
  private readonly string _valueMember;
  private readonly string _windowTitle;
  private readonly string _formLabelText;
  private bool _isEdit;
  private DbDataAdapter _da;
  private DataSet ds;
  internal const string CanViewBusinessTypesForm = "{B2D03DD8-3123-46e8-9A8F-0A750F2AFED0}";

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_UIStateChanged);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedSave);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_ClickedNew);
      EventHandler eventHandler4 = new EventHandler(this.dbSave_ClickedEdit);
      EventHandler eventHandler5 = new EventHandler(this.dbSave_ClickedDelete);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.UIStateChanged -= eventHandler1;
        dbSave1.ClickedSave -= eventHandler2;
        dbSave1.ClickedNew -= eventHandler3;
        dbSave1.ClickedEdit -= eventHandler4;
        dbSave1.ClickedDelete -= eventHandler5;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.UIStateChanged += eventHandler1;
      dbSave2.ClickedSave += eventHandler2;
      dbSave2.ClickedNew += eventHandler3;
      dbSave2.ClickedEdit += eventHandler4;
      dbSave2.ClickedDelete += eventHandler5;
    }
  }

  protected virtual MGAListBox List
  {
    get => this._List;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.List_SelectedIndexChanged);
      MGAListBox list1 = this._List;
      if (list1 != null)
        list1.SelectedIndexChanged -= eventHandler;
      this._List = value;
      MGAListBox list2 = this._List;
      if (list2 == null)
        return;
      list2.SelectedIndexChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.txtShow = new UltraTextEditor();
    this.lblShow = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.List = new MGAListBox();
    ((ISupportInitialize) this.txtShow).BeginInit();
    ((ISupportInitialize) this.List).BeginInit();
    this.SuspendLayout();
    ((Control) this.txtShow).Enabled = false;
    ((Control) this.txtShow).Location = new Point(98, 161);
    ((Control) this.txtShow).Name = "txtShow";
    ((Control) this.txtShow).Size = new Size(100, 22);
    ((Control) this.txtShow).TabIndex = 7;
    this.lblShow.Location = new Point(7, 161);
    this.lblShow.Name = "lblShow";
    this.lblShow.Size = new Size(84, 21);
    this.lblShow.TabIndex = 6;
    this.lblShow.Text = "[Display]";
    this.lblShow.TextAlign = ContentAlignment.MiddleRight;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(208 /*0xD0*/, 160 /*0xA0*/);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 5;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    this.List.BackColor = Color.White;
    this.List.Location = new Point(7, 7);
    this.List.MGAStyle = MGAStyles.Blue;
    this.List.Name = "List";
    this.List.Size = new Size(315, 145);
    this.List.TabIndex = 4;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.FromArgb(250, 250, 250);
    this.ClientSize = new Size(328, 204);
    this.Controls.Add((Control) this.txtShow);
    this.Controls.Add((Control) this.lblShow);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.List);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmAdminBusinessTypes);
    this.Text = "[Name]";
    ((ISupportInitialize) this.txtShow).EndInit();
    ((ISupportInitialize) this.List).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmAdminBusinessTypes()
  {
    this.Load += new EventHandler(this.frmAdminLookups_Load);
    this._da = DefaultDatabase.CreateDataAdapter();
    this.ds = new DataSet();
    this.InitializeComponent();
  }

  public frmAdminBusinessTypes(
    string tableName,
    string displayMember,
    string valueMember,
    string windowTitle,
    string formLabelText)
    : this()
  {
    this._formLabelText = formLabelText;
    this._tableName = tableName;
    this._displayMember = displayMember;
    this._valueMember = valueMember;
    this._windowTitle = windowTitle;
  }

  private void frmAdminLookups_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    DbDataAdapter da = this._da;
    if (da.SelectCommand == null)
      da.SelectCommand = DefaultDatabase.CreateCommand();
    if (da.DeleteCommand == null)
      da.DeleteCommand = DefaultDatabase.CreateCommand();
    if (da.UpdateCommand == null)
      da.UpdateCommand = DefaultDatabase.CreateCommand();
    if (da.InsertCommand == null)
      da.InsertCommand = DefaultDatabase.CreateCommand();
    Utility.SetDataAdapterConnections(this._da, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    this._da.SelectCommand.CommandText = $"SELECT {this._displayMember}, {this._valueMember} FROM {this._tableName}";
    DefaultDatabase.DataAdapterFill(this._da, this.ds);
    this.Text = this._windowTitle;
    this.lblShow.Text = $"{this._formLabelText}:";
    MGAListBox list = this.List;
    list.DataSource = (object) this.ds.Tables[0];
    list.DisplayMember = this._displayMember.ToString();
    list.ValueMember = this._valueMember.ToString();
    ((TextEditorControlBase) this.txtShow).Text = this.ds.Tables[0].Select($"{this._valueMember}='{this.List.SelectedValue.ToString()}'")[0][this._displayMember].ToString();
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.txtShow).Enabled = this.dbSave.UIState == UIState.Editing;
    this.List.Enabled = this.dbSave.UIState != UIState.Editing;
  }

  private void dbSave_ClickedSave(object sender, EventArgs e)
  {
    if (this._isEdit)
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, $"UPDATE {this._tableName} SET {this._displayMember} =  @ST WHERE {this._valueMember}  = @V", new object[4]
      {
        (object) "@ST",
        (object) ((TextEditorControlBase) this.txtShow).Text.Replace("'", "''"),
        (object) "@V",
        (object) this.List.SelectedValue.ToString()
      });
      this.ds.Tables[0].Select($"{this._valueMember}={this.List.SelectedValue.ToString()}")[0][this._displayMember] = (object) ((TextEditorControlBase) this.txtShow).Text;
    }
    else
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, $"INSERT INTO {this._tableName} ({this._displayMember}) VALUES (@ST); SELECT @@IDENTITY", new object[2]
      {
        (object) "@ST",
        (object) ((TextEditorControlBase) this.txtShow).Text.Replace("'", "''")
      }));
      DataRow row = this.ds.Tables[0].NewRow();
      row[this._valueMember] = (object) Conversions.ToByte(objectValue);
      row[this._displayMember] = (object) ((TextEditorControlBase) this.txtShow).Text.Replace("'", "''");
      this.ds.Tables[0].Rows.Add(row);
      if (this.List.Items.Count == 0)
        this.List.SelectedIndex = this.List.Items.Count;
      else
        this.List.SelectedIndex = this.List.Items.Count - 1;
    }
    this.ds.Tables[0].AcceptChanges();
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    this._isEdit = false;
    ((TextEditorControlBase) this.txtShow).Text = string.Empty;
  }

  private void dbSave_ClickedEdit(object sender, EventArgs e) => this._isEdit = true;

  private void dbSave_ClickedDelete(object sender, EventArgs e)
  {
    if (MessageBox.Show("Are you sure you want do delete this item?", "Delete Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, $"DELETE FROM {this._tableName} WHERE {this._valueMember} =@V", new object[2]
    {
      (object) "@V",
      (object) this.List.SelectedValue.ToString()
    });
    this.ds.Tables[0].Rows.RemoveAt(this.List.SelectedIndex);
    ((TextEditorControlBase) this.txtShow).Text = this.ds.Tables[0].Rows[this.List.SelectedIndex][this._displayMember].ToString();
  }

  private void List_SelectedIndexChanged(object sender, EventArgs e)
  {
    ((TextEditorControlBase) this.txtShow).Text = this.ds.Tables[0].Rows[this.List.SelectedIndex][this._displayMember].ToString();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    this._da.Dispose();
    base.Dispose(disposing);
  }
}
