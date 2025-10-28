// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_COMPARE
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Expressions;
using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_COMPARE : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr) => this.eva2(rhPtr);

      public override bool eva2(CRun rhPtr)
      {
        CValue pValue1 = new CValue();
        pValue1.forceValue(rhPtr.get_EventExpressionAny((CParamExpression) this.evtParams[0]));
        CParamExpression evtParam = (CParamExpression) this.evtParams[1];
        CValue eventExpressionAny = rhPtr.get_EventExpressionAny(evtParam);
        return CRun.compareTo(pValue1, eventExpressionAny, evtParam.comparaison);
      }
    }
}
