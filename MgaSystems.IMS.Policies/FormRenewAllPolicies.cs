// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormRenewAllPolicies
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.Policies.Claims;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Security;
using MGASystems.InfragisticsExtensions.Editors;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormRenewAllPolicies : Form
{
  private IContainer components;
  private int _controlNo;
  private Quote _quote;
  private Guid _submissionGroupGuid;
  private MemoryStream _gridlayout;
  private HyperlinkEditor _hlkControlNo;
  private HyperlinkEditor _hlkClaims;
  private HyperlinkEditor _hlkRenewalControlNo;
  private Guid _producerLocationGuid;
  private byte _producerStatus;
  private bool _canRenewProducerInactive;
  private SubmissionGroup _submissionGroup;
  private bool _canRenewCompanyLineInactive;
  private object _procLock;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("dt", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Line");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Expiration");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Premium");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("RenewalExists");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("CompanyLineActive");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ProducerActive");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Renew");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ExistingRenewalNum");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Claims");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormRenewAllPolicies));
    this.ugRenewAll = new UltraGrid();
    this.ds = new dsRenewAll();
    this.lnkDeselectAll = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.btnRenewAll = new MGAButton();
    ((ISupportInitialize) this.ugRenewAll).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnRenewAll).BeginInit();
    this.SuspendLayout();
    ((Control) this.ugRenewAll).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugRenewAll).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugRenewAll).DataMember = "dt";
    ((UltraGridBase) this.ugRenewAll).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 183;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Control #";
    ultraGridColumn2.Header.VisiblePosition = 5;
    ultraGridColumn2.Width = 84;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Policy #";
    ultraGridColumn3.Header.VisiblePosition = 7;
    ultraGridColumn3.Width = 123;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ultraGridColumn4.Header.VisiblePosition = 8;
    ultraGridColumn4.Width = 92;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ultraGridColumn5.Header.VisiblePosition = 9;
    ultraGridColumn5.Width = 56;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ultraGridColumn6.Header.VisiblePosition = 10;
    ultraGridColumn6.Width = 56;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn7.Format = "c";
    ultraGridColumn7.Header.VisiblePosition = 11;
    ultraGridColumn7.Width = 76;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Renewal Exists";
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.Width = 83;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Carrier In-Active";
    ultraGridColumn9.Header.VisiblePosition = 3;
    ultraGridColumn9.Width = 91;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Producer In-Active";
    ultraGridColumn10.Header.VisiblePosition = 4;
    ultraGridColumn10.Width = 115;
    ultraGridColumn11.Header.VisiblePosition = 12;
    ultraGridColumn11.Width = 41;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Renewal #";
    ultraGridColumn12.Header.VisiblePosition = 2;
    ultraGridColumn12.Width = 92;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Center";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn13.Header.VisiblePosition = 6;
    ultraGridColumn13.Width = 67;
    ultraGridBand.Columns.AddRange(new object[13]
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
      (object) ultraGridColumn13
    });
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.Override.SelectTypeCell = (SelectType) 2;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugRenewAll).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugRenewAll).Location = new Point(12, 12);
    ((Control) this.ugRenewAll).Name = "ugRenewAll";
    ((Control) this.ugRenewAll).Size = new Size(978, 344);
    ((Control) this.ugRenewAll).TabIndex = 2;
    ((Control) this.ugRenewAll).Text = "Policies";
    ((UltraControlBase) this.ugRenewAll).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugRenewAll).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsRenewAll";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkDeselectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeselectAll.AutoSize = true;
    this.lnkDeselectAll.BackColor = Color.Transparent;
    this.lnkDeselectAll.Location = new Point(12, 405);
    this.lnkDeselectAll.Name = "lnkDeselectAll";
    this.lnkDeselectAll.Size = new Size(128 /*0x80*/, 13);
    this.lnkDeselectAll.TabIndex = 314;
    this.lnkDeselectAll.TabStop = true;
    this.lnkDeselectAll.Text = "De-Select ALL for Renew";
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.BackColor = Color.Transparent;
    this.lnkSelectAll.Location = new Point(12, 373);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(111, 13);
    this.lnkSelectAll.TabIndex = 313;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select ALL for Renew";
    ((Control) this.btnRenewAll).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance11.BackColor = Color.FromArgb(248, 248, 248);
    appearance11.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance11.BackGradientStyle = (GradientStyle) 2;
    appearance11.BorderColor = Color.DarkGray;
    appearance11.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance11.Image"));
    appearance11.ImageHAlign = (HAlign) 1;
    appearance11.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnRenewAll).Appearance = (AppearanceBase) appearance11;
    ((Control) this.btnRenewAll).Font = new Font("Tahoma", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnRenewAll).Location = new Point(905, 375);
    ((Control) this.btnRenewAll).Name = "btnRenewAll";
    ((ControlBase) this.btnRenewAll).Padding = new Size(5, 0);
    ((Control) this.btnRenewAll).Size = new Size(85, 40);
    ((Control) this.btnRenewAll).TabIndex = 315;
    ((ControlBase) this.btnRenewAll).Text = "Renew";
    this.btnRenewAll.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1002, 427);
    this.Controls.Add((Control) this.btnRenewAll);
    this.Controls.Add((Control) this.lnkDeselectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.ugRenewAll);
    this.Name = nameof (FormRenewAllPolicies);
    this.Text = "Available Polices";
    ((ISupportInitialize) this.ugRenewAll).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnRenewAll).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("ugRenewAll")]
  private virtual UltraGrid ugRenewAll { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsRenewAll ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkDeselectAll
  {
    get => this._lnkDeselectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeselectAll_LinkClicked);
      LinkLabel lnkDeselectAll1 = this._lnkDeselectAll;
      if (lnkDeselectAll1 != null)
        lnkDeselectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeselectAll = value;
      LinkLabel lnkDeselectAll2 = this._lnkDeselectAll;
      if (lnkDeselectAll2 == null)
        return;
      lnkDeselectAll2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkSelectAll
  {
    get => this._lnkSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
      LinkLabel lnkSelectAll1 = this._lnkSelectAll;
      if (lnkSelectAll1 != null)
        lnkSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAll = value;
      LinkLabel lnkSelectAll2 = this._lnkSelectAll;
      if (lnkSelectAll2 == null)
        return;
      lnkSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGAButton btnRenewAll
  {
    get => this._btnRenewAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRenewAll_Click);
      MGAButton btnRenewAll1 = this._btnRenewAll;
      if (btnRenewAll1 != null)
        ((Control) btnRenewAll1).Click -= eventHandler;
      this._btnRenewAll = value;
      MGAButton btnRenewAll2 = this._btnRenewAll;
      if (btnRenewAll2 == null)
        return;
      ((Control) btnRenewAll2).Click += eventHandler;
    }
  }

  public int CurrentPolicyControlNo => this._controlNo;

  public Guid CurrentSubmissionGroupGuid => this._submissionGroupGuid;

  protected FormRenewAllPolicies()
  {
    this.Load += new EventHandler(this.FormRenewAllPolicies_Load);
    this._gridlayout = new MemoryStream();
    this._hlkControlNo = new HyperlinkEditor();
    this._hlkClaims = new HyperlinkEditor();
    this._hlkRenewalControlNo = new HyperlinkEditor();
    this._canRenewProducerInactive = true;
    this._canRenewCompanyLineInactive = false;
    this._procLock = RuntimeHelpers.GetObjectValue(new object());
    this.InitializeComponent();
  }

  public FormRenewAllPolicies(int controlNo)
  {
    this.Load += new EventHandler(this.FormRenewAllPolicies_Load);
    this._gridlayout = new MemoryStream();
    this._hlkControlNo = new HyperlinkEditor();
    this._hlkClaims = new HyperlinkEditor();
    this._hlkRenewalControlNo = new HyperlinkEditor();
    this._canRenewProducerInactive = true;
    this._canRenewCompanyLineInactive = false;
    this._procLock = RuntimeHelpers.GetObjectValue(new object());
    this.InitializeComponent();
    this._controlNo = controlNo;
    this._quote = Quote.FromControlNo(controlNo);
    this._submissionGroupGuid = this._quote.SubmissionGroupGuid;
    this._submissionGroup = new SubmissionGroup(this._submissionGroupGuid);
    this._producerLocationGuid = new SubmissionGroup(this._submissionGroupGuid).ProducerLocationGuid;
    ProducerLocation producerLocation = new ProducerLocation(this._producerLocationGuid);
    this._canRenewProducerInactive = SecurityManager.Instance.AssertPermission("{4AC22A74-7B62-40d3-B78D-CC400DFE3F26}") && SecurityManager.Instance.AssertPermission("{26DBE3BE-3745-414e-8F30-C9315E9A3AA4}");
    this._canRenewCompanyLineInactive = SecurityManager.Instance.AssertPermission("{BBE67BFC-DC78-4984-AB6F-A612D43AACA3}");
  }

  private void FormRenewAllPolicies_Load(object sender, EventArgs e)
  {
    this._hlkControlNo.HyperLinkOpening += new CancelEventHandler(this._hlkControlNo_Opening);
    this._hlkClaims.HyperLinkOpening += new CancelEventHandler(this._hlkClaims_Opening);
    this._hlkRenewalControlNo.HyperLinkOpening += new CancelEventHandler(this._hlkRenewalControlNo_Opening);
    ((Control) this.btnRenewAll).Enabled = false;
    ((UltraGridBase) this.ugRenewAll).DisplayLayout.Save((Stream) this._gridlayout);
    ((UltraGridBase) this.ugRenewAll).DataSource = (object) null;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.LoadPoliciesThread));
  }

  private void HandleError(Exception ex)
  {
  }

  private void LoadPoliciesThread(object state)
  {
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "dt"
      }, this.RenewAllProc(), new object[2]
      {
        (object) "@ControlNo",
        (object) this.CurrentPolicyControlNo
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new FormRenewAllPolicies.HandleErrorOnUIThread(this.HandleError), new object[1]
      {
        (object) ex
      });
      ProjectData.ClearProjectError();
    }
    if (((!this.IsHandleCreated ? 0 : (!this.IsDisposed ? 1 : 0)) & (!this.Disposing ? 1 : 0)) == 0)
      return;
    try
    {
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.LoadPoliciesThreadComplete), new object[0]);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void LoadPoliciesThreadComplete()
  {
    // ISSUE: unable to decompile the method.
  }

  private bool RenewalExistsPassCheck(UltraGridRow row) => !(bool) row.Cells["RenewalExists"].Value;

  private bool ProducerPassCheck(UltraGridRow row)
  {
    return !(bool) row.Cells["ProducerActive"].Value || (bool) row.Cells["ProducerActive"].Value && this._canRenewProducerInactive;
  }

  private bool CompanyLinePassCheck(UltraGridRow row)
  {
    return !(bool) row.Cells["CompanyLineActive"].Value || (bool) row.Cells["CompanyLineActive"].Value && this._canRenewCompanyLineInactive;
  }

  private void _hlkControlNo_Opening(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.ugRenewAll).ActiveRow.Cells["ControlNo"].Value == DBNull.Value)
      return;
    FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
    {
      (object) Conversions.ToInteger(((UltraGridBase) this.ugRenewAll).ActiveRow.Cells["ControlNo"].Value)
    });
  }

  private void _hlkClaims_Opening(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.ugRenewAll).ActiveRow.Cells["Claims"].Value == DBNull.Value)
      return;
    FormSettings.ShowForm(typeof (frmClaims), new object[1]
    {
      (object) (Guid) ((UltraGridBase) this.ugRenewAll).ActiveRow.Cells["QuoteGuid"].Value
    });
  }

  private void _hlkRenewalControlNo_Opening(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.ugRenewAll).ActiveRow.Cells["ExistingRenewalNum"].Value == DBNull.Value)
      return;
    FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
    {
      (object) Conversions.ToInteger(((UltraGridBase) this.ugRenewAll).ActiveRow.Cells["ExistingRenewalNum"].Value)
    });
  }

  private void SetRenewOnGrid(bool renewValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugRenewAll).Rows)
      row.Cells["Renew"].Value = (object) (bool) (!renewValue ? 0 : (row.Cells["Renew"].Activation != 2 ? 1 : 0));
  }

  private void lnkDeselectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetRenewOnGrid(false);
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetRenewOnGrid(true);
  }

  private void btnRenewAll_Click(object sender, EventArgs e)
  {
    string renewalControlNoString = string.Empty;
    string text = string.Empty;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      CompanyDocumentAutomation.BlackBoxMode = true;
      RowEnumerator enumerator = ((UltraGridBase) this.ugRenewAll).Rows.GetEnumerator();
      while (enumerator.MoveNext())
      {
        UltraGridRow current = enumerator.Current;
        if (current.Cells["Renew"].Value != DBNull.Value && Conversions.ToBoolean(current.Cells["Renew"].Value))
        {
          Guid guid = (Guid) current.Cells["QuoteGuid"].Value;
          Quote objectEx = (Quote) ObjectFactory.Instance.CreateObjectEX(typeof (Quote), new object[1]
          {
            (object) guid
          });
          int integer = Conversions.ToInteger(current.Cells["ControlNo"].Value);
          try
          {
            objectEx.Renew();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Exception exception = ex;
            text = $"{text}Control # {Conversions.ToString(integer)} - {exception.Message}\n";
            ProjectData.ClearProjectError();
          }
          if (current.Cells["CompanyLineActive"].Value != DBNull.Value && Conversions.ToBoolean(current.Cells["CompanyLineActive"].Value))
            CurrentUser.Instance.LogAction("Bypassed warning of renewing on a closed or inactive company/line.", guid);
          renewalControlNoString = $"{renewalControlNoString}{current.Cells["ControlNo"].Value.ToString()}/";
        }
      }
      this.ExecuteRenewalAllOnClient(renewalControlNoString);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
      CompanyDocumentAutomation.BlackBoxMode = false;
    }
    if (!string.IsNullOrEmpty(text))
    {
      int num = (int) MessageBox.Show(text, "Renew Message(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    this.Close();
    if (renewalControlNoString.Equals(string.Empty))
      return;
    FormSettings.ShowFormDialog(typeof (FormRenewAllResults), new object[1]
    {
      (object) renewalControlNoString
    });
  }

  protected virtual void ExecuteRenewalAllOnClient(string renewalControlNoString)
  {
  }

  private string RenewAllProc()
  {
    object procLock = this._procLock;
    ObjectFlowControl.CheckForSyncLockOnValueType(procLock);
    bool lockTaken = false;
    try
    {
      Monitor.Enter(procLock, ref lockTaken);
      return this.RenewAllStoredProcedure();
    }
    finally
    {
      if (lockTaken)
        Monitor.Exit(procLock);
    }
  }

  protected virtual string RenewAllStoredProcedure() => "spGetPoliciesRenewalAll";

  private delegate void HandleErrorOnUIThread(Exception ex);
}
