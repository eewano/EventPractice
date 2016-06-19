using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class StatusPlayerName : MonoBehaviour {

    [SerializeField]
    private Text pNameText;

    void Start() {
        pNameText.text = "";
    }

    public void P1StatusPlayerName(object o, EventArgs e) {
        pNameText.text = "勇者";
    }

    public void P2StatusPlayerName(object o, EventArgs e) {
        pNameText.text = "戦士";
    }

    public void P3StatusPlayerName(object o, EventArgs e) {
        pNameText.text = "魔法使い";
    }
}
