using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class NinjaFrogHealthChanger : MonoBehaviour
{
    [SerializeField] private float _rateOfChange;

    private NinjaFrog _ninjaFrog;
    private Slider _slider;

    private void Start()
    {
        _ninjaFrog = GetComponentInParent<NinjaFrog>();
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _ninjaFrog.Health, _rateOfChange * Time.deltaTime);
    }
}
