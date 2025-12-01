using UnityEngine;
using TMPro;

public class RandomLetter : MonoBehaviour
{
    public TextMeshProUGUI letterText;
    private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    void Start()
    {
        DisplayRandomLetter();
    }

    public void DisplayRandomLetter()
    {
        int randomIndex = Random.Range(0, alphabet.Length);
        char randomLetter = alphabet[randomIndex];
        letterText.text = randomLetter.ToString();
    }
}
