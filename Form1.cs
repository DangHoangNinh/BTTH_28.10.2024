using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BTTH_28._10._2024
{
    public partial class Form1 : Form
    {
        // Dictionary lưu trữ mã sinh viên và điểm
        private Dictionary<string, string> studentScores = new Dictionary<string, string>
        {
            { "SV001", "Toán: 8.5, Lý: 7.0, Hóa: 9.0" },
            { "SV002", "Toán: 6.5, Lý: 7.5, Hóa: 8.0" },
            { "SV003", "Toán: 9.0, Lý: 8.5, Hóa: 7.5" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLookup_Click(object sender, EventArgs e)
        {
            TextBox txtStudentID = this.Controls["txtStudentID"] as TextBox;
            Label lblResult = this.Controls["lblResult"] as Label;

            if (txtStudentID != null && lblResult != null)
            {
                string studentID = txtStudentID.Text;
                if (studentScores.TryGetValue(studentID, out string scores))
                {
                    lblResult.Text = $"Điểm của sinh viên {studentID}: {scores}";
                }
                else
                {
                    lblResult.Text = "Mã sinh viên không tồn tại.";
                }
            }
        }
    }
}
