using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountCollider : MonoBehaviour
{

   
    int score;

  private void OnCollisionEnter(Collision collision)
    {
         score = score + 1;
    }
    // Use this for initialization
    void Start()
    {

       

    }


    // Update is called once per frame
    void Update()
    {

        Debug.Log(score);

    }


    
}
