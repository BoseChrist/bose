using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//使用UI一定要宣告


public class RFC_RBobjectJump : MonoBehaviour
{
    public GameObject UI_Canvas;
    public Text Text_RayHitObject;
    Rigidbody W_Rigidbody;

    //射線功能的起手勢
    Ray ray;
    RaycastHit raycastHit;
    // Start is called before the first frame update
    void Start()
    {
        W_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RFC_UI_Test();
        RFCamera_RB_Object_AddForce();
    }
    void RFC_UI_Test()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);//定義由攝影機發出到滑鼠位置的射線
        if (Physics.Raycast(ray, out raycastHit)) //定義射線打中物件之代理變數raycastHit
        {
            //顯示射線
            //Debug.DrawLine(Camera.main.transform.position, raycastHit.transform.position, Color.red, 0.5f, true);//只能顯示射線為擊中物件中心
            Debug.DrawLine(Camera.main.transform.position, raycastHit.point, Color.red, 0.5f, true);//任意顯示擊中點
            //起點, 擊中點位置, 顯示顏色, 持續時間, 深度測試

            if (raycastHit.transform.gameObject.name == gameObject.name)//如果接受射線者名稱就是本體物件名稱時
            {
                UI_Canvas.SetActive(true);
                //UI.text
                Text_RayHitObject.text = $"<color=green>The name of the object hit by Ray: </color> {raycastHit.transform.gameObject.name}";

            }
            else
            {
                UI_Canvas.SetActive(false);
            }
        }
    }
    void RFCamera_RB_Object_AddForce()//按下滑鼠左鍵連續發出Ray打中目標Object即旋轉
    {
        //定義射線如何生成
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);//定義由攝影機發出到滑鼠位置的射線
        if (Physics.Raycast(ray, out raycastHit))//Physics.Raycast()方法檢測射線碰撞資訊(要碰撞客體物件該物件必須有(Collider))
        {
            if (Input.GetMouseButton(0) && raycastHit.transform.gameObject.name == gameObject.name)//滑鼠左鍵按下且未鬆開時回傳 True否則為 False
            {
                Vector3 AddForceVector = new Vector3(0, 50, 0);//AddForce向量要設定大一點(跟RB物件質量有關)
                W_Rigidbody.AddForce(AddForceVector, ForceMode.Force);
                //底下是另一種RB.velocity= 方法函示
                //Vector3 VelocityVector = new Vector3(0, 5, 0);
                //W_Rigidbody.velocity = VelocityVector;
            }
        }
    }


}
