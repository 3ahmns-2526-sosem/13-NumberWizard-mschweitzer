using Unity.VisualScripting;
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
    }
}
