// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_TIMER2
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    internal class CND_TIMER2 : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr) => this.eva2(rhPtr);

      public override bool eva2(CRun rhPtr)
      {
        int num = this.evtParams[0].code != (short) 22 ? ((PARAM_TIME) this.evtParams[0]).timer : rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]);
        PARAM_INT evtParam = (PARAM_INT) this.evtParams[1];
        if (rhPtr.rhTimer < (long) num)
          return false;
        if (evtParam.value_Renamed == rhPtr.rhLoopCount)
        {
          evtParam.value_Renamed = rhPtr.rhLoopCount + 1;
          return false;
        }
        evtParam.value_Renamed = rhPtr.rhLoopCount + 1;
        return true;
      }
    }
}
