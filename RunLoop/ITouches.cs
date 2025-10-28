// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.RunLoop.ITouches
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using Microsoft.Xna.Framework.Input.Touch;

namespace RuntimeXNA.RunLoop
{

    public interface ITouches
    {
      bool touchBegan(TouchLocation touch);

      void touchMoved(TouchLocation touch);

      void touchEnded(TouchLocation touch);

      void touchCancelled(TouchLocation touch);
    }
}
