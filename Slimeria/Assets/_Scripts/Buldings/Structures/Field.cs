using UnityEngine;

public class Field : MonoBehaviour
{
    [Header("Upgrade Sprites")]
    [SerializeField] private Sprite[] _fenceUpgradeSprites;
    [SerializeField] private Sprite[] _grassUpgradeSprites;
    [SerializeField] private Sprite _waterUpgrade;

    [Header("Objects")] 
    [SerializeField] private SpriteRenderer _fence;
    [SerializeField] private SpriteRenderer _grass;
    [SerializeField] private SpriteRenderer _water;
    
    private int _fenceUpgradeLevel = 0;
    private int _grassUpgradeLevel = 0;

    public void UpgradeField()
    {
        if (_fenceUpgradeLevel < _fenceUpgradeSprites.Length)
        {
            _fence.sprite = _fenceUpgradeSprites[_fenceUpgradeLevel];
        }
        
        _fenceUpgradeLevel++;
    }
    
    public void UpgradeGrass()
    {
        _fence.sprite = _fenceUpgradeSprites[_grassUpgradeLevel];
        _grassUpgradeLevel++;
    }
}
