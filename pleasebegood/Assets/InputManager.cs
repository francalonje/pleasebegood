using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerControls playerControls;

    public Vector2 movementInput;

    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();

            playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>(); // When we hit WASD or LeftStick. We record that value on a Vector2 variable -> movementInput.
        }

        playerControls.Enable();

    }


    private void OnDisable()
    {
        playerControls.Disable();
    }

}
