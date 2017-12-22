using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ImageSpawner : MonoBehaviour
{
    

    public Transform targetPos;
    GameObject spawnedImage;
    public List<GameObject> images = new List<GameObject>();
    public int imageIndex = 0;


    void Start ()
    {
        
    }

    void Update ()
    {

    }

    public void SpawnImage ()
    {
        if (spawnedImage != null) {
            Destroy(spawnedImage);
        }
        spawnedImage = Instantiate(images[imageIndex], targetPos.position, targetPos.rotation) as GameObject;
        spawnedImage.SetActive(true);

    }

    public void NextImage ()
    {
        imageIndex++;
        if (imageIndex >= images.Count) {
            imageIndex = 0;
        }
        SpawnImage();

    }
    public void PrevImage ()
    {
        imageIndex--;
        if (imageIndex >= images.Count) {
            imageIndex = 1;
        }
        SpawnImage();
    }

   
    
}


