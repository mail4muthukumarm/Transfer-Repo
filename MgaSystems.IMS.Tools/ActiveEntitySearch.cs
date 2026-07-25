// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ActiveEntitySearch
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinListView;
using MGASystems.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[DesignerGenerated]
public class ActiveEntitySearch : UserControl
{
  private IContainer components;
  private ActiveEntitySearch.EntityTypesFilter _entityTypeFilter;
  private string _entityProcedure;
  private string _entityTypeOverrideInclude;
  private string _entityTypeOverride;
  private DataTable _dt;
  private DataTable _dtBound;
  private string _currentString;
  private BackgroundWorker _bgw;
  private bool _flag;

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
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ActiveEntitySearch));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.ImageList1 = new ImageList(this.components);
    this.timerActiveSearchDelay = new Timer(this.components);
    this.comboEntityList = new MGAComboEditor();
    this.buttonFilter = new MGAButton();
    ((ISupportInitialize) this.comboEntityList).BeginInit();
    ((ISupportInitialize) this.buttonFilter).BeginInit();
    this.SuspendLayout();
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    this.ImageList1.Images.SetKeyName(0, "user.png");
    appearance1.BorderColor = Color.FromArgb(78, 122, 171);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.comboEntityList).Appearance = (AppearanceBase) appearance1;
    this.comboEntityList.AutoCompleteMode = (AutoCompleteMode) 3;
    ((TextEditorControlBase) this.comboEntityList).BorderStyle = (UIElementBorderStyle) 4;
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
    this.comboEntityList.ButtonAppearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.comboEntityList).DisplayStyle = (EmbeddableElementDisplayStyle) 6;
    ((Control) this.comboEntityList).Dock = DockStyle.Fill;
    this.comboEntityList.DropDownButtonDisplayStyle = (ButtonDisplayStyle) 0;
    this.comboEntityList.DropDownListWidth = 500;
    ((Control) this.comboEntityList).Location = new Point(0, 0);
    this.comboEntityList.MaxDropDownItems = 25;
    this.comboEntityList.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboEntityList).Name = "comboEntityList";
    ((TextEditorControlBase) this.comboEntityList).NullText = "[Please enter an entity name.]";
    appearance3.ForeColor = Color.SteelBlue;
    ((TextEditorControlBase) this.comboEntityList).NullTextAppearance = (AppearanceBase) appearance3;
    ((Control) this.comboEntityList).Size = new Size(228, 19);
    ((Control) this.comboEntityList).TabIndex = 4;
    ((UltraControlBase) this.comboEntityList).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboEntityList).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance4.Image"));
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonFilter).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonFilter).Dock = DockStyle.Right;
    ((Control) this.buttonFilter).Location = new Point(228, 0);
    ((Control) this.buttonFilter).Margin = new Padding(0);
    ((Control) this.buttonFilter).Name = "buttonFilter";
    ((Control) this.buttonFilter).Size = new Size(24, 24);
    ((Control) this.buttonFilter).TabIndex = 5;
    ((Control) this.buttonFilter).TabStop = false;
    ((UltraControlBase) this.buttonFilter).UseFlatMode = (DefaultableBoolean) 1;
    this.buttonFilter.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.comboEntityList);
    this.Controls.Add((Control) this.buttonFilter);
    this.Name = nameof (ActiveEntitySearch);
    this.Size = new Size(252, 24);
    ((ISupportInitialize) this.comboEntityList).EndInit();
    ((ISupportInitialize) this.buttonFilter).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("timerActiveSearchDelay")]
  internal virtual Timer timerActiveSearchDelay { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ImageList1")]
  internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAComboEditor comboEntityList
  {
    get => this._comboEntityList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.comboEntityList_KeyDown);
      UltraComboEditor.ItemNotInListEventHandler listEventHandler = new UltraComboEditor.ItemNotInListEventHandler(this.comboEntityList_ItemNotInList);
      EventHandler eventHandler1 = new EventHandler(this.comboEntityList_ValueChanged);
      EventHandler eventHandler2 = new EventHandler(this.comboEntityList_AfterDropDown);
      EventHandler eventHandler3 = new EventHandler(this.comboEntityList_AfterCloseUp);
      EventHandler eventHandler4 = new EventHandler(this.comboEntityList_SelectionChangeCommitted);
      BeforeExitEditModeEventHandler modeEventHandler = new BeforeExitEditModeEventHandler(this.comboEntityList_BeforeExitEditMode);
      MGAComboEditor comboEntityList1 = this._comboEntityList;
      if (comboEntityList1 != null)
      {
        ((Control) comboEntityList1).KeyDown -= keyEventHandler;
        comboEntityList1.ItemNotInList -= listEventHandler;
        ((TextEditorControlBase) comboEntityList1).ValueChanged -= eventHandler1;
        comboEntityList1.AfterDropDown -= eventHandler2;
        comboEntityList1.AfterCloseUp -= eventHandler3;
        comboEntityList1.SelectionChangeCommitted -= eventHandler4;
        ((TextEditorControlBase) comboEntityList1).BeforeExitEditMode -= modeEventHandler;
      }
      this._comboEntityList = value;
      MGAComboEditor comboEntityList2 = this._comboEntityList;
      if (comboEntityList2 == null)
        return;
      ((Control) comboEntityList2).KeyDown += keyEventHandler;
      comboEntityList2.ItemNotInList += listEventHandler;
      ((TextEditorControlBase) comboEntityList2).ValueChanged += eventHandler1;
      comboEntityList2.AfterDropDown += eventHandler2;
      comboEntityList2.AfterCloseUp += eventHandler3;
      comboEntityList2.SelectionChangeCommitted += eventHandler4;
      ((TextEditorControlBase) comboEntityList2).BeforeExitEditMode += modeEventHandler;
    }
  }

  internal virtual MGAButton buttonFilter
  {
    get => this._buttonFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonFilter_Click);
      MGAButton buttonFilter1 = this._buttonFilter;
      if (buttonFilter1 != null)
        ((Control) buttonFilter1).Click -= eventHandler;
      this._buttonFilter = value;
      MGAButton buttonFilter2 = this._buttonFilter;
      if (buttonFilter2 == null)
        return;
      ((Control) buttonFilter2).Click += eventHandler;
    }
  }

  public ActiveEntitySearch()
  {
    this._entityTypeFilter = ActiveEntitySearch.EntityTypesFilter.All;
    this._dt = new DataTable();
    this._dtBound = new DataTable();
    this._currentString = string.Empty;
    this._bgw = new BackgroundWorker();
    this.InitializeComponent();
    this.comboEntityList.DataSource = (object) this._dtBound;
  }

  [Browsable(false)]
  public string EntityName
  {
    get
    {
      return string.IsNullOrEmpty(this.comboEntityList.Text) || this.comboEntityList.Text.IndexOf(" (-- ") == 0 ? string.Empty : this.comboEntityList.Text.Substring(0, this.comboEntityList.Text.IndexOf(" (-- "));
    }
  }

  [Browsable(false)]
  public Guid EntityGuid
  {
    get
    {
      return this.comboEntityList.SelectedItem != null ? new Guid(this.comboEntityList.Value.ToString()) : Guid.Empty;
    }
  }

  [Browsable(false)]
  public bool EntitySelected => this.comboEntityList.SelectedItem != null;

  [Browsable(false)]
  public string EntityType
  {
    get
    {
      return this.comboEntityList.SelectedItem != null ? Strings.Trim(this.comboEntityList.Text.Substring(this.comboEntityList.Text.IndexOf("(-- ") + 4, this.comboEntityList.Text.IndexOf(" --) ") - (this.comboEntityList.Text.IndexOf("(-- ") + 4))) : string.Empty;
    }
  }

  [Browsable(true)]
  [DefaultValue(254)]
  public ActiveEntitySearch.EntityTypesFilter EntityTypeFilter
  {
    get => this._entityTypeFilter;
    set => this._entityTypeFilter = value;
  }

  [Browsable(true)]
  public string EntityProcedure
  {
    get
    {
      return (string) Interaction.IIf(string.IsNullOrEmpty(this._entityProcedure), (object) "dbo.spActiveEntitySearch", (object) this._entityProcedure);
    }
    set => this._entityProcedure = value;
  }

  [Browsable(true)]
  [DefaultValue("")]
  [Description("Allows you to specify an entity type filer that will be included in the filter specified by the Entity Type Filter property")]
  public string EntityTypeOverrideInclude
  {
    get => this._entityTypeOverrideInclude;
    set => this._entityTypeOverrideInclude = value;
  }

  [Browsable(true)]
  [DefaultValue("")]
  [Description("Allows you to specify an entity type filer that will override the filter specified by the Entity Type Filter property")]
  public string EntityTypeOverride
  {
    get => this._entityTypeOverride;
    set => this._entityTypeOverride = value;
  }

  public string Address1
  {
    get
    {
      return this.comboEntityList.SelectedIndex < 0 || this.comboEntityList.DataSource == null ? string.Empty : ((DataTable) this.comboEntityList.DataSource).Rows[this.comboEntityList.SelectedIndex][nameof (Address1)].ToString();
    }
  }

  public string Address2
  {
    get
    {
      return this.comboEntityList.SelectedIndex < 0 || this.comboEntityList.DataSource == null ? string.Empty : ((DataTable) this.comboEntityList.DataSource).Rows[this.comboEntityList.SelectedIndex][nameof (Address2)].ToString();
    }
  }

  public string City
  {
    get
    {
      return this.comboEntityList.SelectedIndex < 0 || this.comboEntityList.DataSource == null ? string.Empty : ((DataTable) this.comboEntityList.DataSource).Rows[this.comboEntityList.SelectedIndex][nameof (City)].ToString();
    }
  }

  public string State
  {
    get
    {
      return this.comboEntityList.SelectedIndex < 0 || this.comboEntityList.DataSource == null ? string.Empty : ((DataTable) this.comboEntityList.DataSource).Rows[this.comboEntityList.SelectedIndex][nameof (State)].ToString();
    }
  }

  public string ZipCode
  {
    get
    {
      return this.comboEntityList.SelectedIndex < 0 || this.comboEntityList.DataSource == null ? string.Empty : ((DataTable) this.comboEntityList.DataSource).Rows[this.comboEntityList.SelectedIndex][nameof (ZipCode)].ToString();
    }
  }

  private void comboEntityList_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.Tab)
      return;
    if (e.KeyCode == Keys.Escape)
    {
      this.comboEntityList.DroppedDown = false;
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.comboEntityList.Text, this._currentString, false) == 0)
        return;
      this._currentString = this.comboEntityList.Text;
      this.comboEntityList.DroppedDown = false;
      this.DoActiveEntitySearch();
    }
  }

  private void DoActiveEntitySearch()
  {
    this._dt = new DataTable();
    this._bgw = new BackgroundWorker();
    this._bgw.DoWork += new DoWorkEventHandler(this.bw_DoWork);
    this._bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
    this._bgw.RunWorkerAsync();
  }

  private void bw_DoWork(object sender, DoWorkEventArgs e)
  {
    if (this._entityTypeFilter == ActiveEntitySearch.EntityTypesFilter.All && string.IsNullOrEmpty(this._entityTypeOverride) && string.IsNullOrEmpty(this._entityTypeOverrideInclude))
    {
      this._dt = DefaultDatabase.ExecuteDataTable(this.EntityProcedure, new object[2]
      {
        (object) "@name",
        (object) this.comboEntityList.Text.Trim()
      });
    }
    else
    {
      string str;
      switch (this._entityTypeFilter)
      {
        case ActiveEntitySearch.EntityTypesFilter.ThirdPartyPayee:
          str = "ThirdPartyPayee";
          break;
        case ActiveEntitySearch.EntityTypesFilter.Company:
          str = "Company";
          break;
        case ActiveEntitySearch.EntityTypesFilter.ExpensePayee:
          str = "ExpensePayee";
          break;
        case ActiveEntitySearch.EntityTypesFilter.InspectionCompany:
          str = "InspectionCompany";
          break;
        case ActiveEntitySearch.EntityTypesFilter.Insured:
          str = "Insured";
          break;
        case ActiveEntitySearch.EntityTypesFilter.Producer:
          str = "Producer";
          break;
        case ActiveEntitySearch.EntityTypesFilter.User:
          str = "User";
          break;
        case ActiveEntitySearch.EntityTypesFilter.All:
          str = "ALL";
          break;
        default:
          str = "ALL";
          break;
      }
      if (this._entityTypeFilter != ActiveEntitySearch.EntityTypesFilter.All && string.IsNullOrEmpty(this._entityTypeOverride) && string.IsNullOrEmpty(this._entityTypeOverrideInclude))
        this._dt = DefaultDatabase.ExecuteDataTable(this.EntityProcedure, new object[4]
        {
          (object) "@name",
          (object) this.comboEntityList.Text.Trim(),
          (object) "@entityTypeFilter",
          (object) str
        });
      else if (!string.IsNullOrEmpty(this._entityTypeOverride) && string.IsNullOrEmpty(this._entityTypeOverrideInclude))
      {
        this._dt = DefaultDatabase.ExecuteDataTable(this.EntityProcedure, new object[6]
        {
          (object) "@name",
          (object) this.comboEntityList.Text.Trim(),
          (object) "@entityTypeFilter",
          (object) str,
          (object) "@entityTypeFilterOverride",
          (object) this._entityTypeOverride
        });
      }
      else
      {
        if (!string.IsNullOrEmpty(this._entityTypeOverride) || string.IsNullOrEmpty(this._entityTypeOverrideInclude))
          return;
        this._dt = DefaultDatabase.ExecuteDataTable(this.EntityProcedure, new object[6]
        {
          (object) "@name",
          (object) this.comboEntityList.Text.Trim(),
          (object) "@entityTypeFilter",
          (object) str,
          (object) "@entityTypeFilterOverrideInclude",
          (object) this._entityTypeOverrideInclude
        });
      }
    }
  }

  private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    this.Cursor = Cursors.Default;
    if (this._dt.Rows.Count > 0)
    {
      this._dtBound = this._dt.Copy();
      this.comboEntityList.DataSource = (object) this._dtBound;
      this.comboEntityList.ValueMember = "EntityGuid";
      this.comboEntityList.DisplayMember = "EntityName";
      if (this.comboEntityList.DroppedDown)
        this.comboEntityList.RefreshList();
      else
        this.comboEntityList.DroppedDown = true;
    }
    this._bgw.Dispose();
  }

  public void Clear() => this.comboEntityList.Value = (object) null;

  private void comboEntityList_ItemNotInList(object sender, ValidationErrorEventArgs e)
  {
    if (!((TextEditorControlBase) this.comboEntityList).IsInEditMode)
      return;
    ((TextEditorControlBase) this.comboEntityList).SelectionStart = this.comboEntityList.Text.Length;
  }

  public void SetSelectedEntity(Guid entityGuid, string entityName)
  {
    this._dt = DefaultDatabase.ExecuteDataTable(this.EntityProcedure, new object[2]
    {
      (object) "@name",
      (object) entityName
    });
    this.bw_RunWorkerCompleted((object) this, new RunWorkerCompletedEventArgs((object) null, (Exception) null, false));
    if (this._dt.Rows.Count == 1)
      this.comboEntityList.Value = RuntimeHelpers.GetObjectValue(this._dt.Rows[0]["EntityGuid"]);
    else
      this.comboEntityList.Value = (object) entityGuid;
    this.comboEntityList.CloseUp();
  }

  private void comboEntityList_ValueChanged(object sender, EventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    ActiveEntitySearch.EntityValueChangedEventHandler valueChangedEvent = this.EntityValueChangedEvent;
    if (valueChangedEvent != null)
      valueChangedEvent((object) this, new EventArgs());
    this.comboEntityList.CloseUp();
  }

  public event ActiveEntitySearch.EntityValueChangedEventHandler EntityValueChanged;

  private void comboEntityList_AfterDropDown(object sender, EventArgs e)
  {
    if (!((TextEditorControlBase) this.comboEntityList).IsInEditMode)
      return;
    ((TextEditorControlBase) this.comboEntityList).SelectionStart = this.comboEntityList.Text.Length;
  }

  private void comboEntityList_AfterCloseUp(object sender, EventArgs e)
  {
    if (!((TextEditorControlBase) this.comboEntityList).IsInEditMode)
      return;
    ((TextEditorControlBase) this.comboEntityList).SelectionStart = this.comboEntityList.Text.Length;
  }

  private void comboEntityList_SelectionChangeCommitted(object sender, EventArgs e)
  {
    if (!((TextEditorControlBase) this.comboEntityList).IsInEditMode)
      return;
    ((TextEditorControlBase) this.comboEntityList).SelectionStart = 0;
  }

  private void comboEntityList_BeforeExitEditMode(object sender, BeforeExitEditModeEventArgs e)
  {
  }

  private void comboEntityList_SelectionChanged(object sender, EventArgs e)
  {
  }

  private void buttonFilter_Click(object sender, EventArgs e)
  {
    FormFilterSelection formFilterSelection = new FormFilterSelection(this);
    formFilterSelection.StartPosition = FormStartPosition.Manual;
    formFilterSelection.Location = this.ParentForm.PointToScreen(((Control) this.buttonFilter).Location);
    if (formFilterSelection.ShowDialog() == DialogResult.OK)
    {
      this._entityTypeFilter = ActiveEntitySearch.EntityTypesFilter.All;
      foreach (UltraListViewItem ultraListViewItem in formFilterSelection.listViewFilters.Items)
      {
        if (ultraListViewItem.CheckState == CheckState.Checked)
        {
          string key = ultraListViewItem.Key;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(key))
          {
            case 718021640:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "EX", false) == 0)
              {
                this._entityTypeFilter = this._entityTypeFilter != ActiveEntitySearch.EntityTypesFilter.All ? ActiveEntitySearch.EntityTypesFilter.ExpensePayee | this._entityTypeFilter : ActiveEntitySearch.EntityTypesFilter.ExpensePayee;
                continue;
              }
              break;
            case 861752635:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "TPP", false) == 0)
              {
                this._entityTypeFilter = this._entityTypeFilter != ActiveEntitySearch.EntityTypesFilter.All ? ActiveEntitySearch.EntityTypesFilter.ThirdPartyPayee | this._entityTypeFilter : ActiveEntitySearch.EntityTypesFilter.ThirdPartyPayee;
                continue;
              }
              break;
            case 3322673650:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "C", false) == 0)
              {
                if (this._entityTypeFilter == ActiveEntitySearch.EntityTypesFilter.All)
                {
                  this._entityTypeFilter = ActiveEntitySearch.EntityTypesFilter.Company;
                  continue;
                }
                continue;
              }
              break;
            case 3423339364:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "I", false) == 0)
              {
                this._entityTypeFilter = this._entityTypeFilter != ActiveEntitySearch.EntityTypesFilter.All ? ActiveEntitySearch.EntityTypesFilter.Insured | this._entityTypeFilter : ActiveEntitySearch.EntityTypesFilter.Insured;
                continue;
              }
              break;
            case 3490449840:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "U", false) == 0)
              {
                this._entityTypeFilter = this._entityTypeFilter != ActiveEntitySearch.EntityTypesFilter.All ? ActiveEntitySearch.EntityTypesFilter.User | this._entityTypeFilter : ActiveEntitySearch.EntityTypesFilter.User;
                continue;
              }
              break;
            case 3574337935:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "P", false) == 0)
              {
                this._entityTypeFilter = this._entityTypeFilter != ActiveEntitySearch.EntityTypesFilter.All ? ActiveEntitySearch.EntityTypesFilter.Producer | this._entityTypeFilter : ActiveEntitySearch.EntityTypesFilter.Producer;
                continue;
              }
              break;
            case 3687029303:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "INS", false) == 0)
              {
                this._entityTypeFilter = this._entityTypeFilter != ActiveEntitySearch.EntityTypesFilter.All ? ActiveEntitySearch.EntityTypesFilter.InspectionCompany | this._entityTypeFilter : ActiveEntitySearch.EntityTypesFilter.InspectionCompany;
                continue;
              }
              break;
          }
          this._entityTypeFilter = ActiveEntitySearch.EntityTypesFilter.All;
        }
      }
      this.DoActiveEntitySearch();
    }
    else
      this._entityTypeFilter = ActiveEntitySearch.EntityTypesFilter.All;
  }

  [Flags]
  public enum EntityTypesFilter
  {
    ThirdPartyPayee = 2,
    Company = 4,
    ExpensePayee = 8,
    InspectionCompany = 16, // 0x00000010
    Insured = 32, // 0x00000020
    Producer = 64, // 0x00000040
    User = 128, // 0x00000080
    All = User | Producer | Insured | InspectionCompany | ExpensePayee | Company | ThirdPartyPayee, // 0x000000FE
  }

  public delegate void EntityValueChangedEventHandler(object sender, EventArgs e);
}
