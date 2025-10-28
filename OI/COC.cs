// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.OI.COC
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Banks;
using RuntimeXNA.Services;

namespace RuntimeXNA.OI
{

    public class COC
    {
      public const short OBSTACLE_NONE = 0;
      public const short OBSTACLE_SOLID = 1;
      public const short OBSTACLE_PLATFORM = 2;
      public const short OBSTACLE_LADDER = 3;
      public const short OBSTACLE_TRANSPARENT = 4;
      public short ocObstacleType;
      public short ocColMode;
      public int ocCx;
      public int ocCy;
      public COI oi;

      public virtual void load(CFile file, short type)
      {
      }

      public virtual void enumElements(IEnum enumImages, IEnum enumFonts)
      {
      }
    }
}
