// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.BindPolicy.frmBinderConfirmation
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Reporting;
using MGASystems.InfragisticsExtensions.Editors;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.BindPolicy;

public class frmBinderConfirmation : Form
{
  private IContainer components;
  private PictureBox PictureBox1;
  private UltraGrid ugInvoices;
  private Label Label2;
  private dsBinderConfirmation ds;
  private Label lblInfo;
  private readonly List<int> _invoiceNumbers;
  private HyperlinkEditor _hlkPrint;
  private HyperlinkEditor _hlkView;
  private HyperlinkEditor _hlkEmail;
  private readonly Quote _quote;
  private bool _painted;
  private static Guid _tmpQuoteGuid;
  private readonly CultureInfo _cultureInfo;

  private virtual LinkLabel lnkContinue
  {
    get => this._lnkContinue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkContinue_LinkClicked);
      LinkLabel lnkContinue1 = this._lnkContinue;
      if (lnkContinue1 != null)
        lnkContinue1.LinkClicked -= clickedEventHandler;
      this._lnkContinue = value;
      LinkLabel lnkContinue2 = this._lnkContinue;
      if (lnkContinue2 == null)
        return;
      lnkContinue2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkPrintAllInvoices
  {
    get => this._lnkPrintAllInvoices;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPrintAllInvoices_LinkClicked);
      LinkLabel printAllInvoices1 = this._lnkPrintAllInvoices;
      if (printAllInvoices1 != null)
        printAllInvoices1.LinkClicked -= clickedEventHandler;
      this._lnkPrintAllInvoices = value;
      LinkLabel printAllInvoices2 = this._lnkPrintAllInvoices;
      if (printAllInvoices2 == null)
        return;
      printAllInvoices2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkEmailAllInvoices
  {
    get => this._lnkEmailAllInvoices;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkEmailAllInvoices_LinkClicked);
      LinkLabel emailAllInvoices1 = this._lnkEmailAllInvoices;
      if (emailAllInvoices1 != null)
        emailAllInvoices1.LinkClicked -= clickedEventHandler;
      this._lnkEmailAllInvoices = value;
      LinkLabel emailAllInvoices2 = this._lnkEmailAllInvoices;
      if (emailAllInvoices2 == null)
        return;
      emailAllInvoices2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBinderConfirmation));
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblFin_Invoices", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("OfficeInvoiceNum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("InvoiceAmount");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("View");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Print");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Email");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    this.PictureBox1 = new PictureBox();
    this.lblInfo = new Label();
    this.ugInvoices = new UltraGrid();
    this.ds = new dsBinderConfirmation();
    this.Label2 = new Label();
    this.lnkContinue = new LinkLabel();
    this.lnkPrintAllInvoices = new LinkLabel();
    this.lnkEmailAllInvoices = new LinkLabel();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.ugInvoices).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(24, 24);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.lblInfo.AutoSize = true;
    this.lblInfo.Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblInfo.Location = new Point(104, 8);
    this.lblInfo.Name = "lblInfo";
    this.lblInfo.Size = new Size(331, 19);
    this.lblInfo.TabIndex = 1;
    this.lblInfo.Text = "Policy #123456 has been successfully bound.";
    ((UltraGridBase) this.ugInvoices).DataSource = (object) this.ds.tblFin_Invoices;
    appearance1.BackColor = Color.White;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Invoice #";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 90;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ultraGridColumn2.Format = "d";
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Due";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 80 /*0x50*/;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ultraGridColumn3.Format = "c";
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Amount";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 94;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Center";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 58;
    appearance3.FontData.UnderlineAsString = "True";
    appearance3.ForeColor = Color.Blue;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Center";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "";
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 60;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 64 /*0x40*/;
    appearance4.FontData.UnderlineAsString = "True";
    appearance4.ForeColor = Color.Blue;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Center";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "";
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 56;
    ultraGridBand.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ultraGridBand.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugInvoices).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance5.BackColor = Color.White;
    appearance5.FontData.BoldAsString = "True";
    appearance5.ForeColor = Color.Gray;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((Control) this.ugInvoices).Location = new Point(104, 64 /*0x40*/);
    ((Control) this.ugInvoices).Name = "ugInvoices";
    ((Control) this.ugInvoices).Size = new Size(438, 120);
    ((Control) this.ugInvoices).TabIndex = 2;
    ((UltraControlBase) this.ugInvoices).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsBinderConfirmation";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(104, 40);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(182, 13);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "The following invoices were created:";
    this.lnkContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkContinue.AutoSize = true;
    this.lnkContinue.Location = new Point(456, 263);
    this.lnkContinue.Name = "lnkContinue";
    this.lnkContinue.Size = new Size(62, 13);
    this.lnkContinue.TabIndex = 4;
    this.lnkContinue.TabStop = true;
    this.lnkContinue.Text = "Continue...";
    this.lnkContinue.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkPrintAllInvoices.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkPrintAllInvoices.AutoSize = true;
    this.lnkPrintAllInvoices.Location = new Point(456, 240 /*0xF0*/);
    this.lnkPrintAllInvoices.Name = "lnkPrintAllInvoices";
    this.lnkPrintAllInvoices.Size = new Size(86, 13);
    this.lnkPrintAllInvoices.TabIndex = 5;
    this.lnkPrintAllInvoices.TabStop = true;
    this.lnkPrintAllInvoices.Text = "Print All Invoices";
    this.lnkPrintAllInvoices.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkEmailAllInvoices.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkEmailAllInvoices.Location = new Point(456, 216);
    this.lnkEmailAllInvoices.Name = "lnkEmailAllInvoices";
    this.lnkEmailAllInvoices.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.lnkEmailAllInvoices.TabIndex = 6;
    this.lnkEmailAllInvoices.TabStop = true;
    this.lnkEmailAllInvoices.Text = "Email All Invoices";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(570, 294);
    this.Controls.Add((Control) this.lnkEmailAllInvoices);
    this.Controls.Add((Control) this.lnkPrintAllInvoices);
    this.Controls.Add((Control) this.lnkContinue);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.lblInfo);
    this.Controls.Add((Control) this.ugInvoices);
    this.Controls.Add((Control) this.PictureBox1);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmBinderConfirmation);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Binder Confirmation";
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.ugInvoices).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmBinderConfirmation(Guid quoteGuid, List<int> invoiceNumbers)
  {
    this.Load += new EventHandler(this.frmBinderConfirmation_Load);
    this.Paint += new PaintEventHandler(this.frmBinderConfirmation_Paint);
    this.Closing += new CancelEventHandler(this.frmBinderConfirmation_Closing);
    this._hlkPrint = new HyperlinkEditor();
    this._hlkView = new HyperlinkEditor();
    this._hlkEmail = new HyperlinkEditor();
    this.InitializeComponent();
    this._invoiceNumbers = invoiceNumbers;
    this._quote = new Quote(quoteGuid);
    frmBinderConfirmation._tmpQuoteGuid = quoteGuid;
    this._cultureInfo = MultiCurrencyUtilities.GetCultureInfo(DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "Select dbo.GetQuoteCurrencyCode(@quoteId)", new object[2]
    {
      (object) "@quoteId",
      (object) this._quote.QuoteID
    }));
  }

  private void frmBinderConfirmation_Load(object sender, EventArgs e)
  {
    this.lblInfo.Text = !this._quote.IsEndorsement ? $"Policy #{this._quote.PolicyNumber} was successfully bound." : "The endorsement was successfully bound.";
    UltraGridBand band = ((UltraGridBase) this.ugInvoices).DisplayLayout.Bands[0];
    band.Columns["Print"].Editor = (EmbeddableEditorBase) this._hlkPrint;
    band.Columns["View"].Editor = (EmbeddableEditorBase) this._hlkView;
    band.Columns["Email"].Editor = (EmbeddableEditorBase) this._hlkEmail;
    this._hlkPrint.HyperLinkOpening += new CancelEventHandler(this.lnkPrint_Click);
    this._hlkView.HyperLinkOpening += new CancelEventHandler(this.lnkView_Click);
    this._hlkEmail.HyperLinkOpening += new CancelEventHandler(this.lnkEmail_Click);
    string str1 = string.Empty;
    try
    {
      foreach (int invoiceNumber in this._invoiceNumbers)
        str1 = $"{str1}{invoiceNumber.ToString()},";
    }
    finally
    {
      List<int>.Enumerator enumerator;
      enumerator.Dispose();
    }
    string str2 = Strings.Left(str1, str1.Length - 1);
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Bands[0].Columns["InvoiceAmount"].FormatInfo = (IFormatProvider) this._cultureInfo;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblFin_Invoices"
    }, "dbo.GetBoundInvoices", new object[2]
    {
      (object) "@invoiceNumbers",
      (object) str2
    });
    this.Show();
  }

  protected virtual string EmailSubjectLine(string policyNum, string insuredPolName)
  {
    return $"Policy #{policyNum} - {insuredPolName}";
  }

  protected virtual void ClickContinueOnClient()
  {
  }

  private static void ViewInvoice(int invoiceNumber)
  {
    ReportFactory.Instance.ShowInvoices(invoiceNumber);
  }

  private void lnkContinue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ClickContinueOnClient();
    this.Close();
  }

  private void lnkPrintAllInvoices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      foreach (int invoiceNumber in this._invoiceNumbers)
        this.PrintInvoice(invoiceNumber);
    }
    finally
    {
      List<int>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.Cursor = MgaCursors.Default;
  }

  private void frmBinderConfirmation_Paint(object sender, PaintEventArgs e)
  {
    if (this._painted)
      return;
    this._painted = true;
    this.Height = ((Control) this.ugInvoices).Height + 150;
  }

  private void lnkPrint_Click(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    this.Cursor = MgaCursors.WaitCursor;
    this.PrintInvoice((int) ((UltraGridBase) this.ugInvoices).ActiveRow.Cells["InvoiceNum"].Value);
    this.Cursor = MgaCursors.Default;
  }

  private void lnkView_Click(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      frmBinderConfirmation.ViewInvoice((int) ((UltraGridBase) this.ugInvoices).ActiveRow.Cells["InvoiceNum"].Value);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void lnkEmail_Click(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    this.Cursor = MgaCursors.WaitCursor;
    this.ClientWorkOnEmailInvoice(false, (UltraGridBase) this.ugInvoices, this.EmailSubjectLine(this._quote.PolicyNumber, this._quote.InsuredPolicyName), this._quote.QuoteGuid);
    this.Cursor = MgaCursors.Default;
  }

  public static void EmailInvoice(
    bool emailAll,
    UltraGridBase ug,
    string emailSubject,
    Guid quoteGuid)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void ClientWorkOnEmailInvoice(
    bool emailAll,
    UltraGridBase ug,
    string emailSubject,
    Guid quoteGuid)
  {
    frmBinderConfirmation.EmailInvoice(emailAll, ug, emailSubject, quoteGuid);
  }

  public virtual void PrintInvoice(int invoiceNumber)
  {
    InvoiceItem[] invoiceItemArray = new InvoiceItem[2];
    ArrayList arrayList1 = new ArrayList();
    ArrayList arrayList2 = new ArrayList();
    arrayList1.AddRange((ICollection) new object[4]
    {
      (object) "MGACopy",
      (object) true,
      (object) "ShowMultipleInvoices",
      (object) true
    });
    this.Cursor = MgaCursors.WaitCursor;
    MDIControls.Instance.StatusBarText = "Printing invoice...";
    invoiceItemArray[0] = new InvoiceItem(invoiceNumber, arrayList1);
    invoiceItemArray[1] = new InvoiceItem(invoiceNumber, arrayList2);
    try
    {
      ReportFactory.Instance.PrintInvoices(invoiceItemArray);
    }
    finally
    {
      MDIControls.Instance.StatusBarText = string.Empty;
      this.Cursor = MgaCursors.Default;
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._hlkPrint != null)
      {
        this._hlkPrint.HyperLinkOpening -= new CancelEventHandler(this.lnkPrint_Click);
        ((DisposableObject) this._hlkPrint).Dispose();
      }
      if (this._hlkView != null)
      {
        this._hlkView.HyperLinkOpening -= new CancelEventHandler(this.lnkPrint_Click);
        ((DisposableObject) this._hlkView).Dispose();
      }
    }
    base.Dispose(disposing);
  }

  private void frmBinderConfirmation_Closing(object sender, CancelEventArgs e)
  {
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmPolicyDetail frmPolicyDetail && frmPolicyDetail.Quote.QuoteGuid.Equals(this._quote.QuoteGuid))
      {
        ((Form) frmPolicyDetail).Activate();
        break;
      }
      checked { ++index; }
    }
  }

  private void lnkEmailAllInvoices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.ugInvoices).Rows.Count <= 0)
      return;
    this.ClientWorkOnEmailInvoice(true, (UltraGridBase) this.ugInvoices, this.EmailSubjectLine(this._quote.PolicyNumber, this._quote.InsuredPolicyName), this._quote.QuoteGuid);
  }
}
