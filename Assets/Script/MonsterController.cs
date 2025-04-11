using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public ScoreManager Score;

    private void Start()
    {
        Score = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DestroyWall"))
        {
            Destroy(this.gameObject);
        }

        if (other.CompareTag("Weapon"))
        {
            Destroy(this.gameObject);
            Score.score += 100;
        }
    }

}
