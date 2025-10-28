// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_STR
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_STR : CExp
    {
      public override void evaluate(CRun rhPtr)
      {
        ++rhPtr.rh4CurToken;
        CValue expression = rhPtr.getExpression();
        string str = "";
        switch (expression.getType())
        {
          case 0:
            str = expression.getInt().ToString();
            break;
          case 1:
            str = expression.getDouble().ToString();
            break;
        }
        rhPtr.getCurrentResult().forceString(str);
      }
    }
}
