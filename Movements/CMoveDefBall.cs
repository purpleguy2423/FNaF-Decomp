// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Movements.CMoveDefBall
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Services;

namespace RuntimeXNA.Movements
{

    internal class CMoveDefBall : CMoveDef
    {
      public short mbSpeed;
      public short mbBounce;
      public short mbAngles;
      public short mbSecurity;
      public short mbDecelerate;

      public override void load(CFile file, int length)
      {
        this.mbSpeed = file.readAShort();
        this.mbBounce = file.readAShort();
        this.mbAngles = file.readAShort();
        this.mbSecurity = file.readAShort();
        this.mbDecelerate = file.readAShort();
      }
    }
}
