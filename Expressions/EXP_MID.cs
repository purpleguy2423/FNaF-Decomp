// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_MID
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_MID : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        ++rhPtr.rh4CurToken;
        string expressionString = rhPtr.get_ExpressionString();
        ++rhPtr.rh4CurToken;
        int startIndex = rhPtr.get_ExpressionInt();
        ++rhPtr.rh4CurToken;
        int num = rhPtr.get_ExpressionInt();
        if (startIndex < 0)
          startIndex = 0;
        if (startIndex > expressionString.Length)
          startIndex = expressionString.Length;
        if (num < 0)
          num = 0;
        if (startIndex + num > expressionString.Length)
          num = expressionString.Length - startIndex;
        rhPtr.getCurrentResult().forceString(expressionString.Substring(startIndex, startIndex + num - startIndex));
      }
    }
}
