using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractEffect
{
    protected List<AbstractTarget> _targets; // 0 - self
    protected int _strength;
    
    public abstract void Update();
    
}
