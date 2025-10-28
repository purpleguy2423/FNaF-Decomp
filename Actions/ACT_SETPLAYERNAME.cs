// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_SETPLAYERNAME
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_SETPLAYERNAME : CAct
    {
      public override void execute(CRun rhPtr)
      {
        int evtOi = (int) this.evtOi;
        if (evtOi >= 4)
          return;
        string expressionString = rhPtr.get_EventExpressionString((CParamExpression) this.evtParams[0]);
        rhPtr.rhApp.playerNames[evtOi] = expressionString;
      }
    }
}
