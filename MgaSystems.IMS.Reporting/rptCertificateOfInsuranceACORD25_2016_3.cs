// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptCertificateOfInsuranceACORD25_2016_3
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Controls;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
public class rptCertificateOfInsuranceACORD25_2016_3 : SectionReport
{
  private Guid _QuoteGuid;
  private DataTable _dt;
  private int _AdditionalInterestID;
  private string _DescriptionText;
  private string _SProc;
  private List<object> _Params;
  private rptCertificateOfInsuranceACORD101 rptADDITIONAL_REMARKS_SCHEDULE;

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptCertificateOfInsuranceACORD25_2016_3));
    this.Detail = new Detail();
    this.shape9 = new Shape();
    this.txtDESCRIPTION_OF_OPERATIONS = new TextBox();
    this.txtBA_POLICY_NO = new TextBox();
    this.TextBox28 = new TextBox();
    this.label102 = new Label();
    this.label106 = new Label();
    this.label35 = new Label();
    this.label52 = new Label();
    this.shape15 = new Shape();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.label85 = new Label();
    this.label92 = new Label();
    this.label74 = new Label();
    this.label98 = new Label();
    this.txtINSURED = new TextBox();
    this.Picture = new Picture();
    this.Label12 = new Label();
    this.txtCOMMERCIAL_GL_POLICY_EXP = new TextBox();
    this.txtCOMMERCIAL_GL_POLICY_NO = new TextBox();
    this.txtCOMMERCIAL_GL_POLICY_EFF = new TextBox();
    this.Label7 = new Label();
    this.Label42 = new Label();
    this.txtBA_POLICY_EFF = new TextBox();
    this.txtBA_POLICY_EXP = new TextBox();
    this.txtUMBR_POLICY_NO = new TextBox();
    this.txtUMBR_POLICY_EFF = new TextBox();
    this.txtUMBR_POLICY_EXP = new TextBox();
    this.Label48 = new Label();
    this.txtWC_POLICY_NO = new TextBox();
    this.txtWC_POLICY_EFF = new TextBox();
    this.txtWC_POLICY_EXP = new TextBox();
    this.Label51 = new Label();
    this.TextBox29 = new TextBox();
    this.TextBox30 = new TextBox();
    this.TextBox31 = new TextBox();
    this.TextBox32 = new TextBox();
    this.txtEXTRA_POLICY_NO = new TextBox();
    this.txtEXTRA_POLICY_EFF = new TextBox();
    this.txtEXTRA_POLICY_EXP = new TextBox();
    this.Label54 = new Label();
    this.Label56 = new Label();
    this.txtEXTRA_DESCRIPTION = new TextBox();
    this.Label57 = new Label();
    this.Label58 = new Label();
    this.Label59 = new Label();
    this.Label60 = new Label();
    this.Label61 = new Label();
    this.Label64 = new Label();
    this.Label66 = new Label();
    this.Label78 = new Label();
    this.Label79 = new Label();
    this.Label80 = new Label();
    this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC = new TextBox();
    this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED = new TextBox();
    this.txtCOMMERCIAL_GL_LIMIT_MED_EXP = new TextBox();
    this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY = new TextBox();
    this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG = new TextBox();
    this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG = new TextBox();
    this.txtBA_COMBINED_SINGLE_LIMIT = new TextBox();
    this.txtBA_BODILY_INJURY_PER_PERSON = new TextBox();
    this.txtBA_BODILY_INJURY_PER_ACCIDENT = new TextBox();
    this.txtBA_PROPERTY_DAMAGE = new TextBox();
    this.TextBox48 = new TextBox();
    this.txtWC_OTHER_LIMIT_AMT = new TextBox();
    this.txtWC_EACH_ACCIDENT = new TextBox();
    this.txtWC_DISEASE_EACH_EMPLOYEE = new TextBox();
    this.txtFooter_Cancellation = new TextBox();
    this.Label15 = new Label();
    this.label10 = new Label();
    this.label31 = new Label();
    this.label32 = new Label();
    this.label33 = new Label();
    this.Label22 = new Label();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label11 = new Label();
    this.Label17 = new Label();
    this.Label16 = new Label();
    this.Label18 = new Label();
    this.Label19 = new Label();
    this.Label20 = new Label();
    this.Label21 = new Label();
    this.txtINSURER_A = new TextBox();
    this.txtINSURER_B = new TextBox();
    this.txtINSURER_C = new TextBox();
    this.txtINSURER_D = new TextBox();
    this.txtINSURER_A_NAIC = new TextBox();
    this.txtINSURER_B_NAIC = new TextBox();
    this.txtINSURER_C_NAIC = new TextBox();
    this.txtINSURER_D_NAIC = new TextBox();
    this.Label26 = new Label();
    this.Label24 = new Label();
    this.Label25 = new Label();
    this.Label27 = new Label();
    this.Label29 = new Label();
    this.Label30 = new Label();
    this.Label37 = new Label();
    this.label9 = new Label();
    this.label38 = new Label();
    this.txtHPRODUCEREMAIL = new TextBox();
    this.txtHeader_ProducerContactFax = new TextBox();
    this.Label55 = new Label();
    this.Label81 = new Label();
    this.txtCertificateHolder = new TextBox();
    this.txtWC_DISEASE_POLICY = new TextBox();
    this.Picture1 = new Picture();
    this.Label84 = new Label();
    this.Label47 = new Label();
    this.Label53 = new Label();
    this.label49 = new Label();
    this.txtINSURER_E = new TextBox();
    this.txtINSURER_E_NAIC = new TextBox();
    this.label86 = new Label();
    this.txtINSURER_F = new TextBox();
    this.txtINSURER_F_NAIC = new TextBox();
    this.label41 = new Label();
    this.label87 = new Label();
    this.label89 = new Label();
    this.label91 = new Label();
    this.label93 = new Label();
    this.label94 = new Label();
    this.label95 = new Label();
    this.label96 = new Label();
    this.label97 = new Label();
    this.label46 = new Label();
    this.label99 = new Label();
    this.shape29 = new Shape();
    this.shape30 = new Shape();
    this.label104 = new Label();
    this.label107 = new Label();
    this.shape33 = new Shape();
    this.label109 = new Label();
    this.txtUMBR_RETENTION_AMT = new Label();
    this.shape28 = new Shape();
    this.label112 = new Label();
    this.label113 = new Label();
    this.label114 = new Label();
    this.txtUMBR_LIMIT_EACH_OCC = new TextBox();
    this.txtUMBR_LIMIT_GEN_AGG = new TextBox();
    this.textBox18 = new TextBox();
    this.textBox49 = new TextBox();
    this.textBox51 = new TextBox();
    this.label69 = new Label();
    this.label36 = new Label();
    this.label70 = new Label();
    this.label2 = new Label();
    this.label71 = new Label();
    this.label72 = new Label();
    this.label116 = new Label();
    this.label117 = new Label();
    this.label118 = new Label();
    this.label119 = new Label();
    this.label45 = new Label();
    this.label5 = new Label();
    this.txtPRODUCER = new TextBox();
    this.Label62 = new Label();
    this.TextBox43 = new TextBox();
    this.Label63 = new Label();
    this.Label170 = new Label();
    this.txtPRODUCERFAX = new TextBox();
    this.txtPRODUCERCONTACT = new TextBox();
    this.txtPRODUCERPHONE = new TextBox();
    this.label108 = new Label();
    this.textBox57 = new TextBox();
    this.textBox58 = new TextBox();
    this.txtDATEISSUED = new TextBox();
    this.lblINSURED_ID = new Label();
    this.lblPRODUCER_ID = new Label();
    this.txtPRODUCER_ID = new TextBox();
    this.txtINSURED_ID = new TextBox();
    this.txtCERTIFICATE_NUMBER = new TextBox();
    this.GL_LTR = new Label();
    this.BA_LTR = new Label();
    this.UMBR_LTR = new Label();
    this.WC_LTR = new Label();
    this.EXTRA_LTR = new Label();
    this.BA_NON_OWNED = new Label();
    this.BA_SCHEDULED = new Label();
    this.BA_OTHER_1 = new Label();
    this.BA_HIRED = new Label();
    this.BA_ALL_OWNED = new Label();
    this.BA_ANY = new Label();
    this.COMMERCIAL_GL_LIMIT_OTHER = new Label();
    this.COMMERCIAL_GL_LIMIT_LOC = new Label();
    this.COMMERCIAL_GL_LIMIT_PROJECT = new Label();
    this.COMMERCIAL_GL_LIMIT_POLICY = new Label();
    this.COMMERCIAL_GL_OTHER_2 = new Label();
    this.COMMERCIAL_GL_OTHER_1 = new Label();
    this.COMMERCIAL_GL_OCCUR = new Label();
    this.COMMERCIAL_GL_CLAIMS_MADE = new Label();
    this.WC_OTHER_LIMIT = new Label();
    this.WC_STATUTORY_LIMIT = new Label();
    this.WC_ANY_EXCLUDED = new Label();
    this.UMBR_RETENTION = new Label();
    this.UMBR_DEDUCTIBLE = new Label();
    this.UMBR_CLAIMS_MADE = new Label();
    this.UMBR_EXCESS_LIAB = new Label();
    this.UMBR_OCCUR = new Label();
    this.UMBR_LIAB = new Label();
    this.BA_OTHER_2 = new Label();
    this.COMMERCIAL_GL_ADDL_INSURED = new Label();
    this.COMMERCIAL_GL_SUBR_WVD = new Label();
    this.EXTRA_ADDL_INSURED = new Label();
    this.UMBR_ADDL_INSURED = new Label();
    this.BA_ADDL_INSURED = new Label();
    this.EXTRA_SUBR_WVD = new Label();
    this.UMBR_SUBR_WVD = new Label();
    this.BA_SUBR_WVD = new Label();
    this.WC_SUBR_WVD = new Label();
    this.txtEXTRA_LIMIT_MESSAGE = new TextBox();
    this.Label34 = new Label();
    this.label50 = new Label();
    this.Label6 = new Label();
    this.Label23 = new Label();
    this.Label43 = new Label();
    this.Label73 = new Label();
    this.Label76 = new Label();
    this.Label82 = new Label();
    this.Label88 = new Label();
    this.Label90 = new Label();
    this.Label28 = new Label();
    this.Label44 = new Label();
    this.Label67 = new Label();
    this.Label68 = new Label();
    this.Label75 = new Label();
    this.Label77 = new Label();
    this.Label100 = new Label();
    this.Label101 = new Label();
    this.Label103 = new Label();
    this.Label105 = new Label();
    this.Label110 = new Label();
    this.Label120 = new Label();
    this.Label121 = new Label();
    this.Label122 = new Label();
    this.Label123 = new Label();
    this.Label124 = new Label();
    this.Label126 = new Label();
    this.Label127 = new Label();
    this.Label128 = new Label();
    this.Label65 = new Label();
    this.Label83 = new Label();
    this.Label125 = new Label();
    this.Label129 = new Label();
    this.Label130 = new Label();
    this.Label131 = new Label();
    this.Label132 = new Label();
    this.Label135 = new Label();
    this.Label136 = new Label();
    this.Label111 = new Label();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.Label8 = new Label();
    this.Label39 = new Label();
    this.Label40 = new Label();
    this.Shape1 = new Shape();
    ((ISupportInitialize) this.txtDESCRIPTION_OF_OPERATIONS).BeginInit();
    ((ISupportInitialize) this.txtBA_POLICY_NO).BeginInit();
    ((ISupportInitialize) this.TextBox28).BeginInit();
    ((ISupportInitialize) this.label102).BeginInit();
    ((ISupportInitialize) this.label106).BeginInit();
    ((ISupportInitialize) this.label35).BeginInit();
    ((ISupportInitialize) this.label52).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.label85).BeginInit();
    ((ISupportInitialize) this.label92).BeginInit();
    ((ISupportInitialize) this.label74).BeginInit();
    ((ISupportInitialize) this.label98).BeginInit();
    ((ISupportInitialize) this.txtINSURED).BeginInit();
    ((ISupportInitialize) this.Picture).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_POLICY_EXP).BeginInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_POLICY_NO).BeginInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_POLICY_EFF).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label42).BeginInit();
    ((ISupportInitialize) this.txtBA_POLICY_EFF).BeginInit();
    ((ISupportInitialize) this.txtBA_POLICY_EXP).BeginInit();
    ((ISupportInitialize) this.txtUMBR_POLICY_NO).BeginInit();
    ((ISupportInitialize) this.txtUMBR_POLICY_EFF).BeginInit();
    ((ISupportInitialize) this.txtUMBR_POLICY_EXP).BeginInit();
    ((ISupportInitialize) this.Label48).BeginInit();
    ((ISupportInitialize) this.txtWC_POLICY_NO).BeginInit();
    ((ISupportInitialize) this.txtWC_POLICY_EFF).BeginInit();
    ((ISupportInitialize) this.txtWC_POLICY_EXP).BeginInit();
    ((ISupportInitialize) this.Label51).BeginInit();
    ((ISupportInitialize) this.TextBox29).BeginInit();
    ((ISupportInitialize) this.TextBox30).BeginInit();
    ((ISupportInitialize) this.TextBox31).BeginInit();
    ((ISupportInitialize) this.TextBox32).BeginInit();
    ((ISupportInitialize) this.txtEXTRA_POLICY_NO).BeginInit();
    ((ISupportInitialize) this.txtEXTRA_POLICY_EFF).BeginInit();
    ((ISupportInitialize) this.txtEXTRA_POLICY_EXP).BeginInit();
    ((ISupportInitialize) this.Label54).BeginInit();
    ((ISupportInitialize) this.Label56).BeginInit();
    ((ISupportInitialize) this.txtEXTRA_DESCRIPTION).BeginInit();
    ((ISupportInitialize) this.Label57).BeginInit();
    ((ISupportInitialize) this.Label58).BeginInit();
    ((ISupportInitialize) this.Label59).BeginInit();
    ((ISupportInitialize) this.Label60).BeginInit();
    ((ISupportInitialize) this.Label61).BeginInit();
    ((ISupportInitialize) this.Label64).BeginInit();
    ((ISupportInitialize) this.Label66).BeginInit();
    ((ISupportInitialize) this.Label78).BeginInit();
    ((ISupportInitialize) this.Label79).BeginInit();
    ((ISupportInitialize) this.Label80).BeginInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC).BeginInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED).BeginInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_LIMIT_MED_EXP).BeginInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY).BeginInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG).BeginInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG).BeginInit();
    ((ISupportInitialize) this.txtBA_COMBINED_SINGLE_LIMIT).BeginInit();
    ((ISupportInitialize) this.txtBA_BODILY_INJURY_PER_PERSON).BeginInit();
    ((ISupportInitialize) this.txtBA_BODILY_INJURY_PER_ACCIDENT).BeginInit();
    ((ISupportInitialize) this.txtBA_PROPERTY_DAMAGE).BeginInit();
    ((ISupportInitialize) this.TextBox48).BeginInit();
    ((ISupportInitialize) this.txtWC_OTHER_LIMIT_AMT).BeginInit();
    ((ISupportInitialize) this.txtWC_EACH_ACCIDENT).BeginInit();
    ((ISupportInitialize) this.txtWC_DISEASE_EACH_EMPLOYEE).BeginInit();
    ((ISupportInitialize) this.txtFooter_Cancellation).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.label10).BeginInit();
    ((ISupportInitialize) this.label31).BeginInit();
    ((ISupportInitialize) this.label32).BeginInit();
    ((ISupportInitialize) this.label33).BeginInit();
    ((ISupportInitialize) this.Label22).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.Label19).BeginInit();
    ((ISupportInitialize) this.Label20).BeginInit();
    ((ISupportInitialize) this.Label21).BeginInit();
    ((ISupportInitialize) this.txtINSURER_A).BeginInit();
    ((ISupportInitialize) this.txtINSURER_B).BeginInit();
    ((ISupportInitialize) this.txtINSURER_C).BeginInit();
    ((ISupportInitialize) this.txtINSURER_D).BeginInit();
    ((ISupportInitialize) this.txtINSURER_A_NAIC).BeginInit();
    ((ISupportInitialize) this.txtINSURER_B_NAIC).BeginInit();
    ((ISupportInitialize) this.txtINSURER_C_NAIC).BeginInit();
    ((ISupportInitialize) this.txtINSURER_D_NAIC).BeginInit();
    ((ISupportInitialize) this.Label26).BeginInit();
    ((ISupportInitialize) this.Label24).BeginInit();
    ((ISupportInitialize) this.Label25).BeginInit();
    ((ISupportInitialize) this.Label27).BeginInit();
    ((ISupportInitialize) this.Label29).BeginInit();
    ((ISupportInitialize) this.Label30).BeginInit();
    ((ISupportInitialize) this.Label37).BeginInit();
    ((ISupportInitialize) this.label9).BeginInit();
    ((ISupportInitialize) this.label38).BeginInit();
    ((ISupportInitialize) this.txtHPRODUCEREMAIL).BeginInit();
    ((ISupportInitialize) this.txtHeader_ProducerContactFax).BeginInit();
    ((ISupportInitialize) this.Label55).BeginInit();
    ((ISupportInitialize) this.Label81).BeginInit();
    ((ISupportInitialize) this.txtCertificateHolder).BeginInit();
    ((ISupportInitialize) this.txtWC_DISEASE_POLICY).BeginInit();
    ((ISupportInitialize) this.Picture1).BeginInit();
    ((ISupportInitialize) this.Label84).BeginInit();
    ((ISupportInitialize) this.Label47).BeginInit();
    ((ISupportInitialize) this.Label53).BeginInit();
    ((ISupportInitialize) this.label49).BeginInit();
    ((ISupportInitialize) this.txtINSURER_E).BeginInit();
    ((ISupportInitialize) this.txtINSURER_E_NAIC).BeginInit();
    ((ISupportInitialize) this.label86).BeginInit();
    ((ISupportInitialize) this.txtINSURER_F).BeginInit();
    ((ISupportInitialize) this.txtINSURER_F_NAIC).BeginInit();
    ((ISupportInitialize) this.label41).BeginInit();
    ((ISupportInitialize) this.label87).BeginInit();
    ((ISupportInitialize) this.label89).BeginInit();
    ((ISupportInitialize) this.label91).BeginInit();
    ((ISupportInitialize) this.label93).BeginInit();
    ((ISupportInitialize) this.label94).BeginInit();
    ((ISupportInitialize) this.label95).BeginInit();
    ((ISupportInitialize) this.label96).BeginInit();
    ((ISupportInitialize) this.label97).BeginInit();
    ((ISupportInitialize) this.label46).BeginInit();
    ((ISupportInitialize) this.label99).BeginInit();
    ((ISupportInitialize) this.label104).BeginInit();
    ((ISupportInitialize) this.label107).BeginInit();
    ((ISupportInitialize) this.label109).BeginInit();
    ((ISupportInitialize) this.txtUMBR_RETENTION_AMT).BeginInit();
    ((ISupportInitialize) this.label112).BeginInit();
    ((ISupportInitialize) this.label113).BeginInit();
    ((ISupportInitialize) this.label114).BeginInit();
    ((ISupportInitialize) this.txtUMBR_LIMIT_EACH_OCC).BeginInit();
    ((ISupportInitialize) this.txtUMBR_LIMIT_GEN_AGG).BeginInit();
    ((ISupportInitialize) this.textBox18).BeginInit();
    ((ISupportInitialize) this.textBox49).BeginInit();
    ((ISupportInitialize) this.textBox51).BeginInit();
    ((ISupportInitialize) this.label69).BeginInit();
    ((ISupportInitialize) this.label36).BeginInit();
    ((ISupportInitialize) this.label70).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.label71).BeginInit();
    ((ISupportInitialize) this.label72).BeginInit();
    ((ISupportInitialize) this.label116).BeginInit();
    ((ISupportInitialize) this.label117).BeginInit();
    ((ISupportInitialize) this.label118).BeginInit();
    ((ISupportInitialize) this.label119).BeginInit();
    ((ISupportInitialize) this.label45).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.txtPRODUCER).BeginInit();
    ((ISupportInitialize) this.Label62).BeginInit();
    ((ISupportInitialize) this.TextBox43).BeginInit();
    ((ISupportInitialize) this.Label63).BeginInit();
    ((ISupportInitialize) this.Label170).BeginInit();
    ((ISupportInitialize) this.txtPRODUCERFAX).BeginInit();
    ((ISupportInitialize) this.txtPRODUCERCONTACT).BeginInit();
    ((ISupportInitialize) this.txtPRODUCERPHONE).BeginInit();
    ((ISupportInitialize) this.label108).BeginInit();
    ((ISupportInitialize) this.textBox57).BeginInit();
    ((ISupportInitialize) this.textBox58).BeginInit();
    ((ISupportInitialize) this.txtDATEISSUED).BeginInit();
    ((ISupportInitialize) this.lblINSURED_ID).BeginInit();
    ((ISupportInitialize) this.lblPRODUCER_ID).BeginInit();
    ((ISupportInitialize) this.txtPRODUCER_ID).BeginInit();
    ((ISupportInitialize) this.txtINSURED_ID).BeginInit();
    ((ISupportInitialize) this.txtCERTIFICATE_NUMBER).BeginInit();
    ((ISupportInitialize) this.GL_LTR).BeginInit();
    ((ISupportInitialize) this.BA_LTR).BeginInit();
    ((ISupportInitialize) this.UMBR_LTR).BeginInit();
    ((ISupportInitialize) this.WC_LTR).BeginInit();
    ((ISupportInitialize) this.EXTRA_LTR).BeginInit();
    ((ISupportInitialize) this.BA_NON_OWNED).BeginInit();
    ((ISupportInitialize) this.BA_SCHEDULED).BeginInit();
    ((ISupportInitialize) this.BA_OTHER_1).BeginInit();
    ((ISupportInitialize) this.BA_HIRED).BeginInit();
    ((ISupportInitialize) this.BA_ALL_OWNED).BeginInit();
    ((ISupportInitialize) this.BA_ANY).BeginInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_LIMIT_OTHER).BeginInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_LIMIT_LOC).BeginInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_LIMIT_PROJECT).BeginInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_LIMIT_POLICY).BeginInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_OTHER_2).BeginInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_OTHER_1).BeginInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_OCCUR).BeginInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_CLAIMS_MADE).BeginInit();
    ((ISupportInitialize) this.WC_OTHER_LIMIT).BeginInit();
    ((ISupportInitialize) this.WC_STATUTORY_LIMIT).BeginInit();
    ((ISupportInitialize) this.WC_ANY_EXCLUDED).BeginInit();
    ((ISupportInitialize) this.UMBR_RETENTION).BeginInit();
    ((ISupportInitialize) this.UMBR_DEDUCTIBLE).BeginInit();
    ((ISupportInitialize) this.UMBR_CLAIMS_MADE).BeginInit();
    ((ISupportInitialize) this.UMBR_EXCESS_LIAB).BeginInit();
    ((ISupportInitialize) this.UMBR_OCCUR).BeginInit();
    ((ISupportInitialize) this.UMBR_LIAB).BeginInit();
    ((ISupportInitialize) this.BA_OTHER_2).BeginInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_ADDL_INSURED).BeginInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_SUBR_WVD).BeginInit();
    ((ISupportInitialize) this.EXTRA_ADDL_INSURED).BeginInit();
    ((ISupportInitialize) this.UMBR_ADDL_INSURED).BeginInit();
    ((ISupportInitialize) this.BA_ADDL_INSURED).BeginInit();
    ((ISupportInitialize) this.EXTRA_SUBR_WVD).BeginInit();
    ((ISupportInitialize) this.UMBR_SUBR_WVD).BeginInit();
    ((ISupportInitialize) this.BA_SUBR_WVD).BeginInit();
    ((ISupportInitialize) this.WC_SUBR_WVD).BeginInit();
    ((ISupportInitialize) this.txtEXTRA_LIMIT_MESSAGE).BeginInit();
    ((ISupportInitialize) this.Label34).BeginInit();
    ((ISupportInitialize) this.label50).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label23).BeginInit();
    ((ISupportInitialize) this.Label43).BeginInit();
    ((ISupportInitialize) this.Label73).BeginInit();
    ((ISupportInitialize) this.Label76).BeginInit();
    ((ISupportInitialize) this.Label82).BeginInit();
    ((ISupportInitialize) this.Label88).BeginInit();
    ((ISupportInitialize) this.Label90).BeginInit();
    ((ISupportInitialize) this.Label28).BeginInit();
    ((ISupportInitialize) this.Label44).BeginInit();
    ((ISupportInitialize) this.Label67).BeginInit();
    ((ISupportInitialize) this.Label68).BeginInit();
    ((ISupportInitialize) this.Label75).BeginInit();
    ((ISupportInitialize) this.Label77).BeginInit();
    ((ISupportInitialize) this.Label100).BeginInit();
    ((ISupportInitialize) this.Label101).BeginInit();
    ((ISupportInitialize) this.Label103).BeginInit();
    ((ISupportInitialize) this.Label105).BeginInit();
    ((ISupportInitialize) this.Label110).BeginInit();
    ((ISupportInitialize) this.Label120).BeginInit();
    ((ISupportInitialize) this.Label121).BeginInit();
    ((ISupportInitialize) this.Label122).BeginInit();
    ((ISupportInitialize) this.Label123).BeginInit();
    ((ISupportInitialize) this.Label124).BeginInit();
    ((ISupportInitialize) this.Label126).BeginInit();
    ((ISupportInitialize) this.Label127).BeginInit();
    ((ISupportInitialize) this.Label128).BeginInit();
    ((ISupportInitialize) this.Label65).BeginInit();
    ((ISupportInitialize) this.Label83).BeginInit();
    ((ISupportInitialize) this.Label125).BeginInit();
    ((ISupportInitialize) this.Label129).BeginInit();
    ((ISupportInitialize) this.Label130).BeginInit();
    ((ISupportInitialize) this.Label131).BeginInit();
    ((ISupportInitialize) this.Label132).BeginInit();
    ((ISupportInitialize) this.Label135).BeginInit();
    ((ISupportInitialize) this.Label136).BeginInit();
    ((ISupportInitialize) this.Label111).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label39).BeginInit();
    ((ISupportInitialize) this.Label40).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.Detail).Controls.AddRange(new ARControl[252]
    {
      (ARControl) this.shape9,
      (ARControl) this.txtDESCRIPTION_OF_OPERATIONS,
      (ARControl) this.txtBA_POLICY_NO,
      (ARControl) this.TextBox28,
      (ARControl) this.label102,
      (ARControl) this.label106,
      (ARControl) this.label35,
      (ARControl) this.label52,
      (ARControl) this.shape15,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.label85,
      (ARControl) this.label92,
      (ARControl) this.label74,
      (ARControl) this.label98,
      (ARControl) this.txtINSURED,
      (ARControl) this.Picture,
      (ARControl) this.Label12,
      (ARControl) this.txtCOMMERCIAL_GL_POLICY_EXP,
      (ARControl) this.txtCOMMERCIAL_GL_POLICY_NO,
      (ARControl) this.txtCOMMERCIAL_GL_POLICY_EFF,
      (ARControl) this.Label7,
      (ARControl) this.Label42,
      (ARControl) this.txtBA_POLICY_EFF,
      (ARControl) this.txtBA_POLICY_EXP,
      (ARControl) this.txtUMBR_POLICY_NO,
      (ARControl) this.txtUMBR_POLICY_EFF,
      (ARControl) this.txtUMBR_POLICY_EXP,
      (ARControl) this.Label48,
      (ARControl) this.txtWC_POLICY_NO,
      (ARControl) this.txtWC_POLICY_EFF,
      (ARControl) this.txtWC_POLICY_EXP,
      (ARControl) this.Label51,
      (ARControl) this.TextBox29,
      (ARControl) this.TextBox30,
      (ARControl) this.TextBox31,
      (ARControl) this.TextBox32,
      (ARControl) this.txtEXTRA_POLICY_NO,
      (ARControl) this.txtEXTRA_POLICY_EFF,
      (ARControl) this.txtEXTRA_POLICY_EXP,
      (ARControl) this.Label54,
      (ARControl) this.Label56,
      (ARControl) this.txtEXTRA_DESCRIPTION,
      (ARControl) this.Label57,
      (ARControl) this.Label58,
      (ARControl) this.Label59,
      (ARControl) this.Label60,
      (ARControl) this.Label61,
      (ARControl) this.Label64,
      (ARControl) this.Label66,
      (ARControl) this.Label78,
      (ARControl) this.Label79,
      (ARControl) this.Label80,
      (ARControl) this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC,
      (ARControl) this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED,
      (ARControl) this.txtCOMMERCIAL_GL_LIMIT_MED_EXP,
      (ARControl) this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY,
      (ARControl) this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG,
      (ARControl) this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG,
      (ARControl) this.txtBA_COMBINED_SINGLE_LIMIT,
      (ARControl) this.txtBA_BODILY_INJURY_PER_PERSON,
      (ARControl) this.txtBA_BODILY_INJURY_PER_ACCIDENT,
      (ARControl) this.txtBA_PROPERTY_DAMAGE,
      (ARControl) this.TextBox48,
      (ARControl) this.txtWC_OTHER_LIMIT_AMT,
      (ARControl) this.txtWC_EACH_ACCIDENT,
      (ARControl) this.txtWC_DISEASE_EACH_EMPLOYEE,
      (ARControl) this.txtFooter_Cancellation,
      (ARControl) this.Label15,
      (ARControl) this.label10,
      (ARControl) this.label31,
      (ARControl) this.label32,
      (ARControl) this.label33,
      (ARControl) this.Label22,
      (ARControl) this.Label1,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label11,
      (ARControl) this.Label17,
      (ARControl) this.Label16,
      (ARControl) this.Label18,
      (ARControl) this.Label19,
      (ARControl) this.Label20,
      (ARControl) this.Label21,
      (ARControl) this.txtINSURER_A,
      (ARControl) this.txtINSURER_B,
      (ARControl) this.txtINSURER_C,
      (ARControl) this.txtINSURER_D,
      (ARControl) this.txtINSURER_A_NAIC,
      (ARControl) this.txtINSURER_B_NAIC,
      (ARControl) this.txtINSURER_C_NAIC,
      (ARControl) this.txtINSURER_D_NAIC,
      (ARControl) this.Label26,
      (ARControl) this.Label24,
      (ARControl) this.Label25,
      (ARControl) this.Label27,
      (ARControl) this.Label29,
      (ARControl) this.Label30,
      (ARControl) this.Label37,
      (ARControl) this.label9,
      (ARControl) this.label38,
      (ARControl) this.txtHPRODUCEREMAIL,
      (ARControl) this.txtHeader_ProducerContactFax,
      (ARControl) this.Label55,
      (ARControl) this.Label81,
      (ARControl) this.txtCertificateHolder,
      (ARControl) this.txtWC_DISEASE_POLICY,
      (ARControl) this.Picture1,
      (ARControl) this.Label84,
      (ARControl) this.Label47,
      (ARControl) this.Label53,
      (ARControl) this.label49,
      (ARControl) this.txtINSURER_E,
      (ARControl) this.txtINSURER_E_NAIC,
      (ARControl) this.label86,
      (ARControl) this.txtINSURER_F,
      (ARControl) this.txtINSURER_F_NAIC,
      (ARControl) this.label41,
      (ARControl) this.label87,
      (ARControl) this.label89,
      (ARControl) this.label91,
      (ARControl) this.label93,
      (ARControl) this.label94,
      (ARControl) this.label95,
      (ARControl) this.label96,
      (ARControl) this.label97,
      (ARControl) this.label46,
      (ARControl) this.label99,
      (ARControl) this.shape29,
      (ARControl) this.shape30,
      (ARControl) this.label104,
      (ARControl) this.label107,
      (ARControl) this.shape33,
      (ARControl) this.label109,
      (ARControl) this.txtUMBR_RETENTION_AMT,
      (ARControl) this.shape28,
      (ARControl) this.label112,
      (ARControl) this.label113,
      (ARControl) this.label114,
      (ARControl) this.txtUMBR_LIMIT_EACH_OCC,
      (ARControl) this.txtUMBR_LIMIT_GEN_AGG,
      (ARControl) this.textBox18,
      (ARControl) this.textBox49,
      (ARControl) this.textBox51,
      (ARControl) this.label69,
      (ARControl) this.label36,
      (ARControl) this.label70,
      (ARControl) this.label2,
      (ARControl) this.label71,
      (ARControl) this.label72,
      (ARControl) this.label116,
      (ARControl) this.label117,
      (ARControl) this.label118,
      (ARControl) this.label119,
      (ARControl) this.label45,
      (ARControl) this.label5,
      (ARControl) this.txtPRODUCER,
      (ARControl) this.Label62,
      (ARControl) this.TextBox43,
      (ARControl) this.Label63,
      (ARControl) this.Label170,
      (ARControl) this.txtPRODUCERFAX,
      (ARControl) this.txtPRODUCERCONTACT,
      (ARControl) this.txtPRODUCERPHONE,
      (ARControl) this.label108,
      (ARControl) this.textBox57,
      (ARControl) this.textBox58,
      (ARControl) this.txtDATEISSUED,
      (ARControl) this.lblINSURED_ID,
      (ARControl) this.lblPRODUCER_ID,
      (ARControl) this.txtPRODUCER_ID,
      (ARControl) this.txtINSURED_ID,
      (ARControl) this.txtCERTIFICATE_NUMBER,
      (ARControl) this.GL_LTR,
      (ARControl) this.BA_LTR,
      (ARControl) this.UMBR_LTR,
      (ARControl) this.WC_LTR,
      (ARControl) this.EXTRA_LTR,
      (ARControl) this.BA_NON_OWNED,
      (ARControl) this.BA_SCHEDULED,
      (ARControl) this.BA_OTHER_1,
      (ARControl) this.BA_HIRED,
      (ARControl) this.BA_ALL_OWNED,
      (ARControl) this.BA_ANY,
      (ARControl) this.COMMERCIAL_GL_LIMIT_OTHER,
      (ARControl) this.COMMERCIAL_GL_LIMIT_LOC,
      (ARControl) this.COMMERCIAL_GL_LIMIT_PROJECT,
      (ARControl) this.COMMERCIAL_GL_LIMIT_POLICY,
      (ARControl) this.COMMERCIAL_GL_OTHER_2,
      (ARControl) this.COMMERCIAL_GL_OTHER_1,
      (ARControl) this.COMMERCIAL_GL_OCCUR,
      (ARControl) this.COMMERCIAL_GL_CLAIMS_MADE,
      (ARControl) this.WC_OTHER_LIMIT,
      (ARControl) this.WC_STATUTORY_LIMIT,
      (ARControl) this.WC_ANY_EXCLUDED,
      (ARControl) this.UMBR_RETENTION,
      (ARControl) this.UMBR_DEDUCTIBLE,
      (ARControl) this.UMBR_CLAIMS_MADE,
      (ARControl) this.UMBR_EXCESS_LIAB,
      (ARControl) this.UMBR_OCCUR,
      (ARControl) this.UMBR_LIAB,
      (ARControl) this.BA_OTHER_2,
      (ARControl) this.COMMERCIAL_GL_ADDL_INSURED,
      (ARControl) this.COMMERCIAL_GL_SUBR_WVD,
      (ARControl) this.EXTRA_ADDL_INSURED,
      (ARControl) this.UMBR_ADDL_INSURED,
      (ARControl) this.BA_ADDL_INSURED,
      (ARControl) this.EXTRA_SUBR_WVD,
      (ARControl) this.UMBR_SUBR_WVD,
      (ARControl) this.BA_SUBR_WVD,
      (ARControl) this.WC_SUBR_WVD,
      (ARControl) this.txtEXTRA_LIMIT_MESSAGE,
      (ARControl) this.Label34,
      (ARControl) this.label50,
      (ARControl) this.Label6,
      (ARControl) this.Label23,
      (ARControl) this.Label43,
      (ARControl) this.Label73,
      (ARControl) this.Label76,
      (ARControl) this.Label82,
      (ARControl) this.Shape1,
      (ARControl) this.Label88,
      (ARControl) this.Label90,
      (ARControl) this.Label28,
      (ARControl) this.Label44,
      (ARControl) this.Label67,
      (ARControl) this.Label68,
      (ARControl) this.Label75,
      (ARControl) this.Label77,
      (ARControl) this.Label100,
      (ARControl) this.Label101,
      (ARControl) this.Label103,
      (ARControl) this.Label105,
      (ARControl) this.Label110,
      (ARControl) this.Label120,
      (ARControl) this.Label121,
      (ARControl) this.Label122,
      (ARControl) this.Label123,
      (ARControl) this.Label124,
      (ARControl) this.Label126,
      (ARControl) this.Label127,
      (ARControl) this.Label128,
      (ARControl) this.Label65,
      (ARControl) this.Label83,
      (ARControl) this.Label125,
      (ARControl) this.Label129,
      (ARControl) this.Label130,
      (ARControl) this.Label131,
      (ARControl) this.Label132,
      (ARControl) this.Label135,
      (ARControl) this.Label136,
      (ARControl) this.Label111
    });
    ((Section) this.Detail).Height = 10.156f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.shape9).Height = 0.8749994f;
    ((ARControl) this.shape9).Left = 1f / 500f;
    ((ARControl) this.shape9).Name = "shape9";
    this.shape9.RoundingRadius = new CornersRadius(new float?(10f), new float?(), new float?(), new float?(), new float?());
    ((ARControl) this.shape9).Top = 8.187f;
    ((ARControl) this.shape9).Width = 7.995f;
    ((ARControl) this.txtDESCRIPTION_OF_OPERATIONS).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDESCRIPTION_OF_OPERATIONS).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDESCRIPTION_OF_OPERATIONS).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDESCRIPTION_OF_OPERATIONS).Border.TopStyle = (BorderLineStyle) 1;
    this.txtDESCRIPTION_OF_OPERATIONS.CanGrow = false;
    ((ARControl) this.txtDESCRIPTION_OF_OPERATIONS).Height = 0.7499998f;
    ((ARControl) this.txtDESCRIPTION_OF_OPERATIONS).Left = 0.0f;
    ((ARControl) this.txtDESCRIPTION_OF_OPERATIONS).Name = "txtDESCRIPTION_OF_OPERATIONS";
    this.txtDESCRIPTION_OF_OPERATIONS.Style = "font-family: Arial; font-size: 9pt; text-align: left; ddo-char-set: 0";
    this.txtDESCRIPTION_OF_OPERATIONS.Text = " ";
    ((ARControl) this.txtDESCRIPTION_OF_OPERATIONS).Top = 8.312f;
    ((ARControl) this.txtDESCRIPTION_OF_OPERATIONS).Width = 8f;
    ((ARControl) this.txtBA_POLICY_NO).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_POLICY_NO).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_POLICY_NO).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_POLICY_NO).Border.TopStyle = (BorderLineStyle) 1;
    this.txtBA_POLICY_NO.CanGrow = false;
    ((ARControl) this.txtBA_POLICY_NO).Height = 0.9369999f;
    ((ARControl) this.txtBA_POLICY_NO).Left = 2.687f;
    ((ARControl) this.txtBA_POLICY_NO).Name = "txtBA_POLICY_NO";
    this.txtBA_POLICY_NO.Style = "font-size: 9pt; text-align: center";
    this.txtBA_POLICY_NO.Text = " ";
    ((ARControl) this.txtBA_POLICY_NO).Top = 5.437f;
    ((ARControl) this.txtBA_POLICY_NO).Width = 1.624f;
    this.TextBox28.CanGrow = false;
    ((ARControl) this.TextBox28).Height = 0.2500002f;
    ((ARControl) this.TextBox28).Left = 0.25f;
    this.TextBox28.MultiLine = false;
    ((ARControl) this.TextBox28).Name = "TextBox28";
    this.TextBox28.Style = "font-size: 6pt; font-weight: bold; text-align: left; vertical-align: middle; white-space: nowrap; ddo-char-set: 1; ddo-wrap-mode: nowrap";
    this.TextBox28.Text = "WORKERS COMPENSATION";
    ((ARControl) this.TextBox28).Top = 6.875f;
    ((ARControl) this.TextBox28).Width = 1.209f;
    ((ARControl) this.label102).Height = 0.187f;
    this.label102.HyperLink = (string) null;
    ((ARControl) this.label102).Left = 0.437f;
    ((ARControl) this.label102).Name = "label102";
    this.label102.Style = "font-size: 6pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.label102.Text = "UMBRELLA LIAB";
    ((ARControl) this.label102).Top = 6.375f;
    ((ARControl) this.label102).Width = 0.75f;
    ((ARControl) this.label106).Height = 0.1880004f;
    this.label106.HyperLink = (string) null;
    ((ARControl) this.label106).Left = 0.4370003f;
    ((ARControl) this.label106).Name = "label106";
    this.label106.Style = "font-size: 6pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.label106.Text = "EXCESS LIAB";
    ((ARControl) this.label106).Top = 6.562f;
    ((ARControl) this.label106).Width = 0.7499997f;
    ((ARControl) this.label35).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label35).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label35).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label35).Border.TopStyle = (BorderLineStyle) 1;
    this.label35.CharacterSpacing = 0.5f;
    ((ARControl) this.label35).Height = 0.564f;
    this.label35.HyperLink = (string) null;
    ((ARControl) this.label35).Left = 0.0f;
    ((ARControl) this.label35).Name = "label35";
    this.label35.Style = "font-size: 8.25pt; font-weight: bold; text-align: justify; text-justify: distribute; ddo-char-set: 0";
    this.label35.Text = "";
    ((ARControl) this.label35).Top = 0.437f;
    ((ARControl) this.label35).Width = 8f;
    ((ARControl) this.label52).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label52).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label52).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label52).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label52).Height = 0.1869999f;
    this.label52.HyperLink = (string) null;
    ((ARControl) this.label52).Left = 6f;
    ((ARControl) this.label52).Name = "label52";
    this.label52.Style = "font-size: 6pt; font-weight: bold; vertical-align: middle; white-space: nowrap; ddo-char-set: 0; ddo-wrap-mode: nowrap";
    this.label52.Text = "FAX (A/C, No, Ext):";
    ((ARControl) this.label52).Top = 1.625f;
    ((ARControl) this.label52).Width = 0.9369998f;
    ((ARControl) this.shape15).Height = 0.209f;
    ((ARControl) this.shape15).Left = 5.625001f;
    ((ARControl) this.shape15).Name = "shape15";
    this.shape15.RoundingRadius = new CornersRadius(new float?(10f), new float?(), new float?(), new float?(), new float?());
    ((ARControl) this.shape15).Top = 5.437f;
    ((ARControl) this.shape15).Width = 1.25f;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 0.06f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-size: 8.5pt; font-weight: bold; ddo-char-set: 1";
    this.Label13.Text = "CERTIFICATE HOLDER";
    ((ARControl) this.Label13).Top = 9.062f;
    ((ARControl) this.Label13).Width = 1.627f;
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Height = 3f / 16f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 4.062f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "font-size: 8.5pt; font-weight: bold; ddo-char-set: 1";
    this.Label14.Text = "CANCELLATION";
    ((ARControl) this.Label14).Top = 9.062f;
    ((ARControl) this.Label14).Width = 1.26025f;
    ((ARControl) this.label85).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label85).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label85).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label85).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label85).Height = 0.436f;
    this.label85.HyperLink = (string) null;
    ((ARControl) this.label85).Left = 0.0f;
    ((ARControl) this.label85).Name = "label85";
    this.label85.Style = "font-size: 8.25pt; font-weight: bold; text-align: left; ddo-char-set: 0";
    this.label85.Text = "";
    ((ARControl) this.label85).Top = 1.001f;
    ((ARControl) this.label85).Width = 8f;
    ((ARControl) this.label92).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label92).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label92).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label92).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label92).Height = 0.5f;
    this.label92.HyperLink = (string) null;
    ((ARControl) this.label92).Left = 0.0f;
    ((ARControl) this.label92).Name = "label92";
    this.label92.Style = "font-size: 8.25pt; font-weight: bold; text-align: left; ddo-char-set: 0";
    this.label92.Text = "";
    ((ARControl) this.label92).Top = 3.437f;
    ((ARControl) this.label92).Width = 8f;
    ((ARControl) this.label74).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label74).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label74).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label74).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label74).Height = 0.1869999f;
    this.label74.HyperLink = (string) null;
    ((ARControl) this.label74).Left = 4f;
    this.label74.MultiLine = false;
    ((ARControl) this.label74).Name = "label74";
    this.label74.Style = "font-size: 6pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label74.Text = "PHONE (A/C, No, Ext):";
    ((ARControl) this.label74).Top = 1.625f;
    ((ARControl) this.label74).Width = 0.9370003f;
    ((ARControl) this.label98).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label98).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label98).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label98).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label98).Height = 0.9369999f;
    this.label98.HyperLink = (string) null;
    ((ARControl) this.label98).Left = 0.25f;
    ((ARControl) this.label98).Name = "label98";
    this.label98.Style = "";
    this.label98.Text = "";
    ((ARControl) this.label98).Top = 5.437f;
    ((ARControl) this.label98).Width = 1.937f;
    ((ARControl) this.txtINSURED).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURED).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURED).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURED).Border.TopStyle = (BorderLineStyle) 1;
    this.txtINSURED.CanGrow = false;
    ((ARControl) this.txtINSURED).DataField = "INSURED";
    ((ARControl) this.txtINSURED).Height = 0.9370003f;
    ((ARControl) this.txtINSURED).Left = 0.0f;
    ((ARControl) this.txtINSURED).Name = "txtINSURED";
    this.txtINSURED.Padding = new PaddingEx(10, 10, 0, 0);
    this.txtINSURED.Style = "font-family: Arial; font-size: 9pt; text-align: left; ddo-char-set: 0";
    this.txtINSURED.Text = (string) null;
    ((ARControl) this.txtINSURED).Top = 2.375f;
    ((ARControl) this.txtINSURED).Width = 4f;
    ((ARControl) this.Picture).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Picture).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Picture).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Picture).DataField = "AUTHORIZED_REPRESENTATIVE_SIGNATURE";
    ((ARControl) this.Picture).Height = 0.5179996f;
    this.Picture.HyperLink = (string) null;
    this.Picture.ImageData = (Stream) null;
    ((ARControl) this.Picture).Left = 3.996f;
    this.Picture.LineColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    ((ARControl) this.Picture).Name = "Picture";
    this.Picture.SizeMode = (SizeModes) 2;
    ((ARControl) this.Picture).Top = 9.625f;
    ((ARControl) this.Picture).Width = 4f;
    ((ARControl) this.Label12).Height = 0.1879997f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 0.062f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-size: 6pt; font-weight: bold; ddo-char-set: 1";
    this.Label12.Text = "DESCRIPTION OF OPERATIONS / LOCATIONS / VEHICLES (Attach ACORD 101, Additional Remarks Schedule, if more space is required)";
    ((ARControl) this.Label12).Top = 8.187f;
    ((ARControl) this.Label12).Width = 7.742f;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EXP).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EXP).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EXP).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EXP).Border.TopStyle = (BorderLineStyle) 1;
    this.txtCOMMERCIAL_GL_POLICY_EXP.CanGrow = false;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EXP).Height = 1.312f;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EXP).Left = 5f;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EXP).Name = "txtCOMMERCIAL_GL_POLICY_EXP";
    this.txtCOMMERCIAL_GL_POLICY_EXP.OutputFormat = componentResourceManager.GetString("txtCOMMERCIAL_GL_POLICY_EXP.OutputFormat");
    this.txtCOMMERCIAL_GL_POLICY_EXP.Style = "font-size: 8.25pt; text-align: center; ddo-char-set: 0";
    this.txtCOMMERCIAL_GL_POLICY_EXP.Text = " ";
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EXP).Top = 4.125f;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EXP).Width = 0.6250005f;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_NO).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_NO).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_NO).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_NO).Border.TopStyle = (BorderLineStyle) 1;
    this.txtCOMMERCIAL_GL_POLICY_NO.CanGrow = false;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_NO).Height = 1.312f;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_NO).Left = 2.687f;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_NO).Name = "txtCOMMERCIAL_GL_POLICY_NO";
    this.txtCOMMERCIAL_GL_POLICY_NO.Style = "font-size: 9pt; text-align: center; vertical-align: top";
    this.txtCOMMERCIAL_GL_POLICY_NO.Text = " ";
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_NO).Top = 4.125f;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_NO).Width = 1.625f;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EFF).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EFF).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EFF).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EFF).Border.TopStyle = (BorderLineStyle) 1;
    this.txtCOMMERCIAL_GL_POLICY_EFF.CanGrow = false;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EFF).Height = 1.312f;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EFF).Left = 4.312f;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EFF).Name = "txtCOMMERCIAL_GL_POLICY_EFF";
    this.txtCOMMERCIAL_GL_POLICY_EFF.OutputFormat = componentResourceManager.GetString("txtCOMMERCIAL_GL_POLICY_EFF.OutputFormat");
    this.txtCOMMERCIAL_GL_POLICY_EFF.Style = "font-size: 8.25pt; text-align: center; ddo-char-set: 0";
    this.txtCOMMERCIAL_GL_POLICY_EFF.Text = " ";
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EFF).Top = 4.125f;
    ((ARControl) this.txtCOMMERCIAL_GL_POLICY_EFF).Width = 0.6879995f;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Height = 1.312f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 2.437f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "";
    this.Label7.Text = "";
    ((ARControl) this.Label7).Top = 4.125f;
    ((ARControl) this.Label7).Width = 0.25f;
    ((ARControl) this.Label42).Height = 0.1249999f;
    this.Label42.HyperLink = (string) null;
    ((ARControl) this.Label42).Left = 0.375f;
    ((ARControl) this.Label42).Name = "Label42";
    this.Label42.Style = "font-size: 6pt; font-weight: normal; text-align: center; text-decoration: none; vertical-align: middle; ddo-char-set: 1";
    this.Label42.Text = "GEN'L AGGREGATE LIMIT APPLIES PER:";
    ((ARControl) this.Label42).Top = 4.875f;
    ((ARControl) this.Label42).Width = 1.823f;
    ((ARControl) this.txtBA_POLICY_EFF).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_POLICY_EFF).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_POLICY_EFF).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_POLICY_EFF).Border.TopStyle = (BorderLineStyle) 1;
    this.txtBA_POLICY_EFF.CanGrow = false;
    ((ARControl) this.txtBA_POLICY_EFF).Height = 0.9369999f;
    ((ARControl) this.txtBA_POLICY_EFF).Left = 4.312f;
    ((ARControl) this.txtBA_POLICY_EFF).Name = "txtBA_POLICY_EFF";
    this.txtBA_POLICY_EFF.OutputFormat = componentResourceManager.GetString("txtBA_POLICY_EFF.OutputFormat");
    this.txtBA_POLICY_EFF.Style = "font-size: 8.25pt; text-align: center; ddo-char-set: 0";
    this.txtBA_POLICY_EFF.Text = " ";
    ((ARControl) this.txtBA_POLICY_EFF).Top = 5.437f;
    ((ARControl) this.txtBA_POLICY_EFF).Width = 0.6879995f;
    ((ARControl) this.txtBA_POLICY_EXP).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_POLICY_EXP).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_POLICY_EXP).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_POLICY_EXP).Border.TopStyle = (BorderLineStyle) 1;
    this.txtBA_POLICY_EXP.CanGrow = false;
    ((ARControl) this.txtBA_POLICY_EXP).Height = 0.9369999f;
    ((ARControl) this.txtBA_POLICY_EXP).Left = 5f;
    ((ARControl) this.txtBA_POLICY_EXP).Name = "txtBA_POLICY_EXP";
    this.txtBA_POLICY_EXP.OutputFormat = componentResourceManager.GetString("txtBA_POLICY_EXP.OutputFormat");
    this.txtBA_POLICY_EXP.Style = "font-size: 8.25pt; text-align: center; ddo-char-set: 0";
    this.txtBA_POLICY_EXP.Text = " ";
    ((ARControl) this.txtBA_POLICY_EXP).Top = 5.437f;
    ((ARControl) this.txtBA_POLICY_EXP).Width = 0.6250003f;
    ((ARControl) this.txtUMBR_POLICY_NO).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_POLICY_NO).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_POLICY_NO).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_POLICY_NO).Border.TopStyle = (BorderLineStyle) 1;
    this.txtUMBR_POLICY_NO.CanGrow = false;
    ((ARControl) this.txtUMBR_POLICY_NO).Height = 0.5619998f;
    ((ARControl) this.txtUMBR_POLICY_NO).Left = 2.687f;
    ((ARControl) this.txtUMBR_POLICY_NO).Name = "txtUMBR_POLICY_NO";
    this.txtUMBR_POLICY_NO.Style = "font-size: 9pt; text-align: center";
    this.txtUMBR_POLICY_NO.Text = " ";
    ((ARControl) this.txtUMBR_POLICY_NO).Top = 6.375f;
    ((ARControl) this.txtUMBR_POLICY_NO).Width = 1.624f;
    ((ARControl) this.txtUMBR_POLICY_EFF).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_POLICY_EFF).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_POLICY_EFF).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_POLICY_EFF).Border.TopStyle = (BorderLineStyle) 1;
    this.txtUMBR_POLICY_EFF.CanGrow = false;
    ((ARControl) this.txtUMBR_POLICY_EFF).Height = 0.5619998f;
    ((ARControl) this.txtUMBR_POLICY_EFF).Left = 4.312f;
    ((ARControl) this.txtUMBR_POLICY_EFF).Name = "txtUMBR_POLICY_EFF";
    this.txtUMBR_POLICY_EFF.OutputFormat = componentResourceManager.GetString("txtUMBR_POLICY_EFF.OutputFormat");
    this.txtUMBR_POLICY_EFF.Style = "font-size: 8.25pt; text-align: center; ddo-char-set: 0";
    this.txtUMBR_POLICY_EFF.Text = " ";
    ((ARControl) this.txtUMBR_POLICY_EFF).Top = 6.375f;
    ((ARControl) this.txtUMBR_POLICY_EFF).Width = 0.6879997f;
    ((ARControl) this.txtUMBR_POLICY_EXP).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_POLICY_EXP).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_POLICY_EXP).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_POLICY_EXP).Border.TopStyle = (BorderLineStyle) 1;
    this.txtUMBR_POLICY_EXP.CanGrow = false;
    ((ARControl) this.txtUMBR_POLICY_EXP).Height = 0.5619998f;
    ((ARControl) this.txtUMBR_POLICY_EXP).Left = 5f;
    ((ARControl) this.txtUMBR_POLICY_EXP).Name = "txtUMBR_POLICY_EXP";
    this.txtUMBR_POLICY_EXP.OutputFormat = componentResourceManager.GetString("txtUMBR_POLICY_EXP.OutputFormat");
    this.txtUMBR_POLICY_EXP.Style = "font-size: 8.25pt; text-align: center; ddo-char-set: 0";
    this.txtUMBR_POLICY_EXP.Text = " ";
    ((ARControl) this.txtUMBR_POLICY_EXP).Top = 6.375f;
    ((ARControl) this.txtUMBR_POLICY_EXP).Width = 0.6250003f;
    ((ARControl) this.Label48).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label48).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label48).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label48).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label48).Height = 0.5619998f;
    this.Label48.HyperLink = (string) null;
    ((ARControl) this.Label48).Left = 2.437f;
    ((ARControl) this.Label48).Name = "Label48";
    this.Label48.Style = "";
    this.Label48.Text = "";
    ((ARControl) this.Label48).Top = 6.375f;
    ((ARControl) this.Label48).Width = 0.2499998f;
    ((ARControl) this.txtWC_POLICY_NO).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_POLICY_NO).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_POLICY_NO).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_POLICY_NO).Border.TopStyle = (BorderLineStyle) 1;
    this.txtWC_POLICY_NO.CanGrow = false;
    ((ARControl) this.txtWC_POLICY_NO).Height = 0.7499999f;
    ((ARControl) this.txtWC_POLICY_NO).Left = 2.687f;
    ((ARControl) this.txtWC_POLICY_NO).Name = "txtWC_POLICY_NO";
    this.txtWC_POLICY_NO.Style = "font-size: 9pt; text-align: center";
    this.txtWC_POLICY_NO.Text = " ";
    ((ARControl) this.txtWC_POLICY_NO).Top = 6.937f;
    ((ARControl) this.txtWC_POLICY_NO).Width = 1.624f;
    ((ARControl) this.txtWC_POLICY_EFF).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_POLICY_EFF).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_POLICY_EFF).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_POLICY_EFF).Border.TopStyle = (BorderLineStyle) 1;
    this.txtWC_POLICY_EFF.CanGrow = false;
    ((ARControl) this.txtWC_POLICY_EFF).Height = 0.7499999f;
    ((ARControl) this.txtWC_POLICY_EFF).Left = 4.312f;
    ((ARControl) this.txtWC_POLICY_EFF).Name = "txtWC_POLICY_EFF";
    this.txtWC_POLICY_EFF.OutputFormat = componentResourceManager.GetString("txtWC_POLICY_EFF.OutputFormat");
    this.txtWC_POLICY_EFF.Style = "font-size: 8.25pt; text-align: center; ddo-char-set: 0";
    this.txtWC_POLICY_EFF.Text = " ";
    ((ARControl) this.txtWC_POLICY_EFF).Top = 6.937f;
    ((ARControl) this.txtWC_POLICY_EFF).Width = 0.6879997f;
    ((ARControl) this.txtWC_POLICY_EXP).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_POLICY_EXP).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_POLICY_EXP).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_POLICY_EXP).Border.TopStyle = (BorderLineStyle) 1;
    this.txtWC_POLICY_EXP.CanGrow = false;
    ((ARControl) this.txtWC_POLICY_EXP).Height = 0.7499999f;
    ((ARControl) this.txtWC_POLICY_EXP).Left = 5f;
    ((ARControl) this.txtWC_POLICY_EXP).Name = "txtWC_POLICY_EXP";
    this.txtWC_POLICY_EXP.OutputFormat = componentResourceManager.GetString("txtWC_POLICY_EXP.OutputFormat");
    this.txtWC_POLICY_EXP.Style = "font-size: 8.25pt; text-align: center; ddo-char-set: 0";
    this.txtWC_POLICY_EXP.Text = " ";
    ((ARControl) this.txtWC_POLICY_EXP).Top = 6.937f;
    ((ARControl) this.txtWC_POLICY_EXP).Width = 0.6250003f;
    ((ARControl) this.Label51).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label51).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label51).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label51).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label51).Height = 0.7499999f;
    this.Label51.HyperLink = (string) null;
    ((ARControl) this.Label51).Left = 2.437f;
    ((ARControl) this.Label51).Name = "Label51";
    this.Label51.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.Label51.Text = "";
    ((ARControl) this.Label51).Top = 6.937f;
    ((ARControl) this.Label51).Width = 0.25f;
    this.TextBox29.CanGrow = false;
    ((ARControl) this.TextBox29).Height = 0.1880004f;
    ((ARControl) this.TextBox29).Left = 0.25f;
    this.TextBox29.MultiLine = false;
    ((ARControl) this.TextBox29).Name = "TextBox29";
    this.TextBox29.Style = "font-family: Arial; font-size: 5.7pt; font-weight: normal; text-align: left; vertical-align: middle; white-space: nowrap; ddo-char-set: 1; ddo-wrap-mode: nowrap";
    this.TextBox29.Text = "ANY PROPRIETOR/PARTNER/EXECUTIVE";
    ((ARControl) this.TextBox29).Top = 7.125f;
    ((ARControl) this.TextBox29).Width = 1.598f;
    this.TextBox30.CanGrow = false;
    ((ARControl) this.TextBox30).Height = 0.125f;
    ((ARControl) this.TextBox30).Left = 0.25f;
    this.TextBox30.MultiLine = false;
    ((ARControl) this.TextBox30).Name = "TextBox30";
    this.TextBox30.Style = "font-family: Arial; font-size: 5.7pt; font-weight: normal; text-align: left; vertical-align: middle; white-space: nowrap; ddo-char-set: 1; ddo-wrap-mode: nowrap";
    this.TextBox30.Text = "OFFICE/MEMBER EXCLUDED?";
    ((ARControl) this.TextBox30).Top = 7.25f;
    ((ARControl) this.TextBox30).Width = 1.468583f;
    this.TextBox31.CanGrow = false;
    ((ARControl) this.TextBox31).Height = 0.1671669f;
    ((ARControl) this.TextBox31).Left = 0.25f;
    this.TextBox31.MultiLine = false;
    ((ARControl) this.TextBox31).Name = "TextBox31";
    this.TextBox31.Style = "font-size: 6pt; font-weight: bold; text-align: left; vertical-align: middle; white-space: nowrap; ddo-char-set: 0; ddo-wrap-mode: nowrap";
    this.TextBox31.Text = "(Mandatory in NH)";
    ((ARControl) this.TextBox31).Top = 7.312f;
    ((ARControl) this.TextBox31).Width = 0.8430002f;
    this.TextBox32.CanGrow = false;
    ((ARControl) this.TextBox32).Height = 0.125f;
    ((ARControl) this.TextBox32).Left = 0.25f;
    this.TextBox32.MultiLine = false;
    ((ARControl) this.TextBox32).Name = "TextBox32";
    this.TextBox32.Style = "font-size: 6pt; font-weight: normal; text-align: left; vertical-align: top; white-space: nowrap; ddo-char-set: 0; ddo-wrap-mode: nowrap";
    this.TextBox32.Text = "If yes, describe under";
    ((ARControl) this.TextBox32).Top = 7.437f;
    ((ARControl) this.TextBox32).Width = 1.624583f;
    ((ARControl) this.txtEXTRA_POLICY_NO).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEXTRA_POLICY_NO).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEXTRA_POLICY_NO).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEXTRA_POLICY_NO).Border.TopStyle = (BorderLineStyle) 1;
    this.txtEXTRA_POLICY_NO.CanGrow = false;
    ((ARControl) this.txtEXTRA_POLICY_NO).DataField = "PolicyNumber";
    ((ARControl) this.txtEXTRA_POLICY_NO).Height = 0.5f;
    ((ARControl) this.txtEXTRA_POLICY_NO).Left = 2.687f;
    ((ARControl) this.txtEXTRA_POLICY_NO).Name = "txtEXTRA_POLICY_NO";
    this.txtEXTRA_POLICY_NO.Style = "font-family: Arial; font-size: 9pt; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.txtEXTRA_POLICY_NO.Text = " ";
    ((ARControl) this.txtEXTRA_POLICY_NO).Top = 7.687f;
    ((ARControl) this.txtEXTRA_POLICY_NO).Width = 1.624f;
    ((ARControl) this.txtEXTRA_POLICY_EFF).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEXTRA_POLICY_EFF).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEXTRA_POLICY_EFF).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEXTRA_POLICY_EFF).Border.TopStyle = (BorderLineStyle) 1;
    this.txtEXTRA_POLICY_EFF.CanGrow = false;
    ((ARControl) this.txtEXTRA_POLICY_EFF).DataField = "EffectiveDate";
    ((ARControl) this.txtEXTRA_POLICY_EFF).Height = 0.5f;
    ((ARControl) this.txtEXTRA_POLICY_EFF).Left = 4.312f;
    ((ARControl) this.txtEXTRA_POLICY_EFF).Name = "txtEXTRA_POLICY_EFF";
    this.txtEXTRA_POLICY_EFF.OutputFormat = componentResourceManager.GetString("txtEXTRA_POLICY_EFF.OutputFormat");
    this.txtEXTRA_POLICY_EFF.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.txtEXTRA_POLICY_EFF.Text = " ";
    ((ARControl) this.txtEXTRA_POLICY_EFF).Top = 7.687f;
    ((ARControl) this.txtEXTRA_POLICY_EFF).Width = 0.6879995f;
    ((ARControl) this.txtEXTRA_POLICY_EXP).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEXTRA_POLICY_EXP).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEXTRA_POLICY_EXP).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEXTRA_POLICY_EXP).Border.TopStyle = (BorderLineStyle) 1;
    this.txtEXTRA_POLICY_EXP.CanGrow = false;
    ((ARControl) this.txtEXTRA_POLICY_EXP).DataField = "ExpirationDate";
    ((ARControl) this.txtEXTRA_POLICY_EXP).Height = 0.5f;
    ((ARControl) this.txtEXTRA_POLICY_EXP).Left = 5f;
    ((ARControl) this.txtEXTRA_POLICY_EXP).Name = "txtEXTRA_POLICY_EXP";
    this.txtEXTRA_POLICY_EXP.OutputFormat = componentResourceManager.GetString("txtEXTRA_POLICY_EXP.OutputFormat");
    this.txtEXTRA_POLICY_EXP.Style = "font-family: Arial; font-size: 8.25pt; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.txtEXTRA_POLICY_EXP.Text = " ";
    ((ARControl) this.txtEXTRA_POLICY_EXP).Top = 7.687f;
    ((ARControl) this.txtEXTRA_POLICY_EXP).Width = 0.6250003f;
    ((ARControl) this.Label54).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label54).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label54).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label54).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label54).Height = 0.5f;
    this.Label54.HyperLink = (string) null;
    ((ARControl) this.Label54).Left = 2.437f;
    ((ARControl) this.Label54).Name = "Label54";
    this.Label54.Style = "font-family: Arial; font-size: 9pt; font-weight: normal; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.Label54.Text = "";
    ((ARControl) this.Label54).Top = 7.687f;
    ((ARControl) this.Label54).Width = 0.25f;
    ((ARControl) this.Label56).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label56).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label56).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label56).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label56).Height = 0.5f;
    this.Label56.HyperLink = (string) null;
    ((ARControl) this.Label56).Left = 0.0f;
    ((ARControl) this.Label56).Name = "Label56";
    this.Label56.Style = "font-family: Arial; font-size: 9pt; font-weight: normal; text-align: center; vertical-align: top; ddo-char-set: 0";
    this.Label56.Text = "";
    ((ARControl) this.Label56).Top = 7.687f;
    ((ARControl) this.Label56).Width = 0.25f;
    ((ARControl) this.txtEXTRA_DESCRIPTION).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEXTRA_DESCRIPTION).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEXTRA_DESCRIPTION).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEXTRA_DESCRIPTION).Border.TopStyle = (BorderLineStyle) 1;
    this.txtEXTRA_DESCRIPTION.CanGrow = false;
    ((ARControl) this.txtEXTRA_DESCRIPTION).Height = 0.5f;
    ((ARControl) this.txtEXTRA_DESCRIPTION).Left = 0.25f;
    ((ARControl) this.txtEXTRA_DESCRIPTION).Name = "txtEXTRA_DESCRIPTION";
    this.txtEXTRA_DESCRIPTION.Style = "font-family: Arial; font-size: 9pt; font-weight: normal; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.txtEXTRA_DESCRIPTION.Text = (string) null;
    ((ARControl) this.txtEXTRA_DESCRIPTION).Top = 7.687f;
    ((ARControl) this.txtEXTRA_DESCRIPTION).Width = 1.937f;
    ((ARControl) this.Label57).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label57).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label57).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label57).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label57).Height = 0.1870005f;
    this.Label57.HyperLink = (string) null;
    ((ARControl) this.Label57).Left = 5.625f;
    ((ARControl) this.Label57).Name = "Label57";
    this.Label57.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: bottom; ddo-char-set: 0";
    this.Label57.Text = "EACH OCCURANCE";
    ((ARControl) this.Label57).Top = 4.125f;
    ((ARControl) this.Label57).Width = 1.25f;
    ((ARControl) this.Label58).Height = 0.1880004f;
    this.Label58.HyperLink = (string) null;
    ((ARControl) this.Label58).Left = 5.625f;
    ((ARControl) this.Label58).Name = "Label58";
    this.Label58.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: top; ddo-char-set: 0";
    this.Label58.Text = "DAMAGE TO RENTED";
    ((ARControl) this.Label58).Top = 4.313f;
    ((ARControl) this.Label58).Width = 0.96f;
    ((ARControl) this.Label59).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label59).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label59).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label59).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label59).Height = 0.187f;
    this.Label59.HyperLink = (string) null;
    ((ARControl) this.Label59).Left = 5.625f;
    ((ARControl) this.Label59).Name = "Label59";
    this.Label59.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: bottom; ddo-char-set: 0";
    this.Label59.Text = "MED EXP (Any one person)";
    ((ARControl) this.Label59).Top = 4.522f;
    ((ARControl) this.Label59).Width = 1.25f;
    ((ARControl) this.Label60).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label60).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label60).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label60).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label60).Height = 0.1879999f;
    this.Label60.HyperLink = (string) null;
    ((ARControl) this.Label60).Left = 5.625f;
    ((ARControl) this.Label60).Name = "Label60";
    this.Label60.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: bottom; ddo-char-set: 0";
    this.Label60.Text = "PERSONAL & ADV INJURY";
    ((ARControl) this.Label60).Top = 4.709f;
    ((ARControl) this.Label60).Width = 1.25f;
    ((ARControl) this.Label61).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label61).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label61).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label61).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label61).Height = 0.1870002f;
    this.Label61.HyperLink = (string) null;
    ((ARControl) this.Label61).Left = 5.625f;
    ((ARControl) this.Label61).Name = "Label61";
    this.Label61.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: bottom; ddo-char-set: 0";
    this.Label61.Text = "GENERAL AGGREGATE";
    ((ARControl) this.Label61).Top = 4.897f;
    ((ARControl) this.Label61).Width = 1.25f;
    ((ARControl) this.Label64).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label64).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label64).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label64).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label64).Height = 0.1880004f;
    this.Label64.HyperLink = (string) null;
    ((ARControl) this.Label64).Left = 5.625f;
    ((ARControl) this.Label64).Name = "Label64";
    this.Label64.Style = "font-family: Arial; font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: bottom; ddo-char-set: 0";
    this.Label64.Text = "BODILY INJURY (Per person)";
    ((ARControl) this.Label64).Top = 5.646f;
    ((ARControl) this.Label64).Width = 1.25f;
    ((ARControl) this.Label66).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label66).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label66).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label66).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label66).Height = 0.187f;
    this.Label66.HyperLink = (string) null;
    ((ARControl) this.Label66).Left = 5.625f;
    ((ARControl) this.Label66).Name = "Label66";
    this.Label66.Style = "font-family: Arial; font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: bottom; ddo-char-set: 0";
    this.Label66.Text = "BODILY INJURY (Per accident)";
    ((ARControl) this.Label66).Top = 5.834f;
    ((ARControl) this.Label66).Width = 1.25f;
    ((ARControl) this.Label78).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label78).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label78).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label78).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label78).Height = 0.1869998f;
    this.Label78.HyperLink = (string) null;
    ((ARControl) this.Label78).Left = 5.625f;
    ((ARControl) this.Label78).Name = "Label78";
    this.Label78.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 0";
    this.Label78.Text = "E.L. EACH ACCIDENT";
    ((ARControl) this.Label78).Top = 7.125f;
    ((ARControl) this.Label78).Width = 1.25f;
    ((ARControl) this.Label79).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label79).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label79).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label79).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label79).Height = 0.1880002f;
    this.Label79.HyperLink = (string) null;
    ((ARControl) this.Label79).Left = 5.625f;
    ((ARControl) this.Label79).Name = "Label79";
    this.Label79.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 0";
    this.Label79.Text = "E.L. DISEASE - EA EMPLOYEE";
    ((ARControl) this.Label79).Top = 7.312f;
    ((ARControl) this.Label79).Width = 1.25f;
    ((ARControl) this.Label80).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label80).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label80).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label80).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label80).Height = 0.1869998f;
    this.Label80.HyperLink = (string) null;
    ((ARControl) this.Label80).Left = 5.625f;
    ((ARControl) this.Label80).Name = "Label80";
    this.Label80.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 0";
    this.Label80.Text = "E.L. DISEASE - POLICY LIMIT";
    ((ARControl) this.Label80).Top = 7.5f;
    ((ARControl) this.Label80).Width = 1.25f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC).Border.TopStyle = (BorderLineStyle) 1;
    this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC.CanGrow = false;
    this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC).Height = 0.1870005f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC).Left = 6.875f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC).Name = "txtCOMMERCIAL_GL_LIMIT_EACH_OCC";
    this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC.OutputFormat = componentResourceManager.GetString("txtCOMMERCIAL_GL_LIMIT_EACH_OCC.OutputFormat");
    this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC.Style = "font-size: 9pt; text-align: left";
    this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC.Text = " ";
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC).Top = 4.125f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC).Width = 1.125f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED).Border.TopStyle = (BorderLineStyle) 1;
    this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED.CanGrow = false;
    this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED).Height = 0.21f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED).Left = 6.875f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED).Name = "txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED";
    this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED.OutputFormat = componentResourceManager.GetString("txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED.OutputFormat");
    this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED.Style = "font-size: 9pt; text-align: left";
    this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED.Text = " ";
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED).Top = 4.312f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED).Width = 1.122f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_MED_EXP).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_MED_EXP).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_MED_EXP).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_MED_EXP).Border.TopStyle = (BorderLineStyle) 1;
    this.txtCOMMERCIAL_GL_LIMIT_MED_EXP.CanGrow = false;
    this.txtCOMMERCIAL_GL_LIMIT_MED_EXP.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_MED_EXP).Height = 0.187f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_MED_EXP).Left = 6.875f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_MED_EXP).Name = "txtCOMMERCIAL_GL_LIMIT_MED_EXP";
    this.txtCOMMERCIAL_GL_LIMIT_MED_EXP.OutputFormat = componentResourceManager.GetString("txtCOMMERCIAL_GL_LIMIT_MED_EXP.OutputFormat");
    this.txtCOMMERCIAL_GL_LIMIT_MED_EXP.Style = "font-size: 9pt; text-align: left";
    this.txtCOMMERCIAL_GL_LIMIT_MED_EXP.Text = " ";
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_MED_EXP).Top = 4.522f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_MED_EXP).Width = 1.122f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY).Border.TopStyle = (BorderLineStyle) 1;
    this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY.CanGrow = false;
    this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY).Height = 0.1879999f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY).Left = 6.875f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY).Name = "txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY";
    this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY.OutputFormat = componentResourceManager.GetString("txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY.OutputFormat");
    this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY.Style = "font-size: 9pt; text-align: left";
    this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY.Text = " ";
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY).Top = 4.709f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY).Width = 1.121833f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG).Border.TopStyle = (BorderLineStyle) 1;
    this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG.CanGrow = false;
    this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG).Height = 0.1870002f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG).Left = 6.875f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG).Name = "txtCOMMERCIAL_GL_LIMIT_GEN_AGG";
    this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG.OutputFormat = componentResourceManager.GetString("txtCOMMERCIAL_GL_LIMIT_GEN_AGG.OutputFormat");
    this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG.Style = "font-size: 9pt; text-align: left";
    this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG.Text = " ";
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG).Top = 4.897f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG).Width = 1.121833f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG).Border.TopStyle = (BorderLineStyle) 1;
    this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG.CanGrow = false;
    this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG).Height = 0.1880001f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG).Left = 6.875f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG).Name = "txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG";
    this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG.OutputFormat = componentResourceManager.GetString("txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG.OutputFormat");
    this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG.Style = "font-family: Arial; font-size: 9pt; text-align: left; ddo-char-set: 0";
    this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG.Text = " ";
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG).Top = 5.084f;
    ((ARControl) this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG).Width = 1.121833f;
    ((ARControl) this.txtBA_COMBINED_SINGLE_LIMIT).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_COMBINED_SINGLE_LIMIT).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_COMBINED_SINGLE_LIMIT).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_COMBINED_SINGLE_LIMIT).Border.TopStyle = (BorderLineStyle) 1;
    this.txtBA_COMBINED_SINGLE_LIMIT.CanGrow = false;
    this.txtBA_COMBINED_SINGLE_LIMIT.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtBA_COMBINED_SINGLE_LIMIT).Height = 0.209f;
    ((ARControl) this.txtBA_COMBINED_SINGLE_LIMIT).Left = 6.875f;
    ((ARControl) this.txtBA_COMBINED_SINGLE_LIMIT).Name = "txtBA_COMBINED_SINGLE_LIMIT";
    this.txtBA_COMBINED_SINGLE_LIMIT.OutputFormat = componentResourceManager.GetString("txtBA_COMBINED_SINGLE_LIMIT.OutputFormat");
    this.txtBA_COMBINED_SINGLE_LIMIT.Style = "font-size: 9pt; text-align: left";
    this.txtBA_COMBINED_SINGLE_LIMIT.Text = " ";
    ((ARControl) this.txtBA_COMBINED_SINGLE_LIMIT).Top = 5.437f;
    ((ARControl) this.txtBA_COMBINED_SINGLE_LIMIT).Width = 1.122f;
    ((ARControl) this.txtBA_BODILY_INJURY_PER_PERSON).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_BODILY_INJURY_PER_PERSON).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_BODILY_INJURY_PER_PERSON).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_BODILY_INJURY_PER_PERSON).Border.TopStyle = (BorderLineStyle) 1;
    this.txtBA_BODILY_INJURY_PER_PERSON.CanGrow = false;
    this.txtBA_BODILY_INJURY_PER_PERSON.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtBA_BODILY_INJURY_PER_PERSON).Height = 0.1880004f;
    ((ARControl) this.txtBA_BODILY_INJURY_PER_PERSON).Left = 6.875f;
    ((ARControl) this.txtBA_BODILY_INJURY_PER_PERSON).Name = "txtBA_BODILY_INJURY_PER_PERSON";
    this.txtBA_BODILY_INJURY_PER_PERSON.OutputFormat = componentResourceManager.GetString("txtBA_BODILY_INJURY_PER_PERSON.OutputFormat");
    this.txtBA_BODILY_INJURY_PER_PERSON.Style = "font-size: 9pt; text-align: left";
    this.txtBA_BODILY_INJURY_PER_PERSON.Text = " ";
    ((ARControl) this.txtBA_BODILY_INJURY_PER_PERSON).Top = 5.646f;
    ((ARControl) this.txtBA_BODILY_INJURY_PER_PERSON).Width = 1.121833f;
    ((ARControl) this.txtBA_BODILY_INJURY_PER_ACCIDENT).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_BODILY_INJURY_PER_ACCIDENT).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_BODILY_INJURY_PER_ACCIDENT).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_BODILY_INJURY_PER_ACCIDENT).Border.TopStyle = (BorderLineStyle) 1;
    this.txtBA_BODILY_INJURY_PER_ACCIDENT.CanGrow = false;
    this.txtBA_BODILY_INJURY_PER_ACCIDENT.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtBA_BODILY_INJURY_PER_ACCIDENT).Height = 0.187f;
    ((ARControl) this.txtBA_BODILY_INJURY_PER_ACCIDENT).Left = 6.875f;
    ((ARControl) this.txtBA_BODILY_INJURY_PER_ACCIDENT).Name = "txtBA_BODILY_INJURY_PER_ACCIDENT";
    this.txtBA_BODILY_INJURY_PER_ACCIDENT.OutputFormat = componentResourceManager.GetString("txtBA_BODILY_INJURY_PER_ACCIDENT.OutputFormat");
    this.txtBA_BODILY_INJURY_PER_ACCIDENT.Style = "font-size: 9pt; text-align: left";
    this.txtBA_BODILY_INJURY_PER_ACCIDENT.Text = " ";
    ((ARControl) this.txtBA_BODILY_INJURY_PER_ACCIDENT).Top = 5.834f;
    ((ARControl) this.txtBA_BODILY_INJURY_PER_ACCIDENT).Width = 1.121833f;
    ((ARControl) this.txtBA_PROPERTY_DAMAGE).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_PROPERTY_DAMAGE).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_PROPERTY_DAMAGE).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBA_PROPERTY_DAMAGE).Border.TopStyle = (BorderLineStyle) 1;
    this.txtBA_PROPERTY_DAMAGE.CanGrow = false;
    this.txtBA_PROPERTY_DAMAGE.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtBA_PROPERTY_DAMAGE).Height = 0.1880004f;
    ((ARControl) this.txtBA_PROPERTY_DAMAGE).Left = 6.875f;
    ((ARControl) this.txtBA_PROPERTY_DAMAGE).Name = "txtBA_PROPERTY_DAMAGE";
    this.txtBA_PROPERTY_DAMAGE.OutputFormat = componentResourceManager.GetString("txtBA_PROPERTY_DAMAGE.OutputFormat");
    this.txtBA_PROPERTY_DAMAGE.Style = "font-size: 9pt; text-align: left";
    this.txtBA_PROPERTY_DAMAGE.Text = " ";
    ((ARControl) this.txtBA_PROPERTY_DAMAGE).Top = 6.021f;
    ((ARControl) this.txtBA_PROPERTY_DAMAGE).Width = 1.121833f;
    ((ARControl) this.TextBox48).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox48).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox48).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox48).Border.TopStyle = (BorderLineStyle) 1;
    this.TextBox48.CanGrow = false;
    this.TextBox48.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.TextBox48).Height = 0.165f;
    ((ARControl) this.TextBox48).Left = 6.875f;
    ((ARControl) this.TextBox48).Name = "TextBox48";
    this.TextBox48.OutputFormat = componentResourceManager.GetString("TextBox48.OutputFormat");
    this.TextBox48.Style = "font-size: 9pt; text-align: left";
    this.TextBox48.Text = " ";
    ((ARControl) this.TextBox48).Top = 6.209f;
    ((ARControl) this.TextBox48).Width = 1.122f;
    ((ARControl) this.txtWC_OTHER_LIMIT_AMT).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_OTHER_LIMIT_AMT).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_OTHER_LIMIT_AMT).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_OTHER_LIMIT_AMT).Border.TopStyle = (BorderLineStyle) 1;
    this.txtWC_OTHER_LIMIT_AMT.CanGrow = false;
    this.txtWC_OTHER_LIMIT_AMT.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtWC_OTHER_LIMIT_AMT).Height = 0.1880002f;
    ((ARControl) this.txtWC_OTHER_LIMIT_AMT).Left = 6.875f;
    ((ARControl) this.txtWC_OTHER_LIMIT_AMT).Name = "txtWC_OTHER_LIMIT_AMT";
    this.txtWC_OTHER_LIMIT_AMT.OutputFormat = componentResourceManager.GetString("txtWC_OTHER_LIMIT_AMT.OutputFormat");
    this.txtWC_OTHER_LIMIT_AMT.Style = "font-size: 9pt; text-align: left";
    this.txtWC_OTHER_LIMIT_AMT.Text = " ";
    ((ARControl) this.txtWC_OTHER_LIMIT_AMT).Top = 6.937f;
    ((ARControl) this.txtWC_OTHER_LIMIT_AMT).Width = 1.121833f;
    ((ARControl) this.txtWC_EACH_ACCIDENT).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_EACH_ACCIDENT).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_EACH_ACCIDENT).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_EACH_ACCIDENT).Border.TopStyle = (BorderLineStyle) 1;
    this.txtWC_EACH_ACCIDENT.CanGrow = false;
    this.txtWC_EACH_ACCIDENT.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtWC_EACH_ACCIDENT).Height = 0.1869998f;
    ((ARControl) this.txtWC_EACH_ACCIDENT).Left = 6.875f;
    ((ARControl) this.txtWC_EACH_ACCIDENT).Name = "txtWC_EACH_ACCIDENT";
    this.txtWC_EACH_ACCIDENT.OutputFormat = componentResourceManager.GetString("txtWC_EACH_ACCIDENT.OutputFormat");
    this.txtWC_EACH_ACCIDENT.Style = "font-size: 9pt; text-align: left";
    this.txtWC_EACH_ACCIDENT.Text = " ";
    ((ARControl) this.txtWC_EACH_ACCIDENT).Top = 7.125f;
    ((ARControl) this.txtWC_EACH_ACCIDENT).Width = 1.121833f;
    ((ARControl) this.txtWC_DISEASE_EACH_EMPLOYEE).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_DISEASE_EACH_EMPLOYEE).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_DISEASE_EACH_EMPLOYEE).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_DISEASE_EACH_EMPLOYEE).Border.TopStyle = (BorderLineStyle) 1;
    this.txtWC_DISEASE_EACH_EMPLOYEE.CanGrow = false;
    this.txtWC_DISEASE_EACH_EMPLOYEE.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtWC_DISEASE_EACH_EMPLOYEE).Height = 0.1880002f;
    ((ARControl) this.txtWC_DISEASE_EACH_EMPLOYEE).Left = 6.875f;
    ((ARControl) this.txtWC_DISEASE_EACH_EMPLOYEE).Name = "txtWC_DISEASE_EACH_EMPLOYEE";
    this.txtWC_DISEASE_EACH_EMPLOYEE.OutputFormat = componentResourceManager.GetString("txtWC_DISEASE_EACH_EMPLOYEE.OutputFormat");
    this.txtWC_DISEASE_EACH_EMPLOYEE.Style = "font-size: 9pt; text-align: left";
    this.txtWC_DISEASE_EACH_EMPLOYEE.Text = " ";
    ((ARControl) this.txtWC_DISEASE_EACH_EMPLOYEE).Top = 7.312f;
    ((ARControl) this.txtWC_DISEASE_EACH_EMPLOYEE).Width = 1.121833f;
    ((ARControl) this.txtFooter_Cancellation).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtFooter_Cancellation).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtFooter_Cancellation).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtFooter_Cancellation).Border.TopStyle = (BorderLineStyle) 1;
    this.txtFooter_Cancellation.CanGrow = false;
    ((ARControl) this.txtFooter_Cancellation).Height = 0.3749999f;
    ((ARControl) this.txtFooter_Cancellation).Left = 3.996f;
    ((ARControl) this.txtFooter_Cancellation).Name = "txtFooter_Cancellation";
    this.txtFooter_Cancellation.Style = "font-size: 6pt; font-weight: normal; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.txtFooter_Cancellation.Text = (string) null;
    ((ARControl) this.txtFooter_Cancellation).Top = 9.25f;
    ((ARControl) this.txtFooter_Cancellation).Width = 4f;
    ((ARControl) this.Label15).Height = 0.125f;
    this.Label15.HyperLink = (string) null;
    ((ARControl) this.Label15).Left = 4.062f;
    ((ARControl) this.Label15).Name = "Label15";
    this.Label15.Style = "font-size: 6pt; font-weight: bold; ddo-char-set: 0";
    this.Label15.Text = "AUTHORIZED REPRESENTATIVE";
    ((ARControl) this.Label15).Top = 9.643f;
    ((ARControl) this.Label15).Width = 1.403f;
    ((ARControl) this.label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label10).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label10).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label10).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label10).Height = 1.312f;
    this.label10.HyperLink = (string) null;
    ((ARControl) this.label10).Left = 2.187f;
    ((ARControl) this.label10).Name = "label10";
    this.label10.Style = "";
    this.label10.Text = "";
    ((ARControl) this.label10).Top = 4.125f;
    ((ARControl) this.label10).Width = 0.25f;
    ((ARControl) this.label31).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label31).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label31).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label31).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label31).Height = 0.5619998f;
    this.label31.HyperLink = (string) null;
    ((ARControl) this.label31).Left = 2.187f;
    ((ARControl) this.label31).Name = "label31";
    this.label31.Style = "";
    this.label31.Text = "";
    ((ARControl) this.label31).Top = 6.375f;
    ((ARControl) this.label31).Width = 0.2499997f;
    ((ARControl) this.label32).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label32).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label32).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label32).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label32).Height = 0.7499999f;
    this.label32.HyperLink = (string) null;
    ((ARControl) this.label32).Left = 2.187f;
    ((ARControl) this.label32).Name = "label32";
    this.label32.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.label32.Text = "";
    ((ARControl) this.label32).Top = 6.937f;
    ((ARControl) this.label32).Width = 0.253f;
    ((ARControl) this.label33).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label33).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label33).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label33).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label33).Height = 0.5f;
    this.label33.HyperLink = (string) null;
    ((ARControl) this.label33).Left = 2.187f;
    ((ARControl) this.label33).Name = "label33";
    this.label33.Style = "font-family: Arial; font-size: 9pt; font-weight: normal; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.label33.Text = "";
    ((ARControl) this.label33).Top = 7.687f;
    ((ARControl) this.label33).Width = 0.253f;
    ((ARControl) this.Label22).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label22).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label22).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label22).Height = 0.1880003f;
    this.Label22.HyperLink = (string) null;
    ((ARControl) this.Label22).Left = 4f;
    ((ARControl) this.Label22).Name = "Label22";
    this.Label22.Style = "font-size: 6pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label22.Text = "  INSURER D:";
    ((ARControl) this.Label22).Top = 2.749f;
    ((ARControl) this.Label22).Width = 0.8120003f;
    ((ARControl) this.Label1).Height = 0.2604167f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 2.00025f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 14.25pt; font-weight: bold; text-align: center; text-decoration: none; ddo-char-set: 0";
    this.Label1.Text = "CERTIFICATE OF LIABILITY INSURANCE";
    ((ARControl) this.Label1).Top = 0.08370833f;
    ((ARControl) this.Label1).Width = 3.937f;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Height = 0.1041667f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 0.062f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 6pt; font-weight: bold; ddo-char-set: 0";
    this.Label3.Text = "INSURED";
    ((ARControl) this.Label3).Top = 2.375f;
    ((ARControl) this.Label3).Width = 0.708f;
    ((ARControl) this.Label4).Height = 0.1041667f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 0.062f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 6pt; font-weight: bold; ddo-char-set: 0";
    this.Label4.Text = "PRODUCER";
    ((ARControl) this.Label4).Top = 1.437f;
    ((ARControl) this.Label4).Width = 0.708f;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Height = 0.125f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 0.062f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label11.Text = "COVERAGES";
    ((ARControl) this.Label11).Top = 3.312f;
    ((ARControl) this.Label11).Width = 0.9895833f;
    ((ARControl) this.Label17).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Height = 3f / 16f;
    this.Label17.HyperLink = (string) null;
    ((ARControl) this.Label17).Left = 6.797f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "font-size: 6pt; text-align: center; ddo-char-set: 0";
    this.Label17.Text = "DATE (MM/DD/YYYY)";
    ((ARControl) this.Label17).Top = 0.0f;
    ((ARControl) this.Label17).Width = 1.2f;
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label16).Height = 0.1870001f;
    this.Label16.HyperLink = (string) null;
    ((ARControl) this.Label16).Left = 4f;
    ((ARControl) this.Label16).Name = "Label16";
    this.Label16.Style = "font-size: 6pt; font-weight: bold; text-align: center; vertical-align: middle";
    this.Label16.Text = " INSURER(S) AFFORDING COVERAGE";
    ((ARControl) this.Label16).Top = 2f;
    ((ARControl) this.Label16).Width = 3.125f;
    ((ARControl) this.Label18).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Height = 0.1870001f;
    this.Label18.HyperLink = (string) null;
    ((ARControl) this.Label18).Left = 7.125f;
    ((ARControl) this.Label18).Name = "Label18";
    this.Label18.Style = "font-size: 6pt; font-weight: bold; text-align: center; vertical-align: middle";
    this.Label18.Text = " NAIC #";
    ((ARControl) this.Label18).Top = 2f;
    ((ARControl) this.Label18).Width = 0.8749995f;
    ((ARControl) this.Label19).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label19).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label19).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label19).Height = 0.1869999f;
    this.Label19.HyperLink = (string) null;
    ((ARControl) this.Label19).Left = 4f;
    ((ARControl) this.Label19).Name = "Label19";
    this.Label19.Style = "font-size: 6pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label19.Text = "  INSURER A:";
    ((ARControl) this.Label19).Top = 2.187f;
    ((ARControl) this.Label19).Width = 0.8120003f;
    ((ARControl) this.Label20).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label20).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label20).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label20).Height = 0.1880001f;
    this.Label20.HyperLink = (string) null;
    ((ARControl) this.Label20).Left = 4f;
    ((ARControl) this.Label20).Name = "Label20";
    this.Label20.Style = "font-size: 6pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label20.Text = "  INSURER B:";
    ((ARControl) this.Label20).Top = 2.374f;
    ((ARControl) this.Label20).Width = 0.8120003f;
    ((ARControl) this.Label21).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label21).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label21).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label21).Height = 0.1870001f;
    this.Label21.HyperLink = (string) null;
    ((ARControl) this.Label21).Left = 4f;
    ((ARControl) this.Label21).Name = "Label21";
    this.Label21.Style = "font-size: 6pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label21.Text = "  INSURER C:";
    ((ARControl) this.Label21).Top = 2.562f;
    ((ARControl) this.Label21).Width = 0.8120003f;
    ((ARControl) this.txtINSURER_A).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_A).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_A).Border.TopStyle = (BorderLineStyle) 1;
    this.txtINSURER_A.CanGrow = false;
    ((ARControl) this.txtINSURER_A).DataField = "INSURER_A";
    ((ARControl) this.txtINSURER_A).Height = 0.1869999f;
    ((ARControl) this.txtINSURER_A).Left = 4.812f;
    this.txtINSURER_A.MultiLine = false;
    ((ARControl) this.txtINSURER_A).Name = "txtINSURER_A";
    this.txtINSURER_A.Style = "font-family: Arial; font-size: 9pt; white-space: nowrap; ddo-char-set: 0";
    this.txtINSURER_A.Text = (string) null;
    ((ARControl) this.txtINSURER_A).Top = 2.187f;
    ((ARControl) this.txtINSURER_A).Width = 2.313f;
    ((ARControl) this.txtINSURER_B).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_B).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_B).Border.TopStyle = (BorderLineStyle) 1;
    this.txtINSURER_B.CanGrow = false;
    ((ARControl) this.txtINSURER_B).DataField = "INSURER_B";
    ((ARControl) this.txtINSURER_B).Height = 0.1880001f;
    ((ARControl) this.txtINSURER_B).Left = 4.812f;
    this.txtINSURER_B.MultiLine = false;
    ((ARControl) this.txtINSURER_B).Name = "txtINSURER_B";
    this.txtINSURER_B.Style = "font-family: Arial; font-size: 9pt; white-space: nowrap; ddo-char-set: 0";
    this.txtINSURER_B.Text = (string) null;
    ((ARControl) this.txtINSURER_B).Top = 2.374f;
    ((ARControl) this.txtINSURER_B).Width = 2.313f;
    ((ARControl) this.txtINSURER_C).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_C).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_C).Border.TopStyle = (BorderLineStyle) 1;
    this.txtINSURER_C.CanGrow = false;
    ((ARControl) this.txtINSURER_C).DataField = "INSURER_C";
    ((ARControl) this.txtINSURER_C).Height = 0.1870001f;
    ((ARControl) this.txtINSURER_C).Left = 4.812f;
    this.txtINSURER_C.MultiLine = false;
    ((ARControl) this.txtINSURER_C).Name = "txtINSURER_C";
    this.txtINSURER_C.Style = "font-family: Arial; font-size: 9pt; white-space: nowrap; ddo-char-set: 0";
    this.txtINSURER_C.Text = (string) null;
    ((ARControl) this.txtINSURER_C).Top = 2.562f;
    ((ARControl) this.txtINSURER_C).Width = 2.313f;
    ((ARControl) this.txtINSURER_D).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_D).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_D).Border.TopStyle = (BorderLineStyle) 1;
    this.txtINSURER_D.CanGrow = false;
    ((ARControl) this.txtINSURER_D).DataField = "INSURER_D";
    ((ARControl) this.txtINSURER_D).Height = 0.1880003f;
    ((ARControl) this.txtINSURER_D).Left = 4.812f;
    this.txtINSURER_D.MultiLine = false;
    ((ARControl) this.txtINSURER_D).Name = "txtINSURER_D";
    this.txtINSURER_D.Style = "font-family: Arial; font-size: 9pt; white-space: nowrap; ddo-char-set: 0";
    this.txtINSURER_D.Text = (string) null;
    ((ARControl) this.txtINSURER_D).Top = 2.749f;
    ((ARControl) this.txtINSURER_D).Width = 2.313f;
    ((ARControl) this.txtINSURER_A_NAIC).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_A_NAIC).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_A_NAIC).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_A_NAIC).Border.TopStyle = (BorderLineStyle) 1;
    this.txtINSURER_A_NAIC.CanGrow = false;
    ((ARControl) this.txtINSURER_A_NAIC).DataField = "INSURER_A_NAIC";
    ((ARControl) this.txtINSURER_A_NAIC).Height = 0.189f;
    ((ARControl) this.txtINSURER_A_NAIC).Left = 7.125f;
    ((ARControl) this.txtINSURER_A_NAIC).Name = "txtINSURER_A_NAIC";
    this.txtINSURER_A_NAIC.Style = "font-family: Arial; font-size: 9pt; text-align: center; ddo-char-set: 0";
    this.txtINSURER_A_NAIC.Text = (string) null;
    ((ARControl) this.txtINSURER_A_NAIC).Top = 2.187f;
    ((ARControl) this.txtINSURER_A_NAIC).Width = 0.8724165f;
    ((ARControl) this.txtINSURER_B_NAIC).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_B_NAIC).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_B_NAIC).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_B_NAIC).Border.TopStyle = (BorderLineStyle) 1;
    this.txtINSURER_B_NAIC.CanGrow = false;
    ((ARControl) this.txtINSURER_B_NAIC).DataField = "INSURER_B_NAIC";
    ((ARControl) this.txtINSURER_B_NAIC).Height = 0.1880001f;
    ((ARControl) this.txtINSURER_B_NAIC).Left = 7.125f;
    ((ARControl) this.txtINSURER_B_NAIC).Name = "txtINSURER_B_NAIC";
    this.txtINSURER_B_NAIC.Style = "font-family: Arial; font-size: 9pt; ddo-char-set: 0";
    this.txtINSURER_B_NAIC.Text = (string) null;
    ((ARControl) this.txtINSURER_B_NAIC).Top = 2.374f;
    ((ARControl) this.txtINSURER_B_NAIC).Width = 0.872416f;
    ((ARControl) this.txtINSURER_C_NAIC).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_C_NAIC).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_C_NAIC).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_C_NAIC).Border.TopStyle = (BorderLineStyle) 1;
    this.txtINSURER_C_NAIC.CanGrow = false;
    ((ARControl) this.txtINSURER_C_NAIC).DataField = "INSURER_C_NAIC";
    ((ARControl) this.txtINSURER_C_NAIC).Height = 0.1870001f;
    ((ARControl) this.txtINSURER_C_NAIC).Left = 7.125f;
    ((ARControl) this.txtINSURER_C_NAIC).Name = "txtINSURER_C_NAIC";
    this.txtINSURER_C_NAIC.Style = "font-family: Arial; font-size: 9pt; ddo-char-set: 0";
    this.txtINSURER_C_NAIC.Text = (string) null;
    ((ARControl) this.txtINSURER_C_NAIC).Top = 2.562f;
    ((ARControl) this.txtINSURER_C_NAIC).Width = 0.872416f;
    ((ARControl) this.txtINSURER_D_NAIC).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_D_NAIC).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_D_NAIC).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_D_NAIC).Border.TopStyle = (BorderLineStyle) 1;
    this.txtINSURER_D_NAIC.CanGrow = false;
    ((ARControl) this.txtINSURER_D_NAIC).DataField = "INSURER_D_NAIC";
    ((ARControl) this.txtINSURER_D_NAIC).Height = 0.1880003f;
    ((ARControl) this.txtINSURER_D_NAIC).Left = 7.125f;
    ((ARControl) this.txtINSURER_D_NAIC).Name = "txtINSURER_D_NAIC";
    this.txtINSURER_D_NAIC.Style = "font-family: Arial; font-size: 9pt; ddo-char-set: 0";
    this.txtINSURER_D_NAIC.Text = (string) null;
    ((ARControl) this.txtINSURER_D_NAIC).Top = 2.749f;
    ((ARControl) this.txtINSURER_D_NAIC).Width = 0.872416f;
    ((ARControl) this.Label26).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label26).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label26).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label26).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label26).Height = 0.1879997f;
    this.Label26.HyperLink = (string) null;
    ((ARControl) this.Label26).Left = 0.25f;
    ((ARControl) this.Label26).Name = "Label26";
    this.Label26.ShrinkToFit = true;
    this.Label26.Style = "font-size: 6pt; font-weight: bold; text-align: center; text-decoration: none; vertical-align: middle; white-space: nowrap; ddo-shrink-to-fit: true; ddo-wrap-mode: nowrap";
    this.Label26.Text = "TYPE OF INSURANCE";
    ((ARControl) this.Label26).Top = 3.937f;
    ((ARControl) this.Label26).Width = 1.937f;
    ((ARControl) this.Label24).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label24).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label24).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label24).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label24).Height = 0.1879997f;
    this.Label24.HyperLink = (string) null;
    ((ARControl) this.Label24).Left = 0.0f;
    ((ARControl) this.Label24).Name = "Label24";
    this.Label24.ShrinkToFit = true;
    this.Label24.Style = "font-size: 5.5pt; font-weight: bold; text-align: center; text-decoration: none; vertical-align: middle; white-space: nowrap; ddo-shrink-to-fit: true; ddo-wrap-mode: nowrap";
    this.Label24.Text = "INSR\r\nLTR";
    ((ARControl) this.Label24).Top = 3.937f;
    ((ARControl) this.Label24).Width = 0.25f;
    ((ARControl) this.Label25).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label25).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label25).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label25).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label25).Height = 0.1879997f;
    this.Label25.HyperLink = (string) null;
    ((ARControl) this.Label25).Left = 2.187f;
    ((ARControl) this.Label25).Name = "Label25";
    this.Label25.ShrinkToFit = true;
    this.Label25.Style = "font-size: 5.5pt; font-weight: bold; text-align: center; text-decoration: none; vertical-align: middle; white-space: nowrap; ddo-char-set: 1; ddo-shrink-to-fit: true; ddo-wrap-mode: nowrap";
    this.Label25.Text = "ADDL\r\nINSD";
    ((ARControl) this.Label25).Top = 3.937f;
    ((ARControl) this.Label25).Width = 0.25f;
    ((ARControl) this.Label27).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label27).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label27).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label27).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label27).Height = 0.1879997f;
    this.Label27.HyperLink = (string) null;
    ((ARControl) this.Label27).Left = 2.687f;
    ((ARControl) this.Label27).Name = "Label27";
    this.Label27.ShrinkToFit = true;
    this.Label27.Style = "font-size: 6pt; font-weight: bold; text-align: center; text-decoration: none; vertical-align: middle; white-space: nowrap; ddo-shrink-to-fit: true; ddo-wrap-mode: nowrap";
    this.Label27.Text = "POLICY NUMBER";
    ((ARControl) this.Label27).Top = 3.937f;
    ((ARControl) this.Label27).Width = 1.625f;
    ((ARControl) this.Label29).Height = 0.1879995f;
    this.Label29.HyperLink = (string) null;
    ((ARControl) this.Label29).Left = 5f;
    ((ARControl) this.Label29).Name = "Label29";
    this.Label29.ShrinkToFit = true;
    this.Label29.Style = "font-size: 6pt; font-weight: bold; text-align: center; text-decoration: none; vertical-align: middle; white-space: nowrap; ddo-shrink-to-fit: true; ddo-wrap-mode: nowrap";
    this.Label29.Text = "POLICY EXP\r\n(MM/DD/YYYY)";
    ((ARControl) this.Label29).Top = 3.937f;
    ((ARControl) this.Label29).Width = 0.6250005f;
    ((ARControl) this.Label30).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label30).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label30).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label30).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label30).Height = 0.1879997f;
    this.Label30.HyperLink = (string) null;
    ((ARControl) this.Label30).Left = 5.625f;
    ((ARControl) this.Label30).Name = "Label30";
    this.Label30.ShrinkToFit = true;
    this.Label30.Style = "font-size: 6pt; font-weight: bold; text-align: center; text-decoration: none; vertical-align: middle; white-space: nowrap; ddo-shrink-to-fit: true; ddo-wrap-mode: nowrap";
    this.Label30.Text = "LIMITS";
    ((ARControl) this.Label30).Top = 3.937f;
    ((ARControl) this.Label30).Width = 2.375f;
    ((ARControl) this.Label37).Height = 0.1879995f;
    this.Label37.HyperLink = (string) null;
    ((ARControl) this.Label37).Left = 4.312f;
    ((ARControl) this.Label37).Name = "Label37";
    this.Label37.ShrinkToFit = true;
    this.Label37.Style = "font-size: 6pt; font-weight: bold; text-align: center; text-decoration: none; vertical-align: middle; white-space: nowrap; ddo-font-vertical: none; ddo-shrink-to-fit: true; ddo-wrap-mode: nowrap";
    this.Label37.Text = "POLICY EFF\r\n(MM/DD/YYYY)";
    ((ARControl) this.Label37).Top = 3.937f;
    ((ARControl) this.Label37).Width = 0.625f;
    ((ARControl) this.label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label9).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label9).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label9).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label9).Height = 0.1879997f;
    this.label9.HyperLink = (string) null;
    ((ARControl) this.label9).Left = 2.437f;
    ((ARControl) this.label9).Name = "label9";
    this.label9.ShrinkToFit = true;
    this.label9.Style = "font-size: 5pt; font-weight: bold; text-align: center; text-decoration: none; vertical-align: middle; white-space: nowrap; ddo-shrink-to-fit: true; ddo-wrap-mode: nowrap";
    this.label9.Text = "SUBR\r\nWVD";
    ((ARControl) this.label9).Top = 3.937f;
    ((ARControl) this.label9).Width = 0.25f;
    ((ARControl) this.label38).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label38).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label38).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label38).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label38).Height = 0.1880001f;
    this.label38.HyperLink = (string) null;
    ((ARControl) this.label38).Left = 4f;
    ((ARControl) this.label38).Name = "label38";
    this.label38.Style = "font-size: 6pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label38.Text = "CONTACT NAME:";
    ((ARControl) this.label38).Top = 1.437f;
    ((ARControl) this.label38).Width = 0.9370003f;
    ((ARControl) this.txtHPRODUCEREMAIL).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtHPRODUCEREMAIL).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtHPRODUCEREMAIL).Border.TopStyle = (BorderLineStyle) 1;
    this.txtHPRODUCEREMAIL.CanGrow = false;
    ((ARControl) this.txtHPRODUCEREMAIL).DataField = "PRODUCEREMAIL";
    ((ARControl) this.txtHPRODUCEREMAIL).Height = 0.188f;
    ((ARControl) this.txtHPRODUCEREMAIL).Left = 4.937f;
    this.txtHPRODUCEREMAIL.MultiLine = false;
    ((ARControl) this.txtHPRODUCEREMAIL).Name = "txtHPRODUCEREMAIL";
    this.txtHPRODUCEREMAIL.Style = "font-family: Arial; font-size: 8.25pt; white-space: nowrap; ddo-char-set: 0";
    this.txtHPRODUCEREMAIL.Text = (string) null;
    ((ARControl) this.txtHPRODUCEREMAIL).Top = 1.812f;
    ((ARControl) this.txtHPRODUCEREMAIL).Width = 3.063f;
    ((ARControl) this.txtHeader_ProducerContactFax).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtHeader_ProducerContactFax).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtHeader_ProducerContactFax).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtHeader_ProducerContactFax).Border.TopStyle = (BorderLineStyle) 1;
    this.txtHeader_ProducerContactFax.CanGrow = false;
    ((ARControl) this.txtHeader_ProducerContactFax).Height = 0.187f;
    ((ARControl) this.txtHeader_ProducerContactFax).Left = 6.937f;
    this.txtHeader_ProducerContactFax.MultiLine = false;
    ((ARControl) this.txtHeader_ProducerContactFax).Name = "txtHeader_ProducerContactFax";
    this.txtHeader_ProducerContactFax.Style = "font-family: Arial; font-size: 9pt; white-space: nowrap; ddo-char-set: 0";
    this.txtHeader_ProducerContactFax.Text = (string) null;
    ((ARControl) this.txtHeader_ProducerContactFax).Top = 1.625f;
    ((ARControl) this.txtHeader_ProducerContactFax).Width = 1.062167f;
    ((ARControl) this.Label55).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label55).Height = 0.125f;
    this.Label55.HyperLink = (string) null;
    ((ARControl) this.Label55).Left = 1.937f;
    ((ARControl) this.Label55).Name = "Label55";
    this.Label55.Style = "font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label55.Text = "CERTIFICATE NUMBER:";
    ((ARControl) this.Label55).Top = 3.312f;
    ((ARControl) this.Label55).Width = 45f / 32f;
    ((ARControl) this.Label81).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label81).Height = 0.125f;
    this.Label81.HyperLink = (string) null;
    ((ARControl) this.Label81).Left = 5.625f;
    ((ARControl) this.Label81).Name = "Label81";
    this.Label81.Style = "font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label81.Text = "REVISION NUMBER:";
    ((ARControl) this.Label81).Top = 3.312f;
    ((ARControl) this.Label81).Width = 19f / 16f;
    ((ARControl) this.txtCertificateHolder).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCertificateHolder).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCertificateHolder).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCertificateHolder).Border.TopStyle = (BorderLineStyle) 1;
    this.txtCertificateHolder.CanGrow = false;
    ((ARControl) this.txtCertificateHolder).DataField = "CERTIFICATE_HOLDER";
    ((ARControl) this.txtCertificateHolder).Height = 0.8929232f;
    ((ARControl) this.txtCertificateHolder).Left = 0.0f;
    ((ARControl) this.txtCertificateHolder).Name = "txtCertificateHolder";
    this.txtCertificateHolder.Style = "font-family: Arial; font-size: 9pt; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.txtCertificateHolder.Text = (string) null;
    ((ARControl) this.txtCertificateHolder).Top = 9.25f;
    ((ARControl) this.txtCertificateHolder).Width = 4f;
    ((ARControl) this.txtWC_DISEASE_POLICY).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_DISEASE_POLICY).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_DISEASE_POLICY).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtWC_DISEASE_POLICY).Border.TopStyle = (BorderLineStyle) 1;
    this.txtWC_DISEASE_POLICY.CanGrow = false;
    this.txtWC_DISEASE_POLICY.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtWC_DISEASE_POLICY).Height = 0.1869998f;
    ((ARControl) this.txtWC_DISEASE_POLICY).Left = 6.875f;
    ((ARControl) this.txtWC_DISEASE_POLICY).Name = "txtWC_DISEASE_POLICY";
    this.txtWC_DISEASE_POLICY.OutputFormat = componentResourceManager.GetString("txtWC_DISEASE_POLICY.OutputFormat");
    this.txtWC_DISEASE_POLICY.Style = "font-size: 9pt; text-align: left";
    this.txtWC_DISEASE_POLICY.Text = " ";
    ((ARControl) this.txtWC_DISEASE_POLICY).Top = 7.5f;
    ((ARControl) this.txtWC_DISEASE_POLICY).Width = 1.121833f;
    ((ARControl) this.Picture1).Height = 0.4265833f;
    this.Picture1.HyperLink = (string) null;
    this.Picture1.ImageData = (Stream) componentResourceManager.GetObject("Picture1.ImageData");
    ((ARControl) this.Picture1).Left = 0.3f;
    ((ARControl) this.Picture1).Name = "Picture1";
    this.Picture1.SizeMode = (SizeModes) 2;
    ((ARControl) this.Picture1).Top = 0.01041667f;
    ((ARControl) this.Picture1).Width = 0.95f;
    ((ARControl) this.Label84).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label84).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label84).Height = 0.3750003f;
    this.Label84.HyperLink = (string) null;
    ((ARControl) this.Label84).Left = 4.198f;
    ((ARControl) this.Label84).Name = "Label84";
    this.Label84.Style = "font-size: 6.75pt; font-weight: bold; text-align: left; ddo-char-set: 0";
    this.Label84.Text = "SHOULD ANY OF THE ABOVE DESCRIBED POLICIES BE CANCELLED BEFORE THE EXPIRATION DATE THEREOF, NOTICE WILL BE DELIVERED IN ACCORDANCE WITH THE POLICY PROVISIONS.";
    ((ARControl) this.Label84).Top = 9.25f;
    ((ARControl) this.Label84).Width = 3.604167f;
    ((ARControl) this.Label47).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label47).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label47).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label47).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label47).Height = 0.5619998f;
    this.Label47.HyperLink = (string) null;
    ((ARControl) this.Label47).Left = 0.0f;
    ((ARControl) this.Label47).Name = "Label47";
    this.Label47.Style = "";
    this.Label47.Text = "";
    ((ARControl) this.Label47).Top = 6.375f;
    ((ARControl) this.Label47).Width = 0.25f;
    ((ARControl) this.Label53).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label53).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label53).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label53).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label53).Height = 0.7499999f;
    this.Label53.HyperLink = (string) null;
    ((ARControl) this.Label53).Left = 0.0f;
    ((ARControl) this.Label53).Name = "Label53";
    this.Label53.Style = "";
    this.Label53.Text = "";
    ((ARControl) this.Label53).Top = 6.937f;
    ((ARControl) this.Label53).Width = 0.25f;
    ((ARControl) this.label49).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label49).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label49).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label49).Height = 0.1869999f;
    this.label49.HyperLink = (string) null;
    ((ARControl) this.label49).Left = 4f;
    ((ARControl) this.label49).Name = "label49";
    this.label49.Style = "font-size: 6pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.label49.Text = "  INSURER E:";
    ((ARControl) this.label49).Top = 2.937001f;
    ((ARControl) this.label49).Width = 0.8120003f;
    ((ARControl) this.txtINSURER_E).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_E).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_E).Border.TopStyle = (BorderLineStyle) 1;
    this.txtINSURER_E.CanGrow = false;
    ((ARControl) this.txtINSURER_E).DataField = "INSURER_E";
    ((ARControl) this.txtINSURER_E).Height = 0.1869999f;
    ((ARControl) this.txtINSURER_E).Left = 4.812f;
    this.txtINSURER_E.MultiLine = false;
    ((ARControl) this.txtINSURER_E).Name = "txtINSURER_E";
    this.txtINSURER_E.Style = "font-family: Arial; font-size: 9pt; white-space: nowrap; ddo-char-set: 0";
    this.txtINSURER_E.Text = (string) null;
    ((ARControl) this.txtINSURER_E).Top = 2.937001f;
    ((ARControl) this.txtINSURER_E).Width = 2.313f;
    ((ARControl) this.txtINSURER_E_NAIC).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_E_NAIC).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_E_NAIC).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_E_NAIC).Border.TopStyle = (BorderLineStyle) 1;
    this.txtINSURER_E_NAIC.CanGrow = false;
    ((ARControl) this.txtINSURER_E_NAIC).DataField = "INSURER_E_NAIC";
    ((ARControl) this.txtINSURER_E_NAIC).Height = 0.1869999f;
    ((ARControl) this.txtINSURER_E_NAIC).Left = 7.125f;
    ((ARControl) this.txtINSURER_E_NAIC).Name = "txtINSURER_E_NAIC";
    this.txtINSURER_E_NAIC.Style = "font-family: Arial; font-size: 9pt; ddo-char-set: 0";
    this.txtINSURER_E_NAIC.Text = (string) null;
    ((ARControl) this.txtINSURER_E_NAIC).Top = 2.937001f;
    ((ARControl) this.txtINSURER_E_NAIC).Width = 0.872416f;
    ((ARControl) this.label86).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label86).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label86).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label86).Height = 0.1869999f;
    this.label86.HyperLink = (string) null;
    ((ARControl) this.label86).Left = 4f;
    ((ARControl) this.label86).Name = "label86";
    this.label86.Style = "font-size: 6pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.label86.Text = "  INSURER F:";
    ((ARControl) this.label86).Top = 3.125f;
    ((ARControl) this.label86).Width = 0.8120003f;
    ((ARControl) this.txtINSURER_F).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_F).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_F).Border.TopStyle = (BorderLineStyle) 1;
    this.txtINSURER_F.CanGrow = false;
    ((ARControl) this.txtINSURER_F).DataField = "INSURER_F";
    ((ARControl) this.txtINSURER_F).Height = 0.1869999f;
    ((ARControl) this.txtINSURER_F).Left = 4.812f;
    this.txtINSURER_F.MultiLine = false;
    ((ARControl) this.txtINSURER_F).Name = "txtINSURER_F";
    this.txtINSURER_F.Style = "font-family: Arial; font-size: 9pt; white-space: nowrap; ddo-char-set: 0";
    this.txtINSURER_F.Text = (string) null;
    ((ARControl) this.txtINSURER_F).Top = 3.125f;
    ((ARControl) this.txtINSURER_F).Width = 2.313f;
    ((ARControl) this.txtINSURER_F_NAIC).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_F_NAIC).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_F_NAIC).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURER_F_NAIC).Border.TopStyle = (BorderLineStyle) 1;
    this.txtINSURER_F_NAIC.CanGrow = false;
    ((ARControl) this.txtINSURER_F_NAIC).DataField = "INSURER_F_NAIC";
    ((ARControl) this.txtINSURER_F_NAIC).Height = 0.1869999f;
    ((ARControl) this.txtINSURER_F_NAIC).Left = 7.125f;
    ((ARControl) this.txtINSURER_F_NAIC).Name = "txtINSURER_F_NAIC";
    this.txtINSURER_F_NAIC.Style = "font-family: Arial; font-size: 9pt; ddo-char-set: 0";
    this.txtINSURER_F_NAIC.Text = (string) null;
    ((ARControl) this.txtINSURER_F_NAIC).Top = 3.125f;
    ((ARControl) this.txtINSURER_F_NAIC).Width = 0.872416f;
    ((ARControl) this.label41).Height = 0.1870004f;
    this.label41.HyperLink = (string) null;
    ((ARControl) this.label41).Left = 0.494f;
    ((ARControl) this.label41).Name = "label41";
    this.label41.Style = "font-size: 6pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.label41.Text = "COMMERCIAL GENERAL LIABILITY";
    ((ARControl) this.label41).Top = 4.125f;
    ((ARControl) this.label41).Width = 1.506f;
    ((ARControl) this.label87).Height = 0.1879996f;
    this.label87.HyperLink = (string) null;
    ((ARControl) this.label87).Left = 0.625f;
    ((ARControl) this.label87).Name = "label87";
    this.label87.Style = "font-size: 6pt; font-weight: normal; text-align: center; text-decoration: none; vertical-align: middle; ddo-char-set: 1";
    this.label87.Text = "CLAIMS-MADE";
    ((ARControl) this.label87).Top = 4.312f;
    ((ARControl) this.label87).Width = 0.598f;
    ((ARControl) this.label89).Height = 0.1879996f;
    this.label89.HyperLink = (string) null;
    ((ARControl) this.label89).Left = 1.562f;
    ((ARControl) this.label89).Name = "label89";
    this.label89.Style = "font-size: 6pt; font-weight: normal; text-align: center; text-decoration: none; vertical-align: middle; ddo-char-set: 1";
    this.label89.Text = "OCCUR";
    ((ARControl) this.label89).Top = 4.312f;
    ((ARControl) this.label89).Width = 0.4600003f;
    ((ARControl) this.label91).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label91).Height = 0.1979998f;
    this.label91.HyperLink = (string) null;
    ((ARControl) this.label91).Left = 0.5f;
    ((ARControl) this.label91).Name = "label91";
    this.label91.Style = "font-size: 6pt; font-weight: normal; text-align: center; text-decoration: none; vertical-align: bottom; ddo-char-set: 1";
    this.label91.Text = "";
    ((ARControl) this.label91).Top = 4.5f;
    ((ARControl) this.label91).Width = 1.641f;
    ((ARControl) this.label93).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label93).Height = 0.1870001f;
    this.label93.HyperLink = (string) null;
    ((ARControl) this.label93).Left = 0.5f;
    ((ARControl) this.label93).Name = "label93";
    this.label93.Style = "font-size: 6pt; font-weight: normal; text-align: center; text-decoration: none; vertical-align: middle; ddo-char-set: 1";
    this.label93.Text = "";
    ((ARControl) this.label93).Top = 4.687f;
    ((ARControl) this.label93).Width = 1.641f;
    ((ARControl) this.label94).Height = 0.1870001f;
    this.label94.HyperLink = (string) null;
    ((ARControl) this.label94).Left = 0.437f;
    ((ARControl) this.label94).Name = "label94";
    this.label94.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: bottom; ddo-char-set: 1";
    this.label94.Text = "POLICY";
    ((ARControl) this.label94).Top = 5.062f;
    ((ARControl) this.label94).Width = 0.385f;
    ((ARControl) this.label95).Height = 0.1249999f;
    this.label95.HyperLink = (string) null;
    ((ARControl) this.label95).Left = 1.187f;
    ((ARControl) this.label95).Name = "label95";
    this.label95.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: top; ddo-char-set: 1";
    this.label95.Text = "PRO-";
    ((ARControl) this.label95).Top = 5.062f;
    ((ARControl) this.label95).Width = 0.307f;
    ((ARControl) this.label96).Height = 0.1880001f;
    this.label96.HyperLink = (string) null;
    ((ARControl) this.label96).Left = 1.812f;
    ((ARControl) this.label96).Name = "label96";
    this.label96.Style = "font-size: 6pt; font-weight: normal; text-align: center; text-decoration: none; vertical-align: bottom; ddo-char-set: 1";
    this.label96.Text = "LOC";
    ((ARControl) this.label96).Top = 5.062f;
    ((ARControl) this.label96).Width = 0.2879998f;
    ((ARControl) this.label97).Height = 0.1869997f;
    this.label97.HyperLink = (string) null;
    ((ARControl) this.label97).Left = 0.437f;
    ((ARControl) this.label97).Name = "label97";
    this.label97.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 1";
    this.label97.Text = "OTHER:";
    ((ARControl) this.label97).Top = 5.25f;
    ((ARControl) this.label97).Width = 0.3850001f;
    ((ARControl) this.label46).Height = 0.187f;
    this.label46.HyperLink = (string) null;
    ((ARControl) this.label46).Left = 0.25f;
    ((ARControl) this.label46).Name = "label46";
    this.label46.Style = "font-size: 6pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.label46.Text = "AUTOMOBILE LIABILITY";
    ((ARControl) this.label46).Top = 5.437f;
    ((ARControl) this.label46).Width = 1.461f;
    ((ARControl) this.label99).Height = 0.1880001f;
    this.label99.HyperLink = (string) null;
    ((ARControl) this.label99).Left = 0.4370003f;
    ((ARControl) this.label99).Name = "label99";
    this.label99.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: bottom; ddo-char-set: 1";
    this.label99.Text = "ANY AUTO";
    ((ARControl) this.label99).Top = 5.624f;
    ((ARControl) this.label99).Width = 0.6879998f;
    ((ARControl) this.shape29).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape29).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape29).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape29).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape29).Height = 0.1880001f;
    ((ARControl) this.shape29).Left = 0.25f;
    ((ARControl) this.shape29).Name = "shape29";
    this.shape29.RoundingRadius = new CornersRadius(new float?(10f), new float?(), new float?(), new float?(), new float?());
    ((ARControl) this.shape29).Top = 6.562f;
    ((ARControl) this.shape29).Width = 0.1870003f;
    ((ARControl) this.shape30).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape30).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape30).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape30).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape30).Height = 0.1869997f;
    ((ARControl) this.shape30).Left = 0.25f;
    ((ARControl) this.shape30).Name = "shape30";
    this.shape30.RoundingRadius = new CornersRadius(new float?(10f), new float?(), new float?(), new float?(), new float?());
    ((ARControl) this.shape30).Top = 6.75f;
    ((ARControl) this.shape30).Width = 0.1870005f;
    ((ARControl) this.label104).Height = 0.1869997f;
    this.label104.HyperLink = (string) null;
    ((ARControl) this.label104).Left = 1.5f;
    ((ARControl) this.label104).Name = "label104";
    this.label104.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 1";
    this.label104.Text = "OCCUR";
    ((ARControl) this.label104).Top = 6.375f;
    ((ARControl) this.label104).Width = 0.6870001f;
    ((ARControl) this.label107).Height = 0.1880001f;
    this.label107.HyperLink = (string) null;
    ((ARControl) this.label107).Left = 1.5f;
    ((ARControl) this.label107).Name = "label107";
    this.label107.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 1";
    this.label107.Text = "CLAIMS-MADE";
    ((ARControl) this.label107).Top = 6.562f;
    ((ARControl) this.label107).Width = 0.687f;
    ((ARControl) this.shape33).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape33).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape33).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape33).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape33).Height = 0.1880001f;
    ((ARControl) this.shape33).Left = 0.687f;
    ((ARControl) this.shape33).Name = "shape33";
    this.shape33.RoundingRadius = new CornersRadius(new float?(10f), new float?(), new float?(), new float?(), new float?());
    ((ARControl) this.shape33).Top = 6.75f;
    ((ARControl) this.shape33).Width = 0.1879997f;
    ((ARControl) this.label109).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label109).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label109).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label109).Height = 0.1869997f;
    this.label109.HyperLink = (string) null;
    ((ARControl) this.label109).Left = 0.875f;
    ((ARControl) this.label109).Name = "label109";
    this.label109.Style = "font-size: 6pt; font-weight: normal; text-align: center; text-decoration: none; vertical-align: middle; ddo-char-set: 1";
    this.label109.Text = "RETENTION $";
    ((ARControl) this.label109).Top = 6.75f;
    ((ARControl) this.label109).Width = 0.6249999f;
    ((ARControl) this.txtUMBR_RETENTION_AMT).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_RETENTION_AMT).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_RETENTION_AMT).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_RETENTION_AMT).Height = 0.1869997f;
    this.txtUMBR_RETENTION_AMT.HyperLink = (string) null;
    ((ARControl) this.txtUMBR_RETENTION_AMT).Left = 1.5f;
    ((ARControl) this.txtUMBR_RETENTION_AMT).Name = "txtUMBR_RETENTION_AMT";
    this.txtUMBR_RETENTION_AMT.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 1";
    this.txtUMBR_RETENTION_AMT.Text = "";
    ((ARControl) this.txtUMBR_RETENTION_AMT).Top = 6.75f;
    ((ARControl) this.txtUMBR_RETENTION_AMT).Width = 0.6870001f;
    ((ARControl) this.shape28).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape28).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape28).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape28).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.shape28).Height = 0.1880001f;
    ((ARControl) this.shape28).Left = 0.25f;
    ((ARControl) this.shape28).Name = "shape28";
    this.shape28.RoundingRadius = new CornersRadius(new float?(10f), new float?(), new float?(), new float?(), new float?());
    ((ARControl) this.shape28).Top = 6.375f;
    ((ARControl) this.shape28).Width = 0.188f;
    ((ARControl) this.label112).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label112).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label112).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label112).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label112).Height = 0.1869999f;
    this.label112.HyperLink = (string) null;
    ((ARControl) this.label112).Left = 5.625f;
    ((ARControl) this.label112).Name = "label112";
    this.label112.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: bottom; ddo-char-set: 0";
    this.label112.Text = "EACH OCCURRENCE";
    ((ARControl) this.label112).Top = 6.375f;
    ((ARControl) this.label112).Width = 1.25f;
    ((ARControl) this.label113).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label113).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label113).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label113).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label113).Height = 0.1880003f;
    this.label113.HyperLink = (string) null;
    ((ARControl) this.label113).Left = 5.625f;
    ((ARControl) this.label113).Name = "label113";
    this.label113.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: bottom; ddo-char-set: 0";
    this.label113.Text = "AGGREGATE";
    ((ARControl) this.label113).Top = 6.562f;
    ((ARControl) this.label113).Width = 1.25f;
    ((ARControl) this.label114).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label114).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label114).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label114).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label114).Height = 0.187f;
    this.label114.HyperLink = (string) null;
    ((ARControl) this.label114).Left = 5.625f;
    ((ARControl) this.label114).Name = "label114";
    this.label114.Style = "font-size: 6pt; font-weight: normal; text-align: center; text-decoration: none; vertical-align: bottom; ddo-char-set: 0";
    this.label114.Text = "";
    ((ARControl) this.label114).Top = 6.75f;
    ((ARControl) this.label114).Width = 1.25f;
    ((ARControl) this.txtUMBR_LIMIT_EACH_OCC).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_LIMIT_EACH_OCC).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_LIMIT_EACH_OCC).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_LIMIT_EACH_OCC).Border.TopStyle = (BorderLineStyle) 1;
    this.txtUMBR_LIMIT_EACH_OCC.CanGrow = false;
    this.txtUMBR_LIMIT_EACH_OCC.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtUMBR_LIMIT_EACH_OCC).Height = 0.1869999f;
    ((ARControl) this.txtUMBR_LIMIT_EACH_OCC).Left = 6.875f;
    ((ARControl) this.txtUMBR_LIMIT_EACH_OCC).Name = "txtUMBR_LIMIT_EACH_OCC";
    this.txtUMBR_LIMIT_EACH_OCC.OutputFormat = componentResourceManager.GetString("txtUMBR_LIMIT_EACH_OCC.OutputFormat");
    this.txtUMBR_LIMIT_EACH_OCC.Style = "font-size: 9pt; text-align: left";
    this.txtUMBR_LIMIT_EACH_OCC.Text = " ";
    ((ARControl) this.txtUMBR_LIMIT_EACH_OCC).Top = 6.375f;
    ((ARControl) this.txtUMBR_LIMIT_EACH_OCC).Width = 1.121833f;
    ((ARControl) this.txtUMBR_LIMIT_GEN_AGG).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_LIMIT_GEN_AGG).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_LIMIT_GEN_AGG).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUMBR_LIMIT_GEN_AGG).Border.TopStyle = (BorderLineStyle) 1;
    this.txtUMBR_LIMIT_GEN_AGG.CanGrow = false;
    this.txtUMBR_LIMIT_GEN_AGG.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.txtUMBR_LIMIT_GEN_AGG).Height = 0.1880003f;
    ((ARControl) this.txtUMBR_LIMIT_GEN_AGG).Left = 6.875f;
    ((ARControl) this.txtUMBR_LIMIT_GEN_AGG).Name = "txtUMBR_LIMIT_GEN_AGG";
    this.txtUMBR_LIMIT_GEN_AGG.OutputFormat = componentResourceManager.GetString("txtUMBR_LIMIT_GEN_AGG.OutputFormat");
    this.txtUMBR_LIMIT_GEN_AGG.Style = "font-size: 9pt; text-align: left";
    this.txtUMBR_LIMIT_GEN_AGG.Text = " ";
    ((ARControl) this.txtUMBR_LIMIT_GEN_AGG).Top = 6.562f;
    ((ARControl) this.txtUMBR_LIMIT_GEN_AGG).Width = 1.121833f;
    ((ARControl) this.textBox18).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox18).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox18).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox18).Border.TopStyle = (BorderLineStyle) 1;
    this.textBox18.CanGrow = false;
    this.textBox18.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.textBox18).Height = 0.187f;
    ((ARControl) this.textBox18).Left = 6.875f;
    ((ARControl) this.textBox18).Name = "textBox18";
    this.textBox18.OutputFormat = componentResourceManager.GetString("textBox18.OutputFormat");
    this.textBox18.Style = "font-size: 9pt; text-align: left";
    this.textBox18.Text = " ";
    ((ARControl) this.textBox18).Top = 6.75f;
    ((ARControl) this.textBox18).Width = 1.121833f;
    this.textBox49.CanGrow = false;
    ((ARControl) this.textBox49).Height = 0.1250002f;
    ((ARControl) this.textBox49).Left = 1.937f;
    ((ARControl) this.textBox49).Name = "textBox49";
    this.textBox49.Style = "font-size: 6pt; font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 0";
    this.textBox49.Text = "Y / N";
    ((ARControl) this.textBox49).Top = 7.062f;
    ((ARControl) this.textBox49).Width = 0.22f;
    ((ARControl) this.textBox51).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox51).Border.RightStyle = (BorderLineStyle) 1;
    this.textBox51.CanGrow = false;
    ((ARControl) this.textBox51).Height = 0.1880004f;
    ((ARControl) this.textBox51).Left = 2.187f;
    ((ARControl) this.textBox51).Name = "textBox51";
    this.textBox51.Style = "font-size: 6pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.textBox51.Text = "N / A";
    ((ARControl) this.textBox51).Top = 7.187f;
    ((ARControl) this.textBox51).Width = 0.2499998f;
    ((ARControl) this.label69).Height = 0.188f;
    this.label69.HyperLink = (string) null;
    ((ARControl) this.label69).Left = 0.06200001f;
    this.label69.MultiLine = false;
    ((ARControl) this.label69).Name = "label69";
    this.label69.Style = "font-size: 8.25pt; font-weight: bold; text-align: left; text-justify: distribute-all-lines; white-space: nowrap; ddo-char-set: 0; ddo-shrink-to-fit: none; ddo-wrap-mode: nowrap";
    this.label69.Text = "CERTIFICATE DOES NOT AFFIRMATIVELY OR NEGATIVELY AMEND, EXTEND OR ALTER THE COVERAGE AFFORDED BY THE POLICIES";
    ((ARControl) this.label69).Top = 0.562f;
    ((ARControl) this.label69).Width = 7.75f;
    ((ARControl) this.label36).Height = 0.188f;
    this.label36.HyperLink = (string) null;
    ((ARControl) this.label36).Left = 0.06200001f;
    this.label36.MultiLine = false;
    ((ARControl) this.label36).Name = "label36";
    this.label36.Style = "font-size: 8.25pt; font-weight: bold; text-align: left; text-justify: distribute-all-lines; white-space: nowrap; ddo-char-set: 0; ddo-shrink-to-fit: none; ddo-wrap-mode: nowrap";
    this.label36.Text = "BELOW. THIS CERTIFICATE OF INSURANCE DOES NOT CONSTITUTE A CONTRACT BETWEEN THE ISSUING INSURER(S), AUTHORIZED";
    ((ARControl) this.label36).Top = 0.687f;
    ((ARControl) this.label36).Width = 7.75f;
    ((ARControl) this.label70).Height = 0.188f;
    this.label70.HyperLink = (string) null;
    ((ARControl) this.label70).Left = 0.06200001f;
    this.label70.MultiLine = false;
    ((ARControl) this.label70).Name = "label70";
    this.label70.Style = "font-size: 8.25pt; font-weight: bold; text-align: left; text-justify: distribute; white-space: nowrap; ddo-char-set: 0; ddo-shrink-to-fit: none; ddo-wrap-mode: nowrap";
    this.label70.Text = "REPRESENTATIVE OR PRODUCER, AND THE CERTIFICATE HOLDER.";
    ((ARControl) this.label70).Top = 0.812f;
    ((ARControl) this.label70).Width = 7.75f;
    ((ARControl) this.label2).Height = 0.1870001f;
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Left = 0.06200001f;
    this.label2.MultiLine = false;
    ((ARControl) this.label2).Name = "label2";
    this.label2.Style = "font-size: 8pt; font-weight: bold; text-align: left; text-justify: distribute-all-lines; ddo-char-set: 1; ddo-shrink-to-fit: none";
    this.label2.Text = "IMPORTANT: If the certificate holder is an ADDITIONAL INSURED, the policy(ies) must have ADDITIONAL INSURED provisions or be endorsed.";
    ((ARControl) this.label2).Top = 1f;
    ((ARControl) this.label2).Width = 7.75f;
    ((ARControl) this.label71).Height = 0.1870001f;
    this.label71.HyperLink = (string) null;
    ((ARControl) this.label71).Left = 0.06200001f;
    this.label71.MultiLine = false;
    ((ARControl) this.label71).Name = "label71";
    this.label71.Style = "font-size: 8pt; font-weight: bold; text-align: left; text-justify: distribute-all-lines; ddo-char-set: 1; ddo-shrink-to-fit: none";
    this.label71.Text = "If SUBROGATION IS WAIVED, subject to the terms and conditions of the policy, certain policies may require an endorsement. A statement on";
    ((ARControl) this.label71).Top = 1.125f;
    ((ARControl) this.label71).Width = 7.75f;
    ((ARControl) this.label72).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label72).Height = 0.187f;
    this.label72.HyperLink = (string) null;
    ((ARControl) this.label72).Left = 0.062f;
    this.label72.MultiLine = false;
    ((ARControl) this.label72).Name = "label72";
    this.label72.Style = "font-size: 8pt; font-weight: bold; text-align: left; text-justify: distribute; white-space: nowrap; ddo-char-set: 0; ddo-shrink-to-fit: none; ddo-wrap-mode: nowrap";
    this.label72.Text = "this certificate does not confer rights to the certificate holder in lieu of such endorsement(s).";
    ((ARControl) this.label72).Top = 1.25f;
    ((ARControl) this.label72).Width = 5.066f;
    ((ARControl) this.label116).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label116).Height = 0.1879999f;
    this.label116.HyperLink = (string) null;
    ((ARControl) this.label116).Left = 0.125f;
    this.label116.MultiLine = false;
    ((ARControl) this.label116).Name = "label116";
    this.label116.Style = "font-size: 6.75pt; font-weight: normal; text-align: left; text-justify: distribute-all-lines; white-space: nowrap; ddo-char-set: 0; ddo-shrink-to-fit: none; ddo-wrap-mode: nowrap";
    this.label116.Text = "THIS IS TO CERTIFY THAT THE POLICIES OF INSURANCE LISTED BELOW HAVE BEEN ISSUED TO THE INSURED NAMED ABOVE FOR THE POLICY PERIOD";
    ((ARControl) this.label116).Top = 3.437f;
    ((ARControl) this.label116).Width = 7.687f;
    ((ARControl) this.label117).Height = 0.1879999f;
    this.label117.HyperLink = (string) null;
    ((ARControl) this.label117).Left = 0.125f;
    this.label117.MultiLine = false;
    ((ARControl) this.label117).Name = "label117";
    this.label117.Style = "font-size: 6.75pt; font-weight: normal; text-align: left; text-justify: distribute-all-lines; white-space: nowrap; ddo-char-set: 0; ddo-shrink-to-fit: none; ddo-wrap-mode: nowrap";
    this.label117.Text = "INDICATED. NOTWITHSTANDING ANY REQUIREMENT, TERM OR CONDITION OF ANY CONTRACT OR OTHER DOCUMENT WITH RESPECT TO WHICH THIS";
    ((ARControl) this.label117).Top = 3.562f;
    ((ARControl) this.label117).Width = 7.687f;
    ((ARControl) this.label118).Height = 0.1879999f;
    this.label118.HyperLink = (string) null;
    ((ARControl) this.label118).Left = 0.125f;
    this.label118.MultiLine = false;
    ((ARControl) this.label118).Name = "label118";
    this.label118.Style = "font-size: 6.75pt; font-weight: normal; text-align: left; text-justify: distribute-all-lines; white-space: nowrap; ddo-char-set: 0; ddo-shrink-to-fit: none; ddo-wrap-mode: nowrap";
    this.label118.Text = "CERTIFICATE MAY BE ISSUED OR MAY PERTAIN, THE INSURANCE AFFORDED BY THE POLICIES DESCRIBED HEREIN IS SUBJECT TO ALL THE TERMS,";
    ((ARControl) this.label118).Top = 3.687f;
    ((ARControl) this.label118).Width = 7.687f;
    ((ARControl) this.label119).Height = 0.1879996f;
    this.label119.HyperLink = (string) null;
    ((ARControl) this.label119).Left = 0.125f;
    this.label119.MultiLine = false;
    ((ARControl) this.label119).Name = "label119";
    this.label119.Style = "font-size: 6.75pt; font-weight: normal; text-align: left; text-justify: auto; white-space: nowrap; ddo-char-set: 0; ddo-shrink-to-fit: none; ddo-wrap-mode: nowrap";
    this.label119.Text = "EXCLUSIONS AND CONDITIONS OF SUCH POLICIES. LIMITS SHOWN MAY HAVE BEEN REDUCED BY PAID CLAIMS.";
    ((ARControl) this.label119).Top = 3.812f;
    ((ARControl) this.label119).Width = 5.497f;
    ((ARControl) this.label45).Height = 0.1249998f;
    this.label45.HyperLink = (string) null;
    ((ARControl) this.label45).Left = 1.187f;
    ((ARControl) this.label45).Name = "label45";
    this.label45.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 1";
    this.label45.Text = "JECT";
    ((ARControl) this.label45).Top = 5.187001f;
    ((ARControl) this.label45).Width = 0.3130001f;
    ((ARControl) this.label5).Height = 0.1870005f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 5.625f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 0";
    this.label5.Text = "PREMISES (Ea occurance)";
    ((ARControl) this.label5).Top = 4.375f;
    ((ARControl) this.label5).Width = 1.050001f;
    ((ARControl) this.txtPRODUCER).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPRODUCER).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPRODUCER).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPRODUCER).Border.TopStyle = (BorderLineStyle) 1;
    this.txtPRODUCER.CanGrow = false;
    ((ARControl) this.txtPRODUCER).DataField = "PRODUCER";
    ((ARControl) this.txtPRODUCER).Height = 0.938f;
    ((ARControl) this.txtPRODUCER).Left = 0.0f;
    ((ARControl) this.txtPRODUCER).Name = "txtPRODUCER";
    this.txtPRODUCER.Padding = new PaddingEx(10, 10, 0, 0);
    this.txtPRODUCER.Style = "font-family: Arial; font-size: 9pt; text-align: left; ddo-char-set: 0";
    this.txtPRODUCER.Text = (string) null;
    ((ARControl) this.txtPRODUCER).Top = 1.437f;
    ((ARControl) this.txtPRODUCER).Width = 4f;
    ((ARControl) this.Label62).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label62).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label62).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label62).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label62).Height = 0.1880001f;
    this.Label62.HyperLink = (string) null;
    ((ARControl) this.Label62).Left = 5.625f;
    ((ARControl) this.Label62).Name = "Label62";
    this.Label62.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: bottom; ddo-char-set: 0";
    this.Label62.Text = "PRODUCTS - COMP/OP AGG";
    ((ARControl) this.Label62).Top = 5.084f;
    ((ARControl) this.Label62).Width = 1.25f;
    ((ARControl) this.TextBox43).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox43).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox43).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox43).Border.TopStyle = (BorderLineStyle) 1;
    this.TextBox43.CanGrow = false;
    this.TextBox43.CurrencyCulture = new CultureInfo("en-US");
    ((ARControl) this.TextBox43).Height = 0.166f;
    ((ARControl) this.TextBox43).Left = 6.875f;
    ((ARControl) this.TextBox43).Name = "TextBox43";
    this.TextBox43.OutputFormat = componentResourceManager.GetString("TextBox43.OutputFormat");
    this.TextBox43.Style = "font-size: 9pt; text-align: left";
    this.TextBox43.Text = " ";
    ((ARControl) this.TextBox43).Top = 5.272f;
    ((ARControl) this.TextBox43).Width = 1.122f;
    ((ARControl) this.Label63).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label63).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label63).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label63).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label63).Height = 0.165f;
    this.Label63.HyperLink = (string) null;
    ((ARControl) this.Label63).Left = 5.625f;
    ((ARControl) this.Label63).Name = "Label63";
    this.Label63.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: bottom; ddo-char-set: 0";
    this.Label63.Text = "";
    ((ARControl) this.Label63).Top = 5.272f;
    ((ARControl) this.Label63).Width = 1.25f;
    ((ARControl) this.Label170).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label170).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label170).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label170).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label170).Height = 0.187f;
    this.Label170.HyperLink = (string) null;
    ((ARControl) this.Label170).Left = 0.25f;
    ((ARControl) this.Label170).Name = "Label170";
    this.Label170.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.Label170.Text = "X";
    ((ARControl) this.Label170).Top = 4.125f;
    ((ARControl) this.Label170).Visible = false;
    ((ARControl) this.Label170).Width = 0.187f;
    ((ARControl) this.txtPRODUCERFAX).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPRODUCERFAX).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPRODUCERFAX).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPRODUCERFAX).Border.TopStyle = (BorderLineStyle) 1;
    this.txtPRODUCERFAX.CanGrow = false;
    ((ARControl) this.txtPRODUCERFAX).DataField = "PRODUCERFAX";
    ((ARControl) this.txtPRODUCERFAX).Height = 0.187f;
    ((ARControl) this.txtPRODUCERFAX).Left = 6.937f;
    this.txtPRODUCERFAX.MultiLine = false;
    ((ARControl) this.txtPRODUCERFAX).Name = "txtPRODUCERFAX";
    this.txtPRODUCERFAX.Style = "font-family: Arial; font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 0";
    this.txtPRODUCERFAX.Text = (string) null;
    ((ARControl) this.txtPRODUCERFAX).Top = 1.625f;
    ((ARControl) this.txtPRODUCERFAX).Width = 1.063f;
    ((ARControl) this.txtPRODUCERCONTACT).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPRODUCERCONTACT).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPRODUCERCONTACT).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPRODUCERCONTACT).Border.TopStyle = (BorderLineStyle) 1;
    this.txtPRODUCERCONTACT.CanGrow = false;
    ((ARControl) this.txtPRODUCERCONTACT).DataField = "PRODUCERCONTACT";
    ((ARControl) this.txtPRODUCERCONTACT).Height = 0.188f;
    ((ARControl) this.txtPRODUCERCONTACT).Left = 4.937f;
    this.txtPRODUCERCONTACT.MultiLine = false;
    ((ARControl) this.txtPRODUCERCONTACT).Name = "txtPRODUCERCONTACT";
    this.txtPRODUCERCONTACT.Style = "font-family: Arial; font-size: 8.25pt; white-space: nowrap; ddo-char-set: 0";
    this.txtPRODUCERCONTACT.Text = (string) null;
    ((ARControl) this.txtPRODUCERCONTACT).Top = 1.437f;
    ((ARControl) this.txtPRODUCERCONTACT).Width = 3.063f;
    ((ARControl) this.txtPRODUCERPHONE).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPRODUCERPHONE).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPRODUCERPHONE).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPRODUCERPHONE).Border.TopStyle = (BorderLineStyle) 1;
    this.txtPRODUCERPHONE.CanGrow = false;
    ((ARControl) this.txtPRODUCERPHONE).Height = 0.187f;
    ((ARControl) this.txtPRODUCERPHONE).Left = 4.937f;
    this.txtPRODUCERPHONE.MultiLine = false;
    ((ARControl) this.txtPRODUCERPHONE).Name = "txtPRODUCERPHONE";
    this.txtPRODUCERPHONE.Style = "font-family: Arial; font-size: 8.25pt; vertical-align: middle; white-space: nowrap; ddo-char-set: 0";
    this.txtPRODUCERPHONE.Text = (string) null;
    ((ARControl) this.txtPRODUCERPHONE).Top = 1.625f;
    ((ARControl) this.txtPRODUCERPHONE).Width = 1.063f;
    ((ARControl) this.label108).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label108).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.label108).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.label108).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label108).Height = 0.1869997f;
    this.label108.HyperLink = (string) null;
    ((ARControl) this.label108).Left = 0.4370003f;
    ((ARControl) this.label108).Name = "label108";
    this.label108.Style = "font-size: 6pt; font-weight: normal; text-align: center; text-decoration: none; vertical-align: middle; ddo-char-set: 1";
    this.label108.Text = "DED";
    ((ARControl) this.label108).Top = 6.75f;
    ((ARControl) this.label108).Width = 0.254f;
    this.textBox57.CanGrow = false;
    ((ARControl) this.textBox57).Height = 0.2499998f;
    ((ARControl) this.textBox57).Left = 0.25f;
    this.textBox57.MultiLine = false;
    ((ARControl) this.textBox57).Name = "textBox57";
    this.textBox57.Style = "font-size: 6pt; font-weight: bold; text-align: left; vertical-align: bottom; white-space: nowrap; ddo-char-set: 1; ddo-wrap-mode: nowrap";
    this.textBox57.Text = "AND EMPLOYERS' LIABILITY";
    ((ARControl) this.textBox57).Top = 6.937f;
    ((ARControl) this.textBox57).Width = 1.209f;
    this.textBox58.CanGrow = false;
    ((ARControl) this.textBox58).Height = 0.1869998f;
    ((ARControl) this.textBox58).Left = 0.25f;
    this.textBox58.MultiLine = false;
    ((ARControl) this.textBox58).Name = "textBox58";
    this.textBox58.Style = "font-size: 6pt; font-weight: normal; text-align: left; vertical-align: bottom; white-space: nowrap; ddo-char-set: 0; ddo-wrap-mode: nowrap";
    this.textBox58.Text = "DESCRIPTION OF OPERATIONS below";
    ((ARControl) this.textBox58).Top = 7.5f;
    ((ARControl) this.textBox58).Width = 1.624583f;
    ((ARControl) this.txtDATEISSUED).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDATEISSUED).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDATEISSUED).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDATEISSUED).DataField = "DATEISSUED";
    ((ARControl) this.txtDATEISSUED).Height = 5f / 32f;
    ((ARControl) this.txtDATEISSUED).Left = 6.797f;
    ((ARControl) this.txtDATEISSUED).Name = "txtDATEISSUED";
    this.txtDATEISSUED.OutputFormat = componentResourceManager.GetString("txtDATEISSUED.OutputFormat");
    this.txtDATEISSUED.Style = "text-align: center";
    this.txtDATEISSUED.Text = (string) null;
    ((ARControl) this.txtDATEISSUED).Top = 0.187f;
    ((ARControl) this.txtDATEISSUED).Width = 1.2f;
    ((ARControl) this.lblINSURED_ID).Height = 0.2f;
    this.lblINSURED_ID.HyperLink = (string) null;
    ((ARControl) this.lblINSURED_ID).Left = 2.812f;
    ((ARControl) this.lblINSURED_ID).Name = "lblINSURED_ID";
    this.lblINSURED_ID.Style = "font-size: 9pt";
    this.lblINSURED_ID.Text = "ID";
    ((ARControl) this.lblINSURED_ID).Top = 3.125f;
    ((ARControl) this.lblINSURED_ID).Visible = false;
    ((ARControl) this.lblINSURED_ID).Width = 0.187f;
    ((ARControl) this.lblPRODUCER_ID).Height = 0.2f;
    this.lblPRODUCER_ID.HyperLink = (string) null;
    ((ARControl) this.lblPRODUCER_ID).Left = 2.812f;
    ((ARControl) this.lblPRODUCER_ID).Name = "lblPRODUCER_ID";
    this.lblPRODUCER_ID.Style = "font-size: 9pt";
    this.lblPRODUCER_ID.Text = "ID";
    ((ARControl) this.lblPRODUCER_ID).Top = 2.187f;
    ((ARControl) this.lblPRODUCER_ID).Visible = false;
    ((ARControl) this.lblPRODUCER_ID).Width = 0.187f;
    ((ARControl) this.txtPRODUCER_ID).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPRODUCER_ID).DataField = "PRODUCER_ID";
    ((ARControl) this.txtPRODUCER_ID).Height = 0.2f;
    ((ARControl) this.txtPRODUCER_ID).Left = 3f;
    ((ARControl) this.txtPRODUCER_ID).Name = "txtPRODUCER_ID";
    this.txtPRODUCER_ID.Style = "font-size: 9pt; text-align: right";
    this.txtPRODUCER_ID.Text = (string) null;
    ((ARControl) this.txtPRODUCER_ID).Top = 2.187f;
    ((ARControl) this.txtPRODUCER_ID).Visible = false;
    ((ARControl) this.txtPRODUCER_ID).Width = 1f;
    ((ARControl) this.txtINSURED_ID).Border.BottomColor = Color.Transparent;
    ((ARControl) this.txtINSURED_ID).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURED_ID).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtINSURED_ID).DataField = "INSURED_ID";
    ((ARControl) this.txtINSURED_ID).Height = 0.2f;
    ((ARControl) this.txtINSURED_ID).Left = 3f;
    ((ARControl) this.txtINSURED_ID).Name = "txtINSURED_ID";
    this.txtINSURED_ID.Style = "font-size: 9pt; text-align: right";
    this.txtINSURED_ID.Text = (string) null;
    ((ARControl) this.txtINSURED_ID).Top = 3.125f;
    ((ARControl) this.txtINSURED_ID).Visible = false;
    ((ARControl) this.txtINSURED_ID).Width = 1f;
    ((ARControl) this.txtCERTIFICATE_NUMBER).DataField = "CERTIFICATE_NUMBER";
    ((ARControl) this.txtCERTIFICATE_NUMBER).Height = 0.25f;
    ((ARControl) this.txtCERTIFICATE_NUMBER).Left = 3.375f;
    ((ARControl) this.txtCERTIFICATE_NUMBER).Name = "txtCERTIFICATE_NUMBER";
    this.txtCERTIFICATE_NUMBER.Style = "font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.txtCERTIFICATE_NUMBER.Text = "0000-0000-00";
    ((ARControl) this.txtCERTIFICATE_NUMBER).Top = 3.25f;
    ((ARControl) this.txtCERTIFICATE_NUMBER).Width = 2.156f;
    ((ARControl) this.GL_LTR).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.GL_LTR).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.GL_LTR).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.GL_LTR).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.GL_LTR).Height = 1.312f;
    this.GL_LTR.HyperLink = (string) null;
    ((ARControl) this.GL_LTR).Left = 0.0f;
    ((ARControl) this.GL_LTR).Name = "GL_LTR";
    this.GL_LTR.Style = "text-align: center; vertical-align: middle";
    this.GL_LTR.Text = "A";
    ((ARControl) this.GL_LTR).Top = 4.125f;
    ((ARControl) this.GL_LTR).Visible = false;
    ((ARControl) this.GL_LTR).Width = 0.25f;
    ((ARControl) this.BA_LTR).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_LTR).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_LTR).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_LTR).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_LTR).Height = 0.9369998f;
    this.BA_LTR.HyperLink = (string) null;
    ((ARControl) this.BA_LTR).Left = 0.0f;
    ((ARControl) this.BA_LTR).Name = "BA_LTR";
    this.BA_LTR.Style = "text-align: center; vertical-align: middle";
    this.BA_LTR.Text = "A";
    ((ARControl) this.BA_LTR).Top = 5.437f;
    ((ARControl) this.BA_LTR).Visible = false;
    ((ARControl) this.BA_LTR).Width = 0.25f;
    ((ARControl) this.UMBR_LTR).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_LTR).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_LTR).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_LTR).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_LTR).Height = 0.5619998f;
    this.UMBR_LTR.HyperLink = (string) null;
    ((ARControl) this.UMBR_LTR).Left = 0.0f;
    ((ARControl) this.UMBR_LTR).Name = "UMBR_LTR";
    this.UMBR_LTR.Style = "text-align: center; vertical-align: middle";
    this.UMBR_LTR.Text = "A";
    ((ARControl) this.UMBR_LTR).Top = 6.375f;
    ((ARControl) this.UMBR_LTR).Visible = false;
    ((ARControl) this.UMBR_LTR).Width = 0.25f;
    ((ARControl) this.WC_LTR).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_LTR).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_LTR).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_LTR).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_LTR).Height = 0.75f;
    this.WC_LTR.HyperLink = (string) null;
    ((ARControl) this.WC_LTR).Left = 0.0f;
    ((ARControl) this.WC_LTR).Name = "WC_LTR";
    this.WC_LTR.Style = "text-align: center; vertical-align: middle";
    this.WC_LTR.Text = "A";
    ((ARControl) this.WC_LTR).Top = 6.937f;
    ((ARControl) this.WC_LTR).Visible = false;
    ((ARControl) this.WC_LTR).Width = 0.25f;
    ((ARControl) this.EXTRA_LTR).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.EXTRA_LTR).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.EXTRA_LTR).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.EXTRA_LTR).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.EXTRA_LTR).Height = 0.5000001f;
    this.EXTRA_LTR.HyperLink = (string) null;
    ((ARControl) this.EXTRA_LTR).Left = 0.0f;
    ((ARControl) this.EXTRA_LTR).Name = "EXTRA_LTR";
    this.EXTRA_LTR.Style = "text-align: center; vertical-align: middle";
    this.EXTRA_LTR.Text = "A";
    ((ARControl) this.EXTRA_LTR).Top = 7.687f;
    ((ARControl) this.EXTRA_LTR).Visible = false;
    ((ARControl) this.EXTRA_LTR).Width = 0.25f;
    ((ARControl) this.BA_NON_OWNED).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_NON_OWNED).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_NON_OWNED).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_NON_OWNED).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_NON_OWNED).Height = 0.1880004f;
    this.BA_NON_OWNED.HyperLink = (string) null;
    ((ARControl) this.BA_NON_OWNED).Left = 1.187f;
    ((ARControl) this.BA_NON_OWNED).Name = "BA_NON_OWNED";
    this.BA_NON_OWNED.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.BA_NON_OWNED.Text = "X";
    ((ARControl) this.BA_NON_OWNED).Top = 5.999f;
    ((ARControl) this.BA_NON_OWNED).Visible = false;
    ((ARControl) this.BA_NON_OWNED).Width = 0.1870003f;
    ((ARControl) this.BA_SCHEDULED).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_SCHEDULED).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_SCHEDULED).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_SCHEDULED).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_SCHEDULED).Height = 0.1829998f;
    this.BA_SCHEDULED.HyperLink = (string) null;
    ((ARControl) this.BA_SCHEDULED).Left = 1.187f;
    ((ARControl) this.BA_SCHEDULED).Name = "BA_SCHEDULED";
    this.BA_SCHEDULED.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.BA_SCHEDULED.Text = "X";
    ((ARControl) this.BA_SCHEDULED).Top = 5.812f;
    ((ARControl) this.BA_SCHEDULED).Visible = false;
    ((ARControl) this.BA_SCHEDULED).Width = 0.1879997f;
    ((ARControl) this.BA_OTHER_1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_OTHER_1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_OTHER_1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_OTHER_1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_OTHER_1).Height = 0.1829998f;
    this.BA_OTHER_1.HyperLink = (string) null;
    ((ARControl) this.BA_OTHER_1).Left = 0.25f;
    ((ARControl) this.BA_OTHER_1).Name = "BA_OTHER_1";
    this.BA_OTHER_1.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.BA_OTHER_1.Text = "X";
    ((ARControl) this.BA_OTHER_1).Top = 6.187f;
    ((ARControl) this.BA_OTHER_1).Visible = false;
    ((ARControl) this.BA_OTHER_1).Width = 0.1879997f;
    ((ARControl) this.BA_HIRED).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_HIRED).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_HIRED).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_HIRED).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_HIRED).Height = 0.1880004f;
    this.BA_HIRED.HyperLink = (string) null;
    ((ARControl) this.BA_HIRED).Left = 0.25f;
    ((ARControl) this.BA_HIRED).Name = "BA_HIRED";
    this.BA_HIRED.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.BA_HIRED.Text = "X";
    ((ARControl) this.BA_HIRED).Top = 5.999f;
    ((ARControl) this.BA_HIRED).Visible = false;
    ((ARControl) this.BA_HIRED).Width = 0.1879997f;
    ((ARControl) this.BA_ALL_OWNED).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_ALL_OWNED).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_ALL_OWNED).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_ALL_OWNED).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_ALL_OWNED).Height = 0.1829998f;
    this.BA_ALL_OWNED.HyperLink = (string) null;
    ((ARControl) this.BA_ALL_OWNED).Left = 0.25f;
    ((ARControl) this.BA_ALL_OWNED).Name = "BA_ALL_OWNED";
    this.BA_ALL_OWNED.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.BA_ALL_OWNED.Text = "X";
    ((ARControl) this.BA_ALL_OWNED).Top = 5.812f;
    ((ARControl) this.BA_ALL_OWNED).Visible = false;
    ((ARControl) this.BA_ALL_OWNED).Width = 0.1870003f;
    ((ARControl) this.BA_ANY).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_ANY).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_ANY).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_ANY).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_ANY).Height = 0.1880004f;
    this.BA_ANY.HyperLink = (string) null;
    ((ARControl) this.BA_ANY).Left = 0.25f;
    ((ARControl) this.BA_ANY).Name = "BA_ANY";
    this.BA_ANY.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.BA_ANY.Text = "X";
    ((ARControl) this.BA_ANY).Top = 5.624f;
    ((ARControl) this.BA_ANY).Visible = false;
    ((ARControl) this.BA_ANY).Width = 0.1879997f;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_OTHER).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_OTHER).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_OTHER).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_OTHER).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_OTHER).Height = 0.1829998f;
    this.COMMERCIAL_GL_LIMIT_OTHER.HyperLink = (string) null;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_OTHER).Left = 0.25f;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_OTHER).Name = "COMMERCIAL_GL_LIMIT_OTHER";
    this.COMMERCIAL_GL_LIMIT_OTHER.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.COMMERCIAL_GL_LIMIT_OTHER.Text = "X";
    ((ARControl) this.COMMERCIAL_GL_LIMIT_OTHER).Top = 5.25f;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_OTHER).Visible = false;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_OTHER).Width = 0.1879997f;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_LOC).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_LOC).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_LOC).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_LOC).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_LOC).Height = 0.187f;
    this.COMMERCIAL_GL_LIMIT_LOC.HyperLink = (string) null;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_LOC).Left = 1.625f;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_LOC).Name = "COMMERCIAL_GL_LIMIT_LOC";
    this.COMMERCIAL_GL_LIMIT_LOC.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.COMMERCIAL_GL_LIMIT_LOC.Text = "X";
    ((ARControl) this.COMMERCIAL_GL_LIMIT_LOC).Top = 5.062f;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_LOC).Visible = false;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_LOC).Width = 0.1879997f;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_PROJECT).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_PROJECT).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_PROJECT).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_PROJECT).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_PROJECT).Height = 0.1879999f;
    this.COMMERCIAL_GL_LIMIT_PROJECT.HyperLink = (string) null;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_PROJECT).Left = 0.9370003f;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_PROJECT).Name = "COMMERCIAL_GL_LIMIT_PROJECT";
    this.COMMERCIAL_GL_LIMIT_PROJECT.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.COMMERCIAL_GL_LIMIT_PROJECT.Text = "X";
    ((ARControl) this.COMMERCIAL_GL_LIMIT_PROJECT).Top = 5.062f;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_PROJECT).Visible = false;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_PROJECT).Width = 0.1870003f;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_POLICY).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_POLICY).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_POLICY).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_POLICY).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_POLICY).Height = 0.1880004f;
    this.COMMERCIAL_GL_LIMIT_POLICY.HyperLink = (string) null;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_POLICY).Left = 0.25f;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_POLICY).Name = "COMMERCIAL_GL_LIMIT_POLICY";
    this.COMMERCIAL_GL_LIMIT_POLICY.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.COMMERCIAL_GL_LIMIT_POLICY.Text = "X";
    ((ARControl) this.COMMERCIAL_GL_LIMIT_POLICY).Top = 5.062f;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_POLICY).Visible = false;
    ((ARControl) this.COMMERCIAL_GL_LIMIT_POLICY).Width = 0.1879997f;
    ((ARControl) this.COMMERCIAL_GL_OTHER_2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_OTHER_2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_OTHER_2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_OTHER_2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_OTHER_2).Height = 0.1870005f;
    this.COMMERCIAL_GL_OTHER_2.HyperLink = (string) null;
    ((ARControl) this.COMMERCIAL_GL_OTHER_2).Left = 0.25f;
    ((ARControl) this.COMMERCIAL_GL_OTHER_2).Name = "COMMERCIAL_GL_OTHER_2";
    this.COMMERCIAL_GL_OTHER_2.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.COMMERCIAL_GL_OTHER_2.Text = "X";
    ((ARControl) this.COMMERCIAL_GL_OTHER_2).Top = 4.687f;
    ((ARControl) this.COMMERCIAL_GL_OTHER_2).Visible = false;
    ((ARControl) this.COMMERCIAL_GL_OTHER_2).Width = 0.1879997f;
    ((ARControl) this.COMMERCIAL_GL_OTHER_1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_OTHER_1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_OTHER_1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_OTHER_1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_OTHER_1).Height = 0.187f;
    this.COMMERCIAL_GL_OTHER_1.HyperLink = (string) null;
    ((ARControl) this.COMMERCIAL_GL_OTHER_1).Left = 0.25f;
    ((ARControl) this.COMMERCIAL_GL_OTHER_1).Name = "COMMERCIAL_GL_OTHER_1";
    this.COMMERCIAL_GL_OTHER_1.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.COMMERCIAL_GL_OTHER_1.Text = "X";
    ((ARControl) this.COMMERCIAL_GL_OTHER_1).Top = 4.5f;
    ((ARControl) this.COMMERCIAL_GL_OTHER_1).Visible = false;
    ((ARControl) this.COMMERCIAL_GL_OTHER_1).Width = 0.1870003f;
    ((ARControl) this.COMMERCIAL_GL_OCCUR).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_OCCUR).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_OCCUR).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_OCCUR).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_OCCUR).Height = 0.187f;
    this.COMMERCIAL_GL_OCCUR.HyperLink = (string) null;
    ((ARControl) this.COMMERCIAL_GL_OCCUR).Left = 1.375f;
    ((ARControl) this.COMMERCIAL_GL_OCCUR).Name = "COMMERCIAL_GL_OCCUR";
    this.COMMERCIAL_GL_OCCUR.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.COMMERCIAL_GL_OCCUR.Text = "X";
    ((ARControl) this.COMMERCIAL_GL_OCCUR).Top = 4.312f;
    ((ARControl) this.COMMERCIAL_GL_OCCUR).Visible = false;
    ((ARControl) this.COMMERCIAL_GL_OCCUR).Width = 0.187f;
    ((ARControl) this.COMMERCIAL_GL_CLAIMS_MADE).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_CLAIMS_MADE).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_CLAIMS_MADE).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_CLAIMS_MADE).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_CLAIMS_MADE).Height = 0.187f;
    this.COMMERCIAL_GL_CLAIMS_MADE.HyperLink = (string) null;
    ((ARControl) this.COMMERCIAL_GL_CLAIMS_MADE).Left = 0.437f;
    ((ARControl) this.COMMERCIAL_GL_CLAIMS_MADE).Name = "COMMERCIAL_GL_CLAIMS_MADE";
    this.COMMERCIAL_GL_CLAIMS_MADE.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.COMMERCIAL_GL_CLAIMS_MADE.Text = "X";
    ((ARControl) this.COMMERCIAL_GL_CLAIMS_MADE).Top = 4.312f;
    ((ARControl) this.COMMERCIAL_GL_CLAIMS_MADE).Visible = false;
    ((ARControl) this.COMMERCIAL_GL_CLAIMS_MADE).Width = 0.187f;
    ((ARControl) this.WC_OTHER_LIMIT).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_OTHER_LIMIT).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_OTHER_LIMIT).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_OTHER_LIMIT).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_OTHER_LIMIT).Height = 0.187f;
    this.WC_OTHER_LIMIT.HyperLink = (string) null;
    ((ARControl) this.WC_OTHER_LIMIT).Left = 6.375f;
    ((ARControl) this.WC_OTHER_LIMIT).Name = "WC_OTHER_LIMIT";
    this.WC_OTHER_LIMIT.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.WC_OTHER_LIMIT.Text = "X";
    ((ARControl) this.WC_OTHER_LIMIT).Top = 6.937f;
    ((ARControl) this.WC_OTHER_LIMIT).Visible = false;
    ((ARControl) this.WC_OTHER_LIMIT).Width = 0.1879997f;
    ((ARControl) this.WC_STATUTORY_LIMIT).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_STATUTORY_LIMIT).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_STATUTORY_LIMIT).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_STATUTORY_LIMIT).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_STATUTORY_LIMIT).Height = 0.1829998f;
    this.WC_STATUTORY_LIMIT.HyperLink = (string) null;
    ((ARControl) this.WC_STATUTORY_LIMIT).Left = 5.625f;
    ((ARControl) this.WC_STATUTORY_LIMIT).Name = "WC_STATUTORY_LIMIT";
    this.WC_STATUTORY_LIMIT.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.WC_STATUTORY_LIMIT.Text = "X";
    ((ARControl) this.WC_STATUTORY_LIMIT).Top = 6.937f;
    ((ARControl) this.WC_STATUTORY_LIMIT).Visible = false;
    ((ARControl) this.WC_STATUTORY_LIMIT).Width = 0.1880007f;
    ((ARControl) this.WC_ANY_EXCLUDED).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_ANY_EXCLUDED).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_ANY_EXCLUDED).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_ANY_EXCLUDED).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_ANY_EXCLUDED).Height = 0.1880004f;
    this.WC_ANY_EXCLUDED.HyperLink = (string) null;
    ((ARControl) this.WC_ANY_EXCLUDED).Left = 1.937f;
    ((ARControl) this.WC_ANY_EXCLUDED).Name = "WC_ANY_EXCLUDED";
    this.WC_ANY_EXCLUDED.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.WC_ANY_EXCLUDED.Text = "X";
    ((ARControl) this.WC_ANY_EXCLUDED).Top = 7.187f;
    ((ARControl) this.WC_ANY_EXCLUDED).Visible = false;
    ((ARControl) this.WC_ANY_EXCLUDED).Width = 0.1880001f;
    ((ARControl) this.UMBR_RETENTION).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_RETENTION).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_RETENTION).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_RETENTION).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_RETENTION).Height = 0.187f;
    this.UMBR_RETENTION.HyperLink = (string) null;
    ((ARControl) this.UMBR_RETENTION).Left = 0.6869998f;
    ((ARControl) this.UMBR_RETENTION).Name = "UMBR_RETENTION";
    this.UMBR_RETENTION.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.UMBR_RETENTION.Text = "X";
    ((ARControl) this.UMBR_RETENTION).Top = 6.75f;
    ((ARControl) this.UMBR_RETENTION).Visible = false;
    ((ARControl) this.UMBR_RETENTION).Width = 0.1869998f;
    ((ARControl) this.UMBR_DEDUCTIBLE).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_DEDUCTIBLE).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_DEDUCTIBLE).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_DEDUCTIBLE).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_DEDUCTIBLE).Height = 0.1829998f;
    this.UMBR_DEDUCTIBLE.HyperLink = (string) null;
    ((ARControl) this.UMBR_DEDUCTIBLE).Left = 0.25f;
    ((ARControl) this.UMBR_DEDUCTIBLE).Name = "UMBR_DEDUCTIBLE";
    this.UMBR_DEDUCTIBLE.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.UMBR_DEDUCTIBLE.Text = "X";
    ((ARControl) this.UMBR_DEDUCTIBLE).Top = 6.75f;
    ((ARControl) this.UMBR_DEDUCTIBLE).Visible = false;
    ((ARControl) this.UMBR_DEDUCTIBLE).Width = 0.1880002f;
    ((ARControl) this.UMBR_CLAIMS_MADE).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_CLAIMS_MADE).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_CLAIMS_MADE).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_CLAIMS_MADE).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_CLAIMS_MADE).Height = 0.1829998f;
    this.UMBR_CLAIMS_MADE.HyperLink = (string) null;
    ((ARControl) this.UMBR_CLAIMS_MADE).Left = 1.312f;
    ((ARControl) this.UMBR_CLAIMS_MADE).Name = "UMBR_CLAIMS_MADE";
    this.UMBR_CLAIMS_MADE.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.UMBR_CLAIMS_MADE.Text = "X";
    ((ARControl) this.UMBR_CLAIMS_MADE).Top = 6.562f;
    ((ARControl) this.UMBR_CLAIMS_MADE).Visible = false;
    ((ARControl) this.UMBR_CLAIMS_MADE).Width = 0.1869998f;
    ((ARControl) this.UMBR_EXCESS_LIAB).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_EXCESS_LIAB).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_EXCESS_LIAB).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_EXCESS_LIAB).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_EXCESS_LIAB).Height = 0.1829998f;
    this.UMBR_EXCESS_LIAB.HyperLink = (string) null;
    ((ARControl) this.UMBR_EXCESS_LIAB).Left = 0.25f;
    ((ARControl) this.UMBR_EXCESS_LIAB).Name = "UMBR_EXCESS_LIAB";
    this.UMBR_EXCESS_LIAB.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.UMBR_EXCESS_LIAB.Text = "X";
    ((ARControl) this.UMBR_EXCESS_LIAB).Top = 6.562f;
    ((ARControl) this.UMBR_EXCESS_LIAB).Visible = false;
    ((ARControl) this.UMBR_EXCESS_LIAB).Width = 0.1869998f;
    ((ARControl) this.UMBR_OCCUR).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_OCCUR).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_OCCUR).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_OCCUR).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_OCCUR).Height = 0.187f;
    this.UMBR_OCCUR.HyperLink = (string) null;
    ((ARControl) this.UMBR_OCCUR).Left = 1.312f;
    ((ARControl) this.UMBR_OCCUR).Name = "UMBR_OCCUR";
    this.UMBR_OCCUR.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.UMBR_OCCUR.Text = "X";
    ((ARControl) this.UMBR_OCCUR).Top = 6.375f;
    ((ARControl) this.UMBR_OCCUR).Visible = false;
    ((ARControl) this.UMBR_OCCUR).Width = 0.1869998f;
    ((ARControl) this.UMBR_LIAB).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_LIAB).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_LIAB).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_LIAB).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_LIAB).Height = 0.187f;
    this.UMBR_LIAB.HyperLink = (string) null;
    ((ARControl) this.UMBR_LIAB).Left = 0.25f;
    ((ARControl) this.UMBR_LIAB).Name = "UMBR_LIAB";
    this.UMBR_LIAB.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.UMBR_LIAB.Text = "X";
    ((ARControl) this.UMBR_LIAB).Top = 6.375f;
    ((ARControl) this.UMBR_LIAB).Visible = false;
    ((ARControl) this.UMBR_LIAB).Width = 0.1869998f;
    ((ARControl) this.BA_OTHER_2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_OTHER_2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_OTHER_2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_OTHER_2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_OTHER_2).Height = 0.1829998f;
    this.BA_OTHER_2.HyperLink = (string) null;
    ((ARControl) this.BA_OTHER_2).Left = 1.187f;
    ((ARControl) this.BA_OTHER_2).Name = "BA_OTHER_2";
    this.BA_OTHER_2.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.BA_OTHER_2.Text = "X";
    ((ARControl) this.BA_OTHER_2).Top = 6.187f;
    ((ARControl) this.BA_OTHER_2).Visible = false;
    ((ARControl) this.BA_OTHER_2).Width = 0.1879997f;
    ((ARControl) this.COMMERCIAL_GL_ADDL_INSURED).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_ADDL_INSURED).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_ADDL_INSURED).Height = 0.1870005f;
    this.COMMERCIAL_GL_ADDL_INSURED.HyperLink = (string) null;
    ((ARControl) this.COMMERCIAL_GL_ADDL_INSURED).Left = 2.187f;
    ((ARControl) this.COMMERCIAL_GL_ADDL_INSURED).Name = "COMMERCIAL_GL_ADDL_INSURED";
    this.COMMERCIAL_GL_ADDL_INSURED.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.COMMERCIAL_GL_ADDL_INSURED.Text = "X";
    ((ARControl) this.COMMERCIAL_GL_ADDL_INSURED).Top = 4.625f;
    ((ARControl) this.COMMERCIAL_GL_ADDL_INSURED).Visible = false;
    ((ARControl) this.COMMERCIAL_GL_ADDL_INSURED).Width = 0.25f;
    ((ARControl) this.COMMERCIAL_GL_SUBR_WVD).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_SUBR_WVD).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.COMMERCIAL_GL_SUBR_WVD).Height = 0.1829998f;
    this.COMMERCIAL_GL_SUBR_WVD.HyperLink = (string) null;
    ((ARControl) this.COMMERCIAL_GL_SUBR_WVD).Left = 2.437f;
    ((ARControl) this.COMMERCIAL_GL_SUBR_WVD).Name = "COMMERCIAL_GL_SUBR_WVD";
    this.COMMERCIAL_GL_SUBR_WVD.Style = "font-size: 12pt; text-align: center; vertical-align: top; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.COMMERCIAL_GL_SUBR_WVD.Text = "X";
    ((ARControl) this.COMMERCIAL_GL_SUBR_WVD).Top = 4.625f;
    ((ARControl) this.COMMERCIAL_GL_SUBR_WVD).Visible = false;
    ((ARControl) this.COMMERCIAL_GL_SUBR_WVD).Width = 0.25f;
    ((ARControl) this.EXTRA_ADDL_INSURED).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.EXTRA_ADDL_INSURED).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.EXTRA_ADDL_INSURED).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.EXTRA_ADDL_INSURED).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.EXTRA_ADDL_INSURED).Height = 0.5000002f;
    this.EXTRA_ADDL_INSURED.HyperLink = (string) null;
    ((ARControl) this.EXTRA_ADDL_INSURED).Left = 2.187f;
    ((ARControl) this.EXTRA_ADDL_INSURED).Name = "EXTRA_ADDL_INSURED";
    this.EXTRA_ADDL_INSURED.Style = "font-size: 12pt; text-align: center; vertical-align: middle; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.EXTRA_ADDL_INSURED.Text = "X";
    ((ARControl) this.EXTRA_ADDL_INSURED).Top = 7.687f;
    ((ARControl) this.EXTRA_ADDL_INSURED).Visible = false;
    ((ARControl) this.EXTRA_ADDL_INSURED).Width = 0.2499998f;
    ((ARControl) this.UMBR_ADDL_INSURED).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_ADDL_INSURED).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_ADDL_INSURED).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_ADDL_INSURED).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_ADDL_INSURED).Height = 0.562f;
    this.UMBR_ADDL_INSURED.HyperLink = (string) null;
    ((ARControl) this.UMBR_ADDL_INSURED).Left = 2.187f;
    ((ARControl) this.UMBR_ADDL_INSURED).Name = "UMBR_ADDL_INSURED";
    this.UMBR_ADDL_INSURED.Style = "font-size: 12pt; text-align: center; vertical-align: middle; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.UMBR_ADDL_INSURED.Text = "X";
    ((ARControl) this.UMBR_ADDL_INSURED).Top = 6.375f;
    ((ARControl) this.UMBR_ADDL_INSURED).Visible = false;
    ((ARControl) this.UMBR_ADDL_INSURED).Width = 0.25f;
    ((ARControl) this.BA_ADDL_INSURED).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_ADDL_INSURED).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_ADDL_INSURED).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_ADDL_INSURED).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_ADDL_INSURED).Height = 0.937f;
    this.BA_ADDL_INSURED.HyperLink = (string) null;
    ((ARControl) this.BA_ADDL_INSURED).Left = 2.187f;
    ((ARControl) this.BA_ADDL_INSURED).Name = "BA_ADDL_INSURED";
    this.BA_ADDL_INSURED.Style = "font-size: 12pt; text-align: center; vertical-align: middle; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.BA_ADDL_INSURED.Text = "X";
    ((ARControl) this.BA_ADDL_INSURED).Top = 5.437f;
    ((ARControl) this.BA_ADDL_INSURED).Visible = false;
    ((ARControl) this.BA_ADDL_INSURED).Width = 0.25f;
    ((ARControl) this.EXTRA_SUBR_WVD).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.EXTRA_SUBR_WVD).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.EXTRA_SUBR_WVD).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.EXTRA_SUBR_WVD).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.EXTRA_SUBR_WVD).Height = 0.5000002f;
    this.EXTRA_SUBR_WVD.HyperLink = (string) null;
    ((ARControl) this.EXTRA_SUBR_WVD).Left = 2.437f;
    ((ARControl) this.EXTRA_SUBR_WVD).Name = "EXTRA_SUBR_WVD";
    this.EXTRA_SUBR_WVD.Style = "font-size: 12pt; text-align: center; vertical-align: middle; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.EXTRA_SUBR_WVD.Text = "X";
    ((ARControl) this.EXTRA_SUBR_WVD).Top = 7.687f;
    ((ARControl) this.EXTRA_SUBR_WVD).Visible = false;
    ((ARControl) this.EXTRA_SUBR_WVD).Width = 0.2499998f;
    ((ARControl) this.UMBR_SUBR_WVD).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_SUBR_WVD).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_SUBR_WVD).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_SUBR_WVD).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.UMBR_SUBR_WVD).Height = 0.562f;
    this.UMBR_SUBR_WVD.HyperLink = (string) null;
    ((ARControl) this.UMBR_SUBR_WVD).Left = 2.437f;
    ((ARControl) this.UMBR_SUBR_WVD).Name = "UMBR_SUBR_WVD";
    this.UMBR_SUBR_WVD.Style = "font-size: 12pt; text-align: center; vertical-align: middle; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.UMBR_SUBR_WVD.Text = "X";
    ((ARControl) this.UMBR_SUBR_WVD).Top = 6.375f;
    ((ARControl) this.UMBR_SUBR_WVD).Visible = false;
    ((ARControl) this.UMBR_SUBR_WVD).Width = 0.2499998f;
    ((ARControl) this.BA_SUBR_WVD).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_SUBR_WVD).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_SUBR_WVD).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_SUBR_WVD).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.BA_SUBR_WVD).Height = 0.937f;
    this.BA_SUBR_WVD.HyperLink = (string) null;
    ((ARControl) this.BA_SUBR_WVD).Left = 2.437f;
    ((ARControl) this.BA_SUBR_WVD).Name = "BA_SUBR_WVD";
    this.BA_SUBR_WVD.Style = "font-size: 12pt; text-align: center; vertical-align: middle; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.BA_SUBR_WVD.Text = "X";
    ((ARControl) this.BA_SUBR_WVD).Top = 5.437f;
    ((ARControl) this.BA_SUBR_WVD).Visible = false;
    ((ARControl) this.BA_SUBR_WVD).Width = 0.2499998f;
    ((ARControl) this.WC_SUBR_WVD).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_SUBR_WVD).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_SUBR_WVD).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_SUBR_WVD).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.WC_SUBR_WVD).Height = 0.7500002f;
    this.WC_SUBR_WVD.HyperLink = (string) null;
    ((ARControl) this.WC_SUBR_WVD).Left = 2.437f;
    ((ARControl) this.WC_SUBR_WVD).Name = "WC_SUBR_WVD";
    this.WC_SUBR_WVD.Style = "font-size: 12pt; text-align: center; vertical-align: middle; white-space: nowrap; ddo-wrap-mode: nowrap";
    this.WC_SUBR_WVD.Text = "X";
    ((ARControl) this.WC_SUBR_WVD).Top = 6.937f;
    ((ARControl) this.WC_SUBR_WVD).Visible = false;
    ((ARControl) this.WC_SUBR_WVD).Width = 0.2499998f;
    ((ARControl) this.txtEXTRA_LIMIT_MESSAGE).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEXTRA_LIMIT_MESSAGE).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEXTRA_LIMIT_MESSAGE).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEXTRA_LIMIT_MESSAGE).Border.TopStyle = (BorderLineStyle) 1;
    this.txtEXTRA_LIMIT_MESSAGE.CanGrow = false;
    ((ARControl) this.txtEXTRA_LIMIT_MESSAGE).Height = 0.5f;
    ((ARControl) this.txtEXTRA_LIMIT_MESSAGE).Left = 5.625f;
    ((ARControl) this.txtEXTRA_LIMIT_MESSAGE).Name = "txtEXTRA_LIMIT_MESSAGE";
    this.txtEXTRA_LIMIT_MESSAGE.OutputFormat = componentResourceManager.GetString("txtEXTRA_LIMIT_MESSAGE.OutputFormat");
    this.txtEXTRA_LIMIT_MESSAGE.ShrinkToFit = true;
    this.txtEXTRA_LIMIT_MESSAGE.Style = "font-family: Arial; font-size: 8.25pt; text-align: left; vertical-align: top; ddo-char-set: 0; ddo-shrink-to-fit: true";
    this.txtEXTRA_LIMIT_MESSAGE.Text = " ";
    ((ARControl) this.txtEXTRA_LIMIT_MESSAGE).Top = 7.687f;
    ((ARControl) this.txtEXTRA_LIMIT_MESSAGE).Width = 2.371832f;
    ((ARControl) this.Label34).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label34).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label34).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label34).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label34).Height = 0.187f;
    this.Label34.HyperLink = (string) null;
    ((ARControl) this.Label34).Left = 4f;
    this.Label34.MultiLine = false;
    ((ARControl) this.Label34).Name = "Label34";
    this.Label34.Style = "font-size: 6pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label34.Text = "E-MAIL ADDRESS:";
    ((ARControl) this.Label34).Top = 1.812f;
    ((ARControl) this.Label34).Width = 0.937f;
    ((ARControl) this.label50).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.label50).Height = 0.188f;
    this.label50.HyperLink = (string) null;
    ((ARControl) this.label50).Left = 0.062f;
    this.label50.MultiLine = false;
    ((ARControl) this.label50).Name = "label50";
    this.label50.Style = "font-size: 8.25pt; font-weight: bold; text-align: left; text-justify: distribute-all-lines; white-space: nowrap; ddo-char-set: 0; ddo-shrink-to-fit: none; ddo-wrap-mode: nowrap";
    this.label50.Text = "THIS CERTIFICATE IS ISSUED AS A MATTER OF INFORMATION ONLY AND CONFERS NO RIGHTS UPON THE CERTIFICATE HOLDER. THIS";
    ((ARControl) this.label50).Top = 0.437f;
    ((ARControl) this.label50).Width = 7.75f;
    ((ARControl) this.Label6).Height = 0.1869996f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 0.437f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 1";
    this.Label6.Text = "OWNED AUTOS ONLY";
    ((ARControl) this.Label6).Top = 5.812f;
    ((ARControl) this.Label6).Width = 0.688f;
    ((ARControl) this.Label23).Height = 0.1888757f;
    this.Label23.HyperLink = (string) null;
    ((ARControl) this.Label23).Left = 0.4369998f;
    ((ARControl) this.Label23).Name = "Label23";
    this.Label23.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 1";
    this.Label23.Text = "HIRED AUTOS ONLY";
    ((ARControl) this.Label23).Top = 5.999f;
    ((ARControl) this.Label23).Width = 0.6880002f;
    ((ARControl) this.Label43).Height = 0.1888757f;
    this.Label43.HyperLink = (string) null;
    ((ARControl) this.Label43).Left = 1.375f;
    ((ARControl) this.Label43).Name = "Label43";
    this.Label43.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 1";
    this.Label43.Text = "SCHEDULED AUTOS";
    ((ARControl) this.Label43).Top = 5.812f;
    ((ARControl) this.Label43).Width = 0.585f;
    ((ARControl) this.Label73).Height = 0.1869996f;
    this.Label73.HyperLink = (string) null;
    ((ARControl) this.Label73).Left = 1.375f;
    ((ARControl) this.Label73).Name = "Label73";
    this.Label73.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 1";
    this.Label73.Text = "NON-OWNED AUTOS ONLY";
    ((ARControl) this.Label73).Top = 5.999f;
    ((ARControl) this.Label73).Width = 0.585f;
    ((ARControl) this.Label76).Height = 0.1250002f;
    this.Label76.HyperLink = (string) null;
    ((ARControl) this.Label76).Left = 5.625f;
    ((ARControl) this.Label76).Name = "Label76";
    this.Label76.Style = "font-family: Arial; font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: top; ddo-char-set: 0";
    this.Label76.Text = "COMBINED SINGLE LIMIT";
    ((ARControl) this.Label76).Top = 5.437f;
    ((ARControl) this.Label76).Width = 1.066709f;
    ((ARControl) this.Label82).Height = 0.187f;
    this.Label82.HyperLink = (string) null;
    ((ARControl) this.Label82).Left = 5.625f;
    ((ARControl) this.Label82).Name = "Label82";
    this.Label82.Style = "font-family: Arial; font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 0";
    this.Label82.Text = "(Ea accident)";
    ((ARControl) this.Label82).Top = 5.5f;
    ((ARControl) this.Label82).Width = 1.063f;
    ((ARControl) this.Label88).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label88).Height = 0.1250002f;
    this.Label88.HyperLink = (string) null;
    ((ARControl) this.Label88).Left = 5.625f;
    ((ARControl) this.Label88).Name = "Label88";
    this.Label88.Style = "font-family: Arial; font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: top; ddo-char-set: 0";
    this.Label88.Text = "PROPERTY DAMAGE";
    ((ARControl) this.Label88).Top = 6.021f;
    ((ARControl) this.Label88).Width = 1.066708f;
    ((ARControl) this.Label90).Height = 0.187f;
    this.Label90.HyperLink = (string) null;
    ((ARControl) this.Label90).Left = 5.625f;
    ((ARControl) this.Label90).Name = "Label90";
    this.Label90.Style = "font-family: Arial; font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 0";
    this.Label90.Text = "(Per accident)";
    ((ARControl) this.Label90).Top = 6.062f;
    ((ARControl) this.Label90).Width = 1.063f;
    ((ARControl) this.Label28).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label28).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label28).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label28).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label28).Height = 0.9369998f;
    this.Label28.HyperLink = (string) null;
    ((ARControl) this.Label28).Left = 2.437f;
    ((ARControl) this.Label28).Name = "Label28";
    this.Label28.Style = "";
    this.Label28.Text = "";
    ((ARControl) this.Label28).Top = 5.437f;
    ((ARControl) this.Label28).Width = 0.25f;
    ((ARControl) this.Label44).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label44).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label44).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label44).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label44).Height = 0.937f;
    this.Label44.HyperLink = (string) null;
    ((ARControl) this.Label44).Left = 2.187f;
    ((ARControl) this.Label44).Name = "Label44";
    this.Label44.Style = "";
    this.Label44.Text = "";
    ((ARControl) this.Label44).Top = 5.437f;
    ((ARControl) this.Label44).Width = 0.25f;
    ((ARControl) this.Label67).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label67).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label67).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label67).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label67).Height = 0.188f;
    this.Label67.HyperLink = (string) null;
    ((ARControl) this.Label67).Left = 1.187f;
    ((ARControl) this.Label67).Name = "Label67";
    this.Label67.Style = "";
    this.Label67.Text = "";
    ((ARControl) this.Label67).Top = 5.812f;
    ((ARControl) this.Label67).Width = 0.1879998f;
    ((ARControl) this.Label68).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label68).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label68).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label68).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label68).Height = 0.1880004f;
    this.Label68.HyperLink = (string) null;
    ((ARControl) this.Label68).Left = 1.187f;
    ((ARControl) this.Label68).Name = "Label68";
    this.Label68.Style = "";
    this.Label68.Text = "";
    ((ARControl) this.Label68).Top = 6f;
    ((ARControl) this.Label68).Width = 0.1879999f;
    ((ARControl) this.Label75).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label75).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label75).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label75).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label75).Height = 0.1879999f;
    this.Label75.HyperLink = (string) null;
    ((ARControl) this.Label75).Left = 1.187f;
    ((ARControl) this.Label75).Name = "Label75";
    this.Label75.Style = "";
    this.Label75.Text = "";
    ((ARControl) this.Label75).Top = 6.187f;
    ((ARControl) this.Label75).Width = 0.1879999f;
    ((ARControl) this.Label77).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label77).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label77).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label77).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label77).Height = 0.1880004f;
    this.Label77.HyperLink = (string) null;
    ((ARControl) this.Label77).Left = 0.25f;
    ((ARControl) this.Label77).Name = "Label77";
    this.Label77.Style = "";
    this.Label77.Text = "";
    ((ARControl) this.Label77).Top = 5.625f;
    ((ARControl) this.Label77).Width = 0.1879999f;
    ((ARControl) this.Label100).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label100).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label100).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label100).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label100).Height = 0.1879999f;
    this.Label100.HyperLink = (string) null;
    ((ARControl) this.Label100).Left = 0.25f;
    ((ARControl) this.Label100).Name = "Label100";
    this.Label100.Style = "";
    this.Label100.Text = "";
    ((ARControl) this.Label100).Top = 5.812f;
    ((ARControl) this.Label100).Width = 0.1879999f;
    ((ARControl) this.Label101).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label101).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label101).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label101).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label101).Height = 0.1880004f;
    this.Label101.HyperLink = (string) null;
    ((ARControl) this.Label101).Left = 0.25f;
    ((ARControl) this.Label101).Name = "Label101";
    this.Label101.Style = "";
    this.Label101.Text = "";
    ((ARControl) this.Label101).Top = 6f;
    ((ARControl) this.Label101).Width = 0.1879999f;
    ((ARControl) this.Label103).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label103).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label103).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label103).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label103).Height = 0.1879999f;
    this.Label103.HyperLink = (string) null;
    ((ARControl) this.Label103).Left = 0.25f;
    ((ARControl) this.Label103).Name = "Label103";
    this.Label103.Style = "";
    this.Label103.Text = "";
    ((ARControl) this.Label103).Top = 6.187f;
    ((ARControl) this.Label103).Width = 0.1879999f;
    ((ARControl) this.Label105).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label105).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label105).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label105).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label105).Height = 0.1879999f;
    this.Label105.HyperLink = (string) null;
    ((ARControl) this.Label105).Left = 0.25f;
    ((ARControl) this.Label105).Name = "Label105";
    this.Label105.Style = "";
    this.Label105.Text = "";
    ((ARControl) this.Label105).Top = 5.25f;
    ((ARControl) this.Label105).Width = 0.1879999f;
    ((ARControl) this.Label110).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label110).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label110).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label110).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label110).Height = 0.1879999f;
    this.Label110.HyperLink = (string) null;
    ((ARControl) this.Label110).Left = 0.25f;
    ((ARControl) this.Label110).Name = "Label110";
    this.Label110.Style = "";
    this.Label110.Text = "";
    ((ARControl) this.Label110).Top = 5.062f;
    ((ARControl) this.Label110).Width = 0.1879999f;
    ((ARControl) this.Label120).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label120).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label120).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label120).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label120).Height = 0.1879999f;
    this.Label120.HyperLink = (string) null;
    ((ARControl) this.Label120).Left = 0.937f;
    ((ARControl) this.Label120).Name = "Label120";
    this.Label120.Style = "";
    this.Label120.Text = "";
    ((ARControl) this.Label120).Top = 5.062f;
    ((ARControl) this.Label120).Width = 0.1879999f;
    ((ARControl) this.Label121).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label121).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label121).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label121).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label121).Height = 0.1879999f;
    this.Label121.HyperLink = (string) null;
    ((ARControl) this.Label121).Left = 1.625f;
    ((ARControl) this.Label121).Name = "Label121";
    this.Label121.Style = "";
    this.Label121.Text = "";
    ((ARControl) this.Label121).Top = 5.062f;
    ((ARControl) this.Label121).Width = 0.1879999f;
    ((ARControl) this.Label122).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label122).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label122).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label122).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label122).Height = 0.1879999f;
    this.Label122.HyperLink = (string) null;
    ((ARControl) this.Label122).Left = 0.25f;
    ((ARControl) this.Label122).Name = "Label122";
    this.Label122.Style = "";
    this.Label122.Text = "";
    ((ARControl) this.Label122).Top = 4.687f;
    ((ARControl) this.Label122).Width = 0.1879999f;
    ((ARControl) this.Label123).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label123).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label123).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label123).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label123).Height = 0.1879999f;
    this.Label123.HyperLink = (string) null;
    ((ARControl) this.Label123).Left = 0.25f;
    ((ARControl) this.Label123).Name = "Label123";
    this.Label123.Style = "";
    this.Label123.Text = "";
    ((ARControl) this.Label123).Top = 4.5f;
    ((ARControl) this.Label123).Width = 0.1879999f;
    ((ARControl) this.Label124).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label124).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label124).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label124).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label124).Height = 0.1879999f;
    this.Label124.HyperLink = (string) null;
    ((ARControl) this.Label124).Left = 0.437f;
    ((ARControl) this.Label124).Name = "Label124";
    this.Label124.Style = "";
    this.Label124.Text = "";
    ((ARControl) this.Label124).Top = 4.312f;
    ((ARControl) this.Label124).Width = 0.1879999f;
    ((ARControl) this.Label126).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label126).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label126).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label126).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label126).Height = 0.1879999f;
    this.Label126.HyperLink = (string) null;
    ((ARControl) this.Label126).Left = 0.25f;
    ((ARControl) this.Label126).Name = "Label126";
    this.Label126.Style = "";
    this.Label126.Text = "";
    ((ARControl) this.Label126).Top = 4.125f;
    ((ARControl) this.Label126).Width = 0.1879999f;
    ((ARControl) this.Label127).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label127).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label127).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label127).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label127).Height = 0.1879999f;
    this.Label127.HyperLink = (string) null;
    ((ARControl) this.Label127).Left = 1.375f;
    ((ARControl) this.Label127).Name = "Label127";
    this.Label127.Style = "";
    this.Label127.Text = "";
    ((ARControl) this.Label127).Top = 4.312f;
    ((ARControl) this.Label127).Width = 0.1879999f;
    ((ARControl) this.Label128).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label128).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label128).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label128).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label128).Height = 1.312f;
    this.Label128.HyperLink = (string) null;
    ((ARControl) this.Label128).Left = 0.0f;
    ((ARControl) this.Label128).Name = "Label128";
    this.Label128.Style = "";
    this.Label128.Text = "";
    ((ARControl) this.Label128).Top = 4.125f;
    ((ARControl) this.Label128).Width = 0.25f;
    ((ARControl) this.Label65).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label65).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label65).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label65).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label65).Height = 0.1879999f;
    this.Label65.HyperLink = (string) null;
    ((ARControl) this.Label65).Left = 1.312f;
    ((ARControl) this.Label65).Name = "Label65";
    this.Label65.Style = "";
    this.Label65.Text = "";
    ((ARControl) this.Label65).Top = 6.375f;
    ((ARControl) this.Label65).Width = 0.1879999f;
    ((ARControl) this.Label83).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label83).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label83).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label83).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label83).Height = 0.1879999f;
    this.Label83.HyperLink = (string) null;
    ((ARControl) this.Label83).Left = 1.312f;
    ((ARControl) this.Label83).Name = "Label83";
    this.Label83.Style = "";
    this.Label83.Text = "";
    ((ARControl) this.Label83).Top = 6.562f;
    ((ARControl) this.Label83).Width = 0.1879999f;
    ((ARControl) this.Label125).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label125).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label125).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label125).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label125).Height = 0.1879999f;
    this.Label125.HyperLink = (string) null;
    ((ARControl) this.Label125).Left = 6.375f;
    ((ARControl) this.Label125).Name = "Label125";
    this.Label125.Style = "";
    this.Label125.Text = "";
    ((ARControl) this.Label125).Top = 6.937f;
    ((ARControl) this.Label125).Width = 0.1879999f;
    ((ARControl) this.Label129).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label129).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label129).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label129).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label129).Height = 0.1879999f;
    this.Label129.HyperLink = (string) null;
    ((ARControl) this.Label129).Left = 5.625f;
    ((ARControl) this.Label129).Name = "Label129";
    this.Label129.Style = "";
    this.Label129.Text = "";
    ((ARControl) this.Label129).Top = 6.937f;
    ((ARControl) this.Label129).Width = 0.1879999f;
    ((ARControl) this.Label130).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label130).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label130).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label130).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label130).Height = 0.1879999f;
    this.Label130.HyperLink = (string) null;
    ((ARControl) this.Label130).Left = 1.937f;
    ((ARControl) this.Label130).Name = "Label130";
    this.Label130.Style = "";
    this.Label130.Text = "";
    ((ARControl) this.Label130).Top = 7.187f;
    ((ARControl) this.Label130).Width = 0.1879999f;
    ((ARControl) this.Label131).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label131).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label131).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label131).Height = 0.1250002f;
    this.Label131.HyperLink = (string) null;
    ((ARControl) this.Label131).Left = 5.812f;
    ((ARControl) this.Label131).Name = "Label131";
    this.Label131.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: top; ddo-char-set: 0";
    this.Label131.Text = "PER";
    ((ARControl) this.Label131).Top = 6.938001f;
    ((ARControl) this.Label131).Width = 0.5629997f;
    ((ARControl) this.Label132).Height = 0.1880004f;
    this.Label132.HyperLink = (string) null;
    ((ARControl) this.Label132).Left = 5.812f;
    ((ARControl) this.Label132).Name = "Label132";
    this.Label132.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 0";
    this.Label132.Text = "STATUTE";
    ((ARControl) this.Label132).Top = 7f;
    ((ARControl) this.Label132).Width = 0.5629997f;
    ((ARControl) this.Label135).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label135).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label135).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label135).Height = 0.1250002f;
    this.Label135.HyperLink = (string) null;
    ((ARControl) this.Label135).Left = 6.562f;
    ((ARControl) this.Label135).Name = "Label135";
    this.Label135.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: top; ddo-char-set: 0";
    this.Label135.Text = "OTH-";
    ((ARControl) this.Label135).Top = 6.937f;
    ((ARControl) this.Label135).Width = 0.3110003f;
    ((ARControl) this.Label136).Height = 0.187f;
    this.Label136.HyperLink = (string) null;
    ((ARControl) this.Label136).Left = 6.562f;
    ((ARControl) this.Label136).Name = "Label136";
    this.Label136.Style = "font-size: 6pt; font-weight: normal; text-align: left; text-decoration: none; vertical-align: middle; ddo-char-set: 0";
    this.Label136.Text = "ER";
    ((ARControl) this.Label136).Top = 7f;
    ((ARControl) this.Label136).Width = 0.3110003f;
    ((ARControl) this.Label111).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label111).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label111).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label111).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label111).Height = 0.9369998f;
    this.Label111.HyperLink = (string) null;
    ((ARControl) this.Label111).Left = 0.0f;
    ((ARControl) this.Label111).Name = "Label111";
    this.Label111.Style = "";
    this.Label111.Text = "";
    ((ARControl) this.Label111).Top = 5.437f;
    ((ARControl) this.Label111).Width = 0.25f;
    this.ReportHeader.Height = 0.0f;
    ((Section) this.ReportHeader).Name = "ReportHeader";
    ((Section) this.ReportFooter).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label8,
      (ARControl) this.Label39,
      (ARControl) this.Label40
    });
    this.ReportFooter.Height = 0.4166667f;
    ((Section) this.ReportFooter).Name = "ReportFooter";
    this.ReportFooter.PrintAtBottom = true;
    ((ARControl) this.Label8).Height = 0.147f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 0.06f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label8.Text = "ACORD 25 (2016/03)";
    ((ARControl) this.Label8).Top = 0.0f;
    ((ARControl) this.Label8).Width = 1.193f;
    ((ARControl) this.Label39).Height = 3f / 16f;
    this.Label39.HyperLink = (string) null;
    ((ARControl) this.Label39).Left = 2.253f;
    ((ARControl) this.Label39).Name = "Label39";
    this.Label39.Style = "font-size: 8.25pt; font-weight: bold; ddo-char-set: 0";
    this.Label39.Text = "The ACORD name and logo are registered marks of ACORD";
    ((ARControl) this.Label39).Top = 0.187f;
    ((ARControl) this.Label39).Width = 3.479f;
    ((ARControl) this.Label40).Height = 0.1354167f;
    this.Label40.HyperLink = (string) null;
    ((ARControl) this.Label40).Left = 4.614f;
    ((ARControl) this.Label40).Name = "Label40";
    this.Label40.Style = "font-size: 8.25pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label40.Text = "© 1988 - 2016 ACORD CORPORATION. All rights reserved.";
    ((ARControl) this.Label40).Top = 0.0f;
    ((ARControl) this.Label40).Width = 3.386f;
    ((ARControl) this.Shape1).Height = 0.1880004f;
    ((ARControl) this.Shape1).Left = 5.625f;
    ((ARControl) this.Shape1).Name = "Shape1";
    this.Shape1.RoundingRadius = new CornersRadius(new float?(10f), new float?(), new float?(), new float?(), new float?());
    ((ARControl) this.Shape1).Top = 6.021f;
    ((ARControl) this.Shape1).Width = 1.25f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.1f;
    this.PageSettings.Margins.Left = 0.2361111f;
    this.PageSettings.Margins.Right = 0.2402778f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 8.022f;
    this.Sections.Add((Section) this.ReportHeader);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtDESCRIPTION_OF_OPERATIONS).EndInit();
    ((ISupportInitialize) this.txtBA_POLICY_NO).EndInit();
    ((ISupportInitialize) this.TextBox28).EndInit();
    ((ISupportInitialize) this.label102).EndInit();
    ((ISupportInitialize) this.label106).EndInit();
    ((ISupportInitialize) this.label35).EndInit();
    ((ISupportInitialize) this.label52).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.label85).EndInit();
    ((ISupportInitialize) this.label92).EndInit();
    ((ISupportInitialize) this.label74).EndInit();
    ((ISupportInitialize) this.label98).EndInit();
    ((ISupportInitialize) this.txtINSURED).EndInit();
    ((ISupportInitialize) this.Picture).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_POLICY_EXP).EndInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_POLICY_NO).EndInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_POLICY_EFF).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label42).EndInit();
    ((ISupportInitialize) this.txtBA_POLICY_EFF).EndInit();
    ((ISupportInitialize) this.txtBA_POLICY_EXP).EndInit();
    ((ISupportInitialize) this.txtUMBR_POLICY_NO).EndInit();
    ((ISupportInitialize) this.txtUMBR_POLICY_EFF).EndInit();
    ((ISupportInitialize) this.txtUMBR_POLICY_EXP).EndInit();
    ((ISupportInitialize) this.Label48).EndInit();
    ((ISupportInitialize) this.txtWC_POLICY_NO).EndInit();
    ((ISupportInitialize) this.txtWC_POLICY_EFF).EndInit();
    ((ISupportInitialize) this.txtWC_POLICY_EXP).EndInit();
    ((ISupportInitialize) this.Label51).EndInit();
    ((ISupportInitialize) this.TextBox29).EndInit();
    ((ISupportInitialize) this.TextBox30).EndInit();
    ((ISupportInitialize) this.TextBox31).EndInit();
    ((ISupportInitialize) this.TextBox32).EndInit();
    ((ISupportInitialize) this.txtEXTRA_POLICY_NO).EndInit();
    ((ISupportInitialize) this.txtEXTRA_POLICY_EFF).EndInit();
    ((ISupportInitialize) this.txtEXTRA_POLICY_EXP).EndInit();
    ((ISupportInitialize) this.Label54).EndInit();
    ((ISupportInitialize) this.Label56).EndInit();
    ((ISupportInitialize) this.txtEXTRA_DESCRIPTION).EndInit();
    ((ISupportInitialize) this.Label57).EndInit();
    ((ISupportInitialize) this.Label58).EndInit();
    ((ISupportInitialize) this.Label59).EndInit();
    ((ISupportInitialize) this.Label60).EndInit();
    ((ISupportInitialize) this.Label61).EndInit();
    ((ISupportInitialize) this.Label64).EndInit();
    ((ISupportInitialize) this.Label66).EndInit();
    ((ISupportInitialize) this.Label78).EndInit();
    ((ISupportInitialize) this.Label79).EndInit();
    ((ISupportInitialize) this.Label80).EndInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC).EndInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED).EndInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_LIMIT_MED_EXP).EndInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY).EndInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG).EndInit();
    ((ISupportInitialize) this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG).EndInit();
    ((ISupportInitialize) this.txtBA_COMBINED_SINGLE_LIMIT).EndInit();
    ((ISupportInitialize) this.txtBA_BODILY_INJURY_PER_PERSON).EndInit();
    ((ISupportInitialize) this.txtBA_BODILY_INJURY_PER_ACCIDENT).EndInit();
    ((ISupportInitialize) this.txtBA_PROPERTY_DAMAGE).EndInit();
    ((ISupportInitialize) this.TextBox48).EndInit();
    ((ISupportInitialize) this.txtWC_OTHER_LIMIT_AMT).EndInit();
    ((ISupportInitialize) this.txtWC_EACH_ACCIDENT).EndInit();
    ((ISupportInitialize) this.txtWC_DISEASE_EACH_EMPLOYEE).EndInit();
    ((ISupportInitialize) this.txtFooter_Cancellation).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.label10).EndInit();
    ((ISupportInitialize) this.label31).EndInit();
    ((ISupportInitialize) this.label32).EndInit();
    ((ISupportInitialize) this.label33).EndInit();
    ((ISupportInitialize) this.Label22).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.Label19).EndInit();
    ((ISupportInitialize) this.Label20).EndInit();
    ((ISupportInitialize) this.Label21).EndInit();
    ((ISupportInitialize) this.txtINSURER_A).EndInit();
    ((ISupportInitialize) this.txtINSURER_B).EndInit();
    ((ISupportInitialize) this.txtINSURER_C).EndInit();
    ((ISupportInitialize) this.txtINSURER_D).EndInit();
    ((ISupportInitialize) this.txtINSURER_A_NAIC).EndInit();
    ((ISupportInitialize) this.txtINSURER_B_NAIC).EndInit();
    ((ISupportInitialize) this.txtINSURER_C_NAIC).EndInit();
    ((ISupportInitialize) this.txtINSURER_D_NAIC).EndInit();
    ((ISupportInitialize) this.Label26).EndInit();
    ((ISupportInitialize) this.Label24).EndInit();
    ((ISupportInitialize) this.Label25).EndInit();
    ((ISupportInitialize) this.Label27).EndInit();
    ((ISupportInitialize) this.Label29).EndInit();
    ((ISupportInitialize) this.Label30).EndInit();
    ((ISupportInitialize) this.Label37).EndInit();
    ((ISupportInitialize) this.label9).EndInit();
    ((ISupportInitialize) this.label38).EndInit();
    ((ISupportInitialize) this.txtHPRODUCEREMAIL).EndInit();
    ((ISupportInitialize) this.txtHeader_ProducerContactFax).EndInit();
    ((ISupportInitialize) this.Label55).EndInit();
    ((ISupportInitialize) this.Label81).EndInit();
    ((ISupportInitialize) this.txtCertificateHolder).EndInit();
    ((ISupportInitialize) this.txtWC_DISEASE_POLICY).EndInit();
    ((ISupportInitialize) this.Picture1).EndInit();
    ((ISupportInitialize) this.Label84).EndInit();
    ((ISupportInitialize) this.Label47).EndInit();
    ((ISupportInitialize) this.Label53).EndInit();
    ((ISupportInitialize) this.label49).EndInit();
    ((ISupportInitialize) this.txtINSURER_E).EndInit();
    ((ISupportInitialize) this.txtINSURER_E_NAIC).EndInit();
    ((ISupportInitialize) this.label86).EndInit();
    ((ISupportInitialize) this.txtINSURER_F).EndInit();
    ((ISupportInitialize) this.txtINSURER_F_NAIC).EndInit();
    ((ISupportInitialize) this.label41).EndInit();
    ((ISupportInitialize) this.label87).EndInit();
    ((ISupportInitialize) this.label89).EndInit();
    ((ISupportInitialize) this.label91).EndInit();
    ((ISupportInitialize) this.label93).EndInit();
    ((ISupportInitialize) this.label94).EndInit();
    ((ISupportInitialize) this.label95).EndInit();
    ((ISupportInitialize) this.label96).EndInit();
    ((ISupportInitialize) this.label97).EndInit();
    ((ISupportInitialize) this.label46).EndInit();
    ((ISupportInitialize) this.label99).EndInit();
    ((ISupportInitialize) this.label104).EndInit();
    ((ISupportInitialize) this.label107).EndInit();
    ((ISupportInitialize) this.label109).EndInit();
    ((ISupportInitialize) this.txtUMBR_RETENTION_AMT).EndInit();
    ((ISupportInitialize) this.label112).EndInit();
    ((ISupportInitialize) this.label113).EndInit();
    ((ISupportInitialize) this.label114).EndInit();
    ((ISupportInitialize) this.txtUMBR_LIMIT_EACH_OCC).EndInit();
    ((ISupportInitialize) this.txtUMBR_LIMIT_GEN_AGG).EndInit();
    ((ISupportInitialize) this.textBox18).EndInit();
    ((ISupportInitialize) this.textBox49).EndInit();
    ((ISupportInitialize) this.textBox51).EndInit();
    ((ISupportInitialize) this.label69).EndInit();
    ((ISupportInitialize) this.label36).EndInit();
    ((ISupportInitialize) this.label70).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.label71).EndInit();
    ((ISupportInitialize) this.label72).EndInit();
    ((ISupportInitialize) this.label116).EndInit();
    ((ISupportInitialize) this.label117).EndInit();
    ((ISupportInitialize) this.label118).EndInit();
    ((ISupportInitialize) this.label119).EndInit();
    ((ISupportInitialize) this.label45).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.txtPRODUCER).EndInit();
    ((ISupportInitialize) this.Label62).EndInit();
    ((ISupportInitialize) this.TextBox43).EndInit();
    ((ISupportInitialize) this.Label63).EndInit();
    ((ISupportInitialize) this.Label170).EndInit();
    ((ISupportInitialize) this.txtPRODUCERFAX).EndInit();
    ((ISupportInitialize) this.txtPRODUCERCONTACT).EndInit();
    ((ISupportInitialize) this.txtPRODUCERPHONE).EndInit();
    ((ISupportInitialize) this.label108).EndInit();
    ((ISupportInitialize) this.textBox57).EndInit();
    ((ISupportInitialize) this.textBox58).EndInit();
    ((ISupportInitialize) this.txtDATEISSUED).EndInit();
    ((ISupportInitialize) this.lblINSURED_ID).EndInit();
    ((ISupportInitialize) this.lblPRODUCER_ID).EndInit();
    ((ISupportInitialize) this.txtPRODUCER_ID).EndInit();
    ((ISupportInitialize) this.txtINSURED_ID).EndInit();
    ((ISupportInitialize) this.txtCERTIFICATE_NUMBER).EndInit();
    ((ISupportInitialize) this.GL_LTR).EndInit();
    ((ISupportInitialize) this.BA_LTR).EndInit();
    ((ISupportInitialize) this.UMBR_LTR).EndInit();
    ((ISupportInitialize) this.WC_LTR).EndInit();
    ((ISupportInitialize) this.EXTRA_LTR).EndInit();
    ((ISupportInitialize) this.BA_NON_OWNED).EndInit();
    ((ISupportInitialize) this.BA_SCHEDULED).EndInit();
    ((ISupportInitialize) this.BA_OTHER_1).EndInit();
    ((ISupportInitialize) this.BA_HIRED).EndInit();
    ((ISupportInitialize) this.BA_ALL_OWNED).EndInit();
    ((ISupportInitialize) this.BA_ANY).EndInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_LIMIT_OTHER).EndInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_LIMIT_LOC).EndInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_LIMIT_PROJECT).EndInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_LIMIT_POLICY).EndInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_OTHER_2).EndInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_OTHER_1).EndInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_OCCUR).EndInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_CLAIMS_MADE).EndInit();
    ((ISupportInitialize) this.WC_OTHER_LIMIT).EndInit();
    ((ISupportInitialize) this.WC_STATUTORY_LIMIT).EndInit();
    ((ISupportInitialize) this.WC_ANY_EXCLUDED).EndInit();
    ((ISupportInitialize) this.UMBR_RETENTION).EndInit();
    ((ISupportInitialize) this.UMBR_DEDUCTIBLE).EndInit();
    ((ISupportInitialize) this.UMBR_CLAIMS_MADE).EndInit();
    ((ISupportInitialize) this.UMBR_EXCESS_LIAB).EndInit();
    ((ISupportInitialize) this.UMBR_OCCUR).EndInit();
    ((ISupportInitialize) this.UMBR_LIAB).EndInit();
    ((ISupportInitialize) this.BA_OTHER_2).EndInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_ADDL_INSURED).EndInit();
    ((ISupportInitialize) this.COMMERCIAL_GL_SUBR_WVD).EndInit();
    ((ISupportInitialize) this.EXTRA_ADDL_INSURED).EndInit();
    ((ISupportInitialize) this.UMBR_ADDL_INSURED).EndInit();
    ((ISupportInitialize) this.BA_ADDL_INSURED).EndInit();
    ((ISupportInitialize) this.EXTRA_SUBR_WVD).EndInit();
    ((ISupportInitialize) this.UMBR_SUBR_WVD).EndInit();
    ((ISupportInitialize) this.BA_SUBR_WVD).EndInit();
    ((ISupportInitialize) this.WC_SUBR_WVD).EndInit();
    ((ISupportInitialize) this.txtEXTRA_LIMIT_MESSAGE).EndInit();
    ((ISupportInitialize) this.Label34).EndInit();
    ((ISupportInitialize) this.label50).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label23).EndInit();
    ((ISupportInitialize) this.Label43).EndInit();
    ((ISupportInitialize) this.Label73).EndInit();
    ((ISupportInitialize) this.Label76).EndInit();
    ((ISupportInitialize) this.Label82).EndInit();
    ((ISupportInitialize) this.Label88).EndInit();
    ((ISupportInitialize) this.Label90).EndInit();
    ((ISupportInitialize) this.Label28).EndInit();
    ((ISupportInitialize) this.Label44).EndInit();
    ((ISupportInitialize) this.Label67).EndInit();
    ((ISupportInitialize) this.Label68).EndInit();
    ((ISupportInitialize) this.Label75).EndInit();
    ((ISupportInitialize) this.Label77).EndInit();
    ((ISupportInitialize) this.Label100).EndInit();
    ((ISupportInitialize) this.Label101).EndInit();
    ((ISupportInitialize) this.Label103).EndInit();
    ((ISupportInitialize) this.Label105).EndInit();
    ((ISupportInitialize) this.Label110).EndInit();
    ((ISupportInitialize) this.Label120).EndInit();
    ((ISupportInitialize) this.Label121).EndInit();
    ((ISupportInitialize) this.Label122).EndInit();
    ((ISupportInitialize) this.Label123).EndInit();
    ((ISupportInitialize) this.Label124).EndInit();
    ((ISupportInitialize) this.Label126).EndInit();
    ((ISupportInitialize) this.Label127).EndInit();
    ((ISupportInitialize) this.Label128).EndInit();
    ((ISupportInitialize) this.Label65).EndInit();
    ((ISupportInitialize) this.Label83).EndInit();
    ((ISupportInitialize) this.Label125).EndInit();
    ((ISupportInitialize) this.Label129).EndInit();
    ((ISupportInitialize) this.Label130).EndInit();
    ((ISupportInitialize) this.Label131).EndInit();
    ((ISupportInitialize) this.Label132).EndInit();
    ((ISupportInitialize) this.Label135).EndInit();
    ((ISupportInitialize) this.Label136).EndInit();
    ((ISupportInitialize) this.Label111).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label39).EndInit();
    ((ISupportInitialize) this.Label40).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_Format);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((Section) detail1).Format -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((Section) detail2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtBA_POLICY_NO")]
  private virtual TextBox txtBA_POLICY_NO { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDESCRIPTION_OF_OPERATIONS")]
  private virtual TextBox txtDESCRIPTION_OF_OPERATIONS { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("shape9")]
  private virtual Shape shape9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox28")]
  private virtual TextBox TextBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label102")]
  private virtual Label label102 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label106")]
  private virtual Label label106 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label35")]
  private virtual Label label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label52")]
  private virtual Label label52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("shape15")]
  private virtual Shape shape15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  private virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  private virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label85")]
  private virtual Label label85 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label92")]
  private virtual Label label92 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label74")]
  private virtual Label label74 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label98")]
  private virtual Label label98 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtINSURED")]
  private virtual TextBox txtINSURED { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Picture")]
  private virtual Picture Picture { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCOMMERCIAL_GL_POLICY_EXP")]
  private virtual TextBox txtCOMMERCIAL_GL_POLICY_EXP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCOMMERCIAL_GL_POLICY_NO")]
  private virtual TextBox txtCOMMERCIAL_GL_POLICY_NO { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCOMMERCIAL_GL_POLICY_EFF")]
  private virtual TextBox txtCOMMERCIAL_GL_POLICY_EFF { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label42")]
  private virtual Label Label42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBA_POLICY_EFF")]
  private virtual TextBox txtBA_POLICY_EFF { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBA_POLICY_EXP")]
  private virtual TextBox txtBA_POLICY_EXP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtUMBR_POLICY_NO")]
  private virtual TextBox txtUMBR_POLICY_NO { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtUMBR_POLICY_EFF")]
  private virtual TextBox txtUMBR_POLICY_EFF { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtUMBR_POLICY_EXP")]
  private virtual TextBox txtUMBR_POLICY_EXP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label48")]
  private virtual Label Label48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtWC_POLICY_NO")]
  private virtual TextBox txtWC_POLICY_NO { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtWC_POLICY_EFF")]
  private virtual TextBox txtWC_POLICY_EFF { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtWC_POLICY_EXP")]
  private virtual TextBox txtWC_POLICY_EXP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label51")]
  private virtual Label Label51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox29")]
  private virtual TextBox TextBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox30")]
  private virtual TextBox TextBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox31")]
  private virtual TextBox TextBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox32")]
  private virtual TextBox TextBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEXTRA_POLICY_NO")]
  private virtual TextBox txtEXTRA_POLICY_NO { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEXTRA_POLICY_EFF")]
  private virtual TextBox txtEXTRA_POLICY_EFF { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEXTRA_POLICY_EXP")]
  private virtual TextBox txtEXTRA_POLICY_EXP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label54")]
  private virtual Label Label54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label56")]
  private virtual Label Label56 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEXTRA_DESCRIPTION")]
  private virtual TextBox txtEXTRA_DESCRIPTION { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label57")]
  private virtual Label Label57 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label58")]
  private virtual Label Label58 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label59")]
  private virtual Label Label59 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label60")]
  private virtual Label Label60 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label61")]
  private virtual Label Label61 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label64")]
  private virtual Label Label64 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label66")]
  private virtual Label Label66 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label78")]
  private virtual Label Label78 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label79")]
  private virtual Label Label79 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label80")]
  private virtual Label Label80 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCOMMERCIAL_GL_LIMIT_EACH_OCC")]
  private virtual TextBox txtCOMMERCIAL_GL_LIMIT_EACH_OCC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED")]
  private virtual TextBox txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCOMMERCIAL_GL_LIMIT_MED_EXP")]
  private virtual TextBox txtCOMMERCIAL_GL_LIMIT_MED_EXP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY")]
  private virtual TextBox txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCOMMERCIAL_GL_LIMIT_GEN_AGG")]
  private virtual TextBox txtCOMMERCIAL_GL_LIMIT_GEN_AGG { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG")]
  private virtual TextBox txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBA_COMBINED_SINGLE_LIMIT")]
  private virtual TextBox txtBA_COMBINED_SINGLE_LIMIT { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBA_BODILY_INJURY_PER_PERSON")]
  private virtual TextBox txtBA_BODILY_INJURY_PER_PERSON { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBA_BODILY_INJURY_PER_ACCIDENT")]
  private virtual TextBox txtBA_BODILY_INJURY_PER_ACCIDENT { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBA_PROPERTY_DAMAGE")]
  private virtual TextBox txtBA_PROPERTY_DAMAGE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox48")]
  private virtual TextBox TextBox48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtWC_OTHER_LIMIT_AMT")]
  private virtual TextBox txtWC_OTHER_LIMIT_AMT { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtWC_EACH_ACCIDENT")]
  private virtual TextBox txtWC_EACH_ACCIDENT { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtWC_DISEASE_EACH_EMPLOYEE")]
  private virtual TextBox txtWC_DISEASE_EACH_EMPLOYEE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFooter_Cancellation")]
  private virtual TextBox txtFooter_Cancellation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  private virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label10")]
  private virtual Label label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label31")]
  private virtual Label label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label32")]
  private virtual Label label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label33")]
  private virtual Label label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label22")]
  private virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  private virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  private virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  private virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  private virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  private virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  private virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtINSURER_A")]
  private virtual TextBox txtINSURER_A { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtINSURER_B")]
  private virtual TextBox txtINSURER_B { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtINSURER_C")]
  private virtual TextBox txtINSURER_C { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtINSURER_D")]
  private virtual TextBox txtINSURER_D { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtINSURER_A_NAIC")]
  private virtual TextBox txtINSURER_A_NAIC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtINSURER_B_NAIC")]
  private virtual TextBox txtINSURER_B_NAIC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtINSURER_C_NAIC")]
  private virtual TextBox txtINSURER_C_NAIC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtINSURER_D_NAIC")]
  private virtual TextBox txtINSURER_D_NAIC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  private virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  private virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  private virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label27")]
  private virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label29")]
  private virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label30")]
  private virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label37")]
  private virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label9")]
  private virtual Label label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label38")]
  private virtual Label label38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtHPRODUCEREMAIL")]
  private virtual TextBox txtHPRODUCEREMAIL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label55")]
  private virtual Label Label55 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label81")]
  private virtual Label Label81 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCertificateHolder")]
  private virtual TextBox txtCertificateHolder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtWC_DISEASE_POLICY")]
  private virtual TextBox txtWC_DISEASE_POLICY { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Picture1")]
  private virtual Picture Picture1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label84")]
  private virtual Label Label84 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label47")]
  private virtual Label Label47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label53")]
  private virtual Label Label53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label49")]
  private virtual Label label49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtINSURER_E")]
  private virtual TextBox txtINSURER_E { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtINSURER_E_NAIC")]
  private virtual TextBox txtINSURER_E_NAIC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label86")]
  private virtual Label label86 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtINSURER_F")]
  private virtual TextBox txtINSURER_F { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtINSURER_F_NAIC")]
  private virtual TextBox txtINSURER_F_NAIC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label41")]
  private virtual Label label41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label87")]
  private virtual Label label87 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label89")]
  private virtual Label label89 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label91")]
  private virtual Label label91 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label93")]
  private virtual Label label93 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label94")]
  private virtual Label label94 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label95")]
  private virtual Label label95 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label96")]
  private virtual Label label96 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label97")]
  private virtual Label label97 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label46")]
  private virtual Label label46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label99")]
  private virtual Label label99 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("shape29")]
  private virtual Shape shape29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("shape30")]
  private virtual Shape shape30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label104")]
  private virtual Label label104 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label107")]
  private virtual Label label107 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("shape33")]
  private virtual Shape shape33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label109")]
  private virtual Label label109 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtUMBR_RETENTION_AMT")]
  private virtual Label txtUMBR_RETENTION_AMT { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("shape28")]
  private virtual Shape shape28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label112")]
  private virtual Label label112 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label113")]
  private virtual Label label113 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label114")]
  private virtual Label label114 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtUMBR_LIMIT_EACH_OCC")]
  private virtual TextBox txtUMBR_LIMIT_EACH_OCC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtUMBR_LIMIT_GEN_AGG")]
  private virtual TextBox txtUMBR_LIMIT_GEN_AGG { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox18")]
  private virtual TextBox textBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox49")]
  private virtual TextBox textBox49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox51")]
  private virtual TextBox textBox51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label50")]
  private virtual Label label50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label69")]
  private virtual Label label69 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label36")]
  private virtual Label label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label70")]
  private virtual Label label70 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label2")]
  private virtual Label label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label71")]
  private virtual Label label71 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label72")]
  private virtual Label label72 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label116")]
  private virtual Label label116 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label117")]
  private virtual Label label117 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label118")]
  private virtual Label label118 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label119")]
  private virtual Label label119 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label45")]
  private virtual Label label45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label5")]
  private virtual Label label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPRODUCER")]
  private virtual TextBox txtPRODUCER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label62")]
  private virtual Label Label62 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox43")]
  private virtual TextBox TextBox43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label63")]
  private virtual Label Label63 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label170")]
  private virtual Label Label170 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPRODUCERFAX")]
  private virtual TextBox txtPRODUCERFAX { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPRODUCERCONTACT")]
  private virtual TextBox txtPRODUCERCONTACT { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPRODUCERPHONE")]
  private virtual TextBox txtPRODUCERPHONE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label108")]
  private virtual Label label108 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox57")]
  private virtual TextBox textBox57 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox58")]
  private virtual TextBox textBox58 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual ReportFooter ReportFooter
  {
    get => this._ReportFooter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportFooter_Format);
      ReportFooter reportFooter1 = this._ReportFooter;
      if (reportFooter1 != null)
        ((Section) reportFooter1).Format -= eventHandler;
      this._ReportFooter = value;
      ReportFooter reportFooter2 = this._ReportFooter;
      if (reportFooter2 == null)
        return;
      ((Section) reportFooter2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label39")]
  private virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label40")]
  private virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDATEISSUED")]
  private virtual TextBox txtDATEISSUED { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblINSURED_ID")]
  private virtual Label lblINSURED_ID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPRODUCER_ID")]
  private virtual Label lblPRODUCER_ID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPRODUCER_ID")]
  private virtual TextBox txtPRODUCER_ID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtINSURED_ID")]
  private virtual TextBox txtINSURED_ID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCERTIFICATE_NUMBER")]
  private virtual TextBox txtCERTIFICATE_NUMBER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GL_LTR")]
  private virtual Label GL_LTR { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("BA_LTR")]
  private virtual Label BA_LTR { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UMBR_LTR")]
  private virtual Label UMBR_LTR { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("WC_LTR")]
  private virtual Label WC_LTR { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("EXTRA_LTR")]
  private virtual Label EXTRA_LTR { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("BA_NON_OWNED")]
  private virtual Label BA_NON_OWNED { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("BA_SCHEDULED")]
  private virtual Label BA_SCHEDULED { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("BA_OTHER_1")]
  private virtual Label BA_OTHER_1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("BA_HIRED")]
  private virtual Label BA_HIRED { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("BA_ALL_OWNED")]
  private virtual Label BA_ALL_OWNED { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("BA_ANY")]
  private virtual Label BA_ANY { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("COMMERCIAL_GL_LIMIT_OTHER")]
  private virtual Label COMMERCIAL_GL_LIMIT_OTHER { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("COMMERCIAL_GL_LIMIT_LOC")]
  private virtual Label COMMERCIAL_GL_LIMIT_LOC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("COMMERCIAL_GL_LIMIT_PROJECT")]
  private virtual Label COMMERCIAL_GL_LIMIT_PROJECT { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("COMMERCIAL_GL_LIMIT_POLICY")]
  private virtual Label COMMERCIAL_GL_LIMIT_POLICY { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("COMMERCIAL_GL_OTHER_2")]
  private virtual Label COMMERCIAL_GL_OTHER_2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("COMMERCIAL_GL_OTHER_1")]
  private virtual Label COMMERCIAL_GL_OTHER_1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("COMMERCIAL_GL_OCCUR")]
  private virtual Label COMMERCIAL_GL_OCCUR { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("COMMERCIAL_GL_CLAIMS_MADE")]
  private virtual Label COMMERCIAL_GL_CLAIMS_MADE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("WC_OTHER_LIMIT")]
  private virtual Label WC_OTHER_LIMIT { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("WC_STATUTORY_LIMIT")]
  private virtual Label WC_STATUTORY_LIMIT { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("WC_ANY_EXCLUDED")]
  private virtual Label WC_ANY_EXCLUDED { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UMBR_RETENTION")]
  private virtual Label UMBR_RETENTION { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UMBR_DEDUCTIBLE")]
  private virtual Label UMBR_DEDUCTIBLE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UMBR_CLAIMS_MADE")]
  private virtual Label UMBR_CLAIMS_MADE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UMBR_EXCESS_LIAB")]
  private virtual Label UMBR_EXCESS_LIAB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UMBR_OCCUR")]
  private virtual Label UMBR_OCCUR { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UMBR_LIAB")]
  private virtual Label UMBR_LIAB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("BA_OTHER_2")]
  private virtual Label BA_OTHER_2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("COMMERCIAL_GL_ADDL_INSURED")]
  private virtual Label COMMERCIAL_GL_ADDL_INSURED { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("COMMERCIAL_GL_SUBR_WVD")]
  private virtual Label COMMERCIAL_GL_SUBR_WVD { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("EXTRA_ADDL_INSURED")]
  private virtual Label EXTRA_ADDL_INSURED { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UMBR_ADDL_INSURED")]
  private virtual Label UMBR_ADDL_INSURED { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("BA_ADDL_INSURED")]
  private virtual Label BA_ADDL_INSURED { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("EXTRA_SUBR_WVD")]
  private virtual Label EXTRA_SUBR_WVD { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UMBR_SUBR_WVD")]
  private virtual Label UMBR_SUBR_WVD { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("BA_SUBR_WVD")]
  private virtual Label BA_SUBR_WVD { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("WC_SUBR_WVD")]
  private virtual Label WC_SUBR_WVD { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEXTRA_LIMIT_MESSAGE")]
  private virtual TextBox txtEXTRA_LIMIT_MESSAGE { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label34")]
  private virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtHeader_ProducerContactFax")]
  private virtual TextBox txtHeader_ProducerContactFax { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label23")]
  private virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label43")]
  private virtual Label Label43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label73")]
  private virtual Label Label73 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label76")]
  private virtual Label Label76 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label82")]
  private virtual Label Label82 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label88")]
  private virtual Label Label88 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label90")]
  private virtual Label Label90 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label28")]
  private virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label44")]
  private virtual Label Label44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label67")]
  private virtual Label Label67 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label68")]
  private virtual Label Label68 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label75")]
  private virtual Label Label75 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label77")]
  private virtual Label Label77 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label100")]
  private virtual Label Label100 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label101")]
  private virtual Label Label101 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label103")]
  private virtual Label Label103 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label105")]
  private virtual Label Label105 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label110")]
  private virtual Label Label110 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label120")]
  private virtual Label Label120 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label121")]
  private virtual Label Label121 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label122")]
  private virtual Label Label122 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label123")]
  private virtual Label Label123 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label124")]
  private virtual Label Label124 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label126")]
  private virtual Label Label126 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label127")]
  private virtual Label Label127 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label128")]
  private virtual Label Label128 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label65")]
  private virtual Label Label65 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label83")]
  private virtual Label Label83 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label125")]
  private virtual Label Label125 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label129")]
  private virtual Label Label129 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label130")]
  private virtual Label Label130 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label131")]
  private virtual Label Label131 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label132")]
  private virtual Label Label132 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label135")]
  private virtual Label Label135 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label136")]
  private virtual Label Label136 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label111")]
  private virtual Label Label111 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Shape1")]
  private virtual Shape Shape1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptCertificateOfInsuranceACORD25_2016_3()
  {
    this.ReportStart += new EventHandler(this.rptCertificateOfInsuranceACORD25_2016_3_ReportStart);
    this.ReportEnd += new EventHandler(this.rptCertificateOfInsuranceACORD25_2016_3_ReportEnd);
    this._SProc = "";
    this._Params = new List<object>();
    this.InitializeComponent();
  }

  public rptCertificateOfInsuranceACORD25_2016_3(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptCertificateOfInsuranceACORD25_2016_3_ReportStart);
    this.ReportEnd += new EventHandler(this.rptCertificateOfInsuranceACORD25_2016_3_ReportEnd);
    this._SProc = "";
    this._Params = new List<object>();
    this.InitializeComponent();
    this._Params.Add((object) "@QuoteGuid");
    this._Params.Add((object) QuoteGuid);
  }

  public rptCertificateOfInsuranceACORD25_2016_3(Guid QuoteGuid, int AdditionalInterestID)
  {
    this.ReportStart += new EventHandler(this.rptCertificateOfInsuranceACORD25_2016_3_ReportStart);
    this.ReportEnd += new EventHandler(this.rptCertificateOfInsuranceACORD25_2016_3_ReportEnd);
    this._SProc = "";
    this._Params = new List<object>();
    this.InitializeComponent();
    this._QuoteGuid = QuoteGuid;
    this._AdditionalInterestID = AdditionalInterestID;
    this._Params.Add((object) "@QuoteGuid");
    this._Params.Add((object) QuoteGuid);
    this._Params.Add((object) "@AdditionalInterestID");
    this._Params.Add((object) AdditionalInterestID);
  }

  public rptCertificateOfInsuranceACORD25_2016_3(
    Guid QuoteGuid,
    string DescText,
    int AdditionalInterestID)
  {
    this.ReportStart += new EventHandler(this.rptCertificateOfInsuranceACORD25_2016_3_ReportStart);
    this.ReportEnd += new EventHandler(this.rptCertificateOfInsuranceACORD25_2016_3_ReportEnd);
    this._SProc = "";
    this._Params = new List<object>();
    this.InitializeComponent();
    this._Params.Add((object) "@QuoteGuid");
    this._Params.Add((object) QuoteGuid);
    this._Params.Add((object) "@AdditionalInterestID");
    this._Params.Add((object) AdditionalInterestID);
    this._DescriptionText = DescText;
  }

  private void rptCertificateOfInsuranceACORD25_2016_3_ReportStart(object sender, EventArgs e)
  {
    this._dt = DefaultDatabase.ExecuteDataTable(this.StoredProcedure, this._Params.ToArray());
    this.DataSource = (object) this._dt;
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (this._dt.Rows.Count < 1)
      return;
    DataRow row = this._dt.Rows[0];
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(row["PRODUCER_ID"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row["PRODUCER_ID"].ToString(), "", false) != 0)
    {
      ((ARControl) this.txtPRODUCER_ID).Visible = true;
      ((ARControl) this.lblPRODUCER_ID).Visible = true;
    }
    if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(row["INSURED_ID"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row["INSURED_ID"].ToString(), "", false) != 0)
    {
      ((ARControl) this.txtINSURED_ID).Visible = true;
      ((ARControl) this.lblINSURED_ID).Visible = true;
    }
    ((ARControl) this.GL_LTR).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["GL_LTR"]));
    if (((ARControl) this.GL_LTR).Visible)
    {
      ((ARControl) this.Label170).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["COMMERCIAL_GL"]));
      ((ARControl) this.COMMERCIAL_GL_CLAIMS_MADE).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["COMMERCIAL_GL_CLAIMS_MADE"]));
      ((ARControl) this.COMMERCIAL_GL_OCCUR).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["COMMERCIAL_GL_OCCUR"]));
      ((ARControl) this.COMMERCIAL_GL_OTHER_1).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["COMMERCIAL_GL_OTHER_1"]));
      ((ARControl) this.COMMERCIAL_GL_OTHER_2).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["COMMERCIAL_GL_OTHER_2"]));
      ((ARControl) this.COMMERCIAL_GL_LIMIT_POLICY).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["COMMERCIAL_GL_LIMIT_POLICY"]));
      ((ARControl) this.COMMERCIAL_GL_LIMIT_PROJECT).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["COMMERCIAL_GL_LIMIT_PROJECT"]));
      ((ARControl) this.COMMERCIAL_GL_LIMIT_LOC).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["COMMERCIAL_GL_LIMIT_LOC"]));
      ((ARControl) this.COMMERCIAL_GL_LIMIT_OTHER).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["COMMERCIAL_GL_LIMIT_OTHER"]));
      ((ARControl) this.COMMERCIAL_GL_ADDL_INSURED).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["COMMERCIAL_GL_ADDL_INSURED"]));
      ((ARControl) this.COMMERCIAL_GL_SUBR_WVD).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["COMMERCIAL_GL_SUBR_WVD"]));
      this.txtCOMMERCIAL_GL_POLICY_NO.Text = row["COMMERCIAL_GL_POLICY_NO"].ToString();
      this.txtCOMMERCIAL_GL_POLICY_EFF.Text = row["COMMERCIAL_GL_POLICY_EFF"].ToString();
      this.txtCOMMERCIAL_GL_POLICY_EXP.Text = row["COMMERCIAL_GL_POLICY_EXP"].ToString();
      this.txtCOMMERCIAL_GL_LIMIT_EACH_OCC.Text = row["COMMERCIAL_GL_LIMIT_EACH_OCC"].ToString();
      this.txtCOMMERCIAL_GL_LIMIT_DAMAGE_RENTED.Text = row["COMMERCIAL_GL_LIMIT_DAMAGE_RENTED"].ToString();
      this.txtCOMMERCIAL_GL_LIMIT_MED_EXP.Text = row["COMMERCIAL_GL_LIMIT_MED_EXP"].ToString();
      this.txtCOMMERCIAL_GL_LIMIT_PERS_ADV_INJURY.Text = row["COMMERCIAL_GL_LIMIT_PERS_ADV_INJURY"].ToString();
      this.txtCOMMERCIAL_GL_LIMIT_GEN_AGG.Text = row["COMMERCIAL_GL_LIMIT_GEN_AGG"].ToString();
      this.txtCOMMERCIAL_GL_LIMIT_PRODUCTS_AGG.Text = row["COMMERCIAL_GL_LIMIT_PRODUCTS_AGG"].ToString();
    }
    ((ARControl) this.BA_LTR).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["BA_LTR"]));
    if (((ARControl) this.BA_LTR).Visible)
    {
      ((ARControl) this.BA_ANY).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["BA_ANY"]));
      ((ARControl) this.BA_ALL_OWNED).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["BA_ALL_OWNED"]));
      ((ARControl) this.BA_SCHEDULED).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["BA_SCHEDULED"]));
      ((ARControl) this.BA_HIRED).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["BA_HIRED"]));
      ((ARControl) this.BA_NON_OWNED).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["BA_NON_OWNED"]));
      ((ARControl) this.BA_OTHER_1).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["BA_OTHER_1"]));
      ((ARControl) this.BA_OTHER_2).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["BA_OTHER_2"]));
      ((ARControl) this.BA_ADDL_INSURED).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["BA_ADDL_INSURED"]));
      ((ARControl) this.BA_SUBR_WVD).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["BA_SUBR_WVD"]));
      this.txtBA_POLICY_NO.Text = row["BA_POLICY_NO"].ToString();
      this.txtBA_POLICY_EFF.Text = row["BA_POLICY_EFF"].ToString();
      this.txtBA_POLICY_EXP.Text = row["BA_POLICY_EXP"].ToString();
      this.txtBA_COMBINED_SINGLE_LIMIT.Text = row["BA_COMBINED_SINGLE_LIMIT"].ToString();
      this.txtBA_BODILY_INJURY_PER_PERSON.Text = row["BA_BODILY_INJURY_PER_PERSON"].ToString();
      this.txtBA_BODILY_INJURY_PER_ACCIDENT.Text = row["BA_BODILY_INJURY_PER_ACCIDENT"].ToString();
      this.txtBA_PROPERTY_DAMAGE.Text = row["BA_PROPERTY_DAMAGE"].ToString();
    }
    ((ARControl) this.UMBR_LTR).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["UMBR_LTR"]));
    if (((ARControl) this.UMBR_LTR).Visible)
    {
      ((ARControl) this.UMBR_LIAB).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["UMBR_LIAB"]));
      ((ARControl) this.UMBR_EXCESS_LIAB).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["UMBR_EXCESS_LIAB"]));
      ((ARControl) this.UMBR_CLAIMS_MADE).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["UMBR_CLAIMS_MADE"]));
      ((ARControl) this.UMBR_OCCUR).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["UMBR_OCCUR"]));
      ((ARControl) this.UMBR_DEDUCTIBLE).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["UMBR_DEDUCTIBLE"]));
      ((ARControl) this.UMBR_RETENTION).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["UMBR_RETENTION"]));
      if (((ARControl) this.UMBR_RETENTION).Visible)
        this.txtUMBR_RETENTION_AMT.Text = row["UMBR_RETENTION_AMT"].ToString();
      ((ARControl) this.UMBR_ADDL_INSURED).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["UMBR_ADDL_INSURED"]));
      ((ARControl) this.UMBR_SUBR_WVD).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["UMBR_SUBR_WVD"]));
      this.txtUMBR_POLICY_NO.Text = row["UMBR_POLICY_NO"].ToString();
      this.txtUMBR_POLICY_EFF.Text = row["UMBR_POLICY_EFF"].ToString();
      this.txtUMBR_POLICY_EXP.Text = row["UMBR_POLICY_EXP"].ToString();
      this.txtUMBR_LIMIT_EACH_OCC.Text = row["UMBR_LIMIT_EACH_OCC"].ToString();
      this.txtUMBR_LIMIT_GEN_AGG.Text = row["UMBR_LIMIT_GEN_AGG"].ToString();
    }
    ((ARControl) this.WC_LTR).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["WC_LTR"]));
    if (((ARControl) this.WC_LTR).Visible)
    {
      ((ARControl) this.WC_ANY_EXCLUDED).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["WC_ANY_EXCLUDED"]));
      ((ARControl) this.WC_SUBR_WVD).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["WC_SUBR_WVD"]));
      ((ARControl) this.WC_STATUTORY_LIMIT).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["WC_STATUTORY_LIMIT"]));
      ((ARControl) this.WC_OTHER_LIMIT).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["WC_OTHER_LIMIT"]));
      this.txtWC_POLICY_NO.Text = row["WC_POLICY_NO"].ToString();
      this.txtWC_POLICY_EFF.Text = row["WC_POLICY_EFF"].ToString();
      this.txtWC_POLICY_EXP.Text = row["WC_POLICY_EXP"].ToString();
      this.txtWC_OTHER_LIMIT_AMT.Text = row["WC_OTHER_LIMIT_AMT"].ToString();
      this.txtWC_EACH_ACCIDENT.Text = row["WC_EACH_ACCIDENT"].ToString();
      this.txtWC_DISEASE_EACH_EMPLOYEE.Text = row["WC_DISEASE_EACH_EMPLOYEE"].ToString();
      this.txtWC_DISEASE_POLICY.Text = row["WC_DISEASE_POLICY"].ToString();
    }
    ((ARControl) this.EXTRA_LTR).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["EXTRA_LTR"]));
    if (((ARControl) this.EXTRA_LTR).Visible)
    {
      ((ARControl) this.EXTRA_ADDL_INSURED).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["EXTRA_ADDL_INSURED"]));
      ((ARControl) this.EXTRA_SUBR_WVD).Visible = this.BitToBool(RuntimeHelpers.GetObjectValue(row["EXTRA_SUBR_WVD"]));
      this.txtEXTRA_POLICY_NO.Text = row["EXTRA_POLICY_NO"].ToString();
      this.txtEXTRA_POLICY_EFF.Text = row["EXTRA_POLICY_EFF"].ToString();
      this.txtEXTRA_POLICY_EXP.Text = row["EXTRA_POLICY_EXP"].ToString();
      this.txtEXTRA_LIMIT_MESSAGE.Text = row["EXTRA_LIMIT_MESSAGE"].ToString();
      this.txtEXTRA_DESCRIPTION.Text = row["EXTRA_DESCRIPTION"].ToString();
    }
    if (Information.IsNothing(RuntimeHelpers.GetObjectValue(row["DESCRIPTION_OF_OPERATIONS"])) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row["DESCRIPTION_OF_OPERATIONS"].ToString(), "", false) == 0)
      return;
    row["DESCRIPTION_OF_OPERATIONS"].ToString();
    if (this.IsAddlRemarksPageRequired(row))
    {
      this.rptADDITIONAL_REMARKS_SCHEDULE = new rptCertificateOfInsuranceACORD101(this._dt);
      this.txtDESCRIPTION_OF_OPERATIONS.Text = "See attached ACORD 101 document.";
    }
    else
      this.txtDESCRIPTION_OF_OPERATIONS.Text = row["DESCRIPTION_OF_OPERATIONS"].ToString();
  }

  private void rptCertificateOfInsuranceACORD25_2016_3_ReportEnd(object sender, EventArgs e)
  {
    if (Information.IsNothing((object) this.rptADDITIONAL_REMARKS_SCHEDULE))
      return;
    this.rptADDITIONAL_REMARKS_SCHEDULE.Run();
    this.Document.Pages.AddRange(this.rptADDITIONAL_REMARKS_SCHEDULE.Document.Pages);
  }

  private bool IsAddlRemarksPageRequired(DataRow dr)
  {
    bool flag;
    if (this.BitToBool(RuntimeHelpers.GetObjectValue(dr["ADDITIONAL_REMARKS_SCHEDULE_REQUIRED"])))
    {
      flag = true;
    }
    else
    {
      string[] strArray1 = dr["DESCRIPTION_OF_OPERATIONS"].ToString().Replace('\r', '\n').Replace("\n\n", "\n").Split('\n');
      int length = strArray1.Length;
      string[] strArray2 = strArray1;
      int index = 0;
      while (index < strArray2.Length)
      {
        int num = strArray2[index].Length / 71;
        if (num > 1)
          length += num;
        checked { ++index; }
      }
      flag = length > 5;
    }
    return flag;
  }

  private bool BitToBool(object val)
  {
    bool flag = false;
    try
    {
      flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(val));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  public string StoredProcedure
  {
    get => this._SProc;
    set => this._SProc = value;
  }

  private void ReportFooter_Format(object sender, EventArgs e)
  {
  }
}
