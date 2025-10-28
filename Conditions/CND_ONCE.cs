// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_ONCE
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Events;
using RuntimeXNA.Objects;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_ONCE : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr) => this.eva2(rhPtr);

      public override bool eva2(CRun rhPtr)
      {
        CEventGroup rhEventGroup = rhPtr.rhEvtProg.rhEventGroup;
        if (((int) rhEventGroup.evgFlags & 1) != 0)
          return false;
        rhEventGroup.evgFlags |= (ushort) 1;
        return true;
      }
    }
}
