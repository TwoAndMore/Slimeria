using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _bulletPlace;
    [SerializeField] private float _shootForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        var bullet = Instantiate(_bulletPrefab, _bulletPlace.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().AddForce(_bulletPlace.transform.up * _shootForce, ForceMode2D.Impulse);
        Destroy(bullet, 2f);
    }
}
