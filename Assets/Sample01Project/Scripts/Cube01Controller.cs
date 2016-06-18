using System;
using UnityEngine;

public class Cube01Controller : MonoBehaviour {

    Vector3 startPosition;

    [SerializeField]
    private float amplitude;    //ボールのX軸の振れ幅
    [SerializeField]
    private float speed;
    private Renderer rend;

    void Awake() {
        startPosition = transform.localPosition;
        rend = GetComponent<Renderer>();
    }

    void Update() {
        //変位を計算する
        float z = amplitude * Mathf.Cos(Time.time * speed);

        //xを変位させたポジションに再設定する
        transform.localPosition = startPosition + new Vector3(0, 0, z);
    }

    public void ChangeScaleHandler(object o, EventArgs e) {
        this.transform.localScale = new Vector3(0.8f, 1.0f, 0.8f);
    }

    public void ResetScaleHandler(object o, EventArgs e) {
        this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    public void ChangeColorHandler(object o, EventArgs e) {
        rend.material.color = new Color(255.0f / 255.0f, 0f / 255.0f, 0f / 255.0f);
        amplitude = 3.0f;
    }

    public void ResetColorHandler(object o, EventArgs e) {
        rend.material.color = new Color(255.0f / 255.0f, 128.0f / 255.0f, 255.0f / 255.0f);
        amplitude = 2.0f;
    }
}