using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class StatusHP : MonoBehaviour {

    private Text hPText;
    [SerializeField]
    private int p1MaxHP;
    [SerializeField]
    private int p1NowHP;
    [SerializeField]
    private int p2MaxHP;
    [SerializeField]
    private int p2NowHP;
    [SerializeField]
    private int p3MaxHP;
    [SerializeField]
    private int p3NowHP;

    [SerializeField]
    private Slider p1HPSlider;
    [SerializeField]
    private Slider p2HPSlider;
    [SerializeField]
    private Slider p3HPSlider;

    private bool p1NowHPDisplay = false;
    private bool p2NowHPDisplay = false;
    private bool p3NowHPDisplay = false;

    void Start() {
        hPText = GetComponent<Text>();
        p1NowHP = p1MaxHP;
        p2NowHP = p2MaxHP;
        p3NowHP = p3MaxHP;
        hPText.text = "";
    }

    void Update() {
        if (p1NowHPDisplay == true)
        {
            hPText.text = p1NowHP + " / " + p1MaxHP;
            p1HPSlider.value = p1NowHP / (float)p1MaxHP;
        }
        else if (p2NowHPDisplay == true)
        {
            hPText.text = p2NowHP + " / " + p2MaxHP;
            p2HPSlider.value = p2NowHP / (float)p2MaxHP;
        }
        else if (p3NowHPDisplay == true)
        {
            hPText.text = p3NowHP + " / " + p3MaxHP;
            p3HPSlider.value = p3NowHP / (float)p3MaxHP;
        }
    }

    public void P1StatusHP(object o, EventArgs e) {
        p1NowHPDisplay = true;
        p2NowHPDisplay = false;
        p3NowHPDisplay = false;
    }

    public void P2StatusHP(object o, EventArgs e) {
        p1NowHPDisplay = false;
        p2NowHPDisplay = true;
        p3NowHPDisplay = false;
    }

    public void P3StatusHP(object o, EventArgs e) {
        p1NowHPDisplay = false;
        p2NowHPDisplay = false;
        p3NowHPDisplay = true;
    }

    public void P1StatusHPChange(object o, int i) {
        p1NowHP = Mathf.Clamp(p1NowHP + i, 0, 999);
    }

    public void P2StatusHPChange(object o, int i) {
        p2NowHP = Mathf.Clamp(p2NowHP + i, 0, 999);
    }

    public void P3StatusHPChange(object o, int i) {
        p3NowHP = Mathf.Clamp(p3NowHP + i, 0, 999);
    }

    public void P1StatusMaxHPChange(object o, int i) {
        p1MaxHP += i;
    }

    public void P2StatusMaxHPChange(object o, int i) {
        p2MaxHP += i;
    }

    public void P3StatusMaxHPChange(object o, int i) {
        p3MaxHP += i;
    }

    public void P1HPMPRecover(object o, EventArgs e) {
        p1NowHP = p1MaxHP;
    }

    public void P2HPMPRecover(object o, EventArgs e) {
        p2NowHP = p2MaxHP;
    }

    public void P3HPMPRecover(object o, EventArgs e) {
        p3NowHP = p3MaxHP;
    }
}