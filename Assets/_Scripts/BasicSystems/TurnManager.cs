using UnityEngine;

public class TurnManager : MonoBehaviour {
    [SerializeField] int turn = 0;
    
    private float timer = 0;

    public void NextTurn() => turn += 1;

    public void StartTimer(float time) {
        timer = time;
    }

    private void Update() {
        if (timer > 0) {
            timer -= Time.deltaTime;
            if (timer <= 0) {
                timer = 0;
            }
        }
    }
}


