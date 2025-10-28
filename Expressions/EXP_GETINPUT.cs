// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_GETINPUT
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_GETINPUT : CExpOi
    {
      public override void evaluate(CRun rhPtr)
      {
        int oi = (int) this.oi;
        int num = 5;
        if (oi < 4)
          num = (int) rhPtr.rhApp.pcCtrlType[oi];
        if (num == 5)
          num = 0;
        rhPtr.getCurrentResult().forceInt(num);
      }
    }
}
