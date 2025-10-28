// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_MINUS
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_MINUS : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        if (rhPtr.bOperande)
        {
          ++rhPtr.rh4CurToken;
          rhPtr.rh4Tokens[rhPtr.rh4CurToken].evaluate(rhPtr);
          rhPtr.getCurrentResult().negate();
        }
        else
          rhPtr.getCurrentResult().sub(rhPtr.getNextResult());
      }
    }
}
