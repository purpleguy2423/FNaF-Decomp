// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_STRDISPLAYDURING
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Events;
using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_STRDISPLAYDURING : CAct
    {
      public override void execute(CRun rhPtr)
      {
        PARAM_SHORT evtParam1 = (PARAM_SHORT) this.evtParams[1];
        int index = rhPtr.txtDoDisplay((CEvent) this, (int) evtParam1.value);
        if (index < 0)
          return;
        PARAM_TIME evtParam2 = (PARAM_TIME) this.evtParams[2];
        CObject rhObject = rhPtr.rhObjectList[index];
        rhObject.ros.rsFlash = evtParam2.timer;
        rhObject.ros.rsFlashCpt = evtParam2.timer;
      }
    }
}
