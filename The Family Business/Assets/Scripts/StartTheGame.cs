using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartTheGame : MonoBehaviour {

    public GameObject startPanel;

    void Start() {
        startPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void StartGame() {
        Time.timeScale = 1;
        startPanel.SetActive(false);
    }

}
