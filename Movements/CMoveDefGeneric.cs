// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Movements.CMoveDefGeneric
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Services;

namespace RuntimeXNA.Movements
{

    internal class CMoveDefGeneric : CMoveDef
    {
      public short mgSpeed;
      public short mgAcc;
      public short mgDec;
      public short mgBounceMult;
      public int mgDir;

      public override void load(CFile file, int length)
      {
        this.mgSpeed = file.readAShort();
        this.mgAcc = file.readAShort();
        this.mgDec = file.readAShort();
        this.mgBounceMult = file.readAShort();
        this.mgDir = file.readAInt();
      }
    }
}
