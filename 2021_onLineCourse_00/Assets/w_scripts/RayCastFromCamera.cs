using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastFromCamera : MonoBehaviour
{
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
        Ray_From_Camera_ShowHitObjectName();

    }

    void Ray_From_Camera_ShowHitObjectName()//射線射中目標物件顯示UI Text 
    {
        //定義射線如何生成
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);//定義由攝影機發出到滑鼠位置的射線
        if (Physics.Raycast(ray, out raycastHit))//Physics.Raycast()方法檢測射線碰撞資訊(要碰撞客體物件該物件必須有(Collider))
        {
            //顯示射線
            //Debug.DrawLine(Camera.main.transform.position, raycastHit.transform.position, Color.red, 0.5f, true);//只能顯示射線為擊中物件中心
            Debug.DrawLine(Camera.main.transform.position, raycastHit.point, Color.red, 0.5f, true);//任意顯示擊中點
            //起點, 擊中點位置, 顯示顏色, 持續時間, 深度測試
            //print(raycastHit.transform.gameObject.name);

            //UI.text
            //Text_RayHitObject.text = $"<color=red>The name of the object hit by Ray: </color> {raycastHit.transform.gameObject.name}";
            //印出射線擊中的物件(需要有Collider)的名字
            //print($"The object is hit by Ray is: {raycastHit.transform.gameObject.name}");
        }
    }


}
