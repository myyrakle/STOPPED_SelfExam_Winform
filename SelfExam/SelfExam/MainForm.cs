using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SelfExam
{
    public partial class SelfExam : Form
    {
        public SelfExam()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //사이즈 고정하기
        }

        private void CreateNewExamButton_Click(object sender, EventArgs e)
        {
            var form = new CreateExamForm();
            form.Show();
        }

        private void OpenExamButton_Click(object sender, EventArgs e)
        {
            var form = new ChoiceExamForm();
            form.Show();
        }

        private void EditExamButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "json 파일 (*.json) | *json; | 모든 파일 (*.*) | *.*";

            var result = dialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                var reader = new StreamReader(dialog.FileName);
                var json_object = JObject.Parse(reader.ReadToEnd());
                reader.Close();

                var form = new CreateExamForm();
                form.SetJObject(json_object);
                form.Show();
            }
            else
            {

            }
        }
    }
}