using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerControllerFinal controller = other.GetComponent<PlayerControllerFinal>();
        if (controller != null)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
}
