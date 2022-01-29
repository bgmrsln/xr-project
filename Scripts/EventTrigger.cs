using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTrigger : MonoBehaviour
{
    public UnityEvent onTrigger;
    public bool destroyAfterTrigger = true;

    void awake()
    {
        if(onTrigger== null)
        {
            onTrigger = new UnityEvent();
        }
    }
    void OnTriggerEnter(Collider Other)
    {
        onTrigger.Invoke();
       
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
