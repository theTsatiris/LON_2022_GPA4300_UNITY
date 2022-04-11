using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCommand : Command
{
    private MovingController movingObject;

    public MoveLeftCommand(MovingController obj)
    {
        this.movingObject = obj;
    }

    public override void Execute()
    {
        this.movingObject.MoveLeft();
    }

    public override void Undo()
    {
        this.movingObject.MoveRight();
    }
}
