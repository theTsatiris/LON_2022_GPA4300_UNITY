using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public int armor;
    public int attack;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameManager myGm = GameManager.Instance;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameStats.SCORE++;
        GameStats.ROUND++;
    }
}
