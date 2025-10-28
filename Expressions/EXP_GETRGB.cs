// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_GETRGB
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_GETRGB : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        ++rhPtr.rh4CurToken;
        int expressionInt1 = rhPtr.get_ExpressionInt();
        ++rhPtr.rh4CurToken;
        int expressionInt2 = rhPtr.get_ExpressionInt();
        ++rhPtr.rh4CurToken;
        int num = ((rhPtr.get_ExpressionInt() & (int) byte.MaxValue) << 16 /*0x10*/) + ((expressionInt2 & (int) byte.MaxValue) << 8) + (expressionInt1 & (int) byte.MaxValue);
        rhPtr.getCurrentResult().forceInt(num);
      }
    }
}
