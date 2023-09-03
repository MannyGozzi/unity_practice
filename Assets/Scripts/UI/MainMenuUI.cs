using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        playButton.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.KitchenScene);
        });
        quitButton.onClick.AddListener(() =>
        {
            Application.Quit(); // doesn't do anything in editor but is working
        });
        Time.timeScale = 1f;
    }

}
