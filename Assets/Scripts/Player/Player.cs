using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerMovement playerMovement; // �÷��̾� �̵�
    PlayerInput playerInput; // �÷��̾� �Է�

    void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        playerMovement.Move(playerInput.InputVec);
    }
}
