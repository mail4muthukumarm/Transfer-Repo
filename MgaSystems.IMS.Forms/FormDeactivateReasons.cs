// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormDeactivateReasons
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class FormDeactivateReasons : Form
{
  private IContainer components;

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
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("lstQuoteStatusReasons", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("QuoteStatus");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Reason");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("DeAct");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    this.btnGo = new MGAButton();
    this.dgReasons = new UltraGrid();
    this.ds = new dsDeactivateReason();
    ((ISupportInitialize) this.btnGo).BeginInit();
    ((ISupportInitialize) this.dgReasons).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.btnGo).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnGo).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnGo).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnGo).ImageSize = new Size(24, 24);
    ((Control) this.btnGo).Location = new Point(739, 580);
    ((Control) this.btnGo).Name = "btnGo";
    ((Control) this.btnGo).Size = new Size(54, 40);
    ((Control) this.btnGo).TabIndex = 10;
    this.btnGo.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.dgReasons).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.dgReasons).Cursor = Cursors.Hand;
    ((UltraGridBase) this.dgReasons).DataMember = "lstQuoteStatusReasons";
    ((UltraGridBase) this.dgReasons).DataSource = (object) this.ds;
    appearance2.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.dgReasons).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.WhiteSmoke;
    appearance3.BorderColor = Color.WhiteSmoke;
    appearance3.FontData.UnderlineAsString = "True";
    appearance3.ForeColor = Color.Blue;
    ((UltraGridBase) this.dgReasons).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.dgReasons).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.dgReasons).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgReasons).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dgReasons).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand.AddButtonCaption = "Add new status reason...";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 196;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 454;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "De-Activate";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.dgReasons).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgReasons).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.dgReasons).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.WhiteSmoke;
    appearance10.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgReasons).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgReasons).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgReasons).Location = new Point(12, 12);
    ((Control) this.dgReasons).Name = "dgReasons";
    ((Control) this.dgReasons).Size = new Size(781, 561);
    ((Control) this.dgReasons).TabIndex = 3;
    ((UltraControlBase) this.dgReasons).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgReasons).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsDeactivateReason";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(805, 632);
    this.Controls.Add((Control) this.btnGo);
    this.Controls.Add((Control) this.dgReasons);
    this.Name = nameof (FormDeactivateReasons);
    this.Text = nameof (FormDeactivateReasons);
    ((ISupportInitialize) this.btnGo).EndInit();
    ((ISupportInitialize) this.dgReasons).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("dgReasons")]
  private virtual UltraGrid dgReasons { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsDeactivateReason ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnGo
  {
    get => this._btnGo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGo_Click);
      MGAButton btnGo1 = this._btnGo;
      if (btnGo1 != null)
        ((Control) btnGo1).Click -= eventHandler;
      this._btnGo = value;
      MGAButton btnGo2 = this._btnGo;
      if (btnGo2 == null)
        return;
      ((Control) btnGo2).Click += eventHandler;
    }
  }

  public FormDeactivateReasons()
  {
    this.Load += new EventHandler(this.FormDeactivateReasons_Load);
    this.InitializeComponent();
  }

  private void FormDeactivateReasons_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnGo).Appearance.Image = (object) ImageCache.Instance.Save;
    DefaultDatabase.LoadDataTable((DataTable) this.ds.lstQuoteStatusReasons, "GetQuoteStatusReasonsWithInactive");
  }

  private void btnGo_Click(object sender, EventArgs e)
  {
    try
    {
      this.dgReasons.PerformAction((UltraGridAction) 44);
      ((UltraGridBase) this.dgReasons).UpdateData();
      this.Cursor = MgaCursors.WaitCursor;
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, eth) =>
      {
        try
        {
          foreach (dsDeactivateReason.lstQuoteStatusReasonsRow quoteStatusReason in (TypedTableBase<dsDeactivateReason.lstQuoteStatusReasonsRow>) this.ds.lstQuoteStatusReasons)
          {
            if (quoteStatusReason.RowState == DataRowState.Modified)
              DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.lstQuoteStatusReasons SET Inactive = @inactive WHERE ID = @id", new object[4]
              {
                (object) "@inactive",
                (object) quoteStatusReason.Inactive,
                (object) "@id",
                (object) quoteStatusReason.ID
              });
          }
        }
        finally
        {
          IEnumerator<dsDeactivateReason.lstQuoteStatusReasonsRow> enumerator;
          enumerator?.Dispose();
        }
        eth.Transaction.Commit();
      }));
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }
}
