using System.Collections;
using System.Collections.Generic;
using CommandPattern;
using UnityEngine;

public class CommandBikeController : MonoBehaviour
{
    private bool _isTurboOn;
    private float _distance = 1.0f;

    public void ToggleTurbo()
    {
        _isTurboOn = !_isTurboOn;
    }

    public void Turn(CommandPatternDirectionEnum direction)
    {
        if (direction == CommandPatternDirectionEnum.Left)
            transform.Translate((Vector3.right * _distance));
        
        if (direction == CommandPatternDirectionEnum.Right)
            transform.Translate(Vector3.right * _distance);
    }

    public void ResetPosition()
    {
        transform.position = Vector3.zero;
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
