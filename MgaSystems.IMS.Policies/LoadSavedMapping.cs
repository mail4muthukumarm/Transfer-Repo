// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.LoadSavedMapping
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinListView;
using MGASystems.Common;
using MGASystems.Data;
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
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class LoadSavedMapping : Form
{
  private IContainer components;
  private UltraListView listMappings;
  private bool _saved;
  private DataTable _dt;
  private string _mappingStore;
  private static string _mappingName;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LoadSavedMapping));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.listMappings = new UltraListView();
    this.buttonLoad = new UltraButton();
    this.buttonCancel = new UltraButton();
    this.btnDelete = new UltraButton();
    ((ISupportInitialize) this.listMappings).BeginInit();
    this.SuspendLayout();
    ((Control) this.listMappings).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    this.listMappings.ItemSettings.Appearance = (AppearanceBase) appearance1;
    ((Control) this.listMappings).Location = new Point(12, 12);
    ((Control) this.listMappings).Name = "listMappings";
    ((Control) this.listMappings).Size = new Size(308, 309);
    ((Control) this.listMappings).TabIndex = 0;
    ((Control) this.listMappings).Text = "UltraListView1";
    this.listMappings.View = (UltraListViewStyle) 2;
    ((Control) this.buttonLoad).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance4.Image"));
    ((ControlBase) this.buttonLoad).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonLoad).Location = new Point(86, 327);
    ((Control) this.buttonLoad).Name = "buttonLoad";
    ((Control) this.buttonLoad).Size = new Size(74, 31 /*0x1F*/);
    ((Control) this.buttonLoad).TabIndex = 1;
    ((ControlBase) this.buttonLoad).Text = "Load";
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance3.Image"));
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(166, 327);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(74, 31 /*0x1F*/);
    ((Control) this.buttonCancel).TabIndex = 2;
    ((ControlBase) this.buttonCancel).Text = "Cancel";
    ((Control) this.btnDelete).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    ((ControlBase) this.btnDelete).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnDelete).Location = new Point(246, 327);
    ((Control) this.btnDelete).Name = "btnDelete";
    ((Control) this.btnDelete).Size = new Size(74, 31 /*0x1F*/);
    ((Control) this.btnDelete).TabIndex = 3;
    ((ControlBase) this.btnDelete).Text = "Delete";
    this.AcceptButton = (IButtonControl) this.buttonLoad;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(332, 370);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonLoad);
    this.Controls.Add((Control) this.listMappings);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (LoadSavedMapping);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Load / Delete Saved Mapping(s)";
    ((ISupportInitialize) this.listMappings).EndInit();
    this.ResumeLayout(false);
  }

  private virtual UltraButton buttonLoad
  {
    get => this._buttonLoad;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonLoad_Click);
      UltraButton buttonLoad1 = this._buttonLoad;
      if (buttonLoad1 != null)
        ((Control) buttonLoad1).Click -= eventHandler;
      this._buttonLoad = value;
      UltraButton buttonLoad2 = this._buttonLoad;
      if (buttonLoad2 == null)
        return;
      ((Control) buttonLoad2).Click += eventHandler;
    }
  }

  private virtual UltraButton buttonCancel
  {
    get => this._buttonCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonCancel_Click);
      UltraButton buttonCancel1 = this._buttonCancel;
      if (buttonCancel1 != null)
        ((Control) buttonCancel1).Click -= eventHandler;
      this._buttonCancel = value;
      UltraButton buttonCancel2 = this._buttonCancel;
      if (buttonCancel2 == null)
        return;
      ((Control) buttonCancel2).Click += eventHandler;
    }
  }

  private virtual UltraButton btnDelete
  {
    get => this._btnDelete;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDelete_Click);
      UltraButton btnDelete1 = this._btnDelete;
      if (btnDelete1 != null)
        ((Control) btnDelete1).Click -= eventHandler;
      this._btnDelete = value;
      UltraButton btnDelete2 = this._btnDelete;
      if (btnDelete2 == null)
        return;
      ((Control) btnDelete2).Click += eventHandler;
    }
  }

  internal bool Saved => this._saved;

  public bool ClientSaved => this._saved;

  public DataTable Data => this._dt;

  public static string MappingName
  {
    get => LoadSavedMapping._mappingName;
    set => LoadSavedMapping._mappingName = value;
  }

  private void LoadSavedMapping_Load(object sender, EventArgs e)
  {
    try
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, $"SELECT DISTINCT MappingName FROM {this._mappingStore} ORDER BY MappingName ASC");
      try
      {
        foreach (DataRow row in dataTable.Rows)
          this.listMappings.Items.Add(row[0].ToString(), RuntimeHelpers.GetObjectValue(row[0]));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

  private void buttonLoad_Click(object sender, EventArgs e)
  {
    if (((DisposableObjectCollectionBase) this.listMappings.SelectedItems).Count == 0)
      return;
    LoadSavedMapping._mappingName = ((UltraListViewStateSpecificItemsCollectionBase) this.listMappings.SelectedItems)[0].Key;
    this._dt = DefaultDatabase.ExecuteDataTable(CommandType.Text, $"SELECT IMSColumn, SpreadsheetColumn FROM {this._mappingStore} WHERE MappingName = @MN", new object[2]
    {
      (object) "@MN",
      (object) ((UltraListViewStateSpecificItemsCollectionBase) this.listMappings.SelectedItems)[0].Key
    });
    this._saved = true;
    this.Close();
  }

  public LoadSavedMapping(string mappingStore)
  {
    this.Load += new EventHandler(this.LoadSavedMapping_Load);
    this.InitializeComponent();
    this._mappingStore = mappingStore;
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    if (((DisposableObjectCollectionBase) this.listMappings.SelectedItems).Count == 0)
    {
      int num1 = (int) MessageBox.Show("No item selected for deletion.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (MessageBox.Show("Continue with the deletion of the selected mapping(s)?", "Continue Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        return;
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        int num2 = ((DisposableObjectCollectionBase) this.listMappings.SelectedItems).Count - 1;
        for (int index = 0; index <= num2; ++index)
        {
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, $"DELETE FROM {this._mappingStore}" + " WHERE MappingName = @MN", new object[2]
          {
            (object) "@MN",
            (object) ((UltraListViewStateSpecificItemsCollectionBase) this.listMappings.SelectedItems)[index].Key
          });
          ((UltraListViewStateSpecificItemsCollectionBase) this.listMappings.SelectedItems)[index].Visible = false;
        }
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }
}
