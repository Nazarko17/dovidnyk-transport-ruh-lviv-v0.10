using ElectroTransport.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ElectroTS {
    public partial class ElectroTransport : Form {
        public ElectroTransport() {
            InitializeComponent();
        }

        electroClass m = new electroClass();
        private void btnAdd_Click(object sender, EventArgs e) {
            if (nudTranportID.Text == "" || txtFinish1.Text == "" || txtFinish2.Text == "" || txtInterval.Text == "" || txtStops1.Text == "" || txtStops2.Text == "" ||
                txtPrice.Text == "" || cmbType.Text == "") {
                MessageBox.Show("Заповніть усі поля та спробуйте ще раз.");
            } else {
                //Взяття даних з вхідних полів
            m.TransportID = Convert.ToInt32(nudTranportID.Text);
            m.Finish1 = txtFinish1.Text;
            m.Finish2 = txtFinish2.Text;
            m.Interval = txtInterval.Text;
            m.Stops1 = txtStops1.Text;
            m.Stops2 = txtStops2.Text;
            m.Price = txtPrice.Text;
            m.Тип = cmbType.Text;

                //Запис даних в БД
                bool success = m.Insert(m);
                if (success == true) {
                    MessageBox.Show("Новий маршурт успішно додано!");
                    Clear();
                } else if (m.TransportID == Convert.ToInt32(nudTranportID.Text)) {
                    MessageBox.Show("Маршрут з таким номером вже записаний!");
                } else {
                    MessageBox.Show("Помилка при додаванні маршруту, спробуйте ще раз.");
                }
            }
            //Завантаження даних у Data GridView
            DataTable dt = m.Select();
            dgvContactList.DataSource = dt;
        }

        private void MarshrutDB_Load(object sender, EventArgs e) {
            //Завантаження даних у Data GridView
            DataTable dt = m.Select();
            dgvContactList.DataSource = dt;
        }

        //Метод для очищення полів
        public void Clear() {
            nudTranportID.Text = "";
            txtFinish1.Text = "";
            txtFinish2.Text = "";
            txtInterval.Text = "";
            txtStops1.Text = "";
            txtStops2.Text = "";
            txtPrice.Text = "";
            cmbType.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (nudTranportID.Text == "" || txtFinish1.Text == "" || txtFinish2.Text == "" || txtInterval.Text == "" || txtStops1.Text == "" || txtStops2.Text == "" ||
                txtPrice.Text == "" || cmbType.Text == "") {
                MessageBox.Show("Виберіть маршрут або заповніть усі поля та спробуйте ще раз.");
            } else {
                //Взяття даних з вхідних полів
                m.TransportID = Convert.ToInt32(nudTranportID.Text);
                m.Finish1 = txtFinish1.Text;
                m.Finish2 = txtFinish2.Text;
                m.Interval = txtInterval.Text;
                m.Stops1 = txtStops1.Text;
                m.Stops2 = txtStops2.Text;
                m.Price = txtPrice.Text;
                m.Тип = cmbType.Text;


                //Оновлення даних в БД
                bool success = m.Update(m);
                if (success == true) {
                    MessageBox.Show("Маршрут успішно оновлено!");
                    //Завантаження даних у Data GridView
                    DataTable dt = m.Select();
                    dgvContactList.DataSource = dt;
                    Clear();
                } else {
                    MessageBox.Show("Помилка при оновленні маршруту, спробуйте ще раз.");
                }
            }
        }

        private void dgvContactList_Click(object sender, DataGridViewCellMouseEventArgs e) {
            //Отримання даних з Dаta Grid View та завантаження їх в текстові поля
            //Ідентифікація рядка, на якому натискається миша
            int rowIndex = e.RowIndex;
            nudTranportID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtFinish1.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtFinish2.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtInterval.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtStops1.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            txtStops2.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
            txtPrice.Text = dgvContactList.Rows[rowIndex].Cells[6].Value.ToString();
            cmbType.Text = dgvContactList.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (nudTranportID.Text == "" || txtFinish1.Text == "" || txtFinish2.Text == "" || txtInterval.Text == "" || txtStops1.Text == "" || txtStops2.Text == "" ||
                txtPrice.Text == "" || cmbType.Text == "") {
                MessageBox.Show("Виберіть маршрут та спробуйте ще раз.");
            } else {
                //Отримання ID транспорту з програми
                m.TransportID = Convert.ToInt32(nudTranportID.Text);
                bool success = m.Delete(m);
                if (success == true) {
                    MessageBox.Show("Маршрут успішно видалено!");
                    //Оновлення Data GridView
                    //Завантаження даних у Data GridView
                    DataTable dt = m.Select();
                    dgvContactList.DataSource = dt;
                    Clear();
                } else {
                    MessageBox.Show("Помилка при видаленні маршруту, спробуйте ще раз.");
                }
            }
        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void txtSearch_TextChanged(object sender, EventArgs e) {
            //Взяття данх з текстового поля "Пошук"
            string keyword = txtSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM table_marshrut WHERE TransportID LIKE '%" + keyword + "%' OR Finish1 LIKE '%" + keyword + "%' OR Finish2 LIKE '%" + keyword + "%' OR Stops1 LIKE '%" + keyword + "%' OR Stops2 LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }

        private void btnClear_MouseEnter(object sender, EventArgs e) {
            btnClear.BackColor = System.Drawing.Color.Orange;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e) {
            btnClear.BackColor = System.Drawing.Color.Gold;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e) {
            btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            btnAdd.BackColor = System.Drawing.Color.Green;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e) {
            btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            btnAdd.BackColor = System.Drawing.Color.FromArgb(34, 52, 72);
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e) {
            btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            btnUpdate.BackColor = System.Drawing.Color.Blue;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e) {
            btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(34, 52, 72);
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e) {
            btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            btnDelete.BackColor = System.Drawing.Color.Maroon;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e) {
            btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            btnDelete.BackColor = System.Drawing.Color.FromArgb(34, 52, 72);
        }

        private void btnHide_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            //this.Close();
            Application.Exit();
        }

        private void lblVersion_MouseEnter(object sender, EventArgs e) {
            lblVersion.Text = "                             :)";
        }

        private void lblVersion_MouseLeave(object sender, EventArgs e) {
            lblVersion.Text = "Бета-версія 0.12";
        }

        private void TxtFinish2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtFinish1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtStops1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtStops2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtInterval_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void NudTranportID_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}