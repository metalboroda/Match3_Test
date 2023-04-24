using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneHandler : MonoBehaviour {

    [Header("Buttons")]
    [SerializeField] private Button startButton;
    [SerializeField] private Button dataButton;
    [SerializeField] private Button mainMenuButton;

    private void Start() {
        if (startButton != null)
            startButton.onClick.AddListener(GameScene);

        if (dataButton != null)
            dataButton.onClick.AddListener(DataScene);

        if (mainMenuButton != null)
            mainMenuButton.onClick.AddListener(MainMenuScene);
    }

    private void GameScene() {
        SceneManager.LoadScene("GameScene");
    }

    private void DataScene() {
        SceneManager.LoadScene("DataScene");
    }

    private void MainMenuScene() {
        SceneManager.LoadScene("MainMenuScene");
    }
}