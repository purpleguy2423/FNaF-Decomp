// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_ONLOOP
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Expressions;
using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;
using System;

namespace RuntimeXNA.Conditions
{

    public class CND_ONLOOP : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr)
      {
        CParamExpression evtParam = (CParamExpression) this.evtParams[0];
        if (evtParam.tokens.Length == 2 && evtParam.tokens[0].code == 262143 /*0x03FFFF*/ && evtParam.tokens[1].code == 0)
          return string.Compare(rhPtr.rh4CurrentFastLoop, ((EXP_STRING) evtParam.tokens[0]).pString, StringComparison.CurrentCultureIgnoreCase) == 0;
        string expressionString = rhPtr.get_EventExpressionString(evtParam);
        if (string.Compare(rhPtr.rh4CurrentFastLoop, expressionString, StringComparison.CurrentCultureIgnoreCase) != 0)
          return false;
        rhPtr.rhEvtProg.rh2ActionOn = false;
        return true;
      }

      public override bool eva2(CRun rhPtr) => false;
    }
}
