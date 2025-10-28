// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.RunLoop.IControl
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Sprites;

namespace RuntimeXNA.RunLoop
{

    public interface IControl
    {
      void drawControl(SpriteBatchEffect batch);

      int getX();

      int getY();

      void setFocus(bool bFlag);

      void click(int nClicks);

      void setMouseControlled(bool bFlag);
    }
}
