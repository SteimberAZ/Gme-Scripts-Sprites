using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
    // Start is called before the
    private float teleportDistance = 50f; // Distancia del teletransporte
    // Start is called before the first frame update
    private float cooldownTime = 5f; // Tiempo de espera en segundos
    private float nextTeleportTime = 0f; // Tiempo en que se puede volver a teletransportar first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Time.time >= nextTeleportTime && Input.GetKey("e"))
        {
            if (Input.GetKey("w"))
            {
                gameObject.transform.Translate(0, teleportDistance, 0);
                nextTeleportTime = Time.time + cooldownTime;
            }
            else if (Input.GetKey("a"))
            {
                gameObject.transform.Translate(-teleportDistance, 0, 0);
                nextTeleportTime = Time.time + cooldownTime;
            }
            else if (Input.GetKey("s"))
            {
                gameObject.transform.Translate(0, -teleportDistance, 0);
                nextTeleportTime = Time.time + cooldownTime;
            }
            else if (Input.GetKey("d"))
            {
                gameObject.transform.Translate(teleportDistance, 0, 0);
                nextTeleportTime = Time.time + cooldownTime;
            }
        }  
    }
}
