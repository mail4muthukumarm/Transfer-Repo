// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmGenericReportPresets
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinTabControl;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Forms;

public sealed class frmGenericReportPresets : Form
{
  private IContainer components;
  private ErrorProvider err;
  private const string InsertSQL = "INSERT INTO tblReportPresets ([UserGUID],[ReportGUID],[PresetDesc],[PresetXML]) VALUES (@userGUID,@rptGUID,@desc,@pres)";
  private const string SelectSQL = "SELECT presetID,UserGUID,ReportGUID,PresetDesc,PresetXML FROM tblReportPresets WHERE UserGUID= @userGUID and ReportGUID = @rptGUID";
  private const string GetPresetSQL = "SELECT PresetXML FROM tblReportPresets WHERE presetID=@presetID";
  private const string IsPresetUniqueSQL = "SELECT presetID FROM tblReportPresets WHERE Ltrim(Rtrim(PresetDesc))=@presetDESC and UserGUID= @userGUID and ReportGUID = @rptGUID";
  private const string DeletePresetSQL = "DELETE FROM tblReportPresets WHERE presetID=@presetID";
  private readonly string _displayName;
  private Guid _GUID;
  private ArrayList _ControlValues;
  private readonly string _DefaultTab;
  private bool _Cancel;
  private string _exitMode;
  internal const string UserCanSavePresetsForAll = "{6896B473-A5CA-41EC-B918-E2803EEE011E}";

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("MgaTabSave")]
  internal virtual MGATab MgaTabSave { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  internal virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  internal virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnCancelSave
  {
    get => this._btnCancelSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Cancel_Click);
      MGAButton btnCancelSave1 = this._btnCancelSave;
      if (btnCancelSave1 != null)
        ((Control) btnCancelSave1).Click -= eventHandler;
      this._btnCancelSave = value;
      MGAButton btnCancelSave2 = this._btnCancelSave;
      if (btnCancelSave2 == null)
        return;
      ((Control) btnCancelSave2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnSave
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

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  internal virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDesc")]
  internal virtual MGATextBox txtDesc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbPresets")]
  internal virtual MGASimpleComboBox cbPresets { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnCancelLoad
  {
    get => this._btnCancelLoad;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Cancel_Click);
      MGAButton btnCancelLoad1 = this._btnCancelLoad;
      if (btnCancelLoad1 != null)
        ((Control) btnCancelLoad1).Click -= eventHandler;
      this._btnCancelLoad = value;
      MGAButton btnCancelLoad2 = this._btnCancelLoad;
      if (btnCancelLoad2 == null)
        return;
      ((Control) btnCancelLoad2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnLoad
  {
    get => this._btnLoad;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnLoad_Click);
      MGAButton btnLoad1 = this._btnLoad;
      if (btnLoad1 != null)
        ((Control) btnLoad1).Click -= eventHandler;
      this._btnLoad = value;
      MGAButton btnLoad2 = this._btnLoad;
      if (btnLoad2 == null)
        return;
      ((Control) btnLoad2).Click += eventHandler;
    }
  }

  internal virtual PictureBox picDeletePreset
  {
    get => this._picDeletePreset;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.picDeletePreset_Click);
      PictureBox picDeletePreset1 = this._picDeletePreset;
      if (picDeletePreset1 != null)
        picDeletePreset1.Click -= eventHandler;
      this._picDeletePreset = value;
      PictureBox picDeletePreset2 = this._picDeletePreset;
      if (picDeletePreset2 == null)
        return;
      picDeletePreset2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ToolTip1")]
  internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DeletePreset")]
  internal virtual PictureBox DeletePreset { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmGenericReportPresets));
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.txtDesc = new MGATextBox();
    this.btnCancelSave = new MGAButton();
    this.btnSave = new MGAButton();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.cbPresets = new MGASimpleComboBox();
    this.btnCancelLoad = new MGAButton();
    this.btnLoad = new MGAButton();
    this.err = new ErrorProvider(this.components);
    this.MgaTabSave = new MGATab();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.picDeletePreset = new PictureBox();
    this.ToolTip1 = new ToolTip(this.components);
    this.DeletePreset = new PictureBox();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.txtDesc).BeginInit();
    ((ISupportInitialize) this.btnCancelSave).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.cbPresets).BeginInit();
    ((ISupportInitialize) this.btnCancelLoad).BeginInit();
    ((ISupportInitialize) this.btnLoad).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.MgaTabSave).BeginInit();
    ((Control) this.MgaTabSave).SuspendLayout();
    ((ISupportInitialize) this.picDeletePreset).BeginInit();
    ((ISupportInitialize) this.DeletePreset).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtDesc);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnCancelSave);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnSave);
    ((Control) this.UltraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(295, 131);
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDesc).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtDesc).BackColor = Color.White;
    ((Control) this.txtDesc).Location = new Point(12, 24);
    ((TextEditorControlBase) this.txtDesc).MaxLength = 500;
    ((Control) this.txtDesc).Name = "txtDesc";
    ((Control) this.txtDesc).Size = new Size(272, 20);
    ((Control) this.txtDesc).TabIndex = 0;
    ((UltraControlBase) this.txtDesc).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDesc).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancelSave).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnCancelSave).Location = new Point(206, 90);
    ((Control) this.btnCancelSave).Name = "btnCancelSave";
    ((Control) this.btnCancelSave).Size = new Size(78, 29);
    ((Control) this.btnCancelSave).TabIndex = 1;
    ((ControlBase) this.btnCancelSave).Text = "Cancel";
    this.btnCancelSave.UseOSThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnSave).Location = new Point(103, 90);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(78, 29);
    ((Control) this.btnSave).TabIndex = 0;
    ((ControlBase) this.btnSave).Text = "Save";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.picDeletePreset);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.cbPresets);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.btnCancelLoad);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.btnLoad);
    ((Control) this.UltraTabPageControl2).Location = new Point(1, 20);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(295, 131);
    this.cbPresets.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbPresets).Location = new Point(12, 24);
    ((Control) this.cbPresets).Name = "cbPresets";
    ((Control) this.cbPresets).Size = new Size(262, 21);
    ((Control) this.cbPresets).TabIndex = 4;
    ((UltraControlBase) this.cbPresets).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbPresets).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancelLoad).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnCancelLoad).Location = new Point(206, 90);
    ((Control) this.btnCancelLoad).Name = "btnCancelLoad";
    ((Control) this.btnCancelLoad).Size = new Size(78, 29);
    ((Control) this.btnCancelLoad).TabIndex = 3;
    ((ControlBase) this.btnCancelLoad).Text = "Cancel";
    this.btnCancelLoad.UseOSThemes = (DefaultableBoolean) 2;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    appearance5.ImageHAlign = (HAlign) 2;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnLoad).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnLoad).Location = new Point(103, 90);
    ((Control) this.btnLoad).Name = "btnLoad";
    ((Control) this.btnLoad).Size = new Size(78, 29);
    ((Control) this.btnLoad).TabIndex = 2;
    ((ControlBase) this.btnLoad).Text = "Load";
    this.btnLoad.UseOSThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    appearance6.BackColor = Color.Gainsboro;
    ((UltraTabControlBase) this.MgaTabSave).Appearance = (AppearanceBase) appearance6;
    ((Control) this.MgaTabSave).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.MgaTabSave).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.MgaTabSave).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.MgaTabSave).Dock = DockStyle.Fill;
    ((Control) this.MgaTabSave).Location = new Point(0, 0);
    ((Control) this.MgaTabSave).Name = "MgaTabSave";
    appearance7.BackColor = Color.WhiteSmoke;
    appearance7.BorderColor = Color.Gray;
    ((UltraTabControlBase) this.MgaTabSave).SelectedTabAppearance = (AppearanceBase) appearance7;
    ((UltraTabControlBase) this.MgaTabSave).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.MgaTabSave).Size = new Size(297, 152);
    ((UltraTabControlBase) this.MgaTabSave).Style = (UltraTabControlStyle) 12;
    ((Control) this.MgaTabSave).TabIndex = 0;
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Save Preset";
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Load Preset";
    ((UltraTabControlBase) this.MgaTabSave).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraControlBase) this.MgaTabSave).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTabSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(295, 131);
    this.picDeletePreset.ErrorImage = (Image) null;
    this.picDeletePreset.Image = (Image) MGASystems.IMS.Forms.My.Resources.Resources.delete;
    this.picDeletePreset.InitialImage = (Image) null;
    this.picDeletePreset.Location = new Point(276, 26);
    this.picDeletePreset.Name = "picDeletePreset";
    this.picDeletePreset.Size = new Size(17, 18);
    this.picDeletePreset.TabIndex = 5;
    this.picDeletePreset.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.picDeletePreset, "Delete preset");
    this.DeletePreset.ErrorImage = (Image) null;
    this.DeletePreset.Image = (Image) MGASystems.IMS.Forms.My.Resources.Resources.delete;
    this.DeletePreset.InitialImage = (Image) null;
    this.DeletePreset.Location = new Point(276, 26);
    this.DeletePreset.Name = "DeletePreset";
    this.DeletePreset.Size = new Size(17, 18);
    this.DeletePreset.TabIndex = 5;
    this.DeletePreset.TabStop = false;
    this.ToolTip1.SetToolTip((Control) this.DeletePreset, "Delete preset");
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(297, 152);
    this.Controls.Add((Control) this.MgaTabSave);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (frmGenericReportPresets);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "[Launch Form]";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.txtDesc).EndInit();
    ((ISupportInitialize) this.btnCancelSave).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.cbPresets).EndInit();
    ((ISupportInitialize) this.btnCancelLoad).EndInit();
    ((ISupportInitialize) this.btnLoad).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.MgaTabSave).EndInit();
    ((Control) this.MgaTabSave).ResumeLayout(false);
    ((ISupportInitialize) this.picDeletePreset).EndInit();
    ((ISupportInitialize) this.DeletePreset).EndInit();
    this.ResumeLayout(false);
  }

  public frmGenericReportPresets(
    string displayName,
    Guid ReportGUID,
    ArrayList ControlValues,
    string DefaultTab)
  {
    this.Activated += new EventHandler(this.frmGenericReportPresets_Activated);
    this._GUID = Guid.Empty;
    this._Cancel = true;
    this.InitializeComponent();
    this._displayName = displayName;
    this._GUID = ReportGUID;
    this._ControlValues = ControlValues;
    this._DefaultTab = DefaultTab;
    this.Text = this._displayName + " presets";
  }

  private void CloseMe() => this.Close();

  private string SerializeArrayList(ArrayList obj)
  {
    XmlDocument xmlDocument = new XmlDocument();
    Type[] typeArray = new Type[1];
    XmlSerializer xmlSerializer = new XmlSerializer(typeof (ArrayList), "report");
    MemoryStream inStream = new MemoryStream();
    try
    {
      xmlSerializer.Serialize((Stream) inStream, (object) obj);
      inStream.Position = 0L;
      xmlDocument.Load((Stream) inStream);
      return xmlDocument.InnerXml;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw;
    }
    finally
    {
      inStream.Close();
      inStream.Dispose();
    }
  }

  private ArrayList DeSerializeArrayList(string serializedData)
  {
    ArrayList arrayList = new ArrayList();
    Type[] typeArray = new Type[1];
    XmlSerializer xmlSerializer = new XmlSerializer(typeof (ArrayList), "report");
    XmlReader xmlReader = XmlReader.Create((TextReader) new StringReader(serializedData));
    try
    {
      return (ArrayList) RuntimeHelpers.GetObjectValue(xmlSerializer.Deserialize(xmlReader));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw;
    }
    finally
    {
      xmlReader.Close();
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this.err.Clear();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtDesc).Text, "", false) == 0)
    {
      this.err.SetError((Control) this.txtDesc, "Description cannot be empty");
    }
    else
    {
      Guid userGuid = CurrentUser.Instance.UserGUID;
      string str = this.SerializeArrayList(this._ControlValues);
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT presetID FROM tblReportPresets WHERE Ltrim(Rtrim(PresetDesc))=@presetDESC and UserGUID= @userGUID and ReportGUID = @rptGUID", new object[6]
      {
        (object) "@presetDESC",
        (object) Strings.UCase(Strings.Trim(((TextEditorControlBase) this.txtDesc).Text)),
        (object) "@userGUID",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@rptGUID",
        (object) this._GUID
      }));
      if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) && !Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue)))
      {
        if (MessageBox.Show("Preset with the same name exists. Do you want to overwrite it?", "Preset exists", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
          return;
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblReportPresets WHERE presetID=@presetID", new object[2]
        {
          (object) "@presetID",
          (object) (int) objectValue
        });
      }
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblReportPresets ([UserGUID],[ReportGUID],[PresetDesc],[PresetXML]) VALUES (@userGUID,@rptGUID,@desc,@pres)", new object[8]
      {
        (object) "@userGUID",
        (object) userGuid,
        (object) "@rptGUID",
        (object) this._GUID,
        (object) "@desc",
        (object) ((TextEditorControlBase) this.txtDesc).Text.Replace("'", "''"),
        (object) "@pres",
        (object) str
      });
      this._Cancel = false;
      this._exitMode = "SAVE";
      this.CloseMe();
    }
  }

  private void frmGenericReportPresets_Activated(object sender, EventArgs e)
  {
    ((UltraGridBase) this.cbPresets).DataSource = (object) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT presetID,UserGUID,ReportGUID,PresetDesc,PresetXML FROM tblReportPresets WHERE UserGUID= @userGUID and ReportGUID = @rptGUID", new object[4]
    {
      (object) "@userGUID",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@rptGUID",
      (object) this._GUID
    });
    ((UltraDropDownBase) this.cbPresets).DisplayMember = "PresetDesc";
    ((UltraDropDownBase) this.cbPresets).ValueMember = "presetID";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._DefaultTab, "SAVE", false) == 0)
    {
      ((UltraTabControlBase) this.MgaTabSave).Tabs[0].Active = true;
      ((UltraTabControlBase) this.MgaTabSave).Tabs[0].Selected = true;
      ((TextEditorControlBase) this.txtDesc).Focus();
    }
    else
    {
      ((UltraTabControlBase) this.MgaTabSave).Tabs[1].Active = true;
      ((UltraTabControlBase) this.MgaTabSave).Tabs[1].Selected = true;
    }
  }

  private void Cancel_Click(object sender, EventArgs e)
  {
    this._Cancel = true;
    this.CloseMe();
  }

  private void btnLoad_Click(object sender, EventArgs e)
  {
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.cbPresets.Value)) & !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.cbPresets.Value)))
    {
      this._ControlValues = this.DeSerializeArrayList(DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT PresetXML FROM tblReportPresets WHERE presetID=@presetID", new object[2]
      {
        (object) "@presetID",
        (object) Conversions.ToInteger(this.cbPresets.Value)
      }));
      this._Cancel = false;
      this._exitMode = "LOAD";
      this.CloseMe();
    }
    else
    {
      int num = (int) MessageBox.Show("Please select preset", "Preset not selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void picDeletePreset_Click(object sender, EventArgs e)
  {
    int integer = Conversions.ToInteger(this.cbPresets.Value);
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.cbPresets.Value)) & !Information.IsNothing(RuntimeHelpers.GetObjectValue(this.cbPresets.Value)))
    {
      if (MessageBox.Show($"Are you sure you want to delete preset '{this.cbPresets.Text}'?", "Delete Preset", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblReportPresets WHERE presetID=@presetID", new object[2]
      {
        (object) "@presetID",
        (object) integer
      });
      ((UltraGridBase) this.cbPresets).DataSource = (object) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT presetID,UserGUID,ReportGUID,PresetDesc,PresetXML FROM tblReportPresets WHERE UserGUID= @userGUID and ReportGUID = @rptGUID", new object[4]
      {
        (object) "@userGUID",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@rptGUID",
        (object) this._GUID
      });
      ((UltraDropDownBase) this.cbPresets).DisplayMember = "PresetDesc";
      ((UltraDropDownBase) this.cbPresets).ValueMember = "presetID";
    }
    else
    {
      int num = (int) MessageBox.Show("Please select preset", "Preset not selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  public ArrayList ReportPresets
  {
    get => this._ControlValues;
    set => this._ControlValues = value;
  }

  public bool FormCancel => this._Cancel;

  public string FormExitMode => this._exitMode;
}
