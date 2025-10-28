// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Params.PARAM_MUSIC
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Application;

namespace RuntimeXNA.Params
{

    public class PARAM_MUSIC : CParam
    {
      public short sndHandle;
      public short sndFlags;

      public override void load(CRunApp app)
      {
        this.sndHandle = app.file.readAShort();
        this.sndFlags = app.file.readAShort();
      }
    }
}
