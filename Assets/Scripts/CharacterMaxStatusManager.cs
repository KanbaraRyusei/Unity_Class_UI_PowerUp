using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMaxStatusManager : SingletonMonoBehaviour<CharacterMaxStatusManager>
{
    public int MaxPower => _maxStatus.Power[CharacterSetButton.Instance.CurrentSetCharacter.Level];
    public int MaxDefence => _maxStatus.Defence[CharacterSetButton.Instance.CurrentSetCharacter.Level];
    public int MaxSpeed => _maxStatus.Speed[CharacterSetButton.Instance.CurrentSetCharacter.Level];
    public int MaxHP => _maxStatus.HP[CharacterSetButton.Instance.CurrentSetCharacter.Level];
    public int MaxMP => _maxStatus.MP[CharacterSetButton.Instance.CurrentSetCharacter.Level];
    public int MaxExp => _maxStatus.Exp[CharacterSetButton.Instance.CurrentSetCharacter.Level];
    public int MaxLevel => _maxStatus.Level;

    [SerializeField]
    private CharacterMaxStatus _maxStatus;

    protected override void Awake()
    {
        base.Awake();
    }
}
