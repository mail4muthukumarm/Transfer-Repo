// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Excel.Views.DisplayUI
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Common;
using MGASystems.IMS.Excel.Data.StandardRating;
using MGASystems.IMS.Excel.Rating;
using MGASystems.IMS.Excel.Views;
using MGASystems.IMS.Policies.PolicyDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Interop;

#nullable disable
namespace MgaSystems.IMS.Excel.Views;

public class DisplayUI
{
  private static readonly Dictionary<Guid, ExternalExcelSaveOptions> openSaveWindows = new Dictionary<Guid, ExternalExcelSaveOptions>();

  public static void DisplayExternalExcelSaveOptions(
    ExcelStandardRatingData ratingData,
    ExcelRater excelRater)
  {
    if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("ExcelRating.ReuseQuoteSaveOptionsWindow", true))
      DisplayUI.DisplayExternalExcelSaveOptionsInternalWithReuse(ratingData, excelRater);
    else
      DisplayUI.DisplayExternalExcelSaveOptionsInternal(ratingData, excelRater);
  }

  private static void DisplayExternalExcelSaveOptionsInternal(
    ExcelStandardRatingData ratingData,
    ExcelRater excelRater)
  {
    ExternalExcelSaveOptions saveOptions = new ExternalExcelSaveOptions(ratingData, excelRater);
    frmPolicyDetail parentForm = MDIControls.Instance.MDIParent.MdiChildren.OfType<frmPolicyDetail>().Where<frmPolicyDetail>((Func<frmPolicyDetail, bool>) (entity => entity.EntityQuoteGuid == excelRater.Quote.QuoteGuid)).FirstOrDefault<frmPolicyDetail>();
    if (parentForm != null)
      saveOptions.SourceInitialized += (EventHandler) ((s, e) => new WindowInteropHelper((Window) saveOptions).Owner = parentForm.Handle);
    saveOptions.Show();
  }

  private static void DisplayExternalExcelSaveOptionsInternalWithReuse(
    ExcelStandardRatingData ratingData,
    ExcelRater excelRater)
  {
    ExternalExcelSaveOptions saveOptions = (ExternalExcelSaveOptions) null;
    if (DisplayUI.openSaveWindows.TryGetValue(excelRater.QuoteGuid, out saveOptions))
    {
      if (saveOptions.WindowState != WindowState.Normal)
        saveOptions.WindowState = WindowState.Normal;
      saveOptions.BringIntoView();
    }
    else
    {
      saveOptions = new ExternalExcelSaveOptions(ratingData, excelRater);
      frmPolicyDetail parentForm = MDIControls.Instance.MDIParent.MdiChildren.OfType<frmPolicyDetail>().Where<frmPolicyDetail>((Func<frmPolicyDetail, bool>) (entity => entity.EntityQuoteGuid == excelRater.Quote.QuoteGuid)).FirstOrDefault<frmPolicyDetail>();
      if (parentForm != null)
        saveOptions.SourceInitialized += (EventHandler) ((s, e) => new WindowInteropHelper((Window) saveOptions).Owner = parentForm.Handle);
      DisplayUI.openSaveWindows.Add(excelRater.QuoteGuid, saveOptions);
      saveOptions.Closed += new EventHandler(DisplayUI.SaveOptions_Closed);
      saveOptions.Show();
    }
  }

  private static void SaveOptions_Closed(object sender, EventArgs e)
  {
    ExternalExcelSaveOptions excelSaveOptions = (ExternalExcelSaveOptions) sender;
    if (!DisplayUI.openSaveWindows.ContainsKey(excelSaveOptions.QuoteGuid))
      return;
    DisplayUI.openSaveWindows.Remove(excelSaveOptions.QuoteGuid);
  }
}
