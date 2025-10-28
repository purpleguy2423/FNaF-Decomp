// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.OI.CDefCCA
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Services;

namespace RuntimeXNA.OI
{

    internal class CDefCCA : CDefObject
    {
      public int odCx;
      public int odCy;
      public short odVersion;
      public short odNStartFrame;
      public int odOptions;
      public string odName;

      public override void load(CFile file)
      {
        file.skipBytes(4);
        this.odCx = file.readAInt();
        this.odCy = file.readAInt();
        this.odVersion = file.readAShort();
        this.odNStartFrame = file.readAShort();
        this.odOptions = file.readAInt();
        file.skipBytes(8);
        this.odName = file.readAString();
      }
    }
}
