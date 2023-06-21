using UnityEngine;

[CreateAssetMenu(menuName = "AnswersScriptableObject")]
public class AnswersScriptable : ScriptableObject
{
    public string categoryName;
    public string[] answers;

    public string GetRandomAnswer()
    {
        return answers[Random.Range(0, answers.Length)];
    }
}
