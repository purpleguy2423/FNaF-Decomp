// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_TAN
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;
using System;

namespace RuntimeXNA.Expressions
{

    public class EXP_TAN : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        ++rhPtr.rh4CurToken;
        double num = Math.Tan(rhPtr.get_ExpressionDouble() / (180.0 / Math.PI));
        rhPtr.getCurrentResult().forceDouble(num);
      }
    }
}
