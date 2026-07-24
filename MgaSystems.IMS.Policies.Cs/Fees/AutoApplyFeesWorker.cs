// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.Fees.AutoApplyFeesWorker
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.IMS.Policies.Fees;

public class AutoApplyFeesWorker
{
  protected Quote CurrentQuote { get; }

  public AutoApplyFeesWorker(Quote quote) => this.CurrentQuote = quote;

  public AutoApplyFeesWorker(Guid quoteGuid)
    : this(Quote.CreateNew(quoteGuid))
  {
  }

  public virtual void AutoApplyFees(bool boundOnly = false)
  {
    foreach (QuoteOption quoteOption in this.CurrentQuote.QuoteOptions.Where<QuoteOption>((System.Func<QuoteOption, bool>) (qo => !boundOnly || qo.Bound)))
      this.AutoApplyFees(quoteOption.QuoteOptionGuid);
  }

  public virtual void AutoApplyFees(Guid quoteOptionGuid)
  {
    this.BeforeApplyFees(quoteOptionGuid);
    try
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spAutoApplyFees", 300, (CommandArgumentType) 0, new object[2]
      {
        (object) "@QuoteOptionGuid",
        (object) quoteOptionGuid
      });
    }
    catch (SqlException ex) when (
    {
      // ISSUE: unable to correctly present filter
      MDIControls instance = MDIControls.Instance;
      if ((instance != null ? (!instance.BlackBoxMode ? 1 : 0) : 0) != 0 && ex.State == (byte) 50 && !this.CurrentQuote.UsingNetRate)
      {
        SuccessfulFiltering;
      }
      else
        throw;
    }
    )
    {
      MGASystems.Common.ThreadingFunctions.MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    this.AfterApplyFees(quoteOptionGuid);
  }

  protected virtual void BeforeApplyFees(Guid quoteOptionGuid)
  {
  }

  protected virtual void AfterApplyFees(Guid quoteOptionGuid)
  {
  }
}
