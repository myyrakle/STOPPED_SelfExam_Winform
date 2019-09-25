using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace SelfExam
{
    public partial class CreateExamForm : Form
    {
        public CreateExamForm()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            switch(mode)
            {
                case Mode.Create:
                    AddNewQuestion();
                    break;

                case Mode.Edit:
                    break;
            }
        }

        public enum Mode
        {
            Create,
            Edit
        }

        private Mode mode = Mode.Create;
        public void SetJObject(JObject json_object)
        {
            this.mode = Mode.Edit;

            ExamNameTextBox.Text = json_object.GetValue("exam_name").ToString();

            var json_array = new JArray(json_object.GetValue("data"));
            foreach(JObject e in json_array)
            {
                question_list.AddLast(
                    new QuestionType(e.GetValue("q").ToString(), 
                                    e.GetValue("a").ToString())
                );
            }
        }

        private LinkedList<QuestionType> question_list = new LinkedList<QuestionType>();
        private LinkedListNode<QuestionType> current_node = null;
        
        private void SaveCurrentTextBoxes()
        {
            if (current_node == null)
                return;

            current_node.Value = new QuestionType(AnswerTextBox.Text, QuestionTextBox.Text);
        }

        private void TogglePrevButton()
        {
            PrevButton.Enabled = current_node.Previous != null;
        }
        private void ToggleNextButton()
        {
            NextButton.Enabled = current_node.Next != null;
        }

        private void RenderCurrent()
        {
            AnswerTextBox.Text = current_node.Value.Answer;
            QuestionTextBox.Text = current_node.Value.Question;

            ToggleNextButton();
            TogglePrevButton();
        }

        private void AddNewQuestion()
        {
            SaveCurrentTextBoxes();

            question_list.AddLast(new QuestionType("", ""));
            current_node = question_list.Last;

            RenderCurrent();
        }
        
        private void NextQuestion()
        {
            SaveCurrentTextBoxes();

            if (current_node.Next == null)
            {
                MessageBox.Show("더 없습니다.");
                return;
            }

            current_node = current_node.Next;

            RenderCurrent();
        }
        private void PrevQuestion()
        {
            SaveCurrentTextBoxes();

            if (current_node.Previous == null)
            {
                MessageBox.Show("더 없습니다.");
                return;
            }

            current_node = current_node.Previous;

            RenderCurrent();
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            AddNewQuestion();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            SaveCurrentTextBoxes();

            JObject json_object = new JObject();
            json_object.Add("exam_name", ExamNameTextBox.Text);

            var questions_array = new JArray();
            
            foreach(var i in question_list)
            {
                var obj = new JObject();
                obj.Add("q", i.Question);
                obj.Add("a", i.Answer);

                questions_array.Add(obj);
            }
            json_object.Add("data", questions_array);

            var dialog = new SaveFileDialog();
            dialog.Filter = "json 파일 (*.json) | *json; | 모든 파일 (*.*) | *.*";
            var result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                var writer = new StreamWriter(dialog.FileName);
                writer.Write(json_object.ToString());
                writer.Close();

                var yes_no = MessageBox.Show("바로 시험을 시작하시겠습니까?", "궱둟셙렪", MessageBoxButtons.YesNo);

                if(yes_no == DialogResult.Yes)
                {
                    var choice_form = new ChoiceExamForm();
                    choice_form.SetFilenameTextBox(dialog.FileName);
                    choice_form.Show();
                }

                this.Close();
            }
            else
            {
                return;
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            PrevQuestion();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }        
    }
}