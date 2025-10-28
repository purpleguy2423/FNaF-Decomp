// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_GOLEVEL
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_GOLEVEL : CAct
    {
      public override void execute(CRun rhPtr)
      {
        short hCell;
        if (this.evtParams[0].code == (short) 26)
        {
          hCell = ((PARAM_SHORT) this.evtParams[0]).value;
          if (rhPtr.rhApp.HCellToNCell(hCell) == (short) -1)
            return;
        }
        else
        {
          short num = (short) (rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]) - 1);
          if (num < (short) 0 || num >= (short) 4096 /*0x1000*/)
            return;
          hCell = (short) ((int) num | (int) short.MinValue);
        }
        rhPtr.rhQuit = (short) 3;
        rhPtr.rhQuitParam = (int) hCell;
      }
    }
}
