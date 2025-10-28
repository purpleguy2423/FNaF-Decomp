// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_EXTSETALPHACOEF
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;
using RuntimeXNA.Services;

namespace RuntimeXNA.Actions
{

    internal class ACT_EXTSETALPHACOEF : CAct
    {
      public override void execute(CRun rhPtr)
      {
        CObject actionObjects = rhPtr.rhEvtProg.get_ActionObjects((CAct) this);
        if (actionObjects == null || actionObjects.ros == null)
          return;
        byte num1 = (byte) CServices.clamp((int) byte.MaxValue - rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]), 0, (int) byte.MaxValue);
        bool flag = (actionObjects.ros.rsEffect & 4096 /*0x1000*/) == 0;
        actionObjects.ros.rsEffect = actionObjects.ros.rsEffect & 4095 /*0x0FFF*/ | 4096 /*0x1000*/;
        int num2 = 16777215 /*0xFFFFFF*/;
        if (!flag)
          num2 = actionObjects.ros.rsEffectParam;
        int num3 = (int) num1 << 24;
        int num4 = num2 & 16777215 /*0xFFFFFF*/;
        actionObjects.ros.rsEffectParam = num3 | num4;
        actionObjects.roc.rcChanged = true;
        if (actionObjects.roc.rcSprite == null)
          return;
        actionObjects.hoAdRunHeader.rhApp.spriteGen.modifSpriteEffect(actionObjects.roc.rcSprite, actionObjects.ros.rsEffect, actionObjects.ros.rsEffectParam);
      }
    }
}
