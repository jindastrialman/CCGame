using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class AbstractPlayer
{
    private List<AbstractCard> _hand;
    private List<AbstractCard> _frontline;
    //private List<AbstractCard> _backline; до лучших времен(

    public AbstractPlayer()
    {
        throw new NotImplementedException();
    }

    public virtual void Unlock()
    {
        throw new NotImplementedException();
    }

    public virtual void Lock()
    {
        throw new NotImplementedException();
    }
}
