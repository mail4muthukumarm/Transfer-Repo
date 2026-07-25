// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Security.frmDisplayFoundSecurityAttributes
// Assembly: MgaSystems.IMS.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: A5FACEA8-628E-4FEB-97EB-CBBA0F666906
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Security.dll

using MGASystems.Common;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Security;

public class frmDisplayFoundSecurityAttributes : Form
{
  private IContainer components;

  public frmDisplayFoundSecurityAttributes()
  {
    this.Load += new EventHandler(this.frmDisplayFoundSecurityAttributes_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("ListView1")]
  internal virtual ListView ListView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("AssemblyName")]
  internal virtual ColumnHeader AssemblyName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PermName")]
  internal virtual ColumnHeader PermName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PermGuid")]
  internal virtual ColumnHeader PermGuid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.ListView1 = new ListView();
    this.AssemblyName = new ColumnHeader();
    this.PermName = new ColumnHeader();
    this.PermGuid = new ColumnHeader();
    this.SuspendLayout();
    this.ListView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ListView1.Columns.AddRange(new ColumnHeader[3]
    {
      this.AssemblyName,
      this.PermName,
      this.PermGuid
    });
    this.ListView1.Location = new Point(8, 8);
    this.ListView1.Name = "ListView1";
    this.ListView1.Size = new Size(776, 520);
    this.ListView1.TabIndex = 0;
    this.ListView1.View = View.Details;
    this.AssemblyName.Text = "Assembly";
    this.AssemblyName.Width = 288;
    this.PermName.Text = "Permission";
    this.PermName.Width = 254;
    this.PermGuid.Text = "GUID";
    this.PermGuid.Width = 187;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(792, 542);
    this.Controls.Add((Control) this.ListView1);
    this.Name = nameof (frmDisplayFoundSecurityAttributes);
    this.Text = "Security Attribute Viewer";
    this.ResumeLayout(false);
  }

  private void frmDisplayFoundSecurityAttributes_Load(object sender, EventArgs e)
  {
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new SecureResourceAttribute());
    int index1 = 0;
    while (index1 < typeArray.Length)
    {
      Type type = typeArray[index1];
      object[] customAttributes = type.GetCustomAttributes(typeof (SecureResourceAttribute), false);
      if (customAttributes != null)
      {
        object[] objArray = customAttributes;
        int index2 = 0;
        while (index2 < objArray.Length)
        {
          SecureResourceAttribute resourceAttribute = (SecureResourceAttribute) objArray[index2];
          this.ListView1.Items.Add(new ListViewItem(type.AssemblyQualifiedName)
          {
            SubItems = {
              resourceAttribute.Name,
              resourceAttribute.UniqueIdentifier.ToString()
            }
          });
          checked { ++index2; }
        }
      }
      checked { ++index1; }
    }
  }
}
