using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Inventory : Singleton<Inventory> {
    Dictionary<string, float> inv;
    public float debt = 50000;
    public float oldDebt;
    public float total = 0;

    void Awake() {
        inv = new Dictionary<string, float>();
        total = 0;
    }

    public void AddItem(GameObject item) {
        ItemProperties prop = item.GetComponent<ItemProperties>();
        inv.Add(item.name, prop.value);
        total += prop.value;
    }

    public float CountValue() {
        return total;
    }

    public Dictionary<string, float> GetList() {
        return inv;
    }
}
