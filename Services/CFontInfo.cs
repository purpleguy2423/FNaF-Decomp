// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Services.CFontInfo
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

namespace RuntimeXNA.Services
{

    public class CFontInfo
    {
      public int lfHeight;
      public int lfWeight;
      public byte lfItalic;
      public byte lfUnderline;
      public byte lfStrikeOut;
      public string lfFaceName;

      public void copy(CFontInfo f)
      {
        this.lfHeight = f.lfHeight;
        this.lfWeight = f.lfWeight;
        this.lfItalic = f.lfItalic;
        this.lfUnderline = f.lfUnderline;
        this.lfStrikeOut = f.lfStrikeOut;
        this.lfFaceName = f.lfFaceName;
      }
    }
}
