// Decompiled with JetBrains decompiler
// Type: Logging.Administration.TroubleshootingAdminWindow
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Logging;
using MGASystems.IMS.Logging.Administration;
using MGASystems.IMS.Logging.TraceListeners;
using MGASystems.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Logging.Administration;

public class TroubleshootingAdminWindow : Form
{
  private TextBoxTraceListener _textBoxTraceListener;
  private const int automationGroupPolicy = 0;
  private const int automationGroupPolicyQuote = 1;
  private const int automationGroupInsured = 2;
  private const int automationGroupSubmission = 3;
  private const int automationGroupInvoice = 4;
  private const int automationGroupAdditional = 5;
  private const int automationGroupOther = 6;
  private IContainer components;
  private LinkLabel LinkLabel2;
  private LinkLabel lnkClearLog;
  private LinkLabel lnkExportToFile;
  internal ComboBox cboAutomationGroup;
  internal Label Label7;
  internal TextBox txtTagResult;
  internal TextBox txtControlNo;
  internal CheckBox chkShowDetail;
  internal Button btnResolvePolicyTag;
  internal TextBox txtTagName;
  internal TabPage TabPage4;
  internal Button Button1;
  internal TextBox ObjFacTypeOut;
  internal Label Label9;
  internal TextBox ObjFacTypeIn;
  internal Label Label8;
  internal Label Label6;
  internal TextBox liveLogTextBox;
  internal TabPage TabPage1;
  private Label label5;
  private Label label3;
  internal TabPage TabPage2;
  internal TabControl TabControl1;
  internal TabPage TabPage3;
  private Label label2;
  private Label label1;
  private Label label4;
  private LinkLabel linkLabel1;
  private MGAButton btnApply;
  private MGAButton btnOk;
  private MGAButton btnCancel;
  private MGAListBox lstCategories;
  private MGAListBox lstDestinations;
  private Label label10;
  private ComboBox cboAITypes;
  private Label label11;
  internal TextBox txtTemplateGroupID;

  public TroubleshootingAdminWindow() => this.InitializeComponent();

  private void btnOk_Click(object sender, EventArgs e)
  {
    this.ApplyChanges();
    MGASystems.IMS.Logging.Log.SerializeLogSettings();
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnApply_Click(object sender, EventArgs e)
  {
    this.ApplyChanges();
    MGASystems.IMS.Logging.Log.SerializeLogSettings();
  }

  private void TroubleshootingAdminWindow_FormClosed(object sender, FormClosedEventArgs e)
  {
    if (this._textBoxTraceListener == null)
      return;
    Trace.Listeners.Remove((TraceListener) this._textBoxTraceListener);
  }

  private void TroubleshootingAdminWindow_Load(object sender, EventArgs e)
  {
    this.cboAutomationGroup.SelectedIndex = 0;
    foreach (KeyValuePair<string, string> logCategory in MGASystems.IMS.Logging.Log.LogCategories)
      this.lstCategories.Items.Add((object) new LogCategoryItem(new LogCategoryAttribute(logCategory.Value, logCategory.Key), MGASystems.IMS.Logging.Log.GetDestination(logCategory.Key)));
    foreach (int num in Enum.GetValues(typeof (LogDestination)))
      this.lstDestinations.Items.Add((object) new LogDestinationItem((LogDestination) num));
    if (this.lstCategories.Items.Count > 0)
      this.lstCategories.SelectedIndex = 0;
    this.cboAITypes.DataSource = (object) DefaultDatabase.ExecuteDataSet(CommandType.Text, "SELECT InterestType, REPLICATE(@nri, isNetRate) + AdditionalInterest AS AdditionalInterest FROM dbo.lstAdditionalInterestTypes ORDER BY AdditionalInterest", new object[2]
    {
      (object) "@nri",
      (object) "[NR ]"
    }).Tables[0];
    this.cboAITypes.ValueMember = "InterestType";
    this.cboAITypes.DisplayMember = "AdditionalInterest";
    this._textBoxTraceListener = new TextBoxTraceListener(this.liveLogTextBox);
    Trace.Listeners.Add((TraceListener) this._textBoxTraceListener);
  }

  private void ApplyChanges()
  {
    foreach (LogCategoryItem logCategoryItem in this.lstCategories.Items)
      MGASystems.IMS.Logging.Log.SetDestination(logCategoryItem.LogCategory.CategoryCode, logCategoryItem.Destination);
  }

  private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (!(this.lstCategories.SelectedItem is LogCategoryItem selectedItem))
      return;
    foreach (LogDestinationItem logDestinationItem in this.lstDestinations.Items)
    {
      if (logDestinationItem.Destination == selectedItem.Destination)
      {
        this.lstDestinations.SelectedItem = (object) logDestinationItem;
        break;
      }
    }
  }

