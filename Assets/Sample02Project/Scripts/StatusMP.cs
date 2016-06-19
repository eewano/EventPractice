using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class StatusMP : MonoBehaviour {

    [SerializeField]
    private Text mPText;
    [SerializeField]
    private int p1MaxMP;
    [SerializeField]
    private int p1NowMP;
    [SerializeField]
    private int p2MaxMP;
    [SerializeField]
    private int p2NowMP;
    [SerializeField]
    private int p3MaxMP;
    [SerializeField]
    private int p3NowMP;

    [SerializeField]
    private Slider p1MPSlider;
    [SerializeField]
    private Slider p2MPSlider;
    [SerializeField]
    private Slider p3MPSlider;

    private bool p1NowMPDisplay = false;
    private bool p2NowMPDisplay = false;
    private bool p3NowMPDisplay = false;

    void Start() {
        p1NowMP = p1MaxMP;
        p2NowMP = p2MaxMP;
        p3NowMP = p3MaxMP;
        mPText.text = "";
    }

    void Update() {
        if (p1NowMPDisplay == true)
        {
            mPText.text = p1NowMP + " / " + p1MaxMP;
            p1MPSlider.value = p1NowMP / (float)p1MaxMP;
        }
        else if (p2NowMPDisplay == true)
        {
            mPText.text = p2NowMP + " / " + p2MaxMP;
            p2MPSlider.value = p2NowMP / (float)p2MaxMP;
        }
        else if (p3NowMPDisplay == true)
        {
            mPText.text = p3NowMP + " / " + p3MaxMP;
            p3MPSlider.value = p3NowMP / (float)p3MaxMP;
        }
    }

    public void P1StatusMP(object o, EventArgs e) {
        p1NowMPDisplay = true;
        p2NowMPDisplay = false;
        p3NowMPDisplay = false;
    }

    public void P2StatusMP(object o, EventArgs e) {
        p1NowMPDisplay = false;
        p2NowMPDisplay = true;
        p3NowMPDisplay = false;
    }

    public void P3StatusMP(object o, EventArgs e) {
        p1NowMPDisplay = false;
        p2NowMPDisplay = false;
        p3NowMPDisplay = true;
    }

    public void P1StatusMPChange(object o, int i) {
        p1NowMP = Mathf.Clamp(p1NowMP + i, 0, 999);
    }

    public void P2StatusMPChange(object o, int i) {
        p2NowMP = Mathf.Clamp(p2NowMP + i, 0, 999);
    }

    public void P3StatusMPChange(object o, int i) {
        p3NowMP = Mathf.Clamp(p3NowMP + i, 0, 999);
    }

    public void P1StatusMaxMPChange(object o, int i) {
        p1MaxMP += i;
    }

    public void P2StatusMaxMPChange(object o, int i) {
        p2MaxMP += i;
    }

    public void P3StatusMaxMPChange(object o, int i) {
        p3MaxMP += i;
    }

    public void P1HPMPRecover(object o, EventArgs e) {
        p1NowMP = p1MaxMP;
    }

    public void P2HPMPRecover(object o, EventArgs e) {
        p2NowMP = p2MaxMP;
    }

    public void P3HPMPRecover(object o, EventArgs e) {
        p3NowMP = p3MaxMP;
    }
}