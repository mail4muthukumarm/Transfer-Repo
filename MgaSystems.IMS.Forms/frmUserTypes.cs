// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmUserTypes
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

public class frmUserTypes : Form
{
  private readonly int _UserID;
  private bool _painted;
  private IContainer components;

  public frmUserTypes()
  {
    this.Load += new EventHandler(this.frmUserTypes_Load);
    this.Paint += new PaintEventHandler(this.frmUserTypes_Paint);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual MGACheckedListBox lstUserTypes
  {
    get => this._lstUserTypes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.lstUserTypes_ItemCheck);
      MGACheckedListBox lstUserTypes1 = this._lstUserTypes;
      if (lstUserTypes1 != null)
        lstUserTypes1.ItemCheck -= checkEventHandler;
      this._lstUserTypes = value;
      MGACheckedListBox lstUserTypes2 = this._lstUserTypes;
      if (lstUserTypes2 == null)
        return;
      lstUserTypes2.ItemCheck += checkEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsUserTypes ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.lstUserTypes = new MGACheckedListBox();
    this.ds = new dsUserTypes();
    ((ISupportInitialize) this.lstUserTypes).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.lstUserTypes.CheckOnClick = true;
    this.lstUserTypes.Dock = DockStyle.Fill;
    this.lstUserTypes.Location = new Point(0, 0);
    this.lstUserTypes.Name = "lstUserTypes";
    this.lstUserTypes.Size = new Size(312, 318);
    this.lstUserTypes.TabIndex = 0;
    this.ds.DataSetName = "dsUserTypes";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(312, 318);
    this.Controls.Add((Control) this.lstUserTypes);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmUserTypes);
    this.Text = "User Types";
    ((ISupportInitialize) this.lstUserTypes).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  public frmUserTypes(int userID)
  {
    this.Load += new EventHandler(this.frmUserTypes_Load);
    this.Paint += new PaintEventHandler(this.frmUserTypes_Paint);
    this.InitializeComponent();
    this._UserID = userID;
  }

  private void frmUserTypes_Load(object sender, EventArgs e)
  {
  }

  private void lstUserTypes_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    Cursor.Current = Cursors.WaitCursor;
    if (e.CurrentValue == e.NewValue)
      return;
    byte num = (byte) ((DataRowView) this.lstUserTypes.Items[e.Index])["TypeID"];
    string str = (string) ((DataRowView) this.lstUserTypes.Items[e.Index])["TypeName"];
    if (e.CurrentValue == CheckState.Unchecked)
    {
      if (RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT UserTypeID FROM tblUserTypes WHERE UserID=@UserID AND UserTypeID=@UserTypeID", new object[4]
      {
        (object) "@UserID",
        (object) this._UserID,
        (object) "@UserTypeID",
        (object) num
      })) == null)
      {
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "Insert INTO tblUserTypes(UserID,UserTypeID) VALUES(@UserID,@UserTypeID)", new object[4]
        {
          (object) "@UserID",
          (object) this._UserID,
          (object) "@UserTypeID",
          (object) num
        });
        CurrentUser.Instance.LogAction("Users Menu -  Added user type " + str, this._UserID);
      }
    }
    else
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblUserTypes WHERE UserID=@UserID AND UserTypeID= @UserTypeID", new object[4]
      {
        (object) "@UserID",
        (object) this._UserID,
        (object) "@UserTypeID",
        (object) num
      });
      CurrentUser.Instance.LogAction("Users Menu -  Removed user type " + str, this._UserID);
    }
    Cursor.Current = Cursors.Default;
  }

  private void frmUserTypes_Paint(object sender, PaintEventArgs e)
  {
    if (this._painted)
      return;
    this._painted = true;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstUserTypes"
    }, CommandType.Text, "SELECT TypeID, TypeName  FROM lstUserTypes");
    MGACheckedListBox lstUserTypes = this.lstUserTypes;
    lstUserTypes.DataSource = (object) this.ds.lstUserTypes;
    lstUserTypes.DisplayMember = "TypeName";
    lstUserTypes.ValueMember = "TypeID";
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT UserTypeID FROM tblUserTypes WHERE UserID =@ID", new object[2]
    {
      (object) "@ID",
      (object) this._UserID
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        int num = this.lstUserTypes.Items.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (((byte) ((DataRowView) this.lstUserTypes.Items[index]).Row[0]).Equals((byte) row[0]))
            this.lstUserTypes.SetItemChecked(index, true);
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
}
