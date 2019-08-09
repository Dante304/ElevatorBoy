using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public void Walk(bool walk,float h, float v)
    {
        if (h > 0.0f)
        {
            spriteRenderer.flipX = false;
        }
        else if (h < 0.0f)
        {
            spriteRenderer.flipX = true;
        }
         animator.SetBool("Walk", walk);
           
    }
}
