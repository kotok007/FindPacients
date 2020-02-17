using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace base_bsmp
{
    public partial class settingForm : Form
    {

        string query = @"SELECT fnamber AS '№ истории', year_in AS 'Год обращения', date_in AS 'Дата поступления', section AS 'Поступил в', date_v AS 'Дата выписки', otdelenie AS 'Выписан из', fio AS 'ФИО', age AS 'Возраст', city AS 'Город', adr1 AS 'Адрес проживания',
phone AS 'Телефон', state_work AS 'Место работы', n_diagn AS 'Диагноз по МКБ'
FROM base_bsmp";
        SQLiteConnection connection = new SQLiteConnection();
        SQLiteCommand command = new SQLiteCommand();
        DataSet dataSet = new DataSet();

        public static class AllVariables
        {
            public static string fileDB;
        }


        public settingForm()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            //string connectionStr = @"Data Source=" + Application.StartupPath +@"\"+ openFileDialogDB.SafeFileName+ @";Version=3";
            string connectionStr = @"Data Source=e:\FindPacientStacionar\Base\base_bsmp.db;Version=3";
            MessageBox.Show(Application.StartupPath + @"\" + openFileDialogDB.SafeFileName);

            SQLiteDataAdapter sqlStacionar = new SQLiteDataAdapter(query, connectionStr);
            sqlStacionar.Fill(dataSet, "base_bsmp");
            formStart startForm = new formStart();
            startForm.dataGridView1.DataSource = dataSet.Tables["base_bsmp"].DefaultView;
            Close();
            startForm.Visible = true;

        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialogDB.ShowDialog() == DialogResult.OK)
            {
                AllVariables.fileDB = openFileDialogDB.FileName;
                textBoxPatchDB.Text = AllVariables.fileDB;
            }

        }
    }
}
