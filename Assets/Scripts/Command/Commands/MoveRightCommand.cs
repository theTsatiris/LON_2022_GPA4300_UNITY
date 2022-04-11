using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightCommand : Command
{
    private MovingController movingObject;

    public MoveRightCommand(MovingController obj)
    {
        this.movingObject = obj;
    }

    public override void Execute()
    {
        this.movingObject.MoveRight();
    }

    public override void Undo()
    {
        this.movingObject.MoveLeft();
    }
}
