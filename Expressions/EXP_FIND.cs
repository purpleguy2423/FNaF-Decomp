// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_FIND
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_FIND : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        ++rhPtr.rh4CurToken;
        string expressionString1 = rhPtr.get_ExpressionString();
        ++rhPtr.rh4CurToken;
        string expressionString2 = rhPtr.get_ExpressionString();
        ++rhPtr.rh4CurToken;
        int expressionInt = rhPtr.get_ExpressionInt();
        if (expressionInt >= expressionString1.Length)
          rhPtr.getCurrentResult().forceInt(-1);
        else
          rhPtr.getCurrentResult().forceInt(expressionString1.IndexOf(expressionString2, expressionInt));
      }
    }
}
