// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_EXTSETEFFECT
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    internal class ACT_EXTSETEFFECT : CAct
    {
      public override void execute(CRun rhPtr)
      {
        CObject actionObjects = rhPtr.rhEvtProg.get_ActionObjects((CAct) this);
        if (actionObjects == null)
          return;
        string pEffect = ((PARAM_EFFECT) this.evtParams[0]).pEffect;
        int effect = 0;
        switch (pEffect)
        {
          case null:
            return;
          case "":
            return;
          case "Add":
            effect = 9;
            break;
          case "Invert":
            effect = 2;
            break;
          case "Sub":
            effect = 11;
            break;
          case "Mono":
            effect = 10;
            break;
          case "Blend":
            effect = 1;
            break;
          case "XOR":
            effect = 3;
            break;
          case "OR":
            effect = 5;
            break;
          case "AND":
            effect = 4;
            break;
        }
        actionObjects.ros.modifSpriteEffect(effect, actionObjects.ros.rsEffectParam);
      }
    }
}
