using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHolderBlueMesh : MonoBehaviour
{
    // Start is called before the first frame update
    TMPro.TextMeshPro scoretext2;

    // Start is called before the first frame update

    private void Awake()
    {
        scoretext2 = GetComponent<TMPro.TextMeshPro>();
        GoalHolderBlueSingle.mavitakimgol = 0;
        GoalHolderKirmiziSingle.kýrmýzýtakýmgol = 0;

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoretext2.text = " " + GoalHolderBlueSingle.mavitakimgol;
    }
}
