// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_EXTSETSEMITRANSPARENCY
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_EXTSETSEMITRANSPARENCY : CAct
    {
      public override void execute(CRun rhPtr)
      {
        CObject actionObjects = rhPtr.rhEvtProg.get_ActionObjects((CAct) this);
        if (actionObjects == null || actionObjects.ros == null)
          return;
        int num = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]);
        if (num < 0)
          num = 0;
        if (num > 128 /*0x80*/)
          num = 128 /*0x80*/;
        actionObjects.ros.rsEffect &= -4096;
        actionObjects.ros.rsEffect |= 1;
        actionObjects.ros.rsEffectParam = num;
        actionObjects.roc.rcChanged = true;
        if (actionObjects.roc.rcSprite == null)
          return;
        actionObjects.hoAdRunHeader.rhApp.spriteGen.modifSpriteEffect(actionObjects.roc.rcSprite, actionObjects.ros.rsEffect, actionObjects.ros.rsEffectParam);
      }
    }
}
