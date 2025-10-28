// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_SETTIMER
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_SETTIMER : CAct
    {
      public override void execute(CRun rhPtr)
      {
        long num = this.evtParams[0].code != (short) 22 ? (long) ((PARAM_TIME) this.evtParams[0]).timer : (long) rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]);
        rhPtr.rhTimer = num;
        rhPtr.rhTimerOld = rhPtr.rhApp.timer - rhPtr.rhTimer;
        rhPtr.rhEvtProg.restartTimerEvents();
      }
    }
}
