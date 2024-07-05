using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public static Player instance;

    PlayerMovement playerMovement; // �÷��̾� �̵�
    PlayerInput playerInput; // �÷��̾� �Է�
    PlayerAttack playerAttack; // �÷��̾� ����

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
