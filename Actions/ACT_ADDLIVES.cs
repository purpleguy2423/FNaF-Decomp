// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_ADDLIVES
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_ADDLIVES : CAct
    {
      public override void execute(CRun rhPtr)
      {
        int eventExpressionInt = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]);
        int evtOi = (int) this.evtOi;
        int live = rhPtr.rhApp.lives[evtOi] + eventExpressionInt;
        rhPtr.actPla_FinishLives(evtOi, live);
      }
    }
}
