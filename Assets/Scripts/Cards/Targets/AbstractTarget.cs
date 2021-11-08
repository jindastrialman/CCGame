using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class AbstractTarget
{
    protected int _hitPoints;
    protected List<AbstractEffect> _effects;

    public delegate void AbstractTargetEventDelegate(AbstractTarget sender);

    public abstract event AbstractTargetEventDelegate OnDeath;
    public abstract event AbstractTargetEventDelegate OnEffectTrigger;

    public abstract int Attack{get;}

    public abstract void ApplyDamage(int damage);
    public abstract void ApplyEffect(AbstractEffect effect);

    public void Update()
    {
        foreach(AbstractEffect effect in _effects)
            effect.Update();
    }
}
