// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Values.CDefValues
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Services;

namespace RuntimeXNA.Values
{

    public class CDefValues
    {
      public short nValues;
      public int[] values;

      public void load(CFile file)
      {
        this.nValues = file.readAShort();
        this.values = new int[(int) this.nValues];
        for (int index = 0; index < (int) this.nValues; ++index)
          this.values[index] = file.readAInt();
      }
    }
}
