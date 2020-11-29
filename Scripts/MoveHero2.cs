using UnityEngine;

public class MoveHero2 : MonoBehaviour
{
    public Vector3 HeroPos;
    public GameObject Door;
    int Direction;

    private void Start()
    {
        int locationX = Random.Range(-5,4);
        int locationY = Random.Range(-5, 4);
        transform.position = new Vector3(locationX + 0.5f, locationY + 0.5f);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            Direction = 1;
            HeroPosAnim();
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Direction = 2;
            HeroPosAnim();
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Direction = 3;
            HeroPosAnim();
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Direction = 4;
            HeroPosAnim();
        }
    }
    public void HeroPosAnim()
    {
        HeroPos = transform.position;
        float newX = transform.position.x;
        float newY = transform.position.y;
        if (Direction == 1 && newY != 4.5f) newY++;// Up
        if (Direction == 2 && newY != -4.5f) newY--; // Down
        if (Direction == 3 && newX != -4.5f) newX--; // Left
        if (Direction == 4 && newX != 4.5f) newX++; // Right
        transform.position = new Vector3(newX, newY);
    }
}
