// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Actions.ACT_STRPREV
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Actions
{

    public class ACT_STRPREV : CAct
    {
      public override void execute(CRun rhPtr)
      {
        CObject actionObjects = rhPtr.rhEvtProg.get_ActionObjects((CAct) this);
        if (actionObjects == null)
          return;
        CText ctext = (CText) actionObjects;
        int num = ctext.rsMini - 1;
        if (num < 0)
          num = 0;
        if (!ctext.txtChange(num))
          return;
        actionObjects.roc.rcChanged = true;
        actionObjects.display();
      }
    }
}
