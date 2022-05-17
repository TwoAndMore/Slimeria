using UnityEngine;

public class Health : MonoBehaviour
{
    private float _maxHealth = 100f;
    [SerializeField] private float _currentHealth;
    [SerializeField] private SliderBar sliderBar;

    private void Start() => 
        _currentHealth = _maxHealth;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10f);   
        }
    }

    private void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        sliderBar.SetValue(_currentHealth);
        
        if (_currentHealth <= 0)
        {
            Debug.Log("You're dead");
        }
    }
}
