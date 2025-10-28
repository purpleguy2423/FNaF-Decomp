// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_EXTNOMOREOBJECT
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Events;
using RuntimeXNA.Objects;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_EXTNOMOREOBJECT : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr)
      {
        if (hoPtr == null)
          return this.eva2(rhPtr);
        if (this.evtOi < (short) 0)
          return this.evaNoMoreObject(rhPtr, 1);
        return (int) hoPtr.hoOi == (int) this.evtOi;
      }

      public override bool eva2(CRun rhPtr) => this.evaNoMoreObject(rhPtr, 0);

      internal virtual bool evaNoMoreObject(CRun rhPtr, int sub)
      {
        short evtOiList = this.evtOiList;
        if (evtOiList >= (short) 0)
          return rhPtr.rhOiList[(int) evtOiList].oilNObjects == 0;
        if (evtOiList == (short) -1)
          return false;
        CQualToOiList qualToOi = rhPtr.rhEvtProg.qualToOiList[(int) evtOiList & (int) short.MaxValue];
        int num = 0;
        for (int index = 0; index < qualToOi.qoiList.Length; index += 2)
        {
          CObjInfo rhOi = rhPtr.rhOiList[(int) qualToOi.qoiList[index + 1]];
          num += rhOi.oilNObjects;
        }
        return num - sub == 0;
      }
    }
}
