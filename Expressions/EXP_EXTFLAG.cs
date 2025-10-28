// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_EXTFLAG
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_EXTFLAG : CExpOi
    {
      public override void evaluate(CRun rhPtr)
      {
        CObject expressionObjects = rhPtr.rhEvtProg.get_ExpressionObjects(this.oiList);
        ++rhPtr.rh4CurToken;
        int expressionInt = rhPtr.get_ExpressionInt();
        if (expressionObjects == null)
        {
          rhPtr.getCurrentResult().forceInt(0);
        }
        else
        {
          int num1 = expressionInt & 31 /*0x1F*/;
          if (expressionObjects.rov != null)
          {
            int num2 = 0;
            if ((1 << num1 & expressionObjects.rov.rvValueFlags) != 0)
              num2 = 1;
            rhPtr.getCurrentResult().forceInt(num2);
          }
          else
            rhPtr.getCurrentResult().forceInt(0);
        }
      }
    }
}
