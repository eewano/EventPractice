using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class StatusSpeed : MonoBehaviour {

    [SerializeField]
    private Text speedText;
    [SerializeField]
    private int p1Speed;
    [SerializeField]
    private int p2Speed;
    [SerializeField]
    private int p3Speed;

    private bool p1SpeedDisplay = false;
    private bool p2SpeedDisplay = false;
    private bool p3SpeedDisplay = false;

    void Start() {
        speedText.text = "";
    }

    void Update() {
        if (p1SpeedDisplay == true)
        {
            speedText.text = "" + p1Speed;
        }
        else if (p2SpeedDisplay == true)
        {
            speedText.text = "" + p2Speed;
        }
        else if (p3SpeedDisplay == true)
        {
            speedText.text = "" + p3Speed;
        }
    }

    public void P1StatusSpeed(object o, EventArgs e) {
        p1SpeedDisplay = true;
        p2SpeedDisplay = false;
        p3SpeedDisplay = false;
    }

    public void P2StatusSpeed(object o, EventArgs e) {
        p1SpeedDisplay = false;
        p2SpeedDisplay = true;
        p3SpeedDisplay = false;
    }

    public void P3StatusSpeed(object o, EventArgs e) {
        p1SpeedDisplay = false;
        p2SpeedDisplay = false;
        p3SpeedDisplay = true;
    }

    public void P1StatusSpeedChange(object o, int i) {
        p1Speed = p1Speed + i;
    }

    public void P2StatusSpeedChange(object o, int i) {
        p2Speed = p2Speed + i;
    }

    public void P3StatusSpeedChange(object o, int i) {
        p3Speed = p3Speed + i;
    }
}