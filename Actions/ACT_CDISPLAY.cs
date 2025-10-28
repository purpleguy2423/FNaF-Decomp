// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_CDISPLAY
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_CDISPLAY : CAct
    {
      public override void execute(CRun rhPtr)
      {
        CPosition evtParam = (CPosition) this.evtParams[0];
        CPositionInfo pInfo = new CPositionInfo();
        evtParam.read_Position(rhPtr, 0, pInfo);
        rhPtr.setDisplay(pInfo.x, pInfo.y, pInfo.layer, 3);
      }
    }
}
