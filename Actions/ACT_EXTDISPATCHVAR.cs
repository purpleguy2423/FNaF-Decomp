// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_EXTDISPATCHVAR
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_EXTDISPATCHVAR : CAct
    {
      public override void execute(CRun rhPtr)
      {
        CObject actionObjects = rhPtr.rhEvtProg.get_ActionObjects((CAct) this);
        if (actionObjects == null)
          return;
        int n = this.evtParams[0].code != (short) 53 ? (int) ((PARAM_SHORT) this.evtParams[0]).value : rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]);
        PARAM_INT evtParam = (PARAM_INT) this.evtParams[2];
        if (rhPtr.rhEvtProg.rh2ActionLoopCount == 0)
          evtParam.value_Renamed = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[1]);
        else
          ++evtParam.value_Renamed;
        if (actionObjects.rov == null)
          return;
        actionObjects.rov.getValue(n).forceInt(evtParam.value_Renamed);
      }
    }
}
