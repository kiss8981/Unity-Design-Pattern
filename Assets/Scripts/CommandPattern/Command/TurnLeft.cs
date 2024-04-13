using System.Collections;
using System.Collections.Generic;
using CommandPattern;
using UnityEngine;

public class TurnLeft : Command
{
    private CommandBikeController _bikeController;

    public TurnLeft(CommandBikeController bikeController)
    {
        _bikeController = bikeController;
    }
    
    public override void Execute()
    {
        _bikeController.Turn(CommandPatternDirectionEnum.Left);
    }
}
