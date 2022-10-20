using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Meow : MonoBehaviour
{
    // public variables
    public int meowScore = 0;
    public int num = 1;
    //„«œ—Ì ‘”„ÌÂ
    public TextMeshProUGUI MeowCount;
    // Functions
    public void click()
    {
        if (meowScore < 14)
        {
            meowScore += num;
            MeowCount.text = $"Meow : {meowScore}";
        }
        else if (meowScore < 50)
        {
            meowScore += num;
            MeowCount.text = $"You Are Bothering Me !!!!! MEOW : {meowScore}";
        }
        else if (meowScore >= 50)
        {
            MeowCount.text = "I Got Angry, I WILL AVENGE MY TIRENESS IN THE NEXT CLASSWORK, give me the toy!";
        }
            }
    public void doubleScore () {
        num += 1;
        meowScore += num;
        MeowCount.text = $"I Like it, ty <3, Meow : {meowScore}";
    }
    





    //$"Meow Count: {meowScore}"
    //$"You Are Bothering Me !!!!! MEOW COUNT : {meowScore}"
    //"I Got Angry, I WILL AVENGE MY TIRENESS IN THE NEXT CLASSWORK"



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
