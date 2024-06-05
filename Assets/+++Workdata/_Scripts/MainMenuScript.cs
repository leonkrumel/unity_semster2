using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] private CanvasGroup mainpanel;
    [SerializeField] private Button startnewGamebutton;
    [SerializeField] private Button levelselectionbutton;
    
    [SerializeField] private CanvasGroup levelSelectionPanel;
    [SerializeField] private Button level1button;
    [SerializeField] private Button level2button;
    [SerializeField] private Button level3button;
    [SerializeField] private Button quitlevelselectionbutton;
    
    [SerializeField] private Button QUitgamebutton;
    
    [SerializeField] private string nameNextScene1;
    [SerializeField] private string nameNextScene2;
    [SerializeField] private string nameNextScene3;
    // Start is called before the first frame update
    void Start()
    {
        levelSelectionPanel.HideCanvasGroup();
        startnewGamebutton.onClick.AddListener(LoadLevel1);
        levelselectionbutton.onClick.AddListener(openLevelPanel);
        quitlevelselectionbutton.onClick.AddListener(closeLevelPanel);
        level1button.onClick.AddListener(LoadLevel1);
        level2button.onClick.AddListener(LoadLevel2);
        level3button.onClick.AddListener(LoadLevel3);
        QUitgamebutton.onClick.AddListener(quitgame);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void closeLevelPanel()
    {
        levelSelectionPanel.HideCanvasGroup();
        mainpanel.ShowCanvasGroup();
    }
    void openLevelPanel()
    {
        levelSelectionPanel.ShowCanvasGroup();
        mainpanel.ShowCanvasGroup();
    }
    
    void LoadLevel1()
    {
        //loadnextlevel
        SceneManager.LoadScene(nameNextScene1);
    }
   
    void LoadLevel2()
    {
        //loadnextlevel
        SceneManager.LoadScene(nameNextScene2);
    }
    
    void LoadLevel3()
    {
        //loadnextlevel
        SceneManager.LoadScene(nameNextScene3);
    }
    public void quitgame()
    {
        Application.Quit();
        Debug.Log(message:"gameclosed");
    }
}
