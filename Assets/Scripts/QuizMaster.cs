using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class QuizMaster : MonoBehaviour
{

    [System.Serializable]
    public class QuestionClass {
        public int id;
        public string question;
        public string choiceA;
        public string choiceB;
        public string choiceC;
        public string choiceD;
        public string answer;
        public string imagepath;
    }

    [System.Serializable]
    public class QuestionList{
        public QuestionClass[] questions;
    }

    [SerializeField]
    private TextMeshProUGUI q_number;

    [SerializeField]
    private TextMeshProUGUI q_txt;

    [SerializeField]
    private TextMeshProUGUI choiceAtxt;
    
    [SerializeField]
    private TextMeshProUGUI choiceBtxt;

    [SerializeField]
    private TextMeshProUGUI choiceCtxt;

    [SerializeField]
    private TextMeshProUGUI choiceDtxt;

    [SerializeField]
    private TextMeshProUGUI pointstxt;

    [SerializeField]
    private RawImage background;

 
    private Texture image;

    public QuestionList q = new QuestionList();
    


    public string filename = "Assets/Questions.json";
    public int points = 0;
    public int total = 0;
    public int endgame = 5;
    private int questionId = 0;
    private int selected = 0;
    private int correct;   

  

    // Start is called before the first frame update
    void Start()
    {
       // q_txt = GameObject.GetComponent<TMP_Text>();
        loadQuestion(questionId);
    }

    // Update is called once per frame
    void Update()
    {
        
        selected = getAnswer();
        if(selected != 0){

            //confirm answer?
       
            total++;
            if(selected == correct){

                points++;
           
                //print correct

            }
            else {
                //print wrong
            }
            pointstxt.text = "Points: " + points + " / " + total;
            selected = 0;
            //sleep (2)

            if(total <= endgame){
                loadQuestion(++questionId);
            }
            else {
                finishGame();
            }
        }
    }

  

    public void setAnswer(int val)
    {
        this.selected = val;
    }
    public int getAnswer()
    {
        return selected;
    }



    void finishGame(){

    }

    void loadQuestion(int questionId){
        
        string jsonString = File.ReadAllText(filename); //load questions
        q = JsonUtility.FromJson<QuestionList>(jsonString);

        q_number.text = "Question no." + (total+1);
        q_txt.text = q.questions[questionId].question;    //update question text
        choiceAtxt.text = q.questions[questionId].choiceA;   //update answers
        choiceBtxt.text = q.questions[questionId].choiceB;
        choiceCtxt.text = q.questions[questionId].choiceC;
        choiceDtxt.text = q.questions[questionId].choiceD;

        if(q.questions[questionId].answer.Equals("A")){       //update correct
            correct = 1;
        }
        else if(q.questions[questionId].answer.Equals("B")){
            correct = 2;
        }
        else if(q.questions[questionId].answer.Equals("C")){
            correct = 3;
        }
        else if(q.questions[questionId].answer.Equals("D")){
            correct = 4;
        }

        image = Resources.Load<Texture>(q.questions[questionId].imagepath);
        
        background.texture = image;
        
 
    }




}
