// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_CHOOSEALL
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_CHOOSEALL : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr) => this.eva2(rhPtr);

      public override bool eva2(CRun rhPtr)
      {
        rhPtr.rhEvtProg.count_ObjectsFromType((short) 0, -1);
        if (rhPtr.rhEvtProg.evtNSelectedObjects == 0)
          return false;
        int stop = (int) rhPtr.random((short) rhPtr.rhEvtProg.evtNSelectedObjects);
        CObject pHo = rhPtr.rhEvtProg.count_ObjectsFromType((short) 0, stop);
        rhPtr.rhEvtProg.evt_DeleteCurrent();
        rhPtr.rhEvtProg.evt_AddCurrentObject(pHo);
        return true;
      }
    }
}
