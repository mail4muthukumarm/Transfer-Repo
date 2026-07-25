// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Claims.Fortegra_FormTPAClaimsImport
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Services.ExcelImport;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Claims;

[SecureResource("{CE6B2331-B1E6-440C-AE1B-2B5BFC3E37B6}", "Fortegra Claims Import", "Determines whether or not a user can access the TPA Claims Import screen.", "Fortegra")]
public class Fortegra_FormTPAClaimsImport : FormExcelImportBase
{
  private const string DB_TABLENAME = "dbo.Fortegra_ClaimsImport";
  public const string SECURITY_ID = "{CE6B2331-B1E6-440C-AE1B-2B5BFC3E37B6}";
  private IContainer components;
  private TPAMenuOption tpaMenuOption1;

  private bool IsExcelMappingsComplete { get; set; }

  public Fortegra_FormTPAClaimsImport() => this.InitializeComponent();

  private void Fortegra_FormTPAClaimsImport_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.AddTPATool();
  }

  private void Fortegra_FormTPAClaimsImport_ExcelMappingsComplete(object sender, EventArgs e)
  {
    if (this.IsExcelMappingsComplete)
      return;
    this.PerformDataCheck();
    this.IsExcelMappingsComplete = true;
  }

  private void Fortegra_FormTPAClaimsImport_ExcelMappingsReset(object sender, EventArgs e)
  {
    this.CreateMappings();
  }

  private void CreateMappings()
  {
    this.Mappings.Clear();
    this.Mappings.Add(new ExcelImportMapping("ClaimNumber", typeof (string), true));
    this.Mappings.Add(new ExcelImportMapping("PolicyNumber", typeof (string), true));
    this.Mappings.Add(new ExcelImportMapping("EffectiveDate", typeof (DateTime), true));
    this.Mappings.Add(new ExcelImportMapping("ExpirationDate", typeof (DateTime), generateField: true));
    this.Mappings.Add(new ExcelImportMapping("LossDate", typeof (DateTime), (object) null, true));
    this.Mappings.Add(new ExcelImportMapping("CatastropheCode", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("CompanyCatastropheCode", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("ClaimComments", typeof (string), (object) string.Empty));
    this.Mappings.Add(new ExcelImportMapping("InhouseAdjuster", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("UserDef_ClaimantId", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("DateReported", typeof (DateTime), (object) null));
    this.Mappings.Add(new ExcelImportMapping("DateSuitServed", typeof (DateTime), (object) null));
    this.Mappings.Add(new ExcelImportMapping("DateSuitAnswered", typeof (DateTime), (object) null));
    this.Mappings.Add(new ExcelImportMapping("DateDenied", typeof (DateTime), (object) null));
    this.Mappings.Add(new ExcelImportMapping("IsInsured", typeof (bool), (object) false));
    this.Mappings.Add(new ExcelImportMapping("CorporationName", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("FirstName", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("MiddleName", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("LastName", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("Address1", typeof (string), (object) string.Empty));
    this.Mappings.Add(new ExcelImportMapping("Address2", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("City", typeof (string), (object) string.Empty));
    this.Mappings.Add(new ExcelImportMapping("State", typeof (string), (object) string.Empty));
    this.Mappings.Add(new ExcelImportMapping("Zipcode", typeof (string), (object) string.Empty));
    this.Mappings.Add(new ExcelImportMapping("ISOCountryCode", typeof (string), (object) "USA"));
    this.Mappings.Add(new ExcelImportMapping("Gender", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("SSN", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("DOB", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("FEIN", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("EmailAddress", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("ManagedCareFacility", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("LossType", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("AccidentType", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("Status", typeof (string), (object) "Open"));
    this.Mappings.Add(new ExcelImportMapping("Status Date", typeof (DateTime), (object) null));
    this.Mappings.Add(new ExcelImportMapping("OutsideInvestigator", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("OutsideInvestigatorHireDate", typeof (DateTime), (object) null));
    this.Mappings.Add(new ExcelImportMapping("IsSettled", typeof (bool), (object) false));
    this.Mappings.Add(new ExcelImportMapping("SettlementType", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("ClaimantComments", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("OutsideAdjuster", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("MedicareEligible", typeof (bool), (object) 0));
    this.Mappings.Add(new ExcelImportMapping("AccidentAddress1", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("AccidentAddress2", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("AccidentCity", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("AccidentState", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("AccidentZipCode", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("AccidentISOCountryCode", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("AccidentCounty", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("AccidentDocumentText", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("AccidentDescription", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("AccidentTime", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("AccidentLatitude", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("AccidentLongitude", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("PayeeName", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("PayeeAddress1", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("PayeeAddress2", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("PayeeCity", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("PayeeState", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("PayeeZipCode", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("CauseofLoss", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("Coverage", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("ALEAReserve", typeof (Decimal), (object) 0M));
    this.Mappings.Add(new ExcelImportMapping("IndemnityReserve", typeof (Decimal), (object) 0M));
    this.Mappings.Add(new ExcelImportMapping("ALEAPaid", typeof (Decimal), (object) 0M));
    this.Mappings.Add(new ExcelImportMapping("IndemnityPaid", typeof (Decimal), (object) 0M));
    this.Mappings.Add(new ExcelImportMapping("CheckDate", typeof (DateTime), generateField: true));
    this.Mappings.Add(new ExcelImportMapping("ChildCoverageLine", typeof (string), (object) null));
    this.Mappings.Add(new ExcelImportMapping("CloseDate", typeof (string), (object) null));
  }

  private void AddTPATool()
  {
    if (((KeyedSubObjectsCollectionBase) this.toolManager.Tools).Exists("tpacontainer"))
      return;
    ControlContainerTool controlContainerTool = new ControlContainerTool("tpacontainer");
    ((ToolBase) controlContainerTool).Control = (Control) this.tpaMenuOption1;
    ((ToolsCollectionBase) this.toolManager.Tools).Add((ToolBase) controlContainerTool);
    ((UltraToolbarBase) this.toolManager.Toolbars[0]).Tools.InsertTool(0, "tpacontainer");
  }

  protected override void ProcessFile()
  {
    if (!this.IsExcelMappingsComplete)
      this.ShowMappings("Default Mapping");
    if (!this.DataIssuesFound)
      this.PerformBulkInsert("dbo.Fortegra_ClaimsImport");
    if (!this.tpaMenuOption1.ClaimTPASelected)
    {
      int num = (int) MessageBox.Show("You must specify a TPA to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        ((UltraControlBase) this.gridExcelData).BeginUpdate();
        if (this.ProcessBusinessRules())
          DefaultDatabase.ExecuteNonQuery("Fortegra_spClaims_ClaimsImport", new object[4]
          {
            (object) "@TPAID",
            (object) this.tpaMenuOption1.SelectedClaimTPAId,
            (object) "@userGuid",
            (object) CurrentUser.Instance.UserGUID
          });
        ((UltraGridBase) this.gridExcelData).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_ExcelImportUtility_GetResultsTable", new object[2]
        {
          (object) "@tableName",
          (object) "dbo.Fortegra_ClaimsImport"
        });
        this.PerformShowResultFormatting();
      }
      finally
      {
        ((UltraControlBase) this.gridExcelData).EndUpdate();
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private bool ProcessBusinessRules()
  {
    return DefaultDatabase.ExecuteScalar<bool>("Fortegra_ProcessBusinessRule_ExcelImport");
  }

  protected override void ShowMappings(string mappingType = "Default Mapping")
  {
    this.CreateMappings();
    if (this.ExcelFields == null)
    {
      int num = (int) MessageBox.Show("You must specify the Excel fields to be mapped to continue.", "Required Fields Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      using (Fortegra_FormClaimExcelFileMappings excelFileMappings = new Fortegra_FormClaimExcelFileMappings(this.Mappings, this.ExcelFields, "Claims Import Mappings", this.tpaMenuOption1.SelectedClaimTPAId, this.tpaMenuOption1.SelectedClaimTPAName))
      {
        if (excelFileMappings.ShowDialog() != DialogResult.OK)
          return;
        this.OnExcelMappingsComplete();
      }
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
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    this.tpaMenuOption1 = new TPAMenuOption();
    ((ISupportInitialize) this.toolManager).BeginInit();
    ((Control) this.FormExcelImportBase_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.FormExcelImportBase_Fill_Panel).SuspendLayout();
    ((ISupportInitialize) this.gridExcelData).BeginInit();
    this.SuspendLayout();
    ((SettingsBase) this.toolManager.MenuSettings).ForceSerialization = true;
    ((SettingsBase) this.toolManager.ToolbarSettings).ForceSerialization = true;
    ((Control) this.FormExcelImportBase_Fill_Panel.ClientArea).Controls.Add((Control) this.tpaMenuOption1);
    ((Control) this.FormExcelImportBase_Fill_Panel).Location = new Point(0, 50);
    ((Control) this.FormExcelImportBase_Fill_Panel).Size = new Size(1045, 612);
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridExcelData).Size = new Size(1045, 612);
    this.tpaMenuOption1.BackColor = Color.Transparent;
    this.tpaMenuOption1.ComboBoxWidth = 284;
    this.tpaMenuOption1.Font = new Font("Tahoma", 8.25f);
    this.tpaMenuOption1.Location = new Point(270, 369);
    this.tpaMenuOption1.Name = "tpaMenuOption1";
    this.tpaMenuOption1.Size = new Size(293, 48 /*0x30*/);
    this.tpaMenuOption1.TabIndex = 4;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1045, 662);
    this.Name = nameof (Fortegra_FormTPAClaimsImport);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Claims Import (Fortegra)";
    this.ExcelMappingsComplete += new EventHandler<EventArgs>(this.Fortegra_FormTPAClaimsImport_ExcelMappingsComplete);
    this.ExcelMappingsReset += new EventHandler<EventArgs>(this.Fortegra_FormTPAClaimsImport_ExcelMappingsReset);
    this.Load += new EventHandler(this.Fortegra_FormTPAClaimsImport_Load);
    ((ISupportInitialize) this.toolManager).EndInit();
    ((Control) this.FormExcelImportBase_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.FormExcelImportBase_Fill_Panel).ResumeLayout(false);
    ((ISupportInitialize) this.gridExcelData).EndInit();
    this.ResumeLayout(false);
  }
}
