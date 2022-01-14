using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class connectingToServer : MonoBehaviourPunCallbacks
{
    public Text s;
    public void Con()
    {
    PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        s.text="connected to master";
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        s.text=("Joined Lobby");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        //s.text=""+SceneManager.GetActiveScene().buildIndex;
    }
   
}
