// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Frame.CLO
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Services;
using RuntimeXNA.Sprites;

namespace RuntimeXNA.Frame
{

    public class CLO
    {
      public const short PARENT_NONE = 0;
      public const short PARENT_FRAME = 1;
      public const short PARENT_FRAMEITEM = 2;
      public const short PARENT_QUALIFIER = 3;
      public short loHandle;
      public short loOiHandle;
      public int loX;
      public int loY;
      public short loParentType;
      public short loOiParentHandle;
      public short loLayer;
      public short loType;
      public CSprite[] loSpr;

      public CLO()
      {
        this.loSpr = new CSprite[4];
        for (int index = 0; index < 4; ++index)
          this.loSpr[index] = (CSprite) null;
      }

      public void load(CFile file)
      {
        this.loHandle = file.readAShort();
        this.loOiHandle = file.readAShort();
        this.loX = file.readAInt();
        this.loY = file.readAInt();
        this.loParentType = file.readAShort();
        this.loOiParentHandle = file.readAShort();
        this.loLayer = file.readAShort();
        file.skipBytes(2);
      }
    }
}
