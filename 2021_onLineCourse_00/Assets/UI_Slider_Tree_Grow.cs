using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//要宣告才有UI的相關變數可以索引


public class UI_Slider_Tree_Grow : MonoBehaviour
{
    public GameObject AnimatorTargetObject;
    Animator animator;

    Slider slider;//一定要在此先宣告Slider變數, 不能在Start區宣告
    // Start is called before the first frame update
    void Start()
    {
        animator = AnimatorTargetObject.GetComponent<Animator>();
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Slider_TreeGrow()
    {
        animator.SetFloat("SliderGrow", slider.value);
        print(slider.value);
    }
}
