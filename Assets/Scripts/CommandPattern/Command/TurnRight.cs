using System.Collections;
using System.Collections.Generic;
using CommandPattern;
using UnityEngine;

public class TurnRight : Command
{
    private CommandBikeController _bikeController;

    public TurnRight(CommandBikeController bikeController)
    {
        _bikeController = bikeController;
    }
    
    public override void Execute()
    {
        _bikeController.Turn(CommandPatternDirectionEnum.Right);
    }
}
