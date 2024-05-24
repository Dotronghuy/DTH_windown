using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            loadDataCombo();
            loadData();
        }
        SqlConnection ketnoiCSDL()
        {
            string strCon = "Data Source =LAPTOP-29UG1RC2\\SQL;Initial Catalog=DoTrongHuy_2210900029;Integrated Security=True";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            return con;
        }
        void loadData()
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Nhanvien", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgwNV.DataSource = dt;
            }
        }
        void loadDataCombo()
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Phongban", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cmbMP.DataSource = dt;
                cmbMP.DisplayMember = "Tenphong";
                cmbMP.ValueMember = "Maphong";
                cmbMP.SelectedIndex = -1;
            }
        }
        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            loadDataCombo();
            loadData();
        }

        void Timvitri(string Maphong)
        {
            int i = 0;
            cmbMP.SelectedIndex = 0;
            while (!cmbMP.SelectedValue.ToString().Equals(Maphong))
            {
                i++;
                cmbMP.SelectedIndex = i;
            }
        }
        void timvitriluoi(string ma)
        {
            int i = 0;
            while (i < dgwNV.Rows.Count)
            {
                if (ma.Trim().Equals(dgwNV.Rows[i].Cells[0].Value.ToString().Trim()))
                {
                    dgwNV.CurrentCell = dgwNV.Rows[i].Cells[0];
                    break;
                }
                i++;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            tbNV.Clear();
            tbTen.Clear();
            tbDC.Clear();
            dpkNS.Value = DateTime.Now;
            cmbMP.SelectedIndex = -1;
        }


        private void dgwNV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < dgwNV.RowCount - 1)
            {
                tbNV.Text = dgwNV.Rows[i].Cells[0].Value.ToString();
                tbTen.Text = dgwNV.Rows[i].Cells[1].Value.ToString();
                if (DateTime.TryParse(dgwNV.Rows[i].Cells[3].Value.ToString(), out DateTime birthDate))
                {
                    dpkNS.Value = birthDate;
                }
                else
                {
                   
                }
                tbDC.Text = dgwNV.Rows[i].Cells[4].Value.ToString();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                try
                {
                    string checkSql = "SELECT * FROM Nhanvien WHERE manv = @manv";
                    SqlCommand checkCmd = new SqlCommand(checkSql, con);
                    checkCmd.Parameters.AddWithValue("@manv", tbNV.Text);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "INSERT INTO Nhanvien (manv, tennv, ns, diachi, maphong) VALUES (@manv, @tennv, @ns, @diachi, @maphong)";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@manv", tbNV.Text);
                        cmd.Parameters.AddWithValue("@tennv", tbTen.Text);
                        cmd.Parameters.AddWithValue("@ns", dpkNS.Value);
                        cmd.Parameters.AddWithValue("@diachi", tbDC.Text);
                        cmd.Parameters.AddWithValue("@maphong", cmbMP.SelectedValue);
                        cmd.ExecuteNonQuery();
                        loadData();
                        MessageBox.Show("Thêm mới nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Lỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                try
                {
                    string sql = "delete from NhanVien where MaNV = @MaNV";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@MASV", tbNV.Text);
                    cmd.ExecuteNonQuery();
                    loadData();
                    timvitriluoi(tbNV.Text);
                }
                catch (Exception er)
                {
                    MessageBox.Show("Lỗi" + er.Message);
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = ketnoiCSDL())
            {
                try
                {
                    string checkSql = "SELECT COUNT(*) FROM Nhanvien WHERE manv = @manv";
                    SqlCommand checkCmd = new SqlCommand(checkSql, con);
                    checkCmd.Parameters.AddWithValue("@manv", tbNV.Text);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "INSERT INTO Nhanvien VALUES (@manv, @tennv, @ns, @diachi, @maphong)"; 
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@manv", tbNV.Text);
                        cmd.Parameters.AddWithValue("@tennv", tbTen.Text);
                        cmd.Parameters.AddWithValue("@ns", dpkNS.Value);
                        cmd.Parameters.AddWithValue("@diachi", tbDC.Text);
                        cmd.Parameters.AddWithValue("@maphong", cmbMP.SelectedValue);
                        cmd.ExecuteNonQuery();
                        loadData();
                        timvitriluoi(tbNV.Text);
                        MessageBox.Show("Thêm mới nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    con.Close();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Lỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            tbNV.Clear();
            tbTen.Clear();
            tbDC.Clear();
            dpkNS.Value = DateTime.Now;
            cmbMP.SelectedIndex = -1;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = ketnoiCSDL())
                {
                    try
                    {
                        string sql = "delete from Nhanvien where manv = @manv";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@manv", tbNV.Text);
                        cmd.ExecuteNonQuery();
                        loadData();
                        timvitriluoi(tbNV.Text);

                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Lỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}


