// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_MCLICKINZONE
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_MCLICKINZONE : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr)
      {
        if ((int) ((PARAM_SHORT) this.evtParams[0]).value == (int) (short) rhPtr.rhEvtProg.rhCurParam0)
        {
          PARAM_ZONE evtParam = (PARAM_ZONE) this.evtParams[1];
          if (rhPtr.rh2MouseX >= (int) evtParam.x1 && rhPtr.rh2MouseX < (int) evtParam.x2 && rhPtr.rh2MouseY >= (int) evtParam.y1 && rhPtr.rh2MouseY < (int) evtParam.y2)
            return true;
        }
        return false;
      }

      public override bool eva2(CRun rhPtr)
      {
        if ((int) ((PARAM_SHORT) this.evtParams[0]).value == (int) rhPtr.rhEvtProg.rh2CurrentClick)
        {
          PARAM_ZONE evtParam = (PARAM_ZONE) this.evtParams[1];
          if (rhPtr.rh2MouseX >= (int) evtParam.x1 && rhPtr.rh2MouseX < (int) evtParam.x2 && rhPtr.rh2MouseY >= (int) evtParam.y1 && rhPtr.rh2MouseY < (int) evtParam.y2)
            return true;
        }
        return false;
      }
    }
}
