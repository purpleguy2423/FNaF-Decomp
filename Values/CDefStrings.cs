// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Values.CDefStrings
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Services;

namespace RuntimeXNA.Values
{

    public class CDefStrings
    {
      public short nStrings;
      public string[] strings;

      public void load(CFile file)
      {
        this.nStrings = file.readAShort();
        this.strings = new string[(int) this.nStrings];
        for (int index = 0; index < (int) this.nStrings; ++index)
          this.strings[index] = file.readAString();
      }
    }
}
