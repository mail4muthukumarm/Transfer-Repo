// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.frmSpecialContactsBase
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.ErrorHandling;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[SecureResource("{1CF7C151-90DE-41cb-99F9-69D3BA46A2C2}", "New Special Contact", "Controls the ability for the user to add a new special contacts.", "Users")]
public class frmSpecialContactsBase : Form
{
  private IContainer components;
  private MGAListBox lstContacts;
  private MGATextBox txtNewContact;
  private Label Label1;
  protected SqlConnection cnSQL;
  private ErrorProvider err;
  private DataTable _contactsList;
  private SqlDataAdapter _contactsDataAdapter;
  private EventHandler _closingDelegate;
  private string _displayMember;
  private string _valueMember;
  internal const string CanAddNewSpecialContact = "{1CF7C151-90DE-41cb-99F9-69D3BA46A2C2}";

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedDelete);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedNew);
      QueryRowCountHandler queryRowCountHandler = new QueryRowCountHandler(this.dbSave_QueryRowCount);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_ClickedButton);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingCancel);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedDelete -= eventHandler1;
        dbSave1.ClickedNew -= eventHandler2;
        dbSave1.QueryRowCount -= queryRowCountHandler;
        dbSave1.ClickedButton -= eventHandler3;
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickingCancel -= cancelEventHandler2;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedDelete += eventHandler1;
      dbSave2.ClickedNew += eventHandler2;
      dbSave2.QueryRowCount += queryRowCountHandler;
      dbSave2.ClickedButton += eventHandler3;
      dbSave2.ClickingSave += cancelEventHandler1;
      dbSave2.ClickingCancel += cancelEventHandler2;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance = new Appearance();
    this.lstContacts = new MGAListBox();
    this.txtNewContact = new MGATextBox();
    this.Label1 = new Label();
    this.cnSQL = new SqlConnection();
    this.err = new ErrorProvider(this.components);
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    ((ISupportInitialize) this.lstContacts).BeginInit();
    ((ISupportInitialize) this.txtNewContact).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    this.lstContacts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstContacts.DisplayMember = "SpecialContactType";
    this.lstContacts.Location = new Point(8, 8);
    this.lstContacts.Name = "lstContacts";
    this.lstContacts.Size = new Size(471, 145);
    this.lstContacts.TabIndex = 14;
    this.lstContacts.ValueMember = "SpecialContactTypeID";
    ((Control) this.txtNewContact).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance.BackColor = Color.White;
    appearance.BorderColor = Color.Gray;
    appearance.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNewContact).Appearance = (AppearanceBase) appearance;
    ((TextEditorControlBase) this.txtNewContact).BackColor = Color.White;
    ((Control) this.txtNewContact).Enabled = false;
    ((Control) this.txtNewContact).Location = new Point(56, 173);
    ((Control) this.txtNewContact).Name = "txtNewContact";
    ((Control) this.txtNewContact).Size = new Size(301, 20);
    ((Control) this.txtNewContact).TabIndex = 2;
    ((UltraControlBase) this.txtNewContact).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNewContact).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label1.Location = new Point(7, 177);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(56, 16 /*0x10*/);
    this.Label1.TabIndex = 3;
    this.Label1.Text = "Contact:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.err.ContainerControl = (ContainerControl) this;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(367, 157);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 15;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(488, 201);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.lstContacts);
    this.Controls.Add((Control) this.txtNewContact);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.MaximizeBox = false;
    this.MinimumSize = new Size(504, 240 /*0xF0*/);
    this.Name = nameof (frmSpecialContactsBase);
    ((ISupportInitialize) this.lstContacts).EndInit();
    ((ISupportInitialize) this.txtNewContact).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmSpecialContactsBase(EventHandler closingHandler)
    : this()
  {
    this._closingDelegate = closingHandler;
  }

  public frmSpecialContactsBase()
  {
    this.Load += new EventHandler(this.frmSpecialContactsBase_Load);
    this.Closing += new CancelEventHandler(this.frmSpecialContactsBase_Closing);
    this._contactsList = new DataTable();
    this._displayMember = "SpecialContactType";
    this._valueMember = "SpecialContactTypeID";
    this.InitializeComponent();
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
  }

  [Browsable(true)]
  protected string DisplayMember
  {
    get => this._displayMember;
    set => this._displayMember = value;
  }

  [Browsable(true)]
  protected string ValueMember
  {
    get => this._valueMember;
    set => this._valueMember = value;
  }

  [Browsable(true)]
  protected DataTable ContactsList
  {
    get => this._contactsList;
    set => this._contactsList = value;
  }

  [Browsable(true)]
  protected SqlDataAdapter ContactsDataAdapter
  {
    get => this._contactsDataAdapter;
    set => this._contactsDataAdapter = value;
  }

  private void frmSpecialContactsBase_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Database.SafeDataAdapterFill(this.ContactsDataAdapter, this.ContactsList);
    if (this.ContactsList.Rows.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    MGAListBox lstContacts = this.lstContacts;
    lstContacts.DataSource = (object) this.ContactsList;
    lstContacts.ValueMember = this._valueMember;
    lstContacts.DisplayMember = this._displayMember;
    ((Control) this.txtNewContact).DataBindings.Add("Text", (object) this.ContactsList, this._displayMember);
  }

  private BindingManagerBase ContactsBindingManager
  {
    get => this.BindingContext[(object) this.ContactsList, this.ContactsList.TableName];
  }

  private void frmSpecialContactsBase_Closing(object sender, CancelEventArgs e)
  {
    if (this.dbSave.UIState == UIState.Editing)
    {
      switch (MessageBox.Show("Would you like to save your changes to the current record?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk))
      {
        case DialogResult.Cancel:
          e.Cancel = true;
          break;
        case DialogResult.Yes:
          if (((TextEditorControlBase) this.txtNewContact).Text.Length == 0)
          {
            int num = (int) MessageBox.Show("Please enter a contact description.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            e.Cancel = true;
            break;
          }
          this.SaveChanges();
          break;
      }
    }
    if (this.DesignMode || this._closingDelegate == null)
      return;
    this._closingDelegate(RuntimeHelpers.GetObjectValue(sender), (EventArgs) e);
  }

  private void dbSave_ClickedDelete(object sender, EventArgs e) => this.DeleteRecord();

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    if (SecurityManager.Instance.AssertPermission("{1CF7C151-90DE-41cb-99F9-69D3BA46A2C2}"))
    {
      this.NewRecord();
    }
    else
    {
      int num = (int) MessageBox.Show("You do not have the required permission to add new special contacts.", "Permission Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void NewRecord() => this.ContactsBindingManager.AddNew();

  private void DeleteRecord()
  {
    if (this.lstContacts.SelectedValue == null)
      return;
    int integer = Conversions.ToInteger(this.lstContacts.SelectedValue);
    DataRow[] dataRowArray = this.ContactsList.Select("SpecialContactTypeID = " + integer.ToString());
    if (dataRowArray[0] == null)
      return;
    dataRowArray[0].Delete();
    try
    {
      Database.SafeDataAdapterUpdate(this.ContactsDataAdapter, this.ContactsList);
    }
    catch (SqlException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      SqlException ex2 = ex1;
      if (ex2.State == (byte) 55)
      {
        dataRowArray[0].RejectChanges();
        int num = (int) MessageBox.Show("You can not delete system-defined contacts.", "System Defined Contact", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.lstContacts.SelectedValue = (object) integer;
      }
      else if (ex2.Message.ContainsNoCase("FK_tblCompanySpecialContacts_lstCompanySpecialContactTypes"))
      {
        dataRowArray[0].RejectChanges();
        int num = (int) MessageBox.Show("This contact type is currently being used in the system and cannot be deleted.", "Contact in use", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.lstContacts.SelectedValue = (object) integer;
      }
      else if (ex2.Message.ContainsNoCase("FK_tblInsuredsSpecialContacts_lstInsuredsSpecialContact"))
      {
        dataRowArray[0].RejectChanges();
        int num = (int) MessageBox.Show("This contact type is being designated as an Insured Special Contact and cannot be deleted.", "Contact In Use", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.lstContacts.SelectedValue = (object) integer;
      }
      else
        ErrorHandler.HandleError((Exception) ex2);
      ProjectData.ClearProjectError();
    }
  }

  private void dbSave_QueryRowCount(object sender, QueryRowCountEventArgs e)
  {
    if (this.DesignMode)
      return;
    e.RowCount = this.ContactsList.Rows.Count;
  }

  private void dbSave_ClickedButton(object sender, EventArgs e)
  {
    this.lstContacts.Enabled = this.dbSave.UIState != UIState.Editing;
    ((Control) this.txtNewContact).Enabled = this.dbSave.UIState == UIState.Editing;
    ((TextEditorControlBase) this.txtNewContact).Focus();
  }

  private bool DuplicateExists(string strDupeToFind)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(((DataRowView) this.lstContacts.SelectedItems[0])[this.ValueMember]);
    strDupeToFind = strDupeToFind.ToLower();
    int num = this.lstContacts.Items.Count - 1;
    bool flag;
    for (int index = 0; index <= num; ++index)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((DataRowView) this.lstContacts.Items[index])[this.DisplayMember].ToString().ToLower(), strDupeToFind, false) == 0 && !objectValue.Equals(RuntimeHelpers.GetObjectValue(((DataRowView) this.lstContacts.Items[index])[this.ValueMember])))
      {
        flag = true;
        goto label_6;
      }
    }
    flag = false;
label_6:
    return flag;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidateForm())
      e.Cancel = true;
    else
      this.SaveChanges();
  }

  private bool ValidateForm()
  {
    bool flag = true;
    if (((TextEditorControlBase) this.txtNewContact).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtNewContact, "Please enter a description for this contact.");
      flag = false;
    }
    else if (this.DuplicateExists(((TextEditorControlBase) this.txtNewContact).Text))
    {
      this.err.SetError((Control) this.txtNewContact, "Please enter a unique description for this contact.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtNewContact, string.Empty);
    ((Control) this.txtNewContact).BringToFront();
    return flag;
  }

  private void SaveChanges()
  {
    try
    {
      this.ContactsBindingManager.EndCurrentEdit();
      Database.SafeDataAdapterUpdate(this.ContactsDataAdapter, this.ContactsList);
      MDIControls.Instance.StatusBarText = "Special contacts saved succesfully.";
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ContactsList.RejectChanges();
    this.err.SetError((Control) this.txtNewContact, string.Empty);
    this.ContactsBindingManager.CancelCurrentEdit();
  }
}
