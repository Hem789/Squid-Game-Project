using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class Lobby : MonoBehaviourPunCallbacks
{
    public Text abc;
    // Start is called before the first frame update
    public InputField xyz;
    /*void start()
    {
        xyz=FindObjectOfType<InputField>();
    }*/
    public void Crea()
    {
        if(xyz==null)
        {
            Debug.Log("didnt work");
        }
        PhotonNetwork.CreateRoom(xyz.text);
        abc.text="Creating \na room named \n("+xyz.text+")";
    }

    // Update is called once per frame
    public void Join()
    {
        PhotonNetwork.JoinRoom(xyz.text);
        abc.text="Joining \na room named \n("+xyz.text+")";
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
