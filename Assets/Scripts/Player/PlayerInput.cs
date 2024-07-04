using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour, IPlayerInput
{
    private Vector2 _inputVec;
    public Vector2 InputVec => _inputVec;

    private bool _inputMouseClick;
    public bool InputMouseClick => _inputMouseClick;

    private Vector2 _mousePos;
    public Vector2 MousePos => _mousePos;

    public void OnMove(InputValue value)
    {
        _inputVec = value.Get<Vector2>();
    }

    public void OnFire(InputValue value)
    {
        _inputMouseClick = value.isPressed;
    }

    public void OnLook(InputValue value)
    {
        _mousePos = value.Get<Vector2>();
    }

}
