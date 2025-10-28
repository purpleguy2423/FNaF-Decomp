// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Services.CChunk
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

namespace RuntimeXNA.Services
{

    internal class CChunk
    {
      public const short CHUNK_LAST = 32639;
      public short chID;
      public short chFlags;
      public int chSize;

      public short readHeader(CFile file)
      {
        this.chID = file.readAShort();
        this.chFlags = file.readAShort();
        this.chSize = file.readAInt();
        return this.chID;
      }

      public void skipChunk(CFile file) => file.skipBytes(this.chSize);
    }
}
