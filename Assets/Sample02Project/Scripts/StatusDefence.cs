using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class StatusDefence : MonoBehaviour {

    [SerializeField]
    private Text defenceText;
    [SerializeField]
    private int p1Defence;
    [SerializeField]
    private int p2Defence;
    [SerializeField]
    private int p3Defence;

    private bool p1DefenceDisplay = false;
    private bool p2DefenceDisplay = false;
    private bool p3DefenceDisplay = false;

    void Start() {
        defenceText.text = "";
    }

    void Update() {
        if (p1DefenceDisplay == true)
        {
            defenceText.text = "" + p1Defence;
        }
        else if (p2DefenceDisplay == true)
        {
            defenceText.text = "" + p2Defence;
        }
        else if (p3DefenceDisplay == true)
        {
            defenceText.text = "" + p3Defence;
        }
    }

    public void P1StatusDefence(object o, EventArgs e) {
        p1DefenceDisplay = true;
        p2DefenceDisplay = false;
        p3DefenceDisplay = false;
    }

    public void P2StatusDefence(object o, EventArgs e) {
        p1DefenceDisplay = false;
        p2DefenceDisplay = true;
        p3DefenceDisplay = false;
    }

    public void P3StatusDefence(object o, EventArgs e) {
        p1DefenceDisplay = false;
        p2DefenceDisplay = false;
        p3DefenceDisplay = true;
    }

    public void P1StatusDefenceChange(object o, int i) {
        p1Defence = p1Defence + i;
    }

    public void P2StatusDefenceChange(object o, int i) {
        p2Defence = p2Defence + i;
    }

    public void P3StatusDefenceChange(object o, int i) {
        p3Defence = p3Defence + i;
    }
}