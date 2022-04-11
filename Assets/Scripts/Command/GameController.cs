using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private MovingController player;

    private Command key_W;
    private Command key_A;
    private Command key_S;
    private Command key_D;

    private Stack<Command> undoStack;

    // Start is called before the first frame update
    void Start()
    {
        key_W = new MoveForwardCommand(player);
        key_A = new MoveLeftCommand(player);
        key_S = new MoveBackwardsCommand(player);
        key_D = new MoveRightCommand(player);

        undoStack = new Stack<Command>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            key_W.Execute();
            undoStack.Push(key_W);
        }
        if(Input.GetKey("a"))
        {
            key_A.Execute();
            undoStack.Push(key_A);
        }
        if(Input.GetKey("s"))
        {
            key_S.Execute();
            undoStack.Push(key_S);
        }
        if(Input.GetKey("d"))
        {
            key_D.Execute();
            undoStack.Push(key_D);
        }

        if(Input.GetKey("u"))
        {
            if(undoStack.Count == 0)
            {
                Debug.Log("Undo stack is empty!!");
            }
            else
            { 
                Command comm = undoStack.Pop();
                comm.Undo();
            }
        }
    }
}
