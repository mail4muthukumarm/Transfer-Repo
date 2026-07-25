// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyBusinessObjects.Quote
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Exceptions;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.CustomExceptions;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.Settings;
using MGASystems.Common.ThreadingFunctions;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.IMS.Policies.BindPolicy;
using MGASystems.IMS.Policies.Cancellations;
using MGASystems.IMS.Policies.Clearance;
using MGASystems.IMS.Policies.Endorsements;
using MgaSystems.IMS.Policies.Fees;
using MGASystems.IMS.Policies.InstallmentBilling;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Policies.PolicyNumbering;
using MGASystems.IMS.Policies.Rating;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyBusinessObjects;

[SecureResource("{C99F4096-F18F-413e-AB18-6C309CFD64C2}", "Unbind Issued Policy", "Allows a user to unbind a policy after is has been issued.", "Policy")]
[SecureResource("{08DD8B9F-6416-4235-8794-D03584E44F78}", "Unbind Recent Policy", "Allows a user to unbind a policy on the same day it was bound.", "Policy")]
[SecureResource("{AEE43ACD-A103-4b88-A86D-74704175F284}", "Create Quote on Inactive Producer", "Allows a user to create a quote on an inactive producer.", "Policy")]
[SecureResource("{5C318669-AE19-4b02-B50E-245B94032ADA}", "Override Allow Endorsement without Issuance", "Controls whether or not a user is allowed to create endorsements before policy issuance", "Policy")]
[SecureResource("{1A8E91F1-5754-4b67-BCFC-EE5C1E92D690}", "Allow the Deletion of an Unbound Quote", "Controls whether or not a user is allowed to delete an unbound quote.", "Policy")]
[SecureResource("{6B8AA593-EFED-496e-98C2-B31EB8544B37}", "Allow Binding On InActive Company / Line", "Controls whether or not a user is allowed to bind policies on an inactive company / line.", "Policy")]
[SecureResource("{EB0AE909-E2C9-473D-9D4C-CB1DE1282E1C}", "Allow Binding of Endorsements On InActive Company/Line", "Controls whether a user is allowed to bind endorsement policies on an inactive company / line.", "Policy")]
[SecureResource("{E9C62145-6F3A-4d8c-970C-A694F539817F}", "Allow Overriding if Cancellation if Requires Issuance", "Allows overriding in cases where cancellation requires issuance.", "Policy")]
[SecureResource("{FF64EE49-3A7F-4169-84AF-E9C1921456BE}", "Allow unbinding on or after Policy/Endorsement effective date", "Allows unbinding on or after Policy/Endorsement effective date.", "Policy")]
[SecureResource("{FC604D63-53CB-450f-A93D-9DEE739AF1DA}", "Allow Unbinding if Bound in the Previous Month.", "Allow the unbinding of a policy if it is bound in the previous month.", "Policy")]
[SecureResource("{3E386169-6DB0-41B0-B964-83B7913E420A}", "Allow Creation of Endorsement on Purchase Book.", "Allow the creation of an endorsement when the policy is of type 'Purchase Book of Business.", "Policy")]
[SecureResource("{86613D75-4B41-4D72-A01D-4B7AAA122230}", "Allow the Deletion of an Unbound Endorsement.", "Controls whether or not a user is allowed to delete an unbound endorsement.", "Policy")]
[SecureResource("{2F33B022-9784-4A33-8646-F6AD5156466F}", "Allow Clearing Child Policy #s On Unbinding.", "Controls whether or not a user is allowed to clear child policy #s when unbinding.", "Policy")]
[SecureResource("{13948EBA-FC22-4C3A-B136-B4842234E5B2}", "Allow Unbind After Policy Filed.", "Allow unbind after a policy is marked as filed.", "Policy")]
[Override(typeof (Quote))]
public class Quote : Quote
{
  internal const string UnbindIssuedPolicy = "{C99F4096-F18F-413e-AB18-6C309CFD64C2}";
  internal const string UnbindPolicy = "{08DD8B9F-6416-4235-8794-D03584E44F78}";
  internal const string CreateQuoteInactiveProducer = "{AEE43ACD-A103-4b88-A86D-74704175F284}";
  internal const string CanCreateEndorsementWithoutIssuance = "{5C318669-AE19-4b02-B50E-245B94032ADA}";
  internal const string AllowDeletionOfUnboundQuote = "{1A8E91F1-5754-4b67-BCFC-EE5C1E92D690}";
  internal const string AllowCancellationEvenIfRequiresIssuance = "{E9C62145-6F3A-4d8c-970C-A694F539817F}";
  internal const string AllowBindingOnInActiveCompanyLine = "{6B8AA593-EFED-496e-98C2-B31EB8544B37}";
  internal const string AllowUnbindIfBoundInPreviousMonth = "{FC604D63-53CB-450f-A93D-9DEE739AF1DA}";
  internal const string AllowUnbindOnOrAfterPolicyEffectiveOrEndorsementEffectiveDate = "{FF64EE49-3A7F-4169-84AF-E9C1921456BE}";
  internal const string AllowCreationEndorsementOnPurchaseBook = "{3E386169-6DB0-41B0-B964-83B7913E420A}";
  internal const string AllowDeletionOfUnboundEndorsementQuote = "{86613D75-4B41-4D72-A01D-4B7AAA122230}";
  internal const string AllowUnbindAfterFiled = "{13948EBA-FC22-4C3A-B136-B4842234E5B2}";
  internal const string AllowBindingEndorsementOnInActiveCompanyLine = "{EB0AE909-E2C9-473D-9D4C-CB1DE1282E1C}";
  internal const string AllowClearingChildPolicyNumberOnUnbind = "{2F33B022-9784-4A33-8646-F6AD5156466F}";
  private bool _supressSuccessMessages;
  private bool _blackBoxMode;
  private DateTime _UseEndDate;
  protected Guid _newQuoteGuidForClientSave;
  private FormUnbindPleaseWait _formUnbindPleaseWait;

  public Quote(Guid quoteGuid)
    : base(quoteGuid)
  {
    this._blackBoxMode = false;
  }

