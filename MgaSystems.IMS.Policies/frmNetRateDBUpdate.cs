// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmNetRateDBUpdate
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class frmNetRateDBUpdate : Form
{
  private IContainer components;
  private readonly Guid _quoteGuid;
  private readonly int _quoteId;

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
    this.lblNetRateUnitNumber = new Label();
    this.txtNetRateXPath = new MGATextBox();
    this.Label1 = new Label();
    this.btnSave = new MGAButton();
    this.btnHelp = new MGAButton();
    this.Label2 = new Label();
    this.txtAddPremium = new MGATextBox();
    ((ISupportInitialize) this.txtNetRateXPath).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnHelp).BeginInit();
    ((ISupportInitialize) this.txtAddPremium).BeginInit();
    this.SuspendLayout();
    this.lblNetRateUnitNumber.AutoSize = true;
    this.lblNetRateUnitNumber.Location = new Point(21, 9);
    this.lblNetRateUnitNumber.Name = "lblNetRateUnitNumber";
    this.lblNetRateUnitNumber.Size = new Size(151, 13);
    this.lblNetRateUnitNumber.TabIndex = 10;
    this.lblNetRateUnitNumber.Text = "Xpath to node to be Updated:";
    this.lblNetRateUnitNumber.TextAlign = ContentAlignment.MiddleRight;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNetRateXPath).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtNetRateXPath).BackColor = Color.White;
    ((Control) this.txtNetRateXPath).Location = new Point(24, 34);
    this.txtNetRateXPath.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtNetRateXPath).Name = "txtNetRateXPath";
    ((Control) this.txtNetRateXPath).Size = new Size(490, 20);
    ((Control) this.txtNetRateXPath).TabIndex = 13;
    ((UltraControlBase) this.txtNetRateXPath).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNetRateXPath).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(21, 18);
    this.Label1.MaximumSize = new Size(350, 100);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(0, 13);
    this.Label1.TabIndex = 14;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(373, 65);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 15;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnHelp).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnHelp).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnHelp).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnHelp).Location = new Point(435, 65);
    ((Control) this.btnHelp).Name = "btnHelp";
    ((Control) this.btnHelp).Size = new Size(40, 40);
    ((Control) this.btnHelp).TabIndex = 16 /*0x10*/;
    this.btnHelp.UseOSThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(122, 72);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(118, 13);
    this.Label2.TabIndex = 17;
    this.Label2.Text = "Add/Subtract Premium:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAddPremium).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtAddPremium).BackColor = Color.White;
    ((Control) this.txtAddPremium).Location = new Point(250, 69);
    this.txtAddPremium.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtAddPremium).Name = "txtAddPremium";
    ((Control) this.txtAddPremium).Size = new Size(95, 20);
    ((Control) this.txtAddPremium).TabIndex = 18;
    ((UltraControlBase) this.txtAddPremium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAddPremium).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(526, 108);
    this.Controls.Add((Control) this.txtAddPremium);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.btnHelp);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtNetRateXPath);
    this.Controls.Add((Control) this.lblNetRateUnitNumber);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmNetRateDBUpdate);
    this.Text = "NetRate Reconnect Data Form";
    ((ISupportInitialize) this.txtNetRateXPath).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnHelp).EndInit();
    ((ISupportInitialize) this.txtAddPremium).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("lblNetRateUnitNumber")]
  private virtual Label lblNetRateUnitNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNetRateXPath")]
  internal virtual MGATextBox txtNetRateXPath { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnHelp
  {
    get => this._btnHelp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnHelp_Click);
      MGAButton btnHelp1 = this._btnHelp;
      if (btnHelp1 != null)
        ((Control) btnHelp1).Click -= eventHandler;
      this._btnHelp = value;
      MGAButton btnHelp2 = this._btnHelp;
      if (btnHelp2 == null)
        return;
      ((Control) btnHelp2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAddPremium")]
  internal virtual MGATextBox txtAddPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmNetRateDBUpdate(int quoteId)
  {
    this.Load += new EventHandler(this.frmNetRateReconnectData_Load);
    this.InitializeComponent();
    this._quoteId = quoteId;
  }

  public frmNetRateDBUpdate(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.frmNetRateReconnectData_Load);
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._quoteId = this.getQuoteId();
  }

  private int getQuoteId()
  {
    string str = "Select quoteid from tblquotes where quoteguid = @QG";
    object objectValue;
    try
    {
      objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, str, new object[2]
      {
        (object) "@QG",
        (object) this._quoteGuid
      }));
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("SQL Error In Function getQuoteId. " + ex.ToString());
      throw;
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("Error In Function getQuoteId. " + ex.ToString());
      throw;
    }
    return (int) objectValue;
  }

  private void frmNetRateReconnectData_Load(object sender, EventArgs e)
  {
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnHelp).Appearance.Image = (object) instance.Help;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtNetRateXPath).Text, "", false) != 0)
    {
      try
      {
        int result;
        if (int.TryParse(((TextEditorControlBase) this.txtAddPremium).Text, out result))
        {
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO NetRateXSL_UpdatePremium(QuoteId, Node, AddToPremium)VALUES(@QuoteId, @Node, @AddToPremium)", new object[6]
          {
            (object) "@QuoteId",
            (object) this._quoteId,
            (object) "@Node",
            (object) ((TextEditorControlBase) this.txtNetRateXPath).Text,
            (object) "@AddToPremium",
            (object) result
          });
          this.Close();
        }
        else
        {
          int num = (int) MessageBox.Show("Please enter a valid premium (type integer).");
        }
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) MessageBox.Show("SQL Error In Function btnSave_Click. " + ex.ToString());
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show("Error In Function btnSave_Click. " + ex.ToString());
        ProjectData.ClearProjectError();
      }
    }
    else
    {
      int num1 = (int) MessageBox.Show("Please enter a valid XPath.");
    }
  }

  private void btnHelp_Click(object sender, EventArgs e)
  {
    int num = (int) MessageBox.Show("This will allow the user to update the particular xml node they want. The reason for doing this instead of using the premium nodes is to update the Database column as well as the premium. Therefore this will allow user to update the IMS premium as well as the premium displayed on the corresponding reports. Otherwise only the IMS willupdate the premium, the corresponding reports will not display the premium as updated.\r \rINSTRUCTIONS: \r1) Insert the node you want updated. Make sure it is the correct path. \r   Ex. //QuoteObject/Insured/Quote/Location[@UnitNumber='1']/TerrorismLiability/Premium\r2) Enter the amount you want to update the node premium by. You can add or subtract but number should be whole numbers.\r3) Save the changes and open the NetRate application.\r4) Return from the NetRate and the premium should update in the IMS display and in the report.\r");
  }

  public enum NetRateUpdateStatus
  {
    Failed,
    Successful,
  }
}
