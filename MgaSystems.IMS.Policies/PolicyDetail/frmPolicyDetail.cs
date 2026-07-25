// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using Mga.Wpf.Ims.DialogService;
using Mga.Wpf.Ims.Interop;
using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.ComplyAdvantage;
using MGASystems.Common.CustomExceptions;
using MGASystems.Common.DataAccess;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.Forms;
using MGASystems.Common.NativeWindowMethods;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.InsuredsProducersCompanies.Companies;
using MGASystems.IMS.InsuredsProducersCompanies.Insureds;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MgaSystems.IMS.Policies;
using MGASystems.IMS.Policies.Administration;
using MGASystems.IMS.Policies.AffidavitNumbering;
using MgaSystems.IMS.Policies.AuthorityLimit.Lib;
using MgaSystems.IMS.Policies.AuthorityLimit.UI;
using MgaSystems.IMS.Policies.BindingChecklist;
using MGASystems.IMS.Policies.BindPolicy;
using MGASystems.IMS.Policies.Cancellations.Notices;
using MGASystems.IMS.Policies.Claims;
using MGASystems.IMS.Policies.Clearance;
using MGASystems.IMS.Policies.Clearance.MultiQuotePrinting;
using MGASystems.IMS.Policies.Commissions;
using MgaSystems.IMS.Policies.E2Value;
using MGASystems.IMS.Policies.Endorsements;
using MGASystems.IMS.Policies.Fees;
using MGASystems.IMS.Policies.InstallmentBilling;
using MGASystems.IMS.Policies.PolicyBusinessObjects;
using MGASystems.IMS.Policies.PolicyNumbering;
using MGASystems.IMS.Policies.Rating;
using MGASystems.IMS.Policies.Rating.Locations;
using MgaSystems.IMS.Policies.ThresholdLimit.Lib;
using MgaSystems.IMS.Policies.ThresholdLimit.UI;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyDetail;

[DocumentFolderFilter("Policy Detail")]
[SecureResource("{6D1A622A-141E-4535-BF6A-211F51848EF5}", "Bind Policy", "Controls whether or not a user is allowed to bind monetary non endorsement transactions.", "Policies")]
[SecureResource("{65BB1BD1-0FE3-411d-AB6E-CAE27786EB53}", "Allow Bind on Inactive Producer", "Allows the user to bind a policy even though the producer is inactive.", "Policies")]
[SecureResource("{96FF6CC8-EDED-47ec-AF12-DDD82E424D6D}", "Allow Bind on Non-Premium", "Controls whether or not a user is allowed to bind non-monetary transactions", "Policies")]
[SecureResource("{66BF2035-74D4-41e7-84E9-B84E2C3FC885}", "Allow Change Policy Number", "Allows users to manually change policy numbers when an automated numbering rule is in effect.", "Policies")]
[SecureResource("{01061E72-02E9-4fa5-80B3-2ED11DB743BC}", "Allow Bind On Renewal With Inactive Producer", "Allows users to bind a renewal on an inactive producer.", "Policies")]
[SecureResource("{3D356C3F-3474-4752-9E1E-59C9B8DD4728}", "Controls Access to 'Issue Policy' Menu", "Allows users to view the Issue Policy menu item.", "Policies")]
[SecureResource("{83485E4E-FE40-43bd-B7AB-D9BF830AEED8}", "Controls Access to 'Reset Rater' Menu", "Allows users to view the Reset Rater menu item.", "Policies")]
[SecureResource("{B18AD5DA-4952-48ce-A983-6310F588B4DF}", "Controls Access to Cancel Policy Menu", "Allows users to view the Cancel Policy menu item.", "Policies")]
[SecureResource("{B20ECC40-68A6-41bb-A55E-A9B044A62846}", "Controls Access to Affidavit Menu Itms After Policy Bound", "Allows users to view / access affidavit number menu item after policy is bound.", "Policies")]
[SecureResource("{01C3023E-006D-4de8-805A-C4E43A818693}", "Allow issuing quote documents with a lapse in coverage", "Allows users to issue quote docs even when there is a lapse in coverage on renewals.", "Policies")]
[SecureResource("{0D49340A-6850-4fc3-BD7D-2B2F792C450F}", "Allow Saving of XML Imported From NetRate", "Allows users to save XML imported from NetRate on their local drive.", "Policies")]
[SecureResource("{FA44600C-7324-4239-84EA-DE4DA656E389}", "Allow Binding With Lapse In Coverage", "Allows users to bind even when there is a lapse in coverage on renewals.", "Policies")]
[SecureResource("{9C69527F-F01C-400c-A03A-793058FC5086}", "Controls Access to 'Create Endorsement' Menu.", "Allows users to view 'Create Endorsment' Menu item.", "Policies")]
[SecureResource("{9DE07023-88D0-4298-8C81-6CAD0423AA3A}", "Controls Access to 'Correction Entry' Menu.", "Allows users to view 'Correction Entry' Menu item.", "Policies")]
[SecureResource("{5612713D-912F-4f94-973B-48DADB8DD0EE}", "Controls Access to 'Related Quotes' Menu.", "Allows users to view 'Related Quotes' Menu item.", "Policies")]
[SecureResource("{E6B873CE-FA3A-4a5f-A922-19D3912EB82B}", "Policy Preview", "Allows users to preview the policy.", "Policies")]
[SecureResource("{43A67ECB-2021-430b-8121-688BC2F4CC5A}", "Notice of Cancellation Menu", "Allows users to access Notice of Cancellation.", "Policies")]
[SecureResource("{4F98C444-D47F-456d-8C81-9BF3B09214CE}", "Target Premium Check", "Allows the user to override the target premium check.", "Policies")]
[SecureResource("{7741F48B-C18B-4eda-9FD8-6FAB20DA32BE}", "Bind Endorsement", "Controls whether or not a user is allowed to bind endorsement transactions.", "Policies")]
[SecureResource("{E4928B2F-5ED8-408a-844E-883157741E38}", "Allow Printing of New Business Quote", "Controls whether or not a user is allowed to print New Business Quote.", "Policies")]
[SecureResource("{A92F0FB9-8924-4126-9DDD-7C53B16E5B32}", "Control Access to 'Print Binder' Link ", "Controls whether or not a user is allowed to view 'Printer Binder' Link Button.", "Policies")]
[SecureResource("{975C1CEE-686E-4e8b-BFC0-B15767EB722F}", "NetRate Reconnect Data", "Allows the user to reconnect NetRate data.", "Policies")]
[SecureResource("{2F03FBCD-07F4-410b-B787-60BEF9C8449F}", "NetRate Update Premium Data", "Allows the user to update NetRate premium data.", "Policies")]
[SecureResource("{AC07E192-4557-4526-BAA7-8DE4E073EBFC}", "NetRate Update from Existing Policy", "Allows the user to update the policy with the data from another control number's NetRate data.", "Policies")]
[SecureResource("{C3BEF8F3-11B0-4439-9E74-E1093E5328F6}", "Associate Factorset to Company Line", "Allows the admin to associate a factorset to a rater for a given company line.", "Rater Setup")]
[SecureResource("{FF1F9A83-E24A-4c49-8D9A-1C3FB1C88F1D}", "Allow Access To NetRate", "Allows Access To NetRate.", "Rater Setup")]
[SecureResource("{86B5C3C0-4701-4BCB-9E7B-403D733F0831}", "Controls Access to Affidavit Menu Items Before Policy Bound", "Allows users to view / access affidavit number menu item before policy is bound.", "Policies")]
[SecureResource("{FC5D5626-5319-4ded-B176-02AF3517116F}", "Controls Access to BOR on Renewal", "Allows users to view / access BOR on Renewal.", "Policies")]
[SecureResource("{EB46BFBA-6C16-45F7-BFE5-7951B0DFD8E8}", "Controls Access to Filing Producers menu", "Allows users to view / access Filing Producers.", "Policies")]
[SecureResource("{E0BD3A3A-B6EB-4D07-8CAC-253F733996ED}", "Controls Access to Change Producer / BOR menu", "Allows users to view / access Change Producers.", "Policies")]
[SecureResource("{43BBAA1B-286E-4BE5-B3A7-B5E135465299}", "Controls Access to Driver Info menu", "Allows users to view / access Driver Info.", "Policies")]
[SecureResource("{096F2A82-0630-481F-9A90-77CB751F01A2}", "Controls Access to Netrate Policy Update menu", "Allows users to view / Netrate Policy Update.", "Policies")]
[SecureResource("{155837A7-CEAE-4025-8773-8F102A82F29E}", "Controls Access to Change Quote Status Reason menu", "Allows users access to Change Quote Status Reason.", "Policies")]
[SecureResource("{4DFAB239-6E8A-41DB-BDC0-34E89E1F89D6}", "Controls Access to Supplemental Vehicle Info menu", "Allows users access to Supplemental Vehicle Info.", "Policies")]
[SecureResource("{25DD6047-A314-4954-9CDF-436DCAC66053}", "Controls Access to Location Import Utility menu", "Allows users access to Location Import Utility.", "Policies")]
[SecureResource("{F57EDC10-6944-4A09-A2E2-52CA9DA32C15}", "Controls Access to Additional Interest Import Utility menu", "Allows users access to Additional Interest Import Utility.", "Policies")]
[SecureResource("{D3C80C0E-AC54-4655-8011-0CCD15BA2865}", "Rating Enabled", "When granted the user can rate a policy, when denied the rating button is disabled.", "Policies")]
[SecureResource("{01F25D54-0EE8-4795-A90A-24E5550D8D9E}", "Control Access to Change Status Menu", "Control access to the Change Status menu item", "Policies")]
[SecureResource("{79DB0862-268F-4AB4-A4C6-4191A775EB88}", "Controls access to viewing Insured Summary in Policy Menu", "Allows users access to Insured Summary in Policy Menu", "Policies")]
[SecureResource("{1CA322D9-44E0-414A-ADD4-C1621410852E}", "Controls access to viewing Reports in Policy Menu", "Allows users access to Reports in Policy Menu", "Policies")]
[SecureResource("{ED84C3E0-A441-4D8F-9E9A-299E05BD4550}", "Controls access to viewing Assign Policy Menu in Policy Menu", "Allows users access to Assign Policy Menu in Policy Menu", "Policies")]
[SecureResource("{0155FDCE-844F-4729-958A-4C2664DBA761}", "Controls access to viewing Print All Quotes in Policy Menu", "Allows users access to Print All Quotes in Policy Menu", "Policies")]
[SecureResource("{8707FD2F-98CD-4F86-87EB-F6D7820577C3}", "Controls access to viewing Create Audit option in the Policy/Endorsements Menu", "Allows users access to Create Audit option in the Policy/Endorsements Menu", "Policies")]
[SecureResource("{E073074D-08EB-4A38-8FD6-EC35ECE810CE}", "Controls access to viewing Create Installment option in the Policy/Endorsements Menu", "Allows users access to Create Installment option in the Policy/Endorsements Menu", "Policies")]
[SecureResource("{72970177-CAD6-4167-9D36-54B08268D28F}", "Controls access to viewing Reprint Policy function in the Issuance Menu", "Allows users access to Reprint Policy function in the Issuance Menu", "Policies")]
[SecureResource("{AEC583E1-D316-493F-8338-D84847ACBC49}", "Controls access to viewing Inspection Compare tool in the Policy Menu", "Allows users rights to view Inspection Compare tool in Policy Menu", "Inspections")]
[SecureResource("{D80EF27F-768F-4EDF-8F28-3416FFA35934}", "Public World Services - OFAC Insured Score Check", "Allows the user to override the PWS - OFAC Score System Setting check.", "Policies")]
[SecureResource("{b8103d19-1ff7-4918-bac9-d2bf5e4df1ab}", "OFAC Insured Score Check", "Allows the user to override the OFAC Score System Setting check.", "Policies")]
[SecureResource("{73465013-ACE0-4E31-87CC-26D4B94D5F68}", "Controls access to Driver Import Utility", "Allows the user to access and utilize the Driver Import Utility.", "Policies")]
[SecureResource("{865E86E4-A00B-4139-B05D-0694D3A0C22F}", "Allow Unissue if Issued in the Previous Month.", "Allow the un-issuing of a policy if it is issued in the previous month.", "Policies")]
[SecureResource("{E7579DEB-0C57-439E-AA03-9F6E307EB96C}", "Show NetRate QuoteID Dialog", "Allows the user to show the NetRate QuoteID dialog before opening the rater.", "Policies")]
[SecureResource("{9C3ECEB4-F10E-4C37-AFAE-7ADC811CFA0A}", "Show Preview Policy Menu on Unbound Transaction", "Allows the user to access Preview Policy on original unbound transaction.", "Policies")]
[SecureResource("{218D5409-9A5D-4CAE-AF8D-15CF46C42B5B}", "Allow Reset of Applied Policy Forms", "Allows the user to reset applied policy forms for the current transaction.", "Policies")]
[SecureResource("{7D8CFDE5-161F-4915-BBCA-447D045F95F7}", "Controls OFAC Compliance Override on Bind", "Allows users to override OFAC compliance on binding.", "Policies")]
[SecureResource("{BB752B7F-0B69-4B31-92C5-4873EFF14DE7}", "Controls OFAC Compliance Override on Print Quote", "Allows users to override OFAC compliance on print quote.", "Policies")]
[SecureResource("{8015A728-9A1A-4C87-B33F-ED56DC0C2E27}", "Controls OFAC Compliance Override on Policy Issuance", "Allows users to override OFAC compliance on issuing policy.", "Policies")]
[SecureResource("{27E6A377-4DE5-481B-BC02-D785A4F381DE}", "Controls OFAC Compliance Override on Endorsements", "Allows users to override OFAC compliance on endorsements.", "Policies")]
[SecureResource("{25B7B6FC-89E7-4C96-9B9B-7CB5DEE1F7E9}", "Controls Add'l Interest OFAC Compliance Override on Print Quote", "Allows users to override Add'l Interest OFAC compliance on print quote.", "Policies")]
[SecureResource("{375E8B6B-D480-409A-80C1-F43E28A8A9F4}", "Allow Binding Endorsement on Inactive Insured", "Allows users to bind endorsements on inactive insureds.", "Policies")]
[SecureResource("{83DD601C-66A8-4914-BB93-2B1501F5B12C}", "Allow Binding Original Transaction on Inactive Insured", "Allows users to bind original transaction on inactive insureds.", "Policies")]
[SecureResource("{1595D7CD-860D-42B6-8D7C-0A62FF0EFE6E}", "Allow Binding endorsement on Closed Insured", "Allows users to bind endorsements on closed insureds.", "Policies")]
[SecureResource("{CA4B8D51-1D1D-47C7-87E2-604898FEE86B}", "Allow Binding Original Transaction on Closed Insured", "Allows users to bind original transaction on closed insureds.", "Policies")]
[SecureResource("{9B955538-C251-416B-8662-B8F3DD75E438}", "Allow Binding Endorsements on Suspended Insured", "Allows users to bind endorsements on suspended insureds.", "Policies")]
[SecureResource("{8031A91C-F772-470A-A477-4ACF9F9D0827}", "Allow Binding Original Transaction on Suspended Insured", "Allows users to bind original transaction on suspended insureds.", "Policies")]
[SecureResource("{7EE86680-72C9-4531-9CCE-6DA6297D8982}", "Allow Quote on Inactive Insured", "Allows users to quote on Inactive insureds.", "Policies")]
[SecureResource("{7C7B979F-1793-4F6F-BEA7-9E0BB74A2C98}", "Allow Quote on Closed Insured", "Allows users to quote on closed insureds.", "Policies")]
[SecureResource("{911F7E7C-F78E-40DE-9FED-9D668B3CDD4C}", "Allow Quote on Suspended Insured", "Allows users to quote on suspended insureds.", "Policies")]
[SecureResource("{52d3d27d-b743-4717-85a9-269f0cf4fdab}", "Allow display of Property Valuation menu item", "Policies")]
[SecureResource("{9C07C0C2-4247-4575-A758-9428D41A6C0A}", "Allow Bind on Inactive Producer Contact", "Allows the user to bind a policy even though the producer contact is inactive.", "Policies")]
[SecureResource("{E86119E8-7146-49B2-84AC-3C9D4B403910}", "Rerun Policy OFAC", "Controls the ability to rerun Policy OFAC ", "Policies")]
[SecureResource("{2080A07F-0DCC-40A4-9D75-7BDAE4A8A13E}", "Allow to Print Quote On Inactive Company/Line", "Allows users to print quotes on inactive company/line.", "Policies")]
public class frmPolicyDetail : 
  FormBase,
  ISupportNoteSystem,
  ISupportDocumentSystem,
  ISupportPolicyTemplateDocs,
  ISupportInvoiceTemplateDocs,
  ISupportInsuredLocationTemplateDocs,
  ISupportSubmissionTemplateDocs,
  IMessageListener,
  ISupportQuoteContacts
{
  private IContainer components;
  private dsPolicyDetail dsDetail;
  private UltraToolbarsDockArea _frmPolicyDetail_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmPolicyDetail_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _frmPolicyDetail_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmPolicyDetail_Toolbars_Dock_Area_Right;
  public static readonly Guid NetRatePolicyUpdate = new Guid("{4F66F4C6-58EA-4C0C-B58D-5CDBD896066E}");
  internal const string SecurityID_AllowRating = "{D3C80C0E-AC54-4655-8011-0CCD15BA2865}";
  internal const string CanUpdateFactorSetCompanyLine = "{C3BEF8F3-11B0-4439-9E74-E1093E5328F6}";
  internal const string BindMonetaryTransactionsSecurity = "{6D1A622A-141E-4535-BF6A-211F51848EF5}";
  internal const string BindOnInactiveProducer = "{65BB1BD1-0FE3-411d-AB6E-CAE27786EB53}";
  internal const string BindNonPremiumEndorsement = "{96FF6CC8-EDED-47ec-AF12-DDD82E424D6D}";
  internal const string ChangePolicyNumbering = "{66BF2035-74D4-41e7-84E9-B84E2C3FC885}";
  internal const string AllowLapseInCoverageOnRenewal = "{01C3023E-006D-4de8-805A-C4E43A818693}";
  internal const string AllowBindOnRenewalWithInactiveProducer = "{01061E72-02E9-4fa5-80B3-2ED11DB743BC}";
  internal const string CanViewIssuePolicyMenuItem = "{3D356C3F-3474-4752-9E1E-59C9B8DD4728}";
  internal const string CanViewPreviewPolicyMenuItem = "{E6B873CE-FA3A-4a5f-A922-19D3912EB82B}";
  public const string CanViewResetRaterMenuItem = "{83485E4E-FE40-43bd-B7AB-D9BF830AEED8}";
  internal const string CanViewCancelPolicyMenuItem = "{B18AD5DA-4952-48ce-A983-6310F588B4DF}";
  internal const string CanViewAffidavitNumberMenuItemAfterBinding = "{B20ECC40-68A6-41bb-A55E-A9B044A62846}";
  internal const string CanSaveNetRateXML = "{0D49340A-6850-4fc3-BD7D-2B2F792C450F}";
  internal const string BindOnLapseInCoverageOnRenewal = "{FA44600C-7324-4239-84EA-DE4DA656E389}";
  internal const string CanViewCreateEndorsementMenuItem = "{9C69527F-F01C-400c-A03A-793058FC5086}";
  internal const string CanViewCorrectionEntryMenuItem = "{9DE07023-88D0-4298-8C81-6CAD0423AA3A}";
  internal const string CanViewRelatedQuotes = "{5612713D-912F-4f94-973B-48DADB8DD0EE}";
  internal const string CanChangeBOROnRenewal = "{FC5D5626-5319-4ded-B176-02AF3517116F}";
  internal const string OverrideTargetPremiumCheck = "{4F98C444-D47F-456d-8C81-9BF3B09214CE}";
  internal const string CanIssueNOC = "{43A67ECB-2021-430b-8121-688BC2F4CC5A}";
  internal const string BindEndorsement = "{7741F48B-C18B-4eda-9FD8-6FAB20DA32BE}";
  internal const string CanReconnectNetRateData = "{975C1CEE-686E-4e8b-BFC0-B15767EB722F}";
  internal const string CanUpdateNetRatePremiumData = "{2F03FBCD-07F4-410b-B787-60BEF9C8449F}";
  internal const string CanUpdateNetRateXML = "{AC07E192-4557-4526-BAA7-8DE4E073EBFC}";
  internal const string CanPrintNewBusinessQuote = "{E4928B2F-5ED8-408a-844E-883157741E38}";
  protected internal const string CanViewPrintBinder = "{A92F0FB9-8924-4126-9DDD-7C53B16E5B32}";
  internal const string CanViewChangeStatusMenu = "{01F25D54-0EE8-4795-A90A-24E5550D8D9E}";
  internal const string AllowAccessToNetRate = "{FF1F9A83-E24A-4c49-8D9A-1C3FB1C88F1D}";
  internal const string ViewAffidavitMenuBeforeBind = "{86B5C3C0-4701-4BCB-9E7B-403D733F0831}";
  internal const string CanViewFilingProducersMenuItem = "{EB46BFBA-6C16-45F7-BFE5-7951B0DFD8E8}";
  internal const string CanViewChangeProducerMenuItem = "{E0BD3A3A-B6EB-4D07-8CAC-253F733996ED}";
  internal const string CanViewDriverInfoMenuItem = "{43BBAA1B-286E-4BE5-B3A7-B5E135465299}";
  internal const string CanViewNetratePolicyUpdateMenuItem = "{096F2A82-0630-481F-9A90-77CB751F01A2}";
  protected internal const string CanViewChangeQuoteStatusReasonMenuItem = "{155837A7-CEAE-4025-8773-8F102A82F29E}";
  internal const string CanViewSupplementalVehicleInfoMenuItem = "{4DFAB239-6E8A-41DB-BDC0-34E89E1F89D6}";
  internal const string CanAccessLocationImportUtilityMenu = "{25DD6047-A314-4954-9CDF-436DCAC66053}";
  internal const string CanAccessAdditionalInterestImportUtilityMenu = "{F57EDC10-6944-4A09-A2E2-52CA9DA32C15}";
  internal const string CanAccessDriversImportUtility = "{73465013-ACE0-4E31-87CC-26D4B94D5F68}";
  internal const string CanViewInsuredSummary = "{79DB0862-268F-4AB4-A4C6-4191A775EB88}";
  internal const string CanViewReports = "{1CA322D9-44E0-414A-ADD4-C1621410852E}";
  internal const string CanViewAssignPolicyNumber = "{ED84C3E0-A441-4D8F-9E9A-299E05BD4550}";
  internal const string CanPrintAllQuotes = "{0155FDCE-844F-4729-958A-4C2664DBA761}";
  internal const string CanViewAuditEndorsement = "{8707FD2F-98CD-4F86-87EB-F6D7820577C3}";
  internal const string CanViewReprintPolicy = "{72970177-CAD6-4167-9D36-54B08268D28F}";
  internal const string CanViewInspectionCompare = "{AEC583E1-D316-493F-8338-D84847ACBC49}";
  internal const string CanViewPropertyValuation = "{6e621012-52c0-4f67-9354-4dec93a64d58}";
  internal const string OverrideOFACInsuredScore = "{b8103d19-1ff7-4918-bac9-d2bf5e4df1ab}";
  internal const string OverridePublicWorldServicesOFACInsuredScore = "{D80EF27F-768F-4EDF-8F28-3416FFA35934}";
  internal const string CanShowNetRateQuoteIDDialog = "{E7579DEB-0C57-439E-AA03-9F6E307EB96C}";
  internal const string CanShowPropertyValuation = "{52d3d27d-b743-4717-85a9-269f0cf4fdab}";
  internal const string CanUnIssueIfIssuedInPreviousMonth = "{865E86E4-A00B-4139-B05D-0694D3A0C22F}";
  internal const string CanResetAppliedPolicyForms = "{218D5409-9A5D-4CAE-AF8D-15CF46C42B5B}";
  internal const string ShowPreviewPolicyMenuOnUnboundPolicy = "{9C3ECEB4-F10E-4C37-AFAE-7ADC811CFA0A}";
  internal const string OverrideOfacComplianceOnBind = "{7D8CFDE5-161F-4915-BBCA-447D045F95F7}";
  internal const string OverrideOfacComplianceOnPrintQuote = "{BB752B7F-0B69-4B31-92C5-4873EFF14DE7}";
  internal const string OverrideOfacComplianceOnIssuance = "{8015A728-9A1A-4C87-B33F-ED56DC0C2E27}";
  internal const string OverrideOfacComplianceOnEndorsements = "{27E6A377-4DE5-481B-BC02-D785A4F381DE}";
  internal const string OverrideAdditionalInterestOfacCompliancePrintQuote = "{25B7B6FC-89E7-4C96-9B9B-7CB5DEE1F7E9}";
  internal const string AllowBindEndorsementOnInactiveInsured = "{375E8B6B-D480-409A-80C1-F43E28A8A9F4}";
  internal const string CanViewInstallmentEndorsement = "{E073074D-08EB-4A38-8FD6-EC35ECE810CE}";
  internal const string AllowBindOriginalTransactionOnInactiveInsured = "{83DD601C-66A8-4914-BB93-2B1501F5B12C}";
  internal const string AllowBindEndorsementOnClosedInsured = "{1595D7CD-860D-42B6-8D7C-0A62FF0EFE6E}";
  internal const string AllowBindOriginalTransactionOnClosedInsured = "{CA4B8D51-1D1D-47C7-87E2-604898FEE86B}";
  internal const string AllowBindEndorsementOnSuspendedInsured = "{9B955538-C251-416B-8662-B8F3DD75E438}";
  internal const string AllowBindOriginalTransactionOnSuspendedInsured = "{8031A91C-F772-470A-A477-4ACF9F9D0827}";
  internal const string AllowQuoteOnInactiveInsured = "{7EE86680-72C9-4531-9CCE-6DA6297D8982}";
  internal const string AllowQuoteOnClosedInsured = "{7C7B979F-1793-4F6F-BEA7-9E0BB74A2C98}";
  internal const string AllowQuoteOnSuspendedInsured = "{911F7E7C-F78E-40DE-9FED-9D668B3CDD4C}";
  internal const string AllowBindOnInactiveProducerContact = "{9C07C0C2-4247-4575-A758-9428D41A6C0A}";
  internal const string CanRerunPolicyOFAC = "{E86119E8-7146-49B2-84AC-3C9D4B403910}";
  internal const string CanPrintQuotesOnInactiveCompanyline = "{2080A07F-0DCC-40A4-9D75-7BDAE4A8A13E}";
  private const string _thresholdLimitsMenuKey = "Threshold Limits Approval";
  private Quote _quote;
  private readonly Dictionary<string, PolicyDetail_Plugin> _cachedPlugins;
  private readonly HashSet<string> _additionalInterestOfacTypes;
  private Type[] _pluginTypes;
  private frmPolicyDetail.SetupMenusEventArgs _menuArgs;
  private QuoteStatusChangeMenu _statusChangeMenu;
  private List<Guid> _insuredQuotesHash;
  private List<Guid> _submissionQuoteHash;
  private bool _newOptionsAdded;
  private bool _reconnectNetRateData;
  private bool _updateNetRatePremiumData;
  private Stream _submissionStream;
  private Stream _insuredStream;
  private bool _showBindinRequirementChecklistScreen;
  private bool _updateNetRateXML;
  private XmlDocument _NetRateXMLDoc;
  private bool _printingIndication;
  private bool _showNetRateQuoteIDDialog;
  private bool _alreadyRefreshMerged;
  private bool _showPreviewPolicyMenuOnUnboundPolicy;
  private bool? _ignoreCompLineReqOnPrintIndication;
  protected AuthorityLimitCheckManager _authorityLimitCheckManager;
  protected ThresholdLimitCheckManager _thresholdLimitCheckManager;
  private bool _ShowChildToolTipOnMinimize;
  private bool _runAuthorityLimitCheck;
  private bool _runThresholdLimitCheck;
  private bool _runAuthorityCheckAtStartup;
  private bool _runThresholdCheckAtStartup;
  private int _numDetailRows;
  private static CultureInfo _cultureInfo;
  private static bool _isMultiCurrency;
  private static string _currencyCode;
  private static bool _implementCurrencyDisplay;
  private bool _viewCompanyCommissions;
  private bool _viewProducerCommissions;
  private bool _canViewAssignPolicyNumber;
  private bool _printQuoteOnInactiveLine;
  private bool _canOverrideBindOfacHits;
  private bool _canOverrideQuoteOfacHits;
  private bool _canOverrideQuoteAIOfacHits;
  private bool _canOverrideIssueOfacHits;
  private bool _canOverrideEndorsementOfacHits;
  private readonly Lazy<bool> _validateOfacClears;
  private readonly Lazy<bool> _runOfacComplianceChecks;
  private readonly Lazy<bool> _runOfacOnAdditionalInterest;
  private readonly Lazy<bool> _validatePolicyCompliance;
  private readonly Lazy<bool> _validateOnQuote;
  private readonly Lazy<bool> _checkOfacOnQuoteIfMissing;
  private readonly Lazy<bool> _bypassOfacSystemOnQuote;
  private readonly Lazy<bool> _validateOnBind;
  private readonly Lazy<bool> _checkOfacOnBindIfMissing;
  private readonly Lazy<bool> _bypassZeroPremEndtCheckOnBind;
  private readonly Lazy<bool> _bypassOfacSystemOnBind;
  private readonly Lazy<bool> _validateOnPolicyIssuance;
  private readonly Lazy<bool> _checkOfacOnIssueIfMissing;
  private readonly Lazy<bool> _bypassOfacSystemOnIssue;
  private readonly Lazy<bool> _assignPolicyNumber;
  private FormWindowState FrmLastState;
  private ToolTip tip;
  private const int WM_NCMOUSEMOVE = 160 /*0xA0*/;
  private static readonly Dictionary<int, string> _raterNameCache = new Dictionary<int, string>();

  protected virtual UltraExplorerBar leftMenu
  {
    get => this._leftMenu;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      GroupCollapsingEventHandler collapsingEventHandler = new GroupCollapsingEventHandler(this.NoCollapse);
      ItemClickEventHandler clickEventHandler = new ItemClickEventHandler(this.leftMenu_ItemClick);
      UltraExplorerBar leftMenu1 = this._leftMenu;
      if (leftMenu1 != null)
      {
        leftMenu1.GroupCollapsing -= collapsingEventHandler;
        leftMenu1.ItemClick -= clickEventHandler;
      }
      this._leftMenu = value;
      UltraExplorerBar leftMenu2 = this._leftMenu;
      if (leftMenu2 == null)
        return;
      leftMenu2.GroupCollapsing += collapsingEventHandler;
      leftMenu2.ItemClick += clickEventHandler;
    }
  }

  protected virtual UltraToolbarsManager UltraToolbarsManager1
  {
    get => this._UltraToolbarsManager1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.MenuClick);
      BeforeToolDropdownEventHandler dropdownEventHandler = new BeforeToolDropdownEventHandler(this.UltraToolbarsManager1_BeforeToolDropdown);
      UltraToolbarsManager toolbarsManager1_1 = this._UltraToolbarsManager1;
      if (toolbarsManager1_1 != null)
      {
        toolbarsManager1_1.ToolClick -= clickEventHandler;
        toolbarsManager1_1.BeforeToolDropdown -= dropdownEventHandler;
      }
      this._UltraToolbarsManager1 = value;
      UltraToolbarsManager toolbarsManager1_2 = this._UltraToolbarsManager1;
      if (toolbarsManager1_2 == null)
        return;
      toolbarsManager1_2.ToolClick += clickEventHandler;
      toolbarsManager1_2.BeforeToolDropdown += dropdownEventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraExplorerBarGroup4")]
  protected virtual UltraExplorerBarGroup UltraExplorerBarGroup4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem1 = new UltraExplorerBarItem();
    this.UltraExplorerBarGroup4 = new UltraExplorerBarGroup();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPolicyDetail));
    UltraExplorerBarItem ultraExplorerBarItem2 = new UltraExplorerBarItem();
    Appearance appearance3 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem3 = new UltraExplorerBarItem();
    Appearance appearance4 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem4 = new UltraExplorerBarItem();
    Appearance appearance5 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem5 = new UltraExplorerBarItem();
    Appearance appearance6 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem6 = new UltraExplorerBarItem();
    Appearance appearance7 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem7 = new UltraExplorerBarItem();
    Appearance appearance8 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup = new UltraExplorerBarGroup();
    UltraExplorerBarItem ultraExplorerBarItem8 = new UltraExplorerBarItem();
    Appearance appearance9 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem9 = new UltraExplorerBarItem();
    Appearance appearance10 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem10 = new UltraExplorerBarItem();
    Appearance appearance11 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem11 = new UltraExplorerBarItem();
    Appearance appearance12 = new Appearance();
    UltraExplorerBarItem ultraExplorerBarItem12 = new UltraExplorerBarItem();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("MainMenu");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("Policy");
    ButtonTool buttonTool1 = new ButtonTool("Create Endorsement");
    Appearance appearance19 = new Appearance();
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("Policy");
    PopupMenuTool popupMenuTool3 = new PopupMenuTool("Endorsements");
    PopupMenuTool popupMenuTool4 = new PopupMenuTool("AffidavitMenu");
    PopupMenuTool popupMenuTool5 = new PopupMenuTool("Associated Items");
    PopupMenuTool popupMenuTool6 = new PopupMenuTool("Issuance");
    PopupMenuTool popupMenuTool7 = new PopupMenuTool("Related Quotes");
    ButtonTool buttonTool2 = new ButtonTool("View Transaction Log");
    ButtonTool buttonTool3 = new ButtonTool("Change Producer");
    ButtonTool buttonTool4 = new ButtonTool("Filing Producers");
    ButtonTool buttonTool5 = new ButtonTool("Company/Line Management");
    ButtonTool buttonTool6 = new ButtonTool("Change Policy Number");
    ButtonTool buttonTool7 = new ButtonTool("Notice Of Cancellation");
    ButtonTool buttonTool8 = new ButtonTool("Property Valuation");
    ButtonTool buttonTool9 = new ButtonTool("Reset Rater");
    ButtonTool buttonTool10 = new ButtonTool("Unbind Policy");
    ButtonTool buttonTool11 = new ButtonTool("Delete Transaction");
    ButtonTool buttonTool12 = new ButtonTool("New Quote");
    ButtonTool buttonTool13 = new ButtonTool("View Underwriting Locations");
    ButtonTool buttonTool14 = new ButtonTool("ITV Calculator");
    ButtonTool buttonTool15 = new ButtonTool("NetRate Additional Info");
    PopupMenuTool popupMenuTool8 = new PopupMenuTool("NetRate XML");
    ButtonTool buttonTool16 = new ButtonTool("BOR on Renewal");
    ButtonTool buttonTool17 = new ButtonTool("Inspection Compare");
    ButtonTool buttonTool18 = new ButtonTool("Driver Info");
    ButtonTool buttonTool19 = new ButtonTool("Current Loss Information");
    ButtonTool buttonTool20 = new ButtonTool("UpdateNetratePolicy");
    ButtonTool buttonTool21 = new ButtonTool("NetRate Reconnect Data");
    ButtonTool buttonTool22 = new ButtonTool("NetRate Update Premium Data");
    ButtonTool buttonTool23 = new ButtonTool("NetRate Update from Existing Policy");
    ButtonTool buttonTool24 = new ButtonTool("Change Quote Status Reason");
    ButtonTool buttonTool25 = new ButtonTool("Insured Summary");
    PopupMenuTool popupMenuTool9 = new PopupMenuTool("Reports");
    ButtonTool buttonTool26 = new ButtonTool("Assign Policy #");
    ButtonTool buttonTool27 = new ButtonTool("Assign Child Policy #");
    ButtonTool buttonTool28 = new ButtonTool("Supplemental Vehicle Info");
    ButtonTool buttonTool29 = new ButtonTool("Location Import Utility");
    ButtonTool buttonTool30 = new ButtonTool("Additional Interest Import Utility");
    ButtonTool buttonTool31 = new ButtonTool("Drivers Import Utility");
    ButtonTool buttonTool32 = new ButtonTool("Print All Quotes in Submission");
    ButtonTool buttonTool33 = new ButtonTool("Open NetRate QuoteID Dialog");
    ButtonTool buttonTool34 = new ButtonTool("Binding Requirements Checklist");
    ButtonTool buttonTool35 = new ButtonTool("Authority Limits Approval");
    ButtonTool buttonTool36 = new ButtonTool("Threshold Limits Approval");
    ButtonTool buttonTool37 = new ButtonTool("Change Policy Number");
    Appearance appearance20 = new Appearance();
    ButtonTool buttonTool38 = new ButtonTool("Unbind Policy");
    Appearance appearance21 = new Appearance();
    PopupMenuTool popupMenuTool10 = new PopupMenuTool("Endorsements");
    ButtonTool buttonTool39 = new ButtonTool("Create Endorsement");
    ButtonTool buttonTool40 = new ButtonTool("Correction Entry");
    ButtonTool buttonTool41 = new ButtonTool("Cancel Policy");
    ButtonTool buttonTool42 = new ButtonTool("Reinstate Policy");
    ButtonTool buttonTool43 = new ButtonTool("Endorsement Information");
    ButtonTool buttonTool44 = new ButtonTool("Endorsement Body");
    ButtonTool buttonTool45 = new ButtonTool("Audit_Endorsement");
    ButtonTool buttonTool46 = new ButtonTool("Create_Installment");
    ButtonTool buttonTool47 = new ButtonTool("Cancel Policy");
    Appearance appearance22 = new Appearance();
    ButtonTool buttonTool48 = new ButtonTool("Company/Line Management");
    Appearance appearance23 = new Appearance();
    ButtonTool buttonTool49 = new ButtonTool("Reinstate Policy");
    Appearance appearance24 = new Appearance();
    ButtonTool buttonTool50 = new ButtonTool("Additional Interests");
    Appearance appearance25 = new Appearance();
    ButtonTool buttonTool51 = new ButtonTool("Affidavit Numbering");
    Appearance appearance26 = new Appearance();
    PopupMenuTool popupMenuTool11 = new PopupMenuTool("AffidavitMenu");
    ButtonTool buttonTool52 = new ButtonTool("Affidavit Numbering");
    ButtonTool buttonTool53 = new ButtonTool("View/Edit Assigned Numbers");
    ButtonTool buttonTool54 = new ButtonTool("View/Edit Assigned Numbers");
    Appearance appearance27 = new Appearance();
    ButtonTool buttonTool55 = new ButtonTool("Reset Rater");
    Appearance appearance28 = new Appearance();
    PopupMenuTool popupMenuTool12 = new PopupMenuTool("Associated Items");
    ButtonTool buttonTool56 = new ButtonTool("Additional Interests");
    ButtonTool buttonTool57 = new ButtonTool("FCW");
    ButtonTool buttonTool58 = new ButtonTool("Claims");
    ButtonTool buttonTool59 = new ButtonTool("VinVerification");
    ButtonTool buttonTool60 = new ButtonTool("ClearAutoAppliedForms");
    ButtonTool buttonTool61 = new ButtonTool("ResetAppliedForms");
    ButtonTool buttonTool62 = new ButtonTool("FCW");
    Appearance appearance29 = new Appearance();
    ButtonTool buttonTool63 = new ButtonTool("Filing Producers");
    Appearance appearance30 = new Appearance();
    ButtonTool buttonTool64 = new ButtonTool("Issue Policy");
    Appearance appearance31 = new Appearance();
    ButtonTool buttonTool65 = new ButtonTool("Endorsement Information");
    Appearance appearance32 = new Appearance();
    ButtonTool buttonTool66 = new ButtonTool("View Transaction Log");
    Appearance appearance33 = new Appearance();
    ButtonTool buttonTool67 = new ButtonTool("Delete Transaction");
    Appearance appearance34 = new Appearance();
    ButtonTool buttonTool68 = new ButtonTool("Notice Of Cancellation");
    Appearance appearance35 = new Appearance();
    ButtonTool buttonTool69 = new ButtonTool("Un-Issue Policy");
    Appearance appearance36 = new Appearance();
    ButtonTool buttonTool70 = new ButtonTool("Correction Entry");
    Appearance appearance37 = new Appearance();
    PopupMenuTool popupMenuTool13 = new PopupMenuTool("Issuance");
    ButtonTool buttonTool71 = new ButtonTool("Issue Policy");
    ButtonTool buttonTool72 = new ButtonTool("Re-Print Policy");
    ButtonTool buttonTool73 = new ButtonTool("Un-Issue Policy");
    ButtonTool buttonTool74 = new ButtonTool("Preview Policy");
    ButtonTool buttonTool75 = new ButtonTool("ClearBatchIssue");
    ButtonTool buttonTool76 = new ButtonTool("Preview Policy");
    Appearance appearance38 = new Appearance();
    ButtonTool buttonTool77 = new ButtonTool("Claims");
    Appearance appearance39 = new Appearance();
    ButtonTool buttonTool78 = new ButtonTool("Re-Print Policy");
    Appearance appearance40 = new Appearance();
    ButtonTool buttonTool79 = new ButtonTool("Change Producer");
    Appearance appearance41 = new Appearance();
    PopupMenuTool popupMenuTool14 = new PopupMenuTool("Related Quotes");
    PopupMenuTool popupMenuTool15 = new PopupMenuTool("Insured Quotes");
    PopupMenuTool popupMenuTool16 = new PopupMenuTool("Submission Quotes");
    ButtonTool buttonTool80 = new ButtonTool("New Quote");
    Appearance appearance42 = new Appearance();
    PopupMenuTool popupMenuTool17 = new PopupMenuTool("Insured Level Quotes");
    PopupMenuTool popupMenuTool18 = new PopupMenuTool("Insured Quotes");
    PopupMenuTool popupMenuTool19 = new PopupMenuTool("Submission Quotes");
    ButtonTool buttonTool81 = new ButtonTool("View Underwriting Locations");
    Appearance appearance43 = new Appearance();
    ButtonTool buttonTool82 = new ButtonTool("Endorsment Body...");
    Appearance appearance44 = new Appearance();
    ButtonTool buttonTool83 = new ButtonTool("Endorsement Body...");
    ButtonTool buttonTool84 = new ButtonTool("Endorsement Body");
    ButtonTool buttonTool85 = new ButtonTool("ITV Calculator");
    Appearance appearance45 = new Appearance();
    ButtonTool buttonTool86 = new ButtonTool("NetRate Additional Info");
    Appearance appearance46 = new Appearance();
    ButtonTool buttonTool87 = new ButtonTool("Save NetRate XML...");
    Appearance appearance47 = new Appearance();
    ButtonTool buttonTool88 = new ButtonTool("BOR on Renewal");
    Appearance appearance48 = new Appearance();
    ButtonTool buttonTool89 = new ButtonTool("Inspection Compare");
    Appearance appearance49 = new Appearance();
    ButtonTool buttonTool90 = new ButtonTool("Change Quote Status Reason");
    Appearance appearance50 = new Appearance();
    ButtonTool buttonTool91 = new ButtonTool("Driver Info");
    Appearance appearance51 = new Appearance();
    ButtonTool buttonTool92 = new ButtonTool("Current Loss Information");
    Appearance appearance52 = new Appearance();
    ButtonTool buttonTool93 = new ButtonTool("NetRate Reconnect Data");
    Appearance appearance53 = new Appearance();
    ButtonTool buttonTool94 = new ButtonTool("NetRate Update Premium Data");
    Appearance appearance54 = new Appearance();
    ButtonTool buttonTool95 = new ButtonTool("Audit_Endorsement");
    Appearance appearance55 = new Appearance();
    ButtonTool buttonTool96 = new ButtonTool("VinVerification");
    Appearance appearance56 = new Appearance();
    ButtonTool buttonTool97 = new ButtonTool("Insured Summary");
    Appearance appearance57 = new Appearance();
    PopupMenuTool popupMenuTool20 = new PopupMenuTool("Reports");
    ButtonTool buttonTool98 = new ButtonTool("Assign Policy #");
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    ButtonTool buttonTool99 = new ButtonTool("Supplemental Vehicle Info");
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    ButtonTool buttonTool100 = new ButtonTool("Location Import Utility");
    Appearance appearance62 = new Appearance();
    ButtonTool buttonTool101 = new ButtonTool("Update NetRate XML");
    Appearance appearance63 = new Appearance();
    ButtonTool buttonTool102 = new ButtonTool("NetRate Update from Existing Policy");
    Appearance appearance64 = new Appearance();
    ButtonTool buttonTool103 = new ButtonTool("ClearBatchIssue");
    Appearance appearance65 = new Appearance();
    ButtonTool buttonTool104 = new ButtonTool("Additional Interest Import Utility");
    Appearance appearance66 = new Appearance();
    ButtonTool buttonTool105 = new ButtonTool("Drivers Import Utility");
    Appearance appearance67 = new Appearance();
    ButtonTool buttonTool106 = new ButtonTool("Print All Quotes in Submission");
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    ButtonTool buttonTool107 = new ButtonTool("ClearAutoAppliedForms");
    Appearance appearance70 = new Appearance();
    ButtonTool buttonTool108 = new ButtonTool("Open NetRate QuoteID Dialog");
    ButtonTool buttonTool109 = new ButtonTool("ResetAppliedForms");
    Appearance appearance71 = new Appearance();
    ButtonTool buttonTool110 = new ButtonTool("Property Valuation");
    PopupMenuTool popupMenuTool21 = new PopupMenuTool("NetRate XML");
    Appearance appearance72 = new Appearance();
    ButtonTool buttonTool111 = new ButtonTool("Save NetRate XML...");
    ButtonTool buttonTool112 = new ButtonTool("View NetRate XML");
    ButtonTool buttonTool113 = new ButtonTool("View NetRate XML");
    PopupMenuTool popupMenuTool22 = new PopupMenuTool("TESTDS");
    ButtonTool buttonTool114 = new ButtonTool("Binding Requirements Checklist");
    ButtonTool buttonTool115 = new ButtonTool("Create_Installment");
    Appearance appearance73 = new Appearance();
    ButtonTool buttonTool116 = new ButtonTool("Authority Limits Approval");
    ButtonTool buttonTool117 = new ButtonTool("Assign Child Policy #");
    ButtonTool buttonTool118 = new ButtonTool("Threshold Limits Approval");
    ButtonTool buttonTool119 = new ButtonTool("UpdateNetratePolicy");
    Appearance appearance74 = new Appearance();
    Appearance appearance75 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblQuoteDetails", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("StateID");
    Appearance appearance76 = new Appearance();
    Appearance appearance77 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyCommission");
    Appearance appearance78 = new Appearance();
    Appearance appearance79 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ProducerCommission");
    Appearance appearance80 = new Appearance();
    Appearance appearance81 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("FactorSetGuid");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("RaterID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("RatingType");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ProgCode");
    Appearance appearance82 = new Appearance();
    Appearance appearance83 = new Appearance();
    Appearance appearance84 = new Appearance();
    this.dsDetail = new dsPolicyDetail();
    this.leftMenu = new UltraExplorerBar();
    this._frmPolicyDetail_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._frmPolicyDetail_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmPolicyDetail_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmPolicyDetail_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.pnlPolicyInfoMain = new UltraPanel();
    this.pnlPolicyInfo = new Panel();
    this.pnlPolicyInfoLabel = new Panel();
    this.lblPolicyInfo = new Label();
    this.SplitContainer1 = new SplitContainer();
    this.pnlLines = new Panel();
    this.dgParticipants = new UltraGrid();
    this.pnlLinesLabel = new Panel();
    this.chkHideZeroPrem = new CheckBox();
    this.lblLines = new Label();
    this.pnlMiscInfo = new Panel();
    this.imageLoading = new PictureBox();
    this.pnlMiscInfoLabel = new Panel();
    this.lblMiscInfo = new Label();
    this.TableLayoutPanel1 = new TableLayoutPanel();
    this.dsDetail.BeginInit();
    ((ISupportInitialize) this.leftMenu).BeginInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    ((Control) this.pnlPolicyInfoMain.ClientArea).SuspendLayout();
    ((Control) this.pnlPolicyInfoMain).SuspendLayout();
    this.pnlPolicyInfoLabel.SuspendLayout();
    this.SplitContainer1.BeginInit();
    this.SplitContainer1.Panel1.SuspendLayout();
    this.SplitContainer1.Panel2.SuspendLayout();
    this.SplitContainer1.SuspendLayout();
    this.pnlLines.SuspendLayout();
    ((ISupportInitialize) this.dgParticipants).BeginInit();
    this.pnlLinesLabel.SuspendLayout();
    this.pnlMiscInfo.SuspendLayout();
    ((ISupportInitialize) this.imageLoading).BeginInit();
    this.pnlMiscInfoLabel.SuspendLayout();
    this.TableLayoutPanel1.SuspendLayout();
    ((Control) this).SuspendLayout();
    this.dsDetail.DataSetName = "dsPolicyDetail";
    this.dsDetail.Locale = new CultureInfo("en-US");
    this.dsDetail.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance1.BackColor = Color.White;
    appearance1.BackColor2 = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    this.leftMenu.Appearance = (AppearanceBase) appearance1;
    this.leftMenu.BorderStyle = (UIElementBorderStyle) 1;
    ((Control) this.leftMenu).Dock = DockStyle.Left;
    ultraExplorerBarItem1.Key = "EditPolicy";
    appearance2.BackColor = Color.FromArgb(239, 247, 253);
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    ultraExplorerBarItem1.Settings.AppearancesLarge.Appearance = (AppearanceBase) appearance2;
    ultraExplorerBarItem1.Text = "Edit Policy";
    ultraExplorerBarItem2.Key = "Rating";
    appearance3.BackColor = Color.FromArgb(239, 247, 253);
    appearance3.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance3.Image"));
    ultraExplorerBarItem2.Settings.AppearancesLarge.Appearance = (AppearanceBase) appearance3;
    ultraExplorerBarItem2.Text = "Rating";
    ultraExplorerBarItem3.Key = "Fees";
    appearance4.BackColor = Color.FromArgb(239, 247, 253);
    appearance4.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance4.Image"));
    ultraExplorerBarItem3.Settings.AppearancesLarge.Appearance = (AppearanceBase) appearance4;
    ultraExplorerBarItem3.Text = "Fees";
    ultraExplorerBarItem4.Key = "Commissions";
    appearance5.BackColor = Color.FromArgb(239, 247, 253);
    appearance5.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance5.Image"));
    ultraExplorerBarItem4.Settings.AppearancesLarge.Appearance = (AppearanceBase) appearance5;
    ultraExplorerBarItem4.Text = "Commissions";
    ultraExplorerBarItem5.Key = "PrintIndication";
    appearance6.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance6.Image"));
    ultraExplorerBarItem5.Settings.AppearancesLarge.Appearance = (AppearanceBase) appearance6;
    ultraExplorerBarItem5.Text = "Print Indication";
    ultraExplorerBarItem6.Key = "Print";
    appearance7.BackColor = Color.FromArgb(239, 247, 253);
    appearance7.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance7.Image"));
    ultraExplorerBarItem6.Settings.AppearancesLarge.Appearance = (AppearanceBase) appearance7;
    ultraExplorerBarItem6.Text = "Print";
    ultraExplorerBarItem7.Key = "Bind";
    appearance8.BackColor = Color.FromArgb(239, 247, 253);
    appearance8.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance8.Image"));
    ultraExplorerBarItem7.Settings.AppearancesLarge.Appearance = (AppearanceBase) appearance8;
    ultraExplorerBarItem7.Text = "Bind";
    this.UltraExplorerBarGroup4.Items.AddRange(new UltraExplorerBarItem[7]
    {
      ultraExplorerBarItem1,
      ultraExplorerBarItem2,
      ultraExplorerBarItem3,
      ultraExplorerBarItem4,
      ultraExplorerBarItem5,
      ultraExplorerBarItem6,
      ultraExplorerBarItem7
    });
    this.UltraExplorerBarGroup4.Key = "PolicyActions";
    this.UltraExplorerBarGroup4.Text = "Policy Actions";
    ultraExplorerBarItem8.Key = "Premiums";
    appearance9.BackColor = Color.FromArgb(239, 247, 253);
    appearance9.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance9.Image"));
    ultraExplorerBarItem8.Settings.AppearancesLarge.Appearance = (AppearanceBase) appearance9;
    ultraExplorerBarItem8.Text = "Premiums";
    ultraExplorerBarItem9.Key = "Invoices";
    appearance10.BackColor = Color.FromArgb(239, 247, 253);
    appearance10.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance10.Image"));
    ultraExplorerBarItem9.Settings.AppearancesLarge.Appearance = (AppearanceBase) appearance10;
    ultraExplorerBarItem9.Text = "Invoices";
    ultraExplorerBarItem10.Key = "Transactions";
    appearance11.BackColor = Color.FromArgb(239, 247, 253);
    appearance11.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance11.Image"));
    ultraExplorerBarItem10.Settings.AppearancesLarge.Appearance = (AppearanceBase) appearance11;
    ultraExplorerBarItem10.Text = "Transactions";
    ultraExplorerBarItem11.Key = "StatusChanges";
    appearance12.BackColor = Color.FromArgb(239, 247, 253);
    appearance12.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance12.Image"));
    ultraExplorerBarItem11.Settings.AppearancesLarge.Appearance = (AppearanceBase) appearance12;
    ultraExplorerBarItem11.Text = "Status Changes";
    ultraExplorerBarItem12.Key = "PolicyInquiry";
    appearance13.BackColor = Color.FromArgb(239, 247, 253);
    appearance13.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance13.Image"));
    ultraExplorerBarItem12.Settings.AppearancesLarge.Appearance = (AppearanceBase) appearance13;
    ultraExplorerBarItem12.Text = "Policy Inquiry";
    explorerBarGroup.Items.AddRange(new UltraExplorerBarItem[5]
    {
      ultraExplorerBarItem8,
      ultraExplorerBarItem9,
      ultraExplorerBarItem10,
      ultraExplorerBarItem11,
      ultraExplorerBarItem12
    });
    explorerBarGroup.Key = "PolicyInformation";
    explorerBarGroup.Text = "Policy Information";
    this.leftMenu.Groups.AddRange(new UltraExplorerBarGroup[2]
    {
      this.UltraExplorerBarGroup4,
      explorerBarGroup
    });
    this.leftMenu.GroupSettings.AllowItemDrop = (DefaultableBoolean) 2;
    appearance14.BackColor = Color.FromArgb(239, 247, 253);
    this.leftMenu.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance14;
    appearance15.AlphaLevel = (short) 38;
    appearance15.BackColor = Color.FromArgb(166, 202, 238);
    appearance15.BackColor2 = Color.FromArgb(166, 202, 238);
    appearance15.BackColorAlpha = (Alpha) 2;
    appearance15.BorderColor = Color.White;
    appearance15.FontData.Name = "Tahoma";
    appearance15.FontData.SizeInPoints = 8f;
    appearance15.ForeColor = Color.DarkBlue;
    appearance15.ForegroundAlpha = (Alpha) 2;
    appearance15.ImageBackground = (Image) componentResourceManager.GetObject("Appearance15.ImageBackground");
    this.leftMenu.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance15;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.leftMenu.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance16;
    this.leftMenu.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.leftMenu.GroupSettings.NavigationAllowHide = (DefaultableBoolean) 2;
    this.leftMenu.GroupSettings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    this.leftMenu.GroupSettings.Style = (GroupStyle) 4;
    this.leftMenu.ItemSettings.AllowDragMove = (ItemDragStyle) 1;
    appearance17.BackColor = Color.FromArgb(239, 247, 253);
    this.leftMenu.ItemSettings.AppearancesLarge.Appearance = (AppearanceBase) appearance17;
    appearance18.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    this.leftMenu.ItemSettings.AppearancesLarge.HotTrackAppearance = (AppearanceBase) appearance18;
    ((UltraExplorerBarSettingsBase) this.leftMenu.ItemSettings).HotTracking = (DefaultableBoolean) 1;
    this.leftMenu.ItemSettings.HotTrackStyle = (ItemHotTrackStyle) 3;
    ((Control) this.leftMenu).Location = new Point(0, 21);
    this.leftMenu.Margins.Bottom = 8;
    this.leftMenu.Margins.Left = 8;
    this.leftMenu.Margins.Right = 8;
    this.leftMenu.Margins.Top = 8;
    ((Control) this.leftMenu).Name = "leftMenu";
    this.leftMenu.NavigationAllowGroupReorder = false;
    this.leftMenu.Scrollbars = (ScrollbarStyle) 2;
    this.leftMenu.ShowDefaultContextMenu = false;
    ((Control) this.leftMenu).Size = new Size(175, 641);
    ((Control) this.leftMenu).TabIndex = 2;
    ((UltraControlBase) this.leftMenu).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.leftMenu).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Right).BackColor = System.Drawing.SystemColors.Control;
    this._frmPolicyDetail_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Right).Location = new Point(892, 21);
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Right).Name = "_frmPolicyDetail_Toolbars_Dock_Area_Right";
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Right).Size = new Size(0, 641);
    this._frmPolicyDetail_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.ImageTransparentColor = Color.Magenta;
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "MainMenu";
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    appearance19.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance29.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance19;
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).Caption = "Create Endorsement...";
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "Policy";
    ((SubObjectBase) popupMenuTool2).Tag = (object) "KeepActive";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[42]
    {
      (ToolBase) popupMenuTool3,
      (ToolBase) popupMenuTool4,
      (ToolBase) popupMenuTool5,
      (ToolBase) popupMenuTool6,
      (ToolBase) popupMenuTool7,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) popupMenuTool8,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20,
      (ToolBase) buttonTool21,
      (ToolBase) buttonTool22,
      (ToolBase) buttonTool23,
      (ToolBase) buttonTool24,
      (ToolBase) buttonTool25,
      (ToolBase) popupMenuTool9,
      (ToolBase) buttonTool26,
      (ToolBase) buttonTool27,
      (ToolBase) buttonTool28,
      (ToolBase) buttonTool29,
      (ToolBase) buttonTool30,
      (ToolBase) buttonTool31,
      (ToolBase) buttonTool32,
      (ToolBase) buttonTool33,
      (ToolBase) buttonTool34,
      (ToolBase) buttonTool35,
      (ToolBase) buttonTool36
    });
    appearance20.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance30.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool37).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance20;
    ((ToolPropsBase) ((ToolBase) buttonTool37).SharedPropsInternal).Caption = "Change Policy Number...";
    appearance21.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance31.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool38).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance21;
    ((ToolPropsBase) ((ToolBase) buttonTool38).SharedPropsInternal).Caption = "Unbind Policy";
    ((ToolPropsBase) ((ToolBase) popupMenuTool10).SharedPropsInternal).Caption = "Endorsements";
    ((ToolsCollectionBase) popupMenuTool10.Tools).AddRange(new ToolBase[8]
    {
      (ToolBase) buttonTool39,
      (ToolBase) buttonTool40,
      (ToolBase) buttonTool41,
      (ToolBase) buttonTool42,
      (ToolBase) buttonTool43,
      (ToolBase) buttonTool44,
      (ToolBase) buttonTool45,
      (ToolBase) buttonTool46
    });
    appearance22.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance32.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool47).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance22;
    ((ToolPropsBase) ((ToolBase) buttonTool47).SharedPropsInternal).Caption = "Cancel Policy...";
    appearance23.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance33.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool48).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance23;
    ((ToolPropsBase) ((ToolBase) buttonTool48).SharedPropsInternal).Caption = "Company/Line Management...";
    appearance24.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance34.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool49).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance24;
    ((ToolPropsBase) ((ToolBase) buttonTool49).SharedPropsInternal).Caption = "Reinstate Policy";
    appearance25.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance35.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool50).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance25;
    ((ToolPropsBase) ((ToolBase) buttonTool50).SharedPropsInternal).Caption = "&Additional Interests...";
    ((SubObjectBase) buttonTool50).Tag = (object) "KeepActive";
    appearance26.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance36.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool51).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance26;
    ((ToolPropsBase) ((ToolBase) buttonTool51).SharedPropsInternal).Caption = "&Assign Affidavit Number";
    ((ToolPropsBase) ((ToolBase) popupMenuTool11).SharedPropsInternal).Caption = "&Affidavit Numbering";
    ((ToolsCollectionBase) popupMenuTool11.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool52,
      (ToolBase) buttonTool53
    });
    appearance27.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance37.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool54).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance27;
    ((ToolPropsBase) ((ToolBase) buttonTool54).SharedPropsInternal).Caption = "&View/Edit Assigned Numbers";
    appearance28.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance38.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool55).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance28;
    ((ToolPropsBase) ((ToolBase) buttonTool55).SharedPropsInternal).Caption = "Reset Rater Selection";
    ((ToolPropsBase) ((ToolBase) popupMenuTool12).SharedPropsInternal).Caption = "Associated Items";
    ((SubObjectBase) popupMenuTool12).Tag = (object) "KeepActive";
    ((ToolsCollectionBase) popupMenuTool12.Tools).AddRange(new ToolBase[6]
    {
      (ToolBase) buttonTool56,
      (ToolBase) buttonTool57,
      (ToolBase) buttonTool58,
      (ToolBase) buttonTool59,
      (ToolBase) buttonTool60,
      (ToolBase) buttonTool61
    });
    appearance29.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance39.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool62).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance29;
    ((ToolPropsBase) ((ToolBase) buttonTool62).SharedPropsInternal).Caption = "Forms/Conditions/Warranties...";
    ((SubObjectBase) buttonTool62).Tag = (object) "KeepActive";
    appearance30.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance40.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool63).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance30;
    ((ToolPropsBase) ((ToolBase) buttonTool63).SharedPropsInternal).Caption = "Filing Producers...";
    appearance31.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance41.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool64).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance31;
    ((ToolPropsBase) ((ToolBase) buttonTool64).SharedPropsInternal).Caption = "Issue Policy";
    ((SubObjectBase) buttonTool64).Tag = (object) "KeepActive";
    appearance32.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance42.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool65).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance32;
    ((ToolPropsBase) ((ToolBase) buttonTool65).SharedPropsInternal).Caption = "Endorsement Information...";
    appearance33.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance43.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool66).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance33;
    ((ToolPropsBase) ((ToolBase) buttonTool66).SharedPropsInternal).Caption = "View Transaction Log...";
    ((SubObjectBase) buttonTool66).Tag = (object) "KeepActive";
    appearance34.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance44.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool67).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance34;
    ((ToolPropsBase) ((ToolBase) buttonTool67).SharedPropsInternal).Caption = "Delete Transaction";
    appearance35.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance45.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool68).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance35;
    ((ToolPropsBase) ((ToolBase) buttonTool68).SharedPropsInternal).Caption = "Notice Of Cancellation...";
    appearance36.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance46.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool69).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance36;
    ((ToolPropsBase) ((ToolBase) buttonTool69).SharedPropsInternal).Caption = "Un-Issue Policy";
    ((SubObjectBase) buttonTool69).Tag = (object) "KeepActive";
    appearance37.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance47.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool70).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance37;
    ((ToolPropsBase) ((ToolBase) buttonTool70).SharedPropsInternal).Caption = "Correction Entry...";
    ((ToolPropsBase) ((ToolBase) popupMenuTool13).SharedPropsInternal).Caption = "Issuance";
    ((SubObjectBase) popupMenuTool13).Tag = (object) "KeepActive";
    ((ToolsCollectionBase) popupMenuTool13.Tools).AddRange(new ToolBase[5]
    {
      (ToolBase) buttonTool71,
      (ToolBase) buttonTool72,
      (ToolBase) buttonTool73,
      (ToolBase) buttonTool74,
      (ToolBase) buttonTool75
    });
    appearance38.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance48.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool76).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance38;
    ((ToolPropsBase) ((ToolBase) buttonTool76).SharedPropsInternal).Caption = "Preview Policy";
    ((SubObjectBase) buttonTool76).Tag = (object) "KeepActive";
    appearance39.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance49.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool77).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance39;
    ((ToolPropsBase) ((ToolBase) buttonTool77).SharedPropsInternal).Caption = "Claims...";
    ((SubObjectBase) buttonTool77).Tag = (object) "KeepActive";
    appearance40.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance50.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool78).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance40;
    ((ToolPropsBase) ((ToolBase) buttonTool78).SharedPropsInternal).Caption = "Re-Print Policy";
    ((SubObjectBase) buttonTool78).Tag = (object) "KeepActive";
    appearance41.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance51.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool79).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance41;
    ((ToolPropsBase) ((ToolBase) buttonTool79).SharedPropsInternal).Caption = "Change Producer / BOR...";
    ((ToolPropsBase) ((ToolBase) popupMenuTool14).SharedPropsInternal).Caption = "Related Quotes";
    ((ToolsCollectionBase) popupMenuTool14.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) popupMenuTool15,
      (ToolBase) popupMenuTool16
    });
    appearance42.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance52.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool80).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance42;
    ((ToolPropsBase) ((ToolBase) buttonTool80).SharedPropsInternal).Caption = "New Quote";
    ((ToolPropsBase) ((ToolBase) popupMenuTool17).SharedPropsInternal).Caption = "Insured Level Quotes";
    ((ToolPropsBase) ((ToolBase) popupMenuTool18).SharedPropsInternal).Caption = "Insured Quotes";
    ((ToolPropsBase) ((ToolBase) popupMenuTool19).SharedPropsInternal).Caption = "Submission Quotes";
    appearance43.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance53.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool81).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance43;
    ((ToolPropsBase) ((ToolBase) buttonTool81).SharedPropsInternal).Caption = "View Underwriting Locations ...";
    appearance44.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance54.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool82).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance44;
    ((ToolPropsBase) ((ToolBase) buttonTool82).SharedPropsInternal).Caption = "Endorsment Body...";
    ((ToolPropsBase) ((ToolBase) buttonTool83).SharedPropsInternal).Caption = "Endorsement Body...";
    ((ToolPropsBase) ((ToolBase) buttonTool84).SharedPropsInternal).Caption = "Endorsement Body...";
    appearance45.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance55.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool85).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance45;
    ((ToolPropsBase) ((ToolBase) buttonTool85).SharedPropsInternal).Caption = "ITV Calculator ...";
    appearance46.Image = (object) strings.add;
    ((ToolPropsBase) ((ToolBase) buttonTool86).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance46;
    ((ToolPropsBase) ((ToolBase) buttonTool86).SharedPropsInternal).Caption = "NetRate Additional Info...";
    appearance47.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance57.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool87).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance47;
    ((ToolPropsBase) ((ToolBase) buttonTool87).SharedPropsInternal).Caption = "Save NetRate XML...";
    appearance48.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance58.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool88).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance48;
    ((ToolPropsBase) ((ToolBase) buttonTool88).SharedPropsInternal).Caption = "BOR on Renewal...";
    appearance49.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance59.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool89).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance49;
    ((ToolPropsBase) ((ToolBase) buttonTool89).SharedPropsInternal).Caption = "Inspection Compare ...";
    appearance50.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance60.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool90).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance50;
    ((ToolPropsBase) ((ToolBase) buttonTool90).SharedPropsInternal).Caption = "Change Quote Status Reason ...";
    appearance51.Image = (object) strings.car;
    ((ToolPropsBase) ((ToolBase) buttonTool91).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance51;
    ((ToolPropsBase) ((ToolBase) buttonTool91).SharedPropsInternal).Caption = "Driver Info ...";
    appearance52.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance62.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool92).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance52;
    ((ToolPropsBase) ((ToolBase) buttonTool92).SharedPropsInternal).Caption = "Current Loss Information ...";
    appearance53.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance63.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool93).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance53;
    ((ToolPropsBase) ((ToolBase) buttonTool93).SharedPropsInternal).Caption = "NetRate Reconnect Data";
    appearance54.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance64.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool94).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance54;
    ((ToolPropsBase) ((ToolBase) buttonTool94).SharedPropsInternal).Caption = "NetRate Update Premium Data";
    appearance55.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance65.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool95).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance55;
    ((ToolPropsBase) ((ToolBase) buttonTool95).SharedPropsInternal).Caption = "Create Audit ...";
    appearance56.Image = (object) strings.car;
    ((ToolPropsBase) ((ToolBase) buttonTool96).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance56;
    ((ToolPropsBase) ((ToolBase) buttonTool96).SharedPropsInternal).Caption = "Vin Verification";
    appearance57.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance67.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool97).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance57;
    ((ToolPropsBase) ((ToolBase) buttonTool97).SharedPropsInternal).Caption = "Insured Summary";
    ((ToolPropsBase) ((ToolBase) popupMenuTool20).SharedPropsInternal).Caption = "Reports";
    appearance58.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance68.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool98).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance58;
    appearance59.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance69.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool98).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance59;
    ((ToolPropsBase) ((ToolBase) buttonTool98).SharedPropsInternal).Caption = "Assign Policy #";
    appearance60.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance70.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool99).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance60;
    appearance61.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance71.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool99).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance61;
    ((ToolPropsBase) ((ToolBase) buttonTool99).SharedPropsInternal).Caption = "Supplemental Vehicle Info";
    appearance62.Image = (object) strings.application_double1;
    ((ToolPropsBase) ((ToolBase) buttonTool100).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance62;
    ((ToolPropsBase) ((ToolBase) buttonTool100).SharedPropsInternal).Caption = "Location Import Utility";
    appearance63.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance73.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool101).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance63;
    ((ToolPropsBase) ((ToolBase) buttonTool101).SharedPropsInternal).Caption = "Update NetRate XML";
    ((ToolPropsBase) ((ToolBase) buttonTool101).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 2;
    appearance64.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance74.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool102).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance64;
    ((ToolPropsBase) ((ToolBase) buttonTool102).SharedPropsInternal).Caption = "NetRate Update from Existing Policy";
    appearance65.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance75.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool103).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance65;
    ((ToolPropsBase) ((ToolBase) buttonTool103).SharedPropsInternal).Caption = "Clear Batch Issue";
    ((SubObjectBase) buttonTool103).Tag = (object) "KeepActive";
    appearance66.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance76.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool104).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance66;
    ((ToolPropsBase) ((ToolBase) buttonTool104).SharedPropsInternal).Caption = "Additional Interest Import Utility";
    appearance67.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance77.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool105).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance67;
    ((ToolPropsBase) ((ToolBase) buttonTool105).SharedPropsInternal).Caption = "Drivers Import Utility";
    appearance68.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance78.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool106).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance68;
    appearance69.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance79.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool106).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance69;
    ((ToolPropsBase) ((ToolBase) buttonTool106).SharedPropsInternal).Caption = "Print All Quotes in Submission";
    appearance70.Image = (object) strings.eraser;
    ((ToolPropsBase) ((ToolBase) buttonTool107).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance70;
    ((ToolPropsBase) ((ToolBase) buttonTool107).SharedPropsInternal).Caption = "[MGA] Clear PolicyFormsAutoApplied";
    ((ToolBase) buttonTool107).SharedPropsInternal.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool108).SharedPropsInternal).Caption = "Open NetRate QuoteID Dialog";
    ((ToolBase) buttonTool108).SharedPropsInternal.CustomizerCaption = "Open NetRate QuoteID Dialog";
    appearance71.Image = (object) strings.eraser;
    ((ToolPropsBase) ((ToolBase) buttonTool109).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance71;
    ((ToolPropsBase) ((ToolBase) buttonTool109).SharedPropsInternal).Caption = "Reset Applied Policy Forms";
    ((ToolPropsBase) ((ToolBase) buttonTool110).SharedPropsInternal).Caption = "Property Valuation";
    ((ToolPropsBase) ((ToolBase) buttonTool110).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 1;
    appearance72.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance82.Image"));
    ((ToolPropsBase) ((ToolBase) popupMenuTool21).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance72;
    ((ToolPropsBase) ((ToolBase) popupMenuTool21).SharedPropsInternal).Caption = "NetRate XML";
    ((ToolsCollectionBase) popupMenuTool21.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool111,
      (ToolBase) buttonTool112
    });
    ((ToolPropsBase) ((ToolBase) buttonTool113).SharedPropsInternal).Caption = "View NetRate XML";
    ((ToolPropsBase) ((ToolBase) popupMenuTool22).SharedPropsInternal).Caption = "TESTDS";
    ((ToolPropsBase) ((ToolBase) buttonTool114).SharedPropsInternal).Caption = "Binding Requirements Checklist";
    appearance73.Image = (object) strings.application_form_edit;
    ((ToolPropsBase) ((ToolBase) buttonTool115).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance73;
    ((ToolPropsBase) ((ToolBase) buttonTool115).SharedPropsInternal).Caption = "Create Installment";
    ((ToolPropsBase) ((ToolBase) buttonTool116).SharedPropsInternal).Caption = "Authority Limits Approval";
    ((ToolPropsBase) ((ToolBase) buttonTool117).SharedPropsInternal).Caption = "Assign Child Policy #";
    ((ToolPropsBase) ((ToolBase) buttonTool118).SharedPropsInternal).Caption = "Threshold Limits Approval";
    appearance74.Image = (object) strings.application_form_edit;
    ((ToolPropsBase) ((ToolBase) buttonTool119).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance74;
    ((ToolPropsBase) ((ToolBase) buttonTool119).SharedPropsInternal).Caption = "NetRate Update Policy Number";
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[73]
    {
      (ToolBase) buttonTool1,
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool37,
      (ToolBase) buttonTool38,
      (ToolBase) popupMenuTool10,
      (ToolBase) buttonTool47,
      (ToolBase) buttonTool48,
      (ToolBase) buttonTool49,
      (ToolBase) buttonTool50,
      (ToolBase) buttonTool51,
      (ToolBase) popupMenuTool11,
      (ToolBase) buttonTool54,
      (ToolBase) buttonTool55,
      (ToolBase) popupMenuTool12,
      (ToolBase) buttonTool62,
      (ToolBase) buttonTool63,
      (ToolBase) buttonTool64,
      (ToolBase) buttonTool65,
      (ToolBase) buttonTool66,
      (ToolBase) buttonTool67,
      (ToolBase) buttonTool68,
      (ToolBase) buttonTool69,
      (ToolBase) buttonTool70,
      (ToolBase) popupMenuTool13,
      (ToolBase) buttonTool76,
      (ToolBase) buttonTool77,
      (ToolBase) buttonTool78,
      (ToolBase) buttonTool79,
      (ToolBase) popupMenuTool14,
      (ToolBase) buttonTool80,
      (ToolBase) popupMenuTool17,
      (ToolBase) popupMenuTool18,
      (ToolBase) popupMenuTool19,
      (ToolBase) buttonTool81,
      (ToolBase) buttonTool82,
      (ToolBase) buttonTool83,
      (ToolBase) buttonTool84,
      (ToolBase) buttonTool85,
      (ToolBase) buttonTool86,
      (ToolBase) buttonTool87,
      (ToolBase) buttonTool88,
      (ToolBase) buttonTool89,
      (ToolBase) buttonTool90,
      (ToolBase) buttonTool91,
      (ToolBase) buttonTool92,
      (ToolBase) buttonTool93,
      (ToolBase) buttonTool94,
      (ToolBase) buttonTool95,
      (ToolBase) buttonTool96,
      (ToolBase) buttonTool97,
      (ToolBase) popupMenuTool20,
      (ToolBase) buttonTool98,
      (ToolBase) buttonTool99,
      (ToolBase) buttonTool100,
      (ToolBase) buttonTool101,
      (ToolBase) buttonTool102,
      (ToolBase) buttonTool103,
      (ToolBase) buttonTool104,
      (ToolBase) buttonTool105,
      (ToolBase) buttonTool106,
      (ToolBase) buttonTool107,
      (ToolBase) buttonTool108,
      (ToolBase) buttonTool109,
      (ToolBase) buttonTool110,
      (ToolBase) popupMenuTool21,
      (ToolBase) buttonTool113,
      (ToolBase) popupMenuTool22,
      (ToolBase) buttonTool114,
      (ToolBase) buttonTool115,
      (ToolBase) buttonTool116,
      (ToolBase) buttonTool117,
      (ToolBase) buttonTool118,
      (ToolBase) buttonTool119
    });
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Left).BackColor = System.Drawing.SystemColors.Control;
    this._frmPolicyDetail_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Left).Location = new Point(0, 21);
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Left).Name = "_frmPolicyDetail_Toolbars_Dock_Area_Left";
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Left).Size = new Size(0, 641);
    this._frmPolicyDetail_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Top).BackColor = System.Drawing.SystemColors.Control;
    this._frmPolicyDetail_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Top).Name = "_frmPolicyDetail_Toolbars_Dock_Area_Top";
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Top).Size = new Size(892, 21);
    this._frmPolicyDetail_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Bottom).BackColor = System.Drawing.SystemColors.Control;
    this._frmPolicyDetail_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Bottom).Location = new Point(0, 662);
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Bottom).Name = "_frmPolicyDetail_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Bottom).Size = new Size(892, 0);
    this._frmPolicyDetail_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this.pnlPolicyInfoMain.ClientArea).Controls.Add((Control) this.pnlPolicyInfo);
    ((Control) this.pnlPolicyInfoMain.ClientArea).Controls.Add((Control) this.pnlPolicyInfoLabel);
    ((Control) this.pnlPolicyInfoMain).Dock = DockStyle.Fill;
    ((Control) this.pnlPolicyInfoMain).Location = new Point(3, 3);
    ((Control) this.pnlPolicyInfoMain).Name = "pnlPolicyInfoMain";
    ((Control) this.pnlPolicyInfoMain).Size = new Size(711, 140);
    ((Control) this.pnlPolicyInfoMain).TabIndex = 8;
    this.pnlPolicyInfo.Dock = DockStyle.Fill;
    this.pnlPolicyInfo.Location = new Point(0, 19);
    this.pnlPolicyInfo.Name = "pnlPolicyInfo";
    this.pnlPolicyInfo.Size = new Size(711, 121);
    this.pnlPolicyInfo.TabIndex = 1;
    this.pnlPolicyInfoLabel.Controls.Add((Control) this.lblPolicyInfo);
    this.pnlPolicyInfoLabel.Dock = DockStyle.Top;
    this.pnlPolicyInfoLabel.Location = new Point(0, 0);
    this.pnlPolicyInfoLabel.Name = "pnlPolicyInfoLabel";
    this.pnlPolicyInfoLabel.Size = new Size(711, 19);
    this.pnlPolicyInfoLabel.TabIndex = 0;
    this.lblPolicyInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
    this.lblPolicyInfo.Dock = DockStyle.Fill;
    this.lblPolicyInfo.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold);
    this.lblPolicyInfo.ForeColor = Color.MediumBlue;
    this.lblPolicyInfo.Location = new Point(0, 0);
    this.lblPolicyInfo.Name = "lblPolicyInfo";
    this.lblPolicyInfo.Size = new Size(711, 19);
    this.lblPolicyInfo.TabIndex = 0;
    this.lblPolicyInfo.Text = "Policy Info";
    this.SplitContainer1.Dock = DockStyle.Fill;
    this.SplitContainer1.Location = new Point(3, 149);
    this.SplitContainer1.Name = "SplitContainer1";
    this.SplitContainer1.Orientation = Orientation.Horizontal;
    this.SplitContainer1.Panel1.Controls.Add((Control) this.pnlLines);
    this.SplitContainer1.Panel1.Controls.Add((Control) this.pnlLinesLabel);
    this.SplitContainer1.Panel2.Controls.Add((Control) this.pnlMiscInfo);
    this.SplitContainer1.Panel2.Controls.Add((Control) this.pnlMiscInfoLabel);
    this.SplitContainer1.Size = new Size(711, 489);
    this.SplitContainer1.SplitterDistance = 188;
    this.SplitContainer1.TabIndex = 9;
    this.pnlLines.Controls.Add((Control) this.dgParticipants);
    this.pnlLines.Dock = DockStyle.Fill;
    this.pnlLines.Location = new Point(0, 19);
    this.pnlLines.Name = "pnlLines";
    this.pnlLines.Size = new Size(711, 169);
    this.pnlLines.TabIndex = 1;
    ((UltraGridBase) this.dgParticipants).DataMember = "tblQuoteDetails";
    ((UltraGridBase) this.dgParticipants).DataSource = (object) this.dsDetail;
    appearance75.BackColor = Color.White;
    appearance75.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance75).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dgParticipants).DisplayLayout.Appearance = (AppearanceBase) appearance75;
    ((UltraGridBase) this.dgParticipants).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 296;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance76).TextHAlignAsString = "Center";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance76;
    ((AppearanceBase) appearance77).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance77;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 71;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 134;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance78).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance78;
    ultraGridColumn5.Format = "p4";
    ((AppearanceBase) appearance79).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance79;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 6;
    ultraGridColumn5.Width = 81;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance80).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance80;
    ultraGridColumn6.Format = "p4";
    ((AppearanceBase) appearance81).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance81;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Producer";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 7;
    ultraGridColumn6.Width = 79;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 8;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 9;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 10;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Rater";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 4;
    ultraGridColumn10.Width = 182;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Prog Code";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 5;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 96 /*0x60*/;
    ultraGridBand.Columns.AddRange(new object[11]
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
    ultraGridBand.Override.ColumnAutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridBand.SummaryFooterCaption = "Grand Summaries";
    ((UltraGridBase) this.dgParticipants).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgParticipants).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance82.BackColor = Color.White;
    appearance82.ForeColor = Color.Black;
    ((UltraGridBase) this.dgParticipants).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance82;
    ((UltraGridBase) this.dgParticipants).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgParticipants).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgParticipants).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgParticipants).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgParticipants).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance83.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    appearance83.ForeColor = Color.Black;
    ((UltraGridBase) this.dgParticipants).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance83;
    appearance84.BackColor = Color.White;
    appearance84.ForeColor = Color.Black;
    ((UltraGridBase) this.dgParticipants).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance84;
    ((UltraGridBase) this.dgParticipants).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((Control) this.dgParticipants).Dock = DockStyle.Fill;
    ((Control) this.dgParticipants).Location = new Point(0, 0);
    ((Control) this.dgParticipants).Name = "dgParticipants";
    ((Control) this.dgParticipants).Size = new Size(711, 169);
    ((Control) this.dgParticipants).TabIndex = 2;
    ((UltraControlBase) this.dgParticipants).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgParticipants).UseOsThemes = (DefaultableBoolean) 2;
    this.pnlLinesLabel.Controls.Add((Control) this.chkHideZeroPrem);
    this.pnlLinesLabel.Controls.Add((Control) this.lblLines);
    this.pnlLinesLabel.Dock = DockStyle.Top;
    this.pnlLinesLabel.Location = new Point(0, 0);
    this.pnlLinesLabel.Name = "pnlLinesLabel";
    this.pnlLinesLabel.Size = new Size(711, 19);
    this.pnlLinesLabel.TabIndex = 0;
    this.chkHideZeroPrem.AutoSize = true;
    this.chkHideZeroPrem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
    this.chkHideZeroPrem.Location = new Point(62, 1);
    this.chkHideZeroPrem.Name = "chkHideZeroPrem";
    this.chkHideZeroPrem.Size = new Size(192 /*0xC0*/, 17);
    this.chkHideZeroPrem.TabIndex = 2;
    this.chkHideZeroPrem.Text = "Hide Lines with Zero Premium/Fees";
    this.chkHideZeroPrem.UseVisualStyleBackColor = false;
    this.lblLines.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
    this.lblLines.Dock = DockStyle.Fill;
    this.lblLines.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold);
    this.lblLines.ForeColor = Color.MediumBlue;
    this.lblLines.Location = new Point(0, 0);
    this.lblLines.Name = "lblLines";
    this.lblLines.Size = new Size(711, 19);
    this.lblLines.TabIndex = 1;
    this.lblLines.Text = "Lines";
    this.pnlMiscInfo.Controls.Add((Control) this.imageLoading);
    this.pnlMiscInfo.Dock = DockStyle.Fill;
    this.pnlMiscInfo.Location = new Point(0, 19);
    this.pnlMiscInfo.Name = "pnlMiscInfo";
    this.pnlMiscInfo.Size = new Size(711, 278);
    this.pnlMiscInfo.TabIndex = 1;
    this.imageLoading.BackColor = Color.White;
    this.imageLoading.Image = (Image) componentResourceManager.GetObject("imageLoading.Image");
    this.imageLoading.Location = new Point(333, 80 /*0x50*/);
    this.imageLoading.Name = "imageLoading";
    this.imageLoading.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.imageLoading.SizeMode = PictureBoxSizeMode.AutoSize;
    this.imageLoading.TabIndex = 0;
    this.imageLoading.TabStop = false;
    this.pnlMiscInfoLabel.Controls.Add((Control) this.lblMiscInfo);
    this.pnlMiscInfoLabel.Dock = DockStyle.Top;
    this.pnlMiscInfoLabel.Location = new Point(0, 0);
    this.pnlMiscInfoLabel.Name = "pnlMiscInfoLabel";
    this.pnlMiscInfoLabel.Size = new Size(711, 19);
    this.pnlMiscInfoLabel.TabIndex = 0;
    this.lblMiscInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
    this.lblMiscInfo.Dock = DockStyle.Fill;
    this.lblMiscInfo.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold);
    this.lblMiscInfo.ForeColor = Color.MediumBlue;
    this.lblMiscInfo.Location = new Point(0, 0);
    this.lblMiscInfo.Name = "lblMiscInfo";
    this.lblMiscInfo.Size = new Size(711, 19);
    this.lblMiscInfo.TabIndex = 1;
    this.TableLayoutPanel1.ColumnCount = 1;
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
    this.TableLayoutPanel1.Controls.Add((Control) this.pnlPolicyInfoMain, 0, 0);
    this.TableLayoutPanel1.Controls.Add((Control) this.SplitContainer1, 0, 1);
    this.TableLayoutPanel1.Dock = DockStyle.Fill;
    this.TableLayoutPanel1.Location = new Point(175, 21);
    this.TableLayoutPanel1.Name = "TableLayoutPanel1";
    this.TableLayoutPanel1.RowCount = 2;
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle());
    this.TableLayoutPanel1.Size = new Size(717, 641);
    this.TableLayoutPanel1.TabIndex = 14;
    ((Form) this).AutoScaleBaseSize = new Size(5, 14);
    ((Form) this).ClientSize = new Size(892, 662);
    ((Control) this).Controls.Add((Control) this.TableLayoutPanel1);
    ((Control) this).Controls.Add((Control) this.leftMenu);
    ((Control) this).Controls.Add((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Right);
    ((Control) this).Controls.Add((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Left);
    ((Control) this).Controls.Add((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Bottom);
    ((Control) this).Controls.Add((Control) this._frmPolicyDetail_Toolbars_Dock_Area_Top);
    ((Control) this).Font = new Font("Tahoma", 8.25f);
    ((Control) this).ForeColor = Color.Black;
    ((Control) this).Name = nameof (frmPolicyDetail);
    ((Form) this).Text = "Policy Detail";
    this.dsDetail.EndInit();
    ((ISupportInitialize) this.leftMenu).EndInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    ((Control) this.pnlPolicyInfoMain.ClientArea).ResumeLayout(false);
    ((Control) this.pnlPolicyInfoMain).ResumeLayout(false);
    this.pnlPolicyInfoLabel.ResumeLayout(false);
    this.SplitContainer1.Panel1.ResumeLayout(false);
    this.SplitContainer1.Panel2.ResumeLayout(false);
    this.SplitContainer1.EndInit();
    this.SplitContainer1.ResumeLayout(false);
    this.pnlLines.ResumeLayout(false);
    ((ISupportInitialize) this.dgParticipants).EndInit();
    this.pnlLinesLabel.ResumeLayout(false);
    this.pnlLinesLabel.PerformLayout();
    this.pnlMiscInfo.ResumeLayout(false);
    this.pnlMiscInfo.PerformLayout();
    ((ISupportInitialize) this.imageLoading).EndInit();
    this.pnlMiscInfoLabel.ResumeLayout(false);
    this.TableLayoutPanel1.ResumeLayout(false);
    ((Control) this).ResumeLayout(false);
  }

  [field: AccessedThroughProperty("pnlPolicyInfoMain")]
  internal virtual UltraPanel pnlPolicyInfoMain { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlPolicyInfo")]
  internal virtual Panel pnlPolicyInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlPolicyInfoLabel")]
  internal virtual Panel pnlPolicyInfoLabel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPolicyInfo")]
  internal virtual Label lblPolicyInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlLinesLabel")]
  internal virtual Panel pnlLinesLabel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLines")]
  internal virtual Label lblLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual CheckBox chkHideZeroPrem
  {
    get => this._chkHideZeroPrem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkHideZeroPrem_CheckedChanged);
      CheckBox chkHideZeroPrem1 = this._chkHideZeroPrem;
      if (chkHideZeroPrem1 != null)
        chkHideZeroPrem1.CheckedChanged -= eventHandler;
      this._chkHideZeroPrem = value;
      CheckBox chkHideZeroPrem2 = this._chkHideZeroPrem;
      if (chkHideZeroPrem2 == null)
        return;
      chkHideZeroPrem2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("pnlLines")]
  internal virtual Panel pnlLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public virtual UltraGrid dgParticipants
  {
    get => this._dgParticipants;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.dgParticipants_InitializeRow);
      UltraGrid dgParticipants1 = this._dgParticipants;
      if (dgParticipants1 != null)
        dgParticipants1.InitializeRow -= initializeRowEventHandler;
      this._dgParticipants = value;
      UltraGrid dgParticipants2 = this._dgParticipants;
      if (dgParticipants2 == null)
        return;
      dgParticipants2.InitializeRow += initializeRowEventHandler;
    }
  }

  [field: AccessedThroughProperty("pnlMiscInfoLabel")]
  internal virtual Panel pnlMiscInfoLabel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMiscInfo")]
  internal virtual Label lblMiscInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("imageLoading")]
  internal virtual PictureBox imageLoading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TableLayoutPanel1")]
  internal virtual TableLayoutPanel TableLayoutPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlMiscInfo")]
  protected virtual Panel pnlMiscInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SplitContainer1")]
  protected virtual SplitContainer SplitContainer1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private int DistinctRaterCount => this.GetDistinctRaterIDs().Count;

  private bool MultipleRaters => this.DistinctRaterCount > 1;

  private bool IgnoreCompanyLineRequirementsOnPrintIndication
  {
    get
    {
      if (!this._ignoreCompLineReqOnPrintIndication.HasValue)
        this._ignoreCompLineReqOnPrintIndication = new bool?(SystemSettings.GetSetting<bool>("IgnoreCompanyLineRequirementsOnPrintingIndication", false));
      return this._ignoreCompLineReqOnPrintIndication.GetValueOrDefault();
    }
  }

  private bool GenerateChildPolicyNumbers
  {
    get
    {
      dsPolicyDetail.tblQuoteDetailsDataTable dataSource = (dsPolicyDetail.tblQuoteDetailsDataTable) ((UltraGridBase) this.dgParticipants).DataSource;
      bool childPolicyNumbers;
      if (dataSource != null && dataSource.Count <= 1)
        childPolicyNumbers = false;
      else
        childPolicyNumbers = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(QuoteDetailID) FROM dbo.tblQuoteDetails WITH (NOLOCK) WHERE QuoteGuid= @QG AND PolicyNumber IS NOT NULL", new object[2]
        {
          (object) "@QG",
          (object) this._quote.QuoteGuid
        }) <= 0;
      return childPolicyNumbers;
    }
  }

  protected PolicyDetail_Premiums PremiumsControl
  {
    get
    {
      return this.pnlMiscInfo.Controls.Count != 1 ? (!(this.pnlMiscInfo.Controls[1] is PolicyDetail_Premiums) ? (PolicyDetail_Premiums) this._cachedPlugins["Premiums"] : (PolicyDetail_Premiums) this.pnlMiscInfo.Controls[1]) : (PolicyDetail_Premiums) null;
    }
  }

  protected virtual bool NetRateRatedOptionExists
  {
    get
    {
      bool ratedOptionExists;
      if (this._quote != null)
        ratedOptionExists = this._quote.NetRateRatedOptionExists;
      return ratedOptionExists;
    }
  }

  protected virtual bool ShowNetRateAdditionalInfoMenu => this.NetRateRatedOptionExists;

  public bool ReconnectNetRateData
  {
    get => this._reconnectNetRateData;
    set => this._reconnectNetRateData = value;
  }

  public bool UpdateNetRateXML
  {
    get => this._updateNetRateXML;
    set => this._updateNetRateXML = value;
  }

  public XmlDocument NetRateXMLDoc
  {
    get => this._NetRateXMLDoc;
    set => this._NetRateXMLDoc = value;
  }

  public bool UpdateNetRatePremiumData
  {
    get => this._updateNetRatePremiumData;
    set => this._updateNetRatePremiumData = value;
  }

  public Quote Quote => this._quote;

  public bool ClickPrintIndication => this._printingIndication;

  [CLSCompliant(false)]
  public AuthorityLimitCheckManager AuthorityLimitCheckManager => this._authorityLimitCheckManager;

  [CLSCompliant(false)]
  public ThresholdLimitCheckManager ThresholdLimitCheckManager => this._thresholdLimitCheckManager;

  public static CultureInfo CurrentCultureInfo => frmPolicyDetail._cultureInfo;

  public static bool CurrentMultiCurrency => frmPolicyDetail._isMultiCurrency;

  public static string CurrencyCodeOnQuote => frmPolicyDetail._currencyCode;

  public static bool ImplementCurrencyDisplay => frmPolicyDetail._implementCurrencyDisplay;

  public frmPolicyDetail(int controlNumber)
    : this()
  {
    try
    {
      Quote quote1 = Quote.FromControlNo(controlNumber);
      if (!(quote1 is Quote quote2))
        quote2 = frmPolicyDetail.CreateQuote(quote1.QuoteGuid);
      this._quote = quote2;
      this._quote.EndorsementCreated += new Quote.EndorsementCreatedEventHandler(this.EndorsementCreated);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public frmPolicyDetail(Guid quoteGuid)
    : this()
  {
    try
    {
      this._quote = frmPolicyDetail.CreateQuote(quoteGuid);
      this._quote.EndorsementCreated += new Quote.EndorsementCreatedEventHandler(this.EndorsementCreated);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public frmPolicyDetail()
  {
    ((Form) this).Load += new EventHandler(this.frmPolicyDetail_Load);
    this._cachedPlugins = new Dictionary<string, PolicyDetail_Plugin>();
    this._additionalInterestOfacTypes = new HashSet<string>((IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
    this._newOptionsAdded = false;
    this._reconnectNetRateData = false;
    this._updateNetRatePremiumData = false;
    this._showBindinRequirementChecklistScreen = false;
    this._updateNetRateXML = false;
    this._printingIndication = false;
    this._showNetRateQuoteIDDialog = false;
    this._alreadyRefreshMerged = false;
    this._showPreviewPolicyMenuOnUnboundPolicy = false;
    this._validateOfacClears = SystemSettings.GetLazySetting<bool>("OFAC.Policy.ValidateClears", false, true);
    this._runOfacComplianceChecks = SystemSettings.GetLazySetting<bool>("OFAC.Policy.RunCompliance", false, true);
    this._runOfacOnAdditionalInterest = SystemSettings.GetLazySetting<bool>("OFAC.AdditionalInterest.RunCompliance", false, true);
    this._validatePolicyCompliance = SystemSettings.GetLazySetting<bool>("OFAC.Policy.ValidateCompliance", this._runOfacComplianceChecks, true);
    this._validateOnQuote = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Quote.CheckCompliance", true, true);
    this._checkOfacOnQuoteIfMissing = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Quote.CheckIfMissing", false, true);
    this._bypassOfacSystemOnQuote = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Quote.BypassOfacSystem", false, true);
    this._validateOnBind = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Bind.CheckCompliance", true, true);
    this._checkOfacOnBindIfMissing = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Bind.CheckIfMissing", false, true);
    this._bypassZeroPremEndtCheckOnBind = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Bind.IgnoreNonZeroEndorsements", false, true);
    this._bypassOfacSystemOnBind = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Bind.BypassOfacSystem", false, true);
    this._validateOnPolicyIssuance = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Issue.CheckCompliance", false, true);
    this._checkOfacOnIssueIfMissing = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Issue.CheckIfMissing", false, true);
    this._bypassOfacSystemOnIssue = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Issue.BypassOfacSystem", false, true);
    this._assignPolicyNumber = SystemSettings.GetLazySetting<bool>("CanAssignPolicyNumber", false, true);
    this.InitializeComponent();
  }

  public frmPolicyDetail(Quote quote)
  {
    ((Form) this).Load += new EventHandler(this.frmPolicyDetail_Load);
    this._cachedPlugins = new Dictionary<string, PolicyDetail_Plugin>();
    this._additionalInterestOfacTypes = new HashSet<string>((IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
    this._newOptionsAdded = false;
    this._reconnectNetRateData = false;
    this._updateNetRatePremiumData = false;
    this._showBindinRequirementChecklistScreen = false;
    this._updateNetRateXML = false;
    this._printingIndication = false;
    this._showNetRateQuoteIDDialog = false;
    this._alreadyRefreshMerged = false;
    this._showPreviewPolicyMenuOnUnboundPolicy = false;
    this._validateOfacClears = SystemSettings.GetLazySetting<bool>("OFAC.Policy.ValidateClears", false, true);
    this._runOfacComplianceChecks = SystemSettings.GetLazySetting<bool>("OFAC.Policy.RunCompliance", false, true);
    this._runOfacOnAdditionalInterest = SystemSettings.GetLazySetting<bool>("OFAC.AdditionalInterest.RunCompliance", false, true);
    this._validatePolicyCompliance = SystemSettings.GetLazySetting<bool>("OFAC.Policy.ValidateCompliance", this._runOfacComplianceChecks, true);
    this._validateOnQuote = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Quote.CheckCompliance", true, true);
    this._checkOfacOnQuoteIfMissing = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Quote.CheckIfMissing", false, true);
    this._bypassOfacSystemOnQuote = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Quote.BypassOfacSystem", false, true);
    this._validateOnBind = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Bind.CheckCompliance", true, true);
    this._checkOfacOnBindIfMissing = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Bind.CheckIfMissing", false, true);
    this._bypassZeroPremEndtCheckOnBind = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Bind.IgnoreNonZeroEndorsements", false, true);
    this._bypassOfacSystemOnBind = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Bind.BypassOfacSystem", false, true);
    this._validateOnPolicyIssuance = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Issue.CheckCompliance", false, true);
    this._checkOfacOnIssueIfMissing = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Issue.CheckIfMissing", false, true);
    this._bypassOfacSystemOnIssue = SystemSettings.GetLazySetting<bool>("OFAC.PolicyDetail.Issue.BypassOfacSystem", false, true);
    this._assignPolicyNumber = SystemSettings.GetLazySetting<bool>("CanAssignPolicyNumber", false, true);
    this._quote = quote;
  }

  private void LoadControls()
  {
    if (this._statusChangeMenu == null)
      this._statusChangeMenu = ObjectFactory.Instance.CreateObjectAs<QuoteStatusChangeMenu>(new object[1]
      {
        (object) (PopupMenuTool) ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Policy"]
      });
    this._statusChangeMenu.EnableDisableItems((Quote) this._quote);
    UserControl objectEx = (UserControl) ObjectFactory.Instance.CreateObjectEX(typeof (PolicyDetail_PolicyInfo), new object[1]
    {
      (object) this._quote.QuoteGuid
    });
    objectEx.Dock = DockStyle.Fill;
    objectEx.Visible = false;
    this.pnlPolicyInfo.Controls.Add((Control) objectEx);
    objectEx.Visible = true;
    this.RefreshPolicyData(false);
  }

  private void frmPolicyDetail_Load(object sender, EventArgs e)
  {
    if (((Component) this).DesignMode)
      return;
    this.EnableRatingButton();
    try
    {
      this._viewCompanyCommissions = SecurityManager.Instance.AssertPermission("{BA0D58C3-9159-4f16-9474-5C313C8D20F7}");
      this._viewProducerCommissions = SecurityManager.Instance.AssertPermission("{650C55A1-7C7B-4AA7-9116-D2801432324A}");
      this._numDetailRows = this.Quote.QuoteDetails.Count;
      this._canViewAssignPolicyNumber = SecurityManager.Instance.AssertPermission("{ED84C3E0-A441-4D8F-9E9A-299E05BD4550}");
      UltraExplorerBarGroup group = this.leftMenu.Groups["PolicyActions"];
      group.Items["PrintIndication"].Visible = false;
      group.Items["Print"].Visible = false;
      group.Items["Commissions"].Visible = false;
      group.Items["Fees"].Visible = false;
      group.Items["Rating"].Visible = false;
      this._showBindinRequirementChecklistScreen = SystemSettings.GetSetting<bool>("ShowBindingRequirementsChecklistScreens", false);
      if (this._runOfacOnAdditionalInterest.Value)
        this._additionalInterestOfacTypes.UnionWith((IEnumerable<string>) AdditionalInterest.OfacSearchTypes);
      this._canOverrideBindOfacHits = SecurityManager.Instance.AssertPermission("{7D8CFDE5-161F-4915-BBCA-447D045F95F7}");
      this._canOverrideQuoteOfacHits = SecurityManager.Instance.AssertPermission("{BB752B7F-0B69-4B31-92C5-4873EFF14DE7}");
      this._canOverrideIssueOfacHits = SecurityManager.Instance.AssertPermission("{8015A728-9A1A-4C87-B33F-ED56DC0C2E27}");
      this._canOverrideEndorsementOfacHits = SecurityManager.Instance.AssertPermission("{27E6A377-4DE5-481B-BC02-D785A4F381DE}");
      this._canOverrideQuoteAIOfacHits = SecurityManager.Instance.AssertPermission("{25B7B6FC-89E7-4C96-9B9B-7CB5DEE1F7E9}");
      if (SecurityManager.Instance.AssertPermission("{E86119E8-7146-49B2-84AC-3C9D4B403910}"))
      {
        try
        {
          this.AddPolicyMenuItem("AdminRerunOfac", "Rerun Insured OFAC");
          if (this.Quote.SearchQuoteOfac)
            this.AddPolicyMenuItem("AdminRerunPolicyOfac", "Rerun Policy OFAC");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    this._ShowChildToolTipOnMinimize = SystemSettings.GetSetting<bool>("PolicyDetail.ShowChildTooltipOnMinimize", true);
    this._runAuthorityLimitCheck = SystemSettings.GetSetting<bool>("RunAuthorityLimiCheck", false);
    this._runAuthorityCheckAtStartup = AuthorityLimitCheckManager.RunAuthorityCheckAtStartup;
    this._runThresholdLimitCheck = SystemSettings.GetSetting<bool>("RunThresholdLimitCheck", false);
    this._runThresholdCheckAtStartup = ThresholdLimitCheckManager.RunThresholdCheckAtStartup;
    frmPolicyDetail._currencyCode = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "Select dbo.GetQuoteCurrencyCode(@quoteId)", new object[2]
    {
      (object) "@QuoteId",
      (object) this._quote.QuoteID
    });
    frmPolicyDetail._cultureInfo = MultiCurrencyUtilities.GetCultureInfo(frmPolicyDetail._currencyCode);
    frmPolicyDetail._isMultiCurrency = MultiCurrencyUtilities.IsMultiCurrencyActive();
    frmPolicyDetail._implementCurrencyDisplay = SystemSettings.GetSetting<bool>("Currency.ImplementDollarDisplay", false);
    this._printQuoteOnInactiveLine = SecurityManager.Instance.AssertPermission("{2080A07F-0DCC-40A4-9D75-7BDAE4A8A13E}");
    this.LoadControls();
    string str = DefaultDatabase.ExecuteScalar<string>("dbo.spGetPolicyDetailBOR", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.Quote.QuoteGuid
    });
    if (!string.IsNullOrEmpty(str))
      this.lblPolicyInfo.Text = $"{this.lblPolicyInfo.Text} - {str}";
    ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Insured Quotes"].BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.InsuredQuotesBeforeToolDropDown);
    ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Submission Quotes"].BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.SubmissionQuotesBeforeToolDropDown);
    this._insuredQuotesHash = new List<Guid>();
    this._submissionQuoteHash = new List<Guid>();
    this._submissionStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Policies.free_icons_30.gif");
    this._insuredStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Policies.free_icons_33.gif");
    ((UltraGridBase) this.dgParticipants).DisplayLayout.Bands[0].Columns["CompanyCommission"].Hidden = !this._viewCompanyCommissions;
    ((UltraGridBase) this.dgParticipants).DisplayLayout.Bands[0].Columns["ProducerCommission"].Hidden = !this._viewProducerCommissions;
    this.chkHideZeroPrem.Visible = SystemSettings.GetSetting<bool>("PolicyDetail.ShowHideZeroPremimCheckBox", false);
    this.AddQuoteReports();
    this.SetSecurity();
    if (this._quote == null)
      return;
    ((Form) this).Text = "Policy Detail - Control #: " + Conversions.ToString(this._quote.ControlNo);
    this.tip = new ToolTip();
    this.FrmLastState = ((Form) this).WindowState;
  }

  protected virtual void WndProc(ref Message m)
  {
    if (!Information.IsNothing((object) this.tip) && m.Msg == 160 /*0xA0*/ && ((Form) this).WindowState == FormWindowState.Minimized && string.IsNullOrEmpty(this.tip.GetToolTip((Control) this)) && this._ShowChildToolTipOnMinimize)
      this.tip.Show($"{Conversions.ToString(this._quote.ControlNo)} || {this._quote.InsuredName} || {this._quote.LineName}", (IWin32Window) this, ((Control) this).PointToClient(Control.MousePosition), 1000);
    // ISSUE: explicit non-virtual call
    __nonvirtual (((Form) this).WndProc(ref m));
  }

  protected virtual void OnMove(EventArgs e)
  {
    if (!Information.IsNothing((object) this.tip))
      this.tip.SetToolTip((Control) this, string.Empty);
    // ISSUE: explicit non-virtual call
    __nonvirtual (((Control) this).OnMove(e));
  }

  protected void OnWindowStateChanged(EventArgs e)
  {
    if (!Information.IsNothing((object) this.tip))
      this.tip.SetToolTip((Control) this, string.Empty);
    // ISSUE: explicit non-virtual call
    __nonvirtual (((Control) this).OnMove(e));
  }

  protected virtual void OnClientSizeChanged(EventArgs e)
  {
    if (((Form) this).WindowState != this.FrmLastState && this._ShowChildToolTipOnMinimize)
    {
      this.FrmLastState = ((Form) this).WindowState;
      this.OnWindowStateChanged(e);
    }
    // ISSUE: explicit non-virtual call
    __nonvirtual (((Control) this).OnClientSizeChanged(e));
  }

  private void SetSecurity()
  {
    if (!SecurityManager.Instance.AssertPermission("{68CE5575-83C7-4df5-BB23-F9AA9747D39A}"))
      this.leftMenu.Groups["PolicyActions"].Items["EditPolicy"].Settings.Enabled = (DefaultableBoolean) 2;
    this._showPreviewPolicyMenuOnUnboundPolicy = SecurityManager.Instance.AssertPermission("{9C3ECEB4-F10E-4C37-AFAE-7ADC811CFA0A}");
  }

  public void InsuredQuotesBeforeToolDropDown(object sender, BeforeToolDropdownEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((CancelableToolEventArgs) e).Tool.Key, "Insured Quotes", false) != 0 || this._insuredQuotesHash.Contains(this.Quote.SubmissionGroupGuid))
      return;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT DISTINCT q.ControlNo, q.PolicyNumber, q.EffectiveDate FROM dbo.tblSubmissionGroup sg WITH (NOLOCK) JOIN dbo.tblQuotes q WITH (NOLOCK) ON q.SubmissionGroupGuid = sg.SubmissionGroupGUID WHERE sg.InsuredGuid = @insGuid", new object[2]
    {
      (object) "@insGUID",
      (object) this.Quote.SubmissionGroup.InsuredGuid
    });
    int num = 0;
    Bitmap bitmap = new Bitmap(this._insuredStream);
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        if (row.Field<int>(0) != this.ControlNumber)
        {
          string str1 = row.Field<string>(1);
          string str2 = string.IsNullOrEmpty(str1) ? "" : ",  Pol #" + str1;
          string str3 = row.IsNull(2) ? "" : ",  Effective - " + row[2].ToString();
          string str4 = $"Control #{RuntimeHelpers.GetObjectValue(row[0])}{str2}{str3}";
          if (!((ToolsCollectionBase) this.UltraToolbarsManager1.Tools).Exists(str4))
          {
            ButtonTool buttonTool = new ButtonTool(str4);
            ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = str4;
            ((SubObjectBase) buttonTool).Tag = RuntimeHelpers.GetObjectValue(row[0]);
            ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Policy"].ToolbarsManager.Tools.Add((ToolBase) buttonTool);
            ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Related Quotes"]).Tools)["Insured Quotes"]).Tools.AddTool(str4);
            ((ToolPropsBase) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Related Quotes"]).Tools)["Insured Quotes"]).Tools)[str4].SharedProps).AppearancesSmall.Appearance.Image = (object) bitmap;
            ++num;
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
    ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Related Quotes"]).Tools)["Insured Quotes"].SharedProps.Visible = num > 0;
    this.UltraToolbarsManager1.RefreshMerge();
    this._insuredQuotesHash.Add(this.Quote.SubmissionGroupGuid);
  }

  public void SubmissionQuotesBeforeToolDropDown(object sender, BeforeToolDropdownEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((CancelableToolEventArgs) e).Tool.Key, "Submission Quotes", false) != 0 || this._submissionQuoteHash.Contains(this.Quote.SubmissionGroupGuid))
      return;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT DISTINCT ControlNo, PolicyNumber, EffectiveDate FROM dbo.tblQuotes WITH (NOLOCK) WHERE SubmissionGroupGuid = @subGUID", new object[2]
    {
      (object) "@subGUID",
      (object) this.Quote.SubmissionGroupGuid
    });
    Bitmap bitmap = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Policies.free_graphics_cyansphere.gif"));
    int num = 0;
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        if (row.Field<int>(0) != this.ControlNumber)
        {
          string str1 = row.Field<string>(1);
          string str2 = string.IsNullOrEmpty(str1) ? "" : ",  Pol #" + str1;
          string str3 = row.IsNull(2) ? "" : ",  Effective - " + row[2].ToString();
          string str4 = $"Control #{RuntimeHelpers.GetObjectValue(row[0])}{str2}{str3}";
          if (!((ToolsCollectionBase) this.UltraToolbarsManager1.Tools).Exists(str4))
          {
            ButtonTool buttonTool = new ButtonTool(str4);
            ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = str4;
            ((SubObjectBase) buttonTool).Tag = RuntimeHelpers.GetObjectValue(row[0]);
            ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Policy"].ToolbarsManager.Tools.Add((ToolBase) buttonTool);
            ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Related Quotes"]).Tools)["Submission Quotes"]).Tools.AddTool(str4);
            ((ToolPropsBase) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Related Quotes"]).Tools)["Submission Quotes"]).Tools)[str4].SharedProps).AppearancesSmall.Appearance.Image = (object) bitmap;
            ++num;
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
    if (this._submissionStream != null)
      ((ToolPropsBase) ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["New Quote"].SharedProps).AppearancesSmall.Appearance.Image = (object) new Bitmap(this._submissionStream);
    ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Related Quotes"]).Tools)["Submission Quotes"].SharedProps.Visible = num > 0;
    this.UltraToolbarsManager1.RefreshMerge();
    this._submissionQuoteHash.Add(this.Quote.SubmissionGroupGuid);
  }

  private void AddQuoteReports()
  {
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new ClearanceContextMenuAttribute());
    int index1 = 0;
    while (index1 < typeArray.Length)
    {
      Type myType = typeArray[index1];
      object[] customAttributes = myType.GetCustomAttributes(false);
      int index2 = 0;
      while (index2 < customAttributes.Length)
      {
        if (RuntimeHelpers.GetObjectValue(customAttributes[index2]) is ClearanceContextMenuAttribute objectValue)
        {
          if (objectValue.Level == 2)
          {
            try
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(myType.BaseType.Name, "MGAExcelReport", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(myType.BaseType.Name, "MGAReport", false) == 0)
              {
                Attribute attributeFromType = ObjectFactory.GetAttributeFromType(myType, (Attribute) new SecureReportResourceAttribute());
                if (attributeFromType == null)
                {
                  if (objectValue.Folder.Contains("Reports|"))
                  {
                    string str = Strings.Mid(objectValue.Folder, Strings.Len(objectValue.Folder) - objectValue.Folder.IndexOf("|") + 1);
                    if (!((ToolsCollectionBase) this.UltraToolbarsManager1.Tools).Exists(str))
                    {
                      PopupMenuTool popupMenuTool = new PopupMenuTool(str);
                      ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = str;
                      this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[1]
                      {
                        (ToolBase) popupMenuTool
                      });
                      ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Policy"]).Tools)["Reports"]).Tools).AddRange(new ToolBase[1]
                      {
                        (ToolBase) popupMenuTool
                      });
                    }
                    this.AddQuoteReportsMenuItem(myType, objectValue, objectValue.Folder);
                  }
                  else
                    this.AddQuoteReportsMenuItem(myType, objectValue, "Reports");
                }
                else if (!SecurityManager.Instance.IsPermissionDenied(((SecureResourceAttribute) attributeFromType).UniqueIdentifier))
                {
                  if (objectValue.Folder.Contains("Reports|"))
                  {
                    string str = Strings.Mid(objectValue.Folder, Strings.Len(objectValue.Folder) - objectValue.Folder.IndexOf("|") + 1);
                    if (!((ToolsCollectionBase) this.UltraToolbarsManager1.Tools).Exists(str))
                    {
                      PopupMenuTool popupMenuTool = new PopupMenuTool(str);
                      ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = str;
                      this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[1]
                      {
                        (ToolBase) popupMenuTool
                      });
                      ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Policy"]).Tools)["Reports"]).Tools).AddRange(new ToolBase[1]
                      {
                        (ToolBase) popupMenuTool
                      });
                    }
                    this.AddQuoteReportsMenuItem(myType, objectValue, objectValue.Folder);
                  }
                  else
                    this.AddQuoteReportsMenuItem(myType, objectValue, "Reports");
                }
              }
              else
                this.AddQuoteReportsMenuItem(myType, objectValue, "Reports");
            }
            catch (InvalidOperationException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              InvalidOperationException operationException = ex;
              ErrorHandler.HandleError(operationException.Message, operationException.InnerException);
              ProjectData.ClearProjectError();
            }
          }
        }
        checked { ++index2; }
      }
      checked { ++index1; }
    }
  }

  private void AddQuoteReportsMenuItem(
    Type myType,
    ClearanceContextMenuAttribute ccma,
    string report_menu)
  {
    this.AddMenuItem(myType.ToString(), ccma.Caption, report_menu);
    ((SubObjectBase) ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)[myType.ToString()]).Tag = (object) ccma;
    Bitmap bitmap = new Bitmap(this._insuredStream);
    if (bitmap != null)
      ((ToolPropsBase) ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)[myType.ToString()].SharedProps).AppearancesSmall.Appearance.Image = (object) bitmap;
    this.UltraToolbarsManager1.RefreshMerge();
  }

  private bool ShowReports(string toolKey)
  {
    bool flag;
    if (((SubObjectBase) ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)[toolKey]).Tag is ClearanceContextMenuAttribute)
    {
      object objectValue1 = RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObject(ObjectFactory.Instance.CreateTypeFromString(toolKey)));
      switch (objectValue1)
      {
        case MGAReport _:
          ReportFactory.Instance.ShowReport(false, ObjectFactory.Instance.CreateTypeFromString(toolKey), new object[1]
          {
            (object) this.Quote.QuoteGuid
          });
          break;
        case ThirdPartyReport _:
          ReportFactory.Instance.ShowThirdPartyReport(false, ObjectFactory.Instance.CreateTypeFromString(toolKey), new object[1]
          {
            (object) this.Quote.QuoteGuid
          });
          break;
        case MGAExcelReport _:
          ReportFactory.Instance.ExportReport(ObjectFactory.Instance.CreateTypeFromString(toolKey), new object[1]
          {
            (object) this.Quote.QuoteGuid
          });
          break;
        case GenericAutomationReport _:
          object[] customAttributes = objectValue1.GetType().GetCustomAttributes(true);
          int index = 0;
          Guid automationReportGuid;
          while (index < customAttributes.Length)
          {
            object objectValue2 = RuntimeHelpers.GetObjectValue(customAttributes[index]);
            if (objectValue2 is AutomationReportAttribute)
              automationReportGuid = ((AutomationReportAttribute) objectValue2).AutomationReportGuid;
            checked { ++index; }
          }
          CompanyDocumentAutomation documentAutomation = new CompanyDocumentAutomation(automationReportGuid, this._quote.CompanyLine.CompanyLineID);
          CompanyDocumentAutomation.Initialize();
          documentAutomation.QuoteGuid = this._quote.QuoteGuid;
          documentAutomation.CreatePDFPackage();
          break;
        default:
          flag = false;
          goto label_14;
      }
      flag = true;
    }
    else
      flag = false;
label_14:
    return flag;
  }

  private bool ViewUnderwritingLocationsMenu()
  {
    bool flag;
    if (SystemSettings.GetSetting<bool>("AlwaysViewUnderwritingLocations", false))
    {
      flag = true;
    }
    else
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT DISTINCT RaterID FROM tblQuoteDetails WITH (NOLOCK) WHERE QuoteGuid = @QuoteGuid", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quote.QuoteGuid
      });
      try
      {
        foreach (DataRow row in dataTable.Rows)
        {
          if (row[0] != DBNull.Value)
          {
            IRater rater = RaterFactory.GetRater(Conversions.ToInteger(row[0]));
            if (rater != null && rater.SupportsUnderwritingLocations)
            {
              flag = true;
              goto label_12;
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
      flag = false;
    }
label_12:
    return flag;
  }

  protected virtual bool EnableNoticeOfCancellation() => false;

  private void SetupMenusThread(object state)
  {
    try
    {
      bool canViewFilingProducersMenu;
      try
      {
        int num = this._quote.CompanyLine.IsAdmitted ? 1 : 0;
        canViewFilingProducersMenu = SecurityManager.Instance.AssertPermission("{EB46BFBA-6C16-45F7-BFE5-7951B0DFD8E8}");
      }
      catch (InvalidOperationException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
        ProjectData.ClearProjectError();
        return;
      }
      bool canViewInstallment = SystemSettings.GetSetting<bool>("ViewCreateInstallmentMenu", false) && SecurityManager.Instance.AssertPermission("{E073074D-08EB-4A38-8FD6-EC35ECE810CE}");
      this._menuArgs = new frmPolicyDetail.SetupMenusEventArgs(this._quote.IsEndorsement, this._quote.IsBound, this._quote.HasPremium, this._quote.IsCancelled, this._quote.UnderNotice, this._quote.CompanyLine.IsAdmitted, this._quote.IsBound || this._quote.QuoteStatus == 6 || this.EnableNoticeOfCancellation(), this._quote.PolicyIsIssued, this._quote.IsOriginalQuoteRecord, this._quote.InvoiceCount, this._quote.IsCurrent, this._quote.RelatedQuotes, this.ViewUnderwritingLocationsMenu(), this._quote.CanUnbind, this._quote.IsBound && this._quote.IsBatchIssuance, this.Quote.IsInternalCorrectionTransaction, this.Quote.IsDownwardInternalCorrectionTransaction, canViewFilingProducersMenu, canViewInstallment);
      try
      {
        if (!((Control) this).IsHandleCreated || ((Control) this).IsDisposed || ((Control) this).Disposing)
          return;
        InvokeExtensions.BetterInvoke((ISynchronizeInvoke) this, (Delegate) new frmPolicyDetail.SetupMenusHandler(this.SetupMenus), new object[2]
        {
          (object) this,
          (object) this._menuArgs
        });
      }
      catch (ObjectDisposedException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
    catch (DatabaseException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void SetupMenus(object sender, frmPolicyDetail.SetupMenusEventArgs e)
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual bool CanClientCreateEndorsemnetMenuItem() => true;

  private void SetupToolbarItems(frmPolicyDetail.SetupMenusEventArgs e)
  {
    UltraExplorerBarItem ultraExplorerBarItem = this.leftMenu.Groups["PolicyActions"].Items["Print"];
    if (e.IsBound)
      ultraExplorerBarItem.Text = !e.IsEndorsement ? "Print Binder" : "Print Endorsement";
    else if (e.IsEndorsement)
      ultraExplorerBarItem.Visible = false;
    else
      ultraExplorerBarItem.Text = "Print Quote";
    UltraExplorerBarGroup group = this.leftMenu.Groups["PolicyActions"];
    group.Items["Print"].Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(group.Items["Print"].Text, "Print Quote", false) != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(group.Items["Print"].Text, "Print Binder", false) != 0 ? e.HasPremium || e.IsEndorsement : SecurityManager.Instance.AssertPermission("{A92F0FB9-8924-4126-9DDD-7C53B16E5B32}")) : (!this.ShouldRunLimitCheck(true) ? e.HasPremium || e.IsEndorsement : this._authorityLimitCheckManager.ShowQuotePrintMenu() && (e.HasPremium || e.IsEndorsement) && this._thresholdLimitCheckManager.ShowQuotePrintMenu());
    group.Items["Commissions"].Visible = e.HasPremium;
    group.Items["Fees"].Visible = (e.HasPremium || e.IsEndorsement) && !e.IsInternalCorrection;
    group.Items["Bind"].Visible = !this.ShouldRunLimitCheck(true) ? !e.IsBound : !e.IsBound && this._authorityLimitCheckManager.ShowBindMenu(e.IsBound) && this._thresholdLimitCheckManager.ShowBindMenu(e.IsBound);
    group.Items["Commissions"].Visible = this._viewProducerCommissions && this._viewCompanyCommissions;
    group.Items["PrintIndication"].Visible = !e.IsBound;
    group.Items["Rating"].Visible = !e.IsInternalCorrection;
    this.SetupToolbarItemsOnClient();
  }

  private bool ShouldRunLimitCheck(bool runAtStart)
  {
    if (this._runAuthorityLimitCheck && this._runAuthorityCheckAtStartup == runAtStart && this._authorityLimitCheckManager != null)
      return true;
    return this._runThresholdLimitCheck && this._runThresholdCheckAtStartup == runAtStart && this._thresholdLimitCheckManager != null;
  }

  private bool ViewAssignPolicyNumberMenuItem(frmPolicyDetail.SetupMenusEventArgs e)
  {
    return !e.IsEndorsement && this._assignPolicyNumber.Value && this.ValidAssignPolicyMenuStatus(e.IsBound) && this._canViewAssignPolicyNumber;
  }

  protected virtual bool ValidAssignPolicyMenuStatus(bool isPolicyBound) => !isPolicyBound;

  internal void SetupMenus()
  {
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.SetupMenusThread));
  }

  public void RefreshPremiums()
  {
    if (this == null || this.PremiumsControl == null)
      return;
    this.PremiumsControl.Fill();
  }

  public void RefreshPolicyData() => this.RefreshPolicyData(true);

  public void RefreshPolicyData(bool refreshQuote)
  {
    if (this.pnlMiscInfo.Controls.Count > 1)
      this._cachedPlugins.Clear();
    if (refreshQuote)
    {
      this._quote.EndorsementCreated -= new Quote.EndorsementCreatedEventHandler(this.EndorsementCreated);
      this._quote = frmPolicyDetail.CreateQuote(this._quote.QuoteGuid);
      this._quote.EndorsementCreated += new Quote.EndorsementCreatedEventHandler(this.EndorsementCreated);
    }
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedLoad));
  }

  public void RefreshFees()
  {
    if (this == null || this.PremiumsControl == null)
      return;
    this.AutoApplyFeesAndRefreshPolicyDetail();
  }

  internal void UpdateFactorSet(Guid companyLineGuid, Guid factorSetGuid)
  {
    if (((UltraGridBase) this.dgParticipants).DataSource == null || ((UltraGridBase) this.dgParticipants).DataSource == DBNull.Value)
      return;
    dsPolicyDetail.tblQuoteDetailsDataTable dataSource = (dsPolicyDetail.tblQuoteDetailsDataTable) ((UltraGridBase) this.dgParticipants).DataSource;
    if (dataSource.FindByCompanyLineGuid(companyLineGuid) == null)
      return;
    dataSource.FindByCompanyLineGuid(companyLineGuid).FactorSetGuid = factorSetGuid;
  }

  internal void UpdateRater(Guid companyLineGuid, int raterID)
  {
    if (((UltraGridBase) this.dgParticipants).DataSource == null || ((UltraGridBase) this.dgParticipants).DataSource == DBNull.Value)
      return;
    ((dsPolicyDetail.tblQuoteDetailsDataTable) ((UltraGridBase) this.dgParticipants).DataSource).FindByCompanyLineGuid(companyLineGuid).RaterID = raterID;
  }

  private void ThreadedLoad(object state)
  {
    Thread.Sleep(250);
    this.SetupMenusThread((object) null);
    if (this.pnlPolicyInfo.Controls.Count > 0)
    {
      try
      {
        foreach (Control control in this.pnlPolicyInfo.Controls)
        {
          if (control is PolicyDetail_PolicyInfo)
            ((PolicyDetail_PolicyInfo) control).ThreadedLoad();
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    dsPolicyDetail.tblQuoteDetailsDataTable detailsDataTable = new dsPolicyDetail.tblQuoteDetailsDataTable();
    DefaultDatabase.LoadDataTable((DataTable) detailsDataTable, "dbo.spPolicyDetail_Companies", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.Quote.QuoteGuid
    });
    if (!((Control) this).IsHandleCreated || ((Control) this).IsDisposed || ((Control) this).Disposing)
      return;
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new frmPolicyDetail.CompanyDataRetrievedHandler(this.CompanyDataRetrieved), new object[1]
    {
      (object) detailsDataTable
    });
    if (this._runAuthorityLimitCheck && this._runAuthorityCheckAtStartup)
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Action) ([SpecialName] () => this.AuthorityLimitCheck((AuthorityLimitCheckType) 2, true)));
    if (!this._runThresholdLimitCheck || !this._runThresholdCheckAtStartup)
      return;
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Action) ([SpecialName] () => this.ThresholdLimitCheck((ThresholdLimitCheckType) 2, true)));
  }

  private void CompanyDataRetrieved(dsPolicyDetail.tblQuoteDetailsDataTable dt)
  {
    MemoryStream memoryStream = new MemoryStream();
    try
    {
      UltraGrid dgParticipants = this.dgParticipants;
      ((UltraGridBase) dgParticipants).DisplayLayout.Save((Stream) memoryStream);
      ((UltraGridBase) dgParticipants).DataMember = string.Empty;
      ((UltraGridBase) dgParticipants).DataSource = (object) dt;
      memoryStream.Position = 0L;
      ((UltraGridBase) dgParticipants).DisplayLayout.Load((Stream) memoryStream);
      ((UltraGridBase) dgParticipants).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
      this.leftMenu.Groups["PolicyActions"].Items["Rating"].Visible = ((UltraGridBase) this.dgParticipants).Rows.Count > 0;
      if (this._quote.RatedInNetRate && !SecurityManager.Instance.AssertPermission("{FF1F9A83-E24A-4c49-8D9A-1C3FB1C88F1D}"))
        this.leftMenu.Groups["PolicyActions"].Items["Rating"].Visible = false;
      ((UltraGridBase) this.dgParticipants).DisplayLayout.Bands[0].Columns["ProgCode"].Hidden = !SystemSettings.GetSetting<bool>("ShowProgramCodeOnPolicyDetail", false);
      this.LoadComplete();
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      memoryStream.Close();
    }
  }

  private void PremiumsControlLoaded(object sender, EventArgs e)
  {
    this.imageLoading.Visible = false;
    ((PolicyDetail_Premiums) this.pnlMiscInfo.Controls[1]).PremiumsControlLoaded -= new PolicyDetail_Premiums.PremiumsControlLoadedEventHandler(this.PremiumsControlLoaded);
    this.ZeroPremiumLineRowsDisplay(this.chkHideZeroPrem.Checked);
  }

  private void LoadComplete()
  {
    this.LoadControl("Premiums");
    this.AfterLoad();
    Note_System.Instance.UIInteractive.ViewPopupNotes(this.Quote.ControlGuid, this.EntityGUID, (Form) this);
    if (this.IsBound)
    {
      ((UltraGridBase) this.PremiumsControl.dgOptions).DisplayLayout.Bands[1].Columns["Bound"].CellActivation = (Activation) 3;
    }
    else
    {
      ((UltraGridBase) this.PremiumsControl.dgOptions).DisplayLayout.Bands[1].Columns["Bound"].CellActivation = (Activation) 0;
      ((UltraGridBase) this.PremiumsControl.dgOptions).Rows.Refresh((RefreshRow) 1);
    }
    ((Control) this).Refresh();
    MDIControls.Instance.MDIParent.Refresh();
  }

  protected void LoadControls(Quote quote)
  {
    if (quote == null)
      throw new ArgumentNullException(nameof (quote));
    if (this._quote != null)
      this._quote.EndorsementCreated -= new Quote.EndorsementCreatedEventHandler(this.EndorsementCreated);
    this._quote = quote;
    this._quote.EndorsementCreated += new Quote.EndorsementCreatedEventHandler(this.EndorsementCreated);
    if (this._statusChangeMenu == null)
      this._statusChangeMenu = (QuoteStatusChangeMenu) ObjectFactory.Instance.CreateObjectEX(typeof (QuoteStatusChangeMenu), new object[1]
      {
        (object) (PopupMenuTool) ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Policy"]
      });
    this._statusChangeMenu.EnableDisableItems((Quote) quote);
    UserControl objectEx = (UserControl) ObjectFactory.Instance.CreateObjectEX(typeof (PolicyDetail_PolicyInfo), new object[1]
    {
      (object) this._quote.QuoteGuid
    });
    objectEx.Dock = DockStyle.Fill;
    objectEx.Visible = false;
    this.pnlPolicyInfo.Controls.Add((Control) objectEx);
    objectEx.Visible = true;
    this.RefreshPolicyData(false);
  }

  protected virtual bool NetRateReconnectPreviousTransactionVisible(bool isCurrent)
  {
    return !isCurrent && CurrentUser.IsMGADeveloper;
  }

  protected virtual bool NetRateUpdatePremiumDataVisible() => CurrentUser.IsMGADeveloper;

  protected virtual bool ResolveUsingBrowserNetRate()
  {
    return SystemSettings.GetSetting<bool>("NetRate.UsingBrowserBasedRating", false);
  }

  protected virtual bool CanUnIssuePolicyRecord(bool IsOriginalQuoteRecord)
  {
    return IsOriginalQuoteRecord;
  }

  protected virtual void SetupToolbarItemsOnClient()
  {
  }

  protected virtual void AfterLoad()
  {
  }

  protected void RemovePolicyMenuItem(string key)
  {
    if (!((ToolsCollectionBase) this.UltraToolbarsManager1.Tools).Exists(key))
      return;
    ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Policy"]).Tools.Remove(((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Policy"]).Tools)[key]);
    this.UltraToolbarsManager1.Tools.RemoveAt(((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)[key].Index);
    this.UltraToolbarsManager1.RefreshMerge();
  }

  protected void AddPolicyMenuItem(string key, string caption)
  {
    this.AddMenuItem(key, caption, string.Empty);
  }

  protected void AddPolicyMenuItem(string key, string caption, string subMenu)
  {
    this.AddMenuItem(key, caption, subMenu);
  }

  protected void AddPolicyMenuItem(string key, string caption, string subMenu, string tagString)
  {
    this.AddMenuItem(key, caption, subMenu, tagString);
  }

  protected void AddPolicyMenuItem(
    string key,
    string caption,
    string subMenu,
    string tagString,
    Bitmap imageResource)
  {
    this.AddMenuItem(key, caption, subMenu, tagString, imageResource);
  }

  private void AddMenuItem(string key, string caption, string subMenu)
  {
    this.AddMenuItem(key, caption, subMenu, string.Empty);
  }

  private void AddMenuItem(string key, string caption, string subMenu, string tagString)
  {
    this.AddMenuItem(key, caption, subMenu, tagString, (Bitmap) null);
  }

  private void AddMenuItem(
    string key,
    string caption,
    string subMenu,
    string tagString,
    Bitmap imageResource)
  {
    if (((ToolsCollectionBase) this.UltraToolbarsManager1.Tools).Exists(key))
      return;
    ButtonTool buttonTool = new ButtonTool(key);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = caption;
    if (!string.IsNullOrEmpty(tagString))
      ((SubObjectBase) buttonTool).Tag = (object) tagString;
    this.UltraToolbarsManager1.Tools.Add((ToolBase) buttonTool);
    if (string.IsNullOrEmpty(subMenu))
    {
      ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Policy"]).Tools).Add((ToolBase) buttonTool);
      if (imageResource != null)
        ((ToolPropsBase) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Policy"]).Tools)[key].SharedProps).AppearancesSmall.Appearance.Image = (object) imageResource;
    }
    else if (subMenu.Contains("Reports|"))
    {
      ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Policy"]).Tools)["Reports"]).Tools)[Strings.Mid(subMenu, Strings.Len(subMenu) - subMenu.IndexOf("|") + 1)]).Tools.AddTool(key);
    }
    else
    {
      ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Policy"]).Tools)[subMenu]).Tools.AddTool(key);
      if (imageResource != null)
        ((ToolPropsBase) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["Policy"]).Tools)[subMenu]).Tools)[key].SharedProps).AppearancesSmall.Appearance.Image = (object) imageResource;
    }
    this.UltraToolbarsManager1.RefreshMerge();
  }

  protected void RelatedQuotesMenuClick(object sender, ToolClickEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    char[] charArray1 = "#".ToCharArray();
    char[] charArray2 = ",".ToCharArray();
    int integer = Conversions.ToInteger(((ToolEventArgs) e).Tool.Key.Split(charArray1[0])[1].Split(charArray2[0])[0]);
    bool flag = false;
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      Form form = mdiChildren[index];
      if (form is frmPolicyDetail frmPolicyDetail && frmPolicyDetail.ControlNumber.Equals(integer))
      {
        form.Focus();
        flag = true;
        break;
      }
      checked { ++index; }
    }
    if (flag)
      return;
    FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
    {
      (object) integer
    });
  }

  protected virtual bool AcceptedRaterResetWarning()
  {
    bool flag;
    if (System.Windows.Forms.MessageBox.Show("Are you sure you want to reset the rater?\n\nAll options will be deleted!", "Reset Rater?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
      DefaultDatabase.ExecuteNonQuery("dbo.spResetRater", new object[2]
      {
        (object) "@quoteGuid",
        (object) this._quote.QuoteGuid
      });
      flag = true;
    }
    else
      flag = false;
    return flag;
  }

  public void ResetRater()
  {
    if (!this.AcceptedRaterResetWarning())
      return;
    CurrentUser.Instance.LogAction("Reset Rater for Policy Control #" + this._quote.ControlNo.ToString(), this._quote.QuoteGuid);
    this.ResetRaterFactorSet(this._quote.QuoteGuid);
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteDetails SET RaterID=NULL, FactorsetGuid=NULL WHERE QuoteGuid=@QuoteGuid", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid
    });
    if (((UltraGridBase) this.dgParticipants).DataSource == null || ((UltraGridBase) this.dgParticipants).DataSource == DBNull.Value)
      return;
    dsPolicyDetail.tblQuoteDetailsDataTable dataSource = (dsPolicyDetail.tblQuoteDetailsDataTable) ((UltraGridBase) this.dgParticipants).DataSource;
    try
    {
      foreach (dsPolicyDetail.tblQuoteDetailsRow tblQuoteDetailsRow in (TypedTableBase<dsPolicyDetail.tblQuoteDetailsRow>) dataSource)
      {
        tblQuoteDetailsRow.SetRaterIDNull();
        tblQuoteDetailsRow.SetFactorSetGuidNull();
        tblQuoteDetailsRow.SetRatingTypeNull();
      }
    }
    finally
    {
      IEnumerator<dsPolicyDetail.tblQuoteDetailsRow> enumerator;
      enumerator?.Dispose();
    }
    int num = (int) System.Windows.Forms.MessageBox.Show("The rater settings have been successfully reset for this policy.", "Rater Settings Reset", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.RefreshPolicyData();
  }

  private void ResetRaterFactorSet(Guid quoteGuid)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT RaterID, FactorSetGuid FROM tblQuoteDetails WHERE RaterID is not null and QuoteGuid = @QuoteGuid", new object[2]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid
    });
    if (dataRow == null || dataRow["RaterID"] == DBNull.Value)
      return;
    int integer = Conversions.ToInteger(dataRow["RaterID"]);
    using (IRater rater = RaterFactory.GetRater(integer))
    {
      IRaterWithFactorSet2 iraterWithFactorSet2 = rater as IRaterWithFactorSet2;
      IRaterReset iraterReset = rater as IRaterReset;
      if (iraterWithFactorSet2 != null)
      {
        iraterWithFactorSet2.AfterRaterReset(new AfterResetArgs(integer, quoteGuid, ((IRaterWithFactorSet) iraterWithFactorSet2).FactorSetGuid));
        iraterReset?.AfterRaterReset(new AfterResetArgs(integer, quoteGuid, ((IRaterWithFactorSet) iraterWithFactorSet2).FactorSetGuid));
      }
      else
        iraterReset?.AfterRaterReset(new AfterResetArgs(integer, quoteGuid, Guid.Empty));
    }
  }

  private void RaterSetupChange(IRater rater, int raterId, Guid quoteGuid, Guid factorSetGuid)
  {
    if (rater == null)
    {
      using (IRater rater1 = RaterFactory.GetRater(raterId))
      {
        if (!(rater1 is IRaterWithFactorSet2 iraterWithFactorSet2))
          return;
        iraterWithFactorSet2.AfterRaterSetupChange(new AfterResetArgs(raterId, quoteGuid, factorSetGuid));
      }
    }
    else
    {
      if (!(rater is IRaterWithFactorSet2 iraterWithFactorSet2))
        return;
      iraterWithFactorSet2.AfterRaterSetupChange(new AfterResetArgs(raterId, quoteGuid, factorSetGuid));
    }
  }

  private void UnissuePolicy()
  {
    if (!this.ValidateUnIssuance() || !this._quote.UnIssue())
      return;
    CurrentUser.Instance.LogAction("Un-issue policy", this._quote.QuoteGuid);
    this.RefreshPolicyData();
    int num = (int) System.Windows.Forms.MessageBox.Show("The policy was successfully un-issued", "Policy Un-issued", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  private bool ValidateUnIssuance()
  {
    bool flag;
    if ("PB".Equals(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("dbo.spGetInvoiceType", new object[2]
    {
      (object) "@QuoteID",
      (object) this.Quote.QuoteID
    }))))
      flag = true;
    else if (SecurityManager.Instance.AssertPermission("{865E86E4-A00B-4139-B05D-0694D3A0C22F}"))
    {
      flag = true;
    }
    else
    {
      DateTime dateTime1 = this.Quote.DateIssued.Value;
      DateTime dateTime2 = DateTime.Now.AddMonths(-1);
      if (dateTime1.Year < dateTime2.Year || dateTime1.Year == dateTime2.Year && dateTime1.Month < dateTime2.Month || dateTime1.Year == dateTime2.Year && dateTime1.Month == dateTime2.Month && dateTime1.Day < dateTime2.Day)
      {
        int num = (int) System.Windows.Forms.MessageBox.Show($"This policy was issued on {dateTime1.ToShortDateString()}.\n\nYou do not have the required security to unissue a policy issued after {dateTime2.ToShortDateString()}", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag = false;
      }
      else
        flag = true;
    }
    return flag;
  }

  private void NoticeOfCancellation()
  {
    if (!SecurityManager.Instance.AssertPermission("{43A67ECB-2021-430b-8121-688BC2F4CC5A}"))
    {
      int num1 = (int) System.Windows.Forms.MessageBox.Show("Insufficient security to access/issue notice of cancellation.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      object objectValue1 = RuntimeHelpers.GetObjectValue(this.Quote.ChangeStatusRequirementsSoftStops(6));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)))
      {
        int num2 = (int) System.Windows.Forms.MessageBox.Show("Soft Stop(s). The following notice of cancellation requirements are not met:\n" + objectValue1.ToString(), "Notice of Cancellation - Company/line Requirements Not Met", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      object objectValue2 = RuntimeHelpers.GetObjectValue(this.Quote.ChangeStatusRequirementsHardStops(6));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
      {
        int num3 = (int) System.Windows.Forms.MessageBox.Show("The following requirements are not met:\n" + objectValue2.ToString(), "Company/line Requirements", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        if (!this.ClientVerificationOfNotice())
          return;
        if (!SystemSettings.GetSetting<bool>("NOCWarningForUnIssuedPolicies", false) || this._quote.IsIssued)
        {
          using (frmNOC frmNoc = (frmNOC) FormSettings.ShowFormDialog(typeof (frmNOC), new object[1]
          {
            (object) this._quote.QuoteGuid
          }))
          {
            if (frmNoc.DialogResult != DialogResult.OK)
              return;
            Messaging.SendBroadcastMessage(BroadcastMessages.NOCIssued, (object) this._quote.QuoteGuid);
          }
        }
        else
        {
          int num4 = (int) System.Windows.Forms.MessageBox.Show("An un-issued policy can not be placed under notice of cancellation.", "Policy UnIssued", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
    }
  }

  protected virtual bool ClientVerificationOfNotice() => true;

  private void EndorsementInfo() => this.ChangeEndorsementInformation();

  private void RefreshClearanceCard()
  {
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmClearance frmClearance)
        frmClearance.UpdateQuote(this._quote.QuoteGuid);
      checked { ++index; }
    }
  }

  private void IssuePolicy()
  {
    if (this._validateOnPolicyIssuance.Value && !this.ValidateCompliance("Issuance", this._canOverrideIssueOfacHits, this._canOverrideIssueOfacHits, this._checkOfacOnIssueIfMissing.Value, this._bypassOfacSystemOnIssue.Value))
      return;
    this._quote.IssuePolicy(CurrentUser.Instance.UserID);
    this.ReloadToCurrentVersion();
    this.RefreshClearanceCard();
  }

  protected virtual void MenuClick(object sender, ToolClickEventArgs e)
  {
    try
    {
      if (((ToolEventArgs) e).Tool.Key.StartsWith("Control #"))
      {
        this.RelatedQuotesMenuClick(RuntimeHelpers.GetObjectValue(sender), e);
      }
      else
      {
        string key = ((ToolEventArgs) e).Tool.Key;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(key))
        {
          case 1173286:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Binding Requirements Checklist", false) == 0)
            {
              BindingChecklistQuote_ViewModel checklistQuoteViewModel = BindingChecklistQuote_ViewModel.Create(this.Quote.QuoteGuid);
              BindingChecklistQuoteView checklistQuoteView = MgaMdiChild.Create<BindingChecklistQuoteView>(new object[0]);
              ((FrameworkElement) checklistQuoteView).DataContext = (object) checklistQuoteViewModel;
              ((MgaMdiChild) checklistQuoteView).Form.MdiParent = MDIControls.Instance.MDIParent;
              ((MgaMdiChild) checklistQuoteView).Form.Show();
              return;
            }
            goto default;
          case 81283355:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "FCW", false) == 0)
            {
              FormSettings.ShowForm(typeof (frmPolicyFCW), new object[1]
              {
                (object) this._quote.QuoteID
              });
              return;
            }
            goto default;
          case 123558485:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "AdminRerunPolicyOfac", false) == 0)
            {
              try
              {
                MDIControls.Instance.StatusBarText = "Running OFAC on Quote...";
                OfacSystem.Instance.CheckOfacResult<Quote>(this.Quote);
                this.ValidateCompliance();
                this.ClientRerunOfac();
                return;
              }
              finally
              {
                ((Control) this).Cursor = MgaCursors.Default;
                MDIControls.Instance.StatusBarText = string.Empty;
              }
            }
            else
              goto default;
          case 153354009:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Print All Quotes in Submission", false) == 0)
            {
              this.PrintAllSubmissionQuotes();
              return;
            }
            goto default;
          case 167573281:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "NetRate Additional Info", false) == 0)
            {
              using (FormSettings.ShowFormDialog(typeof (FormNetrateAdditionalInfo), new object[1]
              {
                (object) this._quote.QuoteGuid
              }))
                return;
            }
            goto default;
          case 321450149:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "New Quote", false) == 0)
            {
              this.ClickNewQuoteMenu();
              return;
            }
            goto default;
          case 407005360:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Reset Rater", false) == 0)
            {
              this.ResetRater();
              return;
            }
            goto default;
          case 439323835:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Assign Policy #", false) == 0)
            {
              this.AssignPolicyNumber();
              return;
            }
            goto default;
          case 541683357:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "BOR on Renewal", false) == 0)
            {
              using (FormSettings.ShowFormDialog(typeof (FormRenewalChangeProducer), new object[1]
              {
                (object) this._quote.QuoteID
              }))
                return;
            }
            goto default;
          case 581167412:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Claims", false) == 0)
            {
              FormSettings.ShowForm(typeof (frmClaims), new object[1]
              {
                (object) this._quote.QuoteGuid
              });
              return;
            }
            goto default;
          case 659570727:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "AdminRerunOfac", false) == 0)
            {
              try
              {
                MDIControls.Instance.StatusBarText = "Running OFAC on Insured...";
                if (!frmInsureds.CheckOfac(this.Quote.SubmissionGroup.InsuredLocation, (Insured) null))
                  return;
                using (frmInsureds formEx = (frmInsureds) ObjectFactory.Instance.CreateFormEX(typeof (frmInsureds), new object[2]
                {
                  (object) this.Quote.SubmissionGroup.InsuredGuid,
                  (object) this.Quote.SubmissionGroup.InsuredLocationGuid
                }))
                {
                  formEx.ClientRerunOfac();
                  return;
                }
              }
              finally
              {
                ((Control) this).Cursor = MgaCursors.Default;
                MDIControls.Instance.StatusBarText = string.Empty;
              }
            }
            else
              goto default;
          case 686840594:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View Transaction Log", false) == 0)
            {
              using (FormSettings.ShowFormDialog(typeof (frmTransactionLog), new object[1]
              {
                (object) this._quote.QuoteGuid
              }))
                return;
            }
            goto default;
          case 722104682:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Delete Transaction", false) == 0)
            {
              this._quote.Delete();
              return;
            }
            goto default;
          case 761164219:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Threshold Limits Approval", false) == 0)
            {
              ThresholdLimitApprovalViewModel approvalViewModel = ThresholdLimitApprovalViewModel.Create(this._thresholdLimitCheckManager, (IWinMsgBoxService) new WinMsgBoxService());
              ThresholdLimitApprovalView limitApprovalView = MgaMdiChild.Create<ThresholdLimitApprovalView>(new object[0]);
              ((FrameworkElement) limitApprovalView).DataContext = (object) approvalViewModel;
              int num = (int) ((MgaMdiChild) limitApprovalView).Form.ShowDialog();
              this.ThresholdLimitCheck((ThresholdLimitCheckType) 2, true);
              return;
            }
            goto default;
          case 802813361:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Assign Child Policy #", false) == 0)
            {
              this.AssignChildPolicyNumber();
              return;
            }
            goto default;
          case 837885795:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Open NetRate QuoteID Dialog", false) == 0)
            {
              this._showNetRateQuoteIDDialog = true;
              this.ClickRating();
              return;
            }
            goto default;
          case 865996501:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "NetRate Reconnect Data", false) == 0)
            {
              this._reconnectNetRateData = true;
              if (this.Quote.IsBound)
              {
                int num = (int) Interaction.MsgBox((object) "This is a bound Policy. After the NetRate application opens copy down the quote id located at the top center of the quote tab. Then close the NetRate application by clicking on the 'X' in the upper right hand corner of the application. Insert the Quote Id in the NetRate Reconnect Data Form and click save.", MsgBoxStyle.Critical, (object) "Bound Policy.");
              }
              this.ClickRating();
              if (this.Quote.IsBound)
              {
                using (FormSettings.ShowFormDialog(typeof (frmNetRateReconnectData), new object[2]
                {
                  (object) this.Quote.QuoteGuid,
                  (object) this._quote.QuoteID
                }))
                  ;
              }
              this._reconnectNetRateData = false;
              return;
            }
            goto default;
          case 881490506:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Issue Policy", false) == 0)
            {
              this.IssuePolicy();
              return;
            }
            goto default;
          case 1072704093:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View/Edit Assigned Numbers", false) == 0)
            {
              using (FormSettings.ShowFormDialog(typeof (frmEditAffidavitNumbers), new object[1]
              {
                (object) this._quote.ControlNo
              }))
                return;
            }
            goto default;
          case 1102577777:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Insured Summary", false) == 0)
            {
              FormSettings.ShowForm(typeof (frmInsuredSummary), new object[2]
              {
                (object) this.Quote.SubmissionGroup.InsuredGuid,
                (object) this.Quote.SubmissionGroup.InsuredLocationGuid
              });
              return;
            }
            goto default;
          case 1288183685:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "ClearBatchIssue", false) == 0)
            {
              DefaultDatabase.ExecuteNonQuery("spBulkIssuance_ClearBatchIssuance", new object[2]
              {
                (object) "@QuoteID",
                (object) this._quote.QuoteID
              });
              CurrentUser.Instance.LogAction("Clearing batch issue for control " + Conversions.ToString(this._quote.ControlNo), this._quote.QuoteGuid);
              this.ReloadToCurrentVersion();
              return;
            }
            goto default;
          case 1519012861:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Correction Entry", false) == 0)
            {
              this._quote.CreateCorrectionEntry();
              return;
            }
            goto default;
          case 1540817188:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Affidavit Numbering", false) == 0)
            {
              this.AssignAffidavitNumber();
              return;
            }
            goto default;
          case 1542364983:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Current Loss Information", false) == 0)
            {
              FormSettings.ShowForm(typeof (frmCurrentLossInformation), new object[1]
              {
                (object) this._quote.QuoteID
              });
              return;
            }
            goto default;
          case 1653947249:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Notice Of Cancellation", false) == 0)
            {
              this.NoticeOfCancellation();
              return;
            }
            goto default;
          case 1728265510:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "ITV Calculator", false) == 0)
            {
              using (FormSettings.ShowFormDialog(typeof (FormITVCalculator), new object[1]
              {
                (object) this._quote.QuoteGuid
              }))
                return;
            }
            goto default;
          case 1910140860:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Re-Print Policy", false) == 0)
            {
              this.RePrintPolicy();
              return;
            }
            goto default;
          case 1912725802:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Reinstate Policy", false) == 0)
            {
              this._quote.Reinstate();
              return;
            }
            goto default;
          case 1987582535:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Property Valuation", false) == 0)
            {
              Form form = ObjectFactory.Instance.CreateForm(typeof (PropertiesViewer), new object[1]
              {
                (object) this.Quote.QuoteGuid
              });
              form.MdiParent = MDIControls.Instance.MDIParent;
              form.FormBorderStyle = FormBorderStyle.Sizable;
              form.MaximizeBox = true;
              form.Show();
              return;
            }
            goto default;
          case 2009620176:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View NetRate XML", false) == 0)
            {
              this.ViewSaveNetRateXML();
              return;
            }
            goto default;
          case 2036361000:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Inspection Compare", false) == 0)
            {
              using (FormSettings.ShowFormDialog(typeof (FormInspectionComparison), new object[1]
              {
                (object) this._quote
              }))
                return;
            }
            goto default;
          case 2284848834:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "View Underwriting Locations", false) == 0)
            {
              FormSettings.ShowForm(typeof (frmUnderwritingLocations), new object[1]
              {
                (object) this._quote.QuoteGuid
              });
              return;
            }
            goto default;
          case 2352915088:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "NetRate Update from Existing Policy", false) == 0)
            {
              frmNetRateUpdateXML netRateUpdateXml = new frmNetRateUpdateXML(this._quote.QuoteID);
              netRateUpdateXml.StartPosition = FormStartPosition.CenterScreen;
              netRateUpdateXml.Focus();
              int num = (int) netRateUpdateXml.ShowDialog();
              this.UpdateNetRateXML = netRateUpdateXml.UpdatePolicyXML;
              this.NetRateXMLDoc = netRateUpdateXml.GetNewAccountXML;
              if (this._updateNetRateXML && this._NetRateXMLDoc != null && !string.IsNullOrEmpty(this._NetRateXMLDoc.ToString()))
              {
                CurrentUser.Instance.LogAction("Update NetRate xml from existing controlno = " + Conversions.ToString(netRateUpdateXml.ControlNo), this._quote.QuoteGuid);
                this.ClickRating();
              }
              this.UpdateNetRateXML = false;
              return;
            }
            goto default;
          case 2393900135:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Location Import Utility", false) == 0)
            {
              this.LocationImport();
              return;
            }
            goto default;
          case 2411880709:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Create_Installment", false) == 0)
            {
              this._quote.CreatingInstallment();
              return;
            }
            goto default;
          case 2418057167:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Additional Interests", false) == 0)
            {
              FormSettings.ShowForm(typeof (frmAdditionalInterests), new object[1]
              {
                (object) this._quote.QuoteID
              });
              return;
            }
            goto default;
          case 2432923335:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Additional Interest Import Utility", false) == 0)
            {
              this.AdditionalInterestImport();
              return;
            }
            goto default;
          case 2463767386:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Company/Line Management", false) == 0)
            {
              this.CompanyLineManagement();
              return;
            }
            goto default;
          case 2492967647:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "UpdateNetratePolicy", false) == 0)
            {
              Messaging.SendBroadcastMessage(frmPolicyDetail.NetRatePolicyUpdate, (object) this._quote.QuoteGuid);
              return;
            }
            goto default;
          case 2545217434:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "NetRate Update Premium Data", false) == 0)
            {
              if (this.Quote.IsBound)
                return;
              using (FormSettings.ShowFormDialog(typeof (frmNetRatePremiums), new object[1]
              {
                (object) this._quote.QuoteGuid
              }))
                ;
              this.RefreshPolicyData();
              return;
            }
            goto default;
          case 2598187322:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Change Policy Number", false) == 0)
            {
              this.ClickChangePolicyNumberMenu();
              return;
            }
            goto default;
          case 2787453627:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Change Quote Status Reason", false) == 0)
            {
              using (FormSettings.ShowFormDialog(typeof (FormChangeQuoteStatusReason), new object[1]
              {
                (object) this._quote.QuoteGuid
              }))
                return;
            }
            goto default;
          case 2869292521:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Drivers Import Utility", false) == 0)
            {
              this.DriversImport();
              return;
            }
            goto default;
          case 2878810109:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "VinVerification", false) == 0)
            {
              FormSettings.ShowForm(typeof (frmVinVerification), new object[1]
              {
                (object) this._quote.QuoteID
              });
              return;
            }
            goto default;
          case 2904692505:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Create Endorsement", false) == 0)
              break;
            goto default;
          case 2928822463:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Audit_Endorsement", false) == 0)
            {
              this._quote.CreatingAudit();
              return;
            }
            goto default;
          case 3122970651:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Cancel Policy", false) == 0)
              break;
            goto default;
          case 3382000972:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "ResetAppliedForms", false) == 0)
            {
              if (!SecurityManager.Instance.AssertPermission("{218D5409-9A5D-4CAE-AF8D-15CF46C42B5B}"))
              {
                int num = (int) System.Windows.Forms.MessageBox.Show("You do not have necessary permissions to reset applied policy forms.");
                return;
              }
              if (System.Windows.Forms.MessageBox.Show("Are you sure you want to reset forms applied to the current policy? This will not modify forms brought forward from a prior transaction.", "Reset Applied Forms", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
              int num1 = DefaultDatabase.ExecuteScalar<int>("spResetAppliedPolicyForms", new object[2]
              {
                (object) "@quoteID",
                (object) this.Quote.QuoteID
              });
              if (num1 <= 0)
                return;
              CurrentUser.Instance.LogAction($"Reset applied forms, cleared {Conversions.ToString(num1)} policy FCW records.", this.Quote.QuoteGuid);
              return;
            }
            goto default;
          case 3506011517:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Unbind Policy", false) == 0)
            {
              this._quote.PolicyUnbound += new Quote.PolicyUnboundEventHandler(this.PolicyUnbound);
              this._quote.Unbind();
              this.DoPostUnbindWork();
              return;
            }
            goto default;
          case 3540794703:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Preview Policy", false) == 0)
            {
              this._quote.PreviewPolicy();
              return;
            }
            goto default;
          case 3541570973:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Driver Info", false) == 0)
            {
              FormSettings.ShowForm(typeof (FormDriversInfo), new object[2]
              {
                (object) this._quote.ControlNo,
                (object) this._quote.QuoteGuid
              });
              return;
            }
            goto default;
          case 3640709701:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "ClearAutoAppliedForms", false) == 0)
            {
              DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuotes SET PolicyFormsAutoApplied = 0 WHERE QuoteGuid = @qg", new object[2]
              {
                (object) "@qg",
                (object) this._quote.QuoteGuid
              });
              return;
            }
            goto default;
          case 3767336753:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Authority Limits Approval", false) == 0)
            {
              AuthorityLimitApprovalViewModel approvalViewModel = AuthorityLimitApprovalViewModel.Create(this._authorityLimitCheckManager, (IWinMsgBoxService) new WinMsgBoxService());
              AuthorityLimitApprovalView limitApprovalView = MgaMdiChild.Create<AuthorityLimitApprovalView>(new object[0]);
              ((FrameworkElement) limitApprovalView).DataContext = (object) approvalViewModel;
              int num = (int) ((MgaMdiChild) limitApprovalView).Form.ShowDialog();
              this.AuthorityLimitCheck((AuthorityLimitCheckType) 2, true);
              return;
            }
            goto default;
          case 3828739461:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Supplemental Vehicle Info", false) == 0)
            {
              this.SupplementalVehicleInfo();
              return;
            }
            goto default;
          case 3972858458:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Un-Issue Policy", false) == 0)
            {
              this.UnissuePolicy();
              return;
            }
            goto default;
          case 4130932966:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Save NetRate XML...", false) == 0)
            {
              this.ClickSaveNetRateXML();
              return;
            }
            goto default;
          case 4133868045:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Endorsement Information", false) == 0)
            {
              this.EndorsementInfo();
              return;
            }
            goto default;
          case 4135018513:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Change Producer", false) == 0)
            {
              this.ClickChangeProducerMenu();
              return;
            }
            goto default;
          case 4199953741:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Endorsement Body", false) == 0)
            {
              FormSettings.ShowForm(typeof (frmEndorsementInfo), new object[1]
              {
                (object) this._quote.QuoteID
              });
              return;
            }
            goto default;
          case 4207640767:
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Filing Producers", false) == 0)
            {
              this.ClickFilingProducersMenu();
              return;
            }
            goto default;
          default:
            if (this.ShowReports(((ToolEventArgs) e).Tool.Key) || this.ShouldLogPolicyReportMenuClick(((ToolEventArgs) e).Tool.Key))
              CurrentUser.Instance.LogAction($"Ran Policy Report -- {((ToolEventArgs) e).Tool.CustomizerCaptionResolved} for control {this._quote.ControlNo}", this._quote.QuoteGuid);
            this._statusChangeMenu.ToolClick(((ToolEventArgs) e).Tool.Key, this._quote);
            return;
        }
        this.ClickCreateEndorsementOrCancelMenu(((ToolEventArgs) e).Tool.Key);
      }
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual bool ShouldLogPolicyReportMenuClick(string toolKey)
  {
    return SystemSettings.GetSetting<bool>("PolicyDetail.Menu.LogAllReportClicks", false);
  }

  [Obsolete("Please use the version that takes the entity searched")]
  protected virtual void ClientRerunOfac() => this.ClientRerunOfac((IOfacEntity) this.Quote);

  protected virtual void ClientRerunOfac(IOfacEntity ofacEntity)
  {
  }

  private void PrintAllSubmissionQuotes()
  {
    FormSettings.ShowForm(typeof (FormMultiQuotePrinting), new object[1]
    {
      (object) this.Quote.SubmissionGroupGuid
    });
  }

  private void DriversImport()
  {
    if (!SecurityManager.Instance.AssertPermission("{73465013-ACE0-4E31-87CC-26D4B94D5F68}"))
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security access to Drivers Import Utility.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      using (FormSettings.ShowFormDialog(typeof (FormDriverExcelImport), new object[1]
      {
        (object) this._quote.QuoteID
      }))
        ;
    }
  }

  private void AdditionalInterestImport()
  {
    if (!SecurityManager.Instance.AssertPermission("{F57EDC10-6944-4A09-A2E2-52CA9DA32C15}"))
    {
      int num1 = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security access to Additional Interest Import Utility.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (frmAdditionalInterests.LockDownOnIssuance(this.Quote.QuoteGuid))
    {
      int num2 = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to update Additional Interest when the policy is issued.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      try
      {
        using (FormSettings.ShowFormDialog(typeof (FormAdditionalInterestExcelImport), new object[1]
        {
          (object) this._quote.QuoteID
        }))
          ;
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
    }
  }

  private void SupplementalVehicleInfo()
  {
    Type typeFromString = ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Underwriting.Supplemental_Vehicle_Info.FormSupplementalVehicleInfo");
    Form form = (Form) null;
    try
    {
      if ((object) typeFromString == null)
        return;
      form = (Form) ObjectFactory.Instance.CreateObjectEX(typeFromString, new object[1]
      {
        (object) this.Quote.QuoteGuid
      });
      if (form == null)
        return;
      form.ShowInTaskbar = true;
      form.BringToFront();
      int num = (int) form.ShowDialog();
    }
    finally
    {
      form?.Dispose();
    }
  }

  private void DoPostUnbindWork()
  {
    this._statusChangeMenu.EnableDisableItems(Quote.CreateNew(this.Quote.QuoteGuid));
    ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Change Status"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{01F25D54-0EE8-4795-A90A-24E5550D8D9E}");
  }

  private void ClickChangeProducerMenu()
  {
    using (FormSettings.ShowFormDialog(typeof (frmChangeProducer), new object[1]
    {
      (object) this._quote.QuoteGuid
    }))
      ;
    this.RefreshPolicyData();
  }

  private void CompanyLineManagement()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      frmCompanyLines objectAs = ObjectFactory.Instance.CreateObjectAs<frmCompanyLines>(new object[0]);
      objectAs.CompanyLineGuidFilter = this._quote.CompanyLineGuid.Value;
      ((Form) objectAs).MdiParent = MDIControls.Instance.MDIParent;
      ((Control) objectAs).Show();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void RePrintPolicy()
  {
    Messaging.SendBroadcastMessage(BroadcastMessages.PolicyIssuing, (object) new PolicyIssuedContext(this.Quote.PolicyOriginalQuoteGuid, false, true));
    CurrentUser.Instance.LogAction($"Reprint Policy #{this.Quote.PolicyNumber}", this.Quote.QuoteGuid);
  }

  public virtual bool ValidateCompliance(
    string operation = null,
    bool canOverridePolicy = false,
    bool canOverrideAis = false,
    bool performOfacIfMissing = false,
    bool shouldBypassOfacSystem = false,
    bool displayMessage = true)
  {
    if (!this.ComplianceCheck_ComplyAdvantage())
      return false;
    if (shouldBypassOfacSystem)
      return true;
    return this.PerformComplianceCheck(performOfacIfMissing, canOverridePolicy, operation, displayMessage) && this.PerformAdditionalInterestComplianceCheck(performOfacIfMissing, canOverrideAis, operation, displayMessage);
  }

  private void ClickCreateEndorsementOrCancelMenu(string toolKey)
  {
    try
    {
      string str = toolKey.Replace("Create ", "").Replace(" Policy", "");
      if (SystemSettings.GetSetting<bool>($"OFAC.PolicyDetail.{str}.CheckCompliance", true) && !this.ValidateCompliance(toolKey, this._canOverrideEndorsementOfacHits, this._canOverrideEndorsementOfacHits, SystemSettings.GetSetting<bool>($"OFAC.PolicyDetail.{str}.CheckIfMissing", false), SystemSettings.GetSetting<bool>($"OFAC.PolicyDetail.{str}.BypassOfacSystem", false)))
        return;
      if (!this._quote.IsBound)
      {
        int num = (int) System.Windows.Forms.MessageBox.Show("Unable to create an endorsement on an unbound transaction!", "Unbound Transaction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(toolKey, "Cancel Policy", false) == 0)
      {
        this._quote.Cancel();
      }
      else
      {
        if (!this.CanEndorsePolicy())
          return;
        this._quote.Endorse();
        ((BaseDataObject) this._quote).RefreshData();
      }
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      SqlException sqlException = ex;
      if (sqlException.State == (byte) 100)
      {
        int num = (int) System.Windows.Forms.MessageBox.Show(sqlException.Message, "Insufficient Premium for Credit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
        ErrorHandler.HandleError((Exception) sqlException);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual bool CanEndorsePolicy() => true;

  private void LocationImport()
  {
    if (!SecurityManager.Instance.AssertPermission("{25DD6047-A314-4954-9CDF-436DCAC66053}"))
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security access to Location Import Utility.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      try
      {
        using (FormSettings.ShowFormDialog(typeof (FormLocationExcelImport), new object[1]
        {
          (object) this._quote.QuoteGuid
        }))
          ;
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
    }
  }

  private void ClickNewQuoteMenu()
  {
    if (!SecurityManager.Instance.AssertPermission("{9EFA732E-DF81-4188-A447-7BFACAADD050}"))
    {
      int num1 = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to add new quotes.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      short status = (short) new Insured(this.Quote.SubmissionGroup.InsuredGuid).Status;
      if (status != (short) 1)
      {
        if (status == (short) 2 && !SecurityManager.Instance.AssertPermission("{9225EE00-057D-4cc5-B09D-A626186BD713}"))
        {
          int num2 = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to add new quotes on an inactive insured", "Cannot Add Quote On Inactive Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          return;
        }
        if (status == (short) 3 && !SecurityManager.Instance.AssertPermission("{BFD2701B-C237-4f71-B918-113625AD47F9}"))
        {
          int num3 = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to add new quotes on a closed insured", "Cannot Add Quote On Closed Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          return;
        }
      }
      frmPolicyDetail.ReplicateQuote(this.Quote.QuoteGuid);
    }
  }

  private void ClickChangePolicyNumberMenu()
  {
    if (DefaultDatabase.ExecuteScalar<int?>("dbo.GetPolicyNumberRule", new object[2]
    {
      (object) "@quoteGuid",
      (object) this.Quote.QuoteGuid
    }).HasValue)
    {
      if (System.Windows.Forms.MessageBox.Show("WARNING: This policy is using an automated policy numbering rule.\nThis rule will not take into account any numbers that have been changed manually.\nAre you sure you want to change this number?", "Change Policy Numbering", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
        return;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET PolicyNumberIndex = NULL WHERE QuoteGuid = @QuoteGuid", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.Quote.QuoteGuid
      });
    }
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      using (FormSettings.ShowFormDialog(typeof (frmChangePolicyNumber), new object[1]
      {
        (object) this._quote.QuoteGuid
      }))
        this.RefreshPolicyData();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void ClickFilingProducersMenu()
  {
    frmFilingProducers frmFilingProducers = (frmFilingProducers) null;
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      frmFilingProducers = (frmFilingProducers) ObjectFactory.Instance.CreateFormEX(typeof (frmFilingProducers), new object[1]
      {
        (object) this._quote.QuoteID
      });
      frmFilingProducers.FillData();
      if (this.PremiumsControl.HasPremium || Decimal.Compare(this._quote.AggregatePremium, 0M) != 0)
      {
        ((Form) frmFilingProducers).ShowInTaskbar = false;
        CurrentUser.Instance.LogAction("Accessed filing producer from Policy menu", this._quote.QuoteGuid);
        int num = (int) ((Form) frmFilingProducers).ShowDialog();
        this.AutoApplyFeesAndRefreshPolicyDetail();
      }
      else
      {
        int num1 = (int) System.Windows.Forms.MessageBox.Show("No premium has been entered on this risk.\n\nPlease enter premium before managing filing producers.", "No Premium Entered", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
    finally
    {
      ((Component) frmFilingProducers)?.Dispose();
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void AutoApplyFeesAndRefreshPolicyDetail()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT QuoteOptionGuid FROM tblQuoteOptions WITH (NOLOCK) WHERE QuoteGuid=@QG", new object[2]
    {
      (object) "@QG",
      (object) this.Quote.QuoteGuid
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
        this.Quote.AutoApplyFees((Guid) row[0]);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmPolicyDetail frmPolicyDetail && frmPolicyDetail.ControlNumber.Equals(this.Quote.ControlNo))
        frmPolicyDetail.RefreshPolicyData();
      checked { ++index; }
    }
  }

  private void ClickSaveNetRateXML()
  {
    if (!this._quote.NetRateRatedOptionExists)
      return;
    string xml = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT NetRateXML FROM dbo.tblQuotes WITH(NOLOCK) WHERE QuoteGUID = @QG", new object[2]
    {
      (object) "@QG",
      (object) this._quote.QuoteGuid
    });
    if (!string.IsNullOrEmpty(xml))
    {
      ((Control) this).Cursor = MgaCursors.WaitCursor;
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(xml);
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
          saveFileDialog.DefaultExt = ".xml";
          saveFileDialog.Filter = "XML Document (*.xml)|*.xml";
          if (saveFileDialog.ShowDialog() != DialogResult.OK)
            return;
          File.WriteAllText(saveFileDialog.FileName, xmlDocument.OuterXml);
        }
      }
      catch (XmlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) System.Windows.Forms.MessageBox.Show("XML Document failed to load properly.", "XML Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        ProjectData.ClearProjectError();
      }
      finally
      {
        ((Control) this).Cursor = MgaCursors.Default;
      }
    }
    else
    {
      int num1 = (int) System.Windows.Forms.MessageBox.Show("No XML data exists on this policy transaction.", "No XML Data Exists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void ViewSaveNetRateXML()
  {
    if (!this._quote.NetRateRatedOptionExists)
      return;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT NetRateXML FROM tblQuotes WHERE QuoteGUID = @QG", new object[2]
    {
      (object) "@QG",
      (object) this._quote.QuoteGuid
    }));
    if (objectValue != null && objectValue != DBNull.Value)
    {
      ((Control) this).Cursor = MgaCursors.WaitCursor;
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(objectValue.ToString());
        frmXMLView frmXmlView = objectValue.ToString().Length <= 100000 ? new frmXMLView("NetRate XML Control #" + this._quote.ControlNo.ToString(), xmlDocument) : new frmXMLView("NetRate XML Control #" + this._quote.ControlNo.ToString(), xmlDocument, 3);
        ((Form) frmXmlView).MdiParent = MDIControls.Instance.MDIParent;
        ((Control) frmXmlView).Show();
      }
      catch (XmlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) System.Windows.Forms.MessageBox.Show("XML Document failed to load properly.", "XML Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        ProjectData.ClearProjectError();
      }
      finally
      {
        ((Control) this).Cursor = MgaCursors.Default;
      }
    }
    else
    {
      int num1 = (int) System.Windows.Forms.MessageBox.Show("No XML data exists on this policy transaction.", "No XML Data Exists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  protected virtual void EnableRatingButton()
  {
    this.leftMenu.Groups["PolicyActions"].Items["Rating"].Settings.Enabled = SecurityManager.Instance.AssertPermission("{D3C80C0E-AC54-4655-8011-0CCD15BA2865}") ? (DefaultableBoolean) 1 : (DefaultableBoolean) 2;
  }

  protected void AssignPolicyNumber()
  {
    string str1 = string.Empty;
    string text1 = "Do you wish to continue with the assignment of a policy number?";
    if (this.Quote.HasPolicyNumber)
    {
      str1 = this.Quote.PolicyNumber;
      text1 = $"Current Policy # - '{str1}{"\n"}{"\n"}{text1}";
    }
    if (System.Windows.Forms.MessageBox.Show(text1, "Continue Assigning Policy #", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    ((Control) this).Cursor = MgaCursors.WaitCursor;
    if (this._quote.IsManualPolicyNumberEntry())
    {
      this.ManualPolicyNumberEntry(new InvalidOperationException("Cannot generate a policy #.  Manual entry is required"));
    }
    else
    {
      try
      {
        PolicyInfo nextPolicy = Quote.GetNextPolicy(this.Quote.QuoteGuid);
        if (nextPolicy.PolicyNumber == null || nextPolicy.PolicyNumber.Equals(string.Empty))
        {
          int num1 = (int) System.Windows.Forms.MessageBox.Show("The system was unable to generate a policy number to assign to this policy.", "Unable to Generate a Policy Number.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          if (this.Quote.IsOriginalQuoteRecord && !frmChangePolicyNumber.DuplicatePolicyNumberCheck((Quote) this.Quote, nextPolicy.PolicyNumber))
            return;
          DefaultDatabase.ExecuteNonQuery(nameof (AssignPolicyNumber), new object[8]
          {
            (object) "@quoteGuid",
            (object) this.Quote.QuoteGuid,
            (object) "@polNumRuleID",
            (object) nextPolicy.PolicyNumberRuleID,
            (object) "@PolicyNumber",
            (object) nextPolicy.PolicyNumber,
            (object) "@PolicyNumberIndex",
            (object) nextPolicy.PolicyIndex
          });
          if (nextPolicy.TableBasedPolicyNumber != null)
            DefaultDatabase.ExecuteNonQuery("spPolicyNumberingSetTablePolicyNumberToUsed", new object[8]
            {
              (object) "@QuoteGuid",
              (object) this.Quote.QuoteGuid,
              (object) "@PolicyNumberRuleId",
              (object) nextPolicy.PolicyNumberRuleID,
              (object) "@ActualPolicyNumber",
              (object) nextPolicy.PolicyNumber,
              (object) "@TableBasedPolicyNumber",
              (object) nextPolicy.TableBasedPolicyNumber
            });
          string str2 = "Policy # has been changed";
          if (!str1.Equals(string.Empty))
            str2 = $"{str2} from \n\n{str1}'";
          this.PopulatePolicyNumberOnScreens(nextPolicy.PolicyNumber);
          string text2 = $"{str2}\n\n to \n\n'{nextPolicy.PolicyNumber}'";
          CurrentUser.Instance.LogAction($"Control # {this.Quote.ControlNo.ToString()} - Assign Policy # '{nextPolicy.PolicyNumber}'", this.Quote.QuoteGuid);
          int num2 = (int) System.Windows.Forms.MessageBox.Show(text2, "Policy # Changed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      catch (ManualEntryRequiredException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.ManualPolicyNumberEntry(new InvalidOperationException(ex.Message));
        ProjectData.ClearProjectError();
      }
      catch (NoPolicyNumbersRemainingException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) System.Windows.Forms.MessageBox.Show(((Exception) ex).Message, "No Policy Numbers Remaining", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        ProjectData.ClearProjectError();
      }
      catch (InvalidOperationException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        InvalidOperationException tmpException = ex;
        if (tmpException.Message.Contains("there is no policy numbering rule assigned to this company line"))
        {
          this.ManualPolicyNumberEntry(tmpException);
        }
        else
        {
          int num = (int) System.Windows.Forms.MessageBox.Show(tmpException.Message, "Unable to Generate the Next Policy Number.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        ProjectData.ClearProjectError();
      }
      finally
      {
        ((Control) this).Cursor = MgaCursors.Default;
      }
    }
  }

  private void ManualPolicyNumberEntry(InvalidOperationException tmpException)
  {
    if (DialogResult.Yes != System.Windows.Forms.MessageBox.Show(tmpException.Message + "\n\nWould you like to enter manual policy #s?", "Unable to Generate a Policy Number - Manual Policy #s?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      return;
    FormManualPolicyNumbersEntry policyNumbersEntry = (FormManualPolicyNumbersEntry) null;
    try
    {
      Cursor.Current = MgaCursors.Default;
      policyNumbersEntry = (FormManualPolicyNumbersEntry) ObjectFactory.Instance.CreateFormEX(typeof (FormManualPolicyNumbersEntry), new object[1]
      {
        (object) this._quote.QuoteGuid
      });
      policyNumbersEntry.ShowInTaskbar = false;
      int num = (int) policyNumbersEntry.ShowDialog();
      this.RefreshPolicyData();
    }
    finally
    {
      policyNumbersEntry?.Dispose();
    }
  }

  private void PopulatePolicyNumberOnScreens(string policyNumber)
  {
    this.RefreshPolicyData();
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmClearance frmClearance)
        frmClearance.UpdatePolicyNumber(this.Quote.QuoteGuid, policyNumber);
      checked { ++index; }
    }
  }

  private static Quote CreateQuote(Guid quoteGuid) => Quote.CreateNewAs<Quote>(quoteGuid);

  private List<int> GetDistinctRaterIDs()
  {
    HashSet<int> source = new HashSet<int>();
    dsPolicyDetail.tblQuoteDetailsDataTable dataSource = (dsPolicyDetail.tblQuoteDetailsDataTable) ((UltraGridBase) this.dgParticipants).DataSource;
    try
    {
      foreach (dsPolicyDetail.tblQuoteDetailsRow tblQuoteDetailsRow in (TypedTableBase<dsPolicyDetail.tblQuoteDetailsRow>) dataSource)
      {
        if (tblQuoteDetailsRow.IsRaterIDNull())
          source.Add(-1);
        else
          source.Add(tblQuoteDetailsRow.RaterID);
      }
    }
    finally
    {
      IEnumerator<dsPolicyDetail.tblQuoteDetailsRow> enumerator;
      enumerator?.Dispose();
    }
    return source.ToList<int>();
  }

  private void UltraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    bool isCurrent;
    bool isBound;
    bool isAdmitted;
    bool flag;
    if (this._menuArgs == null)
    {
      isCurrent = this._quote.IsCurrent;
      int num = this._quote.IsOriginalQuoteRecord ? 1 : 0;
      isBound = this._quote.IsBound;
      isAdmitted = this._quote.CompanyLine.IsAdmitted;
      flag = SecurityManager.Instance.AssertPermission("{EB46BFBA-6C16-45F7-BFE5-7951B0DFD8E8}");
    }
    else
    {
      isCurrent = this._menuArgs.IsCurrent;
      int num = this._menuArgs.IsOriginalQuoteRecord ? 1 : 0;
      isBound = this._menuArgs.IsBound;
      isAdmitted = this._menuArgs.IsAdmitted;
      flag = this._menuArgs.CanViewFilingProducersMenu;
    }
    if (!isCurrent)
    {
      foreach (ToolBase tool in (ToolsCollectionBase) this.UltraToolbarsManager1.Tools)
      {
        if (((SubObjectBase) tool).Tag == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((SubObjectBase) tool).Tag.ToString(), "KeepActive", false) != 0)
          tool.SharedProps.Visible = false;
      }
      if (isBound && !isAdmitted && flag)
        ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Filing Producers"].SharedProps.Visible = true;
    }
    if (this._runAuthorityLimitCheck)
    {
      ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Authority Limits Approval"].SharedProps.Visible = PolSecurity.CanApproveAuthorityLimit;
      if (PolSecurity.CanApproveAuthorityLimit)
      {
        if (this._authorityLimitCheckManager == null)
          this.AuthorityLimitCheck((AuthorityLimitCheckType) 2, false);
        ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Authority Limits Approval"].SharedProps.Enabled = this._authorityLimitCheckManager.HasApprovalItems();
      }
    }
    else
      ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Authority Limits Approval"].SharedProps.Visible = false;
    if (this._runThresholdLimitCheck)
    {
      ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Threshold Limits Approval"].SharedProps.Visible = PolSecurity.CanApproveThresholdLimit;
      if (!PolSecurity.CanApproveThresholdLimit)
        return;
      if (this._thresholdLimitCheckManager == null)
        this.ThresholdLimitCheck((ThresholdLimitCheckType) 2, false);
      ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Threshold Limits Approval"].SharedProps.Enabled = this._thresholdLimitCheckManager.HasApprovalItems();
    }
    else
      ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Threshold Limits Approval"].SharedProps.Visible = false;
  }

  private void NoCollapse(object sender, CancelableGroupEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = true;
  }

  private void EndorsementCreated(object sender, EndorsementEventArgs e)
  {
    FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
    {
      (object) e.NewQuoteGuid
    });
    ((Form) this).Close();
  }

  private void PolicyUnbound(object sender, QuoteEventArgs e)
  {
    this._quote.PolicyUnbound -= new Quote.PolicyUnboundEventHandler(this.PolicyUnbound);
    ((Control) this).Refresh();
    Form form = FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
    {
      (object) e.Quote.QuoteGuid
    });
    ((Form) this).Close();
    form.Refresh();
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmClearance frmClearance)
        frmClearance.UpdateQuoteStatus(e.Quote.QuoteGuid);
      checked { ++index; }
    }
  }

  private void ChangeEndorsementInformation()
  {
    frmCreateEndorsement formEx = (frmCreateEndorsement) ObjectFactory.Instance.CreateFormEX(typeof (frmCreateEndorsement), new object[2]
    {
      (object) this._quote.QuoteGuid,
      (object) this._quote.QuoteStatus
    });
    DateTime endorsementEffective = this._quote.EndorsementEffective;
    try
    {
      formEx.IsEdit = true;
      formEx.ShowInTaskbar = false;
      int num1 = (int) formEx.ShowDialog();
      if (!formEx.Saved)
        return;
      SqlBoolean sqlBoolean;
      if ((sqlBoolean = (SqlDateTime) formEx.EndorsementEffective == SqlDateTime.MinValue) ? sqlBoolean : sqlBoolean | (SqlDateTime) formEx.EndorsementEffective == SqlDateTime.MaxValue)
      {
        int num2 = (int) System.Windows.Forms.MessageBox.Show("Endorsement Effective date cannot be empty.", "Empty Endorsment Effective Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        string str = string.Empty;
        switch (formEx.EndorsementCalcType - 1)
        {
          case 0:
            str = "P";
            break;
          case 1:
            str = "S";
            break;
          case 2:
            str = "F";
            break;
          case 3:
            str = "M";
            break;
        }
        object obj = (object) null;
        if (formEx.ReasonSelected)
          obj = (object) formEx.EndorsementReasonID;
        DefaultDatabase.ExecuteNonQuery("dbo.ChangeEndorsementInformation", new object[10]
        {
          (object) "@quoteID",
          (object) this.Quote.QuoteID,
          (object) "@endorsementEffective",
          (object) formEx.EndorsementEffective,
          (object) "@endorsementComment",
          (object) formEx.EndorsementComment,
          (object) "@endorsementCalculationType",
          (object) str,
          (object) "@quoteStatusReasonID",
          obj
        });
        ((BaseDataObject) this.Quote).RefreshData();
        if (this.DateEqual(formEx.EndorsementEffective, endorsementEffective))
          return;
        if (!Convert.ToBoolean(DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT TOP(1) 1 FROM dbo.tblQuoteDetails WITH(NOLOCK) WHERE RaterID = 98 AND QuoteGuid  = @QuoteGuid", new object[2]
        {
          (object) "@QuoteGuid",
          (object) this._quote.QuoteGuid
        }) ?? 0) || System.Windows.Forms.MessageBox.Show("The endorsement effective date has changed.\n\nWould you Like to update the effective dates on the exposure level?", "Endorsement Effective Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        DefaultDatabase.ExecuteNonQuery("dbo.UpdateExposureOnChangeEndEff", new object[4]
        {
          (object) "@quoteGuid",
          (object) this._quote.QuoteGuid,
          (object) "@endorseEff",
          (object) formEx.EndorsementEffective
        });
      }
    }
    finally
    {
      formEx.Dispose();
    }
  }

  private bool DateEqual(DateTime date1, DateTime date2)
  {
    bool flag = false;
    return date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day || flag;
  }

  private void AssignAffidavitNumber()
  {
    if (this._quote.CompanyLicenseType == 2)
    {
      bool isEndorsement = this._quote.IsEndorsement;
      if (isEndorsement && !SystemSettings.GetSetting<bool>("AssignAffidavitNumberOnEndorsements", false))
      {
        int num1 = (int) System.Windows.Forms.MessageBox.Show("Affidavit numbers can only be created on the original, unendorsed version of the policy.", "Unable to Assign Affidavit Number", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        string text = "Are you sure you want to assign an affidavit number to the original, unendorsed version of the policy?";
        if (isEndorsement)
          text = "This Is an endorsement policy.\n\nAre you sure you want to assign an affidavit number to all versions of the policy?";
        if (System.Windows.Forms.MessageBox.Show(text, "Assign Affidavit Number?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        try
        {
          Cursor.Current = MgaCursors.Working;
          DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT QuoteGuid FROM tblQuotes WITH (NOLOCK) WHERE ControlNo = @cn", new object[2]
          {
            (object) "@cn",
            (object) this.Quote.ControlNo
          });
          try
          {
            foreach (DataRow row in dataTable.Rows)
              Numbering.AssignAffidavitNumbers((Guid) row[0]);
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        finally
        {
          Cursor.Current = MgaCursors.Default;
        }
        int num2;
        if (!isEndorsement)
          num2 = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblQuoteAffidavitNumbers WITH(NOLOCK) WHERE QuoteID=@QuoteID", new object[2]
          {
            (object) "@QuoteID",
            (object) this._quote.QuoteID
          });
        else
          num2 = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblQuoteAffidavitNumbers A WITH(NOLOCK) INNER JOIN tblQuotes Q WITH (NOLOCK) ON Q.QuoteID = A.QuoteID WHERE Q.ControlNo=@CN", new object[2]
          {
            (object) "@CN",
            (object) this._quote.ControlNo
          });
        if (num2 > 0)
        {
          Form form = (Form) null;
          try
          {
            form = FormSettings.ShowFormDialog(typeof (frmAffidavitConfirmation), new object[2]
            {
              (object) this._quote.QuoteID,
              (object) this._quote.IsEndorsement
            });
          }
          finally
          {
            form?.Dispose();
          }
        }
        else
        {
          int num3 = (int) System.Windows.Forms.MessageBox.Show("No affidavit numbers were generated for this quote.", "No Numbers Generated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
    }
    else
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("Affidavit numbers can only be created on non-admitted business.", "Unable to Assign Affidavit Number", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void LoadControl(string controlKey)
  {
    PolicyDetail_Plugin policyDetailPlugin1 = (PolicyDetail_Plugin) null;
    Type o = (Type) null;
    bool flag = this._cachedPlugins.ContainsKey(controlKey);
    if (this._pluginTypes == null)
      this._pluginTypes = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new PolicyDetail_PluginAttribute());
    if (flag)
    {
      policyDetailPlugin1 = this._cachedPlugins[controlKey];
    }
    else
    {
      Type[] pluginTypes = this._pluginTypes;
      int index1 = 0;
      while (index1 < pluginTypes.Length)
      {
        Type type = pluginTypes[index1];
        object[] customAttributes = type.GetCustomAttributes(false);
        int index2 = 0;
        while (index2 < customAttributes.Length)
        {
          if ((Attribute) customAttributes[index2] is PolicyDetail_PluginAttribute detailPluginAttribute && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(detailPluginAttribute.Key, controlKey, false) == 0)
          {
            policyDetailPlugin1 = (PolicyDetail_Plugin) ObjectFactory.Instance.CreateObject(type, new object[1]
            {
              (object) this._quote.QuoteGuid
            });
            o = type;
            policyDetailPlugin1.Tag = (object) detailPluginAttribute.Title;
            break;
          }
          checked { ++index2; }
        }
        if (policyDetailPlugin1 == null)
          checked { ++index1; }
        else
          break;
      }
      if (policyDetailPlugin1 == null)
        throw new InvalidOperationException($"Could Not locate policy detail plugin \"{controlKey}\"");
      if (!this._cachedPlugins.ContainsKey(controlKey))
        this._cachedPlugins.Add(controlKey, policyDetailPlugin1);
    }
    if (this.pnlMiscInfo.Controls.Count > 1)
    {
      if (((PolicyDetail_Plugin) this.pnlMiscInfo.Controls[1]).GetType().Equals(o) && flag)
        return;
      this.pnlMiscInfo.Controls.Remove(this.pnlMiscInfo.Controls[1]);
    }
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      API.LockWindowUpdate(this.pnlMiscInfo.Handle);
      if (!flag)
      {
        PolicyDetail_Plugin policyDetailPlugin2 = policyDetailPlugin1;
        policyDetailPlugin2.SuspendLayout();
        policyDetailPlugin2.Visible = false;
        policyDetailPlugin2.Dock = DockStyle.Fill;
        policyDetailPlugin2.Fill();
        policyDetailPlugin2.ResumeLayout();
        if (policyDetailPlugin1 is PolicyDetail_Premiums policyDetailPremiums)
          policyDetailPremiums.PremiumsControlLoaded += new PolicyDetail_Premiums.PremiumsControlLoadedEventHandler(this.PremiumsControlLoaded);
      }
      this.pnlMiscInfo.Controls.Add((Control) policyDetailPlugin1);
      policyDetailPlugin1.Visible = true;
      this.lblMiscInfo.Text = policyDetailPlugin1.Tag.ToString();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
      API.LockWindowUpdate(new IntPtr());
    }
  }

  private void rater_UIClosed(object sender, EventArgs e)
  {
    ((IDisposable) sender).Dispose();
    this.RefillOptions();
    this.AuthorityLimitCheck((AuthorityLimitCheckType) 2, true);
    this.ThresholdLimitCheck((ThresholdLimitCheckType) 2, true);
  }

  private void RefillOptions()
  {
    Quote q = Quote.CreateNew(this._quote.QuoteGuid);
    bool hasPremium = q.HasPremium;
    try
    {
      UltraExplorerBarGroup group = this.leftMenu.Groups["PolicyActions"];
      group.Items["Print"].Visible = hasPremium;
      group.Items["Commissions"].Visible = hasPremium;
      group.Items["Fees"].Visible = hasPremium;
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
      return;
    }
    try
    {
      if (this.pnlMiscInfo.Controls.Count > 1 && this.pnlMiscInfo.Controls[1] is PolicyDetail_Premiums)
        ((PolicyDetail_Premiums) this.pnlMiscInfo.Controls[1]).Fill();
      else if (this._cachedPlugins.ContainsKey("Premiums"))
        ((PolicyDetail_Premiums) this._cachedPlugins["Premiums"]).Fill();
    }
    catch (IndexOutOfRangeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    this._statusChangeMenu.EnableDisableItems(q);
  }

  private Guid GetCompanyLineGuid(bool forcePrompt)
  {
    if (((UltraGridBase) this.dgParticipants).Rows.Count == 0)
      return Guid.Empty;
    if (((UltraGridBase) this.dgParticipants).Rows.Count == 1)
      return (Guid) ((UltraGridBase) this.dgParticipants).Rows[0].Cells["CompanyLineGuid"].Value;
    if (this.Quote.DefaultToFirstPolicyDetailItem && !forcePrompt)
      return (Guid) ((UltraGridBase) this.dgParticipants).Rows[0].Cells["CompanyLineGuid"].Value;
    if ((this.Quote.UsingNetRate || this.Quote.UsingGenericMultiCarrierRater) && !forcePrompt)
      return (Guid) ((UltraGridBase) this.dgParticipants).Rows[0].Cells["CompanyLineGuid"].Value;
    frmSelectQuoteDetail selectQuoteDetail = (frmSelectQuoteDetail) FormSettings.ShowFormDialog(typeof (frmSelectQuoteDetail), new object[1]
    {
      (object) this._quote.QuoteGuid
    });
    MDIControls.Instance.MDIParent.Refresh();
    try
    {
      return selectQuoteDetail.ItemSelected ? selectQuoteDetail.CompanyLineGuid : Guid.Empty;
    }
    finally
    {
      ((Component) selectQuoteDetail).Dispose();
    }
  }

  private void RaterOptionRated(object sender, OptionRatedEventArgs e)
  {
    this.ClientOptionRated(sender as RaterBase, (Quote) this._quote);
    this.RefillOptions();
  }

  protected virtual void ClientOptionRated(RaterBase rater, Quote ratedQuote)
  {
  }

  private string GetRaterName(int raterID)
  {
    string raterName = (string) null;
    if (!frmPolicyDetail._raterNameCache.TryGetValue(raterID, out raterName))
    {
      raterName = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT RatingType FROM lstRatingTypes WHERE RatingTypeID=@RatingTypeID", new object[2]
      {
        (object) "@RatingTypeID",
        (object) raterID
      });
      frmPolicyDetail._raterNameCache.Add(raterID, raterName);
    }
    return raterName;
  }

  private void SetUsingNetRate(frmQuoteDetailRaterConfig f)
  {
    try
    {
      foreach (dsPolicyDetail.tblQuoteDetailsRow tblQuoteDetailsRow in (TypedTableBase<dsPolicyDetail.tblQuoteDetailsRow>) ((UltraGridBase) this.dgParticipants).DataSource)
      {
        if (new CompanyLine(tblQuoteDetailsRow.CompanyLineGuid).IsRaterAvailable((RatingTypes) 100))
        {
          tblQuoteDetailsRow.RaterID = f.RaterId;
          tblQuoteDetailsRow.RatingType = this.GetRaterName(tblQuoteDetailsRow.RaterID);
          new QuoteDetail(this._quote.QuoteGuid, tblQuoteDetailsRow.CompanyLineGuid).RaterID = new int?(f.RaterId);
        }
      }
    }
    finally
    {
      IEnumerator<dsPolicyDetail.tblQuoteDetailsRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void SetUsingGenericMultiCarrier(frmQuoteDetailRaterConfig f)
  {
    try
    {
      foreach (dsPolicyDetail.tblQuoteDetailsRow tblQuoteDetailsRow in (TypedTableBase<dsPolicyDetail.tblQuoteDetailsRow>) ((UltraGridBase) this.dgParticipants).DataSource)
      {
        if (new CompanyLine(tblQuoteDetailsRow.CompanyLineGuid).IsRaterAvailable((RatingTypes) 89))
        {
          tblQuoteDetailsRow.RaterID = f.RaterId;
          tblQuoteDetailsRow.RatingType = this.GetRaterName(tblQuoteDetailsRow.RaterID);
          new QuoteDetail(this._quote.QuoteGuid, tblQuoteDetailsRow.CompanyLineGuid).RaterID = new int?(f.RaterId);
        }
      }
    }
    finally
    {
      IEnumerator<dsPolicyDetail.tblQuoteDetailsRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private static void EnsureFactorSetAvailableOnCompanyLine(Guid companyLineGuid, int raterID = -1)
  {
    if (!SecurityManager.Instance.AssertPermission("{C3BEF8F3-11B0-4439-9E74-E1093E5328F6}"))
      return;
    if (raterID == -1)
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "select distinct tcr.RatingTypeID from tblCompanyRaters tcr inner join tblFactorSets tf on tf.RaterID = tcr.RatingTypeID where tcr.CompanyLineGuid = @CompanyLineGuid", new object[2]
      {
        (object) "@companyLineGuid",
        (object) companyLineGuid
      });
      if (dataTable == null)
        return;
      if (dataTable.Rows.Count <= 0)
        return;
      try
      {
        foreach (DataRow row in dataTable.Rows)
        {
          if ((int) DefaultDatabase.ExecuteScalar(CommandType.Text, "select count(*) from tblCompanyLineFactorSets tclf inner join tblFactorSets tf on tf.FactorSetGUID = tclf.FactorSetGUID where tf.Hidden = 0 And tclf.CompanyLineGUID = @CompanyLineGUID And tf.RaterID = @RaterID ", new object[4]
          {
            (object) "@RaterID",
            row["RatingTypeID"],
            (object) "@CompanyLineGUID",
            (object) companyLineGuid
          }) == 0)
            frmPolicyDetail.DisplayFactorSetChooser((int) row["RatingTypeID"], companyLineGuid);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else
    {
      if ((int) DefaultDatabase.ExecuteScalar(CommandType.Text, "select count(*) from tblFactorSets where RaterID = @RaterID", new object[2]
      {
        (object) "@RaterID",
        (object) raterID
      }) <= 0)
        return;
      if ((int) DefaultDatabase.ExecuteScalar(CommandType.Text, "select count(*) from tblCompanyLineFactorSets tclf inner join tblFactorSets tf on tf.FactorSetGUID = tclf.FactorSetGUID where tf.Hidden = 0 And tclf.CompanyLineGUID = @CompanyLineGUID", new object[2]
      {
        (object) "@CompanyLineGUID",
        (object) companyLineGuid
      }) != 0)
        return;
      frmPolicyDetail.DisplayFactorSetChooser(raterID, companyLineGuid);
    }
  }

  private static void DisplayFactorSetChooser(int raterID, Guid companyLineGuid)
  {
    using (frmSelectFactorSet frmSelectFactorSet = (frmSelectFactorSet) FormSettings.ShowFormDialog(typeof (frmSelectFactorSet), new object[1]
    {
      (object) raterID
    }))
    {
      if (!(frmSelectFactorSet.FactorSetGuid != Guid.Empty))
        return;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "insert into tblCompanyLineFactorSets (FactorSetGUID, CompanyLineGUID) values (@FactorSetGUID, @CompanyLineGUID)", new object[4]
      {
        (object) "@FactorSetGUID",
        (object) frmSelectFactorSet.FactorSetGuid,
        (object) "@CompanyLineGUID",
        (object) companyLineGuid
      });
    }
  }

  public void InvokeRaterUI() => this.ClickRating();

  protected virtual void ClickRating()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    Guid companyLineGuid = this.GetCompanyLineGuid(false);
    if (companyLineGuid.Equals(Guid.Empty) || !this.IsClientRatingValid())
      return;
    if (!this.Quote.IsEndorsement && new ProducerLine((Quote) this.Quote).Exists)
    {
      if (Conversions.ToBoolean(DefaultDatabase.ExecuteScalar("spIsTheCurrentProducerLineBlocked", new object[6]
      {
        (object) "@producerLocationGuid",
        (object) this.Quote.ProducerLocationGuid,
        (object) "@CompanyLineGuid",
        (object) this.Quote.CompanyLineGuid,
        (object) "@PolicyTypeID",
        (object) this.Quote.PolicyTypeID
      })))
      {
        int num = (int) System.Windows.Forms.MessageBox.Show("This producer/line Is currently blocked.  No rating information can be created.", "Blocked Setup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
    }
    dsPolicyDetail.tblQuoteDetailsRow byCompanyLineGuid = ((dsPolicyDetail.tblQuoteDetailsDataTable) ((UltraGridBase) this.dgParticipants).DataSource).FindByCompanyLineGuid(companyLineGuid);
    if (!byCompanyLineGuid.IsRaterIDNull() && !this.Quote.IsBound && !this.Quote.IsEndorsement)
    {
      if ((int) DefaultDatabase.ExecuteScalar(CommandType.Text, "select count(*) from tblCompanyRaters where CompanyLineGuid = @CompanyLineGuid And RatingTypeID = @RatingTypeID", new object[4]
      {
        (object) "@CompanyLineGuid",
        (object) companyLineGuid,
        (object) "@RatingTypeID",
        (object) byCompanyLineGuid.RaterID
      }) == 0 && System.Windows.Forms.MessageBox.Show("The rater selected on this policy Is invalid. Are you sure you'd like to proceed? Click Yes to continue, or no to choose a different rater.", "Rater invalid for this company line", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        this.ResetRater();
    }
    IRater rater;
    if (byCompanyLineGuid.IsRaterIDNull())
    {
      frmPolicyDetail.EnsureFactorSetAvailableOnCompanyLine(companyLineGuid);
      frmQuoteDetailRaterConfig formEx = (frmQuoteDetailRaterConfig) ObjectFactory.Instance.CreateFormEX(typeof (frmQuoteDetailRaterConfig), new object[2]
      {
        (object) this._quote.QuoteGuid,
        (object) companyLineGuid
      });
      try
      {
        formEx.GetData();
        if (formEx.RatersAvailable == 1 && (formEx.FactorSetsAvailable == 1 || !(formEx.Rater is IRaterWithFactorSet)))
        {
          formEx.SaveData();
        }
        else
        {
          if (formEx.RatersAvailable == 0)
          {
            if (SecurityManager.Instance.AssertPermission("{DC60B27B-78EC-4c89-9750-FAC8B385565A}"))
            {
              if (System.Windows.Forms.MessageBox.Show("No raters are assigned to this company/line/state combination.\n\nWould you like to assign them now?", "No Rater Assigned", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                return;
              FormSettings.ShowForm(typeof (frmCompanyRaters), new object[1]
              {
                (object) companyLineGuid
              });
              return;
            }
            int num = (int) System.Windows.Forms.MessageBox.Show("No raters are assigned to this company/line/state combination.", "No Rater Assigned", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
          if (formEx.FactorSetsAvailable == 0 && formEx.RatersAvailable == 1 && formEx.Rater is IRaterWithFactorSet)
          {
            int num = (int) System.Windows.Forms.MessageBox.Show("No factor sets are assigned to only available rater for this company/line/state combination.\n\nCan not rate this quote.", "No Rater Assigned", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
          if (formEx.RatersAvailable > 0 || formEx.FactorSetsAvailable > 0)
          {
            int num = (int) ((Form) formEx).ShowDialog((IWin32Window) ((Form) formEx).MdiParent);
            if (!formEx.Saved || formEx.Rater == null)
              return;
            this.UpdatePolicyDetailForms(companyLineGuid, formEx);
          }
        }
        if (formEx.Rater == null)
          return;
        rater = formEx.Rater;
        if (formEx.RaterId == 100)
          this.SetUsingNetRate(formEx);
        else if (formEx.RaterId == 89)
          this.SetUsingGenericMultiCarrier(formEx);
        else
          this.SelectRater(byCompanyLineGuid, formEx);
        CurrentUser.Instance.LogAction($"Invoke '{this.GetRaterName(formEx.RaterId)}' rater", this.Quote.QuoteGuid);
        if (rater is IRaterWithFactorSet2)
        {
          if (formEx.FactorSetsAvailable > 0)
            this.RaterSetupChange(rater, formEx.RaterId, this.Quote.QuoteGuid, formEx.FactorSetGuid);
        }
      }
      finally
      {
        ((Component) formEx).Dispose();
      }
    }
    else
    {
      frmPolicyDetail.EnsureFactorSetAvailableOnCompanyLine(companyLineGuid, byCompanyLineGuid.RaterID);
      rater = RaterFactory.GetRater(byCompanyLineGuid.RaterID);
    }
    bool flag = true;
    if (byCompanyLineGuid.RaterID == 100)
    {
      if (!SecurityManager.Instance.AssertPermission("{FF1F9A83-E24A-4c49-8D9A-1C3FB1C88F1D}"))
        flag = false;
    }
    else if (byCompanyLineGuid.RaterID == 0)
      DefaultDatabase.ExecuteNonQuery("GenericRater_AssignAsDefaultRater", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.Quote.QuoteGuid
      });
    if (rater != null && flag)
    {
      CurrentUser.Instance.LogAction($"Invoke '{this.GetRaterName(byCompanyLineGuid.RaterID)}' rater", this.Quote.QuoteGuid);
      this.RaterFound(rater, byCompanyLineGuid, companyLineGuid);
    }
    else if (!flag)
    {
      int num1 = (int) System.Windows.Forms.MessageBox.Show("Insufficient security to access NetRate.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      int num2 = (int) System.Windows.Forms.MessageBox.Show($"A rater was not found for {new CompanyLine(companyLineGuid).CompanyLineState}.", "Rater Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      return;
    }
    Cursor.Current = MgaCursors.Default;
  }

  protected virtual void RefillOptionsOnClient() => this.RefillOptions();

  protected virtual bool IsClientRatingValid() => true;

  private void RaterFound(IRater rater, dsPolicyDetail.tblQuoteDetailsRow dr, Guid companyLineGuid)
  {
    if (dr.RaterID == 100 && this._quote.IsBound && System.Windows.Forms.MessageBox.Show("This risk is bound.\n\nNo changes should be made in NetRate!\nThe IMS will ignore any data being returned on a bound policy.", "NetRate - Bound Policy Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
      return;
    MDIControls.Instance.StatusBarText = "Launching rater...";
    rater.OptionRated += new OptionRatedEventHandler(this.RaterOptionRated);
    try
    {
      if (rater is IRaterWithFactorSet iraterWithFactorSet)
      {
        if (dr.IsFactorSetGuidNull())
        {
          object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select FactorSetGuid from tblQuoteDetails where QuoteGuid = @QuoteGuid and CompanyLineGuid = @CompanyLineGuid", new object[4]
          {
            (object) "@CompanyLineGuid",
            (object) companyLineGuid,
            (object) "@QuoteGuid",
            (object) this.Quote.QuoteGuid
          }));
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
            dr.FactorSetGuid = (Guid) objectValue;
        }
        if (dr.IsFactorSetGuidNull())
          this.SelectFactorSet(dr);
        if (dr.IsFactorSetGuidNull())
        {
          int num = (int) System.Windows.Forms.MessageBox.Show("This rater requires a factor set, but was unable to assign one.", "Factor Set Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        iraterWithFactorSet.FactorSetGuid = dr.FactorSetGuid;
      }
      else if (rater is IMultiCompanyRater imultiCompanyRater)
      {
        int num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT CompanyLocationCode FROM tblCompanyLocations LOC INNER JOIN tblCompanyLines CL ON CL.CompanyLocationGuid = LOC.CompanyLocationGuid WHERE CL.CompanyLineGuid=@CompanyLineGuid", new object[2]
        {
          (object) "@CompanyLineGuid",
          (object) companyLineGuid
        });
        imultiCompanyRater.SetCompanyLocationId(num);
      }
      else if (this._quote.IsMultiCompanyPolicy)
      {
        int num = (int) System.Windows.Forms.MessageBox.Show("This rater is not capable of rating multi-company policies.", "Unable to Rate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      this.Rate(rater, companyLineGuid);
    }
    finally
    {
      MDIControls.Instance.StatusBarText = string.Empty;
    }
  }

  private void SelectRater(dsPolicyDetail.tblQuoteDetailsRow dr, frmQuoteDetailRaterConfig f)
  {
    dr.RaterID = f.RaterId;
    dr.RatingType = this.GetRaterName(dr.RaterID);
    new QuoteDetail(this._quote.QuoteGuid, dr.CompanyLineGuid).RaterID = new int?(f.RaterId);
  }

  private void SelectFactorSet(dsPolicyDetail.tblQuoteDetailsRow dr)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.GetCompanyFactorSets", new object[4]
    {
      (object) "@RaterID",
      (object) dr.RaterID,
      (object) "@CompanyLineGuid",
      (object) dr.CompanyLineGuid
    });
    Guid factorSetGuid = Guid.Empty;
    if (dataTable != null && dataTable.Rows.Count == 1)
    {
      factorSetGuid = (Guid) dataTable.Rows[0]["FactorSetGUID"];
    }
    else
    {
      using (frmSelectFactorSet frmSelectFactorSet = (frmSelectFactorSet) FormSettings.ShowFormDialog(typeof (frmSelectFactorSet), new object[2]
      {
        (object) dr.RaterID,
        (object) dr.CompanyLineGuid
      }))
      {
        if (!frmSelectFactorSet.FactorSetGuid.Equals(Guid.Empty))
        {
          factorSetGuid = frmSelectFactorSet.FactorSetGuid;
        }
        else
        {
          int num = (int) System.Windows.Forms.MessageBox.Show("A factor set must be selected before this rater can be used.", "Unable to Rate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }
    }
    if (factorSetGuid.Equals(Guid.Empty))
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteDetails SET FactorsetGuid=@FS WHERE RaterID=@RID AND QuoteGuid = @QG AND CompanyLineGuid = @CLG", new object[8]
    {
      (object) "@FS",
      (object) factorSetGuid,
      (object) "@RID",
      (object) dr.RaterID,
      (object) "@QG",
      (object) this._quote.QuoteGuid,
      (object) "@CLG",
      (object) dr.CompanyLineGuid
    });
    dr.FactorSetGuid = factorSetGuid;
    this.RaterSetupChange((IRater) null, dr.RaterID, this._quote.QuoteGuid, factorSetGuid);
  }

  private void Rate(IRater rater, Guid companyLineGuid)
  {
    rater.InitializeState((Quote) this._quote, companyLineGuid);
    if (rater.HasUI)
    {
      rater.UIClosed += new EventHandler(this.rater_UIClosed);
      rater.ShowUI();
    }
    else if (!this._reconnectNetRateData)
    {
      if (!this._updateNetRateXML)
      {
        if (this._showNetRateQuoteIDDialog)
        {
          if (rater is INetRateQuoteIDDialog rateQuoteIdDialog)
            rateQuoteIdDialog.ShowNetRateQuoteIDDialog();
          this._showNetRateQuoteIDDialog = false;
        }
        rater.DoNonUIWork();
      }
      else if (rater is INetRateDoNonUIWork inetRateDoNonUiWork)
        inetRateDoNonUiWork.NetRateDoNonUIWork(this._updateNetRateXML, this._NetRateXMLDoc);
    }
    else if (rater is INetRateReconnectData rateReconnectData)
      rateReconnectData.NetRateReconnectData();
    if (rater.HasUI)
      return;
    ((IDisposable) rater).Dispose();
  }

  private void UpdatePolicyDetailForms(Guid companyLineGuid, frmQuoteDetailRaterConfig f)
  {
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmPolicyDetail frmPolicyDetail && frmPolicyDetail.Quote.QuoteGuid.Equals(this.Quote.QuoteGuid))
      {
        if (f.Rater is IRaterWithFactorSet)
          frmPolicyDetail.UpdateFactorSet(companyLineGuid, f.FactorSetGuid);
        frmPolicyDetail.UpdateRater(companyLineGuid, f.RaterId);
      }
      checked { ++index; }
    }
  }

  private void ShowCommissionsScreen()
  {
    Guid companyLineGuid = this.GetCompanyLineGuid(true);
    if (companyLineGuid.Equals(Guid.Empty))
      return;
    CompanyLine companyLine = new CompanyLine(companyLineGuid);
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT QuoteOptionGuid, Premium FROM dbo.tblQuoteOptions WITH(NOLOCK) WHERE QuoteGuid=@QuoteGuid AND LineGuid=@LineGuid AND ISNULL(CompanyLocationID, @companyLocID) = @companyLocID AND Bound=1", new object[6]
    {
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid,
      (object) "@LineGuid",
      (object) companyLine.LineGuid,
      (object) "@companyLocID",
      (object) companyLine.CompanyLocation.CompanyLocationID
    });
    if (dataRow == null || dataRow.IsNull(0))
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT QuoteOptionGuid FROM dbo.tblQuoteOptions WITH(NOLOCK) WHERE QuoteGuid=@QuoteGuid AND LineGuid=@LineGuid AND CompanyLocationID=@companyLocID", new object[6]
      {
        (object) "@QuoteGuid",
        (object) this._quote.QuoteGuid,
        (object) "@LineGuid",
        (object) companyLine.LineGuid,
        (object) "@companyLocID",
        (object) companyLine.CompanyLocation.CompanyLocationID
      });
      if ((dataTable != null ? (dataTable.Rows.Count != 1 ? 1 : 0) : 0) != 0)
      {
        int num = (int) System.Windows.Forms.MessageBox.Show($"Please bind an option for {companyLine.LineName} before establishing commissions.\n\nTo modify the company/producer commission percentages, please use the \"Edit Policy\" button above.", "No Bound Option", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        return;
      }
      Guid quoteOptionGuid = dataTable.Rows[0].Field<Guid>("QuoteOptionGuid");
      this.PremiumsControl.BindUnbindOption(true, quoteOptionGuid);
      dataRow = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT QuoteOptionGuid, Premium FROM dbo.tblQuoteOptions WITH(NOLOCK) WHERE QuoteOptionGuid = @QOGuid", new object[2]
      {
        (object) "@QOGuid",
        (object) quoteOptionGuid
      }).AsEnumerable().FirstOrDefault<DataRow>();
    }
    object objectValue = RuntimeHelpers.GetObjectValue(dataRow[0]);
    Conversions.ToInteger(dataRow[1]);
    if (!SecurityManager.Instance.AssertPermission("{9AEB647B-3105-4a79-ADB5-20C248C70D7E}"))
    {
      int num1 = (int) System.Windows.Forms.MessageBox.Show("You do Not have permission to view the commissionable entities on this policy.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      FormSettings.ShowForm(typeof (frmPolicyCommissions), new object[1]
      {
        (object) (Guid) objectValue
      });
  }

  private void ClickedPrint()
  {
    if (this._runAuthorityLimitCheck && !this._runAuthorityCheckAtStartup)
    {
      this.AuthorityLimitCheck((AuthorityLimitCheckType) 1, true);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.leftMenu.Groups["PolicyActions"].Items["Print"].Text, "Print Quote", false) == 0 && !this._authorityLimitCheckManager.CanPrintQuoteHard())
        return;
    }
    if (this._runThresholdLimitCheck && !this._runThresholdCheckAtStartup)
    {
      this.ThresholdLimitCheck((ThresholdLimitCheckType) 1, true);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.leftMenu.Groups["PolicyActions"].Items["Print"].Text, "Print Quote", false) == 0 && !this._thresholdLimitCheckManager.CanPrintQuoteHard())
        return;
    }
    if (this.Quote.RatedInNetRate && SystemSettings.GetSetting<bool>("EnforceNetRateCompanyMatchOnQuote", false) && SystemSettings.GetSetting<string>("EnforceNetRateCompanyMatchOnQuote", (string) null) != null)
    {
      if (CollectionExtensions.ValueInNoCase(SystemSettings.GetSetting<string>("EnforceNetRateCompanyMatchOnQuote", (string) null), new string[2]
      {
        this.Quote.CompanyLine.LineCode,
        "ALL"
      }))
      {
        DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM dbo.NetRateNotReadyToBindReasons(@quoteGuid)", new object[2]
        {
          (object) "@quoteGuid",
          (object) this.Quote.QuoteGuid
        });
        if (dataTable.Rows.Count > 0)
        {
          List<string> stringList = new List<string>();
          try
          {
            foreach (DataRow row in dataTable.Rows)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row["Reason"].ToString(), "The company selected in NetRate does Not match", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row["Reason"].ToString(), "  the company for this account in the IMS.", false) == 0)
              {
                stringList.Add(row["Reason"].ToString());
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row["Reason"].ToString(), "  the company for this account in the IMS.", false) == 0)
                {
                  FormSettings.ShowFormDialog(typeof (frmBindingRequirements), new object[2]
                  {
                    (object) stringList,
                    (object) frmBindingRequirements.RequirementsType.Bind
                  });
                  return;
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
      }
    }
    if (this.PremiumsControl == null || !this.PremiumsControl.ReadyToPrint())
      return;
    if (!this.Quote.CompanyLine.AllowLapseInCoverageOnRenewal && !this.Quote.IsBound && this.Quote.PolicyType == 2)
    {
      int num1 = DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.CheckRenewalPolicyTerms(@QuoteGUID)", new object[2]
      {
        (object) "@QuoteGUID",
        (object) this.Quote.QuoteGuid
      }) ? 1 : 0;
      bool flag = SecurityManager.Instance.AssertPermission("{01C3023E-006D-4de8-805A-C4E43A818693}");
      if (num1 == 0)
      {
        if (flag)
        {
          if (System.Windows.Forms.MessageBox.Show("The effective date on the current policy does Not match the expiration date on the renewed policy.\n\nContinue to print quote docs?", "Policy Terms Not Match", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            return;
          CurrentUser.Instance.LogAction("Print quote docs on renewals when the terms, expiration date of the previous policy And the effective date of the current policy, do Not match", this.Quote.QuoteGuid);
        }
        else
        {
          int num2 = (int) System.Windows.Forms.MessageBox.Show("The effective date on the current policy does Not match the expiration date on the renewed policy.", "Policy Terms Not Match", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }
    }
    if (this.Quote.IsBound)
    {
      if (this._quote.IsEndorsement)
      {
        if (this.Quote.QuoteStatus == 12 && this.Quote.PreviousQuote.QuoteStatus != 12)
          Messaging.SendBroadcastMessage(BroadcastMessages.PolicyCancelled, (object) this.Quote.QuoteGuid);
        else if (this.Quote.IsReinstated)
          Messaging.SendBroadcastMessage(BroadcastMessages.PolicyReinstated, (object) this.Quote.QuoteGuid);
        else if (this.Quote.IsAuditTransaction)
        {
          Messaging.SendBroadcastMessage(BroadcastMessages.AuditCreated, (object) this.Quote.QuoteGuid);
          Messaging.SendBroadcastMessage(BroadcastMessages.EndorsementBound, (object) this.Quote.QuoteGuid);
        }
        else
          Messaging.SendBroadcastMessage(BroadcastMessages.EndorsementBound, (object) this.Quote.QuoteGuid);
      }
      else
        Messaging.SendBroadcastMessage(BroadcastMessages.ReprintBinder, (object) this.Quote.QuoteGuid);
    }
    else
      this.PrintQuote();
  }

  private bool PassPrintQuoteCompanyLineRequirements()
  {
    bool flag;
    if (this.Quote.IsBound || this.Quote.IsEndorsement)
      flag = true;
    else if (this._printingIndication && this.IgnoreCompanyLineRequirementsOnPrintIndication)
    {
      flag = true;
    }
    else
    {
      object objectValue1 = RuntimeHelpers.GetObjectValue(this.Quote.ChangeStatusRequirementsSoftStops(2));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)))
      {
        int num1 = (int) System.Windows.Forms.MessageBox.Show($"Soft Stop(s). The following print quote requirements are not met - {"\n"}{RuntimeHelpers.GetObjectValue(objectValue1)}", "Print Quote Company/Line Requirement(s) Not Met", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      object objectValue2 = RuntimeHelpers.GetObjectValue(this.Quote.ChangeStatusRequirementsHardStops(2));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
      {
        int num2 = (int) System.Windows.Forms.MessageBox.Show(objectValue2.ToString(), "Print Quote Company/Line requirement(s) Not Met", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        if (SystemSettings.GetSetting<bool>("CompanyLineRequirements.ImplementSoftStops", false))
        {
          if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "select count(ID) from tblCompanyLineBindingReqStops where CompanyLineID = @ID and QuotingSoftStop = @B", new object[4]
          {
            (object) "@ID",
            (object) this.Quote.CompanyLine.CompanyLineID,
            (object) "@B",
            (object) true
          }) > 0)
          {
            flag = true;
            goto label_12;
          }
        }
        flag = false;
      }
      else
        flag = true;
    }
label_12:
    return flag;
  }

  protected virtual bool BaseValidForPrint()
  {
    bool flag;
    if (this.AbortPrintBecausePolicyIsBound())
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("You requested to print however the policy is bound. The policy may have been bound by another user.", "Control Bound", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
    {
      string setting = SystemSettings.GetSetting<string>("ProducerRequirementsSatisfiedStoredProc", "dbo.spIsProducerRequirementsSatisfied");
      if (!this.Quote.IsEndorsement)
      {
        if (!DefaultDatabase.ExecuteScalar<bool>(setting, new object[10]
        {
          (object) "@submissionGroupGuid",
          (object) this.Quote.SubmissionGroupGuid,
          (object) "@producerLocationGuid",
          (object) this.Quote.ProducerLocationGuid,
          (object) "@requirementType",
          (object) "Q",
          (object) "@ExpirationDate",
          (object) this.Quote.ExpirationDate,
          (object) "@EffectiveDate",
          (object) this.Quote.EffectiveDate
        }))
        {
          string empty = string.Empty;
          object objectValue = RuntimeHelpers.GetObjectValue(this.MissingroducerRequirement("Q", ref empty));
          if (objectValue != null && objectValue != DBNull.Value)
          {
            if (System.Windows.Forms.MessageBox.Show($"***Warning*** \n\nProducer Requirement '{objectValue.ToString()}' has not been met because {empty}\n\nProceed?.", "Producer Requirement Not Met", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
              flag = false;
              goto label_19;
            }
          }
          else
          {
            int num = (int) System.Windows.Forms.MessageBox.Show("At least one specified producer requirement marked 'Needed to Quote' is not on file.\n\nOr its 'Valid Through' date occurs before today's date.", "Invalid Producer Requirement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag = false;
            goto label_19;
          }
        }
      }
      if (!this.Quote.IsEndorsement && SystemSettings.GetSetting<bool>("ImplementPolicyFormsAutoAppliedOnPrint", false) && !this.Quote.PolicyFormsAutoApplied)
      {
        int num = (int) System.Windows.Forms.MessageBox.Show("Please review the policy forms prior to printing a quote.", "Review Policy Forms", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
      }
      else if (!this.PassesTargetPremiumCheck())
      {
        int num = (int) System.Windows.Forms.MessageBox.Show("This line of business requires a target premium that is less than the quoted premium.", "Target Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
      }
      else if (this.Quote.PolicyType == 1 && !SecurityManager.Instance.AssertPermission("{E4928B2F-5ED8-408a-844E-883157741E38}"))
      {
        int num = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to print new business quote.", "Security Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
      }
      else if (!this.VerifyNoMissingNotesOnPolicy(this._quote.QuoteGuid))
        flag = false;
      else if (!this.ValidPrintStatus())
      {
        int num = (int) System.Windows.Forms.MessageBox.Show($"Invalid quote status change from '{this.Quote.QuoteStatus.ToString()}' to '{((QuoteStatus) 25).ToString()}'", "Invalid Status Change", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
      }
      else
        flag = this.PassPrintQuoteCompanyLineRequirements() && this.ValidInsuredStatusOnQuote() && this.ValidCompanyLinePrintStatus();
    }
label_19:
    return flag;
  }

  protected virtual bool ValidCompanyLinePrintStatus()
  {
    bool flag;
    if (this.ClickPrintIndication)
      flag = true;
    else if (this.Quote.CompanyLine.StatusID != 2)
      flag = true;
    else if (!this._printQuoteOnInactiveLine)
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("You do not have the required permission to print quotes with an inactive company/line status.", "Cannot Print - Inactive Company/Line Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  protected virtual bool ValidPrintStatus()
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual bool AbortPrintBecausePolicyIsBound()
  {
    this.RefreshPolicyData();
    return this.Quote.QuoteStatusID == 3;
  }

  public virtual void PrintQuote()
  {
    try
    {
      MDIControls.Instance.StatusBarText = "Please wait. About to print quote ...";
      Cursor.Current = MgaCursors.WaitCursor;
      if (!this.BaseValidForPrint() || !this.ClientValidForPrintQuote())
        return;
      this.VerifyProducerCommissions();
      if (this._validateOnQuote.Value && !this.ValidateCompliance("Print Quote", this._canOverrideQuoteOfacHits, this._canOverrideQuoteAIOfacHits, this._checkOfacOnQuoteIfMissing.Value, this._bypassOfacSystemOnQuote.Value))
        return;
      this.UpdateCommissionsOnQuote(frmPolicyDetail.EventType.Print);
    }
    finally
    {
      MDIControls.Instance.StatusBarText = string.Empty;
      Cursor.Current = MgaCursors.Default;
    }
    Messaging.SendBroadcastMessage(BroadcastMessages.QuotePrinted, (object) this._quote.QuoteGuid);
    this.RefreshPolicyData();
  }

  public static DialogResult ShowMessage(
    string message,
    string caption,
    MessageBoxButtons buttons,
    MessageBoxIcon icon,
    DialogResult blackboxResult = DialogResult.OK)
  {
    DialogResult dialogResult;
    if (!CompanyDocumentAutomation.BlackBoxMode)
    {
      Func<DialogResult> func = (Func<DialogResult>) ([SpecialName] () => System.Windows.Forms.MessageBox.Show(message, caption, buttons, icon));
      MDIControls instance = MDIControls.Instance;
      int num;
      if (instance == null)
      {
        num = 0;
      }
      else
      {
        Form mdiParent = instance.MDIParent;
        // ISSUE: explicit non-virtual call
        num = mdiParent != null ? (__nonvirtual (mdiParent.InvokeRequired) ? 1 : 0) : 0;
      }
      dialogResult = num == 0 ? func() : InvokeExtensions.BetterInvoke<DialogResult>((ISynchronizeInvoke) MDIControls.Instance.MDIParent, func);
    }
    else
      dialogResult = blackboxResult;
    return dialogResult;
  }

  public static bool ComplianceCheck(
    Guid quoteGuid,
    bool ofacCompliance,
    bool pwsCompliance,
    ref int currentInsuredScore,
    ref Decimal systemThresholdScore,
    ref object pwsValue)
  {
    return frmPolicyDetail.CheckComplianceStatus((Quote) frmPolicyDetail.CreateQuote(quoteGuid), false, true);
  }

  public static bool CheckComplianceStatus(Quote quote, bool performOfacCheck, bool validateSearch = false)
  {
    return frmPolicyDetail.CheckComplianceStatus(quote, performOfacCheck, validateSearch, (string) null);
  }

  public static bool CheckComplianceStatus(
    Quote quote,
    bool performOfacCheck,
    bool validateSearch,
    string quoteOperation)
  {
    frmPolicyDetail objectAs = ObjectFactory.Instance.CreateObjectAs<frmPolicyDetail>(new object[0]);
    if (!(quote is Quote quote1))
      quote1 = frmPolicyDetail.CreateQuote(quote.QuoteGuid);
    objectAs._quote = quote1;
    return objectAs.PerformComplianceCheck(performOfacCheck, false, quoteOperation, false);
  }

  public bool PerformComplianceCheck(
    bool performOfacCheck,
    bool canOverrideHit,
    string quoteOperation,
    bool displayMessage)
  {
    bool flag;
    if (!this._validatePolicyCompliance.Value && !this._runOfacComplianceChecks.Value)
    {
      flag = true;
    }
    else
    {
      List<IOfacEntity> ofacEntities = new List<IOfacEntity>()
      {
        (IOfacEntity) this.Quote.SubmissionGroup.InsuredLocation
      };
      if (this.Quote.SearchQuoteOfac)
        ofacEntities.Add((IOfacEntity) this.Quote);
      flag = this.OfacPolicyInCompliance(ofacEntities, performOfacCheck, canOverrideHit, quoteOperation, displayMessage);
    }
    return flag;
  }

  protected virtual bool OfacPolicyInCompliance(
    List<IOfacEntity> ofacEntities,
    bool performOfacIfMissing,
    bool canOverrideHit,
    string quoteOperation,
    bool displayMessage)
  {
    // ISSUE: variable of a compiler-generated type
    frmPolicyDetail._Closure\u0024__392\u002D0 closure3920_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmPolicyDetail._Closure\u0024__392\u002D0 closure3920_2 = new frmPolicyDetail._Closure\u0024__392\u002D0(closure3920_1);
    bool flag;
    if (!OfacSystem.Instance.HasValidSetting)
    {
      flag = true;
    }
    else
    {
      // ISSUE: variable of a compiler-generated type
      frmPolicyDetail._Closure\u0024__392\u002D0 closure3920_3 = closure3920_2;
      List<OfacSystem.OfacStatus> multipleEntityStatus1 = OfacSystem.Instance.GetMultipleEntityStatus((ICollection<IOfacEntity>) ofacEntities);
      System.Func<OfacSystem.OfacStatus, (Guid, Guid?)> keySelector;
      // ISSUE: reference to a compiler-generated field
      if (frmPolicyDetail._Closure\u0024__.\u0024I392\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        keySelector = frmPolicyDetail._Closure\u0024__.\u0024I392\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmPolicyDetail._Closure\u0024__.\u0024I392\u002D0 = keySelector = (System.Func<OfacSystem.OfacStatus, (Guid, Guid?)>) ([SpecialName] (status) => (status.EntityGuid, status.ParentEntityGuid));
      }
      System.Func<OfacSystem.OfacStatus, OfacSystem.OfacStatus> elementSelector;
      // ISSUE: reference to a compiler-generated field
      if (frmPolicyDetail._Closure\u0024__.\u0024I392\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        elementSelector = frmPolicyDetail._Closure\u0024__.\u0024I392\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmPolicyDetail._Closure\u0024__.\u0024I392\u002D1 = elementSelector = (System.Func<OfacSystem.OfacStatus, OfacSystem.OfacStatus>) ([SpecialName] (status) => status);
      }
      Dictionary<(Guid, Guid?), OfacSystem.OfacStatus> dictionary = multipleEntityStatus1.ToDictionary<OfacSystem.OfacStatus, (Guid, Guid?), OfacSystem.OfacStatus>(keySelector, elementSelector);
      // ISSUE: reference to a compiler-generated field
      closure3920_3.\u0024VB\u0024Local_ofacStatuses = dictionary;
      if (performOfacIfMissing)
      {
        // ISSUE: reference to a compiler-generated method
        IEnumerable<IOfacEntity> source = ofacEntities.Where<IOfacEntity>(new System.Func<IOfacEntity, bool>(closure3920_2._Lambda\u0024__2));
        try
        {
          foreach (IOfacEntity iofacEntity in source)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(OfacSystem.Instance.CheckOfacResult(iofacEntity).ReturnCode, "-1", false) == 0)
              break;
          }
        }
        finally
        {
          IEnumerator<IOfacEntity> enumerator;
          enumerator?.Dispose();
        }
        List<OfacSystem.OfacStatus> multipleEntityStatus2 = OfacSystem.Instance.GetMultipleEntityStatus((ICollection<IOfacEntity>) source.ToList<IOfacEntity>());
        try
        {
          foreach (OfacSystem.OfacStatus ofacStatus in multipleEntityStatus2)
          {
            // ISSUE: reference to a compiler-generated field
            closure3920_2.\u0024VB\u0024Local_ofacStatuses[(ofacStatus.EntityGuid, ofacStatus.ParentEntityGuid)] = ofacStatus;
          }
        }
        finally
        {
          List<OfacSystem.OfacStatus>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      // ISSUE: reference to a compiler-generated field
      Dictionary<(Guid, Guid?), OfacSystem.OfacStatus>.ValueCollection values1 = closure3920_2.\u0024VB\u0024Local_ofacStatuses.Values;
      System.Func<OfacSystem.OfacStatus, bool> predicate1;
      // ISSUE: reference to a compiler-generated field
      if (frmPolicyDetail._Closure\u0024__.\u0024I392\u002D3 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate1 = frmPolicyDetail._Closure\u0024__.\u0024I392\u002D3;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmPolicyDetail._Closure\u0024__.\u0024I392\u002D3 = predicate1 = (System.Func<OfacSystem.OfacStatus, bool>) ([SpecialName] (ai) => !ai.OFACCleared);
      }
      List<OfacSystem.OfacStatus> list = values1.Where<OfacSystem.OfacStatus>(predicate1).ToList<OfacSystem.OfacStatus>();
      if (list.Any<OfacSystem.OfacStatus>())
      {
        this.OnClientOfacHits(list, quoteOperation);
        if (!displayMessage)
        {
          flag = false;
          goto label_37;
        }
        if (!this.ShowPolicyComplianceMessageAndContinue(list, quoteOperation, canOverrideHit))
        {
          flag = false;
          goto label_37;
        }
        CurrentUser.Instance.LogAction($"Accepted to bypass OFAC compliance check and continue to {(string.IsNullOrEmpty(quoteOperation) ? (object) "next step" : (object) quoteOperation)}.", this.Quote.QuoteGuid);
        string quoteOperation1 = quoteOperation;
        // ISSUE: reference to a compiler-generated field
        Dictionary<(Guid, Guid?), OfacSystem.OfacStatus>.ValueCollection values2 = closure3920_2.\u0024VB\u0024Local_ofacStatuses.Values;
        System.Func<OfacSystem.OfacStatus, bool> predicate2;
        // ISSUE: reference to a compiler-generated field
        if (frmPolicyDetail._Closure\u0024__.\u0024I392\u002D4 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate2 = frmPolicyDetail._Closure\u0024__.\u0024I392\u002D4;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmPolicyDetail._Closure\u0024__.\u0024I392\u002D4 = predicate2 = (System.Func<OfacSystem.OfacStatus, bool>) ([SpecialName] (statusSetting) => statusSetting != null && statusSetting.OfacTypeID == 1);
        }
        int num1 = values2.Any<OfacSystem.OfacStatus>(predicate2) ? 1 : 0;
        // ISSUE: reference to a compiler-generated field
        Dictionary<(Guid, Guid?), OfacSystem.OfacStatus>.ValueCollection values3 = closure3920_2.\u0024VB\u0024Local_ofacStatuses.Values;
        System.Func<OfacSystem.OfacStatus, bool> predicate3;
        // ISSUE: reference to a compiler-generated field
        if (frmPolicyDetail._Closure\u0024__.\u0024I392\u002D5 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate3 = frmPolicyDetail._Closure\u0024__.\u0024I392\u002D5;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmPolicyDetail._Closure\u0024__.\u0024I392\u002D5 = predicate3 = (System.Func<OfacSystem.OfacStatus, bool>) ([SpecialName] (statusSetting) => statusSetting != null && statusSetting.OfacTypeID == 2);
        }
        int num2 = values3.Any<OfacSystem.OfacStatus>(predicate3) ? 1 : 0;
        this.PerformComplianceOnClient(quoteOperation1, num1 != 0, num2 != 0);
      }
      flag = true;
    }
label_37:
    return flag;
  }

  protected virtual void OnClientOfacHits(
    List<OfacSystem.OfacStatus> hitStatuses,
    string quoteOperation)
  {
  }

  protected virtual bool ShowPolicyComplianceMessageAndContinue(
    List<OfacSystem.OfacStatus> hitStatuses,
    string quoteOperation,
    bool canOverrideHit)
  {
    string message = $"Policy is not in OFAC compliance: {hitStatuses.FirstOrDefault<OfacSystem.OfacStatus>().HitMessage}";
    if (canOverrideHit)
      message = $"{message}\n{(string.IsNullOrEmpty(quoteOperation) ? "Proceed anyway?" : $"Continue to {quoteOperation}?")}";
    DialogResult dialogResult = frmPolicyDetail.ShowMessage(message, "OFAC Compliance Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DialogResult.No);
    return canOverrideHit && dialogResult == DialogResult.Yes;
  }

  [Obsolete("OFAC/Compliance has been consolidated to a singular system tblEntityOFAC.See Common.OfacSystem for available methods.")]
  protected virtual void PerformComplianceOnClient(
    string quoteOperation,
    bool performOfacCompliance,
    bool performPwsCompliance)
  {
  }

  public static bool AdditionalInterestComplianceCheck(
    Guid quoteGuid,
    bool ofacCompliance,
    bool pwsCompliance,
    ref int currentInterestScore,
    ref Decimal systemThresholdScore,
    ref object pwsValue)
  {
    return frmPolicyDetail.CheckAdditionalInterestComplianceStatus((Quote) frmPolicyDetail.CreateQuote(quoteGuid), false);
  }

  public static bool CheckAdditionalInterestComplianceStatus(
    Quote quote,
    bool performOfacCheck,
    bool validateSearch = false)
  {
    return frmPolicyDetail.CheckAdditionalInterestComplianceStatus(quote, (string) null, performOfacCheck);
  }

  public static bool CheckAdditionalInterestComplianceStatus(
    Quote quote,
    string quoteOperation,
    bool performOfacCheck)
  {
    frmPolicyDetail objectAs = ObjectFactory.Instance.CreateObjectAs<frmPolicyDetail>(new object[0]);
    if (!(quote is Quote quote1))
      quote1 = frmPolicyDetail.CreateQuote(quote.QuoteGuid);
    objectAs._quote = quote1;
    return objectAs.PerformAdditionalInterestComplianceCheck(performOfacCheck, false, quoteOperation, false);
  }

  public bool PerformAdditionalInterestComplianceCheck(
    bool performOfacCheck,
    bool canOverrideHit,
    string quoteOperation,
    bool displayMessage)
  {
    bool flag;
    if (!this._validatePolicyCompliance.Value && !this._runOfacOnAdditionalInterest.Value)
      flag = true;
    else
      flag = this.OfacPolicyInterestsInCompliance(BaseDataObject.SelectMany<AdditionalInterest>("QuoteID = @QID And ModificationCode <> @MC", new object[4]
      {
        (object) "@QID",
        (object) this.Quote.QuoteID,
        (object) "@MC",
        (object) "D"
      }), performOfacCheck, canOverrideHit, quoteOperation, displayMessage);
    return flag;
  }

  protected virtual bool OfacPolicyInterestsInCompliance(
    List<AdditionalInterest> aiEntities,
    bool performOfac,
    bool canOverrideHit,
    string quoteOperation,
    bool displayMessage)
  {
    // ISSUE: variable of a compiler-generated type
    frmPolicyDetail._Closure\u0024__400\u002D0 closure4000_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmPolicyDetail._Closure\u0024__400\u002D0 closure4000_2 = new frmPolicyDetail._Closure\u0024__400\u002D0(closure4000_1);
    // ISSUE: reference to a compiler-generated field
    closure4000_2.\u0024VB\u0024Me = this;
    bool flag;
    if (!OfacSystem.Instance.HasValidSetting)
    {
      flag = true;
    }
    else
    {
      if (!this._additionalInterestOfacTypes.Any<string>())
        this._additionalInterestOfacTypes.UnionWith((IEnumerable<string>) AdditionalInterest.OfacSearchTypes);
      // ISSUE: variable of a compiler-generated type
      frmPolicyDetail._Closure\u0024__400\u002D0 closure4000_3 = closure4000_2;
      List<OfacSystem.OfacStatus> multipleEntityStatus1 = OfacSystem.Instance.GetMultipleEntityStatus((IOfacEntity[]) aiEntities.ToArray());
      System.Func<OfacSystem.OfacStatus, (Guid, Guid?)> keySelector;
      // ISSUE: reference to a compiler-generated field
      if (frmPolicyDetail._Closure\u0024__.\u0024I400\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        keySelector = frmPolicyDetail._Closure\u0024__.\u0024I400\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmPolicyDetail._Closure\u0024__.\u0024I400\u002D0 = keySelector = (System.Func<OfacSystem.OfacStatus, (Guid, Guid?)>) ([SpecialName] (status) => (status.EntityGuid, status.ParentEntityGuid));
      }
      System.Func<OfacSystem.OfacStatus, OfacSystem.OfacStatus> elementSelector;
      // ISSUE: reference to a compiler-generated field
      if (frmPolicyDetail._Closure\u0024__.\u0024I400\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        elementSelector = frmPolicyDetail._Closure\u0024__.\u0024I400\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmPolicyDetail._Closure\u0024__.\u0024I400\u002D1 = elementSelector = (System.Func<OfacSystem.OfacStatus, OfacSystem.OfacStatus>) ([SpecialName] (status) => status);
      }
      Dictionary<(Guid, Guid?), OfacSystem.OfacStatus> dictionary = multipleEntityStatus1.ToDictionary<OfacSystem.OfacStatus, (Guid, Guid?), OfacSystem.OfacStatus>(keySelector, elementSelector);
      // ISSUE: reference to a compiler-generated field
      closure4000_3.\u0024VB\u0024Local_ofacStatuses = dictionary;
      if (performOfac && this._additionalInterestOfacTypes.Any<string>())
      {
        // ISSUE: reference to a compiler-generated method
        IEnumerable<IOfacEntity> source = (IEnumerable<IOfacEntity>) aiEntities.Where<AdditionalInterest>(new System.Func<AdditionalInterest, bool>(closure4000_2._Lambda\u0024__2));
        try
        {
          foreach (IOfacEntity iofacEntity in source)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(OfacSystem.Instance.CheckOfacResult(iofacEntity).ReturnCode, "-1", false) == 0)
              break;
          }
        }
        finally
        {
          IEnumerator<IOfacEntity> enumerator;
          enumerator?.Dispose();
        }
        List<OfacSystem.OfacStatus> multipleEntityStatus2 = OfacSystem.Instance.GetMultipleEntityStatus((ICollection<IOfacEntity>) source.ToList<IOfacEntity>());
        try
        {
          foreach (OfacSystem.OfacStatus ofacStatus in multipleEntityStatus2)
          {
            // ISSUE: reference to a compiler-generated field
            closure4000_2.\u0024VB\u0024Local_ofacStatuses[(ofacStatus.EntityGuid, ofacStatus.ParentEntityGuid)] = ofacStatus;
          }
        }
        finally
        {
          List<OfacSystem.OfacStatus>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      // ISSUE: reference to a compiler-generated field
      Dictionary<(Guid, Guid?), OfacSystem.OfacStatus>.ValueCollection values1 = closure4000_2.\u0024VB\u0024Local_ofacStatuses.Values;
      System.Func<OfacSystem.OfacStatus, bool> predicate1;
      // ISSUE: reference to a compiler-generated field
      if (frmPolicyDetail._Closure\u0024__.\u0024I400\u002D3 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate1 = frmPolicyDetail._Closure\u0024__.\u0024I400\u002D3;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmPolicyDetail._Closure\u0024__.\u0024I400\u002D3 = predicate1 = (System.Func<OfacSystem.OfacStatus, bool>) ([SpecialName] (ai) => !ai.OFACCleared);
      }
      List<OfacSystem.OfacStatus> list = values1.Where<OfacSystem.OfacStatus>(predicate1).ToList<OfacSystem.OfacStatus>();
      if (list.Any<OfacSystem.OfacStatus>())
      {
        this.OnClientOfacHits(list, quoteOperation);
        if (!displayMessage)
        {
          flag = false;
          goto label_39;
        }
        if (!this.ShowAdditionalInterestsComplianceMessageAndContinue(list, quoteOperation, canOverrideHit))
        {
          flag = false;
          goto label_39;
        }
        CurrentUser.Instance.LogAction($"Accepted to bypass additional interests compliance check and and continue to {(string.IsNullOrEmpty(quoteOperation) ? (object) "next step" : (object) quoteOperation)}.", this.Quote.QuoteGuid);
        string quoteOperation1 = quoteOperation;
        // ISSUE: reference to a compiler-generated field
        Dictionary<(Guid, Guid?), OfacSystem.OfacStatus>.ValueCollection values2 = closure4000_2.\u0024VB\u0024Local_ofacStatuses.Values;
        System.Func<OfacSystem.OfacStatus, bool> predicate2;
        // ISSUE: reference to a compiler-generated field
        if (frmPolicyDetail._Closure\u0024__.\u0024I400\u002D4 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate2 = frmPolicyDetail._Closure\u0024__.\u0024I400\u002D4;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmPolicyDetail._Closure\u0024__.\u0024I400\u002D4 = predicate2 = (System.Func<OfacSystem.OfacStatus, bool>) ([SpecialName] (statusSetting) => statusSetting != null && statusSetting.OfacTypeID == 1);
        }
        int num1 = values2.Any<OfacSystem.OfacStatus>(predicate2) ? 1 : 0;
        // ISSUE: reference to a compiler-generated field
        Dictionary<(Guid, Guid?), OfacSystem.OfacStatus>.ValueCollection values3 = closure4000_2.\u0024VB\u0024Local_ofacStatuses.Values;
        System.Func<OfacSystem.OfacStatus, bool> predicate3;
        // ISSUE: reference to a compiler-generated field
        if (frmPolicyDetail._Closure\u0024__.\u0024I400\u002D5 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate3 = frmPolicyDetail._Closure\u0024__.\u0024I400\u002D5;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmPolicyDetail._Closure\u0024__.\u0024I400\u002D5 = predicate3 = (System.Func<OfacSystem.OfacStatus, bool>) ([SpecialName] (statusSetting) => statusSetting != null && statusSetting.OfacTypeID == 2);
        }
        int num2 = values3.Any<OfacSystem.OfacStatus>(predicate3) ? 1 : 0;
        this.PerformAdditionalInterestComplianceOnClient(quoteOperation1, num1 != 0, num2 != 0);
      }
      flag = true;
    }
label_39:
    return flag;
  }

  protected virtual bool ShowAdditionalInterestsComplianceMessageAndContinue(
    List<OfacSystem.OfacStatus> hitStatuses,
    string quoteOperation,
    bool canOverrideHit)
  {
    List<OfacSystem.OfacStatus> source = hitStatuses;
    System.Func<OfacSystem.OfacStatus, string> selector;
    // ISSUE: reference to a compiler-generated field
    if (frmPolicyDetail._Closure\u0024__.\u0024I401\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = frmPolicyDetail._Closure\u0024__.\u0024I401\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmPolicyDetail._Closure\u0024__.\u0024I401\u002D0 = selector = (System.Func<OfacSystem.OfacStatus, string>) ([SpecialName] (status) => status.HitMessage);
    }
    string message = $"One or more additional interests are not in OFAC compliance:{"\n"}{string.Join("\n", source.Select<OfacSystem.OfacStatus, string>(selector).Distinct<string>().Take<string>(5))}";
    if (canOverrideHit)
      message = $"{message}\n{(string.IsNullOrEmpty(quoteOperation) ? "Proceed anyway?" : $"Continue to {quoteOperation}?")}";
    DialogResult dialogResult = frmPolicyDetail.ShowMessage(message, "Additional Interest OFAC Compliance Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DialogResult.Yes);
    return canOverrideHit && dialogResult == DialogResult.Yes;
  }

  private bool ComplianceCheck_ComplyAdvantage()
  {
    bool flag;
    if (string.IsNullOrWhiteSpace(SystemSettings.GetSetting<string>("ComplyAdvantage_Key", (string) null)))
    {
      flag = true;
    }
    else
    {
      string DefaultResponse = this.Quote.InsuredPolicyName;
      if (DefaultResponse.Length > 290)
      {
        if (MDIControls.Instance.BlackBoxMode)
        {
          flag = false;
          goto label_10;
        }
        DefaultResponse = Interaction.InputBox($"Cannot continue compliance check because the insured name length ({DefaultResponse.Length}) exceeds max lenth of {290}.{Environment.NewLine}Please provide a shortened version", "Compliance search term too long", DefaultResponse);
        if (DefaultResponse.Length > 290)
        {
          int num = (int) System.Windows.Forms.MessageBox.Show($"Cannot continue compliance check because the search term length ({DefaultResponse.Length}) exceeds max lenth of {290}.", "Comply Advantage", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          flag = false;
          goto label_10;
        }
      }
      SanctionsChecker sanctionsChecker = SanctionsChecker.Default;
      int num1 = sanctionsChecker != null ? (sanctionsChecker.IsCompliant(DefaultResponse, this.Quote.SubmissionGroup.InsuredGuid) ? 1 : 0) : 1;
      if (num1 == 0)
      {
        int num2 = (int) System.Windows.Forms.MessageBox.Show($"'{this.NamedInsured}' failed a Comply Advantage check.", "Comply Advantage", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      flag = num1 != 0;
    }
label_10:
    return flag;
  }

  [Obsolete("OFAC/Compliance has been consolidated to a singular system: tblEntityOFAC. See Common.OfacSystem for available methods.")]
  protected virtual void PerformAdditionalInterestComplianceOnClient(
    string quoteOperation,
    bool performOfacCompliance,
    bool performPwsCompliance)
  {
  }

  public virtual void PrintIndication()
  {
    this._printingIndication = true;
    try
    {
      if (!this.BaseValidForPrint())
        return;
    }
    finally
    {
      this._printingIndication = false;
    }
    Messaging.SendBroadcastMessage(BroadcastMessages.IndicationPrinted, (object) this._quote.QuoteGuid);
    this._quote.QuoteStatus = (QuoteStatus) 25;
    this.RefreshPolicyData();
  }

  protected virtual bool ClientValidForPrintQuote() => true;

  private bool VerifyNoMissingNotesOnPolicy(Guid quoteGuid)
  {
    List<string> values = new List<string>();
    try
    {
      foreach (NoteBindFailureReason bindFailureReason in Note_System.Instance.UIInteractive.VerifyRequiredNotesOnPolicy(this._quote.QuoteGuid, (NoteBindRequirement) 0))
        values.Add(bindFailureReason.Description);
    }
    finally
    {
      List<NoteBindFailureReason>.Enumerator enumerator;
      enumerator.Dispose();
    }
    bool flag;
    if (values.Count == 0)
    {
      flag = true;
    }
    else
    {
      int num = (int) System.Windows.Forms.MessageBox.Show((string.Join(", ", (IEnumerable<string>) values) + ".").ToString(), "Quote Note Criteria Not Met", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    return flag;
  }

  public void ReloadToCurrentVersion()
  {
    FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
    {
      (object) this.Quote.ControlNo
    });
    ((Form) this).Close();
  }

  protected virtual bool ValidForBind()
  {
    bool flag1 = false;
    bool flag2;
    try
    {
      if (SystemSettings.GetSetting<int>("ExcelRating.ValidateDataBeforeBind", 1) == 1)
      {
        string setting = SystemSettings.GetSetting<string>("ExcelRating.ExcelValidationProc2", "ExcelRating_IsReadyForBind2");
        if (!string.IsNullOrWhiteSpace(setting))
        {
          DataTable dataTable = DefaultDatabase.ExecuteDataTable(setting, new object[2]
          {
            (object) "@QuoteGuid",
            (object) this.Quote.QuoteGuid
          });
          if (dataTable != null)
          {
            if (dataTable.Rows.Count == 1)
            {
              int num1 = dataTable.Rows[0].Field<bool>(nameof (ValidForBind)) ? 1 : 0;
              string text = dataTable.Rows[0].Field<string>("ErrorMessage");
              if (num1 == 0)
              {
                int num2 = (int) System.Windows.Forms.MessageBox.Show(text, "Not valid for bind", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                flag2 = false;
                goto label_78;
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
    }
    if (SystemSettings.GetSetting<bool>("NoteAutomation.UseReqToBind", false))
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "NoteSystem_AutomationReqToBind", new object[6]
      {
        (object) "@controlGuid",
        (object) this.ControlGUID,
        (object) "@companyLineGuid",
        (object) this.Quote.CompanyLineGuid,
        (object) "@quoteId",
        (object) this.Quote.QuoteID
      });
      List<string> values = new List<string>();
      try
      {
        foreach (DataRow row in dataTable.Rows)
          values.Add($"Completed Note Type {row.Field<string>("Description")} required to bind.");
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (values.Count > 0)
      {
        int num = (int) System.Windows.Forms.MessageBox.Show(string.Join(Environment.NewLine, (IEnumerable<string>) values), "Not valid for bind", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag2 = false;
        goto label_78;
      }
    }
    if (!this.Quote.IsEndorsement)
    {
      if (!DefaultDatabase.ExecuteScalar<bool>(SystemSettings.GetSetting<string>("ProducerRequirementsSatisfiedStoredProc", "dbo.spIsProducerRequirementsSatisfied"), new object[10]
      {
        (object) "@submissionGroupGuid",
        (object) this.Quote.SubmissionGroupGuid,
        (object) "@producerLocationGuid",
        (object) this.Quote.ProducerLocationGuid,
        (object) "@requirementType",
        (object) "B",
        (object) "@ExpirationDate",
        (object) this.Quote.ExpirationDate,
        (object) "@EffectiveDate",
        (object) this.Quote.EffectiveDate
      }))
      {
        int num = (int) System.Windows.Forms.MessageBox.Show($"At least one specified producer requirement marked 'Needed to Bind' is not on file. {Environment.NewLine}{Environment.NewLine}" + "Or its 'Valid Through' date occurs before today's date.", "Invalid Producer Requirement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag2 = false;
        goto label_78;
      }
      if (this.Quote.ProducerLocation.StatusID != 1)
      {
        if (this.Quote.PolicyType == 2)
        {
          if (SecurityManager.Instance.AssertPermission("{01061E72-02E9-4fa5-80B3-2ED11DB743BC}"))
          {
            if (System.Windows.Forms.MessageBox.Show("You are about to bind a renewal account with an Inactive Producer, Proceed?", "Inactive Producer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
              flag2 = false;
              goto label_78;
            }
          }
          else
          {
            int num = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to continue with binding a renewal on a producer that is not active.", "Producer Not Active On Renewal", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            flag2 = false;
            goto label_78;
          }
        }
        else if (SecurityManager.Instance.AssertPermission("{65BB1BD1-0FE3-411d-AB6E-CAE27786EB53}"))
        {
          if (System.Windows.Forms.MessageBox.Show("You are about to bind an account with an Inactive Producer, Proceed?", "Inactive Producer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
          {
            flag2 = false;
            goto label_78;
          }
        }
        else
        {
          int num = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to bind accounts with an Inactive Producer.", "Inactive Producer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          flag2 = false;
          goto label_78;
        }
      }
      if (this.Quote.PolicyType == 2)
      {
        Guid guid = this.Quote.RenewalOfQuoteGuid ?? Guid.Empty;
        if (!guid.Equals(Guid.Empty))
        {
          if (!DefaultDatabase.ExecuteScalar<bool>("dbo.IsValidRenewalPolicyDates", new object[2]
          {
            (object) "@quoteGuid",
            (object) this._quote.QuoteGuid
          }))
          {
            Quote quote = Quote.CreateNew(guid);
            if (SecurityManager.Instance.AssertPermission("{FA44600C-7324-4239-84EA-DE4DA656E389}"))
            {
              if (System.Windows.Forms.MessageBox.Show($"The effective date of {this.Quote.EffectiveDate.ToShortDateString()} does not match the expiration date of {quote.ExpirationDate.ToShortDateString()} on the renewal (control # {quote.ControlNo.ToString()}).\n\nDo you wish to continue?", "Renewal Policy Date Discrepancy", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
              {
                flag2 = false;
                goto label_78;
              }
              flag1 = true;
            }
            else
            {
              int num = (int) System.Windows.Forms.MessageBox.Show("You do not have sufficient security to bind whenever there is a lapse in coverage on renewals.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              flag2 = false;
              goto label_78;
            }
          }
        }
      }
    }
    if (SystemSettings.GetSetting<bool>("CheckInactiveProducerContactForBind", false))
    {
      if (DefaultDatabase.ExecuteScalar<bool>("spIsInactiveQuoteProducerContact", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.Quote.QuoteGuid
      }) & !SecurityManager.Instance.AssertPermission("{9C07C0C2-4247-4575-A758-9428D41A6C0A}"))
      {
        int num = (int) System.Windows.Forms.MessageBox.Show("Producer Contact Inactive or Closed - Please Update.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag2 = false;
        goto label_78;
      }
    }
    if (!this.IsValidCostCenter())
      flag2 = false;
    else if (this.PremiumsControl == null)
      flag2 = false;
    else if (!this.Quote.HasPremium && !this._quote.IsEndorsement && this._quote.PolicyType != 5 && !this.AllowZeroPremiumAlways())
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("There are no options to bind.  Please rate the policy.", "No Options", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag2 = false;
    }
    else if (this._quote.IsBound)
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("This policy is already bound.", "Policy Bound", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag2 = false;
    }
    else if (!this.PremiumsControl.ReadyToBind())
      flag2 = false;
    else if (!this.VerifyAdditionalInterestBillableAmounts())
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("Please ensure all that all additional interests have billable amounts entered, \nand the totals match the premium being billed.", "Invalid Additional Interest Billable Amounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag2 = false;
    }
    else if (!this.PassesTargetPremiumCheck())
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("This line of business requires a target premium that is less than the quoted premium.", "Target Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag2 = false;
    }
    else if (this.Quote.CompanyLocation.DisallowBinding)
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("Binding is not allowed on this Company Location.", "Bind Disallowed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag2 = false;
    }
    else if (this.IsFeeOnlyTransaction())
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("Binding is not allowed when fee-only transaction(s) net to $0.", "Fee Only Transaction", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag2 = false;
    }
    else if (!this.HasValidProducerLicense())
    {
      int num = (int) System.Windows.Forms.MessageBox.Show($"Producer does not have a valid license for the policy state of ({this.Quote.StateID}).", "Missing Valid License", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag2 = false;
    }
    else if (!this.Quote.ValidEndorsementEffectiveDate())
    {
      int num = (int) System.Windows.Forms.MessageBox.Show($"The endorsement effective date of {this.Quote.EndorsementEffective.ToShortDateString()} is invalid.\n\nEndorsement effective must fall on or between {this.Quote.EffectiveDate.ToShortDateString()} to {this.Quote.ExpirationDate.ToShortDateString()}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      flag2 = false;
    }
    else if (!this.IsValidUnderwritingPeriod())
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("The current underwriting period is now closed.", "Cannot Bind - Underwriting Period Closed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag2 = false;
    }
    else if (!this.ValidInsuredStatusOnBind())
      flag2 = false;
    else if (this._validateOnBind.Value && !this.ValidateCompliance("Bind", this._canOverrideBindOfacHits, this._canOverrideBindOfacHits, this._checkOfacOnBindIfMissing.Value, !this._bypassZeroPremEndtCheckOnBind.Value && this.Quote.IsEndorsementWithoutNonZeroPremiums || this._bypassOfacSystemOnBind.Value))
    {
      flag2 = false;
    }
    else
    {
      this.GetNetRateAssociatedDeletedVehicle();
      this.GetNetRateAssociatedDeletedLocation();
      if (SystemSettings.GetSetting<bool>("Policy.Bind.KYLocation", false) && SystemSettings.GetSetting<bool>("Policy.Edit.Show.KYTaxLocationTab", false))
      {
        if (!DefaultDatabase.ExecuteScalar<bool>("dbo.spIsKYLocationValid", new object[2]
        {
          (object) "@QuoteGuid",
          (object) this.Quote.QuoteGuid
        }))
        {
          int num = (int) System.Windows.Forms.MessageBox.Show("Binding is not allowed when Insured KY Location info is Blank", "Cannot Bind - KY Location is Blank ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag2 = false;
          goto label_78;
        }
      }
      if (this.Quote.IsOriginalQuoteRecord && this.Quote.HasPolicyNumber && !frmChangePolicyNumber.DuplicatePolicyNumberCheck((Quote) this.Quote, this.Quote.PolicyNumber))
      {
        flag2 = false;
      }
      else
      {
        if (flag1)
          CurrentUser.Instance.LogAction("Accepted lapse of coverage on renewal warning on bind.", this.Quote.QuoteGuid);
        flag2 = true;
      }
    }
label_78:
    return flag2;
  }

  private bool ValidInsuredStatusOnQuote()
  {
    bool flag;
    if (this.Quote.IsEndorsement)
    {
      flag = true;
    }
    else
    {
      short status = (short) new Insured(this.Quote.SubmissionGroup.InsuredGuid).Status;
      if (status == (short) 2 && !SecurityManager.Instance.AssertPermission("{7EE86680-72C9-4531-9CCE-6DA6297D8982}"))
      {
        int num = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to quote policies on inactive insured", "Cannot Quote On Inactive Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
      }
      else if (status == (short) 3 && !SecurityManager.Instance.AssertPermission("{7C7B979F-1793-4F6F-BEA7-9E0BB74A2C98}"))
      {
        int num = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to quote policies on a closed insured", "Cannot Quote On Closed Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
      }
      else
      {
        short? setting = SystemSettings.GetSetting<short?>("SuspendedInsuredStatusID", new short?());
        if (setting.HasValue && (int) setting.Value == (int) status && !SecurityManager.Instance.AssertPermission("{911F7E7C-F78E-40DE-9FED-9D668B3CDD4C}"))
        {
          int num = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to quote policies on suspended insured", "Cannot Quote On Suspended Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
        }
        else
          flag = true;
      }
    }
    return flag;
  }

  private bool ValidInsuredStatusOnBind()
  {
    short status = (short) new Insured(this.Quote.SubmissionGroup.InsuredGuid).Status;
    bool isEndorsement = this.Quote.IsEndorsement;
    bool flag;
    if (status == (short) 3)
    {
      if (isEndorsement)
      {
        if (!SecurityManager.Instance.AssertPermission("{1595D7CD-860D-42B6-8D7C-0A62FF0EFE6E}"))
        {
          int num = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to bind endorsements on a closed insured", "Cannot Bind Endorsement On Closed Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_19;
        }
      }
      else if (!SecurityManager.Instance.AssertPermission("{CA4B8D51-1D1D-47C7-87E2-604898FEE86B}"))
      {
        int num = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to bind original transactions on closed insured", "Cannot Bind Original Transactions On closed Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
        goto label_19;
      }
    }
    Decimal? setting = SystemSettings.GetSetting<Decimal?>("SuspendedInsuredStatusID", new Decimal?());
    if (setting.HasValue && (int) Convert.ToInt16(setting.Value) == (int) status)
    {
      if (isEndorsement)
      {
        if (!SecurityManager.Instance.AssertPermission("{9B955538-C251-416B-8662-B8F3DD75E438}"))
        {
          int num = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to bind endorsements on a suspended insured", "Cannot Bind Endorsement On Suspended Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_19;
        }
      }
      else if (!SecurityManager.Instance.AssertPermission("{8031A91C-F772-470A-A477-4ACF9F9D0827}"))
      {
        int num = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to bind original transactions on suspended insured", "Cannot Bind Original Transactions On Suspended Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
        goto label_19;
      }
    }
    if (status == (short) 2)
    {
      if (isEndorsement)
      {
        if (!SecurityManager.Instance.AssertPermission("{375E8B6B-D480-409A-80C1-F43E28A8A9F4}"))
        {
          int num = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to bind endorsements on an inactive insured", "Cannot Bind Endorsement On Inactive Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_19;
        }
      }
      else if (!SecurityManager.Instance.AssertPermission("{83DD601C-66A8-4914-BB93-2B1501F5B12C}"))
      {
        int num = (int) System.Windows.Forms.MessageBox.Show("You do not have the required security to bind original transactions on an inactive insured", "Cannot Bind Original Transaction On Inactive Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
        goto label_19;
      }
    }
    flag = true;
label_19:
    return flag;
  }

  private void GetNetRateAssociatedDeletedVehicle()
  {
    if (!this.Quote.IsEndorsement || !SystemSettings.GetSetting<bool>("NetRate.AssociatedVehicleRemovalCheck", false))
      return;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.GetNetRateAssociatedDeletedVehicle", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.Quote.QuoteGuid
    });
    if (dataTable.Rows.Count <= 0)
      return;
    int num = (int) System.Windows.Forms.MessageBox.Show($"Please Note that Vehicle ({$"{dataTable.Rows[0]["Make"].ToString()}/{dataTable.Rows[0]["Model"].ToString()}/{dataTable.Rows[0]["Year"].ToString()}/{dataTable.Rows[0]["VIN"].ToString()}"}) that was deleted has Associated Interest ({dataTable.Rows[0]["InterestName"].ToString()}) for removal", "Deleted Vehicle with Associated Interest", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  private void GetNetRateAssociatedDeletedLocation()
  {
    if (!this.Quote.IsEndorsement || !SystemSettings.GetSetting<bool>("NetRate.AssociatedLocationRemovalCheck", false))
      return;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.GetNetRateAssociatedDeletedLocation", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.Quote.QuoteGuid
    });
    if (dataTable.Rows.Count <= 0)
      return;
    int integer = Conversions.ToInteger(dataTable.Rows[0]["LocationID"]);
    string str1 = dataTable.Rows[0]["Address"].ToString();
    string str2 = dataTable.Rows[0]["City"].ToString();
    string str3 = dataTable.Rows[0]["State"].ToString();
    string str4 = dataTable.Rows[0]["ZipCode"].ToString();
    string str5 = dataTable.Rows[0]["InterestName"].ToString();
    int num = (int) System.Windows.Forms.MessageBox.Show($"Please Note that Location ({$"{Conversions.ToString(integer)}/{str1}/{str2}/{str3}/{str4}"}) that was deleted has Associated Interest ({str5}) for removal", "Deleted Location with Associated Interest", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  protected virtual bool IsValidUnderwritingPeriod()
  {
    return DefaultDatabase.ExecuteScalar<bool>(nameof (IsValidUnderwritingPeriod), new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.Quote.QuoteGuid
    });
  }

  private bool HasValidProducerLicense()
  {
    bool flag;
    if (!SystemSettings.GetSetting<bool>("PerformProducerLicenseCheck", false))
      flag = true;
    else
      flag = Conversions.ToBoolean(DefaultDatabase.ExecuteScalar("ValidProducerLicense", new object[2]
      {
        (object) "@quoteGuid",
        (object) this.Quote.QuoteGuid
      }));
    return flag;
  }

  protected virtual bool IsFeeOnlyTransaction()
  {
    return Conversions.ToBoolean(DefaultDatabase.ExecuteScalar(nameof (IsFeeOnlyTransaction), new object[2]
    {
      (object) "@quoteGuid",
      (object) this.Quote.QuoteGuid
    }));
  }

  private bool VerifyAdditionalInterestBillableAmounts()
  {
    return (bool) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.VerifyBillableAdditionalInterests(@quoteID)", new object[2]
    {
      (object) "@quoteID",
      (object) this._quote.QuoteID
    });
  }

  protected virtual bool IsValidCostCenter()
  {
    Guid quoteGuid = this.Quote.QuoteGuid;
    int num1 = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT CostCenterID FROM tblQuotes  WITH (NOLOCK) WHERE QuoteGuid = @QuoteGuid", new object[2]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid
    });
    bool flag;
    if (DefaultDatabase.ExecuteDataTable("[spGetQuoteCostCenters]", new object[2]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid
    }).Select("GroupId = " + Conversions.ToString(num1)).Length == 0)
    {
      int num2 = (int) System.Windows.Forms.MessageBox.Show("The current cost center selection is invalid.\n\nPlease correct this before binding.", "Invalid Cost Center", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private bool PassesSecurityChecks()
  {
    bool flag;
    if (this.PremiumsControl.HasPremium && !this.Quote.IsEndorsement && !SecurityManager.Instance.AssertPermission("{6D1A622A-141E-4535-BF6A-211F51848EF5}"))
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("You do not have sufficient security to bind monetary transactions.\n\nPlease contact your system administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (this.Quote.IsEndorsement && !this.Quote.HasNonZeroPremiums && !SecurityManager.Instance.AssertPermission("{96FF6CC8-EDED-47ec-AF12-DDD82E424D6D}"))
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("You do not have sufficient security to bind NonMonetaryEndorsements.\n\nPlease contact your system administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (this.Quote.IsEndorsement && !SecurityManager.Instance.AssertPermission("{7741F48B-C18B-4eda-9FD8-6FAB20DA32BE}"))
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("You do not have sufficient security to bind endorsement transactions.\n\nPlease contact your system administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (DefaultDatabase.ExecuteDataRow(CommandType.StoredProcedure, "spCanUserBindLine", new object[4]
    {
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@LineGuid",
      (object) this.Quote.LineGuid
    }).Field<bool>("RestrictBind"))
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("You do not have sufficient security to bind this line.\n\nPlease contact your system administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private bool CanIssuePolicyByLine()
  {
    return !DefaultDatabase.ExecuteScalar<bool>(CommandType.StoredProcedure, "dbo.spCanUserIssueLine", new object[4]
    {
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@LineGuid",
      (object) this.Quote.LineGuid
    });
  }

  private void BindWithZeroPremium()
  {
    this._quote.BindWithZeroPremium(CurrentUser.Instance.UserID);
    this.RefreshPolicyData();
    int num = (int) System.Windows.Forms.MessageBox.Show("This policy has been successfully bound.", "Policy Bound", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.ReloadToCurrentVersion();
  }

  protected virtual string GetNonMonetaryEndorsementMessage()
  {
    return "No premium has been entered on this endorsement.\n\nWould you like to bind a non-monetary endorsement?";
  }

  private void BindNonMonetaryEndorsement()
  {
    if (this.Quote.RatedInNetRate && SystemSettings.GetSetting<bool>("NetRateNonMonetaryBindCheck", false))
    {
      EnumerableRowCollection<DataRow> source1 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM dbo.NetRateNotReadyToBindReasons(@quoteGuid)", new object[2]
      {
        (object) "@quoteGuid",
        (object) this.Quote.QuoteGuid
      }).AsEnumerable();
      System.Func<DataRow, string> selector;
      // ISSUE: reference to a compiler-generated field
      if (frmPolicyDetail._Closure\u0024__.\u0024I422\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = frmPolicyDetail._Closure\u0024__.\u0024I422\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmPolicyDetail._Closure\u0024__.\u0024I422\u002D0 = selector = (System.Func<DataRow, string>) ([SpecialName] (dr) => ExtensionsMethods.FieldOrDefault<string>(dr, "Reason", (string) null));
      }
      EnumerableRowCollection<string> source2 = source1.Select<DataRow, string>(selector);
      System.Func<string, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (frmPolicyDetail._Closure\u0024__.\u0024I422\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = frmPolicyDetail._Closure\u0024__.\u0024I422\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmPolicyDetail._Closure\u0024__.\u0024I422\u002D1 = predicate = (System.Func<string, bool>) ([SpecialName] (reason) => !string.IsNullOrEmpty(reason));
      }
      List<string> list = source2.Where<string>(predicate).ToList<string>();
      if (list.Count > 0)
      {
        using (FormSettings.ShowFormDialog(typeof (frmBindingRequirements), new object[2]
        {
          (object) list,
          (object) frmBindingRequirements.RequirementsType.Bind
        }))
          return;
      }
    }
    if (System.Windows.Forms.MessageBox.Show(this.GetNonMonetaryEndorsementMessage(), "Create Non-Monetary Endorsement?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    if (this._quote.IsEndorsement)
    {
      frmEndorsementInfo frmEndorsementInfo = (frmEndorsementInfo) FormSettings.ShowFormDialog(typeof (frmEndorsementInfo), new object[1]
      {
        (object) this._quote.QuoteID
      });
      try
      {
        if (!frmEndorsementInfo.Saved)
          return;
      }
      finally
      {
        frmEndorsementInfo.Dispose();
      }
    }
    QuoteStatus nextBoundStatus = this.Quote.NextBoundStatus;
    object objectValue1 = RuntimeHelpers.GetObjectValue(this.Quote.ChangeStatusRequirementsSoftStops((int) nextBoundStatus));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)))
    {
      int num1 = (int) System.Windows.Forms.MessageBox.Show("Soft Stop(s). The following issuance requirements are not met - \n" + objectValue1.ToString(), "Company/line Policy Issuance - Requirements", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    object objectValue2 = RuntimeHelpers.GetObjectValue(this.Quote.ChangeStatusRequirementsHardStops((int) nextBoundStatus));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
    {
      int num2 = (int) System.Windows.Forms.MessageBox.Show(objectValue2.ToString(), "Company/line Policy Issuance Not Satisfied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this._quote.BindNonMonetaryEndorsement(CurrentUser.Instance.UserID);
      Guid guid = this._quote.QuoteGuid;
      if (this._quote.HasControlGUID)
        guid = this._quote.ControlGuid;
      CurrentUser.Instance.LogAction("Bound endorsement policy with $0 premium. Control #" + this._quote.ControlNo.ToString(), guid);
      this.ReloadToCurrentVersion();
    }
  }

  private void CreateZeroOptionPremium()
  {
    this._newOptionsAdded = false;
    if (this.dgParticipants == null || ((UltraGridBase) this.dgParticipants).DataSource == null)
      return;
    dsPolicyDetail.tblQuoteDetailsDataTable dataSource = (dsPolicyDetail.tblQuoteDetailsDataTable) ((UltraGridBase) this.dgParticipants).DataSource;
    try
    {
      foreach (dsPolicyDetail.tblQuoteDetailsRow tblQuoteDetailsRow in (TypedTableBase<dsPolicyDetail.tblQuoteDetailsRow>) dataSource)
      {
        CompanyLine companyLine = new CompanyLine(tblQuoteDetailsRow.CompanyLineGuid);
        if (!companyLine.IsParentLine)
        {
          int? nullable = DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT TOP 1 RatingTypeID FROM tblCompanyRaters WITH (NOLOCK) WHERE CompanyLineGuid = @CL AND RatingTypeID = 0", new object[2]
          {
            (object) "@CL",
            (object) tblQuoteDetailsRow.CompanyLineGuid
          });
          if (nullable.HasValue)
          {
            IRater rater = RaterFactory.GetRater(nullable.Value);
            if (rater != null && rater is IAutoCreateZeroPremiumOptions zeroPremiumOptions)
            {
              zeroPremiumOptions.CreateZeroPremiumOptions(this.Quote.QuoteGuid, tblQuoteDetailsRow.CompanyLineGuid, companyLine.LineGuid, companyLine.StateID);
              this._newOptionsAdded = true;
            }
          }
        }
      }
    }
    finally
    {
      IEnumerator<dsPolicyDetail.tblQuoteDetailsRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private bool ContinueBindingEndorsementWithForms()
  {
    bool flag1;
    if (!this._quote.IsEndorsement)
    {
      flag1 = true;
    }
    else
    {
      bool flag2 = true;
      DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.spGetEndorsementForms", new object[4]
      {
        (object) "@QuoteGUID",
        (object) this.Quote.QuoteGuid,
        (object) "@QuoteID",
        (object) this.Quote.QuoteID
      });
      if (dataTable.Rows.Count > 0)
      {
        int num1;
        if (dataTable.Rows.Count < 45)
        {
          num1 = 1;
        }
        else
        {
          num1 = Convert.ToInt32(Math.Floor((double) dataTable.Rows.Count / 45.0));
          if (dataTable.Rows.Count % 45 > 0)
            ++num1;
        }
        List<StringBuilder> stringBuilderList = new List<StringBuilder>();
        StringBuilder stringBuilder1 = new StringBuilder();
        stringBuilder1.AppendLine($"Message {stringBuilderList.Count + 1}/{num1}" + "\n");
        stringBuilder1.AppendLine("The following forms were added on this endorsement:\n");
        int num2 = 0;
        try
        {
          foreach (DataRow row in dataTable.Rows)
          {
            stringBuilder1.AppendLine(row[0].ToString());
            ++num2;
            if (num2 == 44)
            {
              stringBuilder1.AppendLine("\nDo you wish to continue with binding?");
              stringBuilderList.Add(stringBuilder1);
              num2 = 0;
              stringBuilder1 = new StringBuilder();
              stringBuilder1.AppendLine($"Message {stringBuilderList.Count + 1}/{num1}" + "\n");
              stringBuilder1.AppendLine("The following forms were added on this endorsement:\n");
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        stringBuilder1.AppendLine("\nDo you wish to continue with binding?");
        stringBuilderList.Add(stringBuilder1);
        try
        {
          foreach (StringBuilder stringBuilder2 in stringBuilderList)
          {
            if (System.Windows.Forms.MessageBox.Show(stringBuilder2.ToString(), "Forms Added. Continue Binding?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
              flag2 = false;
              break;
            }
          }
        }
        finally
        {
          List<StringBuilder>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      flag1 = flag2;
    }
    return flag1;
  }

  protected virtual bool BeginCreateZeroOptionPremium()
  {
    bool zeroOptionPremium;
    if (SystemSettings.GetSetting<bool>("spAllowCreateZeroOptionRow.Enabled", false))
    {
      if (Conversions.ToBoolean(DefaultDatabase.ExecuteScalar("dbo.spAllowCreateZeroOptionRow", new object[2]
      {
        (object) "@quoteGuid",
        (object) this.Quote.QuoteGuid
      })))
      {
        zeroOptionPremium = true;
        goto label_4;
      }
    }
    zeroOptionPremium = !this.Quote.IsEndorsement && this._quote.PolicyType != 5 && this.Quote.IsOriginalQuoteRecord && !this.AllowZeroPremiumAlways();
label_4:
    return zeroOptionPremium;
  }

  private void ClickedBind()
  {
    if (this._runAuthorityLimitCheck && !this._runAuthorityCheckAtStartup)
    {
      this.AuthorityLimitCheck((AuthorityLimitCheckType) 0, true);
      if (!this._authorityLimitCheckManager.CanBindHard(this._quote.IsBound))
        return;
    }
    if (this._runThresholdLimitCheck && !this._runThresholdCheckAtStartup)
    {
      this.ThresholdLimitCheck((ThresholdLimitCheckType) 0, true);
      if (!this._thresholdLimitCheckManager.CanBindHard(this._quote.IsBound))
        return;
    }
    if (this.PremiumsControl == null || !this.PassesSecurityChecks() || !this.ValidEndorsementBoundCompanyLineRequirements())
      return;
    if (this.BeginCreateZeroOptionPremium())
    {
      this.CreateZeroOptionPremium();
      this.RefillOptions();
    }
    if (!this.ValidForBind() || !this.ContinueBindingEndorsementWithForms())
      return;
    this.VerifyProducerCommissions();
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      this._quote.ClearPremiumCache();
      bool isEndorsement = this._quote.IsEndorsement;
      if (isEndorsement && this.ForceNonMonetaryEndorsement())
      {
        int num = SMTP_Email.SuppressDialog ? 1 : 0;
        SMTP_Email.SuppressDialog = SystemSettings.GetSetting<bool>("BindNonMonetaryEndorsement.SuppressDialog", false);
        this.BindNonMonetaryEndorsement();
        SMTP_Email.SuppressDialog = num != 0;
      }
      else if (!this.Quote.HasFees && (!this.Quote.HasPremium || Decimal.Compare(this.Quote.Premium, 0M) == 0 && !this.Quote.HasNonZeroPremiums) && (this._quote.PolicyType == 5 || !isEndorsement && this.AllowZeroPremiumAlways()))
      {
        if (System.Windows.Forms.MessageBox.Show($"You are about to bind a policy with {(this.Quote.HasPremium ? (object) "$0" : (object) "no")} premium.{"\n"}{"\n"}Do you wish to continue binding?", "Continue Binding", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
          return;
        if (!isEndorsement)
        {
          if (!this.ValidateZeroPremiumBindRequirements())
            return;
          if (SystemSettings.GetSetting<bool>("BindWithZeroPremium.AssignParentPolicyNumber", false) && !this.Quote.HasPolicyNumber)
            this.AssignPolicyNumber();
          if (SystemSettings.GetSetting<bool>("BindWithZeroPremium.AssignChildPolicyNumber", false) && this.GenerateChildPolicyNumbers)
            this.AssignChildPolicyNumber();
        }
        this.BindWithZeroPremium();
        CurrentUser.Instance.LogAction($"Bound policy with {(this._quote.HasPremium ? (object) "$0" : (object) "no")} premium. Control # {this._quote.ControlNo}", this._quote.ControlGuid);
      }
      else if (Decimal.Compare(this.Quote.Premium, 0M) == 0 && !this.Quote.HasNonZeroPremiums && !this.Quote.HasFees)
      {
        if (isEndorsement)
        {
          this.BindNonMonetaryEndorsement();
        }
        else
        {
          int num1 = (int) System.Windows.Forms.MessageBox.Show("Unable to bind.\n\nNo premium has been entered on this quote.", "Unable to Bind", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
      else
      {
        dsPolicyDetail.tblQuoteDetailsDataTable dataSource = (dsPolicyDetail.tblQuoteDetailsDataTable) ((UltraGridBase) this.dgParticipants).DataSource;
        if (!this.VerifyOptionsCreated(dataSource))
          return;
        if (!Conversions.ToBoolean(DefaultDatabase.ExecuteScalar("dbo.VerifyValidPremiumsFees", new object[2]
        {
          (object) "@quoteGuid",
          (object) this.Quote.QuoteGuid
        })))
        {
          int num2 = (int) System.Windows.Forms.MessageBox.Show("There are no premiums/fees booked to the quoting office location.", "Unable to Bind", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          if (!DefaultDatabase.ExecuteScalar<bool>("dbo.IsQuotingLocationOnlyOffice", new object[2]
          {
            (object) "@QuoteGuid",
            (object) this.Quote.QuoteGuid
          }) && System.Windows.Forms.MessageBox.Show("You are about to bind an account to multiple chart of accounts.  Is this correct?", "Chart Of Accounts", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            return;
          List<string> stringList = new List<string>();
          try
          {
            foreach (dsPolicyDetail.tblQuoteDetailsRow dr in (TypedTableBase<dsPolicyDetail.tblQuoteDetailsRow>) dataSource)
            {
              if (!this.VerifyRaters(dr))
                return;
              IRater rater = RaterFactory.GetRater(dr.RaterID);
              if (rater == null && !this._quote.IsMultiCompanyPolicy)
              {
                int num3 = (int) System.Windows.Forms.MessageBox.Show($"A rater was was not found for {new CompanyLine(dr.CompanyLineGuid).CompanyLineState}.", "Rater Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
              }
              if (rater != null)
              {
                try
                {
                  rater.InitializeState(this._quote.QuoteGuid, dr.CompanyLineGuid);
                  if (!rater.IsReadyForBind && rater.NotReadyToBindReason.Count > 0)
                  {
                    FormSettings.ShowFormDialog(typeof (frmBindingRequirements), new object[2]
                    {
                      (object) rater.NotReadyToBindReason,
                      (object) frmBindingRequirements.RequirementsType.Bind
                    }).Dispose();
                    return;
                  }
                  if (SystemSettings.GetSetting<bool>("EnablePreBindValidation", false))
                  {
                    QuoteIsReadyForBindContext readyForBindContext = new QuoteIsReadyForBindContext(rater, dr.RaterID);
                    Messaging.SendBroadcastMessage(BroadcastMessages.QuoteIsReadyForBind, (object) readyForBindContext);
                    stringList.AddRange((IEnumerable<string>) readyForBindContext.ReasonsNotToBind);
                  }
                }
                finally
                {
                  ((IDisposable) rater).Dispose();
                }
              }
            }
          }
          finally
          {
            IEnumerator<dsPolicyDetail.tblQuoteDetailsRow> enumerator;
            enumerator?.Dispose();
          }
          if (stringList.Count > 0)
          {
            FormSettings.ShowFormDialog(typeof (frmBindingRequirements), new object[2]
            {
              (object) stringList,
              (object) frmBindingRequirements.RequirementsType.Bind
            }).Dispose();
          }
          else
          {
            try
            {
              BindingValidationResult validationResult = this._quote.IsReadyForBind();
              if (validationResult.HasHardStops)
              {
                using ((Form) FormSettings.ShowFormDialog<frmBindingRequirements>(new object[2]
                {
                  (object) validationResult.HardStopReasons,
                  (object) frmBindingRequirements.RequirementsType.Bind
                }))
                  return;
              }
              if (validationResult.HasSoftStops)
              {
                int num4 = (int) System.Windows.Forms.MessageBox.Show("Soft stops found:\n" + string.Join("\n", (IEnumerable<string>) validationResult.SoftStopReasons), "Binding Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ErrorHandler.HandleError(ex);
              ProjectData.ClearProjectError();
              return;
            }
            this.UpdateCommissionsOnQuote(frmPolicyDetail.EventType.Bind);
            this.ShowInstallmentBilling();
          }
        }
      }
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  protected virtual bool ForceNonMonetaryEndorsement() => false;

  private bool VerifyRaters(dsPolicyDetail.tblQuoteDetailsRow dr)
  {
    bool flag;
    if (dr.IsRaterIDNull())
    {
      int num1 = DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT RaterID FROM dbo.tblQuoteDetails WITH(NOLOCK) WHERE QuoteGuid=@QuoteGuid AND CompanyLineGuid=@CompanyLineGuid", new object[4]
      {
        (object) "@QuoteGuid",
        (object) this.Quote.QuoteGuid,
        (object) "@CompanyLineGuid",
        (object) dr.CompanyLineGuid
      }) ?? -1;
      if (num1 == -1 && !this._quote.IsMultiCompanyPolicy)
      {
        int num2 = (int) System.Windows.Forms.MessageBox.Show("The system could not determine the rater used on this policy.\n\nPlease contact technical support.", "Rater Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        flag = false;
        goto label_5;
      }
      dr.RaterID = num1;
    }
    flag = true;
label_5:
    return flag;
  }

  private bool VerifyOptionsCreated(dsPolicyDetail.tblQuoteDetailsDataTable dt)
  {
    bool flag;
    if (!this._quote.IsMultiCompanyPolicy)
    {
      try
      {
        foreach (dsPolicyDetail.tblQuoteDetailsRow tblQuoteDetailsRow in (TypedTableBase<dsPolicyDetail.tblQuoteDetailsRow>) dt)
        {
          if (!this._newOptionsAdded && !this.PremiumsControl.CurrentQuoteVersionHasLine(tblQuoteDetailsRow.LineGuid))
          {
            int num = (int) System.Windows.Forms.MessageBox.Show($"Please create an option for {tblQuoteDetailsRow.LineName}.", "Bound Option Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            flag = false;
            goto label_9;
          }
        }
      }
      finally
      {
        IEnumerator<dsPolicyDetail.tblQuoteDetailsRow> enumerator;
        enumerator?.Dispose();
      }
    }
    flag = true;
label_9:
    return flag;
  }

  protected virtual bool AllowZeroPremiumAlways()
  {
    return SystemSettings.GetSetting<bool>(nameof (AllowZeroPremiumAlways), false);
  }

  private Guid SelectQuoteOption()
  {
    frmSelectQuoteOption selectQuoteOption = (frmSelectQuoteOption) FormSettings.ShowFormDialog(typeof (frmSelectQuoteOption), new object[1]
    {
      (object) this._quote.QuoteGuid
    });
    try
    {
      return selectQuoteOption.ItemSelected ? selectQuoteOption.QuoteOptionGuid : Guid.Empty;
    }
    finally
    {
      selectQuoteOption.Dispose();
    }
  }

  private void ShowInstallmentBilling()
  {
    int num1 = DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT dbo.GetOptionIDWithPremiumOrFees(@QuoteGuid)", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quote.QuoteGuid
    }) ?? -1;
    if (num1 == -1)
    {
      int num2 = (int) System.Windows.Forms.MessageBox.Show("No premiums or Fees could be found for a bound option.", "No Premiums or Fees Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else
    {
      QuoteOption quoteOption = new QuoteOption(num1);
      quoteOption.SetupDefaultInstallmentBilling();
      int num3 = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblQuoteAdditionalInterests WHERE QuoteID = @QID AND BillableAmount IS NOT NULL", new object[2]
      {
        (object) "@QID",
        (object) this._quote.QuoteID
      });
      frmInstallmentBillingOptions.EnforceSingleFormInstance(quoteOption.QuoteOptionID);
      frmInstallmentBilling.EnforceSingleFormInstance(quoteOption.QuoteOptionID);
      frmBindPolicy.EnforceSingleFormInstance(quoteOption.Quote.QuoteID);
      if (!this._quote.IsEndorsement && !this._quote.IsMultiCompanyPolicy || num3 > 0)
      {
        frmInstallmentBillingOptions objectAs = ObjectFactory.Instance.CreateObjectAs<frmInstallmentBillingOptions>(new object[1]
        {
          (object) quoteOption.QuoteOptionID
        });
        objectAs.ConfiguratingPolicy = true;
        objectAs.MdiParent = MDIControls.Instance.MDIParent;
        objectAs.Show();
      }
      else
        FormSettings.ShowForm(typeof (frmInstallmentBilling), new object[1]
        {
          (object) quoteOption.QuoteOptionID
        });
    }
  }

  private bool PassesTargetPremiumCheck()
  {
    bool flag = true;
    if (!SecurityManager.Instance.AssertPermission("{4F98C444-D47F-456d-8C81-9BF3B09214CE}"))
      flag = DefaultDatabase.ExecuteScalar<bool>("dbo.spLOBTargetPremiumCheck", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.Quote.QuoteGuid
      });
    return flag;
  }

  private void ShowFees()
  {
    try
    {
      if (((UltraGridBase) this.dgParticipants).Rows.Count == 0)
      {
        int num1 = (int) System.Windows.Forms.MessageBox.Show("There are no options established.\n\nPlease create a quote option before managing fees.", "No Options Created", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        if (!this.PremiumsControl.FillComplete)
          return;
        int optionCount = this.PremiumsControl.OptionCount;
        Guid guid;
        switch (optionCount)
        {
          case 0:
            int num2 = (int) System.Windows.Forms.MessageBox.Show("Please rate the policy before setting up fees.", "Rating Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            break;
          case 1:
            guid = this.PremiumsControl.GetOnlyOptionGuid();
            break;
          default:
            if (optionCount > 1)
            {
              guid = this.SelectQuoteOption();
              break;
            }
            break;
        }
        if (guid.Equals(Guid.Empty))
          return;
        FormSettings.ShowForm(typeof (frmPolicyFees), new object[1]
        {
          (object) guid
        });
      }
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void OnLeftMenuBarItemClicked(object sender, ItemEventArgs e)
  {
  }

  protected UltraExplorerBarItem FindLeftMenuBarItem(string groupKey, string key)
  {
    if (string.IsNullOrEmpty(groupKey))
      throw new ArgumentNullException(nameof (groupKey));
    if (string.IsNullOrEmpty(key))
      throw new ArgumentNullException(nameof (key));
    return this.leftMenu == null || !((KeyedSubObjectsCollectionBase) this.leftMenu.Groups).Exists(groupKey) || !((KeyedSubObjectsCollectionBase) this.leftMenu.Groups[groupKey].Items).Exists(key) ? (UltraExplorerBarItem) null : this.leftMenu.Groups[groupKey].Items[key];
  }

  protected UltraExplorerBarItem AddLeftMenuBarItem(
    string groupKey,
    string key,
    string text,
    Image itemImage = null)
  {
    if (string.IsNullOrEmpty(groupKey))
      throw new ArgumentNullException(nameof (groupKey));
    if (string.IsNullOrEmpty(key))
      throw new ArgumentNullException(nameof (key));
    if (string.IsNullOrEmpty(text))
      throw new ArgumentNullException(nameof (text));
    UltraExplorerBarItem ultraExplorerBarItem = this.leftMenu.Groups[groupKey].Items.Add(key, text);
    ultraExplorerBarItem.Settings.AppearancesLarge.Appearance = (AppearanceBase) new Appearance();
    ultraExplorerBarItem.Settings.AppearancesLarge.Appearance.BackColor = Color.FromArgb(239, 247, 253);
    ultraExplorerBarItem.Settings.AppearancesLarge.Appearance.Image = (object) itemImage;
    return ultraExplorerBarItem;
  }

  private void leftMenu_ItemClick(object sender, ItemEventArgs e)
  {
    if (((Component) this).DesignMode)
      return;
    this.OnLeftMenuBarItemClicked(RuntimeHelpers.GetObjectValue(sender), e);
    if (e.Item.Group.Index == 1)
    {
      this.LoadControl(e.Item.Text);
    }
    else
    {
      string text = e.Item.Text;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Edit Policy", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Rating", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Fees", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Commissions", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Bind", false) != 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Print Indication", false) == 0)
                  this.PrintIndication();
                else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Item.Text.Substring(0, 5).ToUpper(), "PRINT", false) == 0)
                  this.ClickedPrint();
                else
                  this.LeftMenuClickOnClient(RuntimeHelpers.GetObjectValue(sender), e);
              }
              else
                this.ClickedBind();
            }
            else
              this.ShowCommissionsScreen();
          }
          else
            this.ShowFees();
        }
        else
          this.ClickRating();
      }
      else
      {
        CurrentUser.Instance.LogAction($"Edit Policy screen opened - Control #{this._quote.ControlNo}", this._quote.QuoteGuid);
        this._quote.Edit();
      }
    }
  }

  public void OnMessageReceived(Guid eventGuid, object context)
  {
    if (eventGuid.Equals(BroadcastMessages.QuoteDeleted))
    {
      QuoteDeletedContext quoteDeletedContext = (QuoteDeletedContext) context;
      if (!quoteDeletedContext.QuoteGuid.Equals(this.Quote.QuoteGuid))
        return;
      if (this.Quote.OriginalQuoteGuid.HasValue)
        FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
        {
          (object) quoteDeletedContext.ControlNo
        });
      ((Form) this).Close();
    }
    else if (eventGuid.Equals(BroadcastMessages.QuoteDocumentCreated))
    {
      if (!this.Quote.QuoteGuid.Equals((Guid) ((ArrayList) context)[0]))
        return;
      this.RefreshPolicyData();
      Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
      int index = 0;
      while (index < mdiChildren.Length)
      {
        if (mdiChildren[index] is frmClearance frmClearance)
          frmClearance.UpdateQuoteStatus(this.Quote.QuoteGuid);
        checked { ++index; }
      }
    }
    else if (eventGuid.Equals(BroadcastMessages.PolicyBound) || eventGuid.Equals(BroadcastMessages.RenewalBound))
    {
      this._statusChangeMenu.EnableDisableItems(Quote.CreateNew((Guid) context));
    }
    else
    {
      if (!eventGuid.Equals(BroadcastMessages.QuoteIsReadyForBind) || !(context is QuoteIsReadyForBindContext readyForBindContext) || !this.Quote.QuoteGuid.Equals(readyForBindContext.Rater.QuoteGuid))
        return;
      readyForBindContext.ReasonsNotToBind.AddRange((IEnumerable<string>) PreBindValidation.Validate(readyForBindContext.RaterID, readyForBindContext.Rater.LineGuid, readyForBindContext.Rater.QuoteGuid));
    }
  }

  Guid IRecreatableEntity.ControlGUID => this._quote.ControlGuid;

  bool IRecreatableEntity.HasControlGUID => true;

  public bool CanCreateNewNote => true;

  Guid IRecreatableEntity.EntityGUID => this._quote.QuoteGuid;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  string IRecreatableEntity.FriendlyEntityName => "Policy Detail";

  string IRecreatableEntity.RecreateTypeName => typeof (frmPolicyDetail).ToString();

  public int ControlNumber => this._quote.ControlNo;

  public string NamedInsured => this._quote.InsuredPolicyName;

  string IRecreatableEntity.EntityName
  {
    get
    {
      return !this._quote.HasPolicyNumber ? $"{this.NamedInsured} / Control: {this.ControlNumber.ToString()}" : $"Policy: {this._quote.PolicyNumber} / {this.NamedInsured} / Control: {this.ControlNumber.ToString()}";
    }
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged1;

  bool IRecreatableEntity.CanReCreateEntity => true;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGUID)
  {
    Quote current = Quote.CreateNew(Quote.GetQuoteGuidFromEntityGuid(entityGUID)).Current;
    if (!(current is Quote quote))
      quote = Quote.CreateNewAs<Quote>(current.QuoteGuid);
    this._quote = quote;
    this._quote.EndorsementCreated += new Quote.EndorsementCreatedEventHandler(this.EndorsementCreated);
    if (this._quote.QuoteGuid.Equals(Guid.Empty))
      throw new InvalidOperationException("RecreateEntityInitialize improperly implemented QuoteGUID determined from EntityGUID is Empty");
    // ISSUE: reference to a compiler-generated field
    ISupportNoteSystem.EntityInfoChangedEventHandler infoChangedEvent = this.EntityInfoChangedEvent;
    if (infoChangedEvent != null)
      infoChangedEvent((object) this, EventArgs.Empty);
    return true;
  }

  public string InsuredLocationName => this.Quote.SubmissionGroup.InsuredLocation.LocationName;

  public DateTime SubmissionDate => this.Quote.SubmissionGroup.DateSubmitted;

  public int ControlNum => this._quote.ControlNo;

  public bool IsBound => this._quote.IsBound;

  public string PolicyNum => this._quote.PolicyNumber;

  public int OfficeInvoiceNum
  {
    get
    {
      return !(this.pnlMiscInfo.Controls[1] is PolicyDetail_Invoices) ? -1 : (int) ((UltraGridBase) ((PolicyDetail_Invoices) this.pnlMiscInfo.Controls[1]).InvoicesGrid).ActiveRow.Cells[nameof (OfficeInvoiceNum)].Value;
    }
  }

  List<int> ISupportTemplateDocs.SupportedTemplateGroupIDs
  {
    get
    {
      List<int> templateGroupIds = new List<int>()
      {
        1,
        4,
        3
      };
      if (this.pnlMiscInfo.Controls.Count > 1 && this.pnlMiscInfo.Controls[1] is PolicyDetail_Invoices control && ((UltraGridBase) control.InvoicesGrid).ActiveRow != null)
        templateGroupIds.Add(2);
      return templateGroupIds;
    }
  }

  object[] ISupportTemplateDocs.TagParserConstructorArgs(int automationDocGroupID)
  {
    object[] objArray;
    switch ((MGASystems.IMS.Reporting.AutomationReports.Enums.AutomationDocGroups) Enum.Parse(typeof (MGASystems.IMS.Reporting.AutomationReports.Enums.AutomationDocGroups), automationDocGroupID.ToString()) - 1)
    {
      case 0:
        objArray = new object[1]
        {
          (object) this._quote.QuoteGuid
        };
        break;
      case 1:
        if (this.pnlMiscInfo.Controls[1] is PolicyDetail_Invoices control)
        {
          UltraGrid invoicesGrid = control.InvoicesGrid;
          if (((UltraGridBase) invoicesGrid).ActiveRow == null)
          {
            objArray = (object[]) null;
            break;
          }
          objArray = new object[1]
          {
            ((UltraGridBase) invoicesGrid).ActiveRow.Cells["InvoiceNum"].Value
          };
          break;
        }
        objArray = (object[]) null;
        break;
      case 2:
        objArray = new object[1]
        {
          (object) this.Quote.SubmissionGroup.SubmissionGroupGuid
        };
        break;
      case 3:
        objArray = new object[1]
        {
          (object) this.Quote.SubmissionGroup.InsuredLocation.InsuredLocationGuid
        };
        break;
      default:
        objArray = (object[]) null;
        break;
    }
    return objArray;
  }

  public Guid EntityQuoteGuid => this._quote.QuoteGuid;

  public bool SupportsQuoteContacts => true;

  protected virtual void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      try
      {
        foreach (KeyValuePair<string, PolicyDetail_Plugin> cachedPlugin in this._cachedPlugins)
          cachedPlugin.Value.Dispose();
      }
      finally
      {
        Dictionary<string, PolicyDetail_Plugin>.Enumerator enumerator;
        enumerator.Dispose();
      }
      if (this._quote != null)
        this._quote.EndorsementCreated -= new Quote.EndorsementCreatedEventHandler(this.EndorsementCreated);
      if (this.UltraToolbarsManager1 != null)
      {
        if (((ToolsCollectionBase) this.UltraToolbarsManager1.Tools).Exists("Insured Quotes"))
          ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Insured Quotes"].BeforeToolDropdown -= new BeforeToolDropdownEventHandler(this.InsuredQuotesBeforeToolDropDown);
        if (((ToolsCollectionBase) this.UltraToolbarsManager1.Tools).Exists("Submission Quotes"))
          ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Submission Quotes"].BeforeToolDropdown -= new BeforeToolDropdownEventHandler(this.SubmissionQuotesBeforeToolDropDown);
      }
      if (this._submissionStream != null)
        this._submissionStream.Dispose();
      if (this._insuredStream != null)
        this._insuredStream.Dispose();
    }
    // ISSUE: explicit non-virtual call
    __nonvirtual (((Form) this).Dispose(disposing));
  }

  private void dgParticipants_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    try
    {
      if (e.Row.Cells["FactorSetGuid"].Value != null)
      {
        Guid result;
        if (Guid.TryParse(e.Row.Cells["FactorSetGuid"].Value.ToString(), out result) && result != Guid.Empty)
        {
          e.Row.ToolTipText = Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select Title from tblFactorsets where FactorSetGuid = @FactorSetGuid", new object[2]
          {
            (object) "@FactorSetGuid",
            (object) result
          })), "");
        }
        else
        {
          if (e.Row.ToolTipText == null)
            return;
          e.Row.ToolTipText = (string) null;
        }
      }
      else
      {
        if (e.Row.ToolTipText == null)
          return;
        e.Row.ToolTipText = (string) null;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      e.Row.ToolTipText = (string) null;
      ProjectData.ClearProjectError();
    }
  }

  public static void ReplicateQuote(Guid currentQuoteGuid)
  {
    try
    {
      Quote quote = Quote.CreateNew(currentQuoteGuid);
      frmQuoteEdit formEx = (frmQuoteEdit) ObjectFactory.Instance.CreateFormEX(typeof (frmQuoteEdit), new object[2]
      {
        (object) Guid.Empty,
        (object) quote.SubmissionGroupGuid
      });
      formEx.ReplicateQuote = true;
      formEx.ReplicateQuoteGuid = currentQuoteGuid;
      ((Form) formEx).MdiParent = MDIControls.Instance.MDIParent;
      ((Control) formEx).Show();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private object MissingroducerRequirement(string operationType, ref string reason)
  {
    reason = string.Empty;
    string Left1 = operationType;
    string str1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "N", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "B", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "Q", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left1, "I", false) != 0)
            throw new InvalidOperationException("Invalid Operation Type. Expected - Clear, Bind, Quote, Issue, etc.");
          str1 = "WHERE R.NeededToIssue = 1 ";
        }
        else
          str1 = "WHERE R.NeededToQuote = 1 ";
      }
      else
        str1 = "WHERE R.NeededToBind = 1 ";
    }
    else
      str1 = "WHERE R.NeededToClear = 1 ";
    string Left2 = operationType;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "N", false) == 0)
      throw new InvalidOperationException("Invalid Operation Type. No Prompt column for Clear.");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "B", false) == 0)
      throw new InvalidOperationException("Invalid Operation Type. No Prompt column for Bind.");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "Q", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left2, "I", false) == 0)
        throw new InvalidOperationException("Invalid Operation Type. No Prompt column for Issue.");
      throw new InvalidOperationException("Invalid Operation Type. Expected - Clear, Bind, Quote, Issue, etc.");
    }
    string str2 = "AND R.PromptOnQuote = 1 ";
    object objectValue1 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, $"SELECT TOP 1 PR.Description FROM tblProducerRequirements R WITH (NOLOCK) INNER JOIN lstProducerRequirements PR WITH (NOLOCK)  ON PR.ProducerRequirementListID = R.ProducerRequirementListID {str1}{str2}AND R.OnFile = 0 AND( ProducerLocationGUID = @PL OR ProducerGUID = @PG)", new object[4]
    {
      (object) "@PL",
      (object) this.Quote.ProducerLocationGuid,
      (object) "@PG",
      (object) this.Quote.ProducerLocation.ProducerGuid
    }));
    object obj;
    if (objectValue1 != null && objectValue1 != DBNull.Value)
    {
      reason = "it is not on file.";
      obj = objectValue1;
    }
    else
    {
      string str3 = $"SELECT TOP 1 PR.Description FROM tblProducerRequirements R WITH (NOLOCK) INNER JOIN lstProducerRequirements PR WITH (NOLOCK)  ON PR.ProducerRequirementListID = R.ProducerRequirementListID {str1}{str2} AND (DATEDIFF(d,ISNULL(ValidThrough, @currDate),@currDate) > = 0) AND( ProducerLocationGUID = @PL OR ProducerGUID = @PG)";
      DateTime dateTime = CurrentUser.ServerTime;
      dateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
      object objectValue2 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, str3, new object[6]
      {
        (object) "@PL",
        (object) this.Quote.ProducerLocationGuid,
        (object) "@PG",
        (object) this.Quote.ProducerLocation.ProducerGuid,
        (object) "@currDate",
        (object) dateTime
      }));
      if (objectValue2 != null && objectValue2 != DBNull.Value)
        reason = "'Valid Through' date occurs before today's date.";
      obj = objectValue2;
    }
    return obj;
  }

  private void AuthorityLimitCheck(AuthorityLimitCheckType checkType, bool showNotification)
  {
    if (!this._runAuthorityLimitCheck)
      return;
    if (this._authorityLimitCheckManager == null)
      this._authorityLimitCheckManager = AuthorityLimitCheckManager.Create(this._quote.UnderwriterUserGuid.Value, this._quote.QuoteGuid, this._quote.ControlNo, this.ControlGUID, this._quote.PolicyNumber, (ISupportNoteSystem) this, checkType);
    else
      this._authorityLimitCheckManager.RefreshAuthorityCheck(checkType);
    if (!showNotification)
      return;
    this.AuthorityLimitNotification();
  }

  private void AuthorityLimitNotification()
  {
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Action) ([SpecialName] () =>
    {
      this.leftMenu.Groups["PolicyActions"].Items["Bind"].Visible = !this._quote.IsBound && this._authorityLimitCheckManager.ShowBindMenu(this._quote.IsBound);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.leftMenu.Groups["PolicyActions"].Items["Print"].Text, "Print Quote", false) == 0)
        this.leftMenu.Groups["PolicyActions"].Items["Print"].Visible = this._authorityLimitCheckManager.ShowQuotePrintMenu();
      if (this._quote.IsBound || !this._authorityLimitCheckManager.ShowNotification(this._quote.IsBound))
        return;
      AuthorityLimitNotificationViewModel notificationViewModel = AuthorityLimitNotificationViewModel.Create(this._authorityLimitCheckManager);
      AuthorityLimitNotificationView notificationView = MgaMdiChild.Create<AuthorityLimitNotificationView>(new object[0]);
      ((FrameworkElement) notificationView).DataContext = (object) notificationViewModel;
      int num = (int) ((MgaMdiChild) notificationView).Form.ShowDialog();
    }));
  }

  private void ThresholdLimitCheck(ThresholdLimitCheckType checkType, bool showNotification)
  {
    if (!this._runThresholdLimitCheck)
      return;
    if (this._thresholdLimitCheckManager == null)
      this._thresholdLimitCheckManager = ThresholdLimitCheckManager.Create(this._quote.QuoteGuid, this._quote.ControlNo, this.ControlGUID, this._quote.PolicyNumber, checkType);
    else
      this._thresholdLimitCheckManager.RefreshThresholdCheck(checkType);
    if (!showNotification)
      return;
    this.ThresholdLimitNotification();
  }

  private void ThresholdLimitNotification()
  {
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Action) ([SpecialName] () =>
    {
      this.leftMenu.Groups["PolicyActions"].Items["Bind"].Visible = !this._quote.IsBound && this._thresholdLimitCheckManager.ShowBindMenu(this._quote.IsBound);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.leftMenu.Groups["PolicyActions"].Items["Print"].Text, "Print Quote", false) == 0)
        this.leftMenu.Groups["PolicyActions"].Items["Print"].Visible = this._thresholdLimitCheckManager.ShowQuotePrintMenu();
      if (this._quote.IsBound || !this._thresholdLimitCheckManager.ShowNotification(this._quote.IsBound))
        return;
      CurrentUser.Instance.LogAction($"Received Threshold Limit message for Control No. {this._quote.ControlNo}", this._quote.QuoteGuid);
      ThresholdLimitNotificationViewModel notificationViewModel = ThresholdLimitNotificationViewModel.Create(this._thresholdLimitCheckManager);
      ThresholdLimitNotificationView notificationView = MgaMdiChild.Create<ThresholdLimitNotificationView>(new object[0]);
      ((FrameworkElement) notificationView).DataContext = (object) notificationViewModel;
      int num = (int) ((MgaMdiChild) notificationView).Form.ShowDialog();
    }));
  }

  protected virtual void AssignChildPolicyNumber()
  {
    List<Guid> guidList = new List<Guid>();
    dsPolicyDetail.tblQuoteDetailsDataTable dataSource = (dsPolicyDetail.tblQuoteDetailsDataTable) ((UltraGridBase) this.dgParticipants).DataSource;
    try
    {
      foreach (dsPolicyDetail.tblQuoteDetailsRow row in dataSource.Rows)
        guidList.Add(row.CompanyLineGuid);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    FormChildPolicyNumbersUpdate formEx = (FormChildPolicyNumbersUpdate) ObjectFactory.Instance.CreateFormEX(typeof (FormChildPolicyNumbersUpdate), new object[2]
    {
      (object) this.Quote.QuoteGuid,
      (object) guidList
    });
    try
    {
      int num1 = (int) formEx.ShowDialog();
      int num2 = formEx.HasSaved ? 1 : 0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw;
    }
  }

  private void VerifyProducerCommissions()
  {
    if (CompanyDocumentAutomation.BlackBoxMode || !this.Quote.IsOriginalQuoteRecord || !SystemSettings.GetSetting<bool>("ProducerCommissions.RecalculateCommissions", false))
      return;
    MGASystems.IMS.Policies.VerifyProducerCommissions producerCommissions = new MGASystems.IMS.Policies.VerifyProducerCommissions(this._quote.QuoteGuid);
    if (!producerCommissions.HasUnequalCommission())
      return;
    Dictionary<Guid, QuoteDetailCommission> dictionary = producerCommissions.GatherProducerCommissions();
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.AppendLine($"The Producer Commission structure in effect on {this.Quote.EffectiveDate.ToShortDateString()} has changed and is as follows: ");
    stringBuilder.AppendLine(string.Empty);
    try
    {
      foreach (KeyValuePair<Guid, QuoteDetailCommission> keyValuePair in dictionary)
      {
        if (!keyValuePair.Value.CommissionsEqual)
        {
          stringBuilder.AppendLine($"Company/Line - {keyValuePair.Value.CompanyLineState}");
          stringBuilder.AppendLine($"Company Commission - {keyValuePair.Value.CompanyCommission}");
          stringBuilder.AppendLine($"Current Producer Commission - {keyValuePair.Value.CurrentProducerCommission}");
          stringBuilder.AppendLine($"Calculated Producer Commission - {keyValuePair.Value.CalculatedProducerCommission}");
        }
      }
    }
    finally
    {
      Dictionary<Guid, QuoteDetailCommission>.Enumerator enumerator;
      enumerator.Dispose();
    }
    stringBuilder.AppendLine(string.Empty);
    stringBuilder.AppendLine("Do you wish to continue and update the producer commission structure?");
    if (System.Windows.Forms.MessageBox.Show(stringBuilder.ToString(), "Update Producer Commissions", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      ((Control) this).Cursor = MgaCursors.WaitCursor;
      producerCommissions.QuoteDetailProducerCommissionsUpdate();
    }
    finally
    {
      ((Control) this).Cursor = MgaCursors.Default;
    }
  }

  private bool ValidEndorsementBoundCompanyLineRequirements()
  {
    bool flag;
    if (CompanyDocumentAutomation.BlackBoxMode)
      flag = true;
    else if (!this.Quote.IsEndorsement)
    {
      flag = true;
    }
    else
    {
      int? setting = SystemSettings.GetSetting<int?>("CompanyLineRequirement.OnBindingEndorsementStatusID", new int?());
      if (!setting.HasValue)
      {
        flag = true;
      }
      else
      {
        object objectValue1 = RuntimeHelpers.GetObjectValue(this.Quote.ChangeStatusRequirementsSoftStops(setting.Value));
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)))
        {
          int num1 = (int) System.Windows.Forms.MessageBox.Show($"Soft Stop(s). The following endorsement bound requirements are not met - {Environment.NewLine}{RuntimeHelpers.GetObjectValue(objectValue1)}", "Company/line Endorsement Bound Requirements", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        object objectValue2 = RuntimeHelpers.GetObjectValue(this.Quote.ChangeStatusRequirementsHardStops(setting.Value));
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
        {
          int num2 = (int) System.Windows.Forms.MessageBox.Show(objectValue2.ToString(), "Company/line Endorsement Bound Requirements Not Satisfied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
        }
        else
          flag = true;
      }
    }
    return flag;
  }

  private void UpdateCommissionsOnQuote(frmPolicyDetail.EventType eType)
  {
    if (CompanyDocumentAutomation.BlackBoxMode || eType != frmPolicyDetail.EventType.Print && eType != frmPolicyDetail.EventType.Bind || eType == frmPolicyDetail.EventType.Print && !SystemSettings.GetSetting<bool>("PrintQuote.UpdateCommissions", false) || eType == frmPolicyDetail.EventType.Bind && !SystemSettings.GetSetting<bool>("BindQuote.UpdateCommissions", false) || this.Quote.IsEndorsement)
      return;
    ProducerLocation producerLocation = new ProducerLocation(this.Quote.ProducerLocationGuid);
    DateTime effectiveDate = this.Quote.EffectiveDate;
    int policyTypeId = this.Quote.PolicyTypeID;
    bool renewal = this.Quote.IsRenewal || this.Quote.IsImsRenewal;
    Guid quotingLocationGuid = this.Quote.QuotingLocationGuid;
    bool setting = SystemSettings.GetSetting<bool>("QuoteInformation.IncludeProCodeOnMaxProducerCommission", false);
    try
    {
      foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT QuoteDetailID, CompanyLineGuid, ProducerCommission, ProgramID FROM tblQuoteDetails WITH (NOLOCK) WHERE QuoteGuid=@QG", new object[2]
      {
        (object) "@QG",
        (object) this.Quote.QuoteGuid
      }).Rows)
      {
        Decimal d1 = 0M;
        object obj = (object) DBNull.Value;
        if (!row.IsNull("ProgramID"))
          obj = (object) row.Field<int>("ProgramID");
        if (!row.IsNull("ProducerCommission"))
          d1 = row.Field<Decimal>("ProducerCommission");
        Decimal commission = producerLocation.GetCommission(row.Field<Guid>("CompanyLineGuid"), renewal, effectiveDate, (SqlTransaction) null, (object) policyTypeId, RuntimeHelpers.GetObjectValue(obj), quotingLocationGuid);
        if (Decimal.Compare(d1, commission) != 0 && Decimal.Compare(commission, 0M) != 0)
        {
          Decimal producerCommission = this.CalculateMaxProducerCommission(row.Field<Guid>("CompanyLineGuid"), effectiveDate, renewal, setting, RuntimeHelpers.GetObjectValue(obj));
          if (Decimal.Compare(producerCommission, Decimal.MaxValue) != 0 && Decimal.Compare(commission, producerCommission) <= 0)
          {
            string str;
            switch (eType)
            {
              case frmPolicyDetail.EventType.Print:
                str = "print quote";
                break;
              case frmPolicyDetail.EventType.Bind:
                str = "bind";
                break;
              default:
                throw new InvalidOperationException("Invalid EventType");
            }
            CompanyLine companyLine = new CompanyLine(row.Field<Guid>("CompanyLineGuid"));
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteDetails SET ProducerCommission = @PC WHERE QuoteDetailID = @ID", new object[4]
            {
              (object) "@PC",
              (object) commission,
              (object) "@ID",
              (object) row.Field<int>("QuoteDetailID")
            });
            CurrentUser.Instance.LogAction($"Producer commission on {str} was updated to {commission:p} on {companyLine.CompanyLineState}.", this.Quote.QuoteGuid);
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

  private Decimal CalculateMaxProducerCommission(
    Guid companyLineGuid,
    DateTime effectiveDate,
    bool renewal,
    bool useProgCodeOnCheck,
    object tmpProgramCodeID)
  {
    string str1 = "SELECT TOP 1 ";
    string str2 = !renewal ? str1 + "ProducerCommNewMax" : str1 + "ProducerCommRenewalMax";
    CompanyLine companyLine = new CompanyLine(companyLineGuid);
    object objectValue;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(tmpProgramCodeID)) && useProgCodeOnCheck)
      objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, str2 + " FROM tblCompanyLineCommissions WITH (NOLOCK) WHERE CompanyLineID = @CompanyLineID AND (ProgramID = @ProgramID OR ProgramID IS NULL) AND Effective <= @EffectiveDate ORDER BY Effective DESC", new object[6]
      {
        (object) "@CompanyLineID",
        (object) companyLine.CompanyLineID,
        (object) "@EffectiveDate",
        (object) effectiveDate,
        (object) "@ProgramID",
        tmpProgramCodeID
      }));
    else
      objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, str2 + " FROM tblCompanyLineCommissions WITH (NOLOCK) WHERE CompanyLineID = @CompanyLineID AND Effective <= @EffectiveDate ORDER BY Effective DESC", new object[4]
      {
        (object) "@CompanyLineID",
        (object) companyLine.CompanyLineID,
        (object) "@EffectiveDate",
        (object) effectiveDate
      }));
    return !Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? (Decimal) objectValue : Decimal.MaxValue;
  }

  private void chkHideZeroPrem_CheckedChanged(object sender, EventArgs e)
  {
    this.ZeroPremiumLineRowsDisplay(this.chkHideZeroPrem.Checked);
  }

  private void ZeroPremiumLineRowsDisplay(bool hideZeroPremiumRow)
  {
    if (this.PremiumsControl == null)
      return;
    this.PremiumsControl.ZeroPremFeeRowsDisplay(hideZeroPremiumRow);
    if (hideZeroPremiumRow)
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "dbo.spPolicyDetail_QuoteDetailOptionLine", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.Quote.QuoteGuid
      });
      List<Guid> guidList = new List<Guid>();
      try
      {
        foreach ((Guid lineGuid, int companyLocationID) tuple in this.PremiumsControl.LineGuidsToHide)
        {
          try
          {
            foreach (DataRow row in dataTable.Rows)
            {
              if (row.Field<int>("CompanyLocationID") == tuple.companyLocationID && row.Field<Guid>("LineGuid") == tuple.lineGuid)
                guidList.Add(row.Field<Guid>("CompanyLineGUID"));
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
      finally
      {
        List<(Guid lineGuid, int companyLocationID)>.Enumerator enumerator;
        enumerator.Dispose();
      }
      foreach (UltraGridRow row in ((UltraGridBase) this.dgParticipants).Rows)
      {
        object obj = row.Cells["CompanyLineGuid"].Value;
        Guid guid = obj != null ? (Guid) obj : new Guid();
        if (guidList.Contains(guid))
          row.Hidden = true;
      }
    }
    else
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.dgParticipants).Rows)
        row.Hidden = false;
    }
  }

  protected virtual void LeftMenuClickOnClient(object sender, ItemEventArgs e)
  {
  }

  protected virtual bool ValidateZeroPremiumBindRequirements()
  {
    bool flag;
    if (SystemSettings.GetSetting<bool>("BindWithZeroPremium.RunCompanyLineBindRequirements", false))
    {
      object objectValue = RuntimeHelpers.GetObjectValue(this.Quote.ChangeStatusRequirements(3));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
      {
        int num = (int) System.Windows.Forms.MessageBox.Show($"The following binding requirements are not met:{Environment.NewLine}{Environment.NewLine}{RuntimeHelpers.GetObjectValue(objectValue)}", "Binding Requirements Not Met", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
        goto label_4;
      }
    }
    flag = true;
label_4:
    return flag;
  }

  private enum EventType
  {
    Print,
    Bind,
  }

  private class SetupMenusEventArgs : EventArgs
  {
    private readonly bool _isEndorsement;
    private readonly bool _isBound;
    private readonly bool _hasPremium;
    private readonly bool _isCancelled;
    private readonly bool _underNotice;
    private readonly bool _isAdmitted;
    private readonly bool _canIssueNoticeOfCancellation;
    private readonly bool _isIssued;
    private readonly bool _isOriginalQuoteRecord;
    private readonly int _invoiceCount;
    private readonly bool _canViewCommissions;
    private readonly bool _isCurrent;
    private readonly bool _hasRelatedQuotes;
    private readonly bool _viewUnderwritingLocations;
    private readonly bool _canUnbind;
    private readonly bool _isBatchIssue;
    private readonly bool _isInternalCorrection;
    private readonly bool _isDownwardInternalCorrection;
    private readonly bool _canViewFilingProducersMenu;
    private readonly bool _CanViewInstallmentEndorsement;

    public bool CanViewCommissions => this._canViewCommissions;

    public bool IsIssued => this._isIssued;

    public bool IsEndorsement => this._isEndorsement;

    public bool IsBound => this._isBound;

    public bool HasPremium => this._hasPremium;

    public bool IsCancelled => this._isCancelled;

    public bool UnderNotice => this._underNotice;

    public bool IsAdmitted => this._isAdmitted;

    public bool CanIssueNoticeOfCancellation => this._canIssueNoticeOfCancellation;

    public bool IsOriginalQuoteRecord => this._isOriginalQuoteRecord;

    public int InvoiceCount => this._invoiceCount;

    public bool IsCurrent => this._isCurrent;

    public bool HasRelatedQuotes => this._hasRelatedQuotes;

    public bool ViewUnderwritingLocations => this._viewUnderwritingLocations;

    public bool CanUnbind => this._canUnbind;

    public bool IsBatchIssue => this._isBatchIssue;

    public bool IsInternalCorrection => this._isInternalCorrection;

    public bool IsDownwardInternalCorrection => this._isDownwardInternalCorrection;

    public bool CanViewFilingProducersMenu => this._canViewFilingProducersMenu;

    public bool CanViewInstallmentEndorsement => this._CanViewInstallmentEndorsement;

    public SetupMenusEventArgs(
      bool isEndorsement,
      bool isBound,
      bool hasPremium,
      bool isCancelled,
      bool underNotice,
      bool isAdmitted,
      bool canIssueNoticeOfCancellation,
      bool isIssued,
      bool isOriginalQuoteRecord,
      int invoiceCount,
      bool isCurrent,
      bool hasRelatedQuotes,
      bool viewUnderwritingLocations,
      bool canUnbind,
      bool isBatchIssue,
      bool isInternalCorrection,
      bool isDownwardInternalCorrection,
      bool canViewFilingProducersMenu,
      bool canViewInstallment)
    {
      this._isIssued = isIssued;
      this._isEndorsement = isEndorsement;
      this._isBound = isBound;
      this._hasPremium = hasPremium;
      this._isCancelled = isCancelled;
      this._underNotice = underNotice;
      this._isAdmitted = isAdmitted;
      this._canIssueNoticeOfCancellation = canIssueNoticeOfCancellation;
      this._isOriginalQuoteRecord = isOriginalQuoteRecord;
      this._invoiceCount = invoiceCount;
      this._isCurrent = isCurrent;
      this._hasRelatedQuotes = hasRelatedQuotes;
      this._viewUnderwritingLocations = viewUnderwritingLocations;
      this._canUnbind = canUnbind;
      this._isBatchIssue = isBatchIssue;
      this._isInternalCorrection = isInternalCorrection;
      this._isDownwardInternalCorrection = isDownwardInternalCorrection;
      this._canViewFilingProducersMenu = canViewFilingProducersMenu;
      this._CanViewInstallmentEndorsement = canViewInstallment;
    }
  }

  private delegate void SetupMenusHandler(object sender, frmPolicyDetail.SetupMenusEventArgs e);

  private delegate void CompanyDataRetrievedHandler(dsPolicyDetail.tblQuoteDetailsDataTable dt);
}
