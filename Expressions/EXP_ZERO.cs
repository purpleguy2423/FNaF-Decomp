// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_ZERO
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    internal class EXP_ZERO : CExp
    {
      public override void evaluate(CRun rhPtr) => rhPtr.getCurrentResult().forceInt(0);
    }
}
