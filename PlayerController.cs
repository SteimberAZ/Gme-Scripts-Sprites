using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("a"))
        {
      // lo mismo pero as largo uwu gameObject.transform.position= new Vector3(gameObject.transform.position.x+50f*Time.deltaTime,gameObject.transform.position.y,gameObject.transform.position.z);
        gameObject.transform.Translate(-50f*Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("d"))
        {
            gameObject.transform.Translate(50f*Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("w"))
        {
            gameObject.transform.Translate(0, 50f*Time.deltaTime, 0);
        }
        if(Input.GetKey("s"))
        {
            gameObject.transform.Translate(0, -50f*Time.deltaTime, 0);
        }
       
    }
}

