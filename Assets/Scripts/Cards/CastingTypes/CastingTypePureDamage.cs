using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingTypePureDamage : AbstractCastingType
{
    public override void Cast(AbstractTarget self, List<AbstractTarget> targets)
    {
        foreach(AbstractTarget target in targets)
        {
            target.ApplyDamage(self.Attack);
        }
    }
}
