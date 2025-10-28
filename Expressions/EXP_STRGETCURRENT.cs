// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_STRGETCURRENT
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_STRGETCURRENT : CExpOi
    {
      public override void evaluate(CRun rhPtr)
      {
        CObject expressionObjects = rhPtr.rhEvtProg.get_ExpressionObjects(this.oiList);
        if (expressionObjects == null)
        {
          rhPtr.getCurrentResult().forceString("");
        }
        else
        {
          CText ctext = (CText) expressionObjects;
          if (ctext.rsTextBuffer != null)
            rhPtr.getCurrentResult().forceString(ctext.rsTextBuffer);
          else
            rhPtr.getCurrentResult().forceString("");
        }
      }
    }
}
