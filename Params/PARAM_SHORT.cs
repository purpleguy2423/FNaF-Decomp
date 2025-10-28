// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Params.PARAM_SHORT
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Application;

namespace RuntimeXNA.Params
{

    public class PARAM_SHORT : CParam
    {
      public short value;

      public override void load(CRunApp app) => this.value = app.file.readAShort();
    }
}
