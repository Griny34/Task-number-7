using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");

        _playerMovement.Move(moveX);
        _playerMovement.ChekSide(moveX);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerMovement.JumpPlayer();
        }
    }
}
