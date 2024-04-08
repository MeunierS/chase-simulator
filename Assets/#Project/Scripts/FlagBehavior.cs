using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FlagBehavior : MonoBehaviour
{
    [SerializeField] private FlagBehavior nextOne;
    public bool mustBeDeactivated;

    // Start is called before the first frame update
    void Awake()
    {
        if(nextOne != null)
        {
            nextOne.mustBeDeactivated=true;
        }
    }

    // Update is called once per frame
    void Start()
    {
        if (mustBeDeactivated){
            gameObject.SetActive(false);
            mustBeDeactivated = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{other.name} entered into {name}");
        if(other.CompareTag("Player")){
            if(nextOne != null)
            {
                nextOne.gameObject.SetActive(true);
            }
            gameObject.SetActive(false);
        }
    }
}
