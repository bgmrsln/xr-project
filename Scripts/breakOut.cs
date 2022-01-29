using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakOut : MonoBehaviour
{
    private Transform tf;
    public Vector3 nextPosition;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        nextPosition = new Vector3(0, 1, -10);
    }

    // Update is called once per frame
    void Update()
    {
        //OVRInput.Get(OVRInput.Button.One)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (tf.localPosition == nextPosition) {
                tf.SetPositionAndRotation(new Vector3(0,1,0), tf.localRotation);
            }
            else
            {
                tf.SetPositionAndRotation(nextPosition, tf.localRotation);
            }

            
        }
        
    }
}
