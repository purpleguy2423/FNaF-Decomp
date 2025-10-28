// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_SETFRAMERATE
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Application;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_SETFRAMERATE : CAct
    {
      public override void execute(CRun rhPtr)
      {
        int eventExpressionInt = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]);
        if (eventExpressionInt < 1 || eventExpressionInt > 1000)
          return;
        CRunApp crunApp = rhPtr.rhApp;
        while (crunApp.parentApp != null)
          crunApp = crunApp.parentApp;
        crunApp.gaFrameRate = eventExpressionInt;
        crunApp.setFrameRate(eventExpressionInt);
      }
    }
}
