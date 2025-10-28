// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_DELCREATEDBKDAT
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_DELCREATEDBKDAT : CAct
    {
      public override void execute(CRun rhPtr)
      {
        int nLayer = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]) - 1;
        int x = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[1]) - rhPtr.rhWindowX;
        int y = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[2]) - rhPtr.rhWindowY;
        bool bFineDetection = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[3]) != 0;
        rhPtr.deleteBackdrop2At(nLayer, x, y, bFineDetection);
      }
    }
}
