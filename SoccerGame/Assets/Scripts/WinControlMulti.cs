using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon;
using Photon.Pun;
public class WinControlMulti : MonoBehaviour
{
    GoalHolderBlue goalHolderBlue;
    GoalHolderKirmizi goalHolderKirmizi;
    

    
    void Update()
    {
        if (GoalHolderBlue.mavitakimgol == 5)
        {
            PhotonNetwork.Disconnect();
            SceneManager.LoadScene("Main_Menu");
        }
       
        
        if (GoalHolderKirmizi.kýrmýzýtakýmgol == 5)
        {
            PhotonNetwork.Disconnect();
            SceneManager.LoadScene("Main_Menu");
        }


        if (Input.GetKeyDown(KeyCode.M))
        {
            PhotonNetwork.Disconnect();
            SceneManager.LoadScene("Main_Menu");
        }
    }
}
