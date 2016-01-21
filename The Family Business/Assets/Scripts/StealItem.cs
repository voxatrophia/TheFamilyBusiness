using UnityEngine;
using System.Collections;

public class StealItem : MonoBehaviour {
    bool select = false;

    void Update() {
        select = Input.GetButtonDown("Select");
    }

    void OnTriggerStay2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            if (select) {
                //                Messenger.Broadcast(k_Messages.PopupDialog, other.gameObject);
                Dialog.Instance.SelectItem(this.gameObject);
                EventManager.TriggerEvent(k_Messages.PopupDialog);
            }
        }

        if (other.CompareTag("Door")) {
            if (select) {
                EventManager.TriggerEvent(k_Messages.DoorDialog);
            }
        }
    }
}
