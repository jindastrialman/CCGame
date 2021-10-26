using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnHandler : MonoBehaviour
{
    [SerializeField]
    private List<AbstractPlayer> _players;
    private int _currentPlayer

    public void Initialize(params AbstractPlayer players[])
    {
        _players = new List<AbstractPlayer>(players);
        _currentPlayer = 0;
        _players[_currentPlayer].Lock();
    }
    public void TurnOver()
    {
        _players[_currentPlayer++].Unlock();
        if(_currentPlayer >= _players.size) 
            _currentPlayer = 0;
        _players[_currentPlayer].Lock();
    }
}
