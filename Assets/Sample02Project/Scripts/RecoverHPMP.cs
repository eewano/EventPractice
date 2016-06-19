using System;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public delegate void RecoveryEventHandler(object sender, EventArgs e);

public class RecoverHPMP : MonoBehaviour {

    [SerializeField]
    private GameObject buttonHPMPRecover;
    [SerializeField]
    private StatusHP statusHP;
    [SerializeField]
    private StatusMP statusMP;

    private event RecoveryEventHandler p1Recovery;

    private event RecoveryEventHandler p2Recovery;

    private event RecoveryEventHandler p3Recovery;

    void Start() {
        p1Recovery += new RecoveryEventHandler(statusHP.P1HPMPRecover);
        p1Recovery += new RecoveryEventHandler(statusMP.P1HPMPRecover);

        p2Recovery += new RecoveryEventHandler(statusHP.P2HPMPRecover);
        p2Recovery += new RecoveryEventHandler(statusMP.P2HPMPRecover);

        p3Recovery += new RecoveryEventHandler(statusHP.P3HPMPRecover);
        p3Recovery += new RecoveryEventHandler(statusMP.P3HPMPRecover);
    }

    public void OnButtonHPMPRecoverClicked() {
        if (ManagerPlayerSelect.p1Select == true)
        {
            this.p1Recovery(this, EventArgs.Empty);
        }
        else if (ManagerPlayerSelect.p2Select == true)
        {
            this.p2Recovery(this, EventArgs.Empty);
        }
        else if (ManagerPlayerSelect.p3Select == true)
        {
            this.p3Recovery(this, EventArgs.Empty);
        }
    }
}