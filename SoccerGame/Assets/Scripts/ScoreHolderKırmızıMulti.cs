using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHolderKırmızıMulti : MonoBehaviour
{
    Text scoretext;

    // Start is called before the first frame update

    private void Awake()
    {
        scoretext = GetComponent<Text>();
        GoalHolderBlue.mavitakimgol = 0;
        GoalHolderKirmizi.kırmızıtakımgol = 0;

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = " " + GoalHolderKirmizi.kırmızıtakımgol;
    }
}
