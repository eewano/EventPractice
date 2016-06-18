using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class StatusLevel : MonoBehaviour {

    private Text levelText;
    [SerializeField]
    private int p1Level;
    [SerializeField]
    private int p2Level;
    [SerializeField]
    private int p3Level;

    private bool p1LevelDisplay = false;
    private bool p2LevelDisplay = false;
    private bool p3LevelDisplay = false;

    void Start() {
        levelText = GetComponent<Text>();
        levelText.text = "";
    }

    void Update() {
        if (p1LevelDisplay == true)
        {
            levelText.text = "Level : " + p1Level;
        }
        else if (p2LevelDisplay == true)
        {
            levelText.text = "Level : " + p2Level;
        }
        else if (p3LevelDisplay == true)
        {
            levelText.text = "Level : " + p3Level;
        }
    }

    public void P1StatusLevel(object o, EventArgs e) {
        p1LevelDisplay = true;
        p2LevelDisplay = false;
        p3LevelDisplay = false;
    }

    public void P2StatusLevel(object o, EventArgs e) {
        p1LevelDisplay = false;
        p2LevelDisplay = true;
        p3LevelDisplay = false;
    }

    public void P3StatusLevel(object o, EventArgs e) {
        p1LevelDisplay = false;
        p2LevelDisplay = false;
        p3LevelDisplay = true;
    }

    public void P1LevelUp(object o, EventArgs e) {
        p1Level++;
    }

    public void P2LevelUp(object o, EventArgs e) {
        p2Level++;
    }

    public void P3LevelUp(object o, EventArgs e) {
        p3Level++;
    }
}