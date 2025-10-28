// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_EXTISOUT
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_EXTISOUT : CCnd, IEvaObject
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr) => this.evaObject(rhPtr, (IEvaObject) this);

      public override bool eva2(CRun rhPtr) => this.evaObject(rhPtr, (IEvaObject) this);

      public virtual bool evaObjectRoutine(CObject pHo)
      {
        int x1 = pHo.hoX - pHo.hoImgXSpot;
        int x2 = x1 + pHo.hoImgWidth;
        int y1 = pHo.hoY - pHo.hoImgYSpot;
        int y2 = y1 + pHo.hoImgHeight;
        return pHo.hoAdRunHeader.quadran_In(x1, y1, x2, y2) != 0 ? this.negaTRUE() : this.negaFALSE();
      }
    }
}
