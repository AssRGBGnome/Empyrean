using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Player;
    public Animator CamMovement;

    private void Update()
    {
        Cursor.visible = false;
        Vector2 Play = Player.transform.position;
        if (Player.transform.position.y >= -5f && Player.transform.position.y <= 5f && Player.transform.position.x > -5f && Player.transform.position.x < 5f)
        {
            CamMovement.SetInteger("Screen", 1);
        }
        if (Player.transform.position.y >= -10f && Player.transform.position.y <= -5f && Player.transform.position.x > -5f && Player.transform.position.x < 5f)
        {
            CamMovement.SetInteger("Screen", 2);
        }
    }
}
