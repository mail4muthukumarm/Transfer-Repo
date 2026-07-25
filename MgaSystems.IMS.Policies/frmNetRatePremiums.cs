// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmNetRatePremiums
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class frmNetRatePremiums : Form
{
  private IContainer components;
  private readonly Guid _quoteGuid;
  private double _AmountSelected;
  private double _Premium;
  private Dictionary<string, List<ChargeClass>> _Charges;
  private readonly Quote _QuoteObject;

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
    this.txtPremium = new MGATextBox();
    this.Label1 = new Label();
    this.btnSave = new MGAButton();
    this.btnHelp = new MGAButton();
    this.TreeView1 = new TreeView();
    this.lblTotalPremiumAmount = new Label();
    this.lblLOBChosen = new Label();
    this.lblNewPremium = new Label();
    this.lblTotalPremium = new Label();
    this.lblNodeGuid = new Label();
    this.lblNodeTag = new Label();
    this.LinkLabel1 = new LinkLabel();
    this.DBUpdate_Link = new LinkLabel();
    this.btnCancel = new MGAButton();
    ((ISupportInitialize) this.txtPremium).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnHelp).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    this.lblNetRateUnitNumber.AutoSize = true;
    this.lblNetRateUnitNumber.Location = new Point(21, 55);
    this.lblNetRateUnitNumber.Name = "lblNetRateUnitNumber";
    this.lblNetRateUnitNumber.Size = new Size(78, 13);
    this.lblNetRateUnitNumber.TabIndex = 10;
    this.lblNetRateUnitNumber.Text = "Total Premium:";
    this.lblNetRateUnitNumber.TextAlign = ContentAlignment.MiddleLeft;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPremium).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtPremium).BackColor = Color.White;
    ((Control) this.txtPremium).Location = new Point(92, 32 /*0x20*/);
    this.txtPremium.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtPremium).Name = "txtPremium";
    ((Control) this.txtPremium).Size = new Size(107, 20);
    ((Control) this.txtPremium).TabIndex = 13;
    ((UltraControlBase) this.txtPremium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPremium).UseOsThemes = (DefaultableBoolean) 2;
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
    ((Control) this.btnSave).Location = new Point(292, 55);
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
    ((Control) this.btnHelp).Location = new Point(352, 55);
    ((Control) this.btnHelp).Name = "btnHelp";
    ((Control) this.btnHelp).Size = new Size(40, 40);
    ((Control) this.btnHelp).TabIndex = 16 /*0x10*/;
    this.btnHelp.UseOSThemes = (DefaultableBoolean) 2;
    this.TreeView1.Location = new Point(24, 113);
    this.TreeView1.Name = "TreeView1";
    this.TreeView1.Size = new Size(429, 266);
    this.TreeView1.TabIndex = 17;
    this.lblTotalPremiumAmount.Anchor = AnchorStyles.Right;
    this.lblTotalPremiumAmount.AutoSize = true;
    this.lblTotalPremiumAmount.ForeColor = Color.Green;
    this.lblTotalPremiumAmount.ImageAlign = ContentAlignment.MiddleRight;
    this.lblTotalPremiumAmount.Location = new Point(172, 84);
    this.lblTotalPremiumAmount.Name = "lblTotalPremiumAmount";
    this.lblTotalPremiumAmount.Size = new Size(70, 13);
    this.lblTotalPremiumAmount.TabIndex = 18;
    this.lblTotalPremiumAmount.Text = "Amount Here";
    this.lblTotalPremiumAmount.TextAlign = ContentAlignment.MiddleRight;
    this.lblTotalPremiumAmount.Visible = false;
    this.lblLOBChosen.AutoSize = true;
    this.lblLOBChosen.Location = new Point(21, 9);
    this.lblLOBChosen.Name = "lblLOBChosen";
    this.lblLOBChosen.Size = new Size(178, 13);
    this.lblLOBChosen.TabIndex = 19;
    this.lblLOBChosen.Text = "Click on the Charge below to edit it:";
    this.lblLOBChosen.TextAlign = ContentAlignment.MiddleLeft;
    this.lblNewPremium.AutoSize = true;
    this.lblNewPremium.ForeColor = Color.Green;
    this.lblNewPremium.Location = new Point(154, 55);
    this.lblNewPremium.Name = "lblNewPremium";
    this.lblNewPremium.Size = new Size(75, 13);
    this.lblNewPremium.TabIndex = 20;
    this.lblNewPremium.Text = "New Premium:";
    this.lblNewPremium.TextAlign = ContentAlignment.MiddleLeft;
    this.lblNewPremium.Visible = false;
    this.lblTotalPremium.Anchor = AnchorStyles.Right;
    this.lblTotalPremium.AutoSize = true;
    this.lblTotalPremium.ImageAlign = ContentAlignment.MiddleRight;
    this.lblTotalPremium.Location = new Point(44, 84);
    this.lblTotalPremium.Name = "lblTotalPremium";
    this.lblTotalPremium.Size = new Size(70, 13);
    this.lblTotalPremium.TabIndex = 21;
    this.lblTotalPremium.Text = "Amount Here";
    this.lblTotalPremium.TextAlign = ContentAlignment.MiddleRight;
    this.lblNodeGuid.AutoSize = true;
    this.lblNodeGuid.Location = new Point(415, 9);
    this.lblNodeGuid.Name = "lblNodeGuid";
    this.lblNodeGuid.Size = new Size(61, 13);
    this.lblNodeGuid.TabIndex = 22;
    this.lblNodeGuid.Text = "hiddenlabel";
    this.lblNodeGuid.Visible = false;
    this.lblNodeTag.AutoSize = true;
    this.lblNodeTag.Location = new Point(415, 32 /*0x20*/);
    this.lblNodeTag.Name = "lblNodeTag";
    this.lblNodeTag.Size = new Size(61, 13);
    this.lblNodeTag.TabIndex = 23;
    this.lblNodeTag.Text = "hiddenlabel";
    this.lblNodeTag.Visible = false;
    this.LinkLabel1.AutoSize = true;
    this.LinkLabel1.Location = new Point(358, 382);
    this.LinkLabel1.Name = "LinkLabel1";
    this.LinkLabel1.Size = new Size(48 /*0x30*/, 13);
    this.LinkLabel1.TabIndex = 24;
    this.LinkLabel1.TabStop = true;
    this.LinkLabel1.Text = "View Xml";
    this.DBUpdate_Link.AutoSize = true;
    this.DBUpdate_Link.Location = new Point(415, 382);
    this.DBUpdate_Link.Name = "DBUpdate_Link";
    this.DBUpdate_Link.Size = new Size(58, 13);
    this.DBUpdate_Link.TabIndex = 25;
    this.DBUpdate_Link.TabStop = true;
    this.DBUpdate_Link.Text = "DB Update";
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance4;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((Control) this.btnCancel).Location = new Point(413, 55);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 26;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(482, 394);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.DBUpdate_Link);
    this.Controls.Add((Control) this.LinkLabel1);
    this.Controls.Add((Control) this.lblNodeTag);
    this.Controls.Add((Control) this.lblNodeGuid);
    this.Controls.Add((Control) this.lblTotalPremium);
    this.Controls.Add((Control) this.lblNewPremium);
    this.Controls.Add((Control) this.lblLOBChosen);
    this.Controls.Add((Control) this.lblTotalPremiumAmount);
    this.Controls.Add((Control) this.TreeView1);
    this.Controls.Add((Control) this.btnHelp);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtPremium);
    this.Controls.Add((Control) this.lblNetRateUnitNumber);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmNetRatePremiums);
    this.Text = "NetRate Reconnect Data Form";
    ((ISupportInitialize) this.txtPremium).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnHelp).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("lblNetRateUnitNumber")]
  private virtual Label lblNetRateUnitNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox txtPremium
  {
    get => this._txtPremium;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtPremium_ValueChanged);
      MGATextBox txtPremium1 = this._txtPremium;
      if (txtPremium1 != null)
        ((TextEditorControlBase) txtPremium1).ValueChanged -= eventHandler;
      this._txtPremium = value;
      MGATextBox txtPremium2 = this._txtPremium;
      if (txtPremium2 == null)
        return;
      ((TextEditorControlBase) txtPremium2).ValueChanged += eventHandler;
    }
  }

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

  [field: AccessedThroughProperty("btnHelp")]
  private virtual MGAButton btnHelp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual TreeView TreeView1
  {
    get => this._TreeView1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.TreeView1_MouseClick);
      TreeViewEventHandler viewEventHandler = new TreeViewEventHandler(this.TreeView1_AfterSelect);
      TreeView treeView1_1 = this._TreeView1;
      if (treeView1_1 != null)
      {
        treeView1_1.MouseClick -= mouseEventHandler;
        treeView1_1.AfterSelect -= viewEventHandler;
      }
      this._TreeView1 = value;
      TreeView treeView1_2 = this._TreeView1;
      if (treeView1_2 == null)
        return;
      treeView1_2.MouseClick += mouseEventHandler;
      treeView1_2.AfterSelect += viewEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblTotalPremiumAmount")]
  private virtual Label lblTotalPremiumAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLOBChosen")]
  private virtual Label lblLOBChosen { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNewPremium")]
  private virtual Label lblNewPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTotalPremium")]
  private virtual Label lblTotalPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNodeGuid")]
  internal virtual Label lblNodeGuid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNodeTag")]
  internal virtual Label lblNodeTag { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel LinkLabel1
  {
    get => this._LinkLabel1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.ViewXML_LinkClicked);
      LinkLabel linkLabel1_1 = this._LinkLabel1;
      if (linkLabel1_1 != null)
        linkLabel1_1.LinkClicked -= clickedEventHandler;
      this._LinkLabel1 = value;
      LinkLabel linkLabel1_2 = this._LinkLabel1;
      if (linkLabel1_2 == null)
        return;
      linkLabel1_2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel DBUpdate_Link
  {
    get => this._DBUpdate_Link;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.DBUpdate_LinkClicked);
      LinkLabel dbUpdateLink1 = this._DBUpdate_Link;
      if (dbUpdateLink1 != null)
        dbUpdateLink1.LinkClicked -= clickedEventHandler;
      this._DBUpdate_Link = value;
      LinkLabel dbUpdateLink2 = this._DBUpdate_Link;
      if (dbUpdateLink2 == null)
        return;
      dbUpdateLink2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click_1);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  public frmNetRatePremiums(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.frmNetRateReconnectData_Load);
    this._Charges = new Dictionary<string, List<ChargeClass>>();
    this.InitializeComponent();
    ((Control) this.txtPremium).KeyPress += new KeyPressEventHandler(this.txtPremium_ValueChanged);
    this._quoteGuid = quoteGuid;
    this._AmountSelected = 0.0;
    this._QuoteObject = new Quote(this._quoteGuid);
  }

  private void frmNetRateReconnectData_Load(object sender, EventArgs e)
  {
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnHelp).Appearance.Image = (object) instance.Help;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) instance.Undo;
    this.setCharges();
    this.createXMLNodes();
  }

  private void ResetCharges()
  {
    this._Premium = 0.0;
    this._Charges.Clear();
    this.TreeView1.Nodes.Clear();
    this.setCharges();
    this.createXMLNodes();
  }

  private void UpdateNetRateLog(DbConnection conn)
  {
    using (DbCommand command = DefaultDatabase.CreateCommand("UpdateNetRateAuditLog", conn))
    {
      DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@quoteOptionGuid", (object) "5E98D093-317E-43F2-93A0-521571D1B1D4");
      DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@RaterChargeId", (object) 26);
      DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@OldPremium", (object) 2300.0);
      DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@ChangeInPremium", (object) -100.0);
      DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@UserId", (object) 1);
      DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@StateId", (object) "AK");
      command.Parameters.Clear();
      if (command.ExecuteNonQuery() != 0)
        return;
      Exception exception = new Exception("Update was Unsuccessful");
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    try
    {
      try
      {
        foreach (string key in this._Charges.Keys)
        {
          List<ChargeClass> charge = this._Charges[key];
          try
          {
            foreach (ChargeClass chargeClass in charge)
            {
              if (chargeClass.GetChargeUpdated())
              {
                if (DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "UpdatePremiumBasic", 1000, (CommandArgumentType) 0, new object[10]
                {
                  (object) "@quoteOptionGuid",
                  (object) chargeClass.GetQuoteOptionGuid(),
                  (object) "@premium",
                  (object) chargeClass.GetPremium(),
                  (object) "@officeID",
                  (object) -1,
                  (object) "@chargeCode",
                  (object) chargeClass.GetChargeCode(),
                  (object) "@RoundPremiums",
                  (object) false
                }) == 0)
                {
                  Exception exception = new Exception("Update was Unsuccessful");
                }
              }
            }
          }
          finally
          {
            List<ChargeClass>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
      }
      finally
      {
        Dictionary<string, List<ChargeClass>>.KeyCollection.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      SqlException sqlException = ex;
      if (sqlException.Message.Contains("A credit premium can Not be issued for"))
      {
        int num1 = (int) MessageBox.Show(sqlException.Message.ToString());
      }
      else
      {
        int num2 = (int) MessageBox.Show("SQL Error In Function btnSave_Click. " + sqlException.ToString());
      }
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("Error In Function btnSave_Click. " + ex.ToString());
      ProjectData.ClearProjectError();
    }
    try
    {
      try
      {
        foreach (string key in this._Charges.Keys)
        {
          List<ChargeClass> charge = this._Charges[key];
          try
          {
            foreach (ChargeClass chargeClass in charge)
            {
              if (chargeClass.GetChargeUpdated())
              {
                if (DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateNetRateAuditLog", 1000, (CommandArgumentType) 0, new object[12]
                {
                  (object) "@quoteOptionGuid",
                  (object) chargeClass.GetQuoteOptionGuid(),
                  (object) "@RaterChargeId",
                  (object) chargeClass.GetRaterChargeId(),
                  (object) "@OldPremium",
                  (object) chargeClass.GetOriginalPremium(),
                  (object) "@ChangeInPremium",
                  (object) (chargeClass.GetPremium() - chargeClass.GetOriginalPremium()),
                  (object) "@UserId",
                  (object) CurrentUser.Instance.UserID,
                  (object) "@State",
                  (object) chargeClass.GetStateInitials()
                }) == 0)
                {
                  Exception exception = new Exception("Update was Unsuccessful");
                }
              }
            }
          }
          finally
          {
            List<ChargeClass>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
      }
      finally
      {
        Dictionary<string, List<ChargeClass>>.KeyCollection.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      SqlException sqlException = ex;
      if (sqlException.Message.Contains("A credit premium can Not be issued for"))
      {
        int num3 = (int) MessageBox.Show(sqlException.Message.ToString());
      }
      else
      {
        int num4 = (int) MessageBox.Show("SQL Error In Function btnSave_Click. " + sqlException.ToString());
      }
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("Error In Function btnSave_Click. " + ex.ToString());
      ProjectData.ClearProjectError();
    }
  }

  private void setCharges()
  {
    dsPolicyDetail_Premiums policyDetailPremiums = new dsPolicyDetail_Premiums();
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) policyDetailPremiums, new string[4]
      {
        "LinesOptions",
        "tblQuoteOptions",
        "viewOptionPremiums",
        "defaultOptionPremiums"
      }, "dbo.spPolicyDetail_NetRatePremiums", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      });
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      SqlException sqlException = ex;
      if (sqlException.Message.Contains("Could not find stored procedure 'dbo.spPolicyDetail_NetRatePremiums'"))
      {
        int num1 = (int) MessageBox.Show("The necessary premium update sql data items have not yet been installed on this database.  You may still view or update the xml from the links located at the bottom right of the form.", "DB update needed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        int num2 = (int) MessageBox.Show("SQL Error In Function setCharges(). " + sqlException.ToString());
      }
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("SQL Error In Function setCharges(). " + ex.ToString());
      ProjectData.ClearProjectError();
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("Error In Function setCharges. " + ex.ToString());
      ProjectData.ClearProjectError();
    }
    try
    {
      foreach (DataRow row1 in policyDetailPremiums.Tables["tblQuoteOptions"].Rows)
      {
        RuntimeHelpers.GetObjectValue(row1["QuoteOptionGuid"]);
        Guid guid = new Guid(row1["QuoteOptionGuid"].ToString());
        string str = row1["LineName"].ToString();
        List<ChargeClass> chargeClassList = new List<ChargeClass>();
        try
        {
          foreach (DataRow row2 in policyDetailPremiums.Tables["viewOptionPremiums"].Rows)
          {
            ChargeClass chargeClass = new ChargeClass();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(guid.ToString(), row2["QuoteOptionGuid"].ToString(), false) == 0)
            {
              chargeClass.SetQuoteOptionGuid(row2["QuoteOptionGuid"].ToString());
              chargeClass.SetChargeCode(row2["ChargeCode"].ToString());
              chargeClass.SetChargeName(row2["ChargeName"].ToString());
              chargeClass.SetChargeType(char.Parse(row2["ChargeType"].ToString()));
              chargeClass.SetRaterChargeId(row2["RaterChargeId"].ToString());
              chargeClass.SetOfficeId(row2["OfficeId"].ToString());
              chargeClass.SetLineName(str);
              chargeClass.SetPremium(row2["Premium"].ToString());
              chargeClass.SetOriginalPremium(row2["Premium"].ToString());
              chargeClass.SetStateInitials(row2["StateId"].ToString());
              chargeClass.SetChargeUpdated(false);
              chargeClassList.Add(chargeClass);
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        if (chargeClassList.Count == 0)
        {
          try
          {
            foreach (DataRow row3 in policyDetailPremiums.Tables["defaultOptionPremiums"].Rows)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(guid.ToString(), row3["QuoteOptionGuid"].ToString(), false) == 0)
              {
                ChargeClass chargeClass = new ChargeClass();
                chargeClass.SetQuoteOptionGuid(guid.ToString());
                chargeClass.SetStateInitials(row3["DefaultStateId"].ToString());
                chargeClass.SetLineName(str);
                chargeClass.SetChargeName(row3["DefaultChargeName"].ToString());
                chargeClass.SetChargeCode(row3["DefaultChargeCode"].ToString());
                chargeClass.SetRaterChargeId(row3["DefaultRaterChargeId"].ToString());
                chargeClass.SetOfficeId(row3["DefaultOfficeId"].ToString());
                chargeClassList.Add(chargeClass);
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
        this._Charges.Add(str, chargeClassList);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void createXMLNodes()
  {
    try
    {
      foreach (string key in this._Charges.Keys)
      {
        TreeNode node1 = new TreeNode();
        node1.Text = key;
        node1.Tag = (object) frmNetRatePremiums.MyEnum.Parent;
        List<ChargeClass> charge = this._Charges[key];
        try
        {
          foreach (ChargeClass chargeClass in charge)
          {
            TreeNode node2 = new TreeNode();
            node2.Name = chargeClass.GetQuoteOptionGuid().ToString();
            node2.Text = $"{chargeClass.GetStateInitials()}_{chargeClass.GetChargeName()}_{Conversions.ToString(chargeClass.GetPremium())}";
            node2.Tag = (object) chargeClass.GetLineName();
            this._Premium += chargeClass.GetPremium();
            node1.Nodes.Add(node2);
          }
        }
        finally
        {
          List<ChargeClass>.Enumerator enumerator;
          enumerator.Dispose();
        }
        this.TreeView1.Nodes.Add(node1);
      }
    }
    finally
    {
      Dictionary<string, List<ChargeClass>>.KeyCollection.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.lblTotalPremium.Text = this._Premium.ToString();
    this.lblTotalPremiumAmount.Text = this._Premium.ToString();
  }

  private bool ContainsValue(string lineName, string containsString)
  {
    bool flag = false;
    if (this._Charges.ContainsKey(lineName))
    {
      List<ChargeClass> charge = this._Charges[lineName];
      try
      {
        foreach (ChargeClass chargeClass in charge)
        {
          if (chargeClass.GetChargeName().Equals(containsString))
            flag = true;
        }
      }
      finally
      {
        List<ChargeClass>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    return flag;
  }

  private void TreeView1_MouseClick(object sender, MouseEventArgs e)
  {
    if (this.TreeView1.SelectedNode == null || this.TreeView1.SelectedNode.Parent != null || e.Button != MouseButtons.Right)
      return;
    ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
    ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem("Add");
    ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem("Delete");
    List<string> allowableChargesToAdd = this.getAllowableChargesToAdd(this.getStateByLOB());
    try
    {
      foreach (string str in allowableChargesToAdd)
      {
        if (!this.ContainsValue(this.TreeView1.SelectedNode.Text.ToString(), str))
          toolStripMenuItem1.DropDownItems.Add(str);
        else
          toolStripMenuItem2.DropDownItems.Add(str);
      }
    }
    finally
    {
      List<string>.Enumerator enumerator;
      enumerator.Dispose();
    }
    toolStripMenuItem1.DropDown.ItemClicked += new ToolStripItemClickedEventHandler(this.cms_AddItemClicked);
    toolStripMenuItem2.DropDown.ItemClicked += new ToolStripItemClickedEventHandler(this.cms_DeleteItemClicked);
    contextMenuStrip.Items.Add((ToolStripItem) toolStripMenuItem1);
    contextMenuStrip.Items.Add((ToolStripItem) toolStripMenuItem2);
    contextMenuStrip.Show((Control) this.TreeView1, e.Location);
  }

  private void cms_DeleteItemClicked(object sender, ToolStripItemClickedEventArgs e)
  {
    try
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "Delete from tblquoteoptionpremiums where QuoteOptionGuid = @QOG and ChargeCode = @CC", new object[4]
      {
        (object) "@QOG",
        (object) new Guid(this.getQuoteOptionGuidByLOB()),
        (object) "@CC",
        (object) this.getChargeCode(e.ClickedItem.ToString(), this.getStateByLOB())
      });
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("SQL Error In Function cms_DeleteItemClicked. " + ex.ToString());
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("Error In Function cms_DeleteItemClicked. " + ex.ToString());
      ProjectData.ClearProjectError();
    }
    this.ResetCharges();
  }

  private void cms_AddItemClicked(object sender, ToolStripItemClickedEventArgs e)
  {
    try
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblquoteoptionpremiums(QuoteOptionGuid, ChargeCode, OfficeId, Premium, AnnualPremium, Commissionable, added)VALUES(@QuoteOptionGuid, @ChargeCode, @OfficeId, @Premium,@AnnualPremium, @Commissionable, @Added)", new object[14]
      {
        (object) "@QuoteOptionGuid",
        (object) this.getQuoteOptionGuidByLOB(),
        (object) "@ChargeCode",
        (object) this.getChargeCode(e.ClickedItem.ToString(), this.getStateByLOB()),
        (object) "@OfficeId",
        (object) this.getOfficeIdByLOB(),
        (object) "@Premium",
        (object) 0.0,
        (object) "@AnnualPremium",
        (object) 0.0,
        (object) "@Commissionable",
        (object) 1,
        (object) "@Added",
        (object) DateTime.Now
      });
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("SQL Error In Function cms_AddItemClicked. " + ex.ToString());
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("Error In Function cms_AddItemClicked. " + ex.ToString());
      ProjectData.ClearProjectError();
    }
    this.ResetCharges();
  }

  private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
  {
    this.lblNewPremium.Visible = true;
    this.lblTotalPremiumAmount.Visible = true;
    frmNetRatePremiums.MyEnum integer;
    if (Enum.IsDefined(typeof (frmNetRatePremiums.MyEnum), (object) this.TreeView1.SelectedNode.Tag.ToString()))
      integer = (frmNetRatePremiums.MyEnum) Conversions.ToInteger(Enum.Parse(typeof (frmNetRatePremiums.MyEnum), this.TreeView1.SelectedNode.Tag.ToString()));
    if (integer != 0)
      return;
    Guid guid = new Guid(this.TreeView1.SelectedNode.Name.ToString());
    ref Guid local1 = ref guid;
    string str1 = this.StripProperties(this.TreeView1.SelectedNode.Text, 0);
    ref string local2 = ref str1;
    string str2 = this.StripProperties(this.TreeView1.SelectedNode.Text, 1);
    ref string local3 = ref str2;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(this.GetChargeClass(ref local1, ref local2, ref local3).GetChargeType()), "F", false) != 0)
    {
      this._AmountSelected = double.Parse(this.StripProperties(this.TreeView1.SelectedNode.Text, 2));
      this.lblNodeGuid.Text = this.TreeView1.SelectedNode.Name;
      this.lblLOBChosen.Text = this.TreeView1.SelectedNode.Text;
      ((TextEditorControlBase) this.txtPremium).Text = this.StripProperties(this.TreeView1.SelectedNode.Text, 2);
    }
    else
    {
      int num = (int) MessageBox.Show("Fees can not be changed. They will be automatically updated when you save the premium and return to the policy detail page.");
    }
  }

  private string getStateFromTreeNodes()
  {
    string str = "";
    string stateFromTreeNodes;
    try
    {
      foreach (TreeNode node in this.TreeView1.SelectedNode.Nodes)
      {
        string[] strArray = node.Text.ToString().Split('_');
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArray[0], "", false) != 0)
        {
          str = strArray[0];
          stateFromTreeNodes = str;
          goto label_9;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    stateFromTreeNodes = str;
label_9:
    return stateFromTreeNodes;
  }

  private bool checkQuoteIdValidity(string QuoteId) => !new Regex("[a-zA-Z]").IsMatch(QuoteId);

  private string StripProperties(string NodeValue, int ChargeProperty)
  {
    string str = "";
    Array array = (Array) NodeValue.Split(Conversions.ToCharArrayRankOne("_"));
    if (ChargeProperty == 0)
      str = array.GetValue(0).ToString();
    else if (ChargeProperty == 1)
      str = array.GetValue(1).ToString();
    else if (ChargeProperty == 2)
      str = array.GetValue(2).ToString();
    else if (ChargeProperty == 0)
      str = array.GetValue(0).ToString();
    return str;
  }

  private void txtPremium_ValueChanged(object sender, EventArgs e)
  {
    if (!(!string.IsNullOrEmpty(((TextEditorControlBase) this.txtPremium).Text) & !string.IsNullOrEmpty(this.lblLOBChosen.Text)) || this.TreeView1.SelectedNode == null)
      return;
    Guid guid = new Guid(this.TreeView1.SelectedNode.Name.ToString());
    ref Guid local1 = ref guid;
    string str1 = this.StripProperties(this.TreeView1.SelectedNode.Text, 0);
    ref string local2 = ref str1;
    string str2 = this.StripProperties(this.TreeView1.SelectedNode.Text, 1);
    ref string local3 = ref str2;
    ChargeClass chargeClass = this.GetChargeClass(ref local1, ref local2, ref local3);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtPremium).Text, "-", false) == 0 || double.Parse(((TextEditorControlBase) this.txtPremium).Text) == chargeClass.GetPremium())
      return;
    double num = double.Parse(((TextEditorControlBase) this.txtPremium).Text.ToString()) + double.Parse(this.lblTotalPremiumAmount.Text.ToString()) - this._AmountSelected;
    this._AmountSelected = double.Parse(((TextEditorControlBase) this.txtPremium).Text.ToString());
    this.lblTotalPremiumAmount.Text = $"{Conversions.ToDecimal(num.ToString()):f2}";
    this.TreeView1.SelectedNode.Text = $"{this.StripProperties(this.TreeView1.SelectedNode.Text, 0)}_{chargeClass.GetChargeName()}_{((TextEditorControlBase) this.txtPremium).Text}";
    chargeClass.SetPremium(((TextEditorControlBase) this.txtPremium).Text.ToString());
    chargeClass.SetChargeUpdated(true);
  }

  private int getChargeCode(string chargename, string state)
  {
    string str = "Select chargecode from tblfin_policycharges WITH (NOLOCK) where chargename = @CN and stateid = @S";
    int chargeCode;
    try
    {
      chargeCode = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, str, new object[4]
      {
        (object) "@CN",
        (object) chargename,
        (object) "@S",
        (object) state
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("SQL Error In Function getChargeCode. " + ex.ToString());
      ProjectData.ClearProjectError();
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("Error In Function getChargeCode. " + ex.ToString());
      ProjectData.ClearProjectError();
    }
    return chargeCode;
  }

  private List<string> getAllowableChargesToAdd(string state)
  {
    string str = "Select distinct(chargename) from tblfin_policycharges where chargetype <> @CT and stateid = @S";
    DataTable dataTable;
    try
    {
      dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, str, new object[4]
      {
        (object) "@CT",
        (object) "F",
        (object) "@S",
        (object) state
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("SQL Error In Function getAllowableChargesToAdd. " + ex.ToString());
      throw;
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("Error In Function getAllowableChargesToAdd. " + ex.ToString());
      throw;
    }
    List<string> allowableChargesToAdd = new List<string>();
    try
    {
      foreach (DataRow row in dataTable.Rows)
        allowableChargesToAdd.Add(row["chargename"].ToString());
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return allowableChargesToAdd;
  }

  private ChargeClass GetChargeClass(ref Guid guid, ref string state, ref string ChargeName)
  {
    List<ChargeClass> charge = this._Charges[this.TreeView1.SelectedNode.Tag.ToString()];
    ChargeClass chargeClass1 = new ChargeClass();
    try
    {
      foreach (ChargeClass chargeClass2 in charge)
      {
        chargeClass1 = chargeClass2;
        if (chargeClass1.GetQuoteOptionGuid() == guid & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(chargeClass1.GetStateInitials(), state, false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(chargeClass1.GetChargeName(), ChargeName, false) == 0)
          break;
      }
    }
    finally
    {
      List<ChargeClass>.Enumerator enumerator;
      enumerator.Dispose();
    }
    return chargeClass1;
  }

  private string getOfficeIdByLOB()
  {
    List<ChargeClass> charge = this._Charges[this.TreeView1.SelectedNode.Text.ToString()];
    string str = "";
    string officeIdByLob;
    try
    {
      foreach (ChargeClass chargeClass in charge)
      {
        if (!string.IsNullOrEmpty(chargeClass.GetOfficeId().ToString()))
        {
          officeIdByLob = chargeClass.GetOfficeId().ToString();
          goto label_7;
        }
      }
    }
    finally
    {
      List<ChargeClass>.Enumerator enumerator;
      enumerator.Dispose();
    }
    officeIdByLob = str;
label_7:
    return officeIdByLob;
  }

  private string getQuoteOptionGuidByLOB()
  {
    List<ChargeClass> charge = this._Charges[this.TreeView1.SelectedNode.Text.ToString()];
    string str = "";
    string quoteOptionGuidByLob;
    try
    {
      foreach (ChargeClass chargeClass in charge)
      {
        if (!string.IsNullOrEmpty(chargeClass.GetQuoteOptionGuid().ToString()))
        {
          quoteOptionGuidByLob = chargeClass.GetQuoteOptionGuid().ToString();
          goto label_7;
        }
      }
    }
    finally
    {
      List<ChargeClass>.Enumerator enumerator;
      enumerator.Dispose();
    }
    quoteOptionGuidByLob = str;
label_7:
    return quoteOptionGuidByLob;
  }

  private string getStateByLOB()
  {
    List<ChargeClass> charge = this._Charges[this.TreeView1.SelectedNode.Text.ToString()];
    string stateId = this._QuoteObject.StateID;
    string stateByLob;
    try
    {
      foreach (ChargeClass chargeClass in charge)
      {
        if (!string.IsNullOrEmpty(chargeClass.GetStateInitials().ToString()))
        {
          stateByLob = chargeClass.GetStateInitials().ToString();
          goto label_7;
        }
      }
    }
    finally
    {
      List<ChargeClass>.Enumerator enumerator;
      enumerator.Dispose();
    }
    stateByLob = stateId;
label_7:
    return stateByLob;
  }

  private void ViewXML_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    string str = "Select netratexml from tblquotes where quoteguid = @QG";
    DataTable dataTable = (DataTable) null;
    try
    {
      dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, str, new object[2]
      {
        (object) "@QG",
        (object) this._quoteGuid
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) MessageBox.Show("SQL Error In Function getAllowableChargesToAdd. " + ex.ToString());
      ProjectData.ClearProjectError();
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("Error In Function getAllowableChargesToAdd. " + ex.ToString());
      ProjectData.ClearProjectError();
    }
    string empty = string.Empty;
    if (dataTable != null)
    {
      DataRow row = dataTable.Rows[0];
      if (row != null)
        empty = row["netratexml"].ToString();
    }
    if (string.IsNullOrEmpty(empty))
      return;
    SaveFileDialog saveFileDialog = new SaveFileDialog();
    saveFileDialog.Filter = "xml file|*.xml";
    saveFileDialog.Title = "Save Xml File";
    int num1 = (int) saveFileDialog.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(saveFileDialog.FileName, "", false) == 0)
      return;
    XmlDocument xmlDocument = new XmlDocument();
    xmlDocument.LoadXml(empty);
    xmlDocument.Save(saveFileDialog.FileName);
    Process.Start(saveFileDialog.FileName);
  }

  private void DBUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (FormSettings.ShowFormDialog(typeof (frmNetRateDBUpdate), new object[1]
    {
      (object) this._quoteGuid
    }))
      ;
  }

  private void btnCancel_Click_1(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  public enum MyEnum
  {
    Parent = 1,
  }

  public enum NetRateUpdateStatus
  {
    Failed,
    Successful,
  }

  public enum ChargeProperties
  {
    StateId,
    ChargeName,
    Premium,
    ChargeCode,
  }
}
