// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Events.CPushedEvent
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;

namespace RuntimeXNA.Events
{

    public class CPushedEvent
    {
      public int routine;
      public int code;
      public int param;
      public CObject pHo;
      public short oi;

      public CPushedEvent()
      {
      }

      public CPushedEvent(int r, int c, int p, CObject hoPtr, short o)
      {
        this.routine = r;
        this.code = c;
        this.param = p;
        this.pHo = hoPtr;
        this.oi = o;
      }
    }
}
