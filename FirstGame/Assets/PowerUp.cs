using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class PowerUp : ScriptableObject {
public int powerlevel = 10;
public Player CurrentPlayer;

public void runpowerup()
{
   
    CurrentPlayer.score += powerlevel;

}

}
