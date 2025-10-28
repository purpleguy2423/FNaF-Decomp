// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Params.PARAM_KEY
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using Microsoft.Xna.Framework.Input;
using RuntimeXNA.Application;

namespace RuntimeXNA.Params
{

    public class PARAM_KEY : CParam
    {
      public Keys key;
      public short mouseKey;

      public override void load(CRunApp app)
      {
        short pcKey = app.file.readAShort();
        this.key = CKeyConvert.getXnaKey((int) pcKey);
        this.mouseKey = pcKey;
      }
    }
}
