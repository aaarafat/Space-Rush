﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Player : MonoBehaviour
{
    public float Speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = Speed * HThrow * Time.deltaTime ;
        print(xOffset);
        
    }
}