using System.Collections;
using System.Collections.Generic;
using CommandPattern;
using UnityEngine;

public class ToggleTurbo : Command
{
    private CommandBikeController _bikeController;

    public ToggleTurbo(CommandBikeController bikeController)
    {
        _bikeController = bikeController;
    }
    
    public override void Execute()
    {
        _bikeController.ToggleTurbo();
    }
}
