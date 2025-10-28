// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Params.PARAM_GROUP
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Application;

namespace RuntimeXNA.Params
{

    public class PARAM_GROUP : CParam
    {
      public const short GRPFLAGS_INACTIVE = 1;
      public const short GRPFLAGS_CLOSED = 2;
      public const short GRPFLAGS_PARENTINACTIVE = 4;
      public const short GRPFLAGS_GROUPINACTIVE = 8;
      public const short GRPFLAGS_GLOBAL = 16 /*0x10*/;
      public short grpFlags;
      public short grpId;

      public override void load(CRunApp app)
      {
        this.grpFlags = app.file.readAShort();
        this.grpId = app.file.readAShort();
      }
    }
}
