using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEffect : AbstractEffect
{
    public override void Update()
    {
        foreach(AbstractTarget target in _targets)
            target.ApplyDamage(_strength);
    }
}
