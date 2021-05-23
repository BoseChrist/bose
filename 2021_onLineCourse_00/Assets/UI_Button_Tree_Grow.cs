using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Button_Tree_Grow : MonoBehaviour
{
    public GameObject AnimatorTargetObject;
    Animator animator;
    public bool TargetAnimatorBool = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = AnimatorTargetObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Button_TreeGrow()
    {
        if (TargetAnimatorBool == false)
        {
            animator.SetBool("Growing", true);
            TargetAnimatorBool = true;
        }
        else
        {
            animator.SetBool("Growing", false);
            TargetAnimatorBool = false;
        }
    }
}
