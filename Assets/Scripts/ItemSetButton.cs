using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSetButton : MonoBehaviour
{
    [SerializeField]
    private GameObject _panel;

    private void Awake()
    {
        _panel.SetActive(false);
    }

    public void SetPanel()
    {
        _panel.SetActive(!_panel.activeSelf);
    }
}
