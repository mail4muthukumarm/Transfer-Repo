// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ExcelFormula
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

#nullable disable
namespace MGASystems.Tools;

public class ExcelFormula : IList<ExcelFormulaToken>
{
  private string m_formula;
  private List<ExcelFormulaToken> tokens;

  private ExcelFormula()
  {
  }

  public ExcelFormula(string formula)
  {
    this.m_formula = formula != null ? formula.Trim() : throw new ArgumentNullException(nameof (formula));
    this.tokens = new List<ExcelFormulaToken>();
    this.ParseToTokens();
  }

  public string Formula => this.m_formula;

  public ExcelFormulaToken this[int index]
  {
    get => this.tokens[index];
    set => throw new NotSupportedException();
  }

  public int IndexOf(ExcelFormulaToken item) => this.tokens.IndexOf(item);

  public void Insert(int index, ExcelFormulaToken item) => throw new NotSupportedException();

  public void RemoveAt(int index) => throw new NotSupportedException();

  void ICollection<ExcelFormulaToken>.Add(ExcelFormulaToken item)
  {
    throw new NotSupportedException();
  }

  void ICollection<ExcelFormulaToken>.Clear() => throw new NotSupportedException();

  bool ICollection<ExcelFormulaToken>.Contains(ExcelFormulaToken item)
  {
    return this.tokens.Contains(item);
  }

  bool ICollection<ExcelFormulaToken>.IsReadOnly => true;

  bool ICollection<ExcelFormulaToken>.Remove(ExcelFormulaToken item)
  {
    throw new NotSupportedException();
  }

  void ICollection<ExcelFormulaToken>.CopyTo(ExcelFormulaToken[] array, int arrayIndex)
  {
    this.tokens.CopyTo(array, arrayIndex);
  }

  int ICollection<ExcelFormulaToken>.Count => this.tokens.Count;

  IEnumerator<ExcelFormulaToken> IEnumerable<ExcelFormulaToken>.GetEnumerator()
  {
    return (IEnumerator<ExcelFormulaToken>) this.tokens.GetEnumerator();
  }

  IEnumerator IEnumerable.IEnumerable_GetEnumerator() => (IEnumerator) this.GetEnumerator();

