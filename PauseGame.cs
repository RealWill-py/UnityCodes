using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f; // Define o timescale para 0 para pausar o jogo
    }

    void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f; // Define o timescale de volta para 1 para retomar o jogo
    }
}
//Will.py
