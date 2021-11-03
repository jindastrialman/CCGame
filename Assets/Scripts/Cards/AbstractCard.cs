using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractCard
{
    private int _manacost;
    private AbstractCastingType _type;
    private AbstractTarget _self;
    private List<AbstractTarget> _targets; 
    private List<AbstractEffect> _effects;
}
