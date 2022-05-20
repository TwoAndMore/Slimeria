using UnityEngine;
using UnityEngine.UI;

public class FieldUpgrades : MonoBehaviour
{
    [Header("Upgrade Sprites")]
    [SerializeField] private Sprite[] _fenceUpgradeSprites;
    [SerializeField] private Sprite[] _grassUpgradeSprites;
    [SerializeField] private Sprite _waterUpgrade;

    [Header("Objects")] 
    [SerializeField] private SpriteRenderer _fence;
    [SerializeField] private SpriteRenderer _grass;
    [SerializeField] private SpriteRenderer _water;
    
    [Header("UI Objects")] 
    [SerializeField] private Image _waterUI;
    
    private int _fenceUpgradeLevel = 0;
    private int _grassUpgradeLevel = 0;

    private int[] _fenceUpgradesCost = { 300, 400, 500 };
    private int[] _grassUpgradesCost = { 300, 400, 500 };
    private int _waterUpgradeCost = 500;
    
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
