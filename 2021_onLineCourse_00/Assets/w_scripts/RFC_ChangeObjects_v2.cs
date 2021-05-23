using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RFC_ChangeObjects_v2 : MonoBehaviour
{
    public GameObject Red_Sphere;
    public GameObject Green_Sphere;
    public GameObject Gray_Sphere;
    public bool ChangeState = false;
    public bool ChangeState01 = false;

    //射線功能的起手勢
    Ray ray;
    RaycastHit raycastHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RFC_CangeOverTwoOBS();
    }
    void RFC_CangeOverTwoOBS()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);//定義由攝影機發出到滑鼠位置的射線
        if (Physics.Raycast(ray, out raycastHit)) //定義射線打中物件之代理變數raycastHit
        {
            Debug.DrawLine(Camera.main.transform.position, raycastHit.point, Color.blue, 0.5f, true);

            if (raycastHit.transform.gameObject.name == gameObject.name)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (ChangeState == false && ChangeState01 == false)
                    {
                        //print($"01:  {raycastHit.transform.gameObject.name}");
                        Red_Sphere.SetActive(false);
                        Green_Sphere.SetActive(true);
                        Gray_Sphere.SetActive(false);
                        ChangeState = true;
                        ChangeState01 = false;
                    }
                    else if (ChangeState == true && ChangeState01 == false)
                    {
                        //print($"02:  {raycastHit.transform.gameObject.name}");
                        Red_Sphere.SetActive(false);
                        Green_Sphere.SetActive(false);
                        Gray_Sphere.SetActive(true);
                        ChangeState = true;
                        ChangeState01 = true;
                    }
                    else if (ChangeState == true && ChangeState01 == true)
                    {
                        //print($"03:  {raycastHit.transform.gameObject.name}");
                        Red_Sphere.SetActive(true);
                        Green_Sphere.SetActive(false);
                        Gray_Sphere.SetActive(false);
                        ChangeState = false;
                        ChangeState01 = false;
                    }

                }

            }
        }


    }
}
