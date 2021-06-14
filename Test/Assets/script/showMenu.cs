using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class showMenu : MonoBehaviour
{
    public GameObject Menu;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Menu.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("Y");
        }
    }
    public void closeMenu()
    {
        Time.timeScale = 1f;
        Menu.SetActive(false);
    }
    public void ReLoad()
    {
        Time.timeScale = 1f;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
