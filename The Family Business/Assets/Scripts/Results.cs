using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Results : MonoBehaviour {

    //UI stuff
    public Text itemList;
    public Text debtText;
    public Text oldDebtText;
    public GameObject strike;
    public Text total;

    string itemTextList;

    bool calculated = false;

    Dictionary<string, float> items;

    void Start() {
        items = Inventory.Instance.GetList();
        //        debtText.text = Inventory.Instance.debt.ToString();
        //        oldDebtText.text = Inventory.Instance.oldDebt.ToString();

        oldDebtText.text = Inventory.Instance.debt.ToString();
        debtText.gameObject.SetActive(false);
        total.text = Inventory.Instance.total.ToString();
        strike.SetActive(false);

        ListItems();
    }

    void ListItems() {
        if (items == null) {
            return;
        }
        foreach (KeyValuePair<string, float> elem in items) {
            // do something with entry.Value or entry.Key
            itemTextList += elem.Key + ": " + elem.Value + " \n";
            itemList.text = itemTextList;
        }
    }

    public void Continue() {
        if (calculated) {
            //            Messenger.Broadcast(k_Messages.LeaveHouse);
            //            Debug.Log("Load Next Scene");
            GameManager.Instance.NextScene();
        }
        else {
            CalculateTotal();
        }
    }

    void CalculateTotal() {
        calculated = true;
        float amount = Inventory.Instance.debt - Inventory.Instance.total;
        debtText.text = amount.ToString();
        debtText.gameObject.SetActive(true);
        strike.SetActive(true);
        Inventory.Instance.debt = amount;


    }
}
