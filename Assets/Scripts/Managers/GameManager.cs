using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.LoadScene("Inventory", LoadSceneMode.Additive);
    }
}
