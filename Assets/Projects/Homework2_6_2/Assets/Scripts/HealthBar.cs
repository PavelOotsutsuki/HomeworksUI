using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _rateOfChange;
    [SerializeField] private NinjaFrog _ninjaFrog;

    private Slider _slider;
    private Coroutine _displayHealthJob;

    private void Start()
    {
        _slider = GetComponent<Slider>();
    }

    public void DisplayHealthCoroutineStart()
    {
        float health = _ninjaFrog.Health;

        if (_displayHealthJob != null)
        {
            StopCoroutine(_displayHealthJob);
        }

        _displayHealthJob = StartCoroutine(DisplayHealth(health));
    }

    private IEnumerator DisplayHealth(float health)
    {
        while (_slider.value != health)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, health, _rateOfChange * Time.deltaTime);

            yield return true;
        }
    }
}
