// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Movements.CMoveDefPath
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Services;

namespace RuntimeXNA.Movements
{

    internal class CMoveDefPath : CMoveDef
    {
      public short mtNumber;
      public short mtMinSpeed;
      public short mtMaxSpeed;
      public byte mtLoop;
      public byte mtRepos;
      public byte mtReverse;
      public CPathStep[] steps;

      public override void load(CFile file, int length)
      {
        this.mtNumber = file.readAShort();
        this.mtMinSpeed = file.readAShort();
        this.mtMaxSpeed = file.readAShort();
        this.mtLoop = file.readByte();
        this.mtRepos = file.readByte();
        this.mtReverse = file.readByte();
        file.skipBytes(1);
        this.steps = new CPathStep[(int) this.mtNumber];
        for (int index = 0; index < (int) this.mtNumber; ++index)
        {
          int filePointer = file.getFilePointer();
          this.steps[index] = new CPathStep();
          file.readUnsignedByte();
          int num = file.readUnsignedByte();
          this.steps[index].load(file);
          file.seek(filePointer + num);
        }
      }
    }
}
