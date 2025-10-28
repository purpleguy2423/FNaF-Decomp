// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_FRAMERATE
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_FRAMERATE : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        int num = 0;
        for (int index = 0; index < 10; ++index)
          num += rhPtr.rh4FrameRateArray[index];
        if (num != 0)
          rhPtr.getCurrentResult().forceInt(10000 / num);
        else
          rhPtr.getCurrentResult().forceInt(0);
      }
    }
}
