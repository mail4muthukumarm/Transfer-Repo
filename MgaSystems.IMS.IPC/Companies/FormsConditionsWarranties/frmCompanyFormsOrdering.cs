// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.FormsConditionsWarranties.frmCompanyFormsOrdering
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using MGASystems.Tools;
using System;
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies.FormsConditionsWarranties;

public sealed class frmCompanyFormsOrdering : Form
{
  private IContainer components;
  private MGAListBox lstPolicyForms;
  private DbDataAdapter daForms;
  private DbConnection cn;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private Label Label1;
  private dsCompanyFormsOrdering ds;
  private int _companyLineID;
  private bool _isFormOrdering;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnMoveUp
  {
    get => this._btnMoveUp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnMoveUp_Click);
      MGAButton btnMoveUp1 = this._btnMoveUp;
      if (btnMoveUp1 != null)
        ((Control) btnMoveUp1).Click -= eventHandler;
      this._btnMoveUp = value;
      MGAButton btnMoveUp2 = this._btnMoveUp;
      if (btnMoveUp2 == null)
        return;
      ((Control) btnMoveUp2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnMoveDown
  {
    get => this._btnMoveDown;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnMoveDown_Click);
      MGAButton btnMoveDown1 = this._btnMoveDown;
      if (btnMoveDown1 != null)
        ((Control) btnMoveDown1).Click -= eventHandler;
      this._btnMoveDown = value;
      MGAButton btnMoveDown2 = this._btnMoveDown;
      if (btnMoveDown2 == null)
        return;
      ((Control) btnMoveDown2).Click += eventHandler;
    }
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

