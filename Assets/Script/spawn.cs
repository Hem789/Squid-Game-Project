using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class spawn : MonoBehaviour
{
    public GameObject donkey;
    private int x,z;
    private Camera camu;
    // Start is called before the first frame update
    void Start()
    {
        camu=Camera.main;
       // x=Random.Range(-4400,4400);
        //z=Random.Range(-4400,4400);
        x=Random.Range(-4,4);
        z=Random.Range(-4,4);
        camu.gameObject.SetActive(false);
        PhotonNetwork.Instantiate(donkey.name,new Vector3(x,266,z),Quaternion.identity);
    }

}
