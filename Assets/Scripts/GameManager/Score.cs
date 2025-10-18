using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private TMP_Text scoreText;

    private float startZ;

    void Awake()
    {
        startZ = player.position.z;
    }

    void Update()
    {
        int score = Mathf.FloorToInt(player.position.z - startZ);
        scoreText.text = "Score: " + score.ToString();
    }



}
