using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializedField] float rotationSpeed = 100f;
    bool dragging = false;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
            float x = Input.GetAxis ("Mouse X") * rotationSpeed * Time.fixedDeltaTime;
            float y = Input.GetAxis ("Mouse Y") * rotationspeed * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down * x);
            rb.AddTorque(Vector3.right * x);
        }
    }
}