  public Quote(int quoteID)
    : base(quoteID)
  {
    this._blackBoxMode = false;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [Browsable(false)]
  public Quote() => this._blackBoxMode = false;

  public static Quote FromQuoteGuid(Guid quoteGuid)
  {
    Quote quote;
    try
    {
      quote = Quote.CreateNewAs<Quote>(quoteGuid) ?? Quote.CreateNew(quoteGuid) as Quote;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      quote = Quote.CreateNew(quoteGuid) as Quote;
      ProjectData.ClearProjectError();
    }
    return quote;
  }

  public event Quote.EndorsementCreatedEventHandler EndorsementCreated;

  public static PolicyInfo GetNextPolicy(Guid quoteGuid, Guid companyLineGuid)
  {
    return ObjectFactory.Instance.CreateObjectAs<PolicyManagerBase>(new object[0]).GetPolicyEngine(quoteGuid, companyLineGuid).GetNextPolicy(quoteGuid, companyLineGuid);
  }

  public static PolicyInfo GetNextPolicy(Guid quoteGuid)
  {
    return Quote.GetNextPolicy(quoteGuid, Guid.Empty);
  }

  private bool CanCreatePurchasedBookEndorsements()
  {
    return this.PolicyType != 7 || SecurityManager.Instance.AssertPermission("{3E386169-6DB0-41B0-B964-83B7913E420A}");
  }

  public void Endorse() => this.Endorse((QuoteStatus) 9, false, false);

  public void CreatingAudit() => this.Endorse((QuoteStatus) 9, true, false);

  public void CreatingNonRenew() => this.Endorse((QuoteStatus) 26, false, false);

  public void CreatingRescindNonRenew() => this.Endorse((QuoteStatus) 27, false, false);

  public void CreatingInternalCorrection() => this.Endorse((QuoteStatus) 29, false, false);

  public void CreatingInstallment() => this.Endorse((QuoteStatus) 9, false, true);

  protected virtual void Endorse(QuoteStatus newQuoteStatus, bool forAuditing)
  {
    this.Endorse(newQuoteStatus, forAuditing, false);
  }

  protected virtual void Endorse(QuoteStatus newQuoteStatus, bool forAuditing, bool forInstallment)
  {
    // ISSUE: variable of a compiler-generated type
    Quote._Closure\u0024__37\u002D0 closure370_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Quote._Closure\u0024__37\u002D0 closure370_2 = new Quote._Closure\u0024__37\u002D0(closure370_1);
    // ISSUE: reference to a compiler-generated field
    closure370_2.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure370_2.\u0024VB\u0024Local_newQuoteStatus = newQuoteStatus;
    // ISSUE: reference to a compiler-generated field
    closure370_2.\u0024VB\u0024Local_forAuditing = forAuditing;
    // ISSUE: reference to a compiler-generated field
    closure370_2.\u0024VB\u0024Local_forInstallment = forInstallment;
    if (!this.PolicyDateIssued.HasValue)
    {
      if (this.CompanyLine.AllowEndorsementsWithoutIssuance)
      {
        if (!SecurityManager.Instance.AssertPermission("{5C318669-AE19-4b02-B50E-245B94032ADA}"))
        {
          int num = (int) MessageBox.Show("You do not have sufficient security to create endorsements without policy issuance", "Permissions Denied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          return;
        }
        if (DialogResult.No == MessageBox.Show($"This policy has not been issued.{"\n"}{"\n"}Do you want to proceed with the creation of this endorsement?", "Policy Not Issued", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
          return;
      }
      else if (!SecurityManager.Instance.AssertPermission("{5C318669-AE19-4b02-B50E-245B94032ADA}"))
      {
        int num = (int) MessageBox.Show("You do not have sufficient security to create endorsements without policy issuance", "Permissions Denied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        return;
      }
    }
    if (!this.CanCreatePurchasedBookEndorsements())
    {
      int num1 = (int) MessageBox.Show("You do not have sufficient security to create endorsements on 'Purchased Book' policies", "Permissions Denied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (!this.PassPolicyNumberRequirementsCheck())
    {
      int num2 = (int) MessageBox.Show("An endorsement can not be created on this policy because there is no policy number.", "No Policy Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      Cursor.Current = MgaCursors.WaitCursor;
      // ISSUE: reference to a compiler-generated field
      closure370_2.\u0024VB\u0024Local_newQuoteGuid = Guid.Empty;
      try
      {
        // ISSUE: variable of a compiler-generated type
        Quote._Closure\u0024__37\u002D1 closure371_1;
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Quote._Closure\u0024__37\u002D1 closure371_2 = new Quote._Closure\u0024__37\u002D1(closure371_1);
        // ISSUE: reference to a compiler-generated field
        closure371_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2 = closure370_2;
        MDIControls.Instance.StatusBarText = "Checking for unbound endorsements...";
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if ((System.ValueType) DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT TOP(1) QuoteGuid FROM dbo.tblQuotes WITH(NOLOCK) WHERE QuoteStatusID=@QSID AND ControlNo=@CN", new object[4]
        {
          (object) "@QSID",
          (object) (int) closure371_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_newQuoteStatus,
          (object) "@CN",
          (object) this.ControlNo
        }) != null)
        {
          int num3 = (int) MessageBox.Show("An endorsement can not be created on this policy because there is an existing unbound endorsement.", "Unbound Endorsement Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        closure371_2.\u0024VB\u0024Local_f = ObjectFactory.Instance.CreateObjectAs<frmCreateEndorsement>(new object[2]
        {
          (object) this.QuoteGuid,
          (object) closure371_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_newQuoteStatus
        });
        // ISSUE: reference to a compiler-generated field
        closure371_2.\u0024VB\u0024Local_f.ShowInTaskbar = false;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        closure371_2.\u0024VB\u0024Local_f.CreatingAudit = closure371_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_forAuditing;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        closure371_2.\u0024VB\u0024Local_f.CreatingInstallmentEndorsement = !closure371_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_forAuditing && closure371_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_forInstallment;
        // ISSUE: reference to a compiler-generated field
        int num4 = (int) closure371_2.\u0024VB\u0024Local_f.ShowDialog();
        // ISSUE: reference to a compiler-generated field
        if (!closure371_2.\u0024VB\u0024Local_f.Saved)
        {
          // ISSUE: reference to a compiler-generated field
          closure371_2.\u0024VB\u0024Local_f.Dispose();
          return;
        }
        Cursor.Current = MgaCursors.WaitCursor;
        MDIControls.Instance.MDIParent.Refresh();
        Application.DoEvents();
        // ISSUE: reference to a compiler-generated method
        DefaultDatabase.ExecuteTransaction(IsolationLevel.ReadUncommitted, new EventHandler<ExecuteTransactionEventArgs>(closure371_2._Lambda\u0024__0));
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        SqlException sqlException = ex;
        if (sqlException.Number == 547)
        {
          if (sqlException.Message.Contains("CK_tblQuotes_ValidEndorsementEffective"))
          {
            DateTime effectiveDate;
            DateTime expirationDate;
            if (this.IsOriginalQuoteRecord)
            {
              effectiveDate = this.EffectiveDate;
              expirationDate = this.ExpirationDate;
            }
            else
            {
              effectiveDate = this.PreviousQuote.EffectiveDate;
              expirationDate = this.PreviousQuote.ExpirationDate;
            }
            int num5 = (int) MessageBox.Show($"The effective date of the endorsement is invalid.\n\nThe endorsement must fall on or between {effectiveDate.ToShortDateString()} to {expirationDate.ToShortDateString()}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
          else if (sqlException.Message.Contains("Policy numbers must be unique"))
          {
            int num6 = (int) MessageBox.Show("The endorsement could not be created, because policy numbers must be unique.", "Non-Unique Policy Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          else
            ErrorHandler.HandleError((Exception) sqlException);
        }
        else
          ErrorHandler.HandleError((Exception) sqlException);
        ProjectData.ClearProjectError();
      }
      finally
      {
        MDIControls.Instance.StatusBarText = string.Empty;
        Cursor.Current = MgaCursors.Default;
      }
      // ISSUE: reference to a compiler-generated field
      if (!closure370_2.\u0024VB\u0024Local_newQuoteGuid.Equals(Guid.Empty))
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        CurrentUser.Instance.LogAction($"{DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Description FROM dbo.lstQuoteStatus WITH(NOLOCK) WHERE QuoteStatusID=@ID", new object[2]
        {
          (object) "@ID",
          (object) (int) closure370_2.\u0024VB\u0024Local_newQuoteStatus
        })} endorsement created - Control #{this.ControlNo}", closure370_2.\u0024VB\u0024Local_newQuoteGuid);
        // ISSUE: reference to a compiler-generated field
        Quote.EndorsementCreatedEventHandler endorsementCreatedEvent = this.EndorsementCreatedEvent;
        if (endorsementCreatedEvent != null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          endorsementCreatedEvent((object) this, new EndorsementEventArgs(closure370_2.\u0024VB\u0024Local_newQuoteGuid, closure370_2.\u0024VB\u0024Local_newQuoteStatus));
        }
        // ISSUE: reference to a compiler-generated field
        if (closure370_2.\u0024VB\u0024Local_forAuditing)
        {
          // ISSUE: reference to a compiler-generated field
          Messaging.SendBroadcastMessage(BroadcastMessages.AuditCreated, (object) closure370_2.\u0024VB\u0024Local_newQuoteGuid);
        }
        try
        {
          foreach (frmClearance frmClearance in MDIControls.Instance.MDIParent.MdiChildren.OfType<frmClearance>())
          {
            frmClearance.UpdateQuoteStatus(this.QuoteGuid);
            // ISSUE: reference to a compiler-generated field
            frmClearance.UpdateQuoteGuid(this.QuoteGuid, closure370_2.\u0024VB\u0024Local_newQuoteGuid);
          }
        }
        finally
        {
          IEnumerator<frmClearance> enumerator;
          enumerator?.Dispose();
        }
      }
      this.AfterEndorsementCreated();
    }
  }

  protected virtual void ClientEndorsementQuoteCreated(
    SqlTransaction t,
    Guid newQuoteGuid,
    frmCreateEndorsement f)
  {
  }

  public void Cancel()
  {
    if (Convert.ToBoolean(SystemSettings.GetSetting<Decimal>("CancelRequiresIssuance", 0M)) && !this.PolicyIsIssued)
    {
      if (SecurityManager.Instance.AssertPermission("{E9C62145-6F3A-4d8c-970C-A694F539817F}"))
      {
        if (MessageBox.Show("You are about to cancel a policy that has not been issued.\n\nWould you like to continue?", "Cancel Without Issuance?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
          return;
      }
      else
      {
        int num = (int) MessageBox.Show("This policy can not be cancelled.\n\nIt has not been issued", "Unable to Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
    }
    if (!this.CanCreatePurchasedBookEndorsements())
    {
      int num1 = (int) MessageBox.Show("You do not have sufficient security to create cancellation endorsements on 'Purchased Book' policies", "Permissions Denied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      Quote quote = this;
      using (frmCancelPolicy frmCancelPolicy = FormSettings.ShowFormDialog<frmCancelPolicy>(new object[1]
      {
        (object) this.QuoteGuid
      }))
      {
        if (!closure_0.Saved)
          return;
        Cursor.Current = MgaCursors.WaitCursor;
        try
        {
          Guid endorsement;
          DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (dbInstance, executeTransArgs) =>
          {
            SqlTransaction transaction = executeTransArgs.Transaction as SqlTransaction;
            endorsement = closure_1.CreateEndorsement(transaction, (TransactionTypes) 6, (QuoteStatus) 7, closure_0.EndorsementEffective, closure_0.EndorsementComment, closure_0.EndorsementCalcType, new int?(closure_0.ReasonID), new DateTime?(closure_0.EndtRequestDate));
            if (closure_1.QuoteStatus == 7)
              closure_1.PostCancellationSteps(transaction);
            closure_1.CancelPolicyTransaction(transaction);
            transaction.Commit();
          }));
          CurrentUser.Instance.LogAction($"Created a pending cancellation (control #{this.ControlNo})", this.QuoteGuid);
          // ISSUE: reference to a compiler-generated field
          Quote.EndorsementCreatedEventHandler endorsementCreatedEvent = this.EndorsementCreatedEvent;
          if (endorsementCreatedEvent == null)
            return;
          endorsementCreatedEvent((object) this, new EndorsementEventArgs(endorsement, (QuoteStatus) 7));
        }
        catch (Exception ex) when (
        {
          // ISSUE: unable to correctly present filter
          ProjectData.SetProjectError(ex);
          if (ex.Message.Contains("CK_tblQuotes_ValidEndorsementEffective"))
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
          int num2 = (int) MessageBox.Show($"This policy could not be cancelled.{"\n"}{"\n"}The endorsement effective date falls outside of the policy period.", "Invalid Endorsement Date", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
        }
        finally
        {
          Cursor.Current = MgaCursors.Default;
        }
      }
    }
  }

  protected virtual void CancelPolicyTransaction(SqlTransaction trans)
  {
  }

  protected virtual void AddClientWorkAfterCancellation()
  {
  }

  public virtual Guid Rewrite(int newPolicyTypeID)
  {
    Guid guid = base.Rewrite(newPolicyTypeID);
    if (this.BlackBoxMode && !guid.Equals(Guid.Empty) && this.CompanyLine.KeepPolicyNumberOnRewrites)
      DefaultDatabase.ExecuteNonQuery("dbo.spCopyPolicyNumberOnRewrite", new object[4]
      {
        (object) "@originalQuoteGuid",
        (object) this.QuoteGuid,
        (object) "@newQuoteGuid",
        (object) guid
      });
    return guid;
  }

  protected virtual bool IsReinstatementValidated() => true;

  public void Reinstate()
  {
    if (!this.IsCancelled && !this.UnderNotice)
      throw new InvalidOperationException("Reinstatements can only be performed on cancelled or NOC policies.");
    if (!this.IsReinstatementValidated())
      return;
    if (this.BlackBoxMode && MDIControls.Instance?.MDIParent == null)
      throw new InvalidOperationException("Reinstate can not be called in BlackBox. Call ReinstatePolicy instead.");
    QuoteStatus quoteStatus = this.QuoteStatus;
    if (this.IsCancelled)
    {
      this.Endorse((QuoteStatus) 8, false);
    }
    else
    {
      this.QuoteStatus = (QuoteStatus) 3;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuotes SET QuoteStatusReasonID=NULL WHERE QuoteID=@QuoteID", new object[2]
      {
        (object) "@QuoteID",
        (object) this.QuoteID
      });
      try
      {
        foreach (frmPolicyDetail frmPolicyDetail in MDIControls.Instance.MDIParent.MdiChildren.OfType<frmPolicyDetail>())
        {
          if (frmPolicyDetail.Quote.QuoteGuid.Equals(this.QuoteGuid))
          {
            ((Form) frmPolicyDetail).Close();
            FormSettings.ShowForm<frmPolicyDetail>(new object[1]
            {
              (object) this.QuoteGuid
            });
          }
        }
      }
      finally
      {
        IEnumerator<frmPolicyDetail> enumerator;
        enumerator?.Dispose();
      }
    }
    this.ShowRescindNotice();
  }

  protected virtual void ShowRescindNotice()
  {
    if (MessageBox.Show("Continue with the creation of available Rescind Notice Documents?", "Rescind Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    Messaging.SendBroadcastMessage(BroadcastMessages.RescindNotice, (object) this.QuoteGuid);
  }

  public Guid ReinstatePolicy(
    string endtComment,
    DateTime endtEffective,
    EndorsementCalcTypes endtCalcType)
  {
    Quote quote = this;
    string str = endtComment;
    DateTime dateTime = endtEffective;
    EndorsementCalcTypes endorsementCalcTypes = endtCalcType;
    if (!this.BlackBoxMode)
      throw new InvalidOperationException("ReinstatePolicy can only be called in BlackBox Mode!");
    if (!this.IsCancelled && !this.UnderNotice && this.QuoteStatus != 7)
      throw new InvalidOperationException("Reinstatements can only be performed on cancelled or NOC policies.");
    if (!this.IsReinstatementValidated())
      throw new InvalidOperationException("Reinstatement validation failed!");
    QuoteStatus quoteStatus = this.QuoteStatus;
    Guid guid = Guid.Empty;
    if (quoteStatus == 7)
    {
      if (!this.IsEndorsement)
        throw new InvalidOperationException("Cannot have a Pending Cancellation original transaction!");
      guid = this.OriginalQuoteGuid.Value;
      base.Delete();
    }
    else if (this.IsCancelled)
    {
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, eth) =>
      {
        guid = quote.CreateEndorsement((SqlTransaction) eth.Transaction, (TransactionTypes) 2, (QuoteStatus) 8, dateTime, str, endorsementCalcTypes);
        eth.Transaction.Commit();
      }));
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuotes SET ExpirationDate=(SELECT TOP(1) q.ExpirationDate FROM dbo.tblQuotes q WITH(NOLOCK) WHERE q.ControlNo=@controlNo ORDER BY q.QuoteID ASC) WHERE QuoteGuid=@quoteGuid", new object[4]
      {
        (object) "@controlNo",
        (object) this.ControlNo,
        (object) "@quoteGuid",
        (object) guid
      });
    }
    else
    {
      guid = this.QuoteGuid;
      this.QuoteStatus = (QuoteStatus) 3;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuotes SET QuoteStatusReasonID=NULL WHERE QuoteID=@QuoteID", new object[2]
      {
        (object) "@QuoteID",
        (object) this.QuoteID
      });
    }
    if (guid != Guid.Empty)
      Messaging.SendBroadcastMessage(BroadcastMessages.RescindNotice, (object) guid);
    return guid;
  }

  public void Edit()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      frmQuoteEdit objectAs = ObjectFactory.Instance.CreateObjectAs<frmQuoteEdit>(new object[2]
      {
        (object) this.QuoteGuid,
        (object) this.SubmissionGroupGuid
      });
      objectAs.IsQuickQuote = true;
      ((Form) objectAs).MdiParent = MDIControls.Instance.MDIParent;
      ((Control) objectAs).Show();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  public void Open()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      if (this.IsQuickQuote)
      {
        frmQuoteEdit objectAs = ObjectFactory.Instance.CreateObjectAs<frmQuoteEdit>(new object[2]
        {
          (object) this.QuoteGuid,
          (object) this.SubmissionGroupGuid
        });
        objectAs.IsQuickQuote = true;
        ((Form) objectAs).MdiParent = MDIControls.Instance.MDIParent;
        ((Control) objectAs).Show();
      }
      else
        FormSettings.ShowForm<frmPolicyDetail>(new object[1]
        {
          (object) this.QuoteGuid
        });
    }
    catch (QuoteGuidNotFoundException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("This quote could not be located. It is possible that it was removed by another user.", "Unable to Delete Quote", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private static bool ContinueWithCreate(Guid submissionGroupGuid)
  {
    bool flag;
    if (DefaultDatabase.ExecuteScalar<byte>(CommandType.Text, "SELECT pl.StatusID FROM dbo.tblProducerLocations pl WITH(NOLOCK) JOIN dbo.tblSubmissionGroup sg WITH(NOLOCK) ON sg.ProducerLocationGuid = pl.ProducerLocationGUID WHERE sg.SubmissionGroupGUID = @sgGuid", new object[2]
    {
      (object) "@sgGuid",
      (object) submissionGroupGuid
    }) == (byte) 2 && !SecurityManager.Instance.AssertPermission("{AEE43ACD-A103-4b88-A86D-74704175F284}"))
    {
      int num = (int) MessageBox.Show("You do not have the required permissions to create quotes on an inactive producer", "Permissions Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
    {
      SubmissionGroup objectAs = ObjectFactory.Instance.CreateObjectAs<SubmissionGroup>(new object[1]
      {
        (object) submissionGroupGuid
      });
      if (!objectAs.ProducerLocation.HasLines)
      {
        int num = (int) MessageBox.Show("This producer is not authorized to write any lines.", "No Lines Available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag = false;
      }
      else if (!objectAs.ProducerLocation.HasContacts)
      {
        int num = (int) MessageBox.Show("This producer location does not have any contacts assigned to it.  A contact is required for a new quote to be created.", "No Producer Contacts Available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag = false;
      }
      else
        flag = true;
    }
    return flag;
  }

  public virtual Quote.QuoteCreateType GetQuoteCreateType()
  {
    frmSelectQuoteType frmSelectQuoteType = FormSettings.ShowFormDialog<frmSelectQuoteType>();
    frmSelectQuoteType.Refresh();
    try
    {
      if (!frmSelectQuoteType.QuoteTypeSelected)
        return Quote.QuoteCreateType.None;
      return frmSelectQuoteType.QuickQuote ? Quote.QuoteCreateType.Quick : Quote.QuoteCreateType.Full;
    }
    finally
    {
      frmSelectQuoteType.Dispose();
    }
  }

  public virtual void InternalCreate(Guid submissionGroupGuid)
  {
    Quote.QuoteCreateType quoteCreateType = this.GetQuoteCreateType();
    if (quoteCreateType == Quote.QuoteCreateType.None)
      return;
    MDIControls.Instance.MDIParent.Refresh();
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      frmQuoteEdit objectAs = ObjectFactory.Instance.CreateObjectAs<frmQuoteEdit>(new object[2]
      {
        (object) Guid.Empty,
        (object) submissionGroupGuid
      });
      objectAs.IsQuickQuote = quoteCreateType == Quote.QuoteCreateType.Quick;
      ((Form) objectAs).MdiParent = MDIControls.Instance.MDIParent;
      ((Control) objectAs).Show();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  public static void Create(Guid submissionGroupGuid)
  {
    if (!Quote.ContinueWithCreate(submissionGroupGuid))
      return;
    ObjectFactory.Instance.CreateObjectAs<Quote>(new object[0]).InternalCreate(submissionGroupGuid);
  }

  public bool SupressSuccessMessages
  {
    get => this._supressSuccessMessages;
    set => this._supressSuccessMessages = value;
  }

  public bool BlackBoxMode
  {
    get => this._blackBoxMode;
    set => this._blackBoxMode = value;
  }

  public virtual void Bind(int quoteOptionID)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteOptions SET Bound=1 WHERE QuoteOptionID=@ID", new object[2]
    {
      (object) "@ID",
      (object) quoteOptionID
    });
    using (frmInstallmentBilling objectAs = ObjectFactory.Instance.CreateObjectAs<frmInstallmentBilling>(new object[1]
    {
      (object) quoteOptionID
    }))
    {
      objectAs.BlackBoxMode = true;
      objectAs.ConfigureInstallments();
      objectAs.Bind();
    }
    if (!this.IsEndorsement)
      return;
    this.IssueEndorsement(CurrentUser.Instance.UserID);
  }

  public void ShowRater()
  {
    Guid guid;
    if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(1) FROM dbo.tblQuoteDetails WITH(NOLOCK) WHERE QuoteGuid = @QuoteGuid", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid
    }) > 0)
    {
      frmSelectQuoteDetail selectQuoteDetail = FormSettings.ShowFormDialog<frmSelectQuoteDetail>(new object[1]
      {
        (object) this.QuoteGuid
      });
      MDIControls.Instance.MDIParent.Refresh();
      try
      {
        if (!selectQuoteDetail.ItemSelected)
          return;
        guid = selectQuoteDetail.CompanyLineGuid;
      }
      finally
      {
        ((Component) selectQuoteDetail).Dispose();
      }
    }
    else
      guid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP(1) CompanyLineGuid FROM dbo.tblQuoteDetails WITH(NOLOCK) WHERE QuoteGuid = @QuoteGuid", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid
      });
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT RaterID, FactorSetGuid FROM dbo.tblQuoteDetails WITH(NOLOCK) WHERE QuoteGuid = @QuoteGuid AND CompanyLineGuid = @CLG", new object[4]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid,
      (object) "@CLG",
      (object) guid
    });
    IRater rater = RaterFactory.GetRater(row.Field<int>("RaterID"));
    if (!rater.HasUI)
    {
      ((IDisposable) rater).Dispose();
    }
    else
    {
      if (rater is IRaterWithFactorSet iraterWithFactorSet)
        iraterWithFactorSet.FactorSetGuid = row.Field<Guid>("FactorsetGuid");
      rater.InitializeState(this.QuoteGuid, guid);
      rater.ShowUI();
    }
  }

  public virtual void SendNewSubmissionDiaryItem(Guid userGuid)
  {
    Guid[] guidArray = new Guid[1]{ userGuid };
    Note_System.Instance.NonInteractive.CreateBoundNote((Note_System.NonInteractiveNoteManipulator.SystemEntity) 1, "New Submission", "A new submission has been assigned to you, effective " + this.EffectiveDate.ToShortDateString(), guidArray, (ISupportNoteSystem) this, guidArray, this.EffectiveDate, this.EffectiveDate);
  }

  public virtual void SendNewSubmissionDiaryItem()
  {
    ((BaseDataObject) this).RefreshData();
    this.SendNewSubmissionDiaryItem(this.Underwriter.UserGuid);
  }

  public void PreviewPolicy()
  {
    if (!this.RatersReadyForPolicyIssuance())
      return;
    Messaging.SendBroadcastMessage(BroadcastMessages.PolicyIssuing, (object) new PolicyIssuedContext(this.QuoteGuid, true));
  }

  public BindingValidationResult IsReadyForBind()
  {
    BindingValidationResult result = new BindingValidationResult();
    CompanyLine companyLine = this.CompanyLine;
    this.CheckRequiredNotesForBind(result);
    this.CheckBasicCompanyLineRequirementsForBind(companyLine, result);
    this.CheckDatabaseValidationsForBind(companyLine, result);
    this.CheckOtherRequirementsForBind(companyLine, result);
    this.CheckSecurityPermissionsForBind(companyLine, result);
    this.CheckFeinSsnForBind(result);
    this.IsReadyForBindOnClient(result.HardStopReasons);
    this.HandleSoftAndHardStopsForBind(result);
    return result;
  }

  public virtual void CheckRequiredNotesForBind(BindingValidationResult result)
  {
    try
    {
      foreach (NoteBindFailureReason bindFailureReason in Note_System.Instance.UIInteractive.VerifyRequiredNotesOnPolicy(this.QuoteGuid, (NoteBindRequirement) 1))
        result.HardStopReasons.Add(string.Format((IFormatProvider) CultureInfo.InvariantCulture, "Note of type {0} is missing from the policy", (object) bindFailureReason.Description));
    }
    finally
    {
      List<NoteBindFailureReason>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  public virtual void CheckBasicCompanyLineRequirementsForBind(
    CompanyLine companyLine,
    BindingValidationResult result)
  {
    if (companyLine.IsRequiredForBind((CompanyLine.BindingRequirements) 1) && this.IsRetailerNull)
      result.HardStopReasons.Add("Retailer not provided");
    if (companyLine.IsRequiredForBind((CompanyLine.BindingRequirements) 2) && this.IsAccountNumberNull)
      result.HardStopReasons.Add("Account number not provided");
    if (companyLine.IsRequiredForBind((CompanyLine.BindingRequirements) 3) && this.IsRiskClassNull)
      result.HardStopReasons.Add("Risk Class (SIC Code) not provided");
    if (!companyLine.IsRequiredForBind((CompanyLine.BindingRequirements) 10) || !this.IsNaicsCodeNull)
      return;
    result.HardStopReasons.Add("NAICS Code not provided");
  }

  public virtual void CheckDatabaseValidationsForBind(
    CompanyLine companyLine,
    BindingValidationResult result)
  {
    if (companyLine.IsRequiredForBind((CompanyLine.BindingRequirements) 4))
    {
      if (DefaultDatabase.ExecuteScalar<int>("dbo.spCheckMissingLocationClassCodes", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid
      }) > 0)
        result.HardStopReasons.Add("Underwriting locations exist with no class code specified.");
    }
    if (!this.PolicyFormsAutoApplied)
    {
      if (DefaultDatabase.ExecuteFunction<bool>("dbo.PolicyFormsExist", new object[2]
      {
        (object) "@QuoteID",
        (object) this.QuoteID
      }))
        result.HardStopReasons.Add("Policy forms list has not been reviewed.");
    }
    if (companyLine.IsRequiredForBind((CompanyLine.BindingRequirements) 5))
    {
      if (DefaultDatabase.ExecuteScalar<int>("dbo.spCheckMissingLocationTerritoryCodes", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid
      }) > 0)
        result.HardStopReasons.Add("Underwriting locations exist with no territory code specified.");
    }
    if (!DefaultDatabase.ExecuteScalar<bool>("dbo.ValidCompanyLineCommissions", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid
    }))
      result.HardStopReasons.Add("A valid commissions rule is not in effect for this policy.");
    if (!DefaultDatabase.ExecuteScalar<bool>("dbo.ValidCompanyLinePaymentTerms", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid
    }))
      result.HardStopReasons.Add("A valid terms Of payment setup Is Not In effect For this policy.");
    if (companyLine.IsRequiredForBind((CompanyLine.BindingRequirements) 7))
    {
      if (DefaultDatabase.ExecuteScalar<int>("dbo.spCheckMissingFilingProducerSLANumbers", new object[2]
      {
        (object) "@QuoteID",
        (object) this.QuoteID
      }) > 0)
        result.HardStopReasons.Add("Filing producers exist with no SLA Number specified.");
    }
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.spCheckSubPennyPremiums", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid
    });
    if (dataTable == null)
      return;
    if (dataTable.Rows.Count <= 0)
      return;
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        string str1 = row.Field<string>("CompanyLine");
        Decimal? nullable = row.Field<Decimal?>("Premium");
        if (nullable.HasValue)
        {
          string str2 = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "Sub-penny premium found for Company Line '{0}': {1:N4}", (object) str1, (object) nullable.Value);
          result.HardStopReasons.Add(str2);
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

  public virtual void CheckOtherRequirementsForBind(
    CompanyLine companyLine,
    BindingValidationResult result)
  {
    if (this.CompanyLocation.DisallowBinding)
      result.HardStopReasons.Add("Binding Is Not allowed On this Company Location.");
    if (!this.IsEndorsement && !companyLine.IsAdmitted)
      this.CheckAffidavitRequired(result.HardStopReasons);
    if (this.IsValidLineOptions())
      return;
    result.HardStopReasons.Add("Invalid options exist (verify the line Of business On the Option matches the policy).");
  }

  public virtual void CheckSecurityPermissionsForBind(
    CompanyLine companyLine,
    BindingValidationResult result)
  {
    if (!SecurityManager.Instance.AssertPermission("{6B8AA593-EFED-496e-98C2-B31EB8544B37}") && !companyLine.IsActive && !this.IsEndorsement)
      result.HardStopReasons.Add("Binding Is Not allowed On company / lines that are Not active.");
    if (SecurityManager.Instance.AssertPermission("{EB0AE909-E2C9-473D-9D4C-CB1DE1282E1C}") || companyLine.IsActive || !this.IsEndorsement)
      return;
    result.HardStopReasons.Add("Binding Of an endorsement Is Not allowed On company / lines that are Not active.");
  }

  public virtual void CheckFeinSsnForBind(BindingValidationResult result)
  {
    if (DefaultDatabase.ExecuteScalar<bool>("dbo.IsInsuredFEINOrSSN", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid
    }))
      return;
    result.HardStopReasons.Add("Insured's FEIN or SSN must be filled in prior to binding.");
  }

  public virtual void HandleSoftAndHardStopsForBind(BindingValidationResult result)
  {
    int count = result.HardStopReasons.Count;
    QuoteStatus nextBoundStatus = this.NextBoundStatus;
    object objectValue1 = RuntimeHelpers.GetObjectValue(this.ChangeStatusRequirementsSoftStops((int) nextBoundStatus));
    string empty = string.Empty;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)))
      empty = objectValue1.ToString();
    object objectValue2 = RuntimeHelpers.GetObjectValue(this.ChangeStatusRequirementsHardStops((int) nextBoundStatus));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
      result.HardStopReasons.Add(objectValue2.ToString());
    if (!SystemSettings.GetSetting<bool>("CompanyLineRequirements.ImplementSoftStops", false) || count != 0 || result.HardStopReasons.Count != 0 || string.IsNullOrEmpty(empty))
      return;
    if (DefaultDatabase.ExecuteScalar<int>("dbo.spCheckSoftStopBindingRuleCount", new object[2]
    {
      (object) "@CompanyLineID",
      (object) this.CompanyLine.CompanyLineID
    }) <= 0)
      return;
    result.SoftStopReasons.Add(empty);
  }

  protected virtual bool IsValidLineOptions()
  {
    bool flag;
    if (!this.CompanyLine.IsPackage)
    {
      List<QuoteOption> quoteOptions = this.QuoteOptions;
      System.Func<QuoteOption, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (Quote._Closure\u0024__.\u0024I73\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = Quote._Closure\u0024__.\u0024I73\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Quote._Closure\u0024__.\u0024I73\u002D0 = predicate = (System.Func<QuoteOption, bool>) ([SpecialName] (qo) => qo.Bound);
      }
      if (quoteOptions.Any<QuoteOption>(predicate))
      {
        flag = this.QuoteOptions.Any<QuoteOption>((System.Func<QuoteOption, bool>) ([SpecialName] (qo) => qo.Bound && qo.LineGuid.Equals(this.LineGuid)));
        goto label_7;
      }
    }
    flag = true;
label_7:
    return flag;
  }

  protected virtual void IsReadyForBindOnClient(List<string> list)
  {
  }

  public object ChangeStatusRequirements(int quoteStatusID)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.StoredProcedure, "dbo.spCheckCompanyLineRequirements", 0, (CommandArgumentType) 0, new object[4]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid,
      (object) "@QuoteStatusID",
      (object) quoteStatusID
    }));
    return Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? (object) null : (object) objectValue.ToString();
  }

  public object ChangeStatusRequirementsSoftStops(int quoteStatusID)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.StoredProcedure, "dbo.spCheckCompanyLineRequirements_SoftStops", 0, (CommandArgumentType) 0, new object[4]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid,
      (object) "@QuoteStatusID",
      (object) quoteStatusID
    }));
    return Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? (object) null : (object) objectValue.ToString();
  }

  public object ChangeStatusRequirementsHardStops(int quoteStatusID)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.StoredProcedure, "dbo.spCheckCompanyLineRequirements_HardStops", 0, (CommandArgumentType) 0, new object[4]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid,
      (object) "@QuoteStatusID",
      (object) quoteStatusID
    }));
    return Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? (object) null : (object) objectValue.ToString();
  }

  private void CheckAffidavitRequired(List<string> reasonList)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT StateID FROM dbo.tblQuoteFilingProducers WITH(NOLOCK) WHERE QuoteID=@QuoteID And FilingProducer Is NULL", new object[2]
    {
      (object) "@QuoteID",
      (object) this.QuoteID
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        string str = row.Field<string>(0);
        if (DefaultDatabase.ExecuteScalar<bool?>(CommandType.Text, "SELECT RequiredForBinding FROM dbo.tblAdminAffidavitNumbers WITH(NOLOCK) WHERE StateID=@StateID", new object[2]
        {
          (object) "@StateID",
          (object) str
        }) ?? false)
        {
          if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(1) FROM dbo.tblQuoteAffidavitNumbers WITH(NOLOCK) WHERE QuoteID=@QuoteID And StateID=@StateID", new object[4]
          {
            (object) "@QuoteID",
            (object) this.QuoteID,
            (object) "@StateID",
            (object) str
          }) == 0)
            reasonList.Add($"Affidavit Number Required In {str}.");
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

  public void CreateCorrectionEntry() => this.Endorse((QuoteStatus) 16 /*0x10*/, false);

  protected virtual bool ReadyToUnbind()
  {
    bool unbind;
    if (!SecurityManager.Instance.AssertPermission("{08DD8B9F-6416-4235-8794-D03584E44F78}"))
    {
      int num = (int) MessageBox.Show("You Do Not have permission To unbind policies.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      unbind = false;
    }
    else
    {
      DateTime? nullable1;
      DateTime dateTime1;
      DateTime serverTime;
      bool? nullable2;
      if (this.IsEndorsement)
      {
        nullable2 = new bool?(false);
      }
      else
      {
        nullable1 = this.DateBound;
        bool? nullable3;
        if (!nullable1.HasValue)
        {
          nullable3 = new bool?();
        }
        else
        {
          dateTime1 = nullable1.GetValueOrDefault();
          dateTime1 = dateTime1.Date;
          ref DateTime local = ref dateTime1;
          serverTime = CurrentUser.ServerTime;
          DateTime date = serverTime.Date;
          nullable3 = new bool?(local.Equals(date));
        }
        bool? nullable4 = nullable3;
        nullable2 = nullable4.HasValue ? new bool?(!nullable4.GetValueOrDefault()) : nullable4;
      }
      bool? nullable5 = nullable2;
      if (nullable5.HasValue && !nullable5.GetValueOrDefault() || SecurityManager.Instance.AssertPermission("{1831B532-0BAA-4831-B986-F3FA3B16297E}") || !nullable5.HasValue)
      {
        bool? nullable6;
        if (!this.IsEndorsement || !this.IsIssued)
        {
          nullable6 = new bool?(false);
        }
        else
        {
          nullable1 = this.DateIssued;
          bool? nullable7;
          if (!nullable1.HasValue)
          {
            nullable7 = new bool?();
          }
          else
          {
            dateTime1 = nullable1.GetValueOrDefault();
            dateTime1 = dateTime1.Date;
            ref DateTime local = ref dateTime1;
            serverTime = CurrentUser.ServerTime;
            DateTime date = serverTime.Date;
            nullable7 = new bool?(local.Equals(date));
          }
          bool? nullable8 = nullable7;
          nullable6 = nullable8.HasValue ? new bool?(!nullable8.GetValueOrDefault()) : nullable8;
        }
        nullable5 = nullable6;
        if (nullable5.HasValue && !nullable5.GetValueOrDefault() || SecurityManager.Instance.AssertPermission("{1831B532-0BAA-4831-B986-F3FA3B16297E}") || !nullable5.HasValue)
        {
          bool? nullable9;
          if (!this.IsEndorsement)
          {
            nullable9 = new bool?(false);
          }
          else
          {
            nullable1 = this.DateBound;
            bool? nullable10;
            if (!nullable1.HasValue)
            {
              nullable10 = new bool?();
            }
            else
            {
              dateTime1 = nullable1.GetValueOrDefault();
              dateTime1 = dateTime1.Date;
              ref DateTime local = ref dateTime1;
              serverTime = CurrentUser.ServerTime;
              DateTime date = serverTime.Date;
              nullable10 = new bool?(local.Equals(date));
            }
            bool? nullable11 = nullable10;
            nullable9 = nullable11.HasValue ? new bool?(!nullable11.GetValueOrDefault()) : nullable11;
          }
          nullable5 = nullable9;
          if (nullable5.HasValue && !nullable5.GetValueOrDefault() || SecurityManager.Instance.AssertPermission("{1831B532-0BAA-4831-B986-F3FA3B16297E}") || !nullable5.HasValue)
          {
            if (this.IsIssued && !this.IsEndorsement && !SecurityManager.Instance.AssertPermission("{C99F4096-F18F-413e-AB18-6C309CFD64C2}"))
            {
              int num = (int) MessageBox.Show("You Do Not have permission To unbind policies after they have been issued.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              unbind = false;
              goto label_42;
            }
            if (!SecurityManager.Instance.AssertPermission("{FC604D63-53CB-450f-A93D-9DEE739AF1DA}") && (!this.Premium.Equals(0M) || this.HasFees) && this.IsBound && this.ValidateCanUnbind() && !this.BypassValidateCanUnbind())
            {
              if (this._UseEndDate.Day == 1)
              {
                DateTime dateTime2 = this._UseEndDate.AddMonths(1);
                string[] strArray = new string[5]
                {
                  "This policy transaction was bound ",
                  null,
                  null,
                  null,
                  null
                };
                nullable1 = this.DateBound;
                string str;
                if (!nullable1.HasValue)
                {
                  str = (string) null;
                }
                else
                {
                  dateTime1 = nullable1.GetValueOrDefault();
                  str = dateTime1.ToShortDateString();
                }
                strArray[1] = str;
                strArray[2] = ".\n\nYou Do Not have the required security To unbind a policy transaction that was bound prior To ";
                strArray[3] = Conversions.ToString(new DateTime(this._UseEndDate.Year, dateTime2.Month, 1));
                strArray[4] = ".";
                int num = (int) MessageBox.Show(string.Concat(strArray), "Cannot Unbind", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                unbind = false;
                goto label_42;
              }
              nullable1 = this.DateBound;
              string str1;
              if (!nullable1.HasValue)
              {
                str1 = (string) null;
              }
              else
              {
                dateTime1 = nullable1.GetValueOrDefault();
                str1 = dateTime1.ToShortDateString();
              }
              string shortDateString = this._UseEndDate.ToShortDateString();
              int num1 = (int) MessageBox.Show($"This policy transaction was bound {str1}.\n\nYou Do Not have the required security To unbind a policy transaction that was bound prior To {shortDateString}", "Cannot Unbind", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              unbind = false;
              goto label_42;
            }
            if (DateTime.Compare(DateTime.Now, this.IsEndorsement ? this.EndorsementEffective : this.EffectiveDate) >= 0 && !SecurityManager.Instance.AssertPermission("{FF64EE49-3A7F-4169-84AF-E9C1921456BE}"))
            {
              int num = (int) MessageBox.Show("You Do Not have permission To unbind policies On Or after the policy effective/endorsement Date", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              unbind = false;
              goto label_42;
            }
            if (this.IsOriginalQuoteRecord && !SecurityManager.Instance.AssertPermission("{13948EBA-FC22-4C3A-B136-B4842234E5B2}"))
            {
              if (DefaultDatabase.ExecuteScalar<bool>("dbo.IsPolicyFiled", new object[2]
              {
                (object) "@QuoteGuid",
                (object) this.QuoteGuid
              }))
              {
                int num = (int) MessageBox.Show("You Do Not have permission To unbind policies that have been filed.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                unbind = false;
                goto label_42;
              }
            }
            unbind = this.ValidateCompanyLineUnbindRequirements();
            goto label_42;
          }
        }
      }
      int num2 = (int) MessageBox.Show("You Do Not have permission To unbind policies after the Date they were originally bound.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      unbind = false;
    }
label_42:
    return unbind;
  }

  public virtual bool ValidateCanUnbind()
  {
    bool flag1 = false;
    bool flag2;
    if ("PB".Equals(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("dbo.spGetInvoiceType", new object[2]
    {
      (object) "@QuoteID",
      (object) this.QuoteID
    }))))
    {
      flag2 = false;
    }
    else
    {
      int setting = SystemSettings.GetSetting<int>("CompanyDefinedEndOfMonth", 0);
      this._UseEndDate = new DateTime(this.DateBound.Value.Year, this.DateBound.Value.Month, setting + 1);
      DateTime serverTime = CurrentUser.ServerTime;
      DateTime dateTime1 = this.DateBound.Value;
      if (setting == 1)
      {
        DateTime dateTime2 = serverTime.AddMonths(-1);
        if (dateTime1.Year < dateTime2.Year || dateTime1.Month < dateTime2.Month)
          flag1 = true;
      }
      else
      {
        DateTime dateTime3 = serverTime.AddMonths(-1);
        if (dateTime1.Year < dateTime3.Year || dateTime1.Year == dateTime3.Year && dateTime1.Month < dateTime3.Month || dateTime1.Year == dateTime3.Year && dateTime1.Month == dateTime3.Month && dateTime1.Day > setting)
          flag1 = true;
      }
      flag2 = flag1;
    }
    return flag2;
  }

  public virtual bool BypassValidateCanUnbind()
  {
    bool flag = false;
    if (this.PolicyType == 7 && this.IsOriginalQuoteRecord)
      flag = true;
    return flag;
  }

  public void Unbind()
  {
    if (!this.ReadyToUnbind())
      return;
    string str1 = (this.IsEndorsement ? "endorsement" : "policy").ToString();
    if (!this.BlackBoxMode)
    {
      if (MessageBox.Show($"This will unbind the {str1} and void all invoices associated With it.{"\n"}{"\n"}Unbind the {str1}?", $"Unbind {StringExtensions.FirstLetterToUpper(str1, (CultureInfo) null)}?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
    }
    bool keepExistingAffidavitNumbers = true;
    if (!this.IsEndorsement && this.AffidavitNumbers.Count > 0)
    {
      string str2 = "The following affidavit numbers have been assigned To this policy: \n\n";
      try
      {
        foreach (Quote.AffidavitNumber affidavitNumber in this.AffidavitNumbers)
          str2 = $"{str2}{affidavitNumber.StateID} - {affidavitNumber.AffidavitNumber}\n";
      }
      finally
      {
        List<Quote.AffidavitNumber>.Enumerator enumerator;
        enumerator.Dispose();
      }
      if (!this.BlackBoxMode)
      {
        switch (MessageBox.Show(str2 + "\nWould you like to keep these affidavit numbers", "Keep existing affidavit numbers?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3))
        {
          case DialogResult.Cancel:
            return;
          case DialogResult.No:
            keepExistingAffidavitNumbers = false;
            break;
        }
      }
      else
        keepExistingAffidavitNumbers = false;
    }
    bool keepPolicyNumber = this.IsEndorsement || this.BlackBoxMode || DialogResult.Yes == MessageBox.Show($"Would you like to keep the currently assigned policy number ({this.PolicyNumber})?", "Keep Policy Number?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    int[] clearPNFromQuoteDetailIds = Array.Empty<int>();
    if (SecurityManager.Instance.AssertPermission("{2F33B022-9784-4A33-8646-F6AD5156466F}"))
    {
      using (frmChildPolicyNumbers childPolicyNumbers = new frmChildPolicyNumbers(this.QuoteGuid))
      {
        if (childPolicyNumbers.DtQuoteDetails.Rows.Count > 0)
        {
          int num = (int) childPolicyNumbers.ShowDialog();
          clearPNFromQuoteDetailIds = childPolicyNumbers.QuoteDetailIds;
        }
      }
    }
    if (!this.BlackBoxMode && !this.IsEndorsement)
    {
      string str3 = "On attempting to unbind, the user ";
      string str4 = !keepPolicyNumber ? str3 + "chooses to clear the main policy # " : str3 + "chooses to keep the main policy # ";
      if (clearPNFromQuoteDetailIds.Length > 0)
        str4 += "and also opts to clear the child policy #s.";
      CurrentUser.Instance.LogAction(str4, this.QuoteGuid);
    }
    if (!this.BlackBoxMode)
      this.UnbindComplete += new Quote.UnbindCompleteEventHandler(this.DoPostUnbindWork);
    this.DoUnbind(keepExistingAffidavitNumbers, keepPolicyNumber, clearPNFromQuoteDetailIds);
  }

  private void DoPostUnbindWork(object sender, UnbindEventArgs e)
  {
    this.UnbindComplete -= new Quote.UnbindCompleteEventHandler(this.DoPostUnbindWork);
    if (!e.Success)
      return;
    CurrentUser.Instance.LogAction($"Unbound Policy #{this.PolicyNumber} - Control #{this.ControlNo.ToString()}", this.QuoteGuid);
    string str = !this.IsEndorsement ? "policy" : "endorsement";
    if (!this.SupressSuccessMessages)
    {
      int num = (int) MessageBox.Show($"The {str} has been successfully unbound.", "Policy Unbound", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    this.RefreshPolicyDetailForms();
  }

  private void DoUnbind(bool keepExistingAffidavitNumbers, bool keepPolicyNumber)
  {
    this.DoUnbind(keepExistingAffidavitNumbers, keepPolicyNumber, Array.Empty<int>());
  }

  private void DoUnbind(
    bool keepExistingAffidavitNumbers,
    bool keepPolicyNumber,
    int[] clearPNFromQuoteDetailIds)
  {
    if (this.BlackBoxMode)
    {
      this.UnbindOnThread((object) new object[2]
      {
        (object) keepExistingAffidavitNumbers,
        (object) keepPolicyNumber
      });
    }
    else
    {
      if (this._formUnbindPleaseWait == null)
      {
        FormUnbindPleaseWait unbindPleaseWait = new FormUnbindPleaseWait();
        unbindPleaseWait.ShowInTaskbar = false;
        unbindPleaseWait.StartPosition = FormStartPosition.CenterScreen;
        this._formUnbindPleaseWait = unbindPleaseWait;
      }
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.UnbindOnThread), (object) new object[3]
      {
        (object) keepExistingAffidavitNumbers,
        (object) keepPolicyNumber,
        (object) clearPNFromQuoteDetailIds
      });
      int num = (int) this._formUnbindPleaseWait.ShowDialog();
    }
  }

  private void UnbindOnThread(object state)
  {
    object[] objArray = (object[]) state;
    bool flag = (bool) objArray[0];
    bool keepPolicyNumber = (bool) objArray[1];
    int[] numArray = objArray.Length != 3 ? Array.Empty<int>() : (int[]) objArray[2];
    bool success = false;
    if (!this.BlackBoxMode)
      Thread.Sleep(2000);
    try
    {
      this.Unbind(flag, keepPolicyNumber, CurrentUser.Instance.UserGUID, numArray);
      success = true;
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      SqlException sqlException = ex;
      if (this.BlackBoxMode)
        throw new Exception("This policy could not be unbound:\n\n" + sqlException.Message);
      MessageBox.Show("This policy could not be unbound:\n\n" + sqlException.Message, "Unable to Unbind", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ProjectData.ClearProjectError();
    }
    catch (NoInvoicesException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      if (this.BlackBoxMode)
        throw new Exception("This policy could not be unbound.\n\nNo invoices were located for this policy.");
      MessageBox.Show("This policy could not be unbound.\n\nNo invoices were located for this policy.", "Unable to Unbind", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ProjectData.ClearProjectError();
    }
    catch (UnbindClosedAccountingMonthException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      if (this.BlackBoxMode)
        throw new Exception("This policy could not be unbound.\n\nOne or more invoices were billed in a closed accounting month.");
      MessageBox.Show("This policy could not be unbound.\n\nOne or more invoices were billed in a closed accounting month.", "Unable to Unbind", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new Quote.HandleErrorOnUIThreadHandler(this.HandleErrorOnUIThread), new object[1]
      {
        (object) ex
      });
      ProjectData.ClearProjectError();
    }
    if (!this.BlackBoxMode)
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new Quote.UnbindCompleteUIThreadHandler(this.UnbindCompleteUIThread), new object[1]
      {
        (object) success
      });
    this.ClientWorkPostUnbind(success);
    this.ClientWorkPostUnbindPolicyNumber(keepPolicyNumber);
  }

  private void HandleErrorOnUIThread(Exception ex)
  {
    this.DisposePleaseWaitForm();
    ErrorHandler.HandleError(ex);
  }

  private void DisposePleaseWaitForm()
  {
    if (this._formUnbindPleaseWait == null)
      return;
    FormUnbindPleaseWait unbindPleaseWait = this._formUnbindPleaseWait;
    unbindPleaseWait.Close();
    unbindPleaseWait.Dispose();
    this._formUnbindPleaseWait = (FormUnbindPleaseWait) null;
  }

  protected virtual void ClientWorkPostUnbind(bool success)
  {
  }

  protected virtual void ClientWorkPostUnbindPolicyNumber(bool keepPolicyNumber)
  {
  }

  public event Quote.UnbindCompleteEventHandler UnbindComplete;

  private void UnbindCompleteUIThread(bool success)
  {
    this.DisposePleaseWaitForm();
    UnbindEventArgs e = new UnbindEventArgs()
    {
      Success = success
    };
    // ISSUE: reference to a compiler-generated field
    Quote.UnbindCompleteEventHandler unbindCompleteEvent = this.UnbindCompleteEvent;
    if (unbindCompleteEvent == null)
      return;
    unbindCompleteEvent((object) this, e);
  }

  private void RefreshPolicyDetailForms()
  {
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmPolicyDetail frmPolicyDetail && frmPolicyDetail.Quote.QuoteGuid.Equals(this.QuoteGuid))
        frmPolicyDetail.RefreshPolicyData();
      checked { ++index; }
    }
  }

  protected bool RatersReadyForPolicyIssuance()
  {
    bool flag;
    if (this.IsEndorsement)
    {
      flag = true;
    }
    else
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT RaterID, CompanyLineGuid FROM dbo.tblQuoteDetails WITH(NOLOCK) WHERE QuoteGuid=@QuoteGuid AND RaterID IS NOT NULL", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid
      });
      try
      {
        foreach (DataRow row in dataTable.Rows)
        {
          int num1 = row.Field<int>("RaterID");
          Guid guid = row.Field<Guid>("CompanyLineGuid");
          IRater rater = RaterFactory.GetRater(num1);
          if (rater == null)
          {
            int num2 = (int) MessageBox.Show($"Could not locate the rater used on this policy.{"\n"}{"\n"}Please contact technical support.", "Rater Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            flag = true;
            goto label_18;
          }
          rater.InitializeState(this.QuoteGuid, guid);
          if (!rater.IsReadyForPolicyIssuance)
          {
            using ((Form) FormSettings.ShowFormDialog<frmBindingRequirements>(new object[2]
            {
              (object) rater.NotReadyForPolicyIssuanceReasons,
              (object) frmBindingRequirements.RequirementsType.Issue
            }))
              ;
            flag = false;
            goto label_18;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      flag = true;
    }
label_18:
    return flag;
  }

  protected virtual void AfterEndorsementCreated()
  {
  }

  protected virtual bool PassPolicyNumberRequirementsCheck()
  {
    return DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT PolicyNumber FROM dbo.tblQuotes WITH(NOLOCK) WHERE QuoteGuid=@QuoteGuid", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid
    }) != null;
  }

  public virtual void Delete()
  {
    bool flag1 = SecurityManager.Instance.AssertPermission("{1A8E91F1-5754-4b67-BCFC-EE5C1E92D690}");
    if (this.IsOriginalQuoteRecord && !flag1)
    {
      int num1 = (int) MessageBox.Show("You do not have any permission to delete this unbound quote.", "Permissions Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      bool flag2 = SecurityManager.Instance.AssertPermission("{86613D75-4B41-4D72-A01D-4B7AAA122230}");
      if (!this.IsOriginalQuoteRecord && !flag2)
      {
        int num2 = (int) MessageBox.Show("You do not have any permission to delete this unbound endorsement quote.", "Permissions Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        string empty = string.Empty;
        string text = !this.IsOriginalQuoteRecord ? "Are you sure you want to delete this transaction?\n\nThis will revert this transaction to its prior status." : "Are you sure you want to delete this quote?\n\nThis will permanently remove this record.";
        string str = "quote";
        string caption = "Delete Unbound Quote?";
        if (this.IsEndorsement)
        {
          str = "endorsement";
          caption = "Delete Endorsement Transaction?";
        }
        if (DefaultDatabase.ExecuteScalar<bool>("dbo.spDocumentAssociationExists", new object[4]
        {
          (object) "@controlGuid",
          (object) this.ControlGuid,
          (object) "@quoteGuid",
          (object) this.QuoteGuid
        }) && DialogResult.No == MessageBox.Show($"Documents are associated with this {str}. Continue to d{caption.Substring(1)}?", caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
          return;
        if (DefaultDatabase.ExecuteScalar<bool>("dbo.spDriversExist", new object[2]
        {
          (object) "@quoteGuid",
          (object) this.QuoteGuid
        }) && DialogResult.No == MessageBox.Show($"Drivers are associated with this {str}. Continue to d{caption.Substring(1)}?", caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
          return;
        int num3 = (int) MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        if (num3 == 7)
          this.DeclineTransactionDeletion();
        if (num3 != 6)
          return;
        QuoteDeletedContext quoteDeletedContext = new QuoteDeletedContext();
        quoteDeletedContext.QuoteGuid = this.QuoteGuid;
        quoteDeletedContext.ControlNo = this.ControlNo;
        Guid controlGuid = this.ControlGuid;
        Cursor.Current = MgaCursors.WaitCursor;
        try
        {
          base.Delete();
        }
        catch (InvoicesExistException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num4 = (int) MessageBox.Show($"This {str} transaction can not be deleted because it has{"\n"}non-voided invoices created against it.", "Invoices Exist", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          ProjectData.ClearProjectError();
          return;
        }
        catch (SqlException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          SqlException sqlException = ex;
          if (sqlException.Message.Contains("DELETE statement conflicted with COLUMN REFERENCE constraint"))
          {
            int num5 = (int) MessageBox.Show("This quote can not be deleted because it has data associated with it that could not be removed.", "Unable to Delete Quote", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          else if (sqlException.Message.Contains("FK_tblDocumentAssociations_tblDocumentStore"))
          {
            int num6 = (int) MessageBox.Show("This quote can not be deleted, because it has associated documents.", "Unable to Delete Quote", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          else if (sqlException.Message.Contains("Unable to delete original policy record once invoices have been created"))
          {
            int num7 = (int) MessageBox.Show("Unable to delete original policy record once invoices have been created", "Unable To Delete Quote", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sqlException.Procedure, "tblQuotes_BlockBORDelete", false) == 0)
          {
            int num8 = (int) MessageBox.Show("This transaction can not be deleted because the producer on the prior record is not the same as the current submission.\n\nPlease use the change producer/BOR functionality to ensure this record matches the prior transaction prior to deleting it.", "Producer Transaction Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          else
            ErrorHandler.HandleError((Exception) sqlException);
          ProjectData.ClearProjectError();
          return;
        }
        finally
        {
          Cursor.Current = MgaCursors.Default;
        }
        Messaging.SendBroadcastMessage(BroadcastMessages.QuoteDeleted, (object) quoteDeletedContext);
        CurrentUser.Instance.LogAction($"Deleted Transaction - Control #{quoteDeletedContext.ControlNo}", controlGuid);
      }
    }
  }

  private bool IsProducerRequirementsReadyForIssuance()
  {
    bool flag1;
    if (this.IsEndorsement)
    {
      flag1 = true;
    }
    else
    {
      bool flag2 = DefaultDatabase.ExecuteScalar<bool>(SystemSettings.GetSetting<string>("ProducerRequirementsSatisfiedStoredProc", "dbo.spIsProducerRequirementsSatisfied"), new object[10]
      {
        (object) "@submissionGroupGuid",
        (object) this.SubmissionGroupGuid,
        (object) "@producerLocationGuid",
        (object) this.ProducerLocationGuid,
        (object) "@requirementType",
        (object) "I",
        (object) "@ExpirationDate",
        (object) this.ExpirationDate,
        (object) "@EffectiveDate",
        (object) this.EffectiveDate
      });
      if (!flag2)
      {
        if (MDIControls.Instance.BlackBoxMode)
          throw new InvalidOperationException("At least one specified producer requirement marked 'Needed to Issue' is not on file; or its 'Valid Through' date occurs before the current date.");
        int num = (int) MessageBox.Show("At least one specified producer requirement marked 'Needed to Issue' is not on file.\n\nOr its 'Valid Through' date occurs before the current date.", "Invalid Producer Requirement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag1 = false;
      }
      else
        flag1 = flag2;
    }
    return flag1;
  }

  private bool IsCompanyLineRequirementReadyForIssuance()
  {
    bool flag1;
    if (this.IsEndorsement)
    {
      flag1 = true;
    }
    else
    {
      bool flag2 = true;
      byte? nullable1 = DefaultDatabase.ExecuteScalar<byte?>(CommandType.Text, "SELECT QuoteStatusID FROM dbo.lstQuoteStatus WITH(NOLOCK) WHERE EventGuid = @EG AND Description = @DES", new object[4]
      {
        (object) "@EG",
        (object) BroadcastMessages.PolicyIssued,
        (object) "@DES",
        (object) "Policy Issued"
      });
      int? nullable2 = nullable1.HasValue ? new int?((int) nullable1.GetValueOrDefault()) : new int?();
      if (nullable2.HasValue)
      {
        object objectValue1 = RuntimeHelpers.GetObjectValue(this.ChangeStatusRequirementsSoftStops(nullable2.Value));
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)))
        {
          int num1 = (int) MessageBox.Show($"Soft Stop(s). The following issuance requirements are not met - {"\n"}{RuntimeHelpers.GetObjectValue(objectValue1)}", "Company/line Policy Issuance - Requirements", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        object objectValue2 = RuntimeHelpers.GetObjectValue(this.ChangeStatusRequirementsHardStops(nullable2.Value));
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
        {
          flag2 = false;
          int num2 = (int) MessageBox.Show(objectValue2.ToString(), "Company/line Policy Issuance Not Satisfied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
      flag1 = flag2;
    }
    return flag1;
  }

  public virtual void IssuePolicy(int userID)
  {
    if ((!this.RatersReadyForPolicyIssuance() || !this.IsProducerRequirementsReadyForIssuance() ? 0 : (this.IsCompanyLineRequirementReadyForIssuance() ? 1 : 0)) == 0)
      return;
    if (this.BlackBoxMode)
      base.IssuePolicy(userID);
    else
      Messaging.SendBroadcastMessage(BroadcastMessages.PolicyIssuing, (object) new PolicyIssuedContext(this.QuoteGuid, false));
  }

  public void Issue(int userID)
  {
    if (!this.IsEndorsement)
      this.IssuePolicy(userID);
    else
      this.IssueEndorsement(CurrentUser.Instance.UserID);
  }

  protected virtual void DeclineTransactionDeletion()
  {
  }

  public virtual void AutoApplyFees(Guid quoteOptionGuid, SqlTransaction trans)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Quote._Closure\u0024__111\u002D0 closure1110 = new Quote._Closure\u0024__111\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure1110.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure1110.\u0024VB\u0024Local_quoteOptionGuid = quoteOptionGuid;
    // ISSUE: reference to a compiler-generated field
    closure1110.\u0024VB\u0024Local_trans = trans;
    // ISSUE: reference to a compiler-generated field
    if (closure1110.\u0024VB\u0024Local_trans != null && !DefaultDatabase.HasTransaction)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) closure1110.\u0024VB\u0024Local_trans, new ExecuteHandler((object) closure1110, __methodptr(_Lambda\u0024__0)));
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      ObjectFactory.Instance.CreateObjectAs<AutoApplyFeesWorker>(new object[1]
      {
        (object) this
      }).AutoApplyFees(closure1110.\u0024VB\u0024Local_quoteOptionGuid);
    }
  }

  private bool ValidateCompanyLineUnbindRequirements()
  {
    int? setting = SystemSettings.GetSetting<int?>("CompanyLineRequirement.UnbindStatusID", new int?());
    bool flag;
    if (!setting.HasValue)
    {
      flag = true;
    }
    else
    {
      object objectValue1 = RuntimeHelpers.GetObjectValue(this.ChangeStatusRequirementsHardStops(setting.Value));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)))
      {
        int num = (int) MessageBox.Show(objectValue1.ToString(), "Company/line Unbind Requirements Not Satisfied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
      }
      else
      {
        object objectValue2 = RuntimeHelpers.GetObjectValue(this.ChangeStatusRequirementsSoftStops(setting.Value));
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
        {
          int num = (int) MessageBox.Show($"Soft Stop(s). The following unbind requirements are not met - {"\n"}{RuntimeHelpers.GetObjectValue(objectValue2)}", "Company/line Unbind Requirements", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        flag = true;
      }
    }
    return flag;
  }

  public delegate void EndorsementCreatedEventHandler(object sender, EndorsementEventArgs e);

  public enum QuoteCreateType
  {
    None,
    Quick,
    Full,
  }

  private delegate void HandleErrorOnUIThreadHandler(Exception ex);

  private delegate void UnbindCompleteUIThreadHandler(bool success);

  public delegate void UnbindCompleteEventHandler(object sender, UnbindEventArgs e);
}
