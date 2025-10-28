// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Params.PARAM_PROGRAM
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Application;

namespace RuntimeXNA.Params
{

    public class PARAM_PROGRAM : CParam
    {
      public const short PRGFLAGS_WAIT = 1;
      public const short PRGFLAGS_HIDE = 2;
      public short flags;
      public string filename;
      public string command;

      public override void load(CRunApp app)
      {
        this.flags = app.file.readAShort();
        int filePointer = app.file.getFilePointer();
        this.filename = app.file.readAString();
        app.file.seek(filePointer + 260);
        this.command = app.file.readAString();
      }
    }
}
