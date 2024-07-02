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

    void OnMove(InputValue value); // InputSystem
}
