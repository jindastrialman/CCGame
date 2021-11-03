using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractTarget
{
    public abstract int Attack{get; set;}
    public abstract void GetDamage(int damage);
}
