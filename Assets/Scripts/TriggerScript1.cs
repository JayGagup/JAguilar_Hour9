using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + "has touched the sphere");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(gameObject.name + "is still in the sphere");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(gameObject.name + "has left the sphere");
    }
}
