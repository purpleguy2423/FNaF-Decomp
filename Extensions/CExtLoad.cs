// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Extensions.CExtLoad
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Services;
using System;

namespace RuntimeXNA.Extensions
{

    internal class CExtLoad
    {
      public string name;
      public string subType;
      public short handle;

      public void loadInfo(CFile file)
      {
        int filePointer = file.getFilePointer();
        short num = Math.Abs(file.readAShort());
        this.handle = file.readAShort();
        file.skipBytes(12);
        this.name = file.readAString();
        this.name = this.name.Substring(0, this.name.LastIndexOf('.'));
        this.subType = file.readAString();
        file.seek(filePointer + (int) num);
      }

      public CRunExtension loadRunObject()
      {
        CRunExtension crunExtension = (CRunExtension) null;
        if (string.Compare(this.name, "XNA") == 0)
          crunExtension = (CRunExtension) new CRunXNA();
        if (string.Compare(this.name, "kcini") == 0)
          crunExtension = (CRunExtension) new CRunkcini();
        return crunExtension;
      }
    }
}
