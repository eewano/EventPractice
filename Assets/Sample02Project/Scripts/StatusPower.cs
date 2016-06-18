using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class StatusPower : MonoBehaviour {

    private Text powerText;
    [SerializeField]
    private int p1Power;
    [SerializeField]
    private int p2Power;
    [SerializeField]
    private int p3Power;

    private bool p1PowerDisplay = false;
    private bool p2PowerDisplay = false;
    private bool p3PowerDisplay = false;

    void Start() {
        powerText = GetComponent<Text>();
        powerText.text = "";
    }

    void Update() {
        if (p1PowerDisplay == true)
        {
            powerText.text = "" + p1Power;
        }
        else if (p2PowerDisplay == true)
        {
            powerText.text = "" + p2Power;
        }
        else if (p3PowerDisplay == true)
        {
            powerText.text = "" + p3Power;
        }
    }

    public void P1StatusPower(object o, EventArgs e) {
        p1PowerDisplay = true;
        p2PowerDisplay = false;
        p3PowerDisplay = false;
    }

    public void P2StatusPower(object o, EventArgs e) {
        p1PowerDisplay = false;
        p2PowerDisplay = true;
        p3PowerDisplay = false;
    }

    public void P3StatusPower(object o, EventArgs e) {
        p1PowerDisplay = false;
        p2PowerDisplay = false;
        p3PowerDisplay = true;
    }

    public void P1StatusPowerChange(object o, int i) {
        p1Power = p1Power + i;
    }

    public void P2StatusPowerChange(object o, int i) {
        p2Power = p2Power + i;
    }

    public void P3StatusPowerChange(object o, int i) {
        p3Power = p3Power + i;
    }
}