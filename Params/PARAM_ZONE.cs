// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Params.PARAM_ZONE
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Application;

namespace RuntimeXNA.Params
{

    public class PARAM_ZONE : CParam
    {
      public short x1;
      public short y1;
      public short x2;
      public short y2;

      public override void load(CRunApp app)
      {
        this.x1 = app.file.readAShort();
        this.y1 = app.file.readAShort();
        this.x2 = app.file.readAShort();
        this.y2 = app.file.readAShort();
      }
    }
}
