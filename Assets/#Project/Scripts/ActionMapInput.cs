using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ActionMapInput : MonoBehaviour
{
    public InputActionAsset inputActions;
    private InputAction move;
    private InputAction shoot;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        move = inputActions.FindActionMap("Player").FindAction("Move");
        shoot = inputActions.FindActionMap("Player").FindAction("Shoot");
        shoot.performed += ctx => {OnShoot(ctx);};
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = move.ReadValue<Vector2>();
        movement *= speed * Time.deltaTime;
        transform.Translate(movement.x, 0, movement.y);
    }
    public void OnShoot(InputAction.CallbackContext ctx){
        Debug.Log("You shot !");
    }
}
