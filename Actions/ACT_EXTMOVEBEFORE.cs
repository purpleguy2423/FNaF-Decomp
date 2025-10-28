// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_EXTMOVEBEFORE
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;
using RuntimeXNA.Sprites;

namespace RuntimeXNA.Actions
{

    public class ACT_EXTMOVEBEFORE : CAct
    {
      public override void execute(CRun rhPtr)
      {
        CObject actionObjects = rhPtr.rhEvtProg.get_ActionObjects((CAct) this);
        if (actionObjects == null || actionObjects.ros == null)
          return;
        CObject paramActionObjects = rhPtr.rhEvtProg.get_ParamActionObjects(((PARAM_OBJECT) this.evtParams[0]).oiList, (CAct) this);
        if (paramActionObjects == null)
          return;
        CSprite rcSprite1 = actionObjects.roc.rcSprite;
        CSprite rcSprite2 = paramActionObjects.roc.rcSprite;
        if (rcSprite1 == null || rcSprite2 == null)
          return;
        rhPtr.rhApp.spriteGen.moveSpriteBefore(rcSprite1, rcSprite2);
      }
    }
}
