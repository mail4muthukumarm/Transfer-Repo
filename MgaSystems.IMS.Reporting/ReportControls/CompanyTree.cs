// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.CompanyTree
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using MGASystems.Data;
using Microsoft.VisualBasic;
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
namespace MGASystems.IMS.Reporting.ReportControls;

public class CompanyTree : BaseReportControl
{
  private IContainer components;
  private bool _ShowAll;
  private string _strGuid;
  private Type _ReturnType;
  private bool _CheckAllItem;
  private bool _ReturnAll;
  private int _ControlHeight;
  private DataTable _dt;
  private bool _ShowAllOption;
  private bool _AlreadyInitialized;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual TreeView tvCompanies
  {
    get => this._tvCompanies;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      TreeViewEventHandler viewEventHandler = new TreeViewEventHandler(this.tvCompanies_AfterCheck);
      TreeView tvCompanies1 = this._tvCompanies;
      if (tvCompanies1 != null)
        tvCompanies1.AfterCheck -= viewEventHandler;
      this._tvCompanies = value;
      TreeView tvCompanies2 = this._tvCompanies;
      if (tvCompanies2 == null)
        return;
      tvCompanies2.AfterCheck += viewEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.tvCompanies = new TreeView();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 126);
    this.tvCompanies.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.tvCompanies.CheckBoxes = true;
    this.tvCompanies.Location = new Point(88, 6);
    this.tvCompanies.Name = "tvCompanies";
    this.tvCompanies.Size = new Size(300, 114);
    this.tvCompanies.TabIndex = 3;
    this.Controls.Add((Control) this.tvCompanies);
    this.Name = nameof (CompanyTree);
    this.Size = new Size(392, 126);
    this.Controls.SetChildIndex((Control) this.tvCompanies, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.ResumeLayout(false);
  }

  public CompanyTree()
  {
    this._ReturnAll = true;
    this._ControlHeight = 62;
    this._ShowAllOption = false;
    this._AlreadyInitialized = false;
    this.InitializeComponent();
    this._AlreadyInitialized = true;
    this.InitialSize = this.Size;
  }

  public CompanyTree(string LabelText, int width, int ControlHeight, bool ShowAllOption)
    : this(LabelText, ControlHeight, ShowAllOption)
  {
    if (!this._AlreadyInitialized)
    {
      this.InitializeComponent();
      this._AlreadyInitialized = true;
    }
    this.Width -= this.tvCompanies.Width - width;
    this.tvCompanies.Width = width;
    this.InitialSize = this.Size;
  }

  public CompanyTree(string LabelText, int ControlHeight, bool ShowAllOption)
    : this(LabelText, ShowAllOption)
  {
    if (!this._AlreadyInitialized)
    {
      this.InitializeComponent();
      this._AlreadyInitialized = true;
    }
    this.tvCompanies.Height = ControlHeight;
    this.Height = ControlHeight + 2;
    this.InitialSize = this.Size;
  }

