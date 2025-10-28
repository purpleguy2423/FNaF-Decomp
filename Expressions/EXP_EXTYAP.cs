// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_EXTYAP
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Banks;
using RuntimeXNA.Objects;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_EXTYAP : CExpOi
    {
      public override void evaluate(CRun rhPtr)
      {
        int num = 0;
        CObject expressionObjects = rhPtr.rhEvtProg.get_ExpressionObjects(this.oiList);
        if (expressionObjects != null)
        {
          num = expressionObjects.hoY;
          if (expressionObjects.roa != null)
          {
            CImage imageInfoEx = rhPtr.rhApp.imageBank.getImageInfoEx(expressionObjects.roc.rcImage, expressionObjects.roc.rcAngle, expressionObjects.roc.rcScaleX, expressionObjects.roc.rcScaleY);
            if (imageInfoEx != null)
              num += (int) imageInfoEx.yAP - (int) imageInfoEx.ySpot;
          }
        }
        rhPtr.getCurrentResult().forceInt(num);
      }
    }
}
