// Decompiled with JetBrains decompiler
// Type: RuntimeXNA.Extensions.CRunExtension
// Assembly: FiveNightsatFreddys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D75D4F7E-3634-48C7-8A59-EC98ADB9D3F4
// Assembly location: C:\Users\zakga\Desktop\FNaF\FiveNightsatFreddys.dll

using Microsoft.Xna.Framework.Graphics;
using RuntimeXNA.Actions;
using RuntimeXNA.Conditions;
using RuntimeXNA.Expressions;
using RuntimeXNA.Objects;
using RuntimeXNA.RunLoop;
using RuntimeXNA.Services;
using RuntimeXNA.Sprites;

namespace RuntimeXNA.Extensions
{

    public class CRunExtension
    {
      public const int REFLAG_DISPLAY = 1;
      public const int REFLAG_ONESHOT = 2;
      public CExtension ho;
      public CRun rh;

      public virtual void init(CExtension hoPtr)
      {
        this.ho = hoPtr;
        this.rh = hoPtr.hoAdRunHeader;
      }

      public virtual int getNumberOfConditions() => 0;

      public virtual bool createRunObject(CFile file, CCreateObjectInfo cob, int version) => false;

      public virtual int handleRunObject() => 2;

      public virtual void displayRunObject(SpriteBatchEffect batch)
      {
      }

      public virtual void destroyRunObject(bool bFast)
      {
      }

      public virtual void pauseRunObject()
      {
      }

      public virtual void continueRunObject()
      {
      }

      public virtual void getZoneInfos()
      {
      }

      public virtual bool condition(int num, CCndExtension cnd) => false;

      public virtual void action(int num, CActExtension act)
      {
      }

      public virtual CValue expression(int num) => (CValue) null;

      public virtual CMask getRunObjectCollisionMask(int flags) => (CMask) null;

      public virtual Texture2D getRunObjectSurface() => (Texture2D) null;

      public virtual CFontInfo getRunObjectFont() => (CFontInfo) null;

      public virtual void setRunObjectFont(CFontInfo fi, CRect rc)
      {
      }

      public virtual int getRunObjectTextColor() => 0;

      public virtual void setRunObjectTextColor(int rgb)
      {
      }
    }
}
