using UnityEngine;
using UnityEngine.UI;

public class Wizard : MonoBehaviour
{
    [SerializeField] private int min;
    [SerializeField] private int max;
    private int guess;
    [SerializeField] private Text guessText;
    private void Start()
    {
        guess = (min + max) / 2;
        guessText.text = ("I guess... " + guess + "!");
    }
}
