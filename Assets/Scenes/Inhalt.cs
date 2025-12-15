using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CoffeeManager : MonoBehaviour
{
    public static CoffeeManager Instance;
    
    [SerializeField] private TextMeshProUGUI coffeeSlider;
    [SerializeField] private float drainRate = 5f;
    private float coffeeLevel = 100f;
    
    void Awake()
    {
        Instance = this;
    }
    
    void Update()
    {
        coffeeLevel -= drainRate * Time.deltaTime;
        coffeeLevel = Mathf.Clamp(coffeeLevel, 0f, 100f);
        coffeeSlider.text = "Kaffee: " + Mathf.RoundToInt(coffeeLevel) + "%";
        
        if (coffeeLevel <= 0)
        {
            Debug.Log("TODO: Hier macht PERSON 2 weiter - Game Over auslösen");
        }
    }
    
    public void RefillCoffee()
    {
        coffeeLevel = 100f;
        Debug.Log("Kaffee aufgefüllt!");
    }
}