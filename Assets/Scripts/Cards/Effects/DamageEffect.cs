using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEffect : AbstractEffect
{
    public override void Update()
    {
        _targets.ApplyDamage(_strength);
    }
}
