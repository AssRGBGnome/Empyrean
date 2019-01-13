using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator Anim;
    public Rigidbody2D rbtwod;
    public float movespeed = 4f;
    public float swordtimer = .2f;
    public bool able = true;
    public bool swordswing = false;

    private void FixedUpdate()
    {
        if(able == true)
        {
            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");
            rbtwod.velocity = new Vector2(h, v) * movespeed;
            if (Input.GetKeyDown(KeyCode.A))
            {

            }
            if (Input.GetKeyDown(KeyCode.D))
            {

            }
            if (Input.GetKeyDown(KeyCode.W))
            {

            }
            if (Input.GetKeyDown(KeyCode.S))
            {

            }
            if (swordswing == true)
            {
                swordtimer -= Time.deltaTime;
                if (swordtimer <= 0)
                {
                    Anim.SetBool("Idle", true);
                    Anim.SetBool("Attack", false);
                    swordswing = false;
                    swordtimer = .25f;
                }
            }
            if (Input.GetKey(KeyCode.Space))
            {
                Anim.SetBool("Attack", true);
                swordswing = true;
            }
        }
    }
}