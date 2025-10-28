// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_LOOPINDEX
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Actions;
using RuntimeXNA.RunLoop;
using System;

namespace RuntimeXNA.Expressions
{

    public class EXP_LOOPINDEX : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        ++rhPtr.rh4CurToken;
        string expressionString = rhPtr.get_ExpressionString();
        for (int index = 0; index < rhPtr.rh4FastLoops.size(); ++index)
        {
          CLoop cloop = (CLoop) rhPtr.rh4FastLoops.get(index);
          if (string.Compare(cloop.name, expressionString, StringComparison.OrdinalIgnoreCase) == 0)
          {
            rhPtr.getCurrentResult().forceInt(cloop.index);
            return;
          }
        }
        rhPtr.getCurrentResult().forceInt(0);
      }
    }
}
