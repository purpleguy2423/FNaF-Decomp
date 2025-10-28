// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_TIMHOURS
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_TIMHOURS : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        int num = (int) (rhPtr.rhTimer / 3600000L);
        rhPtr.getCurrentResult().forceInt(num);
      }
    }
}
