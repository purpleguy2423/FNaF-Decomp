// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_CHOOSEZONE
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_CHOOSEZONE : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr) => this.eva2(rhPtr);

      public override bool eva2(CRun rhPtr)
      {
        PARAM_ZONE evtParam = (PARAM_ZONE) this.evtParams[0];
        rhPtr.rhEvtProg.count_ZoneTypeObjects(evtParam, -1, (short) 0);
        if (rhPtr.rhEvtProg.evtNSelectedObjects == 0)
          return false;
        int stop = (int) rhPtr.random((short) rhPtr.rhEvtProg.evtNSelectedObjects);
        CObject pHo = rhPtr.rhEvtProg.count_ZoneTypeObjects(evtParam, stop, (short) 0);
        rhPtr.rhEvtProg.evt_DeleteCurrent();
        rhPtr.rhEvtProg.evt_AddCurrentObject(pHo);
        return true;
      }
    }
}
