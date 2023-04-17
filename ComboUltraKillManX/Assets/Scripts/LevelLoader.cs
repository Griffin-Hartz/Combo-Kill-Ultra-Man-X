using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Button StartButton;
    // Start is called before the first frame update

    private void Start()
    {
        StartButton.onClick.AddListener(LoadGame);
    }

    private void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}
