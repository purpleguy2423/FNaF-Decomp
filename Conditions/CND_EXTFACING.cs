// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_EXTFACING
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_EXTFACING : CCnd, IEvaExpObject, IEvaObject
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr) => this.eva2(rhPtr);

      public override bool eva2(CRun rhPtr)
      {
        return this.evtParams[0].code == (short) 29 ? this.evaObject(rhPtr, (IEvaObject) this) : this.evaExpObject(rhPtr, (IEvaExpObject) this);
      }

      public virtual bool evaObjectRoutine(CObject hoPtr)
      {
        int valueRenamed = ((PARAM_INT) this.evtParams[0]).value_Renamed;
        for (int index = 0; index < 32 /*0x20*/; ++index)
        {
          if ((1 << index & valueRenamed) != 0 && hoPtr.roc.rcDir == index)
            return this.negaTRUE();
        }
        return this.negaFALSE();
      }

      public virtual bool evaExpRoutine(CObject hoPtr, int value_Renamed, short comp)
      {
        value_Renamed &= 31 /*0x1F*/;
        return hoPtr.roc.rcDir == value_Renamed ? this.negaTRUE() : this.negaFALSE();
      }
    }
}
