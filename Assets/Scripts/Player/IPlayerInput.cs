using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
///  플레이어 입력 인터페이스
/// </summary>
public interface IPlayerInput
{
    public Vector2 InputVec { get; }

    void OnMove(InputValue value); // InputSystem
}
