using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CreatureTarget : AbstractTarget
{
    protected int _attack;

    public override event AbstractTargetEventDelegate OnDeath;
    public override event AbstractTargetEventDelegate OnEffectTrigger;
    
    public override int Attack
    {
        get;
    }

    public CreatureTarget(int hitPoints, int attack, params AbstractEffect[] effects)
    {
        _hitPoints = hitPoints;
        _attack = attack;
        _effects = new List<AbstractEffect>(effects);
    }

    public override void ApplyDamage(int damage)
    {
        _hitPoints -= damage;
        if(_hitPoints <= 0)
        {
            if(OnDeath != null)
                OnDeath(this);
        }
    }

    public override void ApplyEffect(AbstractEffect effect)
    {
        _effects.Add(effect);
    }
    
}
