// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Params.PARAM_POSITION
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Application;

namespace RuntimeXNA.Params
{

    public class PARAM_POSITION : CPosition
    {
      public override void load(CRunApp app)
      {
        this.posOINUMParent = app.file.readAShort();
        this.posFlags = app.file.readAShort();
        this.posX = app.file.readAShort();
        this.posY = app.file.readAShort();
        this.posSlope = app.file.readAShort();
        this.posAngle = app.file.readAShort();
        this.posDir = app.file.readAInt();
        this.posTypeParent = app.file.readAShort();
        this.posOiList = app.file.readAShort();
        this.posLayer = app.file.readAShort();
      }
    }
}
