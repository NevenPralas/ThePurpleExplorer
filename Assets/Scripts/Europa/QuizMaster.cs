using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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

[SerializeField]
    public GameObject rules;
[SerializeField]
    public GameObject totem;
    public GameObject vitrina;
    private Texture image;

    public QuestionList q = new QuestionList();

    public string filename = "Assets/Questions.json";
    public int points = 0;
    public int total = 0;
    public int endgame = 10;
    private int questionId = 0;
     [SerializeField]
    private int selected = 0;
    private int correct;   

  
    private List<Animator> animators;
    // Start is called before the first frame update
    void Start()
    {
       // q_txt = GameObject.GetComponent<TMP_Text>();
       
        GameObject[] audience = GameObject.FindGameObjectsWithTag("Survivor");
        animators = new List<Animator>();
        foreach(var character in audience){
            animators.Add(character.GetComponent<Animator>());
        }
        
        loadQuestion(questionId);
    }

    // Update is called once per frame
    void Update()
    {
        
        selected = getAnswer();
        if(rules.activeInHierarchy == true)
        {
            if(selected != 0){
                rules.SetActive(false);
                selected = 0;
            }
        }
        else{
            if(selected != 0){
    
            total++;
            if(selected == correct){

                points++;
                
                foreach (Animator animator in animators)
                {
                    animator.SetBool("AnsweredCorrectly", true);
                }
                    
                //print correct

            }
            else {
                //print wrong
                
                foreach (Animator animator in animators)
                {
                    animator.SetBool("AnsweredCorrectly", false);
                }
                
            }
            foreach (Animator animator in animators)
            {
                animator.SetBool("hasAnswered", true);
            }
            pointstxt.text = "Points: " + points + " / " + total;
            selected = 0;
            Invoke("stopAnim", 5);

            if(points >= 5){
                finishGame();
            }
            else if(total <= endgame)
            {
                loadQuestion(++questionId);
            }
            else{
                GlobalMemory.porazEuropa = true;
                SceneManager.LoadScene("Otok");
            }

        }}
        
    }

    void stopAnim(){
        foreach (Animator animator in animators)
            {
                animator.SetBool("hasAnswered", false);
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

        (totem.GetComponent("Grabbable") as MonoBehaviour).enabled = true;
        vitrina.SetActive(false);
        foreach (Animator animator in animators)
            {
                animator.SetBool("hasWon", true);
            }
        this.enabled = false;
    }

    void failGame(){ 

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
