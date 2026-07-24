// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.Controller.MvcComboBoxController`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;
using MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.View;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.Controller;

public class MvcComboBoxController<TDisplayItem> : 
  MvcControllerBase<IMvcComboBoxModel<TDisplayItem>, IMvcComboBoxView>,
  IMvcComboBoxController<TDisplayItem>,
  IMvcComboBoxController,
  IMvcController
  where TDisplayItem : class
{
  public const string DefaultDisplayItemColumnCaption = "<<Hidden DisplayItem Column>>";
  private readonly IUltraGridTableSettings<TDisplayItem> _tableSettings;
  private readonly string _selectedDisplayColumnIdentifier;
  private readonly string _valueColumnIdentifier;
  private BindingList<TDisplayItem> _modelItems;

  private BindingList<TDisplayItem> ModelItems
  {
    get
    {
      if (this._modelItems == null)
      {
        this._modelItems = new BindingList<TDisplayItem>();
        foreach (TDisplayItem displayItem in this.Model.Items)
          this._modelItems.Add(displayItem);
        if (!this.Model.MustHaveSelection)
          this._modelItems.Insert(0, default (TDisplayItem));
      }
      return this._modelItems;
    }
  }

  public bool? OverrideDisplayDropDownColumnHeaders { get; set; }

  public MvcComboBoxController(Func<TDisplayItem, string> getDisplayValue)
    : this(new IComboBoxColumn<TDisplayItem>[1]
    {
      (IComboBoxColumn<TDisplayItem>) new TextReadOnlyColumn<TDisplayItem>("<<Hidden Single Column>>", 400, (Func<TDisplayItem, object>) getDisplayValue)
      {
        IsComboBoxSelectionDisplayColumn = true
      }
    })
  {
  }

  public MvcComboBoxController(IComboBoxColumn<TDisplayItem>[] columns)
  {
    if (columns == null)
      throw new ArgumentNullException(nameof (columns));
    if (!((IEnumerable<IComboBoxColumn<TDisplayItem>>) columns).Any<IComboBoxColumn<TDisplayItem>>())
      throw new ArgumentException("Cannot create a combo box controller with no columns to display.");
    if (!((IEnumerable<IComboBoxColumn<TDisplayItem>>) columns).Any<IComboBoxColumn<TDisplayItem>>((Func<IComboBoxColumn<TDisplayItem>, bool>) (c => c.Visible)))
      throw new ArgumentException("Must have at least one visible column.");
    this._selectedDisplayColumnIdentifier = ((IUniqueObject<string>) (((IEnumerable<IComboBoxColumn<TDisplayItem>>) columns).SingleOrDefault<IComboBoxColumn<TDisplayItem>>((Func<IComboBoxColumn<TDisplayItem>, bool>) (x => x.IsComboBoxSelectionDisplayColumn)) ?? throw new ArgumentException("Must set exactly one display column."))).UniqueIdentifier;
    List<IUltraGridColumnSettings<TDisplayItem>> gridColumnSettingsList = new List<IUltraGridColumnSettings<TDisplayItem>>();
    foreach (IComboBoxColumn<TDisplayItem> column in columns)
      gridColumnSettingsList.Add((IUltraGridColumnSettings<TDisplayItem>) column);
    DisplayItemColumn<TDisplayItem> displayItemColumn = new DisplayItemColumn<TDisplayItem>("<<Hidden DisplayItem Column>>", 10, false);
    gridColumnSettingsList.Add((IUltraGridColumnSettings<TDisplayItem>) displayItemColumn);
    this._valueColumnIdentifier = displayItemColumn.UniqueIdentifier;
    this._tableSettings = (IUltraGridTableSettings<TDisplayItem>) new UltraGridTableSettings<TDisplayItem>(gridColumnSettingsList.ToArray());
  }

  public void RequestSetSelectedValue(TDisplayItem value)
  {
    if ((object) value == null)
      this.Model.ClearSelection();
    else
      this.Model.SelectedItem = value;
  }

  public void RequestAddItem(object value)
  {
    if (!(value is TDisplayItem displayItem))
      throw new InvalidOperationException("Must add a TDisplayItem.");
    this.RequestAddItem((object) displayItem);
  }

  public void RequestRemoveItem(object value)
  {
    if (!(value is TDisplayItem displayItem))
      throw new InvalidOperationException("Must remove a TDisplayItem.");
    this.RequestRemoveItem((object) displayItem);
  }

  public void RequestSetSelectedValue(object value)
  {
    if (value == null)
    {
      this.RequestSetSelectedValue(default (TDisplayItem));
    }
    else
    {
      if (!(value is TDisplayItem displayItem))
        throw new InvalidOperationException("Must set selected value to be that of TDisplayItem.");
      this.RequestSetSelectedValue(displayItem);
    }
  }

  public void WireUpComboBox(MGAComboBox comboBox)
  {
    if (comboBox == null)
      throw new ArgumentNullException(nameof (comboBox));
    ((UltraGridBase) comboBox).DataSource = (object) this.ModelItems;
    ((Control) comboBox).Enabled = true;
    this._tableSettings.ApplyToGridAsTopLevelTable((UltraGridBase) comboBox);
    ((UltraDropDownBase) comboBox).DropDownWidth = this._tableSettings.GetPreferredWidth();
    ((UltraDropDownBase) comboBox).ValueMember = this._valueColumnIdentifier;
    ((UltraDropDownBase) comboBox).DisplayMember = this._selectedDisplayColumnIdentifier;
    comboBox.MGAStyle = MGAStyles.Blue;
    ((UltraControlBase) comboBox).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) comboBox).UseOsThemes = (DefaultableBoolean) 2;
    UltraGridLayout displayLayout = comboBox.DisplayLayout;
    displayLayout.AutoFitStyle = (AutoFitStyle) 1;
    displayLayout.SelectionOverlayBorderColor = Color.LightSteelBlue;
    displayLayout.SelectionOverlayBorderThickness = 1;
    displayLayout.SelectionOverlayColor = Color.LightSteelBlue;
    displayLayout.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    displayLayout.Override.HeaderAppearance.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    this.SetDropDownColumnHeaderVisibility(comboBox);
  }

  private void SetDropDownColumnHeaderVisibility(MGAComboBox cbWrappedComboBox)
  {
    if (this.OverrideDisplayDropDownColumnHeaders.HasValue)
      cbWrappedComboBox.DisplayLayout.Bands[0].ColHeadersVisible = this.OverrideDisplayDropDownColumnHeaders.Value;
    else
      MvcComboBoxController<TDisplayItem>.DisplayColumnHeadersIfMoreThanOneColumn(cbWrappedComboBox);
  }

  private static void DisplayColumnHeadersIfMoreThanOneColumn(MGAComboBox cbWrappedComboBox)
  {
    int num = 0;
    UltraGridBand band = cbWrappedComboBox.DisplayLayout.Bands[0];
    foreach (UltraGridColumn column in band.Columns)
    {
      if (!column.Hidden)
        ++num;
    }
    band.ColHeadersVisible = num > 1;
  }
}
