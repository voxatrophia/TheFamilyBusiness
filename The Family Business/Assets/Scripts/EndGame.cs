using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndGame : MonoBehaviour {

    float total = 0;
    public Image badEnding;
    public Image worseEnding;

    void Start() {
        badEnding.gameObject.SetActive(false);
        worseEnding.gameObject.SetActive(false);

        total = Inventory.Instance.CountValue();

        if (total < 8000) {
            WorseEnding();
        }
        else {
            BadEnding();
        }
    }

    void BadEnding() {
        badEnding.gameObject.SetActive(true);        
    }

    void WorseEnding() {
        worseEnding.gameObject.SetActive(true);

    }

    public void Exit() {
        AppHelper.Quit();
    }
}
