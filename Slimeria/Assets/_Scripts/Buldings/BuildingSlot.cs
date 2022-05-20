using UnityEngine;

public class BuildingSlot : MonoBehaviour
{
    [SerializeField] private ScriptableBuilding _currentBuilding;
    [SerializeField] private Transform _buildPlaceParent;

    private bool _isSetted;
    
    private void Awake() => 
        SetBuilding(_currentBuilding);

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            SetBuilding(_currentBuilding);
        }
    }

    public void SetBuilding(ScriptableBuilding building)
    {
        if(_isSetted)
            Destroy(_buildPlaceParent.GetChild(0).gameObject);
        
        var structure = Instantiate(building.prefab, _buildPlaceParent);
        _isSetted = true;
    }
}
