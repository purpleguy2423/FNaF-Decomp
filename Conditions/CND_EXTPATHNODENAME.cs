// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_EXTPATHNODENAME
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_EXTPATHNODENAME : CCnd, IEvaObject
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr)
      {
        string expressionString = rhPtr.get_EventExpressionString((CParamExpression) this.evtParams[0]);
        return hoPtr.hoMT_NodeName != null && string.CompareOrdinal(hoPtr.hoMT_NodeName, expressionString) == 0;
      }

      public override bool eva2(CRun rhPtr) => this.evaObject(rhPtr, (IEvaObject) this);

      public virtual bool evaObjectRoutine(CObject hoPtr)
      {
        if (hoPtr.roc.rcMovementType != 5 || !this.checkMark(hoPtr.hoAdRunHeader, hoPtr.hoMark1))
          return false;
        string expressionString = hoPtr.hoAdRunHeader.get_EventExpressionString((CParamExpression) this.evtParams[0]);
        return hoPtr.hoMT_NodeName != null && string.CompareOrdinal(hoPtr.hoMT_NodeName, expressionString) == 0;
      }
    }
}
