namespace BTTH_28._10._2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLookup = new Button();
            txtStudentID = new TextBox();
            label1 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnLookup
            // 
            btnLookup.Location = new Point(448, 108);
            btnLookup.Name = "btnLookup";
            btnLookup.Size = new Size(94, 29);
            btnLookup.TabIndex = 0;
            btnLookup.Text = "Tra cứu";
            btnLookup.UseVisualStyleBackColor = true;
            btnLookup.Click += BtnLookup_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(208, 108);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(204, 27);
            txtStudentID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 108);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 2;
            label1.Text = "Mã sinh viên:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = SystemColors.Control;
            lblResult.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblResult.Location = new Point(74, 48);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(177, 25);
            lblResult.TabIndex = 3;
            lblResult.Text = "Điểm của sinh viên:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 180);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(txtStudentID);
            Controls.Add(btnLookup);
            Name = "Form1";
            Text = "Tra cứu điểm sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLookup;
        private TextBox txtStudentID;
        private Label label1;
        private Label lblResult;
    }
}
