// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.EntitySelection
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class EntitySelection : BaseReportControl
{
  private IContainer components;
  private bool _Required;
  private Guid _EntityGuid;
  private bool _OnlyCompanyInfo;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("txtEntityName")]
  internal virtual MGATextBox txtEntityName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnLookup
  {
    get => this._btnLookup;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnLookup_Click);
      MGAButton btnLookup1 = this._btnLookup;
      if (btnLookup1 != null)
        ((Control) btnLookup1).Click -= eventHandler;
      this._btnLookup = value;
      MGAButton btnLookup2 = this._btnLookup;
      if (btnLookup2 == null)
        return;
      ((Control) btnLookup2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (EntitySelection));
    this.txtEntityName = new MGATextBox();
    this.btnLookup = new MGAButton();
    ((ISupportInitialize) this.txtEntityName).BeginInit();
    ((ISupportInitialize) this.btnLookup).BeginInit();
    this.SuspendLayout();
    ((Control) this.txtEntityName).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEntityName).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtEntityName).BackColor = Color.White;
    ((Control) this.txtEntityName).Enabled = false;
    ((Control) this.txtEntityName).Location = new Point(88, 7);
    ((Control) this.txtEntityName).Name = "txtEntityName";
    ((Control) this.txtEntityName).Size = new Size(270, 19);
    ((Control) this.txtEntityName).TabIndex = 1;
    ((UltraControlBase) this.txtEntityName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEntityName).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnLookup).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnLookup).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnLookup).Location = new Point(364, 4);
    ((Control) this.btnLookup).Name = "btnLookup";
    ((Control) this.btnLookup).Size = new Size(24, 24);
    ((Control) this.btnLookup).TabIndex = 2;
    this.btnLookup.UseOSThemes = (DefaultableBoolean) 2;
    this.Controls.Add((Control) this.btnLookup);
    this.Controls.Add((Control) this.txtEntityName);
    this.Name = nameof (EntitySelection);
    this.Size = new Size(392, 32 /*0x20*/);
    this.Controls.SetChildIndex((Control) this.txtEntityName, 0);
    this.Controls.SetChildIndex((Control) this.btnLookup, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.txtEntityName).EndInit();
    ((ISupportInitialize) this.btnLookup).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public EntitySelection()
  {
    this._Required = false;
    this._OnlyCompanyInfo = false;
    this.InitializeComponent();
    this.InitialSize = this.Size;
  }

  public EntitySelection(string LabelText, bool Required)
  {
    this._Required = false;
    this._OnlyCompanyInfo = false;
    this.InitializeComponent();
    this.Description = LabelText;
    this._Required = Required;
    this.InitialSize = this.Size;
  }

  public EntitySelection(string LabelText, bool Required, bool OnlyCompanyInfo)
  {
    this._Required = false;
    this._OnlyCompanyInfo = false;
    this.InitializeComponent();
    this.Description = LabelText;
    this._Required = Required;
    this._OnlyCompanyInfo = OnlyCompanyInfo;
    this.InitialSize = this.Size;
  }

  public override object Value
  {
    get => (object) this._EntityGuid;
    set
    {
      this._EntityGuid = (Guid) value;
      if (this._EntityGuid.Equals(Guid.Empty))
        return;
      ((TextEditorControlBase) this.txtEntityName).Text = Conversions.ToString(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetEntityName(@ENTITYGUID)", new object[2]
      {
        (object) "@ENTITYGUID",
        (object) this._EntityGuid
      }));
    }
  }

  public override void Compress()
  {
    ((Control) this.txtEntityName).Top = 0;
    ((Control) this.btnLookup).Top = 0;
    this.lblDescription.Top = 0;
    this.lblDescription.Height = ((Control) this.txtEntityName).Height;
    ((Control) this.btnLookup).Height = ((Control) this.txtEntityName).Height;
    this.Height = ((Control) this.txtEntityName).Height;
  }

  private void btnLookup_Click(object sender, EventArgs e)
  {
    frmEntitySearch frmEntitySearch = !this._EntityGuid.Equals(Guid.Empty) ? (this._OnlyCompanyInfo ? new frmEntitySearch(true, true, true, this._EntityGuid.ToString()) : new frmEntitySearch(frmEntitySearch.SearchEntityTypes.All, this._EntityGuid.ToString())) : (this._OnlyCompanyInfo ? new frmEntitySearch(true, true, true) : new frmEntitySearch(frmEntitySearch.SearchEntityTypes.All));
    try
    {
      if (frmEntitySearch.ShowDialog() == DialogResult.OK)
      {
        this._EntityGuid = frmEntitySearch.EntityGuid;
        ((TextEditorControlBase) this.txtEntityName).Text = frmEntitySearch.EntityName;
      }
      else
      {
        this._EntityGuid = Guid.Empty;
        ((TextEditorControlBase) this.txtEntityName).Text = string.Empty;
      }
    }
    finally
    {
      frmEntitySearch.Dispose();
    }
  }

  public override string InputErrorMessage
  {
    get
    {
      return !this._Required || !this._EntityGuid.Equals(Guid.Empty) ? string.Empty : "Please select an entity.";
    }
  }
}
