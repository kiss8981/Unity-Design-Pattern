using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeTurnState : MonoBehaviour, IBikeState
{
    private BikeController _bikeController;

    public void Handle(BikeController bikeController)
    {
        if (!_bikeController)
        {
            _bikeController = bikeController;
        }

        Vector3 turnDirection = new Vector3(0, 0, 0);
        turnDirection.x = (float)_bikeController.direction;

        transform.Translate(
            turnDirection * Time.deltaTime * _bikeController.speed
        );
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
