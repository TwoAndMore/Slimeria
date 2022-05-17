using UnityEngine;

public class WeaponRotate : MonoBehaviour
{
    [SerializeField] private Camera _playerCamera;
    
    public Vector3 mousePosition;
    
    private void Update()
    {
        mousePosition = Input.mousePosition;
        LookCursor();
    }
    
    private void LookCursor()
    {
        Vector2 lookDirection = Input.mousePosition - _playerCamera.WorldToScreenPoint(transform.position);
        transform.right = lookDirection;
    }
    
}
