using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DirectDeviceInput : MonoBehaviour
{

    [SerializeField] private float speed=2;
    // Update is called once per frame
    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed){
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (keyboard.qKey.isPressed || keyboard.leftArrowKey.isPressed){
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (keyboard.zKey.isPressed || keyboard.upArrowKey.isPressed){
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed){
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (keyboard.spaceKey.isPressed){
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (keyboard.shiftKey.isPressed){
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        
    }
}
