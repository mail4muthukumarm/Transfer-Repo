// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Utilities.GLClassDialog
// Assembly: MgaSystems.IMS.Accounting.Utilities, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0980F864-5BDB-427E-98EE-09B90661DBB2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Utilities.dll

using MGASystems.Common.ErrorHandling;
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
namespace MGASystems.IMS.Accounting.Utilities;

internal sealed class GLClassDialog : Form
{
  internal int ClassID;
  internal string ClassFullName;
  internal string ClassShortName;
  internal short ClassLLimit;
  internal int GLCompanyId;
  private DateTime mCreationDate;
  private IContainer components;

  public GLClassDialog()
  {
    this.Load += new EventHandler(this.GLClassDialog_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFullName")]
  internal virtual TextBox txtFullName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtShortName")]
  internal virtual TextBox txtShortName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual NumericUpDown nudStartNumber
  {
    get => this._nudStartNumber;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.nudStartNumber_ValueChanged);
      NumericUpDown nudStartNumber1 = this._nudStartNumber;
      if (nudStartNumber1 != null)
        nudStartNumber1.ValueChanged -= eventHandler;
      this._nudStartNumber = value;
      NumericUpDown nudStartNumber2 = this._nudStartNumber;
      if (nudStartNumber2 == null)
        return;
      nudStartNumber2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblEndNumber")]
  internal virtual Label lblEndNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnOK
  {
    get => this._btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOK_Click);
      Button btnOk1 = this._btnOK;
      if (btnOk1 != null)
        btnOk1.Click -= eventHandler;
      this._btnOK = value;
      Button btnOk2 = this._btnOK;
      if (btnOk2 == null)
        return;
      btnOk2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("btnCan")]
  internal virtual Button btnCan { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.Label1 = new Label();
    this.txtFullName = new TextBox();
    this.Label2 = new Label();
    this.txtShortName = new TextBox();
    this.Label3 = new Label();
    this.nudStartNumber = new NumericUpDown();
    this.Label4 = new Label();
    this.lblEndNumber = new Label();
    this.btnOK = new Button();
    this.btnCan = new Button();
    this.nudStartNumber.BeginInit();
    this.SuspendLayout();
    this.Label1.Location = new Point(7, 14);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "&Full Name:";
    this.txtFullName.Location = new Point(92, 12);
    this.txtFullName.MaxLength = 40;
    this.txtFullName.Name = "txtFullName";
    this.txtFullName.Size = new Size(360, 20);
    this.txtFullName.TabIndex = 1;
    this.txtFullName.Text = "";
    this.Label2.Location = new Point(7, 39);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(72, 16 /*0x10*/);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Short Name:";
    this.txtShortName.Location = new Point(92, 39);
    this.txtShortName.MaxLength = 20;
    this.txtShortName.Name = "txtShortName";
    this.txtShortName.Size = new Size(360, 20);
    this.txtShortName.TabIndex = 3;
    this.txtShortName.Text = "";
    this.Label3.Location = new Point(5, 68);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(91, 16 /*0x10*/);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "Starting Number:";
    this.nudStartNumber.Increment = new Decimal(new int[4]
    {
      200,
      0,
      0,
      0
    });
    this.nudStartNumber.Location = new Point(92, 67);
    this.nudStartNumber.Maximum = new Decimal(new int[4]
    {
      9800,
      0,
      0,
      0
    });
    this.nudStartNumber.Minimum = new Decimal(new int[4]
    {
      3000,
      0,
      0,
      0
    });
    this.nudStartNumber.Name = "nudStartNumber";
    this.nudStartNumber.ReadOnly = true;
    this.nudStartNumber.Size = new Size(56, 20);
    this.nudStartNumber.TabIndex = 5;
    this.nudStartNumber.TextAlign = HorizontalAlignment.Right;
    this.nudStartNumber.Value = new Decimal(new int[4]
    {
      3000,
      0,
      0,
      0
    });
    this.Label4.Location = new Point(159, 70);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(88, 16 /*0x10*/);
    this.Label4.TabIndex = 6;
    this.Label4.Text = "Ending Number:";
    this.lblEndNumber.BorderStyle = BorderStyle.Fixed3D;
    this.lblEndNumber.Location = new Point(247, 67);
    this.lblEndNumber.Name = "lblEndNumber";
    this.lblEndNumber.Size = new Size(80 /*0x50*/, 25);
    this.lblEndNumber.TabIndex = 7;
    this.btnOK.DialogResult = DialogResult.OK;
    this.btnOK.Location = new Point(304, 114);
    this.btnOK.Name = "btnOK";
    this.btnOK.Size = new Size(72, 24);
    this.btnOK.TabIndex = 8;
    this.btnOK.Text = "Ok";
    this.btnCan.DialogResult = DialogResult.Cancel;
    this.btnCan.Location = new Point(380, 114);
    this.btnCan.Name = "btnCan";
    this.btnCan.Size = new Size(72, 24);
    this.btnCan.TabIndex = 9;
    this.btnCan.Text = "Cancel";
    this.AcceptButton = (IButtonControl) this.btnOK;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.CancelButton = (IButtonControl) this.btnCan;
    this.ClientSize = new Size(456, 141);
    this.Controls.Add((Control) this.btnCan);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.lblEndNumber);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.nudStartNumber);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.txtShortName);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtFullName);
    this.Controls.Add((Control) this.Label1);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (GLClassDialog);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.nudStartNumber.EndInit();
    this.ResumeLayout(false);
  }

  internal short ClassEndNumber => (short) ((int) Convert.ToInt16(this.nudStartNumber.Value) + 199);

  internal DateTime CreationDate => this.mCreationDate;

  private void GLClassDialog_Load(object sender, EventArgs e)
  {
    if (this.ClassID < 1)
    {
      this.txtFullName.ResetText();
      this.txtShortName.ResetText();
      this.nudStartNumber.ResetText();
      this.Text = "New GL Category";
      this.nudStartNumber.Enabled = true;
    }
    else
    {
      this.txtFullName.Text = this.ClassFullName;
      this.txtShortName.Text = this.ClassShortName;
      this.nudStartNumber.Value = new Decimal((int) this.ClassLLimit);
      this.Text = "Edit GL Category";
      this.nudStartNumber.Enabled = false;
    }
    this.lblEndNumber.Text = this.ClassEndNumber.ToString();
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    bool flag1 = this.txtFullName.Modified | this.txtShortName.Modified;
    this.Cursor = Cursors.WaitCursor;
    bool flag2 = flag1 & this.txtFullName.TextLength > 0 & this.txtShortName.TextLength > 0;
    if (this.ClassID < 1 & flag2)
      this.DialogResult = (DialogResult) (-(this.InsertNewCategory() ? 1 : 0) & 1);
    else if (this.ClassID > 0 & flag2)
      this.DialogResult = (DialogResult) (-(this.UpdateExistingCategory() ? 1 : 0) & 1);
    else
      this.DialogResult = DialogResult.None;
    if (this.DialogResult == DialogResult.OK)
    {
      this.ClassFullName = this.txtFullName.Text;
      this.ClassShortName = this.txtShortName.Text;
      this.ClassLLimit = Convert.ToInt16(this.nudStartNumber.Value);
    }
    if (this.DialogResult == DialogResult.None & (this.txtFullName.TextLength == 0 | this.txtFullName.TextLength == 0))
    {
      int num = (int) MessageBox.Show("Full Name and Short Name are both required.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    this.Cursor = Cursors.Default;
  }

  private bool InsertNewCategory()
  {
    SqlCommand command = Tools.DBConnection.CreateCommand();
    this.ClassID = 0;
    string str = $"INSERT INTO tblFin_AcctClassifications (GLCompanyId, ClassLLimit, ClassFullName, ClassShortName, SystemDefined)  VALUES ({Conversions.ToString(this.GLCompanyId)}, {this.nudStartNumber.Value.ToString()}, '{this.txtFullName.Text}', '{this.txtShortName.Text}', 0)\r\nSELECT SCOPE_IDENTITY()";
    command.CommandType = CommandType.Text;
    command.CommandText = str;
    bool flag;
    if (!Tools.OpenConnection())
    {
      flag = false;
    }
    else
    {
      this.ClassID = (int) Conversions.ToShort(command.ExecuteScalar());
      if (this.ClassID > 0)
      {
        command.CommandText = "SELECT GETDATE()";
        try
        {
          this.mCreationDate = Conversions.ToDate(command.ExecuteScalar());
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          this.mCreationDate = DateTime.Now;
          ProjectData.ClearProjectError();
        }
      }
      command.Dispose();
      Tools.CloseConnection();
      flag = this.ClassID != 0;
    }
    return flag;
  }

  private bool UpdateExistingCategory()
  {
    SqlCommand command = Tools.DBConnection.CreateCommand();
    string str = $"UPDATE tblFin_AcctClassifications SET ClassLLimit = {Conversions.ToString(this.nudStartNumber.Value)}, ClassFullName = '{this.txtFullName.Text}', ClassShortName = '{this.txtShortName.Text}' WHERE (GLCompanyClassID = {Conversions.ToString(this.ClassID)}) AND (ClassFullName = '{this.ClassFullName}') AND (ClassShortName = '{this.ClassShortName}') AND (ClassLLimit = {Conversions.ToString((int) this.ClassLLimit)}) AND (SystemDefined = 0)";
    command.CommandText = str;
    command.CommandType = CommandType.Text;
    bool flag;
    if (!Tools.OpenConnection())
    {
      flag = false;
    }
    else
    {
      int num1;
      try
      {
        num1 = command.ExecuteNonQuery();
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        num1 = -1;
        ProjectData.ClearProjectError();
      }
      if (num1 == 0)
      {
        int num2 = (int) MessageBox.Show("Unable to update The GL category. The catgeory may have been changed by another user.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      command.Dispose();
      Tools.CloseConnection();
      flag = num1 > 0;
    }
    return flag;
  }

  private void nudStartNumber_ValueChanged(object sender, EventArgs e)
  {
    this.lblEndNumber.Text = this.ClassEndNumber.ToString();
  }
}
