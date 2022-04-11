using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//SINGLETON PATTERN
public class GameManager : MonoBehaviour
{
    /*public int score
    {
        get
        {
            //"getter" intermediate code
            return score;
        }
        set
        {
            //"setter" intermediate code
        }
    }*/
    public int score;
    public int round;

    private static GameManager instance = null;

    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                //If we have changed scenes, the "carrying" gameobject may not be alive as well!
                //So we have to search in the scene for a GO with the GameManager loaded on it
                GameManager inst = GameObject.FindObjectOfType<GameManager>();
                
                if(inst == null)
                {
                    GameObject obj = new GameObject("Game Manager");
                    instance = obj.AddComponent<GameManager>();

                    //call initializing functions
                    instance.Init();

                    //Designates the newly created gameobject as one that should not be destroyed
                    //when a new scene is loaded!
                    DontDestroyOnLoad(obj);
                }
            }

            return instance;
        }
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;

            //Call initializing functions
            instance.Init();

            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Init()
    {
        // Initializing function (kindof like a constructor)
        //....
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
