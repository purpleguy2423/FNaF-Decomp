// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_PLAYXRIGHT
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_PLAYXRIGHT : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        int num1 = rhPtr.rhWindowX;
        if (((int) rhPtr.rh3Scrolling & 1) != 0)
          num1 = rhPtr.rh3DisplayX;
        int num2 = num1 + rhPtr.rh3WindowSx;
        if (num2 > rhPtr.rhLevelSx)
          num2 = rhPtr.rhLevelSx;
        rhPtr.getCurrentResult().forceInt(num2);
      }
    }
}
