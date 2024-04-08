using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class DirectActionInput : MonoBehaviour
{
    public InputAction moveHorizontal;
    public InputAction shoot;
    public float speed;

    public void OnEnable(){
        moveHorizontal.Enable();
        shoot.Enable();
    }
    public void OnDisable(){
        moveHorizontal.Disable();
        shoot.Disable();
    }
    void Update(){
        float movement = moveHorizontal.ReadValue<float>();
        movement = Mathf.Clamp(movement, -1, 1);
        transform.Translate(speed* Time.deltaTime * movement, 0, 0);
    }
    public void Awake(){
        shoot.performed += ctx => {OnShoot(ctx);};
    }
    public void OnShoot(InputAction.CallbackContext ctx){
        Debug.Log("You shot !");
    }
}
