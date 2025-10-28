// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_SPRPASTE
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;
using RuntimeXNA.Services;

namespace RuntimeXNA.Actions
{

    public class ACT_SPRPASTE : CAct
    {
      public override void execute(CRun rhPtr)
      {
        CObject actionObjects = rhPtr.rhEvtProg.get_ActionObjects((CAct) this);
        if (actionObjects == null)
          return;
        if (actionObjects.roa != null)
          actionObjects.roa.animIn(0);
        if (actionObjects.hoLayer == 0 && actionObjects.roc.rcSprite != null)
          rhPtr.rhApp.spriteGen.activeSprite(actionObjects.roc.rcSprite, 1, (CRect) null);
        rhPtr.activeToBackdrop(actionObjects, (int) ((PARAM_SHORT) this.evtParams[0]).value, false);
      }
    }
}
