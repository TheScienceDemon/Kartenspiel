using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int health;
    public Boolean death;

    void Start () {
       health = CurrentSettings.MAX_HEALTH_RULE;
    }

    void Update() {
        if (health < 0) {
            health = 0;
            death = true;
        }
    }

    public void ReduceHealth(int damage) {
        health -= damage;
    }

    public void ÍncreaseHealth(int heal) {
        health += heal;
    }
}
