using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CreatureTarget : AbstractTarget
{
    public override event Action OnDeath;

    public override int Attack
    {
        get;
        set;
    }

    public override void ApplyDamage(int damage)
    {
        _hitPoints -= damage;
        if(_hitPoints <= 0)
        {
            if(OnDeath != null)
                OnDeath();
        }
    }

    public override void ApplyEffect(AbstractEffect effect)
    {
        _effects.Add(effect);
    }
    
}
