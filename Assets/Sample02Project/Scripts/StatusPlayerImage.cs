using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class StatusPlayerImage : MonoBehaviour {

    [SerializeField]
    private Image p1PlayerImage;
    [SerializeField]
    private Image p2PlayerImage;
    [SerializeField]
    private Image p3PlayerImage;

    void Start() {
        p1PlayerImage.enabled = false;
        p2PlayerImage.enabled = false;
        p3PlayerImage.enabled = false;
    }

    public void P1StatusPlayerImage(object o, EventArgs e) {
        p1PlayerImage.enabled = true;
        p2PlayerImage.enabled = false;
        p3PlayerImage.enabled = false;
    }

    public void P2StatusPlayerImage(object o, EventArgs e) {
        p1PlayerImage.enabled = false;
        p2PlayerImage.enabled = true;
        p3PlayerImage.enabled = false;
    }

    public void P3StatusPlayerImage(object o, EventArgs e) {
        p1PlayerImage.enabled = false;
        p2PlayerImage.enabled = false;
        p3PlayerImage.enabled = true;
    }
}