// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Claims.frmClaims
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.Common.Functions;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Claims;

[DocumentFolderFilter("Claims")]
[SecureResource("{97FEA54D-B2D9-4b0e-91B8-F335BE758863}", "Ability to Add New Claims", "Controls ability to add new claims.", "Policies")]
[SecureResource("{2E816935-F41A-4b0b-BE97-8034F73E32AD}", "Ability to Edit Claims", "Controls ability to edit claims.", "Policies")]
[SecureResource("{2E87DE95-577C-43e0-96F5-86A4B9A65119}", "Ability to Delete Claims", "Controls ability to delete claims.", "Policies")]
[SecureResource("{C4481E6D-A002-45d0-9A79-A2A570A7D319}", "Access Associated Items, Claims Screen", "Controls access to Associated Items, Claims Screen.", "Policies")]
public class frmClaims : Form, ISupportNoteSystem, ISupportDocumentSystem
{
  private IContainer components;
  private DbDataAdapter daClaims;
  private DbDataAdapter daResPay;
  private DbCommand DbSelectCommand2;
  private DbCommand DbInsertCommand2;
  private DbCommand DbUpdateCommand2;
  private DbCommand DbDeleteCommand2;
  private DbCommand DbSelectCommand1;
  private readonly Quote _quote;
  private bool TotalIncurredManuallyChanged;
  private bool _onlyImportExistingClaims;
  private readonly Guid _quoteGuid;
  private readonly bool _implementsLexisNexusClaims;
  private readonly bool _canEditClaims;
  private DbConnection _cn;
  public const string canViewClaimsForm = "{C4481E6D-A002-45d0-9A79-A2A570A7D319}";
  public const string canAddNewClaims = "{97FEA54D-B2D9-4b0e-91B8-F335BE758863}";
  public const string canEditClaims = "{2E816935-F41A-4b0b-BE97-8034F73E32AD}";
  public const string canDeleteClaims = "{2E87DE95-577C-43e0-96F5-86A4B9A65119}";

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsClaims ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid gridClaims
  {
    get => this._gridClaims;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.gridClaims_BeforeRowExpanded);
      EventHandler eventHandler = new EventHandler(this.gridClaims_AfterRowActivate);
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.gridClaims_InitializeLayout);
      UltraGrid gridClaims1 = this._gridClaims;
      if (gridClaims1 != null)
      {
        gridClaims1.BeforeRowExpanded -= cancelableRowEventHandler;
        gridClaims1.AfterRowActivate -= eventHandler;
        gridClaims1.InitializeLayout -= layoutEventHandler;
      }
      this._gridClaims = value;
      UltraGrid gridClaims2 = this._gridClaims;
      if (gridClaims2 == null)
        return;
      gridClaims2.BeforeRowExpanded += cancelableRowEventHandler;
      gridClaims2.AfterRowActivate += eventHandler;
      gridClaims2.InitializeLayout += layoutEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtClaimNum")]
  protected virtual MGATextBox txtClaimNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtDateOfLoss")]
  protected virtual MGADateTimePicker dtDateOfLoss { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtReported")]
  protected virtual MGADateTimePicker dtReported { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtStatus")]
  protected virtual MGATextBox txtStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLossType")]
  protected virtual MGATextBox txtLossType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaDateTimePicker1")]
  protected virtual MGADateTimePicker MgaDateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl3")]
  protected virtual UltraTabPageControl UltraTabPageControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor24")]
  protected virtual MGANumericEditor MgaNumericEditor24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label66")]
  protected virtual Label Label66 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaDateTimePicker10")]
  protected virtual MGADateTimePicker MgaDateTimePicker10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label65")]
  protected virtual Label Label65 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaDateTimePicker9")]
  protected virtual MGADateTimePicker MgaDateTimePicker9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label64")]
  protected virtual Label Label64 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label63")]
  protected virtual Label Label63 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaDateTimePicker8")]
  protected virtual MGADateTimePicker MgaDateTimePicker8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label62")]
  protected virtual Label Label62 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox26")]
  protected virtual MGATextBox MgaTextBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label47")]
  protected virtual Label Label47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label46")]
  protected virtual Label Label46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox22")]
  protected virtual MGATextBox MgaTextBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox21")]
  protected virtual MGATextBox MgaTextBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label45")]
  protected virtual Label Label45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox20")]
  protected virtual MGATextBox MgaTextBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label44")]
  protected virtual Label Label44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox19")]
  protected virtual MGATextBox MgaTextBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label43")]
  protected virtual Label Label43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox18")]
  protected virtual MGATextBox MgaTextBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label42")]
  protected virtual Label Label42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox17")]
  protected virtual MGATextBox MgaTextBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label41")]
  protected virtual Label Label41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox16")]
  protected virtual MGATextBox MgaTextBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label40")]
  protected virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox15")]
  protected virtual MGATextBox MgaTextBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label39")]
  protected virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaDateTimePicker7")]
  protected virtual MGADateTimePicker MgaDateTimePicker7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label38")]
  protected virtual Label Label38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaDateTimePicker6")]
  protected virtual MGADateTimePicker MgaDateTimePicker6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label37")]
  protected virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaDateTimePicker5")]
  protected virtual MGADateTimePicker MgaDateTimePicker5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label36")]
  protected virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label35")]
  protected virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox14")]
  protected virtual MGATextBox MgaTextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaDateTimePicker4")]
  protected virtual MGADateTimePicker MgaDateTimePicker4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label34")]
  protected virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox13")]
  protected virtual MGATextBox MgaTextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label33")]
  protected virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox12")]
  protected virtual MGATextBox MgaTextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label32")]
  protected virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox11")]
  protected virtual MGATextBox MgaTextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label31")]
  protected virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox10")]
  protected virtual MGATextBox MgaTextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label30")]
  protected virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox9")]
  protected virtual MGATextBox MgaTextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  protected virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label61")]
  protected virtual Label Label61 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor23")]
  protected virtual MGANumericEditor MgaNumericEditor23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label60")]
  protected virtual Label Label60 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor22")]
  protected virtual MGANumericEditor MgaNumericEditor22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label59")]
  protected virtual Label Label59 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor21")]
  protected virtual MGANumericEditor MgaNumericEditor21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label58")]
  protected virtual Label Label58 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor20")]
  protected virtual MGANumericEditor MgaNumericEditor20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label57")]
  protected virtual Label Label57 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor19")]
  protected virtual MGANumericEditor MgaNumericEditor19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor18")]
  protected virtual MGANumericEditor MgaNumericEditor18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label56")]
  protected virtual Label Label56 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor17")]
  protected virtual MGANumericEditor MgaNumericEditor17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label55")]
  protected virtual Label Label55 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label54")]
  protected virtual Label Label54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtValueDate")]
  protected virtual MGADateTimePicker dtValueDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label51")]
  protected virtual Label Label51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label50")]
  protected virtual Label Label50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label49")]
  protected virtual Label Label49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor16")]
  protected virtual MGANumericEditor MgaNumericEditor16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor15")]
  protected virtual MGANumericEditor MgaNumericEditor15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox23")]
  protected virtual MGATextBox MgaTextBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label23")]
  protected virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaDateTimePicker2")]
  protected virtual MGADateTimePicker MgaDateTimePicker2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor11")]
  protected virtual MGANumericEditor MgaNumericEditor11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  protected virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor12")]
  protected virtual MGANumericEditor MgaNumericEditor12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  protected virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor13")]
  protected virtual MGANumericEditor MgaNumericEditor13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label22")]
  protected virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor10")]
  protected virtual MGANumericEditor MgaNumericEditor10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  protected virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor9")]
  protected virtual MGANumericEditor MgaNumericEditor9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  protected virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor8")]
  protected virtual MGANumericEditor MgaNumericEditor8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  protected virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor7")]
  protected virtual MGANumericEditor MgaNumericEditor7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor6")]
  protected virtual MGANumericEditor MgaNumericEditor6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor5")]
  protected virtual MGANumericEditor MgaNumericEditor5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor4")]
  protected virtual MGANumericEditor MgaNumericEditor4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor3")]
  protected virtual MGANumericEditor MgaNumericEditor3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor2")]
  protected virtual MGANumericEditor MgaNumericEditor2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor1")]
  protected virtual MGANumericEditor MgaNumericEditor1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  protected virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  protected virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  protected virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  protected virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  protected virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  protected virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  protected virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraTabPageControl UltraTabPageControl1
  {
    get => this._UltraTabPageControl1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      PaintEventHandler paintEventHandler = new PaintEventHandler(this.UltraTabPageControl1_Paint);
      UltraTabPageControl ultraTabPageControl1_1 = this._UltraTabPageControl1;
      if (ultraTabPageControl1_1 != null)
        ((Control) ultraTabPageControl1_1).Paint -= paintEventHandler;
      this._UltraTabPageControl1 = value;
      UltraTabPageControl ultraTabPageControl1_2 = this._UltraTabPageControl1;
      if (ultraTabPageControl1_2 == null)
        return;
      ((Control) ultraTabPageControl1_2).Paint += paintEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label53")]
  protected virtual Label Label53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox25")]
  protected virtual MGATextBox MgaTextBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label52")]
  protected virtual Label Label52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox24")]
  protected virtual MGATextBox MgaTextBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label48")]
  protected virtual Label Label48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor14")]
  protected virtual MGANumericEditor MgaNumericEditor14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label29")]
  protected virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox8")]
  protected virtual MGATextBox MgaTextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox1")]
  protected virtual MGACheckBox MgaCheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label28")]
  protected virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox7")]
  protected virtual MGATextBox MgaTextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label27")]
  protected virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox6")]
  protected virtual MGATextBox MgaTextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox5")]
  protected virtual MGATextBox MgaTextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  protected virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  protected virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox2")]
  protected virtual MGATextBox MgaTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  protected virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox1")]
  protected virtual MGATextBox MgaTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  protected virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaDateTimePicker3")]
  protected virtual MGADateTimePicker MgaDateTimePicker3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  protected virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  protected virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  protected virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  protected virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  protected virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  protected virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox4")]
  protected virtual MGATextBox MgaTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  protected virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox3")]
  protected virtual MGATextBox MgaTextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("CheckBox1")]
  protected virtual MGACheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  private virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTab1")]
  protected virtual MGATab MgaTab1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingEdit);
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.dbSave_ClickingCancel);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingEdit -= cancelEventHandler1;
        dbSave1.UIStateChanged -= eventHandler;
        dbSave1.ClickingNew -= cancelEventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler3;
        dbSave1.ClickingDelete -= cancelEventHandler4;
        dbSave1.ClickingCancel -= cancelEventHandler5;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingEdit += cancelEventHandler1;
      dbSave2.UIStateChanged += eventHandler;
      dbSave2.ClickingNew += cancelEventHandler2;
      dbSave2.ClickingSave += cancelEventHandler3;
      dbSave2.ClickingDelete += cancelEventHandler4;
      dbSave2.ClickingCancel += cancelEventHandler5;
    }
  }

  [field: AccessedThroughProperty("Label67")]
  protected virtual Label Label67 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGANumericEditor MgaNumericEditor25
  {
    get => this._MgaNumericEditor25;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MgaNumericEditor25_ValueChanged);
      MGANumericEditor mgaNumericEditor25_1 = this._MgaNumericEditor25;
      if (mgaNumericEditor25_1 != null)
        ((UltraNumericEditorBase) mgaNumericEditor25_1).ValueChanged -= eventHandler;
      this._MgaNumericEditor25 = value;
      MGANumericEditor mgaNumericEditor25_2 = this._MgaNumericEditor25;
      if (mgaNumericEditor25_2 == null)
        return;
      ((UltraNumericEditorBase) mgaNumericEditor25_2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblMTDTPAExpensesPaid")]
  protected virtual Label lblMTDTPAExpensesPaid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numMTDTPAExpPaid")]
  protected virtual MGANumericEditor numMTDTPAExpPaid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblExpensePaid")]
  protected virtual Label lblExpensePaid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numExpensePaid")]
  protected virtual MGANumericEditor numExpensePaid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblGrossLoss")]
  protected virtual Label lblGrossLoss { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numGrossLoss")]
  protected virtual MGANumericEditor numGrossLoss { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblExpenseReserved")]
  protected virtual Label lblExpenseReserved { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numExpenseReserved")]
  protected virtual MGANumericEditor numExpenseReserved { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLatitude")]
  internal virtual Label lblLatitude { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLatitude")]
  protected virtual MGATextBox txtLatitude { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLongitude")]
  internal virtual Label lblLongitude { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLongitude")]
  protected virtual MGATextBox txtLongitude { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLossZip")]
  internal virtual Label lblLossZip { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLossZip")]
  protected virtual MGATextBox txtLossZip { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLossState")]
  internal virtual Label lblLossState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLossCity")]
  internal virtual Label lblLossCity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLossCity")]
  protected virtual MGATextBox txtLossCity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLossStreet")]
  internal virtual Label lblLossStreet { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLossStreet")]
  protected virtual MGATextBox txtLossStreet { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboState")]
  protected virtual MGASimpleComboBox cboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblComments")]
  protected virtual Label lblComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTxtComments")]
  protected virtual MGATextBox MgaTxtComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbDeleteCommand")]
  internal virtual DbCommand DbDeleteCommand { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbInsertCommand")]
  internal virtual DbCommand DbInsertCommand { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbUpdateCommand")]
  internal virtual DbCommand DbUpdateCommand { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtClaimUpdated")]
  protected virtual MGADateTimePicker dtClaimUpdated { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDtClaimUpdated")]
  protected virtual Label lblDtClaimUpdated { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabAdditionalReservesPayments")]
  internal virtual UltraTabPageControl tabAdditionalReservesPayments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor38")]
  protected virtual MGANumericEditor MgaNumericEditor38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label80")]
  internal virtual Label Label80 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor37")]
  protected virtual MGANumericEditor MgaNumericEditor37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label79")]
  internal virtual Label Label79 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor36")]
  protected virtual MGANumericEditor MgaNumericEditor36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label78")]
  internal virtual Label Label78 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor34")]
  protected virtual MGANumericEditor MgaNumericEditor34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor35")]
  protected virtual MGANumericEditor MgaNumericEditor35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label77")]
  internal virtual Label Label77 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label76")]
  internal virtual Label Label76 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label75")]
  internal virtual Label Label75 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor33")]
  protected virtual MGANumericEditor MgaNumericEditor33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor32")]
  protected virtual MGANumericEditor MgaNumericEditor32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label74")]
  internal virtual Label Label74 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor30")]
  protected virtual MGANumericEditor MgaNumericEditor30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label73")]
  internal virtual Label Label73 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor31")]
  protected virtual MGANumericEditor MgaNumericEditor31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label72")]
  internal virtual Label Label72 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label71")]
  internal virtual Label Label71 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor29")]
  protected virtual MGANumericEditor MgaNumericEditor29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblHailCode")]
  internal virtual Label lblHailCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numHailCode")]
  protected virtual MGANumericEditor numHailCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblAtcCode")]
  internal virtual Label lblAtcCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numAtcCode")]
  protected virtual MGANumericEditor numAtcCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblIsoCode")]
  internal virtual Label lblIsoCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numIsoCode")]
  protected virtual MGANumericEditor numIsoCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label85")]
  internal virtual Label Label85 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox27")]
  protected virtual MGATextBox MgaTextBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor42")]
  protected virtual MGANumericEditor MgaNumericEditor42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label84")]
  internal virtual Label Label84 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor41")]
  protected virtual MGANumericEditor MgaNumericEditor41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label83")]
  internal virtual Label Label83 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor40")]
  protected virtual MGANumericEditor MgaNumericEditor40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label82")]
  internal virtual Label Label82 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaNumericEditor39")]
  protected virtual MGANumericEditor MgaNumericEditor39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label81")]
  internal virtual Label Label81 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBodyPart")]
  protected virtual Label lblBodyPart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBodyPart")]
  protected virtual MGATextBox txtBodyPart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numAdjCaseReserves")]
  protected virtual MGANumericEditor numAdjCaseReserves { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblAdjCaseReserves")]
  protected virtual Label lblAdjCaseReserves { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDateCreated")]
  protected virtual Label lblDateCreated { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtDateCreated")]
  protected virtual MGADateTimePicker dtDateCreated { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCAT_Name_Details")]
  protected virtual MGATextBox txtCAT_Name_Details { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCAT_Name_Details")]
  protected virtual Label lblCAT_Name_Details { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numTotalPaid")]
  protected virtual MGANumericEditor numTotalPaid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTotalPaid")]
  protected virtual Label lblTotalPaid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label68")]
  protected virtual Label Label68 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtWatchList")]
  protected virtual MGATextBox txtWatchList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numLimit")]
  protected virtual MGANumericEditor numLimit { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLimit")]
  protected virtual Label lblLimit { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkOrder
  {
    get => this._lnkOrder;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkOrder_LinkClicked);
      LinkLabel lnkOrder1 = this._lnkOrder;
      if (lnkOrder1 != null)
        lnkOrder1.LinkClicked -= clickedEventHandler;
      this._lnkOrder = value;
      LinkLabel lnkOrder2 = this._lnkOrder;
      if (lnkOrder2 == null)
        return;
      lnkOrder2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblTPAExpPaid")]
  protected virtual Label lblTPAExpPaid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numTPAExpPTD")]
  protected virtual MGANumericEditor numTPAExpPTD { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numContingentBIReserve")]
  protected virtual MGANumericEditor numContingentBIReserve { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numBusIntReserve")]
  protected virtual MGANumericEditor numBusIntReserve { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblContingentBIReserve")]
  protected virtual Label lblContingentBIReserve { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBusIntReserve")]
  protected virtual Label lblBusIntReserve { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numContingentBIPaid")]
  protected virtual MGANumericEditor numContingentBIPaid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numBusIntPaid")]
  protected virtual MGANumericEditor numBusIntPaid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblContingentBIPaid")]
  protected virtual Label lblContingentBIPaid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBusIntPaid")]
  protected virtual Label lblBusIntPaid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  protected virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    Appearance appearance73 = new Appearance();
    Appearance appearance74 = new Appearance();
    Appearance appearance75 = new Appearance();
    Appearance appearance76 = new Appearance();
    Appearance appearance77 = new Appearance();
    Appearance appearance78 = new Appearance();
    Appearance appearance79 = new Appearance();
    Appearance appearance80 = new Appearance();
    Appearance appearance81 = new Appearance();
    Appearance appearance82 = new Appearance();
    Appearance appearance83 = new Appearance();
    Appearance appearance84 = new Appearance();
    Appearance appearance85 = new Appearance();
    Appearance appearance86 = new Appearance();
    Appearance appearance87 = new Appearance();
    Appearance appearance88 = new Appearance();
    Appearance appearance89 = new Appearance();
    Appearance appearance90 = new Appearance();
    Appearance appearance91 = new Appearance();
    Appearance appearance92 = new Appearance();
    Appearance appearance93 = new Appearance();
    Appearance appearance94 = new Appearance();
    Appearance appearance95 = new Appearance();
    Appearance appearance96 = new Appearance();
    Appearance appearance97 = new Appearance();
    Appearance appearance98 = new Appearance();
    Appearance appearance99 = new Appearance();
    Appearance appearance100 = new Appearance();
    Appearance appearance101 = new Appearance();
    Appearance appearance102 = new Appearance();
    Appearance appearance103 = new Appearance();
    Appearance appearance104 = new Appearance();
    Appearance appearance105 = new Appearance();
    Appearance appearance106 = new Appearance();
    Appearance appearance107 = new Appearance();
    Appearance appearance108 = new Appearance();
    Appearance appearance109 = new Appearance();
    Appearance appearance110 = new Appearance();
    Appearance appearance111 = new Appearance();
    Appearance appearance112 = new Appearance();
    Appearance appearance113 = new Appearance();
    Appearance appearance114 = new Appearance();
    Appearance appearance115 = new Appearance();
    Appearance appearance116 = new Appearance();
    Appearance appearance117 = new Appearance();
    Appearance appearance118 = new Appearance();
    Appearance appearance119 = new Appearance();
    Appearance appearance120 = new Appearance();
    Appearance appearance121 = new Appearance();
    Appearance appearance122 = new Appearance();
    Appearance appearance123 = new Appearance();
    Appearance appearance124 = new Appearance();
    Appearance appearance125 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmClaims));
    Appearance appearance126 = new Appearance();
    Appearance appearance127 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance128 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance129 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance130 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblClaimInformation", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ClaimID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ClaimNo");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("DateReported");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("LossDate");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("LossType");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Status");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("DateClosed");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("InLitigation");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("DescriptionInjury");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("CATNo");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ReadOnly");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("DateReceived");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Claimant");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Deductible");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("CoverageDescription");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Company");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("CorresBranchName");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Occurence");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("LOB");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Lien");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("SubroPotential");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("FirstThirdParty");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("Fatality");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("NCCICode");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("DateReopened");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("InitialContact");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("FirstInsp");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("FirstReport");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("ReportToCarrier");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("AdjusterName");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("AdjusterTitle");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("AdjusterCategory");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("IndepAdjuster");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("DefFirm");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("ClaimantCounsel");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("Gender");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("Age");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("CarrierClaimNo");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("Driver");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("DatePaid");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("OriginalLoanDate");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("RejectedDate");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("RejectedAmount");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("LastClaimUpdated");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("BodyPart");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("AdjCaseReserves");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("CAT_Name_Details");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("TotalPaid");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("Limit");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("WatchList");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("tblClaimInformationtblClaimResPaymentActivity");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblClaimInformationtblClaimResPaymentActivity", 0);
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("PaymentID");
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("ClaimID");
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("OutIndRes");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("OutLAERes");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("OutLegalRes");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("DedRecovery");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("Subrogation");
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("Salvage");
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("OtherRecovery");
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("MTDIndemnityPaid");
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("IndemnityPTD");
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("MTDLAEPaid");
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("LAEPTD");
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("MTDLegalPaid");
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("LegalPTD");
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("MTDTPAExpPaid");
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("TPAExpPTD");
    UltraGridColumn ultraGridColumn73 = new UltraGridColumn("TotalIncurred");
    Appearance appearance131 = new Appearance();
    Appearance appearance132 = new Appearance();
    UltraGridColumn ultraGridColumn74 = new UltraGridColumn("CheckIssued");
    UltraGridColumn ultraGridColumn75 = new UltraGridColumn("RecType");
    UltraGridColumn ultraGridColumn76 = new UltraGridColumn("OutMedRes");
    UltraGridColumn ultraGridColumn77 = new UltraGridColumn("MedicalPTD");
    UltraGridColumn ultraGridColumn78 = new UltraGridColumn("ValueDate");
    UltraGridColumn ultraGridColumn79 = new UltraGridColumn("TotalReserve");
    UltraGridColumn ultraGridColumn80 = new UltraGridColumn("RespayTotalPaid");
    UltraGridColumn ultraGridColumn81 = new UltraGridColumn("TotalRecovery");
    UltraGridColumn ultraGridColumn82 = new UltraGridColumn("TPAReserve");
    UltraGridColumn ultraGridColumn83 = new UltraGridColumn("BIPaid");
    UltraGridColumn ultraGridColumn84 = new UltraGridColumn("BIReserve");
    UltraGridColumn ultraGridColumn85 = new UltraGridColumn("PDPaid");
    UltraGridColumn ultraGridColumn86 = new UltraGridColumn("PDReserve");
    UltraGridColumn ultraGridColumn87 = new UltraGridColumn("GrossLoss");
    UltraGridColumn ultraGridColumn88 = new UltraGridColumn("ExpensePaid");
    UltraGridColumn ultraGridColumn89 = new UltraGridColumn("ExpenseReserved");
    UltraGridColumn ultraGridColumn90 = new UltraGridColumn("DetailDescription");
    UltraGridColumn ultraGridColumn91 = new UltraGridColumn("LossStreet");
    UltraGridColumn ultraGridColumn92 = new UltraGridColumn("LossCity");
    UltraGridColumn ultraGridColumn93 = new UltraGridColumn("LossState");
    UltraGridColumn ultraGridColumn94 = new UltraGridColumn("LossZip");
    UltraGridColumn ultraGridColumn95 = new UltraGridColumn("Longitude");
    UltraGridColumn ultraGridColumn96 = new UltraGridColumn("Latitude");
    UltraGridColumn ultraGridColumn97 = new UltraGridColumn("Iso_Code");
    UltraGridColumn ultraGridColumn98 = new UltraGridColumn("Atc_Code");
    UltraGridColumn ultraGridColumn99 = new UltraGridColumn("Hail_Code");
    UltraGridColumn ultraGridColumn100 = new UltraGridColumn("Pc_Code");
    UltraGridColumn ultraGridColumn101 = new UltraGridColumn("Occupancy");
    UltraGridColumn ultraGridColumn102 = new UltraGridColumn("Subsidized");
    UltraGridColumn ultraGridColumn103 = new UltraGridColumn("Student_Senior");
    UltraGridColumn ultraGridColumn104 = new UltraGridColumn("Total_SqFt");
    UltraGridColumn ultraGridColumn105 = new UltraGridColumn("Price_Per_Sqft");
    UltraGridColumn ultraGridColumn106 = new UltraGridColumn("Total_BV");
    UltraGridColumn ultraGridColumn107 = new UltraGridColumn("Total_BBP");
    UltraGridColumn ultraGridColumn108 = new UltraGridColumn("Total_BI");
    UltraGridColumn ultraGridColumn109 = new UltraGridColumn("Total_TIV");
    UltraGridColumn ultraGridColumn110 = new UltraGridColumn("Program_Deductible_Applied");
    UltraGridColumn ultraGridColumn111 = new UltraGridColumn("Program_AOP");
    UltraGridColumn ultraGridColumn112 = new UltraGridColumn("Program_WindHail");
    UltraGridColumn ultraGridColumn113 = new UltraGridColumn("Program_NS");
    UltraGridColumn ultraGridColumn114 = new UltraGridColumn("Program_Notes");
    UltraGridColumn ultraGridColumn115 = new UltraGridColumn("DateCreated");
    UltraGridColumn ultraGridColumn116 = new UltraGridColumn("BusIntReserve");
    UltraGridColumn ultraGridColumn117 = new UltraGridColumn("ContingentBIReserve");
    UltraGridColumn ultraGridColumn118 = new UltraGridColumn("BusIntPaid");
    UltraGridColumn ultraGridColumn119 = new UltraGridColumn("ContingentBIPaid");
    Appearance appearance133 = new Appearance();
    Appearance appearance134 = new Appearance();
    Appearance appearance135 = new Appearance();
    Appearance appearance136 = new Appearance();
    Appearance appearance137 = new Appearance();
    Appearance appearance138 = new Appearance();
    Appearance appearance139 = new Appearance();
    Appearance appearance140 = new Appearance();
    Appearance appearance141 = new Appearance();
    Appearance appearance142 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.lnkOrder = new LinkLabel();
    this.dtClaimUpdated = new MGADateTimePicker();
    this.ds = new dsClaims();
    this.lblDtClaimUpdated = new Label();
    this.lblComments = new Label();
    this.MgaTxtComments = new MGATextBox();
    this.Label53 = new Label();
    this.MgaTextBox25 = new MGATextBox();
    this.Label52 = new Label();
    this.MgaTextBox24 = new MGATextBox();
    this.Label48 = new Label();
    this.MgaNumericEditor14 = new MGANumericEditor();
    this.Label29 = new Label();
    this.MgaTextBox8 = new MGATextBox();
    this.MgaCheckBox1 = new MGACheckBox();
    this.Label28 = new Label();
    this.MgaTextBox7 = new MGATextBox();
    this.Label27 = new Label();
    this.MgaTextBox6 = new MGATextBox();
    this.MgaTextBox5 = new MGATextBox();
    this.Label26 = new Label();
    this.Label25 = new Label();
    this.MgaTextBox2 = new MGATextBox();
    this.Label24 = new Label();
    this.MgaTextBox1 = new MGATextBox();
    this.Label19 = new Label();
    this.MgaDateTimePicker1 = new MGADateTimePicker();
    this.MgaDateTimePicker3 = new MGADateTimePicker();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.txtStatus = new MGATextBox();
    this.Label4 = new Label();
    this.txtLossType = new MGATextBox();
    this.dtDateOfLoss = new MGADateTimePicker();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.dtReported = new MGADateTimePicker();
    this.txtClaimNum = new MGATextBox();
    this.Label1 = new Label();
    this.Label8 = new Label();
    this.MgaTextBox4 = new MGATextBox();
    this.Label7 = new Label();
    this.MgaTextBox3 = new MGATextBox();
    this.CheckBox1 = new MGACheckBox();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.Label68 = new Label();
    this.txtWatchList = new MGATextBox();
    this.numLimit = new MGANumericEditor();
    this.lblLimit = new Label();
    this.numTotalPaid = new MGANumericEditor();
    this.lblTotalPaid = new Label();
    this.txtCAT_Name_Details = new MGATextBox();
    this.lblCAT_Name_Details = new Label();
    this.numAdjCaseReserves = new MGANumericEditor();
    this.lblAdjCaseReserves = new Label();
    this.lblBodyPart = new Label();
    this.txtBodyPart = new MGATextBox();
    this.MgaNumericEditor24 = new MGANumericEditor();
    this.Label66 = new Label();
    this.MgaDateTimePicker10 = new MGADateTimePicker();
    this.Label65 = new Label();
    this.MgaDateTimePicker9 = new MGADateTimePicker();
    this.Label64 = new Label();
    this.Label63 = new Label();
    this.MgaDateTimePicker8 = new MGADateTimePicker();
    this.Label62 = new Label();
    this.MgaTextBox26 = new MGATextBox();
    this.Label47 = new Label();
    this.Label46 = new Label();
    this.MgaTextBox22 = new MGATextBox();
    this.MgaTextBox21 = new MGATextBox();
    this.Label45 = new Label();
    this.MgaTextBox20 = new MGATextBox();
    this.Label44 = new Label();
    this.MgaTextBox19 = new MGATextBox();
    this.Label43 = new Label();
    this.MgaTextBox18 = new MGATextBox();
    this.Label42 = new Label();
    this.MgaTextBox17 = new MGATextBox();
    this.Label41 = new Label();
    this.MgaTextBox16 = new MGATextBox();
    this.Label40 = new Label();
    this.MgaTextBox15 = new MGATextBox();
    this.Label39 = new Label();
    this.MgaDateTimePicker7 = new MGADateTimePicker();
    this.Label38 = new Label();
    this.MgaDateTimePicker6 = new MGADateTimePicker();
    this.Label37 = new Label();
    this.MgaDateTimePicker5 = new MGADateTimePicker();
    this.Label36 = new Label();
    this.Label35 = new Label();
    this.MgaTextBox14 = new MGATextBox();
    this.MgaDateTimePicker4 = new MGADateTimePicker();
    this.Label34 = new Label();
    this.MgaTextBox13 = new MGATextBox();
    this.Label33 = new Label();
    this.MgaTextBox12 = new MGATextBox();
    this.Label32 = new Label();
    this.MgaTextBox11 = new MGATextBox();
    this.Label31 = new Label();
    this.MgaTextBox10 = new MGATextBox();
    this.Label30 = new Label();
    this.MgaTextBox9 = new MGATextBox();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.numContingentBIPaid = new MGANumericEditor();
    this.numBusIntPaid = new MGANumericEditor();
    this.lblContingentBIPaid = new Label();
    this.lblBusIntPaid = new Label();
    this.numContingentBIReserve = new MGANumericEditor();
    this.numBusIntReserve = new MGANumericEditor();
    this.lblContingentBIReserve = new Label();
    this.lblBusIntReserve = new Label();
    this.lblTPAExpPaid = new Label();
    this.numTPAExpPTD = new MGANumericEditor();
    this.lblDateCreated = new Label();
    this.dtDateCreated = new MGADateTimePicker();
    this.cboState = new MGASimpleComboBox();
    this.lblLatitude = new Label();
    this.txtLatitude = new MGATextBox();
    this.lblLongitude = new Label();
    this.txtLongitude = new MGATextBox();
    this.lblLossZip = new Label();
    this.txtLossZip = new MGATextBox();
    this.lblLossState = new Label();
    this.lblLossCity = new Label();
    this.txtLossCity = new MGATextBox();
    this.lblLossStreet = new Label();
    this.txtLossStreet = new MGATextBox();
    this.lblExpenseReserved = new Label();
    this.numExpenseReserved = new MGANumericEditor();
    this.lblExpensePaid = new Label();
    this.numExpensePaid = new MGANumericEditor();
    this.lblGrossLoss = new Label();
    this.numGrossLoss = new MGANumericEditor();
    this.lblMTDTPAExpensesPaid = new Label();
    this.numMTDTPAExpPaid = new MGANumericEditor();
    this.Label67 = new Label();
    this.MgaNumericEditor25 = new MGANumericEditor();
    this.Label61 = new Label();
    this.MgaNumericEditor23 = new MGANumericEditor();
    this.Label60 = new Label();
    this.MgaNumericEditor22 = new MGANumericEditor();
    this.Label59 = new Label();
    this.MgaNumericEditor21 = new MGANumericEditor();
    this.Label58 = new Label();
    this.MgaNumericEditor20 = new MGANumericEditor();
    this.Label57 = new Label();
    this.MgaNumericEditor19 = new MGANumericEditor();
    this.MgaNumericEditor18 = new MGANumericEditor();
    this.Label56 = new Label();
    this.MgaNumericEditor17 = new MGANumericEditor();
    this.Label55 = new Label();
    this.Label54 = new Label();
    this.dtValueDate = new MGADateTimePicker();
    this.Label51 = new Label();
    this.Label50 = new Label();
    this.Label49 = new Label();
    this.MgaNumericEditor16 = new MGANumericEditor();
    this.MgaNumericEditor15 = new MGANumericEditor();
    this.MgaTextBox23 = new MGATextBox();
    this.Label23 = new Label();
    this.MgaDateTimePicker2 = new MGADateTimePicker();
    this.MgaNumericEditor11 = new MGANumericEditor();
    this.Label20 = new Label();
    this.MgaNumericEditor12 = new MGANumericEditor();
    this.Label21 = new Label();
    this.MgaNumericEditor13 = new MGANumericEditor();
    this.Label22 = new Label();
    this.MgaNumericEditor10 = new MGANumericEditor();
    this.Label18 = new Label();
    this.MgaNumericEditor9 = new MGANumericEditor();
    this.Label17 = new Label();
    this.MgaNumericEditor8 = new MGANumericEditor();
    this.Label16 = new Label();
    this.MgaNumericEditor7 = new MGANumericEditor();
    this.MgaNumericEditor6 = new MGANumericEditor();
    this.MgaNumericEditor5 = new MGANumericEditor();
    this.MgaNumericEditor4 = new MGANumericEditor();
    this.MgaNumericEditor3 = new MGANumericEditor();
    this.MgaNumericEditor2 = new MGANumericEditor();
    this.MgaNumericEditor1 = new MGANumericEditor();
    this.Label15 = new Label();
    this.Label14 = new Label();
    this.Label13 = new Label();
    this.Label12 = new Label();
    this.Label11 = new Label();
    this.Label10 = new Label();
    this.Label9 = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.tabAdditionalReservesPayments = new UltraTabPageControl();
    this.Label85 = new Label();
    this.MgaTextBox27 = new MGATextBox();
    this.MgaNumericEditor42 = new MGANumericEditor();
    this.Label84 = new Label();
    this.MgaNumericEditor41 = new MGANumericEditor();
    this.Label83 = new Label();
    this.MgaNumericEditor40 = new MGANumericEditor();
    this.Label82 = new Label();
    this.MgaNumericEditor39 = new MGANumericEditor();
    this.Label81 = new Label();
    this.MgaNumericEditor38 = new MGANumericEditor();
    this.Label80 = new Label();
    this.MgaNumericEditor37 = new MGANumericEditor();
    this.Label79 = new Label();
    this.MgaNumericEditor36 = new MGANumericEditor();
    this.Label78 = new Label();
    this.MgaNumericEditor34 = new MGANumericEditor();
    this.MgaNumericEditor35 = new MGANumericEditor();
    this.Label77 = new Label();
    this.Label76 = new Label();
    this.Label75 = new Label();
    this.MgaNumericEditor33 = new MGANumericEditor();
    this.MgaNumericEditor32 = new MGANumericEditor();
    this.Label74 = new Label();
    this.MgaNumericEditor30 = new MGANumericEditor();
    this.Label73 = new Label();
    this.MgaNumericEditor31 = new MGANumericEditor();
    this.Label72 = new Label();
    this.Label71 = new Label();
    this.MgaNumericEditor29 = new MGANumericEditor();
    this.lblHailCode = new Label();
    this.numHailCode = new MGANumericEditor();
    this.lblAtcCode = new Label();
    this.numAtcCode = new MGANumericEditor();
    this.lblIsoCode = new Label();
    this.numIsoCode = new MGANumericEditor();
    this.daClaims = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand = DefaultDatabase.CreateCommand();
    this.DbInsertCommand = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand = DefaultDatabase.CreateCommand();
    this.daResPay = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand2 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand2 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand2 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand2 = DefaultDatabase.CreateCommand();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.MgaTab1 = new MGATab();
    this.gridClaims = new UltraGrid();
    this.err = new ErrorProvider(this.components);
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.dtClaimUpdated).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.MgaTxtComments).BeginInit();
    ((ISupportInitialize) this.MgaTextBox25).BeginInit();
    ((ISupportInitialize) this.MgaTextBox24).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor14).BeginInit();
    ((ISupportInitialize) this.MgaTextBox8).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox1).BeginInit();
    ((ISupportInitialize) this.MgaTextBox7).BeginInit();
    ((ISupportInitialize) this.MgaTextBox6).BeginInit();
    ((ISupportInitialize) this.MgaTextBox5).BeginInit();
    ((ISupportInitialize) this.MgaTextBox2).BeginInit();
    ((ISupportInitialize) this.MgaTextBox1).BeginInit();
    ((ISupportInitialize) this.MgaDateTimePicker1).BeginInit();
    ((ISupportInitialize) this.MgaDateTimePicker3).BeginInit();
    ((ISupportInitialize) this.txtStatus).BeginInit();
    ((ISupportInitialize) this.txtLossType).BeginInit();
    ((ISupportInitialize) this.dtDateOfLoss).BeginInit();
    ((ISupportInitialize) this.dtReported).BeginInit();
    ((ISupportInitialize) this.txtClaimNum).BeginInit();
    ((ISupportInitialize) this.MgaTextBox4).BeginInit();
    ((ISupportInitialize) this.MgaTextBox3).BeginInit();
    ((ISupportInitialize) this.CheckBox1).BeginInit();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.txtWatchList).BeginInit();
    ((ISupportInitialize) this.numLimit).BeginInit();
    ((ISupportInitialize) this.numTotalPaid).BeginInit();
    ((ISupportInitialize) this.txtCAT_Name_Details).BeginInit();
    ((ISupportInitialize) this.numAdjCaseReserves).BeginInit();
    ((ISupportInitialize) this.txtBodyPart).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor24).BeginInit();
    ((ISupportInitialize) this.MgaDateTimePicker10).BeginInit();
    ((ISupportInitialize) this.MgaDateTimePicker9).BeginInit();
    ((ISupportInitialize) this.MgaDateTimePicker8).BeginInit();
    ((ISupportInitialize) this.MgaTextBox26).BeginInit();
    ((ISupportInitialize) this.MgaTextBox22).BeginInit();
    ((ISupportInitialize) this.MgaTextBox21).BeginInit();
    ((ISupportInitialize) this.MgaTextBox20).BeginInit();
    ((ISupportInitialize) this.MgaTextBox19).BeginInit();
    ((ISupportInitialize) this.MgaTextBox18).BeginInit();
    ((ISupportInitialize) this.MgaTextBox17).BeginInit();
    ((ISupportInitialize) this.MgaTextBox16).BeginInit();
    ((ISupportInitialize) this.MgaTextBox15).BeginInit();
    ((ISupportInitialize) this.MgaDateTimePicker7).BeginInit();
    ((ISupportInitialize) this.MgaDateTimePicker6).BeginInit();
    ((ISupportInitialize) this.MgaDateTimePicker5).BeginInit();
    ((ISupportInitialize) this.MgaTextBox14).BeginInit();
    ((ISupportInitialize) this.MgaDateTimePicker4).BeginInit();
    ((ISupportInitialize) this.MgaTextBox13).BeginInit();
    ((ISupportInitialize) this.MgaTextBox12).BeginInit();
    ((ISupportInitialize) this.MgaTextBox11).BeginInit();
    ((ISupportInitialize) this.MgaTextBox10).BeginInit();
    ((ISupportInitialize) this.MgaTextBox9).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.numContingentBIPaid).BeginInit();
    ((ISupportInitialize) this.numBusIntPaid).BeginInit();
    ((ISupportInitialize) this.numContingentBIReserve).BeginInit();
    ((ISupportInitialize) this.numBusIntReserve).BeginInit();
    ((ISupportInitialize) this.numTPAExpPTD).BeginInit();
    ((ISupportInitialize) this.dtDateCreated).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.txtLatitude).BeginInit();
    ((ISupportInitialize) this.txtLongitude).BeginInit();
    ((ISupportInitialize) this.txtLossZip).BeginInit();
    ((ISupportInitialize) this.txtLossCity).BeginInit();
    ((ISupportInitialize) this.txtLossStreet).BeginInit();
    ((ISupportInitialize) this.numExpenseReserved).BeginInit();
    ((ISupportInitialize) this.numExpensePaid).BeginInit();
    ((ISupportInitialize) this.numGrossLoss).BeginInit();
    ((ISupportInitialize) this.numMTDTPAExpPaid).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor25).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor23).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor22).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor21).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor20).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor19).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor18).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor17).BeginInit();
    ((ISupportInitialize) this.dtValueDate).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor16).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor15).BeginInit();
    ((ISupportInitialize) this.MgaTextBox23).BeginInit();
    ((ISupportInitialize) this.MgaDateTimePicker2).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor11).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor12).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor13).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor10).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor9).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor8).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor7).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor6).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor5).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor4).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor3).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor2).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor1).BeginInit();
    ((Control) this.tabAdditionalReservesPayments).SuspendLayout();
    ((ISupportInitialize) this.MgaTextBox27).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor42).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor41).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor40).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor39).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor38).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor37).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor36).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor34).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor35).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor33).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor32).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor30).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor31).BeginInit();
    ((ISupportInitialize) this.MgaNumericEditor29).BeginInit();
    ((ISupportInitialize) this.numHailCode).BeginInit();
    ((ISupportInitialize) this.numAtcCode).BeginInit();
    ((ISupportInitialize) this.numIsoCode).BeginInit();
    ((ISupportInitialize) this.MgaTab1).BeginInit();
    ((Control) this.MgaTab1).SuspendLayout();
    ((ISupportInitialize) this.gridClaims).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkOrder);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dtClaimUpdated);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblDtClaimUpdated);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblComments);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTxtComments);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label53);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTextBox25);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label52);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTextBox24);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label48);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaNumericEditor14);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label29);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTextBox8);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaCheckBox1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label28);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTextBox7);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label27);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTextBox6);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTextBox5);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label26);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label25);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTextBox2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label24);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTextBox1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label19);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaDateTimePicker1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaDateTimePicker3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label6);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label5);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtStatus);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtLossType);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dtDateOfLoss);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dtReported);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtClaimNum);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label8);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTextBox4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label7);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaTextBox3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.CheckBox1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 30);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(879, 394);
    this.lnkOrder.AutoSize = true;
    this.lnkOrder.BackColor = Color.Transparent;
    this.lnkOrder.Location = new Point(631, 164);
    this.lnkOrder.Name = "lnkOrder";
    this.lnkOrder.Size = new Size(164, 13);
    this.lnkOrder.TabIndex = 186;
    this.lnkOrder.TabStop = true;
    this.lnkOrder.Tag = (object) " ";
    this.lnkOrder.Text = "Order Lexis Nexus Claims Report";
    this.lnkOrder.Visible = false;
    appearance1.BackColor = Color.LightYellow;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtClaimUpdated).Appearance = (AppearanceBase) appearance1;
    ((UltraDateTimeEditor) this.dtClaimUpdated).BackColor = Color.LightYellow;
    appearance2.AlphaLevel = (short) 14;
    appearance2.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance2.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance2.BackColorAlpha = (Alpha) 2;
    appearance2.BackGradientAlignment = (GradientAlignment) 4;
    appearance2.BackGradientStyle = (GradientStyle) 5;
    appearance2.BorderAlpha = (Alpha) 1;
    appearance2.BorderColor = Color.FromArgb(78, 122, 171);
    appearance2.ForeColor = Color.FromArgb(49, 85, 153);
    appearance2.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtClaimUpdated).ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dtClaimUpdated).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.LastClaimUpdated", true));
    ((UltraDateTimeEditor) this.dtClaimUpdated).DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.dtClaimUpdated).Location = new Point(94, 275);
    this.dtClaimUpdated.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtClaimUpdated).Name = "dtClaimUpdated";
    ((Control) this.dtClaimUpdated).Size = new Size(100, 20);
    ((Control) this.dtClaimUpdated).TabIndex = 41;
    ((UltraControlBase) this.dtClaimUpdated).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtClaimUpdated).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtClaimUpdated).Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    this.ds.DataSetName = "dsClaims";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lblDtClaimUpdated.BackColor = Color.Transparent;
    this.lblDtClaimUpdated.Location = new Point(10, 274);
    this.lblDtClaimUpdated.Name = "lblDtClaimUpdated";
    this.lblDtClaimUpdated.Size = new Size(78, 26);
    this.lblDtClaimUpdated.TabIndex = 42;
    this.lblDtClaimUpdated.Text = "Last Claim Updated:";
    this.lblDtClaimUpdated.TextAlign = ContentAlignment.MiddleLeft;
    this.lblComments.BackColor = Color.Transparent;
    this.lblComments.Location = new Point(318, 283);
    this.lblComments.Name = "lblComments";
    this.lblComments.Size = new Size(61, 17);
    this.lblComments.TabIndex = 40;
    this.lblComments.Text = "Comments:";
    this.lblComments.TextAlign = ContentAlignment.MiddleLeft;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTxtComments).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.MgaTxtComments).BackColor = Color.White;
    ((Control) this.MgaTxtComments).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.Comments", true));
    ((Control) this.MgaTxtComments).Location = new Point(405, 277);
    this.MgaTxtComments.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.MgaTxtComments).Multiline = true;
    ((Control) this.MgaTxtComments).Name = "MgaTxtComments";
    ((Control) this.MgaTxtComments).Size = new Size(326, 66);
    ((Control) this.MgaTxtComments).TabIndex = 39;
    ((UltraControlBase) this.MgaTxtComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTxtComments).UseOsThemes = (DefaultableBoolean) 2;
    this.Label53.BackColor = Color.Transparent;
    this.Label53.Location = new Point(563, 72);
    this.Label53.Name = "Label53";
    this.Label53.Size = new Size(66, 18);
    this.Label53.TabIndex = 13;
    this.Label53.Text = "Location ID:";
    this.Label53.TextAlign = ContentAlignment.MiddleRight;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox25).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.MgaTextBox25).BackColor = Color.White;
    ((Control) this.MgaTextBox25).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.LocationID", true));
    ((Control) this.MgaTextBox25).Location = new Point(635, 71);
    ((TextEditorControlBase) this.MgaTextBox25).MaxLength = 50;
    this.MgaTextBox25.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox25).Name = "MgaTextBox25";
    ((Control) this.MgaTextBox25).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.MgaTextBox25).TabIndex = 14;
    ((UltraControlBase) this.MgaTextBox25).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox25).UseOsThemes = (DefaultableBoolean) 2;
    this.Label52.AutoSize = true;
    this.Label52.BackColor = Color.Transparent;
    this.Label52.Location = new Point(318, (int) byte.MaxValue);
    this.Label52.Name = "Label52";
    this.Label52.Size = new Size(83, 13);
    this.Label52.TabIndex = 38;
    this.Label52.Text = "Carrier Claim #:";
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox24).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.MgaTextBox24).BackColor = Color.White;
    ((Control) this.MgaTextBox24).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.CarrierClaimNo", true));
    ((Control) this.MgaTextBox24).Location = new Point(405, 251);
    ((TextEditorControlBase) this.MgaTextBox24).MaxLength = 50;
    this.MgaTextBox24.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox24).Name = "MgaTextBox24";
    ((Control) this.MgaTextBox24).Size = new Size(193, 20);
    ((Control) this.MgaTextBox24).TabIndex = 20;
    ((UltraControlBase) this.MgaTextBox24).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox24).UseOsThemes = (DefaultableBoolean) 2;
    this.Label48.BackColor = Color.Transparent;
    this.Label48.Location = new Point(318, 73);
    this.Label48.Name = "Label48";
    this.Label48.Size = new Size(61, 17);
    this.Label48.TabIndex = 36;
    this.Label48.Text = "Age:";
    this.Label48.TextAlign = ContentAlignment.MiddleLeft;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor14).Appearance = (AppearanceBase) appearance6;
    ((Control) this.MgaNumericEditor14).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.Age", true));
    ((Control) this.MgaNumericEditor14).Location = new Point(405, 71);
    ((UltraNumericEditor) this.MgaNumericEditor14).MaxValue = (object) 500;
    this.MgaNumericEditor14.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.MgaNumericEditor14).MinValue = (object) 0;
    ((Control) this.MgaNumericEditor14).Name = "MgaNumericEditor14";
    ((UltraNumericEditor) this.MgaNumericEditor14).Nullable = true;
    ((Control) this.MgaNumericEditor14).Size = new Size(68, 20);
    ((Control) this.MgaNumericEditor14).TabIndex = 11;
    ((UltraWinEditorMaskedControlBase) this.MgaNumericEditor14).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.MgaNumericEditor14).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor14).UseOsThemes = (DefaultableBoolean) 2;
    this.Label29.AutoSize = true;
    this.Label29.BackColor = Color.Transparent;
    this.Label29.Location = new Point(318, 225);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(30, 13);
    this.Label29.TabIndex = 34;
    this.Label29.Text = "LOB:";
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox8).Appearance = (AppearanceBase) appearance7;
    ((TextEditorControlBase) this.MgaTextBox8).BackColor = Color.White;
    ((Control) this.MgaTextBox8).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.LOB", true));
    ((Control) this.MgaTextBox8).Location = new Point(405, 221);
    ((TextEditorControlBase) this.MgaTextBox8).MaxLength = 50;
    this.MgaTextBox8.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox8).Name = "MgaTextBox8";
    ((Control) this.MgaTextBox8).Size = new Size(193, 20);
    ((Control) this.MgaTextBox8).TabIndex = 19;
    ((UltraControlBase) this.MgaTextBox8).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox8).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox1).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblClaimInformation.Occurence", true));
    ((UltraToggleEditorBase) this.MgaCheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox1).Location = new Point(479, 71);
    this.MgaCheckBox1.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCheckBox1).Name = "MgaCheckBox1";
    ((Control) this.MgaCheckBox1).Size = new Size(78, 21);
    ((Control) this.MgaCheckBox1).TabIndex = 12;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Text = "Occurence";
    ((UltraControlBase) this.MgaCheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label28.AutoSize = true;
    this.Label28.BackColor = Color.Transparent;
    this.Label28.Location = new Point(318, 195);
    this.Label28.Name = "Label28";
    this.Label28.Size = new Size(74, 13);
    this.Label28.TabIndex = 31 /*0x1F*/;
    this.Label28.Text = "Branch Name:";
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox7).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.MgaTextBox7).BackColor = Color.White;
    ((Control) this.MgaTextBox7).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.CorresBranchName", true));
    ((Control) this.MgaTextBox7).Location = new Point(405, 191);
    ((TextEditorControlBase) this.MgaTextBox7).MaxLength = 100;
    this.MgaTextBox7.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox7).Name = "MgaTextBox7";
    ((Control) this.MgaTextBox7).Size = new Size(193, 20);
    ((Control) this.MgaTextBox7).TabIndex = 18;
    ((UltraControlBase) this.MgaTextBox7).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox7).UseOsThemes = (DefaultableBoolean) 2;
    this.Label27.AutoSize = true;
    this.Label27.BackColor = Color.Transparent;
    this.Label27.Location = new Point(318, 165);
    this.Label27.Name = "Label27";
    this.Label27.Size = new Size(56, 13);
    this.Label27.TabIndex = 29;
    this.Label27.Text = "Company:";
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox6).Appearance = (AppearanceBase) appearance10;
    ((TextEditorControlBase) this.MgaTextBox6).BackColor = Color.White;
    ((Control) this.MgaTextBox6).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.Company", true));
    ((Control) this.MgaTextBox6).Location = new Point(405, 161);
    ((TextEditorControlBase) this.MgaTextBox6).MaxLength = 100;
    this.MgaTextBox6.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox6).Name = "MgaTextBox6";
    ((Control) this.MgaTextBox6).Size = new Size(193, 20);
    ((Control) this.MgaTextBox6).TabIndex = 17;
    ((UltraControlBase) this.MgaTextBox6).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox6).UseOsThemes = (DefaultableBoolean) 2;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox5).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.MgaTextBox5).BackColor = Color.White;
    ((Control) this.MgaTextBox5).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.CoverageDescription", true));
    ((Control) this.MgaTextBox5).Location = new Point(405, 131);
    ((TextEditorControlBase) this.MgaTextBox5).MaxLength = 300;
    this.MgaTextBox5.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox5).Name = "MgaTextBox5";
    ((Control) this.MgaTextBox5).Size = new Size(256 /*0x0100*/, 20);
    ((Control) this.MgaTextBox5).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.MgaTextBox5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox5).UseOsThemes = (DefaultableBoolean) 2;
    this.Label26.BackColor = Color.Transparent;
    this.Label26.Location = new Point(318, 130);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(88, 23);
    this.Label26.TabIndex = 26;
    this.Label26.Text = "Coverage Desc:";
    this.Label26.TextAlign = ContentAlignment.MiddleLeft;
    this.Label25.BackColor = Color.Transparent;
    this.Label25.Location = new Point(318, 100);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(61, 23);
    this.Label25.TabIndex = 25;
    this.Label25.Text = "Deductible:";
    this.Label25.TextAlign = ContentAlignment.MiddleRight;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox2).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.MgaTextBox2).BackColor = Color.White;
    ((Control) this.MgaTextBox2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.Deductible", true));
    ((Control) this.MgaTextBox2).Location = new Point(405, 101);
    ((TextEditorControlBase) this.MgaTextBox2).MaxLength = 25;
    this.MgaTextBox2.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox2).Name = "MgaTextBox2";
    ((Control) this.MgaTextBox2).Size = new Size(256 /*0x0100*/, 20);
    ((Control) this.MgaTextBox2).TabIndex = 15;
    ((UltraControlBase) this.MgaTextBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox2).UseOsThemes = (DefaultableBoolean) 2;
    this.Label24.BackColor = Color.Transparent;
    this.Label24.Location = new Point(318, 40);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(61, 23);
    this.Label24.TabIndex = 23;
    this.Label24.Text = "Claimant:";
    this.Label24.TextAlign = ContentAlignment.MiddleLeft;
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox1).Appearance = (AppearanceBase) appearance13;
    ((TextEditorControlBase) this.MgaTextBox1).BackColor = Color.White;
    ((Control) this.MgaTextBox1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.Claimant", true));
    ((Control) this.MgaTextBox1).Location = new Point(405, 41);
    ((TextEditorControlBase) this.MgaTextBox1).MaxLength = 70;
    this.MgaTextBox1.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox1).Name = "MgaTextBox1";
    ((Control) this.MgaTextBox1).Size = new Size(326, 20);
    ((Control) this.MgaTextBox1).TabIndex = 10;
    ((UltraControlBase) this.MgaTextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Location = new Point(10, 70);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(78, 23);
    this.Label19.TabIndex = 21;
    this.Label19.Text = "Received:";
    this.Label19.TextAlign = ContentAlignment.MiddleLeft;
    appearance14.BackColor = Color.LightYellow;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.MgaDateTimePicker1).Appearance = (AppearanceBase) appearance14;
    ((UltraDateTimeEditor) this.MgaDateTimePicker1).BackColor = Color.LightYellow;
    appearance15.AlphaLevel = (short) 14;
    appearance15.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance15.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance15.BackColorAlpha = (Alpha) 2;
    appearance15.BackGradientAlignment = (GradientAlignment) 4;
    appearance15.BackGradientStyle = (GradientStyle) 5;
    appearance15.BorderAlpha = (Alpha) 1;
    appearance15.BorderColor = Color.FromArgb(78, 122, 171);
    appearance15.ForeColor = Color.FromArgb(49, 85, 153);
    appearance15.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker1).ButtonAppearance = (AppearanceBase) appearance15;
    ((Control) this.MgaDateTimePicker1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.DateReceived", true));
    ((UltraDateTimeEditor) this.MgaDateTimePicker1).DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.MgaDateTimePicker1).Location = new Point(94, 71);
    this.MgaDateTimePicker1.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaDateTimePicker1).Name = "MgaDateTimePicker1";
    ((Control) this.MgaDateTimePicker1).Size = new Size(100, 20);
    ((Control) this.MgaDateTimePicker1).TabIndex = 2;
    ((UltraControlBase) this.MgaDateTimePicker1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaDateTimePicker1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker1).Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    appearance16.BackColor = Color.LightYellow;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.MgaDateTimePicker3).Appearance = (AppearanceBase) appearance16;
    ((UltraDateTimeEditor) this.MgaDateTimePicker3).BackColor = Color.LightYellow;
    appearance17.AlphaLevel = (short) 14;
    appearance17.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance17.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance17.BackColorAlpha = (Alpha) 2;
    appearance17.BackGradientAlignment = (GradientAlignment) 4;
    appearance17.BackGradientStyle = (GradientStyle) 5;
    appearance17.BorderAlpha = (Alpha) 1;
    appearance17.BorderColor = Color.FromArgb(78, 122, 171);
    appearance17.ForeColor = Color.FromArgb(49, 85, 153);
    appearance17.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker3).ButtonAppearance = (AppearanceBase) appearance17;
    ((Control) this.MgaDateTimePicker3).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.DateClosed", true));
    ((UltraDateTimeEditor) this.MgaDateTimePicker3).DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.MgaDateTimePicker3).Location = new Point(94, 161);
    this.MgaDateTimePicker3.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaDateTimePicker3).Name = "MgaDateTimePicker3";
    ((Control) this.MgaDateTimePicker3).Size = new Size(100, 20);
    ((Control) this.MgaDateTimePicker3).TabIndex = 5;
    ((UltraControlBase) this.MgaDateTimePicker3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaDateTimePicker3).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker3).Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(10, 160 /*0xA0*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(78, 23);
    this.Label6.TabIndex = 12;
    this.Label6.Text = "Closed:";
    this.Label6.TextAlign = ContentAlignment.MiddleLeft;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(10, 190);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(78, 23);
    this.Label5.TabIndex = 9;
    this.Label5.Text = "Status:";
    this.Label5.TextAlign = ContentAlignment.MiddleLeft;
    appearance18.BackColor = Color.White;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance18.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtStatus).Appearance = (AppearanceBase) appearance18;
    ((TextEditorControlBase) this.txtStatus).BackColor = Color.White;
    ((Control) this.txtStatus).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.Status", true));
    ((Control) this.txtStatus).Location = new Point(94, 191);
    this.txtStatus.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtStatus).Name = "txtStatus";
    ((Control) this.txtStatus).Size = new Size(210, 20);
    ((Control) this.txtStatus).TabIndex = 6;
    ((UltraControlBase) this.txtStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtStatus).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(10, 220);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(70, 23);
    this.Label4.TabIndex = 7;
    this.Label4.Text = "Loss Type:";
    this.Label4.TextAlign = ContentAlignment.MiddleLeft;
    appearance19.BackColor = Color.White;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLossType).Appearance = (AppearanceBase) appearance19;
    ((TextEditorControlBase) this.txtLossType).BackColor = Color.White;
    ((Control) this.txtLossType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.LossType", true));
    ((Control) this.txtLossType).Location = new Point(94, 221);
    this.txtLossType.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtLossType).Name = "txtLossType";
    ((Control) this.txtLossType).Size = new Size(210, 20);
    ((Control) this.txtLossType).TabIndex = 7;
    ((UltraControlBase) this.txtLossType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLossType).UseOsThemes = (DefaultableBoolean) 2;
    appearance20.BackColor = Color.LightYellow;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtDateOfLoss).Appearance = (AppearanceBase) appearance20;
    ((UltraDateTimeEditor) this.dtDateOfLoss).BackColor = Color.LightYellow;
    appearance21.AlphaLevel = (short) 14;
    appearance21.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance21.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance21.BackColorAlpha = (Alpha) 2;
    appearance21.BackGradientAlignment = (GradientAlignment) 4;
    appearance21.BackGradientStyle = (GradientStyle) 5;
    appearance21.BorderAlpha = (Alpha) 1;
    appearance21.BorderColor = Color.FromArgb(78, 122, 171);
    appearance21.ForeColor = Color.FromArgb(49, 85, 153);
    appearance21.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtDateOfLoss).ButtonAppearance = (AppearanceBase) appearance21;
    ((Control) this.dtDateOfLoss).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.LossDate", true));
    ((UltraDateTimeEditor) this.dtDateOfLoss).DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.dtDateOfLoss).Location = new Point(94, 131);
    this.dtDateOfLoss.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtDateOfLoss).Name = "dtDateOfLoss";
    ((Control) this.dtDateOfLoss).Size = new Size(100, 20);
    ((Control) this.dtDateOfLoss).TabIndex = 4;
    ((UltraControlBase) this.dtDateOfLoss).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtDateOfLoss).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtDateOfLoss).Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(10, 130);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(78, 23);
    this.Label3.TabIndex = 5;
    this.Label3.Text = "Date of Loss:";
    this.Label3.TextAlign = ContentAlignment.MiddleLeft;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(10, 100);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(79, 23);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Reported:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    appearance22.BackColor = Color.LightYellow;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtReported).Appearance = (AppearanceBase) appearance22;
    ((UltraDateTimeEditor) this.dtReported).BackColor = Color.LightYellow;
    appearance23.AlphaLevel = (short) 14;
    appearance23.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance23.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance23.BackColorAlpha = (Alpha) 2;
    appearance23.BackGradientAlignment = (GradientAlignment) 4;
    appearance23.BackGradientStyle = (GradientStyle) 5;
    appearance23.BorderAlpha = (Alpha) 1;
    appearance23.BorderColor = Color.FromArgb(78, 122, 171);
    appearance23.ForeColor = Color.FromArgb(49, 85, 153);
    appearance23.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtReported).ButtonAppearance = (AppearanceBase) appearance23;
    ((Control) this.dtReported).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.DateReported", true));
    ((UltraDateTimeEditor) this.dtReported).DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.dtReported).Location = new Point(94, 101);
    this.dtReported.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtReported).Name = "dtReported";
    ((Control) this.dtReported).Size = new Size(100, 20);
    ((Control) this.dtReported).TabIndex = 3;
    ((UltraControlBase) this.dtReported).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtReported).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtReported).Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    appearance24.BackColor = Color.White;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance24.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtClaimNum).Appearance = (AppearanceBase) appearance24;
    ((TextEditorControlBase) this.txtClaimNum).BackColor = Color.White;
    ((Control) this.txtClaimNum).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.ClaimNo", true));
    ((Control) this.txtClaimNum).Location = new Point(94, 11);
    this.txtClaimNum.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtClaimNum).Name = "txtClaimNum";
    ((Control) this.txtClaimNum).Size = new Size(100, 20);
    ((Control) this.txtClaimNum).TabIndex = 0;
    ((UltraControlBase) this.txtClaimNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtClaimNum).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(10, 10);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(78, 23);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Claim/File #:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(10, 40);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(78, 23);
    this.Label8.TabIndex = 16 /*0x10*/;
    this.Label8.Text = "CAT #:";
    this.Label8.TextAlign = ContentAlignment.MiddleLeft;
    appearance25.BackColor = Color.White;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance25.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox4).Appearance = (AppearanceBase) appearance25;
    ((TextEditorControlBase) this.MgaTextBox4).BackColor = Color.White;
    ((Control) this.MgaTextBox4).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.CATNo", true));
    ((Control) this.MgaTextBox4).Location = new Point(94, 41);
    this.MgaTextBox4.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox4).Name = "MgaTextBox4";
    ((Control) this.MgaTextBox4).Size = new Size(100, 20);
    ((Control) this.MgaTextBox4).TabIndex = 1;
    ((UltraControlBase) this.MgaTextBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox4).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(318, 9);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(61, 17);
    this.Label7.TabIndex = 14;
    this.Label7.Text = "Injury:";
    this.Label7.TextAlign = ContentAlignment.MiddleLeft;
    appearance26.BackColor = Color.White;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance26.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox3).Appearance = (AppearanceBase) appearance26;
    ((TextEditorControlBase) this.MgaTextBox3).BackColor = Color.White;
    ((Control) this.MgaTextBox3).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.DescriptionInjury", true));
    ((Control) this.MgaTextBox3).Location = new Point(405, 3);
    this.MgaTextBox3.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.MgaTextBox3).Multiline = true;
    ((Control) this.MgaTextBox3).Name = "MgaTextBox3";
    ((Control) this.MgaTextBox3).Size = new Size(326, 29);
    ((Control) this.MgaTextBox3).TabIndex = 9;
    ((UltraControlBase) this.MgaTextBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox3).UseOsThemes = (DefaultableBoolean) 2;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.CheckBox1).Appearance = (AppearanceBase) appearance27;
    ((UltraToggleEditorBase) this.CheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.CheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.CheckBox1).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblClaimInformation.InLitigation", true));
    ((UltraToggleEditorBase) this.CheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.CheckBox1).Location = new Point(94, 251);
    this.CheckBox1.MGAStyle = (MGAStyles) 2;
    ((Control) this.CheckBox1).Name = "CheckBox1";
    ((Control) this.CheckBox1).Size = new Size(120, 20);
    ((Control) this.CheckBox1).TabIndex = 8;
    ((UltraToggleEditorBase) this.CheckBox1).Text = "In Litigation";
    ((UltraControlBase) this.CheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.CheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label68);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtWatchList);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.numLimit);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblLimit);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.numTotalPaid);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblTotalPaid);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtCAT_Name_Details);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblCAT_Name_Details);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.numAdjCaseReserves);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblAdjCaseReserves);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblBodyPart);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.txtBodyPart);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaNumericEditor24);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label66);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaDateTimePicker10);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label65);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaDateTimePicker9);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label64);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label63);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaDateTimePicker8);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label62);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox26);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label47);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label46);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox22);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox21);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label45);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox20);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label44);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox19);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label43);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox18);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label42);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox17);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label41);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox16);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label40);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox15);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label39);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaDateTimePicker7);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label38);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaDateTimePicker6);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label37);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaDateTimePicker5);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label36);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label35);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox14);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaDateTimePicker4);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label34);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox13);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label33);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox12);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label32);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox11);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label31);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox10);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label30);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.MgaTextBox9);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(879, 394);
    this.Label68.AutoSize = true;
    this.Label68.BackColor = Color.Transparent;
    this.Label68.Location = new Point(615, 135);
    this.Label68.Name = "Label68";
    this.Label68.Size = new Size(61, 13);
    this.Label68.TabIndex = 97;
    this.Label68.Text = "Watch List:";
    appearance28.BackColor = Color.White;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance28.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtWatchList).Appearance = (AppearanceBase) appearance28;
    ((TextEditorControlBase) this.txtWatchList).BackColor = Color.White;
    ((Control) this.txtWatchList).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.WatchList", true));
    ((Control) this.txtWatchList).Location = new Point(723, 136);
    ((TextEditorControlBase) this.txtWatchList).MaxLength = 100;
    this.txtWatchList.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.txtWatchList).Multiline = true;
    ((Control) this.txtWatchList).Name = "txtWatchList";
    ((Control) this.txtWatchList).Size = new Size(128 /*0x80*/, 62);
    ((Control) this.txtWatchList).TabIndex = 96 /*0x60*/;
    ((UltraControlBase) this.txtWatchList).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtWatchList).UseOsThemes = (DefaultableBoolean) 2;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numLimit).Appearance = (AppearanceBase) appearance29;
    ((Control) this.numLimit).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.Limit", true));
    ((Control) this.numLimit).Location = new Point(723, 82);
    this.numLimit.MGAStyle = (MGAStyles) 2;
    ((Control) this.numLimit).Name = "numLimit";
    ((UltraNumericEditor) this.numLimit).Nullable = true;
    ((UltraNumericEditor) this.numLimit).NumericType = (NumericType) 1;
    ((Control) this.numLimit).Size = new Size(84, 20);
    ((Control) this.numLimit).TabIndex = 95;
    ((UltraWinEditorMaskedControlBase) this.numLimit).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numLimit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numLimit).UseOsThemes = (DefaultableBoolean) 2;
    this.lblLimit.AutoSize = true;
    this.lblLimit.BackColor = Color.Transparent;
    this.lblLimit.Location = new Point(615, 85);
    this.lblLimit.Name = "lblLimit";
    this.lblLimit.Size = new Size(32 /*0x20*/, 13);
    this.lblLimit.TabIndex = 94;
    this.lblLimit.Text = "Limit:";
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numTotalPaid).Appearance = (AppearanceBase) appearance30;
    ((Control) this.numTotalPaid).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.TotalPaid", true));
    ((Control) this.numTotalPaid).Location = new Point(723, 56);
    this.numTotalPaid.MGAStyle = (MGAStyles) 2;
    ((Control) this.numTotalPaid).Name = "numTotalPaid";
    ((UltraNumericEditor) this.numTotalPaid).Nullable = true;
    ((UltraNumericEditor) this.numTotalPaid).NumericType = (NumericType) 1;
    ((Control) this.numTotalPaid).Size = new Size(84, 20);
    ((Control) this.numTotalPaid).TabIndex = 93;
    ((UltraWinEditorMaskedControlBase) this.numTotalPaid).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numTotalPaid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numTotalPaid).UseOsThemes = (DefaultableBoolean) 2;
    this.lblTotalPaid.AutoSize = true;
    this.lblTotalPaid.BackColor = Color.Transparent;
    this.lblTotalPaid.Location = new Point(615, 60);
    this.lblTotalPaid.Name = "lblTotalPaid";
    this.lblTotalPaid.Size = new Size(58, 13);
    this.lblTotalPaid.TabIndex = 92;
    this.lblTotalPaid.Text = "Total Paid:";
    appearance31.BackColor = Color.White;
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance31.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCAT_Name_Details).Appearance = (AppearanceBase) appearance31;
    ((TextEditorControlBase) this.txtCAT_Name_Details).BackColor = Color.White;
    ((Control) this.txtCAT_Name_Details).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.CAT_Name_Details", true));
    ((Control) this.txtCAT_Name_Details).Location = new Point(103, 284);
    ((TextEditorControlBase) this.txtCAT_Name_Details).MaxLength = 2000;
    this.txtCAT_Name_Details.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.txtCAT_Name_Details).Multiline = true;
    ((Control) this.txtCAT_Name_Details).Name = "txtCAT_Name_Details";
    ((Control) this.txtCAT_Name_Details).Size = new Size(193, 63 /*0x3F*/);
    ((Control) this.txtCAT_Name_Details).TabIndex = 91;
    ((UltraControlBase) this.txtCAT_Name_Details).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCAT_Name_Details).UseOsThemes = (DefaultableBoolean) 2;
    this.lblCAT_Name_Details.AutoSize = true;
    this.lblCAT_Name_Details.BackColor = Color.Transparent;
    this.lblCAT_Name_Details.Location = new Point(9, 287);
    this.lblCAT_Name_Details.Name = "lblCAT_Name_Details";
    this.lblCAT_Name_Details.Size = new Size(91, 13);
    this.lblCAT_Name_Details.TabIndex = 90;
    this.lblCAT_Name_Details.Text = "CAT Name Detail:";
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numAdjCaseReserves).Appearance = (AppearanceBase) appearance32;
    ((Control) this.numAdjCaseReserves).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.RejectedAmount", true));
    ((Control) this.numAdjCaseReserves).Location = new Point(723, 31 /*0x1F*/);
    this.numAdjCaseReserves.MGAStyle = (MGAStyles) 2;
    ((Control) this.numAdjCaseReserves).Name = "numAdjCaseReserves";
    ((UltraNumericEditor) this.numAdjCaseReserves).Nullable = true;
    ((UltraNumericEditor) this.numAdjCaseReserves).NumericType = (NumericType) 1;
    ((Control) this.numAdjCaseReserves).Size = new Size(84, 20);
    ((Control) this.numAdjCaseReserves).TabIndex = 89;
    ((UltraWinEditorMaskedControlBase) this.numAdjCaseReserves).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numAdjCaseReserves).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numAdjCaseReserves).UseOsThemes = (DefaultableBoolean) 2;
    this.lblAdjCaseReserves.AutoSize = true;
    this.lblAdjCaseReserves.BackColor = Color.Transparent;
    this.lblAdjCaseReserves.Location = new Point(615, 35);
    this.lblAdjCaseReserves.Name = "lblAdjCaseReserves";
    this.lblAdjCaseReserves.Size = new Size(102, 13);
    this.lblAdjCaseReserves.TabIndex = 88;
    this.lblAdjCaseReserves.Text = "Adj Case Reserves:";
    this.lblBodyPart.AutoSize = true;
    this.lblBodyPart.BackColor = Color.Transparent;
    this.lblBodyPart.Location = new Point(615, 109);
    this.lblBodyPart.Name = "lblBodyPart";
    this.lblBodyPart.Size = new Size(58, 13);
    this.lblBodyPart.TabIndex = 87;
    this.lblBodyPart.Text = "Body Part:";
    appearance33.BackColor = Color.White;
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance33.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtBodyPart).Appearance = (AppearanceBase) appearance33;
    ((TextEditorControlBase) this.txtBodyPart).BackColor = Color.White;
    ((Control) this.txtBodyPart).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.BodyPart", true));
    ((Control) this.txtBodyPart).Location = new Point(723, 110);
    ((TextEditorControlBase) this.txtBodyPart).MaxLength = 50;
    this.txtBodyPart.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtBodyPart).Name = "txtBodyPart";
    ((Control) this.txtBodyPart).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.txtBodyPart).TabIndex = 86;
    ((UltraControlBase) this.txtBodyPart).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtBodyPart).UseOsThemes = (DefaultableBoolean) 2;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor24).Appearance = (AppearanceBase) appearance34;
    ((Control) this.MgaNumericEditor24).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.RejectedAmount", true));
    ((Control) this.MgaNumericEditor24).Location = new Point(723, 6);
    this.MgaNumericEditor24.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor24).Name = "MgaNumericEditor24";
    ((UltraNumericEditor) this.MgaNumericEditor24).Nullable = true;
    ((UltraNumericEditor) this.MgaNumericEditor24).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor24).Size = new Size(84, 20);
    ((Control) this.MgaNumericEditor24).TabIndex = 22;
    ((UltraWinEditorMaskedControlBase) this.MgaNumericEditor24).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.MgaNumericEditor24).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor24).UseOsThemes = (DefaultableBoolean) 2;
    this.Label66.BackColor = Color.Transparent;
    this.Label66.Location = new Point(615, 5);
    this.Label66.Name = "Label66";
    this.Label66.Size = new Size(99, 23);
    this.Label66.TabIndex = 85;
    this.Label66.Text = "Rejected Amount:";
    this.Label66.TextAlign = ContentAlignment.MiddleLeft;
    appearance35.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.MgaDateTimePicker10).Appearance = (AppearanceBase) appearance35;
    appearance36.AlphaLevel = (short) 14;
    appearance36.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance36.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance36.BackColorAlpha = (Alpha) 2;
    appearance36.BackGradientAlignment = (GradientAlignment) 4;
    appearance36.BackGradientStyle = (GradientStyle) 5;
    appearance36.BorderAlpha = (Alpha) 1;
    appearance36.BorderColor = Color.FromArgb(78, 122, 171);
    appearance36.ForeColor = Color.FromArgb(49, 85, 153);
    appearance36.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker10).ButtonAppearance = (AppearanceBase) appearance36;
    ((Control) this.MgaDateTimePicker10).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.RejectedDate", true));
    ((UltraDateTimeEditor) this.MgaDateTimePicker10).DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.MgaDateTimePicker10).Location = new Point(434, 256 /*0x0100*/);
    this.MgaDateTimePicker10.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaDateTimePicker10).Name = "MgaDateTimePicker10";
    ((Control) this.MgaDateTimePicker10).Size = new Size(86, 20);
    ((Control) this.MgaDateTimePicker10).TabIndex = 21;
    ((UltraControlBase) this.MgaDateTimePicker10).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaDateTimePicker10).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker10).Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    this.Label65.AutoSize = true;
    this.Label65.BackColor = Color.Transparent;
    this.Label65.Location = new Point(311, 260);
    this.Label65.Name = "Label65";
    this.Label65.Size = new Size(80 /*0x50*/, 13);
    this.Label65.TabIndex = 83;
    this.Label65.Text = "Rejected Date:";
    appearance37.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.MgaDateTimePicker9).Appearance = (AppearanceBase) appearance37;
    appearance38.AlphaLevel = (short) 14;
    appearance38.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance38.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance38.BackColorAlpha = (Alpha) 2;
    appearance38.BackGradientAlignment = (GradientAlignment) 4;
    appearance38.BackGradientStyle = (GradientStyle) 5;
    appearance38.BorderAlpha = (Alpha) 1;
    appearance38.BorderColor = Color.FromArgb(78, 122, 171);
    appearance38.ForeColor = Color.FromArgb(49, 85, 153);
    appearance38.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker9).ButtonAppearance = (AppearanceBase) appearance38;
    ((Control) this.MgaDateTimePicker9).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.OriginalLoanDate", true));
    ((UltraDateTimeEditor) this.MgaDateTimePicker9).DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.MgaDateTimePicker9).Location = new Point(434, 206);
    this.MgaDateTimePicker9.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaDateTimePicker9).Name = "MgaDateTimePicker9";
    ((Control) this.MgaDateTimePicker9).Size = new Size(86, 20);
    ((Control) this.MgaDateTimePicker9).TabIndex = 19;
    ((UltraControlBase) this.MgaDateTimePicker9).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaDateTimePicker9).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker9).Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    this.Label64.AutoSize = true;
    this.Label64.BackColor = Color.Transparent;
    this.Label64.Location = new Point(311, 210);
    this.Label64.Name = "Label64";
    this.Label64.Size = new Size(87, 13);
    this.Label64.TabIndex = 81;
    this.Label64.Text = "Orig. Loan Date:";
    this.Label63.AutoSize = true;
    this.Label63.BackColor = Color.Transparent;
    this.Label63.Location = new Point(311, 235);
    this.Label63.Name = "Label63";
    this.Label63.Size = new Size(57, 13);
    this.Label63.TabIndex = 80 /*0x50*/;
    this.Label63.Text = "Date Paid:";
    appearance39.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.MgaDateTimePicker8).Appearance = (AppearanceBase) appearance39;
    appearance40.AlphaLevel = (short) 14;
    appearance40.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance40.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance40.BackColorAlpha = (Alpha) 2;
    appearance40.BackGradientAlignment = (GradientAlignment) 4;
    appearance40.BackGradientStyle = (GradientStyle) 5;
    appearance40.BorderAlpha = (Alpha) 1;
    appearance40.BorderColor = Color.FromArgb(78, 122, 171);
    appearance40.ForeColor = Color.FromArgb(49, 85, 153);
    appearance40.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker8).ButtonAppearance = (AppearanceBase) appearance40;
    ((Control) this.MgaDateTimePicker8).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.DatePaid", true));
    ((UltraDateTimeEditor) this.MgaDateTimePicker8).DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.MgaDateTimePicker8).Location = new Point(434, 231);
    this.MgaDateTimePicker8.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaDateTimePicker8).Name = "MgaDateTimePicker8";
    ((Control) this.MgaDateTimePicker8).Size = new Size(86, 20);
    ((Control) this.MgaDateTimePicker8).TabIndex = 20;
    ((UltraControlBase) this.MgaDateTimePicker8).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaDateTimePicker8).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker8).Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    this.Label62.AutoSize = true;
    this.Label62.BackColor = Color.Transparent;
    this.Label62.Location = new Point(9, 260);
    this.Label62.Name = "Label62";
    this.Label62.Size = new Size(40, 13);
    this.Label62.TabIndex = 78;
    this.Label62.Text = "Driver:";
    appearance41.BackColor = Color.White;
    appearance41.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance41.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox26).Appearance = (AppearanceBase) appearance41;
    ((TextEditorControlBase) this.MgaTextBox26).BackColor = Color.White;
    ((Control) this.MgaTextBox26).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.Driver", true));
    ((Control) this.MgaTextBox26).Location = new Point(103, 256 /*0x0100*/);
    ((TextEditorControlBase) this.MgaTextBox26).MaxLength = 100;
    this.MgaTextBox26.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox26).Name = "MgaTextBox26";
    ((Control) this.MgaTextBox26).Size = new Size(193, 20);
    ((Control) this.MgaTextBox26).TabIndex = 10;
    ((UltraControlBase) this.MgaTextBox26).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox26).UseOsThemes = (DefaultableBoolean) 2;
    this.Label47.AutoSize = true;
    this.Label47.BackColor = Color.Transparent;
    this.Label47.Location = new Point(311, 185);
    this.Label47.Name = "Label47";
    this.Label47.Size = new Size(46, 13);
    this.Label47.TabIndex = 76;
    this.Label47.Text = "County:";
    this.Label46.AutoSize = true;
    this.Label46.BackColor = Color.Transparent;
    this.Label46.Location = new Point(311, 160 /*0xA0*/);
    this.Label46.Name = "Label46";
    this.Label46.Size = new Size(46, 13);
    this.Label46.TabIndex = 75;
    this.Label46.Text = "Gender:";
    appearance42.BackColor = Color.White;
    appearance42.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance42.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox22).Appearance = (AppearanceBase) appearance42;
    ((TextEditorControlBase) this.MgaTextBox22).BackColor = Color.White;
    ((Control) this.MgaTextBox22).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.County", true));
    ((Control) this.MgaTextBox22).Location = new Point(434, 181);
    ((TextEditorControlBase) this.MgaTextBox22).MaxLength = 10;
    this.MgaTextBox22.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox22).Name = "MgaTextBox22";
    ((Control) this.MgaTextBox22).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.MgaTextBox22).TabIndex = 18;
    ((UltraControlBase) this.MgaTextBox22).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox22).UseOsThemes = (DefaultableBoolean) 2;
    appearance43.BackColor = Color.White;
    appearance43.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance43.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox21).Appearance = (AppearanceBase) appearance43;
    ((TextEditorControlBase) this.MgaTextBox21).BackColor = Color.White;
    ((Control) this.MgaTextBox21).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.Gender", true));
    ((Control) this.MgaTextBox21).Location = new Point(434, 156);
    ((TextEditorControlBase) this.MgaTextBox21).MaxLength = 10;
    this.MgaTextBox21.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox21).Name = "MgaTextBox21";
    ((Control) this.MgaTextBox21).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.MgaTextBox21).TabIndex = 17;
    ((UltraControlBase) this.MgaTextBox21).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox21).UseOsThemes = (DefaultableBoolean) 2;
    this.Label45.AutoSize = true;
    this.Label45.BackColor = Color.Transparent;
    this.Label45.Location = new Point(311, 135);
    this.Label45.Name = "Label45";
    this.Label45.Size = new Size(93, 13);
    this.Label45.TabIndex = 72;
    this.Label45.Text = "Claimant Counsel:";
    appearance44.BackColor = Color.White;
    appearance44.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance44.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox20).Appearance = (AppearanceBase) appearance44;
    ((TextEditorControlBase) this.MgaTextBox20).BackColor = Color.White;
    ((Control) this.MgaTextBox20).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.ClaimantCounsel", true));
    ((Control) this.MgaTextBox20).Location = new Point(434, 131);
    ((TextEditorControlBase) this.MgaTextBox20).MaxLength = 100;
    this.MgaTextBox20.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox20).Name = "MgaTextBox20";
    ((Control) this.MgaTextBox20).Size = new Size(175, 20);
    ((Control) this.MgaTextBox20).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.MgaTextBox20).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox20).UseOsThemes = (DefaultableBoolean) 2;
    this.Label44.AutoSize = true;
    this.Label44.BackColor = Color.Transparent;
    this.Label44.Location = new Point(311, 85);
    this.Label44.Name = "Label44";
    this.Label44.Size = new Size(117, 13);
    this.Label44.TabIndex = 70;
    this.Label44.Text = "Independent Adjuster:";
    appearance45.BackColor = Color.White;
    appearance45.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance45.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox19).Appearance = (AppearanceBase) appearance45;
    ((TextEditorControlBase) this.MgaTextBox19).BackColor = Color.White;
    ((Control) this.MgaTextBox19).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.DefFirm", true));
    ((Control) this.MgaTextBox19).Location = new Point(434, 106);
    ((TextEditorControlBase) this.MgaTextBox19).MaxLength = 100;
    this.MgaTextBox19.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox19).Name = "MgaTextBox19";
    ((Control) this.MgaTextBox19).Size = new Size(175, 20);
    ((Control) this.MgaTextBox19).TabIndex = 15;
    ((UltraControlBase) this.MgaTextBox19).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox19).UseOsThemes = (DefaultableBoolean) 2;
    this.Label43.AutoSize = true;
    this.Label43.BackColor = Color.Transparent;
    this.Label43.Location = new Point(311, 110);
    this.Label43.Name = "Label43";
    this.Label43.Size = new Size(74, 13);
    this.Label43.TabIndex = 68;
    this.Label43.Text = "Defense Firm:";
    appearance46.BackColor = Color.White;
    appearance46.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance46.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox18).Appearance = (AppearanceBase) appearance46;
    ((TextEditorControlBase) this.MgaTextBox18).BackColor = Color.White;
    ((Control) this.MgaTextBox18).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.IndepAdjuster", true));
    ((Control) this.MgaTextBox18).Location = new Point(434, 81);
    ((TextEditorControlBase) this.MgaTextBox18).MaxLength = 50;
    this.MgaTextBox18.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox18).Name = "MgaTextBox18";
    ((Control) this.MgaTextBox18).Size = new Size(175, 20);
    ((Control) this.MgaTextBox18).TabIndex = 14;
    ((UltraControlBase) this.MgaTextBox18).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox18).UseOsThemes = (DefaultableBoolean) 2;
    this.Label42.AutoSize = true;
    this.Label42.BackColor = Color.Transparent;
    this.Label42.Location = new Point(311, 60);
    this.Label42.Name = "Label42";
    this.Label42.Size = new Size(100, 13);
    this.Label42.TabIndex = 66;
    this.Label42.Text = "Adjuster Category:";
    appearance47.BackColor = Color.White;
    appearance47.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance47.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox17).Appearance = (AppearanceBase) appearance47;
    ((TextEditorControlBase) this.MgaTextBox17).BackColor = Color.White;
    ((Control) this.MgaTextBox17).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.AdjusterCategory", true));
    ((Control) this.MgaTextBox17).Location = new Point(434, 56);
    ((TextEditorControlBase) this.MgaTextBox17).MaxLength = 50;
    this.MgaTextBox17.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox17).Name = "MgaTextBox17";
    ((Control) this.MgaTextBox17).Size = new Size(175, 20);
    ((Control) this.MgaTextBox17).TabIndex = 13;
    ((UltraControlBase) this.MgaTextBox17).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox17).UseOsThemes = (DefaultableBoolean) 2;
    this.Label41.AutoSize = true;
    this.Label41.BackColor = Color.Transparent;
    this.Label41.Location = new Point(311, 35);
    this.Label41.Name = "Label41";
    this.Label41.Size = new Size(75, 13);
    this.Label41.TabIndex = 64 /*0x40*/;
    this.Label41.Text = "Adjuster Title:";
    appearance48.BackColor = Color.White;
    appearance48.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance48.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox16).Appearance = (AppearanceBase) appearance48;
    ((TextEditorControlBase) this.MgaTextBox16).BackColor = Color.White;
    ((Control) this.MgaTextBox16).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.AdjusterTitle", true));
    ((Control) this.MgaTextBox16).Location = new Point(434, 31 /*0x1F*/);
    ((TextEditorControlBase) this.MgaTextBox16).MaxLength = 30;
    this.MgaTextBox16.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox16).Name = "MgaTextBox16";
    ((Control) this.MgaTextBox16).Size = new Size(175, 20);
    ((Control) this.MgaTextBox16).TabIndex = 12;
    ((UltraControlBase) this.MgaTextBox16).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox16).UseOsThemes = (DefaultableBoolean) 2;
    this.Label40.AutoSize = true;
    this.Label40.BackColor = Color.Transparent;
    this.Label40.Location = new Point(311, 10);
    this.Label40.Name = "Label40";
    this.Label40.Size = new Size(82, 13);
    this.Label40.TabIndex = 62;
    this.Label40.Text = "Adjuster Name:";
    appearance49.BackColor = Color.White;
    appearance49.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance49.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox15).Appearance = (AppearanceBase) appearance49;
    ((TextEditorControlBase) this.MgaTextBox15).BackColor = Color.White;
    ((Control) this.MgaTextBox15).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.AdjusterName", true));
    ((Control) this.MgaTextBox15).Location = new Point(434, 6);
    ((TextEditorControlBase) this.MgaTextBox15).MaxLength = 50;
    this.MgaTextBox15.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox15).Name = "MgaTextBox15";
    ((Control) this.MgaTextBox15).Size = new Size(175, 20);
    ((Control) this.MgaTextBox15).TabIndex = 11;
    ((UltraControlBase) this.MgaTextBox15).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox15).UseOsThemes = (DefaultableBoolean) 2;
    this.Label39.AutoSize = true;
    this.Label39.BackColor = Color.Transparent;
    this.Label39.Location = new Point(9, 235);
    this.Label39.Name = "Label39";
    this.Label39.Size = new Size(93, 13);
    this.Label39.TabIndex = 60;
    this.Label39.Text = "Report to Carrier:";
    appearance50.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.MgaDateTimePicker7).Appearance = (AppearanceBase) appearance50;
    appearance51.AlphaLevel = (short) 14;
    appearance51.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance51.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance51.BackColorAlpha = (Alpha) 2;
    appearance51.BackGradientAlignment = (GradientAlignment) 4;
    appearance51.BackGradientStyle = (GradientStyle) 5;
    appearance51.BorderAlpha = (Alpha) 1;
    appearance51.BorderColor = Color.FromArgb(78, 122, 171);
    appearance51.ForeColor = Color.FromArgb(49, 85, 153);
    appearance51.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker7).ButtonAppearance = (AppearanceBase) appearance51;
    ((Control) this.MgaDateTimePicker7).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.ReportToCarrier", true));
    ((UltraDateTimeEditor) this.MgaDateTimePicker7).DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.MgaDateTimePicker7).Location = new Point(103, 231);
    this.MgaDateTimePicker7.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaDateTimePicker7).Name = "MgaDateTimePicker7";
    ((Control) this.MgaDateTimePicker7).Size = new Size(86, 20);
    ((Control) this.MgaDateTimePicker7).TabIndex = 9;
    ((UltraControlBase) this.MgaDateTimePicker7).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaDateTimePicker7).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker7).Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    this.Label38.AutoSize = true;
    this.Label38.BackColor = Color.Transparent;
    this.Label38.Location = new Point(9, 210);
    this.Label38.Name = "Label38";
    this.Label38.Size = new Size(68, 13);
    this.Label38.TabIndex = 58;
    this.Label38.Text = "First Report:";
    appearance52.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.MgaDateTimePicker6).Appearance = (AppearanceBase) appearance52;
    appearance53.AlphaLevel = (short) 14;
    appearance53.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance53.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance53.BackColorAlpha = (Alpha) 2;
    appearance53.BackGradientAlignment = (GradientAlignment) 4;
    appearance53.BackGradientStyle = (GradientStyle) 5;
    appearance53.BorderAlpha = (Alpha) 1;
    appearance53.BorderColor = Color.FromArgb(78, 122, 171);
    appearance53.ForeColor = Color.FromArgb(49, 85, 153);
    appearance53.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker6).ButtonAppearance = (AppearanceBase) appearance53;
    ((Control) this.MgaDateTimePicker6).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.FirstReport", true));
    ((UltraDateTimeEditor) this.MgaDateTimePicker6).DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.MgaDateTimePicker6).Location = new Point(103, 206);
    this.MgaDateTimePicker6.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaDateTimePicker6).Name = "MgaDateTimePicker6";
    ((Control) this.MgaDateTimePicker6).Size = new Size(86, 20);
    ((Control) this.MgaDateTimePicker6).TabIndex = 8;
    ((UltraControlBase) this.MgaDateTimePicker6).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaDateTimePicker6).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker6).Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    this.Label37.AutoSize = true;
    this.Label37.BackColor = Color.Transparent;
    this.Label37.Location = new Point(9, 185);
    this.Label37.Name = "Label37";
    this.Label37.Size = new Size(59, 13);
    this.Label37.TabIndex = 56;
    this.Label37.Text = "First Insp :";
    appearance54.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.MgaDateTimePicker5).Appearance = (AppearanceBase) appearance54;
    appearance55.AlphaLevel = (short) 14;
    appearance55.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance55.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance55.BackColorAlpha = (Alpha) 2;
    appearance55.BackGradientAlignment = (GradientAlignment) 4;
    appearance55.BackGradientStyle = (GradientStyle) 5;
    appearance55.BorderAlpha = (Alpha) 1;
    appearance55.BorderColor = Color.FromArgb(78, 122, 171);
    appearance55.ForeColor = Color.FromArgb(49, 85, 153);
    appearance55.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker5).ButtonAppearance = (AppearanceBase) appearance55;
    ((Control) this.MgaDateTimePicker5).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.FirstInsp", true));
    ((UltraDateTimeEditor) this.MgaDateTimePicker5).DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.MgaDateTimePicker5).Location = new Point(103, 181);
    this.MgaDateTimePicker5.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaDateTimePicker5).Name = "MgaDateTimePicker5";
    ((Control) this.MgaDateTimePicker5).Size = new Size(86, 20);
    ((Control) this.MgaDateTimePicker5).TabIndex = 7;
    ((UltraControlBase) this.MgaDateTimePicker5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaDateTimePicker5).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker5).Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    this.Label36.AutoSize = true;
    this.Label36.BackColor = Color.Transparent;
    this.Label36.Location = new Point(9, 160 /*0xA0*/);
    this.Label36.Name = "Label36";
    this.Label36.Size = new Size(78, 13);
    this.Label36.TabIndex = 54;
    this.Label36.Text = "Initial Contact:";
    this.Label35.AutoSize = true;
    this.Label35.BackColor = Color.Transparent;
    this.Label35.Location = new Point(9, 135);
    this.Label35.Name = "Label35";
    this.Label35.Size = new Size(88, 13);
    this.Label35.TabIndex = 53;
    this.Label35.Text = "Date ReOpened:";
    appearance56.BackColor = Color.White;
    appearance56.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance56.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox14).Appearance = (AppearanceBase) appearance56;
    ((TextEditorControlBase) this.MgaTextBox14).BackColor = Color.White;
    ((Control) this.MgaTextBox14).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.InitialContact", true));
    ((Control) this.MgaTextBox14).Location = new Point(103, 156);
    ((TextEditorControlBase) this.MgaTextBox14).MaxLength = 50;
    this.MgaTextBox14.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox14).Name = "MgaTextBox14";
    ((Control) this.MgaTextBox14).Size = new Size(193, 20);
    ((Control) this.MgaTextBox14).TabIndex = 6;
    ((UltraControlBase) this.MgaTextBox14).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox14).UseOsThemes = (DefaultableBoolean) 2;
    appearance57.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.MgaDateTimePicker4).Appearance = (AppearanceBase) appearance57;
    appearance58.AlphaLevel = (short) 14;
    appearance58.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance58.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance58.BackColorAlpha = (Alpha) 2;
    appearance58.BackGradientAlignment = (GradientAlignment) 4;
    appearance58.BackGradientStyle = (GradientStyle) 5;
    appearance58.BorderAlpha = (Alpha) 1;
    appearance58.BorderColor = Color.FromArgb(78, 122, 171);
    appearance58.ForeColor = Color.FromArgb(49, 85, 153);
    appearance58.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker4).ButtonAppearance = (AppearanceBase) appearance58;
    ((Control) this.MgaDateTimePicker4).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.DateReopened", true));
    ((UltraDateTimeEditor) this.MgaDateTimePicker4).DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.MgaDateTimePicker4).Location = new Point(103, 131);
    this.MgaDateTimePicker4.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaDateTimePicker4).Name = "MgaDateTimePicker4";
    ((Control) this.MgaDateTimePicker4).Size = new Size(86, 20);
    ((Control) this.MgaDateTimePicker4).TabIndex = 5;
    ((UltraControlBase) this.MgaDateTimePicker4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaDateTimePicker4).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker4).Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    this.Label34.AutoSize = true;
    this.Label34.BackColor = Color.Transparent;
    this.Label34.Location = new Point(9, 110);
    this.Label34.Name = "Label34";
    this.Label34.Size = new Size(64 /*0x40*/, 13);
    this.Label34.TabIndex = 39;
    this.Label34.Text = "NCCI Code:";
    appearance59.BackColor = Color.White;
    appearance59.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance59.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox13).Appearance = (AppearanceBase) appearance59;
    ((TextEditorControlBase) this.MgaTextBox13).BackColor = Color.White;
    ((Control) this.MgaTextBox13).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.NCCICode", true));
    ((Control) this.MgaTextBox13).Location = new Point(103, 106);
    ((TextEditorControlBase) this.MgaTextBox13).MaxLength = 50;
    this.MgaTextBox13.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox13).Name = "MgaTextBox13";
    ((Control) this.MgaTextBox13).Size = new Size(193, 20);
    ((Control) this.MgaTextBox13).TabIndex = 4;
    ((UltraControlBase) this.MgaTextBox13).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox13).UseOsThemes = (DefaultableBoolean) 2;
    this.Label33.AutoSize = true;
    this.Label33.BackColor = Color.Transparent;
    this.Label33.Location = new Point(9, 85);
    this.Label33.Name = "Label33";
    this.Label33.Size = new Size(47, 13);
    this.Label33.TabIndex = 37;
    this.Label33.Text = "Fatality:";
    appearance60.BackColor = Color.White;
    appearance60.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance60.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox12).Appearance = (AppearanceBase) appearance60;
    ((TextEditorControlBase) this.MgaTextBox12).BackColor = Color.White;
    ((Control) this.MgaTextBox12).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.Fatality", true));
    ((Control) this.MgaTextBox12).Location = new Point(103, 81);
    ((TextEditorControlBase) this.MgaTextBox12).MaxLength = 50;
    this.MgaTextBox12.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox12).Name = "MgaTextBox12";
    ((Control) this.MgaTextBox12).Size = new Size(193, 20);
    ((Control) this.MgaTextBox12).TabIndex = 3;
    ((UltraControlBase) this.MgaTextBox12).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox12).UseOsThemes = (DefaultableBoolean) 2;
    this.Label32.AutoSize = true;
    this.Label32.BackColor = Color.Transparent;
    this.Label32.Location = new Point(9, 60);
    this.Label32.Name = "Label32";
    this.Label32.Size = new Size(72, 13);
    this.Label32.TabIndex = 35;
    this.Label32.Text = "Ist 3rd Party:";
    appearance61.BackColor = Color.White;
    appearance61.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance61.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox11).Appearance = (AppearanceBase) appearance61;
    ((TextEditorControlBase) this.MgaTextBox11).BackColor = Color.White;
    ((Control) this.MgaTextBox11).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.FirstThirdParty", true));
    ((Control) this.MgaTextBox11).Location = new Point(103, 56);
    ((TextEditorControlBase) this.MgaTextBox11).MaxLength = 50;
    this.MgaTextBox11.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox11).Name = "MgaTextBox11";
    ((Control) this.MgaTextBox11).Size = new Size(193, 20);
    ((Control) this.MgaTextBox11).TabIndex = 2;
    ((UltraControlBase) this.MgaTextBox11).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox11).UseOsThemes = (DefaultableBoolean) 2;
    this.Label31.AutoSize = true;
    this.Label31.BackColor = Color.Transparent;
    this.Label31.Location = new Point(9, 35);
    this.Label31.Name = "Label31";
    this.Label31.Size = new Size(84, 13);
    this.Label31.TabIndex = 33;
    this.Label31.Text = "Subro Potential:";
    appearance62.BackColor = Color.White;
    appearance62.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance62.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox10).Appearance = (AppearanceBase) appearance62;
    ((TextEditorControlBase) this.MgaTextBox10).BackColor = Color.White;
    ((Control) this.MgaTextBox10).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.SubroPotential", true));
    ((Control) this.MgaTextBox10).Location = new Point(103, 31 /*0x1F*/);
    ((TextEditorControlBase) this.MgaTextBox10).MaxLength = 50;
    this.MgaTextBox10.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox10).Name = "MgaTextBox10";
    ((Control) this.MgaTextBox10).Size = new Size(193, 20);
    ((Control) this.MgaTextBox10).TabIndex = 1;
    ((UltraControlBase) this.MgaTextBox10).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox10).UseOsThemes = (DefaultableBoolean) 2;
    this.Label30.AutoSize = true;
    this.Label30.BackColor = Color.Transparent;
    this.Label30.Location = new Point(9, 10);
    this.Label30.Name = "Label30";
    this.Label30.Size = new Size(30, 13);
    this.Label30.TabIndex = 31 /*0x1F*/;
    this.Label30.Text = "Lien:";
    appearance63.BackColor = Color.White;
    appearance63.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance63.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox9).Appearance = (AppearanceBase) appearance63;
    ((TextEditorControlBase) this.MgaTextBox9).BackColor = Color.White;
    ((Control) this.MgaTextBox9).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimInformation.Lien", true));
    ((Control) this.MgaTextBox9).Location = new Point(103, 6);
    ((TextEditorControlBase) this.MgaTextBox9).MaxLength = 50;
    this.MgaTextBox9.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox9).Name = "MgaTextBox9";
    ((Control) this.MgaTextBox9).Size = new Size(193, 20);
    ((Control) this.MgaTextBox9).TabIndex = 0;
    ((UltraControlBase) this.MgaTextBox9).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox9).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.numContingentBIPaid);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.numBusIntPaid);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblContingentBIPaid);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblBusIntPaid);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.numContingentBIReserve);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.numBusIntReserve);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblContingentBIReserve);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblBusIntReserve);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblTPAExpPaid);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.numTPAExpPTD);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblDateCreated);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.dtDateCreated);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.cboState);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblLatitude);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtLatitude);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblLongitude);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtLongitude);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblLossZip);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtLossZip);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblLossState);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblLossCity);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtLossCity);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblLossStreet);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.txtLossStreet);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblExpenseReserved);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.numExpenseReserved);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblExpensePaid);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.numExpensePaid);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblGrossLoss);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.numGrossLoss);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblMTDTPAExpensesPaid);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.numMTDTPAExpPaid);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label67);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor25);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label61);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor23);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label60);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor22);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label59);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor21);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label58);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor20);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label57);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor19);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor18);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label56);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor17);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label55);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label54);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.dtValueDate);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label51);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label50);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label49);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor16);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor15);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaTextBox23);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label23);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaDateTimePicker2);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor11);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label20);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor12);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label21);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor13);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label22);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor10);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label18);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor9);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label17);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor8);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label16);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor7);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor6);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor5);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor4);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor3);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor2);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.MgaNumericEditor1);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label15);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label14);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label13);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label12);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label11);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label10);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(879, 394);
    appearance64.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numContingentBIPaid).Appearance = (AppearanceBase) appearance64;
    ((Control) this.numContingentBIPaid).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.ContingentBIPaid", true));
    ((Control) this.numContingentBIPaid).Location = new Point(182, 316);
    this.numContingentBIPaid.MGAStyle = (MGAStyles) 2;
    ((Control) this.numContingentBIPaid).Name = "numContingentBIPaid";
    ((UltraNumericEditor) this.numContingentBIPaid).NumericType = (NumericType) 1;
    ((Control) this.numContingentBIPaid).Size = new Size(94, 20);
    ((Control) this.numContingentBIPaid).TabIndex = 12;
    ((UltraControlBase) this.numContingentBIPaid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numContingentBIPaid).UseOsThemes = (DefaultableBoolean) 2;
    appearance65.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numBusIntPaid).Appearance = (AppearanceBase) appearance65;
    ((Control) this.numBusIntPaid).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.BusIntPaid", true));
    ((Control) this.numBusIntPaid).Location = new Point(181, 290);
    this.numBusIntPaid.MGAStyle = (MGAStyles) 2;
    ((Control) this.numBusIntPaid).Name = "numBusIntPaid";
    ((UltraNumericEditor) this.numBusIntPaid).NumericType = (NumericType) 1;
    ((Control) this.numBusIntPaid).Size = new Size(94, 20);
    ((Control) this.numBusIntPaid).TabIndex = 11;
    ((UltraControlBase) this.numBusIntPaid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numBusIntPaid).UseOsThemes = (DefaultableBoolean) 2;
    this.lblContingentBIPaid.BackColor = Color.Transparent;
    this.lblContingentBIPaid.Location = new Point(25, 315);
    this.lblContingentBIPaid.Name = "lblContingentBIPaid";
    this.lblContingentBIPaid.Size = new Size(110, 22);
    this.lblContingentBIPaid.TabIndex = 105;
    this.lblContingentBIPaid.Text = "Contingent BI – Paid:";
    this.lblContingentBIPaid.TextAlign = ContentAlignment.MiddleLeft;
    this.lblBusIntPaid.BackColor = Color.Transparent;
    this.lblBusIntPaid.Location = new Point(25, 289);
    this.lblBusIntPaid.Name = "lblBusIntPaid";
    this.lblBusIntPaid.Size = new Size(110, 22);
    this.lblBusIntPaid.TabIndex = 104;
    this.lblBusIntPaid.Text = "Bus Int – Paid:";
    this.lblBusIntPaid.TextAlign = ContentAlignment.MiddleLeft;
    appearance66.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numContingentBIReserve).Appearance = (AppearanceBase) appearance66;
    ((Control) this.numContingentBIReserve).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.ContingentBIReserve", true));
    ((Control) this.numContingentBIReserve).Location = new Point(183, 82);
    this.numContingentBIReserve.MGAStyle = (MGAStyles) 2;
    ((Control) this.numContingentBIReserve).Name = "numContingentBIReserve";
    ((UltraNumericEditor) this.numContingentBIReserve).NumericType = (NumericType) 1;
    ((Control) this.numContingentBIReserve).Size = new Size(94, 20);
    ((Control) this.numContingentBIReserve).TabIndex = 3;
    ((UltraControlBase) this.numContingentBIReserve).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numContingentBIReserve).UseOsThemes = (DefaultableBoolean) 2;
    appearance67.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numBusIntReserve).Appearance = (AppearanceBase) appearance67;
    ((Control) this.numBusIntReserve).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.BusIntReserve", true));
    ((Control) this.numBusIntReserve).Location = new Point(182, 56);
    this.numBusIntReserve.MGAStyle = (MGAStyles) 2;
    ((Control) this.numBusIntReserve).Name = "numBusIntReserve";
    ((UltraNumericEditor) this.numBusIntReserve).NumericType = (NumericType) 1;
    ((Control) this.numBusIntReserve).Size = new Size(94, 20);
    ((Control) this.numBusIntReserve).TabIndex = 2;
    ((UltraControlBase) this.numBusIntReserve).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numBusIntReserve).UseOsThemes = (DefaultableBoolean) 2;
    this.lblContingentBIReserve.BackColor = Color.Transparent;
    this.lblContingentBIReserve.Location = new Point(25, 81);
    this.lblContingentBIReserve.Name = "lblContingentBIReserve";
    this.lblContingentBIReserve.Size = new Size(135, 22);
    this.lblContingentBIReserve.TabIndex = 101;
    this.lblContingentBIReserve.Text = "Contingent BI – Reserve:";
    this.lblContingentBIReserve.TextAlign = ContentAlignment.MiddleLeft;
    this.lblBusIntReserve.BackColor = Color.Transparent;
    this.lblBusIntReserve.Location = new Point(25, 54);
    this.lblBusIntReserve.Name = "lblBusIntReserve";
    this.lblBusIntReserve.Size = new Size(113, 22);
    this.lblBusIntReserve.TabIndex = 100;
    this.lblBusIntReserve.Text = "Bus Int – Reserves :";
    this.lblBusIntReserve.TextAlign = ContentAlignment.MiddleLeft;
    this.lblTPAExpPaid.BackColor = Color.Transparent;
    this.lblTPAExpPaid.Location = new Point(530, 29);
    this.lblTPAExpPaid.Name = "lblTPAExpPaid";
    this.lblTPAExpPaid.Size = new Size(100, 23);
    this.lblTPAExpPaid.TabIndex = 99;
    this.lblTPAExpPaid.Text = "TPA Exp. Pd:";
    this.lblTPAExpPaid.TextAlign = ContentAlignment.MiddleLeft;
    appearance68.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numTPAExpPTD).Appearance = (AppearanceBase) appearance68;
    ((Control) this.numTPAExpPTD).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.TPAExpPTD", true));
    ((Control) this.numTPAExpPTD).Location = new Point(636, 30);
    this.numTPAExpPTD.MGAStyle = (MGAStyles) 2;
    ((Control) this.numTPAExpPTD).Name = "numTPAExpPTD";
    ((UltraNumericEditor) this.numTPAExpPTD).NumericType = (NumericType) 1;
    ((Control) this.numTPAExpPTD).Size = new Size(87, 20);
    ((Control) this.numTPAExpPTD).TabIndex = 31 /*0x1F*/;
    ((UltraControlBase) this.numTPAExpPTD).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numTPAExpPTD).UseOsThemes = (DefaultableBoolean) 2;
    this.lblDateCreated.BackColor = Color.Transparent;
    this.lblDateCreated.Location = new Point(308, 367);
    this.lblDateCreated.Name = "lblDateCreated";
    this.lblDateCreated.Size = new Size(85, 23);
    this.lblDateCreated.TabIndex = 97;
    this.lblDateCreated.Text = "Date Created:";
    this.lblDateCreated.TextAlign = ContentAlignment.MiddleLeft;
    appearance69.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtDateCreated).Appearance = (AppearanceBase) appearance69;
    appearance70.AlphaLevel = (short) 14;
    appearance70.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance70.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance70.BackColorAlpha = (Alpha) 2;
    appearance70.BackGradientAlignment = (GradientAlignment) 4;
    appearance70.BackGradientStyle = (GradientStyle) 5;
    appearance70.BorderAlpha = (Alpha) 1;
    appearance70.BorderColor = Color.FromArgb(78, 122, 171);
    appearance70.ForeColor = Color.FromArgb(49, 85, 153);
    appearance70.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtDateCreated).ButtonAppearance = (AppearanceBase) appearance70;
    ((Control) this.dtDateCreated).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.DateCreated", true));
    ((UltraDateTimeEditor) this.dtDateCreated).DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.dtDateCreated).Location = new Point(413, 368);
    this.dtDateCreated.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtDateCreated).Name = "dtDateCreated";
    ((Control) this.dtDateCreated).Size = new Size(84, 20);
    ((Control) this.dtDateCreated).TabIndex = 29;
    ((UltraControlBase) this.dtDateCreated).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtDateCreated).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtDateCreated).Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((UltraCombo) this.cboState).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboState).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.LossState", true));
    ((UltraGridBase) this.cboState).DataMember = "lstStates";
    ((UltraGridBase) this.cboState).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    ((UltraCombo) this.cboState).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboState).DropDownWidth = 150;
    ((Control) this.cboState).Location = new Point(637, 212);
    this.cboState.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(106, 21);
    ((Control) this.cboState).TabIndex = 38;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    this.lblLatitude.AutoSize = true;
    this.lblLatitude.BackColor = Color.Transparent;
    this.lblLatitude.Location = new Point(530, 294);
    this.lblLatitude.Name = "lblLatitude";
    this.lblLatitude.Size = new Size(46, 13);
    this.lblLatitude.TabIndex = 95;
    this.lblLatitude.Text = "Latitude";
    appearance71.BackColor = Color.White;
    appearance71.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance71.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLatitude).Appearance = (AppearanceBase) appearance71;
    ((TextEditorControlBase) this.txtLatitude).BackColor = Color.White;
    ((Control) this.txtLatitude).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Latitude", true));
    ((Control) this.txtLatitude).Location = new Point(636, 290);
    ((TextEditorControlBase) this.txtLatitude).MaxLength = 50;
    this.txtLatitude.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtLatitude).Name = "txtLatitude";
    ((Control) this.txtLatitude).Size = new Size(107, 20);
    ((Control) this.txtLatitude).TabIndex = 41;
    ((UltraControlBase) this.txtLatitude).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLatitude).UseOsThemes = (DefaultableBoolean) 2;
    this.lblLongitude.AutoSize = true;
    this.lblLongitude.BackColor = Color.Transparent;
    this.lblLongitude.Location = new Point(530, 268);
    this.lblLongitude.Name = "lblLongitude";
    this.lblLongitude.Size = new Size(58, 13);
    this.lblLongitude.TabIndex = 93;
    this.lblLongitude.Text = "Longitude:";
    appearance72.BackColor = Color.White;
    appearance72.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance72.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLongitude).Appearance = (AppearanceBase) appearance72;
    ((TextEditorControlBase) this.txtLongitude).BackColor = Color.White;
    ((Control) this.txtLongitude).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Longitude", true));
    ((Control) this.txtLongitude).Location = new Point(636, 264);
    ((TextEditorControlBase) this.txtLongitude).MaxLength = 50;
    this.txtLongitude.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtLongitude).Name = "txtLongitude";
    ((Control) this.txtLongitude).Size = new Size(107, 20);
    ((Control) this.txtLongitude).TabIndex = 40;
    ((UltraControlBase) this.txtLongitude).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLongitude).UseOsThemes = (DefaultableBoolean) 2;
    this.lblLossZip.AutoSize = true;
    this.lblLossZip.BackColor = Color.Transparent;
    this.lblLossZip.Location = new Point(530, 242);
    this.lblLossZip.Name = "lblLossZip";
    this.lblLossZip.Size = new Size(49, 13);
    this.lblLossZip.TabIndex = 91;
    this.lblLossZip.Text = "Loss Zip:";
    appearance73.BackColor = Color.White;
    appearance73.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance73.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLossZip).Appearance = (AppearanceBase) appearance73;
    ((TextEditorControlBase) this.txtLossZip).BackColor = Color.White;
    ((Control) this.txtLossZip).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.LossZip", true));
    ((Control) this.txtLossZip).Location = new Point(636, 238);
    ((TextEditorControlBase) this.txtLossZip).MaxLength = 50;
    this.txtLossZip.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtLossZip).Name = "txtLossZip";
    ((Control) this.txtLossZip).Size = new Size(107, 20);
    ((Control) this.txtLossZip).TabIndex = 39;
    ((UltraControlBase) this.txtLossZip).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLossZip).UseOsThemes = (DefaultableBoolean) 2;
    this.lblLossState.AutoSize = true;
    this.lblLossState.BackColor = Color.Transparent;
    this.lblLossState.Location = new Point(530, 216);
    this.lblLossState.Name = "lblLossState";
    this.lblLossState.Size = new Size(61, 13);
    this.lblLossState.TabIndex = 89;
    this.lblLossState.Text = "Loss State:";
    this.lblLossCity.AutoSize = true;
    this.lblLossCity.BackColor = Color.Transparent;
    this.lblLossCity.Location = new Point(531, 190);
    this.lblLossCity.Name = "lblLossCity";
    this.lblLossCity.Size = new Size(54, 13);
    this.lblLossCity.TabIndex = 87;
    this.lblLossCity.Text = "Loss City:";
    appearance74.BackColor = Color.White;
    appearance74.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance74.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLossCity).Appearance = (AppearanceBase) appearance74;
    ((TextEditorControlBase) this.txtLossCity).BackColor = Color.White;
    ((Control) this.txtLossCity).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.LossCity", true));
    ((Control) this.txtLossCity).Location = new Point(637, 186);
    ((TextEditorControlBase) this.txtLossCity).MaxLength = 50;
    this.txtLossCity.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtLossCity).Name = "txtLossCity";
    ((Control) this.txtLossCity).Size = new Size(107, 20);
    ((Control) this.txtLossCity).TabIndex = 37;
    ((UltraControlBase) this.txtLossCity).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLossCity).UseOsThemes = (DefaultableBoolean) 2;
    this.lblLossStreet.AutoSize = true;
    this.lblLossStreet.BackColor = Color.Transparent;
    this.lblLossStreet.Location = new Point(531, 164);
    this.lblLossStreet.Name = "lblLossStreet";
    this.lblLossStreet.Size = new Size(65, 13);
    this.lblLossStreet.TabIndex = 85;
    this.lblLossStreet.Text = "Loss Street:";
    appearance75.BackColor = Color.White;
    appearance75.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance75.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLossStreet).Appearance = (AppearanceBase) appearance75;
    ((TextEditorControlBase) this.txtLossStreet).BackColor = Color.White;
    ((Control) this.txtLossStreet).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.LossStreet", true));
    ((Control) this.txtLossStreet).Location = new Point(636, 160 /*0xA0*/);
    ((TextEditorControlBase) this.txtLossStreet).MaxLength = 50;
    this.txtLossStreet.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtLossStreet).Name = "txtLossStreet";
    ((Control) this.txtLossStreet).Size = new Size(107, 20);
    ((Control) this.txtLossStreet).TabIndex = 36;
    ((UltraControlBase) this.txtLossStreet).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLossStreet).UseOsThemes = (DefaultableBoolean) 2;
    this.lblExpenseReserved.BackColor = Color.Transparent;
    this.lblExpenseReserved.Location = new Point(531, 133);
    this.lblExpenseReserved.Name = "lblExpenseReserved";
    this.lblExpenseReserved.Size = new Size(85, 23);
    this.lblExpenseReserved.TabIndex = 83;
    this.lblExpenseReserved.Text = "Exp Reserved";
    this.lblExpenseReserved.TextAlign = ContentAlignment.MiddleLeft;
    appearance76.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numExpenseReserved).Appearance = (AppearanceBase) appearance76;
    ((Control) this.numExpenseReserved).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.ExpenseReserved", true));
    ((Control) this.numExpenseReserved).Location = new Point(637, 134);
    this.numExpenseReserved.MGAStyle = (MGAStyles) 2;
    ((Control) this.numExpenseReserved).Name = "numExpenseReserved";
    ((UltraNumericEditor) this.numExpenseReserved).NumericType = (NumericType) 1;
    ((Control) this.numExpenseReserved).Size = new Size(87, 20);
    ((Control) this.numExpenseReserved).TabIndex = 35;
    ((UltraControlBase) this.numExpenseReserved).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numExpenseReserved).UseOsThemes = (DefaultableBoolean) 2;
    this.lblExpensePaid.BackColor = Color.Transparent;
    this.lblExpensePaid.Location = new Point(530, 107);
    this.lblExpensePaid.Name = "lblExpensePaid";
    this.lblExpensePaid.Size = new Size(75, 23);
    this.lblExpensePaid.TabIndex = 81;
    this.lblExpensePaid.Text = "Expense Paid:";
    this.lblExpensePaid.TextAlign = ContentAlignment.MiddleLeft;
    appearance77.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numExpensePaid).Appearance = (AppearanceBase) appearance77;
    ((Control) this.numExpensePaid).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.ExpensePaid", true));
    ((Control) this.numExpensePaid).Location = new Point(636, 108);
    this.numExpensePaid.MGAStyle = (MGAStyles) 2;
    ((Control) this.numExpensePaid).Name = "numExpensePaid";
    ((UltraNumericEditor) this.numExpensePaid).NumericType = (NumericType) 1;
    ((Control) this.numExpensePaid).Size = new Size(87, 20);
    ((Control) this.numExpensePaid).TabIndex = 34;
    ((UltraControlBase) this.numExpensePaid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numExpensePaid).UseOsThemes = (DefaultableBoolean) 2;
    this.lblGrossLoss.BackColor = Color.Transparent;
    this.lblGrossLoss.Location = new Point(530, 81);
    this.lblGrossLoss.Name = "lblGrossLoss";
    this.lblGrossLoss.Size = new Size(75, 23);
    this.lblGrossLoss.TabIndex = 79;
    this.lblGrossLoss.Text = "Gross Loss:";
    this.lblGrossLoss.TextAlign = ContentAlignment.MiddleLeft;
    appearance78.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numGrossLoss).Appearance = (AppearanceBase) appearance78;
    ((Control) this.numGrossLoss).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.GrossLoss", true));
    ((Control) this.numGrossLoss).Location = new Point(636, 82);
    this.numGrossLoss.MGAStyle = (MGAStyles) 2;
    ((Control) this.numGrossLoss).Name = "numGrossLoss";
    ((UltraNumericEditor) this.numGrossLoss).NumericType = (NumericType) 1;
    ((Control) this.numGrossLoss).Size = new Size(87, 20);
    ((Control) this.numGrossLoss).TabIndex = 33;
    ((UltraControlBase) this.numGrossLoss).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numGrossLoss).UseOsThemes = (DefaultableBoolean) 2;
    this.lblMTDTPAExpensesPaid.BackColor = Color.Transparent;
    this.lblMTDTPAExpensesPaid.Location = new Point(530, 3);
    this.lblMTDTPAExpensesPaid.Name = "lblMTDTPAExpensesPaid";
    this.lblMTDTPAExpensesPaid.Size = new Size(100, 23);
    this.lblMTDTPAExpensesPaid.TabIndex = 77;
    this.lblMTDTPAExpensesPaid.Text = "MTD TPA Exp. Pd:";
    this.lblMTDTPAExpensesPaid.TextAlign = ContentAlignment.MiddleLeft;
    appearance79.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numMTDTPAExpPaid).Appearance = (AppearanceBase) appearance79;
    ((Control) this.numMTDTPAExpPaid).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.MTDTPAExpPaid", true));
    ((Control) this.numMTDTPAExpPaid).Location = new Point(636, 4);
    this.numMTDTPAExpPaid.MGAStyle = (MGAStyles) 2;
    ((Control) this.numMTDTPAExpPaid).Name = "numMTDTPAExpPaid";
    ((UltraNumericEditor) this.numMTDTPAExpPaid).NumericType = (NumericType) 1;
    ((Control) this.numMTDTPAExpPaid).Size = new Size(87, 20);
    ((Control) this.numMTDTPAExpPaid).TabIndex = 30;
    ((UltraControlBase) this.numMTDTPAExpPaid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numMTDTPAExpPaid).UseOsThemes = (DefaultableBoolean) 2;
    this.Label67.BackColor = Color.Transparent;
    this.Label67.Location = new Point(530, 55);
    this.Label67.Name = "Label67";
    this.Label67.Size = new Size(86, 23);
    this.Label67.TabIndex = 75;
    this.Label67.Text = "Total Incurred:";
    this.Label67.TextAlign = ContentAlignment.MiddleLeft;
    appearance80.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor25).Appearance = (AppearanceBase) appearance80;
    ((Control) this.MgaNumericEditor25).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.TotalIncurred", true));
    ((Control) this.MgaNumericEditor25).Location = new Point(636, 56);
    this.MgaNumericEditor25.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor25).Name = "MgaNumericEditor25";
    ((UltraNumericEditor) this.MgaNumericEditor25).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor25).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor25).TabIndex = 32 /*0x20*/;
    ((UltraControlBase) this.MgaNumericEditor25).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor25).UseOsThemes = (DefaultableBoolean) 2;
    this.Label61.BackColor = Color.Transparent;
    this.Label61.Location = new Point(308, 341);
    this.Label61.Name = "Label61";
    this.Label61.Size = new Size(69, 23);
    this.Label61.TabIndex = 73;
    this.Label61.Text = "PD Reserve:";
    this.Label61.TextAlign = ContentAlignment.MiddleLeft;
    appearance81.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor23).Appearance = (AppearanceBase) appearance81;
    ((Control) this.MgaNumericEditor23).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.PDReserve", true));
    ((Control) this.MgaNumericEditor23).Location = new Point(413, 342);
    this.MgaNumericEditor23.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor23).Name = "MgaNumericEditor23";
    ((UltraNumericEditor) this.MgaNumericEditor23).Nullable = true;
    ((UltraNumericEditor) this.MgaNumericEditor23).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor23).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor23).TabIndex = 28;
    ((UltraWinEditorMaskedControlBase) this.MgaNumericEditor23).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.MgaNumericEditor23).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor23).UseOsThemes = (DefaultableBoolean) 2;
    this.Label60.BackColor = Color.Transparent;
    this.Label60.Location = new Point(307, 315);
    this.Label60.Name = "Label60";
    this.Label60.Size = new Size(69, 23);
    this.Label60.TabIndex = 71;
    this.Label60.Text = "PD Paid:";
    this.Label60.TextAlign = ContentAlignment.MiddleLeft;
    appearance82.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor22).Appearance = (AppearanceBase) appearance82;
    ((Control) this.MgaNumericEditor22).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.PDPaid", true));
    ((Control) this.MgaNumericEditor22).Location = new Point(413, 316);
    this.MgaNumericEditor22.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor22).Name = "MgaNumericEditor22";
    ((UltraNumericEditor) this.MgaNumericEditor22).Nullable = true;
    ((UltraNumericEditor) this.MgaNumericEditor22).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor22).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor22).TabIndex = 27;
    ((UltraWinEditorMaskedControlBase) this.MgaNumericEditor22).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.MgaNumericEditor22).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor22).UseOsThemes = (DefaultableBoolean) 2;
    this.Label59.BackColor = Color.Transparent;
    this.Label59.Location = new Point(307, 289);
    this.Label59.Name = "Label59";
    this.Label59.Size = new Size(69, 23);
    this.Label59.TabIndex = 69;
    this.Label59.Text = "BI Reserve:";
    this.Label59.TextAlign = ContentAlignment.MiddleLeft;
    appearance83.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor21).Appearance = (AppearanceBase) appearance83;
    ((Control) this.MgaNumericEditor21).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.BIReserve", true));
    ((Control) this.MgaNumericEditor21).Location = new Point(413, 290);
    this.MgaNumericEditor21.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor21).Name = "MgaNumericEditor21";
    ((UltraNumericEditor) this.MgaNumericEditor21).Nullable = true;
    ((UltraNumericEditor) this.MgaNumericEditor21).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor21).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor21).TabIndex = 26;
    ((UltraWinEditorMaskedControlBase) this.MgaNumericEditor21).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.MgaNumericEditor21).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor21).UseOsThemes = (DefaultableBoolean) 2;
    this.Label58.BackColor = Color.Transparent;
    this.Label58.Location = new Point(307, 263);
    this.Label58.Name = "Label58";
    this.Label58.Size = new Size(69, 23);
    this.Label58.TabIndex = 67;
    this.Label58.Text = "BI Paid:";
    this.Label58.TextAlign = ContentAlignment.MiddleLeft;
    appearance84.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor20).Appearance = (AppearanceBase) appearance84;
    ((Control) this.MgaNumericEditor20).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.BIPaid", true));
    ((Control) this.MgaNumericEditor20).Location = new Point(413, 264);
    this.MgaNumericEditor20.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor20).Name = "MgaNumericEditor20";
    ((UltraNumericEditor) this.MgaNumericEditor20).Nullable = true;
    ((UltraNumericEditor) this.MgaNumericEditor20).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor20).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor20).TabIndex = 25;
    ((UltraWinEditorMaskedControlBase) this.MgaNumericEditor20).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.MgaNumericEditor20).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor20).UseOsThemes = (DefaultableBoolean) 2;
    this.Label57.BackColor = Color.Transparent;
    this.Label57.Location = new Point(307, 237);
    this.Label57.Name = "Label57";
    this.Label57.Size = new Size(82, 23);
    this.Label57.TabIndex = 65;
    this.Label57.Text = "TPA Reserve:";
    this.Label57.TextAlign = ContentAlignment.MiddleLeft;
    appearance85.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor19).Appearance = (AppearanceBase) appearance85;
    ((Control) this.MgaNumericEditor19).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.TPAReserve", true));
    ((Control) this.MgaNumericEditor19).Location = new Point(413, 238);
    this.MgaNumericEditor19.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor19).Name = "MgaNumericEditor19";
    ((UltraNumericEditor) this.MgaNumericEditor19).Nullable = true;
    ((UltraNumericEditor) this.MgaNumericEditor19).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor19).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor19).TabIndex = 24;
    ((UltraWinEditorMaskedControlBase) this.MgaNumericEditor19).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.MgaNumericEditor19).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor19).UseOsThemes = (DefaultableBoolean) 2;
    appearance86.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor18).Appearance = (AppearanceBase) appearance86;
    ((Control) this.MgaNumericEditor18).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.RespayTotalPaid", true));
    ((Control) this.MgaNumericEditor18).Location = new Point(413, 212);
    this.MgaNumericEditor18.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor18).Name = "MgaNumericEditor18";
    ((UltraNumericEditor) this.MgaNumericEditor18).Nullable = true;
    ((UltraNumericEditor) this.MgaNumericEditor18).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor18).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor18).TabIndex = 23;
    ((UltraWinEditorMaskedControlBase) this.MgaNumericEditor18).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.MgaNumericEditor18).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor18).UseOsThemes = (DefaultableBoolean) 2;
    this.Label56.BackColor = Color.Transparent;
    this.Label56.Location = new Point(308, 211);
    this.Label56.Name = "Label56";
    this.Label56.Size = new Size(98, 23);
    this.Label56.TabIndex = 63 /*0x3F*/;
    this.Label56.Text = "ResPay Total Paid:";
    this.Label56.TextAlign = ContentAlignment.MiddleLeft;
    appearance87.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor17).Appearance = (AppearanceBase) appearance87;
    ((Control) this.MgaNumericEditor17).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.TotalReserve", true));
    ((Control) this.MgaNumericEditor17).Location = new Point(413, 186);
    this.MgaNumericEditor17.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor17).Name = "MgaNumericEditor17";
    ((UltraNumericEditor) this.MgaNumericEditor17).Nullable = true;
    ((UltraNumericEditor) this.MgaNumericEditor17).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor17).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor17).TabIndex = 22;
    ((UltraWinEditorMaskedControlBase) this.MgaNumericEditor17).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.MgaNumericEditor17).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor17).UseOsThemes = (DefaultableBoolean) 2;
    this.Label55.BackColor = Color.Transparent;
    this.Label55.Location = new Point(308, 185);
    this.Label55.Name = "Label55";
    this.Label55.Size = new Size(85, 23);
    this.Label55.TabIndex = 61;
    this.Label55.Text = "Total Reserve:";
    this.Label55.TextAlign = ContentAlignment.MiddleLeft;
    this.Label54.BackColor = Color.Transparent;
    this.Label54.Location = new Point(308, 159);
    this.Label54.Name = "Label54";
    this.Label54.Size = new Size(85, 23);
    this.Label54.TabIndex = 59;
    this.Label54.Text = "Value Date:";
    this.Label54.TextAlign = ContentAlignment.MiddleLeft;
    appearance88.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtValueDate).Appearance = (AppearanceBase) appearance88;
    appearance89.AlphaLevel = (short) 14;
    appearance89.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance89.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance89.BackColorAlpha = (Alpha) 2;
    appearance89.BackGradientAlignment = (GradientAlignment) 4;
    appearance89.BackGradientStyle = (GradientStyle) 5;
    appearance89.BorderAlpha = (Alpha) 1;
    appearance89.BorderColor = Color.FromArgb(78, 122, 171);
    appearance89.ForeColor = Color.FromArgb(49, 85, 153);
    appearance89.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtValueDate).ButtonAppearance = (AppearanceBase) appearance89;
    ((Control) this.dtValueDate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.ValueDate", true));
    ((UltraDateTimeEditor) this.dtValueDate).DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.dtValueDate).Location = new Point(413, 160 /*0xA0*/);
    this.dtValueDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtValueDate).Name = "dtValueDate";
    ((Control) this.dtValueDate).Size = new Size(84, 20);
    ((Control) this.dtValueDate).TabIndex = 21;
    ((UltraControlBase) this.dtValueDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtValueDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtValueDate).Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    this.Label51.BackColor = Color.Transparent;
    this.Label51.Location = new Point(308, 133);
    this.Label51.Name = "Label51";
    this.Label51.Size = new Size(93, 23);
    this.Label51.TabIndex = 57;
    this.Label51.Text = "Recovery Type:";
    this.Label51.TextAlign = ContentAlignment.MiddleLeft;
    this.Label50.BackColor = Color.Transparent;
    this.Label50.Location = new Point(308, 107);
    this.Label50.Name = "Label50";
    this.Label50.Size = new Size(85, 23);
    this.Label50.TabIndex = 56;
    this.Label50.Text = "Medical Paid:";
    this.Label50.TextAlign = ContentAlignment.MiddleLeft;
    this.Label49.BackColor = Color.Transparent;
    this.Label49.Location = new Point(308, 81);
    this.Label49.Name = "Label49";
    this.Label49.Size = new Size(96 /*0x60*/, 23);
    this.Label49.TabIndex = 55;
    this.Label49.Text = "Medical Reserves:";
    this.Label49.TextAlign = ContentAlignment.MiddleLeft;
    appearance90.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor16).Appearance = (AppearanceBase) appearance90;
    ((Control) this.MgaNumericEditor16).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.MedicalPTD", true));
    ((Control) this.MgaNumericEditor16).Location = new Point(413, 108);
    this.MgaNumericEditor16.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor16).Name = "MgaNumericEditor16";
    ((UltraNumericEditor) this.MgaNumericEditor16).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor16).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor16).TabIndex = 19;
    ((UltraControlBase) this.MgaNumericEditor16).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor16).UseOsThemes = (DefaultableBoolean) 2;
    appearance91.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor15).Appearance = (AppearanceBase) appearance91;
    ((Control) this.MgaNumericEditor15).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.OutMedRes", true));
    ((Control) this.MgaNumericEditor15).Location = new Point(413, 82);
    this.MgaNumericEditor15.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor15).Name = "MgaNumericEditor15";
    ((UltraNumericEditor) this.MgaNumericEditor15).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor15).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor15).TabIndex = 18;
    ((UltraControlBase) this.MgaNumericEditor15).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor15).UseOsThemes = (DefaultableBoolean) 2;
    appearance92.BackColor = Color.White;
    appearance92.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance92.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox23).Appearance = (AppearanceBase) appearance92;
    ((TextEditorControlBase) this.MgaTextBox23).BackColor = Color.White;
    ((Control) this.MgaTextBox23).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.RecType", true));
    ((Control) this.MgaTextBox23).Location = new Point(413, 134);
    ((TextEditorControlBase) this.MgaTextBox23).MaxLength = 100;
    this.MgaTextBox23.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaTextBox23).Name = "MgaTextBox23";
    ((Control) this.MgaTextBox23).Size = new Size(87, 20);
    ((Control) this.MgaTextBox23).TabIndex = 20;
    ((UltraControlBase) this.MgaTextBox23).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox23).UseOsThemes = (DefaultableBoolean) 2;
    this.Label23.BackColor = Color.Transparent;
    this.Label23.Location = new Point(6, 237);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(113, 23);
    this.Label23.TabIndex = 51;
    this.Label23.Text = "Check Issued Date:";
    this.Label23.TextAlign = ContentAlignment.MiddleLeft;
    appearance93.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.MgaDateTimePicker2).Appearance = (AppearanceBase) appearance93;
    appearance94.AlphaLevel = (short) 14;
    appearance94.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance94.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance94.BackColorAlpha = (Alpha) 2;
    appearance94.BackGradientAlignment = (GradientAlignment) 4;
    appearance94.BackGradientStyle = (GradientStyle) 5;
    appearance94.BorderAlpha = (Alpha) 1;
    appearance94.BorderColor = Color.FromArgb(78, 122, 171);
    appearance94.ForeColor = Color.FromArgb(49, 85, 153);
    appearance94.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker2).ButtonAppearance = (AppearanceBase) appearance94;
    ((Control) this.MgaDateTimePicker2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.CheckIssued", true));
    ((UltraDateTimeEditor) this.MgaDateTimePicker2).DateTime = new DateTime(2010, 7, 7, 0, 0, 0, 0);
    ((Control) this.MgaDateTimePicker2).Location = new Point(182, 238);
    this.MgaDateTimePicker2.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaDateTimePicker2).Name = "MgaDateTimePicker2";
    ((Control) this.MgaDateTimePicker2).Size = new Size(94, 20);
    ((Control) this.MgaDateTimePicker2).TabIndex = 9;
    ((UltraControlBase) this.MgaDateTimePicker2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaDateTimePicker2).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.MgaDateTimePicker2).Value = (object) new DateTime(2010, 7, 7, 0, 0, 0, 0);
    appearance95.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor11).Appearance = (AppearanceBase) appearance95;
    ((Control) this.MgaNumericEditor11).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.MTDLegalPaid", true));
    ((Control) this.MgaNumericEditor11).Location = new Point(413, 56);
    this.MgaNumericEditor11.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor11).Name = "MgaNumericEditor11";
    ((UltraNumericEditor) this.MgaNumericEditor11).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor11).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor11).TabIndex = 17;
    ((UltraControlBase) this.MgaNumericEditor11).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor11).UseOsThemes = (DefaultableBoolean) 2;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Location = new Point(311, 55);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(93, 23);
    this.Label20.TabIndex = 48 /*0x30*/;
    this.Label20.Text = "MTD Legal Paid:";
    this.Label20.TextAlign = ContentAlignment.MiddleLeft;
    appearance96.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor12).Appearance = (AppearanceBase) appearance96;
    ((Control) this.MgaNumericEditor12).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.MTDLAEPaid", true));
    ((Control) this.MgaNumericEditor12).Location = new Point(413, 4);
    this.MgaNumericEditor12.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor12).Name = "MgaNumericEditor12";
    ((UltraNumericEditor) this.MgaNumericEditor12).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor12).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor12).TabIndex = 15;
    ((UltraControlBase) this.MgaNumericEditor12).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor12).UseOsThemes = (DefaultableBoolean) 2;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(307, 3);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(85, 23);
    this.Label21.TabIndex = 46;
    this.Label21.Text = "MTD LAE Paid:";
    this.Label21.TextAlign = ContentAlignment.MiddleLeft;
    appearance97.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor13).Appearance = (AppearanceBase) appearance97;
    ((Control) this.MgaNumericEditor13).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.MTDIndemnityPaid", true));
    ((Control) this.MgaNumericEditor13).Location = new Point(181, 342);
    this.MgaNumericEditor13.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor13).Name = "MgaNumericEditor13";
    ((UltraNumericEditor) this.MgaNumericEditor13).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor13).Size = new Size(94, 20);
    ((Control) this.MgaNumericEditor13).TabIndex = 13;
    ((UltraControlBase) this.MgaNumericEditor13).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor13).UseOsThemes = (DefaultableBoolean) 2;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Location = new Point(6, 341);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(113, 23);
    this.Label22.TabIndex = 44;
    this.Label22.Text = "MTD Indemnity Paid:";
    this.Label22.TextAlign = ContentAlignment.MiddleLeft;
    appearance98.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor10).Appearance = (AppearanceBase) appearance98;
    ((Control) this.MgaNumericEditor10).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.LegalPTD", true));
    ((Control) this.MgaNumericEditor10).Location = new Point(413, 30);
    this.MgaNumericEditor10.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor10).Name = "MgaNumericEditor10";
    ((UltraNumericEditor) this.MgaNumericEditor10).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor10).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor10).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.MgaNumericEditor10).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor10).UseOsThemes = (DefaultableBoolean) 2;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(307, 29);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(99, 23);
    this.Label18.TabIndex = 42;
    this.Label18.Text = "Legal Paid to Date:";
    this.Label18.TextAlign = ContentAlignment.MiddleLeft;
    appearance99.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor9).Appearance = (AppearanceBase) appearance99;
    ((Control) this.MgaNumericEditor9).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.LAEPTD", true));
    ((Control) this.MgaNumericEditor9).Location = new Point(181, 368);
    this.MgaNumericEditor9.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor9).Name = "MgaNumericEditor9";
    ((UltraNumericEditor) this.MgaNumericEditor9).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor9).Size = new Size(94, 20);
    ((Control) this.MgaNumericEditor9).TabIndex = 14;
    ((UltraControlBase) this.MgaNumericEditor9).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor9).UseOsThemes = (DefaultableBoolean) 2;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(6, 367);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(98, 23);
    this.Label17.TabIndex = 40;
    this.Label17.Text = "LAE Paid to Date:";
    this.Label17.TextAlign = ContentAlignment.MiddleLeft;
    appearance100.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor8).Appearance = (AppearanceBase) appearance100;
    ((Control) this.MgaNumericEditor8).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.IndemnityPTD", true));
    ((Control) this.MgaNumericEditor8).Location = new Point(182, 264);
    this.MgaNumericEditor8.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor8).Name = "MgaNumericEditor8";
    ((UltraNumericEditor) this.MgaNumericEditor8).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor8).Size = new Size(94, 20);
    ((Control) this.MgaNumericEditor8).TabIndex = 10;
    ((UltraControlBase) this.MgaNumericEditor8).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor8).UseOsThemes = (DefaultableBoolean) 2;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(6, 263);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(135, 23);
    this.Label16.TabIndex = 38;
    this.Label16.Text = "Indemnity Paid to Date:";
    this.Label16.TextAlign = ContentAlignment.MiddleLeft;
    appearance101.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor7).Appearance = (AppearanceBase) appearance101;
    ((Control) this.MgaNumericEditor7).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.OtherRecovery", true));
    ((Control) this.MgaNumericEditor7).Location = new Point(181, 212);
    this.MgaNumericEditor7.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor7).Name = "MgaNumericEditor7";
    ((UltraNumericEditor) this.MgaNumericEditor7).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor7).Size = new Size(94, 20);
    ((Control) this.MgaNumericEditor7).TabIndex = 8;
    ((UltraControlBase) this.MgaNumericEditor7).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor7).UseOsThemes = (DefaultableBoolean) 2;
    appearance102.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor6).Appearance = (AppearanceBase) appearance102;
    ((Control) this.MgaNumericEditor6).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Salvage", true));
    ((Control) this.MgaNumericEditor6).Location = new Point(182, 186);
    this.MgaNumericEditor6.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor6).Name = "MgaNumericEditor6";
    ((UltraNumericEditor) this.MgaNumericEditor6).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor6).Size = new Size(94, 20);
    ((Control) this.MgaNumericEditor6).TabIndex = 7;
    ((UltraControlBase) this.MgaNumericEditor6).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor6).UseOsThemes = (DefaultableBoolean) 2;
    appearance103.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor5).Appearance = (AppearanceBase) appearance103;
    ((Control) this.MgaNumericEditor5).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Subrogation", true));
    ((Control) this.MgaNumericEditor5).Location = new Point(181, 160 /*0xA0*/);
    this.MgaNumericEditor5.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor5).Name = "MgaNumericEditor5";
    ((UltraNumericEditor) this.MgaNumericEditor5).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor5).Size = new Size(94, 20);
    ((Control) this.MgaNumericEditor5).TabIndex = 6;
    ((UltraControlBase) this.MgaNumericEditor5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor5).UseOsThemes = (DefaultableBoolean) 2;
    appearance104.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor4).Appearance = (AppearanceBase) appearance104;
    ((Control) this.MgaNumericEditor4).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.DedRecovery", true));
    ((Control) this.MgaNumericEditor4).Location = new Point(181, 134);
    this.MgaNumericEditor4.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor4).Name = "MgaNumericEditor4";
    ((UltraNumericEditor) this.MgaNumericEditor4).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor4).Size = new Size(94, 20);
    ((Control) this.MgaNumericEditor4).TabIndex = 5;
    ((UltraControlBase) this.MgaNumericEditor4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor4).UseOsThemes = (DefaultableBoolean) 2;
    appearance105.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor3).Appearance = (AppearanceBase) appearance105;
    ((Control) this.MgaNumericEditor3).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.OutLegalRes", true));
    ((Control) this.MgaNumericEditor3).Location = new Point(182, 108);
    this.MgaNumericEditor3.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor3).Name = "MgaNumericEditor3";
    ((UltraNumericEditor) this.MgaNumericEditor3).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor3).Size = new Size(94, 20);
    ((Control) this.MgaNumericEditor3).TabIndex = 4;
    ((UltraControlBase) this.MgaNumericEditor3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor3).UseOsThemes = (DefaultableBoolean) 2;
    appearance106.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor2).Appearance = (AppearanceBase) appearance106;
    ((Control) this.MgaNumericEditor2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.OutIndRes", true));
    ((Control) this.MgaNumericEditor2).Location = new Point(182, 30);
    this.MgaNumericEditor2.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor2).Name = "MgaNumericEditor2";
    ((UltraNumericEditor) this.MgaNumericEditor2).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor2).Size = new Size(94, 20);
    ((Control) this.MgaNumericEditor2).TabIndex = 1;
    ((UltraControlBase) this.MgaNumericEditor2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor2).UseOsThemes = (DefaultableBoolean) 2;
    appearance107.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor1).Appearance = (AppearanceBase) appearance107;
    ((Control) this.MgaNumericEditor1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.OutLAERes", true));
    ((Control) this.MgaNumericEditor1).Location = new Point(182, 4);
    this.MgaNumericEditor1.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor1).Name = "MgaNumericEditor1";
    ((UltraNumericEditor) this.MgaNumericEditor1).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor1).Size = new Size(94, 20);
    ((Control) this.MgaNumericEditor1).TabIndex = 0;
    ((UltraControlBase) this.MgaNumericEditor1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(6, 211);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(110, 23);
    this.Label15.TabIndex = 30;
    this.Label15.Text = "Other Recovery:";
    this.Label15.TextAlign = ContentAlignment.MiddleLeft;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(6, 185);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(132, 23);
    this.Label14.TabIndex = 28;
    this.Label14.Text = "Salvage Recovery:";
    this.Label14.TextAlign = ContentAlignment.MiddleLeft;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(6, 159);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(132, 23);
    this.Label13.TabIndex = 26;
    this.Label13.Text = "Subrogation Recovery:";
    this.Label13.TextAlign = ContentAlignment.MiddleLeft;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(6, 133);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(132, 23);
    this.Label12.TabIndex = 24;
    this.Label12.Text = "Deductible Recovery:";
    this.Label12.TextAlign = ContentAlignment.MiddleLeft;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(6, 107);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(154, 23);
    this.Label11.TabIndex = 22;
    this.Label11.Text = "Outstanding Legal Reserve:";
    this.Label11.TextAlign = ContentAlignment.MiddleLeft;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(5, 26);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(166, 28);
    this.Label10.TabIndex = 20;
    this.Label10.Text = "Outstanding Indemnity Reserve:";
    this.Label10.TextAlign = ContentAlignment.MiddleLeft;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(6, 1);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(135, 23);
    this.Label9.TabIndex = 18;
    this.Label9.Text = "Outstanding LAE Reserve:";
    this.Label9.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.dbSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = (EditStyle) 1;
    this.dbSave.FreezeEvents = false;
    ((Control) this.dbSave).Location = new Point(764, 343);
    ((Control) this.dbSave).Name = "dbSave";
    ((Control) this.dbSave).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.dbSave).TabIndex = 22;
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.Label85);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.MgaTextBox27);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.MgaNumericEditor42);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.Label84);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.MgaNumericEditor41);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.Label83);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.MgaNumericEditor40);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.Label82);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.MgaNumericEditor39);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.Label81);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.MgaNumericEditor38);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.Label80);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.MgaNumericEditor37);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.Label79);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.MgaNumericEditor36);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.Label78);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.MgaNumericEditor34);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.MgaNumericEditor35);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.Label77);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.Label76);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.Label75);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.MgaNumericEditor33);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.MgaNumericEditor32);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.Label74);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.MgaNumericEditor30);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.Label73);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.MgaNumericEditor31);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.Label72);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.Label71);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.MgaNumericEditor29);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.lblHailCode);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.numHailCode);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.lblAtcCode);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.numAtcCode);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.lblIsoCode);
    ((Control) this.tabAdditionalReservesPayments).Controls.Add((Control) this.numIsoCode);
    ((Control) this.tabAdditionalReservesPayments).Location = new Point(-10000, -10000);
    ((Control) this.tabAdditionalReservesPayments).Name = "tabAdditionalReservesPayments";
    ((Control) this.tabAdditionalReservesPayments).Size = new Size(879, 394);
    this.Label85.AutoSize = true;
    this.Label85.BackColor = Color.Transparent;
    this.Label85.Location = new Point(249, 113);
    this.Label85.Name = "Label85";
    this.Label85.Size = new Size(82, 13);
    this.Label85.TabIndex = 159;
    this.Label85.Text = "Program Notes:";
    appearance108.BackColor = Color.White;
    appearance108.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance108.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox27).Appearance = (AppearanceBase) appearance108;
    ((TextEditorControlBase) this.MgaTextBox27).BackColor = Color.White;
    ((Control) this.MgaTextBox27).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Program_Notes", true));
    ((Control) this.MgaTextBox27).Location = new Point(252, 135);
    this.MgaTextBox27.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.MgaTextBox27).Multiline = true;
    ((Control) this.MgaTextBox27).Name = "MgaTextBox27";
    ((Control) this.MgaTextBox27).Size = new Size(220, 202);
    ((Control) this.MgaTextBox27).TabIndex = 158;
    ((UltraControlBase) this.MgaTextBox27).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox27).UseOsThemes = (DefaultableBoolean) 2;
    appearance109.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor42).Appearance = (AppearanceBase) appearance109;
    ((Control) this.MgaNumericEditor42).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Program_NS", true));
    ((Control) this.MgaNumericEditor42).Location = new Point(385, 83);
    ((UltraNumericEditor) this.MgaNumericEditor42).MaxValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      131072 /*0x020000*/
    });
    this.MgaNumericEditor42.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.MgaNumericEditor42).MinValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      -2147352576 /*0x80020000*/
    });
    ((Control) this.MgaNumericEditor42).Name = "MgaNumericEditor42";
    ((UltraNumericEditor) this.MgaNumericEditor42).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor42).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor42).TabIndex = 156;
    ((UltraControlBase) this.MgaNumericEditor42).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor42).UseOsThemes = (DefaultableBoolean) 2;
    this.Label84.AutoSize = true;
    this.Label84.BackColor = Color.Transparent;
    this.Label84.Location = new Point(249, 87);
    this.Label84.Name = "Label84";
    this.Label84.Size = new Size(67, 13);
    this.Label84.TabIndex = 157;
    this.Label84.Text = "Program NS:";
    appearance110.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor41).Appearance = (AppearanceBase) appearance110;
    ((Control) this.MgaNumericEditor41).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Program_WindHail", true));
    ((Control) this.MgaNumericEditor41).Location = new Point(385, 57);
    ((UltraNumericEditor) this.MgaNumericEditor41).MaxValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      131072 /*0x020000*/
    });
    this.MgaNumericEditor41.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.MgaNumericEditor41).MinValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      -2147352576 /*0x80020000*/
    });
    ((Control) this.MgaNumericEditor41).Name = "MgaNumericEditor41";
    ((UltraNumericEditor) this.MgaNumericEditor41).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor41).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor41).TabIndex = 154;
    ((UltraControlBase) this.MgaNumericEditor41).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor41).UseOsThemes = (DefaultableBoolean) 2;
    this.Label83.AutoSize = true;
    this.Label83.BackColor = Color.Transparent;
    this.Label83.Location = new Point(249, 61);
    this.Label83.Name = "Label83";
    this.Label83.Size = new Size(98, 13);
    this.Label83.TabIndex = 155;
    this.Label83.Text = "Program Wind Hail:";
    appearance111.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor40).Appearance = (AppearanceBase) appearance111;
    ((Control) this.MgaNumericEditor40).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Program_AOP", true));
    ((Control) this.MgaNumericEditor40).Location = new Point(385, 31 /*0x1F*/);
    ((UltraNumericEditor) this.MgaNumericEditor40).MaxValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      131072 /*0x020000*/
    });
    this.MgaNumericEditor40.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.MgaNumericEditor40).MinValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      -2147352576 /*0x80020000*/
    });
    ((Control) this.MgaNumericEditor40).Name = "MgaNumericEditor40";
    ((UltraNumericEditor) this.MgaNumericEditor40).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor40).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor40).TabIndex = 152;
    ((UltraControlBase) this.MgaNumericEditor40).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor40).UseOsThemes = (DefaultableBoolean) 2;
    this.Label82.AutoSize = true;
    this.Label82.BackColor = Color.Transparent;
    this.Label82.Location = new Point(249, 35);
    this.Label82.Name = "Label82";
    this.Label82.Size = new Size(75, 13);
    this.Label82.TabIndex = 153;
    this.Label82.Text = "Program AOP:";
    appearance112.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor39).Appearance = (AppearanceBase) appearance112;
    ((Control) this.MgaNumericEditor39).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Program_Deductible_Applied", true));
    ((Control) this.MgaNumericEditor39).Location = new Point(385, 5);
    ((UltraNumericEditor) this.MgaNumericEditor39).MaxValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      131072 /*0x020000*/
    });
    this.MgaNumericEditor39.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.MgaNumericEditor39).MinValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      -2147352576 /*0x80020000*/
    });
    ((Control) this.MgaNumericEditor39).Name = "MgaNumericEditor39";
    ((UltraNumericEditor) this.MgaNumericEditor39).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor39).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor39).TabIndex = 150;
    ((UltraControlBase) this.MgaNumericEditor39).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor39).UseOsThemes = (DefaultableBoolean) 2;
    this.Label81.AutoSize = true;
    this.Label81.BackColor = Color.Transparent;
    this.Label81.Location = new Point(249, 9);
    this.Label81.Name = "Label81";
    this.Label81.Size = new Size(115, 13);
    this.Label81.TabIndex = 151;
    this.Label81.Text = "Program Ded. Applied:";
    appearance113.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor38).Appearance = (AppearanceBase) appearance113;
    ((Control) this.MgaNumericEditor38).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Total_TIV", true));
    ((Control) this.MgaNumericEditor38).Location = new Point(121, 317);
    ((UltraNumericEditor) this.MgaNumericEditor38).MaxValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      131072 /*0x020000*/
    });
    this.MgaNumericEditor38.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.MgaNumericEditor38).MinValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      -2147352576 /*0x80020000*/
    });
    ((Control) this.MgaNumericEditor38).Name = "MgaNumericEditor38";
    ((UltraNumericEditor) this.MgaNumericEditor38).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor38).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor38).TabIndex = 12;
    ((UltraControlBase) this.MgaNumericEditor38).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor38).UseOsThemes = (DefaultableBoolean) 2;
    this.Label80.AutoSize = true;
    this.Label80.BackColor = Color.Transparent;
    this.Label80.Location = new Point(26, 321);
    this.Label80.Name = "Label80";
    this.Label80.Size = new Size(54, 13);
    this.Label80.TabIndex = 149;
    this.Label80.Text = "Total TIV:";
    appearance114.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor37).Appearance = (AppearanceBase) appearance114;
    ((Control) this.MgaNumericEditor37).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Total_BI", true));
    ((Control) this.MgaNumericEditor37).Location = new Point(121, 291);
    ((UltraNumericEditor) this.MgaNumericEditor37).MaxValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      131072 /*0x020000*/
    });
    this.MgaNumericEditor37.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.MgaNumericEditor37).MinValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      -2147352576 /*0x80020000*/
    });
    ((Control) this.MgaNumericEditor37).Name = "MgaNumericEditor37";
    ((UltraNumericEditor) this.MgaNumericEditor37).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor37).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor37).TabIndex = 11;
    ((UltraControlBase) this.MgaNumericEditor37).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor37).UseOsThemes = (DefaultableBoolean) 2;
    this.Label79.AutoSize = true;
    this.Label79.BackColor = Color.Transparent;
    this.Label79.Location = new Point(26, 295);
    this.Label79.Name = "Label79";
    this.Label79.Size = new Size(48 /*0x30*/, 13);
    this.Label79.TabIndex = 147;
    this.Label79.Text = "Total BI:";
    appearance115.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor36).Appearance = (AppearanceBase) appearance115;
    ((Control) this.MgaNumericEditor36).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Total_BBP", true));
    ((Control) this.MgaNumericEditor36).Location = new Point(121, 265);
    ((UltraNumericEditor) this.MgaNumericEditor36).MaxValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      131072 /*0x020000*/
    });
    this.MgaNumericEditor36.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.MgaNumericEditor36).MinValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      -2147352576 /*0x80020000*/
    });
    ((Control) this.MgaNumericEditor36).Name = "MgaNumericEditor36";
    ((UltraNumericEditor) this.MgaNumericEditor36).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor36).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor36).TabIndex = 10;
    ((UltraControlBase) this.MgaNumericEditor36).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor36).UseOsThemes = (DefaultableBoolean) 2;
    this.Label78.AutoSize = true;
    this.Label78.BackColor = Color.Transparent;
    this.Label78.Location = new Point(28, 269);
    this.Label78.Name = "Label78";
    this.Label78.Size = new Size(56, 13);
    this.Label78.TabIndex = 145;
    this.Label78.Text = "Total BBP:";
    appearance116.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor34).Appearance = (AppearanceBase) appearance116;
    ((Control) this.MgaNumericEditor34).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Price_Per_Sqft", true));
    ((Control) this.MgaNumericEditor34).Location = new Point(121, 135);
    ((UltraNumericEditor) this.MgaNumericEditor34).MaxValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      131072 /*0x020000*/
    });
    this.MgaNumericEditor34.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.MgaNumericEditor34).MinValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      -2147352576 /*0x80020000*/
    });
    ((Control) this.MgaNumericEditor34).Name = "MgaNumericEditor34";
    ((UltraNumericEditor) this.MgaNumericEditor34).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor34).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor34).TabIndex = 5;
    ((UltraControlBase) this.MgaNumericEditor34).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor34).UseOsThemes = (DefaultableBoolean) 2;
    appearance117.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor35).Appearance = (AppearanceBase) appearance117;
    ((Control) this.MgaNumericEditor35).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Total_BV", true));
    ((Control) this.MgaNumericEditor35).Location = new Point(121, 239);
    ((UltraNumericEditor) this.MgaNumericEditor35).MaxValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      131072 /*0x020000*/
    });
    this.MgaNumericEditor35.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.MgaNumericEditor35).MinValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      -2147352576 /*0x80020000*/
    });
    ((Control) this.MgaNumericEditor35).Name = "MgaNumericEditor35";
    ((UltraNumericEditor) this.MgaNumericEditor35).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor35).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor35).TabIndex = 9;
    ((UltraControlBase) this.MgaNumericEditor35).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor35).UseOsThemes = (DefaultableBoolean) 2;
    this.Label77.AutoSize = true;
    this.Label77.BackColor = Color.Transparent;
    this.Label77.Location = new Point(26, 243);
    this.Label77.Name = "Label77";
    this.Label77.Size = new Size(50, 13);
    this.Label77.TabIndex = 142;
    this.Label77.Text = "Total BV:";
    this.Label76.AutoSize = true;
    this.Label76.BackColor = Color.Transparent;
    this.Label76.Location = new Point(28, 139);
    this.Label76.Name = "Label76";
    this.Label76.Size = new Size(81, 13);
    this.Label76.TabIndex = 141;
    this.Label76.Text = "Price Per Sq Ft:";
    this.Label75.AutoSize = true;
    this.Label75.BackColor = Color.Transparent;
    this.Label75.Location = new Point(26, 113);
    this.Label75.Name = "Label75";
    this.Label75.Size = new Size(63 /*0x3F*/, 13);
    this.Label75.TabIndex = 140;
    this.Label75.Text = "Total Sq Ft:";
    appearance118.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor33).Appearance = (AppearanceBase) appearance118;
    ((Control) this.MgaNumericEditor33).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Total_SqFt", true));
    ((Control) this.MgaNumericEditor33).Location = new Point(121, 109);
    ((UltraNumericEditor) this.MgaNumericEditor33).MaskInput = "nnnnnnnnnn";
    this.MgaNumericEditor33.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor33).Name = "MgaNumericEditor33";
    ((UltraNumericEditor) this.MgaNumericEditor33).Nullable = true;
    ((Control) this.MgaNumericEditor33).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor33).TabIndex = 4;
    ((UltraWinEditorMaskedControlBase) this.MgaNumericEditor33).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.MgaNumericEditor33).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor33).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditor) this.MgaNumericEditor33).Value = (object) null;
    appearance119.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor32).Appearance = (AppearanceBase) appearance119;
    ((Control) this.MgaNumericEditor32).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Student_Senior", true));
    ((Control) this.MgaNumericEditor32).Location = new Point(121, 213);
    ((UltraNumericEditor) this.MgaNumericEditor32).MaxValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      131072 /*0x020000*/
    });
    this.MgaNumericEditor32.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.MgaNumericEditor32).MinValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      -2147352576 /*0x80020000*/
    });
    ((Control) this.MgaNumericEditor32).Name = "MgaNumericEditor32";
    ((UltraNumericEditor) this.MgaNumericEditor32).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor32).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor32).TabIndex = 8;
    ((UltraControlBase) this.MgaNumericEditor32).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor32).UseOsThemes = (DefaultableBoolean) 2;
    this.Label74.AutoSize = true;
    this.Label74.BackColor = Color.Transparent;
    this.Label74.Location = new Point(26, 217);
    this.Label74.Name = "Label74";
    this.Label74.Size = new Size(82, 13);
    this.Label74.TabIndex = 137;
    this.Label74.Text = "Student Senior:";
    appearance120.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor30).Appearance = (AppearanceBase) appearance120;
    ((Control) this.MgaNumericEditor30).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Subsidized", true));
    ((Control) this.MgaNumericEditor30).Location = new Point(121, 187);
    ((UltraNumericEditor) this.MgaNumericEditor30).MaxValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      131072 /*0x020000*/
    });
    this.MgaNumericEditor30.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.MgaNumericEditor30).MinValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      -2147352576 /*0x80020000*/
    });
    ((Control) this.MgaNumericEditor30).Name = "MgaNumericEditor30";
    ((UltraNumericEditor) this.MgaNumericEditor30).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor30).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor30).TabIndex = 7;
    ((UltraControlBase) this.MgaNumericEditor30).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor30).UseOsThemes = (DefaultableBoolean) 2;
    this.Label73.AutoSize = true;
    this.Label73.BackColor = Color.Transparent;
    this.Label73.Location = new Point(28, 191);
    this.Label73.Name = "Label73";
    this.Label73.Size = new Size(61, 13);
    this.Label73.TabIndex = 135;
    this.Label73.Text = "Subsidized:";
    appearance121.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor31).Appearance = (AppearanceBase) appearance121;
    ((Control) this.MgaNumericEditor31).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Occupancy", true));
    ((Control) this.MgaNumericEditor31).Location = new Point(121, 161);
    ((UltraNumericEditor) this.MgaNumericEditor31).MaxValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      131072 /*0x020000*/
    });
    this.MgaNumericEditor31.MGAStyle = (MGAStyles) 2;
    ((UltraNumericEditor) this.MgaNumericEditor31).MinValue = (object) new Decimal(new int[4]
    {
      -1530494977,
      232830,
      0,
      -2147352576 /*0x80020000*/
    });
    ((Control) this.MgaNumericEditor31).Name = "MgaNumericEditor31";
    ((UltraNumericEditor) this.MgaNumericEditor31).NumericType = (NumericType) 1;
    ((Control) this.MgaNumericEditor31).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor31).TabIndex = 6;
    ((UltraControlBase) this.MgaNumericEditor31).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor31).UseOsThemes = (DefaultableBoolean) 2;
    this.Label72.AutoSize = true;
    this.Label72.BackColor = Color.Transparent;
    this.Label72.Location = new Point(28, 165);
    this.Label72.Name = "Label72";
    this.Label72.Size = new Size(64 /*0x40*/, 13);
    this.Label72.TabIndex = 133;
    this.Label72.Text = "Occupancy:";
    this.Label71.AutoSize = true;
    this.Label71.BackColor = Color.Transparent;
    this.Label71.Location = new Point(26, 87);
    this.Label71.Name = "Label71";
    this.Label71.Size = new Size(52, 13);
    this.Label71.TabIndex = 132;
    this.Label71.Text = "PC Code:";
    appearance122.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor29).Appearance = (AppearanceBase) appearance122;
    ((Control) this.MgaNumericEditor29).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Pc_Code", true));
    ((Control) this.MgaNumericEditor29).Location = new Point(121, 83);
    ((UltraNumericEditor) this.MgaNumericEditor29).MaskInput = "nnnnnnnnnn";
    this.MgaNumericEditor29.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaNumericEditor29).Name = "MgaNumericEditor29";
    ((UltraNumericEditor) this.MgaNumericEditor29).Nullable = true;
    ((Control) this.MgaNumericEditor29).Size = new Size(87, 20);
    ((Control) this.MgaNumericEditor29).TabIndex = 3;
    ((UltraWinEditorMaskedControlBase) this.MgaNumericEditor29).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.MgaNumericEditor29).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor29).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditor) this.MgaNumericEditor29).Value = (object) null;
    this.lblHailCode.AutoSize = true;
    this.lblHailCode.BackColor = Color.Transparent;
    this.lblHailCode.Location = new Point(26, 61);
    this.lblHailCode.Name = "lblHailCode";
    this.lblHailCode.Size = new Size(56, 13);
    this.lblHailCode.TabIndex = 130;
    this.lblHailCode.Text = "Hail Code:";
    appearance123.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numHailCode).Appearance = (AppearanceBase) appearance123;
    ((Control) this.numHailCode).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Hail_Code", true));
    ((Control) this.numHailCode).Location = new Point(121, 57);
    ((UltraNumericEditor) this.numHailCode).MaskInput = "nnnnnnnnnn";
    this.numHailCode.MGAStyle = (MGAStyles) 2;
    ((Control) this.numHailCode).Name = "numHailCode";
    ((UltraNumericEditor) this.numHailCode).Nullable = true;
    ((Control) this.numHailCode).Size = new Size(87, 20);
    ((Control) this.numHailCode).TabIndex = 2;
    ((UltraWinEditorMaskedControlBase) this.numHailCode).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numHailCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numHailCode).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditor) this.numHailCode).Value = (object) null;
    this.lblAtcCode.AutoSize = true;
    this.lblAtcCode.BackColor = Color.Transparent;
    this.lblAtcCode.Location = new Point(26, 35);
    this.lblAtcCode.Name = "lblAtcCode";
    this.lblAtcCode.Size = new Size(59, 13);
    this.lblAtcCode.TabIndex = 128 /*0x80*/;
    this.lblAtcCode.Text = "ATC Code:";
    appearance124.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numAtcCode).Appearance = (AppearanceBase) appearance124;
    ((Control) this.numAtcCode).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Atc_Code", true));
    ((Control) this.numAtcCode).Location = new Point(121, 31 /*0x1F*/);
    ((UltraNumericEditor) this.numAtcCode).MaskInput = "nnnnnnnnnn";
    this.numAtcCode.MGAStyle = (MGAStyles) 2;
    ((Control) this.numAtcCode).Name = "numAtcCode";
    ((UltraNumericEditor) this.numAtcCode).Nullable = true;
    ((Control) this.numAtcCode).Size = new Size(87, 20);
    ((Control) this.numAtcCode).TabIndex = 1;
    ((UltraWinEditorMaskedControlBase) this.numAtcCode).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numAtcCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numAtcCode).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditor) this.numAtcCode).Value = (object) null;
    this.lblIsoCode.AutoSize = true;
    this.lblIsoCode.BackColor = Color.Transparent;
    this.lblIsoCode.Location = new Point(26, 9);
    this.lblIsoCode.Name = "lblIsoCode";
    this.lblIsoCode.Size = new Size(57, 13);
    this.lblIsoCode.TabIndex = 126;
    this.lblIsoCode.Text = "ISO Code:";
    appearance125.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numIsoCode).Appearance = (AppearanceBase) appearance125;
    ((Control) this.numIsoCode).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClaimResPaymentActivity.Iso_Code", true));
    ((Control) this.numIsoCode).Location = new Point(121, 5);
    ((UltraNumericEditor) this.numIsoCode).MaskInput = "nnnnnnnnnn";
    this.numIsoCode.MGAStyle = (MGAStyles) 2;
    ((Control) this.numIsoCode).Name = "numIsoCode";
    ((UltraNumericEditor) this.numIsoCode).Nullable = true;
    ((Control) this.numIsoCode).Size = new Size(87, 20);
    ((Control) this.numIsoCode).TabIndex = 0;
    ((UltraWinEditorMaskedControlBase) this.numIsoCode).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numIsoCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numIsoCode).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraNumericEditor) this.numIsoCode).Value = (object) null;
    this.daClaims.DeleteCommand = this.DbDeleteCommand;
    this.daClaims.InsertCommand = this.DbInsertCommand;
    this.daClaims.SelectCommand = this.DbSelectCommand1;
    this.daClaims.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblClaimInformation", new DataColumnMapping[50]
      {
        new DataColumnMapping("ClaimID", "ClaimID"),
        new DataColumnMapping("ControlNo", "ControlNo"),
        new DataColumnMapping("ClaimNo", "ClaimNo"),
        new DataColumnMapping("DateReceived", "DateReceived"),
        new DataColumnMapping("DateReported", "DateReported"),
        new DataColumnMapping("LossDate", "LossDate"),
        new DataColumnMapping("LossType", "LossType"),
        new DataColumnMapping("Status", "Status"),
        new DataColumnMapping("DateClosed", "DateClosed"),
        new DataColumnMapping("InLitigation", "InLitigation"),
        new DataColumnMapping("DescriptionInjury", "DescriptionInjury"),
        new DataColumnMapping("CATNo", "CATNo"),
        new DataColumnMapping("Claimant", "Claimant"),
        new DataColumnMapping("Deductible", "Deductible"),
        new DataColumnMapping("CoverageDescription", "CoverageDescription"),
        new DataColumnMapping("Company", "Company"),
        new DataColumnMapping("CorresBranchName", "CorresBranchName"),
        new DataColumnMapping("Occurence", "Occurence"),
        new DataColumnMapping("LOB", "LOB"),
        new DataColumnMapping("Lien", "Lien"),
        new DataColumnMapping("SubroPotential", "SubroPotential"),
        new DataColumnMapping("FirstThirdParty", "FirstThirdParty"),
        new DataColumnMapping("Fatality", "Fatality"),
        new DataColumnMapping("NCCICode", "NCCICode"),
        new DataColumnMapping("DateReOpened", "DateReOpened"),
        new DataColumnMapping("InitialContact", "InitialContact"),
        new DataColumnMapping("FirstInsp", "FirstInsp"),
        new DataColumnMapping("FirstReport", "FirstReport"),
        new DataColumnMapping("ReportToCarrier", "ReportToCarrier"),
        new DataColumnMapping("AdjusterName", "AdjusterName"),
        new DataColumnMapping("AdjusterTitle", "AdjusterTitle"),
        new DataColumnMapping("AdjusterCategory", "AdjusterCategory"),
        new DataColumnMapping("IndepAdjuster", "IndepAdjuster"),
        new DataColumnMapping("DefFirm", "DefFirm"),
        new DataColumnMapping("ClaimantCounsel", "ClaimantCounsel"),
        new DataColumnMapping("Gender", "Gender"),
        new DataColumnMapping("Age", "Age"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("ReadOnly", "ReadOnly"),
        new DataColumnMapping("CarrierClaimNo", "CarrierClaimNo"),
        new DataColumnMapping("LocationID", "LocationID"),
        new DataColumnMapping("Driver", "Driver"),
        new DataColumnMapping("DatePaid", "DatePaid"),
        new DataColumnMapping("OriginalLoanDate", "OriginalLoanDate"),
        new DataColumnMapping("RejectedDate", "RejectedDate"),
        new DataColumnMapping("RejectedAmount", "RejectedAmount"),
        new DataColumnMapping("Comments", "Comments"),
        new DataColumnMapping("LastClaimUpdated", "LastClaimUpdated"),
        new DataColumnMapping("BodyPart", "BodyPart"),
        new DataColumnMapping("AdjCaseReserves", "AdjCaseReserves")
      })
    });
    this.daClaims.UpdateCommand = this.DbUpdateCommand;
    this.DbDeleteCommand.CommandText = "DELETE FROM [dbo].[tblClaimInformation] WHERE (([ClaimID] = @Original_ClaimID))";
    this.DbDeleteCommand.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_ClaimID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ClaimID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand.CommandText = componentResourceManager.GetString("DbInsertCommand.CommandText");
    this.DbInsertCommand.Parameters.AddRange((Array) new DbParameter[53]
    {
      DefaultDatabase.CreateParameter("@ControlNo", SqlDbType.Int, 4, "ControlNo"),
      DefaultDatabase.CreateParameter("@ClaimNo", SqlDbType.VarChar, 50, "ClaimNo"),
      DefaultDatabase.CreateParameter("@DateReceived", SqlDbType.SmallDateTime, 4, "DateReceived"),
      DefaultDatabase.CreateParameter("@DateReported", SqlDbType.SmallDateTime, 4, "DateReported"),
      DefaultDatabase.CreateParameter("@LossDate", SqlDbType.SmallDateTime, 4, "LossDate"),
      DefaultDatabase.CreateParameter("@LossType", SqlDbType.VarChar, 50, "LossType"),
      DefaultDatabase.CreateParameter("@Status", SqlDbType.VarChar, 50, "Status"),
      DefaultDatabase.CreateParameter("@DateClosed", SqlDbType.SmallDateTime, 4, "DateClosed"),
      DefaultDatabase.CreateParameter("@InLitigation", SqlDbType.Bit, 1, "InLitigation"),
      DefaultDatabase.CreateParameter("@DescriptionInjury", SqlDbType.VarChar, 500, "DescriptionInjury"),
      DefaultDatabase.CreateParameter("@CATNo", SqlDbType.VarChar, 50, "CATNo"),
      DefaultDatabase.CreateParameter("@Claimant", SqlDbType.VarChar, 70, "Claimant"),
      DefaultDatabase.CreateParameter("@Deductible", SqlDbType.VarChar, 25, "Deductible"),
      DefaultDatabase.CreateParameter("@CoverageDescription", SqlDbType.VarChar, 300, "CoverageDescription"),
      DefaultDatabase.CreateParameter("@Company", SqlDbType.VarChar, 100, "Company"),
      DefaultDatabase.CreateParameter("@CorresBranchName", SqlDbType.VarChar, 100, "CorresBranchName"),
      DefaultDatabase.CreateParameter("@Occurence", SqlDbType.VarChar, 50, "Occurence"),
      DefaultDatabase.CreateParameter("@LOB", SqlDbType.VarChar, 50, "LOB"),
      DefaultDatabase.CreateParameter("@Lien", SqlDbType.VarChar, 50, "Lien"),
      DefaultDatabase.CreateParameter("@SubroPotential", SqlDbType.VarChar, 50, "SubroPotential"),
      DefaultDatabase.CreateParameter("@FirstThirdParty", SqlDbType.VarChar, 50, "FirstThirdParty"),
      DefaultDatabase.CreateParameter("@Fatality", SqlDbType.VarChar, 50, "Fatality"),
      DefaultDatabase.CreateParameter("@NCCICode", SqlDbType.VarChar, 50, "NCCICode"),
      DefaultDatabase.CreateParameter("@DateReOpened", SqlDbType.DateTime, 8, "DateReOpened"),
      DefaultDatabase.CreateParameter("@InitialContact", SqlDbType.VarChar, 50, "InitialContact"),
      DefaultDatabase.CreateParameter("@FirstInsp", SqlDbType.DateTime, 8, "FirstInsp"),
      DefaultDatabase.CreateParameter("@FirstReport", SqlDbType.DateTime, 8, "FirstReport"),
      DefaultDatabase.CreateParameter("@ReportToCarrier", SqlDbType.DateTime, 8, "ReportToCarrier"),
      DefaultDatabase.CreateParameter("@AdjusterName", SqlDbType.VarChar, 50, "AdjusterName"),
      DefaultDatabase.CreateParameter("@AdjusterTitle", SqlDbType.VarChar, 30, "AdjusterTitle"),
      DefaultDatabase.CreateParameter("@AdjusterCategory", SqlDbType.VarChar, 50, "AdjusterCategory"),
      DefaultDatabase.CreateParameter("@IndepAdjuster", SqlDbType.VarChar, 50, "IndepAdjuster"),
      DefaultDatabase.CreateParameter("@DefFirm", SqlDbType.VarChar, 100, "DefFirm"),
      DefaultDatabase.CreateParameter("@ClaimantCounsel", SqlDbType.VarChar, 100, "ClaimantCounsel"),
      DefaultDatabase.CreateParameter("@Gender", SqlDbType.VarChar, 10, "Gender"),
      DefaultDatabase.CreateParameter("@Age", SqlDbType.Int, 4, "Age"),
      DefaultDatabase.CreateParameter("@County", SqlDbType.VarChar, 50, "County"),
      DefaultDatabase.CreateParameter("@ReadOnly", SqlDbType.Bit, 1, "ReadOnly"),
      DefaultDatabase.CreateParameter("@CarrierClaimNo", SqlDbType.VarChar, 50, "CarrierClaimNo"),
      DefaultDatabase.CreateParameter("@LocationID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "LocationID", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@Driver", SqlDbType.VarChar, 100, "Driver"),
      DefaultDatabase.CreateParameter("@DatePaid", SqlDbType.DateTime, 8, "DatePaid"),
      DefaultDatabase.CreateParameter("@OriginalLoanDate", SqlDbType.DateTime, 8, "OriginalLoanDate"),
      DefaultDatabase.CreateParameter("@RejectedDate", SqlDbType.DateTime, 8, "RejectedDate"),
      DefaultDatabase.CreateParameter("@RejectedAmount", SqlDbType.Money, 8, "RejectedAmount"),
      DefaultDatabase.CreateParameter("@Comments", SqlDbType.VarChar, 500, "Comments"),
      DefaultDatabase.CreateParameter("@LastClaimUpdated", SqlDbType.SmallDateTime, 4, "LastClaimUpdated"),
      DefaultDatabase.CreateParameter("@BodyPart", SqlDbType.VarChar, 50, "BodyPart"),
      DefaultDatabase.CreateParameter("@AdjCaseReserves", SqlDbType.Money, 8, "AdjCaseReserves"),
      DefaultDatabase.CreateParameter("@CAT_Name_Details", SqlDbType.VarChar, int.MaxValue, "CAT_Name_Details"),
      DefaultDatabase.CreateParameter("@TotalPaid", SqlDbType.Money, 8, "TotalPaid"),
      DefaultDatabase.CreateParameter("@Limit", SqlDbType.Money, 8, "Limit"),
      DefaultDatabase.CreateParameter("@WatchList", SqlDbType.VarChar, 100, "WatchList")
    });
    this.DbSelectCommand1.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@ControlNo", SqlDbType.Int, 4, "ControlNo")
    });
    this.DbUpdateCommand.CommandText = componentResourceManager.GetString("DbUpdateCommand.CommandText");
    this.DbUpdateCommand.Parameters.AddRange((Array) new DbParameter[55]
    {
      DefaultDatabase.CreateParameter("@ControlNo", SqlDbType.Int, 4, "ControlNo"),
      DefaultDatabase.CreateParameter("@ClaimNo", SqlDbType.VarChar, 50, "ClaimNo"),
      DefaultDatabase.CreateParameter("@DateReceived", SqlDbType.SmallDateTime, 4, "DateReceived"),
      DefaultDatabase.CreateParameter("@DateReported", SqlDbType.SmallDateTime, 4, "DateReported"),
      DefaultDatabase.CreateParameter("@LossDate", SqlDbType.SmallDateTime, 4, "LossDate"),
      DefaultDatabase.CreateParameter("@LossType", SqlDbType.VarChar, 50, "LossType"),
      DefaultDatabase.CreateParameter("@Status", SqlDbType.VarChar, 50, "Status"),
      DefaultDatabase.CreateParameter("@DateClosed", SqlDbType.SmallDateTime, 4, "DateClosed"),
      DefaultDatabase.CreateParameter("@InLitigation", SqlDbType.Bit, 1, "InLitigation"),
      DefaultDatabase.CreateParameter("@DescriptionInjury", SqlDbType.VarChar, 500, "DescriptionInjury"),
      DefaultDatabase.CreateParameter("@CATNo", SqlDbType.VarChar, 50, "CATNo"),
      DefaultDatabase.CreateParameter("@Claimant", SqlDbType.VarChar, 70, "Claimant"),
      DefaultDatabase.CreateParameter("@Deductible", SqlDbType.VarChar, 25, "Deductible"),
      DefaultDatabase.CreateParameter("@CoverageDescription", SqlDbType.VarChar, 300, "CoverageDescription"),
      DefaultDatabase.CreateParameter("@Company", SqlDbType.VarChar, 100, "Company"),
      DefaultDatabase.CreateParameter("@CorresBranchName", SqlDbType.VarChar, 100, "CorresBranchName"),
      DefaultDatabase.CreateParameter("@Occurence", SqlDbType.VarChar, 50, "Occurence"),
      DefaultDatabase.CreateParameter("@LOB", SqlDbType.VarChar, 50, "LOB"),
      DefaultDatabase.CreateParameter("@Lien", SqlDbType.VarChar, 50, "Lien"),
      DefaultDatabase.CreateParameter("@SubroPotential", SqlDbType.VarChar, 50, "SubroPotential"),
      DefaultDatabase.CreateParameter("@FirstThirdParty", SqlDbType.VarChar, 50, "FirstThirdParty"),
      DefaultDatabase.CreateParameter("@Fatality", SqlDbType.VarChar, 50, "Fatality"),
      DefaultDatabase.CreateParameter("@NCCICode", SqlDbType.VarChar, 50, "NCCICode"),
      DefaultDatabase.CreateParameter("@DateReOpened", SqlDbType.DateTime, 8, "DateReOpened"),
      DefaultDatabase.CreateParameter("@InitialContact", SqlDbType.VarChar, 50, "InitialContact"),
      DefaultDatabase.CreateParameter("@FirstInsp", SqlDbType.DateTime, 8, "FirstInsp"),
      DefaultDatabase.CreateParameter("@FirstReport", SqlDbType.DateTime, 8, "FirstReport"),
      DefaultDatabase.CreateParameter("@ReportToCarrier", SqlDbType.DateTime, 8, "ReportToCarrier"),
      DefaultDatabase.CreateParameter("@AdjusterName", SqlDbType.VarChar, 50, "AdjusterName"),
      DefaultDatabase.CreateParameter("@AdjusterTitle", SqlDbType.VarChar, 30, "AdjusterTitle"),
      DefaultDatabase.CreateParameter("@AdjusterCategory", SqlDbType.VarChar, 50, "AdjusterCategory"),
      DefaultDatabase.CreateParameter("@IndepAdjuster", SqlDbType.VarChar, 50, "IndepAdjuster"),
      DefaultDatabase.CreateParameter("@DefFirm", SqlDbType.VarChar, 100, "DefFirm"),
      DefaultDatabase.CreateParameter("@ClaimantCounsel", SqlDbType.VarChar, 100, "ClaimantCounsel"),
      DefaultDatabase.CreateParameter("@Gender", SqlDbType.VarChar, 10, "Gender"),
      DefaultDatabase.CreateParameter("@Age", SqlDbType.Int, 4, "Age"),
      DefaultDatabase.CreateParameter("@County", SqlDbType.VarChar, 50, "County"),
      DefaultDatabase.CreateParameter("@ReadOnly", SqlDbType.Bit, 1, "ReadOnly"),
      DefaultDatabase.CreateParameter("@CarrierClaimNo", SqlDbType.VarChar, 50, "CarrierClaimNo"),
      DefaultDatabase.CreateParameter("@LocationID", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 18, (byte) 0, "LocationID", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@Driver", SqlDbType.VarChar, 100, "Driver"),
      DefaultDatabase.CreateParameter("@DatePaid", SqlDbType.DateTime, 8, "DatePaid"),
      DefaultDatabase.CreateParameter("@OriginalLoanDate", SqlDbType.DateTime, 8, "OriginalLoanDate"),
      DefaultDatabase.CreateParameter("@RejectedDate", SqlDbType.DateTime, 8, "RejectedDate"),
      DefaultDatabase.CreateParameter("@RejectedAmount", SqlDbType.Money, 8, "RejectedAmount"),
      DefaultDatabase.CreateParameter("@Comments", SqlDbType.VarChar, 500, "Comments"),
      DefaultDatabase.CreateParameter("@LastClaimUpdated", SqlDbType.SmallDateTime, 4, "LastClaimUpdated"),
      DefaultDatabase.CreateParameter("@BodyPart", SqlDbType.VarChar, 50, "BodyPart"),
      DefaultDatabase.CreateParameter("@AdjCaseReserves", SqlDbType.Money, 8, "AdjCaseReserves"),
      DefaultDatabase.CreateParameter("@CAT_Name_Details", SqlDbType.VarChar, int.MaxValue, "CAT_Name_Details"),
      DefaultDatabase.CreateParameter("@TotalPaid", SqlDbType.Money, 8, "TotalPaid"),
      DefaultDatabase.CreateParameter("@Limit", SqlDbType.Money, 8, "Limit"),
      DefaultDatabase.CreateParameter("@WatchList", SqlDbType.VarChar, 100, "WatchList"),
      DefaultDatabase.CreateParameter("@Original_ClaimID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ClaimID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@ClaimID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ClaimID", DataRowVersion.Original, (object) null)
    });
    this.daResPay.DeleteCommand = this.DbDeleteCommand2;
    this.daResPay.InsertCommand = this.DbInsertCommand2;
    this.daResPay.SelectCommand = this.DbSelectCommand2;
    this.daResPay.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblClaimResPaymentActivity", new DataColumnMapping[55]
      {
        new DataColumnMapping("PaymentID", "PaymentID"),
        new DataColumnMapping("ClaimID", "ClaimID"),
        new DataColumnMapping("OutIndRes", "OutIndRes"),
        new DataColumnMapping("OutLAERes", "OutLAERes"),
        new DataColumnMapping("OutLegalRes", "OutLegalRes"),
        new DataColumnMapping("DedRecovery", "DedRecovery"),
        new DataColumnMapping("Subrogation", "Subrogation"),
        new DataColumnMapping("Salvage", "Salvage"),
        new DataColumnMapping("OtherRecovery", "OtherRecovery"),
        new DataColumnMapping("MTDIndemnityPaid", "MTDIndemnityPaid"),
        new DataColumnMapping("IndemnityPTD", "IndemnityPTD"),
        new DataColumnMapping("MTDLAEPaid", "MTDLAEPaid"),
        new DataColumnMapping("LAEPTD", "LAEPTD"),
        new DataColumnMapping("MTDLegalPaid", "MTDLegalPaid"),
        new DataColumnMapping("LegalPTD", "LegalPTD"),
        new DataColumnMapping("MTDTPAExpPaid", "MTDTPAExpPaid"),
        new DataColumnMapping("TPAExpPTD", "TPAExpPTD"),
        new DataColumnMapping("TotalIncurred", "TotalIncurred"),
        new DataColumnMapping("CheckIssued", "CheckIssued"),
        new DataColumnMapping("OutMedRes", "OutMedRes"),
        new DataColumnMapping("MedicalPTD", "MedicalPTD"),
        new DataColumnMapping("RecType", "RecType"),
        new DataColumnMapping("TPAReserve", "TPAReserve"),
        new DataColumnMapping("BIPaid", "BIPaid"),
        new DataColumnMapping("BIReserve", "BIReserve"),
        new DataColumnMapping("PDPaid", "PDPaid"),
        new DataColumnMapping("PDReserve", "PDReserve"),
        new DataColumnMapping("GrossLoss", "GrossLoss"),
        new DataColumnMapping("ExpensePaid", "ExpensePaid"),
        new DataColumnMapping("ExpenseReserved", "ExpenseReserved"),
        new DataColumnMapping("DetailDescription", "DetailDescription"),
        new DataColumnMapping("LossStreet", "LossStreet"),
        new DataColumnMapping("LossCity", "LossCity"),
        new DataColumnMapping("LossState", "LossState"),
        new DataColumnMapping("LossZip", "LossZip"),
        new DataColumnMapping("Longitude", "Longitude"),
        new DataColumnMapping("Latitude", "Latitude"),
        new DataColumnMapping("Iso_Code", "Iso_Code"),
        new DataColumnMapping("Atc_Code", "Atc_Code"),
        new DataColumnMapping("Hail_Code", "Hail_Code"),
        new DataColumnMapping("Pc_Code", "Pc_Code"),
        new DataColumnMapping("Occupancy", "Occupancy"),
        new DataColumnMapping("Subsidized", "Subsidized"),
        new DataColumnMapping("Student_Senior", "Student_Senior"),
        new DataColumnMapping("Total_SqFt", "Total_SqFt"),
        new DataColumnMapping("Price_Per_Sqft", "Price_Per_Sqft"),
        new DataColumnMapping("Total_BV", "Total_BV"),
        new DataColumnMapping("Total_BBP", "Total_BBP"),
        new DataColumnMapping("Total_BI", "Total_BI"),
        new DataColumnMapping("Total_TIV", "Total_TIV"),
        new DataColumnMapping("Program_Deductible_Applied", "Program_Deductible_Applied"),
        new DataColumnMapping("Program_AOP", "Program_AOP"),
        new DataColumnMapping("Program_WindHail", "Program_WindHail"),
        new DataColumnMapping("Program_NS", "Program_NS"),
        new DataColumnMapping("Program_Notes", "Program_Notes")
      })
    });
    this.daResPay.UpdateCommand = this.DbUpdateCommand2;
    this.DbDeleteCommand2.CommandText = "DELETE FROM [dbo].[tblClaimResPaymentActivity] WHERE (([PaymentID] = @Original_PaymentID))";
    this.DbDeleteCommand2.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_PaymentID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PaymentID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand2.CommandText = componentResourceManager.GetString("DbInsertCommand2.CommandText");
    this.DbInsertCommand2.Parameters.AddRange((Array) new DbParameter[58]
    {
      DefaultDatabase.CreateParameter("@ClaimID", SqlDbType.Int, 4, "ClaimID"),
      DefaultDatabase.CreateParameter("@OutIndRes", SqlDbType.Money, 8, "OutIndRes"),
      DefaultDatabase.CreateParameter("@OutLAERes", SqlDbType.Money, 8, "OutLAERes"),
      DefaultDatabase.CreateParameter("@OutLegalRes", SqlDbType.Money, 8, "OutLegalRes"),
      DefaultDatabase.CreateParameter("@DedRecovery", SqlDbType.Money, 8, "DedRecovery"),
      DefaultDatabase.CreateParameter("@Subrogation", SqlDbType.Money, 8, "Subrogation"),
      DefaultDatabase.CreateParameter("@Salvage", SqlDbType.Money, 8, "Salvage"),
      DefaultDatabase.CreateParameter("@OtherRecovery", SqlDbType.Money, 8, "OtherRecovery"),
      DefaultDatabase.CreateParameter("@MTDIndemnityPaid", SqlDbType.Money, 8, "MTDIndemnityPaid"),
      DefaultDatabase.CreateParameter("@IndemnityPTD", SqlDbType.Money, 8, "IndemnityPTD"),
      DefaultDatabase.CreateParameter("@MTDLAEPaid", SqlDbType.Money, 8, "MTDLAEPaid"),
      DefaultDatabase.CreateParameter("@LAEPTD", SqlDbType.Money, 8, "LAEPTD"),
      DefaultDatabase.CreateParameter("@MTDLegalPaid", SqlDbType.Money, 8, "MTDLegalPaid"),
      DefaultDatabase.CreateParameter("@LegalPTD", SqlDbType.Money, 8, "LegalPTD"),
      DefaultDatabase.CreateParameter("@MTDTPAExpPaid", SqlDbType.Money, 8, "MTDTPAExpPaid"),
      DefaultDatabase.CreateParameter("@TPAExpPTD", SqlDbType.Money, 8, "TPAExpPTD"),
      DefaultDatabase.CreateParameter("@TotalIncurred", SqlDbType.Money, 8, "TotalIncurred"),
      DefaultDatabase.CreateParameter("@CheckIssued", SqlDbType.DateTime, 8, "CheckIssued"),
      DefaultDatabase.CreateParameter("@OutMedRes", SqlDbType.Money, 8, "OutMedRes"),
      DefaultDatabase.CreateParameter("@MedicalPTD", SqlDbType.Money, 8, "MedicalPTD"),
      DefaultDatabase.CreateParameter("@RecType", SqlDbType.VarChar, 20, "RecType"),
      DefaultDatabase.CreateParameter("@TPAReserve", SqlDbType.Money, 8, "TPAReserve"),
      DefaultDatabase.CreateParameter("@BIPaid", SqlDbType.Money, 8, "BIPaid"),
      DefaultDatabase.CreateParameter("@BIReserve", SqlDbType.Money, 8, "BIReserve"),
      DefaultDatabase.CreateParameter("@PDPaid", SqlDbType.Money, 8, "PDPaid"),
      DefaultDatabase.CreateParameter("@PDReserve", SqlDbType.Money, 8, "PDReserve"),
      DefaultDatabase.CreateParameter("@GrossLoss", SqlDbType.Money, 8, "GrossLoss"),
      DefaultDatabase.CreateParameter("@ExpensePaid", SqlDbType.Money, 8, "ExpensePaid"),
      DefaultDatabase.CreateParameter("@ExpenseReserved", SqlDbType.Money, 8, "ExpenseReserved"),
      DefaultDatabase.CreateParameter("@DetailDescription", SqlDbType.VarChar, 3000, "DetailDescription"),
      DefaultDatabase.CreateParameter("@LossStreet", SqlDbType.VarChar, 100, "LossStreet"),
      DefaultDatabase.CreateParameter("@LossCity", SqlDbType.VarChar, 100, "LossCity"),
      DefaultDatabase.CreateParameter("@LossState", SqlDbType.VarChar, 2, "LossState"),
      DefaultDatabase.CreateParameter("@LossZip", SqlDbType.VarChar, 15, "LossZip"),
      DefaultDatabase.CreateParameter("@Longitude", SqlDbType.VarChar, 15, "Longitude"),
      DefaultDatabase.CreateParameter("@Latitude", SqlDbType.VarChar, 15, "Latitude"),
      DefaultDatabase.CreateParameter("@Iso_Code", SqlDbType.Int, 4, "Iso_Code"),
      DefaultDatabase.CreateParameter("@Atc_Code", SqlDbType.Int, 4, "Atc_Code"),
      DefaultDatabase.CreateParameter("@Hail_Code", SqlDbType.Int, 4, "Hail_Code"),
      DefaultDatabase.CreateParameter("@Pc_Code", SqlDbType.Int, 4, "Pc_Code"),
      DefaultDatabase.CreateParameter("@Occupancy", SqlDbType.Money, 8, "Occupancy"),
      DefaultDatabase.CreateParameter("@Subsidized", SqlDbType.Money, 8, "Subsidized"),
      DefaultDatabase.CreateParameter("@Student_Senior", SqlDbType.Money, 8, "Student_Senior"),
      DefaultDatabase.CreateParameter("@Total_SqFt", SqlDbType.Int, 4, "Total_SqFt"),
      DefaultDatabase.CreateParameter("@Price_Per_Sqft", SqlDbType.Int, 4, "Price_Per_Sqft"),
      DefaultDatabase.CreateParameter("@Total_BV", SqlDbType.Money, 8, "Total_BV"),
      DefaultDatabase.CreateParameter("@Total_BBP", SqlDbType.Money, 8, "Total_BBP"),
      DefaultDatabase.CreateParameter("@Total_BI", SqlDbType.Money, 8, "Total_BI"),
      DefaultDatabase.CreateParameter("@Total_TIV", SqlDbType.Money, 8, "Total_TIV"),
      DefaultDatabase.CreateParameter("@Program_Deductible_Applied", SqlDbType.Money, 8, "Program_Deductible_Applied"),
      DefaultDatabase.CreateParameter("@Program_AOP", SqlDbType.Money, 8, "Program_AOP"),
      DefaultDatabase.CreateParameter("@Program_WindHail", SqlDbType.Money, 8, "Program_WindHail"),
      DefaultDatabase.CreateParameter("@Program_NS", SqlDbType.Money, 8, "Program_NS"),
      DefaultDatabase.CreateParameter("@Program_Notes", SqlDbType.VarChar, 2000, "Program_Notes"),
      DefaultDatabase.CreateParameter("@BusIntReserve", SqlDbType.Money, 8, "BusIntReserve"),
      DefaultDatabase.CreateParameter("@ContingentBIReserve", SqlDbType.Money, 8, "ContingentBIReserve"),
      DefaultDatabase.CreateParameter("@BusIntPaid", SqlDbType.Money, 8, "BusIntPaid"),
      DefaultDatabase.CreateParameter("@ContingentBIPaid", SqlDbType.Money, 8, "ContingentBIPaid")
    });
    this.DbSelectCommand2.CommandText = componentResourceManager.GetString("DbSelectCommand2.CommandText");
    this.DbSelectCommand2.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@ClaimID", SqlDbType.Int, 4, "ClaimID")
    });
    this.DbUpdateCommand2.CommandText = componentResourceManager.GetString("DbUpdateCommand2.CommandText");
    this.DbUpdateCommand2.Parameters.AddRange((Array) new DbParameter[60]
    {
      DefaultDatabase.CreateParameter("@ClaimID", SqlDbType.Int, 4, "ClaimID"),
      DefaultDatabase.CreateParameter("@OutIndRes", SqlDbType.Money, 8, "OutIndRes"),
      DefaultDatabase.CreateParameter("@OutLAERes", SqlDbType.Money, 8, "OutLAERes"),
      DefaultDatabase.CreateParameter("@OutLegalRes", SqlDbType.Money, 8, "OutLegalRes"),
      DefaultDatabase.CreateParameter("@DedRecovery", SqlDbType.Money, 8, "DedRecovery"),
      DefaultDatabase.CreateParameter("@Subrogation", SqlDbType.Money, 8, "Subrogation"),
      DefaultDatabase.CreateParameter("@Salvage", SqlDbType.Money, 8, "Salvage"),
      DefaultDatabase.CreateParameter("@OtherRecovery", SqlDbType.Money, 8, "OtherRecovery"),
      DefaultDatabase.CreateParameter("@MTDIndemnityPaid", SqlDbType.Money, 8, "MTDIndemnityPaid"),
      DefaultDatabase.CreateParameter("@IndemnityPTD", SqlDbType.Money, 8, "IndemnityPTD"),
      DefaultDatabase.CreateParameter("@MTDLAEPaid", SqlDbType.Money, 8, "MTDLAEPaid"),
      DefaultDatabase.CreateParameter("@LAEPTD", SqlDbType.Money, 8, "LAEPTD"),
      DefaultDatabase.CreateParameter("@MTDLegalPaid", SqlDbType.Money, 8, "MTDLegalPaid"),
      DefaultDatabase.CreateParameter("@LegalPTD", SqlDbType.Money, 8, "LegalPTD"),
      DefaultDatabase.CreateParameter("@MTDTPAExpPaid", SqlDbType.Money, 8, "MTDTPAExpPaid"),
      DefaultDatabase.CreateParameter("@TPAExpPTD", SqlDbType.Money, 8, "TPAExpPTD"),
      DefaultDatabase.CreateParameter("@TotalIncurred", SqlDbType.Money, 8, "TotalIncurred"),
      DefaultDatabase.CreateParameter("@CheckIssued", SqlDbType.DateTime, 8, "CheckIssued"),
      DefaultDatabase.CreateParameter("@OutMedRes", SqlDbType.Money, 8, "OutMedRes"),
      DefaultDatabase.CreateParameter("@MedicalPTD", SqlDbType.Money, 8, "MedicalPTD"),
      DefaultDatabase.CreateParameter("@RecType", SqlDbType.VarChar, 20, "RecType"),
      DefaultDatabase.CreateParameter("@TPAReserve", SqlDbType.Money, 8, "TPAReserve"),
      DefaultDatabase.CreateParameter("@BIPaid", SqlDbType.Money, 8, "BIPaid"),
      DefaultDatabase.CreateParameter("@BIReserve", SqlDbType.Money, 8, "BIReserve"),
      DefaultDatabase.CreateParameter("@PDPaid", SqlDbType.Money, 8, "PDPaid"),
      DefaultDatabase.CreateParameter("@PDReserve", SqlDbType.Money, 8, "PDReserve"),
      DefaultDatabase.CreateParameter("@GrossLoss", SqlDbType.Money, 8, "GrossLoss"),
      DefaultDatabase.CreateParameter("@ExpensePaid", SqlDbType.Money, 8, "ExpensePaid"),
      DefaultDatabase.CreateParameter("@ExpenseReserved", SqlDbType.Money, 8, "ExpenseReserved"),
      DefaultDatabase.CreateParameter("@DetailDescription", SqlDbType.VarChar, 3000, "DetailDescription"),
      DefaultDatabase.CreateParameter("@LossStreet", SqlDbType.VarChar, 100, "LossStreet"),
      DefaultDatabase.CreateParameter("@LossCity", SqlDbType.VarChar, 100, "LossCity"),
      DefaultDatabase.CreateParameter("@LossState", SqlDbType.VarChar, 2, "LossState"),
      DefaultDatabase.CreateParameter("@LossZip", SqlDbType.VarChar, 15, "LossZip"),
      DefaultDatabase.CreateParameter("@Longitude", SqlDbType.VarChar, 15, "Longitude"),
      DefaultDatabase.CreateParameter("@Latitude", SqlDbType.VarChar, 15, "Latitude"),
      DefaultDatabase.CreateParameter("@Iso_Code", SqlDbType.Int, 4, "Iso_Code"),
      DefaultDatabase.CreateParameter("@Atc_Code", SqlDbType.Int, 4, "Atc_Code"),
      DefaultDatabase.CreateParameter("@Hail_Code", SqlDbType.Int, 4, "Hail_Code"),
      DefaultDatabase.CreateParameter("@Pc_Code", SqlDbType.Int, 4, "Pc_Code"),
      DefaultDatabase.CreateParameter("@Occupancy", SqlDbType.Money, 8, "Occupancy"),
      DefaultDatabase.CreateParameter("@Subsidized", SqlDbType.Money, 8, "Subsidized"),
      DefaultDatabase.CreateParameter("@Student_Senior", SqlDbType.Money, 8, "Student_Senior"),
      DefaultDatabase.CreateParameter("@Total_SqFt", SqlDbType.Int, 4, "Total_SqFt"),
      DefaultDatabase.CreateParameter("@Price_Per_Sqft", SqlDbType.Int, 4, "Price_Per_Sqft"),
      DefaultDatabase.CreateParameter("@Total_BV", SqlDbType.Money, 8, "Total_BV"),
      DefaultDatabase.CreateParameter("@Total_BBP", SqlDbType.Money, 8, "Total_BBP"),
      DefaultDatabase.CreateParameter("@Total_BI", SqlDbType.Money, 8, "Total_BI"),
      DefaultDatabase.CreateParameter("@Total_TIV", SqlDbType.Money, 8, "Total_TIV"),
      DefaultDatabase.CreateParameter("@Program_Deductible_Applied", SqlDbType.Money, 8, "Program_Deductible_Applied"),
      DefaultDatabase.CreateParameter("@Program_AOP", SqlDbType.Money, 8, "Program_AOP"),
      DefaultDatabase.CreateParameter("@Program_WindHail", SqlDbType.Money, 8, "Program_WindHail"),
      DefaultDatabase.CreateParameter("@Program_NS", SqlDbType.Money, 8, "Program_NS"),
      DefaultDatabase.CreateParameter("@Program_Notes", SqlDbType.VarChar, 2000, "Program_Notes"),
      DefaultDatabase.CreateParameter("@BusIntReserve", SqlDbType.Money, 8, "BusIntReserve"),
      DefaultDatabase.CreateParameter("@ContingentBIReserve", SqlDbType.Money, 8, "ContingentBIReserve"),
      DefaultDatabase.CreateParameter("@BusIntPaid", SqlDbType.Money, 8, "BusIntPaid"),
      DefaultDatabase.CreateParameter("@ContingentBIPaid", SqlDbType.Money, 8, "ContingentBIPaid"),
      DefaultDatabase.CreateParameter("@Original_PaymentID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PaymentID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@PaymentID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PaymentID", DataRowVersion.Original, (object) null)
    });
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(879, 394);
    ((Control) this.MgaTab1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance126.BackColor = Color.Transparent;
    ((UltraTabControlBase) this.MgaTab1).Appearance = (AppearanceBase) appearance126;
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.MgaTab1).Controls.Add((Control) this.tabAdditionalReservesPayments);
    ((Control) this.MgaTab1).Location = new Point(5, 309);
    ((Control) this.MgaTab1).Name = "MgaTab1";
    appearance127.BackColor = Color.WhiteSmoke;
    appearance127.BorderColor = Color.Gray;
    ((UltraTabControlBase) this.MgaTab1).SelectedTabAppearance = (AppearanceBase) appearance127;
    ((UltraTabControlBase) this.MgaTab1).SharedControls.AddRange(new Control[1]
    {
      (Control) this.dbSave
    });
    ((UltraTabControlBase) this.MgaTab1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.MgaTab1).Size = new Size(881, 425);
    ((UltraTabControlBase) this.MgaTab1).Style = (UltraTabControlStyle) 13;
    ((Control) this.MgaTab1).TabIndex = 0;
    ((UltraTabControlBase) this.MgaTab1).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.MgaTab1).TabPadding = new Size(10, 5);
    appearance128.BackColor = Color.White;
    ultraTab1.ActiveAppearance = (AppearanceBase) appearance128;
    ultraTab1.Key = "tabClaimInfo";
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Claim Information";
    ultraTab2.TabPage = this.UltraTabPageControl3;
    ultraTab2.Text = "Add'l Claimaint Info";
    appearance129.BackColor = Color.White;
    ultraTab3.ActiveAppearance = (AppearanceBase) appearance129;
    ultraTab3.Key = "tabResPay";
    ultraTab3.TabPage = this.UltraTabPageControl2;
    ultraTab3.Text = "Reserves/Payments";
    ultraTab4.TabPage = this.tabAdditionalReservesPayments;
    ultraTab4.Text = "Add'l Reserves/Payments";
    ((UltraTabControlBase) this.MgaTab1).Tabs.AddRange(new UltraTab[4]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4
    });
    ((UltraControlBase) this.MgaTab1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTab1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTabControlBase) this.MgaTab1).ViewStyle = (ViewStyle) 4;
    ((Control) this.gridClaims).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridClaims).DataSource = (object) this.ds.tblClaimInformation;
    appearance130.BackColor = Color.White;
    appearance130.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaims).DisplayLayout.Appearance = (AppearanceBase) appearance130;
    ((UltraGridBase) this.gridClaims).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 25;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 50;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Claim #";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 72;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Format = "d";
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Reported";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 79;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Format = "d";
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Loss";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 50;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Loss Type";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 68;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 50;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.Format = "d";
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Closed";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 52;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Litigation";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Width = 53;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Injury";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 78;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "CAT #";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Width = 60;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Read Only";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn12.Width = 56;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Date Received";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Width = 56;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 44;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 52;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 53;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 72;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 54;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 18;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 85;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 19;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 44;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 20;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 56;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 21;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 55;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 22;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 65;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 23;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 68;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 24;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 66;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 25;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 71;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 26;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 75;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 27;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 73;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 28;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 92;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 29;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 82;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 30;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 21;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 22;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 32 /*0x20*/;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn33.Width = 23;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 33;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 23;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 34;
    ultraGridColumn35.Hidden = true;
    ultraGridColumn35.Width = 101;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 35;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 113;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 36;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn37.Width = 23;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 37;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 23;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 38;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 23;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 39;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 14;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 40;
    ultraGridColumn41.Hidden = true;
    ultraGridColumn41.Width = 88;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 41;
    ultraGridColumn42.Width = 78;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 42;
    ultraGridColumn43.Hidden = true;
    ultraGridColumn43.Width = 72;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 43;
    ultraGridColumn44.Hidden = true;
    ultraGridColumn44.Width = 89;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 44;
    ultraGridColumn45.Hidden = true;
    ultraGridColumn45.Width = 66;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 45;
    ultraGridColumn46.Hidden = true;
    ultraGridColumn46.Width = 67;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 47;
    ultraGridColumn47.Width = 78;
    ((HeaderBase) ultraGridColumn48.Header).Caption = "Last Claim Updated";
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 46;
    ultraGridColumn48.Width = 91;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 48 /*0x30*/;
    ultraGridColumn49.Hidden = true;
    ultraGridColumn49.Width = 89;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 49;
    ultraGridColumn50.Hidden = true;
    ultraGridColumn50.Width = 91;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 50;
    ultraGridColumn51.Hidden = true;
    ultraGridColumn51.Width = 99;
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 51;
    ultraGridColumn52.Hidden = true;
    ultraGridColumn52.Width = 74;
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 52;
    ultraGridColumn53.Hidden = true;
    ultraGridColumn53.Width = 67;
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Header.VisiblePosition = 53;
    ultraGridColumn54.Hidden = true;
    ultraGridColumn54.Width = 88;
    ultraGridColumn55.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Header.VisiblePosition = 54;
    ultraGridBand1.Columns.AddRange(new object[55]
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
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48,
      (object) ultraGridColumn49,
      (object) ultraGridColumn50,
      (object) ultraGridColumn51,
      (object) ultraGridColumn52,
      (object) ultraGridColumn53,
      (object) ultraGridColumn54,
      (object) ultraGridColumn55
    });
    ultraGridBand2.CardSettings.CardScrollbars = (CardScrollbars) 0;
    ultraGridBand2.CardSettings.ShowCaption = false;
    ultraGridBand2.CardView = true;
    ultraGridColumn56.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn56.Header.VisiblePosition = 0;
    ultraGridColumn56.Hidden = true;
    ultraGridColumn56.Width = 29;
    ultraGridColumn57.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.Header.VisiblePosition = 1;
    ultraGridColumn57.Hidden = true;
    ultraGridColumn57.Width = 45;
    ultraGridColumn58.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn58.Format = "c";
    ((HeaderBase) ultraGridColumn58.Header).Caption = "Out. Indemnity Reseserve";
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.Header.VisiblePosition = 4;
    ultraGridColumn58.Width = 55;
    ultraGridColumn59.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn59.Format = "c";
    ((HeaderBase) ultraGridColumn59.Header).Caption = "Out. LAE Reseserve";
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn59.Header.VisiblePosition = 3;
    ultraGridColumn59.Width = 51;
    ultraGridColumn60.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn60.Format = "c";
    ((HeaderBase) ultraGridColumn60.Header).Caption = "Out. Legal Reseserve";
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn60.Header.VisiblePosition = 5;
    ultraGridColumn60.Width = 51;
    ultraGridColumn61.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn61.Format = "c";
    ((HeaderBase) ultraGridColumn61.Header).Caption = "Deductible Recovery";
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn61.Header.VisiblePosition = 6;
    ultraGridColumn61.Width = 54;
    ultraGridColumn62.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn62.Format = "c";
    ((HeaderBase) ultraGridColumn62.Header).Caption = "Subrogation Recovery";
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn62.Header.VisiblePosition = 7;
    ultraGridColumn62.Width = 51;
    ultraGridColumn63.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn63.Format = "c";
    ((HeaderBase) ultraGridColumn63.Header).Caption = "Salvage Recovery";
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn63.Header.VisiblePosition = 8;
    ultraGridColumn63.Width = 51;
    ultraGridColumn64.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn64.Format = "c";
    ((HeaderBase) ultraGridColumn64.Header).Caption = "Other Recovery";
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn64.Header.VisiblePosition = 9;
    ultraGridColumn64.Width = 58;
    ultraGridColumn65.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn65.Format = "c";
    ((HeaderBase) ultraGridColumn65.Header).Caption = "MTD Indemnity Paid";
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn65.Header.VisiblePosition = 10;
    ultraGridColumn65.Width = 71;
    ultraGridColumn66.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn66.Format = "c";
    ((HeaderBase) ultraGridColumn66.Header).Caption = "Indemnity Paid to Date";
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn66.Header.VisiblePosition = 11;
    ultraGridColumn66.Width = 55;
    ultraGridColumn67.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn67.Format = "c";
    ((HeaderBase) ultraGridColumn67.Header).Caption = "MTD LAE Paid";
    ((HeaderBase) ultraGridColumn67.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn67.Header.VisiblePosition = 12;
    ultraGridColumn67.Width = 54;
    ultraGridColumn68.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn68.Format = "c";
    ((HeaderBase) ultraGridColumn68.Header).Caption = "LAE Paid to Date";
    ((HeaderBase) ultraGridColumn68.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn68.Header.VisiblePosition = 13;
    ultraGridColumn68.Width = 51;
    ultraGridColumn69.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn69.Format = "c";
    ((HeaderBase) ultraGridColumn69.Header).Caption = "MTD Legal Paid";
    ((HeaderBase) ultraGridColumn69.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn69.Header.VisiblePosition = 14;
    ultraGridColumn69.Width = 57;
    ultraGridColumn70.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn70.Format = "c";
    ((HeaderBase) ultraGridColumn70.Header).Caption = "Legal Paid to Date";
    ((HeaderBase) ultraGridColumn70.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn70.Header.VisiblePosition = 15;
    ultraGridColumn70.Width = 51;
    ultraGridColumn71.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn71.Format = "c";
    ((HeaderBase) ultraGridColumn71.Header).Caption = "MTD TPA Expenses Paid";
    ((HeaderBase) ultraGridColumn71.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn71.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn71.Width = 66;
    ultraGridColumn72.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn72.Format = "c";
    ((HeaderBase) ultraGridColumn72.Header).Caption = "TPA Expenses Paid to Date";
    ((HeaderBase) ultraGridColumn72.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn72.Header.VisiblePosition = 17;
    ultraGridColumn72.Width = 51;
    ultraGridColumn73.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance131.FontData.BoldAsString = "True";
    appearance131.ForeColor = Color.Red;
    ultraGridColumn73.CellAppearance = (AppearanceBase) appearance131;
    ultraGridColumn73.Format = "c";
    appearance132.FontData.BoldAsString = "True";
    appearance132.ForeColor = Color.Red;
    ((HeaderBase) ultraGridColumn73.Header).Appearance = (AppearanceBase) appearance132;
    ((HeaderBase) ultraGridColumn73.Header).Caption = "Total Incurred";
    ((HeaderBase) ultraGridColumn73.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn73.Header.VisiblePosition = 32 /*0x20*/;
    ultraGridColumn73.Width = 52;
    ultraGridColumn74.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn74.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn74.Header.VisiblePosition = 18;
    ultraGridColumn75.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn75.Header).Caption = "Recovery Type";
    ((HeaderBase) ultraGridColumn75.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn75.Header.VisiblePosition = 2;
    ultraGridColumn76.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn76.Format = "c";
    ((HeaderBase) ultraGridColumn76.Header).Caption = "Medical Reserves";
    ((HeaderBase) ultraGridColumn76.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn76.Header.VisiblePosition = 19;
    ultraGridColumn77.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn77.Format = "c";
    ((HeaderBase) ultraGridColumn77.Header).Caption = "Medical Paid";
    ((HeaderBase) ultraGridColumn77.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn77.Header.VisiblePosition = 20;
    ultraGridColumn78.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn78.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn78.Header.VisiblePosition = 23;
    ultraGridColumn78.Hidden = true;
    ultraGridColumn79.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn79.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn79.Header.VisiblePosition = 24;
    ultraGridColumn79.Hidden = true;
    ultraGridColumn80.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn80.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn80.Header.VisiblePosition = 25;
    ultraGridColumn80.Hidden = true;
    ultraGridColumn81.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn81.Format = "c";
    ((HeaderBase) ultraGridColumn81.Header).Caption = "Total Recovery";
    ((HeaderBase) ultraGridColumn81.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn81.Header.VisiblePosition = 22;
    ultraGridColumn82.Format = "c";
    ((HeaderBase) ultraGridColumn82.Header).Caption = "TPA Reserve";
    ((HeaderBase) ultraGridColumn82.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn82.Header.VisiblePosition = 21;
    ultraGridColumn83.Format = "c";
    ((HeaderBase) ultraGridColumn83.Header).Caption = "BI Paid";
    ((HeaderBase) ultraGridColumn83.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn83.Header.VisiblePosition = 26;
    ultraGridColumn84.Format = "c";
    ((HeaderBase) ultraGridColumn84.Header).Caption = "BI Reserve";
    ((HeaderBase) ultraGridColumn84.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn84.Header.VisiblePosition = 27;
    ultraGridColumn85.Format = "c";
    ((HeaderBase) ultraGridColumn85.Header).Caption = "PD Paid";
    ((HeaderBase) ultraGridColumn85.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn85.Header.VisiblePosition = 28;
    ultraGridColumn86.Format = "c";
    ((HeaderBase) ultraGridColumn86.Header).Caption = "PD Reserve";
    ((HeaderBase) ultraGridColumn86.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn86.Header.VisiblePosition = 29;
    ultraGridColumn87.Format = "c";
    ((HeaderBase) ultraGridColumn87.Header).Caption = "Gross Loss";
    ((HeaderBase) ultraGridColumn87.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn87.Header.VisiblePosition = 30;
    ultraGridColumn88.Format = "c";
    ((HeaderBase) ultraGridColumn88.Header).Caption = "Expense Paid";
    ((HeaderBase) ultraGridColumn88.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn88.Header.VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn88.Hidden = true;
    ((HeaderBase) ultraGridColumn89.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn89.Header.VisiblePosition = 33;
    ultraGridColumn89.Hidden = true;
    ((HeaderBase) ultraGridColumn90.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn90.Header.VisiblePosition = 34;
    ultraGridColumn90.Hidden = true;
    ((HeaderBase) ultraGridColumn91.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn91.Header.VisiblePosition = 35;
    ultraGridColumn91.Hidden = true;
    ((HeaderBase) ultraGridColumn92.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn92.Header.VisiblePosition = 36;
    ultraGridColumn92.Hidden = true;
    ((HeaderBase) ultraGridColumn93.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn93.Header.VisiblePosition = 37;
    ultraGridColumn93.Hidden = true;
    ((HeaderBase) ultraGridColumn94.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn94.Header.VisiblePosition = 38;
    ultraGridColumn94.Hidden = true;
    ((HeaderBase) ultraGridColumn95.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn95.Header.VisiblePosition = 39;
    ultraGridColumn95.Hidden = true;
    ((HeaderBase) ultraGridColumn96.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn96.Header.VisiblePosition = 40;
    ultraGridColumn96.Hidden = true;
    ((HeaderBase) ultraGridColumn97.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn97.Header.VisiblePosition = 41;
    ultraGridColumn97.Hidden = true;
    ((HeaderBase) ultraGridColumn98.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn98.Header.VisiblePosition = 42;
    ultraGridColumn98.Hidden = true;
    ((HeaderBase) ultraGridColumn99.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn99.Header.VisiblePosition = 43;
    ultraGridColumn99.Hidden = true;
    ((HeaderBase) ultraGridColumn100.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn100.Header.VisiblePosition = 44;
    ultraGridColumn100.Hidden = true;
    ((HeaderBase) ultraGridColumn101.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn101.Header.VisiblePosition = 45;
    ultraGridColumn101.Hidden = true;
    ((HeaderBase) ultraGridColumn102.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn102.Header.VisiblePosition = 46;
    ultraGridColumn102.Hidden = true;
    ((HeaderBase) ultraGridColumn103.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn103.Header.VisiblePosition = 47;
    ultraGridColumn103.Hidden = true;
    ((HeaderBase) ultraGridColumn104.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn104.Header.VisiblePosition = 48 /*0x30*/;
    ultraGridColumn104.Hidden = true;
    ((HeaderBase) ultraGridColumn105.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn105.Header.VisiblePosition = 49;
    ultraGridColumn105.Hidden = true;
    ((HeaderBase) ultraGridColumn106.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn106.Header.VisiblePosition = 50;
    ultraGridColumn106.Hidden = true;
    ((HeaderBase) ultraGridColumn107.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn107.Header.VisiblePosition = 51;
    ultraGridColumn107.Hidden = true;
    ((HeaderBase) ultraGridColumn108.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn108.Header.VisiblePosition = 52;
    ultraGridColumn108.Hidden = true;
    ((HeaderBase) ultraGridColumn109.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn109.Header.VisiblePosition = 53;
    ultraGridColumn109.Hidden = true;
    ((HeaderBase) ultraGridColumn110.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn110.Header.VisiblePosition = 54;
    ultraGridColumn110.Hidden = true;
    ((HeaderBase) ultraGridColumn111.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn111.Header.VisiblePosition = 55;
    ultraGridColumn111.Hidden = true;
    ((HeaderBase) ultraGridColumn112.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn112.Header.VisiblePosition = 56;
    ultraGridColumn112.Hidden = true;
    ((HeaderBase) ultraGridColumn113.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn113.Header.VisiblePosition = 57;
    ultraGridColumn113.Hidden = true;
    ((HeaderBase) ultraGridColumn114.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn114.Header.VisiblePosition = 58;
    ultraGridColumn114.Hidden = true;
    ((HeaderBase) ultraGridColumn115.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn115.Header.VisiblePosition = 59;
    ultraGridColumn115.Hidden = true;
    ((HeaderBase) ultraGridColumn116.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn116.Header.VisiblePosition = 60;
    ultraGridColumn116.Hidden = true;
    ((HeaderBase) ultraGridColumn117.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn117.Header.VisiblePosition = 61;
    ultraGridColumn117.Hidden = true;
    ((HeaderBase) ultraGridColumn118.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn118.Header.VisiblePosition = 62;
    ultraGridColumn118.Hidden = true;
    ((HeaderBase) ultraGridColumn119.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn119.Header.VisiblePosition = 63 /*0x3F*/;
    ultraGridColumn119.Hidden = true;
    ultraGridBand2.Columns.AddRange(new object[64 /*0x40*/]
    {
      (object) ultraGridColumn56,
      (object) ultraGridColumn57,
      (object) ultraGridColumn58,
      (object) ultraGridColumn59,
      (object) ultraGridColumn60,
      (object) ultraGridColumn61,
      (object) ultraGridColumn62,
      (object) ultraGridColumn63,
      (object) ultraGridColumn64,
      (object) ultraGridColumn65,
      (object) ultraGridColumn66,
      (object) ultraGridColumn67,
      (object) ultraGridColumn68,
      (object) ultraGridColumn69,
      (object) ultraGridColumn70,
      (object) ultraGridColumn71,
      (object) ultraGridColumn72,
      (object) ultraGridColumn73,
      (object) ultraGridColumn74,
      (object) ultraGridColumn75,
      (object) ultraGridColumn76,
      (object) ultraGridColumn77,
      (object) ultraGridColumn78,
      (object) ultraGridColumn79,
      (object) ultraGridColumn80,
      (object) ultraGridColumn81,
      (object) ultraGridColumn82,
      (object) ultraGridColumn83,
      (object) ultraGridColumn84,
      (object) ultraGridColumn85,
      (object) ultraGridColumn86,
      (object) ultraGridColumn87,
      (object) ultraGridColumn88,
      (object) ultraGridColumn89,
      (object) ultraGridColumn90,
      (object) ultraGridColumn91,
      (object) ultraGridColumn92,
      (object) ultraGridColumn93,
      (object) ultraGridColumn94,
      (object) ultraGridColumn95,
      (object) ultraGridColumn96,
      (object) ultraGridColumn97,
      (object) ultraGridColumn98,
      (object) ultraGridColumn99,
      (object) ultraGridColumn100,
      (object) ultraGridColumn101,
      (object) ultraGridColumn102,
      (object) ultraGridColumn103,
      (object) ultraGridColumn104,
      (object) ultraGridColumn105,
      (object) ultraGridColumn106,
      (object) ultraGridColumn107,
      (object) ultraGridColumn108,
      (object) ultraGridColumn109,
      (object) ultraGridColumn110,
      (object) ultraGridColumn111,
      (object) ultraGridColumn112,
      (object) ultraGridColumn113,
      (object) ultraGridColumn114,
      (object) ultraGridColumn115,
      (object) ultraGridColumn116,
      (object) ultraGridColumn117,
      (object) ultraGridColumn118,
      (object) ultraGridColumn119
    });
    appearance133.BackColor = Color.White;
    ultraGridBand2.Override.CardAreaAppearance = (AppearanceBase) appearance133;
    ultraGridBand2.Override.CardSpacing = 1;
    appearance134.BackColor = Color.FromArgb(246, 250, 253);
    ultraGridBand2.Override.CellAppearance = (AppearanceBase) appearance134;
    ultraGridBand2.Override.CellPadding = 1;
    ultraGridBand2.Override.CellSpacing = 0;
    appearance135.BackColor = Color.White;
    ultraGridBand2.Override.HeaderAppearance = (AppearanceBase) appearance135;
    ((UltraGridBase) this.gridClaims).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridClaims).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridClaims).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance136.BackColor = Color.LightSteelBlue;
    appearance136.FontData.SizeInPoints = 10f;
    appearance136.ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaims).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance136;
    appearance137.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance137.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance137.ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance137;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance138.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance138;
    appearance139.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance139;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance140.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance140;
    appearance141.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance141;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance142.BackColor = Color.Transparent;
    appearance142.ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance142;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridClaims).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridClaims).Location = new Point(5, 8);
    ((Control) this.gridClaims).Name = "gridClaims";
    ((Control) this.gridClaims).Size = new Size(881, 295);
    ((Control) this.gridClaims).TabIndex = 6;
    ((Control) this.gridClaims).Text = "Claim Information - Policy #";
    ((UltraControlBase) this.gridClaims).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridClaims).UseOsThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(894, 738);
    this.Controls.Add((Control) this.MgaTab1);
    this.Controls.Add((Control) this.gridClaims);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmClaims);
    this.Text = "Claims";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.dtClaimUpdated).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.MgaTxtComments).EndInit();
    ((ISupportInitialize) this.MgaTextBox25).EndInit();
    ((ISupportInitialize) this.MgaTextBox24).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor14).EndInit();
    ((ISupportInitialize) this.MgaTextBox8).EndInit();
    ((ISupportInitialize) this.MgaCheckBox1).EndInit();
    ((ISupportInitialize) this.MgaTextBox7).EndInit();
    ((ISupportInitialize) this.MgaTextBox6).EndInit();
    ((ISupportInitialize) this.MgaTextBox5).EndInit();
    ((ISupportInitialize) this.MgaTextBox2).EndInit();
    ((ISupportInitialize) this.MgaTextBox1).EndInit();
    ((ISupportInitialize) this.MgaDateTimePicker1).EndInit();
    ((ISupportInitialize) this.MgaDateTimePicker3).EndInit();
    ((ISupportInitialize) this.txtStatus).EndInit();
    ((ISupportInitialize) this.txtLossType).EndInit();
    ((ISupportInitialize) this.dtDateOfLoss).EndInit();
    ((ISupportInitialize) this.dtReported).EndInit();
    ((ISupportInitialize) this.txtClaimNum).EndInit();
    ((ISupportInitialize) this.MgaTextBox4).EndInit();
    ((ISupportInitialize) this.MgaTextBox3).EndInit();
    ((ISupportInitialize) this.CheckBox1).EndInit();
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).PerformLayout();
    ((ISupportInitialize) this.txtWatchList).EndInit();
    ((ISupportInitialize) this.numLimit).EndInit();
    ((ISupportInitialize) this.numTotalPaid).EndInit();
    ((ISupportInitialize) this.txtCAT_Name_Details).EndInit();
    ((ISupportInitialize) this.numAdjCaseReserves).EndInit();
    ((ISupportInitialize) this.txtBodyPart).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor24).EndInit();
    ((ISupportInitialize) this.MgaDateTimePicker10).EndInit();
    ((ISupportInitialize) this.MgaDateTimePicker9).EndInit();
    ((ISupportInitialize) this.MgaDateTimePicker8).EndInit();
    ((ISupportInitialize) this.MgaTextBox26).EndInit();
    ((ISupportInitialize) this.MgaTextBox22).EndInit();
    ((ISupportInitialize) this.MgaTextBox21).EndInit();
    ((ISupportInitialize) this.MgaTextBox20).EndInit();
    ((ISupportInitialize) this.MgaTextBox19).EndInit();
    ((ISupportInitialize) this.MgaTextBox18).EndInit();
    ((ISupportInitialize) this.MgaTextBox17).EndInit();
    ((ISupportInitialize) this.MgaTextBox16).EndInit();
    ((ISupportInitialize) this.MgaTextBox15).EndInit();
    ((ISupportInitialize) this.MgaDateTimePicker7).EndInit();
    ((ISupportInitialize) this.MgaDateTimePicker6).EndInit();
    ((ISupportInitialize) this.MgaDateTimePicker5).EndInit();
    ((ISupportInitialize) this.MgaTextBox14).EndInit();
    ((ISupportInitialize) this.MgaDateTimePicker4).EndInit();
    ((ISupportInitialize) this.MgaTextBox13).EndInit();
    ((ISupportInitialize) this.MgaTextBox12).EndInit();
    ((ISupportInitialize) this.MgaTextBox11).EndInit();
    ((ISupportInitialize) this.MgaTextBox10).EndInit();
    ((ISupportInitialize) this.MgaTextBox9).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.numContingentBIPaid).EndInit();
    ((ISupportInitialize) this.numBusIntPaid).EndInit();
    ((ISupportInitialize) this.numContingentBIReserve).EndInit();
    ((ISupportInitialize) this.numBusIntReserve).EndInit();
    ((ISupportInitialize) this.numTPAExpPTD).EndInit();
    ((ISupportInitialize) this.dtDateCreated).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.txtLatitude).EndInit();
    ((ISupportInitialize) this.txtLongitude).EndInit();
    ((ISupportInitialize) this.txtLossZip).EndInit();
    ((ISupportInitialize) this.txtLossCity).EndInit();
    ((ISupportInitialize) this.txtLossStreet).EndInit();
    ((ISupportInitialize) this.numExpenseReserved).EndInit();
    ((ISupportInitialize) this.numExpensePaid).EndInit();
    ((ISupportInitialize) this.numGrossLoss).EndInit();
    ((ISupportInitialize) this.numMTDTPAExpPaid).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor25).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor23).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor22).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor21).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor20).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor19).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor18).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor17).EndInit();
    ((ISupportInitialize) this.dtValueDate).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor16).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor15).EndInit();
    ((ISupportInitialize) this.MgaTextBox23).EndInit();
    ((ISupportInitialize) this.MgaDateTimePicker2).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor11).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor12).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor13).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor10).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor9).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor8).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor7).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor6).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor5).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor4).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor3).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor2).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor1).EndInit();
    ((Control) this.tabAdditionalReservesPayments).ResumeLayout(false);
    ((Control) this.tabAdditionalReservesPayments).PerformLayout();
    ((ISupportInitialize) this.MgaTextBox27).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor42).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor41).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor40).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor39).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor38).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor37).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor36).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor34).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor35).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor33).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor32).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor30).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor31).EndInit();
    ((ISupportInitialize) this.MgaNumericEditor29).EndInit();
    ((ISupportInitialize) this.numHailCode).EndInit();
    ((ISupportInitialize) this.numAtcCode).EndInit();
    ((ISupportInitialize) this.numIsoCode).EndInit();
    ((ISupportInitialize) this.MgaTab1).EndInit();
    ((Control) this.MgaTab1).ResumeLayout(false);
    ((ISupportInitialize) this.gridClaims).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
  }

  private virtual BindingManagerBase _bmb
  {
    get => this.__bmb;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this._bmb_PositionChanged);
      BindingManagerBase bmb1 = this.__bmb;
      if (bmb1 != null)
        bmb1.PositionChanged -= eventHandler;
      this.__bmb = value;
      BindingManagerBase bmb2 = this.__bmb;
      if (bmb2 == null)
        return;
      bmb2.PositionChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("_bmbResPay")]
  private virtual BindingManagerBase _bmbResPay { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmClaims(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.frmClaims_Load);
    this.TotalIncurredManuallyChanged = false;
    this._onlyImportExistingClaims = false;
    this.InitializeComponent();
    this._cn = DefaultDatabase.CreateDbConnection();
    Utility.SetDataAdapterConnections(this.daResPay, this._cn, (DbTransaction) null);
    Utility.SetDataAdapterConnections(this.daClaims, this._cn, (DbTransaction) null);
    if (this.DesignMode)
      return;
    this._quote = new Quote(quoteGuid);
    this._quoteGuid = this._quote.QuoteGuid;
    this.Text = "Claim Information - Policy #" + this._quote.PolicyNumber;
    ((Control) this.gridClaims).Text = this.Text;
    this._implementsLexisNexusClaims = ClaimsLexisNexus.ImplementsLexisNexusClaims();
    this._canEditClaims = SecurityManager.Instance.AssertPermission("{2E816935-F41A-4b0b-BE97-8034F73E32AD}");
    this.SetControlsEnabledState();
  }

  public frmClaims()
  {
    this.Load += new EventHandler(this.frmClaims_Load);
    this.TotalIncurredManuallyChanged = false;
    this._onlyImportExistingClaims = false;
    this.InitializeComponent();
  }

  public virtual bool LockDownForm => true;

  private void frmClaims_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      this.ds.lstStates.TableName
    }, CommandType.Text, "SELECT StateID, State FROM lstStates ORDER BY State");
    this._bmb = this.BindingContext[(object) this.ds, this.ds.tblClaimInformation.TableName];
    this._bmbResPay = this.BindingContext[(object) this.ds, this.ds.tblClaimResPaymentActivity.TableName];
    if (SystemSettings.GetSetting<bool>("ClaimsImport.OnlyImportExistingClaims", false))
    {
      this._onlyImportExistingClaims = true;
      ((UltraDateTimeEditor) this.dtReported).Appearance.BackColor = Color.White;
      ((UltraDateTimeEditor) this.MgaDateTimePicker1).Appearance.BackColor = Color.White;
      ((TextEditorControlBase) this.txtLossType).Appearance.BackColor = Color.White;
    }
    this.lnkOrder.Visible = this._implementsLexisNexusClaims;
    this.daResPay.SelectCommand.CommandText = "SELECT TOP 1 PaymentID, ClaimID, OutIndRes, OutLAERes, OutLegalRes, DedRecovery, Subrogation, Salvage, OtherRecovery, MTDIndemnityPaid, IndemnityPTD, MTDLAEPaid, LAEPTD, MTDLegalPaid, LegalPTD, MTDTPAExpPaid, TPAExpPTD, TotalIncurred, CheckIssued, OutMedRes, MedicalPTD, RecType, ValueDate, TotalReserve, RespayTotalPaid, TPAReserve, BIPaid,BIReserve, PDPaid, PDReserve, GrossLoss, ExpensePaid, ExpenseReserved, DetailDescription,LossStreet,LossCity,LossState,LossZip, Longitude, Latitude, Iso_Code, Atc_Code,Hail_Code, Pc_Code,Occupancy, Subsidized, Student_Senior, Total_SqFt,Price_Per_Sqft, Total_BV,Total_BBP,Total_BI, Total_TIV, Program_Deductible_Applied, Program_AOP, Program_WindHail, Program_NS, Program_Notes, BusIntReserve, ContingentBIReserve, BusIntPaid, ContingentBIPaid FROM tblClaimResPaymentActivity WHERE ClaimID = @ClaimID ORDER BY PaymentID DESC ";
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedFill));
  }

  private void ThreadedFill(object state)
  {
    Thread.Sleep(100);
    dsClaims.tblClaimInformationDataTable informationDataTable = new dsClaims.tblClaimInformationDataTable();
    this.daClaims.SelectCommand.Parameters["@ControlNo"].Value = (object) this._quote.ControlNo;
    DefaultDatabase.DataAdapterFill(this.daClaims, (DataTable) informationDataTable);
    if (!this.IsHandleCreated || this.IsDisposed || this.Disposing)
      return;
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) this, (Delegate) new frmClaims.ThreadedFillCompleteHandler(this.ThreadedFillComplete), new object[1]
    {
      (object) informationDataTable
    });
  }

  private void ThreadedFillComplete(dsClaims.tblClaimInformationDataTable dt)
  {
    this._bmb.SuspendBinding();
    this.ds.tblClaimInformation.Clear();
    try
    {
      foreach (DataRow row in dt.Rows)
        this.ds.tblClaimInformation.ImportRow(row);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this._bmb.ResumeBinding();
    this.SetReadonlyStatus();
    this.dbSave.UIState = this.ds.tblClaimInformation.Count != 0 ? (UIState) 1 : (UIState) 0;
    this.FillClientTables();
  }

  protected virtual void FillClientTables()
  {
  }

  private void SetControlsEnabledState()
  {
    ((Control) this.gridClaims).Enabled = this.dbSave.UIState != 2;
    foreach (UltraTab tab in ((UltraTabControlBase) this.MgaTab1).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (control != this.dbSave)
            control.Enabled = this.dbSave.UIState == 2;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this.lnkOrder.Enabled = this._implementsLexisNexusClaims;
    ((Control) this.dbSave).Enabled = this.LockDownForm;
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (this._canEditClaims)
      return;
    int num = (int) MessageBox.Show("You do not have the authorization to edit claims.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    e.Cancel = true;
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e) => this.SetControlsEnabledState();

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{97FEA54D-B2D9-4b0e-91B8-F335BE758863}"))
    {
      int num = (int) MessageBox.Show("You do not have the authorization to add new claims.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
    {
      dsClaims.tblClaimInformationRow row1 = this.ds.tblClaimInformation.NewtblClaimInformationRow();
      row1.ControlNo = this._quote.ControlNo;
      this.ds.tblClaimInformation.AddtblClaimInformationRow(row1);
      dsClaims.tblClaimResPaymentActivityRow row2 = this.ds.tblClaimResPaymentActivity.NewtblClaimResPaymentActivityRow();
      row2.ClaimID = row1.ClaimID;
      this.ds.tblClaimResPaymentActivity.AddtblClaimResPaymentActivityRow(row2);
      this._bmb.Position = this.ds.tblClaimInformation.Count - 1;
      this._bmbResPay.Position = this._bmb.Position;
    }
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this._bmb.Position == -1)
      e.Cancel = true;
    else if (this.ds.tblClaimInformation[this._bmb.Position].IsClaimNoNull())
    {
      int num = (int) MessageBox.Show("Claim/File number is empty. This item is required.", "Claim/File Number Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      this._bmb.EndCurrentEdit();
      this._bmbResPay.EndCurrentEdit();
      bool flag = true;
      this.err.SetError((Control) this.txtClaimNum, string.Empty);
      this.err.SetError((Control) this.dtDateOfLoss, string.Empty);
      this.err.SetError((Control) this.dtReported, string.Empty);
      this.err.SetError((Control) this.MgaDateTimePicker1, string.Empty);
      this.err.SetError((Control) this.txtLossType, string.Empty);
      this.err.SetError((Control) this.txtStatus, string.Empty);
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(((TextEditorControlBase) this.txtClaimNum).Value)))
      {
        flag = false;
        this.err.SetError((Control) this.txtClaimNum, "Please enter a value");
      }
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtDateOfLoss).Value)))
      {
        flag = false;
        this.err.SetError((Control) this.dtDateOfLoss, "Please enter a value");
      }
      if (((TextEditorControlBase) this.txtStatus).Text.Replace(" ", string.Empty).Length == 0)
      {
        flag = false;
        this.err.SetError((Control) this.txtStatus, "Please enter a value");
      }
      if (!this._onlyImportExistingClaims)
      {
        if (Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtReported).Value)))
        {
          flag = false;
          this.err.SetError((Control) this.dtReported, "Please enter a value");
        }
        if (Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.MgaDateTimePicker1).Value)))
        {
          flag = false;
          this.err.SetError((Control) this.MgaDateTimePicker1, "Please enter a value");
        }
        if (((TextEditorControlBase) this.txtLossType).Text.Replace(" ", string.Empty).Length == 0)
        {
          flag = false;
          this.err.SetError((Control) this.txtLossType, "Please enter a value");
        }
      }
      if (!flag)
      {
        ((UltraTabControlBase) this.MgaTab1).SelectedTab = ((UltraTabControlBase) this.MgaTab1).Tabs[0];
        e.Cancel = true;
      }
      else
      {
        Dictionary<string, string> dictionary1 = new Dictionary<string, string>();
        List<frmClaims.ClaimStructure> claimStructureList1 = new List<frmClaims.ClaimStructure>();
        Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
        List<frmClaims.ClaimStructure> claimStructureList2 = new List<frmClaims.ClaimStructure>();
        this.GetClaimChanges(claimStructureList1);
        if (this._bmbResPay.Position != -1 && this.ds.tblClaimResPaymentActivity[this._bmbResPay.Position].RowState == DataRowState.Modified)
          this.GetPaymentActivityChanges(claimStructureList2);
        this.SaveChanges();
        this.GetFriendlyColumnNames(dictionary1);
        this.LogClaimChanges(claimStructureList1, dictionary1);
        this.GetPayActFriendlyColumnNames(dictionary2);
        this.LogPayActChanges(claimStructureList2, dictionary2);
      }
    }
  }

  private void LogPayActChanges(
    List<frmClaims.ClaimStructure> payActChanges,
    Dictionary<string, string> dictFriendlyColName)
  {
    if (payActChanges.Count == 0)
      return;
    int num = payActChanges.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      frmClaims.ClaimStructure payActChange = payActChanges[index];
      if (payActChange.ModCode.Equals("M"))
      {
        string columnName = payActChange.ColumnName;
        if (dictFriendlyColName.ContainsKey(payActChange.ColumnName))
          columnName = dictFriendlyColName[payActChange.ColumnName];
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(payActChange.OrigValue, string.Empty, false) == 0)
          payActChange.OrigValue = "<empty>";
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(payActChange.CurrValue, string.Empty, false) == 0)
          payActChange.CurrValue = "<empty>";
        CurrentUser.Instance.LogAction($"Modified Payment Activity - {payActChange.Desc} Change {columnName} from {payActChange.OrigValue} to {payActChange.CurrValue}", this._quoteGuid);
      }
    }
  }

  private void LogClaimChanges(
    List<frmClaims.ClaimStructure> claimChanges,
    Dictionary<string, string> dictFriendlyColName)
  {
    if (claimChanges.Count == 0)
      return;
    int num = claimChanges.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      frmClaims.ClaimStructure claimChange = claimChanges[index];
      if (claimChange.ModCode.Equals("D"))
      {
        CurrentUser.Instance.LogAction("Deleted Claim. " + claimChange.Desc, this._quoteGuid);
        break;
      }
      if (claimChange.ModCode.Equals("A"))
      {
        CurrentUser.Instance.LogAction("Add Claim." + claimChange.Desc, this._quoteGuid);
        break;
      }
      string columnName = claimChange.ColumnName;
      if (dictFriendlyColName.ContainsKey(claimChange.ColumnName))
        columnName = dictFriendlyColName[claimChange.ColumnName];
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(claimChange.OrigValue, string.Empty, false) == 0)
        claimChange.OrigValue = "<empty>";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(claimChange.CurrValue, string.Empty, false) == 0)
        claimChange.CurrValue = "<empty>";
      CurrentUser.Instance.LogAction($"Modified Claim - {claimChange.Desc} Change {columnName} from {claimChange.OrigValue} to {claimChange.CurrValue}", this._quoteGuid);
    }
  }

  private void GetFriendlyColumnNames(Dictionary<string, string> friendlyColNames)
  {
    Dictionary<string, string> dictionary = friendlyColNames;
    dictionary.Add("DateReceived", "Date Claim Received");
    dictionary.Add("DateReported", "Date Claim Reported");
    dictionary.Add("LossDate", "Date of Loss");
    dictionary.Add("LossType", "Type of Loss");
    dictionary.Add("Status", "Claim Status");
    dictionary.Add("DateClosed", "Date Claim Closed");
    dictionary.Add("InLitigation", "Claim In Litigation");
    dictionary.Add("DescriptionInjury", "Injury Description");
    dictionary.Add("CATNo", "CAT Number");
    dictionary.Add("ImportedID", "Imported Type");
  }

  private void GetPayActFriendlyColumnNames(
    Dictionary<string, string> friendlyPayActColumnName)
  {
    Dictionary<string, string> dictionary = friendlyPayActColumnName;
    dictionary.Add("OutIndRes", "Outstanding Indemnity Reserve");
    dictionary.Add("OutLAERes", "Outstanding LAE Reserves");
    dictionary.Add("OutLegalRes", "Outstanding legal reserve");
    dictionary.Add("DedRecovery", "Deductible Recovery");
    dictionary.Add("Subrogation", "Subrogation Recovery");
    dictionary.Add("Salvage", "Salvage Recovery");
    dictionary.Add("OtherRecovery", "Other Recovery");
    dictionary.Add("MTDIndemnityPaid", "MTD Indemnity Paid");
    dictionary.Add("IndemnityPTD", "Indemnity Paid to Date");
    dictionary.Add("LAEPTD", "LAE Paid To Date");
    dictionary.Add("MTDLAEPaid", "MTD LAE Paid");
    dictionary.Add("LegalPTD", "Legal Paid to Date");
    dictionary.Add("MTDLegalPaid", "MTD Legal Paid");
    dictionary.Add("CheckIssued", "Check Issued Date");
    dictionary.Add("OutMedRes", "Medical Reserve");
    dictionary.Add("MedicalPTD", "Medical Paid");
    dictionary.Add("RecType", "Recovery Type");
  }

  private void GetPaymentActivityChanges(
    List<frmClaims.ClaimStructure> payActColumnChangesList)
  {
    if (this._bmbResPay.Position == -1)
      return;
    string str = string.Empty;
    dsClaims.tblClaimInformationRow claimInformationRow = this.ds.tblClaimInformation[this._bmb.Position];
    if (claimInformationRow["ClaimNo", DataRowVersion.Original] != DBNull.Value)
      str = $"Claim #\r\n                End If\r\n                     {claimInformationRow["ClaimNo", DataRowVersion.Original].ToString()} - ";
    if (claimInformationRow["ControlNo", DataRowVersion.Original] != DBNull.Value)
      str = $"{str}Control #\r\n                     {claimInformationRow["ControlNo", DataRowVersion.Original].ToString()}";
    dsClaims.tblClaimResPaymentActivityRow paymentActivityRow = this.ds.tblClaimResPaymentActivity[this._bmbResPay.Position];
    if (paymentActivityRow.RowState != DataRowState.Modified)
      return;
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) this.ds.tblClaimResPaymentActivity.Columns)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paymentActivityRow[column.ColumnName, DataRowVersion.Original].ToString(), paymentActivityRow[column.ColumnName, DataRowVersion.Current].ToString(), false) != 0)
          payActColumnChangesList.Add(new frmClaims.ClaimStructure()
          {
            ModCode = "M",
            ColumnName = column.ColumnName,
            CurrValue = paymentActivityRow[column] == DBNull.Value || paymentActivityRow[column, DataRowVersion.Current] == DBNull.Value ? string.Empty : paymentActivityRow[column, DataRowVersion.Current].ToString(),
            OrigValue = paymentActivityRow[column] == DBNull.Value || paymentActivityRow[column, DataRowVersion.Original] == DBNull.Value ? string.Empty : paymentActivityRow[column, DataRowVersion.Original].ToString(),
            Desc = str
          });
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void GetClaimChanges(List<frmClaims.ClaimStructure> claimChangeList)
  {
    frmClaims.ClaimStructure claimStructure = new frmClaims.ClaimStructure();
    dsClaims.tblClaimInformationRow claimInformationRow = this.ds.tblClaimInformation[this._bmb.Position];
    if (claimInformationRow.RowState == DataRowState.Deleted)
    {
      claimStructure.ModCode = "D";
      if (claimInformationRow["ClaimNo", DataRowVersion.Original] != DBNull.Value)
      {
        claimStructure.OrigValue = claimInformationRow["ClaimNo", DataRowVersion.Original].ToString();
        claimStructure.Desc = "Claim #\r\n                     " + claimStructure.OrigValue;
      }
      if (claimInformationRow["ControlNo", DataRowVersion.Original] != DBNull.Value)
      {
        string str1 = claimInformationRow["ControlNo", DataRowVersion.Original].ToString();
        // ISSUE: variable of a reference type
        string& local;
        // ISSUE: explicit reference operation
        string str2 = $"{^(local = ref claimStructure.Desc)} - Control #\r\n                     {str1}";
        local = str2;
      }
      claimChangeList.Add(claimStructure);
    }
    else if (claimInformationRow.RowState == DataRowState.Added)
    {
      claimStructure.ModCode = "A";
      if (claimInformationRow["ClaimNo", DataRowVersion.Current] != DBNull.Value)
      {
        claimStructure.CurrValue = claimInformationRow["ClaimNo", DataRowVersion.Current].ToString();
        claimStructure.Desc = "Claim #\r\n                     " + claimStructure.CurrValue;
      }
      if (claimInformationRow["ControlNo", DataRowVersion.Current] != DBNull.Value)
      {
        string str3 = claimInformationRow["ControlNo", DataRowVersion.Current].ToString();
        // ISSUE: variable of a reference type
        string& local;
        // ISSUE: explicit reference operation
        string str4 = $"{^(local = ref claimStructure.Desc)} - Control #\r\n                     {str3}";
        local = str4;
      }
      claimChangeList.Add(claimStructure);
    }
    else
    {
      if (claimInformationRow.RowState != DataRowState.Modified)
        return;
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) this.ds.tblClaimInformation.Columns)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(claimInformationRow[column.ColumnName, DataRowVersion.Original].ToString(), claimInformationRow[column.ColumnName, DataRowVersion.Current].ToString(), false) != 0)
          {
            claimStructure.ModCode = "M";
            claimStructure.ColumnName = column.ColumnName;
            claimStructure.CurrValue = claimInformationRow[column] == DBNull.Value || claimInformationRow[column, DataRowVersion.Current] == DBNull.Value ? string.Empty : claimInformationRow[column, DataRowVersion.Current].ToString();
            claimStructure.OrigValue = claimInformationRow[column] == DBNull.Value || claimInformationRow[column, DataRowVersion.Original] == DBNull.Value ? string.Empty : claimInformationRow[column, DataRowVersion.Original].ToString();
            claimChangeList.Add(claimStructure);
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

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{2E87DE95-577C-43e0-96F5-86A4B9A65119}"))
    {
      int num = (int) MessageBox.Show("You do not have the authorization to delete claims.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to delete this claim?", "Delete Claim?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      dsClaims.tblClaimResPaymentActivityRow[] paymentActivityRowArray = this.ds.tblClaimInformation[this._bmb.Position].GettblClaimResPaymentActivityRows();
      int index = 0;
      while (index < paymentActivityRowArray.Length)
      {
        paymentActivityRowArray[index].Delete();
        checked { ++index; }
      }
      this.ds.tblClaimInformation[this._bmb.Position].Delete();
      this.SaveChanges();
      e.Cancel = true;
      if (this.ds.tblClaimInformation.Count == 0 || this._bmb.Position == -1)
        this.dbSave.UIState = (UIState) 0;
      else
        this.dbSave.UIState = (UIState) 1;
    }
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ds.tblClaimResPaymentActivity.RejectChanges();
    this.ds.tblClaimInformation.RejectChanges();
    e.Cancel = true;
    if (this.ds.tblClaimInformation.Count == 0)
      this.dbSave.UIState = (UIState) 0;
    else
      this.dbSave.UIState = (UIState) 1;
  }

  private static void AssignTransaction(DbDataAdapter da, DbTransaction trans)
  {
    da.SelectCommand.Transaction = trans;
    da.InsertCommand.Transaction = trans;
    da.UpdateCommand.Transaction = trans;
    da.DeleteCommand.Transaction = trans;
  }

  private void SaveChanges()
  {
    this._bmb.EndCurrentEdit();
    this._bmbResPay.EndCurrentEdit();
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
    {
      try
      {
        frmClaims.AssignTransaction(this.daResPay, args.Transaction);
        frmClaims.AssignTransaction(this.daClaims, args.Transaction);
        DefaultDatabase.DataAdapterUpdate(this.daResPay, this.ds.tblClaimResPaymentActivity.Select(string.Empty, string.Empty, DataViewRowState.Deleted));
        DefaultDatabase.DataAdapterUpdate(this.daClaims, this.ds.tblClaimInformation.Select(string.Empty, string.Empty, DataViewRowState.Deleted));
        DefaultDatabase.DataAdapterUpdate(this.daClaims, (DataTable) this.ds.tblClaimInformation);
        DefaultDatabase.DataAdapterUpdate(this.daResPay, (DataTable) this.ds.tblClaimResPaymentActivity);
        args.Transaction.Commit();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        args.Transaction.Rollback();
        throw;
      }
    }));
  }

  private void _bmb_PositionChanged(object sender, EventArgs e) => this.SetReadonlyStatus();

  private void SetReadonlyStatus()
  {
    if (this._bmb.Position == -1 || this.ds.tblClaimInformation.Count == 0)
      return;
    ((Control) this.dbSave).Enabled = !this.ds.tblClaimInformation[this._bmb.Position]._ReadOnly;
    if (!this._canEditClaims)
      return;
    ((Control) this.dbSave).Enabled = true;
  }

  private void gridClaims_BeforeRowExpanded(object sender, CancelableRowEventArgs e)
  {
    int claimID = (int) e.Row.Cells["ClaimID"].Value;
    this.FillResPayData(claimID);
    this._bmbResPay.Position = this.ds.tblClaimResPaymentActivity.Rows.IndexOf(this.ds.tblClaimResPaymentActivity.Select("ClaimID=" + claimID.ToString())[0]);
  }

  private void FillResPayData(int claimID)
  {
    DataRow[] dataRowArray1 = this.ds.tblClaimResPaymentActivity.Select("ClaimID=" + claimID.ToString());
    int index1 = 0;
    while (index1 < dataRowArray1.Length)
    {
      this.ds.tblClaimResPaymentActivity.RemovetblClaimResPaymentActivityRow((dsClaims.tblClaimResPaymentActivityRow) dataRowArray1[index1]);
      checked { ++index1; }
    }
    this.daResPay.SelectCommand.Parameters["@ClaimID"].Value = (object) claimID;
    DefaultDatabase.DataAdapterFill(this.daResPay, (DataTable) this.ds.tblClaimResPaymentActivity);
    DataRow[] dataRowArray2 = this.ds.tblClaimResPaymentActivity.Select("ClaimID=" + claimID.ToString());
    int index2 = 0;
    while (index2 < dataRowArray2.Length)
    {
      dsClaims.tblClaimResPaymentActivityRow paymentActivityRow = (dsClaims.tblClaimResPaymentActivityRow) dataRowArray2[index2];
      Decimal d2_1 = 0M;
      if (!paymentActivityRow.IsOutMedResNull())
        d2_1 = paymentActivityRow.OutMedRes;
      if (paymentActivityRow.IsBIPaidNull())
        paymentActivityRow.BIPaid = 0M;
      if (paymentActivityRow.IsPDPaidNull())
        paymentActivityRow.PDPaid = 0M;
      if (paymentActivityRow.IsBIReserveNull())
        paymentActivityRow.BIReserve = 0M;
      if (paymentActivityRow.IsPDReserveNull())
        paymentActivityRow.PDReserve = 0M;
      Decimal d1 = Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Add(paymentActivityRow.OutIndRes, paymentActivityRow.OutLAERes), paymentActivityRow.OutLegalRes), d2_1), paymentActivityRow.BIReserve), paymentActivityRow.PDReserve);
      Decimal num = Decimal.Add(Decimal.Add(Decimal.Add(paymentActivityRow.DedRecovery, paymentActivityRow.Subrogation), paymentActivityRow.Salvage), paymentActivityRow.OtherRecovery);
      Decimal d2_2 = Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Add(Decimal.Add(paymentActivityRow.LegalPTD, paymentActivityRow.MTDIndemnityPaid), paymentActivityRow.IndemnityPTD), paymentActivityRow.MTDLAEPaid), paymentActivityRow.MTDTPAExpPaid), paymentActivityRow.MTDLegalPaid), paymentActivityRow.LAEPTD), paymentActivityRow.TPAExpPTD), paymentActivityRow.BIPaid), paymentActivityRow.PDPaid);
      if (!this.TotalIncurredManuallyChanged)
        paymentActivityRow.TotalIncurred = Decimal.Subtract(Decimal.Add(d1, d2_2), Math.Abs(num));
      paymentActivityRow.TotalRecovery = num;
      checked { ++index2; }
    }
    ((UltraGridBase) this.gridClaims).Rows.Refresh((RefreshRow) 2, true);
  }

  private void gridClaims_AfterRowActivate(object sender, EventArgs e)
  {
    if (this._bmb.Position < 0)
      return;
    int claimID = (int) ((UltraGridBase) this.gridClaims).ActiveRow.Cells["ClaimID"].Value;
    if (this.ds.tblClaimResPaymentActivity.Select("ClaimID=" + claimID.ToString()).Length == 0)
      this.FillResPayData(claimID);
    Database.MoveTo((object) claimID, this.ds.tblClaimInformation.ClaimIDColumn.ColumnName, (DataTable) this.ds.tblClaimInformation, this._bmb);
    if (this.ds.tblClaimResPaymentActivity.Select("ClaimID=" + claimID.ToString()).Length <= 0)
      return;
    this._bmbResPay.Position = this.ds.tblClaimResPaymentActivity.Rows.IndexOf(this.ds.tblClaimResPaymentActivity.Select("ClaimID=" + claimID.ToString())[0]);
  }

  private void MgaNumericEditor25_ValueChanged(object sender, EventArgs e)
  {
    this.TotalIncurredManuallyChanged = true;
  }

  private void gridClaims_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    this.Grid_InitializeLayout(RuntimeHelpers.GetObjectValue(sender), e);
  }

  protected virtual void Grid_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
  }

  Guid IRecreatableEntity.ControlGUID => this._quote.ControlGuid;

  bool IRecreatableEntity.HasControlGUID => true;

  public bool CanCreateNewNote => true;

  Guid IRecreatableEntity.EntityGUID => this._quote.ControlGuid;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  string IRecreatableEntity.FriendlyEntityName => "Policy Detail";

  string IRecreatableEntity.RecreateTypeName => typeof (frmPolicyDetail).ToString();

  public int ControlNumber => this._quote.ControlNo;

  public string LineName => this._quote.LineName;

  public string NamedInsured => this._quote.InsuredPolicyName;

  string IRecreatableEntity.EntityName
  {
    get
    {
      return !this._quote.HasPolicyNumber ? $"{this.NamedInsured} / Control\r\n                     {this.ControlNumber.ToString()}" : $"Policy\r\n                     {this._quote.PolicyNumber} / {this.NamedInsured} / Control\r\n                     {this.ControlNumber.ToString()}";
    }
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged1;

  bool IRecreatableEntity.CanReCreateEntity => true;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGUID)
  {
    bool flag;
    return flag;
  }

  private void UltraTabPageControl1_Paint(object sender, PaintEventArgs e)
  {
  }

  private void lnkOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (DialogResult.Yes != MessageBox.Show("Continue and order the Lexis Nexus Claim's report for this insured?", "Order Lexis Nexus Report?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      return;
    bool flag = false;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      CurrentUser.Instance.LogAction("Invoking Lexis Nexus service using the quote insured.", this._quoteGuid);
      flag = new ClaimsLexisNexus(this._quote.SubmissionGroup.InsuredGuid).Submit();
      if (flag)
        CurrentUser.Instance.LogAction("Lexis Nexus service ran on the insured successfully.", this._quoteGuid);
      else
        CurrentUser.Instance.LogAction("Lexis Nexus service ran on the insured and failed.", this._quoteGuid);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    if (!flag)
      return;
    this.UpdateClaims();
  }

  private void UpdateClaims()
  {
    if (!SecurityManager.Instance.AssertPermission("{97FEA54D-B2D9-4b0e-91B8-F335BE758863}"))
      return;
    if (DialogResult.Yes != MessageBox.Show("Do you wish to transfer the data from Lexis Nexus to a claim in the IMS?", "Transfer Data To IMS?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DefaultDatabase.ExecuteNonQuery("TransferLexisNexusDataToClaims", new object[4]
      {
        (object) "@QuoteGuid",
        (object) this._quote.QuoteGuid,
        (object) "@InsuredGuid",
        (object) this._quote.SubmissionGroup.InsuredGuid
      });
      CurrentUser.Instance.LogAction("Transfer data from Lexis Nexus to claims", this._quoteGuid);
      this.Close();
      FormSettings.ShowForm(typeof (frmClaims), new object[1]
      {
        (object) this._quote.QuoteGuid
      });
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private delegate void ThreadedFillCompleteHandler(dsClaims.tblClaimInformationDataTable dt);

  private struct ClaimStructure
  {
    public string ColumnName;
    public string OrigValue;
    public string CurrValue;
    public string ModCode;
    public string Desc;
  }
}
