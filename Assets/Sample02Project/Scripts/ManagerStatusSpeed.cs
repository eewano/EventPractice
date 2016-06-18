using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public delegate void ChangeSpeedEventHandler(object sender, int i);

public class ManagerStatusSpeed : MonoBehaviour {

    private StatusSpeed statusSpeed;
    [SerializeField]
    private int p1SpeedChangeValue;
    [SerializeField]
    private int p2SpeedChangeValue;
    [SerializeField]
    private int p3SpeedChangeValue;

    private event ChangeSpeedEventHandler p1ChangeSpeedEvent;

    private event ChangeSpeedEventHandler p2ChangeSpeedEvent;

    private event ChangeSpeedEventHandler p3ChangeSpeedEvent;

    void Awake() {
        statusSpeed = GameObject.Find("SpeedValueText").GetComponent<StatusSpeed>();
    }

    void Start() {
        p1ChangeSpeedEvent += new ChangeSpeedEventHandler(statusSpeed.P1StatusSpeedChange);
        p2ChangeSpeedEvent += new ChangeSpeedEventHandler(statusSpeed.P2StatusSpeedChange);
        p3ChangeSpeedEvent += new ChangeSpeedEventHandler(statusSpeed.P3StatusSpeedChange);
    }

    public void P1StatusSpeedChange(object o, EventArgs e) {
        this.p1ChangeSpeedEvent(this, p1SpeedChangeValue);
    }

    public void P2StatusSpeedChange(object o, EventArgs e) {
        this.p2ChangeSpeedEvent(this, p2SpeedChangeValue);
    }

    public void P3StatusSpeedChange(object o, EventArgs e) {
        this.p3ChangeSpeedEvent(this, p3SpeedChangeValue);
    }
}
