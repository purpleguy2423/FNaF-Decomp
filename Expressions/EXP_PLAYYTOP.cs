// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_PLAYYTOP
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_PLAYYTOP : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        int num = rhPtr.rhWindowY;
        if (((int) rhPtr.rh3Scrolling & 1) != 0)
          num = rhPtr.rh3DisplayY;
        if (num < 0)
          num = 0;
        rhPtr.getCurrentResult().forceInt(num);
      }
    }
}
