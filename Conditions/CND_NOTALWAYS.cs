// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_NOTALWAYS
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Events;
using RuntimeXNA.Objects;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_NOTALWAYS : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr) => this.eva2(rhPtr);

      public override bool eva2(CRun rhPtr)
      {
        CEventGroup rhEventGroup = rhPtr.rhEvtProg.rhEventGroup;
        if (((int) rhEventGroup.evgFlags & 2) != 0)
          return true;
        if (((int) rhEventGroup.evgFlags & 8) != 0)
          return false;
        rhEventGroup.evgInhibit = (ushort) 65534;
        rhEventGroup.evgFlags |= (ushort) 2;
        return true;
      }
    }
}
