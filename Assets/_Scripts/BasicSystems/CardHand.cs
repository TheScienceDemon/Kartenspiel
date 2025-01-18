using System.Collections.Generic;
using UnityEngine;

public class CardHand : MonoBehaviour {
    
    private List<GameObject> cardsInHand = new List<GameObject>();

    public int maxCardsPerRow = 7;
    public float cardSpacing = 1.5f;
    public float rowSpacing = 2.0f; 
    public Vector3 startPosition = new Vector3(0, 0, 0);


    
    public void AddCard(GameObject card) {
        cardsInHand.Add(card);
        card.transform.SetParent(transform);
        UpdateCardPositions();
    }

    public int CardsCount => cardsInHand.Count;
    public GameObject GetLastCard() {
        if (cardsInHand.Count > 0) {
            return cardsInHand[cardsInHand.Count - 1];
        }
        return null;
    }


    
    public void RemoveCard(GameObject card) {
        if (cardsInHand.Contains(card)) {
            cardsInHand.Remove(card);
            card.transform.SetParent(null);
            UpdateCardPositions();
        }
    }

    
    private void UpdateCardPositions() {
        for (int i = 0; i < cardsInHand.Count; i++) {
            int row = i / maxCardsPerRow;
            int column = i % maxCardsPerRow;

            Vector3 newPosition = startPosition
                                  + new Vector3(column * cardSpacing, -row * rowSpacing, 0);
            cardsInHand[i].transform.localPosition = newPosition;
        }
    }

    
    public void ClearHand() {
        foreach (GameObject card in cardsInHand) {
            card.transform.SetParent(null);
        }
        cardsInHand.Clear();
    }
}
