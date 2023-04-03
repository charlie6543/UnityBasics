using UnityEngine;
using UnityEngine.UI;

public class ActivateWriter : MonoBehaviour
{
    [SerializeField] private TextWriter textWriter;
    private Text messageText;

    private void Awake()
    {
        messageText = transform.Find("Message").GetComponent<Text>();
    }

    void Start()
    {
        textWriter.AddWriter(messageText, "Once upon a time, in a galaxy far, far, away, there lived a lonely duck. " +
            "The duck had lived sheltered in a castle all of its life.", 0.03f, true);
    }

    
}
