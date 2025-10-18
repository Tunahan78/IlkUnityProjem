using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private TMP_Text _gameOverText;
    [SerializeField] private Transform _playerTransform;

    private bool _isGameOver = false;

    void Start()
    {
        _gameOverText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (_isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                RestartGame();
            }
            return;
        }

        if (_playerTransform.position.y < -1f || _playerMovement.enabled == false) 
        {
            GameOver();
            
        }
    }
    private void GameOver()
    {
        _gameOverText.gameObject.SetActive(true);
        _isGameOver = true;

    }
    private void RestartGame()
    {
          UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    
    }





}
