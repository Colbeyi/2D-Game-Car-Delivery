using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Vector3 follower;
    
    void Start()
    {
        follower = transform.position - player.transform.position;
        
    }

    
    void Update()
    {
        transform.position = player.transform.position + follower;
        
    }
}
