using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfExam
{
    public partial class TestExamForm : Form
    {
        public TestExamForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //사이즈 고정하기
        }

        private bool repeat = false;
        public void SetRepeatFlag(bool b)
        {
            repeat = b;
        }

        private bool random = false;
        public void SetRandomFlag(bool b)
        {
            random = b;
        }

        private List<QuestionType> question_list;
        private List<QuestionType>.Enumerator enumerator;
        private uint current_position = 0;
        public void SetQuestionList(List<QuestionType> list)
        {
            question_list = list;
            enumerator = question_list.GetEnumerator();
            if (enumerator.MoveNext())
            { }
            else
            {
                state = State.NoMoreQuestion;
            }
        }
        
        private void RenderQuestion()
        {
            AnswerTextBox.Text = "";
            QuestionTextBox.Text = enumerator.Current.Question;
            state = State.ShowQuestion;

            current_position++;
            RenderCurrnetPageView();
        }
        private void RenderAnswer()
        {
            AnswerTextBox.Text = enumerator.Current.Answer;
            state = State.ShowAnswer;
        }

        private void RenderCurrnetPageView()
        {
            CurrentPageViewLabel.Text = $"{current_position}/{question_list.Count}";
        }

        enum State
        {
            None, 
            ShowQuestion,
            ShowAnswer,
            NoMoreQuestion
        }
        private State state = State.None;
        private void NextButton_Click(object sender, EventArgs e)
        {
            switch(state)
            {
                case State.None:
                    RenderQuestion();
                    break;

                case State.ShowQuestion:
                    RenderAnswer();
                    break;

                case State.ShowAnswer:
                    if(enumerator.MoveNext())
                    {
                        RenderQuestion();
                    }
                    else
                    {
                        if(repeat)
                        {
                            
                            question_list.Shuffle();
                            enumerator = question_list.GetEnumerator();
                            state = State.None;
                        }
                        else
                        {
                            state = State.NoMoreQuestion;
                            MessageBox.Show("문제가 더 없습니다.");
                        }
                    }
                    break;

                case State.NoMoreQuestion:
                    MessageBox.Show("문제가 더 없습니다.");
                    break;
            }
        }

        private void TestExamForm_Load(object sender, EventArgs e)
        {
            NextButton_Click(sender, e);
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
