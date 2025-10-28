// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_CHOOSEALLINLINE
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_CHOOSEALLINLINE : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr) => this.eva2(rhPtr);

      public override bool eva2(CRun rhPtr)
      {
        int eventExpressionInt1 = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]);
        int eventExpressionInt2 = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[1]);
        int eventExpressionInt3 = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[2]);
        int eventExpressionInt4 = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[3]);
        return rhPtr.rhEvtProg.select_LineOfSight(eventExpressionInt1, eventExpressionInt2, eventExpressionInt3, eventExpressionInt4) != 0;
      }
    }
}
