using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlayerColisiones : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver();
    }
    public void gameOver()
    {
        SceneManager.LoadScene(0);
    }
}
