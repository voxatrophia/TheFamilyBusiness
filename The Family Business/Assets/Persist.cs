using UnityEngine;
using System.Collections;

public class Persist : MonoBehaviour {
    void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }
}
