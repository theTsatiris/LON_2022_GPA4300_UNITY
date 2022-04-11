using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data
{
    List<float> actualLoad;
    public static int SIZE = 10000;

    public Data()
    {
        for(int i = 0; i < SIZE; i++)
        {
            actualLoad.Add(i);
        }
    }
}
