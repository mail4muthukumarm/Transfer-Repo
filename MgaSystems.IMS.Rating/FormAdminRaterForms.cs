// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormAdminRaterForms
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.FormattedLinkLabel;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Policies.Rating.PolicyForms;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormAdminRaterForms : Form
{
  private IContainer components;
  private CompanyLine _companyLine;
  private Decimal _nupValue;

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
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormAdminRaterForms));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblRaterFormSetups", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("SetupID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PolicyFormID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("RaterID", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyLineConditionID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("formDescription");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("SingleTransaction");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("tblRaterFormSetups_tblRaterFormAutomation");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("FormNumber", 0);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("FormName", 1);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Disabled", 2);
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblRaterFormSetups_tblRaterFormAutomation", 0);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ConditionalID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Operator");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Amount");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("SetupID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("ConditionID");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("RaterID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("FormVisibility");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblRaterFormSetups_tblRaterFormAutomation", -1);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ConditionalID");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Operator");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("Amount");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("SetupID");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("ConditionID");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("RaterID");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("FormVisibility");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("Delete", 0);
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    this.cn = new SqlConnection();
    this.cboForms = new MGASimpleComboBox();
    this.bindingSetups = new BindingSource(this.components);
    this.ds = new dsAdminRaterForms();
    this.cboRaters = new MGASimpleComboBox();
    this.cboCompanyLineConditions = new MGASimpleComboBox();
    this.cboConditions = new MGASimpleComboBox();
    this.bindingConditions = new BindingSource(this.components);
    this.bindingRaterConditions = new BindingSource(this.components);
    this.cboOperator = new MGASimpleComboBox();
    this.lnkDeleteCondition = new UltraFormattedTextEditor();
    this.Label6 = new Label();
    this.daSetups = new SqlDataAdapter();
    this.daFormConditions = new SqlDataAdapter();
    this.err = new ErrorProvider(this.components);
    this.pnlMainForm = new Panel();
    this.lnkDeleteAllCond = new LinkLabel();
    this.Label7 = new Label();
    this.nudGridSize = new NumericUpDown();
    this.gridSavedSetups = new UltraGrid();
    this.pnlConditions = new Panel();
    this.gridConditions = new UltraGrid();
    this.grpConditionSetup = new UltraGroupBox();
    this.chkSingleTransaction = new CheckBox();
    this.chkFormVisibility = new CheckBox();
    this.txtAmount = new MGATextBox();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.TableLayoutPanel1 = new TableLayoutPanel();
    Label label1 = new Label();
    Label label2 = new Label();
    SqlCommand sqlCommand1 = new SqlCommand();
    SqlCommand sqlCommand2 = new SqlCommand();
    SqlCommand sqlCommand3 = new SqlCommand();
    SqlCommand sqlCommand4 = new SqlCommand();
    SqlCommand sqlCommand5 = new SqlCommand();
    SqlCommand sqlCommand6 = new SqlCommand();
    SqlCommand sqlCommand7 = new SqlCommand();
    SqlCommand sqlCommand8 = new SqlCommand();
    Label label3 = new Label();
    Label label4 = new Label();
    Label label5 = new Label();
    ((ISupportInitialize) this.cboForms).BeginInit();
    ((ISupportInitialize) this.bindingSetups).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboRaters).BeginInit();
    ((ISupportInitialize) this.cboCompanyLineConditions).BeginInit();
    ((ISupportInitialize) this.cboConditions).BeginInit();
    ((ISupportInitialize) this.bindingConditions).BeginInit();
    ((ISupportInitialize) this.bindingRaterConditions).BeginInit();
    ((ISupportInitialize) this.cboOperator).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.pnlMainForm.SuspendLayout();
    this.nudGridSize.BeginInit();
    ((ISupportInitialize) this.gridSavedSetups).BeginInit();
    this.pnlConditions.SuspendLayout();
    ((ISupportInitialize) this.gridConditions).BeginInit();
    ((ISupportInitialize) this.grpConditionSetup).BeginInit();
    ((Control) this.grpConditionSetup).SuspendLayout();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    this.TableLayoutPanel1.SuspendLayout();
    this.SuspendLayout();
    label1.AutoSize = true;
    label1.Location = new Point(104, 43);
    label1.Name = "Label2";
    label1.Size = new Size(35, 13);
    label1.TabIndex = 10;
    label1.Text = "Form:";
    label1.TextAlign = ContentAlignment.MiddleRight;
    label2.AutoSize = true;
    label2.Location = new Point(101, 16 /*0x10*/);
    label2.Name = "Label1";
    label2.Size = new Size(38, 13);
    label2.TabIndex = 8;
    label2.Text = "Rater:";
    label2.TextAlign = ContentAlignment.MiddleRight;
    sqlCommand1.CommandText = "DELETE FROM [tblRaterFormSetups] WHERE (([SetupID] = @Original_SetupID))";
    sqlCommand1.Connection = this.cn;
    sqlCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_SetupID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SetupID", DataRowVersion.Original, (object) null)
    });
    this.cn.ConnectionString = "Data Source=mgads0001.mgasystems.com,1433;Initial Catalog=demo;Integrated Security=True;Persist Security Info=True";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    sqlCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    sqlCommand2.Connection = this.cn;
    sqlCommand2.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@PolicyFormID", SqlDbType.Int, 4, "PolicyFormID"),
      new SqlParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID"),
      new SqlParameter("@RaterID", SqlDbType.Int, 4, "RaterID"),
      new SqlParameter("@CompanyLineConditionID", SqlDbType.Int, 4, "CompanyLineConditionID"),
      new SqlParameter("@SingleTransaction", SqlDbType.Bit, 1, "SingleTransaction")
    });
    sqlCommand3.CommandText = "SELECT        SetupID, PolicyFormID, CompanyLineID, RaterID, CompanyLineConditionID, SingleTransaction\r\nFROM            tblRaterFormSetups\r\nWHERE        (CompanyLineID = @companylineid)";
    sqlCommand3.Connection = this.cn;
    sqlCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@companylineid", SqlDbType.Int, 4, "CompanyLineID")
    });
    sqlCommand4.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    sqlCommand4.Connection = this.cn;
    sqlCommand4.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@PolicyFormID", SqlDbType.Int, 4, "PolicyFormID"),
      new SqlParameter("@CompanyLineID", SqlDbType.Int, 4, "CompanyLineID"),
      new SqlParameter("@RaterID", SqlDbType.Int, 4, "RaterID"),
      new SqlParameter("@CompanyLineConditionID", SqlDbType.Int, 4, "CompanyLineConditionID"),
      new SqlParameter("@SingleTransaction", SqlDbType.Bit, 1, "SingleTransaction"),
      new SqlParameter("@Original_SetupID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SetupID", DataRowVersion.Original, (object) null),
      new SqlParameter("@SetupID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SetupID", DataRowVersion.Original, (object) null)
    });
    sqlCommand5.CommandText = "DELETE FROM [tblRaterFormAutomation] WHERE (([ConditionID] = @Original_ConditionID))";
    sqlCommand5.Connection = this.cn;
    sqlCommand5.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ConditionID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ConditionID", DataRowVersion.Original, (object) null)
    });
    sqlCommand6.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    sqlCommand6.Connection = this.cn;
    sqlCommand6.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@ConditionalID", SqlDbType.Int, 4, "ConditionalID"),
      new SqlParameter("@RaterID", SqlDbType.Int, 4, "RaterID"),
      new SqlParameter("@Operator", SqlDbType.Char, 2, "Operator"),
      new SqlParameter("@Amount", SqlDbType.VarChar, 5000, "Amount"),
      new SqlParameter("@SetupID", SqlDbType.Int, 4, "SetupID"),
      new SqlParameter("@FormVisibility", SqlDbType.Bit, 1, "FormVisibility")
    });
    sqlCommand7.CommandText = "SELECT        ConditionID, ConditionalID, RaterID, Operator, Amount, SetupID, FormVisibility\r\nFROM            tblRaterFormAutomation WITH (NOLOCK)\r\nWHERE        (SetupID = @setupID)";
    sqlCommand7.Connection = this.cn;
    sqlCommand7.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@setupID", SqlDbType.Int, 4, "SetupID")
    });
    sqlCommand8.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    sqlCommand8.Connection = this.cn;
    sqlCommand8.Parameters.AddRange(new SqlParameter[8]
    {
      new SqlParameter("@ConditionalID", SqlDbType.Int, 4, "ConditionalID"),
      new SqlParameter("@RaterID", SqlDbType.Int, 4, "RaterID"),
      new SqlParameter("@Operator", SqlDbType.Char, 2, "Operator"),
      new SqlParameter("@Amount", SqlDbType.VarChar, 5000, "Amount"),
      new SqlParameter("@SetupID", SqlDbType.Int, 4, "SetupID"),
      new SqlParameter("@FormVisibility", SqlDbType.Bit, 1, "FormVisibility"),
      new SqlParameter("@Original_ConditionID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ConditionID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ConditionID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ConditionID", DataRowVersion.Original, (object) null)
    });
    label3.AutoSize = true;
    label3.BackColor = Color.Transparent;
    label3.Location = new Point(8, 74);
    label3.Name = "Label5";
    label3.Size = new Size(37, 13);
    label3.TabIndex = 45;
    label3.Text = "Value:";
    label3.TextAlign = ContentAlignment.MiddleRight;
    label4.AutoSize = true;
    label4.BackColor = Color.Transparent;
    label4.Location = new Point(448, 37);
    label4.Name = "Label4";
    label4.Size = new Size(55, 13);
    label4.TabIndex = 43;
    label4.Text = "Operator:";
    label4.TextAlign = ContentAlignment.MiddleRight;
    label5.AutoSize = true;
    label5.BackColor = Color.Transparent;
    label5.Location = new Point(8, 37);
    label5.Name = "Label3";
    label5.Size = new Size(61, 13);
    label5.TabIndex = 41;
    label5.Text = "Conditions:";
    label5.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.cboForms).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboForms.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboForms).DataBindings.Add(new Binding("Value", (object) this.bindingSetups, "PolicyFormID", true, DataSourceUpdateMode.OnPropertyChanged));
    ((UltraGridBase) this.cboForms).DataMember = "tblPolicyForms";
    ((UltraGridBase) this.cboForms).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboForms).DisplayMember = "FormName";
    this.cboForms.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboForms).Location = new Point(145, 39);
    this.cboForms.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboForms).Name = "cboForms";
    ((Control) this.cboForms).Size = new Size(499, 21);
    ((Control) this.cboForms).TabIndex = 11;
    ((UltraControlBase) this.cboForms).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboForms).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboForms).ValueMember = "FormID";
    this.bindingSetups.DataMember = "tblRaterFormSetups";
    this.bindingSetups.DataSource = (object) this.ds;
    this.ds.DataSetName = "dsAdminRaterForms";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.cboRaters).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboRaters.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboRaters).DataMember = "tblCompanyRaters";
    ((UltraGridBase) this.cboRaters).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboRaters).DisplayMember = "RatingType";
    this.cboRaters.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboRaters).Location = new Point(145, 12);
    this.cboRaters.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboRaters).Name = "cboRaters";
    ((Control) this.cboRaters).Size = new Size(499, 21);
    ((Control) this.cboRaters).TabIndex = 9;
    ((UltraControlBase) this.cboRaters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboRaters).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboRaters).ValueMember = "RatingTypeID";
    ((Control) this.cboCompanyLineConditions).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboCompanyLineConditions.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboCompanyLineConditions).DataBindings.Add(new Binding("Value", (object) this.bindingSetups, "CompanyLineConditionID", true, DataSourceUpdateMode.OnPropertyChanged));
    ((UltraGridBase) this.cboCompanyLineConditions).DataMember = "tblConditions";
    ((UltraGridBase) this.cboCompanyLineConditions).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboCompanyLineConditions).DisplayMember = "Condition";
    this.cboCompanyLineConditions.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCompanyLineConditions).Location = new Point(145, 66);
    this.cboCompanyLineConditions.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompanyLineConditions).Name = "cboCompanyLineConditions";
    ((Control) this.cboCompanyLineConditions).Size = new Size(499, 21);
    ((Control) this.cboCompanyLineConditions).TabIndex = 50;
    ((UltraControlBase) this.cboCompanyLineConditions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanyLineConditions).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompanyLineConditions).ValueMember = "ConditionID";
    this.cboConditions.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboConditions).DataBindings.Add(new Binding("Value", (object) this.bindingConditions, "ConditionalID", true, DataSourceUpdateMode.OnPropertyChanged, (object) "N/A"));
    ((UltraGridBase) this.cboConditions).DataSource = (object) this.bindingRaterConditions;
    ((UltraDropDownBase) this.cboConditions).DisplayMember = "Condition";
    this.cboConditions.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboConditions).DropDownWidth = 700;
    ((Control) this.cboConditions).Location = new Point(75, 33);
    this.cboConditions.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboConditions).Name = "cboConditions";
    ((Control) this.cboConditions).Size = new Size(358, 21);
    ((Control) this.cboConditions).TabIndex = 42;
    ((UltraControlBase) this.cboConditions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboConditions).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboConditions).ValueMember = "ConditionalID";
    this.bindingConditions.AllowNew = true;
    this.bindingConditions.DataMember = "tblRaterFormSetups_tblRaterFormAutomation";
    this.bindingConditions.DataSource = (object) this.bindingSetups;
    this.bindingRaterConditions.DataMember = "Conditions";
    this.bindingRaterConditions.DataSource = (object) this.ds;
    this.bindingRaterConditions.Sort = "Condition";
    this.cboOperator.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboOperator).DataBindings.Add(new Binding("Value", (object) this.bindingConditions, "Operator", true, DataSourceUpdateMode.OnPropertyChanged, (object) "N/A"));
    ((UltraGridBase) this.cboOperator).DataMember = "Operators";
    ((UltraGridBase) this.cboOperator).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboOperator).DisplayMember = "Description";
    this.cboOperator.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboOperator).DropDownWidth = 300;
    ((Control) this.cboOperator).Location = new Point(518, 33);
    this.cboOperator.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboOperator).Name = "cboOperator";
    ((Control) this.cboOperator).Size = new Size(233, 21);
    ((Control) this.cboOperator).TabIndex = 44;
    ((UltraControlBase) this.cboOperator).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOperator).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboOperator).ValueMember = "Operator";
    ((AppearanceBase) appearance1).TextHAlignAsString = "Center";
    ((UltraFormattedTextEditorBase) this.lnkDeleteCondition).Appearance = (AppearanceBase) appearance1;
    ((UltraFormattedTextEditorBase) this.lnkDeleteCondition).AutoSize = true;
    ((Control) this.lnkDeleteCondition).Location = new Point(603, 3);
    ((Control) this.lnkDeleteCondition).Name = "lnkDeleteCondition";
    ((UltraFormattedTextEditorBase) this.lnkDeleteCondition).ScrollBarDisplayStyle = (ScrollBarDisplayStyle) 2;
    ((Control) this.lnkDeleteCondition).Size = new Size(60, 17);
    ((Control) this.lnkDeleteCondition).TabIndex = 47;
    ((UltraFormattedTextEditorBase) this.lnkDeleteCondition).TreatValueAs = (TreatValueAs) 2;
    ((UltraFormattedTextEditorBase) this.lnkDeleteCondition).Value = (object) "Delete";
    ((Control) this.lnkDeleteCondition).Visible = false;
    this.Label6.AutoSize = true;
    this.Label6.Location = new Point(12, 70);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size((int) sbyte.MaxValue, 13);
    this.Label6.TabIndex = 49;
    this.Label6.Text = "Company/Line Condition:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.daSetups.DeleteCommand = sqlCommand1;
    this.daSetups.InsertCommand = sqlCommand2;
    this.daSetups.SelectCommand = sqlCommand3;
    this.daSetups.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblRaterFormSetups", new DataColumnMapping[5]
      {
        new DataColumnMapping("SetupID", "SetupID"),
        new DataColumnMapping("PolicyFormID", "PolicyFormID"),
        new DataColumnMapping("CompanyLineID", "CompanyLineID"),
        new DataColumnMapping("RaterID", "RaterID"),
        new DataColumnMapping("SingleTransaction", "SingleTransaction")
      })
    });
    this.daSetups.UpdateCommand = sqlCommand4;
    this.daFormConditions.DeleteCommand = sqlCommand5;
    this.daFormConditions.InsertCommand = sqlCommand6;
    this.daFormConditions.SelectCommand = sqlCommand7;
    this.daFormConditions.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblRaterFormAutomation", new DataColumnMapping[7]
      {
        new DataColumnMapping("ConditionID", "ConditionID"),
        new DataColumnMapping("ConditionalID", "ConditionalID"),
        new DataColumnMapping("RaterID", "RaterID"),
        new DataColumnMapping("Operator", "Operator"),
        new DataColumnMapping("Amount", "Amount"),
        new DataColumnMapping("SetupID", "SetupID"),
        new DataColumnMapping("FormVisibility", "FormVisibility")
      })
    });
    this.daFormConditions.UpdateCommand = sqlCommand8;
    this.err.ContainerControl = (ContainerControl) this;
    this.pnlMainForm.Controls.Add((Control) this.lnkDeleteAllCond);
    this.pnlMainForm.Controls.Add((Control) this.Label7);
    this.pnlMainForm.Controls.Add((Control) this.nudGridSize);
    this.pnlMainForm.Controls.Add((Control) this.cboCompanyLineConditions);
    this.pnlMainForm.Controls.Add((Control) this.Label6);
    this.pnlMainForm.Controls.Add((Control) this.gridSavedSetups);
    this.pnlMainForm.Controls.Add((Control) label2);
    this.pnlMainForm.Controls.Add((Control) this.cboRaters);
    this.pnlMainForm.Controls.Add((Control) label1);
    this.pnlMainForm.Controls.Add((Control) this.cboForms);
    this.pnlMainForm.Dock = DockStyle.Fill;
    this.pnlMainForm.Location = new Point(3, 3);
    this.pnlMainForm.Name = "pnlMainForm";
    this.pnlMainForm.Size = new Size(769, 283);
    this.pnlMainForm.TabIndex = 49;
    this.lnkDeleteAllCond.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkDeleteAllCond.AutoSize = true;
    this.lnkDeleteAllCond.Location = new Point(518, 267);
    this.lnkDeleteAllCond.Name = "lnkDeleteAllCond";
    this.lnkDeleteAllCond.Size = new Size(180, 13);
    this.lnkDeleteAllCond.TabIndex = 57;
    this.lnkDeleteAllCond.TabStop = true;
    this.lnkDeleteAllCond.Text = "Delete ALL forms and ALL conditions";
    this.Label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(650, 16 /*0x10*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(57, 13);
    this.Label7.TabIndex = 56;
    this.Label7.Text = "Size Form:";
    this.Label7.Visible = false;
    this.nudGridSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.nudGridSize.Location = new Point(722, 12);
    this.nudGridSize.Maximum = new Decimal(new int[4]
    {
      10,
      0,
      0,
      0
    });
    this.nudGridSize.Name = "nudGridSize";
    this.nudGridSize.Size = new Size(44, 21);
    this.nudGridSize.TabIndex = 55;
    this.nudGridSize.Visible = false;
    ((Control) this.gridSavedSetups).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridSavedSetups).DataSource = (object) this.bindingSetups;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 57;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ultraGridColumn2.EditorComponent = (Component) this.cboForms;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Policy Form";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 4;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Style = (ColumnStyle) 5;
    ultraGridColumn2.Width = 205;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 6;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 120;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ultraGridColumn4.EditorComponent = (Component) this.cboRaters;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Rater";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Style = (ColumnStyle) 6;
    ultraGridColumn4.Width = 143;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ultraGridColumn5.EditorComponent = (Component) this.cboCompanyLineConditions;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Company / Line Condition";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn5.Style = (ColumnStyle) 5;
    ultraGridColumn5.Width = 249;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Policy Form Description";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 7;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 97;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Per Transaction";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).ToolTipText = "Indicates the condition is considered fresh on every Quote transaction, and will not be copied forward on endorsements, renewals, or rewrites.";
    ultraGridColumn7.Header.VisiblePosition = 8;
    ultraGridColumn7.Width = 113;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Form Number";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 2;
    ultraGridColumn9.Width = 122;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Form Name";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 3;
    ultraGridColumn10.Width = 140;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 9;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 103;
    ultraGridBand1.Columns.AddRange(new object[11]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11
    });
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 6;
    ultraGridBand2.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18
    });
    ultraGridBand2.Hidden = true;
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance3.BackColor = Color.LightSteelBlue;
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraGridBase) this.gridSavedSetups).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.gridSavedSetups).Location = new Point(0, 95);
    ((Control) this.gridSavedSetups).Name = "gridSavedSetups";
    ((Control) this.gridSavedSetups).Size = new Size(769, 170);
    this.gridSavedSetups.SyncWithCurrencyManagerAfterRowDeletion = true;
    ((Control) this.gridSavedSetups).TabIndex = 13;
    ((Control) this.gridSavedSetups).Text = "Existing Policy Forms Setups";
    ((UltraControlBase) this.gridSavedSetups).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridSavedSetups).UseOsThemes = (DefaultableBoolean) 2;
    this.pnlConditions.Controls.Add((Control) this.lnkDeleteCondition);
    this.pnlConditions.Controls.Add((Control) this.gridConditions);
    this.pnlConditions.Dock = DockStyle.Fill;
    this.pnlConditions.Location = new Point(3, 292);
    this.pnlConditions.Name = "pnlConditions";
    this.pnlConditions.Size = new Size(769, 150);
    this.pnlConditions.TabIndex = 50;
    ((UltraGridBase) this.gridConditions).DataSource = (object) this.bindingConditions;
    ((SpecialBoxBase) ((UltraGridBase) this.gridConditions).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.gridConditions).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.gridConditions).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridConditions).DisplayLayout.Appearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridConditions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.AddButtonCaption = "New Condition";
    ultraGridBand3.AddButtonToolTipText = "Add a new conditional to check current form/condition against rater data.";
    ultraGridColumn19.CellActivation = (Activation) 3;
    ultraGridColumn19.EditorComponent = (Component) this.cboConditions;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Condition";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 4;
    ultraGridColumn19.Width = 297;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ultraGridColumn20.EditorComponent = (Component) this.cboOperator;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 5;
    ultraGridColumn20.Width = 184;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 6;
    ultraGridColumn21.Width = 138;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 1;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 39;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 0;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 183;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 2;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 95;
    ultraGridColumn25.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn25.Header).Caption = "Visibility";
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 7;
    ultraGridColumn25.Width = 74;
    ultraGridColumn26.CellActivation = (Activation) 3;
    ultraGridColumn26.DefaultCellValue = (object) "Delete";
    ultraGridColumn26.EditorComponent = (Component) this.lnkDeleteCondition;
    ((HeaderBase) ultraGridColumn26.Header).Caption = "";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 3;
    ultraGridColumn26.Width = 57;
    ultraGridBand3.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26
    });
    ((UltraGridBase) this.gridConditions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.gridConditions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance11.BackColor = Color.LightSteelBlue;
    appearance11.FontData.SizeInPoints = 10f;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.gridConditions).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.gridConditions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridConditions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridConditions).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridConditions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridConditions).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance15.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridConditions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance15;
    appearance16.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridConditions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridConditions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance17.BackColor = Color.Transparent;
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.gridConditions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridConditions).DisplayLayout.Override.SupportDataErrorInfo = (SupportDataErrorInfo) 4;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridConditions).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.gridConditions).DisplayLayout.ShowDeleteRowsPrompt = false;
    ((UltraGridBase) this.gridConditions).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.gridConditions).Dock = DockStyle.Fill;
    ((Control) this.gridConditions).Location = new Point(0, 0);
    ((Control) this.gridConditions).Name = "gridConditions";
    ((Control) this.gridConditions).Size = new Size(769, 150);
    this.gridConditions.SyncWithCurrencyManagerAfterRowDeletion = true;
    ((Control) this.gridConditions).TabIndex = 44;
    ((Control) this.gridConditions).Text = "Conditions For the Selected Setup";
    ((UltraControlBase) this.gridConditions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridConditions).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.grpConditionSetup).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance18.BackColor = Color.FromArgb(239, 247, 253);
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpConditionSetup.ContentAreaAppearance = (AppearanceBase) appearance18;
    ((Control) this.grpConditionSetup).Controls.Add((Control) this.chkSingleTransaction);
    ((Control) this.grpConditionSetup).Controls.Add((Control) this.chkFormVisibility);
    ((Control) this.grpConditionSetup).Controls.Add((Control) this.txtAmount);
    ((Control) this.grpConditionSetup).Controls.Add((Control) label3);
    ((Control) this.grpConditionSetup).Controls.Add((Control) this.dbSave);
    ((Control) this.grpConditionSetup).Controls.Add((Control) this.cboOperator);
    ((Control) this.grpConditionSetup).Controls.Add((Control) label4);
    ((Control) this.grpConditionSetup).Controls.Add((Control) this.cboConditions);
    ((Control) this.grpConditionSetup).Controls.Add((Control) label5);
    appearance19.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpConditionSetup.HeaderAppearance = (AppearanceBase) appearance19;
    ((Control) this.grpConditionSetup).Location = new Point(3, 449);
    ((Control) this.grpConditionSetup).Name = "grpConditionSetup";
    ((Control) this.grpConditionSetup).Size = new Size(769, 132);
    ((Control) this.grpConditionSetup).TabIndex = 43;
    this.grpConditionSetup.Text = "Conditions Setup";
    this.grpConditionSetup.ViewStyle = (GroupBoxViewStyle) 3;
    this.chkSingleTransaction.AutoSize = true;
    this.chkSingleTransaction.BackColor = Color.Transparent;
    this.chkSingleTransaction.DataBindings.Add(new Binding("Checked", (object) this.bindingSetups, "SingleTransaction", true, DataSourceUpdateMode.OnPropertyChanged));
    this.chkSingleTransaction.Location = new Point(650, 63 /*0x3F*/);
    this.chkSingleTransaction.Name = "chkSingleTransaction";
    this.chkSingleTransaction.Size = new Size(101, 17);
    this.chkSingleTransaction.TabIndex = 47;
    this.chkSingleTransaction.Text = "Per Transaction";
    this.chkSingleTransaction.UseVisualStyleBackColor = false;
    this.chkSingleTransaction.Visible = false;
    this.chkFormVisibility.AutoSize = true;
    this.chkFormVisibility.BackColor = Color.Transparent;
    this.chkFormVisibility.DataBindings.Add(new Binding("Checked", (object) this.bindingConditions, "FormVisibility", true, DataSourceUpdateMode.OnPropertyChanged));
    this.chkFormVisibility.Location = new Point(451, 70);
    this.chkFormVisibility.Name = "chkFormVisibility";
    this.chkFormVisibility.Size = new Size(111, 17);
    this.chkFormVisibility.TabIndex = 47;
    this.chkFormVisibility.Text = "Visibility Condition";
    this.chkFormVisibility.UseVisualStyleBackColor = false;
    this.chkFormVisibility.Visible = false;
    appearance20.BackColor = Color.White;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAmount).Appearance = (AppearanceBase) appearance20;
    ((TextEditorControlBase) this.txtAmount).BackColor = Color.White;
    ((Control) this.txtAmount).DataBindings.Add(new Binding("Value", (object) this.bindingConditions, "Amount", true, DataSourceUpdateMode.OnPropertyChanged));
    ((Control) this.txtAmount).Location = new Point(76, 70);
    this.txtAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAmount).Name = "txtAmount";
    ((Control) this.txtAmount).Size = new Size(357, 20);
    ((Control) this.txtAmount).TabIndex = 46;
    ((UltraControlBase) this.txtAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAmount).UseOsThemes = (DefaultableBoolean) 2;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(639, 86);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 40;
    this.dbSave.Tag = (object) "keepAlive";
    this.TableLayoutPanel1.ColumnCount = 1;
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
    this.TableLayoutPanel1.Controls.Add((Control) this.pnlMainForm, 0, 0);
    this.TableLayoutPanel1.Controls.Add((Control) this.pnlConditions, 0, 1);
    this.TableLayoutPanel1.Controls.Add((Control) this.grpConditionSetup, 0, 2);
    this.TableLayoutPanel1.Dock = DockStyle.Fill;
    this.TableLayoutPanel1.Location = new Point(0, 0);
    this.TableLayoutPanel1.Name = "TableLayoutPanel1";
    this.TableLayoutPanel1.RowCount = 3;
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65f));
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35f));
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 138f));
    this.TableLayoutPanel1.Size = new Size(775, 584);
    this.TableLayoutPanel1.TabIndex = 58;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(775, 584);
    this.Controls.Add((Control) this.TableLayoutPanel1);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (FormAdminRaterForms);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Admin Rater Forms";
    ((ISupportInitialize) this.cboForms).EndInit();
    ((ISupportInitialize) this.bindingSetups).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboRaters).EndInit();
    ((ISupportInitialize) this.cboCompanyLineConditions).EndInit();
    ((ISupportInitialize) this.cboConditions).EndInit();
    ((ISupportInitialize) this.bindingConditions).EndInit();
    ((ISupportInitialize) this.bindingRaterConditions).EndInit();
    ((ISupportInitialize) this.cboOperator).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.pnlMainForm.ResumeLayout(false);
    this.pnlMainForm.PerformLayout();
    this.nudGridSize.EndInit();
    ((ISupportInitialize) this.gridSavedSetups).EndInit();
    this.pnlConditions.ResumeLayout(false);
    this.pnlConditions.PerformLayout();
    ((ISupportInitialize) this.gridConditions).EndInit();
    ((ISupportInitialize) this.grpConditionSetup).EndInit();
    ((Control) this.grpConditionSetup).ResumeLayout(false);
    ((Control) this.grpConditionSetup).PerformLayout();
    ((ISupportInitialize) this.txtAmount).EndInit();
    this.TableLayoutPanel1.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("cn")]
  private virtual SqlConnection cn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daSetups")]
  private virtual SqlDataAdapter daSetups { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daFormConditions")]
  private virtual SqlDataAdapter daFormConditions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  private virtual dsAdminRaterForms ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  private virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual NumericUpDown nudGridSize
  {
    get => this._nudGridSize;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.nudGridSize_ValueChanged);
      NumericUpDown nudGridSize1 = this._nudGridSize;
      if (nudGridSize1 != null)
        nudGridSize1.ValueChanged -= eventHandler;
      this._nudGridSize = value;
      NumericUpDown nudGridSize2 = this._nudGridSize;
      if (nudGridSize2 == null)
        return;
      nudGridSize2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkDeleteAllCond
  {
    get => this._lnkDeleteAllCond;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lnkDeleteAllCond_Click);
      LinkLabel lnkDeleteAllCond1 = this._lnkDeleteAllCond;
      if (lnkDeleteAllCond1 != null)
        lnkDeleteAllCond1.Click -= eventHandler;
      this._lnkDeleteAllCond = value;
      LinkLabel lnkDeleteAllCond2 = this._lnkDeleteAllCond;
      if (lnkDeleteAllCond2 == null)
        return;
      lnkDeleteAllCond2.Click += eventHandler;
    }
  }

  private virtual UltraFormattedTextEditor lnkDeleteCondition
  {
    get => this._lnkDeleteCondition;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkClickedEventHandler clickedEventHandler = new LinkClickedEventHandler(this.DeleteConditionLink);
      UltraFormattedTextEditor lnkDeleteCondition1 = this._lnkDeleteCondition;
      if (lnkDeleteCondition1 != null)
        ((UltraFormattedTextEditorBase) lnkDeleteCondition1).LinkClicked -= clickedEventHandler;
      this._lnkDeleteCondition = value;
      UltraFormattedTextEditor lnkDeleteCondition2 = this._lnkDeleteCondition;
      if (lnkDeleteCondition2 == null)
        return;
      ((UltraFormattedTextEditorBase) lnkDeleteCondition2).LinkClicked += clickedEventHandler;
    }
  }

  private virtual BindingSource bindingSetups
  {
    get => this._bindingSetups;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.bindingSetups_CurrentChanged);
      BindingSource bindingSetups1 = this._bindingSetups;
      if (bindingSetups1 != null)
        bindingSetups1.CurrentChanged -= eventHandler;
      this._bindingSetups = value;
      BindingSource bindingSetups2 = this._bindingSetups;
      if (bindingSetups2 == null)
        return;
      bindingSetups2.CurrentChanged += eventHandler;
    }
  }

  private virtual BindingSource bindingConditions
  {
    get => this._bindingConditions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.bindingConditions_CurrentChanged);
      BindingSource bindingConditions1 = this._bindingConditions;
      if (bindingConditions1 != null)
        bindingConditions1.CurrentChanged -= eventHandler;
      this._bindingConditions = value;
      BindingSource bindingConditions2 = this._bindingConditions;
      if (bindingConditions2 == null)
        return;
      bindingConditions2.CurrentChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("bindingRaterConditions")]
  private virtual BindingSource bindingRaterConditions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlConditions")]
  protected virtual Panel pnlConditions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cboForms
  {
    get => this._cboForms;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.comboBoxesAfterClose);
      EventHandler eventHandler2 = new EventHandler(this.cboForms_ValueChanged);
      MGASimpleComboBox cboForms1 = this._cboForms;
      if (cboForms1 != null)
      {
        cboForms1.AfterCloseUp -= eventHandler1;
        cboForms1.ValueChanged -= eventHandler2;
      }
      this._cboForms = value;
      MGASimpleComboBox cboForms2 = this._cboForms;
      if (cboForms2 == null)
        return;
      cboForms2.AfterCloseUp += eventHandler1;
      cboForms2.ValueChanged += eventHandler2;
    }
  }

  private virtual MGASimpleComboBox cboRaters
  {
    get => this._cboRaters;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.cboRaters_ValueChanged);
      EventHandler eventHandler2 = new EventHandler(this.comboBoxesAfterClose);
      MGASimpleComboBox cboRaters1 = this._cboRaters;
      if (cboRaters1 != null)
      {
        cboRaters1.ValueChanged -= eventHandler1;
        cboRaters1.AfterCloseUp -= eventHandler2;
      }
      this._cboRaters = value;
      MGASimpleComboBox cboRaters2 = this._cboRaters;
      if (cboRaters2 == null)
        return;
      cboRaters2.ValueChanged += eventHandler1;
      cboRaters2.AfterCloseUp += eventHandler2;
    }
  }

  private virtual UltraGrid gridSavedSetups
  {
    get => this._gridSavedSetups;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gridSavedSetups_AfterRowActivate);
      UltraGrid gridSavedSetups1 = this._gridSavedSetups;
      if (gridSavedSetups1 != null)
        gridSavedSetups1.AfterRowActivate -= eventHandler;
      this._gridSavedSetups = value;
      UltraGrid gridSavedSetups2 = this._gridSavedSetups;
      if (gridSavedSetups2 == null)
        return;
      gridSavedSetups2.AfterRowActivate += eventHandler;
    }
  }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.dbSave_ClickingSave);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingCancel -= cancelEventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.ClickingEdit -= cancelEventHandler3;
        dbSave1.ClickingNew -= cancelEventHandler4;
        dbSave1.ClickingSave -= cancelEventHandler5;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingCancel += cancelEventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.ClickingEdit += cancelEventHandler3;
      dbSave2.ClickingNew += cancelEventHandler4;
      dbSave2.ClickingSave += cancelEventHandler5;
    }
  }

  [field: AccessedThroughProperty("cboConditions")]
  protected virtual MGASimpleComboBox cboConditions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASimpleComboBox cboOperator
  {
    get => this._cboOperator;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboOperator_BeforeDropDown);
      MGASimpleComboBox cboOperator1 = this._cboOperator;
      if (cboOperator1 != null)
        cboOperator1.BeforeDropDown -= cancelEventHandler;
      this._cboOperator = value;
      MGASimpleComboBox cboOperator2 = this._cboOperator;
      if (cboOperator2 == null)
        return;
      cboOperator2.BeforeDropDown += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtAmount")]
  protected virtual MGATextBox txtAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid gridConditions
  {
    get => this._gridConditions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.gridConditions_InitializeRow);
      RowEventHandler rowEventHandler = new RowEventHandler(this.gridConditions_AfterRowInsert);
      EventHandler eventHandler = new EventHandler(this.gridConditions_AfterRowActivate);
      UltraGrid gridConditions1 = this._gridConditions;
      if (gridConditions1 != null)
      {
        gridConditions1.InitializeRow -= initializeRowEventHandler;
        gridConditions1.AfterRowInsert -= rowEventHandler;
        gridConditions1.AfterRowActivate -= eventHandler;
      }
      this._gridConditions = value;
      UltraGrid gridConditions2 = this._gridConditions;
      if (gridConditions2 == null)
        return;
      gridConditions2.InitializeRow += initializeRowEventHandler;
      gridConditions2.AfterRowInsert += rowEventHandler;
      gridConditions2.AfterRowActivate += eventHandler;
    }
  }

  private virtual MGASimpleComboBox cboCompanyLineConditions
  {
    get => this._cboCompanyLineConditions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.comboBoxesAfterClose);
      EventHandler eventHandler2 = new EventHandler(this.cboCompanyLineConditions_ValueChanged);
      MGASimpleComboBox companyLineConditions1 = this._cboCompanyLineConditions;
      if (companyLineConditions1 != null)
      {
        companyLineConditions1.AfterCloseUp -= eventHandler1;
        companyLineConditions1.ValueChanged -= eventHandler2;
      }
      this._cboCompanyLineConditions = value;
      MGASimpleComboBox companyLineConditions2 = this._cboCompanyLineConditions;
      if (companyLineConditions2 == null)
        return;
      companyLineConditions2.AfterCloseUp += eventHandler1;
      companyLineConditions2.ValueChanged += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("TableLayoutPanel1")]
  private virtual TableLayoutPanel TableLayoutPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlMainForm")]
  protected virtual Panel pnlMainForm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpConditionSetup")]
  public virtual UltraGroupBox grpConditionSetup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFormVisibility")]
  internal virtual CheckBox chkFormVisibility { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkSingleTransaction")]
  internal virtual CheckBox chkSingleTransaction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected CompanyLine CompanyLine => this._companyLine;

  protected dsAdminRaterForms dsRaterForms => this.ds;

  public FormAdminRaterForms()
  {
    this.Load += new EventHandler(this.FormAdminRaterForms_Load);
    this._companyLine = (CompanyLine) null;
    this._nupValue = 0M;
    this.InitializeComponent();
  }

  public FormAdminRaterForms(Guid companyLineGuid)
    : this()
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._companyLine = new CompanyLine(companyLineGuid);
  }

  private void FormAdminRaterForms_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      try
      {
        this.Text = $"{this.Text} - {this._companyLine.CompanyLineState}".TrimEnd(' ', '-');
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.lnkDeleteAllCond.Hide();
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[5]
      {
        this.ds.tblCompanyRaters.TableName,
        this.ds.tblPolicyForms.TableName,
        this.ds.tblConditions.TableName,
        this.ds.tblRaterFormSetups.TableName,
        this.ds.tblRaterFormAutomation.TableName
      }, "dbo.spAdminRaterFormsLoad", new object[2]
      {
        (object) "@companyLineID",
        (object) this.CompanyLine.CompanyLineID
      });
      this.bindingSetups.Filter = "RaterID = -1";
      dsAdminRaterForms.OperatorsDataTable operators = this.ds.Operators;
      operators.AddOperatorsRow("LT", "Less Than");
      operators.AddOperatorsRow("GT", "Greater Than");
      operators.AddOperatorsRow("EQ", "Equal To");
      operators.AddOperatorsRow("NE", "Not Equal To");
      operators.AddOperatorsRow("TR", "True");
      operators.AddOperatorsRow("FA", "False");
      operators.AddOperatorsRow("CT", "Contains");
      operators.AddOperatorsRow("NC", "Not Contains");
      RowEnumerator enumerator = ((UltraGridBase) this.cboForms).Rows.GetEnumerator();
      while (enumerator.MoveNext())
      {
        UltraGridRow current = enumerator.Current;
        if (current.Cells["Disabled"].Value != DBNull.Value && Conversions.ToBoolean(current.Cells["Disabled"].Value))
        {
          current.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
          current.Appearance.ForeColor = Color.Red;
        }
      }
      this.ClientLoadData();
      this.chkFormVisibility.Visible = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("CompanyLine.RaterConditionals.VisibilityFilters", false);
      this.chkSingleTransaction.Visible = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("CompanyLine.RaterConditionals.SingleTransactionSetups", false);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this.SetDBUIState();
    this.EnableConditions(false);
  }

  protected virtual void ClientLoadData()
  {
  }

  private void EnableConditions(bool enable)
  {
    try
    {
      foreach (Control control in ((Control) this.grpConditionSetup).Controls)
      {
        if (!(control is MGASystems.Tools.DBSaveUI.DBSaveUI))
          control.Enabled = enable;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((Control) this.cboRaters).Enabled = !enable;
    ((Control) this.gridSavedSetups).Enabled = !enable;
    ((SpecialBoxBase) ((UltraGridBase) this.gridConditions).DisplayLayout.AddNewBox).Hidden = !enable;
    ((Control) this.cboForms).Enabled = enable;
    ((Control) this.cboCompanyLineConditions).Enabled = enable;
    ((UltraGridBase) this.gridConditions).DisplayLayout.Bands[0].Columns["Delete"].CellActivation = enable ? (Activation) 1 : (Activation) 2;
  }

  private void SetDBUIState()
  {
    if (this.bindingSetups.Count > 0)
    {
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
      this.lnkDeleteAllCond.Visible = true;
    }
    else
    {
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
      this.lnkDeleteAllCond.Hide();
    }
  }

  private DataTable OtherSetupsToDelete(int setupID)
  {
    return new RaterFormSetup(setupID).SimilarCompanyLineSetupsDatatable;
  }

  private void DeleteAllConditions()
  {
    string str1 = $"User:{CurrentUser.Instance.LastName}, {CurrentUser.Instance.FirstName}. ";
    if (this.bindingSetups.Count <= 0)
      return;
    List<int> intList = new List<int>();
    StringBuilder stringBuilder = new StringBuilder();
    try
    {
      foreach (DataRowView bindingSetup in this.bindingSetups)
      {
        DataRow row = bindingSetup.Row;
        intList.Add(row.Field<int>("SetupID"));
        stringBuilder.Append($"SetupID: {RuntimeHelpers.GetObjectValue(row["SetupID"])}, RaterID: {RuntimeHelpers.GetObjectValue(row["RaterID"])}, ");
        if (row.IsNull("PolicyFormID"))
          stringBuilder.Append($"CompanyLineConditionID: {RuntimeHelpers.GetObjectValue(row["CompanyLineConditionID"])}. ");
        else
          stringBuilder.Append($"PolicyFormID: {RuntimeHelpers.GetObjectValue(row["policyFormID"])}. ");
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    string str2 = str1 + stringBuilder.ToString().Trim();
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DefaultDatabase.ExecuteNonQuery("dbo.DeleteAllFormSetupConditions", new object[4]
      {
        (object) "@CompanyLineID",
        (object) this._companyLine.CompanyLineID,
        (object) "@raterID",
        (object) Conversions.ToInteger(this.cboRaters.Value)
      });
      CurrentUser.Instance.LogAction($"FCW screen: User deleted ALL form condition setups for rater {this.cboRaters.Text}. " + str2, this._companyLine.CompanyLineGuid);
      try
      {
        foreach (int SetupID in intList)
          this.ds.tblRaterFormSetups.FindBySetupID(SetupID)?.Delete();
      }
      finally
      {
        List<int>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.ds.AcceptChanges();
      ((UltraControlBase) this.gridSavedSetups).Update();
      ((UltraControlBase) this.gridConditions).Update();
      this.EnableConditions(false);
      this.SetDBUIState();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void DeleteConditionLink(object sender, LinkClickedEventArgs e)
  {
    if (this.dbSave.UIState != UIState.Editing || !(e.Context is UltraGridCell context) || MessageBox.Show("Are you sure you want to delete this condition?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    context.Row.Delete();
    ((UltraGridBase) this.gridConditions).UpdateData();
  }

  private void SaveData()
  {
    int num1 = int.MinValue;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      dsAdminRaterForms.tblRaterFormSetupsRow dr1 = (dsAdminRaterForms.tblRaterFormSetupsRow) null;
      if (((UltraGridBase) this.gridSavedSetups).ActiveRow != null)
      {
        dr1 = this.ResolveRowFromGrid<dsAdminRaterForms.tblRaterFormSetupsRow>(((UltraGridBase) this.gridSavedSetups).ActiveRow);
        if (dr1 == null)
        {
          num1 = Conversions.ToInteger(((UltraGridBase) this.gridSavedSetups).ActiveRow.Cells["SetupID"].Value);
          dr1 = this.ds.tblRaterFormSetups.FindBySetupID(num1);
        }
        else
          num1 = dr1.SetupID;
      }
      if (dr1.RowState == DataRowState.Added)
      {
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSetups, (DataTable) this.ds.tblRaterFormSetups);
        num1 = dr1.SetupID;
        string str = dr1.IsPolicyFormIDNull() ? " Condition ID: " + Conversions.ToString(dr1.CompanyLineConditionID) : " Policy Form ID: " + Conversions.ToString(dr1.PolicyFormID);
        CurrentUser.Instance.LogAction("FCW screen: User added a new form condition setup. " + $"User: {CurrentUser.Instance.LastName} ,{CurrentUser.Instance.FirstName} company Line ID: {Conversions.ToString(dr1.CompanyLineID)} raterid: {Conversions.ToString(dr1.RaterID)}{str}. ", num1);
      }
      else
      {
        string str1 = this.GetdataRowDifferences((DataTable) this.ds.tblRaterFormSetups, (DataRow) dr1);
        string str2 = dr1.IsPolicyFormIDNull() ? " Condition ID: " + Conversions.ToString(dr1.CompanyLineConditionID) : " Policy Form ID: " + Conversions.ToString(dr1.PolicyFormID);
        DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSetups, (DataTable) this.ds.tblRaterFormSetups);
        CurrentUser.Instance.LogAction($"FCW screen: User modified existing form condition setup. {$"User: {CurrentUser.Instance.LastName} ,{CurrentUser.Instance.FirstName} raterid: {Conversions.ToString(dr1.RaterID)} setup ID: {Conversions.ToString(dr1.SetupID)}{str2}. "}The following fields were changed. {str1}", num1);
      }
      if (!dr1.IsPolicyFormIDNull())
      {
        if (DefaultDatabase.ExecuteScalar<bool?>(CommandType.Text, "SELECT CheckedByDefault FROM dbo.tblCompanyFormsConditionsWarranties WHERE CompanyLineID = @clID AND PolicyFormID = @formID", new object[4]
        {
          (object) "@clID",
          (object) this._companyLine.CompanyLineID,
          (object) "@formID",
          (object) dr1.PolicyFormID
        }) ?? false)
        {
          int num2 = (int) MessageBox.Show("The current form is set to \"Checked by Default\", which could cause unexpected behavior when evaluating these conditions and applying/removing the form.", "Conditional Form Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      List<string> values = new List<string>();
      dsAdminRaterForms.tblRaterFormAutomationRow[] formAutomationRowArray = dr1.GettblRaterFormAutomationRows();
      int index = 0;
      while (index < formAutomationRowArray.Length)
      {
        dsAdminRaterForms.tblRaterFormAutomationRow dr2 = formAutomationRowArray[index];
        if (dr2.RowState != DataRowState.Unchanged)
        {
          string str = dr2.RowState == DataRowState.Added ? "" : $" ({(dr2.RowState == DataRowState.Deleted ? (object) dr2["ConditionID", DataRowVersion.Original].ToString() : (object) dr2.ConditionID.ToString())})";
          values.Add($"Condition{str}: {this.GetdataRowDifferences((DataTable) this.ds.tblRaterFormAutomation, (DataRow) dr2)}");
        }
        checked { ++index; }
      }
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daFormConditions, (DataTable) this.ds.tblRaterFormAutomation);
      CurrentUser.Instance.LogAction($"FCW screen: User modified exisiting form conditions for SetupID {num1}. The following fields were changed: {string.Join("\r\n", (IEnumerable<string>) values)}", num1);
      this.ClientSaveData();
      this.ds.AcceptChanges();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void ClientSaveData()
  {
  }

  protected string GetdataRowDifferences(DataTable dt, DataRow dr)
  {
    string str1 = "";
    string str2;
    if (dr.RowState == DataRowState.Added)
      str2 = "A new record was ADDED. ";
    else if (dr.RowState == DataRowState.Deleted)
    {
      str2 = "A record was DELETED. ";
    }
    else
    {
      if (dr.RowState == DataRowState.Modified)
      {
        StringBuilder stringBuilder = new StringBuilder();
        try
        {
          foreach (DataColumn column in (InternalDataCollectionBase) dt.Columns)
          {
            string str3 = dr[column.ColumnName, DataRowVersion.Original].ToString();
            string str4 = dr[column.ColumnName, DataRowVersion.Current].ToString();
            if ((object) str3 == (object) DBNull.Value || str3 == null)
              str3 = "<Empty>";
            if ((object) str4 == (object) DBNull.Value || str4 == null)
              str4 = "<Empty>";
            if (!str3.ToString().Equals(str4.ToString()))
              stringBuilder.Append($"{column.ColumnName} was changed FROM {str3.ToString()} TO {str4.ToString()}. ");
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        str1 = stringBuilder.ToString().Trim();
      }
      str2 = str1;
    }
    return str2;
  }

  private bool IsOfEqualType(string condType, string amountValue, ref string errStr)
  {
    string Left = condType;
    bool flag;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "System.Boolean", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "System.Decimal", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "System.String", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "System.DateTime", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "System.Char", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "System.Int32", false) == 0)
              {
                int result = int.MinValue;
                errStr = "Please enter a number";
                flag = int.TryParse(amountValue, out result);
              }
              else
                flag = false;
            }
            else
            {
              char result = char.MinValue;
              errStr = "Please enter a single character";
              flag = char.TryParse(amountValue, out result);
            }
          }
          else
          {
            DateTime result = DateTime.MinValue;
            errStr = "Please enter a date";
            flag = DateTime.TryParse(amountValue, out result);
          }
        }
        else
          flag = true;
      }
      else
      {
        Decimal result = Decimal.MinValue;
        errStr = "Please enter a decimal";
        flag = Decimal.TryParse(amountValue, out result);
      }
    }
    else
    {
      bool result = true;
      errStr = "Please enter true or false";
      flag = bool.TryParse(amountValue, out result);
    }
    return flag;
  }

  private bool ValidForm()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboForms, string.Empty);
    this.err.SetError((Control) this.cboConditions, string.Empty);
    this.err.SetError((Control) this.cboRaters, string.Empty);
    this.err.SetError((Control) this.cboOperator, string.Empty);
    this.err.SetError((Control) this.txtAmount, string.Empty);
    this.err.SetError((Control) this.cboCompanyLineConditions, string.Empty);
    this.ClearDatasetErrors((DataSet) this.ds);
    if (this.cboForms.Value == null && this.cboCompanyLineConditions.Value == null)
    {
      this.err.SetError((Control) this.cboForms, "Please select a policy form or a condition");
      this.err.SetError((Control) this.cboCompanyLineConditions, "Please select a policy form or a condition");
      flag = false;
    }
    if (this.cboForms.Value != null && this.cboCompanyLineConditions.Value != null)
    {
      this.err.SetError((Control) this.cboForms, "Cannot select both a policy form and a condition");
      this.err.SetError((Control) this.cboCompanyLineConditions, "Cannot select both a policy form and a condition");
      flag = false;
    }
    if (this.cboForms.Value != null && this.cboForms.Text.StartsWith("[Not Applicable: Form Deleted]"))
    {
      this.err.SetError((Control) this.cboForms, "Form is no longer associated with this company line");
      flag = false;
    }
    if (flag && this.bindingConditions.Count == 0)
    {
      flag = false;
      int num = (int) MessageBox.Show("Must specify at least 1 condition for the setup. Either add conditions, or delete the setup.", "Setup Missing Conditions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    if (flag)
    {
      List<(int, bool)> valueTupleList = new List<(int, bool)>();
      try
      {
        foreach (DataRowView bindingCondition in this.bindingConditions)
        {
          if (bindingCondition.Row is dsAdminRaterForms.tblRaterFormAutomationRow row && row.RowState != DataRowState.Deleted)
          {
            if (row.IsConditionalIDNull())
            {
              row.RowError = "Invalid Condition";
              row.SetColumnError("ConditionalID", "Must specify a valid conditional for each setup condition!");
              flag = false;
            }
            else
            {
              dsAdminRaterForms.ConditionsRow raterIdConditionalId = this.ds.Conditions.FindByRaterIDConditionalID(row.RaterID, row.ConditionalID);
              if (raterIdConditionalId != null && !row.IsAmountNull() && row.Amount.Length > 0 && !raterIdConditionalId.IsConditionalTypeNull() && !raterIdConditionalId.ConditionalType.Equals("NULL"))
              {
                string empty = string.Empty;
                if (!this.IsOfEqualType(raterIdConditionalId.ConditionalType, row.Amount, ref empty))
                {
                  row.RowError = "Invalid Condition";
                  row.SetColumnError("Amount", empty);
                  flag = false;
                  continue;
                }
              }
              if (row.ConditionID > 0 && !valueTupleList.Contains((row.ConditionalID, row.FormVisibility)))
              {
                DataRow[] dataRowArray1 = this.ds.tblRaterFormAutomation.Select($"ConditionalID = {row.ConditionalID} AND SetupID = {row.SetupID} AND FormVisibility = {Convert.ToInt32(row.FormVisibility)}");
                if (dataRowArray1.Length > 1)
                {
                  valueTupleList.Add((row.ConditionalID, row.FormVisibility));
                  flag = false;
                  DataRow[] dataRowArray2 = dataRowArray1;
                  int index = 0;
                  while (index < dataRowArray2.Length)
                  {
                    DataRow dataRow = dataRowArray2[index];
                    dataRow.RowError = "Condition Already Applied";
                    dataRow.SetColumnError("ConditionalID", "Conditional applied multiple times.");
                    checked { ++index; }
                  }
                }
              }
            }
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
    if (flag)
    {
      List<int> intList = new List<int>();
      try
      {
        foreach (DataRowView bindingSetup in this.bindingSetups)
        {
          if (bindingSetup?.Row is dsAdminRaterForms.tblRaterFormSetupsRow row && !row.IsPolicyFormIDNull())
          {
            if (intList.Contains(row.PolicyFormID))
            {
              int num = (int) MessageBox.Show("The following policy form exists in duplicate.\n\n" + this.ds.tblPolicyForms.FindByFormID(row.PolicyFormID).FormName, "Form In Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              flag = false;
              break;
            }
            intList.Add(row.PolicyFormID);
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
    if (flag && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboForms.Value)) && this.ds.tblPolicyForms.FindByFormID(Conversions.ToInteger(this.cboForms.Value)).Disabled)
    {
      this.err.SetError((Control) this.cboForms, "The selected form is disabled.");
      flag = false;
    }
    return flag;
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.err.SetError((Control) this.cboForms, string.Empty);
    this.err.SetError((Control) this.cboConditions, string.Empty);
    this.err.SetError((Control) this.cboRaters, string.Empty);
    this.err.SetError((Control) this.cboOperator, string.Empty);
    this.err.SetError((Control) this.txtAmount, string.Empty);
    this.err.SetError((Control) this.cboCompanyLineConditions, string.Empty);
    this.ClearDatasetErrors((DataSet) this.ds);
    this.ds.tblRaterFormAutomation.RejectChanges();
    this.ds.tblRaterFormSetups.RejectChanges();
    ((UltraControlBase) this.gridSavedSetups).Update();
    ((UltraControlBase) this.gridConditions).Update();
    this.gridSavedSetups_AfterRowActivate((object) this, EventArgs.Empty);
    this.EnableConditions(false);
    this.SetDBUIState();
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.gridSavedSetups).ActiveRow == null)
    {
      e.Cancel = true;
    }
    else
    {
      dsAdminRaterForms.tblRaterFormSetupsRow raterFormSetupsRow = this.ResolveRowFromGrid<dsAdminRaterForms.tblRaterFormSetupsRow>(((UltraGridBase) this.gridSavedSetups).ActiveRow);
      if (raterFormSetupsRow == null)
        return;
      int setupId = raterFormSetupsRow.SetupID;
      if (MessageBox.Show($"Delete would remove all conditions for this setup. {"\n"}{"\n"}Continue with this delete operation?", "Continue With Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        try
        {
          this.Cursor = MgaCursors.WaitCursor;
          CurrentUser.Instance.LogAction($"FCW screen: User deleted form condition setup. {$"User: {CurrentUser.Instance.DisplayNameLastFirst}; setup ID: {raterFormSetupsRow.SetupID}; rater ID: {raterFormSetupsRow.RaterID}"}");
          DataTable delete = this.OtherSetupsToDelete(setupId);
          string str1 = $"User: {CurrentUser.Instance.DisplayNameLastFirst}; SetupID: {setupId}";
          dsAdminRaterForms.tblRaterFormAutomationRow[] source1 = raterFormSetupsRow.GettblRaterFormAutomationRows();
          System.Func<dsAdminRaterForms.tblRaterFormAutomationRow, int> selector1;
          // ISSUE: reference to a compiler-generated field
          if (FormAdminRaterForms._Closure\u0024__.\u0024I136\u002D0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            selector1 = FormAdminRaterForms._Closure\u0024__.\u0024I136\u002D0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            FormAdminRaterForms._Closure\u0024__.\u0024I136\u002D0 = selector1 = (System.Func<dsAdminRaterForms.tblRaterFormAutomationRow, int>) ([SpecialName] (tr) => tr.ConditionID);
          }
          string str2 = string.Join<int>(", ", ((IEnumerable<dsAdminRaterForms.tblRaterFormAutomationRow>) source1).Select<dsAdminRaterForms.tblRaterFormAutomationRow, int>(selector1));
          raterFormSetupsRow.Delete();
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daSetups, (DataTable) this.ds.tblRaterFormSetups);
          CurrentUser.Instance.LogAction($"FCW screen: User deleted form condition setup(s). {str1}. The conditional IDs deleted are:  {str2}", setupId);
          try
          {
            this.Cursor = MgaCursors.Default;
            if (DialogResult.Yes == MessageBox.Show("You have deleted a setup.\n\nDelete similar setups on other company/lines with the same line and state?", "Delete Other Setups?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
              EnumerableRowCollection<DataRow> source2 = delete.AsEnumerable();
              System.Func<DataRow, string> selector2;
              // ISSUE: reference to a compiler-generated field
              if (FormAdminRaterForms._Closure\u0024__.\u0024I136\u002D1 != null)
              {
                // ISSUE: reference to a compiler-generated field
                selector2 = FormAdminRaterForms._Closure\u0024__.\u0024I136\u002D1;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                FormAdminRaterForms._Closure\u0024__.\u0024I136\u002D1 = selector2 = (System.Func<DataRow, string>) ([SpecialName] (dr) => dr["SetupID"].ToString());
              }
              string str3 = string.Join(",", (IEnumerable<string>) source2.Select<DataRow, string>(selector2));
              DefaultDatabase.ExecuteNonQuery("spDeleteCompanyLinesRaterConditionSetup", new object[4]
              {
                (object) "@Current_CompanyLineGuid",
                (object) this._companyLine.CompanyLineGuid,
                (object) "@SetupIDString",
                (object) str3
              });
              CurrentUser.Instance.LogAction($"FCW screen: User selected option to delete form conditions setups for other company/lines with the same line and state. It was related to setup id {Conversions.ToString(setupId)}: It included the following setup ids for the same line and state:{str3}. ", this._companyLine.CompanyLineGuid);
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ErrorHandler.SilentHandleError(ex);
            ProjectData.ClearProjectError();
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          e.Cancel = true;
          ProjectData.ClearProjectError();
          return;
        }
        finally
        {
          this.Cursor = MgaCursors.Default;
        }
      }
      this.ds.AcceptChanges();
      ((UltraControlBase) this.gridSavedSetups).Update();
      this.SetDBUIState();
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.gridSavedSetups).ActiveRow == null)
      e.Cancel = true;
    else
      this.EnableConditions(true);
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    dsAdminRaterForms.tblRaterFormSetupsRow row1 = this.ds.tblRaterFormSetups.NewtblRaterFormSetupsRow();
    row1.CompanyLineID = this._companyLine.CompanyLineID;
    row1.RaterID = Conversions.ToInteger(this.cboRaters.Value);
    this.ds.tblRaterFormSetups.AddtblRaterFormSetupsRow(row1);
    this.bindingSetups.MoveLast();
    dsAdminRaterForms.tblRaterFormAutomationRow row2 = this.ds.tblRaterFormAutomation.NewtblRaterFormAutomationRow();
    row2.SetupID = row1.SetupID;
    row2.RaterID = row1.RaterID;
    row2.tblRaterFormSetupsRow = row1;
    this.ds.tblRaterFormAutomation.AddtblRaterFormAutomationRow(row2);
    this.bindingConditions.MoveLast();
    this.EnableConditions(true);
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    this.bindingSetups.EndEdit();
    this.bindingConditions.EndEdit();
    if (this.ValidForm())
    {
      this.SaveData();
      this.EnableConditions(false);
      ((UltraControlBase) this.gridSavedSetups).Update();
      ((UltraControlBase) this.gridConditions).Update();
    }
    else
      e.Cancel = true;
  }

  private void cboRaters_ValueChanged(object sender, EventArgs e)
  {
    int raterID = -1;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboRaters.Value)))
    {
      raterID = Conversions.ToInteger(this.cboRaters.Value);
      this.GetConditions(raterID);
    }
    this.FilterData(raterID);
    this.SetDBUIState();
    foreach (UltraGridRow row in ((UltraGridBase) this.gridSavedSetups).Rows)
    {
      if (row.Cells["Disabled"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["Disabled"].Value))
      {
        row.Cells["FormNumber"].Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
        row.Cells["FormName"].Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
        row.Appearance.ForeColor = Color.Red;
      }
    }
  }

  private void FilterData(int raterID)
  {
    this.bindingRaterConditions.Filter = $"RaterID = {raterID}";
    ((UltraControlBase) this.cboConditions).Update();
    this.bindingSetups.Filter = $"RaterID = {raterID}";
    ((UltraControlBase) this.gridSavedSetups).Update();
    ((UltraControlBase) this.gridConditions).Update();
  }

  private void GetConditions(int raterID)
  {
    if (this.ds.Conditions.Select($"RaterID = {raterID}").Length > 0)
      return;
    List<RaterConditionalElement> conditionalElementList = RaterFactory.GetRater(raterID).RaterConditionalElements(this._companyLine.LineCode);
    if (conditionalElementList != null)
    {
      try
      {
        foreach (RaterConditionalElement conditionalElement in conditionalElementList)
        {
          int conditionalId = conditionalElement.ConditionalID;
          string condition = conditionalElement.Condition;
          string ConditionalType = string.Empty;
          if (conditionalElement.ConditionType != null)
            ConditionalType = conditionalElement.ConditionType;
          this.ds.Conditions.AddConditionsRow(condition, raterID, conditionalId, ConditionalType);
        }
      }
      finally
      {
        List<RaterConditionalElement>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    else
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ConditionalID, Condition, ConditionalType FROM tblRaterConditionals WHERE RaterID=@RaterID ORDER BY Condition", new object[2]
      {
        (object) "@RaterID",
        (object) raterID
      });
      try
      {
        foreach (DataRow row in dataTable.Rows)
        {
          int ConditionalID = (int) row[0];
          string Condition = row[1].ToString();
          string empty = string.Empty;
          if (!row.IsNull("ConditionalType"))
            empty = row["ConditionalType"].ToString();
          this.ds.Conditions.AddConditionsRow(Condition, raterID, ConditionalID, empty);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this.ds.Conditions.AcceptChanges();
    ((UltraControlBase) this.cboConditions).Update();
  }

  private void gridSavedSetups_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridSavedSetups).ActiveRow == null || this.ResolveRowFromGrid<dsAdminRaterForms.tblRaterFormSetupsRow>(((UltraGridBase) this.gridSavedSetups).ActiveRow) != null)
      return;
    this.ds.tblRaterFormSetups.FindBySetupID(Conversions.ToInteger(((UltraGridBase) this.gridSavedSetups).ActiveRow.Cells["SetupID"].Value));
  }

  private void cboOperator_BeforeDropDown(object sender, CancelEventArgs e)
  {
    if (this.cboConditions.Text.Equals(string.Empty))
      return;
    dsAdminRaterForms.ConditionsRow conditionsRow = (dsAdminRaterForms.ConditionsRow) this.ds.Conditions.Select("conditionalID=" + Conversions.ToString(Conversions.ToInteger(this.cboConditions.Value)))[0];
    if (conditionsRow == null || conditionsRow.IsConditionalTypeNull())
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.cboOperator).Rows)
    {
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["Operator"].Value)))
      {
        string str = Conversions.ToString(row.Cells["Operator"].Value);
        if (conditionsRow.ConditionalType.Equals("System.Boolean"))
          row.Hidden = !str.Equals("TR") && !str.Equals("FA");
        else if (conditionsRow.ConditionalType.Equals("System.Decimal") || conditionsRow.ConditionalType.Equals("System.Int32"))
          row.Hidden = !str.Equals("LT") && !str.Equals("GT") && !str.Equals("EQ") && !str.Equals("NE");
        else if (conditionsRow.ConditionalType.Equals("System.String"))
          row.Hidden = !str.Equals("EQ") && !str.Equals("NE") && !str.Equals("CT") && !str.Equals("NC");
      }
    }
  }

  private void lnkClearForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.cboForms.Value = (object) null;
  }

  private void lnkClearCompLineCondition_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.cboCompanyLineConditions.Value = (object) null;
  }

  private void nudGridSize_ValueChanged(object sender, EventArgs e)
  {
    Size size1 = this.pnlMainForm.Size;
    Size size2 = this.Size;
    Decimal d1 = Decimal.Subtract(this.nudGridSize.Value, this._nupValue);
    this.pnlMainForm.Size = new Size(size1.Width, size1.Height + Convert.ToInt32(Decimal.Multiply(d1, 25M)));
    this.Size = new Size(size2.Width, size2.Height + Convert.ToInt32(Decimal.Multiply(d1, 20M)));
    this._nupValue = this.nudGridSize.Value;
  }

  private void lnkDeleteAllCond_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("This will delete ALL the forms and their setups for the company line and rater.  Are you sure you want to delete ALL the policy forms and ALL their condition setups?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    this.DeleteAllConditions();
    this.SetDBUIState();
  }

  private void gridConditions_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (e.ReInitialize || !((KeyedSubObjectsCollectionBase) e.Row.Cells).Exists("Delete"))
      return;
    e.Row.Cells["Delete"].Value = (object) "Delete";
  }

  private void gridConditions_AfterRowInsert(object sender, RowEventArgs e)
  {
    if (e.Row.ListObject is DataRowView listObject && listObject.Row is dsAdminRaterForms.tblRaterFormAutomationRow row1)
    {
      dsAdminRaterForms.tblRaterFormSetupsRow row = (this.bindingSetups.Current as DataRowView).Row as dsAdminRaterForms.tblRaterFormSetupsRow;
      row1.SetupID = row.SetupID;
      row1.RaterID = row.RaterID;
      row1.tblRaterFormSetupsRow = row;
      ((UltraGridBase) this.gridConditions).ActiveRow = e.Row;
    }
    else
    {
      e.Row.Delete();
      ((UltraGridBase) this.gridConditions).UpdateData();
    }
  }

  private void gridConditions_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridConditions).ActiveRow == null)
      this.bindingConditions.Position = -1;
    else
      this.bindingConditions.Position = ((UltraGridBase) this.gridConditions).ActiveRow.Index;
  }

  private T ResolveRowFromGrid<T>(UltraGridRow gridRow) where T : DataRow
  {
    return (gridRow?.ListObject is DataRowView listObject ? listObject.Row : (DataRow) null) as T;
  }

  private void ClearDatasetErrors(DataSet dSet)
  {
    try
    {
      foreach (DataTable table in (InternalDataCollectionBase) dSet.Tables)
      {
        if (table.HasErrors)
        {
          try
          {
            foreach (DataRow row in table.Rows)
              row.ClearErrors();
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
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

  private void comboBoxesAfterClose(object sender, EventArgs args)
  {
    ((Control) this.gridSavedSetups).Focus();
  }

  private void cboCompanyLineConditions_ValueChanged(object sender, EventArgs e)
  {
    if (this.cboCompanyLineConditions.Value == null || this.cboCompanyLineConditions.Value == DBNull.Value)
      return;
    this.cboForms.Value = (object) null;
  }

  private void cboForms_ValueChanged(object sender, EventArgs e)
  {
    if (this.cboForms.Value == null || this.cboForms.Value == DBNull.Value)
      return;
    this.cboCompanyLineConditions.Value = (object) null;
  }

  private void bindingSetups_CurrentChanged(object sender, EventArgs e)
  {
    dsAdminRaterForms.tblRaterFormSetupsRow row = (this.bindingSetups.Current is DataRowView current ? current.Row : (DataRow) null) as dsAdminRaterForms.tblRaterFormSetupsRow;
  }

  protected virtual void SetupSelected(dsAdminRaterForms.tblRaterFormSetupsRow setupRow)
  {
  }

  private void bindingConditions_CurrentChanged(object sender, EventArgs e)
  {
    dsAdminRaterForms.tblRaterFormAutomationRow row = (this.bindingConditions.Current is DataRowView current ? current.Row : (DataRow) null) as dsAdminRaterForms.tblRaterFormAutomationRow;
  }

  protected virtual void AutomationSelected(
    dsAdminRaterForms.tblRaterFormAutomationRow automationRow)
  {
  }
}
