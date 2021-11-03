using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractCastingType
{
    public abstract void Cast(AbstractTarget self, List<AbstractTarget> targets);
}
