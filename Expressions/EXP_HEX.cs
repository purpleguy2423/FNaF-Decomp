// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_HEX
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_HEX : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        ++rhPtr.rh4CurToken;
        string str = rhPtr.get_ExpressionInt().ToString("X");
        rhPtr.getCurrentResult().forceString(str);
      }
    }
}
