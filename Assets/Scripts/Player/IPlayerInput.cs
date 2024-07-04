using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
///  �÷��̾� �Է� �������̽�
/// </summary>
public interface IPlayerInput
{
    public Vector2 InputVec { get; }
    public bool InputMouseClick { get; }
    public Vector2 MousePos { get; }

    // InputSystem
    void OnMove(InputValue value);
    void OnFire(InputValue value);
    void OnLook(InputValue value);
}
