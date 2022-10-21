using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gernade : MonoBehaviour
{
   public GameObject gernadePrefab;
   public GameObject gSpawn;

    public void CreateGernade()
    {
        GameObject newGernade = Instantiate(gernadePrefab, gSpawn.transform.position, gSpawn.transform.rotation);

    }

}
