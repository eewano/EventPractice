using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Command04Display : MonoBehaviour {

    [SerializeField]
    private GameObject command04Display;

    void Start() {
        command04Display.gameObject.SetActive(false);
    }

    public void Command04Enabled(object o, EventArgs e) {
        command04Display.gameObject.SetActive(true);
        enabled = false;
    }
}