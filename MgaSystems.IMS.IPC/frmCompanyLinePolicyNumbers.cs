// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.frmCompanyLinePolicyNumbers
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
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

public class frmCompanyLinePolicyNumbers : Form
{
  private IContainer components;
  private readonly int _companyLineID;
  private readonly Guid _companyLineGuid;
  private Dictionary<int, string> _deleteRows;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual UltraGrid UltraGrid1
  {
    get => this._UltraGrid1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.UltraGrid1_AfterRowInsert);
      CellEventHandler cellEventHandler = new CellEventHandler(this.UltraGrid1_CellChange);
      BeforeRowsDeletedEventHandler deletedEventHandler = new BeforeRowsDeletedEventHandler(this.UltraGrid1_BeforeRowsDeleted);
      UltraGrid ultraGrid1_1 = this._UltraGrid1;
      if (ultraGrid1_1 != null)
      {
        ultraGrid1_1.AfterRowInsert -= rowEventHandler;
        ultraGrid1_1.CellChange -= cellEventHandler;
        ultraGrid1_1.BeforeRowsDeleted -= deletedEventHandler;
      }
      this._UltraGrid1 = value;
      UltraGrid ultraGrid1_2 = this._UltraGrid1;
      if (ultraGrid1_2 == null)
        return;
      ultraGrid1_2.AfterRowInsert += rowEventHandler;
      ultraGrid1_2.CellChange += cellEventHandler;
      ultraGrid1_2.BeforeRowsDeleted += deletedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCompanyLinePolicyNumbers ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnSave
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

