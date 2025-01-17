using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour {
    
    [SerializeField] GameObject mainMenuObj;
        [SerializeField] GameObject singlePlayerObj;
        [SerializeField] GameObject multiPlayerObj;
        [SerializeField] GameObject endGameObj;
        [SerializeField] Button buttonObj;
        [SerializeField] GameObject settingsMenuObj;
            [SerializeField] GameObject audioSettingsObj;
            [SerializeField] GameObject overallSettingsObj;
            [SerializeField] GameObject videoSettingsObj;
            [SerializeField] GameObject keybindsSettingsObj;


    private Outline focusOutline;
    private Color focusOutlineColor = Color.white;
    private Color noFocusColor = Color.clear;

    void Start() {
        mainMenuObj.SetActive(true);

        focusOutline = buttonObj.GetComponent<Outline>();
        if (focusOutline == null) {
            focusOutline = buttonObj.gameObject.AddComponent<Outline>();
        }

        focusOutline.effectColor = noFocusColor;
        focusOutline.effectDistance = new Vector2(2, 2);
    }

    private void Update() {
        if (EventSystem.current.currentSelectedGameObject == buttonObj) {
            focusOutline.effectColor = focusOutlineColor;
        } else {
            focusOutline.effectColor = noFocusColor;
        }
    }

    public void OpenSettingsMenu() {
        if (settingsMenuObj.activeSelf) {
            settingsMenuObj.SetActive(false);
            mainMenuObj.SetActive(true);
        } else {
            mainMenuObj.SetActive(false);
            settingsMenuObj.SetActive(true);
        }
    }
    
    public void OpenOverallSettings() {
        if (overallSettingsObj.activeSelf) {
            overallSettingsObj.SetActive(false);
        } else {
            overallSettingsObj.SetActive(true);
        }
    }
    public void LoadScene() {
        SceneManager.LoadScene(2);
    }
}
