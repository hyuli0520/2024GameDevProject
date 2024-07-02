using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerMovement playerMovement; // 플레이어 이동
    PlayerInput playerInput; // 플레이어 입력
    PlayerAttack playerAttack; // 플레이어 공격

    void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerInput = GetComponent<PlayerInput>();
        playerAttack = GetComponent<PlayerAttack>();
    }

    void Update()
    {
        playerMovement.Move(playerInput.InputVec);
        playerMovement.LookAtMouse();

        if(playerInput.InputMouseClick)
        {
            playerAttack.Shoot();
        }
    }
}
