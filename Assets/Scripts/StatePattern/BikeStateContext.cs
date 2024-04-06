using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeStateContext : MonoBehaviour
{
    public IBikeState CurrentState
    {
        get;
        set;
    }

    private BikeController _bikeController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    public BikeStateContext(BikeController bikeController)
    {
        _bikeController = bikeController;
    }

    public void Transition()
    {
        CurrentState.Handle(_bikeController);
    }

    public void Transiton(IBikeState state)
    {
        CurrentState = state;
        CurrentState.Handle(_bikeController);
    }
}
