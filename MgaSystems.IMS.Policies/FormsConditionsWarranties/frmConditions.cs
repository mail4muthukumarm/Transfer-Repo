// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormsConditionsWarranties.frmConditions
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.FormsConditionsWarranties;

[SecureResource("{B731F4DD-F449-4831-AFD4-7ADFCE099BE8}", "Access Conditions Screen", "Controls access to Conditions Screen.", "Policies")]
public sealed class frmConditions : Form
{
  private IContainer components;
  private DbDataAdapter da;
  private dsConditions ds;
  private DbCommand DbDeleteCommand1;
  public const string canViewConditionsForm = "{B731F4DD-F449-4831-AFD4-7ADFCE099BE8}";

  public frmConditions()
  {
    this.Closing += new CancelEventHandler(this.frmConditions_Closing);
    this.Load += new EventHandler(this.frmConditions_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid ug
  {
    get => this._ug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.ug_BeforeRowUpdate);
      UltraGrid ug1 = this._ug;
      if (ug1 != null)
        ug1.BeforeRowUpdate -= cancelableRowEventHandler;
      this._ug = value;
      UltraGrid ug2 = this._ug;
      if (ug2 == null)
        return;
      ug2.BeforeRowUpdate += cancelableRowEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblConditions", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ConditionID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Condition", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    this.ug = new UltraGrid();
    this.ds = new dsConditions();
    this.da = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    DbCommand command1 = DefaultDatabase.CreateCommand();
    DbCommand command2 = DefaultDatabase.CreateCommand();
    DbCommand command3 = DefaultDatabase.CreateCommand();
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    command1.CommandText = "INSERT INTO dbo.tblConditions (Condition) VALUES (@Condition)";
    command1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Condition", SqlDbType.VarChar, 1000, "Condition")
    });
    command2.CommandText = "SELECT ConditionID, Condition FROM dbo.tblConditions ORDER BY Condition";
    command3.CommandText = "UPDATE dbo.tblConditions SET Condition = @Condition WHERE (ConditionID = @Original_ConditionID)";
    command3.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@Condition", SqlDbType.VarChar, 1000, "Condition"),
      DefaultDatabase.CreateParameter("@Original_ConditionID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ConditionID", DataRowVersion.Original, (object) null)
    });
    ((UltraGridBase) this.ug).DataSource = (object) this.ds.tblConditions;
    appearance1.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.WhiteSmoke;
    appearance2.BorderColor = Color.WhiteSmoke;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.ug).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.ug).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.AddButtonCaption = "Click here to add a new condition ...";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 189;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 419;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ultraGridBand.Override.FilterUIType = (FilterUIType) 2;
    ultraGridBand.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.WhiteSmoke;
    appearance10.BorderColor = Color.Silver;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectorAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.Transparent;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.WhiteSmoke;
    appearance12.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ug).Dock = DockStyle.Fill;
    ((Control) this.ug).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ug).Location = new Point(0, 0);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(440, 398);
    ((Control) this.ug).TabIndex = 0;
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsConditions";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.da.DeleteCommand = this.DbDeleteCommand1;
    this.da.InsertCommand = command1;
    this.da.SelectCommand = command2;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblConditions", new DataColumnMapping[2]
      {
        new DataColumnMapping("ConditionID", "ConditionID"),
        new DataColumnMapping("Condition", "Condition")
      })
    });
    this.da.UpdateCommand = command3;
    this.DbDeleteCommand1.CommandText = "DELETE FROM dbo.tblConditions WHERE (ConditionID = @Original_ConditionID)";
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_ConditionID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ConditionID", DataRowVersion.Original, (object) null)
    });
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(440, 398);
    this.Controls.Add((Control) this.ug);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmConditions);
    this.Text = "Conditions Administration";
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  private void frmConditions_Closing(object sender, CancelEventArgs e)
  {
    this.ug.PerformAction((UltraGridAction) 44);
    if (((UltraGridBase) this.ug).ActiveRow != null)
      ((UltraGridBase) this.ug).ActiveRow.Update();
    ((UltraGridBase) this.ug).UpdateData();
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      this.LogChanges((DataSet) this.ds, this.ds.tblConditions.TableName, "Modify Conditions Administration menu:  The condition(s). ", "conditionId", "conditionId");
      DefaultDatabase.DataAdapterUpdate(this.da, (DataTable) this.ds.tblConditions);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      if (MessageBox.Show("An error has occured.\n\nWould you like to close the form anyway?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
        e.Cancel = true;
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void frmConditions_Load(object sender, EventArgs e)
  {
    Utility.SetDataAdapterConnections(this.da, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    DefaultDatabase.DataAdapterFill(this.da, (DataTable) this.ds.tblConditions);
  }

  private void ug_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (!(e.Row.Cells[1].Value == DBNull.Value | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Row.Cells[1].Value.ToString(), string.Empty, false) == 0))
      return;
    int num = (int) MessageBox.Show("Missing Condition Name", "Condition name can't be blank", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    ((CancelEventArgs) e).Cancel = true;
  }

  protected void LogChanges(
    DataSet ds,
    string dtTableName,
    string strAction,
    string strIDtoLog,
    string strcontext)
  {
    DataTable table = ds.Tables[dtTableName];
    DataRow[] dataRowArray1 = table.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent);
    int index1 = 0;
    while (index1 < dataRowArray1.Length)
    {
      DataRow dataRow = dataRowArray1[index1];
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
        {
          string Left = dataRow[column, DataRowVersion.Original].ToString();
          string Right = dataRow[column, DataRowVersion.Current].ToString();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Right, false) != 0)
            strAction = $"{strAction} Original {column.Caption}: {Left} was changed to: {Right}";
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{strAction} for {strcontext}: {dataRow[strcontext].ToString()}", Guid.Empty, $"{strcontext}: {dataRow[strcontext].ToString()}");
      checked { ++index1; }
    }
    DataRow[] dataRowArray2 = table.Select((string) null, (string) null, DataViewRowState.Added);
    int index2 = 0;
    while (index2 < dataRowArray2.Length)
    {
      DataRow dataRow = dataRowArray2[index2];
      string str = "";
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
          str = $"{str}  {column.Caption}: {dataRow[column, DataRowVersion.Current].ToString()}";
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{strAction} User inserted new record. {str}", Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow[strIDtoLog])), $"{strcontext}: {dataRow[strcontext].ToString()}");
      checked { ++index2; }
    }
    DataRow[] dataRowArray3 = table.Select((string) null, (string) null, DataViewRowState.Deleted);
    int index3 = 0;
    while (index3 < dataRowArray3.Length)
    {
      DataRow dataRow = dataRowArray3[index3];
      string str = "";
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
          str = $"{str} {column.Caption}: {dataRow[column, DataRowVersion.Original].ToString()}";
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{strAction} User deleted the record. {str}");
      checked { ++index3; }
    }
  }
}
