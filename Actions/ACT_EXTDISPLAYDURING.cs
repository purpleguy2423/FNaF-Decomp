// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_EXTDISPLAYDURING
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_EXTDISPLAYDURING : CAct
    {
      public override void execute(CRun rhPtr)
      {
        CObject actionObjects = rhPtr.rhEvtProg.get_ActionObjects((CAct) this);
        if (actionObjects == null || actionObjects.ros == null)
          return;
        actionObjects.ros.obHide();
        actionObjects.ros.rsFlags &= (short) -33;
        actionObjects.ros.rsFlash = ((PARAM_TIME) this.evtParams[0]).timer;
        actionObjects.ros.rsFlashCpt = ((PARAM_TIME) this.evtParams[0]).timer;
      }
    }
}
