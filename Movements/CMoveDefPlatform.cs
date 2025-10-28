// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Movements.CMoveDefPlatform
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Services;

namespace RuntimeXNA.Movements
{

    internal class CMoveDefPlatform : CMoveDef
    {
      public short mpSpeed;
      public short mpAcc;
      public short mpDec;
      public short mpJumpControl;
      public short mpGravity;
      public short mpJump;

      public override void load(CFile file, int length)
      {
        this.mpSpeed = file.readAShort();
        this.mpAcc = file.readAShort();
        this.mpDec = file.readAShort();
        this.mpJumpControl = file.readAShort();
        this.mpGravity = file.readAShort();
        this.mpJump = file.readAShort();
      }
    }
}
