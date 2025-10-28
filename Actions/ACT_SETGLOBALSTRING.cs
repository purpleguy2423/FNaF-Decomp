// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_SETGLOBALSTRING
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_SETGLOBALSTRING : CAct
    {
      public override void execute(CRun rhPtr)
      {
        int num = this.evtParams[0].code != (short) 52 ? (int) ((PARAM_SHORT) this.evtParams[0]).value : rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]) - 1;
        string expressionString = rhPtr.get_EventExpressionString((CParamExpression) this.evtParams[1]);
        rhPtr.rhApp.setGlobalStringAt(num, expressionString);
      }
    }
}
