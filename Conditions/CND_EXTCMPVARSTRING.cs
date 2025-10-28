// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_EXTCMPVARSTRING
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Expressions;
using RuntimeXNA.Objects;
using RuntimeXNA.Params;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_EXTCMPVARSTRING : CCnd
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr) => this.eva2(rhPtr);

      public override bool eva2(CRun rhPtr)
      {
        CObject cobject = rhPtr.rhEvtProg.evt_FirstObject(this.evtOiList);
        if (cobject == null)
          return false;
        int nselectedObjects = rhPtr.rhEvtProg.evtNSelectedObjects;
        CValue pValue1 = new CValue();
        CParamExpression evtParam = (CParamExpression) this.evtParams[1];
        do
        {
          int n = this.evtParams[0].code != (short) 62 ? (int) ((PARAM_SHORT) this.evtParams[0]).value : rhPtr.get_EventExpressionInt((CParamExpression) this.evtParams[0]);
          if (n >= 0 && n < 10 && cobject.rov != null)
          {
            pValue1.forceString(cobject.rov.getString(n));
            CValue eventExpressionAny = rhPtr.get_EventExpressionAny(evtParam);
            if (!CRun.compareTo(pValue1, eventExpressionAny, evtParam.comparaison))
            {
              --nselectedObjects;
              rhPtr.rhEvtProg.evt_DeleteCurrentObject();
            }
          }
          else
          {
            --nselectedObjects;
            rhPtr.rhEvtProg.evt_DeleteCurrentObject();
          }
          cobject = rhPtr.rhEvtProg.evt_NextObject();
        }
        while (cobject != null);
        return nselectedObjects != 0;
      }
    }
}
