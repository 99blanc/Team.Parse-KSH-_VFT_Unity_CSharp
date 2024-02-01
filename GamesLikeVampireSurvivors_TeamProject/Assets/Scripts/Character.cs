using UnityEngine;
using UniRx;

public abstract class Character : MonoBehaviour
{
    protected RelativeProperty<int> _currentHealthAmount;

    public abstract void Init();

    public virtual void GetDamage(int damage)
    {
        _currentHealthAmount.Value -= damage;

        if (_currentHealthAmount.Value <= 0)
        {
            Die();
        }
    }

    public abstract void Die();
}
