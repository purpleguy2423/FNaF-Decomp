// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Objects.CRCom
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Sprites;

namespace RuntimeXNA.Objects
{

    public class CRCom
    {
      public int rcPlayer;
      public int rcMovementType;
      public CSprite rcSprite;
      public int rcAnim;
      public short rcImage = -1;
      public float rcScaleX = 1f;
      public float rcScaleY = 1f;
      public int rcAngle;
      public int rcDir;
      public int rcSpeed;
      public int rcMinSpeed;
      public int rcMaxSpeed;
      public bool rcChanged;
      public bool rcCheckCollides;
      public int rcOldX;
      public int rcOldY;
      public short rcOldImage = -1;
      public int rcOldAngle;
      public int rcOldDir;
      public int rcOldX1;
      public int rcOldY1;
      public int rcOldX2;
      public int rcOldY2;

      public void init()
      {
        this.rcScaleX = 1f;
        this.rcScaleY = 1f;
        this.rcAngle = 0;
        this.rcMovementType = -1;
      }

      public void kill(bool bFast)
      {
      }
    }
}
