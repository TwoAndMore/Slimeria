using UnityEngine;
using UnityEngine.UI;

public class SetBuildingUI : MonoBehaviour
{
    [SerializeField] private Image _image;
    
    public ScriptableBuilding building;

    private void Start() => 
        _image.sprite = building.image;
}
