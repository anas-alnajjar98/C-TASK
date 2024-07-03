using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPTaskForm_7_3_2024_
{
    public partial class FormInput : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submitButton_Click(object sender, EventArgs e)
        {
            string name = firstName.Text;
            string id = InputID.Text;
            string email = InputEmail.Text;
            string gender = "";
            List<string> selectedSubjects = new List<string>();

            foreach (ListItem item in genderList.Items)
            {
                if (item.Selected)
                {
                    gender = item.Text;
                }
            }
            foreach (ListItem item in CheckBoxListSubjects.Items)
            {
                if (item.Selected)
                {
                    string[] subjects = item.Text.Split(',');
                    selectedSubjects.AddRange(subjects);
                }
            }
            NameFrom.Text = name;
            EmailForm.Text = email;
            IDForm.Text = id;
            GenderFrom.Text = gender;
            SubjectsForm.Text = string.Join(", ", selectedSubjects);
        }
    }
}