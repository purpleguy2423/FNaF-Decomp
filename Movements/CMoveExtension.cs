// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Movements.CMoveExtension
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using RuntimeXNA.Objects;
using RuntimeXNA.Services;

namespace RuntimeXNA.Movements
{

    public class CMoveExtension : CMove
    {
      public CRunMvtExtension movement;
      public double callParam;

      public CMoveExtension(CRunMvtExtension m) => this.movement = m;

      public override void init(CObject ho, CMoveDef mvPtr)
      {
        this.hoPtr = ho;
        CFile file = new CFile(((CMoveDefExtension) mvPtr).data);
        file.setUnicode(ho.hoAdRunHeader.rhApp.bUnicode);
        this.movement.initialize(file);
        this.hoPtr.roc.rcCheckCollides = true;
        this.hoPtr.roc.rcChanged = true;
      }

      public override void kill() => this.movement.kill();

      public override void move()
      {
        if (!this.movement.move())
          return;
        this.hoPtr.roc.rcChanged = true;
      }

      public override void stop()
      {
        this.movement.stop((int) this.rmCollisionCount == (int) this.hoPtr.hoAdRunHeader.rh3CollisionCount);
      }

      public override void start() => this.movement.start();

      public override void bounce()
      {
        this.movement.bounce((int) this.rmCollisionCount == (int) this.hoPtr.hoAdRunHeader.rh3CollisionCount);
      }

      public override void reverse() => this.movement.reverse();

      public virtual double callMovement(int function, double param)
      {
        this.callParam = param;
        return this.movement.actionEntry(function);
      }

      public override void setSpeed(int value) => this.movement.setSpeed(value);

      public override void setMaxSpeed(int value) => this.movement.setMaxSpeed(value);

      public override void setXPosition(int value)
      {
        this.movement.setXPosition(value);
        this.hoPtr.roc.rcChanged = true;
        this.hoPtr.roc.rcCheckCollides = true;
      }

      public override void setYPosition(int value)
      {
        this.movement.setYPosition(value);
        this.hoPtr.roc.rcChanged = true;
        this.hoPtr.roc.rcCheckCollides = true;
      }

      public override void setDir(int value)
      {
        this.movement.setDir(value);
        this.hoPtr.roc.rcChanged = true;
        this.hoPtr.roc.rcCheckCollides = true;
      }
    }
}
