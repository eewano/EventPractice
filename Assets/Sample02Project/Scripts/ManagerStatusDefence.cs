using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public delegate void ChangeDefenceEventHandler(object sender, int i);

public class ManagerStatusDefence : MonoBehaviour {

    private StatusDefence statusDefence;
    [SerializeField]
    private int p1DefenceChangeValue;
    [SerializeField]
    private int p2DefenceChangeValue;
    [SerializeField]
    private int p3DefenceChangeValue;

    private event ChangeDefenceEventHandler p1ChangeDefenceEvent;

    private event ChangeDefenceEventHandler p2ChangeDefenceEvent;

    private event ChangeDefenceEventHandler p3ChangeDefenceEvent;

    void Awake() {
        statusDefence = GameObject.Find("DefenceValueText").GetComponent<StatusDefence>();
    }

    void Start() {
        p1ChangeDefenceEvent += new ChangeDefenceEventHandler(statusDefence.P1StatusDefenceChange);
        p2ChangeDefenceEvent += new ChangeDefenceEventHandler(statusDefence.P2StatusDefenceChange);
        p3ChangeDefenceEvent += new ChangeDefenceEventHandler(statusDefence.P3StatusDefenceChange);
    }

    public void P1StatusDefenceChange(object o, EventArgs e) {
        this.p1ChangeDefenceEvent(this, p1DefenceChangeValue);
    }

    public void P2StatusDefenceChange(object o, EventArgs e) {
        this.p2ChangeDefenceEvent(this, p2DefenceChangeValue);
    }

    public void P3StatusDefenceChange(object o, EventArgs e) {
        this.p3ChangeDefenceEvent(this, p3DefenceChangeValue);
    }
}