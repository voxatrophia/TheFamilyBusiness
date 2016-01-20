using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : Singleton<GameManager> {
    int level;
    public GameObject results;
    public GameObject[] levels;

    void OnEnable() {
 //       Messenger.AddListener(k_Messages.LeaveHouse, ChangeScene);
        //EventManager.StartListening(k_Messages.LeaveHouse, ChangeScene);
    }

    void Start() {
        //SceneManager.LoadScene("HouseTest");
    }

    public void GameOver() {
        SceneManager.LoadScene("GameOver");
    }

    void ChangeScene() {
        //        SceneManager.UnloadScene("HouseTest");
        //      SceneManager.LoadScene("House2", LoadSceneMode.Additive);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//        SceneManager.LoadScene("Results");

    }

    public void Results() {

    }

    public void NextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
