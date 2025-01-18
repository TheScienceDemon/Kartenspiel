using UnityEngine;

public class GameManager : MonoBehaviour {
    public CardHand cardHand; // Referenz zum CardHand-Skript
    public GameObject cardPrefab; // Kartenvorlage für neue Karten

    void Update() {
        // Prüfe, ob die "+" Taste gedrückt wird
        if (Input.GetKeyDown(KeyCode.Plus) || Input.GetKeyDown(KeyCode.KeypadPlus)) {
            DrawCard();
        }

        // Prüfe, ob die "-" Taste gedrückt wird
        if (Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.KeypadMinus)) {
            DiscardCard();
        }
    }

    // Neue Karte ziehen und zur Hand hinzufügen
    private void DrawCard() {
        GameObject newCard = Instantiate(cardPrefab); // Erstelle eine neue Karte
        cardHand.AddCard(newCard); // Füge die Karte zur Hand hinzu
    }

    // Letzte Karte aus der Hand entfernen
    private void DiscardCard() {
        if (cardHand != null && cardHand.CardsCount > 0) {
            GameObject lastCard = cardHand.GetLastCard(); // Hole die letzte Karte
            cardHand.RemoveCard(lastCard); // Entferne sie aus der Hand
            Destroy(lastCard); // Lösche das Karten-GameObject
        }
    }
}
