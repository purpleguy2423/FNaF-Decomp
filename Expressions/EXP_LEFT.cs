// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_LEFT
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_LEFT : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        ++rhPtr.rh4CurToken;
        string expressionString = rhPtr.get_ExpressionString();
        ++rhPtr.rh4CurToken;
        int length = rhPtr.get_ExpressionInt();
        if (length < 0)
          length = 0;
        if (length > expressionString.Length)
          length = expressionString.Length;
        rhPtr.getCurrentResult().forceString(expressionString.Substring(0, length));
      }
    }
}
