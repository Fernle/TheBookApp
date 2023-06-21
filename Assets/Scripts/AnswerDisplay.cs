using UnityEngine;
using TMPro;

public class AnswerDisplay : MonoBehaviour
{
    public TMP_Text answerText;
    public AnswersScriptable answersScriptable;

    public void GettingRandomAnswer()
    {
        string randomAnswer = answersScriptable.GetRandomAnswer();
        answerText.text = randomAnswer;
    }
    
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                HandleInput();
            }
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            HandleInput();
        }
    }

    private void HandleInput()
    {
        Debug.LogWarning("Screen touched or clicked!");
        GettingRandomAnswer();
    }
}
