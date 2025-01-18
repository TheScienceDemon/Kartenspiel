using UnityEngine;

public class GameManager : MonoBehaviour {
    public CardHand cardHand; // Referenz zum CardHand-Skript
    public GameObject cardPrefab; // Kartenvorlage f�r neue Karten

    void Update() {
        // Pr�fe, ob die "+" Taste gedr�ckt wird
        if (Input.GetKeyDown(KeyCode.Plus) || Input.GetKeyDown(KeyCode.KeypadPlus)) {
            DrawCard();
        }

        // Pr�fe, ob die "-" Taste gedr�ckt wird
        if (Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.KeypadMinus)) {
            DiscardCard();
        }
    }

    // Neue Karte ziehen und zur Hand hinzuf�gen
    private void DrawCard() {
        GameObject newCard = Instantiate(cardPrefab); // Erstelle eine neue Karte
        cardHand.AddCard(newCard); // F�ge die Karte zur Hand hinzu
    }

    // Letzte Karte aus der Hand entfernen
    private void DiscardCard() {
        if (cardHand != null && cardHand.CardsCount > 0) {
            GameObject lastCard = cardHand.GetLastCard(); // Hole die letzte Karte
            cardHand.RemoveCard(lastCard); // Entferne sie aus der Hand
            Destroy(lastCard); // L�sche das Karten-GameObject
        }
    }
}
