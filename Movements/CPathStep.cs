// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Movements.CPathStep
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Services;

namespace RuntimeXNA.Movements
{

    internal class CPathStep
    {
      public byte mdSpeed;
      public byte mdDir;
      public short mdDx;
      public short mdDy;
      public short mdCosinus;
      public short mdSinus;
      public short mdLength;
      public short mdPause;
      public string mdName;

      public void load(CFile file)
      {
        this.mdSpeed = file.readByte();
        this.mdDir = file.readByte();
        this.mdDx = file.readAShort();
        this.mdDy = file.readAShort();
        this.mdCosinus = file.readAShort();
        this.mdSinus = file.readAShort();
        this.mdLength = file.readAShort();
        this.mdPause = file.readAShort();
        string str = file.readAString();
        if (str.Length <= 0)
          return;
        this.mdName = str;
      }
    }
}
