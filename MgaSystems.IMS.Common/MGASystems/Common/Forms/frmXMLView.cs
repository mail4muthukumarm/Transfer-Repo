// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Forms.frmXMLView
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinTree;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.Common.Forms;

[DesignerGenerated]
public class frmXMLView : Form
{
  private IContainer components;
  private XmlDocument xmldoc;
  private DataSet ds;
  private int MaxNodeLevel;
  private int NodeLoadLevelLimit;
  private frmXMLView.frmSearchPrivate frmsrch;
  private List<UltraTreeNode> AllNodes;
  private List<string> CurrentNodeMatches;
  private List<XElement> XElementMatches;
  private List<Tuple<string, string>> SearchList;
  private bool SearchListPopulated;
  private int LastNodeIndex;
  private string LastSearchText;
  private Override NodeOverrideDefault;
  private Override NodeOverrideLastLeaf;
  private Override NodeOverrideYellowBack;

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
    Appearance appearance1 = new Appearance("default", 860791594);
    Appearance appearance2 = new Appearance("lastleaf", 860826454);
    Appearance appearance3 = new Appearance("yellowback", 862099579);
    Override @override = new Override();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    this.ultraTreeX = new UltraTree();
    this.trackBarCollapse = new TrackBar();
    this.Panel1 = new Panel();
    this.lblCollapse = new Label();
    this.StatusStrip1 = new StatusStrip();
    this.ToolStripStatusLabel2 = new ToolStripStatusLabel();
    this.PopulateSearchListWorker = new BackgroundWorker();
    ((ISupportInitialize) this.ultraTreeX).BeginInit();
    this.trackBarCollapse.BeginInit();
    this.Panel1.SuspendLayout();
    this.StatusStrip1.SuspendLayout();
    this.SuspendLayout();
    appearance2.FontData.BoldAsString = "True";
    appearance2.FontData.ItalicAsString = "False";
    appearance2.FontData.Name = "Arial";
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.FontData.StrikeoutAsString = "False";
    appearance2.FontData.UnderlineAsString = "False";
    appearance3.BackColor = Color.Yellow;
    appearance3.FontData.BoldAsString = "True";
    appearance3.FontData.ItalicAsString = "False";
    appearance3.FontData.Name = "Arial";
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.FontData.StrikeoutAsString = "False";
    appearance3.FontData.UnderlineAsString = "False";
    this.ultraTreeX.Appearances.Add((object) appearance1);
    this.ultraTreeX.Appearances.Add((object) appearance2);
    this.ultraTreeX.Appearances.Add((object) appearance3);
    ((Control) this.ultraTreeX).Dock = DockStyle.Fill;
    ((Control) this.ultraTreeX).Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ultraTreeX.HideExpansionIndicators = (HideExpansionIndicators) 1;
    this.ultraTreeX.HideSelection = false;
    ((Control) this.ultraTreeX).Location = new Point(0, 45);
    ((Control) this.ultraTreeX).Name = "ultraTreeX";
    this.ultraTreeX.NodeConnectorColor = Color.Black;
    this.ultraTreeX.NodeConnectorStyle = (NodeConnectorStyle) 4;
    appearance4.BackColor = Color.Blue;
    appearance4.FontData.BoldAsString = "True";
    appearance4.FontData.ItalicAsString = "False";
    appearance4.FontData.Name = "Arial";
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.FontData.StrikeoutAsString = "False";
    appearance4.FontData.UnderlineAsString = "False";
    appearance4.ForeColor = Color.White;
    @override.ActiveNodeAppearance = (AppearanceBase) appearance4;
    @override.ItemHeight = 15;
    appearance5.FontData.BoldAsString = "False";
    appearance5.FontData.ItalicAsString = "False";
    appearance5.FontData.Name = "Arial";
    appearance5.FontData.SizeInPoints = 10f;
    appearance5.FontData.StrikeoutAsString = "False";
    appearance5.FontData.UnderlineAsString = "False";
    @override.NodeAppearance = (AppearanceBase) appearance5;
    @override.ShowExpansionIndicator = (ShowExpansionIndicator) 4;
    this.ultraTreeX.Override = @override;
    this.ultraTreeX.ShowRootLines = false;
    ((Control) this.ultraTreeX).Size = new Size(591, 537);
    ((Control) this.ultraTreeX).TabIndex = 0;
    this.ultraTreeX.ViewStyle = (ViewStyle) 1;
    this.trackBarCollapse.Dock = DockStyle.Top;
    this.trackBarCollapse.LargeChange = 1;
    this.trackBarCollapse.Location = new Point(0, 0);
    this.trackBarCollapse.Name = "trackBarCollapse";
    this.trackBarCollapse.Size = new Size(591, 45);
    this.trackBarCollapse.TabIndex = 1;
    this.trackBarCollapse.TickStyle = TickStyle.TopLeft;
    this.Panel1.Controls.Add((Control) this.lblCollapse);
    this.Panel1.Controls.Add((Control) this.trackBarCollapse);
    this.Panel1.Dock = DockStyle.Top;
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(591, 45);
    this.Panel1.TabIndex = 2;
    this.lblCollapse.Dock = DockStyle.Bottom;
    this.lblCollapse.Location = new Point(0, 32 /*0x20*/);
    this.lblCollapse.Name = "lblCollapse";
    this.lblCollapse.Size = new Size(591, 13);
    this.lblCollapse.TabIndex = 3;
    this.lblCollapse.Text = "Collapse Level";
    this.lblCollapse.TextAlign = ContentAlignment.TopCenter;
    this.StatusStrip1.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.ToolStripStatusLabel2
    });
    this.StatusStrip1.Location = new Point(0, 582);
    this.StatusStrip1.Name = "StatusStrip1";
    this.StatusStrip1.Size = new Size(591, 22);
    this.StatusStrip1.TabIndex = 3;
    this.StatusStrip1.Text = "StatusStrip1";
    this.ToolStripStatusLabel2.AutoToolTip = true;
    this.ToolStripStatusLabel2.DisplayStyle = ToolStripItemDisplayStyle.Text;
    this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
    this.ToolStripStatusLabel2.Overflow = ToolStripItemOverflow.Never;
    this.ToolStripStatusLabel2.Size = new Size(576, 17);
    this.ToolStripStatusLabel2.Spring = true;
    this.ToolStripStatusLabel2.Text = "                     ";
    this.ToolStripStatusLabel2.TextAlign = ContentAlignment.MiddleLeft;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CausesValidation = false;
    this.ClientSize = new Size(591, 604);
    this.Controls.Add((Control) this.ultraTreeX);
    this.Controls.Add((Control) this.StatusStrip1);
    this.Controls.Add((Control) this.Panel1);
    this.KeyPreview = true;
    this.Name = nameof (frmXMLView);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.Text = "IMS XML Viewer";
    ((ISupportInitialize) this.ultraTreeX).EndInit();
    this.trackBarCollapse.EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.StatusStrip1.ResumeLayout(false);
    this.StatusStrip1.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual UltraTree ultraTreeX
  {
    get => this._ultraTreeX;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AfterNodeSelectEventHandler selectEventHandler = new AfterNodeSelectEventHandler(this.ultraTreeX_AfterSelect);
      BeforeNodeChangedEventHandler changedEventHandler = new BeforeNodeChangedEventHandler(this.ultraTreeX_BeforeExpand);
      UltraTree ultraTreeX1 = this._ultraTreeX;
      if (ultraTreeX1 != null)
      {
        ultraTreeX1.AfterSelect -= selectEventHandler;
        ultraTreeX1.BeforeExpand -= changedEventHandler;
      }
      this._ultraTreeX = value;
      UltraTree ultraTreeX2 = this._ultraTreeX;
      if (ultraTreeX2 == null)
        return;
      ultraTreeX2.AfterSelect += selectEventHandler;
      ultraTreeX2.BeforeExpand += changedEventHandler;
    }
  }

  internal virtual TrackBar trackBarCollapse
  {
    get => this._trackBarCollapse;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.trackBarCollapse_ValueChanged);
      TrackBar trackBarCollapse1 = this._trackBarCollapse;
      if (trackBarCollapse1 != null)
        trackBarCollapse1.ValueChanged -= eventHandler;
      this._trackBarCollapse = value;
      TrackBar trackBarCollapse2 = this._trackBarCollapse;
      if (trackBarCollapse2 == null)
        return;
      trackBarCollapse2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("StatusStrip1")]
  internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ToolStripStatusLabel2")]
  internal virtual ToolStripStatusLabel ToolStripStatusLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCollapse")]
  internal virtual Label lblCollapse { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual BackgroundWorker PopulateSearchListWorker
  {
    get => this._PopulateSearchListWorker;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.PopulateSearchListWorker_DoWork);
      RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.PopulateSearchListWorker_RunWorkerCompleted);
      BackgroundWorker searchListWorker1 = this._PopulateSearchListWorker;
      if (searchListWorker1 != null)
      {
        searchListWorker1.DoWork -= workEventHandler;
        searchListWorker1.RunWorkerCompleted -= completedEventHandler;
      }
      this._PopulateSearchListWorker = value;
      BackgroundWorker searchListWorker2 = this._PopulateSearchListWorker;
      if (searchListWorker2 == null)
        return;
      searchListWorker2.DoWork += workEventHandler;
      searchListWorker2.RunWorkerCompleted += completedEventHandler;
    }
  }

  public frmXMLView(string XMLStr)
  {
    this.Load += new EventHandler(this.frmXMLView_Load);
    this.KeyDown += new KeyEventHandler(this.frmXMLView_KeyDown);
    this.Shown += new EventHandler(this.frmXMLView_Shown);
    this.xmldoc = new XmlDocument();
    this.ds = new DataSet();
    this.MaxNodeLevel = 0;
    this.NodeLoadLevelLimit = int.MaxValue;
    this.AllNodes = new List<UltraTreeNode>();
    this.CurrentNodeMatches = new List<string>();
    this.SearchList = new List<Tuple<string, string>>();
    this.SearchListPopulated = false;
    this.LastNodeIndex = 0;
    this.NodeOverrideDefault = new Override();
    this.NodeOverrideLastLeaf = new Override();
    this.NodeOverrideYellowBack = new Override();
    this.InitializeComponent();
    this.xmldoc.LoadXml(XMLStr);
    this.AfterConstructor(this.xmldoc, int.MaxValue);
  }

  public frmXMLView(string FormCaption, string XMLStr)
  {
    this.Load += new EventHandler(this.frmXMLView_Load);
    this.KeyDown += new KeyEventHandler(this.frmXMLView_KeyDown);
    this.Shown += new EventHandler(this.frmXMLView_Shown);
    this.xmldoc = new XmlDocument();
    this.ds = new DataSet();
    this.MaxNodeLevel = 0;
    this.NodeLoadLevelLimit = int.MaxValue;
    this.AllNodes = new List<UltraTreeNode>();
    this.CurrentNodeMatches = new List<string>();
    this.SearchList = new List<Tuple<string, string>>();
    this.SearchListPopulated = false;
    this.LastNodeIndex = 0;
    this.NodeOverrideDefault = new Override();
    this.NodeOverrideLastLeaf = new Override();
    this.NodeOverrideYellowBack = new Override();
    this.InitializeComponent();
    this.Text = FormCaption;
    this.xmldoc.LoadXml(XMLStr);
    this.AfterConstructor(this.xmldoc, int.MaxValue);
  }

  public frmXMLView(XmlDocument XMLdocument)
  {
    this.Load += new EventHandler(this.frmXMLView_Load);
    this.KeyDown += new KeyEventHandler(this.frmXMLView_KeyDown);
    this.Shown += new EventHandler(this.frmXMLView_Shown);
    this.xmldoc = new XmlDocument();
    this.ds = new DataSet();
    this.MaxNodeLevel = 0;
    this.NodeLoadLevelLimit = int.MaxValue;
    this.AllNodes = new List<UltraTreeNode>();
    this.CurrentNodeMatches = new List<string>();
    this.SearchList = new List<Tuple<string, string>>();
    this.SearchListPopulated = false;
    this.LastNodeIndex = 0;
    this.NodeOverrideDefault = new Override();
    this.NodeOverrideLastLeaf = new Override();
    this.NodeOverrideYellowBack = new Override();
    this.InitializeComponent();
    this.AfterConstructor(XMLdocument, int.MaxValue);
  }

  public frmXMLView(string FormCaption, XmlDocument XMLdocument)
  {
    this.Load += new EventHandler(this.frmXMLView_Load);
    this.KeyDown += new KeyEventHandler(this.frmXMLView_KeyDown);
    this.Shown += new EventHandler(this.frmXMLView_Shown);
    this.xmldoc = new XmlDocument();
    this.ds = new DataSet();
    this.MaxNodeLevel = 0;
    this.NodeLoadLevelLimit = int.MaxValue;
    this.AllNodes = new List<UltraTreeNode>();
    this.CurrentNodeMatches = new List<string>();
    this.SearchList = new List<Tuple<string, string>>();
    this.SearchListPopulated = false;
    this.LastNodeIndex = 0;
    this.NodeOverrideDefault = new Override();
    this.NodeOverrideLastLeaf = new Override();
    this.NodeOverrideYellowBack = new Override();
    this.InitializeComponent();
    this.Text = FormCaption;
    this.AfterConstructor(XMLdocument, int.MaxValue);
  }

  public frmXMLView(string XMLStr, int NodeLevelLimit)
  {
    this.Load += new EventHandler(this.frmXMLView_Load);
    this.KeyDown += new KeyEventHandler(this.frmXMLView_KeyDown);
    this.Shown += new EventHandler(this.frmXMLView_Shown);
    this.xmldoc = new XmlDocument();
    this.ds = new DataSet();
    this.MaxNodeLevel = 0;
    this.NodeLoadLevelLimit = int.MaxValue;
    this.AllNodes = new List<UltraTreeNode>();
    this.CurrentNodeMatches = new List<string>();
    this.SearchList = new List<Tuple<string, string>>();
    this.SearchListPopulated = false;
    this.LastNodeIndex = 0;
    this.NodeOverrideDefault = new Override();
    this.NodeOverrideLastLeaf = new Override();
    this.NodeOverrideYellowBack = new Override();
    this.InitializeComponent();
    this.xmldoc.LoadXml(XMLStr);
    this.AfterConstructor(this.xmldoc, NodeLevelLimit);
  }

  public frmXMLView(string FormCaption, string XMLStr, int NodeLevelLimit)
  {
    this.Load += new EventHandler(this.frmXMLView_Load);
    this.KeyDown += new KeyEventHandler(this.frmXMLView_KeyDown);
    this.Shown += new EventHandler(this.frmXMLView_Shown);
    this.xmldoc = new XmlDocument();
    this.ds = new DataSet();
    this.MaxNodeLevel = 0;
    this.NodeLoadLevelLimit = int.MaxValue;
    this.AllNodes = new List<UltraTreeNode>();
    this.CurrentNodeMatches = new List<string>();
    this.SearchList = new List<Tuple<string, string>>();
    this.SearchListPopulated = false;
    this.LastNodeIndex = 0;
    this.NodeOverrideDefault = new Override();
    this.NodeOverrideLastLeaf = new Override();
    this.NodeOverrideYellowBack = new Override();
    this.InitializeComponent();
    this.Text = FormCaption;
    this.xmldoc.LoadXml(XMLStr);
    this.AfterConstructor(this.xmldoc, NodeLevelLimit);
  }

  public frmXMLView(XmlDocument XMLdocument, int NodeLevelLimit)
  {
    this.Load += new EventHandler(this.frmXMLView_Load);
    this.KeyDown += new KeyEventHandler(this.frmXMLView_KeyDown);
    this.Shown += new EventHandler(this.frmXMLView_Shown);
    this.xmldoc = new XmlDocument();
    this.ds = new DataSet();
    this.MaxNodeLevel = 0;
    this.NodeLoadLevelLimit = int.MaxValue;
    this.AllNodes = new List<UltraTreeNode>();
    this.CurrentNodeMatches = new List<string>();
    this.SearchList = new List<Tuple<string, string>>();
    this.SearchListPopulated = false;
    this.LastNodeIndex = 0;
    this.NodeOverrideDefault = new Override();
    this.NodeOverrideLastLeaf = new Override();
    this.NodeOverrideYellowBack = new Override();
    this.InitializeComponent();
    this.AfterConstructor(XMLdocument, NodeLevelLimit);
  }

  public frmXMLView(string FormCaption, XmlDocument XMLdocument, int NodeLevelLimit)
  {
    this.Load += new EventHandler(this.frmXMLView_Load);
    this.KeyDown += new KeyEventHandler(this.frmXMLView_KeyDown);
    this.Shown += new EventHandler(this.frmXMLView_Shown);
    this.xmldoc = new XmlDocument();
    this.ds = new DataSet();
    this.MaxNodeLevel = 0;
    this.NodeLoadLevelLimit = int.MaxValue;
    this.AllNodes = new List<UltraTreeNode>();
    this.CurrentNodeMatches = new List<string>();
    this.SearchList = new List<Tuple<string, string>>();
    this.SearchListPopulated = false;
    this.LastNodeIndex = 0;
    this.NodeOverrideDefault = new Override();
    this.NodeOverrideLastLeaf = new Override();
    this.NodeOverrideYellowBack = new Override();
    this.InitializeComponent();
    this.Text = FormCaption;
    this.AfterConstructor(XMLdocument, NodeLevelLimit);
  }

  private void AfterConstructor(XmlDocument XMLdocument, int NodeLevelLimit)
  {
    this.NodeLoadLevelLimit = NodeLevelLimit;
    this.xmldoc = XMLdocument;
    this.PopulateSearchListWorker.RunWorkerAsync();
  }

  private void PopulateSearchListWorker_DoWork(object sender, DoWorkEventArgs e)
  {
    this.PopulateSearchList();
  }

  private void PopulateSearchListWorker_RunWorkerCompleted(
    object sender,
    RunWorkerCompletedEventArgs e)
  {
    this.SearchListPopulated = true;
  }

  private void PopulateSearchList()
  {
    XmlNodeReader reader = new XmlNodeReader((XmlNode) this.xmldoc);
    int content = (int) reader.MoveToContent();
    IEnumerable<XElement> xelements = XDocument.Load((XmlReader) reader).Root.Descendants();
    try
    {
      foreach (XElement element in xelements)
      {
        if (element.HasElements)
          this.SearchList.Add(new Tuple<string, string>(frmXMLView.GetPath(element), string.Empty));
        else
          this.SearchList.Add(new Tuple<string, string>(frmXMLView.GetPath(element), element.Value));
      }
    }
    finally
    {
      IEnumerator<XElement> enumerator;
      enumerator?.Dispose();
    }
  }

  private void frmXMLView_Load(object sender, EventArgs e)
  {
    try
    {
      this.ultraTreeX.Nodes.Clear();
      this.ultraTreeX.Nodes.Add(new UltraTreeNode(new frmXMLView.NodeTagInfo((XmlNode) this.xmldoc.DocumentElement).XPath, this.xmldoc.DocumentElement.Name));
      UltraTreeNode ultraTreeNode = new UltraTreeNode();
      this.AddNode((XmlNode) this.xmldoc.DocumentElement, this.ultraTreeX.Nodes[0]);
      this.ultraTreeX.ExpandAll();
    }
    catch (XmlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show(ex.Message);
      this.Close();
      ProjectData.ClearProjectError();
    }
    if (this.NodeLoadLevelLimit < int.MaxValue)
    {
      this.trackBarCollapse.Maximum = this.NodeLoadLevelLimit;
      this.trackBarCollapse.Value = this.NodeLoadLevelLimit;
    }
    else
    {
      this.trackBarCollapse.Maximum = this.MaxNodeLevel;
      this.trackBarCollapse.Value = this.MaxNodeLevel;
    }
  }

  private void ultraTreeX_AfterSelect(object sender, SelectEventArgs e)
  {
    if (((DisposableObjectCollectionBase) this.ultraTreeX.SelectedNodes).Count <= 0)
      return;
    this.ToolStripStatusLabel2.Text = this.ultraTreeX.SelectedNodes[0].FullPath;
  }

  private void frmXMLView_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.F || !e.Control)
      return;
    this.ShowSearch();
  }

  private void frmXMLView_Shown(object sender, EventArgs e)
  {
    this.NodeOverrideLastLeaf.NodeAppearance = (AppearanceBase) this.ultraTreeX.Appearances["lastleaf"];
    this.NodeOverrideYellowBack.NodeAppearance = (AppearanceBase) this.ultraTreeX.Appearances["yellowback"];
    this.NodeOverrideDefault.NodeAppearance = (AppearanceBase) this.ultraTreeX.Appearances["default"];
  }

  private void AddNode(XmlNode inXmlNode, UltraTreeNode inTreeNode)
  {
    ((SubObjectBase) inTreeNode).Tag = (object) new frmXMLView.NodeTagInfo(inXmlNode);
    if (inXmlNode.HasChildNodes && inTreeNode.Level <= this.NodeLoadLevelLimit)
    {
      int num = inXmlNode.ChildNodes.Count - 1;
      for (int i = 0; i <= num; ++i)
      {
        XmlNode childNode = inXmlNode.ChildNodes[i];
        frmXMLView.NodeTagInfo nodeTagInfo = new frmXMLView.NodeTagInfo(childNode);
        try
        {
          inTreeNode.Nodes.Add(new UltraTreeNode(nodeTagInfo.XPath, childNode.Name));
        }
        catch (ArgumentException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          inTreeNode.Nodes.Add(new UltraTreeNode((string) null, childNode.Name));
          this.ToolStripStatusLabel2.Text = "Duplicate paths found";
          ProjectData.ClearProjectError();
        }
        UltraTreeNode node = inTreeNode.Nodes[i];
        this.AddNode(childNode, node);
        if (this.MaxNodeLevel < node.Level)
          this.MaxNodeLevel = node.Level;
      }
      ((frmXMLView.NodeTagInfo) ((SubObjectBase) inTreeNode).Tag).IsNodePopulated = true;
    }
    else
    {
      if (inXmlNode.HasChildNodes)
      {
        inTreeNode.Text = inXmlNode.Name.Trim();
      }
      else
      {
        inTreeNode.Text = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(inXmlNode.InnerText.Trim(), "", false) != 0 ? inXmlNode.InnerText.Trim() : inXmlNode.Name;
        inTreeNode.Override = this.NodeOverrideLastLeaf;
        inTreeNode.Override.ShowExpansionIndicator = (ShowExpansionIndicator) 2;
      }
      if (this.MaxNodeLevel < inTreeNode.Level)
        this.MaxNodeLevel = inTreeNode.Level;
    }
    this.AllNodes.Add(inTreeNode);
  }

  private void ShowSearch()
  {
    if (!this.SearchListPopulated)
    {
      int num = (int) MessageBox.Show("Search function initializing. Please try again in 5 seconds.", "Search function not ready", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (Information.IsNothing((object) this.frmsrch))
      {
        this.frmsrch = new frmXMLView.frmSearchPrivate();
        this.frmsrch.TopLevel = false;
        this.frmsrch.Parent = (Control) this;
        this.Controls.Add((Control) this.frmsrch);
        this.frmsrch.Visible = true;
        this.frmsrch.Show();
      }
      this.frmsrch.Location = new Point(this.ClientRectangle.Width - this.frmsrch.Width, 0);
      this.frmsrch.Visible = true;
      this.frmsrch.BringToFront();
      this.frmsrch.Activate();
    }
  }

  public void DoSearch(string SearchStr)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.LastSearchText, SearchStr, false) != 0)
    {
      this.CurrentNodeMatches.Clear();
      this.LastSearchText = SearchStr;
      this.LastNodeIndex = 0;
      try
      {
        foreach (Tuple<string, string> search in this.SearchList)
        {
          if (search.Item1.ToLower().Contains(SearchStr.ToLower()) | search.Item2.ToLower().Contains(SearchStr.ToLower()))
            this.CurrentNodeMatches.Add(search.Item1);
        }
      }
      finally
      {
        List<Tuple<string, string>>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    if (this.LastNodeIndex >= this.CurrentNodeMatches.Count)
    {
      int num = (int) MessageBox.Show("End of XML document reached.", "Search done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.LastNodeIndex = 0;
    }
    if (this.LastNodeIndex < 0 || this.CurrentNodeMatches.Count <= 0 || this.LastNodeIndex >= this.CurrentNodeMatches.Count)
      return;
    this.SelectNodeByPath(this.CurrentNodeMatches[this.LastNodeIndex]);
    ++this.LastNodeIndex;
  }

  private void SelectNodeByPath(string path)
  {
    string[] strArray = path.Split('/');
    string str = "/" + strArray[0];
    UltraTreeNode node = this.ultraTreeX.Nodes[str];
    int num = strArray.Length - 1;
    for (int index = 1; index <= num; ++index)
    {
      str = $"{str}/{strArray[index]}";
      node = node.Nodes[str];
      node.Expanded = true;
      this.ultraTreeX.ActiveNode = node;
    }
    if (!node.HasNodes)
      return;
    this.ultraTreeX.ActiveNode = node.Nodes[0];
    this.ToolStripStatusLabel2.Text = node.Nodes[0].FullPath;
  }

  public static string GetPath(XElement element)
  {
    IEnumerable<XElement> source = element.AncestorsAndSelf().Reverse<XElement>();
    System.Func<XElement, string> selector;
    // ISSUE: reference to a compiler-generated field
    if (frmXMLView._Closure\u0024__.\u0024I66\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = frmXMLView._Closure\u0024__.\u0024I66\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmXMLView._Closure\u0024__.\u0024I66\u002D0 = selector = (System.Func<XElement, string>) ([SpecialName] (e) =>
      {
        frmXMLView.GetIndex(e);
        return $"{e.Name.LocalName}[{frmXMLView.GetIndex(e)}]";
      });
    }
    return string.Join("/", source.Select<XElement, string>(selector));
  }

  private static int GetIndex(XElement element)
  {
    int num = 1;
    int index;
    if (element.Parent == null)
    {
      index = 1;
    }
    else
    {
      try
      {
        foreach (object element1 in element.Parent.Elements((XName) element.Name.LocalName))
        {
          if (!element1.Equals((object) element))
            ++num;
          else
            break;
        }
      }
      finally
      {
        IEnumerator<XElement> enumerator;
        enumerator?.Dispose();
      }
      index = num;
    }
    return index;
  }

  private void trackBarCollapse_ValueChanged(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      foreach (UltraTreeNode ultraTreeNode in this.AllNodes.Where<UltraTreeNode>((System.Func<UltraTreeNode, bool>) ([SpecialName] (n) => n.Level <= this.trackBarCollapse.Value)))
        ultraTreeNode.Expanded = ultraTreeNode.Level != this.trackBarCollapse.Value;
    }
    finally
    {
      IEnumerator<UltraTreeNode> enumerator;
      enumerator?.Dispose();
    }
    this.Cursor = Cursors.Default;
  }

  private void ultraTreeX_BeforeExpand(object sender, CancelableNodeEventArgs e)
  {
    if (((frmXMLView.NodeTagInfo) ((SubObjectBase) e.TreeNode).Tag).IsNodeLeaf || ((frmXMLView.NodeTagInfo) ((SubObjectBase) e.TreeNode).Tag).IsNodePopulated)
      return;
    frmXMLView.NodeTagInfo tag = (frmXMLView.NodeTagInfo) ((SubObjectBase) e.TreeNode).Tag;
    XmlNode Expression = this.xmldoc.SelectSingleNode(tag.XPath);
    if (Information.IsNothing((object) Expression))
      return;
    tag.IsNodePopulated = true;
    try
    {
      foreach (XmlNode childNode in Expression.ChildNodes)
      {
        frmXMLView.NodeTagInfo nodeTagInfo = new frmXMLView.NodeTagInfo(childNode);
        UltraTreeNode ultraTreeNode = new UltraTreeNode(nodeTagInfo.XPath, childNode.Name);
        ((SubObjectBase) ultraTreeNode).Tag = (object) nodeTagInfo;
        if (childNode.HasChildNodes)
        {
          ultraTreeNode.Text = childNode.Name.Trim();
        }
        else
        {
          ultraTreeNode.Text = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(childNode.InnerText.Trim(), "", false) != 0 ? childNode.InnerText.Trim() : childNode.Name;
          ultraTreeNode.Override = this.NodeOverrideLastLeaf;
          ultraTreeNode.Override.ShowExpansionIndicator = (ShowExpansionIndicator) 2;
        }
        e.TreeNode.Nodes.Add(ultraTreeNode);
        this.AllNodes.Add(ultraTreeNode);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private class frmSearchPrivate : Form
  {
    private IContainer components;

    public frmSearchPrivate()
    {
      this.FormClosing += new FormClosingEventHandler(this.frmSearch_FormClosing);
      this.Activated += new EventHandler(this.frmSearch_Activated);
      this.Shown += new EventHandler(this.frmSearch_Shown);
      this.VisibleChanged += new EventHandler(this.frmSearch_VisibleChanged);
      this.InitializeComponent();
    }

    internal virtual TextBox txtSearchBox
    {
      get => this._txtSearchBox;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSearchBox_KeyUp);
        TextBox txtSearchBox1 = this._txtSearchBox;
        if (txtSearchBox1 != null)
          txtSearchBox1.KeyUp -= keyEventHandler;
        this._txtSearchBox = value;
        TextBox txtSearchBox2 = this._txtSearchBox;
        if (txtSearchBox2 == null)
          return;
        txtSearchBox2.KeyUp += keyEventHandler;
      }
    }

    internal virtual Button Button1
    {
      get => this._Button1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        Button button1_1 = this._Button1;
        if (button1_1 != null)
          button1_1.Click -= eventHandler;
        this._Button1 = value;
        Button button1_2 = this._Button1;
        if (button1_2 == null)
          return;
        button1_2.Click += eventHandler;
      }
    }

    private void frmSearch_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (e.CloseReason != CloseReason.UserClosing)
        return;
      this.Visible = false;
      e.Cancel = true;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      ((frmXMLView) this.Parent).DoSearch(this.txtSearchBox.Text);
    }

    private void frmSearch_Activated(object sender, EventArgs e) => this.txtSearchBox.Focus();

    private void frmSearch_Shown(object sender, EventArgs e) => this.txtSearchBox.Focus();

    private void frmSearch_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.txtSearchBox.Focus();
    }

    private void txtSearchBox_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.Button1_Click((object) this, new EventArgs());
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
      this.txtSearchBox = new TextBox();
      this.Button1 = new Button();
      this.SuspendLayout();
      this.txtSearchBox.Dock = DockStyle.Fill;
      this.txtSearchBox.Location = new Point(0, 0);
      this.txtSearchBox.Name = "txtSearchBox";
      this.txtSearchBox.Size = new Size(278, 20);
      this.txtSearchBox.TabIndex = 0;
      this.Button1.Dock = DockStyle.Right;
      this.Button1.Location = new Point(278, 0);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(75, 20);
      this.Button1.TabIndex = 0;
      this.Button1.Text = "Search";
      this.Button1.UseVisualStyleBackColor = true;
      this.AccessibleRole = AccessibleRole.None;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CausesValidation = false;
      this.ClientSize = new Size(353, 20);
      this.Controls.Add((Control) this.txtSearchBox);
      this.Controls.Add((Control) this.Button1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.KeyPreview = true;
      this.MinimizeBox = false;
      this.Name = "frmSearch";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.SizeGripStyle = SizeGripStyle.Hide;
      this.StartPosition = FormStartPosition.Manual;
      this.Text = "Search";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }

  private class NodeTagInfo
  {
    private bool _isNodeLeaf;
    public bool IsNodePopulated;
    private string _xPath;
    private XmlNodeType _nodeType;

    public bool IsNodeLeaf => this._isNodeLeaf;

    public string XPath => this._xPath;

    public XmlNodeType NodeType
    {
      get => this._nodeType;
      set => this._nodeType = value;
    }

    public NodeTagInfo(XmlNode node)
    {
      this._isNodeLeaf = false;
      this.IsNodePopulated = false;
      this._isNodeLeaf = !node.HasChildNodes;
      this.NodeType = node.NodeType;
      this._xPath = this.FindXPath(node);
    }

    private string FindXPath(XmlNode node)
    {
      StringBuilder stringBuilder = new StringBuilder();
      while (node != null)
      {
        switch (node.NodeType)
        {
          case XmlNodeType.Element:
            int elementIndex1 = this.FindElementIndex((XmlElement) node);
            stringBuilder.Insert(0, $"/{node.Name}[{elementIndex1.ToString()}]");
            node = node.ParentNode;
            continue;
          case XmlNodeType.Attribute:
            stringBuilder.Insert(0, "/@" + node.Name);
            node = (XmlNode) ((XmlAttribute) node).OwnerElement;
            continue;
          case XmlNodeType.Text:
            int elementIndex2 = this.FindElementIndex((XmlElement) node.ParentNode);
            stringBuilder.Insert(0, $"/{node.ParentNode.Name}[{elementIndex2.ToString()}]");
            node = node.ParentNode;
            continue;
          case XmlNodeType.Document:
            return stringBuilder.ToString();
          default:
            throw new ArgumentException("Only elements and attributes are supported");
        }
      }
      throw new ArgumentException("Node was not in a document");
    }

    private int FindElementIndex(XmlElement element)
    {
      XmlNode parentNode = element.ParentNode;
      if (parentNode is XmlDocument)
        return 1;
      XmlElement xmlElement = (XmlElement) parentNode;
      int elementIndex = 1;
      try
      {
        foreach (XmlNode childNode in xmlElement.ChildNodes)
        {
          if (childNode is XmlElement && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(childNode.Name, element.Name, false) == 0)
          {
            if (childNode.Equals((object) element))
              return elementIndex;
            ++elementIndex;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      throw new ArgumentException("Couldn't find element within parent");
    }
  }
}
