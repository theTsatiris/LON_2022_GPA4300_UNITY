using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardCommand : Command
{
    private MovingController movingObject;

    public MoveForwardCommand(MovingController obj)
    {
        this.movingObject = obj;
    }

    public override void Execute()
    {
        this.movingObject.MoveForward();
    }

    public override void Undo()
    {
        this.movingObject.MoveBackwards();
    }
}
