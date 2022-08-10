using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    [SerializeField] Color32 packageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noneColor = new Color32(1, 1, 1, 1);

    bool pick_up = false;
    private float destroyDelay = 0.6f;
    SpriteRenderer changeColor;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("That's hurt!");

    }
    void Start()
    {
        changeColor = GetComponent<SpriteRenderer>();
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !pick_up)
        {
            pick_up = true;
            Debug.Log("Package is load!");
            changeColor.color = packageColor;
            Destroy(collision.gameObject, destroyDelay);
            
        }
        if (collision.tag == ("DeliveryPoint") && pick_up)
        {
            Debug.Log("Package is delivered!");
            pick_up = false;
            changeColor.color = noneColor;
        }
    }
}
