using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPlayer : MonoBehaviour
{
    private Vector2 dirMov;
    public float velMov;
    public Rigidbody2D rb;
    public Animator anim;

    private void FixedUpdate()
    {
        Movimiento();
        AnimacionesPlayer();
    }
    private void Movimiento()
    {
        float movX = Input.GetAxisRaw("Horizontal");
        float movY = Input.GetAxisRaw("Vertical");
        dirMov = new Vector2(movX, movY).normalized;
        rb.velocity = new Vector2(dirMov.x * velMov, dirMov.y * velMov);
    }
    void AnimacionesPlayer()
    {
        anim.SetFloat("movX", dirMov.x);
        anim.SetFloat("movY", dirMov.y);
    }
        
}
