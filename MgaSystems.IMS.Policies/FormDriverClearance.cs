// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormDriverClearance
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
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
public class FormDriverClearance : Form
{
  private IContainer components;
  private DriverClearance _driverSearchInfo;
  private MemoryStream _layoutStream;
  private int _currentUserID;

  public FormDriverClearance()
  {
    this._currentUserID = CurrentUser.Instance.UserID;
    this.InitializeComponent();
  }

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
    UltraGridBand ultraGridBand = new UltraGridBand("dtDriverSearch", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LastName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("FirstName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Street1");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ProducerLocationName");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("InsuredPolicyName");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("DriverStatus");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("DOB");
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
    this.ugDriverSearch = new UltraGrid();
    this.ds = new dsDriverSearch();
    ((ISupportInitialize) this.ugDriverSearch).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.da.AcceptChangesDuringFill = false;
    this.da.SelectCommand = this.DbSelectCommand3;
    this.DbSelectCommand3.CommandText = "[spDriverClearanceSearchData]";
    this.DbSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand3.Parameters.AddRange((Array) new DbParameter[11]
    {
      DefaultDatabase.CreateParameter("@InsuredName", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@FirstName", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@LastName", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@LicenseNumber", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@ControlNo", SqlDbType.Int),
      DefaultDatabase.CreateParameter("@NumResults", SqlDbType.VarChar, 4),
      DefaultDatabase.CreateParameter("@InforceOnly", SqlDbType.Bit),
      DefaultDatabase.CreateParameter("@SearchingUserID", SqlDbType.Int),
      DefaultDatabase.CreateParameter("@Address", SqlDbType.VarChar, 100),
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2),
      DefaultDatabase.CreateParameter("@Zip", SqlDbType.VarChar, 15)
    });
    ((Control) this.ugDriverSearch).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugDriverSearch).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugDriverSearch).DataMember = "dtDriverSearch";
    ((UltraGridBase) this.ugDriverSearch).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Control #";
    ultraGridColumn1.Header.VisiblePosition = 4;
    ultraGridColumn1.Width = 85;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Policy #";
    ultraGridColumn2.Header.VisiblePosition = 5;
    ultraGridColumn2.Width = 108;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Last";
    ultraGridColumn3.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "First";
    ultraGridColumn4.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "License #";
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Width = 83;
    ultraGridColumn6.Header.VisiblePosition = 9;
    ultraGridColumn7.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "State";
    ultraGridColumn8.Header.VisiblePosition = 3;
    ultraGridColumn9.Header.VisiblePosition = 11;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Producer";
    ultraGridColumn10.Header.VisiblePosition = 8;
    ultraGridColumn10.Width = 142;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Insured";
    ultraGridColumn11.Header.VisiblePosition = 7;
    ultraGridColumn11.Width = 147;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Status";
    ultraGridColumn12.Header.VisiblePosition = 12;
    ultraGridColumn13.Header.VisiblePosition = 6;
    ultraGridColumn13.Width = 65;
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
    ultraGridBand.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 2;
    ultraGridBand.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugDriverSearch).Location = new Point(12, 12);
    ((Control) this.ugDriverSearch).Name = "ugDriverSearch";
    ((Control) this.ugDriverSearch).Size = new Size(891, 585);
    ((Control) this.ugDriverSearch).TabIndex = 60;
    ((Control) this.ugDriverSearch).Text = "Available Drivers";
    ((UltraControlBase) this.ugDriverSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugDriverSearch).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsDriverSearch";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(915, 609);
    this.Controls.Add((Control) this.ugDriverSearch);
    this.Name = nameof (FormDriverClearance);
    this.Text = "Driver Clearance Information";
    ((ISupportInitialize) this.ugDriverSearch).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  protected virtual UltraGrid ugDriverSearch
  {
    get => this._ugDriverSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugDriverSearch_DoubleClick);
      UltraGrid ugDriverSearch1 = this._ugDriverSearch;
      if (ugDriverSearch1 != null)
        ((Control) ugDriverSearch1).DoubleClick -= eventHandler;
      this._ugDriverSearch = value;
      UltraGrid ugDriverSearch2 = this._ugDriverSearch;
      if (ugDriverSearch2 == null)
        return;
      ((Control) ugDriverSearch2).DoubleClick += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsDriverSearch ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("da")]
  private virtual DbDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand3")]
  private virtual DbCommand DbSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected Stream GridLayout
  {
    get
    {
      if (this._layoutStream == null)
        this._layoutStream = new MemoryStream();
      return (Stream) this._layoutStream;
    }
  }

  public virtual void StartSearch(DriverClearance dSearch)
  {
    this.Cursor = MgaCursors.WaitCursor;
    ((UltraControlBase) this.ugDriverSearch).Cursor = MgaCursors.WaitCursor;
    this._driverSearchInfo = dSearch;
    this.ds.dtDriverSearch.Clear();
    List<object> objectList = new List<object>();
    objectList.Add((object) "@InsuredName");
    objectList.Add((object) this._driverSearchInfo.InsuredName);
    objectList.Add((object) "@FirstName");
    objectList.Add((object) this._driverSearchInfo.FirstName);
    objectList.Add((object) "@LastName");
    objectList.Add((object) this._driverSearchInfo.LastName);
    objectList.Add((object) "@LicenseNumber");
    objectList.Add((object) this._driverSearchInfo.LicenseNumber);
    objectList.Add((object) "@ControlNo");
    objectList.Add((object) this._driverSearchInfo.ControlNo);
    objectList.Add((object) "@Address");
    objectList.Add((object) this._driverSearchInfo.Address);
    objectList.Add((object) "@StateID");
    objectList.Add((object) this._driverSearchInfo.StateID);
    objectList.Add((object) "@Zip");
    objectList.Add((object) this._driverSearchInfo.Zip);
    objectList.Add((object) "@NumResults");
    objectList.Add((object) this._driverSearchInfo.NumResults);
    objectList.Add((object) "@Inforce");
    objectList.Add((object) this._driverSearchInfo.InforceOnly);
    objectList.Add((object) "@SearchingUserID");
    objectList.Add((object) this._currentUserID);
    this.SetClientParameters(objectList, this._driverSearchInfo);
    ((UltraGridBase) this.ugDriverSearch).DisplayLayout.Save(this.GridLayout);
    ((UltraGridBase) this.ugDriverSearch).DataSource = (object) null;
    ((UltraGridBase) this.ugDriverSearch).DataMember = string.Empty;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.DriverSearch), (object) objectList);
  }

  private void DriverSearch(object state)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dtDriverSearch"
    }, this.DriverSearchStoreProcedure(), ((List<object>) state).ToArray());
    if (this.IsDisposed)
      return;
    if (this.Disposing)
      return;
    try
    {
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.DriverSearchComplete), new object[0]);
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void DriverSearchComplete()
  {
    try
    {
      if (((UltraGridBase) this.ugDriverSearch).DisplayLayout != null)
      {
        ((UltraGridBase) this.ugDriverSearch).DataSource = (object) this.ds.dtDriverSearch;
        this.GridLayout.Position = 0L;
        ((UltraGridBase) this.ugDriverSearch).DisplayLayout.Load(this.GridLayout);
        ((UltraGridBase) this.ugDriverSearch).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
      }
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    this.Cursor = MgaCursors.Default;
    ((UltraControlBase) this.ugDriverSearch).Cursor = MgaCursors.Hand;
  }

  protected virtual string DriverSearchStoreProcedure() => "spDriverClearanceSearchData";

  protected virtual void SetClientParameters(List<object> spParameters, DriverClearance sLoc)
  {
  }

  private void ugDriverSearch_DoubleClick(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ugDriverSearch).ActiveRow == null)
      return;
    UIElement lastElementEntered = ((ControlUIElementBase) ((UltraGridBase) this.ugDriverSearch).DisplayLayout.UIElement).LastElementEntered;
    if (!(lastElementEntered is RowUIElement))
    {
      RowUIElement ancestor = (RowUIElement) lastElementEntered.GetAncestor(typeof (RowUIElement));
      if (ancestor == null || (UltraGridRow) ((UIElement) ancestor).GetContext(typeof (UltraGridRow)) == null)
        return;
      Quote quote = Quote.FromControlNo((int) ((UltraGridBase) this.ugDriverSearch).ActiveRow.Cells["ControlNo"].Value);
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
