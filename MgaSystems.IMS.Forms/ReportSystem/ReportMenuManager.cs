// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.ReportSystem.ReportMenuManager
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using GrapeCity.ActiveReports;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common.ReportSystem;
using MGASystems.IMS.Reporting;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.ReportSystem;

[MGASystems.Common.MenuManager]
public class ReportMenuManager : MenuManagerBase
{
  private const string CONST_REPORTS_ROOT_KEY = "REPORTS_ROOT";

  protected override void OnBeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
    if (Operators.CompareString(((CancelableToolEventArgs) e).Tool.Key, "REPORTS_ROOT", false) != 0)
      return;
    this.ClearVolatileTools();
    if (!this.MDIChildSupportsReports)
      return;
    PopupMenuTool residentTool = (PopupMenuTool) this.GetResidentTool("REPORTS_ROOT");
    if (this.MDIChildAsISupportReports.ReportItems == null)
    {
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      DictionaryEntry[] reportItems = this.MDIChildAsISupportReports.ReportItems;
      int index = 0;
      while (index < reportItems.Length)
      {
        DictionaryEntry dictionaryEntry = reportItems[index];
        if (!(dictionaryEntry.Key is string) || !(dictionaryEntry.Value is string))
          throw new InvalidOperationException("The key and Value of the dictionary entry provided by 'ReportItems' must be of type string.");
        ButtonTool tool = new ButtonTool((string) dictionaryEntry.Key);
        ((ToolPropsBase) ((ToolBase) tool).SharedProps).Caption = (string) dictionaryEntry.Value;
        ((ToolBase) tool).SharedProps.Visible = true;
        this.AddVolatileTool((ToolBase) tool);
        residentTool.Tools.AddTool(((ToolBase) tool).Key);
        checked { ++index; }
      }
    }
  }

  protected override void OnIGMenuToolClicked(object sender, ToolClickEventArgs e)
  {
    if (!this.MDIChildSupportsReports)
      return;
    SectionReport rpt = this.MDIChildAsISupportReports.PrintReport(((ToolEventArgs) e).Tool.Key);
    if (rpt == null)
      return;
    try
    {
      rpt.Document.Name = "Report";
      ReportFactory.Instance.ShowReport(rpt);
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      bool showDialog = true;
      this.MDIChildAsISupportReports.PrintErrorOccured(ex2, ref showDialog);
      if (showDialog && DialogResult.OK == MessageBox.Show("An error has occured during the generation of your report. This is most likely an internal error, and not an error associated with your printer. If the error continues to occur you should contact your system admin. \r\n\r\n" + ex2.Message, "Printing error, Try again?", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand))
        this.OnIGMenuToolClicked(RuntimeHelpers.GetObjectValue(sender), e);
      ProjectData.ClearProjectError();
    }
  }

  protected override void OnSetupIGMenu(UltraToolbarsManager menu)
  {
    PopupMenuTool tool1 = new PopupMenuTool("REPORTS_ROOT");
    ((ToolPropsBase) ((ToolBase) tool1).SharedProps).Caption = "&Reports";
    this.AddResidentTool((ToolBase) tool1);
    ((UltraToolbarBase) menu.Toolbars["mainMenu"]).Tools.InsertTool(((ToolsCollectionBase) ((UltraToolbarBase) menu.Toolbars["mainMenu"]).Tools).IndexOf("Window"), "REPORTS_ROOT");
    PopupMenuTool tool2 = (PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) menu.Toolbars["mainMenu"]).Tools)["File"];
    tool2.Tools.InsertTool(((ToolsCollectionBase) tool2.Tools)["File_Exit"].Index, "REPORTS_ROOT");
    this.SetResidentToolsVisible(false);
  }

  protected override void OnMDIChildActivate(object sender, EventArgs e)
  {
    this.SetResidentToolsVisible(this.MDIChildSupportsReports);
  }

  protected override bool FilterResidentToolClicks => false;

  private bool MDIChildSupportsReports
  {
    get => this.ActiveMDIChild != null && this.ActiveMDIChild is ISupportReports;
  }

  private ISupportReports MDIChildAsISupportReports
  {
    get
    {
      return !this.MDIChildSupportsReports ? (ISupportReports) null : (ISupportReports) this.ActiveMDIChild;
    }
  }
}
