using System;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public delegate void PSelectEventHandler(object sender, EventArgs e);

public class ManagerPlayerSelect : MonoBehaviour {

    [SerializeField]
    private GameObject buttonP1;
    [SerializeField]
    private GameObject buttonP2;
    [SerializeField]
    private GameObject buttonP3;

    [SerializeField]
    private StatusPower statusPower;
    [SerializeField]
    private StatusDefence statusDefence;
    [SerializeField]
    private StatusSpeed statusSpeed;
    [SerializeField]
    private StatusHP statusHP;
    [SerializeField]
    private StatusMP statusMP;
    [SerializeField]
    private StatusLevel statusLevel;
    [SerializeField]
    private StatusPlayerName statusPlayerName;
    [SerializeField]
    private StatusPlayerImage statusPlayerImage;
    [SerializeField]
    private Command04Display command04Display;

    public static bool p1Select = false;
    public static bool p2Select = false;
    public static bool p3Select = false;

    public event PSelectEventHandler p1SelectEvent;

    public event PSelectEventHandler p2SelectEvent;

    public event PSelectEventHandler p3SelectEvent;

    void Start() {
        p1SelectEvent += new PSelectEventHandler(statusPower.P1StatusPower);
        p1SelectEvent += new PSelectEventHandler(statusSpeed.P1StatusSpeed);
        p1SelectEvent += new PSelectEventHandler(statusDefence.P1StatusDefence);
        p1SelectEvent += new PSelectEventHandler(statusHP.P1StatusHP);
        p1SelectEvent += new PSelectEventHandler(statusMP.P1StatusMP);
        p1SelectEvent += new PSelectEventHandler(statusLevel.P1StatusLevel);
        p1SelectEvent += new PSelectEventHandler(statusPlayerName.P1StatusPlayerName);
        p1SelectEvent += new PSelectEventHandler(statusPlayerImage.P1StatusPlayerImage);
        p1SelectEvent += new PSelectEventHandler(command04Display.Command04Enabled);

        p2SelectEvent += new PSelectEventHandler(statusPower.P2StatusPower);
        p2SelectEvent += new PSelectEventHandler(statusSpeed.P2StatusSpeed);
        p2SelectEvent += new PSelectEventHandler(statusDefence.P2StatusDefence);
        p2SelectEvent += new PSelectEventHandler(statusHP.P2StatusHP);
        p2SelectEvent += new PSelectEventHandler(statusMP.P2StatusMP);
        p2SelectEvent += new PSelectEventHandler(statusLevel.P2StatusLevel);
        p2SelectEvent += new PSelectEventHandler(statusPlayerName.P2StatusPlayerName);
        p2SelectEvent += new PSelectEventHandler(statusPlayerImage.P2StatusPlayerImage);
        p2SelectEvent += new PSelectEventHandler(command04Display.Command04Enabled);

        p3SelectEvent += new PSelectEventHandler(statusPower.P3StatusPower);
        p3SelectEvent += new PSelectEventHandler(statusSpeed.P3StatusSpeed);
        p3SelectEvent += new PSelectEventHandler(statusDefence.P3StatusDefence);
        p3SelectEvent += new PSelectEventHandler(statusHP.P3StatusHP);
        p3SelectEvent += new PSelectEventHandler(statusMP.P3StatusMP);
        p3SelectEvent += new PSelectEventHandler(statusLevel.P3StatusLevel);
        p3SelectEvent += new PSelectEventHandler(statusPlayerName.P3StatusPlayerName);
        p3SelectEvent += new PSelectEventHandler(statusPlayerImage.P3StatusPlayerImage);
        p3SelectEvent += new PSelectEventHandler(command04Display.Command04Enabled);
    }

    public void OnButtonPlayer01Clicked() {
        p1Select = true;
        p2Select = false;
        p3Select = false;
        this.p1SelectEvent(this, EventArgs.Empty);
    }

    public void OnButtonPlayer02Clicked() {
        p1Select = false;
        p2Select = true;
        p3Select = false;
        this.p2SelectEvent(this, EventArgs.Empty);
    }

    public void OnButtonPlayer03Clicked() {
        p1Select = false;
        p2Select = false;
        p3Select = true;
        this.p3SelectEvent(this, EventArgs.Empty);
    }
}