// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Application.CEmbeddedFile
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Services;

namespace RuntimeXNA.Application
{

    public class CEmbeddedFile
    {
      private CRunApp app;
      public string path;
      private int length;
      private int offset;
      private CFile data;

      public CEmbeddedFile(CRunApp a) => this.app = a;

      private string cleanName(string name)
      {
        int num = name.LastIndexOf('\\');
        if (num < 0)
          num = name.LastIndexOf('/');
        if (num >= 0 && num + 1 < name.Length)
          name = name.Substring(num + 1);
        return name;
      }

      public void preLoad()
      {
        this.path = this.app.file.readAString((int) this.app.file.readAShort());
        this.path = this.cleanName(this.path);
        this.length = this.app.file.readAInt();
        this.offset = this.app.file.getFilePointer();
        this.app.file.skipBytes(this.length);
      }

      public CFile open()
      {
        this.app.file.seek(this.offset);
        this.data = new CFile(this.app.file, this.length);
        return this.data;
      }
    }
}
