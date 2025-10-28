// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_MKEYDEPRESSED
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_MKEYDEPRESSED : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr) => this.eva2(rhPtr);

      public override bool eva2(CRun rhPtr)
      {
        switch (((PARAM_KEY) this.evtParams[0]).mouseKey)
        {
          case 1:
            if (rhPtr.mouseKey == 0)
              return this.negaTRUE();
            break;
          case 2:
            if (rhPtr.mouseKey == 2)
              return this.negaTRUE();
            break;
          case 3:
            if (rhPtr.mouseKey == 1)
              return this.negaTRUE();
            break;
        }
        return this.negaFALSE();
      }
    }
}
