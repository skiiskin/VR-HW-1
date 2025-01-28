using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportPlayer : MonoBehaviour
{

    public InputActionReference action;
    // Start is called before the first frame update
    void Start()
    {
        //starting location is in room
        bool isInRoom = true;

        //teleportation locations, including compensation for camera height
        Vector3 insideRoom = new Vector3(0, 1, 0);
        Vector3 outsidePlane = new Vector3(-20, 11, -15);

        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (isInRoom)
            {
                gameObject.transform.position = outsidePlane;
                isInRoom = false;
            }
            else
            {
                gameObject.transform.position = insideRoom;
                isInRoom = true;
            }
        }; 
    }
}