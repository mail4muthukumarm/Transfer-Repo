// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.DBNavigator
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public class DBNavigator : UserControl
{
  private IContainer components;
  private TextBox txtText;
  private int _min;
  private int _max;
  private int _value;
  private bool _enforceBounds;
  private bool _autoMoveValue;

  public DBNavigator()
  {
    this._max = 100;
    this._autoMoveValue = true;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual Button btnMF
  {
    get => this._btnMF;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnMF_Click);
      Button btnMf1 = this._btnMF;
      if (btnMf1 != null)
        btnMf1.Click -= eventHandler;
      this._btnMF = value;
      Button btnMf2 = this._btnMF;
      if (btnMf2 == null)
        return;
      btnMf2.Click += eventHandler;
    }
  }

  private virtual Button btnMP
  {
    get => this._btnMP;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnMP_Click);
      Button btnMp1 = this._btnMP;
      if (btnMp1 != null)
        btnMp1.Click -= eventHandler;
      this._btnMP = value;
      Button btnMp2 = this._btnMP;
      if (btnMp2 == null)
        return;
      btnMp2.Click += eventHandler;
    }
  }

  private virtual Button btnMN
  {
    get => this._btnMN;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnMN_Click);
      Button btnMn1 = this._btnMN;
      if (btnMn1 != null)
        btnMn1.Click -= eventHandler;
      this._btnMN = value;
      Button btnMn2 = this._btnMN;
      if (btnMn2 == null)
        return;
      btnMn2.Click += eventHandler;
    }
  }

  private virtual Button btnML
  {
    get => this._btnML;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnML_Click);
      Button btnMl1 = this._btnML;
      if (btnMl1 != null)
        btnMl1.Click -= eventHandler;
      this._btnML = value;
      Button btnMl2 = this._btnML;
      if (btnMl2 == null)
        return;
      btnMl2.Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.btnMF = new Button();
    this.btnMP = new Button();
    this.txtText = new TextBox();
    this.btnMN = new Button();
    this.btnML = new Button();
    this.SuspendLayout();
    this.btnMF.Location = new Point(8, 8);
    this.btnMF.Name = "btnMF";
    this.btnMF.Size = new Size(24, 16 /*0x10*/);
    this.btnMF.TabIndex = 1;
    this.btnMP.Location = new Point(48 /*0x30*/, 8);
    this.btnMP.Name = "btnMP";
    this.btnMP.Size = new Size(24, 16 /*0x10*/);
    this.btnMP.TabIndex = 2;
    this.txtText.Location = new Point(88, 0);
    this.txtText.Multiline = true;
    this.txtText.Name = "txtText";
    this.txtText.ReadOnly = true;
    this.txtText.Size = new Size(64 /*0x40*/, 24);
    this.txtText.TabIndex = 3;
    this.txtText.Text = "";
    this.txtText.TextAlign = HorizontalAlignment.Center;
    this.btnMN.Location = new Point(168, 8);
    this.btnMN.Name = "btnMN";
    this.btnMN.Size = new Size(24, 16 /*0x10*/);
    this.btnMN.TabIndex = 4;
    this.btnML.Location = new Point(200, 8);
    this.btnML.Name = "btnML";
    this.btnML.Size = new Size(24, 16 /*0x10*/);
    this.btnML.TabIndex = 5;
    this.Controls.Add((Control) this.btnMF);
    this.Controls.Add((Control) this.btnMP);
    this.Controls.Add((Control) this.txtText);
    this.Controls.Add((Control) this.btnMN);
    this.Controls.Add((Control) this.btnML);
    this.Name = nameof (DBNavigator);
    this.Size = new Size(232, 32 /*0x20*/);
    this.ResumeLayout(false);
  }

  public event EventHandler ClickedMoveFirst;

  public event EventHandler ClickedMoveLast;

  public event EventHandler ClickedMovePrev;

  public event EventHandler ClickedMoveNext;

  public event EventHandler MinChanged;

  public event EventHandler MaxChanged;

  public event EventHandler ValueChanged;

  [Category("Appearance")]
  [DefaultValue(false)]
  [Description("Determines whether or not bounds max/min value will be enforced.")]
  public bool EnforceBounds
  {
    get => this._enforceBounds;
    set
    {
      if (this._enforceBounds == value)
        return;
      this._enforceBounds = value;
      this.SetImages();
    }
  }

  [Category("Appearance")]
  [DefaultValue(0)]
  [Description("Minimum allowable value enforced if EnforceBounds is true.")]
  public int Min
  {
    get => this._min;
    set
    {
      if (value == this._min)
        return;
      this._min = value;
      this.SetImages();
    }
  }

  [Category("Appearance")]
  [DefaultValue(100)]
  [Description("Maximum allowable value enforced if EnforceBounds is true.")]
  public int Max
  {
    get => this._max;
    set
    {
      if (value == this._max)
        return;
      this._max = value;
      this.SetImages();
    }
  }

  [Category("Appearance")]
  [DefaultValue(0)]
  [Description("Current position")]
  public int Value
  {
    get => this._value;
    set
    {
      if (value == this._value)
        return;
      this._value = value;
      this.SetImages();
    }
  }

  protected override void OnSizeChanged(EventArgs e)
  {
    int num1 = (int) Math.Round((double) (this.Width - 10) / 7.0);
    int num2 = this.Controls.Count - 1;
    for (int index = 0; index <= num2; ++index)
    {
      Control control = this.Controls[index];
      control.Width = !(this.Controls[index] is TextBox) ? num1 : num1 * 3;
      control.Height = this.Height;
      control.Top = 0;
      control.Left = index != 0 ? this.Controls[index - 1].Right + 2 : 0;
    }
    base.OnSizeChanged(e);
  }

  private void SetImages()
  {
    this.btnMF.Image = ImageCache.Instance.MoveFirst;
    this.btnML.Image = ImageCache.Instance.MoveLast;
    this.btnMN.Image = ImageCache.Instance.MoveNext;
    this.btnMP.Image = ImageCache.Instance.MovePrev;
    if (!this.EnforceBounds)
      return;
    if (this._value <= this._min)
    {
      this.btnMF.Enabled = false;
      this.btnMP.Enabled = false;
    }
    else
    {
      this.btnMF.Enabled = true;
      this.btnMP.Enabled = true;
      this.btnMP.Focus();
    }
    if (this._value >= this._max)
    {
      this.btnML.Enabled = false;
      this.btnMN.Enabled = false;
    }
    else
    {
      this.btnML.Enabled = true;
      this.btnMN.Enabled = true;
      this.btnMN.Focus();
    }
  }

  protected override void OnLoad(EventArgs e)
  {
    this.SetImages();
    base.OnLoad(e);
  }

  protected virtual void OnMinChanged()
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler minChangedEvent = this.MinChangedEvent;
    if (minChangedEvent == null)
      return;
    minChangedEvent((object) this, EventArgs.Empty);
  }

  protected virtual void OnMaxChanged()
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler maxChangedEvent = this.MaxChangedEvent;
    if (maxChangedEvent == null)
      return;
    maxChangedEvent((object) this, EventArgs.Empty);
  }

  protected virtual void OnValueChanged()
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler valueChangedEvent = this.ValueChangedEvent;
    if (valueChangedEvent == null)
      return;
    valueChangedEvent((object) this, EventArgs.Empty);
  }

  protected virtual void OnClickedMoveFirst()
  {
    if (this._autoMoveValue)
      this.Value = this._min;
    // ISSUE: reference to a compiler-generated field
    EventHandler clickedMoveFirstEvent = this.ClickedMoveFirstEvent;
    if (clickedMoveFirstEvent == null)
      return;
    clickedMoveFirstEvent((object) this, EventArgs.Empty);
  }

  protected virtual void OnClickedMoveLast()
  {
    if (this._autoMoveValue)
      this.Value = this._max;
    // ISSUE: reference to a compiler-generated field
    EventHandler clickedMoveLastEvent = this.ClickedMoveLastEvent;
    if (clickedMoveLastEvent == null)
      return;
    clickedMoveLastEvent((object) this, EventArgs.Empty);
  }

  protected virtual void OnClickedMoveNext()
  {
    if (this._autoMoveValue)
      ++this.Value;
    // ISSUE: reference to a compiler-generated field
    EventHandler clickedMoveNextEvent = this.ClickedMoveNextEvent;
    if (clickedMoveNextEvent == null)
      return;
    clickedMoveNextEvent((object) this, EventArgs.Empty);
  }

  protected virtual void OnClickedMovePrev()
  {
    if (this._autoMoveValue)
      --this.Value;
    // ISSUE: reference to a compiler-generated field
    EventHandler clickedMovePrevEvent = this.ClickedMovePrevEvent;
    if (clickedMovePrevEvent == null)
      return;
    clickedMovePrevEvent((object) this, EventArgs.Empty);
  }

  protected override void OnTextChanged(EventArgs e)
  {
    base.OnTextChanged(e);
    this.txtText.Text = this.Text;
  }

  public bool AutoMoveValue
  {
    get => this._autoMoveValue;
    set => this._autoMoveValue = value;
  }

  public new string Text
  {
    get => base.Text;
    set => base.Text = value;
  }

  private void btnMF_Click(object sender, EventArgs e) => this.OnClickedMoveFirst();

  private void btnMP_Click(object sender, EventArgs e) => this.OnClickedMovePrev();

  private void btnMN_Click(object sender, EventArgs e) => this.OnClickedMoveNext();

  private void btnML_Click(object sender, EventArgs e) => this.OnClickedMoveLast();
}
