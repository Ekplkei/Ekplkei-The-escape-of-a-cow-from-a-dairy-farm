using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class CreateDoor : MonoBehaviour
{
    public GameObject Door;
    private void Start()
    {
        int locationX = Random.Range(-5, 4);
        int locationY = Random.Range(-5, 4);
        Instantiate(Door, new Vector3(locationX + 0.5f, locationY + 0.5f), Quaternion.identity);
    }

}