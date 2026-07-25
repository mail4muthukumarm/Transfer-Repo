// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormInsuredCallReport
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinListView;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormInsuredCallReport : Form
{
  private IContainer components;
  private readonly bool _newRecordOnLoad;
  private readonly Guid _insuredLocationGuid;
  private readonly int _callReportID;
  private bool _allowFutureDateOfVisit;
  private bool _formLoading;
  private string _additionalActiveStatus;
  private bool _isSaving;
  private Dictionary<int, bool> _userList;
  private Dictionary<Guid, bool> _contactList;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormInsuredCallReport));
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstInsuredCallReportType", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Type");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblUsers", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("UserID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Name_LastFirst");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("StatusID");
    Appearance appearance10 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblInsuredCallReport", -1);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CallReportID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("DateOfVisit");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("CallType", -1, (object) "ddCallRepType");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("LeadContactID", -1, (object) "ddUsers");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("MeetingNotes");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("InsuredLocationGuid");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.grpCallReport = new MGAGroupBox();
    this.Label2 = new Label();
    this.UltraGroupBox4 = new UltraGroupBox();
    this.txtMeetingNotes = new MGATextBox();
    this.dtVisit = new MGADateTimePicker();
    this.label6 = new Label();
    this.label5 = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.Label3 = new Label();
    this.Label1 = new Label();
    this.ulvUserContacts = new UltraListView();
    this.ulvClientContacts = new UltraListView();
    this.cnSQL = new SqlConnection();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.daPC = new SqlDataAdapter();
    this.SqlCommand1 = new SqlCommand();
    this.SqlCommand2 = new SqlCommand();
    this.SqlCommand3 = new SqlCommand();
    this.SqlCommand4 = new SqlCommand();
    this.daPU = new SqlDataAdapter();
    this.SqlCommand5 = new SqlCommand();
    this.SqlCommand6 = new SqlCommand();
    this.SqlCommand7 = new SqlCommand();
    this.SqlCommand8 = new SqlCommand();
    this.err = new ErrorProvider(this.components);
    this.cboLeadContact = new MGASimpleComboBox();
    this.ds = new dsInsuredCallReport();
    this.cboReportType = new MGASimpleComboBox();
    this.ddCallRepType = new UltraDropDown();
    this.ddUsers = new UltraDropDown();
    this.ugCallReport = new UltraGrid();
    ((ISupportInitialize) this.grpCallReport).BeginInit();
    ((Control) this.grpCallReport).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox4).BeginInit();
    ((Control) this.UltraGroupBox4).SuspendLayout();
    ((ISupportInitialize) this.txtMeetingNotes).BeginInit();
    ((ISupportInitialize) this.dtVisit).BeginInit();
    ((ISupportInitialize) this.ulvUserContacts).BeginInit();
    ((ISupportInitialize) this.ulvClientContacts).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.cboLeadContact).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboReportType).BeginInit();
    ((ISupportInitialize) this.ddCallRepType).BeginInit();
    ((ISupportInitialize) this.ddUsers).BeginInit();
    ((ISupportInitialize) this.ugCallReport).BeginInit();
    this.SuspendLayout();
    ((Control) this.grpCallReport).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpCallReport.Appearance = (AppearanceBase) appearance1;
    this.grpCallReport.BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance2.BackColor = Color.FromArgb(239, 247, 253);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpCallReport.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.grpCallReport).Controls.Add((Control) this.cboLeadContact);
    ((Control) this.grpCallReport).Controls.Add((Control) this.Label2);
    ((Control) this.grpCallReport).Controls.Add((Control) this.UltraGroupBox4);
    ((Control) this.grpCallReport).Controls.Add((Control) this.dtVisit);
    ((Control) this.grpCallReport).Controls.Add((Control) this.cboReportType);
    ((Control) this.grpCallReport).Controls.Add((Control) this.label6);
    ((Control) this.grpCallReport).Controls.Add((Control) this.label5);
    appearance3.ForeColor = Color.FromArgb(21, 66, 139);
    this.grpCallReport.HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.grpCallReport).Location = new Point(12, 340);
    ((Control) this.grpCallReport).Name = "grpCallReport";
    ((Control) this.grpCallReport).Size = new Size(464, 272);
    ((Control) this.grpCallReport).TabIndex = 252;
    this.grpCallReport.Text = "Call Report Details";
    this.grpCallReport.ViewStyle = (GroupBoxViewStyle) 2;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(15, 80 /*0x50*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(96 /*0x60*/, 24);
    this.Label2.TabIndex = 483;
    this.Label2.Text = "Lead Contact:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    this.UltraGroupBox4.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    this.UltraGroupBox4.ContentAreaAppearance = (AppearanceBase) appearance4;
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.txtMeetingNotes);
    ((Control) this.UltraGroupBox4).Location = new Point(30, 108);
    ((Control) this.UltraGroupBox4).Name = "UltraGroupBox4";
    ((Control) this.UltraGroupBox4).Size = new Size(399, 151);
    ((Control) this.UltraGroupBox4).TabIndex = 481;
    this.UltraGroupBox4.Text = "Meeting Notes";
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.Gray;
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtMeetingNotes).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtMeetingNotes).BackColor = Color.White;
    ((TextEditorControlBase) this.txtMeetingNotes).BorderStyle = (UIElementBorderStyle) 1;
    ((Control) this.txtMeetingNotes).Dock = DockStyle.Fill;
    ((Control) this.txtMeetingNotes).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((TextEditorControlBase) this.txtMeetingNotes).ForeColor = Color.Black;
    ((Control) this.txtMeetingNotes).Location = new Point(3, 16 /*0x10*/);
    this.txtMeetingNotes.Multiline = true;
    ((Control) this.txtMeetingNotes).Name = "txtMeetingNotes";
    ((Control) this.txtMeetingNotes).Size = new Size(393, 132);
    ((Control) this.txtMeetingNotes).TabIndex = 0;
    ((UltraControlBase) this.txtMeetingNotes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMeetingNotes).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtVisit.Appearance = (AppearanceBase) appearance6;
    appearance7.AlphaLevel = (short) 14;
    appearance7.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance7.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance7.BackColorAlpha = (Alpha) 2;
    appearance7.BackGradientAlignment = (GradientAlignment) 4;
    appearance7.BackGradientStyle = (GradientStyle) 5;
    appearance7.BorderAlpha = (Alpha) 1;
    appearance7.BorderColor = Color.FromArgb(78, 122, 171);
    appearance7.ForeColor = Color.FromArgb(49, 85, 153);
    appearance7.ForegroundAlpha = (Alpha) 2;
    this.dtVisit.ButtonAppearance = (AppearanceBase) appearance7;
    ((Control) this.dtVisit).DataBindings.Add(new Binding("Value", (object) this.ds, "tblInsuredCallReport.DateOfVisit", true));
    this.dtVisit.DateTime = new DateTime(2008, 10, 27, 0, 0, 0, 0);
    ((Control) this.dtVisit).Location = new Point(117, 31 /*0x1F*/);
    this.dtVisit.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtVisit).Name = "dtVisit";
    ((Control) this.dtVisit).Size = new Size(96 /*0x60*/, 19);
    ((Control) this.dtVisit).TabIndex = 0;
    ((UltraControlBase) this.dtVisit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtVisit).UseOsThemes = (DefaultableBoolean) 2;
    this.dtVisit.Value = (object) new DateTime(2008, 10, 27, 0, 0, 0, 0);
    this.label6.BackColor = Color.Transparent;
    this.label6.Location = new Point(15, 56);
    this.label6.Name = "label6";
    this.label6.Size = new Size(96 /*0x60*/, 24);
    this.label6.TabIndex = 110;
    this.label6.Text = "Call Report Type:";
    this.label6.TextAlign = ContentAlignment.MiddleLeft;
    this.label5.BackColor = Color.Transparent;
    this.label5.Location = new Point(15, 30);
    this.label5.Name = "label5";
    this.label5.Size = new Size(74, 20);
    this.label5.TabIndex = 109;
    this.label5.Text = "Date of Visit:";
    this.label5.TextAlign = ContentAlignment.MiddleLeft;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(598, 619);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(109, 39);
    this.dbSave.TabIndex = 253;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    this.Label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(488, 342);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(79, 13);
    this.Label3.TabIndex = 257;
    this.Label3.Text = "Users Contacts";
    this.Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(488, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(131, 13);
    this.Label1.TabIndex = 256 /*0x0100*/;
    this.Label1.Text = "Insured Location Contacts";
    ((Control) this.ulvUserContacts).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance8.BackColor = Color.Transparent;
    appearance8.BorderColor = Color.LightSteelBlue;
    this.ulvUserContacts.Appearance = (AppearanceBase) appearance8;
    ((Control) this.ulvUserContacts).Location = new Point(491, 371);
    ((Control) this.ulvUserContacts).Name = "ulvUserContacts";
    ((Control) this.ulvUserContacts).Size = new Size(216, 241);
    ((Control) this.ulvUserContacts).TabIndex = (int) byte.MaxValue;
    ((Control) this.ulvUserContacts).Text = "UltraListView2";
    ((UltraControlBase) this.ulvUserContacts).UseFlatMode = (DefaultableBoolean) 1;
    this.ulvUserContacts.View = (UltraListViewStyle) 2;
    ((UltraListViewListSettingsBase) this.ulvUserContacts.ViewSettingsList).CheckBoxStyle = (CheckBoxStyle) 1;
    ((UltraListViewSettingsBase) this.ulvUserContacts.ViewSettingsList).ImageSize = new Size(0, -1);
    this.ulvUserContacts.ViewSettingsList.MultiColumn = false;
    ((Control) this.ulvClientContacts).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    appearance9.BackColor = Color.Transparent;
    appearance9.BorderColor = Color.LightSteelBlue;
    this.ulvClientContacts.Appearance = (AppearanceBase) appearance9;
    ((Control) this.ulvClientContacts).Location = new Point(491, 25);
    ((Control) this.ulvClientContacts).Name = "ulvClientContacts";
    ((Control) this.ulvClientContacts).Size = new Size(216, 294);
    ((Control) this.ulvClientContacts).TabIndex = 254;
    ((Control) this.ulvClientContacts).Text = "Client Contacts";
    ((UltraControlBase) this.ulvClientContacts).UseFlatMode = (DefaultableBoolean) 1;
    this.ulvClientContacts.View = (UltraListViewStyle) 2;
    ((UltraListViewListSettingsBase) this.ulvClientContacts.ViewSettingsList).CheckBoxStyle = (CheckBoxStyle) 1;
    ((UltraListViewSettingsBase) this.ulvClientContacts.ViewSettingsList).ImageSize = new Size(0, -1);
    this.ulvClientContacts.ViewSettingsList.MultiColumn = false;
    this.cnSQL.ConnectionString = "Data Source=10.0.0.52;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.da.DeleteCommand = this.SqlDeleteCommand2;
    this.da.InsertCommand = this.SqlInsertCommand2;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblInsuredCallReport", new DataColumnMapping[6]
      {
        new DataColumnMapping("CallReportID", "CallReportID"),
        new DataColumnMapping("DateOfVisit", "DateOfVisit"),
        new DataColumnMapping("CallType", "CallType"),
        new DataColumnMapping("LeadContactID", "LeadContactID"),
        new DataColumnMapping("MeetingNotes", "MeetingNotes"),
        new DataColumnMapping("InsuredLocationGuid", "InsuredLocationGuid")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM [dbo].[tblInsuredCallReport] WHERE (([CallReportID] = @Original_CallReportID))";
    this.SqlDeleteCommand2.Connection = this.cnSQL;
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_CallReportID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CallReportID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    this.SqlInsertCommand2.Connection = this.cnSQL;
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@DateOfVisit", SqlDbType.DateTime, 0, "DateOfVisit"),
      new SqlParameter("@CallType", SqlDbType.Int, 0, "CallType"),
      new SqlParameter("@LeadContactID", SqlDbType.Int, 0, "LeadContactID"),
      new SqlParameter("@MeetingNotes", SqlDbType.Text, 0, "MeetingNotes"),
      new SqlParameter("@InsuredLocationGuid", SqlDbType.UniqueIdentifier, 0, "InsuredLocationGuid")
    });
    this.SqlSelectCommand1.CommandText = "SELECT        CallReportID, DateOfVisit, CallType, LeadContactID, MeetingNotes, InsuredLocationGuid\r\nFROM            dbo.tblInsuredCallReport";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Connection = this.cnSQL;
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@DateOfVisit", SqlDbType.DateTime, 0, "DateOfVisit"),
      new SqlParameter("@CallType", SqlDbType.Int, 0, "CallType"),
      new SqlParameter("@LeadContactID", SqlDbType.Int, 0, "LeadContactID"),
      new SqlParameter("@MeetingNotes", SqlDbType.Text, 0, "MeetingNotes"),
      new SqlParameter("@InsuredLocationGuid", SqlDbType.UniqueIdentifier, 0, "InsuredLocationGuid"),
      new SqlParameter("@Original_CallReportID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CallReportID", DataRowVersion.Original, (object) null),
      new SqlParameter("@CallReportID", SqlDbType.Int, 4, "CallReportID")
    });
    this.daPC.DeleteCommand = this.SqlCommand1;
    this.daPC.InsertCommand = this.SqlCommand2;
    this.daPC.SelectCommand = this.SqlCommand3;
    this.daPC.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblInsuredCallReportContacts", new DataColumnMapping[3]
      {
        new DataColumnMapping("CallReportID", "CallReportID"),
        new DataColumnMapping("InsuredContactGUID", "InsuredContactGUID"),
        new DataColumnMapping("ID", "ID")
      })
    });
    this.daPC.UpdateCommand = this.SqlCommand4;
    this.SqlCommand1.CommandText = "DELETE FROM [dbo].[tblInsuredCallReportContacts] WHERE (([ID] = @Original_ID))";
    this.SqlCommand1.Connection = this.cnSQL;
    this.SqlCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlCommand2.CommandText = componentResourceManager.GetString("SqlCommand2.CommandText");
    this.SqlCommand2.Connection = this.cnSQL;
    this.SqlCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@CallReportID", SqlDbType.Int, 0, "CallReportID"),
      new SqlParameter("@InsuredContactGUID", SqlDbType.UniqueIdentifier, 0, "InsuredContactGUID")
    });
    this.SqlCommand3.CommandText = "SELECT        CallReportID, InsuredContactGUID, ID\r\nFROM            dbo.tblInsuredCallReportContacts\r\nWHERE        (CallReportID = @callReportID)";
    this.SqlCommand3.Connection = this.cnSQL;
    this.SqlCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@callReportID", SqlDbType.Int, 4, "CallReportID")
    });
    this.SqlCommand4.CommandText = componentResourceManager.GetString("SqlCommand4.CommandText");
    this.SqlCommand4.Connection = this.cnSQL;
    this.SqlCommand4.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@CallReportID", SqlDbType.Int, 0, "CallReportID"),
      new SqlParameter("@InsuredContactGUID", SqlDbType.UniqueIdentifier, 0, "InsuredContactGUID"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    this.daPU.DeleteCommand = this.SqlCommand5;
    this.daPU.InsertCommand = this.SqlCommand6;
    this.daPU.SelectCommand = this.SqlCommand7;
    this.daPU.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblInsuredCallReportUsers", new DataColumnMapping[3]
      {
        new DataColumnMapping("CallReportID", "CallReportID"),
        new DataColumnMapping("UserID", "UserID"),
        new DataColumnMapping("ID", "ID")
      })
    });
    this.daPU.UpdateCommand = this.SqlCommand8;
    this.SqlCommand5.CommandText = "DELETE FROM [dbo].[tblInsuredCallReportUsers] WHERE (([ID] = @Original_ID))";
    this.SqlCommand5.Connection = this.cnSQL;
    this.SqlCommand5.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlCommand6.CommandText = componentResourceManager.GetString("SqlCommand6.CommandText");
    this.SqlCommand6.Connection = this.cnSQL;
    this.SqlCommand6.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@CallReportID", SqlDbType.Int, 0, "CallReportID"),
      new SqlParameter("@UserID", SqlDbType.Int, 0, "UserID")
    });
    this.SqlCommand7.CommandText = "SELECT        CallReportID, UserID, ID\r\nFROM            dbo.tblInsuredCallReportUsers\r\nWHERE        (CallReportID = @callReportID)";
    this.SqlCommand7.Connection = this.cnSQL;
    this.SqlCommand7.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@callReportID", SqlDbType.Int, 4, "CallReportID")
    });
    this.SqlCommand8.CommandText = componentResourceManager.GetString("SqlCommand8.CommandText");
    this.SqlCommand8.Connection = this.cnSQL;
    this.SqlCommand8.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@CallReportID", SqlDbType.Int, 0, "CallReportID"),
      new SqlParameter("@UserID", SqlDbType.Int, 0, "UserID"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    this.err.ContainerControl = (ContainerControl) this;
    this.cboLeadContact.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLeadContact).DataBindings.Add(new Binding("Value", (object) this.ds, "tblInsuredCallReport.LeadContactID", true));
    ((UltraGridBase) this.cboLeadContact).DataMember = "tblUsers";
    ((UltraGridBase) this.cboLeadContact).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboLeadContact).DisplayMember = "Name_LastFirst";
    this.cboLeadContact.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLeadContact).DropDownWidth = 300;
    ((Control) this.cboLeadContact).Location = new Point(117, 82);
    this.cboLeadContact.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLeadContact).Name = "cboLeadContact";
    ((Control) this.cboLeadContact).Size = new Size(182, 20);
    ((Control) this.cboLeadContact).TabIndex = 2;
    ((UltraControlBase) this.cboLeadContact).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLeadContact).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLeadContact).ValueMember = "UserID";
    this.ds.DataSetName = "dsInsuredCallReport";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cboReportType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboReportType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblInsuredCallReport.CallType", true));
    ((UltraGridBase) this.cboReportType).DataMember = "lstInsuredCallReportType";
    ((UltraGridBase) this.cboReportType).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboReportType).DisplayMember = "Type";
    this.cboReportType.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboReportType).DropDownWidth = 300;
    ((Control) this.cboReportType).Location = new Point(117, 56);
    this.cboReportType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboReportType).Name = "cboReportType";
    ((Control) this.cboReportType).Size = new Size(182, 20);
    ((Control) this.cboReportType).TabIndex = 1;
    ((UltraControlBase) this.cboReportType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboReportType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboReportType).ValueMember = "ID";
    ((UltraGridBase) this.ddCallRepType).DataMember = "lstInsuredCallReportType";
    ((UltraGridBase) this.ddCallRepType).DataSource = (object) this.ds;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 156;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ddCallRepType).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraDropDownBase) this.ddCallRepType).DisplayMember = "Type";
    ((UltraDropDownBase) this.ddCallRepType).DropDownWidth = 250;
    ((Control) this.ddCallRepType).Location = new Point(46, 117);
    ((Control) this.ddCallRepType).Name = "ddCallRepType";
    ((Control) this.ddCallRepType).Size = new Size(164, 56);
    ((Control) this.ddCallRepType).TabIndex = 250;
    ((UltraDropDownBase) this.ddCallRepType).ValueMember = "ID";
    ((Control) this.ddCallRepType).Visible = false;
    ((UltraGridBase) this.ddUsers).DataMember = "tblUsers";
    ((UltraGridBase) this.ddUsers).DataSource = (object) this.ds;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 176 /*0xB0*/;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Hidden = true;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.ddUsers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddUsers).DisplayMember = "Name_LastFirst";
    ((UltraDropDownBase) this.ddUsers).DropDownWidth = 250;
    ((Control) this.ddUsers).Location = new Point(246, 140);
    ((Control) this.ddUsers).Name = "ddUsers";
    ((Control) this.ddUsers).Size = new Size(164, 60);
    ((Control) this.ddUsers).TabIndex = 251;
    ((UltraDropDownBase) this.ddUsers).ValueMember = "UserID";
    ((Control) this.ddUsers).Visible = false;
    ((Control) this.ugCallReport).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugCallReport).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugCallReport).DataMember = "tblInsuredCallReport";
    ((UltraGridBase) this.ugCallReport).DataSource = (object) this.ds;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugCallReport).DisplayLayout.Appearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugCallReport).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.AddButtonCaption = "Details";
    ultraGridColumn6.Header.VisiblePosition = 0;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 56;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Date Of Visit";
    ultraGridColumn7.Header.VisiblePosition = 1;
    ultraGridColumn7.Width = 168;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Call Type";
    ultraGridColumn8.Header.VisiblePosition = 2;
    ultraGridColumn8.Style = (ColumnStyle) 6;
    ultraGridColumn8.Width = 119;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Lead Contact";
    ultraGridColumn9.Header.VisiblePosition = 3;
    ultraGridColumn9.Style = (ColumnStyle) 6;
    ultraGridColumn9.Width = 175;
    ultraGridColumn10.Header.VisiblePosition = 4;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 79;
    ultraGridColumn11.Header.VisiblePosition = 5;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 230;
    ultraGridBand3.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11
    });
    ((UltraGridBase) this.ugCallReport).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ugCallReport).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance11.BackColor = Color.LightSteelBlue;
    appearance11.FontData.SizeInPoints = 10f;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCallReport).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.Wheat;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCallReport).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ugCallReport).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugCallReport).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugCallReport).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCallReport).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ugCallReport).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance14.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugCallReport).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.ugCallReport).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance15.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugCallReport).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance15;
    appearance16.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCallReport).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.ugCallReport).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance17.BackColor = Color.Transparent;
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCallReport).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.ugCallReport).DisplayLayout.Override.SelectTypeCell = (SelectType) 2;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugCallReport).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugCallReport).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugCallReport).Location = new Point(12, 12);
    ((Control) this.ugCallReport).Name = "ugCallReport";
    ((Control) this.ugCallReport).Size = new Size(464, 307);
    ((Control) this.ugCallReport).TabIndex = 6;
    ((Control) this.ugCallReport).Text = "Available Call Reports";
    ((UltraControlBase) this.ugCallReport).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugCallReport).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(728, 670);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.ulvUserContacts);
    this.Controls.Add((Control) this.ulvClientContacts);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.grpCallReport);
    this.Controls.Add((Control) this.ddCallRepType);
    this.Controls.Add((Control) this.ddUsers);
    this.Controls.Add((Control) this.ugCallReport);
    this.Name = nameof (FormInsuredCallReport);
    this.Text = "Insured Call Reports";
    ((ISupportInitialize) this.grpCallReport).EndInit();
    ((Control) this.grpCallReport).ResumeLayout(false);
    ((Control) this.grpCallReport).PerformLayout();
    ((ISupportInitialize) this.UltraGroupBox4).EndInit();
    ((Control) this.UltraGroupBox4).ResumeLayout(false);
    ((Control) this.UltraGroupBox4).PerformLayout();
    ((ISupportInitialize) this.txtMeetingNotes).EndInit();
    ((ISupportInitialize) this.dtVisit).EndInit();
    ((ISupportInitialize) this.ulvUserContacts).EndInit();
    ((ISupportInitialize) this.ulvClientContacts).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.cboLeadContact).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboReportType).EndInit();
    ((ISupportInitialize) this.ddCallRepType).EndInit();
    ((ISupportInitialize) this.ddUsers).EndInit();
    ((ISupportInitialize) this.ugCallReport).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private virtual UltraGrid ugCallReport
  {
    get => this._ugCallReport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugDetails_AfterRowActivate);
      UltraGrid ugCallReport1 = this._ugCallReport;
      if (ugCallReport1 != null)
        ugCallReport1.AfterRowActivate -= eventHandler;
      this._ugCallReport = value;
      UltraGrid ugCallReport2 = this._ugCallReport;
      if (ugCallReport2 == null)
        return;
      ugCallReport2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ddCallRepType")]
  private virtual UltraDropDown ddCallRepType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddUsers")]
  private virtual UltraDropDown ddUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpCallReport")]
  protected virtual MGAGroupBox grpCallReport { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASimpleComboBox cboLeadContact
  {
    get => this._cboLeadContact;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboLeadContact_AfterCloseUp);
      MGASimpleComboBox cboLeadContact1 = this._cboLeadContact;
      if (cboLeadContact1 != null)
        cboLeadContact1.AfterCloseUp -= eventHandler;
      this._cboLeadContact = value;
      MGASimpleComboBox cboLeadContact2 = this._cboLeadContact;
      if (cboLeadContact2 == null)
        return;
      cboLeadContact2.AfterCloseUp += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox4")]
  private virtual UltraGroupBox UltraGroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtMeetingNotes")]
  private virtual MGATextBox txtMeetingNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtVisit")]
  private virtual MGADateTimePicker dtVisit { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboReportType")]
  protected virtual MGASimpleComboBox cboReportType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label6")]
  private virtual Label label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label5")]
  private virtual Label label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_UISstateChanged);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_ClickedDelete);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.ClickingNew -= cancelEventHandler1;
        dbSave1.ClickingEdit -= cancelEventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler3;
        dbSave1.ClickingDelete -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler2;
        dbSave1.ClickedDelete -= eventHandler3;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.ClickingNew += cancelEventHandler1;
      dbSave2.ClickingEdit += cancelEventHandler2;
      dbSave2.ClickingSave += cancelEventHandler3;
      dbSave2.ClickingDelete += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler2;
      dbSave2.ClickedDelete += eventHandler3;
    }
  }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraListView ulvUserContacts
  {
    get => this._ulvUserContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckStateChangingEventHandler changingEventHandler = new ItemCheckStateChangingEventHandler(this.ulvUserContacts_ItemCheckStateChanging);
      UltraListView ulvUserContacts1 = this._ulvUserContacts;
      if (ulvUserContacts1 != null)
        ulvUserContacts1.ItemCheckStateChanging -= changingEventHandler;
      this._ulvUserContacts = value;
      UltraListView ulvUserContacts2 = this._ulvUserContacts;
      if (ulvUserContacts2 == null)
        return;
      ulvUserContacts2.ItemCheckStateChanging += changingEventHandler;
    }
  }

  protected virtual UltraListView ulvClientContacts
  {
    get => this._ulvClientContacts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckStateChangingEventHandler changingEventHandler = new ItemCheckStateChangingEventHandler(this.ulvClientContacts_ItemCheckStateChanging);
      UltraListView ulvClientContacts1 = this._ulvClientContacts;
      if (ulvClientContacts1 != null)
        ulvClientContacts1.ItemCheckStateChanging -= changingEventHandler;
      this._ulvClientContacts = value;
      UltraListView ulvClientContacts2 = this._ulvClientContacts;
      if (ulvClientContacts2 == null)
        return;
      ulvClientContacts2.ItemCheckStateChanging += changingEventHandler;
    }
  }

  [field: AccessedThroughProperty("cnSQL")]
  private virtual SqlConnection cnSQL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsInsuredCallReport ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("da")]
  private virtual SqlDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand2")]
  private virtual SqlCommand SqlDeleteCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand2")]
  private virtual SqlCommand SqlInsertCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  private virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand2")]
  private virtual SqlCommand SqlUpdateCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daPC")]
  private virtual SqlDataAdapter daPC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand1")]
  private virtual SqlCommand SqlCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand2")]
  private virtual SqlCommand SqlCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand3")]
  private virtual SqlCommand SqlCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand4")]
  private virtual SqlCommand SqlCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daPU")]
  private virtual SqlDataAdapter daPU { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand5")]
  private virtual SqlCommand SqlCommand5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand6")]
  private virtual SqlCommand SqlCommand6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand7")]
  private virtual SqlCommand SqlCommand7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand8")]
  private virtual SqlCommand SqlCommand8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  private virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormInsuredCallReport(Guid insuredLocationGuid, bool newRecordOnLoad)
  {
    this.Load += new EventHandler(this.FormInsuredCallReport_Load);
    this._newRecordOnLoad = false;
    this._callReportID = int.MinValue;
    this._allowFutureDateOfVisit = false;
    this._formLoading = true;
    this._additionalActiveStatus = string.Empty;
    this._userList = new Dictionary<int, bool>();
    this._contactList = new Dictionary<Guid, bool>();
    this.InitializeComponent();
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._insuredLocationGuid = insuredLocationGuid;
    this._newRecordOnLoad = newRecordOnLoad;
  }

  public FormInsuredCallReport(Guid insuredLocationGuid, bool newRecordOnLoad, int callReportID)
  {
    this.Load += new EventHandler(this.FormInsuredCallReport_Load);
    this._newRecordOnLoad = false;
    this._callReportID = int.MinValue;
    this._allowFutureDateOfVisit = false;
    this._formLoading = true;
    this._additionalActiveStatus = string.Empty;
    this._userList = new Dictionary<int, bool>();
    this._contactList = new Dictionary<Guid, bool>();
    this.InitializeComponent();
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._insuredLocationGuid = insuredLocationGuid;
    this._newRecordOnLoad = newRecordOnLoad;
    this._callReportID = callReportID;
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblInsuredCallReport.TableName];
  }

  private void FormInsuredCallReport_Load(object sender, EventArgs e)
  {
    dsInsuredCallReport.lstInsuredCallReportTypeRow row1 = this.ds.lstInsuredCallReportType.NewlstInsuredCallReportTypeRow();
    row1.Type = string.Empty;
    this.ds.lstInsuredCallReportType.AddlstInsuredCallReportTypeRow(row1);
    dsInsuredCallReport.tblUsersRow row2 = this.ds.tblUsers.NewtblUsersRow();
    row2.Name_LastFirst = string.Empty;
    this.ds.tblUsers.AddtblUsersRow(row2);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblUsers"
    }, "dbo.GetInsuredCallReportLeadUsers");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstInsuredCallReportType"
    }, CommandType.Text, "SELECT ID, Type FROM lstInsuredCallReportType ORDER BY Type");
    if (this._callReportID == int.MinValue)
    {
      this.da.SelectCommand.Parameters.AddWithValue("@InsuredLocationGuid", (object) this._insuredLocationGuid);
      SqlCommand selectCommand;
      string str = (selectCommand = this.da.SelectCommand).CommandText + " WHERE InsuredLocationGuid = @InsuredLocationGuid Order by DateOfVisit DESC";
      selectCommand.CommandText = str;
    }
    else
    {
      this.da.SelectCommand.Parameters.AddWithValue("@CallReportID", (object) this._callReportID);
      SqlCommand selectCommand;
      string str = (selectCommand = this.da.SelectCommand).CommandText + " WHERE CallReportID = @CallReportID Order by DateOfVisit DESC";
      selectCommand.CommandText = str;
    }
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.da, (DataTable) this.ds.tblInsuredCallReport);
    this.EnableControls(this._newRecordOnLoad);
    this.bmb.PositionChanged += new EventHandler(this.bmb_PositionChanged);
    UltraListView ulvClientContacts = this.ulvClientContacts;
    ulvClientContacts.Appearance.BackColor = Color.Transparent;
    ulvClientContacts.Appearance.BorderColor = Color.LightSteelBlue;
    ulvClientContacts.BorderStyle = (UIElementBorderStyle) 16 /*0x10*/;
    ((ScrollBarLook) ulvClientContacts.ScrollBarLook).ViewStyle = (ScrollBarViewStyle) 2;
    ((UltraControlBase) ulvClientContacts).UseFlatMode = (DefaultableBoolean) 1;
    ulvClientContacts.View = (UltraListViewStyle) 2;
    ((UltraListViewListSettingsBase) ulvClientContacts.ViewSettingsList).CheckBoxStyle = (CheckBoxStyle) 1;
    ulvClientContacts.ViewSettingsList.MultiColumn = false;
    ((Control) this.ulvClientContacts).Enabled = true;
    this.LoadContactsAndUsers();
    if (this.bmb.Position != -1)
    {
      try
      {
        this.ulvClientContacts.ItemCheckStateChanging -= new ItemCheckStateChangingEventHandler(this.ulvClientContacts_ItemCheckStateChanging);
        this.ulvUserContacts.ItemCheckStateChanging -= new ItemCheckStateChangingEventHandler(this.ulvUserContacts_ItemCheckStateChanging);
        this.LoadReportProducerContacts(this.ds.tblInsuredCallReport[this.bmb.Position].CallReportID);
        this.LoadReportUserContacts(this.ds.tblInsuredCallReport[this.bmb.Position].CallReportID);
        this.LoadTextBoxes();
      }
      finally
      {
        this.ulvClientContacts.ItemCheckStateChanging += new ItemCheckStateChangingEventHandler(this.ulvClientContacts_ItemCheckStateChanging);
        this.ulvUserContacts.ItemCheckStateChanging += new ItemCheckStateChangingEventHandler(this.ulvUserContacts_ItemCheckStateChanging);
      }
    }
    this.dbSave.AutoQueryRowCountOnLoad = false;
    if (!this._newRecordOnLoad)
    {
      this.SetSaveState();
    }
    else
    {
      this.dbSave_ClickingNew((object) null, (CancelEventArgs) null);
      this.dbSave.UIState = UIState.Editing;
    }
    this.HighlightInactiveUsers();
    this._allowFutureDateOfVisit = SystemSettings.KeyExists("AllowCallReportsFutureDateOfVisit") && SystemSettings.GetBoolSetting("AllowCallReportsFutureDateOfVisit");
    this._formLoading = false;
  }

  private bool EnableLocationContact(
    dsInsuredCallReport.tblInsuredCallReportContactsRow row)
  {
    return !row.IsStatusIDNull() && (row.StatusID == 1 || !this._additionalActiveStatus.Equals(string.Empty) && Array.Exists<string>(this._additionalActiveStatus.Split(";".ToCharArray()), (Predicate<string>) ([SpecialName] (arrStatus) => arrStatus.Equals(row.StatusID.ToString()))));
  }

  private void LoadContactsAndUsers()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblInsuredCallReportContacts"
    }, CommandType.Text, "SELECT  IC.InsuredContactGUID, IC.LName + @apos + IC.FName AS ContactName, IC.StatusID FROM tblInsuredContacts IC WITH (NOLOCK) INNER JOIN tblInsuredLocations ILC WITH (NOLOCK) ON IC.InsuredLocationGUID = ILC.InsuredLocationGUID WHERE ILC.InsuredLocationGUID = @InsuredLocationGuid AND IC.StatusID = 1 ORDER BY IC.LName", new object[4]
    {
      (object) "@apos",
      (object) ", ",
      (object) "@InsuredLocationGuid",
      (object) this._insuredLocationGuid
    });
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblInsuredCallReportUsers"
    }, CommandType.Text, "SELECT UserID, Name_LastFirst, StatusID FROM tblUsers WITH (NOLOCK) WHERE StatusID = 1 ORDER BY Name_LastFirst");
    int num1 = 0;
    this.ulvClientContacts.Items.Clear();
    this.ulvUserContacts.Items.Clear();
    try
    {
      foreach (dsInsuredCallReport.tblInsuredCallReportContactsRow row in this.ds.tblInsuredCallReportContacts.Rows)
      {
        this.ulvClientContacts.Items.Add(row.InsuredContactGUID.ToString(), (object) row.ContactName);
        this.ulvClientContacts.Items[num1].Enabled = this.EnableLocationContact(row);
        ++num1;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    int num2 = 0;
    try
    {
      foreach (dsInsuredCallReport.tblInsuredCallReportUsersRow row in this.ds.tblInsuredCallReportUsers.Rows)
      {
        this.ulvUserContacts.Items.Add(row.UserID.ToString(), (object) row.Name_LastFirst);
        this.ulvUserContacts.Items[num2].Enabled = row.Field<int?>("StatusID").GetValueOrDefault() == 1;
        ++num2;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void UncheckListViewItems(UltraListView lv)
  {
    this._isSaving = true;
    try
    {
      this.ulvClientContacts.ItemCheckStateChanging -= new ItemCheckStateChangingEventHandler(this.ulvClientContacts_ItemCheckStateChanging);
      this.ulvUserContacts.ItemCheckStateChanging -= new ItemCheckStateChangingEventHandler(this.ulvUserContacts_ItemCheckStateChanging);
      UltraListViewItemsCollection.UltraListViewItemEnumerator enumerator = lv.Items.GetEnumerator();
      while (((DisposableObjectEnumeratorBase) enumerator).MoveNext())
        enumerator.Current.CheckState = CheckState.Unchecked;
    }
    finally
    {
      this.ulvClientContacts.ItemCheckStateChanging += new ItemCheckStateChangingEventHandler(this.ulvClientContacts_ItemCheckStateChanging);
      this.ulvUserContacts.ItemCheckStateChanging += new ItemCheckStateChangingEventHandler(this.ulvUserContacts_ItemCheckStateChanging);
    }
    this._isSaving = false;
  }

  private void LoadReportProducerContacts(int callReportID)
  {
    this._isSaving = true;
    this.ds.tblInsuredCallReportContacts.Clear();
    this.daPC.SelectCommand.Parameters["@callReportID"].Value = (object) callReportID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daPC, (DataTable) this.ds.tblInsuredCallReportContacts);
    try
    {
      foreach (dsInsuredCallReport.tblInsuredCallReportContactsRow row in this.ds.tblInsuredCallReportContacts.Rows)
      {
        foreach (UltraListViewItem ultraListViewItem in this.ulvClientContacts.Items)
        {
          if (row.InsuredContactGUID.ToString().Equals(ultraListViewItem.Key))
          {
            try
            {
              this.ulvClientContacts.ItemCheckStateChanging -= new ItemCheckStateChangingEventHandler(this.ulvClientContacts_ItemCheckStateChanging);
              ultraListViewItem.CheckState = CheckState.Checked;
              break;
            }
            finally
            {
              this.ulvClientContacts.ItemCheckStateChanging += new ItemCheckStateChangingEventHandler(this.ulvClientContacts_ItemCheckStateChanging);
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
    this._isSaving = false;
  }

  private void LoadReportUserContacts(int callReportID)
  {
    this._isSaving = true;
    this.ds.tblInsuredCallReportUsers.Clear();
    this.daPU.SelectCommand.Parameters["@callReportID"].Value = (object) callReportID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daPU, (DataTable) this.ds.tblInsuredCallReportUsers);
    try
    {
      foreach (dsInsuredCallReport.tblInsuredCallReportUsersRow row in this.ds.tblInsuredCallReportUsers.Rows)
      {
        foreach (UltraListViewItem ultraListViewItem in this.ulvUserContacts.Items)
        {
          if (row.UserID.ToString().Equals(ultraListViewItem.Key))
          {
            try
            {
              this.ulvUserContacts.ItemCheckStateChanging -= new ItemCheckStateChangingEventHandler(this.ulvUserContacts_ItemCheckStateChanging);
              ultraListViewItem.CheckState = CheckState.Checked;
              break;
            }
            finally
            {
              this.ulvUserContacts.ItemCheckStateChanging += new ItemCheckStateChangingEventHandler(this.ulvUserContacts_ItemCheckStateChanging);
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
    this._isSaving = false;
  }

  private void LoadTextBoxes()
  {
    ((TextEditorControlBase) this.txtMeetingNotes).Text = string.Empty;
    if (this.bmb.Position == -1)
      return;
    if (this.ds.tblInsuredCallReport[this.bmb.Position].IsMeetingNotesNull())
      return;
    try
    {
      ((TextEditorControlBase) this.txtMeetingNotes).Text = this.ds.tblInsuredCallReport[this.bmb.Position].MeetingNotes;
    }
    catch (ArgumentException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ((TextEditorControlBase) this.txtMeetingNotes).Text = this.ds.tblInsuredCallReport[this.bmb.Position].MeetingNotes;
      ProjectData.ClearProjectError();
    }
  }

  private void bmb_PositionChanged(object sender, EventArgs e)
  {
    this._isSaving = true;
    this.ds.tblInsuredCallReportContacts.Clear();
    this.ds.tblInsuredCallReportUsers.Clear();
    this._contactList.Clear();
    this._userList.Clear();
    this.UncheckListViewItems(this.ulvUserContacts);
    this.UncheckListViewItems(this.ulvClientContacts);
    if (this.bmb.Position == -1)
      return;
    this.LoadTextBoxes();
    this.LoadReportProducerContacts(this.ds.tblInsuredCallReport[this.bmb.Position].CallReportID);
    this.LoadReportUserContacts(this.ds.tblInsuredCallReport[this.bmb.Position].CallReportID);
    this._isSaving = false;
  }

  private void SetSaveState()
  {
    if (this.ds.tblInsuredCallReport.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void EnableControls(bool enable) => ((Control) this.grpCallReport).Enabled = enable;

  private bool IsValidReport()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboLeadContact, string.Empty);
    this.err.SetError((Control) this.cboReportType, string.Empty);
    this.err.SetError((Control) this.dtVisit, string.Empty);
    if (this.dtVisit.Value != DBNull.Value && this.dtVisit.Value != null)
    {
      if (!this._allowFutureDateOfVisit && DateAndTime.DateDiff(DateInterval.Day, DateAndTime.Now.Date, Conversions.ToDate(this.dtVisit.Value)) > 0L)
      {
        flag = false;
        this.err.SetError((Control) this.dtVisit, "no future entries");
      }
    }
    else
    {
      flag = false;
      this.err.SetError((Control) this.dtVisit, "Please enter a value");
    }
    if (!this.IsReportTypeValid())
    {
      flag = false;
      this.err.SetError((Control) this.cboReportType, "Please enter a value.");
    }
    if (!this.IsValidLeadContact())
    {
      flag = false;
      this.err.SetError((Control) this.cboLeadContact, "Please enter a value.");
    }
    if (!this.IsValidInsuredContact())
    {
      flag = false;
      int num = (int) MessageBox.Show("Please select a contact producer contact to continue.", "No Contact Selected.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    return flag;
  }

  protected virtual bool IsReportTypeValid() => true;

  protected virtual bool IsValidLeadContact() => true;

  protected virtual bool IsValidInsuredContact() => true;

  private void SaveTextBoxesData(dsInsuredCallReport.tblInsuredCallReportRow row)
  {
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtMeetingNotes).Text))
      row.MeetingNotes = ((TextEditorControlBase) this.txtMeetingNotes).Text;
    else
      row.SetMeetingNotesNull();
  }

  private void ugDetails_AfterRowActivate(object sender, EventArgs e)
  {
    this.UncheckListViewItems(this.ulvUserContacts);
    this.UncheckListViewItems(this.ulvClientContacts);
    if (((UltraGridBase) this.ugCallReport).ActiveRow == null)
      return;
    int callReportID = (int) ((UltraGridBase) this.ugCallReport).ActiveRow.Cells["CallReportID"].Value;
    Database.MoveTo((object) callReportID, "CallReportID", (DataTable) this.ds.tblInsuredCallReport, this.bmb);
    this.LoadReportProducerContacts(callReportID);
    this.LoadReportUserContacts(callReportID);
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ulvClientContacts.ItemCheckStateChanging -= new ItemCheckStateChangingEventHandler(this.ulvClientContacts_ItemCheckStateChanging);
    this.ulvUserContacts.ItemCheckStateChanging -= new ItemCheckStateChangingEventHandler(this.ulvUserContacts_ItemCheckStateChanging);
    try
    {
      this.ds.tblInsuredCallReport.RejectChanges();
      this.SetSaveState();
      this.EnableControls(false);
      ((UltraGridBase) this.ugCallReport).UpdateData();
    }
    finally
    {
      this.ulvClientContacts.ItemCheckStateChanging += new ItemCheckStateChangingEventHandler(this.ulvClientContacts_ItemCheckStateChanging);
      this.ulvUserContacts.ItemCheckStateChanging += new ItemCheckStateChangingEventHandler(this.ulvUserContacts_ItemCheckStateChanging);
    }
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    try
    {
      this.ulvClientContacts.ItemCheckStateChanging -= new ItemCheckStateChangingEventHandler(this.ulvClientContacts_ItemCheckStateChanging);
      this.ulvUserContacts.ItemCheckStateChanging -= new ItemCheckStateChangingEventHandler(this.ulvUserContacts_ItemCheckStateChanging);
      dsInsuredCallReport.tblInsuredCallReportRow row = this.ds.tblInsuredCallReport.NewtblInsuredCallReportRow();
      row.InsuredLocationGuid = this._insuredLocationGuid;
      this.ds.tblInsuredCallReport.AddtblInsuredCallReportRow(row);
      this.bmb.Position = this.ds.tblInsuredCallReport.Count - 1;
      this.UncheckListViewItems(this.ulvUserContacts);
      this.UncheckListViewItems(this.ulvClientContacts);
      this.EnableControls(true);
    }
    finally
    {
      this.ulvClientContacts.ItemCheckStateChanging += new ItemCheckStateChangingEventHandler(this.ulvClientContacts_ItemCheckStateChanging);
      this.ulvUserContacts.ItemCheckStateChanging += new ItemCheckStateChangingEventHandler(this.ulvUserContacts_ItemCheckStateChanging);
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e) => this.EnableControls(true);

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.IsValidReport())
    {
      e.Cancel = true;
    }
    else
    {
      this.bmb.EndCurrentEdit();
      this.SaveTextBoxesData(this.ds.tblInsuredCallReport[this.bmb.Position]);
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblInsuredCallReport);
      int callReportId = this.ds.tblInsuredCallReport[this.bmb.Position].CallReportID;
      try
      {
        foreach (dsInsuredCallReport.tblInsuredCallReportContactsRow row in this.ds.tblInsuredCallReportContacts.Rows)
        {
          if (row.RowState != DataRowState.Deleted)
            row.CallReportID = callReportId;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        foreach (dsInsuredCallReport.tblInsuredCallReportUsersRow row in this.ds.tblInsuredCallReportUsers.Rows)
        {
          if (row.RowState != DataRowState.Deleted)
            row.CallReportID = callReportId;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daPC, (DataTable) this.ds.tblInsuredCallReportContacts);
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daPU, (DataTable) this.ds.tblInsuredCallReportUsers);
      this.EnableControls(false);
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
      e.Cancel = true;
    else if (MessageBox.Show("Do you wish to continue with the deletion of this call report?", "Delete Call Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
    {
      e.Cancel = true;
    }
    else
    {
      this._isSaving = false;
      this.UncheckListViewItems(this.ulvClientContacts);
      this.UncheckListViewItems(this.ulvUserContacts);
      this.ds.tblInsuredCallReport[this.bmb.Position].Delete();
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblInsuredCallReport);
      this.SetSaveState();
      this._isSaving = true;
    }
  }

  private void dbSave_UISstateChanged(object sender, EventArgs e)
  {
    ((Control) this.ulvClientContacts).Enabled = this.dbSave.UIState == UIState.Editing;
    ((Control) this.ulvUserContacts).Enabled = this.dbSave.UIState == UIState.Editing;
  }

  private void ulvUserContacts_ItemCheckStateChanging(
    object sender,
    ItemCheckStateChangingEventArgs e)
  {
    try
    {
      this.ulvUserContacts.EventManager.Disable((UltraListViewEventIds) 12);
      this.ulvUserContacts.EventManager.Disable((UltraListViewEventIds) 11);
      if (this._formLoading || this._isSaving)
        return;
      int callReportId = this.ds.tblInsuredCallReport[this.bmb.Position].CallReportID;
      int integer = Conversions.ToInteger(((CancelableItemEventArgs) e).Item.Key);
      if (((CancelableItemEventArgs) e).Item.CheckState == CheckState.Unchecked)
      {
        if (!this._userList.ContainsKey(integer))
          this._userList.Add(integer, true);
        else if (this._userList[integer])
          return;
      }
      else if (this._userList.ContainsKey(integer))
        this._userList.Remove(integer);
      if (((CancelableItemEventArgs) e).Item.CheckState == CheckState.Unchecked)
      {
        dsInsuredCallReport.tblInsuredCallReportUsersRow row = this.ds.tblInsuredCallReportUsers.NewtblInsuredCallReportUsersRow();
        row.UserID = Conversions.ToInteger(((CancelableItemEventArgs) e).Item.Key);
        this.ds.tblInsuredCallReportUsers.AddtblInsuredCallReportUsersRow(row);
      }
      else
      {
        if (this.ds.tblInsuredCallReportUsers.Select($"CallReportID={Conversions.ToString(callReportId)} AND UserID= {Conversions.ToString(integer)}").Length <= 0)
          return;
        this.ds.tblInsuredCallReportUsers.Select($"CallReportID={Conversions.ToString(callReportId)} AND UserID= {Conversions.ToString(integer)}")[0].Delete();
      }
    }
    finally
    {
      this.ulvUserContacts.EventManager.Enable((UltraListViewEventIds) 12);
      this.ulvUserContacts.EventManager.Enable((UltraListViewEventIds) 11);
    }
  }

  private void ulvClientContacts_ItemCheckStateChanging(
    object sender,
    ItemCheckStateChangingEventArgs e)
  {
    try
    {
      this.ulvClientContacts.EventManager.Disable((UltraListViewEventIds) 12);
      this.ulvClientContacts.EventManager.Disable((UltraListViewEventIds) 11);
      if (this._formLoading || this._isSaving)
        return;
      int callReportId = this.ds.tblInsuredCallReport[this.bmb.Position].CallReportID;
      Guid key = new Guid(((CancelableItemEventArgs) e).Item.Key);
      if (((CancelableItemEventArgs) e).Item.CheckState == CheckState.Unchecked)
      {
        if (!this._contactList.ContainsKey(key))
          this._contactList.Add(key, true);
        else if (this._contactList[key])
          return;
      }
      else if (this._contactList.ContainsKey(key))
        this._contactList.Remove(key);
      if (((CancelableItemEventArgs) e).Item.CheckState == CheckState.Unchecked)
      {
        dsInsuredCallReport.tblInsuredCallReportContactsRow row = this.ds.tblInsuredCallReportContacts.NewtblInsuredCallReportContactsRow();
        row.InsuredContactGUID = key;
        this.ds.tblInsuredCallReportContacts.AddtblInsuredCallReportContactsRow(row);
      }
      else
      {
        if (this.ds.tblInsuredCallReportContacts.Select($"CallReportID={Conversions.ToString(callReportId)} AND InsuredContactGUID='{key.ToString()}'").Length <= 0)
          return;
        this.ds.tblInsuredCallReportContacts.Select($"CallReportID={Conversions.ToString(callReportId)} AND InsuredContactGUID='{key.ToString()}'")[0].Delete();
      }
    }
    finally
    {
      this.ulvClientContacts.EventManager.Enable((UltraListViewEventIds) 12);
      this.ulvClientContacts.EventManager.Enable((UltraListViewEventIds) 11);
    }
  }

  private void dbSave_ClickedDelete(object sender, EventArgs e) => this.SetSaveState();

  private void HighlightInactiveUsers()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.cboLeadContact).Rows)
    {
      if (row.Cells["StatusID"].Value != null && row.Cells["StatusID"].Value != DBNull.Value && Conversions.ToInteger(row.Cells["StatusID"].Value) != 1)
      {
        UltraGridRow ultraGridRow = row;
        ultraGridRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
        ultraGridRow.Appearance.ForeColor = Color.Red;
      }
    }
  }

  private void cboLeadContact_AfterCloseUp(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.cboLeadContact).ActiveRow == null || ((UltraGridBase) this.cboLeadContact).ActiveRow.Cells["StatusID"].Value == null || ((UltraGridBase) this.cboLeadContact).ActiveRow.Cells["StatusID"].Value == DBNull.Value || Conversions.ToInteger(((UltraGridBase) this.cboLeadContact).ActiveRow.Cells["StatusID"].Value) == 1)
      return;
    int num = (int) MessageBox.Show("The chosen user is not active.", "User is not Active", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.cboLeadContact.Value = (object) null;
  }
}
