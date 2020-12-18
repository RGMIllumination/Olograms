using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfBoyAnimations : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(AnimationsStates());
    }

    public void Idle()
    {
        animator.SetBool("GoWaving", false);
        animator.SetBool("GoDance", false);
    }

    public void Dance()
    {
        animator.SetBool("GoDance", true);
        animator.SetBool("GoWaving", false);
    }

    public void Waving()
    {
        animator.SetBool("GoWaving", true);
        animator.SetBool("GoDance", false);
    }


    public IEnumerator AnimationsStates()
    {
        Idle();
        yield return new WaitForSeconds(5.0f);

        Waving();
        yield return new WaitForSeconds(5.0f);

        Dance();
        yield return new WaitForSeconds(5.0f);

        StartCoroutine(AnimationsStates());
    }
}
