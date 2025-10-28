// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Animations.CAnimHeader
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Banks;
using RuntimeXNA.Services;

namespace RuntimeXNA.Animations
{

    public class CAnimHeader
    {
      private static short[] tableApprox = new short[64 /*0x40*/]
      {
        (short) 3,
        (short) 1,
        (short) 2,
        (short) 0,
        (short) 2,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 1,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 1,
        (short) 2,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 1,
        (short) 2,
        (short) 0,
        (short) 0,
        (short) 1,
        (short) 2,
        (short) 0,
        (short) 1,
        (short) 2,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 1,
        (short) 2,
        (short) 0,
        (short) 1,
        (short) 2,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 1,
        (short) 2,
        (short) 0,
        (short) 0,
        (short) 1,
        (short) 2,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0,
        (short) 0
      };
      public short ahAnimMax;
      public CAnim[] ahAnims;
      public byte[] ahAnimExists;

      public void load(CFile file)
      {
        int filePointer = file.getFilePointer();
        file.skipBytes(2);
        this.ahAnimMax = file.readAShort();
        short[] numArray = new short[(int) this.ahAnimMax];
        for (int index = 0; index < (int) this.ahAnimMax; ++index)
          numArray[index] = file.readAShort();
        this.ahAnims = new CAnim[(int) this.ahAnimMax];
        this.ahAnimExists = new byte[(int) this.ahAnimMax];
        for (int index = 0; index < (int) this.ahAnimMax; ++index)
        {
          this.ahAnims[index] = (CAnim) null;
          this.ahAnimExists[index] = (byte) 0;
          if (numArray[index] != (short) 0)
          {
            this.ahAnims[index] = new CAnim();
            file.seek(filePointer + (int) numArray[index]);
            this.ahAnims[index].load(file);
            this.ahAnimExists[index] = (byte) 1;
          }
        }
        for (int nAnim = 0; nAnim < (int) this.ahAnimMax; ++nAnim)
        {
          if (this.ahAnimExists[nAnim] == (byte) 0)
          {
            bool flag = false;
            if (nAnim < 12)
            {
              for (int index = 0; index < 4; ++index)
              {
                if (this.ahAnimExists[(int) CAnimHeader.tableApprox[nAnim * 4 + index]] != (byte) 0)
                {
                  this.ahAnims[nAnim] = this.ahAnims[(int) CAnimHeader.tableApprox[nAnim * 4 + index]];
                  flag = true;
                  break;
                }
              }
            }
            if (!flag)
            {
              for (int index = 0; index < (int) this.ahAnimMax; ++index)
              {
                if (this.ahAnimExists[index] != (byte) 0)
                {
                  this.ahAnims[nAnim] = this.ahAnims[index];
                  break;
                }
              }
            }
          }
          else
            this.ahAnims[nAnim].approximate(nAnim);
        }
      }

      public void enumElements(IEnum enumImages)
      {
        for (int index = 0; index < (int) this.ahAnimMax; ++index)
        {
          if (this.ahAnimExists[index] != (byte) 0)
            this.ahAnims[index].enumElements(enumImages);
        }
      }
    }
}
