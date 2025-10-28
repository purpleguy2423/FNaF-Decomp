// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Animations.CAnimDir
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Banks;
using RuntimeXNA.Services;

namespace RuntimeXNA.Animations
{

    public class CAnimDir
    {
      public byte adMinSpeed;
      public byte adMaxSpeed;
      public short adRepeat;
      public short adRepeatFrame;
      public short adNumberOfFrame;
      public short[] adFrames;

      public void load(CFile file)
      {
        this.adMinSpeed = file.readAByte();
        this.adMaxSpeed = file.readAByte();
        this.adRepeat = file.readAShort();
        this.adRepeatFrame = file.readAShort();
        this.adNumberOfFrame = file.readAShort();
        this.adFrames = new short[(int) this.adNumberOfFrame];
        for (int index = 0; index < (int) this.adNumberOfFrame; ++index)
          this.adFrames[index] = file.readAShort();
      }

      public void enumElements(IEnum enumImages)
      {
        for (int index = 0; index < (int) this.adNumberOfFrame; ++index)
        {
          if (enumImages != null)
          {
            short num = enumImages.enumerate(this.adFrames[index]);
            if (num != (short) -1)
              this.adFrames[index] = num;
          }
        }
      }
    }
}
