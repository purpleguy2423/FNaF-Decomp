// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Movements.CMoveDefRace
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Services;

namespace RuntimeXNA.Movements
{

    internal class CMoveDefRace : CMoveDef
    {
      public short mrSpeed;
      public short mrAcc;
      public short mrDec;
      public short mrRot;
      public short mrBounceMult;
      public short mrAngles;
      public short mrOkReverse;

      public override void load(CFile file, int length)
      {
        this.mrSpeed = file.readAShort();
        this.mrAcc = file.readAShort();
        this.mrDec = file.readAShort();
        this.mrRot = file.readAShort();
        this.mrBounceMult = file.readAShort();
        this.mrAngles = file.readAShort();
        this.mrOkReverse = file.readAShort();
      }
    }
}
