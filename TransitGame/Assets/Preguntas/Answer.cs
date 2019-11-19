using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    public Text answerText;
    private Option answerData;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Setup(Option data)
    {
        answerData = data;
        answerText.text = answerData.answerText;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandlerClick()
    {
        
    }
}
