using UnityEngine;
using UnityEngine.UI;

public class SliderBar : MonoBehaviour
{
    private Slider _slider;

    private void Awake() => 
        _slider = GetComponent<Slider>();

    public void SetValue(float value) => 
        _slider.value = value;
}
