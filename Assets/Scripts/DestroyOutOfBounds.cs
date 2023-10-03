using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float _topBound = 30;
    private float _sideBound = 30;
    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > _topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < -_topBound)
        {
            _gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x > _sideBound) 
        {
            _gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x < -_sideBound)
        {
            _gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
