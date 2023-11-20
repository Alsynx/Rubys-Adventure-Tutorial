using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TMP_Text Score;

    public int numFixed = 0;

    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<TMP_Text>();
        Score.text = "Robots Fixed: " + numFixed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore(){
        numFixed++;
        Score.text = "Robots Fixed: " + numFixed;
    }
}
