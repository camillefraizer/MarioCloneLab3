using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    [SerializeField] private float upLimit;
    [SerializeField] private float distanceToMove = 10f;
    private float startPosition;
    private Vector3 direction = Vector3.up;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position.y;
        upLimit = startPosition + distanceToMove;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime); 
        
        if (transform.position.y >= upLimit) {
            direction = Vector3.down;
        } else if (transform.position.y <= startPosition) {
            direction = Vector3.up; 
        }
        
    }
}
