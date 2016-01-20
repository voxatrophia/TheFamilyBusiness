using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Risk : Singleton<Risk> {

    public Slider slider;
    public float maxAmount = 100;
    float risk;

    void Start() {
        slider.value = 0;
        slider.maxValue = maxAmount;
    }

    void Update() {
       slider.value += Time.deltaTime;
        if (slider.value >= 100) {
            GameManager.Instance.GameOver();
        }
    }

    public void AddRisk(float amount) {
        slider.value += amount;
    }

}
