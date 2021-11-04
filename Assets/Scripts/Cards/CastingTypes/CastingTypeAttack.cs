using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingTypeAttack : AbstractCastingType
{
    public override void Cast(AbstractTarget self, List<AbstractTarget> targets)
    {
        foreach(AbstractTarget target in targets)
        {
            self.ApplyDamage(target.Attack);
            target.ApplyDamage(self.Attack);
        }
    }
}
