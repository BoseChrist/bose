using UnityEngine;

public class Rotator : MonoBehaviour
{
    float rotationSpeed = 100f;
    bool dragging = false;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }


    void OnMouseDrag()
    {
        dragging = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }
    }
    void FixedUpdate()
    {
        if (dragging)
        {
            float z = Input.GetAxis ("Mouse Z") * rotationSpeed * Time.fixedDeltaTime;
            z += Time.deltaTime * 10;
            transform.rotation = Quaternion.Euler(0, 0, z);


        }
    }
}
