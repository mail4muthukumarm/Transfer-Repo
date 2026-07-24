// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormAuthorizeOfficeLocationCurrencies
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinListView;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class FormAuthorizeOfficeLocationCurrencies : FormBase
{
  private IContainer components;

  public FormAuthorizeOfficeLocationCurrencies()
  {
    this.Load += new EventHandler(this.FormAuthorizeOfficeLocationCurrencies_Load);
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
    Appearance appearance2 = new Appearance();
    UltraListViewSubItemColumn viewSubItemColumn = new UltraListViewSubItemColumn("Currency Description");
    Appearance appearance3 = new Appearance();
    this.listViewCurrencies = new UltraListView();
    this.Label1 = new Label();
    this.comboOfficeLocation = new MGASimpleComboBox();
    ((ISupportInitialize) this.listViewCurrencies).BeginInit();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    this.SuspendLayout();
    appearance1.BorderColor = Color.LightSteelBlue;
    this.listViewCurrencies.Appearance = (AppearanceBase) appearance1;
    this.listViewCurrencies.GroupHeadersVisible = (DefaultableBoolean) 2;
    this.listViewCurrencies.ItemSettings.DefaultImage = (Image) MGASystems.IMS.Forms.My.Resources.Resources.money;
    appearance2.BackColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, (int) byte.MaxValue);
    this.listViewCurrencies.ItemSettings.HotTrackingAppearance = (AppearanceBase) appearance2;
    ((Control) this.listViewCurrencies).Location = new Point(6, 32 /*0x20*/);
    ((KeyedSubObjectBase) this.listViewCurrencies.MainColumn).Key = "Currency Code";
    ((UltraListViewColumnBase) this.listViewCurrencies.MainColumn).Width = 50;
    ((Control) this.listViewCurrencies).Name = "listViewCurrencies";
    ((Control) this.listViewCurrencies).Size = new Size(360, 469);
    ((KeyedSubObjectBase) viewSubItemColumn).Key = "Currency Description";
    ((UltraListViewColumnBase) viewSubItemColumn).Width = 100;
    this.listViewCurrencies.SubItemColumns.AddRange(new UltraListViewSubItemColumn[1]
    {
      viewSubItemColumn
    });
    ((Control) this.listViewCurrencies).TabIndex = 0;
    ((Control) this.listViewCurrencies).Text = "UltraListView1";
    ((UltraControlBase) this.listViewCurrencies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.listViewCurrencies).UseOsThemes = (DefaultableBoolean) 2;
    this.listViewCurrencies.View = (UltraListViewStyle) 0;
    this.listViewCurrencies.ViewSettingsDetails.AllowColumnMoving = false;
    this.listViewCurrencies.ViewSettingsDetails.AutoFitColumns = (AutoFitColumns) 2;
    ((UltraListViewListSettingsBase) this.listViewCurrencies.ViewSettingsDetails).CheckBoxStyle = (CheckBoxStyle) 1;
    this.listViewCurrencies.ViewSettingsDetails.ColumnAutoSizeMode = (ColumnAutoSizeMode) 10;
    appearance3.BackColor = Color.LightSteelBlue;
    appearance3.BackColor2 = Color.White;
    appearance3.BackGradientStyle = (GradientStyle) 36;
    appearance3.BorderColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    this.listViewCurrencies.ViewSettingsDetails.ColumnHeaderAppearance = (AppearanceBase) appearance3;
    this.listViewCurrencies.ViewSettingsDetails.ColumnHeaderStyle = (HeaderStyle) 4;
    this.listViewCurrencies.ViewSettingsDetails.FullRowSelect = true;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Tahoma", 8.25f);
    this.Label1.Location = new Point(4, 5);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(83, 13);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Office Location:";
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(93, 5);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(273, 21);
    ((Control) this.comboOfficeLocation).TabIndex = 2;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(369, 503);
    this.Controls.Add((Control) this.comboOfficeLocation);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.listViewCurrencies);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormAuthorizeOfficeLocationCurrencies);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Authorize Office Location Currencies";
    ((ISupportInitialize) this.listViewCurrencies).EndInit();
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual UltraListView listViewCurrencies
  {
    get => this._listViewCurrencies;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemCheckStateChangedEventHandler changedEventHandler = new ItemCheckStateChangedEventHandler(this.listViewCurrencies_ItemCheckStateChanged);
      UltraListView listViewCurrencies1 = this._listViewCurrencies;
      if (listViewCurrencies1 != null)
        listViewCurrencies1.ItemCheckStateChanged -= changedEventHandler;
      this._listViewCurrencies = value;
      UltraListView listViewCurrencies2 = this._listViewCurrencies;
      if (listViewCurrencies2 == null)
        return;
      listViewCurrencies2.ItemCheckStateChanged += changedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox comboOfficeLocation
  {
    get => this._comboOfficeLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
      MGASimpleComboBox comboOfficeLocation1 = this._comboOfficeLocation;
      if (comboOfficeLocation1 != null)
        comboOfficeLocation1.RowSelected -= selectedEventHandler;
      this._comboOfficeLocation = value;
      MGASimpleComboBox comboOfficeLocation2 = this._comboOfficeLocation;
      if (comboOfficeLocation2 == null)
        return;
      comboOfficeLocation2.RowSelected += selectedEventHandler;
    }
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_GetOfficeLocations");
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    this.comboOfficeLocation.Value = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.comboOfficeLocation).Rows[0].Cells["ID"].Value);
  }

  private void LoadAuthorizedCurrencies()
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
      return;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spFin_GetAuthorizedCurrencies", new object[2]
    {
      (object) "@GLCompanyId",
      ((UltraDropDownBase) this.comboOfficeLocation).SelectedRow.Cells["ID"].Value
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        if (((KeyedSubObjectsCollectionBase) this.listViewCurrencies.Items).Exists(row["CurrencyCode"].ToString()))
          this.listViewCurrencies.Items[row["CurrencyCode"].ToString()].CheckState = CheckState.Checked;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void UncheckAll()
  {
    foreach (UltraListViewItem ultraListViewItem in this.listViewCurrencies.Items)
      ultraListViewItem.CheckState = CheckState.Unchecked;
  }

  private void LoadCurrencies()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spFin_GetCurrencies");
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        this.listViewCurrencies.Items.Add(row["CurrencyCode"].ToString());
        UltraListViewItem ultraListViewItem = this.listViewCurrencies.Items[row["CurrencyCode"].ToString()];
        ((UltraListViewItemBase) ultraListViewItem.SubItems[0]).Value = RuntimeHelpers.GetObjectValue(row["CurrencyCode"]);
        ((UltraListViewItemBase) ultraListViewItem.SubItems[0]).Value = RuntimeHelpers.GetObjectValue(row["Currency"]);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void SaveAuthorizedCurrency(int glCompanyId, string currencyCode)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_AuthorizeOfficeLocationCurrency", new object[4]
    {
      (object) "@GLCompanyId",
      (object) glCompanyId,
      (object) "@CurrencyCode",
      (object) currencyCode
    });
  }

  private void DeleteAuthorizedCurrency(int glCompanyId, string currencyCode)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_DeleteAuthorizedOfficeLocationCurrency", new object[4]
    {
      (object) "@GLCompanyId",
      (object) glCompanyId,
      (object) "@CurrencyCode",
      (object) currencyCode
    });
  }

  private void FormAuthorizeOfficeLocationCurrencies_Load(object sender, EventArgs e)
  {
    this.comboOfficeLocation.EventManager.SetEnabled((ComboEventIds) 7, false);
    this.LoadOfficeLocations();
    this.LoadCurrencies();
    this.LoadAuthorizedCurrencies();
    this.comboOfficeLocation.EventManager.SetEnabled((ComboEventIds) 7, true);
  }

  private void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    this.listViewCurrencies.EventManager.Disable((UltraListViewEventIds) 11);
    this.UncheckAll();
    this.LoadAuthorizedCurrencies();
    this.listViewCurrencies.EventManager.Enable((UltraListViewEventIds) 11);
  }

  private void listViewCurrencies_ItemCheckStateChanged(
    object sender,
    ItemCheckStateChangedEventArgs e)
  {
    if (((ItemEventArgs) e).Item.CheckState == CheckState.Checked)
      DefaultDatabase.ExecuteNonQuery("spFin_AuthorizeOfficeLocationCurrency", new object[4]
      {
        (object) "@GLCompanyId",
        ((UltraDropDownBase) this.comboOfficeLocation).SelectedRow.Cells["ID"].Value,
        (object) "@CurrencyCode",
        (object) ((ItemEventArgs) e).Item.Key
      });
    else
      DefaultDatabase.ExecuteNonQuery("spFin_DeleteAuthorizedOfficeLocationCurrency", new object[4]
      {
        (object) "@GLCompanyId",
        ((UltraDropDownBase) this.comboOfficeLocation).SelectedRow.Cells["ID"].Value,
        (object) "@CurrencyCode",
        (object) ((ItemEventArgs) e).Item.Key
      });
  }
}
