// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_STRSETSTRING
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_STRSETSTRING : CAct
    {
      public override void execute(CRun rhPtr)
      {
        CObject actionObjects = rhPtr.rhEvtProg.get_ActionObjects((CAct) this);
        if (actionObjects == null)
          return;
        string expressionString = rhPtr.get_EventExpressionString((CParamExpression) this.evtParams[0]);
        CText ctext = (CText) actionObjects;
        if (ctext.rsTextBuffer != null && (ctext.rsTextBuffer == null || string.CompareOrdinal(expressionString, ctext.rsTextBuffer) == 0))
          return;
        ctext.txtSetString(expressionString);
        ctext.txtChange(-1);
        if (((int) actionObjects.ros.rsFlags & 1) != 0)
          return;
        actionObjects.roc.rcChanged = true;
        actionObjects.display();
      }
    }
}
