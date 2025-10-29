using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public event Action OnMainMenu;
    public event Action OnItemMenu;
    public event Action OnARPosition;

    private static GameManager instance;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        MainMenu();
    }

    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("Main Menu event invoked");
    }

    public void ItemsMenu()
    {
        OnItemMenu?.Invoke();
        Debug.Log("Item Menu event invoked");
    }

    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("AR Position event invoked");
    }

    public void CloseAPP()
    {
        Application.Quit();
    }
}

