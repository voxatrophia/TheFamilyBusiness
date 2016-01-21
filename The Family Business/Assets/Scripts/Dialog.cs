using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class Dialog : Singleton<Dialog> {
    public GameObject box;
    public Button startButton;
    public Text dialogDescription;
    public Image dialogImage;
    public Text value;

    GameObject item;
    //float itemValue;
    float itemRisk;

    void Start() {
        box.SetActive(false);
    }

    //void OnEnable() {
    //    Messenger.AddListener(k_Messages.PopupDialog, EnableDialog);
    //}

    //void OnDisable() {
    //    Messenger.RemoveListener(k_Messages.PopupDialog, EnableDialog);
    //}

    void OnEnable() {
        //Messenger.AddListener<GameObject>(k_Messages.PopupDialog, EnableDialog);
        EventManager.StartListening(k_Messages.PopupDialog, EnableDialog);

    }

    void OnDestroy() {
        //Messenger.RemoveListener<GameObject>(k_Messages.PopupDialog, EnableDialog);
        EventManager.StopListening(k_Messages.PopupDialog, EnableDialog);

    }

    public void SelectItem(GameObject itemToSelect) {
        item = itemToSelect;
    }

    void EnableDialog() {
        Time.timeScale = 0;

        if (item == null) {
            return;
        }

        SpriteRenderer spr = item.GetComponent<SpriteRenderer>();
        ItemProperties prop = item.GetComponent<ItemProperties>();

        dialogDescription.text = prop.description;
        dialogImage.sprite = spr.sprite;
        itemRisk = prop.risk;
        //itemValue = prop.value;
        value.text = prop.value.ToString();

        box.SetActive(true);
        EventSystem.current.SetSelectedGameObject(startButton.gameObject);
        box.SetActive(true);

    }

    void EnableDialog(GameObject SelectedItem) {
        Time.timeScale = 0;
        item = SelectedItem;
        SpriteRenderer spr = SelectedItem.GetComponent<SpriteRenderer>();
        ItemProperties prop = SelectedItem.GetComponent<ItemProperties>();

        dialogDescription.text = prop.description;
        dialogImage.sprite = spr.sprite;
        itemRisk = prop.risk;
        //itemValue = prop.value;
        value.text = prop.value.ToString();

        box.SetActive(true);
        EventSystem.current.SetSelectedGameObject(startButton.gameObject);
    }

    public void DisableDialog(GameObject window) {
        Time.timeScale = 1;
        window.SetActive(false);

    }

    public void StealItem() {
        Risk.Instance.AddRisk(itemRisk);
        Inventory.Instance.AddItem(item);
        item.SetActive(false);

    }


}
