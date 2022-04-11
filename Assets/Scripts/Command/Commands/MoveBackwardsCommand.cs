using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackwardsCommand : Command
{
    private MovingController movingObject;

    public MoveBackwardsCommand(MovingController obj)
    {
        this.movingObject = obj;
    }

    public override void Execute()
    {
        this.movingObject.MoveBackwards();
    }

    public override void Undo()
    {
        this.movingObject.MoveForward();
    }
}
