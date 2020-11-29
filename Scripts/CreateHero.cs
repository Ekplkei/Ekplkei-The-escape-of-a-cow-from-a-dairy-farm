using UnityEngine;

public class CreateHero : MonoBehaviour
{
    public GameObject Hero;
    private void Start()
    {
    int locationX = Random.Range(-5, 4);
    int locationY = Random.Range(-5, 4);
    Hero = Instantiate(Hero, new Vector3(locationX + 0.5f, locationY + 0.5f), Quaternion.identity) as GameObject;
    }
}