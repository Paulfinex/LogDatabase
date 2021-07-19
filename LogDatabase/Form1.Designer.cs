
namespace LogDatabase
{
    partial class LogDB
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
            this.btn_display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbox_number = new System.Windows.Forms.TextBox();
            this.btn_cerca = new System.Windows.Forms.Button();
            this.comboBox_cerca = new System.Windows.Forms.ComboBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.txtbox_import = new System.Windows.Forms.TextBox();
            this.importDialog = new System.Windows.Forms.OpenFileDialog();
            this.progBar_import = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_selectDialog = new System.Windows.Forms.Button();
            this.lbl_progresso = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbox_type = new System.Windows.Forms.TextBox();
            this.txtbox_date = new System.Windows.Forms.TextBox();
            this.txtbox_time = new System.Windows.Forms.TextBox();
            this.txtbox_user = new System.Windows.Forms.TextBox();
            this.txtbox_action = new System.Windows.Forms.TextBox();
            this.txtbox_accessedres = new System.Windows.Forms.TextBox();
            this.txtbox_connectiontype = new System.Windows.Forms.TextBox();
            this.txtbox_computername = new System.Windows.Forms.TextBox();
            this.txtbox_sourceip = new System.Windows.Forms.TextBox();
            this.btn_exp = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.progbar_export = new System.Windows.Forms.ProgressBar();
            this.lbl_prog_export = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(12, 291);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(104, 29);
            this.btn_display.TabIndex = 2;
            this.btn_display.Text = "Aggiorna";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-8, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1880, 703);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtbox_number
            // 
            this.txtbox_number.Location = new System.Drawing.Point(703, 103);
            this.txtbox_number.Name = "txtbox_number";
            this.txtbox_number.Size = new System.Drawing.Size(214, 20);
            this.txtbox_number.TabIndex = 5;
            // 
            // btn_cerca
            // 
            this.btn_cerca.Location = new System.Drawing.Point(615, 261);
            this.btn_cerca.Name = "btn_cerca";
            this.btn_cerca.Size = new System.Drawing.Size(87, 25);
            this.btn_cerca.TabIndex = 7;
            this.btn_cerca.Text = "Cerca";
            this.btn_cerca.UseVisualStyleBackColor = true;
            this.btn_cerca.Click += new System.EventHandler(this.btn_cerca_Click);
            // 
            // comboBox_cerca
            // 
            this.comboBox_cerca.FormattingEnabled = true;
            this.comboBox_cerca.Items.AddRange(new object[] {
            "Number",
            "Type",
            "Date",
            "Time",
            "Users",
            "Source_IP",
            "Computer_name",
            "Connection_type",
            "Accessed_resources",
            "Action"});
            this.comboBox_cerca.Location = new System.Drawing.Point(1503, 52);
            this.comboBox_cerca.Name = "comboBox_cerca";
            this.comboBox_cerca.Size = new System.Drawing.Size(121, 21);
            this.comboBox_cerca.TabIndex = 8;
            this.comboBox_cerca.Visible = false;
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(12, 133);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(86, 23);
            this.btn_import.TabIndex = 9;
            this.btn_import.Text = "Importa";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // txtbox_import
            // 
            this.txtbox_import.Enabled = false;
            this.txtbox_import.Location = new System.Drawing.Point(117, 106);
            this.txtbox_import.Name = "txtbox_import";
            this.txtbox_import.Size = new System.Drawing.Size(214, 20);
            this.txtbox_import.TabIndex = 10;
            // 
            // importDialog
            // 
            this.importDialog.FileName = "...";
            this.importDialog.Multiselect = true;
            // 
            // progBar_import
            // 
            this.progBar_import.Location = new System.Drawing.Point(117, 133);
            this.progBar_import.Name = "progBar_import";
            this.progBar_import.Size = new System.Drawing.Size(214, 23);
            this.progBar_import.TabIndex = 11;
            this.progBar_import.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btn_selectDialog
            // 
            this.btn_selectDialog.Location = new System.Drawing.Point(12, 103);
            this.btn_selectDialog.Name = "btn_selectDialog";
            this.btn_selectDialog.Size = new System.Drawing.Size(86, 23);
            this.btn_selectDialog.TabIndex = 12;
            this.btn_selectDialog.Text = "Seleziona CSV";
            this.btn_selectDialog.UseVisualStyleBackColor = true;
            this.btn_selectDialog.Click += new System.EventHandler(this.btn_selectDialog_Click);
            // 
            // lbl_progresso
            // 
            this.lbl_progresso.AutoSize = true;
            this.lbl_progresso.Location = new System.Drawing.Point(117, 163);
            this.lbl_progresso.Name = "lbl_progresso";
            this.lbl_progresso.Size = new System.Drawing.Size(60, 13);
            this.lbl_progresso.TabIndex = 13;
            this.lbl_progresso.Text = "Progresso..";
            this.lbl_progresso.Visible = false;
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(612, 106);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(44, 13);
            this.Number.TabIndex = 14;
            this.Number.Text = "Number";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(612, 134);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 15;
            this.Type.Text = "Type";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(612, 164);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 16;
            this.Date.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(968, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Source IP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(968, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Computer Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(968, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Connection Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(968, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Accessed Resources";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(968, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Action";
            // 
            // txtbox_type
            // 
            this.txtbox_type.Location = new System.Drawing.Point(703, 131);
            this.txtbox_type.Name = "txtbox_type";
            this.txtbox_type.Size = new System.Drawing.Size(214, 20);
            this.txtbox_type.TabIndex = 24;
            // 
            // txtbox_date
            // 
            this.txtbox_date.Location = new System.Drawing.Point(703, 161);
            this.txtbox_date.Name = "txtbox_date";
            this.txtbox_date.Size = new System.Drawing.Size(214, 20);
            this.txtbox_date.TabIndex = 25;
            // 
            // txtbox_time
            // 
            this.txtbox_time.Location = new System.Drawing.Point(703, 191);
            this.txtbox_time.Name = "txtbox_time";
            this.txtbox_time.Size = new System.Drawing.Size(214, 20);
            this.txtbox_time.TabIndex = 26;
            // 
            // txtbox_user
            // 
            this.txtbox_user.Location = new System.Drawing.Point(703, 224);
            this.txtbox_user.Name = "txtbox_user";
            this.txtbox_user.Size = new System.Drawing.Size(214, 20);
            this.txtbox_user.TabIndex = 27;
            // 
            // txtbox_action
            // 
            this.txtbox_action.Location = new System.Drawing.Point(1093, 224);
            this.txtbox_action.Name = "txtbox_action";
            this.txtbox_action.Size = new System.Drawing.Size(214, 20);
            this.txtbox_action.TabIndex = 32;
            // 
            // txtbox_accessedres
            // 
            this.txtbox_accessedres.Location = new System.Drawing.Point(1093, 191);
            this.txtbox_accessedres.Name = "txtbox_accessedres";
            this.txtbox_accessedres.Size = new System.Drawing.Size(214, 20);
            this.txtbox_accessedres.TabIndex = 31;
            // 
            // txtbox_connectiontype
            // 
            this.txtbox_connectiontype.Location = new System.Drawing.Point(1093, 161);
            this.txtbox_connectiontype.Name = "txtbox_connectiontype";
            this.txtbox_connectiontype.Size = new System.Drawing.Size(214, 20);
            this.txtbox_connectiontype.TabIndex = 30;
            // 
            // txtbox_computername
            // 
            this.txtbox_computername.Location = new System.Drawing.Point(1093, 131);
            this.txtbox_computername.Name = "txtbox_computername";
            this.txtbox_computername.Size = new System.Drawing.Size(214, 20);
            this.txtbox_computername.TabIndex = 29;
            // 
            // txtbox_sourceip
            // 
            this.txtbox_sourceip.Location = new System.Drawing.Point(1093, 103);
            this.txtbox_sourceip.Name = "txtbox_sourceip";
            this.txtbox_sourceip.Size = new System.Drawing.Size(214, 20);
            this.txtbox_sourceip.TabIndex = 28;
            // 
            // btn_exp
            // 
            this.btn_exp.Location = new System.Drawing.Point(724, 261);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(104, 24);
            this.btn_exp.TabIndex = 33;
            this.btn_exp.Text = "Esporta Ricerca";
            this.btn_exp.UseVisualStyleBackColor = true;
            this.btn_exp.Click += new System.EventHandler(this.btn_exp_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            // 
            // progbar_export
            // 
            this.progbar_export.Location = new System.Drawing.Point(724, 291);
            this.progbar_export.Name = "progbar_export";
            this.progbar_export.Size = new System.Drawing.Size(214, 23);
            this.progbar_export.TabIndex = 34;
            this.progbar_export.Visible = false;
            // 
            // lbl_prog_export
            // 
            this.lbl_prog_export.AutoSize = true;
            this.lbl_prog_export.Location = new System.Drawing.Point(721, 317);
            this.lbl_prog_export.Name = "lbl_prog_export";
            this.lbl_prog_export.Size = new System.Drawing.Size(60, 13);
            this.lbl_prog_export.TabIndex = 35;
            this.lbl_prog_export.Text = "Progresso..";
            this.lbl_prog_export.Visible = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(596, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 323);
            this.label1.TabIndex = 37;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LogDatabase.Properties.Resources.search_icon__1_;
            this.pictureBox2.Location = new System.Drawing.Point(605, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 62);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LogDatabase.Properties.Resources.forensic;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 85);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(1313, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 323);
            this.label2.TabIndex = 39;
            // 
            // LogDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_prog_export);
            this.Controls.Add(this.progbar_export);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.txtbox_action);
            this.Controls.Add(this.txtbox_accessedres);
            this.Controls.Add(this.txtbox_connectiontype);
            this.Controls.Add(this.txtbox_computername);
            this.Controls.Add(this.txtbox_sourceip);
            this.Controls.Add(this.txtbox_user);
            this.Controls.Add(this.txtbox_time);
            this.Controls.Add(this.txtbox_date);
            this.Controls.Add(this.txtbox_type);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.lbl_progresso);
            this.Controls.Add(this.btn_selectDialog);
            this.Controls.Add(this.progBar_import);
            this.Controls.Add(this.txtbox_import);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.comboBox_cerca);
            this.Controls.Add(this.btn_cerca);
            this.Controls.Add(this.txtbox_number);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_display);
            this.Name = "LogDB";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbox_number;
        private System.Windows.Forms.Button btn_cerca;
        private System.Windows.Forms.ComboBox comboBox_cerca;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.TextBox txtbox_import;
        private System.Windows.Forms.OpenFileDialog importDialog;
        private System.Windows.Forms.ProgressBar progBar_import;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_selectDialog;
        private System.Windows.Forms.Label lbl_progresso;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbox_type;
        private System.Windows.Forms.TextBox txtbox_date;
        private System.Windows.Forms.TextBox txtbox_time;
        private System.Windows.Forms.TextBox txtbox_user;
        private System.Windows.Forms.TextBox txtbox_action;
        private System.Windows.Forms.TextBox txtbox_accessedres;
        private System.Windows.Forms.TextBox txtbox_connectiontype;
        private System.Windows.Forms.TextBox txtbox_computername;
        private System.Windows.Forms.TextBox txtbox_sourceip;
        private System.Windows.Forms.Button btn_exp;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ProgressBar progbar_export;
        private System.Windows.Forms.Label lbl_prog_export;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

