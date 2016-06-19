using System;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public delegate void EventHandler(object sender, EventArgs e);

public class EventManager : MonoBehaviour {

    private Cube01Controller cube01Controller;
    private Cube02Controller cube02Controller;

    public event EventHandler changeSpeed;

    public event EventHandler resetSpeed;

    public event EventHandler changeColor;

    public event EventHandler resetColor;

    private const string TagScaleChange = "ScaleChange";
    private const string TagColorChange = "ColorChange";

    void Awake() {
        cube01Controller = GameObject.Find("Cube01").GetComponent<Cube01Controller>();
        cube02Controller = GameObject.Find("Cube02").GetComponent<Cube02Controller>();

        changeSpeed += new EventHandler(cube01Controller.ChangeScaleHandler);
        changeSpeed += new EventHandler(cube02Controller.ChangeScaleHandler);
        resetSpeed += new EventHandler(cube01Controller.ResetScaleHandler);
        resetSpeed += new EventHandler(cube02Controller.ResetScaleHandler);
        changeColor += new EventHandler(cube01Controller.ChangeColorHandler);
        changeColor += new EventHandler(cube02Controller.ChangeColorHandler);
        resetColor += new EventHandler(cube01Controller.ResetColorHandler);
        resetColor += new EventHandler(cube02Controller.ResetColorHandler);
    }


    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == TagScaleChange)
        {
            this.changeSpeed(this, EventArgs.Empty);
        }
        else if (col.gameObject.tag == TagColorChange)
        {
            this.changeColor(this, EventArgs.Empty);
        }
    }

    void OnTriggerExit(Collider col) {
        if (col.gameObject.tag == TagScaleChange)
        {
            this.resetSpeed(this, EventArgs.Empty);
        }
        else if (col.gameObject.tag == TagColorChange)
        {
            this.resetColor(this, EventArgs.Empty);
        }
    }
}