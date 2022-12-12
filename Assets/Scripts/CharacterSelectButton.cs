using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectButton : MonoBehaviour
{
    [SerializeField]
    private Character _character;

    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
    }

    public void SetCharacter()
    {
        CharacterSetButton.Instance.SetCharacter(_character);
    }
}
