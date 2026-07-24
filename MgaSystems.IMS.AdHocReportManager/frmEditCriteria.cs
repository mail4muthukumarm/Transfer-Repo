// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.AdHocReportManager.frmEditCriteria
// Assembly: MGASystems.IMS.AdHocReportManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 82F2F291-BD8F-4EDC-8925-41D0C4FA14AC
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.AdHocReportManager.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.AdHocReportManager;

public class frmEditCriteria : Form
{
  private DataTable _dtAvalableCriteriaList = new DataTable();
  private DataTable _dtTempTable;
  private DataRow _drCriteria;
  private DataRow _drOriginalCriteria;
  private int _criteriaId;
  private int _MinCriteriaId;
  private int _CurrentOverloadNo;
  private Dictionary<string, ControlParameters> ControlParameterValues = new Dictionary<string, ControlParameters>();
  private string _ShortControlName;
  private lstAdHocControls AdHocControls;
  private string[] _ReturnParameters;
  private int documentAutomationGroup;
  private IContainer components;
  private Button btnCancel;
  private Button btnOk;
  private ComboBox cbCriterion;
  private Label label1;
  private Label label2;
  private NumericUpDown txtOverloadNo;
  private Panel panel1;
  private TableLayoutPanel tableLayoutPanel1;
  private Panel panel2;
  private TextBox txtFullControlName;
  private Label lblOverloadsCount;
  private Label label3;

  public frmEditCriteria(int criteriaId)
  {
    this.InitializeComponent();
    this._criteriaId = criteriaId;
    this.AdHocControls = new lstAdHocControls();
  }

  public frmEditCriteria(DataRow drCriteria)
  {
    this.InitializeComponent();
    this._dtTempTable = drCriteria.Table.Clone();
    this._dtTempTable.ImportRow(drCriteria);
    this._drCriteria = this._dtTempTable.Rows[0];
    this._drCriteria.Table.Columns.Add("NumberOfRetValues", typeof (int));
    this._drOriginalCriteria = drCriteria;
    this.AdHocControls = new lstAdHocControls();
  }

  public frmEditCriteria(DataRow drCriteria, int documentAutomationGroup)
    : this(drCriteria)
  {
    this.documentAutomationGroup = documentAutomationGroup;
  }

  public string[] ReturnParameters
  {
    set => this._ReturnParameters = value;
  }

  private void frmEditCriteria_Load(object sender, EventArgs e)
  {
    this._criteriaId = (int) this._drCriteria.ItemArray[2];
    this._dtAvalableCriteriaList = this.AdHocControls.GetAdHocControlGroups(this.documentAutomationGroup);
    this._drCriteria.Table.Rows[0]["NumberOfRetValues"] = (object) this.AdHocControls.NumberOfRetValues(this._criteriaId);
    this._ShortControlName = this._drCriteria.ItemArray[1].ToString();
    this._ShortControlName = this._ShortControlName.Substring(0, this._ShortControlName.IndexOf('('));
    this.cbCriterion.DataSource = (object) this._dtAvalableCriteriaList;
    this.cbCriterion.DisplayMember = "ControlName";
    this.cbCriterion.ValueMember = "ControlID";
    this.cbCriterion.Text = this._ShortControlName;
    this._MinCriteriaId = (int) this.cbCriterion.SelectedValue;
    this.txtOverloadNo.Maximum = (Decimal) (int) this._dtAvalableCriteriaList.Select($"ControlName = '{this._ShortControlName}'")[0]["OverloadsCount"];
    this._CurrentOverloadNo = this._criteriaId - this._MinCriteriaId + 1;
    this.txtOverloadNo.Value = (Decimal) this._CurrentOverloadNo;
    this.lblOverloadsCount.Text = this.txtOverloadNo.Maximum.ToString();
    this.initControlParameterValues(this._drCriteria);
    this.RebuildEditorForm();
    this.cbCriterion.SelectedIndexChanged += new EventHandler(this._criteriaIdChanged);
    this.txtOverloadNo.ValueChanged += new EventHandler(this._criteriaIdChanged);
  }

