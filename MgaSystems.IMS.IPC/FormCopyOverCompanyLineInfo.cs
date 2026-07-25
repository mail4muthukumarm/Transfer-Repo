// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormCopyOverCompanyLineInfo
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormCopyOverCompanyLineInfo : Form
{
  private IContainer components;
  private readonly CompanyLine _cl;
  private Guid _currentLineGuid;

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
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormCopyOverCompanyLineInfo));
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CopyOver", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.lblCompany = new Label();
    this.btnCopy = new MGAButton();
    this.errProv = new ErrorProvider(this.components);
    this.lblCompanyAddress = new Label();
    this.lblLine = new Label();
    this.lblState = new Label();
    this.UltraGroupBox1 = new UltraGroupBox();
    this.ugLine = new UltraGrid();
    this.cboState = new MGASimpleComboBox();
    this.ds = new dsCopyOverCompanyLines();
    this.cboCompany = new MGASimpleComboBox();
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    ((ISupportInitialize) this.btnCopy).BeginInit();
    ((ISupportInitialize) this.errProv).BeginInit();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.ugLine).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboCompany).BeginInit();
    this.SuspendLayout();
    label1.AutoSize = true;
    label1.Location = new Point(9, 156);
    label1.Name = "Label1";
    label1.Size = new Size(56, 13);
    label1.TabIndex = 2;
    label1.Text = "Company:";
    label1.TextAlign = ContentAlignment.MiddleLeft;
    label2.AutoSize = true;
    label2.Location = new Point(9, 189);
    label2.Name = "Label3";
    label2.Size = new Size(37, 13);
    label2.TabIndex = 10;
    label2.Text = "State:";
    label2.TextAlign = ContentAlignment.MiddleLeft;
    this.lblCompany.AutoSize = true;
    this.lblCompany.Location = new Point(5, 27);
    this.lblCompany.Name = "lblCompany";
    this.lblCompany.Size = new Size(81, 13);
    this.lblCompany.TabIndex = 3;
    this.lblCompany.Text = "lblCompanyLine";
    ((Control) this.btnCopy).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    ((ControlBase) this.btnCopy).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnCopy).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCopy).Location = new Point(327, 544);
    ((Control) this.btnCopy).Name = "btnCopy";
    ((ControlBase) this.btnCopy).Padding = new Size(5, 0);
    ((Control) this.btnCopy).Size = new Size(74, 25);
    ((Control) this.btnCopy).TabIndex = 442;
    ((Control) this.btnCopy).Tag = (object) "";
    ((ControlBase) this.btnCopy).Text = "Copy";
    this.btnCopy.UseOSThemes = (DefaultableBoolean) 2;
    this.errProv.ContainerControl = (ContainerControl) this;
    this.lblCompanyAddress.AutoSize = true;
    this.lblCompanyAddress.Location = new Point(5, 49);
    this.lblCompanyAddress.Name = "lblCompanyAddress";
    this.lblCompanyAddress.Size = new Size(101, 13);
    this.lblCompanyAddress.TabIndex = 443;
    this.lblCompanyAddress.Text = "lblCompanyAddress";
    this.lblLine.AutoSize = true;
    this.lblLine.Location = new Point(5, 71);
    this.lblLine.Name = "lblLine";
    this.lblLine.Size = new Size(36, 13);
    this.lblLine.TabIndex = 444;
    this.lblLine.Text = "lblLine";
    this.lblState.AutoSize = true;
    this.lblState.Location = new Point(5, 93);
    this.lblState.Name = "lblState";
    this.lblState.Size = new Size(43, 13);
    this.lblState.TabIndex = 445;
    this.lblState.Text = "lblState";
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.lblCompanyAddress);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.lblState);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.lblCompany);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.lblLine);
    ((Control) this.UltraGroupBox1).Location = new Point(12, 12);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(389, 118);
    ((Control) this.UltraGroupBox1).TabIndex = 446;
    this.UltraGroupBox1.Text = "Current Company / Line Info";
    this.UltraGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.ugLine).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugLine).DataMember = "lstLines";
    ((UltraGridBase) this.ugLine).DataSource = (object) this.ds;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugLine).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ugLine).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 185;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Line Name";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 277;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Copy";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 53;
    ultraGridBand.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.ugLine).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugLine).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance3.BackColor = Color.LightSteelBlue;
    appearance3.FontData.SizeInPoints = 10f;
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLine).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLine).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugLine).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLine).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugLine).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugLine).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugLine).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugLine).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLine).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugLine).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLine).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugLine).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ugLine).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugLine).Location = new Point(69, 218);
    ((Control) this.ugLine).Name = "ugLine";
    ((Control) this.ugLine).Size = new Size(332, 309);
    ((Control) this.ugLine).TabIndex = 447;
    ((UltraControlBase) this.ugLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugLine).UseOsThemes = (DefaultableBoolean) 2;
    label3.AutoSize = true;
    label3.Location = new Point(9, 218);
    label3.Name = "Label2";
    label3.Size = new Size(35, 13);
    label3.TabIndex = 448;
    label3.Text = "Lines:";
    label3.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.cboState).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboState).DataMember = "lstStates";
    ((UltraGridBase) this.cboState).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboState).DropDownWidth = 200;
    ((Control) this.cboState).Location = new Point(69, 185);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(332, 21);
    ((Control) this.cboState).TabIndex = 8;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    this.ds.DataSetName = "dsCopyOverCompanyLines";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.cboCompany).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.cboCompany.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboCompany).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.cboCompany).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboCompany).DisplayMember = "LocationName";
    this.cboCompany.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCompany).DropDownWidth = 500;
    ((Control) this.cboCompany).Location = new Point(69, 152);
    this.cboCompany.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompany).Name = "cboCompany";
    ((Control) this.cboCompany).Size = new Size(332, 21);
    ((Control) this.cboCompany).TabIndex = 1;
    ((UltraControlBase) this.cboCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompany).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompany).ValueMember = "CompanyLocationGUID";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(424, 581);
    this.Controls.Add((Control) label3);
    this.Controls.Add((Control) this.ugLine);
    this.Controls.Add((Control) this.UltraGroupBox1);
    this.Controls.Add((Control) this.btnCopy);
    this.Controls.Add((Control) label2);
    this.Controls.Add((Control) this.cboState);
    this.Controls.Add((Control) label1);
    this.Controls.Add((Control) this.cboCompany);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormCopyOverCompanyLineInfo);
    this.Text = "Copy Over Company / Line Info";
    ((ISupportInitialize) this.btnCopy).EndInit();
    ((ISupportInitialize) this.errProv).EndInit();
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    ((Control) this.UltraGroupBox1).PerformLayout();
    ((ISupportInitialize) this.ugLine).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboCompany).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("cboCompany")]
  private virtual MGASimpleComboBox cboCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCompany")]
  internal virtual Label lblCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCopyOverCompanyLines ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboState")]
  private virtual MGASimpleComboBox cboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnCopy
  {
    get => this._btnCopy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCopy_Click);
      MGAButton btnCopy1 = this._btnCopy;
      if (btnCopy1 != null)
        ((Control) btnCopy1).Click -= eventHandler;
      this._btnCopy = value;
      MGAButton btnCopy2 = this._btnCopy;
      if (btnCopy2 == null)
        return;
      ((Control) btnCopy2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("errProv")]
  protected virtual ErrorProvider errProv { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox1")]
  internal virtual UltraGroupBox UltraGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCompanyAddress")]
  internal virtual Label lblCompanyAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblState")]
  internal virtual Label lblState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLine")]
  internal virtual Label lblLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugLine")]
  private virtual UltraGrid ugLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormCopyOverCompanyLineInfo(Guid companyLineGuid)
  {
    this.Load += new EventHandler(this.FormCopyOverCompanyLineInfo_Load);
    this._currentLineGuid = Guid.Empty;
    this.InitializeComponent();
    this._cl = new CompanyLine(companyLineGuid);
  }

  public Guid CurrentLineGuid => this._currentLineGuid;

  private void FormCopyOverCompanyLineInfo_Load(object sender, EventArgs e)
  {
    this.lblCompany.Text = "Current Company: " + this._cl.CompanyLocation.LocationName;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ISNULL(Address1 + @s, @e) + City + @s + State AS Address FROM tblCompanyLocations WITH (NOLOCK) WHERE CompanyLocationGUID = @CLG", new object[6]
    {
      (object) "@CLG",
      (object) this._cl.CompanyLocationGuid,
      (object) "@s",
      (object) ", ",
      (object) "@e",
      (object) ""
    }));
    this.lblCompanyAddress.Text = Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? string.Empty : "Address: " + objectValue.ToString();
    this.lblLine.Text = "Line: " + this._cl.LineName;
    this.lblState.Text = "State: " + this._cl.StateID;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[3]
    {
      "lstLines",
      "lstStates",
      "tblCompanyLocations"
    }, "spGetCompanyLineDataToCopy");
  }

  private bool ValidateCompanyLine()
  {
    bool flag1 = true;
    this.errProv.SetError((Control) this.ugLine, string.Empty);
    this.errProv.SetError((Control) this.cboCompany, string.Empty);
    this.errProv.SetError((Control) this.cboState, string.Empty);
    if (string.IsNullOrEmpty(this.cboCompany.Text))
    {
      this.errProv.SetError((Control) this.cboCompany, "Please select a value");
      flag1 = false;
    }
    if (this.ds.lstLines.Select("CopyOver=1").Length == 0)
    {
      this.errProv.SetError((Control) this.ugLine, "Please select a line");
      flag1 = false;
    }
    if (string.IsNullOrEmpty(this.cboState.Text))
    {
      this.errProv.SetError((Control) this.cboState, "Please select a value");
      flag1 = false;
    }
    bool flag2;
    if (flag1)
    {
      if (!this._cl.IsParentLine)
      {
        int num = (int) MessageBox.Show("Copy / Creation of Company / Lines is only done on parent lines.", "Copy / Create From Parent Company / Line Only", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag2 = false;
        goto label_19;
      }
      if (this.ds.lstLines.Select($"CopyOver=1 AND LineGuid='{this._cl.LineGuid.ToString()}'").Length > 0 && this._cl.CompanyLocationGuid.ToString().Equals(((Guid) this.cboCompany.Value).ToString()) && this._cl.StateID.ToString().Equals(this.cboState.Value.ToString()))
      {
        int num = (int) MessageBox.Show("Cannot create and copy company / line data to current company / line", "Current Company / Line / Combination Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag2 = false;
        goto label_19;
      }
      StringBuilder stringBuilder = new StringBuilder();
      int num1 = 0;
      foreach (UltraGridRow row in ((UltraGridBase) this.ugLine).Rows)
      {
        if (row.Cells["CopyOver"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["CopyOver"].Value))
        {
          if (DefaultDatabase.ExecuteScalar<bool>("spCompanyLineExists", new object[6]
          {
            (object) "@CompanyLocationGuid",
            this.cboCompany.Value,
            (object) "@LineGuid",
            row.Cells["LineGuid"].Value,
            (object) "@StateID",
            this.cboState.Value
          }))
          {
            stringBuilder.AppendLine(row.Cells["LineName"].Value.ToString());
            ++num1;
            if (num1 > 3)
              break;
          }
        }
      }
      if (num1 > 0)
      {
        int num2 = (int) MessageBox.Show("Please recheck existing selections.\n\nThe selected company and state and the following LOB combinations already exist ... \n\n" + stringBuilder.ToString(), "Company / Line Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag2 = false;
        goto label_19;
      }
    }
    flag2 = flag1;
label_19:
    return flag2;
  }

  private void btnCopy_Click(object sender, EventArgs e)
  {
    if (!this.ValidateCompanyLine())
      return;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
    {
      // ISSUE: unable to decompile the method.
    }));
    this.Close();
  }

  protected virtual void CopyOverClientData(SqlTransaction trans, Guid newCompanyLineGuid)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    FormCopyOverCompanyLineInfo._Closure\u0024__55\u002D0 closure550 = new FormCopyOverCompanyLineInfo._Closure\u0024__55\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure550.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure550.\u0024VB\u0024Local_newCompanyLineGuid = newCompanyLineGuid;
    // ISSUE: reference to a compiler-generated field
    closure550.\u0024VB\u0024Local_tmpStoredProcName = string.Empty;
    if (SystemSettings.KeyExists("StoredProcForCompanyLineCopyToNewSetup"))
    {
      // ISSUE: reference to a compiler-generated field
      closure550.\u0024VB\u0024Local_tmpStoredProcName = SystemSettings.GetStringSetting("StoredProcForCompanyLineCopyToNewSetup");
    }
    // ISSUE: reference to a compiler-generated field
    if (closure550.\u0024VB\u0024Local_tmpStoredProcName.Equals(string.Empty))
      return;
    // ISSUE: method pointer
    DefaultDatabase.EnlistTransaction((DbTransaction) trans, new ExecuteHandler((object) closure550, __methodptr(_Lambda\u0024__R1)));
  }

  private bool CopyOnClient(Guid newCompanyLineGuid, string storedProcName)
  {
    bool flag;
    if (this.CurrentLineGuid.Equals(Guid.Empty))
    {
      flag = false;
    }
    else
    {
      DefaultDatabase.ExecuteNonQuery(storedProcName, new object[8]
      {
        (object) "@companyLineGuid",
        (object) this._cl.CompanyLineGuid,
        (object) "@stateID",
        this.cboState.Value,
        (object) "@lineGuid",
        (object) this.CurrentLineGuid,
        (object) "@newCompanyLineGuid",
        (object) newCompanyLineGuid
      });
      flag = true;
    }
    return flag;
  }
}
