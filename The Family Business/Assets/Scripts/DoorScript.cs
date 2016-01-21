using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class DoorScript : MonoBehaviour {

    public GameObject box;
    public Button startButton;

    void Start() {
        box.SetActive(false);
    }

    void OnEnable() {
        //Messenger.AddListener(k_Messages.DoorDialog, EnableDialog);
        EventManager.StartListening(k_Messages.DoorDialog, EnableDialog);
    }

    void OnDestroy() {
//        Messenger.RemoveListener(k_Messages.DoorDialog, EnableDialog);
        EventManager.StopListening(k_Messages.DoorDialog, EnableDialog);
    }

    void EnableDialog() {
        Time.timeScale = 0;

        box.SetActive(true);
        EventSystem.current.SetSelectedGameObject(startButton.gameObject);
    }

    public void DisableDialog(GameObject window) {
        Time.timeScale = 1;
        window.SetActive(false);
    }

    public void LeaveHouse(GameObject window) {
        //        DisableDialog(window);
        //EventManager.TriggerEvent(k_Messages.LeaveHouse);
        //        Messenger.Broadcast(k_Messages.LeaveHouse);
        Time.timeScale = 1;
        GameManager.Instance.NextScene();

    }
}
