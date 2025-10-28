// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_QEQUAL
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_QEQUAL : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr)
      {
        int eventExpressionInt = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]);
        return rhPtr.rhEvtProg.rhCurParam0 == eventExpressionInt;
      }

      public override bool eva2(CRun rhPtr) => false;
    }
}
