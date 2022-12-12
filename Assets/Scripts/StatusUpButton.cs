using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class StatusUpButton : SingletonMonoBehaviour<StatusUpButton>
{
    [SerializeField]
    private Button _button;

    protected override void Awake()
    {
        base.Awake();
    }

    public void AddButtonAction(Action action)
    {
        _button.onClick.AddListener(action.Invoke);
    }

    public void RemoveAllButtonAction()
    {
        _button.onClick.RemoveAllListeners();
    }

    public void RemoveButtonAction(Action action)
    {
        _button.onClick.RemoveListener(action.Invoke);
    }
}
