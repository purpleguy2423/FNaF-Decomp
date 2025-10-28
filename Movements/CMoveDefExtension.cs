// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Movements.CMoveDefExtension
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Services;

namespace RuntimeXNA.Movements
{

    public class CMoveDefExtension : CMoveDef
    {
      public string moduleName;
      public int mvtID;
      public byte[] data;

      public override void load(CFile file, int length)
      {
        file.skipBytes(14);
        this.data = new byte[length - 14];
        file.read(this.data);
      }

      public void setModuleName(string name, int id)
      {
        this.moduleName = name;
        this.mvtID = id;
      }
    }
}
