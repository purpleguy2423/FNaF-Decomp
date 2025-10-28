// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.RunLoop.CObjInfo
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.OI;

namespace RuntimeXNA.RunLoop
{

    public class CObjInfo
    {
      public const short OILIMITFLAGS_BORDERS = 15;
      public const short OILIMITFLAGS_BACKDROPS = 16 /*0x10*/;
      public const short OILIMITFLAGS_ONCOLLIDE = 128 /*0x80*/;
      public const short OILIMITFLAGS_QUICKCOL = 256 /*0x0100*/;
      public const short OILIMITFLAGS_QUICKBACK = 512 /*0x0200*/;
      public const short OILIMITFLAGS_QUICKBORDER = 1024 /*0x0400*/;
      public const short OILIMITFLAGS_QUICKSPR = 2048 /*0x0800*/;
      public const short OILIMITFLAGS_QUICKEXT = 4096 /*0x1000*/;
      public const short OILIMITFLAGS_ALL = -1;
      public short oilOi;
      public short oilListSelected;
      public short oilType;
      public short oilObject;
      public int oilEvents;
      public byte oilWrap;
      public bool oilNextFlag;
      public int oilNObjects;
      public int oilActionCount;
      public int oilActionLoopCount;
      public int oilCurrentRoutine;
      public int oilCurrentOi;
      public int oilNext;
      public int oilEventCount;
      public int oilNumOfSelected;
      public int oilOEFlags;
      public short oilLimitFlags;
      public int oilLimitList;
      public short oilOIFlags;
      public short oilOCFlags2;
      public int oilInkEffect;
      public int oilEffectParam;
      public short oilHFII;
      public int oilBackColor;
      public short[] oilQualifiers = new short[8];
      public string oilName;
      public int oilEventCountOR;
      public short[] oilColList;
      public int oilColCount;

      public void copyData(COI oiPtr)
      {
        this.oilOi = oiPtr.oiHandle;
        this.oilType = oiPtr.oiType;
        this.oilOIFlags = oiPtr.oiFlags;
        CObjectCommon oiOc = (CObjectCommon) oiPtr.oiOC;
        this.oilOCFlags2 = oiOc.ocFlags2;
        this.oilInkEffect = oiPtr.oiInkEffect;
        this.oilEffectParam = oiPtr.oiInkEffectParam;
        this.oilOEFlags = oiOc.ocOEFlags;
        this.oilBackColor = oiOc.ocBackColor;
        this.oilEventCount = 0;
        this.oilObject = (short) -1;
        this.oilLimitFlags = (short) -1;
        if (oiPtr.oiName != null)
          this.oilName = oiPtr.oiName;
        for (int index = 0; index < 8; ++index)
          this.oilQualifiers[index] = oiOc.ocQualifiers[index];
      }
    }
}
