using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public delegate void ChangeMaxHPEventHandler(object sender, int i);

public class ManagerStatusMaxHP : MonoBehaviour {

    private StatusHP statusHP;
    [SerializeField]
    private int p1MaxHPChangeValue;
    [SerializeField]
    private int p2MaxHPChangeValue;
    [SerializeField]
    private int p3MaxHPChangeValue;

    private event ChangeMaxHPEventHandler p1ChangeMaxHPEvent;

    private event ChangeMaxHPEventHandler p2ChangeMaxHPEvent;

    private event ChangeMaxHPEventHandler p3ChangeMaxHPEvent;

    void Awake() {
        statusHP = GameObject.Find("HPValueText").GetComponent<StatusHP>();
    }

    void Start() {
        p1ChangeMaxHPEvent += new ChangeMaxHPEventHandler(statusHP.P1StatusMaxHPChange);
        p2ChangeMaxHPEvent += new ChangeMaxHPEventHandler(statusHP.P2StatusMaxHPChange);
        p3ChangeMaxHPEvent += new ChangeMaxHPEventHandler(statusHP.P3StatusMaxHPChange);
    }

    public void P1StatusMaxHPChange(object o, EventArgs e) {
        this.p1ChangeMaxHPEvent(this, p1MaxHPChangeValue);
    }

    public void P2StatusMaxHPChange(object o, EventArgs e) {
        this.p2ChangeMaxHPEvent(this, p2MaxHPChangeValue);
    }

    public void P3StatusMaxHPChange(object o, EventArgs e) {
        this.p3ChangeMaxHPEvent(this, p3MaxHPChangeValue);
    }
}