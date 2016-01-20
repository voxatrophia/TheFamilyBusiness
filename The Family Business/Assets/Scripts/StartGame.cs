using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartGame : MonoBehaviour {

    public void StartTheGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
