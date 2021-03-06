﻿using System;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float forwardSpeed;
    [SerializeField]
    private float rotateSpeed;

    void Update() {
        float translation = Input.GetAxis("Vertical") * forwardSpeed;
        if (translation < 0)
        {
            translation *= 0.6f;
        }
        float rotation = Input.GetAxis("Horizontal") * rotateSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
}