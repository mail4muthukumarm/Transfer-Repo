// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.FormDataUpdate
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

[DesignerGenerated]
public class FormDataUpdate : Form
{
  private IContainer components;
  private DataRow _row;
  private string _tableName;
  private string _whereClause;
  private string _updatedFields;
  private SqlTransaction _t;
  private Dictionary<string, string> _columns;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.label1 = new Label();
    this.lstQuoteColumns = new MGACheckedListBox();
    this.lnkDeSelectAll = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.btnSave = new MGAButton();
    this.lblUserCaption = new Label();
    this.cnSQL = new SqlConnection();
    this.btnCancel = new MGAButton();
    ((ISupportInitialize) this.lstQuoteColumns).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    this.label1.AutoSize = true;
    this.label1.Location = new Point(12, 9);
    this.label1.Name = "label1";
    this.label1.Size = new Size(162, 13);
    this.label1.TabIndex = 49;
    this.label1.Text = "The following data has changed:";
    this.lstQuoteColumns.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstQuoteColumns.CheckOnClick = true;
    this.lstQuoteColumns.Location = new Point(12, 40);
    this.lstQuoteColumns.Name = "lstQuoteColumns";
    this.lstQuoteColumns.Size = new Size(389, 379);
    this.lstQuoteColumns.TabIndex = 50;
    this.lnkDeSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lnkDeSelectAll.BackColor = Color.Transparent;
    this.lnkDeSelectAll.Location = new Point(12, 517);
    this.lnkDeSelectAll.Name = "lnkDeSelectAll";
    this.lnkDeSelectAll.Size = new Size(86, 16 /*0x10*/);
    this.lnkDeSelectAll.TabIndex = 52;
    this.lnkDeSelectAll.TabStop = true;
    this.lnkDeSelectAll.Text = "De-Select All";
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lnkSelectAll.BackColor = Color.Transparent;
    this.lnkSelectAll.Location = new Point(12, 493);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(70, 16 /*0x10*/);
    this.lnkSelectAll.TabIndex = 51;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    appearance1.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnSave).Font = new Font("Tahoma", 8f);
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(292, 488);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 53;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.lblUserCaption.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lblUserCaption.AutoSize = true;
    this.lblUserCaption.Location = new Point(12, 444);
    this.lblUserCaption.Name = "lblUserCaption";
    this.lblUserCaption.Size = new Size(163, 13);
    this.lblUserCaption.TabIndex = 54;
    this.lblUserCaption.Text = "Stuff to inform the user goes here";
    this.cnSQL.ConnectionString = "workstation id=ERICHARDS1;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnCancel).Font = new Font("Tahoma", 8f);
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(361, 488);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 55;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(412, 540);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.lblUserCaption);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lnkDeSelectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.lstQuoteColumns);
    this.Controls.Add((Control) this.label1);
    this.Name = nameof (FormDataUpdate);
    this.Text = "Information To Update";
    ((ISupportInitialize) this.lstQuoteColumns).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("label1")]
  private virtual Label label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lstQuoteColumns")]
  internal virtual MGACheckedListBox lstQuoteColumns { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkDeSelectAll
  {
    get => this._lnkDeSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAll_LinkClicked);
      LinkLabel lnkDeSelectAll1 = this._lnkDeSelectAll;
      if (lnkDeSelectAll1 != null)
        lnkDeSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAll = value;
      LinkLabel lnkDeSelectAll2 = this._lnkDeSelectAll;
      if (lnkDeSelectAll2 == null)
        return;
      lnkDeSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkSelectAll
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

  [field: AccessedThroughProperty("lblUserCaption")]
  private virtual Label lblUserCaption { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cnSQL")]
  private virtual SqlConnection cnSQL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  public FormDataUpdate(
    DataRow row,
    Dictionary<string, string> columns,
    SqlTransaction t,
    string whereClause,
    string messageCaption)
  {
    this._row = (DataRow) null;
    this._tableName = string.Empty;
    this._whereClause = string.Empty;
    this._updatedFields = string.Empty;
    this._t = (SqlTransaction) null;
    this._columns = new Dictionary<string, string>();
    this.InitializeComponent();
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._row = row;
    this._tableName = row.Table.TableName;
    this._columns = columns;
    this._t = t;
    this._whereClause = whereClause;
    this.lblUserCaption.Text = messageCaption;
    this.LoadColumns(columns);
  }

  public int ListBoxItemsCount => this.lstQuoteColumns.Items.Count;

  public string UpdatedFields => this._updatedFields;

  private void LoadColumns(Dictionary<string, string> columns)
  {
    try
    {
      foreach (KeyValuePair<string, string> column in columns)
      {
        if (MGASystems.Common.Functions.Database.DataHasChanged(this._row, this._row.Table.Columns[column.Key]))
          this.lstQuoteColumns.Items.Add((object) column.Value);
      }
    }
    finally
    {
      Dictionary<string, string>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    for (int index = 0; index <= this.lstQuoteColumns.Items.Count - 1; ++index)
      this.lstQuoteColumns.SetItemChecked(index, true);
  }

  private void lnkDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    for (int index = 0; index <= this.lstQuoteColumns.Items.Count - 1; ++index)
      this.lstQuoteColumns.SetItemChecked(index, false);
  }

  private string GetKeyFromValue(string value)
  {
    string keyFromValue;
    try
    {
      foreach (KeyValuePair<string, string> column in this._columns)
      {
        if (column.Value.Equals(value))
        {
          keyFromValue = column.Key;
          goto label_6;
        }
      }
    }
    finally
    {
      Dictionary<string, string>.Enumerator enumerator;
      enumerator.Dispose();
    }
    keyFromValue = string.Empty;
label_6:
    return keyFromValue;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (this.lstQuoteColumns.CheckedItems.Count > 0)
    {
      string empty = string.Empty;
      string str1 = $"UPDATE {this._tableName} ";
      List<SqlParameter> sqlParameterList = new List<SqlParameter>();
      bool flag = false;
      int num = this.lstQuoteColumns.Items.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (this.lstQuoteColumns.GetItemChecked(index))
        {
          string str2 = this.lstQuoteColumns.Items[index].ToString();
          string keyFromValue = this.GetKeyFromValue(str2);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(keyFromValue, string.Empty, false) != 0)
          {
            string parameterName = "@" + keyFromValue;
            sqlParameterList.Add(new SqlParameter(parameterName, RuntimeHelpers.GetObjectValue(this._row[keyFromValue]))
            {
              SqlDbType = DatabaseTypeConvertor.ToSqlDbType(this._row.Table.Columns[keyFromValue].DataType)
            });
            if (flag)
            {
              str1 = $"{str1} , {keyFromValue} = {parameterName} ";
              // ISSUE: variable of a reference type
              string& local;
              // ISSUE: explicit reference operation
              string str3 = $"{^(local = ref this._updatedFields)}, {str2}";
              local = str3;
            }
            else
            {
              str1 = $"{str1} SET {keyFromValue} = {parameterName} ";
              this._updatedFields = str2;
              flag = true;
            }
          }
        }
      }
      string str4 = str1 + this._whereClause;
      this.Cursor = MgaCursors.WaitCursor;
      if (this._t != null)
      {
        SqlCommand sqlCommand = (SqlCommand) null;
        try
        {
          sqlCommand = new SqlCommand(str4, this._t.Connection);
          int index = 0;
          try
          {
            foreach (SqlParameter sqlParameter in sqlParameterList)
            {
              sqlCommand.Parameters.AddWithValue(sqlParameter.ParameterName, RuntimeHelpers.GetObjectValue(sqlParameter.Value));
              sqlCommand.Parameters[index].SqlDbType = sqlParameter.SqlDbType;
              ++index;
            }
          }
          finally
          {
            List<SqlParameter>.Enumerator enumerator;
            enumerator.Dispose();
          }
          sqlCommand.Transaction = this._t;
          sqlCommand.ExecuteNonQuery();
        }
        finally
        {
          sqlCommand.Dispose();
          this.Cursor = MgaCursors.Default;
        }
      }
      else
      {
        try
        {
          MGASystems.Common.DataAccess.Database.Instance.QueryText.PerformNonQuery(str4, sqlParameterList.ToArray());
        }
        finally
        {
          this.Cursor = MgaCursors.Default;
        }
      }
      this.DialogResult = DialogResult.OK;
    }
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();
}
