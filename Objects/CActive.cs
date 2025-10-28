// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Objects.CActive
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

namespace RuntimeXNA.Objects
{

    internal class CActive : CObject
    {
      public override void handle()
      {
        this.ros.handle();
        if (!this.roc.rcChanged)
          return;
        this.roc.rcChanged = false;
        this.modif();
      }

      public override void modif() => this.ros.modifRoutine();
    }
}
