using UnityEngine;
using UnityEngine.Serialization;

public delegate void DamageEventHandler(object sender, int i);

public class ManagerDamage : MonoBehaviour {

    [SerializeField]
    private GameObject buttonDamage;
    [SerializeField]
    private StatusHP statusHP;

    public event DamageEventHandler p1DamageEvent;

    public event DamageEventHandler p2DamageEvent;

    public event DamageEventHandler p3DamageEvent;

    void Start() {
        p1DamageEvent += new DamageEventHandler(statusHP.P1StatusHPChange);

        p2DamageEvent += new DamageEventHandler(statusHP.P2StatusHPChange);

        p3DamageEvent += new DamageEventHandler(statusHP.P3StatusHPChange);
    }

    public void OnButtonDamageClicked() {
        if (ManagerPlayerSelect.p1Select == true)
        {
            this.p1DamageEvent(this, -7);
        }
        else if (ManagerPlayerSelect.p2Select == true)
        {
            this.p2DamageEvent(this, -6);
        }
        else if (ManagerPlayerSelect.p3Select == true)
        {
            this.p3DamageEvent(this, -10);
        }
    }
}