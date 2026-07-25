// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormAdditionalInterestClearance
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.Policies.PolicyDetail;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormAdditionalInterestClearance : Form
{
  private IContainer components;
  private AdditionalInterestSearch _addlSearchInfo;
  private MemoryStream _layoutStream;
  private int _currentUserID;
  private Dictionary<int, bool> _boundControlNumHash;

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
    UltraGridBand ultraGridBand = new UltraGridBand("dtInterest", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("InterestName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ModificationCode");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ProducerLocationName");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("InsuredPolicyName");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("LOB");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("QuoteStatus");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("InterestType");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    this.da = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand3 = DefaultDatabase.CreateCommand();
    this.ug = new UltraGrid();
    this.ds = new dsAdditionalInterestSearch();
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.da.AcceptChangesDuringFill = false;
    this.da.SelectCommand = this.DbSelectCommand3;
    this.DbSelectCommand3.CommandText = "spAdditionalInterestClearanceSearchData";
    this.DbSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand3.Parameters.AddRange((Array) new DbParameter[12]
    {
      DefaultDatabase.CreateParameter("@InsuredName", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@InterestName", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@FirstName", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@LastName", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@Interest", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@ControlNo", SqlDbType.Int),
      DefaultDatabase.CreateParameter("@Address", SqlDbType.VarChar, 100),
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2),
      DefaultDatabase.CreateParameter("@Zip", SqlDbType.VarChar, 15),
      DefaultDatabase.CreateParameter("@NumResults", SqlDbType.VarChar, 4),
      DefaultDatabase.CreateParameter("@InforceOnly", SqlDbType.Bit),
      DefaultDatabase.CreateParameter("@SearchingUserID", SqlDbType.Int)
    });
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ug).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ug).DataMember = "dtInterest";
    ((UltraGridBase) this.ug).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Control #";
    ultraGridColumn1.Header.VisiblePosition = 5;
    ultraGridColumn1.Width = 97;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Policy #";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 91;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Interest Name";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Mod Code";
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Width = 81;
    ultraGridColumn5.Header.VisiblePosition = 8;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.Header.VisiblePosition = 10;
    ultraGridColumn6.Width = 76;
    ultraGridColumn7.Header.VisiblePosition = 9;
    ultraGridColumn7.Width = 65;
    ultraGridColumn8.Header.VisiblePosition = 11;
    ultraGridColumn8.Width = 70;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Producer";
    ultraGridColumn9.Header.VisiblePosition = 12;
    ultraGridColumn9.Width = 156;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Insured";
    ultraGridColumn10.Header.VisiblePosition = 0;
    ultraGridColumn10.Width = 201;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Line Of Business";
    ultraGridColumn11.Header.VisiblePosition = 6;
    ultraGridColumn12.Header.VisiblePosition = 13;
    ultraGridColumn13.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Quote Status";
    ultraGridColumn14.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Interest Type";
    ultraGridColumn15.Header.VisiblePosition = 3;
    ultraGridBand.Columns.AddRange(new object[15]
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
      (object) ultraGridColumn15
    });
    ultraGridBand.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 2;
    ultraGridBand.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ug).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ug).DisplayLayout.MaxRowScrollRegions = 1;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ug).Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ug).Location = new Point(12, 12);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(777, 462);
    ((Control) this.ug).TabIndex = 60;
    ((Control) this.ug).Text = "Add'l Interest Clearance";
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAdditionalInterestSearch";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(801, 534);
    this.Controls.Add((Control) this.ug);
    this.Name = nameof (FormAdditionalInterestClearance);
    this.Text = "Clearance by Additional Interest";
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  protected virtual UltraGrid ug
  {
    get => this._ug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugDriverSearch_DoubleClick);
      UltraGrid ug1 = this._ug;
      if (ug1 != null)
        ((Control) ug1).DoubleClick -= eventHandler;
      this._ug = value;
      UltraGrid ug2 = this._ug;
      if (ug2 == null)
        return;
      ((Control) ug2).DoubleClick += eventHandler;
    }
  }

  [field: AccessedThroughProperty("da")]
  private virtual DbDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand3")]
  private virtual DbCommand DbSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsAdditionalInterestSearch ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormAdditionalInterestClearance()
  {
    this._currentUserID = CurrentUser.Instance.UserID;
    this._boundControlNumHash = new Dictionary<int, bool>();
    this.InitializeComponent();
    int num = this.DesignMode ? 1 : 0;
  }

  protected Stream GridLayout
  {
    get
    {
      if (this._layoutStream == null)
        this._layoutStream = new MemoryStream();
      return (Stream) this._layoutStream;
    }
  }

  public virtual void StartSearch(AdditionalInterestSearch addlSearch)
  {
    this.Cursor = MgaCursors.WaitCursor;
    ((UltraControlBase) this.ug).Cursor = MgaCursors.WaitCursor;
    this._addlSearchInfo = addlSearch;
    this.ds.dtInterest.Clear();
    List<object> objectList = new List<object>();
    objectList.Add((object) "@InsuredName");
    objectList.Add((object) this._addlSearchInfo.InsuredName);
    objectList.Add((object) "@InterestName");
    objectList.Add((object) this._addlSearchInfo.InterestName);
    objectList.Add((object) "@FirstName");
    objectList.Add((object) this._addlSearchInfo.FirstName);
    objectList.Add((object) "@LastName");
    objectList.Add((object) this._addlSearchInfo.LastName);
    objectList.Add((object) "@Interest");
    objectList.Add((object) this._addlSearchInfo.Interest);
    objectList.Add((object) "@ControlNo");
    objectList.Add((object) this._addlSearchInfo.ControlNo);
    objectList.Add((object) "@Address");
    objectList.Add((object) this._addlSearchInfo.Address);
    objectList.Add((object) "@StateID");
    objectList.Add((object) this._addlSearchInfo.StateID);
    objectList.Add((object) "@Zip");
    objectList.Add((object) this._addlSearchInfo.Zip);
    objectList.Add((object) "@NumResults");
    objectList.Add((object) this._addlSearchInfo.NumResults);
    objectList.Add((object) "@Inforce");
    objectList.Add((object) this._addlSearchInfo.InforceOnly);
    objectList.Add((object) "@SearchingUserID");
    objectList.Add((object) this._currentUserID);
    this.SetClientParameters(objectList, this._addlSearchInfo);
    ((UltraGridBase) this.ug).DisplayLayout.Save(this.GridLayout);
    ((UltraGridBase) this.ug).DataSource = (object) null;
    ((UltraGridBase) this.ug).DataMember = string.Empty;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.AiSearch), (object) objectList);
  }

  private void AiSearch(object state)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dtInterest"
    }, this.AdditionalInterestSearchStoreProcedure(), ((List<object>) state).ToArray());
    if (this.IsDisposed)
      return;
    if (this.Disposing)
      return;
    try
    {
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.SearchComplete), new object[0]);
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void SearchComplete()
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual string AdditionalInterestSearchStoreProcedure()
  {
    return "spAdditionalInterestClearanceSearchData";
  }

  protected virtual void SetClientParameters(
    List<object> spParameters,
    AdditionalInterestSearch addlInterest)
  {
  }

  private void ugDriverSearch_DoubleClick(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ug).ActiveRow == null)
      return;
    UIElement lastElementEntered = ((ControlUIElementBase) ((UltraGridBase) this.ug).DisplayLayout.UIElement).LastElementEntered;
    if (!(lastElementEntered is RowUIElement))
    {
      RowUIElement ancestor = (RowUIElement) lastElementEntered.GetAncestor(typeof (RowUIElement));
      if (ancestor == null || (UltraGridRow) ((UIElement) ancestor).GetContext(typeof (UltraGridRow)) == null)
        return;
      Quote quote = Quote.FromControlNo((int) ((UltraGridBase) this.ug).ActiveRow.Cells["ControlNo"].Value);
      if (quote.IsQuickQuote)
      {
        frmQuoteEdit formEx = (frmQuoteEdit) ObjectFactory.Instance.CreateFormEX(typeof (frmQuoteEdit), new object[2]
        {
          (object) quote.QuoteGuid,
          (object) quote.SubmissionGroupGuid
        });
        formEx.IsQuickQuote = true;
        ((Form) formEx).MdiParent = MDIControls.Instance.MDIParent;
        ((Control) formEx).Show();
      }
      else
        FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
        {
          (object) quote.QuoteGuid
        });
    }
  }
}
