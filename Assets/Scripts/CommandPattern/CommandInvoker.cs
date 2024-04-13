using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    private bool _isRecording;
    private bool _isReplaying;
    private float _replayTime;
    private float _recordingTime;
    private SortedList<float, Command> _recordedCommands = 
        new SortedList<float, Command>();

    public void ExecuteCommand(Command command)
    {
        command.Execute();
            
        if (_isRecording) 
            _recordedCommands.Add(_recordingTime, command);
    }

    public void Record()
    {
        _recordingTime = 0.0f;
        _isRecording = true;
    }

    public void Replay()
    {
        _replayTime = 0.0f;
        _isReplaying = true;
            
        _recordedCommands.Reverse();
    }
        
    void FixedUpdate()
    {
        if (_isRecording) 
            _recordingTime += Time.fixedDeltaTime;
            
        if (_isReplaying)
        {
            _replayTime += Time.fixedDeltaTime;

            if (_recordedCommands.Any()) 
            {
                if (Mathf.Approximately(
                        _replayTime, _recordedCommands.Keys[0])) {
                    _recordedCommands.Values[0].Execute();
                    _recordedCommands.RemoveAt(0);
                }
            }
            else
            {
                _isReplaying = false;
            }
        }
    }
}
