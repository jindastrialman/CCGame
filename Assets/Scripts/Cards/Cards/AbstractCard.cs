using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractCard
{
    protected int _manacost;
    protected AbstractTarget _self;
    
    public virtual void Update()
    {
        _self.Update();
    }

    public virtual void Play(int position)
    {
        Desk.AddTargetToPlayer(position, _self);
        _self.Update();
    }
}
