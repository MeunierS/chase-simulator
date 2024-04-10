using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputEvents : MonoBehaviour
{
    public float speed;
    private Vector2 movement;
    public void HandleMovement(InputAction.CallbackContext context){
        if (context.performed)
        {
            movement = context.ReadValue<Vector2>();
        }
        else if (context.canceled){
            movement = Vector2.zero;
        }
    }
    //!TO BE MOVED to it's own script
    // public void OnShoot(InputAction.CallbackContext context){
    //     if (context.performed)
    //     {
    //         Debug.Log("You shot !");
    //     }
    // }
    void Update(){
        Vector2 displacement = movement* speed * Time.deltaTime;
        transform.Translate(displacement.x, 0, displacement.y);
    }
}
