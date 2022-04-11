using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightWeightPlayer
{
    private float health;
    private float armor;

    //Common Data object, supposedely shared among all players
    private Data EnvData;

    public LightWeightPlayer(Data data)
    {
        this.health = Random.Range(100.0f, 1000.0f);
        this.armor = Random.Range(10.0f, 100.0f);

        //Every player has a reference to a single copy of the Data object (created elsewhere)!
        this.EnvData = data;
    }
}