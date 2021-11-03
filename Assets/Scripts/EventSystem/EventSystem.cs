using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventSystem : MonoBehaviour
{
    public static EventSystem Current;

    private void Awake()
    {
        Current = this;
    }

    public event Action OnTurnSwitch;
    public event Action OnCardPlay;

    public void TurnSwitch()
    {
        if (OnTurnSwitch != null)
            OnTurnSwitch();
        
    }
}

