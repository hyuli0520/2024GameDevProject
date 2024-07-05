using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public static Player instance;

    PlayerMovement playerMovement; // 플레이어 이동
    PlayerInput playerInput; // 플레이어 입력
    PlayerAttack playerAttack; // 플레이어 공격

    void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerInput = GetComponent<PlayerInput>();
        playerAttack = GetComponent<PlayerAttack>();

        instance = this;
    }

    void Update()
    {
        playerMovement.Move(playerInput.InputVec);
        playerMovement.LookAtMouse(playerInput.MousePos);

        if(playerInput.InputMouseClick)
        {
            playerAttack.Shoot();
        }
    }
}
