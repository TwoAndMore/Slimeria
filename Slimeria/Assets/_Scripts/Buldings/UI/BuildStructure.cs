using UnityEngine;

public class BuildStructure : MonoBehaviour
{
    [SerializeField] private LoadBuildings _loadBuildings;
    [SerializeField] private Coins _coins;

    private void Start() => 
        _coins = Coins.Instance;

    public void Build()
    {
        Debug.Log(_coins.currentCoins);
        Debug.Log(_loadBuildings.currentBuilding.price);
        if (_coins.currentCoins >= _loadBuildings.currentBuilding.price)
        {
            Debug.Log("Build");
            _coins.AddCoins(-_loadBuildings.currentBuilding.price);
        }
        else
        {
            Debug.Log("<color=red>Not Enough money! </color>");
        }
    }
}
