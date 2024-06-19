using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMANAGER : MonoBehaviour
{
    public GameObject[] cubes;
    public int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ActivateAll();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            DeactivateAll();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentIndex < cubes.Length)
            {
                DeactivateAll();
                ActivateByIndex(currentIndex);
                currentIndex++;
            }
            else
            {
                currentIndex = 0;
                DeactivateAll();
                ActivateByIndex(currentIndex);
                currentIndex++;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            if (currentIndex >= 0)
            {
                DeactivateAll();
                ActivateByIndex(currentIndex);

            }
            else
            {
                currentIndex = cubes.Length - 1;
                DeactivateAll();
                ActivateByIndex(currentIndex);

            }
        }
        void DeactivateAll()
        {
            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[i].SetActive(false);
            }

        }
        void ActivateAll()
        {
            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[i].SetActive(true);
            }
        }
        void ActivateByIndex(int index)
        {
            cubes[index].SetActive(true);
        }
    }
}