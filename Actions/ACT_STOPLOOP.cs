// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_STOPLOOP
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;
using System;

namespace RuntimeXNA.Actions
{

    public class ACT_STOPLOOP : CAct
    {
      public override void execute(CRun rhPtr)
      {
        string expressionString = rhPtr.get_EventExpressionString((CParamExpression) this.evtParams[0]);
        if (expressionString.Length == 0)
          return;
        for (int index = 0; index < rhPtr.rh4FastLoops.size(); ++index)
        {
          CLoop cloop = (CLoop) rhPtr.rh4FastLoops.get(index);
          if (string.Compare(cloop.name, expressionString, StringComparison.OrdinalIgnoreCase) == 0)
            cloop.flags |= (short) 1;
        }
      }
    }
}
