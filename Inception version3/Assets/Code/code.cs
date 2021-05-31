using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code : MonoBehaviour
{
    float rotationSpeed = 100f;
    bool dragging = false;
    float x;
    // Update is called once per frame
    void Update()
    {
        x += Time.deltaTime * 10;
        transform.rotation = Quaternion.Euler(x, 0, 0);
    }
}
