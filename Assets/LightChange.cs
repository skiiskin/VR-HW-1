using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightChange : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();

        Color blue = Color.blue;
        Color green = Color.green;
        Color red = Color.red;
        Color white = Color.white;
        Color gray = Color.gray;
        Color[] colors = {blue, green, red, white, gray};

        int totalColors = colors.Length;
        int clicks = 0;

        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            light.color = colors[clicks % totalColors];
            clicks++;
        };
    }
}
