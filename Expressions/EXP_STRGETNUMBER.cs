// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_STRGETNUMBER
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.OI;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_STRGETNUMBER : CExpOi
    {
      public override void evaluate(CRun rhPtr)
      {
        CObject expressionObjects = rhPtr.rhEvtProg.get_ExpressionObjects(this.oiList);
        ++rhPtr.rh4CurToken;
        if (expressionObjects == null)
        {
          rhPtr.getCurrentResult().forceString("");
        }
        else
        {
          int index = rhPtr.get_ExpressionInt();
          CText ctext = (CText) expressionObjects;
          if (index < 0)
          {
            if (ctext.rsTextBuffer != null)
              rhPtr.getCurrentResult().forceString(ctext.rsTextBuffer);
            else
              rhPtr.getCurrentResult().forceString("");
          }
          else
          {
            if (index >= ctext.rsMaxi)
              index = ctext.rsMaxi - 1;
            CDefTexts ocObject = (CDefTexts) expressionObjects.hoCommon.ocObject;
            rhPtr.getCurrentResult().forceString(ocObject.otTexts[index].tsText);
          }
        }
      }
    }
}
