using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D col)
    {
        print("Тут может быть любая надпись");
        if (col.tag == "Player")
        {
            Debug.Log("Игрок");
        }
    }


}
