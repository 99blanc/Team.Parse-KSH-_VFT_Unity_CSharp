using UnityEngine;
using UniRx;

public abstract class CharacterBase : MonoBehaviour
{
    public ReactiveProperty<int> _HealthAmount { get; private set; }
    public ReactiveProperty<int> _ManaAmount { get; private set; }
    public ReactiveProperty<int> _UltimateAmount { get; private set; }

    public float moveSpeed { get; private set; }

    public abstract void GetDamage();

    public abstract void KeyInput();
}
