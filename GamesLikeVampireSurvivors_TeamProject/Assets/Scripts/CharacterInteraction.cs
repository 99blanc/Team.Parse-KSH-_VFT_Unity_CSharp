using UnityEngine;
using UniRx;

public class CharacterInteraction : MonoBehaviour
{
    public ReactiveProperty<int> _CurrentHealthAmount { get; protected set; }
    public ReactiveProperty<int> _CurrentManaAmount { get; protected set; }
    public ReactiveProperty<int> _CurrentUltimateAmount { get; protected set; }

    public float moveSpeed { get; protected set; }
}