  internal virtual MGAButton btnMoveTop
  {
    get => this._btnMoveTop;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnMoveTop_Click);
      MGAButton btnMoveTop1 = this._btnMoveTop;
      if (btnMoveTop1 != null)
        ((Control) btnMoveTop1).Click -= eventHandler;
      this._btnMoveTop = value;
      MGAButton btnMoveTop2 = this._btnMoveTop;
      if (btnMoveTop2 == null)
        return;
      ((Control) btnMoveTop2).Click += eventHandler;
    }
  }

  internal virtual MGAButton MgabtnPageUp
  {
    get => this._MgabtnPageUp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MgabtnPageUp_Click);
      MGAButton mgabtnPageUp1 = this._MgabtnPageUp;
      if (mgabtnPageUp1 != null)
        ((Control) mgabtnPageUp1).Click -= eventHandler;
      this._MgabtnPageUp = value;
      MGAButton mgabtnPageUp2 = this._MgabtnPageUp;
      if (mgabtnPageUp2 == null)
        return;
      ((Control) mgabtnPageUp2).Click += eventHandler;
    }
  }

  internal virtual MGAButton MgabtnPageDown
  {
    get => this._MgabtnPageDown;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MgabtnPageDown_Click);
      MGAButton mgabtnPageDown1 = this._MgabtnPageDown;
      if (mgabtnPageDown1 != null)
        ((Control) mgabtnPageDown1).Click -= eventHandler;
      this._MgabtnPageDown = value;
      MGAButton mgabtnPageDown2 = this._MgabtnPageDown;
      if (mgabtnPageDown2 == null)
        return;
      ((Control) mgabtnPageDown2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnMoveBottom
  {
    get => this._btnMoveBottom;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnMoveBottom_Click);
      MGAButton btnMoveBottom1 = this._btnMoveBottom;
      if (btnMoveBottom1 != null)
        ((Control) btnMoveBottom1).Click -= eventHandler;
      this._btnMoveBottom = value;
      MGAButton btnMoveBottom2 = this._btnMoveBottom;
      if (btnMoveBottom2 == null)
        return;
      ((Control) btnMoveBottom2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCompanyFormsOrdering));
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    this.lstPolicyForms = new MGAListBox();
    this.btnMoveUp = new MGAButton();
    this.btnMoveDown = new MGAButton();
    this.btnSave = new MGAButton();
    this.daForms = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.cn = DefaultDatabase.CreateDbConnection();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.Label1 = new Label();
    this.btnMoveTop = new MGAButton();
    this.btnMoveBottom = new MGAButton();
    this.ds = new dsCompanyFormsOrdering();
    this.MgabtnPageUp = new MGAButton();
    this.MgabtnPageDown = new MGAButton();
    ((ISupportInitialize) this.lstPolicyForms).BeginInit();
    ((ISupportInitialize) this.btnMoveUp).BeginInit();
    ((ISupportInitialize) this.btnMoveDown).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnMoveTop).BeginInit();
    ((ISupportInitialize) this.btnMoveBottom).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.MgabtnPageUp).BeginInit();
    ((ISupportInitialize) this.MgabtnPageDown).BeginInit();
    this.SuspendLayout();
    this.lstPolicyForms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstPolicyForms.Location = new Point(8, 32 /*0x20*/);
    this.lstPolicyForms.Name = "lstPolicyForms";
    this.lstPolicyForms.Size = new Size(554, 249);
    this.lstPolicyForms.TabIndex = 0;
    ((Control) this.btnMoveUp).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    ((ControlBase) this.btnMoveUp).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnMoveUp).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((Control) this.btnMoveUp).Location = new Point(568, 74);
    ((Control) this.btnMoveUp).Name = "btnMoveUp";
    ((Control) this.btnMoveUp).Size = new Size(80 /*0x50*/, 23);
    ((Control) this.btnMoveUp).TabIndex = 1;
    ((ControlBase) this.btnMoveUp).Text = "Move Up";
    this.btnMoveUp.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnMoveDown).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    ((ControlBase) this.btnMoveDown).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnMoveDown).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((Control) this.btnMoveDown).Location = new Point(568, 161);
    ((Control) this.btnMoveDown).Name = "btnMoveDown";
    ((Control) this.btnMoveDown).Size = new Size(80 /*0x50*/, 23);
    ((Control) this.btnMoveDown).TabIndex = 2;
    ((ControlBase) this.btnMoveDown).Text = "Move Down";
    this.btnMoveDown.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance3.BackColor = Color.Gainsboro;
    appearance3.BackColor2 = Color.White;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.Gray;
    appearance3.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance3.Image"));
    appearance3.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(618, 263);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 3;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.daForms.DeleteCommand = this.DbDeleteCommand1;
    this.daForms.InsertCommand = this.DbInsertCommand1;
    this.daForms.SelectCommand = this.DbSelectCommand1;
    this.daForms.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyFormsConditionsWarranties", new DataColumnMapping[3]
      {
        new DataColumnMapping("PolicyFormID", "PolicyFormID"),
        new DataColumnMapping("FormOrder", "FormOrder"),
        new DataColumnMapping("Company_FCW_ID", "Company_FCW_ID")
      })
    });
    this.daForms.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = componentResourceManager.GetString("DbDeleteCommand1.CommandText");
    this.DbDeleteCommand1.Connection = this.cn;
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[3]
    {
      DefaultDatabase.CreateParameter("@Original_Company_FCW_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Company_FCW_ID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_FormOrder", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FormOrder", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_PolicyFormID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PolicyFormID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Connection = this.cn;
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@PolicyFormID", SqlDbType.Int, 4, "PolicyFormID"),
      DefaultDatabase.CreateParameter("@FormOrder", SqlDbType.SmallInt, 2, "FormOrder")
    });
    this.DbSelectCommand1.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    this.DbSelectCommand1.Connection = this.cn;
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@companyLineID", SqlDbType.Int, 4, "CompanyLineID")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Connection = this.cn;
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[6]
    {
      DefaultDatabase.CreateParameter("@PolicyFormID", SqlDbType.Int, 4, "PolicyFormID"),
      DefaultDatabase.CreateParameter("@FormOrder", SqlDbType.SmallInt, 2, "FormOrder"),
      DefaultDatabase.CreateParameter("@Original_Company_FCW_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Company_FCW_ID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_FormOrder", SqlDbType.SmallInt, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FormOrder", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_PolicyFormID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "PolicyFormID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Company_FCW_ID", SqlDbType.Int, 4, "Company_FCW_ID")
    });
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(402, 13);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Please select the order in which you would like these forms to appear in the policy:";
    ((Control) this.btnMoveTop).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance4.BackColor = Color.Gainsboro;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.Gray;
    ((ControlBase) this.btnMoveTop).Appearance = (AppearanceBase) appearance4;
    ((ControlBase) this.btnMoveTop).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((Control) this.btnMoveTop).Location = new Point(568, 45);
    ((Control) this.btnMoveTop).Name = "btnMoveTop";
    ((Control) this.btnMoveTop).Size = new Size(80 /*0x50*/, 23);
    ((Control) this.btnMoveTop).TabIndex = 5;
    ((ControlBase) this.btnMoveTop).Text = "Move Top";
    this.btnMoveTop.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnMoveBottom).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance5.BackColor = Color.Gainsboro;
    appearance5.BackColor2 = Color.White;
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.Gray;
    ((ControlBase) this.btnMoveBottom).Appearance = (AppearanceBase) appearance5;
    ((ControlBase) this.btnMoveBottom).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((Control) this.btnMoveBottom).Location = new Point(568, 190);
    ((Control) this.btnMoveBottom).Name = "btnMoveBottom";
    ((Control) this.btnMoveBottom).Size = new Size(80 /*0x50*/, 23);
    ((Control) this.btnMoveBottom).TabIndex = 6;
    ((ControlBase) this.btnMoveBottom).Text = "Move Bottom";
    this.btnMoveBottom.UseOSThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompanyFormsOrdering";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.MgabtnPageUp).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance6.BackColor = Color.Gainsboro;
    appearance6.BackColor2 = Color.White;
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.Gray;
    ((ControlBase) this.MgabtnPageUp).Appearance = (AppearanceBase) appearance6;
    ((ControlBase) this.MgabtnPageUp).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((Control) this.MgabtnPageUp).Location = new Point(568, 103);
    ((Control) this.MgabtnPageUp).Name = "MgabtnPageUp";
    ((Control) this.MgabtnPageUp).Size = new Size(80 /*0x50*/, 23);
    ((Control) this.MgabtnPageUp).TabIndex = 7;
    ((ControlBase) this.MgabtnPageUp).Text = "Page Up 20";
    this.MgabtnPageUp.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.MgabtnPageDown).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance7.BackColor = Color.Gainsboro;
    appearance7.BackColor2 = Color.White;
    appearance7.BackGradientStyle = (GradientStyle) 2;
    appearance7.BorderColor = Color.Gray;
    ((ControlBase) this.MgabtnPageDown).Appearance = (AppearanceBase) appearance7;
    ((ControlBase) this.MgabtnPageDown).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((Control) this.MgabtnPageDown).Location = new Point(568, 219);
    ((Control) this.MgabtnPageDown).Name = "MgabtnPageDown";
    ((Control) this.MgabtnPageDown).Size = new Size(90, 23);
    ((Control) this.MgabtnPageDown).TabIndex = 8;
    ((ControlBase) this.MgabtnPageDown).Text = "Page Down  20";
    this.MgabtnPageDown.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(666, 304);
    this.Controls.Add((Control) this.MgabtnPageDown);
    this.Controls.Add((Control) this.MgabtnPageUp);
    this.Controls.Add((Control) this.btnMoveBottom);
    this.Controls.Add((Control) this.btnMoveTop);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.btnMoveDown);
    this.Controls.Add((Control) this.btnMoveUp);
    this.Controls.Add((Control) this.lstPolicyForms);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmCompanyFormsOrdering);
    this.Text = "Policy Forms - Ordering";
    ((ISupportInitialize) this.lstPolicyForms).EndInit();
    ((ISupportInitialize) this.btnMoveUp).EndInit();
    ((ISupportInitialize) this.btnMoveDown).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnMoveTop).EndInit();
    ((ISupportInitialize) this.btnMoveBottom).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.MgabtnPageUp).EndInit();
    ((ISupportInitialize) this.MgabtnPageDown).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmCompanyFormsOrdering(int companyLineID, bool isFormOrdering)
  {
    this.Load += new EventHandler(this.frmCompanyFormsOrdering_Load);
    this.InitializeComponent();
    this._companyLineID = companyLineID;
    this._isFormOrdering = isFormOrdering;
    this.daForms.UpdateCommand.CommandType = CommandType.StoredProcedure;
    this.daForms.UpdateCommand.CommandText = "dbo.spUpdateFCWOrdering";
    DbParameterCollectionExtensions.DerivedAdd(this.daForms.UpdateCommand.Parameters, "@IsFormOrdering", SqlDbType.Bit);
    DbParameterCollectionExtensions.DerivedAdd(this.daForms.UpdateCommand.Parameters, "@ConditionOrder", SqlDbType.SmallInt);
    DbParameterCollectionExtensions.DerivedAdd(this.daForms.UpdateCommand.Parameters, "@Original_ConditionOrder", SqlDbType.SmallInt);
    DbParameterCollectionExtensions.DerivedAdd(this.daForms.UpdateCommand.Parameters, "@OriginalConditionID", SqlDbType.Int);
    this.daForms.UpdateCommand.Parameters["@IsFormOrdering"].Value = (object) this._isFormOrdering;
    this.daForms.UpdateCommand.Parameters["@ConditionOrder"].SourceColumn = "ConditionOrder";
    this.daForms.UpdateCommand.Parameters["@ConditionOrder"].SourceVersion = DataRowVersion.Current;
    this.daForms.UpdateCommand.Parameters["@Original_ConditionOrder"].SourceColumn = "ConditionOrder";
    this.daForms.UpdateCommand.Parameters["@Original_ConditionOrder"].SourceVersion = DataRowVersion.Original;
    this.daForms.UpdateCommand.Parameters["@OriginalConditionID"].SourceColumn = "ConditionID";
    this.daForms.UpdateCommand.Parameters["@OriginalConditionID"].SourceVersion = DataRowVersion.Original;
    if (this._isFormOrdering)
      return;
    this.Text = "Conditions - Ordering";
  }

  private void frmCompanyFormsOrdering_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataTable((DataTable) this.ds.tblCompanyFormsConditionsWarranties, CommandType.StoredProcedure, "GetFCWOrdering", new object[4]
    {
      (object) "@companyLineID",
      (object) this._companyLineID,
      (object) "@IsFormOrdering",
      (object) this._isFormOrdering
    });
    this.lstPolicyForms.DrawMode = DrawMode.OwnerDrawFixed;
    this.lstPolicyForms.DrawItem += new DrawItemEventHandler(this.lstPolicyForms_DrawItem);
    try
    {
      foreach (dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow conditionsWarranty in (TypedTableBase<dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow>) this.ds.tblCompanyFormsConditionsWarranties)
      {
        int sortOrder = this.lstPolicyForms.Items.Count + 1;
        this.lstPolicyForms.Items.Add(!this._isFormOrdering ? (object) new frmCompanyFormsOrdering.FormItem(conditionsWarranty.Company_FCW_ID, conditionsWarranty.Condition, sortOrder) : (object) new frmCompanyFormsOrdering.FormItem(conditionsWarranty.Company_FCW_ID, $"{conditionsWarranty.FormNumber} - {conditionsWarranty.FormName}", sortOrder));
        this.lstPolicyForms.Refresh();
      }
    }
    finally
    {
      IEnumerator<dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private bool FormDisabled(
    dsCompanyFormsOrdering.tblCompanyFormsConditionsWarrantiesRow row)
  {
    return !row.IsDisabledNull() && (CurrentUser.ServerTime - row.Disabled).Days > 0;
  }

  private void lstPolicyForms_DrawItem(object sender, DrawItemEventArgs e)
  {
    bool flag = false;
    if (this.lstPolicyForms.Items[e.Index] != null)
      flag = this.FormDisabled(this.ds.tblCompanyFormsConditionsWarranties.FindByCompany_FCW_ID(((frmCompanyFormsOrdering.FormItem) this.lstPolicyForms.Items[e.Index]).Company_FCW_ID));
    e.DrawBackground();
    Font font1 = e.Font;
    using (SolidBrush solidBrush = new SolidBrush(e.ForeColor))
    {
      if (!flag)
      {
        e.Graphics.DrawString(this.lstPolicyForms.GetItemText(RuntimeHelpers.GetObjectValue(this.lstPolicyForms.Items[e.Index])), font1, (Brush) solidBrush, (RectangleF) e.Bounds);
      }
      else
      {
        Font font2 = new Font(font1.FontFamily, font1.Size, FontStyle.Strikeout);
        e.Graphics.DrawString(this.lstPolicyForms.GetItemText(RuntimeHelpers.GetObjectValue(this.lstPolicyForms.Items[e.Index])), font2, Brushes.Red, (RectangleF) e.Bounds);
      }
    }
    e.DrawFocusRectangle();
  }

  private void btnMoveUp_Click(object sender, EventArgs e)
  {
    if (this.lstPolicyForms.SelectedItems.Count == 0 || this.lstPolicyForms.SelectedIndex == 0)
      return;
    this.MoveUp(1);
  }

  private void MoveUp(int i)
  {
    frmCompanyFormsOrdering.FormItem selectedItem = (frmCompanyFormsOrdering.FormItem) this.lstPolicyForms.SelectedItem;
    int selectedIndex = this.lstPolicyForms.SelectedIndex;
    if (selectedIndex - i < 0)
      return;
    this.lstPolicyForms.Items.Remove(RuntimeHelpers.GetObjectValue(this.lstPolicyForms.SelectedItem));
    this.lstPolicyForms.Items.Insert(selectedIndex - i, (object) selectedItem);
    this.RefreshItemOrder();
    this.lstPolicyForms.SelectedItem = RuntimeHelpers.GetObjectValue(this.lstPolicyForms.Items[selectedIndex - i]);
  }

  private void MoveDown(int i)
  {
    frmCompanyFormsOrdering.FormItem selectedItem = (frmCompanyFormsOrdering.FormItem) this.lstPolicyForms.SelectedItem;
    int selectedIndex = this.lstPolicyForms.SelectedIndex;
    if (this.lstPolicyForms.Items.Count - selectedIndex < i)
      return;
    this.lstPolicyForms.Items.Remove(RuntimeHelpers.GetObjectValue(this.lstPolicyForms.SelectedItem));
    this.lstPolicyForms.Items.Insert(selectedIndex + i, (object) selectedItem);
    this.RefreshItemOrder();
    this.lstPolicyForms.SelectedItem = RuntimeHelpers.GetObjectValue(this.lstPolicyForms.Items[selectedIndex + i]);
  }

  private void btnMoveDown_Click(object sender, EventArgs e)
  {
    if (this.lstPolicyForms.SelectedItems.Count == 0 || this.lstPolicyForms.SelectedIndex == this.lstPolicyForms.Items.Count - 1)
      return;
    this.MoveDown(1);
  }

  private void RefreshItemOrder()
  {
    int num = this.lstPolicyForms.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      ((frmCompanyFormsOrdering.FormItem) this.lstPolicyForms.Items[index]).SortOrder = index + 1;
      this.lstPolicyForms.Items[index] = RuntimeHelpers.GetObjectValue(this.lstPolicyForms.Items[index]);
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      if (this._isFormOrdering)
      {
        int count = this.lstPolicyForms.Items.Count;
        for (int index = 1; index <= count; ++index)
          this.ds.tblCompanyFormsConditionsWarranties.FindByCompany_FCW_ID(((frmCompanyFormsOrdering.FormItem) this.lstPolicyForms.Items[index - 1]).Company_FCW_ID).FormOrder = index;
      }
      else
      {
        int count = this.lstPolicyForms.Items.Count;
        for (int index = 1; index <= count; ++index)
          this.ds.tblCompanyFormsConditionsWarranties.FindByCompany_FCW_ID(((frmCompanyFormsOrdering.FormItem) this.lstPolicyForms.Items[index - 1]).Company_FCW_ID).ConditionOrder = index;
      }
      DefaultDatabase.DataAdapterUpdate(this.daForms, (DataTable) this.ds.tblCompanyFormsConditionsWarranties);
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
      this.Close();
    }
  }

  private void btnMoveTop_Click(object sender, EventArgs e)
  {
    if (this.lstPolicyForms.SelectedItems.Count == 0 || this.lstPolicyForms.SelectedIndex == 0)
      return;
    frmCompanyFormsOrdering.FormItem selectedItem = (frmCompanyFormsOrdering.FormItem) this.lstPolicyForms.SelectedItem;
    int selectedIndex = this.lstPolicyForms.SelectedIndex;
    this.lstPolicyForms.Items.Remove(RuntimeHelpers.GetObjectValue(this.lstPolicyForms.SelectedItem));
    this.lstPolicyForms.Items.Insert(0, (object) selectedItem);
    this.RefreshItemOrder();
    this.lstPolicyForms.SelectedItem = RuntimeHelpers.GetObjectValue(this.lstPolicyForms.Items[0]);
  }

  private void btnMoveBottom_Click(object sender, EventArgs e)
  {
    if (this.lstPolicyForms.SelectedItems.Count == 0 || this.lstPolicyForms.SelectedIndex == this.lstPolicyForms.Items.Count - 1)
      return;
    frmCompanyFormsOrdering.FormItem selectedItem = (frmCompanyFormsOrdering.FormItem) this.lstPolicyForms.SelectedItem;
    int selectedIndex = this.lstPolicyForms.SelectedIndex;
    this.lstPolicyForms.Items.Remove(RuntimeHelpers.GetObjectValue(this.lstPolicyForms.SelectedItem));
    this.lstPolicyForms.Items.Insert(this.lstPolicyForms.Items.Count, (object) selectedItem);
    this.RefreshItemOrder();
    this.lstPolicyForms.SelectedItem = RuntimeHelpers.GetObjectValue(this.lstPolicyForms.Items[this.lstPolicyForms.Items.Count - 1]);
  }

  private void MgabtnPageUp_Click(object sender, EventArgs e)
  {
    if (this.lstPolicyForms.SelectedItems.Count == 0 || this.lstPolicyForms.SelectedIndex == 0)
      return;
    this.MoveUp(20);
  }

  private void MgabtnPageDown_Click(object sender, EventArgs e)
  {
    if (this.lstPolicyForms.SelectedItems.Count == 0 || this.lstPolicyForms.SelectedIndex == this.lstPolicyForms.Items.Count - 1)
      return;
    this.MoveDown(20);
  }

  private class FormItem
  {
    private int _company_FCW_ID;
    private string _display;
    private int _sortOrder;

    public FormItem(int company_FCW_ID, string display, int sortOrder)
    {
      this._display = display;
      this._company_FCW_ID = company_FCW_ID;
      this._sortOrder = sortOrder;
    }

    public int SortOrder
    {
      get => this._sortOrder;
      set => this._sortOrder = value;
    }

    public string Display => $"{this.SortOrder.ToString()} - {this._display}";

    public int Company_FCW_ID => this._company_FCW_ID;

    public override string ToString() => this.Display;
  }
}
