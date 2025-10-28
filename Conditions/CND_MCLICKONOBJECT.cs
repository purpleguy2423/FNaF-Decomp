// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_MCLICKONOBJECT
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Events;
using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_MCLICKONOBJECT : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr)
      {
        PARAM_SHORT evtParam1 = (PARAM_SHORT) this.evtParams[0];
        if (rhPtr.rhEvtProg.rhCurParam0 != (int) evtParam1.value)
          return false;
        short rhCurParam1 = (short) rhPtr.rhEvtProg.rhCurParam1;
        PARAM_OBJECT evtParam2 = (PARAM_OBJECT) this.evtParams[1];
        if ((int) rhCurParam1 == (int) evtParam2.oi)
        {
          rhPtr.rhEvtProg.evt_AddCurrentObject(rhPtr.rhEvtProg.rh4_2ndObject);
          return true;
        }
        short oiList = evtParam2.oiList;
        if (oiList >= (short) 0)
          return false;
        CQualToOiList qualToOi = rhPtr.rhEvtProg.qualToOiList[(int) oiList & (int) short.MaxValue];
        for (int index = 0; index < qualToOi.qoiList.Length; index += 2)
        {
          if ((int) qualToOi.qoiList[index] == (int) rhCurParam1)
          {
            rhPtr.rhEvtProg.evt_AddCurrentQualifier(oiList);
            rhPtr.rhEvtProg.evt_AddCurrentObject(rhPtr.rhEvtProg.rh4_2ndObject);
            return true;
          }
        }
        return false;
      }

      public override bool eva2(CRun rhPtr)
      {
        PARAM_SHORT evtParam1 = (PARAM_SHORT) this.evtParams[0];
        if ((int) rhPtr.rhEvtProg.rh2CurrentClick != (int) evtParam1.value)
          return false;
        PARAM_OBJECT evtParam2 = (PARAM_OBJECT) this.evtParams[1];
        return rhPtr.getMouseOnObjectsEDX(evtParam2.oiList, false);
      }
    }
}
