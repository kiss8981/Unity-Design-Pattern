using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    private IBikeState _bikeStartState;
    private IBikeState _bikeStopState;
    private IBikeState _bikeTurnState;

    public float speed = 2.0f;
    public Direction direction = Direction.right;

    private BikeStateContext _bikeStateContext;

    // Start is called before the first frame update
    void Start()
    {
        _bikeStateContext = new BikeStateContext(this);

        _bikeStartState = gameObject.AddComponent<BikeStartState>();
        _bikeStopState = gameObject.AddComponent<BikeStopState>();
        _bikeTurnState = gameObject.AddComponent<BikeTurnState>();

        _bikeStateContext.Transiton(_bikeStopState);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartBike()
    {
        _bikeStateContext.Transiton(_bikeStartState);
    }

    public void StopBike()
    {
        _bikeStateContext.Transiton(_bikeStopState);
    }

    public void TurnBike(Direction changeDirection)
    {
        direction = changeDirection;
        _bikeStateContext.Transiton(_bikeTurnState);
    }
}
