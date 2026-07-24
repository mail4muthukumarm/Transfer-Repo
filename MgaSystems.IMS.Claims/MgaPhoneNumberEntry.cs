// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.MgaPhoneNumberEntry
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolTip;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class MgaPhoneNumberEntry : UserControl
{
  private PhoneNumberManager _numberManager;
  private PhoneNumber _currentPhoneNumber;
  private dsPhoneNumberManager _phoneNumberDataset;
  private bool _enabled = true;
  private int _addressId;
  private MgaPhoneNumberEntry.PhoneLabelTypes _phoneLabelType;
  private IContainer components;
  private MGASimpleComboBox comboPhoneTypes;
  private Label label11;
  private Label label10;
  private Label labelPhoneType;
  private dsPhoneTypes dsPhoneTypes1;
  private UltraToolTipManager ultraToolTipManager1;
  private UltraGrid gridPhoneNumbers;
  private MGAInternationalPhoneNumberEditor maskedEditPhoneNumber;
  private Button buttonAddPhoneNumber;
  private Button buttonCancel;

  public MgaPhoneNumberEntry() => this.InitializeComponent();

  public event MgaPhoneNumberEntry.UnsavedPhoneNumberDeletedHandler UnsavedPhoneNumberDeleted;

  protected void OnUnsavedPhoneNumberDeleted(int index)
  {
    if (this.UnsavedPhoneNumberDeleted == null)
      return;
    this.UnsavedPhoneNumberDeleted((object) this, new UnsavedPhoneNumberDeletedEventArgs(index));
  }

  [Browsable(true)]
  [DefaultValue(0)]
  [EditorBrowsable(EditorBrowsableState.Always)]
  public MgaPhoneNumberEntry.PhoneLabelTypes PhoneLabelType
  {
    get => this._phoneLabelType;
    set
    {
      this._phoneLabelType = value;
      this.SetLabelType();
    }
  }

  [Browsable(true)]
  [DefaultValue(true)]
  [EditorBrowsable(EditorBrowsableState.Always)]
  public new bool Enabled
  {
    get => this._enabled;
    set
    {
      this._enabled = value;
      this.SetEnabled(value);
    }
  }

  [AttributeProvider(typeof (IListSource))]
  internal object DataSource
  {
    get => ((UltraGridBase) this.gridPhoneNumbers).DataSource;
    set
    {
      try
      {
        ((UltraGridBase) this.gridPhoneNumbers).DataSource = value;
      }
      catch
      {
      }
    }
  }

  internal int AddressId => this._addressId;

  internal bool HasNewPhoneNumbers => this.NumberManager.Added.Count > 0;

  public PhoneNumberManager NumberManager
  {
    get
    {
      if (this._numberManager == null)
        this._numberManager = new PhoneNumberManager();
      return this._numberManager;
    }
  }

  private void SetEnabled(bool value)
  {
    ((Control) this.gridPhoneNumbers).Enabled = value;
    ((Control) this.maskedEditPhoneNumber).Enabled = value;
    ((Control) this.comboPhoneTypes).Enabled = value;
    this.buttonAddPhoneNumber.Enabled = value;
    this.buttonCancel.Enabled = value;
  }

  private void HideColumns(params string[] columnNames)
  {
    if (((UltraGridBase) this.gridPhoneNumbers).DataSource == null || ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout == null)
      return;
    this.UnhideColumns();
    for (int index = 0; index < columnNames.Length; ++index)
    {
      if (((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].Columns).Exists(columnNames[index]))
        ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].Columns[columnNames[index]].Hidden = true;
    }
  }

  private void UnhideColumns()
  {
    if (((UltraGridBase) this.gridPhoneNumbers).DataSource == null || ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout == null)
      return;
    foreach (UltraGridColumn column in ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].Columns)
    {
      column.MaskInput = string.Empty;
      column.Hidden = false;
    }
  }

  private void LoadPhoneTypes()
  {
    if (this.DesignMode)
      return;
    if (string.IsNullOrEmpty(DefaultDatabase.ConnectionString))
      DefaultDatabase.ConnectionString = CurrentUser.Instance.ConnectionString;
    DefaultDatabase.LoadDataSet((DataSet) this.dsPhoneTypes1, new string[1]
    {
      this.dsPhoneTypes1.PhoneTypes.TableName
    }, "spClaims_LoadPhoneTypes");
  }

  private bool VerifyPhoneNumber()
  {
    if (this.maskedEditPhoneNumber.Value != DBNull.Value && this.maskedEditPhoneNumber.Value != null)
    {
      if (string.IsNullOrEmpty((string) this.maskedEditPhoneNumber.Value))
      {
        int num = (int) MessageBox.Show(Resources.PHONENUMBER_ERROR_ENTERPHONENUMBER, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if (((UltraDropDownBase) this.comboPhoneTypes).SelectedRow == null)
      {
        int num = (int) MessageBox.Show(Resources.PHONENUMBER_ERROR_SELECTPHONETYPE, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if (((UltraGridBase) this.gridPhoneNumbers).DataSource is dsPhoneNumberManager.PhoneNumbersDataTable)
      {
        if ((((UltraGridBase) this.gridPhoneNumbers).DataSource as DataTable).Select($"PhoneTypeId = {((UltraCombo) this.comboPhoneTypes).Value} AND PhoneNumberID <> {(this._currentPhoneNumber == null ? 0 : this._currentPhoneNumber.PhoneNumberId)}").Length != 0)
        {
          int num = (int) MessageBox.Show(Resources.PHONENUMBER_ERROR_PHONETYPEEXISTS, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return false;
        }
      }
      else if (((UltraGridBase) this.gridPhoneNumbers).DataSource != null && (((UltraGridBase) this.gridPhoneNumbers).DataSource as DataTable).Select($"PhoneTypeId = {((UltraCombo) this.comboPhoneTypes).Value} AND PhoneNumberID <> {(this._currentPhoneNumber == null ? 0 : this._currentPhoneNumber.PhoneNumberId)} AND AddressId = {this.AddressId}").Length != 0)
      {
        int num = (int) MessageBox.Show(Resources.PHONENUMBER_ERROR_PHONETYPEEXISTS, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      return true;
    }
    int num1 = (int) MessageBox.Show(Resources.PHONENUMBER_ERROR_ENTERPHONENUMBER, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void ClearEntry()
  {
    if (this._currentPhoneNumber != null)
      this._currentPhoneNumber = (PhoneNumber) null;
    ((Control) this.maskedEditPhoneNumber).Text = string.Empty;
    ((Control) this.comboPhoneTypes).ResetText();
  }

  private void AddNewToDataset(PhoneNumber phoneNumber)
  {
    if (((UltraGridBase) this.gridPhoneNumbers).DataSource == null)
    {
      if (this._phoneNumberDataset == null)
        this._phoneNumberDataset = new dsPhoneNumberManager();
      ((UltraGridBase) this.gridPhoneNumbers).DataSource = (object) this._phoneNumberDataset.PhoneNumbers;
      this.InitializePhoneGrid("AddressId", "PhoneTypeId", "PhoneNumberId", "CountryCode", "InputMask");
      this.CreateGridButtons();
    }
    DataRow row = (((UltraGridBase) this.gridPhoneNumbers).DataSource as DataTable).NewRow();
    row["AddressId"] = (object) phoneNumber.AddressId;
    row["PhoneNumber"] = (object) phoneNumber.Number;
    row["PhoneTypeId"] = (object) phoneNumber.PhoneTypeId;
    row["PhoneType"] = (object) phoneNumber.PhoneType;
    row["CountryCode"] = (object) phoneNumber.CountryCode;
    row["InputMask"] = (object) phoneNumber.InputMask;
    (((UltraGridBase) this.gridPhoneNumbers).DataSource as DataTable).Rows.Add(row);
  }

  private void SetLabelType()
  {
    if (this.PhoneLabelType == MgaPhoneNumberEntry.PhoneLabelTypes.Stacked)
    {
      this.labelPhoneType.AutoSize = false;
      this.labelPhoneType.Size = new Size(86, 13);
    }
    else
      this.labelPhoneType.AutoSize = true;
    this.Invalidate();
  }

  public void Clear()
  {
    if (this._phoneNumberDataset == null)
      this._phoneNumberDataset = new dsPhoneNumberManager();
    this._phoneNumberDataset.PhoneNumbers.Clear();
    ((Control) this.maskedEditPhoneNumber).Text = string.Empty;
    ((Control) this.comboPhoneTypes).ResetText();
    if (this.NumberManager.Added != null)
      this.NumberManager.Added.Clear();
    if (this.NumberManager.Updated != null)
      this.NumberManager.Updated.Clear();
    if (this.NumberManager.Deleted != null)
      this.NumberManager.Deleted.Clear();
    this.DataSource = (object) null;
  }

  public void DeleteAll()
  {
    foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this.gridPhoneNumbers).Rows.GetFilteredInNonGroupByRows())
      this.DeletePhoneNumber(filteredInNonGroupByRow);
  }

  public void SetAddressId(int addressId)
  {
    if (this.NumberManager.Added != null)
    {
      this.NumberManager.Added.Clear();
      this.NumberManager.Deleted.Clear();
      this.NumberManager.Updated.Clear();
    }
    this._addressId = addressId;
    if (((UltraGridBase) this.gridPhoneNumbers).DataSource == null)
      return;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].ColumnFilters["AddressId"].ClearFilterConditions();
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].ColumnFilters["AddressId"].FilterConditions.Add((FilterComparisionOperator) 0, (object) this._addressId);
  }

  internal void InitializePhoneGrid(params string[] columnNames)
  {
    if (((UltraGridBase) this.gridPhoneNumbers).DisplayLayout == null)
      return;
    this.HideColumns(columnNames);
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].Columns["PhoneNumber"].MaskInput = "(###) ###-####";
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].Columns["PhoneNumber"].MaskDisplayMode = (MaskMode) 3;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].Columns["PhoneNumber"].MaskDataMode = (MaskMode) 0;
    ((HeaderBase) ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].Columns["PhoneNumber"].Header).Caption = "Phone Number";
    ((HeaderBase) ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].Columns["PhoneType"].Header).Caption = "Type";
    this.CreateGridButtons();
  }

  public void AddNew(string phoneNumber)
  {
    if (this.dsPhoneTypes1.PhoneTypes.Count == 0)
      return;
    int phoneTypeId = -1;
    foreach (dsPhoneTypes.PhoneTypesRow phoneType in (TypedTableBase<dsPhoneTypes.PhoneTypesRow>) this.dsPhoneTypes1.PhoneTypes)
    {
      if (phoneType.PhoneType == "Primary")
      {
        phoneTypeId = phoneType.PhoneTypeId;
        break;
      }
    }
    if (phoneTypeId == -1)
      throw new PrimaryPhoneTypeNotFoundException("Primary phone type could not be determined.");
    PhoneNumber phoneNumber1 = new PhoneNumber(this.AddressId, phoneNumber.Replace("-", ""), phoneTypeId, "Primary", PhoneNumber.PhoneNumberStatus.New, this.maskedEditPhoneNumber.CountryCode, this.maskedEditPhoneNumber.InputMask);
    this.NumberManager.Added.Add(phoneNumber1);
    this.AddNewToDataset(phoneNumber1);
  }

  public void AddNew(string phoneNumber, string phoneType)
  {
    if (this.dsPhoneTypes1.PhoneTypes.Count == 0)
      return;
    int phoneTypeId = -1;
    foreach (dsPhoneTypes.PhoneTypesRow phoneType1 in (TypedTableBase<dsPhoneTypes.PhoneTypesRow>) this.dsPhoneTypes1.PhoneTypes)
    {
      if (phoneType1.PhoneType == phoneType)
      {
        phoneTypeId = phoneType1.PhoneTypeId;
        break;
      }
    }
    if (phoneTypeId == -1)
      throw new PrimaryPhoneTypeNotFoundException($"{phoneType} phone type could not be determined.");
    PhoneNumber phoneNumber1 = new PhoneNumber(this.AddressId, phoneNumber.Replace("-", ""), phoneTypeId, phoneType, PhoneNumber.PhoneNumberStatus.New, this.maskedEditPhoneNumber.CountryCode, this.maskedEditPhoneNumber.InputMask);
    this.NumberManager.Added.Add(phoneNumber1);
    this.AddNewToDataset(phoneNumber1);
  }

  private void buttonAddPhoneNumber_Click(object sender, EventArgs e)
  {
    if (!this.VerifyPhoneNumber())
      return;
    if (this._currentPhoneNumber == null)
    {
      PhoneNumber phoneNumber = new PhoneNumber(this.AddressId, ((Control) this.maskedEditPhoneNumber).Text, (int) ((UltraCombo) this.comboPhoneTypes).Value, ((Control) this.comboPhoneTypes).Text, PhoneNumber.PhoneNumberStatus.New, this.maskedEditPhoneNumber.CountryCode, this.maskedEditPhoneNumber.InputMask);
      this.NumberManager.Added.Add(phoneNumber);
      this.AddNewToDataset(phoneNumber);
    }
    else if (this._currentPhoneNumber.Number != (string) this.maskedEditPhoneNumber.Value || this._currentPhoneNumber.PhoneTypeId != (int) ((UltraCombo) this.comboPhoneTypes).Value)
    {
      UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridPhoneNumbers).Rows.GetFilteredInNonGroupByRows();
      for (int index = 0; index < inNonGroupByRows.Length; ++index)
      {
        if ((int) inNonGroupByRows[index].Cells["PhoneNumberId"].Value == this._currentPhoneNumber.PhoneNumberId)
        {
          ((AppearanceBase) inNonGroupByRows[index].Appearance).FontData.Bold = (DefaultableBoolean) 1;
          inNonGroupByRows[index].Cells["PhoneNumber"].Value = this.maskedEditPhoneNumber.Value;
          inNonGroupByRows[index].Cells["CountryCode"].Value = (object) this.maskedEditPhoneNumber.CountryCode;
          inNonGroupByRows[index].Cells["InputMask"].Value = (object) this.maskedEditPhoneNumber.InputMask;
          break;
        }
      }
      this.NumberManager.Updated.Add(new PhoneNumber()
      {
        PhoneNumberId = this._currentPhoneNumber.PhoneNumberId,
        PhoneType = ((Control) this.comboPhoneTypes).Text,
        PhoneTypeId = (int) ((UltraCombo) this.comboPhoneTypes).Value,
        AddressId = this._currentPhoneNumber.AddressId,
        CountryCode = this.maskedEditPhoneNumber.CountryCode,
        InputMask = this.maskedEditPhoneNumber.InputMask,
        Number = (string) this.maskedEditPhoneNumber.Value,
        Status = PhoneNumber.PhoneNumberStatus.Updated
      });
    }
    this.ClearEntry();
  }

  private void gridPhoneNumbers_ClickCellButton(object sender, CellEventArgs e)
  {
    if (((KeyedSubObjectBase) e.Cell.Column).Key == "Delete")
      this.DeletePhoneNumber(e.Cell.Row);
    if (!(((KeyedSubObjectBase) e.Cell.Column).Key == "Edit"))
      return;
    this.EditPhoneNumber(e.Cell.Row);
  }

  private void DeletePhoneNumber(UltraGridRow row)
  {
    foreach (UltraGridCell cell in row.Cells)
    {
      ((AppearanceBase) cell.Appearance).FontData.Strikeout = (DefaultableBoolean) 1;
      ((AppearanceBase) cell.Appearance).FontData.Bold = (DefaultableBoolean) 1;
      ((AppearanceBase) cell.Appearance).ForeColor = Color.Red;
    }
    if (this.NumberManager.Added.Count != 0)
    {
      foreach (PhoneNumber phoneNumber in this.NumberManager.Added)
      {
        if (phoneNumber.Number == (string) row.Cells["PhoneNumber"].Value || phoneNumber.PhoneTypeId == (int) row.Cells["PhoneTypeId"].Value)
        {
          this.NumberManager.Added.Remove(phoneNumber);
          return;
        }
      }
    }
    if (this.NumberManager.Updated.Count != 0)
    {
      foreach (PhoneNumber phoneNumber in this.NumberManager.Updated)
      {
        if (phoneNumber.Number == (string) row.Cells["PhoneNumber"].Value || phoneNumber.PhoneTypeId == (int) row.Cells["PhoneTypeId"].Value)
          this.NumberManager.Updated.Remove(phoneNumber);
      }
    }
    PhoneNumber phoneNumber1 = new PhoneNumber();
    phoneNumber1.PhoneNumberId = (int) row.Cells["PhoneNumberId"].Value;
    phoneNumber1.AddressId = (int) row.Cells["AddressId"].Value;
    phoneNumber1.Number = (string) row.Cells["PhoneNumber"].Value;
    phoneNumber1.PhoneTypeId = (int) row.Cells["PhoneTypeId"].Value;
    phoneNumber1.PhoneType = (string) row.Cells["PhoneType"].Value;
    phoneNumber1.Status = PhoneNumber.PhoneNumberStatus.Deleted;
    if ((int) row.Cells["PhoneNumberId"].Value == 0)
      row.Delete(false);
    this.NumberManager.Deleted.Add(phoneNumber1);
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.ClearEntry();

  private void EditPhoneNumber(UltraGridRow row)
  {
    this._currentPhoneNumber = new PhoneNumber((int) row.Cells["AddressID"].Value, row.Cells["PhoneNumber"].Value.ToString(), (int) row.Cells["PhoneTypeID"].Value, row.Cells["PhoneType"].Value.ToString(), row.Cells["CountryCode"].Value.ToString(), MGAInternationalPhoneNumberEditor.GetCountryInputMask(row.Cells["CountryCode"].Value.ToString()));
    this._currentPhoneNumber.PhoneNumberId = (int) row.Cells["PhoneNumberId"].Value;
    this.maskedEditPhoneNumber.Value = (object) this._currentPhoneNumber.Number;
    this.maskedEditPhoneNumber.CountryCode = row.Cells["CountryCode"].Value.ToString();
    ((Control) this.comboPhoneTypes).Text = this._currentPhoneNumber.PhoneType;
  }

  private void MgaPhoneNumberEntry_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadPhoneTypes();
  }

  private void CreateGridButtons()
  {
    if (!((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].Columns).Exists("Edit"))
    {
      ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].Columns.Add("Edit");
      UltraGridColumn column = ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].Columns["Edit"];
      column.Style = (ColumnStyle) 8;
      column.ButtonDisplayStyle = (ButtonDisplayStyle) 1;
      column.Width = 22;
      ((HeaderBase) column.Header).Caption = string.Empty;
      column.CellButtonAppearance.ImageHAlign = (HAlign) 2;
      column.CellButtonAppearance.ImageVAlign = (VAlign) 2;
      column.CellButtonAppearance.Image = (object) Resources.Edit;
      column.CellButtonAppearance.BackColor = Color.White;
    }
    if (((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].Columns).Exists("Delete"))
      return;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].Columns.Add("Delete");
    UltraGridColumn column1 = ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Bands[0].Columns["Delete"];
    column1.Style = (ColumnStyle) 8;
    column1.ButtonDisplayStyle = (ButtonDisplayStyle) 1;
    column1.Width = 22;
    ((HeaderBase) column1.Header).Caption = string.Empty;
    column1.CellButtonAppearance.ImageHAlign = (HAlign) 2;
    column1.CellButtonAppearance.ImageVAlign = (VAlign) 2;
    column1.CellButtonAppearance.Image = (object) Resources.DeleteClaimSmall;
    column1.CellButtonAppearance.BackColor = Color.White;
  }

  private void gridPhoneNumbers_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (e.Row.Cells["InputMask"].Value != DBNull.Value && e.Row.Cells["InputMask"].Value != null && !string.IsNullOrEmpty(e.Row.Cells["InputMask"].Value.ToString()))
    {
      e.Row.Cells["PhoneNumber"].EditorComponent = (Component) new UltraMaskedEdit()
      {
        InputMask = e.Row.Cells["InputMask"].Value.ToString()
      };
    }
    else
    {
      e.Row.Cells["InputMask"].Value = (object) MGAInternationalPhoneNumberEditor.GetCountryInputMask(e.Row.Cells["CountryCode"].Value.ToString());
      e.Row.Cells["PhoneNumber"].EditorComponent = (Component) new UltraMaskedEdit()
      {
        InputMask = e.Row.Cells["InputMask"].Value.ToString()
      };
    }
  }

  private void gridPhoneNumbers_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    if (((DisposableObjectCollectionBase) e.Layout.Bands).Count > 0 && ((KeyedSubObjectsCollectionBase) e.Layout.Bands[0].Columns).Exists("InputMask"))
      e.Layout.Bands[0].Columns["InputMask"].Hidden = true;
    e.Layout.Bands[0].Columns["PhoneNumber"].UseEditorMaskSettings = true;
    e.Layout.Bands[0].Columns["PhoneNumber"].MaskDisplayMode = (MaskMode) 3;
  }

  private void buttonAddPhoneNumber_Leave(object sender, EventArgs e)
  {
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

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
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MgaPhoneNumberEntry));
    this.dsPhoneTypes1 = new dsPhoneTypes();
    this.label11 = new Label();
    this.label10 = new Label();
    this.labelPhoneType = new Label();
    this.ultraToolTipManager1 = new UltraToolTipManager(this.components);
    this.gridPhoneNumbers = new UltraGrid();
    this.maskedEditPhoneNumber = new MGAInternationalPhoneNumberEditor();
    this.comboPhoneTypes = new MGASimpleComboBox();
    this.buttonAddPhoneNumber = new Button();
    this.buttonCancel = new Button();
    this.dsPhoneTypes1.BeginInit();
    ((ISupportInitialize) this.gridPhoneNumbers).BeginInit();
    ((ISupportInitialize) this.comboPhoneTypes).BeginInit();
    this.SuspendLayout();
    this.dsPhoneTypes1.DataSetName = "dsPhoneTypes";
    this.dsPhoneTypes1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label11.AutoSize = true;
    this.label11.Location = new Point(186, 112 /*0x70*/);
    this.label11.Name = "label11";
    this.label11.Size = new Size(35, 13);
    this.label11.TabIndex = 27;
    this.label11.Text = "Type:";
    this.label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label10.AutoSize = true;
    this.label10.Location = new Point(8, 112 /*0x70*/);
    this.label10.Name = "label10";
    this.label10.Size = new Size(81, 13);
    this.label10.TabIndex = 25;
    this.label10.Text = "Phone Number:";
    this.labelPhoneType.AutoSize = true;
    this.labelPhoneType.Location = new Point(3, 7);
    this.labelPhoneType.Name = "labelPhoneType";
    this.labelPhoneType.Size = new Size(86, 13);
    this.labelPhoneType.TabIndex = 23;
    this.labelPhoneType.Text = "Phone Numbers:";
    this.ultraToolTipManager1.ContainingControl = (Control) this;
    ((Control) this.gridPhoneNumbers).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridPhoneNumbers).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridPhoneNumbers).Location = new Point(105, 7);
    ((Control) this.gridPhoneNumbers).Name = "gridPhoneNumbers";
    ((Control) this.gridPhoneNumbers).Size = new Size(261, 102);
    ((Control) this.gridPhoneNumbers).TabIndex = 31 /*0x1F*/;
    ((UltraControlBase) this.gridPhoneNumbers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridPhoneNumbers).UseOsThemes = (DefaultableBoolean) 2;
    this.gridPhoneNumbers.InitializeLayout += new InitializeLayoutEventHandler(this.gridPhoneNumbers_InitializeLayout);
    this.gridPhoneNumbers.InitializeRow += new InitializeRowEventHandler(this.gridPhoneNumbers_InitializeRow);
    this.gridPhoneNumbers.ClickCellButton += new CellEventHandler(this.gridPhoneNumbers_ClickCellButton);
    ((Control) this.maskedEditPhoneNumber).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.maskedEditPhoneNumber.CountryCode = "";
    ((Control) this.maskedEditPhoneNumber).Location = new Point(11, (int) sbyte.MaxValue);
    this.maskedEditPhoneNumber.MGAStyle = (MGAStyles) 1;
    ((Control) this.maskedEditPhoneNumber).Name = "maskedEditPhoneNumber";
    ((Control) this.maskedEditPhoneNumber).Size = new Size(175, 21);
    ((Control) this.maskedEditPhoneNumber).TabIndex = 32 /*0x20*/;
    this.maskedEditPhoneNumber.Value = componentResourceManager.GetObject("maskedEditPhoneNumber.Value");
    ((Control) this.comboPhoneTypes).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((UltraCombo) this.comboPhoneTypes).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboPhoneTypes).DataMember = "PhoneTypes";
    ((UltraGridBase) this.comboPhoneTypes).DataSource = (object) this.dsPhoneTypes1;
    ((UltraDropDownBase) this.comboPhoneTypes).DisplayMember = "PhoneType";
    ((UltraCombo) this.comboPhoneTypes).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboPhoneTypes).DropDownWidth = 200;
    ((Control) this.comboPhoneTypes).Location = new Point(189, (int) sbyte.MaxValue);
    this.comboPhoneTypes.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboPhoneTypes).Name = "comboPhoneTypes";
    ((Control) this.comboPhoneTypes).Size = new Size(113, 21);
    ((Control) this.comboPhoneTypes).TabIndex = 28;
    ((UltraControlBase) this.comboPhoneTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboPhoneTypes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboPhoneTypes).ValueMember = "PhoneTypeId";
    this.buttonAddPhoneNumber.Image = (Image) Resources.Add;
    this.buttonAddPhoneNumber.Location = new Point(308, 126);
    this.buttonAddPhoneNumber.Name = "buttonAddPhoneNumber";
    this.buttonAddPhoneNumber.Size = new Size(28, 22);
    this.buttonAddPhoneNumber.TabIndex = 33;
    this.buttonAddPhoneNumber.UseVisualStyleBackColor = true;
    this.buttonAddPhoneNumber.Click += new EventHandler(this.buttonAddPhoneNumber_Click);
    this.buttonCancel.Image = (Image) Resources.BlueRefresh;
    this.buttonCancel.Location = new Point(340, 126);
    this.buttonCancel.Name = "buttonCancel";
    this.buttonCancel.Size = new Size(28, 22);
    this.buttonCancel.TabIndex = 34;
    this.buttonCancel.UseVisualStyleBackColor = true;
    this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonAddPhoneNumber);
    this.Controls.Add((Control) this.maskedEditPhoneNumber);
    this.Controls.Add((Control) this.gridPhoneNumbers);
    this.Controls.Add((Control) this.comboPhoneTypes);
    this.Controls.Add((Control) this.label11);
    this.Controls.Add((Control) this.label10);
    this.Controls.Add((Control) this.labelPhoneType);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (MgaPhoneNumberEntry);
    this.Size = new Size(371, 154);
    this.Load += new EventHandler(this.MgaPhoneNumberEntry_Load);
    this.dsPhoneTypes1.EndInit();
    ((ISupportInitialize) this.gridPhoneNumbers).EndInit();
    ((ISupportInitialize) this.comboPhoneTypes).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [Flags]
  public enum PhoneLabelTypes
  {
    Default = 0,
    Linear = 2,
    Stacked = 4,
  }

  public delegate void UnsavedPhoneNumberDeletedHandler(
    object sender,
    UnsavedPhoneNumberDeletedEventArgs e);
}
