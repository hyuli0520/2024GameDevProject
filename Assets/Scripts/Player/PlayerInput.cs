using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour, IPlayerInput
{
    private Vector2 _inputVec;
    public Vector2 InputVec => _inputVec;

    public void OnMove(InputValue value)
    {
        _inputVec = value.Get<Vector2>();
    }
}
