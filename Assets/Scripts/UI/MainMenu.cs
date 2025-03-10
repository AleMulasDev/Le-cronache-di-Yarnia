using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Transform loadContentRoot;
    [SerializeField] private LoadButton loadButton;
    [SerializeField] private GameObject dataAlreadyExists;
    [SerializeField] private TMP_InputField inputField;

    private string _path;

    public string GetInputText()
    {
        return inputField.text;
    }

    public void Start()
    {
        foreach (Transform child in loadContentRoot)
            Destroy(child.gameObject);

        _path = Application.persistentDataPath;

        string[] files = Directory.GetFiles(_path);

        foreach(string file in files)
        {
            LoadButton button = Instantiate(loadButton, loadContentRoot);
            button.SetButton(file);
        }

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ShowDataAlreadyExists()
    {
        dataAlreadyExists.SetActive(true);
    }

    public void NewGame()
    {
        GameManager.Instance.NewGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
