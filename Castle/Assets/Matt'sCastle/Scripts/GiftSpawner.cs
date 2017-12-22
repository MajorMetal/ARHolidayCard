using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiftSpawner : MonoBehaviour
{

    public Transform targetPos;
    public GameObject spawnedGift;
    public GameObject pushButton;
   

    void Awake ()
    {
        
    }
    void Start ()
    {

    }

    void Update ()
    {

    }

    public void SpawnGift()
    {
      if (pushButton != null) {
            Destroy(pushButton);
       }
      //  spawnedGift = Instantiate(spawnedGift, targetPos.position, targetPos.rotation) as GameObject;
      //  spawnedGift.SetActive(true);
        pushButton = Instantiate(pushButton, targetPos.position, targetPos.rotation) as GameObject;
        pushButton.SetActive(true);
        Debug.Log("spawnedGift");

    }

 
}

