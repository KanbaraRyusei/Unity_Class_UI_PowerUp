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
    [Header("名前")]
    private string _name;

    [SerializeField]
    [Header("画像")]
    private Sprite _sprite;

    [SerializeField]
    [Header("効果量")]
    private int _value;

    [SerializeField]
    [Header("強化できるステータス")]
    private PlayerStatus _status;
}
