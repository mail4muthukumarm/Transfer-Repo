// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.frmTagExtractor
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.Tools;
using MGASystems.Tools.BaseClasses;
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
namespace MGASystems.IMS.DocumentAutomation;

[DesignerGenerated]
public class frmTagExtractor : MGABaseForm
{
  private IContainer components;
  private List<DocTag> _tags;
  private Dictionary<string, string> _tagData;
  private Guid _quoteGuid;
  private ISupportTemplateDocs _supportingObject;
  private Enums.AutomationDocGroups _automationGroup;
  private int _templateID;

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
    this.grdTags = new MGAGrid();
    this.tbControlNo = new MGATextBox();
    this.txtControlNo = new Label();
    this.btnResolveTags = new MGAButton();
    ((ISupportInitialize) this.grdTags).BeginInit();
    ((ISupportInitialize) this.tbControlNo).BeginInit();
    ((ISupportInitialize) this.btnResolveTags).BeginInit();
    this.SuspendLayout();
    ((Control) this.grdTags).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.grdTags).Location = new Point(0, -2);
    ((Control) this.grdTags).Name = "grdTags";
    ((Control) this.grdTags).Size = new Size(439, 307);
    ((Control) this.grdTags).TabIndex = 0;
    ((Control) this.grdTags).Text = "Extracted Tags";
    ((UltraControlBase) this.grdTags).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.grdTags).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tbControlNo).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.tbControlNo).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.tbControlNo).BackColor = Color.White;
    ((Control) this.tbControlNo).Location = new Point(335, 311);
    ((TextEditorControlBase) this.tbControlNo).MaxLength = 10;
    ((Control) this.tbControlNo).Name = "tbControlNo";
    ((Control) this.tbControlNo).Size = new Size(98, 20);
    ((Control) this.tbControlNo).TabIndex = 1;
    ((UltraControlBase) this.tbControlNo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.tbControlNo).UseOsThemes = (DefaultableBoolean) 2;
    this.txtControlNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.txtControlNo.AutoSize = true;
    this.txtControlNo.BackColor = Color.Transparent;
    this.txtControlNo.Location = new Point(264, 314);
    this.txtControlNo.Name = "txtControlNo";
    this.txtControlNo.Size = new Size(65, 13);
    this.txtControlNo.TabIndex = 2;
    this.txtControlNo.Text = "Control No: ";
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnResolveTags).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnResolveTags).Dock = DockStyle.Bottom;
    ((Control) this.btnResolveTags).Location = new Point(0, 337);
    ((Control) this.btnResolveTags).Name = "btnResolveTags";
    ((Control) this.btnResolveTags).Size = new Size(439, 30);
    ((Control) this.btnResolveTags).TabIndex = 3;
    ((ControlBase) this.btnResolveTags).Text = "Resolve Tags";
    this.btnResolveTags.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(439, 367);
    this.Controls.Add((Control) this.btnResolveTags);
    this.Controls.Add((Control) this.txtControlNo);
    this.Controls.Add((Control) this.tbControlNo);
    this.Controls.Add((Control) this.grdTags);
    this.Name = nameof (frmTagExtractor);
    this.Text = "Template Document Tag Extractor";
    ((ISupportInitialize) this.grdTags).EndInit();
    ((ISupportInitialize) this.tbControlNo).EndInit();
    ((ISupportInitialize) this.btnResolveTags).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual MGAGrid grdTags
  {
    get => this._grdTags;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.grdTags_InitializeRow);
      MGAGrid grdTags1 = this._grdTags;
      if (grdTags1 != null)
        grdTags1.InitializeRow -= initializeRowEventHandler;
      this._grdTags = value;
      MGAGrid grdTags2 = this._grdTags;
      if (grdTags2 == null)
        return;
      grdTags2.InitializeRow += initializeRowEventHandler;
    }
  }

  internal virtual MGATextBox tbControlNo
  {
    get => this._tbControlNo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.tbControlNo_KeyDown);
      MGATextBox tbControlNo1 = this._tbControlNo;
      if (tbControlNo1 != null)
        ((Control) tbControlNo1).KeyDown -= keyEventHandler;
      this._tbControlNo = value;
      MGATextBox tbControlNo2 = this._tbControlNo;
      if (tbControlNo2 == null)
        return;
      ((Control) tbControlNo2).KeyDown += keyEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtControlNo")]
  internal virtual Label txtControlNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnResolveTags
  {
    get => this._btnResolveTags;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnResolveTags_Click);
      MGAButton btnResolveTags1 = this._btnResolveTags;
      if (btnResolveTags1 != null)
        ((Control) btnResolveTags1).Click -= eventHandler;
      this._btnResolveTags = value;
      MGAButton btnResolveTags2 = this._btnResolveTags;
      if (btnResolveTags2 == null)
        return;
      ((Control) btnResolveTags2).Click += eventHandler;
    }
  }

  public frmTagExtractor()
    : this((List<DocTag>) null)
  {
  }

  public frmTagExtractor(List<DocTag> tags)
    : this(tags, (ISupportTemplateDocs) null, -1, (Enums.AutomationDocGroups) 0)
  {
  }

  public frmTagExtractor(
    List<DocTag> tags,
    ISupportTemplateDocs supportingObject,
    int templateID,
    Enums.AutomationDocGroups automationGroup)
  {
    this.Load += new EventHandler(this.frmTagExtractor_Load);
    this._tagData = new Dictionary<string, string>();
    this._quoteGuid = Guid.Empty;
    this.InitializeComponent();
    this._automationGroup = automationGroup;
    this._supportingObject = supportingObject;
    this._tags = tags;
    this._templateID = templateID;
    try
    {
      foreach (DocTag tag in this._tags)
      {
        if (!this._tagData.ContainsKey(tag.TagName))
          this._tagData.Add(tag.TagName, tag.TagValue);
      }
    }
    finally
    {
      List<DocTag>.Enumerator enumerator;
      enumerator.Dispose();
    }
    if (this._supportingObject == null)
      return;
    this.ParseTags();
  }

  public frmTagExtractor(List<DocTag> tags, Guid quoteGuid)
    : this(tags)
  {
    this._quoteGuid = quoteGuid;
    this.SetControlNumberText(this._quoteGuid);
    this.ParseTags();
  }

  private void frmTagExtractor_Load(object sender, EventArgs e)
  {
    if (this._tags == null)
      return;
    ((UltraGridBase) this.grdTags).DataSource = (object) this._tagData;
    this.grdTags.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) this.grdTags.DisplayLayout.Bands[0].Columns[0].Header).Caption = "Tag Name";
    ((HeaderBase) this.grdTags.DisplayLayout.Bands[0].Columns[1].Header).Caption = "Tag Value";
  }

  private void ParseTags()
  {
    int result;
    if (!int.TryParse(((TextEditorControlBase) this.tbControlNo).Text, out result) && this._supportingObject == null)
    {
      int num1 = (int) MessageBox.Show("Invalid control number.", "Invalid Control No.");
    }
    else
    {
      try
      {
        this._quoteGuid = Utility.IsNull<Guid>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select top 1 quoteguid from tblQuotes where controlno = @controlno order by quoteid desc", new object[2]
        {
          (object) "@controlno",
          (object) result
        })), Guid.Empty);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num2 = (int) MessageBox.Show("Invalid control number.", "Invalid Control No.");
        ProjectData.ClearProjectError();
        return;
      }
      TagParserBase tagParserBase;
      if (this._supportingObject != null)
      {
        object[] objArray = this._supportingObject.TagParserConstructorArgs((int) this._automationGroup);
        tagParserBase = ((TagParserFactory) ObjectFactory.Instance.CreateObject(typeof (TagParserFactory))).GetTagParser((int) this._automationGroup, objArray);
        if (this._supportingObject is ISupportPolicyTemplateDocs)
          ((TextEditorControlBase) this.tbControlNo).Text = Conversions.ToString(((ISupportPolicyTemplateDocs) this._supportingObject).ControlNum);
      }
      else
      {
        if (this._quoteGuid == Guid.Empty)
        {
          int num3 = (int) MessageBox.Show("Invalid control number.", "Invalid Control No.");
          return;
        }
        this.SetControlNumberText(this._quoteGuid);
        tagParserBase = (TagParserBase) new PolicyTagParser(this._quoteGuid);
      }
      this._tags = tagParserBase.ProcessTags(this._tags);
      this._tags = tagParserBase.ProcessPolicyFormTags(this._tags, (object) null, -1, this._templateID, -1);
      int num4 = this._tags.Count - 1;
      for (int index = 0; index <= num4; ++index)
      {
        string tagName = this._tags[index].TagName;
        DocTag tag = this._tags[index];
        this._tagData[tagName] = !tag.IsImageTag ? (!tag.IsTableTag ? (!tag.IsCheckBoxTag ? (!tag.IsRepeatableTag ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tag.TagValue, string.Empty, false) != 0 ? tag.TagValue : "{No Data}") : "{Repeatable tags not supported.}") : "{Checkbox tag not supported.}") : "{Table tag not supported.}") : "{Image tag not supported}";
      }
      ((UltraGridBase) this.grdTags).DataBind();
    }
  }

  private void SetControlNumberText(Guid g)
  {
    ((TextEditorControlBase) this.tbControlNo).Text = new Quote(g).ControlNo.ToString();
  }

  private void grdTags_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    UltraGridColumn column = this.grdTags.DisplayLayout.Bands[0].Columns[1];
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Row.GetCellText(column), "{No Data}", false) == 0)
    {
      e.Row.Cells[1].Appearance.ForeColor = Color.Red;
      e.Row.Cells[1].Appearance.FontData.Bold = (DefaultableBoolean) 1;
    }
    else
    {
      if (!LikeOperator.LikeString(e.Row.GetCellText(column), "{*}", CompareMethod.Binary))
        return;
      e.Row.Cells[1].Appearance.ForeColor = Color.Green;
      e.Row.Cells[1].Appearance.FontData.Italic = (DefaultableBoolean) 1;
    }
  }

  private void btnResolveTags_Click(object sender, EventArgs e) => this.ParseTags();

  private void tbControlNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.ParseTags();
  }
}
