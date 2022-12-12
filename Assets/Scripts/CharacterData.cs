using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="CharacterData", fileName ="CharacterData")]
public class CharacterData : ScriptableObject
{
    public string Name => _name;
    public int Power => _power;
    public int Defence => _defence;
    public int Speed => _speed;
    public int HP => _hp;
    public int MP => _mp;
    public int Exp => _exp;
    public int Level => _level;

    [SerializeField]
    private string _name;

    [SerializeField]
    private int _power;

    [SerializeField]
    private int _defence;

    [SerializeField]
    private int _speed;

    [SerializeField]
    private int _hp;

    [SerializeField]
    private int _mp;

    [SerializeField]
    private int _exp;

    [SerializeField]
    private int _level;
}