  public CompanyTree(string LabelText, bool ShowAllOption)
  {
    this._ReturnAll = true;
    this._ControlHeight = 62;
    this._ShowAllOption = false;
    this._AlreadyInitialized = false;
    if (!this._AlreadyInitialized)
    {
      this.InitializeComponent();
      this._AlreadyInitialized = true;
    }
    this._ShowAllOption = ShowAllOption;
    this.Description = LabelText;
    this._dt = DefaultDatabase.ExecuteDataTable("Report_GetCompanyTree");
    TreeNode node1 = new TreeNode();
    if (ShowAllOption)
    {
      node1 = this.tvCompanies.Nodes.Add(Guid.Empty.ToString(), "Select All");
      node1.Tag = (object) Guid.Empty;
      this.Paint += new PaintEventHandler(this.CompanyTree_Paint);
    }
    this.tvCompanies.AfterCheck += new TreeViewEventHandler(this.tvCompanies_AfterCheck);
    int num = 1;
    try
    {
      foreach (DataRow row in this._dt.Rows)
      {
        ++num;
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(row["ParentGUID"])))
        {
          TreeNode node2 = new TreeNode(Conversions.ToString(row["LocationName"]));
          node2.Tag = RuntimeHelpers.GetObjectValue(row["CompanyLocationGUID"]);
          DataRow[] dataRowArray = this._dt.Select($"ParentGUID='{row["CompanyLocationGUID"].ToString()}'");
          int index = 0;
          while (index < dataRowArray.Length)
          {
            DataRow dataRow = dataRowArray[index];
            ++num;
            node2.Nodes.Add(new TreeNode(Conversions.ToString(dataRow["LocationName"]))
            {
              Tag = RuntimeHelpers.GetObjectValue(dataRow["CompanyLocationGUID"])
            });
            checked { ++index; }
          }
          if (ShowAllOption)
            node1.Nodes.Add(node2);
          else
            this.tvCompanies.Nodes.Add(node2);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (ShowAllOption)
      this.CheckAllChildNodes(node1, true);
    this.InitialSize = this.Size;
  }

  private bool AllIsSelected()
  {
    return this.tvCompanies.Nodes.Find(Guid.Empty.ToString(), true).Length > 0 && this.tvCompanies.Nodes.Find(Guid.Empty.ToString(), true)[0].Checked;
  }

  private int TreeviewCountCheckedNodes(TreeNodeCollection treeNodeCollection)
  {
    int num = 0;
    if (treeNodeCollection != null)
    {
      try
      {
        foreach (TreeNode treeNode in treeNodeCollection)
        {
          if (treeNode.Nodes.Count == 0 && treeNode.Checked)
            ++num;
          else if (treeNode.Nodes.Count > 0)
            num += this.TreeviewCountCheckedNodes(treeNode.Nodes);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    return num;
  }

  public override string InputErrorMessage
  {
    get
    {
      int num = this.TreeviewCountCheckedNodes(this.tvCompanies.Nodes);
      return num != 0 ? (num <= 200 || this.AllIsSelected() ? string.Empty : "Please select fewer then 200 items.") : "Please select at least one item from the list.";
    }
  }

  public override object Value
  {
    get
    {
      string str1 = string.Empty;
      string str2 = string.Empty;
      TreeNodeCollection treeNodeCollection = !this._ShowAllOption ? this.tvCompanies.Nodes : this.tvCompanies.Nodes.Find(Guid.Empty.ToString(), true)[0].Nodes;
      if (!this.AllIsSelected())
      {
        try
        {
          foreach (TreeNode treeNode in treeNodeCollection)
          {
            if (treeNode.Checked)
            {
              if (!str1.Contains(treeNode.Tag.ToString()))
                str1 = $"{str1}{treeNode.Tag.ToString()},";
              try
              {
                foreach (TreeNode node in treeNode.Nodes)
                {
                  if (node.Checked && !str2.Contains(node.Tag.ToString()))
                    str2 = $"{str2}{node.Tag.ToString()},";
                }
              }
              finally
              {
                IEnumerator enumerator;
                if (enumerator is IDisposable)
                  (enumerator as IDisposable).Dispose();
              }
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      if (str1.Length > 5)
        str1 = str1.Substring(0, str1.Length - 1);
      if (str2.Length > 5)
        str2 = str2.Substring(0, str2.Length - 1);
      return (object) new object[2]
      {
        (object) str1,
        (object) str2
      };
    }
    set
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(value)) || Information.IsNothing(RuntimeHelpers.GetObjectValue(value)) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(value.ToString(), "", false) == 0 || !Information.IsArray(RuntimeHelpers.GetObjectValue(value)))
        return;
      object[] objArray = (object[]) value;
      string Expression1 = Conversions.ToString(objArray[0]);
      string Expression2 = Conversions.ToString(objArray[1]);
      Strings.Split(Expression1, ",");
      Strings.Split(Expression2, ",");
      this.tvCompanies.AfterCheck -= new TreeViewEventHandler(this.tvCompanies_AfterCheck);
      TreeNodeCollection nodes;
      if (this._ShowAllOption)
      {
        this.tvCompanies.Nodes.Find(Guid.Empty.ToString(), true)[0].Checked = false;
        nodes = this.tvCompanies.Nodes.Find(Guid.Empty.ToString(), true)[0].Nodes;
      }
      else
        nodes = this.tvCompanies.Nodes;
      try
      {
        foreach (TreeNode treeNode in nodes)
        {
          if (Expression1.Contains(treeNode.Tag.ToString()))
          {
            treeNode.Checked = true;
            try
            {
              foreach (TreeNode node in treeNode.Nodes)
                node.Checked = Expression2.Contains(node.Tag.ToString());
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
          }
          else
            treeNode.Checked = false;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.tvCompanies.AfterCheck += new TreeViewEventHandler(this.tvCompanies_AfterCheck);
    }
  }

  public override void Compress()
  {
    this.tvCompanies.Top = 0;
    this.lblDescription.Height = this.tvCompanies.Height;
    this.lblDescription.Top = 0;
    this.Height = this.tvCompanies.Height;
  }

  private void CompanyTree_Paint(object sender, PaintEventArgs e)
  {
    TreeNode treeNode = this.tvCompanies.Nodes.Find(Guid.Empty.ToString(), true)[0];
    treeNode.Checked = true;
    treeNode.Expand();
    this.Paint -= new PaintEventHandler(this.CompanyTree_Paint);
  }

  private void tvCompanies_AfterCheck(object sender, TreeViewEventArgs e)
  {
    if (e.Action == TreeViewAction.Unknown)
      return;
    if (e.Node.Nodes.Count > 0)
    {
      this.tvCompanies.AfterCheck -= new TreeViewEventHandler(this.tvCompanies_AfterCheck);
      this.CheckAllChildNodes(e.Node, e.Node.Checked);
      this.tvCompanies.AfterCheck += new TreeViewEventHandler(this.tvCompanies_AfterCheck);
    }
    if (!e.Node.Checked || Information.IsNothing((object) e.Node.Parent) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Node.Parent.Tag.ToString(), Guid.Empty.ToString(), false) == 0)
      return;
    this.tvCompanies.AfterCheck -= new TreeViewEventHandler(this.tvCompanies_AfterCheck);
    e.Node.Parent.Checked = true;
    this.tvCompanies.AfterCheck += new TreeViewEventHandler(this.tvCompanies_AfterCheck);
  }

  private void CheckAllChildNodes(TreeNode node, bool nodeChecked)
  {
    try
    {
      foreach (TreeNode node1 in node.Nodes)
      {
        node1.Checked = nodeChecked;
        if (node1.Nodes.Count > 0)
          this.CheckAllChildNodes(node1, nodeChecked);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }
}
