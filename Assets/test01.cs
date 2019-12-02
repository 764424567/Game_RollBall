using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

enum Status
{
    win,//1
    one,//3
    two,//8
    three,//24
    four,//72
    five,//216
    six,//648
    seven,//1944
    eight,//5832
    nine,//17496
    ten,//52488
    eleven,//157464
    twelve//472392
}

public class test01 : MonoBehaviour
{
    public Text num1;
    public Text num2;
    public Text num3;
    public Text result;
    public Text score;
    public Text Total;
    public Button button;
    public float totalInt;
    public InputField input;
    public Dropdown drop;

    private int numInt1;
    private int numInt2;
    private int numInt3;
    private int TotalNum;
    private float scoreInt;
    private int inputInt = 1;
    bool IsDa = true;
    public int CycleIndex;
    Status m_status = Status.win;
    private string show;
    private int[] m_Count;

    void Start()
    {
        button.onClick.AddListener(AutoButton);
        num1.text = "0";
        num2.text = "0";
        num3.text = "0";
        result.text = "0";
        score.text = "0";
        Total.text = totalInt.ToString();
        //初始化
        m_Count = new int[13];
        for (int i = 0; i < m_Count.Length; i++)
        {
            m_Count[i] = 0;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (IsDa)
            {
                drop.captionText.text = "大";
                IsDa = false;
            }
            else
            {
                drop.captionText.text = "小";
                IsDa = true;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (IsDa)
            {
                drop.captionText.text = "大";
                IsDa = false;
            }
            else
            {
                drop.captionText.text = "小";
                IsDa = true;
            }
        }
    }

    public void AutoButton()
    {
        for (int i = 0; i < CycleIndex; i++)
        {
            //cut
            if (drop.captionText.text.Equals("小"))
            {
                drop.captionText.text = "大";
            }
            else
            {
                drop.captionText.text = "小";
            }
            //judge
            switch (m_status)
            {
                case Status.win:
                    inputInt = 1;
                    m_Count[0] += 1;
                    break;
                case Status.one:
                    inputInt = 3;
                    m_Count[1] += 1;
                    break;
                case Status.two:
                    inputInt = 8;
                    m_Count[2] += 1;
                    break;
                case Status.three:
                    inputInt = 24;
                    m_Count[3] += 1;
                    break;
                case Status.four:
                    inputInt = 72;
                    m_Count[4] += 1;
                    break;
                case Status.five:
                    inputInt = 216;
                    m_Count[5] += 1;
                    break;
                case Status.six:
                    inputInt = 648;
                    m_Count[6] += 1;
                    break;
                case Status.seven:
                    inputInt = 1944;
                    m_Count[7] += 1;
                    break;
                case Status.eight:
                    inputInt = 5832;
                    m_Count[8] += 1;
                    break;
                case Status.nine:
                    inputInt = 17496;
                    m_Count[9] += 1;
                    break;
                case Status.ten:
                    inputInt = 52488;
                    m_Count[10] += 1;
                    break;
                case Status.eleven:
                    inputInt = 157464;
                    m_Count[11] += 1;
                    break;
                case Status.twelve:
                    inputInt = 472392;
                    m_Count[12] += 1;
                    break;
                default:
                    break;
            }
            totalInt -= inputInt;
            numInt1 = Random.Range(1, 6);
            numInt2 = Random.Range(1, 6);
            numInt3 = Random.Range(1, 6);
            num1.text = numInt1.ToString();
            num2.text = numInt2.ToString();
            num3.text = numInt3.ToString();
            TotalNum = numInt1 + numInt3 + numInt3;
            if (TotalNum < 10)
            {
                result.text = "小";
                if (drop.captionText.text.Equals("小"))
                {
                    show = "中";
                    scoreInt = inputInt * 1.97f;
                    totalInt += scoreInt;
                    score.text = scoreInt.ToString();
                    m_status = Status.win;
                }
                else
                {
                    show = "不中";
                    score.text = "0";
                    scoreInt = 0;
                    if (m_status == Status.one)
                    {
                        m_status = Status.two;
                    }
                    else if (m_status == Status.two)
                    {
                        m_status = Status.three;
                    }
                    else if (m_status == Status.three)
                    {
                        m_status = Status.four;
                    }
                    else if (m_status == Status.four)
                    {
                        m_status = Status.five;
                    }
                    else if (m_status == Status.five)
                    {
                        m_status = Status.six;
                    }
                    else if (m_status == Status.six)
                    {
                        m_status = Status.seven;
                    }
                    else if (m_status == Status.seven)
                    {
                        m_status = Status.eight;
                    }
                    else if (m_status == Status.eight)
                    {
                        m_status = Status.nine;
                    }
                    else if (m_status == Status.nine)
                    {
                        m_status = Status.ten;
                    }
                    else if (m_status == Status.ten)
                    {
                        m_status = Status.eleven;
                    }
                    else if (m_status == Status.eleven)
                    {
                        m_status = Status.twelve;
                    }
                    else
                    {
                        m_status = Status.one;
                    }
                }
            }
            else
            {
                result.text = "大";
                if (drop.captionText.text.Equals("大"))
                {
                    show = "中";
                    scoreInt = inputInt * 1.97f;
                    totalInt += scoreInt;
                    score.text = scoreInt.ToString();
                    m_status = Status.win;
                }
                else
                {
                    show = "不中";
                    score.text = "0";
                    scoreInt = 0;
                    if (m_status == Status.one)
                    {
                        m_status = Status.two;
                    }
                    else if (m_status == Status.two)
                    {
                        m_status = Status.three;
                    }
                    else if (m_status == Status.three)
                    {
                        m_status = Status.four;
                    }
                    else if (m_status == Status.four)
                    {
                        m_status = Status.five;
                    }
                    else if (m_status == Status.five)
                    {
                        m_status = Status.six;
                    }
                    else if (m_status == Status.six)
                    {
                        m_status = Status.seven;
                    }
                    else if (m_status == Status.seven)
                    {
                        m_status = Status.eight;
                    }
                    else if (m_status == Status.eight)
                    {
                        m_status = Status.nine;
                    }
                    else if (m_status == Status.nine)
                    {
                        m_status = Status.ten;
                    }
                    else if (m_status == Status.ten)
                    {
                        m_status = Status.eleven;
                    }
                    else if (m_status == Status.eleven)
                    {
                        m_status = Status.twelve;
                    }
                    else
                    {
                        m_status = Status.one;
                    }
                }
            }
            Debug.Log(num1.text + "," + num2.text + "," + num3.text + "," + result.text + "," + show + "," + scoreInt + "," + m_status + "," + totalInt.ToString());
            Total.text = totalInt.ToString();
        }
        for (int i = 0; i < m_Count.Length; i++)
        {
            Debug.Log(i+","+m_Count[i]);
        }
    }

    public void ButtonOnClick()
    {
        inputInt = int.Parse(input.text);
        totalInt -= inputInt;
        numInt1 = Random.Range(1, 6);
        numInt2 = Random.Range(1, 6);
        numInt3 = Random.Range(1, 6);
        num1.text = numInt1.ToString();
        num2.text = numInt2.ToString();
        num3.text = numInt3.ToString();
        TotalNum = numInt1 + numInt3 + numInt3;
        if (TotalNum < 10)
        {
            result.text = "小";
            if (drop.captionText.text.Equals("小"))
            {
                scoreInt = inputInt * 1.97f;
                totalInt += scoreInt;
                score.text = scoreInt.ToString();
            }
            else
            {
                score.text = "0";
            }
        }
        else
        {
            result.text = "大";
            if (drop.captionText.text.Equals("大"))
            {
                scoreInt = inputInt * 1.97f;
                totalInt += scoreInt;
                score.text = scoreInt.ToString();
            }
            else
            {
                score.text = "0";
            }
        }
        Debug.Log(num1.text + "," + num2.text + "," + num3.text + "," + result.text);
        Total.text = totalInt.ToString();
    }
}
