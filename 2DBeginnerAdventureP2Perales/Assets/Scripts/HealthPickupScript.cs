using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickupScript : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerControllerFinal controller = other.GetComponent<PlayerControllerFinal>();
        if (controller != null)
        {
            if(controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
       
        }
    }
}
