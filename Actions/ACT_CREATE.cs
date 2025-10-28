// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_CREATE
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_CREATE : CAct
    {
      public override void execute(CRun rhPtr)
      {
        PARAM_CREATE evtParam = (PARAM_CREATE) this.evtParams[0];
        CPositionInfo pInfo = new CPositionInfo();
        if (evtParam.read_Position(rhPtr, 17, pInfo))
        {
          if (pInfo.bRepeat)
          {
            this.evtFlags |= (byte) 1;
            rhPtr.rhEvtProg.rh2ActionLoop = true;
          }
          else
            this.evtFlags &= (byte) 254;
        }
        int index = rhPtr.f_CreateObject(evtParam.cdpHFII, evtParam.cdpOi, pInfo.x, pInfo.y, pInfo.dir, (short) 0, pInfo.layer, -1);
        if (index < 0)
          return;
        CObject rhObject = rhPtr.rhObjectList[index];
        rhPtr.rhEvtProg.evt_AddCurrentObject(rhObject);
        if (pInfo.layer == -1 || (rhObject.hoOEFlags & 512 /*0x0200*/) == 0 || (rhPtr.rhFrame.layers[pInfo.layer].dwOptions & 131088 /*0x020010*/) == 16 /*0x10*/)
          return;
        rhObject.ros.obHide();
      }
    }
}
