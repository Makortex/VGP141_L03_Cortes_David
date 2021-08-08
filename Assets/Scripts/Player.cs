using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player:MonoBehaviour
{
    public string Name { get; set; }
    public string Level { get; set; }
    public string Score { get; set; }

    public Player(string name, string level, string score)
    {
        Name = name;
        Level = level;
        Score = score;
    }

    //public void Gaming()
    //{
    //    Player P1 = new Player
    //    {
    //        Name = "Amogus",
    //        level = "1",
    //        score = "100"
    //    };

    //    Player P2 = new Player
    //    {
    //        Name = "Bryan",
    //        level = "2",
    //        score = "400"
    //    };
    //    Player P3 = new Player
    //    {
    //        Name = "Laura",
    //        level = "3",
    //        score = "13"
    //    };
    //}

}
