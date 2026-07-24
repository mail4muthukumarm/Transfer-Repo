// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmUserCompanyViewingRights
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

public class frmUserCompanyViewingRights : Form
{
  private IContainer components;
  private readonly Guid _userGuid;

  public frmUserCompanyViewingRights()
  {
    this.Load += new EventHandler(this.frmUserCompanyViewingRights_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual MGACheckedListBox lstCompanyLocations
  {
    get => this._lstCompanyLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.lstCompanyLocations_ItemCheck);
      MGACheckedListBox companyLocations1 = this._lstCompanyLocations;
      if (companyLocations1 != null)
        companyLocations1.ItemCheck -= checkEventHandler;
      this._lstCompanyLocations = value;
      MGACheckedListBox companyLocations2 = this._lstCompanyLocations;
      if (companyLocations2 == null)
        return;
      companyLocations2.ItemCheck += checkEventHandler;
    }
  }

  internal virtual LinkLabel lnkDeselectAll
  {
    get => this._lnkDeselectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lnkDeselectAll_Click);
      LinkLabel lnkDeselectAll1 = this._lnkDeselectAll;
      if (lnkDeselectAll1 != null)
        lnkDeselectAll1.Click -= eventHandler;
      this._lnkDeselectAll = value;
      LinkLabel lnkDeselectAll2 = this._lnkDeselectAll;
      if (lnkDeselectAll2 == null)
        return;
      lnkDeselectAll2.Click += eventHandler;
    }
  }

  internal virtual LinkLabel lnkSelectAll
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

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCompanyViewingRights ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.lstCompanyLocations = new MGACheckedListBox();
    this.ds = new dsCompanyViewingRights();
    this.lnkDeselectAll = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.Label1 = new Label();
    ((ISupportInitialize) this.lstCompanyLocations).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.lstCompanyLocations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstCompanyLocations.CheckOnClick = true;
    this.lstCompanyLocations.Location = new Point(0, 30);
    this.lstCompanyLocations.Name = "lstCompanyLocations";
    this.lstCompanyLocations.Size = new Size(672, 349);
    this.lstCompanyLocations.TabIndex = 1;
    this.ds.DataSetName = "dsCompanyViewingRights";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkDeselectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeselectAll.AutoSize = true;
    this.lnkDeselectAll.Location = new Point(89, 386);
    this.lnkDeselectAll.Name = "lnkDeselectAll";
    this.lnkDeselectAll.Size = new Size(68, 13);
    this.lnkDeselectAll.TabIndex = 16 /*0x10*/;
    this.lnkDeselectAll.TabStop = true;
    this.lnkDeselectAll.Text = "De-Select All";
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(12, 386);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(51, 13);
    this.lnkSelectAll.TabIndex = 15;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(167, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(278, 13);
    this.Label1.TabIndex = 19;
    this.Label1.Text = "Check the companies the user should not be able to view";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(672, 408);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lnkDeselectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.lstCompanyLocations);
    this.Name = nameof (frmUserCompanyViewingRights);
    this.Text = "User Company Viewing Rights";
    ((ISupportInitialize) this.lstCompanyLocations).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmUserCompanyViewingRights(Guid userGuid)
  {
    this.Load += new EventHandler(this.frmUserCompanyViewingRights_Load);
    this.InitializeComponent();
    this._userGuid = userGuid;
  }

  private void lstCompanyLocations_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    Cursor.Current = Cursors.WaitCursor;
    if (e.CurrentValue == e.NewValue)
      return;
    Guid guid = (Guid) ((DataRowView) this.lstCompanyLocations.Items[e.Index])["CompanyLocationGuid"];
    string str = (string) ((DataRowView) this.lstCompanyLocations.Items[e.Index])["LocationNameAddress"];
    if (e.CurrentValue == CheckState.Unchecked)
    {
      if (RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT CompanyLocationGuid FROM tblUserCompanyViewingRights WHERE CompanyLocationGuid = @cLoc AND UserGuid = @uGuid", new object[4]
      {
        (object) "@cLoc",
        (object) guid,
        (object) "@uGuid",
        (object) this._userGuid
      })) == null)
      {
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "Insert INTO tblUserCompanyViewingRights(CompanyLocationGuid,UserGuid) VALUES(@cLoc,@uGuid)", new object[4]
        {
          (object) "@cLoc",
          (object) guid,
          (object) "@uGuid",
          (object) this._userGuid
        });
        CurrentUser.Instance.LogAction($"Users Menu - Deleted user company viewing rights ({str} ) .", this._userGuid);
      }
    }
    else
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblUserCompanyViewingRights WHERE CompanyLocationGuid=@cLoc AND UserGuid= @uGuid", new object[4]
      {
        (object) "@cLoc",
        (object) guid,
        (object) "@uGuid",
        (object) this._userGuid
      });
      CurrentUser.Instance.LogAction($"Users Menu - Added user company viewing rights ({str} ) .", this._userGuid);
    }
    Cursor.Current = Cursors.Default;
  }

  private void SetCheckBoxes(bool SetValue)
  {
    int num = this.lstCompanyLocations.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      this.lstCompanyLocations.SetItemChecked(index, SetValue);
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetCheckBoxes(true);
  }

  private void lnkDeselectAll_Click(object sender, EventArgs e) => this.SetCheckBoxes(false);

  private void frmUserCompanyViewingRights_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblCompanyLocations"
    }, CommandType.Text, "SELECT  CompanyLocationGUID,  Name + @D + ISNULL(Address1,@E) + @C + ISNULL(City,@E) + @C + ISNULL(State,@E) + @S + ISNULL(ZipCode,@E) AS LocationNameAddress  FROM tblCompanyLocations  ORDER BY Name, Address1", new object[8]
    {
      (object) "@D",
      (object) " - ",
      (object) "@E",
      (object) "",
      (object) "@C",
      (object) ", ",
      (object) "@S",
      (object) " "
    });
    MGACheckedListBox companyLocations = this.lstCompanyLocations;
    companyLocations.DataSource = (object) this.ds.tblCompanyLocations;
    companyLocations.DisplayMember = "LocationNameAddress";
    companyLocations.ValueMember = "CompanyLocationGUID";
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblUserCompanyViewingRights"
    }, CommandType.Text, "SELECT CompanyLocationGuid, UserGuid FROM tblUserCompanyViewingRights WHERE UserGuid = @uGuid ", new object[2]
    {
      (object) "@uGuid",
      (object) this._userGuid
    });
    EnumerableRowCollection<dsCompanyViewingRights.tblUserCompanyViewingRightsRow> source = this.ds.tblUserCompanyViewingRights.AsEnumerable<dsCompanyViewingRights.tblUserCompanyViewingRightsRow>();
    System.Func<dsCompanyViewingRights.tblUserCompanyViewingRightsRow, Guid> keySelector;
    // ISSUE: reference to a compiler-generated field
    if (frmUserCompanyViewingRights._Closure\u0024__.\u0024I30\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      keySelector = frmUserCompanyViewingRights._Closure\u0024__.\u0024I30\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmUserCompanyViewingRights._Closure\u0024__.\u0024I30\u002D0 = keySelector = (System.Func<dsCompanyViewingRights.tblUserCompanyViewingRightsRow, Guid>) ([SpecialName] (dr) => dr.Field<Guid>("CompanyLocationGuid"));
    }
    ILookup<Guid, dsCompanyViewingRights.tblUserCompanyViewingRightsRow> lookup = source.ToLookup<dsCompanyViewingRights.tblUserCompanyViewingRightsRow, Guid>(keySelector);
    int num = this.lstCompanyLocations.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      dsCompanyViewingRights.tblCompanyLocationsRow row = (dsCompanyViewingRights.tblCompanyLocationsRow) ((DataRowView) this.lstCompanyLocations.Items[index]).Row;
      if (lookup.Contains(row.CompanyLocationGUID))
        this.lstCompanyLocations.SetItemChecked(index, true);
    }
  }
}