  [field: AccessedThroughProperty("ddRules")]
  internal virtual UltraDropDown ddRules { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblPolicyNumberRules", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("RuleID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("RuleName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("tblPolicyNumberRulestblCompanyLinePolicyNumbers");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblPolicyNumberRulestblCompanyLinePolicyNumbers", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("PolicyNumberRuleID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("StoredProcedureName");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ID");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblCompanyLinePolicyNumbers", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("PolicyNumberRuleID", -1, (object) "ddRules");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("StoredProcedureName");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ID");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance13 = new Appearance();
    this.ddRules = new UltraDropDown();
    this.ds = new dsCompanyLinePolicyNumbers();
    this.UltraGrid1 = new UltraGrid();
    this.btnSave = new MGAButton();
    ((ISupportInitialize) this.ddRules).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.ddRules).DataSource = (object) this.ds.tblPolicyNumberRules;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ddRules).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ddRules).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand1.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Rule";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 422;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 4;
    ultraGridBand2.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.ddRules).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ddRules).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddRules).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddRules).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddRules).DisplayMember = "RuleName";
    ((Control) this.ddRules).Location = new Point(125, 165);
    ((Control) this.ddRules).Name = "ddRules";
    ((Control) this.ddRules).Size = new Size(424, 80 /*0x50*/);
    ((Control) this.ddRules).TabIndex = 1;
    ((UltraControlBase) this.ddRules).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddRules).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddRules).ValueMember = "RuleID";
    ((Control) this.ddRules).Visible = false;
    this.ds.DataSetName = "dsCompanyLinePolicyNumbers";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.UltraGrid1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds.tblCompanyLinePolicyNumbers;
    appearance2.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.WhiteSmoke;
    appearance3.BorderColor = Color.WhiteSmoke;
    appearance3.FontData.UnderlineAsString = "True";
    appearance3.ForeColor = Color.Blue;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Hidden = false;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.AddButtonCaption = "New Policy Numbering Setup";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 0;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 185;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Policy Numbering Rule";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 1;
    ultraGridColumn10.Style = (ColumnStyle) 6;
    ultraGridColumn10.Width = 600;
    ultraGridColumn11.Format = "d";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 2;
    ultraGridColumn11.Width = 167;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Stored Proc Name";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 3;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 222;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 4;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 54;
    ultraGridBand3.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13
    });
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = Color.LightSteelBlue;
    appearance5.FontData.SizeInPoints = 10f;
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.WhiteSmoke;
    appearance11.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectorAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.Transparent;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.UltraGrid1).Location = new Point(-3, 1);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(788, 338);
    ((Control) this.UltraGrid1).TabIndex = 0;
    this.UltraGrid1.UpdateMode = (UpdateMode) 4;
    ((UltraControlBase) this.UltraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance13.BackColor = Color.FromArgb(248, 248, 248);
    appearance13.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance13.BackGradientStyle = (GradientStyle) 2;
    appearance13.BorderColor = Color.DarkGray;
    appearance13.ImageHAlign = (HAlign) 2;
    appearance13.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance13;
    ((Control) this.btnSave).Location = new Point(372, 348);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 2;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(783, 400);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.ddRules);
    this.Controls.Add((Control) this.UltraGrid1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmCompanyLinePolicyNumbers);
    this.Text = "Policy Number Rule Assignment";
    ((ISupportInitialize) this.ddRules).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ResumeLayout(false);
  }

  public frmCompanyLinePolicyNumbers(int companyLineID)
  {
    this.Load += new EventHandler(this.frmCompanyLinePolicyNumbers_Load);
    this._deleteRows = new Dictionary<int, string>();
    this.InitializeComponent();
    this._companyLineID = companyLineID;
    this._companyLineGuid = new CompanyLine(companyLineID).CompanyLineGuid;
  }

  private void frmCompanyLinePolicyNumbers_Load(object sender, EventArgs e)
  {
    MGAButton btnSave = this.btnSave;
    ((ControlBase) btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) btnSave).Appearance.ImageHAlign = (HAlign) 2;
    ((ControlBase) btnSave).Appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) btnSave).ImageTransparentColor = Color.Magenta;
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("CompanyLine.PolicyNumbers.ShowStoredProcColumn"))
      ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["StoredProcedureName"].Hidden = false;
    else
      this.Width -= 60;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblPolicyNumberRules"
    }, CommandType.Text, "SELECT RuleID, RuleName FROM tblPolicyNumberRules WITH (NOLOCK) ORDER BY RuleName");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblCompanyLinePolicyNumbers"
    }, CommandType.Text, "SELECT CompanyLineID, PolicyNumberRuleID, Effective, StoredProcedureName, ID FROM tblCompanyLinePolicyNumbers WITH (NOLOCK) WHERE (CompanyLineID = @companyLineID) ORDER BY Effective DESC", new object[2]
    {
      (object) "@companyLineID",
      (object) this._companyLineID
    });
  }

  private void UltraGrid1_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["CompanyLineID"].Value = (object) this._companyLineID;
    e.Row.Cells["StoredProcedureName"].Value = (object) DBNull.Value;
  }

  private void UltraGrid1_CellChange(object sender, CellEventArgs e)
  {
    try
    {
      if (e.Cell.Row.Cells["PolicyNumberRuleID"].Value == DBNull.Value || e.Cell.Row.Cells["Effective"].Value == DBNull.Value || e.Cell.Row.Cells["StoredProcedureName"].Value == DBNull.Value)
        return;
      e.Cell.Row.Update();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (!ex.Message.Contains("Value in the editor is not valid"))
        throw;
      ProjectData.ClearProjectError();
    }
  }

  protected void LogChanges(
    string dtTableName,
    string strAction,
    int identifierID,
    string strcontext)
  {
    DataTable table = this.ds.Tables[dtTableName];
    DataRow[] dataRowArray1 = table.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent);
    string str1 = strAction;
    DataRow[] dataRowArray2 = dataRowArray1;
    int index1 = 0;
    while (index1 < dataRowArray2.Length)
    {
      DataRow dataRow = dataRowArray2[index1];
      string str2 = "";
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
        {
          string Left = dataRow[column, DataRowVersion.Original].ToString();
          string Right = dataRow[column, DataRowVersion.Current].ToString();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Right, false) != 0)
            str2 = $"{str2} Original {column.Caption}: {Left} was changed to: {Right}";
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{str1} User updated record. {str2}", identifierID, strcontext);
      checked { ++index1; }
    }
    DataRow[] dataRowArray3 = table.Select((string) null, (string) null, DataViewRowState.Added);
    int index2 = 0;
    while (index2 < dataRowArray3.Length)
    {
      DataRow dataRow = dataRowArray3[index2];
      string str3 = "";
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
          str3 = $"{str3}  {column.Caption}: {dataRow[column, DataRowVersion.Current].ToString()}";
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{str1} User inserted record. {str3}", identifierID, strcontext);
      checked { ++index2; }
    }
    try
    {
      foreach (KeyValuePair<int, string> deleteRow in this._deleteRows)
        CurrentUser.Instance.LogAction($"{deleteRow.Value}", this._companyLineGuid);
    }
    finally
    {
      Dictionary<int, string>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void SaveCompanyLinePolicyNumbers()
  {
    using (DbDataAdapter dbDataAdapter = DefaultDatabase.BuildDataAdapter((DataTable) this.ds.tblCompanyLinePolicyNumbers, "dbo.CompanyLinePolicyNumbersInsert", "dbo.CompanyLinePolicyNumbersUpdate", "dbo.CompanyLinePolicyNumbersDelete", true, 30, (DbTransaction) null))
      DefaultDatabase.DataAdapterUpdate(dbDataAdapter, (DataTable) this.ds.tblCompanyLinePolicyNumbers);
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    ((UltraGridBase) this.UltraGrid1).UpdateData();
    try
    {
      this.SaveCompanyLinePolicyNumbers();
      this.LogChanges("tblCompanyLinePolicyNumbers", $"The company line policy number setups was modified. {Conversions.ToString(this._companyLineID)} . ", this._companyLineID, "Company/Line");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (!ex.Message.Contains("Value in the editor is not valid"))
        throw;
      ProjectData.ClearProjectError();
    }
    finally
    {
      this._deleteRows.Clear();
    }
    this.Close();
  }

  private void UltraGrid1_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
  {
    e.DisplayPromptMsg = false;
    if (MessageBox.Show($"Deleting {e.Rows.Length} row(s). Do you wish to Continue ?", "Delete rows?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
    {
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      UltraGridRow[] rows = e.Rows;
      int index = 0;
      while (index < rows.Length)
      {
        UltraGridRow ultraGridRow = rows[index];
        if (!this._deleteRows.ContainsKey((int) ultraGridRow.Cells["ID"].Value) && !Utility.IsNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["PolicyNumberRuleID"].Value)))
        {
          dsCompanyLinePolicyNumbers.tblPolicyNumberRulesRow byRuleId = this.ds.tblPolicyNumberRules.FindByRuleID((short) ultraGridRow.Cells["PolicyNumberRuleID"].Value);
          string str = string.Empty;
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["Effective"].Value)))
            str = ((DateTime) ultraGridRow.Cells["Effective"].Value).ToShortDateString();
          this._deleteRows.Add((int) ultraGridRow.Cells["ID"].Value, $"Deleted '{byRuleId.RuleName}' with effective date of {str}");
        }
        checked { ++index; }
      }
    }
  }
}
