using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractCard
{
    protected int _manacost;
    protected AbstractCastingType _type;
    protected AbstractTarget _self;
    protected List<AbstractTarget> _targets; 
}
