// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Administration.frmAdminLookups
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

[SecureResource("{130F49D1-6485-42a4-BFDB-9A2B59FE33D3}", "Can View Licenses Menu", "Controls whether or not a user can view Licenses menu item.", "Users")]
public sealed class frmAdminLookups : Form
{
  private IContainer components;
  private UltraTextEditor txtShow;
  private Label lblShow;
  private ErrorProvider err;
  private readonly string _tableName;
  private readonly string _displayMember;
  private readonly string _valueMember;
  private readonly string _windowTitle;
  private readonly string _formLabelText;
  private bool _isEdit;
  private DbDataAdapter _da;
  private DataSet _ds;
  public const string CanViewLicensesForm = "{130F49D1-6485-42a4-BFDB-9A2B59FE33D3}";

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.dbSave_ClickingNew);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.UIStateChanged -= eventHandler;
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickingCancel -= cancelEventHandler2;
        dbSave1.ClickingDelete -= cancelEventHandler3;
        dbSave1.ClickingEdit -= cancelEventHandler4;
        dbSave1.ClickingNew -= cancelEventHandler5;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.UIStateChanged += eventHandler;
      dbSave2.ClickingSave += cancelEventHandler1;
      dbSave2.ClickingCancel += cancelEventHandler2;
      dbSave2.ClickingDelete += cancelEventHandler3;
      dbSave2.ClickingEdit += cancelEventHandler4;
      dbSave2.ClickingNew += cancelEventHandler5;
    }
  }

  private virtual MGAListBox List
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
    this.components = (IContainer) new System.ComponentModel.Container();
    this.txtShow = new UltraTextEditor();
    this.lblShow = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.List = new MGAListBox();
    this.err = new ErrorProvider(this.components);
    ((ISupportInitialize) this.txtShow).BeginInit();
    ((ISupportInitialize) this.List).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
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
    this.dbSave.Location = new Point(224 /*0xE0*/, 161);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 5;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    this.List.BackColor = Color.White;
    this.List.ForeColor = Color.Black;
    this.List.Location = new Point(7, 7);
    this.List.MGAStyle = MGAStyles.Blue;
    this.List.Name = "List";
    this.List.Size = new Size(329, 145);
    this.List.TabIndex = 4;
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.FromArgb(250, 250, 250);
    this.ClientSize = new Size(342, 204);
    this.Controls.Add((Control) this.txtShow);
    this.Controls.Add((Control) this.lblShow);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.List);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmAdminLookups);
    this.Text = "[Name]";
    ((ISupportInitialize) this.txtShow).EndInit();
    ((ISupportInitialize) this.List).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmAdminLookups(
    string tableName,
    string displayMember,
    string valueMember,
    string windowTitle,
    string formLabelText)
  {
    this.Load += new EventHandler(this.frmAdminLookups_Load);
    this._da = DefaultDatabase.CreateDataAdapter();
    this._ds = new DataSet();
    this.InitializeComponent();
    this._formLabelText = formLabelText;
    this._tableName = tableName;
    this._displayMember = displayMember;
    this._valueMember = valueMember;
    this._windowTitle = windowTitle;
  }

  private void frmAdminLookups_Load(object sender, EventArgs e)
  {
    DbDataAdapter da = this._da;
    if (da.SelectCommand == null)
      da.SelectCommand = DefaultDatabase.CreateCommand();
    Utility.SetDataAdapterConnections(this._da, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    this._da.SelectCommand.CommandText = $"SELECT {this._displayMember}, {this._valueMember} FROM {this._tableName} ORDER BY {this._displayMember}";
    DefaultDatabase.DataAdapterFill(this._da, this._ds);
    this.List.DataSource = (object) this._ds.Tables[0];
    this.List.DisplayMember = this._displayMember.ToString();
    this.List.ValueMember = this._valueMember.ToString();
    this.Text = this._windowTitle;
    this.lblShow.Text = this._formLabelText + ":";
    if (this._ds.Tables[0].Rows.Count > 0)
      ((TextEditorControlBase) this.txtShow).Text = this._ds.Tables[0].Select($"{this._valueMember}='{this.List.SelectedValue.ToString()}'")[0][this._displayMember].ToString();
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.txtShow).Enabled = this.dbSave.UIState == UIState.Editing;
    this.List.Enabled = this.dbSave.UIState != UIState.Editing;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtShow).Text, string.Empty, false) == 0)
    {
      this.err.SetError((Control) this.txtShow, "Cannot be blank");
      e.Cancel = true;
    }
    else
    {
      this.err.SetError((Control) this.txtShow, string.Empty);
      string str = $"UPDATE {this._tableName} SET {this._displayMember} =@D WHERE {this._valueMember} = @V";
      if (this._isEdit)
      {
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, str, new object[4]
        {
          (object) "@D",
          (object) ((TextEditorControlBase) this.txtShow).Text.Replace("'", "''"),
          (object) "@V",
          (object) this.List.SelectedValue.ToString()
        });
        this._ds.Tables[0].Select($"{this._valueMember}={this.List.SelectedValue.ToString()}")[0][this._displayMember] = (object) ((TextEditorControlBase) this.txtShow).Text;
      }
      else
      {
        object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, $"INSERT INTO {this._tableName}({this._displayMember}) VALUES (@D); SELECT @@IDENTITY", new object[2]
        {
          (object) "@D",
          (object) ((TextEditorControlBase) this.txtShow).Text.Replace("'", "''")
        }));
        DataRow row = this._ds.Tables[0].NewRow();
        row[this._valueMember] = (object) Conversions.ToInteger(objectValue);
        row[this._displayMember] = (object) ((TextEditorControlBase) this.txtShow).Text.Replace("'", "''");
        this._ds.Tables[0].Rows.Add(row);
        if (this.List.Items.Count > 0)
          this.List.SelectedIndex = this.List.Items.Count - 1;
      }
      this._ds.Tables[0].AcceptChanges();
    }
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    ((TextEditorControlBase) this.txtShow).Text = this._ds.Tables[0].Rows[this.List.SelectedIndex][this._displayMember].ToString();
    this.err.SetError((Control) this.txtShow, string.Empty);
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, $"DELETE FROM {this._tableName} WHERE {this._valueMember} =@V", new object[2]
      {
        (object) "@V",
        (object) this.List.SelectedValue.ToString()
      });
      this._ds.Tables[0].Rows.RemoveAt(this.List.SelectedIndex);
      if (this.List.Items.Count == 0)
      {
        ((TextEditorControlBase) this.txtShow).Text = string.Empty;
        this.dbSave.UIState = UIState.NoRecordsNotEditing;
      }
      else
      {
        ((TextEditorControlBase) this.txtShow).Text = this._ds.Tables[0].Rows[this.List.SelectedIndex][this._displayMember].ToString();
        this.dbSave.UIState = UIState.HasRecordsNotEditing;
      }
    }
    else
      e.Cancel = true;
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e) => this._isEdit = true;

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    this._isEdit = false;
    ((TextEditorControlBase) this.txtShow).Text = string.Empty;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._da != null)
        this._da.Dispose();
    }
    base.Dispose(disposing);
  }

  private void List_SelectedIndexChanged(object sender, EventArgs e)
  {
    ((TextEditorControlBase) this.txtShow).Text = this._ds.Tables[0].Rows[this.List.SelectedIndex][this._displayMember].ToString();
  }
}
