using System;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public delegate void LevelUpEventHandler(object sender, EventArgs e);

public class ManagerLevelUp : MonoBehaviour {

    [SerializeField]
    private GameObject buttonLevelUp;
    [SerializeField]
    private StatusLevel statusLevel;
    [SerializeField]
    private ManagerStatusPower managerStatusPower;
    [SerializeField]
    private ManagerStatusDefence managerStatusDefence;
    [SerializeField]
    private ManagerStatusSpeed managerStatusSpeed;
    [SerializeField]
    private ManagerStatusMaxHP managerStatusMaxHP;
    [SerializeField]
    private ManagerStatusMaxMP managerStatusMaxMP;

    public event LevelUpEventHandler p1LevelUpEvent;

    public event LevelUpEventHandler p2LevelUpEvent;

    public event LevelUpEventHandler p3LevelUpEvent;

    void Start() {
        p1LevelUpEvent += new LevelUpEventHandler(statusLevel.P1LevelUp);
        p1LevelUpEvent += new LevelUpEventHandler(managerStatusPower.P1StatusPowerChange);
        p1LevelUpEvent += new LevelUpEventHandler(managerStatusDefence.P1StatusDefenceChange);
        p1LevelUpEvent += new LevelUpEventHandler(managerStatusSpeed.P1StatusSpeedChange);
        p1LevelUpEvent += new LevelUpEventHandler(managerStatusMaxHP.P1StatusMaxHPChange);
        p1LevelUpEvent += new LevelUpEventHandler(managerStatusMaxMP.P1StatusMaxMPChange);

        p2LevelUpEvent += new LevelUpEventHandler(statusLevel.P2LevelUp);
        p2LevelUpEvent += new LevelUpEventHandler(managerStatusPower.P2StatusPowerChange);
        p2LevelUpEvent += new LevelUpEventHandler(managerStatusDefence.P2StatusDefenceChange);
        p2LevelUpEvent += new LevelUpEventHandler(managerStatusSpeed.P2StatusSpeedChange);
        p2LevelUpEvent += new LevelUpEventHandler(managerStatusMaxHP.P2StatusMaxHPChange);
        p2LevelUpEvent += new LevelUpEventHandler(managerStatusMaxMP.P2StatusMaxMPChange);

        p3LevelUpEvent += new LevelUpEventHandler(statusLevel.P3LevelUp);
        p3LevelUpEvent += new LevelUpEventHandler(managerStatusPower.P3StatusPowerChange);
        p3LevelUpEvent += new LevelUpEventHandler(managerStatusDefence.P3StatusDefenceChange);
        p3LevelUpEvent += new LevelUpEventHandler(managerStatusSpeed.P3StatusSpeedChange);
        p3LevelUpEvent += new LevelUpEventHandler(managerStatusMaxHP.P3StatusMaxHPChange);
        p3LevelUpEvent += new LevelUpEventHandler(managerStatusMaxMP.P3StatusMaxMPChange);
    }

    public void OnButtonLevelUpClicked() {
        if (ManagerPlayerSelect.p1Select == true)
        {
            this.p1LevelUpEvent(this, EventArgs.Empty);
        }
        else if (ManagerPlayerSelect.p2Select == true)
        {
            this.p2LevelUpEvent(this, EventArgs.Empty);
        }
        else if (ManagerPlayerSelect.p3Select == true)
        {
            this.p3LevelUpEvent(this, EventArgs.Empty);
        }
    }
}