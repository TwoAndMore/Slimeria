using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadBuildings : MonoBehaviour
{
    [SerializeField] private string _path;
    [SerializeField] private ScriptableBuilding[] _buildings;
    [SerializeField] private GameObject _frame;

    [SerializeField] private TextMeshProUGUI _title;
    [SerializeField] private TextMeshProUGUI _price;
    [SerializeField] private TextMeshProUGUI _description;
    [SerializeField] private Image _image;
    [SerializeField] private Button _button;
    
    [SerializeField] private Coins _coins;
    
    public ScriptableBuilding currentBuilding;
    
    private void Awake()
    {
        _buildings = Resources.LoadAll<ScriptableBuilding>(_path);
        
        currentBuilding = _buildings[0];
        
        foreach (var building in _buildings)
        {
            var build = Instantiate(_frame, transform);
            build.GetComponent<SetBuildingUI>().building = building;
            build.transform.Find("Frame").GetComponent<Button>().onClick.AddListener(delegate
            {
                SetBuildingInfo(building);
                UpdateInfo();
            });
        }
    }

    private void Start()
    {
        _coins = Coins.Instance;
        UpdateInfo();
    }
        

    private void SetBuildingInfo(ScriptableBuilding building) => 
        currentBuilding = building;

    private void UpdateInfo()
    {
        _title.text = currentBuilding.title;
        _price.text = currentBuilding.price + " $";
        _image.sprite = currentBuilding.image;
        _description.text = currentBuilding.description;
        _button.interactable = _coins.currentCoins >= currentBuilding.price;
    }
}
