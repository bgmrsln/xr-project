using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightscr : MonoBehaviour
{
    public Light light;
    float red = 0.3f;
    float green = 0.4f;
    float blue = 0.6f;
    float alpha = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        //OVRInput.Get(OVRInput.Button.Two)
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            light.color = new Color(red,green, blue, alpha);
            red = Random.Range(0f,1f);
            green = Random.Range(0f, 1f);
            blue = Random.Range(0f, 1f);
            
        }
        
    }
}
