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
        GetComponent<Button>().onClick.AddListener(SetPanel);
    }

    public void SetCharacter(Character character)
    {
        _character = character;
    }

    private void SetPanel()
    {
        _panel.SetActive(!_panel.activeSelf);
    }
}
