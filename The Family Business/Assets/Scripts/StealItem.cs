using UnityEngine;
using System.Collections;

public class StealItem : MonoBehaviour {
    bool select = false;

    void Update() {
        select = Input.GetKeyDown(KeyCode.E);
    }

    void OnTriggerStay2D(Collider2D other) {
        if (other.CompareTag("Item")) {
            if (select) {
                Messenger.Broadcast(k_Messages.PopupDialog, other.gameObject);
                //Messenger.MarkAsPermanent(k_Messages.PopupDialog);
            }
        }

        if (other.CompareTag("Door")) {
            if (select) {
                Messenger.Broadcast(k_Messages.DoorDialog);
                //Messenger.MarkAsPermanent(k_Messages.DoorDialog);
                //EventManager.TriggerEvent(k_Messages.DoorDialog);
            }
        }
    }
}
