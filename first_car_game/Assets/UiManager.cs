using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{   static public UiManager instance;
    public GameObject bnGameOver;

    private void Awake(){
        UiManager.instance = this;
        this.bnGameOver =  GameObject.Find("bnGameOver");
        this.bnGameOver.SetActive(false);
    }



   
}
