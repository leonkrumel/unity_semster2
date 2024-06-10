using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    private Playerinputs playercontroles;
    //greifft auf das neue input system im "menu" ordner zu
    private InputAction menu;

    [SerializeField] private GameObject pauseUI;
    [SerializeField] private bool isPaused;
    
    [SerializeField] private Button ExittoMenuBUtton;
    [SerializeField] private Button ContinueBUtton;
    [SerializeField] private Button SettingsBUtton;
    [SerializeField] private string nameMenuScene;
    
    // Start is called before the first frame update
    void Awake()
    {
        ExittoMenuBUtton.onClick.AddListener(backtomenu);
        ContinueBUtton.onClick.AddListener(DeactivateMenu);
        playercontroles = new Playerinputs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        menu = playercontroles.interactions.pausegame;
        menu.Enable();

        menu.performed += Pause;
    }

    private void OnDisable()
    {
        menu.Disable();
    }

    void Pause(InputAction.CallbackContext context)
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }

    }

    void ActivateMenu()
    {
        Time.timeScale = 0;
        pauseUI.SetActive(true);
    }

     public void DeactivateMenu()
    {
        Time.timeScale = 1;
        pauseUI.SetActive(false);
        isPaused = false;
    }
    void backtomenu()
    {
        //loadmainmenu
        SceneManager.LoadScene(nameMenuScene);
    }
}
