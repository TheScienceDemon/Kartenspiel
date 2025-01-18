using UnityEngine;
using UnityEngine.UI;

public class CardInfo : MonoBehaviour {
    public Sprite GetSprite() {
        return transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetComponent<Image>().sprite;
    }
}
