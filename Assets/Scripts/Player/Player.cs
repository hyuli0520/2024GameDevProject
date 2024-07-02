using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerMovement playerMovement; // �÷��̾� �̵�
    PlayerInput playerInput; // �÷��̾� �Է�
    PlayerAttack playerAttack; // �÷��̾� ����

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
