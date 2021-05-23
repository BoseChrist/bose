using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayFromObject_LightDetector : MonoBehaviour
{
    public GameObject SensorSpotLight;
    public float RayDistance = 3.0f; //顯示射線距離

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
        RayFromObject_Detector();
    }

    void RayFromObject_Detector()
    {
        //生成射線
        ray = new Ray(transform.position, transform.forward);//注意射線方向是前方(物件藍色箭頭向)
        //顯示射線
        Debug.DrawRay(ray.origin, ray.direction * RayDistance, Color.green);//duration和depthTest採預設值

        if (Physics.Raycast(ray, out raycastHit))//一定要使用if程序才能使用raycastHit的各種子函式得到回傳資訊
        {
            //印出 raycastHit 被打到的collider相關資訊
            //print($"The Object's name hit by ray: {raycastHit.transform.gameObject.name}");
            //print($"{raycastHit.transform.gameObject.name}; {raycastHit.collider.gameObject.name}"); //兩種印出物件名稱的方式raycastHit函式方法要抓到gameobject, 
            //需使用raycastHit.transform或者raycastHit.collider
            //print($"The distance from hit object:{raycastHit.distance}");
            //print($"The point of the ray projecting on the object: {raycastHit.point}");
            if (raycastHit.transform.gameObject.name == "MainCharacter")
            {    
                print($"The Object's name hit by ray: {raycastHit.transform.gameObject.name}");
                SensorSpotLight.SetActive(true);
            }
        }
    }

}
