using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class ActivateActionMap : MonoBehaviour
{
    public InputActionAsset inputActions;
    public string[] actionMapsToEnable;

    void OnEnable(){
        foreach (string actionMap in actionMapsToEnable)
        {
            inputActions.FindActionMap(actionMap).Enable();
        }
    }
    void OnDisable(){
        foreach (string actionMap in actionMapsToEnable)
        {
            inputActions.FindActionMap(actionMap).Disable();
        }
    }
}
