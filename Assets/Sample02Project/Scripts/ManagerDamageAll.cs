using System;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public delegate void DamageAllEventHandler(object sender, int i);

public class ManagerDamageAll : MonoBehaviour {

    [SerializeField]
    private GameObject buttonDamageAll;
    private StatusHP statusHP;

    public event DamageAllEventHandler damageAllEvent;

    void Awake() {
        statusHP = GameObject.Find("HPValueText").GetComponent<StatusHP>();
    }

    void Start() {
        damageAllEvent += new DamageAllEventHandler(statusHP.P1StatusHPChange);
        damageAllEvent += new DamageAllEventHandler(statusHP.P2StatusHPChange);
        damageAllEvent += new DamageAllEventHandler(statusHP.P3StatusHPChange);
    }

    public void OnButtonDamageAllClicked() {
        this.damageAllEvent(this, -3);
    }
}