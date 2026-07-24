// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.BroadcastMessaging.BroadcastMessageListener
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.Enums;
using MGASystems.Common.Extensions;
using MGASystems.Common.LogonServer;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.Forms.Users;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Policies;
using MGASystems.IMS.Policies.Clearance;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.BroadcastMessaging;

public class BroadcastMessageListener
{
  private static BroadcastMessageListener listener;

  public static BroadcastMessageListener Instance
  {
    get
    {
      if (BroadcastMessageListener.listener == null)
        BroadcastMessageListener.listener = ObjectFactory.Instance.CreateObjectAs<BroadcastMessageListener>();
      return BroadcastMessageListener.listener;
    }
  }

  public void Listen()
  {
    Messaging.MessageSent += new Messaging.MessageSentEventHandler(this.ReceiveMessage);
  }

  public void ReceiveMessage(object sender, Messaging.MessageEventArgs e)
  {
    if (e.EventGuid.Equals(BroadcastMessages.LaunchPolicyDetailScreen))
      MGASystems.Common.FormSettings.ShowForm(typeof (frmPolicyDetail), (object) (int) e.Context);
    else if (e.EventGuid.Equals(BroadcastMessages.LaunchUsersScreen))
      BroadcastMessageListener.LaunchUsersScreen(e);
    else if (e.EventGuid.Equals(BroadcastMessages.LaunchOfficeScreen))
      MGASystems.Common.FormSettings.ShowForm(typeof (frmClientLocations), e.Context);
    else if (e.EventGuid.Equals(BroadcastMessages.InvoicePrinted))
      BroadcastMessageListener.InvoicePrinted(e);
    else if (e.EventGuid.Equals(BroadcastMessages.CompanyBillingTypesUpdated))
      BroadcastMessageListener.CompanyBillingTypesUpdated(e);
    else if (e.EventGuid.Equals(BroadcastMessages.BeginNewSubmission))
      this.NewSubmission(e);
    else if (e.EventGuid.Equals(BroadcastMessages.RefreshClearanceSearch))
      BroadcastMessageListener.RefreshClearanceSearch();
    else if (e.EventGuid.Equals(BroadcastMessages.PolicyIssuing))
    {
      if (!(e.Context is PolicyIssuedContext context))
        return;
      MGASystems.IMS.Policies.PolicyBusinessObjects.Quote objectAs = ObjectFactory.Instance.CreateObjectAs<MGASystems.IMS.Policies.PolicyBusinessObjects.Quote>((object) context.QuoteGuid);
      if (!this.SetupPolicyForIssuance(e, objectAs, context.IsPreview, context.IsReprint))
        return;
      Messaging.SendBroadcastMessage(context.IsPreview ? BroadcastMessages.PolicyPreviewed : BroadcastMessages.PolicyIssued, (object) context);
    }
    else
    {
      if (e.EventGuid.Equals(BroadcastMessages.QuoteDeleted) || !CompanyDocumentAutomation.IsQuoteLevelMessage(e.EventGuid) && !e.EventGuid.Equals(BroadcastMessages.TemplateDocumentInstanceCreated))
        return;
      if (e.Context is TemplateDocumentInstanceCreatedInfo context)
      {
        if (DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM dbo.tblClaims_Claim WITH(NOLOCK) WHERE ClaimGuid = @claimGuid", new object[2]
        {
          (object) "@claimGuid",
          (object) context.QuoteGuid
        }).Rows.Count > 0)
        {
          this.ProcessClaimLevelMessage(e);
          return;
        }
      }
      if ((!MDIControls.Instance.MDIParent.InvokeRequired ? 1 : (!e.EventGuid.Equals(BroadcastMessages.PolicyIssued) ? 0 : (CompanyDocumentAutomation.BlackBoxMode ? 1 : 0))) == 0 || !this.ContinueProcessQuoteLevelMessage(e))
        return;
      this.ProcessQuoteLevelMessage(e);
    }
  }

  private void ProcessQuoteLevelMessage(Messaging.MessageEventArgs e)
  {
    if (e.Context == null)
      throw new InvalidOperationException("BroadcastMessage context required to be a QuoteGuid for all quote level broadcasts");
    Guid guid;
    bool isPreview;
    int? templateId;
    if (e.EventGuid.ValueIn<Guid>(BroadcastMessages.PolicyIssued, BroadcastMessages.PolicyPreviewed))
    {
      PolicyIssuedContext context = (PolicyIssuedContext) e.Context;
      guid = context.QuoteGuid;
      isPreview = context.IsPreview;
      int num = context.IsReprint ? 1 : 0;
    }
    else if (e.EventGuid.Equals(BroadcastMessages.TemplateDocumentInstanceCreated))
    {
      if (!(e.Context is TemplateDocumentInstanceCreatedInfo context))
        throw new InvalidOperationException("BroadcastMessage context required to be a TemplateDocumentInstanceCreatedInfo for all quote level TemplateDocumentInstanceCreated broadcasts");
      templateId = new int?(context.TemplateId);
      guid = context.QuoteGuid;
    }
    else
      guid = !e.EventGuid.Equals(BroadcastMessages.InspectionRequested) ? (!e.EventGuid.Equals(BroadcastMessages.DriverStatusChanged) ? (Guid) e.Context : ((BroadcastMessages.Types.DriverStatusChangedContext) e.Context).QuoteGuid) : ((InspectionRequestedEventArgs) e.Context).QuoteGuid;
    MGASystems.IMS.Policies.PolicyBusinessObjects.Quote objectEx = (MGASystems.IMS.Policies.PolicyBusinessObjects.Quote) ObjectFactory.Instance.CreateObjectEX(typeof (MGASystems.BusinessObjects.Quote), (object) guid);
    if (objectEx.HasValidCompanyLineGuid)
      NoteAutomation.FireEvent(e.EventGuid, objectEx.ControlGuid, objectEx.CompanyLineGuid.Value, objectEx.QuoteID, templateId);
    try
    {
      this.CreatePolicyDocuments(e, objectEx, isPreview, guid);
      this.LaunchOfac(e, objectEx);
      if (e.EventGuid.ValueIn<Guid>(BroadcastMessages.NewQuote, BroadcastMessages.NewRenewal) && !MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("SuppressNewSubmissionNote"))
        objectEx.SendNewSubmissionDiaryItem();
      else if (e.EventGuid.Equals(BroadcastMessages.ReprintBinder))
        CurrentUser.Instance.LogAction($"Print Binder - Policy #{objectEx.PolicyNumber} - Control #{objectEx.ControlNo}", guid);
      else if (e.EventGuid.Equals(BroadcastMessages.EndorsementBound))
      {
        objectEx.Issue(CurrentUser.Instance.UserID);
      }
      else
      {
        if (!e.EventGuid.ValueIn<Guid>(BroadcastMessages.PolicyCancelled, BroadcastMessages.PolicyReinstated))
          return;
        objectEx.Issue(CurrentUser.Instance.UserID);
        CurrentUser.Instance.LogAction($"{(e.EventGuid.Equals(BroadcastMessages.PolicyCancelled) ? (object) "Cancellation" : (object) "Reinstatement")} Bound - Policy #{objectEx.PolicyNumber} - Control {objectEx.ControlNo}", guid);
      }
    }
    catch (InvalidOperationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      if (ex.Message.IndexOf("Client found response content type") != -1)
      {
        int num = (int) MessageBox.Show("The system was unable to generate the invoice document.\n\nThe invoicing web service appears to be offline.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
      else
        throw;
    }
  }

  private void ProcessClaimLevelMessage(Messaging.MessageEventArgs e)
  {
    if (e.Context == null)
      throw new InvalidOperationException("BroadcastMessage context required to be a ClaimGuid for all quote level broadcasts");
    if (!(e.Context is TemplateDocumentInstanceCreatedInfo context))
      throw new InvalidOperationException("BroadcastMessage context required to be a TemplateDocumentInstanceCreatedInfo for all quote level TemplateDocumentInstanceCreated broadcasts");
    int? templateId = new int?(context.TemplateId);
    Guid quoteGuid = context.QuoteGuid;
    NoteAutomation.FireEvent(e.EventGuid, quoteGuid, templateId);
  }

  private static void InvoicePrinted(Messaging.MessageEventArgs e)
  {
    int context = (int) e.Context;
    MGASystems.IMS.Forms.BusinessObjects.Invoice invoice = new MGASystems.IMS.Forms.BusinessObjects.Invoice(context);
    CurrentUser instance = CurrentUser.Instance;
    int num = invoice.OfficeInvoiceNum;
    string str1 = num.ToString();
    num = invoice.Quote.ControlNo;
    string str2 = num.ToString();
    string action = $"Printed Invoice #{str1} - Control #{str2}";
    int identifier = context;
    instance.LogAction(action, identifier);
    if (invoice.IsIssued)
      return;
    invoice.Issue();
  }

  private static void LaunchUsersScreen(Messaging.MessageEventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{48AED463-E95A-468b-92C0-5ADFCDB3814D}"))
    {
      int num = (int) MessageBox.Show("You do Not have the required security to open the user's form.", "Require Security", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      MGASystems.BusinessObjects.User user = new MGASystems.BusinessObjects.User((Guid) e.Context);
      if (ServerXML.UseEncryptedPasswords)
        MGASystems.Common.FormSettings.ShowForm(typeof (frmUserEncPwd), (object) user);
      else
        MGASystems.Common.FormSettings.ShowForm(typeof (frmUsers), (object) user);
    }
  }

  protected virtual void NewSubmission(Messaging.MessageEventArgs e)
  {
    Form form = (Form) null;
    Guid context = (Guid) e.Context;
    try
    {
      form = MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmSubmissionGroup), (object) context);
    }
    finally
    {
      form.Dispose();
    }
  }

  private static void RefreshClearanceSearch()
  {
    try
    {
      foreach (frmClearance frmClearance in MDIControls.Instance.MDIParent.MdiChildren.OfType<frmClearance>())
        frmClearance.RefreshSearch();
    }
    finally
    {
      IEnumerator<frmClearance> enumerator;
      enumerator?.Dispose();
    }
  }

  private void CreatePolicyDocuments(
    Messaging.MessageEventArgs e,
    MGASystems.IMS.Policies.PolicyBusinessObjects.Quote q,
    bool preview,
    Guid quoteGuid)
  {
    if (!q.HasValidCompanyLineGuid)
      return;
    if (e.EventGuid.ValueIn<Guid>(BroadcastMessages.QuotePrinted, BroadcastMessages.RenewalQuotePrinted) && !q.PolicyFormsAutoApplied)
    {
      if (DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.PolicyFormsExist(@QuoteID)", new object[2]
      {
        (object) "@QuoteID",
        (object) q.QuoteID
      }))
      {
        int num = (int) MessageBox.Show("The policy forms list must be reviewed prior to printing the quote.", "Unable to Print Quote", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
    }
    CompanyDocumentAutomation.Initialize();
    if (e.EventGuid.ValueIn<Guid>(BroadcastMessages.PolicyIssued, BroadcastMessages.PolicyPreviewed))
    {
      this.IssueOrPreviewPolicy(e, q, preview);
    }
    else
    {
      if (e.EventGuid.ValueIn<Guid>(BroadcastMessages.QuotePrinted, BroadcastMessages.RenewalQuotePrinted))
        this.QuotePrinted(q, quoteGuid);
      this.CreateQuoteAutomationDocuments((MGASystems.BusinessObjects.Quote) q, e, preview);
    }
  }

  private static void CompanyBillingTypesUpdated(Messaging.MessageEventArgs e)
  {
    Guid context = (Guid) e.Context;
    try
    {
      foreach (frmQuoteEdit frmQuoteEdit in MDIControls.Instance.MDIParent.MdiChildren.OfType<frmQuoteEdit>())
      {
        if (frmQuoteEdit.IsValidCompanyLineSelected && frmQuoteEdit.CompanyLineGuid.Equals(context))
          frmQuoteEdit.GetAvailableBillingTypes();
      }
    }
    finally
    {
      IEnumerator<frmQuoteEdit> enumerator;
      enumerator?.Dispose();
    }
  }

  private void ProcessPrintQuoteStatusReason(MGASystems.IMS.Policies.PolicyBusinessObjects.Quote q)
  {
    int num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(1) FROM dbo.lstQuoteStatusReasons WITH(NOLOCK) WHERE ID = @ID AND QuoteStatusID = @QID", new object[4]
    {
      (object) "@ID",
      (object) q.QuoteStatusReasonID,
      (object) "@QID",
      (object) QuoteStatus.Quoted
    });
    q.ChangeStatus(2, num > 0 ? q.QuoteStatusReasonID.Value : -1);
  }

  private void QuotePrinted(MGASystems.IMS.Policies.PolicyBusinessObjects.Quote q, Guid quoteGuid)
  {
    if (q.IsOriginalQuoteRecord && !q.IsBound)
    {
      if (!q.HasQuoteStatusReason)
        q.QuoteStatus = QuoteStatus.Quoted;
      else
        this.ProcessPrintQuoteStatusReason(q);
      if (!q.IsEndorsement)
        this.UpdateQuoteOptions((MGASystems.BusinessObjects.Quote) q);
    }
    CurrentUser.Instance.LogAction($"Print Quote - Control #{q.ControlNo}", quoteGuid);
  }

  protected virtual bool ContinueProcessQuoteLevelMessage(Messaging.MessageEventArgs e) => true;

  protected virtual bool ContinuePolicyIssuance()
  {
    return CompanyDocumentAutomation.BlackBoxMode || MessageBox.Show($"There are no documents attached to this policy.{"\n"}{"\n"}Are you sure you want to issue this policy?", "Issuance Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
  }

  protected virtual DateTime GetPolicyIssuanceDate() => CurrentUser.ServerTime;

  private bool SetupPolicyForIssuance(
    Messaging.MessageEventArgs e,
    MGASystems.IMS.Policies.PolicyBusinessObjects.Quote q,
    bool isPreview,
    bool isReprint)
  {
    PolicyIssuedContext context = (PolicyIssuedContext) e.Context;
    int num1 = DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.HasPolicyForms(@QID)", new object[2]
    {
      (object) "@QID",
      (object) q.QuoteID
    }) ? 1 : 0;
    int printTypeID = -1;
    Guid eventGuid = isPreview ? BroadcastMessages.PolicyPreviewed : BroadcastMessages.PolicyIssued;
    bool flag1 = BroadcastMessageListener.HasQuoteDocs(q, eventGuid, printTypeID);
    bool flag2;
    if (num1 != 0 || flag1)
    {
      if (CompanyDocumentAutomation.BlackBoxMode || MDIControls.Instance.MDIParent.InvokeRequired)
      {
        printTypeID = 1;
      }
      else
      {
        frmPolicyPrintTypes policyPrintTypes = (frmPolicyPrintTypes) MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmPolicyPrintTypes), (object) isPreview, (object) isReprint, (object) q.QuoteID);
        try
        {
          if (policyPrintTypes.Saved)
          {
            if (policyPrintTypes.BatchIssuePrintTypeID != -1)
            {
              CurrentUser.Instance.LogAction($"Set control {q.ControlNo} to be batch issued.", q.QuoteGuid);
              flag2 = false;
              goto label_25;
            }
            printTypeID = policyPrintTypes.PrintTypeID;
          }
          else
          {
            flag2 = false;
            goto label_25;
          }
        }
        finally
        {
          policyPrintTypes.Dispose();
        }
      }
    }
    context.PrintTypeID = printTypeID;
    if (BroadcastMessageListener.HasQuoteDocs(q, eventGuid, printTypeID))
    {
      if (!isPreview && !isReprint)
      {
        BroadcastMessageListener.MarkPolicyAsIssued(this.GetPolicyIssuanceDate(), q.ControlNo);
        CurrentUser.Instance.LogAction($"Issued Policy #{q.PolicyNumber} - Control #{q.ControlNo}", q.QuoteGuid);
      }
      flag2 = true;
    }
    else
    {
      if (!isPreview && !isReprint && !CompanyDocumentAutomation.BlackBoxMode)
      {
        if (!q.IsEndorsement)
        {
          if (this.ContinuePolicyIssuance())
          {
            BroadcastMessageListener.MarkPolicyAsIssued(this.GetPolicyIssuanceDate(), q.ControlNo);
            CurrentUser.Instance.LogAction($"Issued Policy #{q.PolicyNumber}", q.QuoteGuid);
            flag2 = true;
            goto label_25;
          }
        }
        else if (MessageBox.Show($"This is an endorsement transaction.{"\n"}{"\n"}There are no documents attached.{"\n"}{"\n"}Would you like to continue with the issuance of this endorsement?", "Issue Endorsement?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          frmIssueEndorsementDate issueEndorsementDate = (frmIssueEndorsementDate) MGASystems.Common.FormSettings.ShowFormDialog(typeof (frmIssueEndorsementDate));
          if (issueEndorsementDate.ClickedSave)
          {
            BroadcastMessageListener.MarkPolicyAsIssued(issueEndorsementDate.IssueDateChosen, q.ControlNo);
            CurrentUser.Instance.LogAction($"Issued Policy #{q.PolicyNumber}", q.QuoteGuid);
            flag2 = true;
            goto label_25;
          }
        }
      }
      else
      {
        if (CompanyDocumentAutomation.BlackBoxMode)
          throw new InvalidOperationException("There are no documents attached to this policy");
        int num2 = (int) MessageBox.Show("There are no documents attached to this policy", "No Documents attached", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      flag2 = false;
    }
label_25:
    return flag2;
  }

  private void IssueOrPreviewPolicy(Messaging.MessageEventArgs e, MGASystems.IMS.Policies.PolicyBusinessObjects.Quote q, bool isPreview)
  {
    PolicyIssuedContext context = (PolicyIssuedContext) e.Context;
    int printTypeID = context != null ? context.PrintTypeID : -1;
    bool? invokeRequired;
    if (printTypeID == -1 && CompanyDocumentAutomation.BlackBoxMode || ((invokeRequired = MDIControls.Instance?.MDIParent?.InvokeRequired).HasValue ? (invokeRequired.GetValueOrDefault() ? 1 : 0) : 1) != 0)
      printTypeID = 1;
    if (!BroadcastMessageListener.HasQuoteDocs(q, e.EventGuid, printTypeID) || printTypeID == -1)
      return;
    this.CreateQuoteAutomationDocuments((MGASystems.BusinessObjects.Quote) q, e, isPreview, printTypeID);
  }

  private static bool HasQuoteDocs(MGASystems.IMS.Policies.PolicyBusinessObjects.Quote q, Guid eventGuid, int printTypeID)
  {
    return DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.HasQuoteDocument(@quoteGuid,@companyLineGuid, @printTypeID, @eventGuid,@companyLineID)", new object[10]
    {
      (object) "@quoteGuid",
      (object) q.QuoteGuid,
      (object) "@companyLineGuid",
      (object) q.CompanyLineGuid,
      (object) "@printTypeID",
      (object) (printTypeID == -1 ? new int?() : new int?(printTypeID)),
      (object) "@eventGuid",
      (object) eventGuid,
      (object) "@companyLineID",
      (object) q.CompanyLine.CompanyLineID
    });
  }

  private static void MarkPolicyAsIssued(DateTime issueDate, int controlno)
  {
    Guid guid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT QuoteGUID FROM dbo.tblQuotes WITH(NOLOCK) WHERE ControlNo=@ControlNo AND OriginalQuoteGuid IS NULL", new object[2]
    {
      (object) "@ControlNo",
      (object) controlno
    });
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuotes SET DateIssued=@DateIssued, IssuedByUserID=@IssuedByUserID WHERE QuoteGUID = @QuoteGuid", new object[6]
    {
      (object) "@DateIssued",
      (object) issueDate,
      (object) "@IssuedByUserID",
      (object) CurrentUser.Instance.UserID,
      (object) "@QuoteGuid",
      (object) guid
    });
  }

  private void UpdateQuoteOptions(MGASystems.BusinessObjects.Quote q)
  {
    if (!MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("PrintQuote.CheckQuotedOnMultiCompanyPolicy") || !q.IsMultiCompanyPolicy)
    {
      EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable("dbo.GetQuoteOptionsFromQuote", new object[2]
      {
        (object) "@QuoteGuid",
        (object) q.QuoteGuid
      }).AsEnumerable();
      System.Func<DataRow, string> keySelector;
      // ISSUE: reference to a compiler-generated field
      if (BroadcastMessageListener._Closure\u0024__.\u0024I23\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        keySelector = BroadcastMessageListener._Closure\u0024__.\u0024I23\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        BroadcastMessageListener._Closure\u0024__.\u0024I23\u002D0 = keySelector = (System.Func<DataRow, string>) ([SpecialName] (dr) => dr.Field<string>("LineName"));
      }
      System.Func<DataRow, Guid> elementSelector;
      // ISSUE: reference to a compiler-generated field
      if (BroadcastMessageListener._Closure\u0024__.\u0024I23\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        elementSelector = BroadcastMessageListener._Closure\u0024__.\u0024I23\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        BroadcastMessageListener._Closure\u0024__.\u0024I23\u002D1 = elementSelector = (System.Func<DataRow, Guid>) ([SpecialName] (dr) => dr.Field<Guid>("QuoteOptionGUID"));
      }
      StringComparer cultureIgnoreCase = StringComparer.InvariantCultureIgnoreCase;
      ILookup<string, Guid> lookup = source.ToLookup<DataRow, string, Guid>(keySelector, elementSelector, (IEqualityComparer<string>) cultureIgnoreCase);
      System.Func<IGrouping<string, Guid>, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (BroadcastMessageListener._Closure\u0024__.\u0024I23\u002D2 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = BroadcastMessageListener._Closure\u0024__.\u0024I23\u002D2;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        BroadcastMessageListener._Closure\u0024__.\u0024I23\u002D2 = predicate = (System.Func<IGrouping<string, Guid>, bool>) ([SpecialName] (opts) => opts.Count<Guid>() > 1);
      }
      if (lookup.Any<IGrouping<string, Guid>>(predicate))
        return;
    }
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteOptions SET Quote = 1 WHERE QuoteGUID = @quoteGuid", new object[2]
    {
      (object) "@quoteGuid",
      (object) q.QuoteGuid
    });
  }

  private void CreateQuoteAutomationDocuments(
    MGASystems.BusinessObjects.Quote q,
    Messaging.MessageEventArgs e,
    bool preview,
    int printTypeID = -1)
  {
    CompanyDocumentAutomation objectEx = (CompanyDocumentAutomation) ObjectFactory.Instance.CreateObjectEX(typeof (CompanyDocumentAutomation), (object) q.CompanyLineGuid, (object) e, (object) printTypeID);
    objectEx.QuoteGuid = q.QuoteGuid;
    objectEx.PolicyPreview = preview;
    this.CreatePDFPackage(objectEx);
  }

  protected void CreatePDFPackage(CompanyDocumentAutomation ca)
  {
    if (ca == null)
      throw new ArgumentNullException(nameof (ca));
    ca.ShowInitialPleaseWaitForm();
    ca.CreatePDFPackage();
  }

  private void LaunchOfac(Messaging.MessageEventArgs e, MGASystems.IMS.Policies.PolicyBusinessObjects.Quote q)
  {
    if (!e.EventGuid.ValueIn<Guid>(BroadcastMessages.PolicyBound, BroadcastMessages.RenewalBound) || q.IsEndorsement || !MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ProcessOfacOnPolicyBound"))
      return;
    IOfacEntity entity = q.SearchQuoteOfac ? (IOfacEntity) q : (IOfacEntity) q.SubmissionGroup.InsuredLocation;
    OfacSystem.OfacStatus entityStatus = OfacSystem.Instance.GetEntityStatus(entity.EntityGuid, entity.ParentEntityGuid);
    bool setting1 = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OFAC.PolicyBound.ValidateSearch");
    bool setting2 = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OFAC.PolicyBound.ForceSearch");
    if (entityStatus != null && !setting2 && (DateTime.Now - entityStatus.LogDate).TotalDays <= 365.0 && (!setting1 || entityStatus.IsValid))
      return;
    OfacSystem.Instance.CheckOfacResult(entity);
  }
}
