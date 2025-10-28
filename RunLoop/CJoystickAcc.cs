// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.RunLoop.CJoystickAcc
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Application;

namespace RuntimeXNA.RunLoop
{

    public class CJoystickAcc
    {
      public byte getJoystick()
      {
        byte joystick = 0;
        if ((double) CRunApp.filteredAccX < -0.15)
          joystick |= (byte) 4;
        if ((double) CRunApp.filteredAccX > 0.15)
          joystick |= (byte) 8;
        if ((double) CRunApp.filteredAccY < -0.15)
          joystick |= (byte) 1;
        if ((double) CRunApp.filteredAccY > 0.15)
          joystick |= (byte) 2;
        return joystick;
      }
    }
}
