// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_MOUSEWHEELDELTA
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_MOUSEWHEELDELTA : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        int num = 0;
        if (rhPtr.rh4MouseWheelDelta < (short) 0)
          num = 120;
        else if (rhPtr.rh4MouseWheelDelta > (short) 0)
          num = -120;
        rhPtr.getCurrentResult().forceInt(num);
      }
    }
}
