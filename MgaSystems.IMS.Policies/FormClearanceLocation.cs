// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormClearanceLocation
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
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormClearanceLocation : Form
{
  private IContainer components;
  private LocationClearance _locSearchInfo;
  private MemoryStream _layoutStream;
  private int _currentUserID;

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
    UltraGridBand ultraGridBand = new UltraGridBand("dtLocationSearch", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Line");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("LocationNo");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("BuildingNo");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Address");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Zip");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ProducerLocationName");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("InsuredPolicyName");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("LocStatus");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("TransAdded");
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
    this.daLoc = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand3 = DefaultDatabase.CreateCommand();
    this.ugLocSearch = new UltraGrid();
    this.ds = new dsLocationSearch();
    ((ISupportInitialize) this.ugLocSearch).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.daLoc.AcceptChangesDuringFill = false;
    this.daLoc.SelectCommand = this.DbSelectCommand3;
    this.DbSelectCommand3.CommandText = "[GetLocationSearchData]";
    this.DbSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand3.Parameters.AddRange((Array) new DbParameter[8]
    {
      DefaultDatabase.CreateParameter("@InsuredName", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@locStreet", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@locCity", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@locState", SqlDbType.VarChar, 10),
      DefaultDatabase.CreateParameter("@locZip", SqlDbType.VarChar, 20),
      DefaultDatabase.CreateParameter("@NumResults", SqlDbType.VarChar, 4),
      DefaultDatabase.CreateParameter("@InforceOnly", SqlDbType.Bit),
      DefaultDatabase.CreateParameter("@SearchingUserID", SqlDbType.Int)
    });
    ((Control) this.ugLocSearch).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugLocSearch).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugLocSearch).DataMember = "dtLocationSearch";
    ((UltraGridBase) this.ugLocSearch).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Control #";
    ultraGridColumn1.Header.VisiblePosition = 2;
    ultraGridColumn1.Width = 64 /*0x40*/;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Policy #";
    ultraGridColumn2.Header.VisiblePosition = 3;
    ultraGridColumn2.Width = 62;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 4;
    ultraGridColumn3.Width = 83;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Effective Date";
    ultraGridColumn4.Header.VisiblePosition = 5;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Expiration Date";
    ultraGridColumn5.Header.VisiblePosition = 6;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Location #";
    ultraGridColumn6.Header.VisiblePosition = 7;
    ultraGridColumn6.Width = 73;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Bldg #";
    ultraGridColumn7.Header.VisiblePosition = 8;
    ultraGridColumn7.Width = 60;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.Header.VisiblePosition = 9;
    ultraGridColumn8.Width = 85;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.Header.VisiblePosition = 10;
    ultraGridColumn9.Width = 76;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.Header.VisiblePosition = 11;
    ultraGridColumn10.Width = 46;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.Header.VisiblePosition = 12;
    ultraGridColumn11.Width = 46;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Producer";
    ultraGridColumn12.Header.VisiblePosition = 1;
    ultraGridColumn12.Width = 92;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Insured";
    ultraGridColumn13.Header.VisiblePosition = 0;
    ultraGridColumn13.Width = 83;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Status";
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Width = 62;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Added";
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn15.Width = 67;
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
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugLocSearch).Location = new Point(12, 12);
    ((Control) this.ugLocSearch).Name = "ugLocSearch";
    ((Control) this.ugLocSearch).Size = new Size(906, 462);
    ((Control) this.ugLocSearch).TabIndex = 59;
    ((Control) this.ugLocSearch).Text = "Location Clearance";
    ((UltraControlBase) this.ugLocSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugLocSearch).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsLocationSearch";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(930, 486);
    this.Controls.Add((Control) this.ugLocSearch);
    this.Name = nameof (FormClearanceLocation);
    this.Text = "Clearance by Location";
    ((ISupportInitialize) this.ugLocSearch).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("daLoc")]
  private virtual DbDataAdapter daLoc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand3")]
  private virtual DbCommand DbSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  protected internal virtual dsLocationSearch ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid ugLocSearch
  {
    get => this._ugLocSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugLocSearch_DoubleClick);
      UltraGrid ugLocSearch1 = this._ugLocSearch;
      if (ugLocSearch1 != null)
        ((Control) ugLocSearch1).DoubleClick -= eventHandler;
      this._ugLocSearch = value;
      UltraGrid ugLocSearch2 = this._ugLocSearch;
      if (ugLocSearch2 == null)
        return;
      ((Control) ugLocSearch2).DoubleClick += eventHandler;
    }
  }

  public FormClearanceLocation()
  {
    this._currentUserID = CurrentUser.Instance.UserID;
    this.InitializeComponent();
    Utility.SetDataAdapterConnections(this.daLoc, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
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

  public virtual void StartSearch(LocationClearance searchLoc)
  {
    this.Cursor = MgaCursors.WaitCursor;
    ((UltraControlBase) this.ugLocSearch).Cursor = MgaCursors.WaitCursor;
    this._locSearchInfo = searchLoc;
    this.ds.dtLocationSearch.Clear();
    DbCommand selectCommand = this.daLoc.SelectCommand;
    selectCommand.CommandText = this.SearchStoreProcedure();
    selectCommand.Parameters["@InsuredName"].Value = (object) this._locSearchInfo.InsuredName;
    selectCommand.Parameters["@locStreet"].Value = (object) this._locSearchInfo.LocAddress;
    selectCommand.Parameters["@locCity"].Value = (object) this._locSearchInfo.LocCity;
    selectCommand.Parameters["@locState"].Value = (object) this._locSearchInfo.LocState;
    selectCommand.Parameters["@locZip"].Value = (object) this._locSearchInfo.LocZip;
    selectCommand.Parameters["@NumResults"].Value = (object) this._locSearchInfo.NumResults;
    selectCommand.Parameters["@InforceOnly"].Value = (object) this._locSearchInfo.InforceOnly;
    selectCommand.Parameters["@SearchingUserID"].Value = (object) this._currentUserID;
    this.SetClientParameters(this.daLoc, searchLoc);
    ((UltraGridBase) this.ugLocSearch).DisplayLayout.Save(this.GridLayout);
    ((UltraGridBase) this.ugLocSearch).DataSource = (object) null;
    ((UltraGridBase) this.ugLocSearch).DataMember = string.Empty;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.LocationSearch));
  }

  [Obsolete("Use System.Data.Common arguments instead of System.Data.SqlClient arguments", false)]
  protected virtual void SetClientParameters(SqlDataAdapter da, LocationClearance sLoc)
  {
  }

  protected virtual void SetClientParameters(DbDataAdapter da, LocationClearance sLoc)
  {
    if (!(da is SqlDataAdapter))
      return;
    this.SetClientParameters(da as SqlDataAdapter, sLoc);
  }

  protected virtual string SearchStoreProcedure() => "GetLocationSearchData";

  private void LocationSearch(object state)
  {
    DefaultDatabase.DataAdapterFill(this.daLoc, (DataTable) this.ds.dtLocationSearch);
    if (this.IsDisposed)
      return;
    if (this.Disposing)
      return;
    try
    {
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.LocationSearchComplete), new object[0]);
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void LocationSearchComplete()
  {
    try
    {
      if (((UltraGridBase) this.ugLocSearch).DisplayLayout != null)
      {
        ((UltraGridBase) this.ugLocSearch).DataSource = (object) this.ds.dtLocationSearch;
        this.GridLayout.Position = 0L;
        ((UltraGridBase) this.ugLocSearch).DisplayLayout.Load(this.GridLayout);
        ((UltraGridBase) this.ugLocSearch).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
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
    ((UltraControlBase) this.ugLocSearch).Cursor = MgaCursors.Hand;
  }

  private void ugLocSearch_DoubleClick(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ugLocSearch).ActiveRow == null)
      return;
    UIElement lastElementEntered = ((ControlUIElementBase) ((UltraGridBase) this.ugLocSearch).DisplayLayout.UIElement).LastElementEntered;
    if (!(lastElementEntered is RowUIElement))
    {
      RowUIElement ancestor = (RowUIElement) lastElementEntered.GetAncestor(typeof (RowUIElement));
      if (ancestor == null || (UltraGridRow) ((UIElement) ancestor).GetContext(typeof (UltraGridRow)) == null)
        return;
      Quote quote = Quote.FromControlNo((int) ((UltraGridBase) this.ugLocSearch).ActiveRow.Cells["ControlNo"].Value);
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
