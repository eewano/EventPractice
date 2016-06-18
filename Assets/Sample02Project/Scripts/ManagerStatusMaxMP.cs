using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public delegate void ChangeMaxMPEventHandler(object sender, int i);

public class ManagerStatusMaxMP : MonoBehaviour {

    private StatusMP statusMP;
    [SerializeField]
    private int p1MaxMPChangeValue;
    [SerializeField]
    private int p2MaxMPChangeValue;
    [SerializeField]
    private int p3MaxMPChangeValue;

    private event ChangeMaxMPEventHandler p1ChangeMaxMPEvent;

    private event ChangeMaxMPEventHandler p2ChangeMaxMPEvent;

    private event ChangeMaxMPEventHandler p3ChangeMaxMPEvent;

    void Awake() {
        statusMP = GameObject.Find("MPValueText").GetComponent<StatusMP>();
    }

    void Start() {
        p1ChangeMaxMPEvent += new ChangeMaxMPEventHandler(statusMP.P1StatusMaxMPChange);
        p2ChangeMaxMPEvent += new ChangeMaxMPEventHandler(statusMP.P2StatusMaxMPChange);
        p3ChangeMaxMPEvent += new ChangeMaxMPEventHandler(statusMP.P3StatusMaxMPChange);
    }

    public void P1StatusMaxMPChange(object o, EventArgs e) {
        this.p1ChangeMaxMPEvent(this, p1MaxMPChangeValue);
    }

    public void P2StatusMaxMPChange(object o, EventArgs e) {
        this.p2ChangeMaxMPEvent(this, p2MaxMPChangeValue);
    }

    public void P3StatusMaxMPChange(object o, EventArgs e) {
        this.p3ChangeMaxMPEvent(this, p3MaxMPChangeValue);
    }
}