using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commands : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(ChangeAnimations());
    }


    public void Jump()
    {
        animator.SetBool("GoJump", true);
        animator.SetBool("SayHi", false);
    }

    public void Hello()
    {
        animator.SetBool("SayHi", true);
        animator.SetBool("GoJump", false);
    }

    public void Idle()
    {
        animator.SetBool("SayHi", false);
        animator.SetBool("GoJump", false);
    }




    public IEnumerator ChangeAnimations()
    {
        Idle();
        yield return new WaitForSeconds(5.0f);

        Hello();
        yield return new WaitForSeconds(5.0f);

        Jump();
        yield return new WaitForSeconds(5.0f);

        StartCoroutine(ChangeAnimations());
    }
}
