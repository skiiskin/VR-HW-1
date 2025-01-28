using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GrabObject : MonoBehaviour
{
    public GameObject currentObject;

    void start()
    {
        currentObject = GetComponent<GameObject>();
    }

    void OnTriggerEnter(Collider newParent)
    {
        currentObject.transform.SetParent(newParent.transform);
        Debug.Log("collision");
    }
}
