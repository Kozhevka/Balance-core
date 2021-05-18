using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputListener : MonoBehaviour
{
    private Vector2 inputRotation;

    public void InputDelta(InputAction.CallbackContext ctx)
    {
        inputRotation += ctx.ReadValue<Vector2>();
        GameActive.instance.RotateFloor(inputRotation);
    }

    public void StickContext(InputAction.CallbackContext ctx)
    {
        inputRotation = ctx.ReadValue<Vector2>();
        GameActive.instance.RotateFloor(inputRotation);
    }
    public void GyroInput(InputAction.CallbackContext ctx)
    {
        inputRotation = ctx.ReadValue<Vector3>();
        GameActive.instance.RotateFloor(inputRotation);
    }


}