using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI scoreText;
    private int _score;
    public int Score
    {
        get
        {
            return _score;
        }
        set
        {
            scoreText.text = value.ToString();
            _score = value;
        }
    }

}
