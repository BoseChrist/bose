using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CC_MoveRotation_CameraRotate : MonoBehaviour
{
    public GameObject MainCamera;
    public float CameraUpDownSpeed = 3.5f;
    public float CC_MoveSpeed = 3.5f;
    public float CC_RotateSpeed = 3.5f;
    CharacterController W_characterController;
    // Start is called before the first frame update
    void Start()
    {
        W_characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        CC_SimpleMove();
        CC_RotationByMouseX();
        UpDownCameraByMouseY();
    }

    void CC_SimpleMove()
    {
        float X_Axis = Input.GetAxis("Horizontal") * CC_MoveSpeed;
        float Z_Axis = Input.GetAxis("Vertical") * CC_MoveSpeed;
        Vector3 Move_Vector = new Vector3(X_Axis, 0, Z_Axis);
        //W_characterController.SimpleMove(transform.right * Move_Vector.x + transform.up * Move_Vector.y + transform.forward * Move_Vector.z);

        Quaternion Current_Rotate = Quaternion.Euler(0, transform.eulerAngles.y, 0);
        Move_Vector = Current_Rotate * Move_Vector;//注意這邊寫法, 旋轉角Quaternion乘上位移向量, 變成自身坐標系狀態!!!
        W_characterController.SimpleMove(Move_Vector);
    }
    void CC_RotationByMouseX()
    {
        float Mouse_X = Input.GetAxis("Mouse X");//滑鼠水平左右移動
        if (Mouse_X != 0)
        {
            float Y_vector_Rotate = Input.GetAxis("Mouse X") * CC_RotateSpeed;
            transform.Rotate(0, Y_vector_Rotate, 0);
        }
    }
    void UpDownCameraByMouseY()
    {

        float Mouse_Y = Input.GetAxis("Mouse Y");//滑鼠水平左右移動
        if (Mouse_Y != 0)
        {
            float X_vector_Rotate = Input.GetAxis("Mouse Y") * CameraUpDownSpeed;
            MainCamera.transform.Rotate(X_vector_Rotate * -1, 0, 0);
        }
    }

}
