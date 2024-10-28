using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2d>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
    }
    
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + 3.0f * horizontal * Time.DeltaTime;
        position.y = position.y + 3.0f * vertical * Time.DeltaTime;

        rigidbody2d.MovePosition(position);
    }

       
}
