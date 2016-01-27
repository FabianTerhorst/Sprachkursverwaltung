using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sprachkursverwaltung
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            updateUI();
        }

        private void updateUI()
        {
            languages.Items.Clear();
            members.Items.Clear();
            courses.Items.Clear();
            foreach (Language language in SprachkursApplication.Instance.languages)
            {
                languages.Items.Add(language.name);
            }
            foreach (Member member in SprachkursApplication.Instance.members)
            {
                members.Items.Add(member.name);
            }
            foreach (Course course in SprachkursApplication.Instance.courses)
            {
                courses.Items.Add(course.name);
            }
        }

        private void courseAdd_Click(object sender, EventArgs e)
        {
            SprachkursApplication.Instance.addCourse(languages.SelectedIndex);
            updateUI();
        }

        private void memberAdd_Click(object sender, EventArgs e)
        {
            SprachkursApplication.Instance.addMember(memberName.Text);
            updateUI();
        }

        private void members_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(members.SelectedItems != null && members.SelectedItems.Count > 0)
            {
                editBoxMembers.Text = members.SelectedItems[0].Text;
            }
        }

        private void courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courses.SelectedItems != null && members.SelectedItems.Count > 0)
            {
                editBoxMembers.Text = courses.SelectedItems[0].Text;
            }
        }

        private void saveMember_Click(object sender, EventArgs e)
        {
            if (members.SelectedItems != null)
            {
                Member member = SprachkursApplication.Instance.members[members.SelectedIndices[0]];
                SprachkursApplication.Instance.editMember(member.id, editBoxMembers.Text);
                updateUI();
            }
        }

        private void saveCourse_Click(object sender, EventArgs e)
        {
            if (courses.SelectedItems != null)
            {
                Course course = SprachkursApplication.Instance.courses[courses.SelectedIndices[0]];
                SprachkursApplication.Instance.editCourse(course.id, Int32.Parse(editBoxCourses.Text));
                updateUI();
            }
        }
    }
}
