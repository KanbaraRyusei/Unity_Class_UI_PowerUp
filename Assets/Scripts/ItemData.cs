using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ItemData", fileName ="ItemData")]
public class ItemData : ScriptableObject
{
    public string Name => _name;
    public Sprite ItemSprite => _sprite;
    public int Value => _value;
    public PlayerStatus Status => _status;

    [SerializeField]
    [Header("���O")]
    private string _name;

    [SerializeField]
    [Header("�摜")]
    private Sprite _sprite;

    [SerializeField]
    [Header("���ʗ�")]
    private int _value;

    [SerializeField]
    [Header("�����ł���X�e�[�^�X")]
    private PlayerStatus _status;
}
