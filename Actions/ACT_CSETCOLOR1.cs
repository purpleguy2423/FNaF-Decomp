// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_CSETCOLOR1
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;
using RuntimeXNA.Services;

namespace RuntimeXNA.Actions
{

    public class ACT_CSETCOLOR1 : CAct
    {
      public override void execute(CRun rhPtr)
      {
        CObject actionObjects = rhPtr.rhEvtProg.get_ActionObjects((CAct) this);
        if (actionObjects == null)
          return;
        int rgb = this.evtParams[0].code != (short) 22 ? ((PARAM_COLOUR) this.evtParams[0]).color : CServices.swapRGB(rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]));
        ((CCounter) actionObjects).cpt_SetColor1(rgb);
      }
    }
}
