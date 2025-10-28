// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_EXTALPHACOEF
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    internal class EXP_EXTALPHACOEF : CExpOi
    {
      public override void evaluate(CRun rhPtr)
      {
        CObject expressionObjects = rhPtr.rhEvtProg.get_ExpressionObjects(this.oiList);
        if (expressionObjects == null || expressionObjects.ros == null)
        {
          rhPtr.getCurrentResult().forceInt(0);
        }
        else
        {
          int rsEffect = expressionObjects.ros.rsEffect;
          int rsEffectParam = expressionObjects.ros.rsEffectParam;
          int num1 = rsEffectParam;
          int num2 = (rsEffect & 4095 /*0x0FFF*/) == 13 || (rsEffect & 4096 /*0x1000*/) != 0 ? (int) byte.MaxValue - (num1 >> 24 & (int) byte.MaxValue) : (rsEffectParam != -1 ? rsEffectParam * 2 : 0);
          rhPtr.getCurrentResult().forceInt(num2);
        }
      }
    }
}
