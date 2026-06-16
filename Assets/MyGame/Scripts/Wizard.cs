using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Wizard : MonoBehaviour
{
    [SerializeField] private int min;
    [SerializeField] private int max;
    private int guess;
    [SerializeField] private Text guessText;
    [SerializeField] private Button correct;
    [SerializeField] private Button lower;
    [SerializeField] private Button higher;
    private void Start()
    {
        guess = (min + max) / 2;
        guessText.text = ("I guess... " + guess + "!");
    }

    public void CorrectGuess()
    {
        guessText.text = ("I guessed your number!" + "        Final Guess: " + guess);
        lower.interactable = false;
        higher.interactable = false;
        correct.interactable = false;
        // Wenn die korrekte Zahl erreicht ist, ist das Spiel zu ende.
    }
    public void Higher()
    {
        min = guess + 1;
        guess = (min + max) / 2;
        guessText.text = ("I guess... " + guess + "!");
        //min Wert wird angepasst, der minimale guess-Wert kann nicht größer als der letzte guess sein.
    }

    public void Lower()
    {
        max = guess - 1;
        guess = (max + min) / 2;
        guessText.text = ("I guess... " + guess + "!");
        // max Wert wird angepasst, der maximale guess-Wert kann nicht größer als der letzte guess sein.
    }
    public void Restart()
    {
        min = 0;
        max = 100;
        lower.interactable = true;
        higher.interactable = true;
        correct.interactable = true;
        guess = (min + max) / 2;
        guessText.text = ("I guess... " + guess + "!");
    }
}
