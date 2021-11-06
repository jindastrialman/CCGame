using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class AbstractTarget
{
    protected int _hitPoints;
    protected List<AbstractEffect> _effects;

    public abstract event Action OnDeath;
    public abstract event Action OnEffectTrigger;

    public abstract int Attack{get; set;}

    public abstract void ApplyDamage(int damage);
    public abstract void ApplyEffect(AbstractEffect effect);

    public void UpdateEffects()
    {
        foreach(AbstractEffect effect in _effects)
            effect.Update();
    }
}
