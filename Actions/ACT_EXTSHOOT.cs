// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_EXTSHOOT
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_EXTSHOOT : CAct
    {
      public override void execute(CRun rhPtr)
      {
        CObject actionObjects = rhPtr.rhEvtProg.get_ActionObjects((CAct) this);
        if (actionObjects == null)
          return;
        PARAM_SHOOT evtParam = (PARAM_SHOOT) this.evtParams[0];
        CPositionInfo pInfo = new CPositionInfo();
        if (!evtParam.read_Position(rhPtr, 17, pInfo))
          return;
        actionObjects.shtCreate(evtParam, pInfo.x, pInfo.y, pInfo.dir);
      }
    }
}
