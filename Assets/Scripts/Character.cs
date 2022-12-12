using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int Level => _level;

    public string Name => _name;
    public bool IsSetCharacter => _isSetCharacter;

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

    private CharacterData _data;
    private bool _isSetCharacter = false;

    public void SetData(CharacterData data)
    {
        _data = data;
        _isSetCharacter = true;
    }

    public void Init()
    {
        _name = _data.Name;
        _power = _data.Power;
        _defence = _data.Defence;
        _speed = _data.Speed;
        _hp = _data.HP;
        _mp = _data.MP;
        _exp = _data.Exp;
        _level = _data.Level;
    }

    public void ChangeStatus(PlayerStatus status, int value)
    {
        switch (status)
        {
            case PlayerStatus.Power:

                _power += CheckState(status, value);
                
                break;

            case PlayerStatus.Defence:
                
                _defence += CheckState(status, value);
                
                break;

            case PlayerStatus.Speed:
                
                _speed += CheckState(status, value);
                
                break;

            case PlayerStatus.HP:
                
                _hp += CheckState(status, value);
                
                break;

            case PlayerStatus.MP:
                
                _mp += CheckState(status, value);
                
                break;

            case PlayerStatus.Exp:
                
                _exp += CheckState(status, value);
                
                break;

            case PlayerStatus.Level:
                
                _level += CheckState(status, value);
                
                break;
        }
    }

    private int CheckState(PlayerStatus status, int value)
    {
        int currentState = 0;
        int maxState = 0;
        switch (status)
        {
            case PlayerStatus.Power:

                currentState = _power;
                maxState = CharacterMaxStatusManager.Instance.MaxPower;

                break;

            case PlayerStatus.Defence:

                currentState = _defence;
                maxState = CharacterMaxStatusManager.Instance.MaxDefence;

                break;

            case PlayerStatus.Speed:

                currentState = _speed;
                maxState = CharacterMaxStatusManager.Instance.MaxSpeed;

                break;

            case PlayerStatus.HP:

                currentState = _hp;
                maxState = CharacterMaxStatusManager.Instance.MaxHP;

                break;

            case PlayerStatus.MP:

                currentState = _mp;
                maxState = CharacterMaxStatusManager.Instance.MaxMP;

                break;

            case PlayerStatus.Exp:

                currentState = _exp;
                maxState = CharacterMaxStatusManager.Instance.MaxExp;

                break;

            case PlayerStatus.Level:

                currentState = _level;
                maxState = CharacterMaxStatusManager.Instance.MaxLevel;

                break;
        }

        if (currentState + value > maxState)
        {
            value = maxState - currentState;
        }

        return value;
    }
}
