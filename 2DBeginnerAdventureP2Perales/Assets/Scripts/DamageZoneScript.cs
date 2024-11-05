using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZoneScript : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        PlayerControllerFinal controller = other.GetComponent<PlayerControllerFinal>();

        if(controller != null )
        {
            controller.ChangeHealth(-1);
        }
    }
}
