using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public delegate void ChangePowerEventHandler(object sender, int i);

public class ManagerStatusPower : MonoBehaviour {

    private StatusPower statusPower;
    [SerializeField]
    private int p1PowerChangeValue;
    [SerializeField]
    private int p2PowerChangeValue;
    [SerializeField]
    private int p3PowerChangeValue;

    private event ChangePowerEventHandler p1ChangePowerEvent;

    private event ChangePowerEventHandler p2ChangePowerEvent;

    private event ChangePowerEventHandler p3ChangePowerEvent;

    void Awake() {
        statusPower = GameObject.Find("PowerValueText").GetComponent<StatusPower>();
    }

    void Start() {
        p1ChangePowerEvent += new ChangePowerEventHandler(statusPower.P1StatusPowerChange);
        p2ChangePowerEvent += new ChangePowerEventHandler(statusPower.P2StatusPowerChange);
        p3ChangePowerEvent += new ChangePowerEventHandler(statusPower.P3StatusPowerChange);
    }

    public void P1StatusPowerChange(object o, EventArgs e) {
        this.p1ChangePowerEvent(this, p1PowerChangeValue);
    }

    public void P2StatusPowerChange(object o, EventArgs e) {
        this.p2ChangePowerEvent(this, p2PowerChangeValue);
    }

    public void P3StatusPowerChange(object o, EventArgs e) {
        this.p3ChangePowerEvent(this, p3PowerChangeValue);
    }
}