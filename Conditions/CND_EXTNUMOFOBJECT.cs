// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_EXTNUMOFOBJECT
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Events;
using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_EXTNUMOFOBJECT : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr) => this.eva2(rhPtr);

      public override bool eva2(CRun rhPtr)
      {
        int num = 0;
        short evtOiList = this.evtOiList;
        if (evtOiList >= (short) 0)
          num = rhPtr.rhOiList[(int) evtOiList].oilNObjects;
        else if (evtOiList != (short) -1)
        {
          CQualToOiList qualToOi = rhPtr.rhEvtProg.qualToOiList[(int) evtOiList & (int) short.MaxValue];
          for (int index = 0; index < qualToOi.qoiList.Length; index += 2)
          {
            CObjInfo rhOi = rhPtr.rhOiList[(int) qualToOi.qoiList[index + 1]];
            num += rhOi.oilNObjects;
          }
        }
        int eventExpressionInt = rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]);
        return CRun.compareTer(num, eventExpressionInt, ((CParamExpression) this.evtParams[0]).comparaison);
      }
    }
}
