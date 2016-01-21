using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;
    bool select;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        float Xmove = Input.GetAxis("Horizontal");
        float Ymove = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(Xmove * speed, Ymove * speed);
        select = Input.GetButtonDown("Select");
    }

    void OnTriggerStay2D(Collider2D other) {
        if (other.CompareTag("Door")) {
            if (select) {
                EventManager.TriggerEvent(k_Messages.DoorDialog);
            }
        }
    }

}
