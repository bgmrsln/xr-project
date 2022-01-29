using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbiting : MonoBehaviour
{
    private Transform tf;
    private float rotationSpeed= 5f;

    void Rotate()
    {
        tf.Rotate(new Vector3(0f, 6f * rotationSpeed * Time.deltaTime, 0f));
    }
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }
}
