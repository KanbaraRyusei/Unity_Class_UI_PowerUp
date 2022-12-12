using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSetButton : MonoBehaviour
{
    [SerializeField]
    private GameObject _panel;

    private void Awake()
    {
        _panel.SetActive(false);
        GetComponent<Button>().onClick.AddListener(SetPanel);
    }

    private void SetPanel()
    {
        _panel.SetActive(!_panel.activeInHierarchy);
    }
}
