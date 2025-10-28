// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Params.PARAM_2SHORTS
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Application;

namespace RuntimeXNA.Params
{

    public class PARAM_2SHORTS : CParam
    {
      public short value1;
      public short value2;

      public override void load(CRunApp app)
      {
        this.value1 = app.file.readAShort();
        this.value2 = app.file.readAShort();
      }
    }
}
