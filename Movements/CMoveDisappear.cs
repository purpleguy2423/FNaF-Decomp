// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Movements.CMoveDisappear
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;

namespace RuntimeXNA.Movements
{

    internal class CMoveDisappear : CMove
    {
      public override void init(CObject ho, CMoveDef mvPtr) => this.hoPtr = ho;

      public override void move()
      {
        if (((int) this.hoPtr.hoFlags & 16 /*0x10*/) != 0 || this.hoPtr.roa == null)
          return;
        this.hoPtr.roa.animate();
        if (this.hoPtr.roa.raAnimForced == 5)
          return;
        this.hoPtr.hoAdRunHeader.destroy_Add((int) this.hoPtr.hoNumber);
      }

      public override void setXPosition(int x)
      {
        if (this.hoPtr.hoX == x)
          return;
        this.hoPtr.hoX = x;
        this.hoPtr.rom.rmMoveFlag = true;
        this.hoPtr.roc.rcChanged = true;
      }

      public override void setYPosition(int y)
      {
        if (this.hoPtr.hoY == y)
          return;
        this.hoPtr.hoY = y;
        this.hoPtr.rom.rmMoveFlag = true;
        this.hoPtr.roc.rcChanged = true;
      }
    }
}
