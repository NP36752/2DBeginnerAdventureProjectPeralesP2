using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;
    public bool vertical;
    public float changeTime = 3.0f;

    public ParticleSystem smokeEffect;

    Rigidbody2D rigidbody2d;

    bool broken = true;

    float timer;
    int direction = 1;

    Animator animator;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changeTime;
        animator = GetComponent<Animator>();

    }

    
    void Update()
    {
        if(!broken)
        {
            return;
        }
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        if (vertical)
        {
            if(!broken)
            {
                return;
            }
            animator.SetFloat("MoveX", 0);
            animator.SetFloat("MoveY", direction);
            position.y = position.y + Time.deltaTime * speed * direction;
        }
        else
        {
            animator.SetFloat("MoveX", direction);
            animator.SetFloat("MoveY", 0);
            position.x = position.x + Time.deltaTime * speed * direction;
        }


        rigidbody2d.MovePosition(position);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        PlayerControllerFinal player = other.gameObject.GetComponent<PlayerControllerFinal>();
        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }

    public void Fix()
    {
        broken = false;
        rigidbody2d.simulated = false;
        animator.SetTrigger("FixedDown");
        smokeEffect.Stop();
    }
}
