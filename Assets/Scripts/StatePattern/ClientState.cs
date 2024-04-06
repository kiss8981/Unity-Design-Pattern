using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientState : MonoBehaviour
{
    private BikeController _bikeController;

    void Start()
    {
        _bikeController =
            (BikeController)
            FindObjectOfType(typeof(BikeController));
    }




    void OnGUI()
    {
        if (GUILayout.Button("Start Bike"))
            _bikeController.StartBike();

        if (GUILayout.Button("Turn Left"))
            _bikeController.TurnBike(Direction.left);

        if (GUILayout.Button("Turn Right"))
            _bikeController.TurnBike(Direction.right);

        if (GUILayout.Button("Stop Bike"))
            _bikeController.StopBike();
    }
}