  private void ParseToTokens()
  {
    if (this.m_formula.Length < 2 || this.m_formula[0] != '=')
      return;
    ExcelFormula.ExcelFormulaTokens excelFormulaTokens1 = new ExcelFormula.ExcelFormulaTokens();
    ExcelFormula.ExcelFormulaStack excelFormulaStack = new ExcelFormula.ExcelFormulaStack();
    string[] array1 = new string[7]
    {
      "#NULL!",
      "#DIV/0!",
      "#VALUE!",
      "#REF!",
      "#NAME?",
      "#NUM!",
      "#N/A"
    };
    string[] array2 = new string[3]{ ">=", "<=", "<>" };
    bool flag1 = false;
    bool flag2 = false;
    bool flag3 = false;
    bool flag4 = false;
    int num = 1;
    string input = "";
    while (num < this.m_formula.Length)
    {
      if (flag1)
      {
        if (this.m_formula[num] == '"')
        {
          if (num + 2 <= this.m_formula.Length && this.m_formula[num + 1] == '"')
          {
            input += "\"";
            ++num;
          }
          else
          {
            flag1 = false;
            excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Operand, ExcelFormulaTokenSubtype.Text));
            input = "";
          }
        }
        else
          input += Conversions.ToString(this.m_formula[num]);
        ++num;
        continue;
      }
      if (flag2)
      {
        if (this.m_formula[num] == '\'')
        {
          if (num + 2 <= this.m_formula.Length && this.m_formula[num + 1] == '\'')
          {
            input += "'";
            ++num;
          }
          else
            flag2 = false;
        }
        else
          input += Conversions.ToString(this.m_formula[num]);
        ++num;
        continue;
      }
      if (flag3)
      {
        if (this.m_formula[num] == ']')
          flag3 = false;
        input += Conversions.ToString(this.m_formula[num]);
        ++num;
        continue;
      }
      if (flag4)
      {
        input += Conversions.ToString(this.m_formula[num]);
        ++num;
        if (Array.IndexOf<string>(array1, input) != -1)
        {
          flag4 = false;
          excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Operand, ExcelFormulaTokenSubtype.Error));
          input = "";
          continue;
        }
        continue;
      }
      if ("+-".IndexOf(this.m_formula[num]) != -1 && input.Length > 1 && Regex.IsMatch(input, "^[1-9]{1}(\\.[0-9]+)?E{1}$"))
      {
        input += Conversions.ToString(this.m_formula[num]);
        ++num;
        continue;
      }
      if (this.m_formula[num] == '"')
      {
        if (input.Length > 0)
        {
          excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Unknown));
          input = "";
        }
        flag1 = true;
        ++num;
        continue;
      }
      if (this.m_formula[num] == '\'')
      {
        if (input.Length > 0)
        {
          excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Unknown));
          input = "";
        }
        flag2 = true;
        ++num;
        continue;
      }
      if (this.m_formula[num] == '[')
      {
        flag3 = true;
        input += "[";
        ++num;
        continue;
      }
      if (this.m_formula[num] == '#')
      {
        if (input.Length > 0)
        {
          excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Unknown));
          input = "";
        }
        flag4 = true;
        input += "#";
        ++num;
        continue;
      }
      if (this.m_formula[num] == '{')
      {
        if (input.Length > 0)
        {
          excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Unknown));
          input = "";
        }
        excelFormulaStack.Push(excelFormulaTokens1.Add(new ExcelFormulaToken("ARRAY", ExcelFormulaTokenType.Function, ExcelFormulaTokenSubtype.Start)));
        excelFormulaStack.Push(excelFormulaTokens1.Add(new ExcelFormulaToken("ARRAYROW", ExcelFormulaTokenType.Function, ExcelFormulaTokenSubtype.Start)));
        ++num;
        continue;
      }
      if (this.m_formula[num] == ';')
      {
        if (input.Length > 0)
        {
          excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Operand));
          input = "";
        }
        excelFormulaTokens1.Add(excelFormulaStack.Pop());
        excelFormulaTokens1.Add(new ExcelFormulaToken(",", ExcelFormulaTokenType.Argument));
        excelFormulaStack.Push(excelFormulaTokens1.Add(new ExcelFormulaToken("ARRAYROW", ExcelFormulaTokenType.Function, ExcelFormulaTokenSubtype.Start)));
        ++num;
        continue;
      }
      if (this.m_formula[num] == '}')
      {
        if (input.Length > 0)
        {
          excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Operand));
          input = "";
        }
        excelFormulaTokens1.Add(excelFormulaStack.Pop());
        excelFormulaTokens1.Add(excelFormulaStack.Pop());
        ++num;
        continue;
      }
      if (this.m_formula[num] == ' ')
      {
        if (input.Length > 0)
        {
          excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Operand));
          input = "";
        }
        excelFormulaTokens1.Add(new ExcelFormulaToken("", ExcelFormulaTokenType.Whitespace));
        ++num;
        while (true)
        {
          if (this.m_formula[num] == ' ' && num < this.m_formula.Length)
            ++num;
          else
            goto label_87;
        }
      }
      else
      {
        if (num + 2 <= this.m_formula.Length && Array.IndexOf<string>(array2, this.m_formula.Substring(num, 2)) != -1)
        {
          if (input.Length > 0)
          {
            excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Operand));
            input = "";
          }
          excelFormulaTokens1.Add(new ExcelFormulaToken(this.m_formula.Substring(num, 2), ExcelFormulaTokenType.OperatorInfix, ExcelFormulaTokenSubtype.Logical));
          num += 2;
          continue;
        }
        if ("+-*/^&=><".IndexOf(this.m_formula[num]) != -1)
        {
          if (input.Length > 0)
          {
            excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Operand));
            input = "";
          }
          excelFormulaTokens1.Add(new ExcelFormulaToken(this.m_formula[num].ToString(), ExcelFormulaTokenType.OperatorInfix));
          ++num;
          continue;
        }
        if ("%".IndexOf(this.m_formula[num]) != -1)
        {
          if (input.Length > 0)
          {
            excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Operand));
            input = "";
          }
          excelFormulaTokens1.Add(new ExcelFormulaToken(this.m_formula[num].ToString(), ExcelFormulaTokenType.OperatorPostfix));
          ++num;
          continue;
        }
        if (this.m_formula[num] == '(')
        {
          if (input.Length > 0)
          {
            excelFormulaStack.Push(excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Function, ExcelFormulaTokenSubtype.Start)));
            input = "";
          }
          else
            excelFormulaStack.Push(excelFormulaTokens1.Add(new ExcelFormulaToken("", ExcelFormulaTokenType.Subexpression, ExcelFormulaTokenSubtype.Start)));
          ++num;
          continue;
        }
        if (this.m_formula[num] == ',')
        {
          if (input.Length > 0)
          {
            excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Operand));
            input = "";
          }
          if (excelFormulaStack.Current.Type != ExcelFormulaTokenType.Function)
            excelFormulaTokens1.Add(new ExcelFormulaToken(",", ExcelFormulaTokenType.OperatorInfix, ExcelFormulaTokenSubtype.Union));
          else
            excelFormulaTokens1.Add(new ExcelFormulaToken(",", ExcelFormulaTokenType.Argument));
          ++num;
          continue;
        }
        if (this.m_formula[num] == ')')
        {
          if (input.Length > 0)
          {
            excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Operand));
            input = "";
          }
          excelFormulaTokens1.Add(excelFormulaStack.Pop());
          ++num;
          continue;
        }
        input += Conversions.ToString(this.m_formula[num]);
        ++num;
        continue;
      }
