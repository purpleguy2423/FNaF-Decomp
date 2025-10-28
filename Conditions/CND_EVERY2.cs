// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_EVERY2
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    internal class CND_EVERY2 : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr) => this.eva2(rhPtr);

      public override bool eva2(CRun rhPtr)
      {
        PARAM_INT evtParam = (PARAM_INT) this.evtParams[1];
        if (evtParam.value2 == 0)
        {
          int num = this.evtParams[0].code != (short) 22 ? ((PARAM_TIME) this.evtParams[0]).timer : rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]);
          evtParam.value_Renamed = num;
          evtParam.value2 = -1;
        }
        else
        {
          evtParam.value_Renamed -= rhPtr.rhTimerDelta;
          if (evtParam.value_Renamed <= 0)
          {
            int num = this.evtParams[0].code != (short) 22 ? ((PARAM_TIME) this.evtParams[0]).timer : rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]);
            evtParam.value_Renamed += num;
            return true;
          }
        }
        return false;
      }
    }
}
