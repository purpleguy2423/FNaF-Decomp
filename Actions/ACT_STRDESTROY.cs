// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_STRDESTROY
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_STRDESTROY : CAct
    {
      public override void execute(CRun rhPtr)
      {
        CObject actionObjects = rhPtr.rhEvtProg.get_ActionObjects((CAct) this);
        if (actionObjects == null)
          return;
        if (((int) ((CText) actionObjects).rsHidden & 4) != 0)
        {
          actionObjects.ros.obHide();
          actionObjects.ros.rsFlags &= (short) -33;
          actionObjects.hoFlags |= (short) 8192 /*0x2000*/;
        }
        else
        {
          actionObjects.hoFlags |= (short) 1;
          rhPtr.destroy_Add((int) actionObjects.hoNumber);
        }
      }
    }
}
