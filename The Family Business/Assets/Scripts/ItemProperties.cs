using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemProperties : MonoBehaviour {
    public Dictionary<string, string> properties;

    public string description;
    public float risk;
    public float value;
    public float weight;
    public float itemName;

    void Start() {
        properties = new Dictionary<string, string>();

        properties["Description"] = description;
        properties["Risk"] = risk.ToString();
        properties["Value"] = value.ToString();
        properties["Weight"] = weight.ToString();
    }
}
