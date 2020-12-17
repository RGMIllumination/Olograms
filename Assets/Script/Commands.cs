using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commands : MonoBehaviour
{

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.FindGameObjectsWithTag(“Player”);
    }


    public void Jump()
    {
     animator.SetBool(“GoJump", true);
     animator.SetBool(“SayHi”, false);
    }

    public void Hello()
    {
     animator.SetBool(“SayHi”, true);
     animator.SetBool(“GoJump”, false);
    }

    public void Idle()
    {
     animator.SetBool(“SayHi”, false);
     animator.SetBool(“GoJump", false);
    }

}
