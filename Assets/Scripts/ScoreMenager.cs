using TMPro;
using UnityEngine;

public class ScoreMenager : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public int score = 0;
    public static int finalScore;

    public void addScore()
    {
        score ++;
        finalScore=score;
        UiUpdate();
    }
    public void UiUpdate()
    {
        tmp.text = $"Score:{score.ToString()}";
    }
}
