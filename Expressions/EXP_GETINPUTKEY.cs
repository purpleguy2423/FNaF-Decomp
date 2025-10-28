// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_GETINPUTKEY
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Application;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_GETINPUTKEY : CExpOi
    {
      public override void evaluate(CRun rhPtr)
      {
        int oi = (int) this.oi;
        ++rhPtr.rh4CurToken;
        int expressionInt = rhPtr.get_ExpressionInt();
        string keyText = CKeyConvert.getKeyText(rhPtr.rhApp.pcCtrlKeys[oi * 4 + expressionInt]);
        rhPtr.getCurrentResult().forceString(keyText);
      }
    }
}
