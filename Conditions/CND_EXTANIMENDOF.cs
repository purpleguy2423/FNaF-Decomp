// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_EXTANIMENDOF
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_EXTANIMENDOF : CCnd, IEvaExpObject, IEvaObject
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr)
      {
        if ((this.evtParams[0].code != (short) 10 ? rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]) : (int) ((PARAM_SHORT) this.evtParams[0]).value) != rhPtr.rhEvtProg.rhCurParam0)
          return false;
        rhPtr.rhEvtProg.evt_AddCurrentObject(hoPtr);
        return true;
      }

      public override bool eva2(CRun rhPtr)
      {
        return this.evtParams[0].code == (short) 10 ? this.evaObject(rhPtr, (IEvaObject) this) : this.evaExpObject(rhPtr, (IEvaExpObject) this);
      }

      public virtual bool evaExpRoutine(CObject hoPtr, int value_Renamed, short comp)
      {
        return value_Renamed == hoPtr.roa.raAnimOn && hoPtr.roa.raAnimNumberOfFrame == 0;
      }

      public virtual bool evaObjectRoutine(CObject hoPtr)
      {
        return (int) ((PARAM_SHORT) this.evtParams[0]).value == hoPtr.roa.raAnimOn && hoPtr.roa.raAnimNumberOfFrame == 0;
      }
    }
}
