using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightManager : MonoBehaviour
{
    [SerializeField]
    int heavyObjects;
    [SerializeField]
    int lightObjects;

    List<HeavyWeightPlayer> heavyList;
    List<LightWeightPlayer> lightList;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        heavyList = new List<HeavyWeightPlayer>();
        lightList = new List<LightWeightPlayer>();

        for (int i = 0; i < heavyObjects; i++)
        {
            HeavyWeightPlayer pl = new HeavyWeightPlayer();
            heavyList.Add(pl);
        }

        Data data = new Data();
        for (int i = 0; i < lightObjects; i++)
        {
            LightWeightPlayer pl = new LightWeightPlayer(data);
            lightList.Add(pl);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*int a = 0;
        AFunction(a);

        Data rubbish = new Data();
        BFunction(rubbish);*/
    }

    /*void AFunction(int a)
    {
        a = 1234;
    }

    void BFunction(Data obj)
    {
        obj = ...;
    }*/
}
