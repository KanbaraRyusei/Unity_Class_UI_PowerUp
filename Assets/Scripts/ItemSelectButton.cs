using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSelectButton : MonoBehaviour
{
    [SerializeField]
    private ItemData _itemData;

    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
    }

    public void SetItem()
    {
        StatusUpButton.Instance.AddButtonAction(StatusUp);
        _image.sprite = _itemData.ItemSprite;
    }

    public void UnSetItem()
    {
        StatusUpButton.Instance.RemoveButtonAction(StatusUp);
        _image.sprite = null;
    }

    public void StatusUp()
    {
        CharacterSetButton.Instance.CurrentSetCharacter.ChangeStatus(_itemData.Status, _itemData.Value);
        StatusUpButton.Instance.RemoveAllButtonAction();
    }
}
