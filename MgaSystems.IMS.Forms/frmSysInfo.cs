// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmSysInfo
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.Serialization;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

public sealed class frmSysInfo : Form
{
  private IContainer components;
  private ListView ListView1;
  private ColumnHeader colItem;
  private ColumnHeader colValue;

  public frmSysInfo()
  {
    this.Load += new EventHandler(this.frmSysInfo_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.ListView1 = new ListView();
    this.colItem = new ColumnHeader();
    this.colValue = new ColumnHeader();
    this.Button1 = new Button();
    this.SuspendLayout();
    this.ListView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ListView1.BackColor = Color.White;
    this.ListView1.Columns.AddRange(new ColumnHeader[2]
    {
      this.colItem,
      this.colValue
    });
    this.ListView1.ForeColor = Color.Black;
    this.ListView1.GridLines = true;
    this.ListView1.HideSelection = false;
    this.ListView1.Location = new Point(0, 32 /*0x20*/);
    this.ListView1.Name = "ListView1";
    this.ListView1.Size = new Size(644, 306);
    this.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
    this.ListView1.TabIndex = 0;
    this.ListView1.UseCompatibleStateImageBehavior = false;
    this.ListView1.View = View.Details;
    this.colItem.Text = "Item";
    this.colItem.Width = 300;
    this.colValue.Text = "Value";
    this.colValue.Width = 300;
    this.Button1.Dock = DockStyle.Top;
    this.Button1.Location = new Point(0, 0);
    this.Button1.Name = "Button1";
    this.Button1.Size = new Size(644, 26);
    this.Button1.TabIndex = 1;
    this.Button1.Text = "View Embedded Browser Information";
    this.Button1.UseVisualStyleBackColor = true;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(644, 339);
    this.Controls.Add((Control) this.Button1);
    this.Controls.Add((Control) this.ListView1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.MinimizeBox = false;
    this.Name = nameof (frmSysInfo);
    this.SizeGripStyle = SizeGripStyle.Show;
    this.Text = "System Information";
    this.ResumeLayout(false);
  }

  private void AddItem(string item, string value)
  {
    this.ListView1.Items.Add(new ListViewItem(new string[2]
    {
      item,
      value
    }));
  }

  private void frmSysInfo_Load(object sender, EventArgs e)
  {
    this.AddItem("IMS Username", CurrentUser.Instance.UserName);
    this.AddItem("IMS Port", IMSClientLogOn.ServerPort.ToString());
    this.AddItem("IMS Domain", IMSClientLogOn.LogOnDomainName);
    using (SqlConnection connection = DefaultDatabase.CreateConnection())
      this.AddItem("Packet Size", connection.PacketSize.ToString());
    try
    {
      try
      {
        foreach (string installedDotnetVersion in DotnetEnvironment.DetectInstalledDotnetVersions())
          this.AddItem(".Net Framework", installedDotnetVersion.Replace(".NET Framework", "Version"));
      }
      finally
      {
        List<string>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.AddItem(".Net Framework", "An error occurred while detecting the .Net version installed on this machine");
      ProjectData.ClearProjectError();
    }
    try
    {
      if (frmSysInfo.ResolveNetRateUsingFileBasedCommunication())
        this.AddItem("NetRate Integration Method", "File");
      else
        this.AddItem("NetRate Integration Method", "COM+");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.AddItem("NetRate Integration Method", "Unable to determine");
      ProjectData.ClearProjectError();
    }
    try
    {
      this.AddItem("Windows Version", Environment.OSVersion.ToString());
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    try
    {
      try
      {
        Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
        Func<Assembly, string> selector;
        // ISSUE: reference to a compiler-generated field
        if (frmSysInfo._Closure\u0024__.\u0024I12\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector = frmSysInfo._Closure\u0024__.\u0024I12\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmSysInfo._Closure\u0024__.\u0024I12\u002D0 = selector = (Func<Assembly, string>) ([SpecialName] (asm) => asm.FullName);
        }
        IEnumerable<string> source = ((IEnumerable<Assembly>) assemblies).Select<Assembly, string>(selector);
        Func<string, string> keySelector;
        // ISSUE: reference to a compiler-generated field
        if (frmSysInfo._Closure\u0024__.\u0024I12\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          keySelector = frmSysInfo._Closure\u0024__.\u0024I12\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmSysInfo._Closure\u0024__.\u0024I12\u002D1 = keySelector = (Func<string, string>) ([SpecialName] (fullName) => fullName);
        }
        foreach (string str in (IEnumerable<string>) source.OrderBy<string, string>(keySelector))
          this.AddItem("Loaded Assembly", str);
      }
      finally
      {
        IEnumerator<string> enumerator;
        enumerator?.Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    this.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
    this.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
  }

  private static bool ResolveNetRateUsingFileBasedCommunication()
  {
    string str = "UseNetRateFileCommunication";
    int num = Preferences.GetPreferenceInt($"NetRate.Override.{str}");
    if (num == -1)
      num = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<int>($"NetRate.{str}", 0);
    if (num == -1)
      throw new InvalidOperationException($"NetRate setting cannot be null. Setting name: {str}");
    return num == 1;
  }

  private void Button1_Click(object sender, EventArgs e) => new HostedBrowserInfo().ShowDialog();
}
