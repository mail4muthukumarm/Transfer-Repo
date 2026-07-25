// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.frmRaterBase
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win.UltraWinToolbars;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Enums;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Security;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[SecureResource("39673335-B609-4045-B40E-59BE1E9BE387", "Premium Override Modification", "Allows the user to view, add and modify the override premium.", "Rating")]
[DocumentFolderFilter("Policy Detail")]
public class frmRaterBase : FormBase, IQuoteOption, ISupportDocumentSystem, ISupportNoteSystem
{
  private IContainer components;
  public const string AllowPremiumOverride = "39673335-B609-4045-B40E-59BE1E9BE387";
  private RaterBase _rater;
  private UltraToolbarsDockArea _frmRaterBase_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmRaterBase_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _frmRaterBase_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmRaterBase_Toolbars_Dock_Area_Bottom;

  public frmRaterBase()
  {
    this.Load += new EventHandler(this.frmRaterBase_Load);
    this.InitializeComponent();
  }

  public RaterBase Rater
  {
    get => this._rater;
    set => this._rater = value;
  }

  protected virtual UltraToolbarsManager RatingToolbar
  {
    get => this._RatingToolbar;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.RatingToolbar_ToolClick);
      UltraToolbarsManager ratingToolbar1 = this._RatingToolbar;
      if (ratingToolbar1 != null)
        ratingToolbar1.ToolClick -= clickEventHandler;
      this._RatingToolbar = value;
      UltraToolbarsManager ratingToolbar2 = this._RatingToolbar;
      if (ratingToolbar2 == null)
        return;
      ratingToolbar2.ToolClick += clickEventHandler;
    }
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler ISupportDocumentSystem_EntityInfoChanged;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler ISupportNoteSystem_EntityInfoChanged;

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    UltraToolbar ultraToolbar = new UltraToolbar("Rating");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("Rating");
    ButtonTool buttonTool1 = new ButtonTool("Override Premium");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("Rating");
    ButtonTool buttonTool2 = new ButtonTool("Override Premium");
    this.RatingToolbar = new UltraToolbarsManager(this.components);
    this._frmRaterBase_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmRaterBase_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmRaterBase_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmRaterBase_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.RatingToolbar).BeginInit();
    this.SuspendLayout();
    this.RatingToolbar.DesignerFlags = 1;
    this.RatingToolbar.DockWithinContainer = (Control) this;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ultraToolbar.Text = "Rating";
    ((ToolsCollectionBase) ((UltraToolbarBase) ultraToolbar).Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    this.RatingToolbar.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedProps).Caption = "Override Premium";
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedProps).DisplayStyle = (ToolDisplayStyle) 2;
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedProps).Caption = "Rating";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool2
    });
    this.RatingToolbar.Tools.AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) popupMenuTool2
    });
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._frmRaterBase_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Left).Location = new Point(0, 47);
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Left).Name = "_frmRaterBase_Toolbars_Dock_Area_Left";
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Left).Size = new Size(0, 334);
    this._frmRaterBase_Toolbars_Dock_Area_Left.ToolbarsManager = this.RatingToolbar;
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._frmRaterBase_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Right).Location = new Point(560, 47);
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Right).Name = "_frmRaterBase_Toolbars_Dock_Area_Right";
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Right).Size = new Size(0, 334);
    this._frmRaterBase_Toolbars_Dock_Area_Right.ToolbarsManager = this.RatingToolbar;
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._frmRaterBase_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Top).Name = "_frmRaterBase_Toolbars_Dock_Area_Top";
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Top).Size = new Size(560, 47);
    this._frmRaterBase_Toolbars_Dock_Area_Top.ToolbarsManager = this.RatingToolbar;
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._frmRaterBase_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Bottom).Location = new Point(0, 381);
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Bottom).Name = "_frmRaterBase_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmRaterBase_Toolbars_Dock_Area_Bottom).Size = new Size(560, 0);
    this._frmRaterBase_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.RatingToolbar;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.Controls.Add((Control) this._frmRaterBase_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmRaterBase_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmRaterBase_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._frmRaterBase_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (frmRaterBase);
    ((ISupportInitialize) this.RatingToolbar).EndInit();
  }

  public Decimal IQuoteOptionCalculateFactor(EndorsementCalcTypes calcType, DateTime effectiveDate)
  {
    this.OnQuoteOptionCalculateFactor(calcType, effectiveDate);
    Decimal factor;
    return factor;
  }

  protected virtual Decimal OnQuoteOptionCalculateFactor(
    EndorsementCalcTypes calcType,
    DateTime effectiveDate)
  {
    Quote quote = this.Rater.Quote;
    Decimal factor;
    if (quote.QuoteStatus == QuoteStatus.PendingReinstatement)
      factor = DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, string.Format("SELECT {0}_1.Factor FROM {0} INNER JOIN {0} {0}_1 ON {0}.PreviousQuoteGUID = {0}.QuoteGUID WHERE {0}.QuoteGUID=@QuoteGUID", (object) this.QuoteOptionFactorTableName), new object[2]
      {
        (object) "@QuoteGUID",
        (object) quote.QuoteGuid
      });
    else
      factor = ObjectFactory.Instance.CreateObjectAs<QuoteOption>(this.QuoteOptionIdentifier).CalculateFactor(calcType, effectiveDate);
    return factor;
  }

  protected virtual object QuoteOptionIdentifier
  {
    get
    {
      throw new InvalidOperationException("You must override QuoteOptionIdentifier to return either a QuoteOptionID or QuoteOptionGUID");
    }
  }

  protected virtual string QuoteOptionFactorTableName
  {
    get
    {
      throw new InvalidOperationException("You must override CalculateFactorTable to specify Quote level table containing the Factor, QuoteGUID, and PreviousQuoteGuid Fields");
    }
  }

  protected void AddRatingMenuTool(string toolKey, string toolCaption, Image toolIcon)
  {
    if (((ToolsCollectionBase) this.RatingToolbar.Tools).Exists(toolKey))
      return;
    PopupMenuTool popupMenu = this.RatingToolbar.FindPopupMenu("Rating");
    if (popupMenu == null)
      return;
    popupMenu.AddOrShowButtonTool(toolKey, toolCaption, true, (Action<ButtonTool>) ([SpecialName] (newMenu) => ((ToolPropsBase) ((ToolBase) newMenu).InstanceProps).AppearancesSmall.Appearance.Image = (object) toolIcon));
    this.RatingToolbar.RefreshMerge();
  }

  private void RatingToolbar_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ToolEventArgs) e).Tool.Key, "Override Premium", false) == 0)
    {
      using (frmPremiumOverride objectAs = ObjectFactory.Instance.CreateObjectAs<frmPremiumOverride>((object) this._rater.QuoteGuid))
      {
        objectAs.StartPosition = FormStartPosition.CenterScreen;
        if (objectAs.ShowDialog() == DialogResult.OK)
          DefaultDatabase.ExecuteNonQuery("dbo.spUpdateOverriddenPremium", new object[6]
          {
            (object) "@QuoteOptionGuid",
            (object) objectAs.QuoteOptionGuid,
            (object) "@OverriddenPremium",
            (object) objectAs.OverridePremium,
            (object) "@ChargeCode",
            (object) objectAs.ChargeCode
          });
      }
    }
    this.ClientMenuToolClick(((ToolEventArgs) e).Tool.Key);
  }

  protected virtual void ClientMenuToolClick(string ToolKey)
  {
  }

  private void frmRaterBase_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((ToolsCollectionBase) this.RatingToolbar.Tools)["Override Premium"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("39673335-B609-4045-B40E-59BE1E9BE387");
  }

  private IRecreatableEntity QuoteEntity
  {
    get
    {
      RaterBase rater = this.Rater;
      return rater == null ? (IRecreatableEntity) null : (IRecreatableEntity) rater.Quote;
    }
  }

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    IRecreatableEntity quoteEntity = this.QuoteEntity;
    return quoteEntity != null && quoteEntity.RecreateEntityInitialize(entityGuid);
  }

  public bool AllowAddNewDocument
  {
    get
    {
      return this.QuoteEntity is ISupportDocumentSystem quoteEntity && quoteEntity.AllowAddNewDocument;
    }
  }

  string IRecreatableEntity.EntityName => this.QuoteEntity?.EntityName;

  Guid IRecreatableEntity.EntityGuid
  {
    get
    {
      IRecreatableEntity quoteEntity = this.QuoteEntity;
      return quoteEntity == null ? Guid.Empty : quoteEntity.EntityGuid;
    }
  }

  string IRecreatableEntity.FriendlyEntityName => this.QuoteEntity?.FriendlyEntityName;

  string IRecreatableEntity.RecreateTypeName => this.QuoteEntity?.RecreateTypeName;

  bool IRecreatableEntity.CanReCreateEntity
  {
    get
    {
      IRecreatableEntity quoteEntity = this.QuoteEntity;
      return quoteEntity != null && quoteEntity.CanReCreateEntity;
    }
  }

  bool IRecreatableEntity.HasControlGUID
  {
    get
    {
      IRecreatableEntity quoteEntity = this.QuoteEntity;
      return quoteEntity != null && quoteEntity.HasControlGUID;
    }
  }

  Guid IRecreatableEntity.ControlGUID
  {
    get
    {
      IRecreatableEntity quoteEntity = this.QuoteEntity;
      return quoteEntity == null ? Guid.Empty : quoteEntity.ControlGUID;
    }
  }

  public bool CanCreateNewNote
  {
    get => this.QuoteEntity is ISupportNoteSystem quoteEntity && quoteEntity.CanCreateNewNote;
  }
}
