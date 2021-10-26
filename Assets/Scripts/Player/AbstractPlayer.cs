using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractPlayer
{
    private List<AbstractCard> _hand;
    private List<AbstractCard> _frontline;
    private List<AbstractCard> _backline;

    public abstract AbstractPlayer();

    public abstract void Unlock();
    public abstract void Lock();
}