  private void lstDestinations_SelectedValueChanged(object sender, EventArgs e)
  {
    if (!(this.lstCategories.SelectedItem is LogCategoryItem selectedItem1) || !(this.lstDestinations.SelectedItem is LogDestinationItem selectedItem2))
      return;
    selectedItem1.Destination = selectedItem2.Destination;
  }

  private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    string str = FormattableString.Invariant(FormattableStringFactory.Create("{0}Ims.log", (object) MGASystems.IMS.Logging.Log.SerializationSettingsDirectory));
    if (File.Exists(str))
    {
      Process.Start("notepad.exe", str);
    }
    else
    {
      int num = (int) MessageBox.Show("Log File not yet created");
    }
  }

  private void lnkExportToFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
    {
      saveFileDialog.Filter = "Text Files | *.txt";
      saveFileDialog.FileName = $"IMSLog_{DateTime.Now.Month}_{DateTime.Now.Day}_{DateTime.Now.Year}";
      if (saveFileDialog.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(saveFileDialog.FileName))
        return;
      File.WriteAllText(saveFileDialog.FileName, this.liveLogTextBox.Text);
    }
  }

  private void lnkClearLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.liveLogTextBox.Clear();
  }

  private void btnResolvePolicyTag_Click(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      int result1 = -1;
      Guid guid = Guid.Empty;
      if (this.cboAutomationGroup.SelectedIndex == 2)
      {
        try
        {
          guid = new Guid(this.txtControlNo.Text);
        }
        catch
        {
          int num = (int) MessageBox.Show("Please enter a valid insured location guid", "An error occurred resolving your tag");
        }
      }
      else if (!int.TryParse(this.txtControlNo.Text, out result1))
      {
        int num1 = (int) MessageBox.Show("Please enter a numeric id", "An error occurred resolving your tag");
      }
      if (string.IsNullOrEmpty(this.txtTagName.Text))
      {
        int num2 = (int) MessageBox.Show("Please enter a tag name", "An error occurred resolving your tag");
      }
      Type typeFromString1 = ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.DocumentAutomation.TemplateDocuments.TagParserFactory");
      Type typeFromString2 = ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.DocumentAutomation.TemplateDocuments.DocTag");
      object obj = ObjectFactory.Instance.CreateObject(typeFromString1);
      if (typeFromString1 == (Type) null)
      {
        int num3 = (int) MessageBox.Show("Could not create TagFactoryType from MGASystems.IMS.DocumentAutomation.TemplateDocuments.TagParserFactory (did the namespace change?)", "An error occurred resolving your tag");
      }
      else
      {
        ITagParserFactory tagParserFactory = (ITagParserFactory) obj;
        if (tagParserFactory == null)
        {
          int num4 = (int) MessageBox.Show($"Could not cast the type {typeFromString1.FullName} to ITagParserFactory", "An error occurred resolving your tag");
        }
        else
        {
          List<ITagParser> tagParserList = new List<ITagParser>();
          Guid? nullable = new Guid?(Guid.Empty);
          if (result1 < 0)
            return;
          switch (this.cboAutomationGroup.SelectedIndex)
          {
            case 0:
              nullable = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "select top 1 quoteguid from tblQuotes where controlno = @controlno order by quoteid desc", new object[2]
              {
                (object) "@controlno",
                (object) result1
              });
              if (!nullable.HasValue)
              {
                int num5 = (int) MessageBox.Show("Could not find this Control No", "An error occurred resolving your tag");
                return;
              }
              tagParserList.Add((ITagParser) tagParserFactory.QueryTagParser(1, (object) nullable));
              break;
            case 1:
              nullable = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "select quoteguid from tblQuotes where quoteid = @quoteid", new object[2]
              {
                (object) "@quoteid",
                (object) result1
              });
              if (!nullable.HasValue)
              {
                int num6 = (int) MessageBox.Show("Could not find this quote id", "An error occurred resolving your tag");
                return;
              }
              tagParserList.Add((ITagParser) tagParserFactory.QueryTagParser(1, (object) nullable));
              break;
            case 2:
              tagParserList.Add((ITagParser) tagParserFactory.QueryTagParser(4, (object) guid));
              break;
            case 3:
              nullable = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "select SubmissionGroupGuid from tblSubmissionGroup where SubmissionGroupID = @SubmissionGroupID", new object[2]
              {
                (object) "@SubmissionGroupID",
                (object) result1
              });
              if (!nullable.HasValue)
              {
                int num7 = (int) MessageBox.Show("Could not find this submission group id", "An error occurred resolving your tag");
                return;
              }
              tagParserList.Add((ITagParser) tagParserFactory.QueryTagParser(3, (object) nullable));
              break;
            case 4:
              tagParserList.Add((ITagParser) tagParserFactory.QueryTagParser(2, (object) result1));
              break;
            case 5:
              IEnumerator enumerator = DefaultDatabase.ExecuteDataTable("dbo.DocumentAutomation_GetInterestIDs", new object[6]
              {
                (object) "@quoteID",
                (object) DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT MAX(QuoteID) FROM dbo.tblQuotes WHERE ControlNo = @controlNo", new object[2]
                {
                  (object) "@controlNo",
                  (object) result1
                }),
                (object) "@interestType",
                (object) this.cboAITypes.SelectedValue.ToString(),
                (object) "@includeUnchanged",
                (object) MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("GetInterestInformation.IncludeUnchanged")
              }).Rows.GetEnumerator();
              try
              {
                while (enumerator.MoveNext())
                {
                  DataRow current = (DataRow) enumerator.Current;
                  tagParserList.Add((ITagParser) tagParserFactory.QueryTagParser(13, (object) current.Field<int>("AdditionalInterestID")));
                }
                break;
              }
              finally
              {
                if (enumerator is IDisposable disposable)
                  disposable.Dispose();
              }
            case 6:
              int result2;
              if (!int.TryParse(this.txtTemplateGroupID.Text, out result2))
              {
                int num8 = (int) MessageBox.Show("Could not parse Template Group ID (must be integer)", "An error occurred resolving your tag");
                return;
              }
              tagParserList.Add((ITagParser) tagParserFactory.QueryTagParser(result2, (object) result1));
              break;
          }
          if (tagParserList.Count == 0 || tagParserList[0] == null)
          {
            int num9 = (int) MessageBox.Show("Unable to create tag parser for the selected type", "An error occurred resolving your tag");
          }
          else
          {
            IList<IDocTag> docTagList = (IList<IDocTag>) new List<IDocTag>();
            foreach (ITagParser tagParser in tagParserList)
            {
              IDocTag docTag = (IDocTag) ObjectFactory.Instance.CreateObject(typeFromString2);
              if (docTag == null)
              {
                int num10 = (int) MessageBox.Show("Could not create TagFactoryType from MGASystems.IMS.DocumentAutomation.TemplateDocuments.DocTag (did the namespace change?)", "An error occurred resolving your tag");
                return;
              }
              if (tagParser == null)
              {
                int num11 = (int) MessageBox.Show("Unable to cast tagparser to ITagParser", "An error occurred resolving your tag");
                return;
              }
              List<IDocTag> tags = new List<IDocTag>();
              docTag.TagName = this.txtTagName.Text;
              tags.Add(docTag);
              foreach (IDocTag processTag in (IEnumerable<IDocTag>) tagParser.ProcessTagList((IList<IDocTag>) tags))
                docTagList.Add(processTag);
            }
            foreach (IDocTag docTag1 in (IEnumerable<IDocTag>) docTagList)
            {
              if (docTag1.IsImageTag)
              {
                TextBox txtTagResult = this.txtTagResult;
                txtTagResult.Text = $"{txtTagResult.Text}{docTag1.TagName}: Image Tag Not Supported In this View{Environment.NewLine}";
              }
              else if (docTag1.IsTableTag)
              {
                TextBox txtTagResult = this.txtTagResult;
                txtTagResult.Text = $"{txtTagResult.Text}{docTag1.TagName}: Image Tag Not Supported In this View{Environment.NewLine}";
              }
              else if (docTag1.IsCheckBoxTag)
                this.txtTagResult.Text += $"{docTag1.TagName}: CheckBox.Checked={docTag1.TagCheckbox}{Environment.NewLine}";
              else if (docTag1.IsRepeatableTag)
              {
                IDocTag docTag2 = docTag1;
                DataTable dataTable = docTag1.TagDataset.Tables.Cast<DataTable>().FirstOrDefault<DataTable>();
                if (dataTable != null)
                {
                  if (!dataTable.Columns.Contains(docTag2.InnerTagName))
                  {
                    TextBox txtTagResult = this.txtTagResult;
                    txtTagResult.Text = $"{txtTagResult.Text}{docTag2.TagName} ({dataTable.TableName}): Stored procedure failed to return value for field.{Environment.NewLine}";
                  }
                  else
                  {
                    List<string> source = new List<string>();
                    string innerTagName = docTag2.InnerTagName;
                    foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
                    {
                      docTag2.TagValue = row.IsNull(innerTagName) ? "" : row[innerTagName].ToString();
                      docTag2.PostProcessTag();
                      source.Add($"\tRow {dataTable.Rows.IndexOf(row) + 1}: {docTag2.TagValue}");
                    }
                    TextBox txtTagResult = this.txtTagResult;
                    txtTagResult.Text = $"{txtTagResult.Text}{docTag2.TagName} ({dataTable.TableName}):{Environment.NewLine}{string.Join(Environment.NewLine, source.DefaultIfEmpty<string>("No Rows Returned").ToArray<string>())}{Environment.NewLine}";
                  }
                }
                else
                {
                  TextBox txtTagResult = this.txtTagResult;
                  txtTagResult.Text = $"{txtTagResult.Text}{docTag1.TagName}: Unable to find repeatable source for tag{Environment.NewLine}";
                }
              }
              else
              {
                TextBox txtTagResult = this.txtTagResult;
                txtTagResult.Text = $"{txtTagResult.Text}{docTag1.TagName}: {docTag1.TagValue}{Environment.NewLine}";
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show(ex.Message, "An error occurred resolving your tag");
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void LinkLabel2_Click(object sender, EventArgs e)
  {
    this.txtTagResult.Text = string.Empty;
  }

  private void txtTagName_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.A || !e.Control)
      return;
    this.liveLogTextBox.SelectAll();
    e.Handled = true;
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    Type typeFromString = ObjectFactory.Instance.CreateTypeFromString(this.ObjFacTypeIn.Text);
    if (typeFromString != (Type) null)
    {
      this.ObjFacTypeOut.Text = typeFromString.FullName;
    }
    else
    {
      List<ObjectInfo> list = ObjectFactory.Instance.GetObjectOverrideList().Where<ObjectInfo>((System.Func<ObjectInfo, bool>) (info => info.BaseClass.EndsWith(this.ObjFacTypeIn.Text))).ToList<ObjectInfo>();
      switch (list.Count)
      {
        case 0:
          this.ObjFacTypeOut.Text = "No type found, be sure to use fully qualified class names";
          break;
        case 1:
          ObjectInfo objectInfo = list.Single<ObjectInfo>();
          this.ObjFacTypeIn.Text = objectInfo.BaseClass;
          this.ObjFacTypeOut.Text = objectInfo.ObjectName;
          break;
        default:
          this.ObjFacTypeOut.Text = "Mutiple potential base class name matches: " + string.Join(",", list.Select<ObjectInfo, string>((System.Func<ObjectInfo, string>) (info => info.BaseClass)));
          break;
      }
    }
  }

  private void cboAutomationGroup_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.cboAITypes.Enabled = this.cboAutomationGroup.SelectedIndex == 5;
    this.txtTemplateGroupID.Enabled = this.cboAutomationGroup.SelectedIndex == 6;
    if (this.cboAutomationGroup.SelectedIndex == 6)
      return;
    this.txtTemplateGroupID.Text = string.Empty;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    this.LinkLabel2 = new LinkLabel();
    this.lnkClearLog = new LinkLabel();
    this.lnkExportToFile = new LinkLabel();
    this.cboAutomationGroup = new ComboBox();
    this.Label7 = new Label();
    this.txtTagResult = new TextBox();
    this.txtControlNo = new TextBox();
    this.chkShowDetail = new CheckBox();
    this.btnResolvePolicyTag = new Button();
    this.txtTagName = new TextBox();
    this.TabPage4 = new TabPage();
    this.Button1 = new Button();
    this.ObjFacTypeOut = new TextBox();
    this.Label9 = new Label();
    this.ObjFacTypeIn = new TextBox();
    this.Label8 = new Label();
    this.Label6 = new Label();
    this.liveLogTextBox = new TextBox();
    this.TabPage1 = new TabPage();
    this.lstDestinations = new MGAListBox();
    this.lstCategories = new MGAListBox();
    this.label5 = new Label();
    this.label3 = new Label();
    this.TabPage2 = new TabPage();
    this.TabControl1 = new TabControl();
    this.TabPage3 = new TabPage();
    this.label11 = new Label();
    this.txtTemplateGroupID = new TextBox();
    this.label10 = new Label();
    this.cboAITypes = new ComboBox();
    this.label2 = new Label();
    this.label1 = new Label();
    this.label4 = new Label();
    this.linkLabel1 = new LinkLabel();
    this.btnApply = new MGAButton();
    this.btnOk = new MGAButton();
    this.btnCancel = new MGAButton();
    this.TabPage4.SuspendLayout();
    this.TabPage1.SuspendLayout();
    ((ISupportInitialize) this.lstDestinations).BeginInit();
    ((ISupportInitialize) this.lstCategories).BeginInit();
    this.TabPage2.SuspendLayout();
    this.TabControl1.SuspendLayout();
    this.TabPage3.SuspendLayout();
    ((ISupportInitialize) this.btnApply).BeginInit();
    ((ISupportInitialize) this.btnOk).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    this.LinkLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.LinkLabel2.AutoSize = true;
    this.LinkLabel2.Location = new Point(7, 264);
    this.LinkLabel2.Name = "LinkLabel2";
    this.LinkLabel2.Size = new Size(52, 13);
    this.LinkLabel2.TabIndex = 36;
    this.LinkLabel2.TabStop = true;
    this.LinkLabel2.Text = "Clear Log";
    this.LinkLabel2.Click += new EventHandler(this.LinkLabel2_Click);
    this.lnkClearLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkClearLog.AutoSize = true;
    this.lnkClearLog.Location = new Point(132, 257);
    this.lnkClearLog.Name = "lnkClearLog";
    this.lnkClearLog.Size = new Size(52, 13);
    this.lnkClearLog.TabIndex = 35;
    this.lnkClearLog.TabStop = true;
    this.lnkClearLog.Text = "Clear Log";
    this.lnkClearLog.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkClearLog_LinkClicked);
    this.lnkExportToFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkExportToFile.AutoSize = true;
    this.lnkExportToFile.Location = new Point(727, 257);
    this.lnkExportToFile.Name = "lnkExportToFile";
    this.lnkExportToFile.Size = new Size(72, 13);
    this.lnkExportToFile.TabIndex = 34;
    this.lnkExportToFile.TabStop = true;
    this.lnkExportToFile.Text = "Export To File";
    this.lnkExportToFile.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkExportToFile_LinkClicked);
    this.cboAutomationGroup.DropDownHeight = 126;
    this.cboAutomationGroup.DropDownWidth = 181;
    this.cboAutomationGroup.FormattingEnabled = true;
    this.cboAutomationGroup.IntegralHeight = false;
    this.cboAutomationGroup.Items.AddRange(new object[7]
    {
      (object) "Policy (Control #)",
      (object) "Policy (Quote ID)",
      (object) "Insured Location Guid",
      (object) "Submission ID",
      (object) "Invoice Num",
      (object) "Additional Interest (Control #)",
      (object) "Other ID"
    });
    this.cboAutomationGroup.Location = new Point(206, 6);
    this.cboAutomationGroup.Name = "cboAutomationGroup";
    this.cboAutomationGroup.Size = new Size(116, 21);
    this.cboAutomationGroup.TabIndex = 6;
    this.cboAutomationGroup.SelectedIndexChanged += new EventHandler(this.cboAutomationGroup_SelectedIndexChanged);
    this.Label7.AutoSize = true;
    this.Label7.Location = new Point(592, 10);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(18, 13);
    this.Label7.TabIndex = 5;
    this.Label7.Text = "ID";
    this.txtTagResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.txtTagResult.Location = new Point(7, 36);
    this.txtTagResult.Multiline = true;
    this.txtTagResult.Name = "txtTagResult";
    this.txtTagResult.ScrollBars = ScrollBars.Both;
    this.txtTagResult.Size = new Size(796, 225);
    this.txtTagResult.TabIndex = 4;
    this.txtControlNo.Location = new Point(610, 7);
    this.txtControlNo.Name = "txtControlNo";
    this.txtControlNo.Size = new Size(103, 20);
    this.txtControlNo.TabIndex = 3;
    this.chkShowDetail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.chkShowDetail.AutoSize = true;
    this.chkShowDetail.Location = new Point(6, 256 /*0x0100*/);
    this.chkShowDetail.Name = "chkShowDetail";
    this.chkShowDetail.Size = new Size(83, 17);
    this.chkShowDetail.TabIndex = 1;
    this.chkShowDetail.Text = "Show Detail";
    this.chkShowDetail.UseVisualStyleBackColor = true;
    this.btnResolvePolicyTag.Location = new Point(719, 7);
    this.btnResolvePolicyTag.Name = "btnResolvePolicyTag";
    this.btnResolvePolicyTag.Size = new Size(75, 23);
    this.btnResolvePolicyTag.TabIndex = 2;
    this.btnResolvePolicyTag.Text = "Resolve";
    this.btnResolvePolicyTag.UseVisualStyleBackColor = true;
    this.btnResolvePolicyTag.Click += new EventHandler(this.btnResolvePolicyTag_Click);
    this.txtTagName.Location = new Point(64 /*0x40*/, 7);
    this.txtTagName.Name = "txtTagName";
    this.txtTagName.Size = new Size(135, 20);
    this.txtTagName.TabIndex = 0;
    this.txtTagName.KeyDown += new KeyEventHandler(this.txtTagName_KeyDown);
    this.TabPage4.Controls.Add((Control) this.Button1);
    this.TabPage4.Controls.Add((Control) this.ObjFacTypeOut);
    this.TabPage4.Controls.Add((Control) this.Label9);
    this.TabPage4.Controls.Add((Control) this.ObjFacTypeIn);
    this.TabPage4.Controls.Add((Control) this.Label8);
    this.TabPage4.Location = new Point(4, 22);
    this.TabPage4.Name = "TabPage4";
    this.TabPage4.Padding = new Padding(3, 3, 3, 3);
    this.TabPage4.Size = new Size(806, 285);
    this.TabPage4.TabIndex = 3;
    this.TabPage4.Text = "ObjectFactory";
    this.TabPage4.UseVisualStyleBackColor = true;
    this.Button1.Location = new Point(60, 33);
    this.Button1.Name = "Button1";
    this.Button1.Size = new Size(75, 23);
    this.Button1.TabIndex = 4;
    this.Button1.Text = "Get Type";
    this.Button1.UseVisualStyleBackColor = true;
    this.Button1.Click += new EventHandler(this.Button1_Click);
    this.ObjFacTypeOut.Location = new Point(60, 62);
    this.ObjFacTypeOut.Name = "ObjFacTypeOut";
    this.ObjFacTypeOut.ReadOnly = true;
    this.ObjFacTypeOut.Size = new Size(540, 20);
    this.ObjFacTypeOut.TabIndex = 3;
    this.Label9.AutoSize = true;
    this.Label9.Location = new Point(6, 65);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(54, 13);
    this.Label9.TabIndex = 2;
    this.Label9.Text = "Type Out:";
    this.ObjFacTypeIn.Location = new Point(60, 6);
    this.ObjFacTypeIn.Name = "ObjFacTypeIn";
    this.ObjFacTypeIn.Size = new Size(540, 20);
    this.ObjFacTypeIn.TabIndex = 1;
    this.Label8.AutoSize = true;
    this.Label8.Location = new Point(6, 9);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(46, 13);
    this.Label8.TabIndex = 0;
    this.Label8.Text = "Type In:";
    this.Label6.AutoSize = true;
    this.Label6.Location = new Point(4, 10);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(57, 13);
    this.Label6.TabIndex = 1;
    this.Label6.Text = "Tag Name";
    this.liveLogTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.liveLogTextBox.Location = new Point(6, 6);
    this.liveLogTextBox.Multiline = true;
    this.liveLogTextBox.Name = "liveLogTextBox";
    this.liveLogTextBox.ScrollBars = ScrollBars.Both;
    this.liveLogTextBox.Size = new Size(794, 244);
    this.liveLogTextBox.TabIndex = 0;
    this.TabPage1.Controls.Add((Control) this.lstDestinations);
    this.TabPage1.Controls.Add((Control) this.lstCategories);
    this.TabPage1.Controls.Add((Control) this.label5);
    this.TabPage1.Controls.Add((Control) this.label3);
    this.TabPage1.Location = new Point(4, 22);
    this.TabPage1.Name = "TabPage1";
    this.TabPage1.Padding = new Padding(3, 3, 3, 3);
    this.TabPage1.Size = new Size(806, 285);
    this.TabPage1.TabIndex = 0;
    this.TabPage1.Text = "Configure";
    this.TabPage1.UseVisualStyleBackColor = true;
    this.lstDestinations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    this.lstDestinations.FormattingEnabled = true;
    this.lstDestinations.Location = new Point(691, 19);
    this.lstDestinations.MGAStyle = MGAStyles.Blue;
    this.lstDestinations.Name = "lstDestinations";
    this.lstDestinations.Size = new Size(109, 249);
    this.lstDestinations.TabIndex = 34;
    this.lstDestinations.SelectedValueChanged += new EventHandler(this.lstDestinations_SelectedValueChanged);
    this.lstCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstCategories.FormattingEnabled = true;
    this.lstCategories.Location = new Point(6, 19);
    this.lstCategories.MGAStyle = MGAStyles.Blue;
    this.lstCategories.Name = "lstCategories";
    this.lstCategories.Size = new Size(682, 249);
    this.lstCategories.TabIndex = 33;
    this.lstCategories.SelectedIndexChanged += new EventHandler(this.lstCategories_SelectedIndexChanged);
    this.label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label5.AutoSize = true;
    this.label5.Location = new Point(688, 3);
    this.label5.Name = "label5";
    this.label5.Size = new Size(60, 13);
    this.label5.TabIndex = 32 /*0x20*/;
    this.label5.Text = "Destination";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(3, 3);
    this.label3.Name = "label3";
    this.label3.Size = new Size(49, 13);
    this.label3.TabIndex = 29;
    this.label3.Text = "Category";
    this.TabPage2.Controls.Add((Control) this.lnkClearLog);
    this.TabPage2.Controls.Add((Control) this.lnkExportToFile);
    this.TabPage2.Controls.Add((Control) this.chkShowDetail);
    this.TabPage2.Controls.Add((Control) this.liveLogTextBox);
    this.TabPage2.Location = new Point(4, 22);
    this.TabPage2.Name = "TabPage2";
    this.TabPage2.Padding = new Padding(3, 3, 3, 3);
    this.TabPage2.Size = new Size(806, 285);
    this.TabPage2.TabIndex = 1;
    this.TabPage2.Text = "Live Log";
    this.TabPage2.UseVisualStyleBackColor = true;
    this.TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.TabControl1.Controls.Add((Control) this.TabPage1);
    this.TabControl1.Controls.Add((Control) this.TabPage2);
    this.TabControl1.Controls.Add((Control) this.TabPage3);
    this.TabControl1.Controls.Add((Control) this.TabPage4);
    this.TabControl1.Location = new Point(23, 37);
    this.TabControl1.Name = "TabControl1";
    this.TabControl1.SelectedIndex = 0;
    this.TabControl1.Size = new Size(814, 311);
    this.TabControl1.TabIndex = 39;
    this.TabPage3.Controls.Add((Control) this.label11);
    this.TabPage3.Controls.Add((Control) this.txtTemplateGroupID);
    this.TabPage3.Controls.Add((Control) this.label10);
    this.TabPage3.Controls.Add((Control) this.cboAITypes);
    this.TabPage3.Controls.Add((Control) this.LinkLabel2);
    this.TabPage3.Controls.Add((Control) this.cboAutomationGroup);
    this.TabPage3.Controls.Add((Control) this.Label7);
    this.TabPage3.Controls.Add((Control) this.txtTagResult);
    this.TabPage3.Controls.Add((Control) this.txtControlNo);
    this.TabPage3.Controls.Add((Control) this.btnResolvePolicyTag);
    this.TabPage3.Controls.Add((Control) this.Label6);
    this.TabPage3.Controls.Add((Control) this.txtTagName);
    this.TabPage3.Location = new Point(4, 22);
    this.TabPage3.Name = "TabPage3";
    this.TabPage3.Size = new Size(806, 285);
    this.TabPage3.TabIndex = 2;
    this.TabPage3.Text = "Template Tag Resolver";
    this.TabPage3.UseVisualStyleBackColor = true;
    this.label11.AutoSize = true;
    this.label11.Location = new Point(332, 10);
    this.label11.Margin = new Padding(2, 0, 2, 0);
    this.label11.Name = "label11";
    this.label11.Size = new Size(97, 13);
    this.label11.TabIndex = 40;
    this.label11.Text = "Template Group ID";
    this.txtTemplateGroupID.Enabled = false;
    this.txtTemplateGroupID.Location = new Point(428, 7);
    this.txtTemplateGroupID.Margin = new Padding(2, 2, 2, 2);
    this.txtTemplateGroupID.Name = "txtTemplateGroupID";
    this.txtTemplateGroupID.Size = new Size(36, 20);
    this.txtTemplateGroupID.TabIndex = 39;
    this.label10.AutoSize = true;
    this.label10.Location = new Point(467, 10);
    this.label10.Name = "label10";
    this.label10.Size = new Size(47, 13);
    this.label10.TabIndex = 38;
    this.label10.Text = "AI Type:";
    this.cboAITypes.DropDownWidth = 249;
    this.cboAITypes.Enabled = false;
    this.cboAITypes.FormattingEnabled = true;
    this.cboAITypes.Location = new Point(512 /*0x0200*/, 6);
    this.cboAITypes.Name = "cboAITypes";
    this.cboAITypes.Size = new Size(77, 21);
    this.cboAITypes.TabIndex = 37;
    this.label2.AutoSize = true;
    this.label2.Location = new Point(20, 21);
    this.label2.Name = "label2";
    this.label2.Size = new Size(323, 13);
    this.label2.TabIndex = 36;
    this.label2.Text = "Warning: Enabling logging can negatively affect IMS performance. ";
    this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(20, 7);
    this.label1.Name = "label1";
    this.label1.Size = new Size(363, 13);
    this.label1.TabIndex = 35;
    this.label1.Text = "Enabling Logging may help to diagnose and troubleshoot issues in the IMS. ";
    this.label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(20, 354);
    this.label4.Name = "label4";
    this.label4.Size = new Size(334, 13);
    this.label4.TabIndex = 37;
    this.label4.Text = "Log file will truncate at 5 megs, or every week, whichever occurs first.";
    this.linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.linkLabel1.AutoSize = true;
    this.linkLabel1.Location = new Point(20, 369);
    this.linkLabel1.Name = "linkLabel1";
    this.linkLabel1.Size = new Size(51, 13);
    this.linkLabel1.TabIndex = 38;
    this.linkLabel1.TabStop = true;
    this.linkLabel1.Text = "View Log";
    this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
    ((Control) this.btnApply).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnApply).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnApply).Location = new Point(761, 354);
    ((Control) this.btnApply).Name = "btnApply";
    ((Control) this.btnApply).Size = new Size(75, 23);
    ((Control) this.btnApply).TabIndex = 42;
    ((Control) this.btnApply).Text = "Apply";
    ((UltraControlBase) this.btnApply).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnApply).Click += new EventHandler(this.btnApply_Click);
    ((Control) this.btnOk).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOk).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnOk).Location = new Point(599, 354);
    ((Control) this.btnOk).Name = "btnOk";
    ((Control) this.btnOk).Size = new Size(75, 23);
    ((Control) this.btnOk).TabIndex = 41;
    ((Control) this.btnOk).Text = "Ok";
    ((UltraControlBase) this.btnOk).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnOk).Click += new EventHandler(this.btnOk_Click);
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(680, 354);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(75, 23);
    ((Control) this.btnCancel).TabIndex = 40;
    ((Control) this.btnCancel).Text = "Cancel";
    ((UltraControlBase) this.btnCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Click += new EventHandler(this.btnCancel_Click);
    this.AcceptButton = (IButtonControl) this.btnResolvePolicyTag;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(857, 389);
    this.Controls.Add((Control) this.btnApply);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.TabControl1);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.linkLabel1);
    this.Name = nameof (TroubleshootingAdminWindow);
    this.Text = "IMS Troubleshooting";
    this.FormClosed += new FormClosedEventHandler(this.TroubleshootingAdminWindow_FormClosed);
    this.Load += new EventHandler(this.TroubleshootingAdminWindow_Load);
    this.TabPage4.ResumeLayout(false);
    this.TabPage4.PerformLayout();
    this.TabPage1.ResumeLayout(false);
    this.TabPage1.PerformLayout();
    ((ISupportInitialize) this.lstDestinations).EndInit();
    ((ISupportInitialize) this.lstCategories).EndInit();
    this.TabPage2.ResumeLayout(false);
    this.TabPage2.PerformLayout();
    this.TabControl1.ResumeLayout(false);
    this.TabPage3.ResumeLayout(false);
    this.TabPage3.PerformLayout();
    ((ISupportInitialize) this.btnApply).EndInit();
    ((ISupportInitialize) this.btnOk).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
