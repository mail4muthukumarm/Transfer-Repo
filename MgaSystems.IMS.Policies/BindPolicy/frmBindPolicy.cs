// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.BindPolicy.frmBindPolicy
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.CustomExceptions;
using MGASystems.Common.Extensions;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.IMS.Policies.AccountingTransfer;
using MGASystems.IMS.Policies.Clearance;
using MGASystems.IMS.Policies.PolicyBusinessObjects;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Policies.PolicyNumbering;
using MgaSystems.IMS.Policies.WaivedPremiumDetail;
using MGASystems.IMS.Security;
using MGASystems.Tools;
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
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.BindPolicy;

[DesignerGenerated]
[SecureResource("{15C570A8-2D3D-4aa3-B88E-ACA661A123C2}", "Backdate Override", "Allows the user to override the maximum number of days coverage can be back-dated.", "Policy")]
public class frmBindPolicy : Form, ILoadAutomatically
{
  private IContainer components;
  private Label lblBindText;
  private Label Label2;
  private Label lblPremium;
  private Label Label1;
  private dsBindQuote ds;
  private SqlDataAdapter daQuoteDetails;
  private Label Label4;
  private Label Label6;
  private Label lblFees;
  private Label lblTotalPremium;
  private UltraGrid dgFees;
  private UltraGrid dgComm;
  private Label lblDebug;
  private UltraGroupBox ElipsePanel1;
  private SqlDataAdapter daLoadData;
  protected SqlCommand SqlSelectCommand1;
  private Label lblPolicyTerm;
  private SqlCommand SqlSelectCommand2;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  internal const string OverrideMaxBackdate = "{15C570A8-2D3D-4aa3-B88E-ACA661A123C2}";
  private const int PLEASE_WAIT_MINIMUM_SHOW_TIME = 1;
  private bool _debugMode;
  private string _debugText;
  private bool _magicMode;
  private readonly MGASystems.IMS.Policies.Invoices.Invoices _invoices;
  private readonly Queue _letterQueue;
  private readonly Quote _quote;
  private PolicyInfo _pi;
  private frmCreatingInvoicesPleaseWait _frmCreatingInvoicesPleaseWait;
  private DateTime _startBindTime;
  private readonly ArrayList _gridDataSources;
  private bool _acceptOnBackDateExceedDays;
  private readonly bool _blackBoxMode;
  private CultureInfo _cultureInfo;
  private string _costCenter;
  private readonly List<PolicyDetailInfo> _childLinePolicyInfo;
  private readonly object _detailLock;
  private const byte DOWNPAYMENT_TOO_SMALL = 41;
  private const byte TOO_MUCH_COMMISSION = 92;
  private const byte PAID_TOO_MUCH = 53;
  private const byte INCORRECT_DISTRIBUTIONS = 62;
  private const byte NO_COMPANY_LINE = 67;
  private const byte TOTALS_DO_NOT_MATCH = 111;
  private int retryCount;

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
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBindPolicy));
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblPolicyCommissions", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Entity");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ChargeName");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("EntityType");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Description");
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Percentage");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("FlatAmount");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance16 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("Fees", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ChargeName");
    Appearance appearance17 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Amount");
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("PayableEntity");
    Appearance appearance20 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ChargeCode");
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance24 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblQuoteOptions", -1);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("LineName");
    Appearance appearance25 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Premium");
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    this.btnYes = new MGAButton();
    this.btnNo = new MGAButton();
    this.lblBindText = new Label();
    this.cnSQL = new SqlConnection();
    this.Label2 = new Label();
    this.lblPremium = new Label();
    this.Label1 = new Label();
    this.daQuoteDetails = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand2 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.lblFees = new Label();
    this.Label4 = new Label();
    this.lblTotalPremium = new Label();
    this.Label6 = new Label();
    this.lblDebug = new Label();
    this.ElipsePanel1 = new UltraGroupBox();
    this.daLoadData = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.lblPolicyTerm = new Label();
    this.lblMagic = new Label();
    this.dgComm = new UltraGrid();
    this.ds = new dsBindQuote();
    this.dgFees = new UltraGrid();
    this.dgPremiums = new UltraGrid();
    ((ISupportInitialize) this.btnYes).BeginInit();
    ((ISupportInitialize) this.btnNo).BeginInit();
    ((ISupportInitialize) this.ElipsePanel1).BeginInit();
    ((Control) this.ElipsePanel1).SuspendLayout();
    ((ISupportInitialize) this.dgComm).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.dgFees).BeginInit();
    ((ISupportInitialize) this.dgPremiums).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnYes).Anchor = AnchorStyles.Bottom;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    ((ControlBase) this.btnYes).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnYes).Location = new Point(322, 517);
    ((Control) this.btnYes).Name = "btnYes";
    ((Control) this.btnYes).Size = new Size(63 /*0x3F*/, 28);
    ((Control) this.btnYes).TabIndex = 0;
    ((ControlBase) this.btnYes).Text = "&Yes";
    this.btnYes.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnNo).Anchor = AnchorStyles.Bottom;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    ((ControlBase) this.btnNo).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnNo).DialogResult = DialogResult.Cancel;
    ((Control) this.btnNo).Location = new Point(392, 517);
    ((Control) this.btnNo).Name = "btnNo";
    ((Control) this.btnNo).Size = new Size(63 /*0x3F*/, 28);
    ((Control) this.btnNo).TabIndex = 1;
    ((ControlBase) this.btnNo).Text = "&No";
    this.btnNo.UseOSThemes = (DefaultableBoolean) 2;
    this.lblBindText.Anchor = AnchorStyles.Bottom;
    this.lblBindText.Font = new Font("Tahoma", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblBindText.Location = new Point(56, 520);
    this.lblBindText.Name = "lblBindText";
    this.lblBindText.Size = new Size(250, 23);
    this.lblBindText.TabIndex = 2;
    this.lblBindText.Text = "Bind this policy?";
    this.lblBindText.TextAlign = ContentAlignment.MiddleRight;
    this.cnSQL.ConnectionString = "workstation id=ALIENWARE;packet size=4096;user id=mgasystems;data source=\"167.206.82.38\";persist security info=False;initial catalog=IMS";
    this.cnSQL.FireInfoMessageEventOnUserErrors = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(14, 14);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(98, 21);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Premium:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.lblPremium.BackColor = Color.Transparent;
    this.lblPremium.Font = new Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblPremium.Location = new Point(119, 13);
    this.lblPremium.Name = "lblPremium";
    this.lblPremium.Size = new Size(154, 23);
    this.lblPremium.TabIndex = 4;
    this.lblPremium.Text = "$0.00";
    this.lblPremium.TextAlign = ContentAlignment.MiddleLeft;
    this.Label1.Font = new Font("Tahoma", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(7, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(637, 21);
    this.Label1.TabIndex = 9;
    this.Label1.Text = "Pre-Bind Confirmation";
    this.Label1.TextAlign = ContentAlignment.BottomCenter;
    this.daQuoteDetails.DeleteCommand = this.SqlDeleteCommand1;
    this.daQuoteDetails.InsertCommand = this.SqlInsertCommand1;
    this.daQuoteDetails.SelectCommand = this.SqlSelectCommand2;
    this.daQuoteDetails.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteDetails", new DataColumnMapping[5]
      {
        new DataColumnMapping("QuoteGuid", "QuoteGuid"),
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("PolicyNumber", "PolicyNumber"),
        new DataColumnMapping("PolicyNumberIndex", "PolicyNumberIndex"),
        new DataColumnMapping("PolicyNumberRuleID", "PolicyNumberRuleID")
      })
    });
    this.daQuoteDetails.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblQuoteDetails WHERE (CompanyLineGuid = @Original_CompanyLineGuid) AND (QuoteGuid = @Original_QuoteGuid)";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteGuid", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid"),
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      new SqlParameter("@PolicyNumber", SqlDbType.VarChar, 20, "PolicyNumber"),
      new SqlParameter("@PolicyNumberIndex", SqlDbType.Int, 4, "PolicyNumberIndex"),
      new SqlParameter("@PolicyNumberRuleID", SqlDbType.SmallInt, 2, "PolicyNumberRuleID")
    });
    this.SqlSelectCommand2.CommandText = "SELECT QuoteGuid, CompanyLineGuid, PolicyNumber, PolicyNumberIndex, PolicyNumberRuleID FROM tblQuoteDetails WHERE (QuoteGuid = @QuoteGuid)";
    this.SqlSelectCommand2.Connection = this.cnSQL;
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid"),
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      new SqlParameter("@PolicyNumber", SqlDbType.VarChar, 20, "PolicyNumber"),
      new SqlParameter("@PolicyNumberIndex", SqlDbType.Int, 4, "PolicyNumberIndex"),
      new SqlParameter("@PolicyNumberRuleID", SqlDbType.SmallInt, 2, "PolicyNumberRuleID"),
      new SqlParameter("@Original_CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteGuid", DataRowVersion.Original, (object) null)
    });
    this.lblFees.BackColor = Color.Transparent;
    this.lblFees.Font = new Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblFees.Location = new Point(119, 35);
    this.lblFees.Name = "lblFees";
    this.lblFees.Size = new Size(154, 21);
    this.lblFees.TabIndex = 11;
    this.lblFees.Text = "$0.00";
    this.lblFees.TextAlign = ContentAlignment.MiddleLeft;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Font = new Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label4.Location = new Point(14, 35);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(98, 21);
    this.Label4.TabIndex = 10;
    this.Label4.Text = "+ Fees:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.lblTotalPremium.BackColor = Color.Transparent;
    this.lblTotalPremium.Font = new Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblTotalPremium.Location = new Point(119, 56);
    this.lblTotalPremium.Name = "lblTotalPremium";
    this.lblTotalPremium.Size = new Size(154, 21);
    this.lblTotalPremium.TabIndex = 13;
    this.lblTotalPremium.Text = "$0.00";
    this.lblTotalPremium.TextAlign = ContentAlignment.MiddleLeft;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Font = new Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label6.Location = new Point(14, 56);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(98, 21);
    this.Label6.TabIndex = 12;
    this.Label6.Text = "Total Premium:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.lblDebug.Anchor = AnchorStyles.Bottom;
    this.lblDebug.BackColor = Color.MistyRose;
    this.lblDebug.BorderStyle = BorderStyle.FixedSingle;
    this.lblDebug.Font = new Font("Tahoma", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblDebug.Location = new Point(588, 524);
    this.lblDebug.Name = "lblDebug";
    this.lblDebug.Size = new Size(56, 21);
    this.lblDebug.TabIndex = 19;
    this.lblDebug.Text = "DEBUG";
    this.lblDebug.TextAlign = ContentAlignment.MiddleCenter;
    this.lblDebug.Visible = false;
    ((Control) this.ElipsePanel1).Anchor = AnchorStyles.Bottom;
    appearance3.BackColor = Color.FromArgb(246, 250, 253);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ElipsePanel1.ContentAreaAppearance = (AppearanceBase) appearance3;
    ((Control) this.ElipsePanel1).Controls.Add((Control) this.Label6);
    ((Control) this.ElipsePanel1).Controls.Add((Control) this.lblTotalPremium);
    ((Control) this.ElipsePanel1).Controls.Add((Control) this.Label4);
    ((Control) this.ElipsePanel1).Controls.Add((Control) this.lblFees);
    ((Control) this.ElipsePanel1).Controls.Add((Control) this.Label2);
    ((Control) this.ElipsePanel1).Controls.Add((Control) this.lblPremium);
    ((Control) this.ElipsePanel1).Location = new Point(185, 419);
    ((Control) this.ElipsePanel1).Name = "ElipsePanel1";
    ((Control) this.ElipsePanel1).Size = new Size(280, 84);
    ((Control) this.ElipsePanel1).TabIndex = 21;
    this.daLoadData.SelectCommand = this.SqlSelectCommand1;
    this.daLoadData.TableMappings.AddRange(new DataTableMapping[5]
    {
      new DataTableMapping("Table", "spBindPolicyData", new DataColumnMapping[4]
      {
        new DataColumnMapping("CompanyCommission", "CompanyCommission"),
        new DataColumnMapping("ProducerCommission", "ProducerCommission"),
        new DataColumnMapping("Company", "Company"),
        new DataColumnMapping("Producer", "Producer")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[6]
      {
        new DataColumnMapping("Entity", "Entity"),
        new DataColumnMapping("ChargeName", "ChargeName"),
        new DataColumnMapping("EntityType", "EntityType"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("Percentage", "Percentage"),
        new DataColumnMapping("FlatAmount", "FlatAmount")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[2]
      {
        new DataColumnMapping("Amount", "Amount"),
        new DataColumnMapping("OptionFeeID", "OptionFeeID")
      }),
      new DataTableMapping("Table3", "Table3", new DataColumnMapping[3]
      {
        new DataColumnMapping("ChargeName", "ChargeName"),
        new DataColumnMapping("Amount", "Amount"),
        new DataColumnMapping("PayableEntity", "PayableEntity")
      }),
      new DataTableMapping("Table4", "Table4", new DataColumnMapping[2]
      {
        new DataColumnMapping("LineName", "LineName"),
        new DataColumnMapping("Premium", "Premium")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spBindPolicyData]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@quoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/)
    });
    this.lblPolicyTerm.Location = new Point(7, 30);
    this.lblPolicyTerm.Name = "lblPolicyTerm";
    this.lblPolicyTerm.Size = new Size(637, 23);
    this.lblPolicyTerm.TabIndex = 22;
    this.lblPolicyTerm.Text = "Policy Term: 4/1/05 to 9/1/05";
    this.lblPolicyTerm.TextAlign = ContentAlignment.MiddleCenter;
    this.lblMagic.Anchor = AnchorStyles.Bottom;
    this.lblMagic.BackColor = Color.MistyRose;
    this.lblMagic.BorderStyle = BorderStyle.FixedSingle;
    this.lblMagic.Font = new Font("Tahoma", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblMagic.Location = new Point(588, 503);
    this.lblMagic.Name = "lblMagic";
    this.lblMagic.Size = new Size(56, 21);
    this.lblMagic.TabIndex = 19;
    this.lblMagic.Text = "MAGIC";
    this.lblMagic.TextAlign = ContentAlignment.MiddleCenter;
    this.lblMagic.Visible = false;
    ((UltraGridBase) this.dgComm).DataSource = (object) this.ds.tblPolicyCommissions;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgComm).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dgComm).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 103;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Item";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 117;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Entity Type";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 110;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 110;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance9;
    ultraGridColumn5.Format = "p4";
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 89;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance11;
    ultraGridColumn6.Format = "c";
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Flat Amount";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 89;
    ultraGridBand1.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.dgComm).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgComm).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance13.BackColor = Color.LightSteelBlue;
    appearance13.FontData.SizeInPoints = 10f;
    appearance13.ForeColor = Color.Black;
    ((UltraGridBase) this.dgComm).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance14.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.MaxSelectedRows = 1;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance15.BackColor = Color.Transparent;
    appearance15.ForeColor = Color.Black;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance15;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgComm).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.dgComm).Location = new Point(7, 300);
    ((Control) this.dgComm).Name = "dgComm";
    ((Control) this.dgComm).Size = new Size(637, 110);
    ((Control) this.dgComm).TabIndex = 18;
    ((Control) this.dgComm).Text = "Commissionable Entities";
    ((UltraControlBase) this.dgComm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgComm).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsBindQuote";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.dgFees).DataSource = (object) this.ds.Fees;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgFees).DisplayLayout.Appearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.dgFees).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance17;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn7.Width = 223;
    ((AppearanceBase) appearance18).TextHAlignAsString = "Right";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance18;
    ultraGridColumn8.Format = "c";
    ((AppearanceBase) appearance19).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance19;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.Width = 185;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance20;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Payable To";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 2;
    ultraGridColumn9.Width = 227;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 3;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 69;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ultraGridBand2.Override.MinRowHeight = 20;
    ((UltraGridBase) this.dgFees).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgFees).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance21.BackColor = Color.LightSteelBlue;
    appearance21.FontData.SizeInPoints = 10f;
    appearance21.ForeColor = Color.Black;
    ((UltraGridBase) this.dgFees).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance22.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.MaxSelectedRows = 1;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance23.BackColor = Color.Transparent;
    appearance23.ForeColor = Color.Black;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance23;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgFees).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.dgFees).DisplayLayout.Scrollbars = (Scrollbars) 0;
    ((UltraGridBase) this.dgFees).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((Control) this.dgFees).Location = new Point(7, 180);
    ((Control) this.dgFees).Name = "dgFees";
    ((Control) this.dgFees).Size = new Size(637, 110);
    ((Control) this.dgFees).TabIndex = 15;
    ((Control) this.dgFees).Text = "Poilcy Fees";
    ((UltraControlBase) this.dgFees).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgFees).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgPremiums).DataSource = (object) this.ds.tblQuoteOptions;
    appearance24.BackColor = Color.White;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance24.ForeColor = Color.Black;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Appearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance25;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 0;
    ultraGridColumn11.Width = 350;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Right";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance26;
    ultraGridColumn12.Format = "c";
    ((AppearanceBase) appearance27).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance27;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 1;
    ultraGridColumn12.Width = 285;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn11,
      (object) ultraGridColumn12
    });
    ultraGridBand3.Override.MinRowHeight = 20;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dgPremiums).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance28.BackColor = Color.LightSteelBlue;
    appearance28.FontData.SizeInPoints = 10f;
    appearance28.ForeColor = Color.Black;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance29.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Override.MaxSelectedRows = 1;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance30.BackColor = Color.Transparent;
    appearance30.ForeColor = Color.Black;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance30;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Scrollbars = (Scrollbars) 0;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((Control) this.dgPremiums).Location = new Point(7, 60);
    ((Control) this.dgPremiums).Name = "dgPremiums";
    ((Control) this.dgPremiums).Size = new Size(637, 110);
    ((Control) this.dgPremiums).TabIndex = 17;
    ((Control) this.dgPremiums).Text = "Policy Premiums";
    ((UltraControlBase) this.dgPremiums).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgPremiums).UseOsThemes = (DefaultableBoolean) 2;
    this.AcceptButton = (IButtonControl) this.btnYes;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnNo;
    this.ClientSize = new Size(650, 553);
    this.Controls.Add((Control) this.lblPolicyTerm);
    this.Controls.Add((Control) this.ElipsePanel1);
    this.Controls.Add((Control) this.lblMagic);
    this.Controls.Add((Control) this.lblDebug);
    this.Controls.Add((Control) this.lblBindText);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnNo);
    this.Controls.Add((Control) this.btnYes);
    this.Controls.Add((Control) this.dgComm);
    this.Controls.Add((Control) this.dgFees);
    this.Controls.Add((Control) this.dgPremiums);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmBindPolicy);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Confirm Binding";
    ((ISupportInitialize) this.btnYes).EndInit();
    ((ISupportInitialize) this.btnNo).EndInit();
    ((ISupportInitialize) this.ElipsePanel1).EndInit();
    ((Control) this.ElipsePanel1).ResumeLayout(false);
    ((ISupportInitialize) this.dgComm).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.dgFees).EndInit();
    ((ISupportInitialize) this.dgPremiums).EndInit();
    this.ResumeLayout(false);
  }

  private virtual MGAButton btnYes
  {
    get => this._btnYes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnYes_Click);
      MGAButton btnYes1 = this._btnYes;
      if (btnYes1 != null)
        ((Control) btnYes1).Click -= eventHandler;
      this._btnYes = value;
      MGAButton btnYes2 = this._btnYes;
      if (btnYes2 == null)
        return;
      ((Control) btnYes2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnNo
  {
    get => this._btnNo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNo_Click);
      MGAButton btnNo1 = this._btnNo;
      if (btnNo1 != null)
        ((Control) btnNo1).Click -= eventHandler;
      this._btnNo = value;
      MGAButton btnNo2 = this._btnNo;
      if (btnNo2 == null)
        return;
      ((Control) btnNo2).Click += eventHandler;
    }
  }

  private virtual SqlConnection cnSQL
  {
    get => this._cnSQL;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      SqlInfoMessageEventHandler messageEventHandler = new SqlInfoMessageEventHandler(this.cnSQL_InfoMessage);
      SqlConnection cnSql1 = this._cnSQL;
      if (cnSql1 != null)
        cnSql1.InfoMessage -= messageEventHandler;
      this._cnSQL = value;
      SqlConnection cnSql2 = this._cnSQL;
      if (cnSql2 == null)
        return;
      cnSql2.InfoMessage += messageEventHandler;
    }
  }

  [field: AccessedThroughProperty("dgPremiums")]
  private virtual UltraGrid dgPremiums { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMagic")]
  private virtual Label lblMagic { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected frmBindPolicy()
  {
    this.KeyUp += new KeyEventHandler(this.frmBindPolicy_KeyUp);
    this._letterQueue = new Queue();
    this._gridDataSources = new ArrayList();
    this._costCenter = string.Empty;
    this._childLinePolicyInfo = new List<PolicyDetailInfo>();
    this._detailLock = RuntimeHelpers.GetObjectValue(new object());
    this.InitializeComponent();
  }

  public frmBindPolicy(Guid quoteGuid, MGASystems.IMS.Policies.Invoices.Invoices i)
    : this(quoteGuid, i, false)
  {
  }

  public frmBindPolicy(Guid quoteGuid, MGASystems.IMS.Policies.Invoices.Invoices i, bool blackBoxMode)
    : this()
  {
    this._blackBoxMode = blackBoxMode;
    this._quote = Quote.CreateNew(quoteGuid);
    this._invoices = i;
  }

  private void SetBindLabel()
  {
    string str = "Bind This ";
    if (this._quote.IsEndorsement)
      str = this._quote.QuoteStatus != 7 ? (this._quote.QuoteStatus != 8 ? "Endorsement?" : "Reinstatement?") : "Cancellation?";
    if (this._quote.IsImsRenewal)
      str = "Renewal?";
    else if (this._quote.IsImsRewrite)
      str = "Rewrite?";
    if (string.IsNullOrEmpty(str))
      return;
    this.lblBindText.Text = str;
  }

  protected bool BlackBoxMode => this._blackBoxMode;

  protected Quote Quote => this._quote;

  internal static void EnforceSingleFormInstance(int quoteID)
  {
    // ISSUE: variable of a compiler-generated type
    frmBindPolicy._Closure\u0024__70\u002D0 closure700_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmBindPolicy._Closure\u0024__70\u002D0 closure700_2 = new frmBindPolicy._Closure\u0024__70\u002D0(closure700_1);
    // ISSUE: reference to a compiler-generated field
    closure700_2.\u0024VB\u0024Local_quoteID = quoteID;
    try
    {
      if (!BindingProcessSettings.EnforceFormSingleInstance)
        return;
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated field
        foreach (Form form in MDIControls.Instance.MDIParent.MdiChildren.OfType<frmBindPolicy>().Where<frmBindPolicy>(closure700_2.\u0024I0 == null ? (closure700_2.\u0024I0 = new System.Func<frmBindPolicy, bool>(closure700_2._Lambda\u0024__0)) : closure700_2.\u0024I0))
          form.Close();
      }
      finally
      {
        IEnumerator<frmBindPolicy> enumerator;
        enumerator?.Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      MGASystems.Common.ErrorHandling.ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  virtual void ILoadAutomatically.LoadData()
  {
    this.cnSQL.ConnectionString = DefaultDatabase.ConnectionString;
    string str = DefaultDatabase.ExecuteScalar<string>("dbo.spGetCostCenterName", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid
    });
    if (!string.IsNullOrEmpty(str))
      this._costCenter = str;
    if (!this.BlackBoxMode)
    {
      try
      {
        foreach (Control control in this.Controls)
        {
          if (control is UltraGrid ultraGrid)
          {
            this._gridDataSources.Add(RuntimeHelpers.GetObjectValue(((UltraGridBase) ultraGrid).DataSource));
            ((UltraGridBase) ultraGrid).DataSource = (object) null;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      ((Control) this.btnNo).Enabled = false;
      ((Control) this.btnYes).Enabled = false;
      this.lblPolicyTerm.Text = $"Policy Term: {this._quote.EffectiveDate:d} to {this._quote.ExpirationDate:d}";
      Cursor.Current = MgaCursors.WaitCursor;
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedLoad));
    }
    else
      this.ThreadedLoad((object) null);
  }

  private void EnableYesButton()
  {
    ((Control) this.btnYes).Enabled = true;
    ((Control) this.btnNo).Enabled = true;
  }

  private void ThreadedLoad(object state)
  {
    if (this._quote.IsBound)
      throw new InvalidOperationException("This quote is already bound, this screen should not be accessible.");
    this.AutoApplyCommissions();
    SqlDataAdapter daLoadData = this.daLoadData;
    daLoadData.TableMappings.Clear();
    daLoadData.TableMappings.Add("Table", this.ds.PreBindShowCompanyProducerCommissions.TableName);
    daLoadData.TableMappings.Add("Table1", this.ds.tblPolicyCommissions.TableName);
    daLoadData.TableMappings.Add("Table2", this.ds.TransferFees.TableName);
    daLoadData.TableMappings.Add("Table3", this.ds.Fees.TableName);
    daLoadData.TableMappings.Add("Table4", this.ds.tblQuoteOptions.TableName);
    daLoadData.SelectCommand.Parameters["@quoteGuid"].Value = (object) this._quote.QuoteGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daLoadData, (DataSet) this.ds);
    this.daQuoteDetails.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quote.QuoteGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daQuoteDetails, (DataTable) this.ds.tblQuoteDetails);
    this.AddProducerCompanyCommissions();
    Decimal premium = DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, "SELECT ISNULL(Sum(Premium),0) FROM tblQuoteOptions WHERE QuoteGuid=@QG AND Bound=1", new object[2]
    {
      (object) "@QG",
      (object) this._quote.QuoteGuid
    });
    Decimal num = 0M;
    try
    {
      foreach (AccountingTransferInvoice invoice in (ArrayList) this._invoices)
      {
        try
        {
          foreach (Fee fee in (List<Fee>) invoice.Fees)
            num = Decimal.Add(num, fee.Amount);
        }
        finally
        {
          List<Fee>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (!this.BlackBoxMode)
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new frmBindPolicy.LoadCompleteHandler(this.LoadComplete), new object[2]
      {
        (object) premium,
        (object) num
      });
    else
      this.LoadComplete(premium, num);
  }

  public event frmBindPolicy.BindPolicyFormLoadCompleteEventHandler BindPolicyFormLoadComplete;

  private void LoadComplete(Decimal premium, Decimal totalFees)
  {
    if (this.BlackBoxMode)
      return;
    this._cultureInfo = MultiCurrencyUtilities.GetCultureInfo(Conversions.ToString(DefaultDatabase.ExecuteScalar(CommandType.Text, "Select dbo.GetQuoteCurrencyCode(@quoteId)", new object[2]
    {
      (object) "@QuoteId",
      (object) this._quote.QuoteID
    })));
    this.lblPremium.Text = premium.ToString("c", (IFormatProvider) this._cultureInfo);
    this.lblFees.Text = totalFees.ToString("c", (IFormatProvider) this._cultureInfo);
    this.lblTotalPremium.Text = Decimal.Add(premium, totalFees).ToString("c", (IFormatProvider) this._cultureInfo);
    frmBindPolicy.FormatLabel(this.lblPremium, this._cultureInfo);
    frmBindPolicy.FormatLabel(this.lblFees, this._cultureInfo);
    frmBindPolicy.FormatLabel(this.lblTotalPremium, this._cultureInfo);
    int index = 0;
    try
    {
      foreach (Control control in this.Controls)
      {
        if (control is UltraGrid ultraGrid)
        {
          ((UltraGridBase) ultraGrid).DataSource = RuntimeHelpers.GetObjectValue(this._gridDataSources[index]);
          ++index;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.LayoutForm();
    ((Control) this.btnYes).Enabled = true;
    ((Control) this.btnNo).Enabled = true;
    ((UltraGridBase) this.dgFees).DisplayLayout.Bands[0].Columns["Amount"].FormatInfo = (IFormatProvider) this._cultureInfo;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Bands[0].Columns["Premium"].FormatInfo = (IFormatProvider) this._cultureInfo;
    this.ds.tblQuoteOptions.Columns.Add("Cost Center", Type.GetType("System.String"));
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Bands[0].Columns["Cost Center"].Header.VisiblePosition = 1;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Bands[0].Columns["Cost Center"].Width = 300;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Bands[0].Columns["Premium"].Width = 185;
    ((UltraGridBase) this.dgPremiums).DisplayLayout.Bands[0].Columns["LineName"].Width = 400;
    ((UltraGridBase) this.dgPremiums).UpdateData();
    foreach (UltraGridRow row in ((UltraGridBase) this.dgPremiums).Rows)
      row.Cells["Cost Center"].Value = (object) this._costCenter;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("GetFeeRestrictionsPerUser", new object[6]
    {
      (object) "@WholePolicy",
      (object) false,
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid,
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    if (dataTable.Rows.Count > 0)
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.dgFees).Rows)
      {
        if (row.Cells["ChargeCode"].Value != DBNull.Value && row.Cells["ChargeCode"].Value != null && dataTable.Select("ChargeCode=" + row.Cells["ChargeCode"].Value.ToString()).Length > 0)
          row.Hidden = true;
      }
    }
    // ISSUE: reference to a compiler-generated field
    frmBindPolicy.BindPolicyFormLoadCompleteEventHandler loadCompleteEvent = this.BindPolicyFormLoadCompleteEvent;
    if (loadCompleteEvent == null)
      return;
    loadCompleteEvent((object) this, new EventArgs());
  }

  protected DialogResult ShowMessage(
    string message,
    string caption,
    MessageBoxButtons buttons,
    MessageBoxIcon icon)
  {
    if (this._blackBoxMode)
      throw new InvalidOperationException(message);
    DialogResult dialogResult;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new frmBindPolicy.ShowMessageHandler(this.ShowMessage), new object[4]
      {
        (object) message,
        (object) caption,
        (object) buttons,
        (object) icon
      });
    else
      dialogResult = MessageBox.Show(message, caption, buttons, icon);
    return dialogResult;
  }

  private void HandleError(Exception ex)
  {
    if (!this._blackBoxMode && MDIControls.Instance.MDIParent.InvokeRequired)
    {
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new frmBindPolicy.ErrorHandler(this.HandleError), new object[1]
      {
        (object) ex
      });
    }
    else
    {
      this.HidePleaseWaitForm();
      SqlException sqlException = ex as SqlException;
      if (!this._blackBoxMode && this._debugMode)
      {
        if (sqlException != null)
          this._debugText = $"ERROR\nProcedure: {sqlException.Procedure}\nLine #: {sqlException.LineNumber.ToString()}\n\n{this._debugText}";
        // ISSUE: variable of a reference type
        string& local;
        // ISSUE: explicit reference operation
        string str = $"{^(local = ref this._debugText)}\n{ex.Message}";
        local = str;
        using (frmBindPolicyDebugInfo bindPolicyDebugInfo = new frmBindPolicyDebugInfo(this._debugText))
        {
          int num = (int) bindPolicyDebugInfo.ShowDialog();
        }
      }
      bool flag = false;
      if (sqlException != null)
      {
        flag = true;
        switch (sqlException.State)
        {
          case 41:
            int num1 = (int) this.ShowMessage($"The downpayment on this policy is too small, and would result in premium{"\n"}items or fees to proportionally reduced to $0 on this invoice.{"\n"}{"\n"}Please increase the size of the downpayment before binding this policy.", "Invalid Downpayment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;
          case 53:
            int num2 = (int) this.ShowMessage($"The amount paid out exceeds the policy total.{"\n"}{"\n"}Please double-check all commissions on the policy to ensure they are correct.", "Unable to Bind - Payouts Exceed Policy Total", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;
          case 62:
            if (sqlException.Message.StartsWith("Could not find"))
            {
              flag = false;
              break;
            }
            int num3 = (int) this.ShowMessage($"The distributions on this invoice are invalid.{"\n"}{"\n"}Please double-check all commissions on the policy to ensure they are correct.", "Unable to Bind - Invalid Commissions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;
          case 67:
            int num4 = (int) this.ShowMessage($"No company/line setup found for one or more items.{"\n"}{"\n"}Please double-check a company/line setup exists for all premiums and fees on the policy.", "Unable to Bind - Invalid Company/Line", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;
          case 92:
            int num5 = (int) this.ShowMessage($"The amount paid on commissions exceeds the policy total.{"\n"}{"\n"}Please double-check all commissions on the policy to ensure they are correct.", "Unable to Bind - Invalid Commissions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;
          case 111:
            int num6 = (int) this.ShowMessage(ex.Message, "Fee Totals Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            flag = false;
            break;
          default:
            if (ex.Message.Contains("NULL AmtBilled") && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sqlException.Procedure, "spAccountingTransfer_VerifyPremiumsTransferred", false) == 0)
            {
              int num7 = (int) this.ShowMessage($"The system could not bind this policy.{"\n"}{"\n"}Please ensure that the policy is properly configured.", "Unable to Bind - Invalid Setup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              break;
            }
            if (sqlException.Message.Contains("tblInvoiceFees_PK"))
            {
              string str = sqlException.Procedure.IndexOf("Fees", StringComparison.InvariantCultureIgnoreCase) > -1 ? "Fees" : "Premiums";
              int num8 = (int) this.ShowMessage($"The system could not bind this policy.{"\n"}{"\n"}Duplicate {str.ToLower()} were detected.", $"Unable To Bind - Duplicate {str}", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              break;
            }
            if (sqlException.Message.Contains("PK_tblFin_InvoiceExtPayees"))
            {
              int num9 = (int) this.ShowMessage($"The system could not create an invoice due to duplicate payees being detected.{"\n"}{"\n"}Please verify that the commission setup on the policy is valid.", "Unable to Bind - Duplicate Invoice Payee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              break;
            }
            if (sqlException.Message.Contains("chkInvoiceDetailsPercentages"))
            {
              int num10 = (int) this.ShowMessage("The system could not create an invoice due to incorrect invoice percentages.{vbLf}{vbLf}Please verify that the commission and installment setups on the policy are valid.", "Unable to Bind - Incorrect Invoice Percentages", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              break;
            }
            if (sqlException.Message.Contains("expects parameter '@BillingCode'"))
            {
              int num11 = (int) this.ShowMessage($"The system could not resolve the billing type used on the policy.{"\n"}{"\n"}Please ensure custom billing types are setup correctly and are implemented in the accounting transfer process (contact techsupport@mgasystems.com).", "Unable to Bind - Billing Type Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              flag = false;
              break;
            }
            if (sqlException.Procedure.Equals("Insert_CheckCostCenter", StringComparison.CurrentCultureIgnoreCase))
            {
              int num12 = (int) this.ShowMessage($"The cost center does not belong to the specified office.{"\n"}{"\n"}Please edit the Quote to update the Cost Center to match the issuing office.", "Unable to Bind - Cost Center Mismatch Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              flag = false;
              break;
            }
            flag = false;
            break;
        }
      }
      else if (ex is NoInvoiceDetailItemsCreatedException && !this.BlackBoxMode)
      {
        if (this.ShowMessage($"{$"No invoices were created.{"\n"}Please ensure that the billing setup on this policy is correct.{"\n"}"}{$"Certain invalid setups, such as billing a non-commissionable fee on a direct-bill policy, may result in this scenario.{"\n"}{"\n"}"}Would you Like to bind this policy without creating invoices?", "No Invoices Created", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        {
          this._quote.BindWithZeroPremium(CurrentUser.Instance.UserID);
          CurrentUser.Instance.LogAction("Accepted bind with no invoices.", this._quote.QuoteGuid);
          this.ClientChangeStatusReason();
          try
          {
            DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, etea) =>
            {
              if (!this.UpdatePolicyNumber())
                return;
              etea.Transaction.Commit();
            }));
            this.UpdateForms();
          }
          catch (Exception ex1)
          {
            ProjectData.SetProjectError(ex1);
            MGASystems.Common.ErrorHandling.ErrorHandler.HandleError(ex1);
            ProjectData.ClearProjectError();
          }
        }
        flag = true;
      }
      if (flag && !this._blackBoxMode)
      {
        MDIControls.Instance.MDIParent.Refresh();
        this.Close();
      }
      else if (this.BlackBoxMode)
        ExceptionDispatchInfo.Capture(ex).Throw();
      else
        MGASystems.Common.ErrorHandling.ErrorHandler.HandleError(ex);
    }
  }

  private void PolicyBound(List<int> officeInvoiceNumbers, List<int> invoiceNumbers)
  {
    this.Close();
    MDIControls.Instance.MDIParent.Refresh();
    Form formEx = ObjectFactory.Instance.CreateFormEX(typeof (frmBinderConfirmation), new object[2]
    {
      (object) this._quote.QuoteGuid,
      (object) invoiceNumbers
    });
    formEx.StartPosition = FormStartPosition.CenterScreen;
    formEx.MdiParent = MDIControls.Instance.MDIParent;
    formEx.Show();
    formEx.BringToFront();
    this.UpdateForms();
    this._quote.ResetQuoteStatus();
    this._quote.SendPostBinderBroadcastMessages();
  }

  private void UpdateForms()
  {
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      switch (mdiChildren[index])
      {
        case frmClearance frmClearance:
          if (SystemSettings.GetSetting<bool>("Policy.Bind.KeepClearanceForm.Open", false))
          {
            frmClearance.UpdateQuote(this._quote.QuoteGuid);
            break;
          }
          frmClearance.Close();
          break;
        case frmPolicyDetail frmPolicyDetail:
          if (frmPolicyDetail.Quote.QuoteGuid.Equals(this._quote.QuoteGuid))
          {
            frmPolicyDetail.RefreshPolicyData();
            break;
          }
          break;
      }
      checked { ++index; }
    }
  }

  private void HidePleaseWaitForm()
  {
    if (this._blackBoxMode || this._frmCreatingInvoicesPleaseWait == null || !this._frmCreatingInvoicesPleaseWait.Visible)
      return;
    if (this._frmCreatingInvoicesPleaseWait != null && this._frmCreatingInvoicesPleaseWait.IsHandleCreated)
    {
      this._frmCreatingInvoicesPleaseWait.Dispose();
      this._frmCreatingInvoicesPleaseWait = (frmCreatingInvoicesPleaseWait) null;
    }
    MDIControls.Instance.MDIParent.Refresh();
  }

  private bool UpdatePolicyNumber() => this.UpdatePolicyNumber(this._pi);

  protected virtual bool UpdatePolicyNumber(PolicyInfo polNumber)
  {
    bool flag1 = false;
    int? nullable1 = polNumber?.PolicyNumberRuleID;
    bool flag2;
    if (!this._quote.IsEndorsement && polNumber != null)
    {
      int? nullable2 = nullable1;
      if ((nullable2.HasValue ? new bool?(nullable2.GetValueOrDefault() == 0) : new bool?()).GetValueOrDefault())
        nullable1 = new int?();
      else if (!this._quote.IsRenewal)
        flag1 = true;
      try
      {
        if (DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuotes SET PolicyNumberRuleID = @polRuleID, PolicyNumber=@polNumber, PolicyNumberIndex=@polNumberIndex WHERE QuoteGuid=@quoteGuid", new object[8]
        {
          (object) "@polRuleID",
          (object) nullable1,
          (object) "@polNumber",
          (object) polNumber.PolicyNumber,
          (object) "@polNumberIndex",
          (object) polNumber.PolicyIndex,
          (object) "@quoteGuid",
          (object) this._quote.QuoteGuid
        }) == 0)
          throw new InvalidOperationException("Could not update the policy number when binding the policy - no rows affected.");
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        SqlException sqlException = ex;
        if (sqlException.State == (byte) 123 || StringExtensions.ContainsNoCase(sqlException.Message, "BlockDuplicateCompanyLinePolicyNumber"))
        {
          this.HidePleaseWaitFormOnThread();
          int num = (int) this.ShowMessage(sqlException.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag2 = false;
          ProjectData.ClearProjectError();
          goto label_17;
        }
        throw;
      }
    }
    if (flag1 && !this._quote.IsImsRewrite)
    {
      if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM dbo.tblQuotes WITH(NOLOCK) WHERE PolicyNumberRuleID = @ruleId AND PolicyNumber = @polNumber AND PolicyNumberIndex = @polIndex", new object[6]
      {
        (object) "@ruleId",
        (object) nullable1,
        (object) "@polNumber",
        (object) polNumber.PolicyNumber,
        (object) "@polIndex",
        (object) polNumber.PolicyIndex
      }) != 1 && this._quote.CompanyLine.EnforceUniquePolicyNumbers)
        throw new DuplicatePolicyNumberException();
    }
    if (polNumber != null && polNumber.TableBasedPolicyNumber != null)
      DefaultDatabase.ExecuteNonQuery("dbo.spPolicyNumberingSetTablePolicyNumberToUsed", new object[8]
      {
        (object) "@QuoteGuid",
        (object) this._quote.QuoteGuid,
        (object) "@PolicyNumberRuleId",
        (object) nullable1,
        (object) "@ActualPolicyNumber",
        (object) polNumber.PolicyNumber,
        (object) "@TableBasedPolicyNumber",
        (object) polNumber.TableBasedPolicyNumber
      });
    flag2 = true;
label_17:
    return flag2;
  }

  private void HidePleaseWaitFormOnThread()
  {
    while (!this._debugMode && (DateAndTime.Now - this._startBindTime).TotalSeconds < 1.0)
      Thread.Sleep(1000);
    try
    {
      MDIControls.Instance.MDIParent.BeginInvoke((Delegate) new frmBindPolicy.HidePleaseWaitFormHandler(this.HidePleaseWaitForm));
    }
    catch (InvalidOperationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void PostInvoicesThread()
  {
    // ISSUE: variable of a compiler-generated type
    frmBindPolicy._Closure\u0024__101\u002D0 closure1010_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmBindPolicy._Closure\u0024__101\u002D0 closure1010_2 = new frmBindPolicy._Closure\u0024__101\u002D0(closure1010_1);
    // ISSUE: reference to a compiler-generated field
    closure1010_2.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure1010_2.\u0024VB\u0024Local_trans = (SqlTransaction) null;
    // ISSUE: reference to a compiler-generated field
    closure1010_2.\u0024VB\u0024Local_accountingTrans = (MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer) null;
    // ISSUE: reference to a compiler-generated field
    closure1010_2.\u0024VB\u0024Local_completed = false;
    // ISSUE: reference to a compiler-generated field
    closure1010_2.\u0024VB\u0024Local_policyCancelWashAll = SystemSettings.GetLazySetting<bool>("PolicyCancelWashAll", false, true);
    // ISSUE: reference to a compiler-generated field
    closure1010_2.\u0024VB\u0024Local_policyCancelWashFlat = SystemSettings.GetLazySetting<bool>("PolicyCancelWashFlat", false, true);
    // ISSUE: reference to a compiler-generated field
    closure1010_2.\u0024VB\u0024Local_policyEndorsementWashAll = SystemSettings.GetLazySetting<bool>("PolicyEndorsementWashAll", false, true);
    // ISSUE: reference to a compiler-generated field
    closure1010_2.\u0024VB\u0024Local_policyCancelSproc = SystemSettings.GetLazySetting<string>("PolicyCancelWashProcedure", "dbo.spFin_CancelPolicy", true);
    this.retryCount = 0;
    // ISSUE: reference to a compiler-generated field
    while (!closure1010_2.\u0024VB\u0024Local_completed && this.retryCount < 3)
    {
      this._debugText = string.Empty;
      try
      {
        // ISSUE: reference to a compiler-generated method
        DefaultDatabase.ExecuteTransaction(IsolationLevel.ReadCommitted, new EventHandler<ExecuteTransactionEventArgs>(closure1010_2._Lambda\u0024__0), (object) null, new SqlInfoMessageEventHandler(this.cnSQL_InfoMessage), false);
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        // ISSUE: reference to a compiler-generated field
        if (closure1010_2.\u0024VB\u0024Local_accountingTrans != null)
        {
          // ISSUE: reference to a compiler-generated field
          closure1010_2.\u0024VB\u0024Local_accountingTrans.Dispose();
        }
        if (this.retryCount < 3 && Utility.IsRetryableException(ex2))
        {
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = ^(local = ref this.retryCount) + 1;
          local = num;
          ProjectData.ClearProjectError();
        }
        else
        {
          if (!this.Disposing && !this.IsDisposed)
          {
            if (ex2.Message.Contains("spAccountingTransfer_VerifyPremiumsTransferred"))
            {
              int num = (int) this.ShowMessage("No company/line setup exists for a premium item on this policy.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
              this.HandleError(ex2);
          }
          InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new frmBindPolicy.EnableYesButtonHandler(this.EnableYesButton), new object[0]);
          MDIControls.Instance.MDIParent.BeginInvoke((Delegate) new frmBindPolicy.HidePleaseWaitFormHandler(this.HidePleaseWaitForm));
          ProjectData.ClearProjectError();
          return;
        }
      }
    }
    try
    {
      ((BaseDataObject) this._quote).RefreshData();
      if (this._quote.IsEndorsement)
        CurrentUser.Instance.LogAction($"Bound Endorsement - Policy #{this._quote.PolicyNumber}. Cost center - {this._costCenter}", this._quote.QuoteGuid);
      else
        CurrentUser.Instance.LogAction($"Bound Policy #{this._pi?.PolicyNumber ?? this._quote.PolicyNumber}. Cost Center - {this._costCenter}", this._quote.QuoteGuid);
      if (!this.BlackBoxMode)
      {
        this.HidePleaseWaitFormOnThread();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        MDIControls.Instance?.MDIParent?.BeginInvoke((Delegate) new frmBindPolicy.PolicyBoundHandler(this.PolicyBound), (object) closure1010_2.\u0024VB\u0024Local_accountingTrans.OfficeInvoiceNumbers, (object) closure1010_2.\u0024VB\u0024Local_accountingTrans.InvoicesNumbers);
      }
    }
    catch (InvalidOperationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MGASystems.Common.ErrorHandling.ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
      ProjectData.ClearProjectError();
    }
    try
    {
      ObjectFactory.Instance.CreateObjectAs<BindPolicyExtendedWork>(new object[1]
      {
        (object) this._quote
      }).BG_DoExtendedWork();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      MGASystems.Common.ErrorHandling.ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
      ProjectData.ClearProjectError();
    }
  }

  private static void FormatLabel(Label lbl, CultureInfo ci)
  {
    Decimal result;
    if (!Decimal.TryParse(lbl.Text, NumberStyles.Any, (IFormatProvider) ci, out result))
      return;
    switch (Math.Sign(result))
    {
      case -1:
        lbl.ForeColor = Color.Red;
        break;
      case 1:
        lbl.ForeColor = Color.FromArgb(0, 192 /*0xC0*/, 0);
        break;
      default:
        lbl.ForeColor = Color.Black;
        break;
    }
  }

  private void LayoutForm()
  {
    this.SuspendLayout();
    try
    {
      foreach (UltraGrid ultraGrid1 in this.Controls.OfType<UltraGrid>())
      {
        ((UltraGridBase) ultraGrid1).DisplayLayout.Scrollbars = (Scrollbars) 0;
        if (((UltraGridBase) ultraGrid1).Rows.Count == 0)
          ((Control) ultraGrid1).Height = 0;
        else
          ((Control) ultraGrid1).Height = ((UltraGridBase) ultraGrid1).Rows[0].Height * ((UltraGridBase) ultraGrid1).Rows.Count;
        if (((Control) ultraGrid1).Height > 0)
        {
          UltraGrid ultraGrid2;
          int num = ((Control) (ultraGrid2 = ultraGrid1)).Height + (((UltraGridBase) ultraGrid1).Rows[0].Height * 2 + 20);
          ((Control) ultraGrid2).Height = num;
        }
        if (((Control) ultraGrid1).Height > 230)
        {
          ((Control) ultraGrid1).Height = 230;
          ((UltraGridBase) ultraGrid1).DisplayLayout.Scrollbars = (Scrollbars) 2;
        }
      }
    }
    finally
    {
      IEnumerator<UltraGrid> enumerator;
      enumerator?.Dispose();
    }
    if (!SecurityManager.Instance.AssertPermission("{9AEB647B-3105-4a79-ADB5-20C248C70D7E}"))
      ((Control) this.dgComm).Height = 0;
    ((Control) this.dgFees).Top = ((Control) this.dgPremiums).Bottom + 10;
    ((Control) this.dgComm).Top = ((Control) this.dgFees).Bottom + 10;
    this.Height = ((Control) this.dgComm).Bottom + 177;
    this.ResumeLayout();
  }

  private void AutoApplyCommissions()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT QuoteOptionGuid FROM tblQuoteOptions WHERE QuoteGuid=@QG AND Bound=1", new object[2]
    {
      (object) "@QG",
      (object) this._quote.QuoteGuid
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
        new QuoteOption((Guid) row[0]).AutoApplyCommissions();
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void cnSQL_InfoMessage(object sender, SqlInfoMessageEventArgs e)
  {
    if (e.Errors[0].State == (byte) 50)
    {
      if (this.BlackBoxMode)
        return;
      if (MDIControls.Instance.MDIParent.InvokeRequired)
      {
        InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new SqlInfoMessageEventHandler(this.cnSQL_InfoMessage), new object[2]
        {
          sender,
          (object) e
        });
      }
      else
      {
        frmCreatingInvoicesPleaseWait invoicesPleaseWait = this._frmCreatingInvoicesPleaseWait;
        invoicesPleaseWait.SetText(e.Message);
        invoicesPleaseWait.MoveProgress();
      }
    }
    else
    {
      // ISSUE: variable of a reference type
      string& local;
      // ISSUE: explicit reference operation
      string str = ^(local = ref this._debugText) + e.Message;
      local = str;
    }
  }

  private void btnYes_Click(object sender, EventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      this.BindPolicy();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void btnNo_Click(object sender, EventArgs e) => this.Close();

  private void AddProducerCompanyCommissions()
  {
    try
    {
      foreach (dsBindQuote.PreBindShowCompanyProducerCommissionsRow producerCommission in (TypedTableBase<dsBindQuote.PreBindShowCompanyProducerCommissionsRow>) this.ds.PreBindShowCompanyProducerCommissions)
      {
        dsBindQuote.tblPolicyCommissionsRow row1 = this.ds.tblPolicyCommissions.NewtblPolicyCommissionsRow();
        dsBindQuote.tblPolicyCommissionsRow policyCommissionsRow1 = row1;
        policyCommissionsRow1.Entity = producerCommission.Company;
        policyCommissionsRow1.Description = "Company Commission";
        policyCommissionsRow1.Percentage = producerCommission.CompanyCommission;
        this.ds.tblPolicyCommissions.AddtblPolicyCommissionsRow(row1);
        dsBindQuote.tblPolicyCommissionsRow row2 = this.ds.tblPolicyCommissions.NewtblPolicyCommissionsRow();
        dsBindQuote.tblPolicyCommissionsRow policyCommissionsRow2 = row2;
        policyCommissionsRow2.Entity = producerCommission.Producer;
        policyCommissionsRow2.Description = "Producer Commission";
        policyCommissionsRow2.Percentage = producerCommission.ProducerCommission;
        this.ds.tblPolicyCommissions.AddtblPolicyCommissionsRow(row2);
      }
    }
    finally
    {
      IEnumerator<dsBindQuote.PreBindShowCompanyProducerCommissionsRow> enumerator;
      enumerator?.Dispose();
    }
  }

  protected virtual bool ValidateFees(AccountingTransferInvoice inv)
  {
    bool flag;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(inv.BillingCode, "DBCOM", false) == 0)
    {
      try
      {
        foreach (Fee fee in (List<Fee>) inv.Fees)
        {
          if (fee.FeeType == 2)
          {
            int num = (int) this.ShowMessage("Agency fees are not allowed on the Direct Bill portion of the invoices.\n\nRejected Fee: " + fee.ChargeName, "Invalid Agency Fees", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            flag = false;
            goto label_7;
          }
        }
      }
      finally
      {
        List<Fee>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    flag = true;
label_7:
    return flag;
  }

  protected virtual bool ClientReadyToBind(Guid quoteGuid) => true;

  private bool ReadyToBind()
  {
    bool bind;
    if (this._quote.IsBound)
    {
      int num = (int) this.ShowMessage("This policy is already bound.", "Policy Bound", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      bind = false;
    }
    else
    {
      try
      {
        foreach (AccountingTransferInvoice invoice in (ArrayList) this._invoices)
        {
          if (!this.ValidateFees(invoice))
          {
            bind = false;
            goto label_31;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      DateTime dateTime = DefaultDatabase.ExecuteScalar<DateTime>(CommandType.Text, "SELECT GETDATE()");
      if (!this._quote.IsEndorsement && DateTime.Compare(this._quote.EffectiveDate.Date, dateTime.Date) < 0)
      {
        object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT MaxBackdateDays FROM tblCompanyLines WHERE CompanyLineGuid=@CLG", new object[2]
        {
          (object) "@CLG",
          (object) this._quote.CompanyLineGuid
        }));
        if (objectValue != DBNull.Value && dateTime.Subtract(this._quote.EffectiveDate).Days > Conversions.ToInteger(objectValue))
        {
          if (SecurityManager.Instance.AssertPermission("{15C570A8-2D3D-4aa3-B88E-ACA661A123C2}"))
          {
            string empty = string.Empty;
            if (this.ShowMessage(this.BlackBoxMode ? $"Effective date exceeds the maximum backdate allowance ({objectValue.ToString()} days) for this company/line setup." : $"Effective date exceeds the maximum backdate allowance ({objectValue.ToString()} days) for this company/line setup.\n\nAre you sure you want to bind coverage?", "Backdate Coverage?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
              bind = false;
              goto label_31;
            }
            this._acceptOnBackDateExceedDays = true;
          }
          else
          {
            int num = (int) this.ShowMessage($"Can not backdate coverage more than {objectValue.ToString()} days for this company/line setup.", "Unable to Backdate Coverage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            bind = false;
            goto label_31;
          }
        }
      }
      if (this._quote.IsEndorsement)
      {
        if (this._quote.QuoteStatus == 7 && Decimal.Compare(this._quote.Premium, 0M) > 0)
        {
          bool flag = false;
          if (SystemSettings.GetSetting<bool>("AllowPositivePremiumsOnCancellation", false))
            flag = true;
          if (!flag)
          {
            int num = (int) this.ShowMessage("Cancellation endorsements must carry a negative premium amount.", "Negative Premium Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            bind = false;
            goto label_31;
          }
        }
        if (Convert.ToDouble(Decimal.Add(this._quote.AggregatePremium, this._quote.AggregateFees)) == 0.0 && this._quote.QuoteStatus != 7 && (!this._blackBoxMode || !SystemSettings.GetSetting<bool>("InstallmentBilling.BlackBox.AllowZeroInvoices", false)) && this.ShowMessage("This endorsement results in an aggregate premium of $0.00 for this policy,\nand is not a cancellation endorsement.\n\nAre you sure you want to bind this endorsement?", "Aggregate Premium is $0", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
        {
          bind = false;
          goto label_31;
        }
      }
      if (!this.ValidateFinalBindConformationRequirements())
      {
        bind = false;
      }
      else
      {
        bool isEndorsement = this._quote.IsEndorsement;
        bool setting = SystemSettings.GetSetting<bool>("AllowWaivedPremiumOnOrigTransaction", false);
        if (!this._blackBoxMode && isEndorsement || !this._blackBoxMode && setting && !isEndorsement)
        {
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM dbo.tblDetailWaivedPremium WHERE QuoteGuid = @QG", new object[2]
          {
            (object) "@QG",
            (object) this._quote.QuoteGuid
          });
          DataTable dt = DefaultDatabase.ExecuteDataTable("WaivePremiumByDetailLinesData", new object[2]
          {
            (object) "@QuoteGuid",
            (object) this._quote.QuoteGuid
          });
          if (dt.Rows.Count > 0 && SystemSettings.GetSetting<bool>("WaivedPremiumOnDetailLines", false))
            this.WaivePremiumByDetailLines(dt);
          else
            this.WaivePremium(setting);
        }
        bind = this.ClientReadyToBind(this._quote.QuoteGuid);
      }
    }
label_31:
    return bind;
  }

  private bool ValidateFinalBindConformationRequirements()
  {
    int quoteStatusID = SystemSettings.GetSetting<int?>("FinalBindConformationStatusID", new int?()) ?? -1;
    bool flag;
    if (quoteStatusID == -1)
    {
      flag = true;
    }
    else
    {
      object objectValue = RuntimeHelpers.GetObjectValue(new Quote(this._quote.QuoteGuid).ChangeStatusRequirements(quoteStatusID));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
      {
        int num = (int) MessageBox.Show(objectValue.ToString(), "Company/line Final Bind Conformation Requirements Not Satisfied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
      }
      else
        flag = true;
    }
    return flag;
  }

  protected virtual bool PromptWaivePremium(Decimal addlPrem, Decimal tmpWaivedPremium)
  {
    Decimal? setting = SystemSettings.GetSetting<Decimal?>("WaivedPremium", new Decimal?());
    bool flag;
    if (!setting.HasValue)
    {
      flag = false;
    }
    else
    {
      tmpWaivedPremium = setting.Value;
      flag = Decimal.Compare(addlPrem, Decimal.Multiply(-1M, tmpWaivedPremium)) > 0 && Decimal.Compare(addlPrem, tmpWaivedPremium) < 0;
    }
    return flag;
  }

  protected virtual bool PromptWaivePremiumUsingCompanyLine(Decimal addlPrem)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "Select MinWaivePremium, MaxWaivePremium FROM tblCompanyLines With (NOLOCK) WHERE CompanyLineGuid = @CLG", new object[2]
    {
      (object) "@CLG",
      (object) this._quote.CompanyLineGuid
    });
    bool flag;
    if (dataRow == null)
      flag = false;
    else if (dataRow[0] != DBNull.Value)
    {
      int integer1 = Conversions.ToInteger(dataRow[0]);
      if (dataRow[1] != DBNull.Value)
      {
        int integer2 = Conversions.ToInteger(dataRow[1]);
        flag = Decimal.Compare(addlPrem, new Decimal(integer1)) > 0 && Decimal.Compare(addlPrem, new Decimal(integer2)) < 0;
      }
      else
        flag = false;
    }
    else
      flag = false;
    return flag;
  }

  private void WaivePremium(bool waivePremOnOrigTrans)
  {
    if ((this._blackBoxMode || !this._quote.IsEndorsement) && (this._blackBoxMode || !waivePremOnOrigTrans || this._quote.IsEndorsement))
      return;
    bool flag = false;
    if (this._quote.CompanyLine.WaivePremium)
    {
      Decimal addlPrem = DefaultDatabase.ExecuteScalar<Decimal>("GetAdditionalPremium", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quote.QuoteGuid
      });
      Decimal tmpWaivedPremium = 0M;
      if (this.PromptWaivePremium(addlPrem, tmpWaivedPremium) || this.PromptWaivePremiumUsingCompanyLine(addlPrem))
      {
        string str;
        if (MessageBox.Show($"Additional Premium Of {addlPrem.ToString("c")} Is found On this policy.\n\nWaive Premium?", "Waive Premium?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          flag = true;
          str = $"Waived premium For control # {this._quote.ControlNo.ToString()}. Quote's Premium = {addlPrem.ToString("c")}";
        }
        else
        {
          flag = false;
          str = $"Not accept waived premium for control # {this._quote.ControlNo.ToString()}. Quote's Premium = {addlPrem.ToString("c")}";
        }
        CurrentUser.Instance.LogAction(str, this._quote.QuoteGuid);
      }
    }
    DefaultDatabase.ExecuteNonQuery("UpdateWaivePremiumPolicyData", new object[4]
    {
      (object) "@QuoteID",
      (object) this._quote.QuoteID,
      (object) "@WaivedOriginalPremium",
      (object) flag
    });
  }

  private void GetManualPolicyNumber(PolicyInfo pol, int ruleID)
  {
    using (frmPolicyNumberEntry formEx = (frmPolicyNumberEntry) ObjectFactory.Instance.CreateFormEX(typeof (frmPolicyNumberEntry), new object[1]
    {
      (object) this._quote.CompanyLineGuid
    }))
    {
      if (this._quote.HasPolicyNumber)
        formEx.PolicyNumber = this._quote.PolicyNumber;
      formEx.PolicyNumberID = ruleID;
      int num = (int) formEx.ShowDialog();
      MDIControls.Instance.MDIParent.Refresh();
      if (formEx.ClickedCancel)
      {
        this.Close();
      }
      else
      {
        pol.PolicyNumber = formEx.PolicyNumber;
        pol.PolicyIndex = 0;
      }
    }
  }

  private void GetManualPolicyNumber(dsBindQuote.tblQuoteDetailsRow dr, int ruleID)
  {
    frmPolicyNumberEntry formEx = (frmPolicyNumberEntry) ObjectFactory.Instance.CreateFormEX(typeof (frmPolicyNumberEntry), new object[1]
    {
      (object) dr.CompanyLineGuid
    });
    try
    {
      if (!dr.IsPolicyNumberNull())
        formEx.PolicyNumber = dr.PolicyNumber;
      formEx.PolicyNumberID = ruleID;
      int num = (int) formEx.ShowDialog();
      MDIControls.Instance.MDIParent.Refresh();
      if (formEx.ClickedCancel)
      {
        this.Close();
      }
      else
      {
        dr.PolicyNumber = formEx.PolicyNumber;
        dr.PolicyNumberIndex = 0;
      }
    }
    finally
    {
      formEx.Dispose();
    }
  }

  public virtual PolicyInfo GetPolicyNumber()
  {
    bool flag1 = !this.Quote.IsPackagePolicy || !SystemSettings.GetSetting<bool>("PolicyNumbers.ByPassForPackage", false);
    bool flag2 = !this.Quote.IsMultiCompanyPolicy || !SystemSettings.GetSetting<bool>("PolicyNumbers.ByPassForMultiCompany", false);
    this._childLinePolicyInfo.Clear();
    PolicyInfo policyNumber1;
    if (this.ds.tblQuoteDetails.Rows.Count > 1 && flag1 && flag2)
    {
      List<string> stringList = new List<string>();
      Exception exception;
      try
      {
        try
        {
          foreach (dsBindQuote.tblQuoteDetailsRow tblQuoteDetail in (TypedTableBase<dsBindQuote.tblQuoteDetailsRow>) this.ds.tblQuoteDetails)
          {
            QuoteDetail quoteDetail = new QuoteDetail(this._quote.QuoteGuid, tblQuoteDetail.CompanyLineGuid);
            object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Premium FROM tblQuoteOptions WHERE QuoteGuid = @quoteGuid AND LineGuid = @lineGuid AND CompanyLocationID = @CLID", new object[6]
            {
              (object) "@quoteGuid",
              (object) this._quote.QuoteGuid,
              (object) "@lineGuid",
              (object) quoteDetail.CompanyLine.LineGuid,
              (object) "@CLID",
              (object) quoteDetail.CompanyLine.CompanyLocation.CompanyLocationID
            }));
            bool flag3 = objectValue != null && Decimal.Compare(Conversions.ToDecimal(objectValue), 0M) != 0;
            int? policyNumberRuleId = quoteDetail.CalculatedPolicyNumberRuleID;
            if (policyNumberRuleId.HasValue && flag3)
            {
              if (quoteDetail.IsManualPolicyNumberEntry(policyNumberRuleId))
              {
                this.GetManualPolicyNumber(tblQuoteDetail, policyNumberRuleId.Value);
                if (string.IsNullOrEmpty(tblQuoteDetail.PolicyNumber))
                {
                  this.Close();
                  policyNumber1 = (PolicyInfo) null;
                  goto label_93;
                }
              }
              else
              {
                int ruleID = int.MinValue;
                try
                {
                  PolicyInfo nextPolicy = Quote.GetNextPolicy(this._quote.QuoteGuid, tblQuoteDetail.CompanyLineGuid);
                  if (nextPolicy.PolicyNumber == null)
                  {
                    int num = (int) this.ShowMessage("The system was unable to generate a policy number.\n\nPlease check the policy number administration to verify a valid rule is in place.", "Unable to Generate Policy Number", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    policyNumber1 = (PolicyInfo) null;
                    goto label_93;
                  }
                  if (new CompanyLine(tblQuoteDetail.CompanyLineGuid).EnforceUniquePolicyNumbers && stringList.Contains(nextPolicy.PolicyNumber))
                  {
                    int num = (int) this.ShowMessage($"The policy number {nextPolicy.PolicyNumber} is already in use on the policy detail level.  The policy can not be bound.", "Duplicate Policy Detail Number", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    policyNumber1 = (PolicyInfo) null;
                    goto label_93;
                  }
                  stringList.Add(nextPolicy.PolicyNumber);
                  tblQuoteDetail.PolicyNumber = nextPolicy.PolicyNumber;
                  tblQuoteDetail.PolicyNumberIndex = nextPolicy.PolicyIndex;
                  tblQuoteDetail.PolicyNumberRuleID = nextPolicy.PolicyNumberRuleID;
                  ruleID = nextPolicy.PolicyNumberRuleID;
                  this._childLinePolicyInfo.Add(new PolicyDetailInfo()
                  {
                    CompanyLineguid = tblQuoteDetail.CompanyLineGuid,
                    PolicyIndex = nextPolicy.PolicyIndex,
                    PolicyNumber = nextPolicy.PolicyNumber,
                    PolicyNumberRuleID = nextPolicy.PolicyNumberRuleID,
                    TableBasedPolicyNumber = nextPolicy.TableBasedPolicyNumber
                  });
                }
                catch (NoPolicyNumbersRemainingException ex)
                {
                  ProjectData.SetProjectError((Exception) ex);
                  int num = (int) this.ShowMessage(((Exception) ex).Message, "No Policy Numbers Remaining", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                  policyNumber1 = (PolicyInfo) null;
                  ProjectData.ClearProjectError();
                  goto label_93;
                }
                catch (ManualEntryRequiredException ex)
                {
                  ProjectData.SetProjectError((Exception) ex);
                  this.GetManualPolicyNumber(tblQuoteDetail, ruleID);
                  if (string.IsNullOrEmpty(tblQuoteDetail.PolicyNumber))
                  {
                    this.Close();
                    policyNumber1 = (PolicyInfo) null;
                    ProjectData.ClearProjectError();
                    goto label_93;
                  }
                  ProjectData.ClearProjectError();
                }
              }
            }
          }
        }
        finally
        {
          IEnumerator<dsBindQuote.tblQuoteDetailsRow> enumerator;
          enumerator?.Dispose();
        }
        bool flag4 = true;
        string message = string.Empty;
        object detailLock = this._detailLock;
        ObjectFlowControl.CheckForSyncLockOnValueType(detailLock);
        bool lockTaken = false;
        try
        {
          Monitor.Enter(detailLock, ref lockTaken);
          try
          {
            foreach (PolicyDetailInfo policyDetailInfo in this._childLinePolicyInfo)
            {
              if (!string.IsNullOrEmpty(policyDetailInfo.PolicyNumber) && new CompanyLine(policyDetailInfo.CompanyLineguid).EnforceUniquePolicyNumbers)
              {
                if (DefaultDatabase.ExecuteScalar<bool>("spIsPolicyNumberInUseOnQuoteDetail", new object[2]
                {
                  (object) "@PolicyNumber",
                  (object) policyDetailInfo.PolicyNumber
                }))
                {
                  message = $"The policy number {policyDetailInfo.PolicyNumber} is already in use on the policy detail level.  The policy can not be bound.";
                  flag4 = false;
                  break;
                }
              }
            }
          }
          finally
          {
            List<PolicyDetailInfo>.Enumerator enumerator;
            enumerator.Dispose();
          }
          if (flag4)
          {
            DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daQuoteDetails, (DataTable) this.ds.tblQuoteDetails);
            try
            {
              foreach (PolicyDetailInfo policyDetailInfo in this._childLinePolicyInfo)
              {
                if (!Utility.IsNull((object) policyDetailInfo.TableBasedPolicyNumber) && policyDetailInfo.TableBasedPolicyNumber.Length > 0)
                  DefaultDatabase.ExecuteNonQuery("dbo.spPolicyNumberingSetTablePolicyNumberToUsed", new object[8]
                  {
                    (object) "@QuoteGuid",
                    (object) this._quote.QuoteGuid,
                    (object) "@PolicyNumberRuleId",
                    (object) policyDetailInfo.PolicyNumberRuleID,
                    (object) "@ActualPolicyNumber",
                    (object) policyDetailInfo.PolicyNumber,
                    (object) "@TableBasedPolicyNumber",
                    (object) policyDetailInfo.TableBasedPolicyNumber
                  });
              }
            }
            finally
            {
              List<PolicyDetailInfo>.Enumerator enumerator;
              enumerator.Dispose();
            }
          }
        }
        finally
        {
          if (lockTaken)
            Monitor.Exit(detailLock);
        }
        if (!flag4)
        {
          int num = (int) this.ShowMessage(message, "Duplicate Policy Detail Number", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          policyNumber1 = (PolicyInfo) null;
          goto label_93;
        }
        Guid quoteGuid = this._quote.QuoteGuid;
        try
        {
          foreach (dsBindQuote.tblQuoteDetailsRow row in this.ds.tblQuoteDetails.Rows)
          {
            if (!row.IsPolicyNumberNull() && this.IsChildPolicyNumberCurrent(row.CompanyLineGuid, row.PolicyNumber))
            {
              CompanyLine companyLine = new CompanyLine(row.CompanyLineGuid);
              int num;
              string empty1;
              if (!row.IsPolicyNumberIndexNull())
              {
                num = row.PolicyNumberIndex;
                empty1 = num.ToString();
              }
              else
                empty1 = string.Empty;
              string str1 = empty1;
              string empty2;
              if (!row.IsPolicyNumberRuleIDNull())
              {
                num = row.PolicyNumberRuleID;
                empty2 = num.ToString();
              }
              else
                empty2 = string.Empty;
              string str2 = empty2;
              CurrentUser.Instance.LogAction($"Assign, on bind, policy # {row.PolicyNumber}, index='{str1}' and ruleId='{str2}' to company/line {companyLine.CompanyLineState}", quoteGuid);
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
      catch (Exception ex) when (
      {
        // ISSUE: unable to correctly present filter
        ProjectData.SetProjectError(ex);
        exception = ex;
        if (!this.BlackBoxMode)
        {
          SuccessfulFiltering;
        }
        else
          throw;
      }
      )
      {
        MGASystems.Common.ErrorHandling.ErrorHandler.HandleError(exception);
        policyNumber1 = (PolicyInfo) null;
        ProjectData.ClearProjectError();
        goto label_93;
      }
    }
    PolicyInfo policyInfo = new PolicyInfo();
    Exception exception1;
    try
    {
      int? policyNumberRuleId = this._quote.CalculatedPolicyNumberRuleID;
      if (policyNumberRuleId.HasValue && this._quote.IsManualPolicyNumberEntry(new int?(policyNumberRuleId.Value)) || !policyNumberRuleId.HasValue)
      {
        if (this.BlackBoxMode)
          throw new InvalidOperationException("Can not bind a policy requiring a manual policy number in black box mode");
        frmPolicyNumberEntry formEx = (frmPolicyNumberEntry) ObjectFactory.Instance.CreateFormEX(typeof (frmPolicyNumberEntry), new object[1]
        {
          (object) this._quote.CompanyLineGuid
        });
        try
        {
          formEx.IsMainPolicyNumberEntry = true;
          formEx.PolicyNumberID = !policyNumberRuleId.HasValue ? int.MinValue : policyNumberRuleId.Value;
          int num = (int) formEx.ShowDialog();
          policyInfo.PolicyNumber = formEx.PolicyNumber;
          if (!formEx.ClickedCancel)
          {
            if (formEx.ValidMask)
              goto label_66;
          }
          this.Close();
          policyNumber1 = (PolicyInfo) null;
          goto label_93;
        }
        finally
        {
          formEx.Dispose();
        }
label_66:
        policyInfo.PolicyIndex = 0;
      }
      else
      {
        bool flag5 = true;
        int ruleID = int.MinValue;
        PolicyInfo pol;
        try
        {
          pol = Quote.GetNextPolicy(this._quote.QuoteGuid);
          if (pol.PolicyNumber == null)
          {
            int num = (int) this.ShowMessage("Could not find a policy number for this quote.", "Policy Number Not Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            policyNumber1 = (PolicyInfo) null;
            goto label_93;
          }
          ruleID = pol.PolicyNumberRuleID;
          if (DefaultDatabase.ExecuteScalar<bool>("spPromptForManualOverride", new object[2]
          {
            (object) "@PolicyNumberRuleId",
            (object) pol.PolicyNumberRuleID
          }))
          {
            if (this.BlackBoxMode)
              throw new InvalidOperationException("Cannot bind a policy set for manual override in black box mode");
            frmPolicyNumberEntry formEx = (frmPolicyNumberEntry) ObjectFactory.Instance.CreateFormEX(typeof (frmPolicyNumberEntry), new object[1]
            {
              (object) this._quote.CompanyLineGuid
            });
            try
            {
              string policyNumber2 = pol.PolicyNumber;
              formEx.IsMainPolicyNumberEntry = true;
              formEx.PolicyNumber = policyNumber2;
              formEx.PolicyNumberID = pol.PolicyNumberRuleID;
              int num = (int) formEx.ShowDialog();
              policyInfo.PolicyNumber = formEx.PolicyNumber;
              if (formEx.ClickedCancel)
              {
                this.Close();
                policyNumber1 = (PolicyInfo) null;
                goto label_93;
              }
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(policyNumber2, formEx.PolicyNumber, false) != 0)
              {
                policyInfo.PolicyNumber = formEx.PolicyNumber;
                if (SystemSettings.GetSetting<bool>("KeepPolicyNumberDetailsOnManualOverride", false))
                {
                  pol.PolicyNumber = formEx.PolicyNumber;
                  if (!this.BlackBoxMode)
                    CurrentUser.Instance.LogAction($"Policy # manual override. Changed generated pol # '{policyNumber2}' to '{policyInfo.PolicyNumber}'", this._quote.QuoteGuid);
                }
                else
                {
                  policyInfo.PolicyIndex = 0;
                  flag5 = false;
                }
              }
            }
            finally
            {
              formEx.Dispose();
            }
          }
        }
        catch (NoPolicyNumbersRemainingException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) this.ShowMessage(((Exception) ex).Message, "No Policy Numbers Remaining", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          policyNumber1 = (PolicyInfo) null;
          ProjectData.ClearProjectError();
          goto label_93;
        }
        catch (ManualEntryRequiredException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          pol = new PolicyInfo();
          this.GetManualPolicyNumber(pol, ruleID);
          if (string.IsNullOrEmpty(pol.PolicyNumber))
          {
            this.Close();
            policyNumber1 = (PolicyInfo) null;
            ProjectData.ClearProjectError();
            goto label_93;
          }
          ProjectData.ClearProjectError();
        }
        if (flag5)
        {
          policyInfo.PolicyNumber = pol.PolicyNumber;
          policyInfo.PolicyIndex = pol.PolicyIndex;
          policyInfo.PolicyNumberRuleID = pol.PolicyNumberRuleID;
          policyInfo.TableBasedPolicyNumber = pol.TableBasedPolicyNumber;
        }
      }
    }
    catch (Exception ex) when (
    {
      // ISSUE: unable to correctly present filter
      ProjectData.SetProjectError(ex);
      exception1 = ex;
      if (!this._blackBoxMode)
      {
        SuccessfulFiltering;
      }
      else
        throw;
    }
    )
    {
      if (exception1.Message.Contains("no policy numbering rule assigned to this company line"))
      {
        int num = (int) this.ShowMessage($"{exception1.Message}{"\n"}{"\n"}Check the company/line for a rule with a valid effective date, or that the program code on the policy # rule matches that on the policy.", "No Policy Numbers Rule Assigned to Company/Line", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        policyNumber1 = (PolicyInfo) null;
        ProjectData.ClearProjectError();
        goto label_93;
      }
      MGASystems.Common.ErrorHandling.ErrorHandler.HandleError(exception1);
      policyNumber1 = (PolicyInfo) null;
      ProjectData.ClearProjectError();
      goto label_93;
    }
    policyNumber1 = policyInfo;
label_93:
    return policyNumber1;
  }

  private bool IsChildPolicyNumberCurrent(Guid childCompanyLineGuid, string childPolicyNumber)
  {
    bool flag;
    try
    {
      foreach (PolicyDetailInfo policyDetailInfo in this._childLinePolicyInfo)
      {
        if (policyDetailInfo.CompanyLineguid.Equals(childCompanyLineGuid) && policyDetailInfo.PolicyNumber.Equals(childPolicyNumber))
        {
          flag = true;
          goto label_6;
        }
      }
    }
    finally
    {
      List<PolicyDetailInfo>.Enumerator enumerator;
      enumerator.Dispose();
    }
    flag = false;
label_6:
    return flag;
  }

  public virtual void RefreshQuoteObject()
  {
  }

  internal void BindPolicy()
  {
    if (!this.ReadyToBind())
      return;
    if (!this._quote.IsEndorsement)
    {
      this.RefreshQuoteObject();
      if (!this._quote.HasPolicyNumber)
      {
        this._pi = this.GetPolicyNumber();
        if (this._pi == null)
          return;
      }
      if (!frmChangePolicyNumber.DuplicatePolicyNumberCheck(this._quote, this._pi != null ? this._pi.PolicyNumber : this._quote.PolicyNumber))
        return;
    }
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT RaterID, CompanyLineGuid FROM dbo.tblQuoteDetails WITH(NOLOCK) WHERE QuoteGuid=@QuoteGuid AND RaterID IS NOT NULL", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        int num = ExtensionsMethods.FieldAs<int>(row, "RaterID", DataRowVersion.Current);
        Guid guid = row.Field<Guid>("CompanyLineGuid");
        IRater rater = RaterFactory.GetRater(num);
        if (rater != null)
        {
          rater.InitializeState(this._quote.QuoteGuid, guid);
          rater.PreBind();
        }
        else if (!this.BlackBoxMode)
          throw new InvalidOperationException($"RaterID {num.ToString()} not found.");
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (!this.ValidCompanylinePolicyNumberRequirements())
      return;
    if (this._acceptOnBackDateExceedDays && !this._quote.IsEndorsement)
      CurrentUser.Instance.LogAction($"Control #{this._quote.ControlNo.ToString()} - User accepts to bind when effective date exceeds the maximum backdate allowed on company / line.", this._quote.QuoteGuid);
    this._startBindTime = DateAndTime.Now;
    if (!this.BlackBoxMode)
    {
      ((Control) this.btnYes).Enabled = false;
      ((Control) this.btnNo).Enabled = false;
      new Thread(new ThreadStart(this.PostInvoicesThread))
      {
        IsBackground = false,
        Name = "Post Invoices"
      }.Start();
    }
    else
      this.PostInvoicesThread();
    if (this._frmCreatingInvoicesPleaseWait != null)
      this._frmCreatingInvoicesPleaseWait.Dispose();
    if (this.BlackBoxMode)
      return;
    this._frmCreatingInvoicesPleaseWait = (frmCreatingInvoicesPleaseWait) ObjectFactory.Instance.CreateForm(typeof (frmCreatingInvoicesPleaseWait));
    frmCreatingInvoicesPleaseWait invoicesPleaseWait = this._frmCreatingInvoicesPleaseWait;
    invoicesPleaseWait.StartPosition = FormStartPosition.CenterScreen;
    invoicesPleaseWait.ShowInTaskbar = false;
    invoicesPleaseWait.TopLevel = true;
    invoicesPleaseWait.Show();
    invoicesPleaseWait.Refresh();
    invoicesPleaseWait.SetProgressBarMax(this._invoices.Count);
  }

  protected virtual void ClientChangeStatusReason()
  {
  }

  protected virtual bool ValidCompanylinePolicyNumberRequirements()
  {
    bool flag;
    if (this._quote.IsEndorsement)
    {
      flag = true;
    }
    else
    {
      string setting = SystemSettings.GetSetting<string>("CompanylinePolicyNumberRequirementsStoredProc", (string) null);
      if (string.IsNullOrWhiteSpace(setting))
      {
        flag = true;
      }
      else
      {
        object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(setting, new object[2]
        {
          (object) "@QuoteGuid",
          (object) this._quote.QuoteGuid
        }));
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
        {
          int num = (int) this.ShowMessage(objectValue.ToString(), "Cannot Continue Bind - Missing Company/line Policy #s", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
        }
        else
          flag = true;
      }
    }
    return flag;
  }

  private void WaivePremiumByDetailLines(DataTable dt)
  {
    Form form = ObjectFactory.Instance.CreateForm(typeof (PremiumDetail), new object[2]
    {
      (object) this._quote.QuoteGuid,
      (object) dt
    });
    form.FormBorderStyle = FormBorderStyle.Sizable;
    form.MaximizeBox = true;
    int num = (int) form.ShowDialog();
  }

  private void frmBindPolicy_KeyUp(object sender, KeyEventArgs e)
  {
    this._letterQueue.Enqueue((object) e.KeyData.ToString());
    if (this._letterQueue.Count > 5)
      this._letterQueue.Dequeue();
    if (this._letterQueue.Count != 5)
      return;
    this.OnFiveLetterAlphaCodeRecieved(this.QueueString);
  }

  private void OnFiveLetterAlphaCodeRecieved(string code)
  {
    string Left = code;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "DEBUG", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "MAGIC", false) != 0)
        return;
      this.lblMagic.Visible = true;
      this._magicMode = true;
    }
    else
    {
      this.lblDebug.Visible = true;
      this._debugMode = true;
    }
  }

  private string QueueString
  {
    get
    {
      StringBuilder stringBuilder = new StringBuilder();
      try
      {
        foreach (object letter in this._letterQueue)
        {
          char ch = Conversions.ToChar(letter);
          stringBuilder.Append(ch);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return stringBuilder.ToString();
    }
  }

  private delegate void EnableYesButtonHandler();

  private delegate void LoadCompleteHandler(Decimal premium, Decimal totalFees);

  public delegate void BindPolicyFormLoadCompleteEventHandler(object sender, EventArgs e);

  private delegate void ErrorHandler(Exception ex);

  public delegate DialogResult ShowMessageHandler(
    string message,
    string caption,
    MessageBoxButtons buttons,
    MessageBoxIcon icon);

  private delegate void PolicyBoundHandler(List<int> officeInvoiceNumbers, List<int> invoiceNumbers);

  private delegate void HidePleaseWaitFormHandler();
}
