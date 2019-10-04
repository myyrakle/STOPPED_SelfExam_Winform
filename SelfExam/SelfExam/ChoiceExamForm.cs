using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SelfExam
{
    public partial class ChoiceExamForm : Form
    {
        public ChoiceExamForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //사이즈 고정하기
        }

        private void ChoiceFileButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "json 파일 (*.json) | *json; | 모든 파일 (*.*) | *.*";

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                FilenameTextBox.Text = dialog.FileName;           
        }

        public void SetFilenameTextBox(String s)
        {
            FilenameTextBox.Text = s;
        }

        private void TestStartButton_Click(object sender, EventArgs e)
        {
            if(FilenameTextBox.Text == "")
            {
                MessageBox.Show("파일이 선택되지 않았습니다.");
                return;
            }

            var reader = new StreamReader(FilenameTextBox.Text);
            var json_text = reader.ReadToEnd();
            reader.Close();

            var json_object = JObject.Parse(json_text);
            var json_array = json_object.GetValue("data");

            var question_list = new List<QuestionType>();
            foreach (JObject obj in json_array)
            {
                question_list.Add(new QuestionType(
                    obj.GetValue("q").ToString(), 
                    obj.GetValue("a").ToString()
                )) ;
            }

            if (RandomCheckBox.Checked)
            {
                question_list.Shuffle();
            }

            var test_form = new TestExamForm();
            test_form.SetRepeatFlag(RepeatCheckBox.Checked);
            test_form.SetQuestionList(question_list);
            test_form.Show();

            this.Close();
        }
    }

    public struct QuestionType
    {
        public String Question;
        public String Answer;
        public QuestionType(String q, String a)
        {
            Question = q;
            Answer = a;
        }
    }

    static class IListExtension
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            var randomer = new Random();

            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = randomer.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
