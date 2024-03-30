using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeStopState : MonoBehaviour, IBikeState
{
    private BikeController _bikeController;

    public void Handle(BikeController bikeController)
    {
        if (!_bikeController)
        {
            _bikeController = bikeController;
        }

        _bikeController.speed = 0.0f;
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
