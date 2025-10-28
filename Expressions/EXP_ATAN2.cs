// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_ATAN2
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;
using System;

namespace RuntimeXNA.Expressions
{

    public class EXP_ATAN2 : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        ++rhPtr.rh4CurToken;
        double expressionDouble1 = rhPtr.get_ExpressionDouble();
        ++rhPtr.rh4CurToken;
        double expressionDouble2 = rhPtr.get_ExpressionDouble();
        rhPtr.getCurrentResult().forceDouble(Math.Atan2(expressionDouble1, expressionDouble2) * 180.0 / Math.PI);
      }
    }
}
