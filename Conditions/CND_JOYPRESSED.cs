// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_JOYPRESSED
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_JOYPRESSED : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr)
      {
        if ((int) this.evtOi != (int) rhPtr.rhEvtProg.rhCurOi)
          return false;
        short rhCurParam0 = (short) rhPtr.rhEvtProg.rhCurParam0;
        PARAM_SHORT evtParam = (PARAM_SHORT) this.evtParams[0];
        return (int) (short) ((int) rhCurParam0 & (int) evtParam.value) == (int) evtParam.value;
      }

      public override bool eva2(CRun rhPtr)
      {
        int evtOi = (int) this.evtOi;
        short num1 = (short) (sbyte) ((int) rhPtr.rh2NewPlayer[evtOi] & (int) rhPtr.rhPlayer[evtOi]);
        PARAM_SHORT evtParam = (PARAM_SHORT) this.evtParams[0];
        short num2 = (short) ((int) num1 & (int) evtParam.value);
        return (int) evtParam.value == (int) num2;
      }
    }
}
