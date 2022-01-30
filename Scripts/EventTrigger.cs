using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTrigger : MonoBehaviour
{
    public UnityEvent onTrigger;
    public bool destroyAfterTrigger = true;
    public Collider coll;

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
        coll.attachedRigidbody.useGravity = true;
        Other.isTrigger = true;
        coll.isTrigger = false;
        
      
        
       
    }
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
