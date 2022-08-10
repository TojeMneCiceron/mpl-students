using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace syap2
{
    public partial class Form1 : Form
    {
        StudentsList sl;
        XmlSerializer xs = new XmlSerializer(typeof(List<Student>));
        public Form1()
        {
            InitializeComponent();
            sl = new StudentsList();
            cbSearch.Items.Add("Имя");
            cbSearch.Items.Add("Фамилия");
            cbSearch.Items.Add("Факультет");
            sl.SearchDefault();
            CheckButtons();
        }

        public void SearchClear()
        {
            tbSearch.Text = "";
            cbSearch.SelectedItem = null;
            sl.SearchDefault();
        }

        public void tbClear()
        {
            tbName.Text = "";
            tbSurname.Text = "";
            tbFaculty.Text = "";
            tbDiploma.Text = "";
        }

        public void tbBlock(bool flag)
        {
            tbName.Enabled = flag;
            tbSurname.Enabled = flag;
            tbFaculty.Enabled = flag;
            tbDiploma.Enabled = flag;
        }

        public void CheckButtons()
        {
            bPrevious.Enabled = sl.curSt > sl.first ? true : false;
            bNext.Enabled = sl.curSt < sl.last ? true : false;
            предыдущиToolStripMenuItem.Enabled = bPrevious.Enabled;
            следующийToolStripMenuItem.Enabled = bNext.Enabled;
            if (sl.curSt < 0 || sl.last < 0)
            {
                bPrevious.Enabled = false;
                bNext.Enabled = false;
                tbBlock(false);
                bSave.Enabled = false;
                bUpgrade.Visible = false;
                редактироватьToolStripMenuItem.Enabled = false;
                удалитьToolStripMenuItem1.Enabled = false;
            }
            else
            {
                редактироватьToolStripMenuItem.Enabled = true;
                удалитьToolStripMenuItem1.Enabled = true;
            }
            if (sl.students.Count == 0)
            {
                cbSearch.Enabled = false;              
            }
            else
            {
                cbSearch.Enabled = true;
            }
        }

        public void CreateEditMode_on()
        {
            cbSearch.Enabled = false;
            menu.Items[2].Enabled = false;
            bPrevious.Enabled = false;
            bNext.Enabled = false;
            tbBlock(true);
            bSave.Enabled = true;
            bUpgrade.Enabled = false;
            menu.Items[1].Enabled = false;
            tbSearch.Enabled = false;
            bSearch.Enabled = false;
            bCancel.Enabled = false;
        }

        public void CreateEditMode_off()
        { 
            bSave.Enabled = false;
            CheckButtons();
            menu.Items[2].Enabled = true;
            cbSearch.Enabled = true;
            bUpgrade.Enabled = true;
            menu.Items[1].Enabled = true;
            if (tbSearch.Text != "")
            {
                tbSearch.Enabled = true;
                bSearch.Enabled = true;
                bCancel.Enabled = true;
            }
        }

        private void StudentShow()
        {
            int i = sl.curSt;
            int n = sl.students.Count - 1;
            if (i >= 0 && i <= n)
            {
                tbName.Text = sl.students[i].Name;
                tbSurname.Text = sl.students[i].Surname;
                tbFaculty.Text = sl.students[i].Faculty;
                if (sl.students[i] is Master)
                {
                    Master ms = (Master)sl.students[i];
                    tbDiploma.Visible = lbDiploma.Visible = true;
                    tbDiploma.Text = ms.Diploma;
                    bUpgrade.Visible = false;
                }
                else
                {
                    tbDiploma.Visible = false;
                    lbDiploma.Visible = false;
                    bUpgrade.Visible = true;
                }
            }
            else
            {
                tbName.Text = "";
                tbSurname.Text = "";
                tbFaculty.Text = "";
                tbDiploma.Visible = false;
                lbDiploma.Visible = false;
                bUpgrade.Visible = false;
            }
        }
        
        private void bPrevious_Click(object sender, EventArgs e)
        {
            sl.Prev();
            StudentShow();
            CheckButtons();
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            sl.Next();
            StudentShow();
            CheckButtons();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbName.Enabled = false;
            tbSurname.Enabled = false;
            tbFaculty.Enabled = false;
            tbDiploma.Visible = false;
            lbDiploma.Visible = false;
            tbClear();
            sl.NewList();
            CheckButtons();
            SearchClear();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Файл XML (*.xml)|*.xml|All files (*.*)|*.*";
            dlg.InitialDirectory = @"C:\Users\Пользователь\source\repos\syap2\syap2\bin\Debug\Saved";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            using (FileStream fs = new FileStream(dlg.FileName, FileMode.Open))
            {
                try
                {
                    sl.students = (List<Student>)xs.Deserialize(fs);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Выберите файл с расширением .xml");
                }
            }
            tbBlock(false);
            sl.SearchDefault();
            CheckButtons();
            StudentShow();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "Файл XML (*.xml)|*.xml|All files (*.*)|*.*";
            dlg.InitialDirectory = @"C:\Users\Пользователь\source\repos\syap2\syap2\bin\Debug\Saved";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            using (FileStream fs = new FileStream(dlg.FileName, FileMode.Create))
            {
                xs.Serialize(fs, sl.students);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void предыдущиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bPrevious.Enabled)
                bPrevious_Click(sender, e);
        }

        private void следующийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bNext.Enabled)
                bNext_Click(sender, e);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sl.curSt < 0)
                return;
            CreateEditMode_on();
        }

        private void бакалаврToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchClear();
            CreateEditMode_on();
            tbDiploma.Visible = false;
            lbDiploma.Visible = false;
            bUpgrade.Visible = true;
            Student new_student = new Student();
            tbClear();
            sl.NewStudent(new_student);
        }

        private void магистрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchClear();
            CreateEditMode_on();
            Student new_student = new Master();
            tbDiploma.Visible = true;
            lbDiploma.Visible = true;
            bUpgrade.Visible = false;
            tbClear();
            sl.NewStudent(new_student);

        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sl.Delete();
            CheckButtons();
            //if (sl.)
            if (sl.curSt < 0)
            {
                tbClear();
                tbDiploma.Visible = false;
                lbDiploma.Visible = false;
                bUpgrade.Visible = false;
                return;
            }
            StudentShow();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (sl.students[sl.curSt] is Master)
            {
                sl.NewInfo(tbName.Text, tbSurname.Text, tbFaculty.Text, tbDiploma.Text);
            }
            else
            {
                sl.NewInfo(tbName.Text, tbSurname.Text, tbFaculty.Text);
                bUpgrade.Visible = true;
            }
            CreateEditMode_off();
            CheckButtons();
            tbBlock(false);
        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            SearchClear();
            StudentShow();
            CheckButtons();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            sl.SearchDefault();
            switch (cbSearch.SelectedIndex)
            {
                case 0:
                    sl.Search(s => s.name == tbSearch.Text);
                    break;
                case 1:
                    sl.Search(s => s.surname == tbSearch.Text);
                    break;
                case 2:
                    sl.Search(s => s.surname == tbSearch.Text);
                    break;
            }
            CheckButtons();
            StudentShow();
        }

        private void bUpgrade_Click(object sender, EventArgs e)
        {
            sl.Upgrade();
            sl.NewInfo(tbName.Text, tbSurname.Text, tbFaculty.Text, "диплом " + tbFaculty.Text + "а");
            StudentShow();
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Enabled = cbSearch.SelectedItem != null ? true : false;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            bSearch.Enabled = tbSearch.Text != "" ? true : false;
            bCancel.Enabled = bSearch.Enabled;
        }
    }
}
