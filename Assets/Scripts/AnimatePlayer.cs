using UnityEngine;

public class Animate : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            animator.SetTrigger("FIGHT");
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            animator.SetTrigger("Walk");
            animator.ResetTrigger("Idle");
            animator.ResetTrigger("WalkR");
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            animator.SetTrigger("WalkR");
            animator.ResetTrigger("Idle");
            animator.ResetTrigger("Walk");
        }
        else
        {
            animator.SetTrigger("Idle");
            animator.ResetTrigger("Walk");
            animator.ResetTrigger("WalkR");
        }
    }
}
