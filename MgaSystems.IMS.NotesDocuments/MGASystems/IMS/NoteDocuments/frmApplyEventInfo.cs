// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmApplyEventInfo
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common.DataAccess;
using MGASystems.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmApplyEventInfo : Form
{
  private IContainer components;
  private List<Guid> _companyLineGuids;
  private DataTable _companyLinesTable;
  private bool _companiesLoaded;
  private const string SelectAllCompanies = "SELECT CompanyLocationGuid, CompanyGuid, [Name] FROM tblcompanyLocations (NOLOCK) ORDER BY NAME";
  private const string SelectCompanyLinesTable = "SELECT CompanyLineGuid, CompanyLocationGuid, LineGuid, StateID FROM tblCompanyLines (NOLOCK)";
  private const string SelectLinesFromCompany = "SELECT   DISTINCT  dbo.lstLines.LineGUID, dbo.lstLines.LineName FROM         dbo.lstLines (NOLOCK) INNER JOIN                       dbo.tblCompanyLines (NOLOCK) ON dbo.lstLines.LineGUID = dbo.tblCompanyLines.LineGUID AND                       dbo.lstLines.LineGUID = dbo.tblCompanyLines.LineGUID WHERE     (dbo.tblCompanyLines.CompanyLocationGUID = @CompanyLocationGUID)";
  private const string SelectStatesFromCompanyAndLine = "SELECT DISTINCT dbo.lstStates.StateID, dbo.lstStates.State FROM         dbo.tblCompanyLines (NOLOCK) INNER JOIN                       dbo.lstStates (NOLOCK) ON dbo.tblCompanyLines.StateID = dbo.lstStates.StateID WHERE     (dbo.tblCompanyLines.LineGUID = @LineGuid) AND (dbo.tblCompanyLines.CompanyLocationGUID = @CompanyLocationGUID)";

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("MgaGroupBox1")]
  internal virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGACheckedListBox clCompanies
  {
    get => this._clCompanies;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CheckedListBox_SelectedValueChanged);
      MGACheckedListBox clCompanies1 = this._clCompanies;
      if (clCompanies1 != null)
        clCompanies1.SelectedValueChanged -= eventHandler;
      this._clCompanies = value;
      MGACheckedListBox clCompanies2 = this._clCompanies;
      if (clCompanies2 == null)
        return;
      clCompanies2.SelectedValueChanged += eventHandler;
    }
  }

  internal virtual MGACheckedListBox clLines
  {
    get => this._clLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CheckedListBox_SelectedValueChanged);
      MGACheckedListBox clLines1 = this._clLines;
      if (clLines1 != null)
        clLines1.SelectedValueChanged -= eventHandler;
      this._clLines = value;
      MGACheckedListBox clLines2 = this._clLines;
      if (clLines2 == null)
        return;
      clLines2.SelectedValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("clStates")]
  internal virtual MGACheckedListBox clStates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (frmApplyEventInfo));
    this.clCompanies = new MGACheckedListBox();
    this.clLines = new MGACheckedListBox();
    this.clStates = new MGACheckedListBox();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    ((ISupportInitialize) this.clCompanies).BeginInit();
    ((ISupportInitialize) this.clLines).BeginInit();
    ((ISupportInitialize) this.clStates).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    this.SuspendLayout();
    this.clCompanies.BackColor = Color.White;
    this.clCompanies.ForeColor = Color.Black;
    this.clCompanies.IntegralHeight = false;
    this.clCompanies.Location = new Point(8, 48 /*0x30*/);
    this.clCompanies.MGAStyle = MGAStyles.Blue;
    this.clCompanies.Name = "clCompanies";
    this.clCompanies.Size = new Size(232, 336);
    this.clCompanies.TabIndex = 0;
    this.clLines.BackColor = Color.White;
    this.clLines.ForeColor = Color.Black;
    this.clLines.IntegralHeight = false;
    this.clLines.Location = new Point(248, 48 /*0x30*/);
    this.clLines.MGAStyle = MGAStyles.Blue;
    this.clLines.Name = "clLines";
    this.clLines.Size = new Size(232, 336);
    this.clLines.TabIndex = 1;
    this.clStates.BackColor = Color.White;
    this.clStates.ForeColor = Color.Black;
    this.clStates.IntegralHeight = false;
    this.clStates.Location = new Point(488, 48 /*0x30*/);
    this.clStates.MGAStyle = MGAStyles.Blue;
    this.clStates.Name = "clStates";
    this.clStates.Size = new Size(232, 336);
    this.clStates.TabIndex = 2;
    ((Control) this.MgaGroupBox1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(239, 247, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label3);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.clCompanies);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.clLines);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.clStates);
    appearance2.AlphaLevel = (short) 230;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.White;
    appearance2.ForegroundAlpha = (Alpha) 2;
    appearance2.ImageAlpha = (Alpha) 2;
    appearance2.ImageBackground = (Image) resourceManager.GetObject("Appearance2.ImageBackground");
    appearance2.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.MgaGroupBox1).Location = new Point(8, 8);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(728, 392);
    this.MgaGroupBox1.SupportThemes = false;
    ((Control) this.MgaGroupBox1).TabIndex = 3;
    this.MgaGroupBox1.Text = "Changes currently apply to the following:";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(488, 32 /*0x20*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(29, 16 /*0x10*/);
    this.Label3.TabIndex = 5;
    this.Label3.Text = "State";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(248, 32 /*0x20*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(24, 16 /*0x10*/);
    this.Label2.TabIndex = 4;
    this.Label2.Text = "Line";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(8, 32 /*0x20*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(49, 16 /*0x10*/);
    this.Label1.TabIndex = 3;
    this.Label1.Text = "Company";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(744, 406);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmApplyEventInfo);
    this.Text = "Company/Line/State";
    ((ISupportInitialize) this.clCompanies).EndInit();
    ((ISupportInitialize) this.clLines).EndInit();
    ((ISupportInitialize) this.clStates).EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public frmApplyEventInfo(Guid companyLineGuid)
  {
    this.Load += new EventHandler(this.frmApplyEventInfo_Load);
    this._companyLineGuids = new List<Guid>();
    this.InitializeComponent();
    this._companyLineGuids.Add(companyLineGuid);
  }

  private void frmApplyEventInfo_Load(object sender, EventArgs e)
  {
    Database.Instance.QueryMultithreadedText.PerformTableQuery(new TableQueryMultithreadEventHandler(this.TableQuery_Completed), (Control) this, (object) "Companies", "SELECT CompanyLocationGuid, CompanyGuid, [Name] FROM tblcompanyLocations (NOLOCK) ORDER BY NAME");
    Database.Instance.QueryMultithreadedText.PerformTableQuery(new TableQueryMultithreadEventHandler(this.TableQuery_Completed), (Control) this, (object) "CompanyLines", "SELECT CompanyLineGuid, CompanyLocationGuid, LineGuid, StateID FROM tblCompanyLines (NOLOCK)");
  }

  private void SetSelectedCompanies()
  {
    this.clCompanies.ItemCheck -= new ItemCheckEventHandler(this.CheckedListBox_ItemCheck);
    if (this._companiesLoaded && this._companyLinesTable != null)
    {
      StringBuilder stringBuilder = new StringBuilder();
      int num1 = this._companyLineGuids.Count - 1;
      for (int index = 0; index <= num1; ++index)
      {
        Guid companyLineGuid = this._companyLineGuids[index];
        if (index == 0)
          stringBuilder.Append($"CompanyLineGuid = '{companyLineGuid.ToString()}'");
        else
          stringBuilder.Append($" OR CompanyLineGuid = '{companyLineGuid.ToString()}'");
      }
      int num2 = this.clCompanies.Items.Count - 1;
      for (int index = 0; index <= num2; ++index)
        this.clCompanies.SetItemChecked(index, false);
      DataRow[] dataRowArray = this._companyLinesTable.Select(stringBuilder.ToString());
      int index1 = 0;
      while (index1 < dataRowArray.Length)
      {
        DataRow dataRow = dataRowArray[index1];
        int num3 = this.clCompanies.Items.Count - 1;
        for (int index2 = 0; index2 <= num3; ++index2)
        {
          if (((frmApplyEventInfo.CompanyItem) this.clCompanies.Items[index2]).CompanyLocationGuid.Equals(RuntimeHelpers.GetObjectValue(dataRow["CompanyLocationGuid"])))
          {
            this.clCompanies.SetItemChecked(index2, true);
            bool flag;
            if (!flag)
            {
              flag = true;
              this.clCompanies.SetSelected(index2, true);
            }
          }
        }
        checked { ++index1; }
      }
    }
    this.clCompanies.ItemCheck += new ItemCheckEventHandler(this.CheckedListBox_ItemCheck);
  }

  private void SetSelectedLines()
  {
    this.clLines.ItemCheck -= new ItemCheckEventHandler(this.CheckedListBox_ItemCheck);
    if (this._companyLinesTable != null && this.clCompanies.SelectedItem != null)
    {
      frmApplyEventInfo.CompanyItem selectedItem = (frmApplyEventInfo.CompanyItem) this.clCompanies.SelectedItem;
      int num1 = this.clLines.Items.Count - 1;
      for (int index = 0; index <= num1; ++index)
        this.clLines.SetItemChecked(index, false);
      StringBuilder stringBuilder1 = new StringBuilder();
      int num2 = this._companyLineGuids.Count - 1;
      for (int index = 0; index <= num2; ++index)
      {
        Guid companyLineGuid = this._companyLineGuids[index];
        if (index == 0)
          stringBuilder1.Append($"CompanyLineGuid = '{companyLineGuid.ToString()}'");
        else
          stringBuilder1.Append($" OR CompanyLineGuid = '{companyLineGuid.ToString()}'");
      }
      StringBuilder stringBuilder2 = stringBuilder1;
      Guid guid = selectedItem.CompanyLocationGuid;
      string str = $" AND CompanyLocationGuid = '{guid.ToString()}'";
      stringBuilder2.Append(str);
      DataRow[] dataRowArray = this._companyLinesTable.Select(stringBuilder1.ToString());
      int index1 = 0;
      while (index1 < dataRowArray.Length)
      {
        DataRow dataRow = dataRowArray[index1];
        int num3 = this.clLines.Items.Count - 1;
        for (int index2 = 0; index2 <= num3; ++index2)
        {
          guid = ((frmApplyEventInfo.LineItem) this.clLines.Items[index2]).LineGuid;
          if (guid.Equals(RuntimeHelpers.GetObjectValue(dataRow["LineGuid"])))
          {
            this.clLines.SetItemChecked(index2, true);
            bool flag;
            if (!flag)
            {
              flag = true;
              this.clLines.SetSelected(index2, true);
            }
          }
        }
        checked { ++index1; }
      }
    }
    this.clLines.ItemCheck += new ItemCheckEventHandler(this.CheckedListBox_ItemCheck);
  }

  private void SetSelectedStates()
  {
    this.clStates.ItemCheck -= new ItemCheckEventHandler(this.CheckedListBox_ItemCheck);
    if (this._companyLinesTable != null && this.clCompanies.SelectedItem != null && this.clLines.SelectedItem != null)
    {
      frmApplyEventInfo.CompanyItem selectedItem1 = (frmApplyEventInfo.CompanyItem) this.clCompanies.SelectedItem;
      frmApplyEventInfo.LineItem selectedItem2 = (frmApplyEventInfo.LineItem) this.clLines.SelectedItem;
      int num1 = this.clStates.Items.Count - 1;
      for (int index = 0; index <= num1; ++index)
        this.clStates.SetItemChecked(index, false);
      StringBuilder stringBuilder1 = new StringBuilder();
      int num2 = this._companyLineGuids.Count - 1;
      for (int index = 0; index <= num2; ++index)
      {
        Guid companyLineGuid = this._companyLineGuids[index];
        if (index == 0)
          stringBuilder1.Append($"CompanyLineGuid = '{companyLineGuid.ToString()}'");
        else
          stringBuilder1.Append($" OR CompanyLineGuid = '{companyLineGuid.ToString()}'");
      }
      StringBuilder stringBuilder2 = stringBuilder1;
      Guid guid = selectedItem1.CompanyLocationGuid;
      string str1 = $" AND CompanyLocationGuid = '{guid.ToString()}'";
      stringBuilder2.Append(str1);
      StringBuilder stringBuilder3 = stringBuilder1;
      guid = selectedItem2.LineGuid;
      string str2 = $" AND LineGuid = '{guid.ToString()}'";
      stringBuilder3.Append(str2);
      DataRow[] dataRowArray = this._companyLinesTable.Select(stringBuilder1.ToString());
      int index1 = 0;
      while (index1 < dataRowArray.Length)
      {
        DataRow dataRow = dataRowArray[index1];
        int num3 = this.clStates.Items.Count - 1;
        for (int index2 = 0; index2 <= num3; ++index2)
        {
          if (((frmApplyEventInfo.StateItem) this.clStates.Items[index2]).StateID.Equals(RuntimeHelpers.GetObjectValue(dataRow["StateID"])))
          {
            this.clStates.SetItemChecked(index2, true);
            bool flag;
            if (!flag)
            {
              flag = true;
              this.clStates.SetSelected(index2, true);
            }
          }
        }
        checked { ++index1; }
      }
    }
    this.clStates.ItemCheck += new ItemCheckEventHandler(this.CheckedListBox_ItemCheck);
  }

  private void TableQuery_Completed(object sender, TableQueryMultithreadEventArgs e)
  {
    string key = (string) e.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Companies", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "CompanyLines", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Lines", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "States", false) != 0)
            return;
          this.clStates.Items.Clear();
          try
          {
            foreach (DataRow row in e.Table.Rows)
              this.clStates.Items.Add((object) new frmApplyEventInfo.StateItem(row));
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
          this.SetSelectedStates();
        }
        else
        {
          this.clLines.Items.Clear();
          this.clStates.Items.Clear();
          try
          {
            foreach (DataRow row in e.Table.Rows)
              this.clLines.Items.Add((object) new frmApplyEventInfo.LineItem(row));
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
          this.SetSelectedLines();
        }
      }
      else
      {
        this._companyLinesTable = e.Table;
        this.SetSelectedCompanies();
      }
    }
    else
    {
      this.clCompanies.Items.Clear();
      try
      {
        foreach (DataRow row in e.Table.Rows)
          this.clCompanies.Items.Add((object) new frmApplyEventInfo.CompanyItem(row));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this._companiesLoaded = true;
      this.SetSelectedCompanies();
    }
  }

  private void CheckedListBox_SelectedValueChanged(object sender, EventArgs e)
  {
    if (sender == this.clCompanies)
    {
      if (this.clCompanies.SelectedItem == null)
        return;
      Database.Instance.QueryMultithreadedText.PerformTableQuery(new TableQueryMultithreadEventHandler(this.TableQuery_Completed), (Control) this, (object) "Lines", "SELECT   DISTINCT  dbo.lstLines.LineGUID, dbo.lstLines.LineName FROM         dbo.lstLines (NOLOCK) INNER JOIN                       dbo.tblCompanyLines (NOLOCK) ON dbo.lstLines.LineGUID = dbo.tblCompanyLines.LineGUID AND                       dbo.lstLines.LineGUID = dbo.tblCompanyLines.LineGUID WHERE     (dbo.tblCompanyLines.CompanyLocationGUID = @CompanyLocationGUID)", (object) "@CompanyLocationGuid", (object) ((frmApplyEventInfo.CompanyItem) this.clCompanies.SelectedItem).CompanyLocationGuid);
    }
    else
    {
      if (sender != this.clLines || this.clCompanies.SelectedItem == null || this.clLines.SelectedItem == null)
        return;
      Database.Instance.QueryMultithreadedText.PerformTableQuery(new TableQueryMultithreadEventHandler(this.TableQuery_Completed), (Control) this, (object) "States", "SELECT DISTINCT dbo.lstStates.StateID, dbo.lstStates.State FROM         dbo.tblCompanyLines (NOLOCK) INNER JOIN                       dbo.lstStates (NOLOCK) ON dbo.tblCompanyLines.StateID = dbo.lstStates.StateID WHERE     (dbo.tblCompanyLines.LineGUID = @LineGuid) AND (dbo.tblCompanyLines.CompanyLocationGUID = @CompanyLocationGUID)", (object) "@LineGuid", (object) ((frmApplyEventInfo.LineItem) this.clLines.SelectedItem).LineGuid, (object) "@CompanyLocationGuid", (object) ((frmApplyEventInfo.CompanyItem) this.clCompanies.SelectedItem).CompanyLocationGuid);
    }
  }

  private void CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
  {
    if (sender == this.clCompanies)
    {
      if (e.NewValue == CheckState.Unchecked)
      {
        DataRow[] dataRowArray = this._companyLinesTable.Select($"CompanyLocationGuid = '{((frmApplyEventInfo.CompanyItem) this.clCompanies.Items[e.Index]).CompanyLocationGuid.ToString()}'");
        int index = 0;
        while (index < dataRowArray.Length)
        {
          dataRowArray[index].Delete();
          checked { ++index; }
        }
      }
    }
    else if (sender == this.clLines)
    {
      if (e.NewValue == CheckState.Unchecked)
      {
        frmApplyEventInfo.CompanyItem companyItem = (frmApplyEventInfo.CompanyItem) this.clCompanies.Items[e.Index];
        frmApplyEventInfo.LineItem lineItem = (frmApplyEventInfo.LineItem) this.clLines.Items[e.Index];
        DataRow[] dataRowArray = this._companyLinesTable.Select($"CompanyLocationGuid = '{companyItem.CompanyLocationGuid.ToString()}' AND LineGuid = '{lineItem.LineGuid.ToString()}'");
        int index = 0;
        while (index < dataRowArray.Length)
        {
          dataRowArray[index].Delete();
          checked { ++index; }
        }
      }
    }
    else if (sender == this.clStates)
    {
      frmApplyEventInfo.CompanyItem companyItem = (frmApplyEventInfo.CompanyItem) this.clCompanies.Items[e.Index];
      frmApplyEventInfo.LineItem lineItem = (frmApplyEventInfo.LineItem) this.clLines.Items[e.Index];
      frmApplyEventInfo.StateItem stateItem = (frmApplyEventInfo.StateItem) this.clStates.Items[e.Index];
      DataRow[] dataRowArray = this._companyLinesTable.Select($"CompanyLocationGuid = '{companyItem.CompanyLocationGuid.ToString()}' AND LineGuid = '{lineItem.LineGuid.ToString()}' AND StateID = '{stateItem.StateID}'");
      int index = 0;
      while (index < dataRowArray.Length)
      {
        DataRow dataRow = dataRowArray[index];
        if (e.NewValue == CheckState.Unchecked)
        {
          try
          {
            foreach (Guid companyLineGuid in this._companyLineGuids)
            {
              ref Guid local = ref companyLineGuid;
              object obj = dataRow["CompanyLineGuid"];
              Guid g = obj != null ? (Guid) obj : new Guid();
              if (local.Equals(g))
              {
                this._companyLineGuids.Remove(companyLineGuid);
                break;
              }
            }
          }
          finally
          {
            List<Guid>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
        else
          this._companyLineGuids.Add((Guid) dataRow["CompanyLineGuid"]);
        checked { ++index; }
      }
    }
    this.SetSelectedCompanies();
  }

  private class CompanyItem
  {
    private string _companyName;
    private Guid _companyLocationGuid;

    public CompanyItem(DataRow row)
    {
      this._companyName = (string) row["Name"];
      this._companyLocationGuid = (Guid) row[nameof (CompanyLocationGuid)];
    }

    public string CompanyName => this._companyName;

    public Guid CompanyLocationGuid => this._companyLocationGuid;

    public override string ToString() => this.CompanyName;
  }

  private class LineItem
  {
    private Guid _lineGuid;
    private string _lineName;

    public LineItem(DataRow row)
    {
      object obj = row["LineGUID"];
      this._lineGuid = obj != null ? (Guid) obj : new Guid();
      this._lineName = (string) row[nameof (LineName)];
    }

    public Guid LineGuid => this._lineGuid;

    public string LineName => this._lineName;

    public override string ToString() => this.LineName;
  }

  private class StateItem
  {
    private string _stateID;
    private string _state;

    public StateItem(DataRow row)
    {
      this._state = (string) row[nameof (State)];
      this._stateID = (string) row[nameof (StateID)];
    }

    public string State => this._state;

    public string StateID => this._stateID;

    public override string ToString() => this.State;
  }
}
