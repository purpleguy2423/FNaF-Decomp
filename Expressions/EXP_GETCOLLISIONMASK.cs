// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_GETCOLLISIONMASK
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_GETCOLLISIONMASK : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        ++rhPtr.rh4CurToken;
        int expressionInt1 = rhPtr.get_ExpressionInt();
        ++rhPtr.rh4CurToken;
        int expressionInt2 = rhPtr.get_ExpressionInt();
        int num = 0;
        if (rhPtr.y_GetLadderAt_Absolute(-1, expressionInt1, expressionInt2) != null)
          num = 2;
        else if (rhPtr.rhFrame.bkdCol_TestPoint(expressionInt1 - rhPtr.rhWindowX, expressionInt2 - rhPtr.rhWindowY, -1, 0))
          num = 1;
        rhPtr.getCurrentResult().forceInt(num);
      }
    }
}
