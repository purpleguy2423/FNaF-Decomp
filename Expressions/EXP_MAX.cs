// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_MAX
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;
using System;

namespace RuntimeXNA.Expressions
{

    public class EXP_MAX : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        ++rhPtr.rh4CurToken;
        CValue expressionAny1 = rhPtr.get_ExpressionAny();
        ++rhPtr.rh4CurToken;
        CValue expressionAny2 = rhPtr.get_ExpressionAny();
        if (expressionAny1.type == (byte) 0 && expressionAny2.type == (byte) 0)
        {
          int intValue1 = expressionAny1.intValue;
          int intValue2 = expressionAny2.intValue;
          if (intValue1 > intValue2)
            rhPtr.getCurrentResult().forceInt(intValue1);
          else
            rhPtr.getCurrentResult().forceInt(intValue2);
        }
        else
          rhPtr.getCurrentResult().forceDouble(Math.Max(expressionAny1.getDouble(), expressionAny2.getDouble()));
      }
    }
}
