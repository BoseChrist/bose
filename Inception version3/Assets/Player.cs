﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class Player : NetworkBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
            return;

        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        transform.Rotate(x, 0, 0);
        // Right Stick is mapped to HorizontalR and VerticalR
    }
}