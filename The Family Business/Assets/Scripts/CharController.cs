using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;
    
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        float Xmove = Input.GetAxis("Horizontal");
        float Ymove = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(Xmove * speed, Ymove * speed);
        if (Input.GetKeyDown(KeyCode.L)) {
            Debug.Log("Pressed");
        }
    }
}
