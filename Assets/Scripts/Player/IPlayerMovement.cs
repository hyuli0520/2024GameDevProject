using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  플레이어 이동 인터페이스
/// </summary>
public interface IPlayerMovement
{
    public void Move(Vector2 inputVec); // 일반적인 이동
    public void MoveTo(Vector2 des); // 특정 지점으로 이동
}