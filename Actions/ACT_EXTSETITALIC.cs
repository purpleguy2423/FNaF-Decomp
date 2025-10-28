// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_EXTSETITALIC
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;
using RuntimeXNA.Services;

namespace RuntimeXNA.Actions
{

    public class ACT_EXTSETITALIC : CAct
    {
      public override void execute(CRun rhPtr)
      {
        CObject actionObjects = rhPtr.rhEvtProg.get_ActionObjects((CAct) this);
        if (actionObjects == null)
          return;
        int eventExpressionInt = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]);
        CFontInfo objectFont = CRun.getObjectFont(actionObjects);
        objectFont.lfItalic = (byte) eventExpressionInt;
        CRun.setObjectFont(actionObjects, objectFont, (CRect) null);
      }
    }
}
