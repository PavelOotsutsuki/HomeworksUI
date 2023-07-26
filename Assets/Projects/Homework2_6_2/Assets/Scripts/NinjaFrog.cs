using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NinjaFrog : MonoBehaviour
{
    [SerializeField] private UnityEvent _healthChange = new UnityEvent();

    private readonly float _maxHealth = 1f;
    private readonly float _minHealth = 0;
    private readonly float _heal = 0.1f;
    private readonly float _damage = 0.1f;

    private float _health;

    public float Health => _health;

    private void Start()
    {
        _health = _maxHealth;
    }

    public void TakeHeal()
    {
        _health += _heal;

        CorrectHealth();
        _healthChange?.Invoke();
    }

    public void TakeDamage()
    {
        _health -= _damage;

        CorrectHealth();
        _healthChange?.Invoke();
    }

    private void CorrectHealth()
    {
        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }
        else if (_health < _minHealth)
        {
            _health = _minHealth;
            Dead();
        }
    }

    private void Dead()
    {
        Debug.Log("You dead!");
    }
}
