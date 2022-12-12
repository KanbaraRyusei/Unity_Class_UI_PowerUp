using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSetButton : SingletonMonoBehaviour<CharacterSetButton>
{
    public Character CurrentSetCharacter => _character;

    private Character _character;

    [SerializeField]
    private GameObject _panel;

    protected override void Awake()
    {
        base.Awake();
        _panel.SetActive(false);
    }

    public void SetPanel()
    {
        _panel.SetActive(!_panel.activeSelf);
    }

    public void SetCharacter(Character character)
    {
        _character = character;
    }
}
