using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHolderKırmızıMesh : MonoBehaviour
{
    TMPro.TextMeshPro scoretext;

    // Start is called before the first frame update

    private void Awake()
    {
        scoretext = GetComponent<TMPro.TextMeshPro>();
        GoalHolderBlueSingle.mavitakimgol = 0;
        GoalHolderKirmiziSingle.kırmızıtakımgol = 0;

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = " " + GoalHolderKirmiziSingle.kırmızıtakımgol;
    }
}
