// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormTablePolicyNumberEntry
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormTablePolicyNumberEntry : FormBase
{
  private IContainer components;
  private readonly bool _ruleExists;
  private readonly bool _isTableRule;
  private readonly int _ruleID;

  [DebuggerNonUserCode]
  protected virtual void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Form) this).Dispose(disposing));
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.txtInputFileName = new TextBox();
    this.Label1 = new Label();
    this.btnInputDialog = new Button();
    this.Label2 = new Label();
    this.lblRuleName = new Label();
    this.btnGenPolicyNumbers = new Button();
    ((Control) this).SuspendLayout();
    this.txtInputFileName.Location = new Point(90, 56);
    this.txtInputFileName.Name = "txtInputFileName";
    this.txtInputFileName.Size = new Size(359, 20);
    this.txtInputFileName.TabIndex = 0;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(12, 60);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(53, 13);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Input File:";
    this.btnInputDialog.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnInputDialog.Location = new Point(455, 55);
    this.btnInputDialog.Name = "btnInputDialog";
    this.btnInputDialog.Size = new Size(157, 23);
    this.btnInputDialog.TabIndex = 2;
    this.btnInputDialog.Text = "Browse for input text file ...";
    this.btnInputDialog.UseVisualStyleBackColor = true;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(12, 18);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(69, 13);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Current Rule:";
    this.lblRuleName.AutoSize = true;
    this.lblRuleName.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblRuleName.Location = new Point(87, 18);
    this.lblRuleName.Name = "lblRuleName";
    this.lblRuleName.Size = new Size(65, 13);
    this.lblRuleName.TabIndex = 4;
    this.lblRuleName.Text = "RuleName";
    this.btnGenPolicyNumbers.FlatStyle = FlatStyle.Popup;
    this.btnGenPolicyNumbers.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnGenPolicyNumbers.Location = new Point(206, 138);
    this.btnGenPolicyNumbers.Name = "btnGenSqlStatements";
    this.btnGenPolicyNumbers.Size = new Size(164, 23);
    this.btnGenPolicyNumbers.TabIndex = 5;
    this.btnGenPolicyNumbers.Text = "Generate Policy Numbers";
    this.btnGenPolicyNumbers.UseVisualStyleBackColor = true;
    ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
    ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
    ((Form) this).BackColor = Color.White;
    ((Form) this).ClientSize = new Size(619, 173);
    ((Control) this).Controls.Add((Control) this.btnGenPolicyNumbers);
    ((Control) this).Controls.Add((Control) this.lblRuleName);
    ((Control) this).Controls.Add((Control) this.Label2);
    ((Control) this).Controls.Add((Control) this.btnInputDialog);
    ((Control) this).Controls.Add((Control) this.Label1);
    ((Control) this).Controls.Add((Control) this.txtInputFileName);
    ((Form) this).MaximizeBox = false;
    ((Form) this).MinimizeBox = false;
    ((Control) this).Name = nameof (FormTablePolicyNumberEntry);
    ((Form) this).Text = "Table-Based Policy # Generation";
    ((Control) this).ResumeLayout(false);
    ((Control) this).PerformLayout();
  }

  [field: AccessedThroughProperty("txtInputFileName")]
  internal virtual TextBox txtInputFileName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnInputDialog
  {
    get => this._btnInputDialog;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDialog_Click);
      Button btnInputDialog1 = this._btnInputDialog;
      if (btnInputDialog1 != null)
        btnInputDialog1.Click -= eventHandler;
      this._btnInputDialog = value;
      Button btnInputDialog2 = this._btnInputDialog;
      if (btnInputDialog2 == null)
        return;
      btnInputDialog2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblRuleName")]
  internal virtual Label lblRuleName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnGenPolicyNumbers
  {
    get => this._btnGenPolicyNumbers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGenPolicyNumbers_Click);
      Button genPolicyNumbers1 = this._btnGenPolicyNumbers;
      if (genPolicyNumbers1 != null)
        genPolicyNumbers1.Click -= eventHandler;
      this._btnGenPolicyNumbers = value;
      Button genPolicyNumbers2 = this._btnGenPolicyNumbers;
      if (genPolicyNumbers2 == null)
        return;
      genPolicyNumbers2.Click += eventHandler;
    }
  }

  public FormTablePolicyNumberEntry(int ruleID)
  {
    this.InitializeComponent();
    this._ruleID = ruleID;
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT RuleName, UseTableBasedNumbering FROM tblPolicyNumberRules WITH (NOLOCK) WHERE RuleID = @ID", new object[2]
    {
      (object) "@ID",
      (object) ruleID
    });
    this._ruleExists = !row.IsNull("RuleName");
    if (!this._ruleExists)
      return;
    this.lblRuleName.Text = row.Field<string>("RuleName");
    this._isTableRule = row.Field<bool>("UseTableBasedNumbering");
  }

  private void btnDialog_Click(object sender, EventArgs e)
  {
    this.txtInputFileName.Text = string.Empty;
    using (OpenFileDialog openFileDialog = new OpenFileDialog())
    {
      openFileDialog.Title = "Input File Dialog";
      openFileDialog.Filter = "Text files (*.txt)|*.txt";
      openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.txtInputFileName.Text = openFileDialog.FileName;
    }
  }

  private bool ValidInputFile()
  {
    bool flag;
    if (string.IsNullOrEmpty(this.txtInputFileName.Text))
    {
      int num = (int) MessageBox.Show("Empty input filename.", "Empty Input FileName", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private bool ValidTableBasedRule()
  {
    bool flag;
    if (!this._ruleExists)
    {
      int num = (int) MessageBox.Show($"Rule '{this.lblRuleName.Text}' does not exist.", "Rule Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (!this._isTableRule)
    {
      int num = (int) MessageBox.Show($"Rule '{this.lblRuleName.Text}' is not table-based.", "Rule Not Table-based", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void InsertTableBasedPolicyNumbers()
  {
    string str1 = string.Empty;
    using (StreamReader streamReader = new StreamReader(this.txtInputFileName.Text))
    {
      string empty = string.Empty;
      while (streamReader.Peek() >= 0)
      {
        string str2 = streamReader.ReadLine();
        str1 = $"{str1}{str2}/";
      }
    }
    try
    {
      ((Control) this).Cursor = MgaCursors.WaitCursor;
      DataTable source1 = DefaultDatabase.ExecuteDataTable("dbo.ImportTableBasePolicyNumbers", new object[4]
      {
        (object) "@PolicyNumberRuleID",
        (object) this._ruleID,
        (object) "@PolicyNumberBlob",
        (object) str1
      });
      if (source1.Rows.Count <= 0)
        return;
      string duplicateType = source1.Rows[0].Field<string>("Result");
      string newLine = Environment.NewLine;
      EnumerableRowCollection<DataRow> source2 = source1.AsEnumerable();
      System.Func<DataRow, string> selector;
      // ISSUE: reference to a compiler-generated field
      if (FormTablePolicyNumberEntry._Closure\u0024__.\u0024I34\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = FormTablePolicyNumberEntry._Closure\u0024__.\u0024I34\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        FormTablePolicyNumberEntry._Closure\u0024__.\u0024I34\u002D0 = selector = (System.Func<DataRow, string>) ([SpecialName] (row) => row.Field<string>("PolicyNumber"));
      }
      EnumerableRowCollection<string> values = source2.Select<DataRow, string>(selector);
      string duplicatePolicies = string.Join(newLine, (IEnumerable<string>) values);
      string str3 = string.Empty;
      if (duplicateType.Equals("Duplicates Found in Upload File", StringComparison.OrdinalIgnoreCase))
        str3 = this.GetDuplicateMessage(duplicateType, source1.Rows.Count, duplicatePolicies);
      else if (duplicateType.Equals("Already Associated with Rule", StringComparison.OrdinalIgnoreCase))
        str3 = this.GetDuplicateMessage(duplicateType, source1.Rows.Count, duplicatePolicies, this.lblRuleName.Text);
      else if (duplicateType.Equals("Inserted Successfully", StringComparison.OrdinalIgnoreCase))
      {
        int num1 = (int) MessageBox.Show("Successfully added table-based policy numbers.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str3, string.Empty, false) == 0)
        return;
      int num2 = (int) MessageBox.Show(str3, "Duplicate Policy Numbers Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      ((Control) this).Cursor = MgaCursors.Default;
    }
  }

  private string GetDuplicateMessage(
    string duplicateType,
    int count,
    string duplicatePolicies,
    string ruleName = "")
  {
    string lower = duplicateType.ToLower();
    string duplicateMessage;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "duplicates found in upload file", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "already associated with rule", false) == 0)
        duplicateMessage = $"{$"Rule '{ruleName}' already has {count} table-based policy numbers already associated with this rule."}{Environment.NewLine}Remove duplicate numbers from the file and reupload. Process aborted.{Environment.NewLine}Duplicate Policy Numbers:{Environment.NewLine}{duplicatePolicies}";
      else
        duplicateMessage = string.Empty;
    }
    else
      duplicateMessage = $"{$"The upload file contains {count} duplicate policy numbers."}{Environment.NewLine}Remove duplicate numbers from the file and reupload. Process aborted.{Environment.NewLine}Duplicate Policy Numbers:{Environment.NewLine}{duplicatePolicies}";
    return duplicateMessage;
  }

  private void btnGenPolicyNumbers_Click(object sender, EventArgs e)
  {
    if (!this.ValidInputFile() || !this.ValidTableBasedRule())
      return;
    this.InsertTableBasedPolicyNumbers();
  }
}
