using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakOut : MonoBehaviour
{
    private Transform tf;
    public Vector3 nextPosition = new Vector3(0,1,-40);
    
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //OVRInput.Update();
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            if (tf.localPosition == nextPosition)
            {
                tf.position = new Vector3(0, 1, 0);

            }
            else
            {
                tf.position = nextPosition;
            }


        }
        
        //OVRInput.Get(OVRInput.Button.One)
        //Input.GetKeyDown(KeyCode.Space)
     
       
    }
    
}
