// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.EntitySelectionMulti
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic;
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
namespace MGASystems.IMS.Reporting.ReportControls;

public class EntitySelectionMulti : BaseReportControl
{
  private IContainer components;
  private bool _Required;
  private string _EntityGuids;
  private frmEntitySearchMulti.SearchEntityTypes _EntityTypeToDisplay;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("ListBox1")]
  internal virtual ListBox ListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    Appearance appearance = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (EntitySelectionMulti));
    this.btnLookup = new MGAButton();
    this.ListBox1 = new ListBox();
    ((ISupportInitialize) this.btnLookup).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 76);
    ((Control) this.btnLookup).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance.BackColor = Color.FromArgb(248, 248, 248);
    appearance.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance.BackGradientStyle = (GradientStyle) 2;
    appearance.BorderColor = Color.DarkGray;
    appearance.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance.ImageHAlign = (HAlign) 2;
    appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnLookup).Appearance = (AppearanceBase) appearance;
    ((Control) this.btnLookup).Location = new Point(364, 5);
    ((Control) this.btnLookup).Name = "btnLookup";
    ((Control) this.btnLookup).Size = new Size(24, 24);
    ((Control) this.btnLookup).TabIndex = 2;
    this.btnLookup.UseOSThemes = (DefaultableBoolean) 2;
    this.ListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.ListBox1.FormattingEnabled = true;
    this.ListBox1.Location = new Point(88, 4);
    this.ListBox1.Name = "ListBox1";
    this.ListBox1.SelectionMode = SelectionMode.None;
    this.ListBox1.Size = new Size(270, 69);
    this.ListBox1.TabIndex = 3;
    this.Controls.Add((Control) this.btnLookup);
    this.Controls.Add((Control) this.ListBox1);
    this.Name = nameof (EntitySelectionMulti);
    this.Size = new Size(392, 76);
    this.Controls.SetChildIndex((Control) this.ListBox1, 0);
    this.Controls.SetChildIndex((Control) this.btnLookup, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.btnLookup).EndInit();
    this.ResumeLayout(false);
  }

  public EntitySelectionMulti()
  {
    this._Required = false;
    this._EntityGuids = "";
    this._EntityTypeToDisplay = frmEntitySearchMulti.SearchEntityTypes.All;
    this.InitializeComponent();
    this.InitialSize = this.Size;
  }

  public EntitySelectionMulti(string LabelText, bool Required)
  {
    this._Required = false;
    this._EntityGuids = "";
    this._EntityTypeToDisplay = frmEntitySearchMulti.SearchEntityTypes.All;
    this.InitializeComponent();
    this.Description = LabelText;
    this._Required = Required;
    this.InitialSize = this.Size;
  }

  public EntitySelectionMulti(
    string LabelText,
    bool Required,
    frmEntitySearchMulti.SearchEntityTypes EntityTypeToDisplay)
  {
    this._Required = false;
    this._EntityGuids = "";
    this._EntityTypeToDisplay = frmEntitySearchMulti.SearchEntityTypes.All;
    this.InitializeComponent();
    this.Description = LabelText;
    this._Required = Required;
    this._EntityTypeToDisplay = EntityTypeToDisplay;
    this.InitialSize = this.Size;
  }

  public EntitySelectionMulti(string LabelText, bool Required, bool OnlyCompanyInfo)
  {
    this._Required = false;
    this._EntityGuids = "";
    this._EntityTypeToDisplay = frmEntitySearchMulti.SearchEntityTypes.All;
    this.InitializeComponent();
    this.Description = LabelText;
    this._Required = Required;
    this._EntityTypeToDisplay = frmEntitySearchMulti.SearchEntityTypes.ShowCompany;
    this.InitialSize = this.Size;
  }

  public override object Value
  {
    get => (object) this._EntityGuids;
    set
    {
      if (!(value is string str))
        return;
      this._EntityGuids = str;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "", false) == 0)
        return;
      string[] strArray = Strings.Split(str, ",");
      int index = 0;
      while (index < strArray.Length)
      {
        string g = strArray[index];
        this.ListBox1.Items.Add((object) new frmEntitySearchMulti.clsSelectedEntity(Conversions.ToString(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetEntityName(@ENTITYGUID)", new object[2]
        {
          (object) "@ENTITYGUID",
          (object) g
        })), new Guid(g)));
        checked { ++index; }
      }
    }
  }

  public override void Compress()
  {
    this.ListBox1.Top = 0;
    this.lblDescription.Top = 0;
    this.lblDescription.Height = this.ListBox1.Height;
    this.Height = this.ListBox1.Height;
  }

  private void btnLookup_Click(object sender, EventArgs e)
  {
    frmEntitySearchMulti entitySearchMulti = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._EntityGuids, "", false) != 0 ? new frmEntitySearchMulti(this._EntityTypeToDisplay, this._EntityGuids) : new frmEntitySearchMulti(this._EntityTypeToDisplay);
    try
    {
      if (entitySearchMulti.ShowDialog() != DialogResult.OK)
        return;
      List<frmEntitySearchMulti.clsSelectedEntity> selectedEntities = entitySearchMulti.SelectedEntities;
      this.ListBox1.Items.Clear();
      this._EntityGuids = "";
      try
      {
        foreach (frmEntitySearchMulti.clsSelectedEntity clsSelectedEntity in selectedEntities)
        {
          this.ListBox1.Items.Add((object) clsSelectedEntity);
          this._EntityGuids = $"{this._EntityGuids}{clsSelectedEntity.Value.ToString()},";
        }
      }
      finally
      {
        List<frmEntitySearchMulti.clsSelectedEntity>.Enumerator enumerator;
        enumerator.Dispose();
      }
      if (this._EntityGuids.Length <= 1)
        return;
      this._EntityGuids = this._EntityGuids.Substring(0, this._EntityGuids.Length - 1);
    }
    finally
    {
      entitySearchMulti.Dispose();
    }
  }

  public override string InputErrorMessage
  {
    get
    {
      return !this._Required || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._EntityGuids, "", false) != 0 ? string.Empty : "Please select an entity.";
    }
  }
}
