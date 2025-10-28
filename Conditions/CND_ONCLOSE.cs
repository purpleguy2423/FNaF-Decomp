// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_ONCLOSE
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_ONCLOSE : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr)
      {
        rhPtr.rh4MenuEaten = true;
        return true;
      }

      public override bool eva2(CRun rhPtr) => rhPtr.rh4OnCloseCount == rhPtr.rhLoopCount;
    }
}
