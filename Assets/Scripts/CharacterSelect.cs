using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    [SerializeField] private GameObject[] Characters;

    private int selectedCharacter = 0;
    void Start()
    {
        foreach (GameObject ch in Characters)
        {
            ch.SetActive(false);
        }
        Characters[selectedCharacter].SetActive(true);
    }

    public void ChangeCharacter(int newCharacter)
    {
        Characters[selectedCharacter].SetActive(false);
        Characters[newCharacter].SetActive(true);
        selectedCharacter = newCharacter;
    }
}
