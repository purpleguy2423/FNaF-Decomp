// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.OI.CDefCounter
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Services;

namespace RuntimeXNA.OI
{

    internal class CDefCounter : CDefObject
    {
      public int ctInit;
      public int ctMini;
      public int ctMaxi;

      public override void load(CFile file)
      {
        file.skipBytes(2);
        this.ctInit = file.readAInt();
        this.ctMini = file.readAInt();
        this.ctMaxi = file.readAInt();
      }
    }
}
