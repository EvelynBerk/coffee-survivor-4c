using UnityEngine;
using TMPro;

public class TypingGame : MonoBehaviour
{
    public static TypingGame Instance;
    

    [SerializeField] private TMP_Text letterText;
    [SerializeField] private GameObject minigameUI;
    
    private char currentLetter;
    private bool isActive = false;
    
    void Awake()
    {
        Instance = this;
    }
    
    void Start()
    {
        GenerateNewLetter();
        isActive = true;
    }
    
    public void Activate()
    {
        isActive = true;
        minigameUI.SetActive(true);
        GenerateNewLetter();
        Debug.Log("Minigame aktiviert");
    }
    
    public void Deactivate()
    {
        isActive = false;
        minigameUI.SetActive(false);
        Debug.Log("Minigame deaktiviert");
    }
    
    void GenerateNewLetter()
    {
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int randomIndex = Random.Range(0, alphabet.Length);
        currentLetter = alphabet[randomIndex];
        letterText.text = currentLetter.ToString();
    }
    
    void Update()
    {
        if (!isActive) return;
        
        foreach (char c in Input.inputString)
        {
            char upper = char.ToUpper(c);
            if (char.IsLetter(upper) && upper == currentLetter)
            {
                Debug.Log("Richtig!");
                GenerateNewLetter();
            }
            else if (char.IsLetter(upper))
            {
                Debug.Log("Falsch!");
            }
        }
    }
}