  private void _criteriaIdChanged(object sender, EventArgs e)
  {
    DataTable dataTable = new DataTable();
    this.cbCriterion.SelectedIndexChanged -= new EventHandler(this._criteriaIdChanged);
    this.txtOverloadNo.ValueChanged -= new EventHandler(this._criteriaIdChanged);
    if (sender.GetType().Name == "NumericUpDown")
    {
      this._CurrentOverloadNo = (int) this.txtOverloadNo.Value;
      this._criteriaId = this._MinCriteriaId + this._CurrentOverloadNo - 1;
    }
    if (sender.GetType().Name == "ComboBox")
    {
      this.txtOverloadNo.Maximum = (Decimal) (int) this._dtAvalableCriteriaList.Select($"ControlName = '{this.cbCriterion.Text}'")[0]["OverloadsCount"];
      this._CurrentOverloadNo = 1;
      this.txtOverloadNo.Value = (Decimal) this._CurrentOverloadNo;
      this._MinCriteriaId = (int) this.cbCriterion.SelectedValue;
      this._criteriaId = this._MinCriteriaId;
      this.lblOverloadsCount.Text = this.txtOverloadNo.Maximum.ToString();
    }
    DataTable adHocControl = this.AdHocControls.GetAdHocControl(this._criteriaId);
    this._drCriteria.BeginEdit();
    int index = this._drCriteria.Table.Rows.IndexOf(this._drCriteria);
    this._drCriteria.Table.Rows[index]["Description"] = adHocControl.Rows[0]["FullControlName"];
    this._drCriteria.Table.Rows[index]["ParametersCount"] = adHocControl.Rows[0]["NumberOfArgs"];
    this._drCriteria.Table.Rows[index]["NumberOfRetValues"] = adHocControl.Rows[0]["NumberOfRetValues"];
    this._drCriteria.Table.Rows[index]["CriteriaID"] = (object) this._criteriaId;
    this._drCriteria.AcceptChanges();
    this._drCriteria.EndEdit();
    this.initControlParameterValues(this._drCriteria);
    this.RebuildEditorForm();
    this.cbCriterion.SelectedIndexChanged += new EventHandler(this._criteriaIdChanged);
    this.txtOverloadNo.ValueChanged += new EventHandler(this._criteriaIdChanged);
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnOk_Click(object sender, EventArgs e) => this.SelectAndReturn();

  private void SelectAndReturn()
  {
    int num1 = (int) this._drCriteria.ItemArray[3];
    string str = this._drCriteria.ItemArray[1].ToString();
    int index = this._drOriginalCriteria.Table.Rows.IndexOf(this._drOriginalCriteria);
    this.CollectData();
    Dictionary<int, ControlParameters> dictionary = new Dictionary<int, ControlParameters>();
    foreach (KeyValuePair<string, ControlParameters> controlParameterValue in this.ControlParameterValues)
      dictionary.Add(controlParameterValue.Value.index, controlParameterValue.Value);
    this._drOriginalCriteria.Table.Rows[index]["Description"] = (object) str;
    this._drOriginalCriteria.Table.Rows[index]["CriteriaID"] = (object) this._criteriaId;
    this._drOriginalCriteria.Table.Rows[index]["ParametersCount"] = (object) num1;
    this._drOriginalCriteria.Table.Rows[index]["Parameter00"] = num1 <= 0 ? (object) "" : (object) dictionary[0].Value;
    this._drOriginalCriteria.Table.Rows[index]["Parameter01"] = num1 <= 1 ? (object) "" : (object) dictionary[1].Value;
    this._drOriginalCriteria.Table.Rows[index]["Parameter02"] = num1 <= 2 ? (object) "" : (object) dictionary[2].Value;
    this._drOriginalCriteria.Table.Rows[index]["Parameter03"] = num1 <= 3 ? (object) "" : (object) dictionary[3].Value;
    this._drOriginalCriteria.Table.Rows[index]["Parameter04"] = num1 <= 4 ? (object) "" : (object) dictionary[4].Value;
    this._drOriginalCriteria.Table.Rows[index]["Parameter05"] = num1 <= 5 ? (object) "" : (object) dictionary[5].Value;
    this._drOriginalCriteria.Table.Rows[index]["Parameter06"] = num1 <= 6 ? (object) "" : (object) dictionary[6].Value;
    this._drOriginalCriteria.Table.Rows[index]["Parameter07"] = num1 <= 7 ? (object) "" : (object) dictionary[7].Value;
    this._drOriginalCriteria.Table.Rows[index]["Parameter08"] = num1 <= 8 ? (object) "" : (object) dictionary[8].Value;
    int num2 = (int) this._drCriteria.Table.Rows[0]["NumberOfRetValues"];
    if (num2 == 1)
    {
      this._drOriginalCriteria.Table.Rows[index]["SQLParam1Name"] = (object) dictionary[dictionary.Keys.Count - 1].Value;
      this._drOriginalCriteria.Table.Rows[index]["SQLParam2Name"] = (object) DBNull.Value;
    }
    if (num2 == 2)
    {
      this._drOriginalCriteria.Table.Rows[index]["SQLParam1Name"] = (object) dictionary[dictionary.Keys.Count - 2].Value;
      this._drOriginalCriteria.Table.Rows[index]["SQLParam2Name"] = (object) dictionary[dictionary.Keys.Count - 1].Value;
    }
    this._drOriginalCriteria.Table.Rows[index]["ReturnType1"] = this._drCriteria.Table.Rows[0]["ReturnType1"];
    this._drOriginalCriteria.Table.Rows[index]["ReturnType2"] = this._drCriteria.Table.Rows[0]["ReturnType2"];
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void CollectData()
  {
    foreach (KeyValuePair<string, ControlParameters> controlParameterValue in this.ControlParameterValues)
    {
      ControlParameters controlParameters = controlParameterValue.Value;
      Control control = this.tableLayoutPanel1.Controls[controlParameters.index * 2 + 1];
      controlParameters.Value = control.Text;
    }
  }

  private void RebuildEditorForm()
  {
    this.tableLayoutPanel1.SuspendLayout();
    this.tableLayoutPanel1.Controls.Clear();
    int num = this.tableLayoutPanel1.GetColumnWidths()[1] - 2;
    foreach (KeyValuePair<string, ControlParameters> controlParameterValue in this.ControlParameterValues)
    {
      ControlParameters controlParameters = controlParameterValue.Value;
      Label label = new Label();
      label.Text = controlParameters.Name;
      this.tableLayoutPanel1.Controls.Add((Control) label, 0, controlParameters.index);
      string lower = controlParameters.Type.ToLower();
      if (lower != null)
      {
        switch (lower.Length)
        {
          case 3:
            if (lower == "int")
              goto label_22;
            continue;
          case 4:
            switch (lower[0])
            {
              case 'd':
                if (lower == "date")
                  break;
                continue;
              case 't':
                if (lower == "type")
                  goto label_25;
                continue;
              default:
                continue;
            }
            break;
          case 6:
            if (lower == "string")
            {
              TextBox textBox = new TextBox();
              textBox.Text = controlParameters.Value;
              textBox.Width = num;
              this.tableLayoutPanel1.Controls.Add((Control) textBox, 1, controlParameters.index);
              continue;
            }
            continue;
          case 7:
            switch (lower[0])
            {
              case 'b':
                if (lower == "boolean")
                {
                  ComboBox booleanCb = this.GetBooleanCB(controlParameters.Value);
                  booleanCb.Width = num;
                  this.tableLayoutPanel1.Controls.Add((Control) booleanCb, 1, controlParameters.index);
                  continue;
                }
                continue;
              case 'i':
                if (lower == "integer")
                  goto label_22;
                continue;
              default:
                continue;
            }
          case 8:
            if (lower == "datetime")
              break;
            continue;
          case 9:
            if (lower == "parameter")
            {
              ComboBox parametersCb = this.GetParametersCB(controlParameters.Value);
              parametersCb.Width = num;
              this.tableLayoutPanel1.Controls.Add((Control) parametersCb, 1, controlParameters.index);
              continue;
            }
            continue;
          case 10:
            if (lower == "returntype")
            {
              ComboBox typeTextCb = this.GetTypeTextCB(controlParameters.Value);
              typeTextCb.Width = num;
              this.tableLayoutPanel1.Controls.Add((Control) typeTextCb, 1, controlParameters.index);
              continue;
            }
            continue;
          case 11:
            if (lower == "system.type")
              goto label_25;
            continue;
          default:
            continue;
        }
        TextBox textBox1 = new TextBox();
        textBox1.Text = controlParameters.Value;
        if (textBox1.Text.Equals(string.Empty))
          textBox1.Text = "NOW";
        textBox1.Width = num;
        this.tableLayoutPanel1.Controls.Add((Control) textBox1, 1, controlParameters.index);
        continue;
label_22:
        NumericUpDown numericUpDown = new NumericUpDown();
        numericUpDown.Maximum = Decimal.MaxValue;
        numericUpDown.Width = num;
        int result;
        if (int.TryParse(controlParameters.Value, out result))
          numericUpDown.Value = (Decimal) result;
        this.tableLayoutPanel1.Controls.Add((Control) numericUpDown, 1, controlParameters.index);
        continue;
label_25:
        ComboBox typeCb = this.GetTypeCB(controlParameters.Value);
        typeCb.Width = num;
        this.tableLayoutPanel1.Controls.Add((Control) typeCb, 1, controlParameters.index);
      }
    }
    this.tableLayoutPanel1.ResumeLayout();
  }

  private ComboBox GetBooleanCB(string SelectedValue)
  {
    ComboBox booleanCb = new ComboBox();
    booleanCb.Items.Add((object) "true");
    booleanCb.Items.Add((object) "false");
    booleanCb.DropDownStyle = ComboBoxStyle.DropDownList;
    switch (SelectedValue.ToLower())
    {
      case "0":
        booleanCb.SelectedIndex = 1;
        break;
      case "1":
        booleanCb.SelectedIndex = 0;
        break;
      case "true":
        booleanCb.SelectedIndex = 0;
        break;
      case "false":
        booleanCb.SelectedIndex = 1;
        break;
      default:
        booleanCb.SelectedIndex = 0;
        break;
    }
    return booleanCb;
  }

  private ComboBox GetParametersCB(string SelectedValue)
  {
    ComboBox parametersCb = new ComboBox();
    parametersCb.DropDownStyle = ComboBoxStyle.DropDown;
    parametersCb.Items.AddRange((object[]) this._ReturnParameters);
    parametersCb.Text = SelectedValue.ToLower();
    return parametersCb;
  }

  private ComboBox GetTypeCB(string SelectedValue)
  {
    ComboBox typeCb = new ComboBox();
    typeCb.DropDownStyle = ComboBoxStyle.DropDownList;
    typeCb.Items.AddRange((object[]) new string[5]
    {
      "datetime",
      "date",
      "guid",
      "string",
      "int32"
    });
    typeCb.SelectedIndex = typeCb.FindStringExact(SelectedValue.ToLower());
    return typeCb;
  }

  private ComboBox GetTypeTextCB(string SelectedValue)
  {
    ComboBox typeTextCb = new ComboBox();
    typeTextCb.DropDownStyle = ComboBoxStyle.DropDownList;
    typeTextCb.Items.AddRange((object[]) new string[4]
    {
      "Str",
      "Dbl",
      "Dec",
      "Int"
    });
    typeTextCb.SelectedIndex = typeTextCb.FindStringExact(SelectedValue.ToLower());
    return typeTextCb;
  }

  private void initControlParameterValues(DataRow drCriteria)
  {
    Dictionary<string, ControlParameters> dictionary = new Dictionary<string, ControlParameters>((IDictionary<string, ControlParameters>) this.ControlParameterValues);
    this.ControlParameterValues.Clear();
    int num = (int) drCriteria.ItemArray[3];
    string str1 = this._drCriteria.ItemArray[1].ToString();
    this.txtFullControlName.Text = str1;
    string[] strArray = str1.Split('(', ')')[1].Replace("ByVal ", "").Replace(" As ", "|").Split(',');
    for (int index = 0; index < num; ++index)
    {
      string str2 = strArray[index].Split('|')[0];
      string str3 = strArray[index].Split('|')[1];
      string str4 = dictionary.Count != 0 ? "" : drCriteria.ItemArray[4 + index].ToString();
      this.ControlParameterValues.Add(str2.ToLower(), new ControlParameters()
      {
        index = index,
        Name = str2.Trim(),
        Type = str3.Trim(),
        Value = str4.Trim()
      });
    }
    this.ControlParameterValues.Add("SQL Argument 1", new ControlParameters()
    {
      index = num,
      Name = "SQL Argument 1",
      Type = "parameter",
      Value = drCriteria.ItemArray[16 /*0x10*/].ToString().Trim()
    });
    if (drCriteria.ItemArray[18] != DBNull.Value && (int) drCriteria.ItemArray[18] > 1)
      this.ControlParameterValues.Add("SQL Argument 2", new ControlParameters()
      {
        index = num + 1,
        Name = "SQL Argument 2",
        Type = "parameter",
        Value = drCriteria.ItemArray[17].ToString().Trim()
      });
    foreach (KeyValuePair<string, ControlParameters> controlParameterValue in this.ControlParameterValues)
    {
      ControlParameters controlParameters;
      if (dictionary.TryGetValue(controlParameterValue.Key, out controlParameters))
        controlParameterValue.Value.Value = controlParameters.Value;
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.btnCancel = new Button();
    this.btnOk = new Button();
    this.cbCriterion = new ComboBox();
    this.label1 = new Label();
    this.label2 = new Label();
    this.txtOverloadNo = new NumericUpDown();
    this.panel1 = new Panel();
    this.tableLayoutPanel1 = new TableLayoutPanel();
    this.panel2 = new Panel();
    this.txtFullControlName = new TextBox();
    this.label3 = new Label();
    this.lblOverloadsCount = new Label();
    this.txtOverloadNo.BeginInit();
    this.panel1.SuspendLayout();
    this.panel2.SuspendLayout();
    this.SuspendLayout();
    this.btnCancel.DialogResult = DialogResult.Cancel;
    this.btnCancel.Location = new Point(259, 3);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(75, 23);
    this.btnCancel.TabIndex = 1;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnOk.Location = new Point(155, 3);
    this.btnOk.Name = "btnOk";
    this.btnOk.Size = new Size(75, 23);
    this.btnOk.TabIndex = 2;
    this.btnOk.Text = "Ok";
    this.btnOk.UseVisualStyleBackColor = true;
    this.btnOk.Click += new EventHandler(this.btnOk_Click);
    this.cbCriterion.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbCriterion.FormattingEnabled = true;
    this.cbCriterion.Location = new Point(60, 6);
    this.cbCriterion.Name = "cbCriterion";
    this.cbCriterion.Size = new Size(337, 21);
    this.cbCriterion.TabIndex = 3;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(3, 9);
    this.label1.Name = "label1";
    this.label1.Size = new Size(51, 13);
    this.label1.TabIndex = 4;
    this.label1.Text = "Condition";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(406, 10);
    this.label2.Name = "label2";
    this.label2.Size = new Size(14, 13);
    this.label2.TabIndex = 6;
    this.label2.Text = "#";
    this.txtOverloadNo.Location = new Point(426, 7);
    this.txtOverloadNo.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.txtOverloadNo.Name = "txtOverloadNo";
    this.txtOverloadNo.ReadOnly = true;
    this.txtOverloadNo.Size = new Size(35, 20);
    this.txtOverloadNo.TabIndex = 7;
    this.txtOverloadNo.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.panel1.Controls.Add((Control) this.lblOverloadsCount);
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.cbCriterion);
    this.panel1.Controls.Add((Control) this.txtOverloadNo);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Dock = DockStyle.Top;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(515, 39);
    this.panel1.TabIndex = 8;
    this.tableLayoutPanel1.ColumnCount = 2;
    this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.tableLayoutPanel1.Dock = DockStyle.Fill;
    this.tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
    this.tableLayoutPanel1.Location = new Point(0, 100);
    this.tableLayoutPanel1.Name = "tableLayoutPanel1";
    this.tableLayoutPanel1.RowCount = 10;
    this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
    this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
    this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
    this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
    this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
    this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
    this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
    this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
    this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
    this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
    this.tableLayoutPanel1.Size = new Size(515, 380);
    this.tableLayoutPanel1.TabIndex = 9;
    this.panel2.Controls.Add((Control) this.btnOk);
    this.panel2.Controls.Add((Control) this.btnCancel);
    this.panel2.Dock = DockStyle.Bottom;
    this.panel2.Location = new Point(0, 480);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(515, 34);
    this.panel2.TabIndex = 10;
    this.txtFullControlName.Dock = DockStyle.Top;
    this.txtFullControlName.Location = new Point(0, 39);
    this.txtFullControlName.Multiline = true;
    this.txtFullControlName.Name = "txtFullControlName";
    this.txtFullControlName.ReadOnly = true;
    this.txtFullControlName.Size = new Size(515, 61);
    this.txtFullControlName.TabIndex = 11;
    this.label3.AutoSize = true;
    this.label3.Location = new Point(466, 10);
    this.label3.Name = "label3";
    this.label3.Size = new Size(16 /*0x10*/, 13);
    this.label3.TabIndex = 8;
    this.label3.Text = "of";
    this.lblOverloadsCount.AutoSize = true;
    this.lblOverloadsCount.Location = new Point(482, 10);
    this.lblOverloadsCount.Name = "lblOverloadsCount";
    this.lblOverloadsCount.Size = new Size(13, 13);
    this.lblOverloadsCount.TabIndex = 9;
    this.lblOverloadsCount.Text = "1";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(515, 514);
    this.Controls.Add((Control) this.tableLayoutPanel1);
    this.Controls.Add((Control) this.txtFullControlName);
    this.Controls.Add((Control) this.panel2);
    this.Controls.Add((Control) this.panel1);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (frmEditCriteria);
    this.Text = "Edit Criterion";
    this.Load += new EventHandler(this.frmEditCriteria_Load);
    this.txtOverloadNo.EndInit();
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.panel2.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
