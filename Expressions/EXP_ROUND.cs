// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_ROUND
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;
using System;

namespace RuntimeXNA.Expressions
{

    public class EXP_ROUND : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        ++rhPtr.rh4CurToken;
        double expressionDouble = rhPtr.get_ExpressionDouble();
        double num = Math.Floor(expressionDouble);
        if (expressionDouble - num > 0.5)
          ++num;
        rhPtr.getCurrentResult().forceInt((int) num);
      }
    }
}
