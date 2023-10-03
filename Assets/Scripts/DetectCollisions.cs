using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour

{
    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Food"))
        {
            this.GetComponent<AnimalHunger>().FeedAnimal(1);
        }
        
    }
}
