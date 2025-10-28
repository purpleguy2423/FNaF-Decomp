// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Params.CCreate
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Application;

namespace RuntimeXNA.Params
{

    public abstract class CCreate : CPosition
    {
      public short cdpHFII;
      public short cdpOi;

      public abstract override void load(CRunApp app);
    }
}
