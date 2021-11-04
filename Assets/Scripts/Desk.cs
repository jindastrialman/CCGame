using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk
{
    private static Desk _instance;
    private static List<List<AbstractTarget>> _playersDesk; //задел под 2+ игроков B)

    public static Desk GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Desk();
            _playersDesk = new List<List<AbstractTarget>>(); //синглтрон - имба патча
        }
        return _instance;
    }

    public static List<AbstractTarget> GetPlayerDesk(int number) //сувать с 0, максимально тупой(без проверок)
    {
        return _playersDesk[number];
    }
}
