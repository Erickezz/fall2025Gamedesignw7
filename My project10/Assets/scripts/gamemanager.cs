using NUnit.Framework;
using TMPro;
using UnityEngine;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;

public class gameengine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created



    //variables

    
   public TextMeshProUGUI teststack;
    public TextMeshProUGUI textqueue;
    private TextMeshProUGUI TextMeshPro;

    //Make a list, thats empty and hold strings
    private List<string> foodlist = new List<string>();

    //Make a stack of things, last in, first out!
    private Stack<string> foodstack = new Stack<string>();

    //Make a Queque of strings
    private Queue <string> foodqueue = new Queue<string>();

    //Make another Queue, whiles hes in bano
    private Queue<string> ahhhh = new Queue<string>();

    //Make a second stack of strings 
    private Stack<string>liststack = new Stack<string>();

    public InputActionReference interactstack;

    public InputActionReference interactqueue;


    //Make Array
    private string[] Food = new string[6] {"Carrot", "Apple", "Peas", "Leaks", "Cereal", "Tree" };

    void Start()
    {
        //Add the strings in the Array to the list 
        foodlist.AddRange(Food);

        for (int i = 0; Food.Length > i; i++)
        {
            foodstack.Push(Food[i]);
        }
        Debug.Log(foodstack.Count);
       
        for (int i = 0; i <foodlist.Count; i++)
        {
            liststack.Push(foodlist[i]);
        }

        //foreach loop using the array to make a queue 
        foreach (string s in Food)
        {
            foodqueue.Enqueue(s); 
        }
        //LPrint length of strings in the queue
        Debug.Log(foodqueue.Count);

        foreach (string s in foodlist)
        {
            ahhhh.Enqueue(s);
        }
        Debug.Log(ahhhh.Count);
        Debug.Log(ahhhh.Dequeue());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
