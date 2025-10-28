// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Expressions.EXP_EXTNOBJECTS
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Events;
using RuntimeXNA.RunLoop;

namespace RuntimeXNA.Expressions
{

    public class EXP_EXTNOBJECTS : CExpOi
    {
      public override void evaluate(CRun rhPtr)
      {
        short oiList = this.oiList;
        if (oiList >= (short) 0)
        {
          CObjInfo rhOi = rhPtr.rhOiList[(int) oiList];
          rhPtr.getCurrentResult().forceInt(rhOi.oilNObjects);
        }
        else
        {
          int num = 0;
          if (oiList != (short) -1)
          {
            CQualToOiList qualToOi = rhPtr.rhEvtProg.qualToOiList[(int) oiList & (int) short.MaxValue];
            for (int index = 0; index < qualToOi.qoiList.Length; index += 2)
            {
              CObjInfo rhOi = rhPtr.rhOiList[(int) qualToOi.qoiList[index + 1]];
              num += rhOi.oilNObjects;
            }
          }
          rhPtr.getCurrentResult().forceInt(num);
        }
      }
    }
}
