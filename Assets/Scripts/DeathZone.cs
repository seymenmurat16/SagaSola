using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameObject guiGameOver = null;
    void OnTriggerEnter(Collider other)
    {
        if(other != null){
            Destroy(other.gameObject);
            if (other.gameObject.tag == "Player"){
                guiGameOver.SetActive ( true );   
            }
        }
    }
}
