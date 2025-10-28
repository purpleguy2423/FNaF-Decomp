// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_SETVIRTUALWIDTH
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_SETVIRTUALWIDTH : CAct
    {
      public override void execute(CRun rhPtr)
      {
        int num = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]);
        if (num < rhPtr.rhFrame.leWidth)
          num = rhPtr.rhFrame.leWidth;
        if (num > 2147479552)
          num = 2147479552;
        if (rhPtr.rhFrame.leVirtualRect.right == num)
          return;
        rhPtr.rhFrame.leVirtualRect.right = rhPtr.rhLevelSx = num;
      }
    }
}
