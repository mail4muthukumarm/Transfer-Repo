// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Commissions.frmPolicyCommissions
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Commissions;

[SecureResource("{9AEB647B-3105-4a79-ADB5-20C248C70D7E}", "View Commissions", "Controls the ability for the user to see which entities receive commission on a policy.", "Commissions")]
public sealed class frmPolicyCommissions : Form
{
  private IContainer components;
  private DbDataAdapter daComm;
  private dsPolicyCommissions ds;
  private ErrorProvider err;
  private Label lblCompanyLineInfo;
  private DbDataAdapter daCommTypes;
  private DbCommand cmdSumCommissionableFees;
  private AddCommissionableEntity ctlEntity;
  internal const string CanViewCommissions = "{9AEB647B-3105-4a79-ADB5-20C248C70D7E}";
  private Guid _quoteGuid;
  private Guid _companyLineGuid;
  private Guid _quoteOptionGuid;

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingCancel);
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.dbSave_ClickingDelete);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingEdit -= cancelEventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickingNew -= cancelEventHandler3;
        dbSave1.ClickingCancel -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler;
        dbSave1.ClickingDelete -= cancelEventHandler5;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingEdit += cancelEventHandler1;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickingNew += cancelEventHandler3;
      dbSave2.ClickingCancel += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler;
      dbSave2.ClickingDelete += cancelEventHandler5;
    }
  }

  private virtual UltraGrid dgComm
  {
    get => this._dgComm;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dgComm_AfterRowActivate);
      UltraGrid dgComm1 = this._dgComm;
      if (dgComm1 != null)
        dgComm1.AfterRowActivate -= eventHandler;
      this._dgComm = value;
      UltraGrid dgComm2 = this._dgComm;
      if (dgComm2 == null)
        return;
      dgComm2.AfterRowActivate += eventHandler;
    }
  }

  private virtual ContextMenu cm
  {
    get => this._cm;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cm_Popup);
      ContextMenu cm1 = this._cm;
      if (cm1 != null)
        cm1.Popup -= eventHandler;
      this._cm = value;
      ContextMenu cm2 = this._cm;
      if (cm2 == null)
        return;
      cm2.Popup += eventHandler;
    }
  }

  private virtual MenuItem mnuReinstate
  {
    get => this._mnuReinstate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuReinstate_Click);
      MenuItem mnuReinstate1 = this._mnuReinstate;
      if (mnuReinstate1 != null)
        mnuReinstate1.Click -= eventHandler;
      this._mnuReinstate = value;
      MenuItem mnuReinstate2 = this._mnuReinstate;
      if (mnuReinstate2 == null)
        return;
      mnuReinstate2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuManual
  {
    get => this._mnuManual;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuManual_Click);
      MenuItem mnuManual1 = this._mnuManual;
      if (mnuManual1 != null)
        mnuManual1.Click -= eventHandler;
      this._mnuManual = value;
      MenuItem mnuManual2 = this._mnuManual;
      if (mnuManual2 == null)
        return;
      mnuManual2.Click += eventHandler;
    }
  }

  private virtual MenuItem mnuWaive
  {
    get => this._mnuWaive;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuWaive_Click);
      MenuItem mnuWaive1 = this._mnuWaive;
      if (mnuWaive1 != null)
        mnuWaive1.Click -= eventHandler;
      this._mnuWaive = value;
      MenuItem mnuWaive2 = this._mnuWaive;
      if (mnuWaive2 == null)
        return;
      mnuWaive2.Click += eventHandler;
    }
  }

  internal virtual LinkLabel lblShowProducerLocationEntities
  {
    get => this._lblShowProducerLocationEntities;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LblShowProducerLocationEntities_LinkClicked);
      LinkLabel locationEntities1 = this._lblShowProducerLocationEntities;
      if (locationEntities1 != null)
        locationEntities1.LinkClicked -= clickedEventHandler;
      this._lblShowProducerLocationEntities = value;
      LinkLabel locationEntities2 = this._lblShowProducerLocationEntities;
      if (locationEntities2 == null)
        return;
      locationEntities2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lblShowCompanyEntities
  {
    get => this._lblShowCompanyEntities;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LblShowCompanyEntities_LinkClicked);
      LinkLabel showCompanyEntities1 = this._lblShowCompanyEntities;
      if (showCompanyEntities1 != null)
        showCompanyEntities1.LinkClicked -= clickedEventHandler;
      this._lblShowCompanyEntities = value;
      LinkLabel showCompanyEntities2 = this._lblShowCompanyEntities;
      if (showCompanyEntities2 == null)
        return;
      showCompanyEntities2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGACheckBox chkShowWaived
  {
    get => this._chkShowWaived;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkShowWaived_CheckedChanged);
      MGACheckBox chkShowWaived1 = this._chkShowWaived;
      if (chkShowWaived1 != null)
        ((UltraToggleEditorBase) chkShowWaived1).CheckedChanged -= eventHandler;
      this._chkShowWaived = value;
      MGACheckBox chkShowWaived2 = this._chkShowWaived;
      if (chkShowWaived2 == null)
        return;
      ((UltraToggleEditorBase) chkShowWaived2).CheckedChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPolicyCommissions));
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("View", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("EntityGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("WaivedByUserGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Participant");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Percentage");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("DollarAmount");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CommissionFrom");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("CommissionTypeID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("EntityType");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Premium");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance13 = new Appearance();
    this.ds = new dsPolicyCommissions();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.daComm = DefaultDatabase.CreateDataAdapter();
    this.err = new ErrorProvider(this.components);
    this.lblCompanyLineInfo = new Label();
    this.daCommTypes = DefaultDatabase.CreateDataAdapter();
    this.dgComm = new UltraGrid();
    this.cm = new ContextMenu();
    this.mnuReinstate = new MenuItem();
    this.mnuManual = new MenuItem();
    this.mnuWaive = new MenuItem();
    this.cmdSumCommissionableFees = DefaultDatabase.CreateCommand();
    this.ctlEntity = new AddCommissionableEntity();
    this.chkShowWaived = new MGACheckBox();
    this.lblShowCompanyEntities = new LinkLabel();
    this.lblShowProducerLocationEntities = new LinkLabel();
    DbCommand command1 = DefaultDatabase.CreateCommand();
    DbCommand command2 = DefaultDatabase.CreateCommand();
    DbCommand command3 = DefaultDatabase.CreateCommand();
    DbCommand command4 = DefaultDatabase.CreateCommand();
    DbCommand command5 = DefaultDatabase.CreateCommand();
    this.ds.BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.dgComm).BeginInit();
    ((ISupportInitialize) this.chkShowWaived).BeginInit();
    this.SuspendLayout();
    command1.CommandText = "DELETE FROM dbo.tblPolicyCommissions\r\nWHERE        (ID = @Original_ID)";
    command1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    command2.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    command2.Parameters.AddRange((Array) new DbParameter[14]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid"),
      DefaultDatabase.CreateParameter("@EntityGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "EntityGuid"),
      DefaultDatabase.CreateParameter("@EntityTypeID", SqlDbType.VarChar, 2, "EntityTypeID"),
      DefaultDatabase.CreateParameter("@CommissionTypeID", SqlDbType.VarChar, 2, "CommissionTypeID"),
      DefaultDatabase.CreateParameter("@FlatAmount", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "FlatAmount", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@Percentage", SqlDbType.Decimal, 7, ParameterDirection.Input, false, (byte) 11, (byte) 10, "Percentage", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      DefaultDatabase.CreateParameter("@ChargeCode", SqlDbType.Int, 4, "ChargeCode"),
      DefaultDatabase.CreateParameter("@OptionFeeID", SqlDbType.Int, 4, "OptionFeeID"),
      DefaultDatabase.CreateParameter("@PremiumID", SqlDbType.Int, 4, "PremiumID"),
      DefaultDatabase.CreateParameter("@CommissionsFromOperatingAccount", SqlDbType.Bit, 1, "CommissionsFromOperatingAccount"),
      DefaultDatabase.CreateParameter("@AutoApplied", SqlDbType.Bit, 1, "AutoApplied"),
      DefaultDatabase.CreateParameter("@WaivedByUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "WaivedByUserGuid"),
      DefaultDatabase.CreateParameter("@ConvertedToManualUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ConvertedToManualUserGuid")
    });
    command3.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    command3.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid"),
      DefaultDatabase.CreateParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid")
    });
    command4.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    command4.Parameters.AddRange((Array) new DbParameter[16 /*0x10*/]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid"),
      DefaultDatabase.CreateParameter("@EntityGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "EntityGuid"),
      DefaultDatabase.CreateParameter("@EntityTypeID", SqlDbType.VarChar, 2, "EntityTypeID"),
      DefaultDatabase.CreateParameter("@CommissionTypeID", SqlDbType.Char, 2, "CommissionTypeID"),
      DefaultDatabase.CreateParameter("@FlatAmount", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 10, (byte) 2, "FlatAmount", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@Percentage", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 11, (byte) 10, "Percentage", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      DefaultDatabase.CreateParameter("@ChargeCode", SqlDbType.Int, 4, "ChargeCode"),
      DefaultDatabase.CreateParameter("@OptionFeeID", SqlDbType.Int, 4, "OptionFeeID"),
      DefaultDatabase.CreateParameter("@PremiumID", SqlDbType.Int, 4, "PremiumID"),
      DefaultDatabase.CreateParameter("@CommissionsFromOperatingAccount", SqlDbType.Bit, 1, "CommissionsFromOperatingAccount"),
      DefaultDatabase.CreateParameter("@AutoApplied", SqlDbType.Bit, 1, "AutoApplied"),
      DefaultDatabase.CreateParameter("@WaivedByUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "WaivedByUserGuid"),
      DefaultDatabase.CreateParameter("@ConvertedToManualUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ConvertedToManualUserGuid"),
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    command5.CommandText = "SELECT CommissionTypeID, Description FROM lstCommissionTypes";
    this.ds.DataSetName = "dsPolicyCommissions";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.dbSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = (EditStyle) 1;
    this.dbSave.FreezeEvents = false;
    ((Control) this.dbSave).Location = new Point(610, 405);
    ((Control) this.dbSave).Name = "dbSave";
    ((Control) this.dbSave).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.dbSave).TabIndex = 10;
    this.daComm.DeleteCommand = command1;
    this.daComm.InsertCommand = command2;
    this.daComm.SelectCommand = command3;
    this.daComm.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblPolicyCommissions", new DataColumnMapping[15]
      {
        new DataColumnMapping("QuoteGuid", "QuoteGuid"),
        new DataColumnMapping("EntityGuid", "EntityGuid"),
        new DataColumnMapping("EntityTypeID", "EntityTypeID"),
        new DataColumnMapping("CommissionTypeID", "CommissionTypeID"),
        new DataColumnMapping("FlatAmount", "FlatAmount"),
        new DataColumnMapping("Percentage", "Percentage"),
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("ChargeCode", "ChargeCode"),
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("OptionFeeID", "OptionFeeID"),
        new DataColumnMapping("PremiumID", "PremiumID"),
        new DataColumnMapping("CommissionsFromOperatingAccount", "CommissionsFromOperatingAccount"),
        new DataColumnMapping("AutoApplied", "AutoApplied"),
        new DataColumnMapping("WaivedByUserGuid", "WaivedByUserGuid"),
        new DataColumnMapping("ConvertedToManualUserGuid", "ConvertedToManualUserGuid")
      })
    });
    this.daComm.UpdateCommand = command4;
    this.err.ContainerControl = (ContainerControl) this;
    this.lblCompanyLineInfo.Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCompanyLineInfo.Location = new Point(7, 7);
    this.lblCompanyLineInfo.Name = "lblCompanyLineInfo";
    this.lblCompanyLineInfo.Size = new Size(721, 23);
    this.lblCompanyLineInfo.TabIndex = 16 /*0x10*/;
    this.lblCompanyLineInfo.Text = "(company line info here)";
    this.lblCompanyLineInfo.TextAlign = ContentAlignment.MiddleCenter;
    this.daCommTypes.SelectCommand = command5;
    this.daCommTypes.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "lstCommissionTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("CommissionTypeID", "CommissionTypeID"),
        new DataColumnMapping("Description", "Description")
      })
    });
    ((Control) this.dgComm).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.dgComm).ContextMenu = this.cm;
    ((UltraGridBase) this.dgComm).DataSource = (object) this.ds.View;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgComm).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgComm).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 136;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 140;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 76;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 290;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn5.Format = "#,##0.00## %";
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 77;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn6.Format = "c";
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Flat Amount";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 73;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Commission Type";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 286;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 119;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 125;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 151;
    ultraGridBand.Columns.AddRange(new object[10]
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
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.dgComm).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgComm).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance6.BackColor = Color.LightSteelBlue;
    appearance6.FontData.SizeInPoints = 10f;
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.dgComm).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance10.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    appearance11.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = Color.Transparent;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.dgComm).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgComm).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgComm).Location = new Point(7, 35);
    ((Control) this.dgComm).Name = "dgComm";
    ((Control) this.dgComm).Size = new Size(728, 112 /*0x70*/);
    ((Control) this.dgComm).TabIndex = 17;
    ((UltraControlBase) this.dgComm).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgComm).UseOsThemes = (DefaultableBoolean) 2;
    this.cm.MenuItems.AddRange(new MenuItem[3]
    {
      this.mnuReinstate,
      this.mnuManual,
      this.mnuWaive
    });
    this.mnuReinstate.Index = 0;
    this.mnuReinstate.Text = "Reinstate Entity";
    this.mnuManual.Index = 1;
    this.mnuManual.Text = "Convert to Manual Entity";
    this.mnuWaive.Index = 2;
    this.mnuWaive.Text = "Waive Entity";
    this.cmdSumCommissionableFees.CommandText = "dbo.[SumCommissionableFees]";
    this.cmdSumCommissionableFees.CommandType = CommandType.StoredProcedure;
    this.cmdSumCommissionableFees.Parameters.AddRange((Array) new DbParameter[3]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@FeeTypeID", SqlDbType.TinyInt, 1)
    });
    this.ctlEntity.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ctlEntity.BackColor = Color.Transparent;
    this.ctlEntity.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ctlEntity.Location = new Point(7, 154);
    this.ctlEntity.Name = "ctlEntity";
    this.ctlEntity.ShowMinimumIncomeTab = false;
    this.ctlEntity.Size = new Size(728, 245);
    this.ctlEntity.TabIndex = 18;
    ((Control) this.chkShowWaived).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance13.BorderColor = Color.Gray;
    appearance13.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkShowWaived).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.chkShowWaived).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkShowWaived).Location = new Point(7, 420);
    ((Control) this.chkShowWaived).Name = "chkShowWaived";
    ((Control) this.chkShowWaived).Size = new Size(133, 24);
    ((Control) this.chkShowWaived).TabIndex = 23;
    ((UltraToggleEditorBase) this.chkShowWaived).Text = "Show Waived Entities";
    ((UltraControlBase) this.chkShowWaived).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkShowWaived).UseOsThemes = (DefaultableBoolean) 2;
    this.lblShowCompanyEntities.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblShowCompanyEntities.AutoSize = true;
    this.lblShowCompanyEntities.BackColor = Color.Transparent;
    this.lblShowCompanyEntities.Location = new Point(251, 434);
    this.lblShowCompanyEntities.Name = "lblShowCompanyEntities";
    this.lblShowCompanyEntities.Size = new Size(119, 13);
    this.lblShowCompanyEntities.TabIndex = 24;
    this.lblShowCompanyEntities.TabStop = true;
    this.lblShowCompanyEntities.Text = "Show Company Entities";
    this.lblShowProducerLocationEntities.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblShowProducerLocationEntities.AutoSize = true;
    this.lblShowProducerLocationEntities.BackColor = Color.Transparent;
    this.lblShowProducerLocationEntities.Location = new Point(251, 405);
    this.lblShowProducerLocationEntities.Name = "lblShowProducerLocationEntities";
    this.lblShowProducerLocationEntities.Size = new Size(160 /*0xA0*/, 13);
    this.lblShowProducerLocationEntities.TabIndex = 25;
    this.lblShowProducerLocationEntities.TabStop = true;
    this.lblShowProducerLocationEntities.Text = "Show Producer Location Entities";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(741, 456);
    this.Controls.Add((Control) this.lblShowProducerLocationEntities);
    this.Controls.Add((Control) this.lblShowCompanyEntities);
    this.Controls.Add((Control) this.chkShowWaived);
    this.Controls.Add((Control) this.ctlEntity);
    this.Controls.Add((Control) this.dgComm);
    this.Controls.Add((Control) this.lblCompanyLineInfo);
    this.Controls.Add((Control) this.dbSave);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmPolicyCommissions);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Policy Commissions";
    this.ds.EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.dgComm).EndInit();
    ((ISupportInitialize) this.chkShowWaived).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmPolicyCommissions(Guid quoteOptionGuid)
  {
    this.Load += new EventHandler(this.frmPolicyCommissions_Load);
    if (!SecurityManager.Instance.AssertPermission("{9AEB647B-3105-4a79-ADB5-20C248C70D7E}"))
      throw new InvalidOperationException("User does not have permission to view this form.  Call AssertPermission before showing.");
    this.InitializeComponent();
    this.ctlEntity.ShowMinimumIncomeTab = false;
    Utility.SetDataAdapterConnections(this.daCommTypes, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    Utility.SetDataAdapterConnections(this.daComm, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    this._quoteOptionGuid = quoteOptionGuid;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void frmPolicyCommissions_Load(object sender, EventArgs e)
  {
    CurrentUser.Instance.LogAction("Policy commissions accessed", "Policy Commissions");
    MDIControls.Instance.StatusBarText = "Auto applying commissions...";
    QuoteOption quoteOption = new QuoteOption(this._quoteOptionGuid);
    quoteOption.AutoApplyCommissions();
    MDIControls.Instance.StatusBarText = "Getting companies...";
    this._quoteGuid = quoteOption.QuoteGuid;
    this._companyLineGuid = quoteOption.CompanyLineGuid;
    this.lblCompanyLineInfo.Text = new CompanyLine(this._companyLineGuid).CompanyLineState;
    MDIControls.Instance.StatusBarText = "Loading data...";
    AddCommissionableEntity ctlEntity = this.ctlEntity;
    ctlEntity.Enabled = false;
    ctlEntity.FillPremiumsFees(this._quoteOptionGuid);
    DefaultDatabase.DataAdapterFill(this.daCommTypes, (DataTable) this.ds.lstCommissionTypes);
    dsPolicyCommissions.tblFin_PolicyChargesRow row = this.ds.tblFin_PolicyCharges.NewtblFin_PolicyChargesRow();
    row.ChargeCode = -500;
    row.ChargeName = "Total Premium";
    this.ds.tblFin_PolicyCharges.AddtblFin_PolicyChargesRow(row);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblFin_PolicyCharges"
    }, CommandType.Text, "SELECT ChargeName, ChargeCode FROM dbo.GetPremiumsAndCommissionableFeesOnOption(@QuoteOptionGuid)", new object[2]
    {
      (object) "@QuoteOptionGuid",
      (object) this._quoteOptionGuid
    });
    this.daComm.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quoteGuid;
    this.daComm.SelectCommand.Parameters["@CompanyLineGuid"].Value = (object) this._companyLineGuid;
    this.ds.EnforceConstraints = false;
    DefaultDatabase.DataAdapterFill(this.daComm, (DataTable) this.ds.tblPolicyCommissions);
    try
    {
      this.ds.EnforceConstraints = true;
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      for (int index = this.ds.tblPolicyCommissions.Count - 1; index >= 0; index += -1)
      {
        dsPolicyCommissions.tblPolicyCommissionsRow policyCommission = this.ds.tblPolicyCommissions[index];
        if (this.ds.tblFin_PolicyCharges.FindByChargeCode(policyCommission.ChargeCode) == null)
        {
          string str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT ChargeName FROM tblFin_PolicyCharges WHERE ChargeCode=@CC", new object[2]
          {
            (object) "@CC",
            (object) policyCommission.ChargeCode
          });
          int num = (int) MessageBox.Show($"{frmPolicyCommissions.GetEntityName(policyCommission.EntityGuid)} is set to receive commissions on \n\"{str}\", which is no longer commissionable.\n\nThey have been removed from the commissions setup.", "Invalid Commissions Setup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblPolicyCommissions WHERE ID=@ID", new object[2]
          {
            (object) "@ID",
            (object) policyCommission.ID
          });
          this.ds.tblPolicyCommissions.RemovetblPolicyCommissionsRow(policyCommission);
        }
      }
      this.ds.EnforceConstraints = true;
      ProjectData.ClearProjectError();
    }
    this.FillGrid();
    ((Control) this.dbSave).Enabled = !new Quote(this._quoteGuid).IsBound;
    this.ds.View.DefaultView.RowFilter = "WaivedByUserGuid IS NULL";
    MDIControls.Instance.StatusBarText = string.Empty;
  }

  private void mnuReinstate_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to reinstate the following waived entity?\n\n" + ((UltraGridBase) this.dgComm).ActiveRow.Cells["Participant"].Value.ToString(), "Reinstate Auto-Applied Entity?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    this.CurrenttblPolicyCommissionsRow.SetWaivedByUserGuidNull();
    try
    {
      frmPolicyCommissions.ColorWaivedRows(((UltraGridBase) this.dgComm).ActiveRow);
      this.SaveData();
      this.mnuReinstate.Enabled = false;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("An error occured while trying to waive this entity:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
  }

  private void ColorWaivedRows()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dgComm).Rows)
    {
      if (row.Cells["WaivedByUserGuid"].Value != DBNull.Value)
        frmPolicyCommissions.ColorWaivedRows(row);
    }
  }

  private static void ColorWaivedRows(UltraGridRow row)
  {
    if (row.Cells["WaivedByUserGuid"].Value != DBNull.Value)
    {
      row.Appearance.ForeColor = Color.Red;
      row.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
    }
    else
    {
      row.Appearance.ForeColor = SystemColors.ControlText;
      row.Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
    }
  }

  private void ConvertToManual()
  {
    if (this.CurrenttblPolicyCommissionsRow == null)
      return;
    dsPolicyCommissions.tblPolicyCommissionsRow policyCommissionsRow = this.CurrenttblPolicyCommissionsRow;
    dsPolicyCommissions.tblPolicyCommissionsRow row = this.ds.tblPolicyCommissions.NewtblPolicyCommissionsRow();
    row.ChargeCode = policyCommissionsRow.ChargeCode;
    row.CommissionsFromOperatingAccount = policyCommissionsRow.CommissionsFromOperatingAccount;
    row.CommissionTypeID = policyCommissionsRow.CommissionTypeID;
    row.CompanyLineGuid = policyCommissionsRow.CompanyLineGuid;
    row.EntityGuid = policyCommissionsRow.EntityGuid;
    row.EntityTypeID = policyCommissionsRow.EntityTypeID;
    row.QuoteGuid = policyCommissionsRow.QuoteGuid;
    if (policyCommissionsRow.IsPercentageNull())
      row.SetPercentageNull();
    else
      row.Percentage = policyCommissionsRow.Percentage;
    if (policyCommissionsRow.IsOptionFeeIDNull())
      row.SetOptionFeeIDNull();
    else
      row.OptionFeeID = policyCommissionsRow.OptionFeeID;
    if (policyCommissionsRow.IsFlatAmountNull())
      row.SetFlatAmountNull();
    else
      row.FlatAmount = policyCommissionsRow.FlatAmount;
    if (policyCommissionsRow.IsConvertedToManualUserGuidNull())
      row.SetConvertedToManualUserGuidNull();
    else
      row.ConvertedToManualUserGuid = policyCommissionsRow.ConvertedToManualUserGuid;
    if (policyCommissionsRow.IsPremiumIDNull())
      row.SetPremiumIDNull();
    else
      row.PremiumID = policyCommissionsRow.PremiumID;
    if (policyCommissionsRow.IsWaivedByUserGuidNull())
      row.SetWaivedByUserGuidNull();
    else
      row.WaivedByUserGuid = policyCommissionsRow.WaivedByUserGuid;
    row.ConvertedToManualUserGuid = CurrentUser.Instance.UserGUID;
    this.CurrenttblPolicyCommissionsRow.Delete();
    this.ds.tblPolicyCommissions.AddtblPolicyCommissionsRow(row);
    this.dbSave.UIState = (UIState) 2;
  }

  private void mnuManual_Click(object sender, EventArgs e) => this.ConvertToManual();

  private void cm_Popup(object sender, EventArgs e)
  {
    if (this.CurrenttblPolicyCommissionsRow == null)
      return;
    object objectValue = RuntimeHelpers.GetObjectValue(((ControlUIElementBase) ((UltraGridBase) this.dgComm).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridRow), true));
    if (objectValue != null && ((Control) this.dbSave).Enabled)
    {
      UltraGridRow ultraGridRow = (UltraGridRow) objectValue;
      ultraGridRow.Activate();
      this.mnuManual.Enabled = this.CurrenttblPolicyCommissionsRow.AutoApplied;
      this.mnuWaive.Enabled = this.CurrenttblPolicyCommissionsRow.AutoApplied && this.CurrenttblPolicyCommissionsRow.IsWaivedByUserGuidNull();
      this.mnuReinstate.Enabled = !this.CurrenttblPolicyCommissionsRow.IsWaivedByUserGuidNull();
      this.dgComm.Selected.Rows.Clear();
      ultraGridRow.Selected = true;
    }
    else
    {
      this.mnuManual.Enabled = false;
      this.mnuWaive.Enabled = false;
      this.mnuReinstate.Enabled = false;
    }
  }

  private void mnuWaive_Click(object sender, EventArgs e) => this.WaiveEntity();

  private void WaiveEntity()
  {
    UltraGridRow activeRow = ((UltraGridBase) this.dgComm).ActiveRow;
    if (MessageBox.Show("Are you sure you want to waive the following auto-applied entity?\n\n" + activeRow.Cells["Participant"].Value.ToString(), "Waive Auto-Applied Entity?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    this.CurrenttblPolicyCommissionsRow.WaivedByUserGuid = CurrentUser.Instance.UserGUID;
    frmPolicyCommissions.ColorWaivedRows(activeRow);
    this.SaveData();
  }

  private void chkShowWaived_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.chkShowWaived).Checked)
    {
      this.ds.View.DefaultView.RowFilter = string.Empty;
      this.ColorWaivedRows();
    }
    else
      this.ds.View.DefaultView.RowFilter = "WaivedByUserGuid IS NULL";
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (this.CurrenttblPolicyCommissionsRow == null)
    {
      e.Cancel = true;
      this.PopulateFields();
    }
    else
    {
      if (!this.CurrenttblPolicyCommissionsRow.AutoApplied)
        return;
      if (MessageBox.Show("This entity has been auto-applied.\n\nBefore you can edit this record, it must be converted to a manual entry.\n\nWould you like to convert this record at this time?", "Convert to Manual?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
        this.ConvertToManual();
      else
        e.Cancel = true;
    }
  }

  private void GetQuoteCompanyLineGuids(Guid quoteOptionGuid)
  {
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT QD.QuoteGUID, QD.CompanyLineGUID FROM tblQuoteOptions QO WITH (NOLOCK) INNER JOIN tblQuotes Q WITH (NOLOCK) ON QO.QuoteGUID = Q.QuoteGUID INNER JOIN tblQuoteDetails QD WITH (NOLOCK) ON Q.QuoteGUID = QD.QuoteGUID INNER JOIN tblCompanyLines CL WITH (NOLOCK) ON QD.CompanyLineGUID = CL.CompanyLineGUID AND QO.LineGUID = CL.LineGUID WHERE (QO.QuoteOptionGUID = @QuoteOptionGuid)", new object[2]
    {
      (object) "@QuoteOptionGuid",
      (object) quoteOptionGuid
    });
    this._quoteGuid = row.Field<Guid>("QuoteGuid");
    this._companyLineGuid = row.Field<Guid>("CompanyLineGuid");
  }

  private void FillGrid()
  {
    this.ds.lstEntityTypes.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstEntityTypes"
    }, CommandType.Text, "SELECT * FROM lstEntityTypes WHERE EntityTypeID IN (SELECT EntityTypeID FROM tblPolicyCommissions WHERE QuoteGuid=@QuoteGuid)", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this._quoteGuid
    });
    this.ds.View.Clear();
    DataRow[] dataRowArray1 = this.ds.tblPolicyCommissions.Select("CommissionTypeID='GR' OR CommissionTypeID='FG' OR CommissionTypeID='GP'");
    int index1 = 0;
    while (index1 < dataRowArray1.Length)
    {
      this.AddGridRow((dsPolicyCommissions.tblPolicyCommissionsRow) dataRowArray1[index1]);
      checked { ++index1; }
    }
    DataRow[] dataRowArray2 = this.ds.tblPolicyCommissions.Select("CommissionTypeID='NT' OR CommissionTypeID='FN'");
    int index2 = 0;
    while (index2 < dataRowArray2.Length)
    {
      this.AddGridRow((dsPolicyCommissions.tblPolicyCommissionsRow) dataRowArray2[index2]);
      checked { ++index2; }
    }
    DataRow[] dataRowArray3 = this.ds.tblPolicyCommissions.Select("CommissionTypeID='FA' OR CommissionTypeID='NA'");
    int index3 = 0;
    while (index3 < dataRowArray3.Length)
    {
      this.AddGridRow((dsPolicyCommissions.tblPolicyCommissionsRow) dataRowArray3[index3]);
      checked { ++index3; }
    }
  }

  private static string GetEntityName(Guid entityGuid)
  {
    return DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.GetEntityName(@EG)", new object[2]
    {
      (object) "@EG",
      (object) entityGuid
    });
  }

  private void AddGridRow(dsPolicyCommissions.tblPolicyCommissionsRow dr)
  {
    dsPolicyCommissions.tblFin_PolicyChargesRow policyChargesRow = !dr.IsChargeCodeNull() ? this.ds.tblFin_PolicyCharges.FindByChargeCode(dr.ChargeCode) : this.ds.tblFin_PolicyCharges.FindByChargeCode(-500);
    dsPolicyCommissions.ViewRow row = this.ds.View.NewViewRow();
    row.Participant = frmPolicyCommissions.GetEntityName(dr.EntityGuid);
    if (!dr.IsPercentageNull())
      row.Percentage = dr.Percentage;
    else
      row.DollarAmount = dr.FlatAmount;
    row.CommissionFrom = this.ds.lstCommissionTypes.FindByCommissionTypeID(dr.CommissionTypeID).Description;
    row.CommissionTypeID = dr.CommissionTypeID;
    row.EntityGuid = dr.EntityGuid;
    row.EntityType = this.ds.lstEntityTypes.FindByEntityTypeID(dr.EntityTypeID).Description;
    row.Premium = policyChargesRow.ChargeName;
    row.ChargeCode = policyChargesRow.ChargeCode;
    if (dr.IsWaivedByUserGuidNull())
      row.SetWaivedByUserGuidNull();
    else
      row.WaivedByUserGuid = dr.WaivedByUserGuid;
    this.ds.View.AddViewRow(row);
  }

  private dsPolicyCommissions.tblPolicyCommissionsRow GettblPolicyCommissionsRow(
    Guid entityGuid,
    int chargeCode)
  {
    DataRow[] dataRowArray = this.ds.tblPolicyCommissions.Select($"EntityGuid='{entityGuid.ToString()}' AND ChargeCode{Interaction.IIf(chargeCode == -500, (object) " IS NULL", (object) ("=" + chargeCode.ToString())).ToString()}");
    return dataRowArray.Length != 0 ? (dsPolicyCommissions.tblPolicyCommissionsRow) dataRowArray[0] : (dsPolicyCommissions.tblPolicyCommissionsRow) null;
  }

  private bool SaveData()
  {
    bool flag;
    try
    {
      dsPolicyCommissions.tblPolicyCommissionsRow row = this.GettblPolicyCommissionsRow(this.ctlEntity.EntityGuid, this.ctlEntity.ChargeCode) ?? this.ds.tblPolicyCommissions.NewtblPolicyCommissionsRow();
      row.CommissionsFromOperatingAccount = ((UltraToggleEditorBase) this.ctlEntity.chkOperatingAccount).Checked;
      row.EntityGuid = this.ctlEntity.EntityGuid;
      row.QuoteGuid = this._quoteGuid;
      if (this.ctlEntity.CommissionOnTotalPremium)
        row.SetChargeCodeNull();
      else
        row.ChargeCode = this.ctlEntity.ChargeCode;
      row.CompanyLineGuid = this._companyLineGuid;
      row.CommissionTypeID = this.ctlEntity.CommissionTypeID;
      row.EntityTypeID = this.ctlEntity.EntityTypeID;
      if (this.ctlEntity.SelectedPolicyChargeType == AddCommissionableEntity.PolicyChargeTypes.Fee)
      {
        row.OptionFeeID = this.ctlEntity.SelectedPolicyChargeCodeID;
        row.SetPremiumIDNull();
      }
      else if (this.ctlEntity.SelectedPolicyChargeType == AddCommissionableEntity.PolicyChargeTypes.Premium)
      {
        row.PremiumID = this.ctlEntity.SelectedPolicyChargeCodeID;
        row.SetOptionFeeIDNull();
      }
      else
      {
        row.SetPremiumIDNull();
        row.SetOptionFeeIDNull();
      }
      if (((UltraToggleEditorBase) this.ctlEntity.chkFlat).Checked)
      {
        row.FlatAmount = Math.Round(Conversions.ToDecimal(((UltraNumericEditor) this.ctlEntity.txtAmount).Value), 2);
        row.SetPercentageNull();
      }
      else
      {
        row.Percentage = Conversions.ToDecimal(((UltraNumericEditor) this.ctlEntity.txtAmount).Value);
        row.SetFlatAmountNull();
      }
      if (row.RowState == DataRowState.Detached)
        this.ds.tblPolicyCommissions.AddtblPolicyCommissionsRow(row);
      DefaultDatabase.DataAdapterUpdate(this.daComm, (DataTable) this.ds.tblPolicyCommissions);
      CurrentUser.Instance.LogAction($"Commission Participant Added - Entity: {this.ctlEntity.Entity} Type: {this.ctlEntity.EntityType}", this._quoteGuid);
      this.FillGrid();
      flag = true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.IsValidData())
    {
      e.Cancel = true;
    }
    else
    {
      if (this.SaveData())
        return;
      e.Cancel = true;
    }
  }

  private bool IsValidData()
  {
    bool flag = true;
    this.err.SetError((Control) this.ctlEntity.rbNetAfter, string.Empty);
    if (!this.ctlEntity.rbGross.Checked && !this.ctlEntity.rbGrossPremium.Checked && !this.ctlEntity.rbNet.Checked && !this.ctlEntity.rbNetAfter.Checked)
    {
      this.err.SetError((Control) this.ctlEntity.rbNetAfter, "In order to continue please select one of these radio buttons.");
      flag = false;
    }
    return flag;
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e) => this.ctlEntity.ClearInput();

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ctlEntity.ClearErrors();
    this.PopulateFields();
    e.Cancel = true;
  }

  private dsPolicyCommissions.tblPolicyCommissionsRow CurrenttblPolicyCommissionsRow
  {
    get
    {
      return ((UltraGridBase) this.dgComm).ActiveRow != null ? this.GettblPolicyCommissionsRow((Guid) ((UltraGridBase) this.dgComm).ActiveRow.Cells["EntityGuid"].Value, (int) ((UltraGridBase) this.dgComm).ActiveRow.Cells["ChargeCode"].Value) : (dsPolicyCommissions.tblPolicyCommissionsRow) null;
    }
  }

  private void PopulateFields()
  {
    if (((UltraGridBase) this.dgComm).ActiveRow == null)
    {
      this.ctlEntity.ClearInput();
      if (((UltraGridBase) this.dgComm).Rows.Count == 0)
        this.dbSave.UIState = (UIState) 0;
      else
        this.dbSave.UIState = (UIState) 1;
    }
    else
    {
      Guid guid = (Guid) ((UltraGridBase) this.dgComm).ActiveRow.Cells["EntityGuid"].Value;
      int num = (int) ((UltraGridBase) this.dgComm).ActiveRow.Cells["ChargeCode"].Value;
      dsPolicyCommissions.tblPolicyCommissionsRow policyCommissionsRow = this.GettblPolicyCommissionsRow(guid, num);
      if (policyCommissionsRow == null)
        return;
      dsPolicyCommissions.ViewRow entityGuidChargeCode = this.ds.View.FindByEntityGuidChargeCode(guid, num);
      this.ctlEntity.Entity = entityGuidChargeCode.Participant;
      this.ctlEntity.EntityGuid = entityGuidChargeCode.EntityGuid;
      this.ctlEntity.EntityType = entityGuidChargeCode.EntityType;
      this.ctlEntity.EntityTypeID = this.GettblPolicyCommissionsRow(guid, num).EntityTypeID;
      ((UltraCombo) this.ctlEntity.cboChargeCodes).Value = (object) ((dsPolicyCommissions.tblFin_PolicyChargesRow) this.ds.tblFin_PolicyCharges.Select($"ChargeName='{entityGuidChargeCode.Premium}'")[0]).ChargeCode;
      ((UltraToggleEditorBase) this.ctlEntity.chkOperatingAccount).Checked = policyCommissionsRow.CommissionsFromOperatingAccount;
      string commissionTypeId = policyCommissionsRow.CommissionTypeID;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(commissionTypeId))
      {
        case 686187615:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(commissionTypeId, "NT", false) == 0)
          {
            AddCommissionableEntity ctlEntity = this.ctlEntity;
            ctlEntity.rbNet.Checked = true;
            ((UltraToggleEditorBase) ctlEntity.chkFlat).Checked = false;
            ((UltraWinEditorMaskedControlBase) ctlEntity.txtAmount).Text = policyCommissionsRow.Percentage.ToString();
            break;
          }
          break;
        case 870741424:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(commissionTypeId, "NA", false) == 0)
          {
            AddCommissionableEntity ctlEntity = this.ctlEntity;
            ctlEntity.rbNetAfter.Checked = true;
            ((UltraToggleEditorBase) ctlEntity.chkFlat).Checked = false;
            ((UltraWinEditorMaskedControlBase) ctlEntity.txtAmount).Text = policyCommissionsRow.Percentage.ToString();
            break;
          }
          break;
        case 1825638684:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(commissionTypeId, "GR", false) == 0)
          {
            AddCommissionableEntity ctlEntity = this.ctlEntity;
            ctlEntity.rbGross.Checked = true;
            ((UltraToggleEditorBase) ctlEntity.chkFlat).Checked = false;
            ((UltraWinEditorMaskedControlBase) ctlEntity.txtAmount).Text = policyCommissionsRow.Percentage.ToString();
            break;
          }
          break;
        case 1859193922:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(commissionTypeId, "GP", false) == 0)
          {
            AddCommissionableEntity ctlEntity = this.ctlEntity;
            ctlEntity.rbGrossPremium.Checked = true;
            ((UltraToggleEditorBase) ctlEntity.chkFlat).Checked = false;
            ((UltraWinEditorMaskedControlBase) ctlEntity.txtAmount).Text = policyCommissionsRow.Percentage.ToString();
            break;
          }
          break;
        case 2194893397:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(commissionTypeId, "FN", false) == 0)
          {
            AddCommissionableEntity ctlEntity = this.ctlEntity;
            ctlEntity.rbNet.Checked = true;
            ((UltraToggleEditorBase) ctlEntity.chkFlat).Checked = true;
            ((UltraWinEditorMaskedControlBase) ctlEntity.txtAmount).Text = policyCommissionsRow.FlatAmount.ToString();
            break;
          }
          break;
        case 2211671016:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(commissionTypeId, "FA", false) == 0)
          {
            AddCommissionableEntity ctlEntity = this.ctlEntity;
            ctlEntity.rbNetAfter.Checked = true;
            ((UltraToggleEditorBase) ctlEntity.chkFlat).Checked = true;
            ((UltraWinEditorMaskedControlBase) ctlEntity.txtAmount).Text = policyCommissionsRow.FlatAmount.ToString();
            break;
          }
          break;
        case 2312336730:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(commissionTypeId, "FG", false) == 0)
          {
            AddCommissionableEntity ctlEntity = this.ctlEntity;
            ctlEntity.rbGross.Checked = true;
            ((UltraToggleEditorBase) ctlEntity.chkFlat).Checked = true;
            ((UltraWinEditorMaskedControlBase) ctlEntity.txtAmount).Text = policyCommissionsRow.FlatAmount.ToString();
            break;
          }
          break;
      }
      this.dbSave.UIState = (UIState) 1;
    }
  }

  private void dgComm_AfterRowActivate(object sender, EventArgs e) => this.PopulateFields();

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.dgComm).Enabled = this.dbSave.UIState != 2;
    this.ctlEntity.Enabled = this.dbSave.UIState == 2;
  }

  private void LblShowProducerLocationEntities_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      using (FormSettings.ShowFormDialog(typeof (FormShowProdLocCommissionEntities), new object[3]
      {
        (object) this._quoteGuid,
        (object) "L",
        (object) this.ds
      }))
        ;
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void LblShowCompanyEntities_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      using (FormSettings.ShowFormDialog(typeof (FormShowProdLocCommissionEntities), new object[3]
      {
        (object) this._quoteGuid,
        (object) "C",
        (object) this.ds
      }))
        ;
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.dgComm).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select an entity from the grid to delete.", "No Entity Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
      if (((UltraGridBase) this.dgComm).Rows.Count == 0)
        this.dbSave.UIState = (UIState) 0;
      else
        this.dbSave.UIState = (UIState) 1;
    }
    else
    {
      dsPolicyCommissions.tblPolicyCommissionsRow policyCommissionsRow = this.GettblPolicyCommissionsRow((Guid) ((UltraGridBase) this.dgComm).ActiveRow.Cells["EntityGuid"].Value, (int) ((UltraGridBase) this.dgComm).ActiveRow.Cells["ChargeCode"].Value);
      if (policyCommissionsRow == null)
        return;
      if (policyCommissionsRow.AutoApplied)
        this.WaiveEntity();
      else if (MessageBox.Show($"Are you sure you want to delete {this.ctlEntity.Entity} from the commissions list?", "Delete Entity?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        try
        {
          policyCommissionsRow.Delete();
          DefaultDatabase.DataAdapterUpdate(this.daComm, (DataTable) this.ds.tblPolicyCommissions);
          CurrentUser.Instance.LogAction($"Commission Participant Deleted - Entity: {this.ctlEntity.Entity} - Type: {this.ctlEntity.EntityType}", this._quoteGuid);
          this.FillGrid();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ErrorHandler.HandleError(ex);
          e.Cancel = true;
          ProjectData.ClearProjectError();
        }
      }
      this.PopulateFields();
    }
  }

  private enum FeeTypes
  {
    Commissionable,
    InternalOnly,
  }
}
