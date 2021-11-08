using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk
{
    private static Desk _instance;
    private static List<List<AbstractTarget>> _playersDesks; //задел под 2+ игроков B)
    private static int _currentPlayer = 0;

    public static Desk GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Desk();
            _playersDesks = new List<List<AbstractTarget>>(); //синглтрон - имба патча
        }
        return _instance;
    }

    public static void AddTargetToPlayer(int position, AbstractTarget target)
    {
        _playersDesks[_currentPlayer].Insert(position, target);
        _playersDesks[_currentPlayer][position].OnDeath += OnDeath;
    }

    public static void OnDeath(AbstractTarget target)
    {
            foreach(List<AbstractTarget> desk in _playersDesks)
                desk.Remove(target);
    }

    public static void IncrementCurrentPlayerCounter()
    {
        if(++_currentPlayer == _playersDesks.Count)
            _currentPlayer = 0;
    }

    public static List<AbstractTarget> GetPlayerDesk(int player) //сувать с 0, максимально тупой(без проверок)
    {
        return _playersDesks[player];
    }
}
