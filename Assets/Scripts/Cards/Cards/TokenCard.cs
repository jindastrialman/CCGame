using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenCard : AbstractCard
{
    public TokenCard()
    {
        _manacost = 0;
        _self = new CreatureTarget(1, 1);
    }
}
