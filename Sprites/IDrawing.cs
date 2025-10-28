// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Sprites.IDrawing
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Banks;

namespace RuntimeXNA.Sprites
{

    public interface IDrawing
    {
      void drawableDraw(SpriteBatchEffect batch, CSprite sprite, CImageBank bank, int x, int y);

      void drawableKill();

      CMask drawableGetMask(int flags);
    }
}
