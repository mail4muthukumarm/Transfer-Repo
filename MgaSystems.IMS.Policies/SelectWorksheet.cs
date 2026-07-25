// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.SelectWorksheet
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Shared;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinListView;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.AsposeFacade.Cells;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class SelectWorksheet : Form
{
  private IContainer components;
  private Label Label1;
  private Label Label2;
  private UltraListView listWorksheets;
  private Workbook _workbook;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SelectWorksheet));
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.listWorksheets = new UltraListView();
    this.buttonOK = new UltraButton();
    ((ISupportInitialize) this.listWorksheets).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(12, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(248, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "This workbook contains more than one worksheet.";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(12, 31 /*0x1F*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(261, 13);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Please select the worksheet you would like to import:";
    this.listWorksheets.ItemSettings.DefaultImage = (Image) componentResourceManager.GetObject("listWorksheets.ItemSettings.DefaultImage");
    this.listWorksheets.ItemSettings.SelectionType = (SelectionType) 2;
    ((Control) this.listWorksheets).Location = new Point(12, 58);
    ((Control) this.listWorksheets).Name = "listWorksheets";
    ((ScrollBarLook) this.listWorksheets.ScrollBarLook).ViewStyle = (ScrollBarViewStyle) 3;
    ((Control) this.listWorksheets).Size = new Size(364, 157);
    ((Control) this.listWorksheets).TabIndex = 2;
    this.listWorksheets.View = (UltraListViewStyle) 2;
    ((Control) this.buttonOK).Location = new Point(301, 221);
    ((Control) this.buttonOK).Name = "buttonOK";
    ((Control) this.buttonOK).Size = new Size(75, 23);
    ((Control) this.buttonOK).TabIndex = 3;
    ((ControlBase) this.buttonOK).Text = "OK";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(388, 256 /*0x0100*/);
    this.Controls.Add((Control) this.buttonOK);
    this.Controls.Add((Control) this.listWorksheets);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (SelectWorksheet);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (SelectWorksheet);
    ((ISupportInitialize) this.listWorksheets).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private virtual UltraButton buttonOK
  {
    get => this._buttonOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonOK_Click);
      UltraButton buttonOk1 = this._buttonOK;
      if (buttonOk1 != null)
        ((Control) buttonOk1).Click -= eventHandler;
      this._buttonOK = value;
      UltraButton buttonOk2 = this._buttonOK;
      if (buttonOk2 == null)
        return;
      ((Control) buttonOk2).Click += eventHandler;
    }
  }

  public Worksheet SelectedSheet
  {
    get
    {
      return this._workbook.Worksheets[((UltraListViewItemBase) ((UltraListViewStateSpecificItemsCollectionBase) this.listWorksheets.SelectedItems)[0]).Value.ToString()];
    }
  }

  public SelectWorksheet(Workbook workbook)
  {
    this.InitializeComponent();
    this._workbook = workbook;
    try
    {
      foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
        this.listWorksheets.Items.Add(worksheet.Name, (object) worksheet.Name);
    }
    finally
    {
      IEnumerator<Worksheet> enumerator;
      enumerator?.Dispose();
    }
  }

  private void buttonOK_Click(object sender, EventArgs e)
  {
    if (((DisposableObjectCollectionBase) this.listWorksheets.SelectedItems).Count != 1)
      return;
    this.DialogResult = DialogResult.OK;
    this.Close();
  }
}
