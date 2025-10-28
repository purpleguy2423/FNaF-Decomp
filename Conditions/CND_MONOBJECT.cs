// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_MONOBJECT
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_MONOBJECT : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr) => this.eva2(rhPtr);

      public override bool eva2(CRun rhPtr)
      {
        bool nega = ((int) this.evtFlags2 & 1) != 0;
        PARAM_OBJECT evtParam = (PARAM_OBJECT) this.evtParams[0];
        return rhPtr.getMouseOnObjectsEDX(evtParam.oiList, nega);
      }
    }
}
