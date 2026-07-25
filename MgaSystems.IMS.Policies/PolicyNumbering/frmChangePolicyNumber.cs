// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyNumbering.frmChangePolicyNumber
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessageEvents;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.Policies.Clearance;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyNumbering;

[SecureResource("{2BC29C5E-81A3-426a-8112-D90F821B340E}", "Allow Duplicate Policy Numbers", "Allows a user to create multiple policies with the same policy number.", "Policy")]
public sealed class frmChangePolicyNumber : Form
{
  internal const string AllowDuplicatePolicyNumbers = "{2BC29C5E-81A3-426a-8112-D90F821B340E}";
  private IContainer components;
  private Label Label1;
  private Label Label2;
  private MGATextBox txtPolNum;
  private MGAButton btnCancel;
  private Guid _quoteGuid;
  private string _previousPolicyNumber;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.txtPolNum = new MGATextBox();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    ((ISupportInitialize) this.txtPolNum).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    this.Label1.Location = new Point(7, 7);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(434, 21);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "This will permanently change the policy number, and will not create an endorsement.";
    this.Label2.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(7, 35);
    this.Label2.Name = "Label2";
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Policy Number:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPolNum).Appearance = (AppearanceBase) appearance1;
    ((Control) this.txtPolNum).Location = new Point(112 /*0x70*/, 35);
    this.txtPolNum.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtPolNum).Name = "txtPolNum";
    ((Control) this.txtPolNum).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.txtPolNum).TabIndex = 2;
    appearance2.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(350, 35);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).TabIndex = 3;
    appearance3.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(399, 35);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).TabIndex = 4;
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(449, 80 /*0x50*/);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.txtPolNum);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmChangePolicyNumber);
    this.ShowInTaskbar = false;
    this.Text = "Change Policy Number";
    ((ISupportInitialize) this.txtPolNum).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
  }

  public frmChangePolicyNumber(Guid QuoteGuid)
  {
    this.Load += new EventHandler(this.frmChangePolicyNumber_Load);
    this._previousPolicyNumber = string.Empty;
    this.InitializeComponent();
    this._quoteGuid = QuoteGuid;
  }

  private void frmChangePolicyNumber_Load(object sender, EventArgs e)
  {
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) instance.Undo;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT PolicyNumber FROM tblQuotes WHERE QuoteGuid=@QG", new object[2]
    {
      (object) "@QG",
      (object) this._quoteGuid
    }));
    if (objectValue == DBNull.Value || objectValue == null)
      return;
    ((TextEditorControlBase) this.txtPolNum).Text = (string) objectValue;
    this._previousPolicyNumber = (string) objectValue;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!frmChangePolicyNumber.DuplicatePolicyNumberCheck(new Quote(this._quoteGuid), ((TextEditorControlBase) this.txtPolNum).Text))
      return;
    DefaultDatabase.ExecuteNonQuery("spChangePolicyNumber", new object[4]
    {
      (object) "@PolicyNumber",
      (object) ((TextEditorControlBase) this.txtPolNum).Text,
      (object) "@QuoteGuid",
      (object) this._quoteGuid
    });
    CurrentUser.Instance.LogAction($"Changed policy number {this._previousPolicyNumber} to {((TextEditorControlBase) this.txtPolNum).Text}", this._quoteGuid);
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmClearance frmClearance)
        frmClearance.UpdatePolicyNumber(this._quoteGuid, ((TextEditorControlBase) this.txtPolNum).Text);
      checked { ++index; }
    }
    this.Close();
    Messaging.SendBroadcastMessage(BroadcastMessages.PolicyNumberChanged, (object) new PolicyNumberChangedEventArgs(this._quoteGuid, this._previousPolicyNumber, ((TextEditorControlBase) this.txtPolNum).Text));
  }

  public static bool DuplicatePolicyNumberCheck(Quote q, string policyNumber)
  {
    if (q == null)
      throw new ArgumentNullException(nameof (q));
    bool flag;
    if (q.PolicyType == 3 && q.CompanyLine.KeepPolicyNumberOnRewrites)
    {
      flag = true;
    }
    else
    {
      if (q.CompanyLine.EnforceUniquePolicyNumbers)
      {
        object obj = (object) DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT TOP 1 QuoteID FROM dbo.tblQuotes WITH(NOLOCK) WHERE PolicyNumber=@PN AND ControlNo <> @CN ORDER BY QuoteID DESC", new object[4]
        {
          (object) "@PN",
          (object) policyNumber,
          (object) "@CN",
          (object) q.ControlNo
        });
        if (Utility.IsNull(RuntimeHelpers.GetObjectValue(obj)) && SystemSettings.GetSetting<bool>("PolicyNumber.CheckChildForUniqueness", false))
          obj = (object) DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT TOP 1 q.QuoteID FROM dbo.tblQuotes q WITH(NOLOCK) INNER JOIN tblQuoteDetails qd WITH (NOLOCK) ON qd.QuoteGuid = q.QuoteGuid WHERE qd.PolicyNumber = @PN AND q.ControlNo <> @CN ORDER BY QuoteID DESC", new object[4]
          {
            (object) "@PN",
            (object) policyNumber,
            (object) "@CN",
            (object) q.ControlNo
          });
        if (obj != null)
        {
          Guid quoteGuid = q.QuoteGuid;
          int controlNo = q.ControlNo;
          DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT Q.ControlNo, Q.InsuredPolicyName, S.Description FROM tblQuotes Q INNER JOIN lstQuoteStatus S ON Q.QuoteStatusID = S.QuoteStatusID WHERE Q.QuoteID = @QID", new object[2]
          {
            (object) "@QID",
            obj
          });
          if (CompanyDocumentAutomation.BlackBoxMode)
            throw new InvalidOperationException($"The policy number attempting to be assigned to this policy {policyNumber} has been applied to one or more other policies.{"\n"}{"\n"}" + $"Control #: {RuntimeHelpers.GetObjectValue(dataRow[0])}; Insured: {RuntimeHelpers.GetObjectValue(dataRow[1])}; Status: {RuntimeHelpers.GetObjectValue(dataRow[2])}");
          if (SecurityManager.Instance.AssertPermission("{2BC29C5E-81A3-426a-8112-D90F821B340E}"))
          {
            if (MessageBox.Show($"The policy number attempting to be assigned to this policy ({policyNumber}) has been applied to one or more other policies.\n\nControl #: {dataRow[0].ToString()}\nInsured: {dataRow[1].ToString()}\nStatus: {dataRow[2].ToString()}\n\nAre you sure you want to use this policy number?", "Potential Duplicate Policy Number", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
              flag = false;
              goto label_16;
            }
            CurrentUser.Instance.LogAction($"Accepted duplicate policy number warning ( {policyNumber} ) on control # {controlNo}.");
            CurrentUser.Instance.LogAction($"Accepted duplicate policy number warning ( {policyNumber} ) on control # {controlNo}.", quoteGuid);
          }
          else
          {
            int num = (int) MessageBox.Show($"The policy number attempting to be assigned to this policy ({policyNumber}) has been applied to one or more other policies.\n\nControl #: {dataRow[0].ToString()}\nInsured: {dataRow[1].ToString()}\nStatus: {dataRow[2].ToString()}\n\nDuplicate Policy Numbers Are Not Allowed.", "Potential Duplicate Policy Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            CurrentUser.Instance.LogAction($"Attempted to create a duplicate policy number ( {policyNumber} on control # {controlNo}.");
            CurrentUser.Instance.LogAction($"Attempted to create a duplicate policy number ( {policyNumber} on control # {controlNo}.", quoteGuid);
            flag = false;
            goto label_16;
          }
        }
      }
      flag = true;
    }
label_16:
    return flag;
  }
}
