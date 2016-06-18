using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Command04Display : MonoBehaviour {

    private GameObject command04Display;

    void Start() {
        command04Display = GameObject.Find("BackGround04");
        command04Display.gameObject.SetActive(false);
    }

    public void Command04Enabled(object o, EventArgs e) {
        command04Display.gameObject.SetActive(true);
        enabled = false;
    }
}