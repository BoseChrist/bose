using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_DoorOPCL : MonoBehaviour
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
    public void Button_OpenCloseDoor()
    {
        if (TargetAnimatorBool == false)
        {
            animator.SetBool("Open", true);
            TargetAnimatorBool = true;
        }
        else
        {
            animator.SetBool("Open", false);
            TargetAnimatorBool = false;
        }
    }


}
