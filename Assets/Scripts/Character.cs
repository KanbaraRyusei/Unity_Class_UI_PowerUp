using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int Level => _level;
    public string Name => _name;
    public bool IsSetCharacter => _isSetCharacter;

    private string _name;
    private int _power;
    private int _defence;
    private int _speed;
    private int _hp;
    private int _mp;
    private int _exp;
    private int _level;

    [SerializeField]
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
        int changeValue = CheckState(status, value);
        switch (status)
        {
            case PlayerStatus.Power:

                _power += changeValue;
                
                break;

            case PlayerStatus.Defence:
                
                _defence += changeValue;
                
                break;

            case PlayerStatus.Speed:
                
                _speed += changeValue;
                
                break;

            case PlayerStatus.HP:
                
                _hp += changeValue;
                
                break;

            case PlayerStatus.MP:
                
                _mp += changeValue;
                
                break;

            case PlayerStatus.Exp:
                
                _exp += changeValue;
                
                break;

            case PlayerStatus.Level:
                
                _level += changeValue;
                
                break;
        }

        Debug.Log(status + "が" + changeValue + "アップした！");
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
