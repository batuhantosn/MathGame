using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Math : MonoBehaviour
{
    public Text firstNumber, secondNumber, Maths, Answer, Case;
    public InputField answerInp;
    int number1, number2, maths;
    int result;
    void Start()
    {
        NewQuestion();
    }

    void Update()
    {
        
    }
    public void Control()
    {
        if (int.Parse(Answer.text) == result)
        {
            Case.text = "DOGRU";
        }
        else
            Case.text = "YANLIS";
    }
    public void NewQuestion()
    {
        Case.text = "";
        answerInp.text = "";
        number1 = Random.Range(1, 10);
        number2 = Random.Range(1, 10);
        maths = Random.Range(1, 5);
        switch (maths)
        {
            case 1:
                Maths.text = "+";
                result = number1 + number2;
                break;
            case 2:
                Maths.text = "-";
                result = number1 - number2;
                break;
            case 3:
                Maths.text = "x";
                result = number1 * number2;
                break;
            case 4:
                Maths.text = "/";
                result = number1 / number2;
                break;
        }
        firstNumber.text = number1 + "";
        secondNumber.text = number2 + "";
    }
}
