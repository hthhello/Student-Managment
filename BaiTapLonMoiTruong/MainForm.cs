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
using System.Data.SqlClient;


namespace BaiTapLonMoiTruong
{
    public partial class MainForm : Form
    {
        int selectedChoice = 0;
        string k;
        string sexy;
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            clearsametime.Enabled = true;
            comboBox1.Text = "01";
            comboBox2.Text = "01";
            dateofbirth.Text = "1996";
        }
        public void searchbox_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = true;
            }
            if (searchbox.Text != "")
            {
                xoaall.Enabled = false;
            }
            else
            {
                xoaall.Enabled = true;
            }
        }
        public void finding_Click(object sender, EventArgs e)
        {
            if ((ften.Checked == false) && (flop.Checked == false) && (fkhoa.Checked == false) && (fms.Checked == false))
            {
                MessageBox.Show("Bạn chưa chọn mục cần tìm kìa @@!");
            }
            else
            {
                string searchvalue = searchbox.Text;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                if (ften.Checked == true)
                    selectedChoice = 2;
                else if (flop.Checked == true)
                    selectedChoice = 7;
                else if (fms.Checked == true)
                    selectedChoice = 8;
                else if (fkhoa.Checked == true)
                    selectedChoice = 6;
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.Visible = true;
                        if (row.Cells[selectedChoice].Value.ToString().Equals(searchvalue))
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
                catch
                {
                }
            }    
        }
        private void adding_Click(object sender, EventArgs e)
        {
            if ((familyname.Text == "") && (name.Text == "") && (comboBox1.Text == "") && (comboBox2.Text == "") && (dateofbirth.Text == "") && (nganh.Text == "") && (classes.Text == "") && (ids.Text == ""))
            {
                MessageBox.Show("Bạn đã nhập dữ liệu chưa??? @@!");
            }
            else
            {
                if (conditions() == false)
                {
                    if ((Convert.ToInt32(dateofbirth.Text) % 4 == 0) && (comboBox1.Text == "30" || comboBox1.Text == "31") && comboBox2.Text == "02")
                        MessageBox.Show("Tháng 2 năm nhuận chỉ có 29 ngày!");
                    if ((Convert.ToInt32(dateofbirth.Text) % 4 != 0) && (comboBox1.Text == "30" || comboBox1.Text == "31" || comboBox1.Text == "29") && comboBox2.Text == "02")
                        MessageBox.Show("Tháng 2 năm không nhuận chỉ có 28 ngày!");
                    if (comboBox1.Text == "31" && (comboBox2.Text == "4" || comboBox2.Text == "6" || comboBox2.Text == "9" || comboBox2.Text == "11"))
                    {
                        MessageBox.Show("Tháng bạn nhập chỉ có 30 ngày");
                    }
                }
                else if (conditions() == true)
                {
                    if (sameID(ids.Text) == true)
                    {
                        MessageBox.Show("Mỗi sinh viên chỉ có một mã số sinh viên!!! Vui lòng nhập lại!!!");
                    }
                    else if (sameID(ids.Text) == false)
                    {
                        if (smale.Checked == true)
                            k = "Nam";
                        else if (sfemale.Checked == true)
                            k = "Nữ";
                        int dong = 0;
                        if (familyname.Text == "")
                            familyname.Text = "???";
                        if (name.Text == "")
                            name.Text = "???";
                        if (address.Text == "")
                            address.Text = "???";
                        if (nganh.Text == "")
                            nganh.Text = "???";
                        if (classes.Text == "")
                            classes.Text = "???";
                        if (ids.Text == "")
                            ids.Text = "???";
                        dataGridView1.Rows.Add("\t", familyname.Text, name.Text, comboBox1.Text + "/" + comboBox2.Text + "/" + dateofbirth.Text, k, address.Text, nganh.Text, classes.Text, ids.Text);
                        familyname.Clear();
                        name.Clear();
                        dateofbirth.Clear();
                        address.Clear();
                        ids.Clear();
                        nganh.Clear();
                        classes.Clear();
                        comboBox1.Text = comboBox2.Text = null;
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dong++;
                            dataGridView1.Rows[i].Cells[0].Value = dong.ToString();
                        }
                    }
                }
            }
        }
        private void chinhsua_Click(object sender, EventArgs e)
        {
            if (smale.Checked == true)
                sexy = "Nam";
            if (sfemale.Checked == true)
                sexy = "Nữ";
            if (familyname.Text == "")
                familyname.Text = "???";
            if (name.Text == "")
                name.Text = "???";
            if (address.Text == "")
                address.Text = "???";
            if (nganh.Text == "")
                nganh.Text = "???";
            if (classes.Text == "")
                classes.Text = "???";
            if (ids.Text == "")
                ids.Text = "???";
            dataGridView1.CurrentRow.SetValues("\t", familyname.Text, name.Text, comboBox1.Text + "/" + comboBox2.Text + "/" + dateofbirth.Text, sexy, address.Text, nganh.Text, classes.Text, ids.Text);
            int dong = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dong++;
                dataGridView1.Rows[i].Cells[0].Value = dong.ToString();
            }
            adding.Enabled = true;
            familyname.Clear();
            name.Clear();
            dateofbirth.Clear();
            address.Clear();
            nganh.Clear();
            classes.Clear();
            ids.Clear();
            comboBox1.Text = comboBox2.Text = null;
            chinhsua.Enabled = false;
        }
        private void xuat_Click(object sender, System.EventArgs e)
        {
            saveFileDialog1.Filter = "|*.txt";
            saveFileDialog1.FileName = "quanlysv.txt";
            saveFileDialog1.Title = "XUẤT DỮ LIỆU";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter ghi = new StreamWriter(saveFileDialog1.FileName);
                    try
                    {
                        ghi.WriteLine("DANH SÁCH SINH VIÊN");
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                ghi.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t");
                            }
                            ghi.WriteLine();
                        }
                        ghi.Close();
                    }
                    catch { };
                }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                familyname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                name.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string dob = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string ngaysinh = dob.Substring(0,2);
                comboBox1.Text = ngaysinh;
                string thangsinh = dob.Substring(3, 2);
                comboBox2.Text = thangsinh;
                string namsinh = dob.Substring(6, 4);
                dateofbirth.Text = namsinh;
                address.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                nganh.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                classes.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                ids.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                adding.Enabled = false;
                chinhsua.Enabled = true;
                xoa.Enabled = true;
                if(dataGridView1.CurrentRow.Cells[4].Value.ToString()=="Nam")
                {
                    smale.Checked = true;
                }
                if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Nữ")
                {
                    sfemale.Checked = true;
                }
            }
            catch { };
        }
        public void nhap_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "|*.txt";
            openFileDialog1.FileName = "quanlysv.txt";
            openFileDialog1.Title = "NHẬP DỮ LIỆU";
            try
                {
                    if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
                    {
                        String sLine = "";
                            StreamReader FileStream = new StreamReader(openFileDialog1.FileName);
                            dataGridView1.AllowUserToAddRows = false;
                            sLine = FileStream.ReadLine();
                            string[] s = sLine.Split('\t');
                            for (int i = 0; i < s.Count(); i++)
                            {
                                DataGridViewColumn colHold = new DataGridViewTextBoxColumn();
                                colHold.Name = "col" + System.Convert.ToString(i);
                                colHold.HeaderText = s[i].ToString();
                                dataGridView1.Columns.Add(colHold);
                            }
                            sLine = FileStream.ReadLine();
                            while (sLine != null)
                            {
                                dataGridView1.Rows.Add();
                                for (int i = 0; i < s.Count(); i++)
                                {
                                    s = sLine.Split('\t');
                                    dataGridView1.Rows[dataGridView1.Rows.Count - 1 ].Cells[i].Value = s[i].ToString();
                                }
                                sLine = FileStream.ReadLine();
                            }
                            FileStream.Close(); 
                    }
                    dataGridView1.Columns.Remove(dataGridView1.Columns[9]);
                    int cellnum = 0;
                    int rownum = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        cellnum = cellnum + 1;
                        dataGridView1.Rows[rownum].Cells[0].Value = cellnum;
                        rownum = rownum + 1;
                    }
                }
            catch 
                {
                    
                }
        }
        private void xoaall_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                }
                familyname.Clear();
                name.Clear();
                dateofbirth.Clear();
                address.Clear();
                ids.Clear();
                classes.Clear();
                nganh.Clear();
            }
            catch { };
            chinhsua.Enabled = false;
            adding.Enabled = true;
            xoa.Enabled = false;
        }
        private void clearsametime_Click(object sender, EventArgs e)
        {
            int dong = 0;
            int sodongchon = dataGridView1.SelectedRows.Count;
            if (sodongchon == 0)
            {
                MessageBox.Show("Bạn đã chọn dòng xóa chưa nhỉ!!! @@!");
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    if (!row.IsNewRow) dataGridView1.Rows.Remove(row);
                familyname.Clear();
                name.Clear();
                dateofbirth.Clear();
                address.Clear();
                ids.Clear();
                classes.Clear();
                nganh.Clear();
                comboBox1.Text = comboBox2.Text = null;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dong++;
                dataGridView1.Rows[i].Cells[0].Value = dong.ToString();
            }
            chinhsua.Enabled = false;
            adding.Enabled = true;
            xoa.Enabled = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private bool conditions()
        {
            bool kiemtra = true;
            if ((Convert.ToInt32(dateofbirth.Text) % 4 == 0) && (comboBox1.Text == "30" || comboBox1.Text == "31") && comboBox2.Text == "02")
            {
                kiemtra = false;
            }
            else
            {
                if ((Convert.ToInt32(dateofbirth.Text) % 4 != 0) && (comboBox1.Text == "30" || comboBox1.Text == "31" || comboBox1.Text == "29") && comboBox2.Text == "02")
                {
                    kiemtra = false;
                }
                else
                {
                    if ((comboBox1.Text == "31") && ((comboBox2.Text == "4") || (comboBox2.Text == "6") || (comboBox2.Text == "9") || (comboBox2.Text == "11")) && (Convert.ToInt32(dateofbirth.Text) != 0))
                    {
                        kiemtra = false;
                    }
                }
            }
            return kiemtra;
        }

        private bool sameID(string a)
        {
            bool kt = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (a == dataGridView1.Rows[i].Cells[8].Value.ToString())
                {
                    kt = true;
                }

            }
            return kt;
        }
        private void closeform(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Cám ơn bạn đã sử dụng ứng dụng ^^! \n Ứng dụng này được viết bởi Huỳnh Tấn Hưng và Nguyễn Duy Hàn Lâm","Close");
        }
    }
}
