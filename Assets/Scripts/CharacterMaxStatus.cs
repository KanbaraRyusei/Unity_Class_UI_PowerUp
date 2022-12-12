using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="CharacterMaxStatus", fileName ="CharacterMaxStatus")]
public class CharacterMaxStatus : ScriptableObject
{
    public int[] Power => _maxPower;
    public int[] Defence => _maxDefence;
    public int[] Speed => _maxSpeed;
    public int[] HP => _maxHp;
    public int[] MP => _maxMp;
    public int[] Exp => _maxExp;
    public int Level => _maxLevel;

    [SerializeField]
    private int[] _maxPower;

    [SerializeField]
    private int[] _maxDefence;

    [SerializeField]
    private int[] _maxSpeed;

    [SerializeField]
    private int[] _maxHp;

    [SerializeField]
    private int[] _maxMp;

    [SerializeField]
    private int[] _maxExp;

    [SerializeField]
    private int _maxLevel;
}
