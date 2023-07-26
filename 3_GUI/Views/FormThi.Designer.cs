namespace _3_GUI.Views
{
    partial class FormThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tx_tPho = new TextBox();
            tx_qGia = new TextBox();
            tx_diaChi = new TextBox();
            tx_ten = new TextBox();
            tx_ma = new TextBox();
            tx_id = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tx = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtgv_data = new DataGridView();
            groupBox3 = new GroupBox();
            bt_delete = new Button();
            bt_create = new Button();
            tx_tim = new TextBox();
            bt_show = new Button();
            bt_export = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_export);
            groupBox1.Controls.Add(tx_tPho);
            groupBox1.Controls.Add(tx_qGia);
            groupBox1.Controls.Add(tx_diaChi);
            groupBox1.Controls.Add(tx_ten);
            groupBox1.Controls.Add(tx_ma);
            groupBox1.Controls.Add(tx_id);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tx);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1047, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thuộc tính";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tx_tPho
            // 
            tx_tPho.Location = new Point(805, 51);
            tx_tPho.Name = "tx_tPho";
            tx_tPho.Size = new Size(182, 27);
            tx_tPho.TabIndex = 2;
            // 
            // tx_qGia
            // 
            tx_qGia.Location = new Point(687, 123);
            tx_qGia.Name = "tx_qGia";
            tx_qGia.Size = new Size(117, 27);
            tx_qGia.TabIndex = 4;
            tx_qGia.TextChanged += textBox6_TextChanged;
            // 
            // tx_diaChi
            // 
            tx_diaChi.Location = new Point(321, 123);
            tx_diaChi.Name = "tx_diaChi";
            tx_diaChi.Size = new Size(133, 27);
            tx_diaChi.TabIndex = 3;
            // 
            // tx_ten
            // 
            tx_ten.Location = new Point(439, 48);
            tx_ten.Name = "tx_ten";
            tx_ten.Size = new Size(198, 27);
            tx_ten.TabIndex = 0;
            tx_ten.TextChanged += tx_ten_TextChanged;
            // 
            // tx_ma
            // 
            tx_ma.Location = new Point(88, 123);
            tx_ma.Name = "tx_ma";
            tx_ma.ReadOnly = true;
            tx_ma.Size = new Size(118, 27);
            tx_ma.TabIndex = 99;
            // 
            // tx_id
            // 
            tx_id.Location = new Point(144, 40);
            tx_id.Name = "tx_id";
            tx_id.ReadOnly = true;
            tx_id.Size = new Size(183, 27);
            tx_id.TabIndex = 99;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(577, 123);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 6;
            label7.Text = "Quốc Gia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(687, 51);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 4;
            label5.Text = "Thành Phố";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 123);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 48);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên";
            // 
            // tx
            // 
            tx.AutoSize = true;
            tx.Location = new Point(9, 123);
            tx.Name = "tx";
            tx.Size = new Size(30, 20);
            tx.TabIndex = 1;
            tx.Text = "Ma";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 40);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgv_data);
            groupBox2.Location = new Point(12, 198);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(817, 386);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "gr";
            // 
            // dtgv_data
            // 
            dtgv_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_data.Location = new Point(6, 26);
            dtgv_data.Name = "dtgv_data";
            dtgv_data.RowHeadersWidth = 51;
            dtgv_data.RowTemplate.Height = 29;
            dtgv_data.Size = new Size(805, 354);
            dtgv_data.TabIndex = 0;
            dtgv_data.CellClick += dtgv_data_CellClick;
            dtgv_data.CellContentClick += dtgv_data_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bt_delete);
            groupBox3.Controls.Add(bt_create);
            groupBox3.Controls.Add(tx_tim);
            groupBox3.Controls.Add(bt_show);
            groupBox3.Location = new Point(835, 198);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(230, 395);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(53, 324);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(123, 55);
            bt_delete.TabIndex = 7;
            bt_delete.Text = "Delete";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_create
            // 
            bt_create.Location = new Point(0, 207);
            bt_create.Name = "bt_create";
            bt_create.Size = new Size(230, 65);
            bt_create.TabIndex = 6;
            bt_create.Text = "Create";
            bt_create.UseVisualStyleBackColor = true;
            bt_create.Click += bt_create_Click;
            // 
            // tx_tim
            // 
            tx_tim.Location = new Point(13, 54);
            tx_tim.Name = "tx_tim";
            tx_tim.PlaceholderText = "Tìm kiếm";
            tx_tim.Size = new Size(209, 27);
            tx_tim.TabIndex = 11;
            tx_tim.TextChanged += tx_tim_TextChanged;
            // 
            // bt_show
            // 
            bt_show.Location = new Point(0, 147);
            bt_show.Name = "bt_show";
            bt_show.Size = new Size(230, 64);
            bt_show.TabIndex = 5;
            bt_show.Text = "Show";
            bt_show.UseVisualStyleBackColor = true;
            bt_show.Click += bt_show_Click;
            // 
            // bt_export
            // 
            bt_export.Location = new Point(849, 120);
            bt_export.Name = "bt_export";
            bt_export.Size = new Size(94, 29);
            bt_export.TabIndex = 100;
            bt_export.Text = "Export";
            bt_export.UseVisualStyleBackColor = true;
            bt_export.Click += bt_export_Click;
            // 
            // FormThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 588);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormThi";
            Text = "FormThi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_data).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tx_tPho;
        private TextBox tx_qGia;
        private TextBox tx_diaChi;
        private TextBox tx_ten;
        private TextBox tx_ma;
        private TextBox tx_id;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label tx;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dtgv_data;
        private GroupBox groupBox3;
        private Button bt_delete;
        private Button bt_create;
        private Button bt_show;
        private TextBox tx_tim;
        private Button bt_export;
    }
}