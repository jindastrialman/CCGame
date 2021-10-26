using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractCard
{
    private int _manacost;
    private AbstractCastingType _type;
    private List<AbstractEffect> _effects;
}
