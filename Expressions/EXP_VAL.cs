// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_VAL
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;
using RuntimeXNA.Services;

namespace RuntimeXNA.Expressions
{

    public class EXP_VAL : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        ++rhPtr.rh4CurToken;
        string expressionString = rhPtr.get_ExpressionString();
        CFuncVal cfuncVal = new CFuncVal();
        switch (cfuncVal.parse(expressionString))
        {
          case 0:
            rhPtr.getCurrentResult().forceInt(cfuncVal.intValue);
            break;
          case 1:
            rhPtr.getCurrentResult().forceDouble(cfuncVal.doubleValue);
            break;
        }
      }
    }
}