label_87:;
    }
    if (input.Length > 0)
      excelFormulaTokens1.Add(new ExcelFormulaToken(input, ExcelFormulaTokenType.Operand));
    ExcelFormula.ExcelFormulaTokens excelFormulaTokens2 = new ExcelFormula.ExcelFormulaTokens(excelFormulaTokens1.Count);
    while (excelFormulaTokens1.MoveNext())
    {
      ExcelFormulaToken current = excelFormulaTokens1.Current;
      if (current != null)
      {
        if (current.Type != ExcelFormulaTokenType.Whitespace)
          excelFormulaTokens2.Add(current);
        else if (!excelFormulaTokens1.BOF && !excelFormulaTokens1.EOF)
        {
          ExcelFormulaToken previous = excelFormulaTokens1.Previous;
          if (previous != null && (previous.Type == ExcelFormulaTokenType.Function && previous.Subtype == ExcelFormulaTokenSubtype.Stop || previous.Type == ExcelFormulaTokenType.Subexpression && previous.Subtype == ExcelFormulaTokenSubtype.Stop || previous.Type == ExcelFormulaTokenType.Operand))
          {
            ExcelFormulaToken next = excelFormulaTokens1.Next;
            if (next != null && (next.Type == ExcelFormulaTokenType.Function && next.Subtype == ExcelFormulaTokenSubtype.Start || next.Type == ExcelFormulaTokenType.Subexpression && next.Subtype == ExcelFormulaTokenSubtype.Start || next.Type == ExcelFormulaTokenType.Operand))
              excelFormulaTokens2.Add(new ExcelFormulaToken("", ExcelFormulaTokenType.OperatorInfix, ExcelFormulaTokenSubtype.Intersection));
          }
        }
      }
    }
    this.tokens = new List<ExcelFormulaToken>(excelFormulaTokens2.Count);
    while (excelFormulaTokens2.MoveNext())
    {
      ExcelFormulaToken current = excelFormulaTokens2.Current;
      if (current != null)
      {
        ExcelFormulaToken previous = excelFormulaTokens2.Previous;
        ExcelFormulaToken next = excelFormulaTokens2.Next;
        if (current.Type == ExcelFormulaTokenType.OperatorInfix && Operators.CompareString(current.Value, "-", false) == 0)
        {
          if (excelFormulaTokens2.BOF)
            current.Type = ExcelFormulaTokenType.OperatorPrefix;
          else if (previous.Type == ExcelFormulaTokenType.Function && previous.Subtype == ExcelFormulaTokenSubtype.Stop || previous.Type == ExcelFormulaTokenType.Subexpression && previous.Subtype == ExcelFormulaTokenSubtype.Stop || previous.Type == ExcelFormulaTokenType.OperatorPostfix || previous.Type == ExcelFormulaTokenType.Operand)
            current.Subtype = ExcelFormulaTokenSubtype.Math;
          else
            current.Type = ExcelFormulaTokenType.OperatorPrefix;
          this.tokens.Add(current);
        }
        else if (current.Type == ExcelFormulaTokenType.OperatorInfix && Operators.CompareString(current.Value, "+", false) == 0)
        {
          if (!excelFormulaTokens2.BOF && (previous.Type == ExcelFormulaTokenType.Function && previous.Subtype == ExcelFormulaTokenSubtype.Stop || previous.Type == ExcelFormulaTokenType.Subexpression && previous.Subtype == ExcelFormulaTokenSubtype.Stop || previous.Type == ExcelFormulaTokenType.OperatorPostfix || previous.Type == ExcelFormulaTokenType.Operand))
          {
            current.Subtype = ExcelFormulaTokenSubtype.Math;
            this.tokens.Add(current);
          }
        }
        else if (current.Type == ExcelFormulaTokenType.OperatorInfix && current.Subtype == ExcelFormulaTokenSubtype.Nothing)
        {
          current.Subtype = "<>=".IndexOf(current.Value.Substring(0, 1)) == -1 ? (Operators.CompareString(current.Value, "&", false) != 0 ? ExcelFormulaTokenSubtype.Math : ExcelFormulaTokenSubtype.Concatenation) : ExcelFormulaTokenSubtype.Logical;
          this.tokens.Add(current);
        }
        else if (current.Type == ExcelFormulaTokenType.Operand && current.Subtype == ExcelFormulaTokenSubtype.Nothing)
        {
          current.Subtype = double.TryParse(current.Value, NumberStyles.Any, (IFormatProvider) CultureInfo.CurrentCulture, out double _) ? ExcelFormulaTokenSubtype.Number : (Operators.CompareString(current.Value, "TRUE", false) == 0 || Operators.CompareString(current.Value, "FALSE", false) == 0 ? ExcelFormulaTokenSubtype.Logical : ExcelFormulaTokenSubtype.Range);
          this.tokens.Add(current);
        }
        else
        {
          if (current.Type == ExcelFormulaTokenType.Function && current.Value.Length > 0 && Operators.CompareString(current.Value.Substring(0, 1), "@", false) == 0)
            current.Value = current.Value.Substring(1);
          this.tokens.Add(current);
        }
      }
    }
  }

  internal class ExcelFormulaTokens
  {
    private int index;
    private List<ExcelFormulaToken> tokens;

    public ExcelFormulaTokens()
      : this(4)
    {
    }

    public ExcelFormulaTokens(int capacity)
    {
      this.index = -1;
      this.tokens = new List<ExcelFormulaToken>(capacity);
    }

    public int Count => this.tokens.Count;

    public bool BOF => this.index <= 0;

    public bool EOF => this.index >= this.tokens.Count - 1;

    public ExcelFormulaToken Current
    {
      get => this.index != -1 ? this.tokens[this.index] : (ExcelFormulaToken) null;
    }

    public ExcelFormulaToken Next
    {
      get => !this.EOF ? this.tokens[this.index + 1] : (ExcelFormulaToken) null;
    }

    public ExcelFormulaToken Previous
    {
      get => this.index >= 1 ? this.tokens[this.index - 1] : (ExcelFormulaToken) null;
    }

    public ExcelFormulaToken Add(ExcelFormulaToken token)
    {
      this.tokens.Add(token);
      return token;
    }

    public bool MoveNext()
    {
      bool flag;
      if (this.EOF)
      {
        flag = false;
      }
      else
      {
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num = ^(local = ref this.index) + 1;
        local = num;
        flag = true;
      }
      return flag;
    }

    public void Reset() => this.index = -1;
  }

  internal class ExcelFormulaStack
  {
    private Stack<ExcelFormulaToken> stack;

    public ExcelFormulaStack() => this.stack = new Stack<ExcelFormulaToken>();

    public void Push(ExcelFormulaToken token) => this.stack.Push(token);

    public ExcelFormulaToken Pop()
    {
      return this.stack.Count != 0 ? new ExcelFormulaToken("", this.stack.Pop().Type, ExcelFormulaTokenSubtype.Stop) : (ExcelFormulaToken) null;
    }

    public ExcelFormulaToken Current
    {
      get => this.stack.Count <= 0 ? (ExcelFormulaToken) null : this.stack.Peek();
    }
  }
}
