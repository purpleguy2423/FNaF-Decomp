// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Conditions.CND_EXTISCOLBACK
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Conditions
{

    public class CND_EXTISCOLBACK : CCnd, IEvaObject
    {
      public override bool eva1(CRun rhPtr, CObject hoPtr) => this.eva2(rhPtr);

      public override bool eva2(CRun rhPtr) => this.evaObject(rhPtr, (IEvaObject) this);

      public virtual bool evaObjectRoutine(CObject hoPtr)
      {
        return hoPtr.hoAdRunHeader.colMask_TestObject_IXY(hoPtr, hoPtr.roc.rcImage, hoPtr.roc.rcAngle, hoPtr.roc.rcScaleX, hoPtr.roc.rcScaleY, hoPtr.hoX, hoPtr.hoY, 0, 1) != 0 ? this.negaTRUE() : this.negaFALSE();
      }
    }
}
