using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractTarget
{
    protected int _hitPoints;
    protected List<AbstractEffect> _effects;

    public event Action OnDeath;

    public abstract int Attack{get; set;}

    public abstract void ApplyDamage(int damage);
    public abstract void ApplyEffect(AbstractEffect effect);
}
