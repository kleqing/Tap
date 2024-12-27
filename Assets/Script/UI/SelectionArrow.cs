using System;
using UnityEngine;
using UnityEngine.UI;

public class SelectionArrow : MonoBehaviour
{
    private RectTransform rectTransform;
    [SerializeField] private RectTransform[] options;
    private int currentOption;
    
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            ChangePosition(-1);
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            ChangePosition(1);
        }
        
        //* Interaction with the selected option
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            //* Interact
        }
    }

    private void ChangePosition(int _change)
    {
        currentOption += _change;

        if (currentOption < 0)
        {
            currentOption = options.Length - 1;
        }
        else if (currentOption >= options.Length - 1)
        {
            currentOption = 0;
        }
        rectTransform.position = new Vector3(rectTransform.position.x, options[currentOption].position.y, 0);
    }
    
    //* Interaction with the selected option
    private void Interact()
    {
        //* Interact
        options[currentOption].GetComponent<Button>().onClick.Invoke();
    }
}
