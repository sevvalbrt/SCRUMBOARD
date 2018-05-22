namespace ScrumTableÖdev
{
    partial class ScrumBoard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpProjeEkle = new System.Windows.Forms.TabPage();
            this.dtBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtPrjSorumlu = new System.Windows.Forms.TextBox();
            this.lblPrjSorumlu = new System.Windows.Forms.Label();
            this.chbDone = new System.Windows.Forms.CheckBox();
            this.chbInProgress = new System.Windows.Forms.CheckBox();
            this.chbNotStarted = new System.Windows.Forms.CheckBox();
            this.lblKonu = new System.Windows.Forms.Label();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.lblYazarAdi = new System.Windows.Forms.Label();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.btnTaskEkle = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.btnStoriesEkle = new System.Windows.Forms.Button();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.tbpBoard = new System.Windows.Forms.TabPage();
            this.pnlinProgress = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlNotStarted = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDone = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlStories = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpProjeEkle.SuspendLayout();
            this.tbpBoard.SuspendLayout();
            this.pnlinProgress.SuspendLayout();
            this.pnlNotStarted.SuspendLayout();
            this.pnlDone.SuspendLayout();
            this.pnlStories.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpProjeEkle);
            this.tabControl1.Controls.Add(this.tbpBoard);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpProjeEkle
            // 
            this.tbpProjeEkle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbpProjeEkle.Controls.Add(this.dtBitisTarihi);
            this.tbpProjeEkle.Controls.Add(this.dtBaslangicTarihi);
            this.tbpProjeEkle.Controls.Add(this.txtPrjSorumlu);
            this.tbpProjeEkle.Controls.Add(this.lblPrjSorumlu);
            this.tbpProjeEkle.Controls.Add(this.chbDone);
            this.tbpProjeEkle.Controls.Add(this.chbInProgress);
            this.tbpProjeEkle.Controls.Add(this.chbNotStarted);
            this.tbpProjeEkle.Controls.Add(this.lblKonu);
            this.tbpProjeEkle.Controls.Add(this.lblBitisTarihi);
            this.tbpProjeEkle.Controls.Add(this.lblBaslangicTarihi);
            this.tbpProjeEkle.Controls.Add(this.lblYazarAdi);
            this.tbpProjeEkle.Controls.Add(this.txtYazarAdi);
            this.tbpProjeEkle.Controls.Add(this.btnTaskEkle);
            this.tbpProjeEkle.Controls.Add(this.txtTask);
            this.tbpProjeEkle.Controls.Add(this.lblTask);
            this.tbpProjeEkle.Controls.Add(this.btnStoriesEkle);
            this.tbpProjeEkle.Controls.Add(this.txtKonu);
            this.tbpProjeEkle.Location = new System.Drawing.Point(4, 24);
            this.tbpProjeEkle.Name = "tbpProjeEkle";
            this.tbpProjeEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProjeEkle.Size = new System.Drawing.Size(944, 500);
            this.tbpProjeEkle.TabIndex = 0;
            this.tbpProjeEkle.Text = "Proje Ekle";
            this.tbpProjeEkle.Click += new System.EventHandler(this.tbpProjeEkle_Click);
            // 
            // dtBitisTarihi
            // 
            this.dtBitisTarihi.Location = new System.Drawing.Point(234, 123);
            this.dtBitisTarihi.Name = "dtBitisTarihi";
            this.dtBitisTarihi.Size = new System.Drawing.Size(136, 21);
            this.dtBitisTarihi.TabIndex = 40;
            // 
            // dtBaslangicTarihi
            // 
            this.dtBaslangicTarihi.Location = new System.Drawing.Point(234, 70);
            this.dtBaslangicTarihi.Name = "dtBaslangicTarihi";
            this.dtBaslangicTarihi.Size = new System.Drawing.Size(136, 21);
            this.dtBaslangicTarihi.TabIndex = 39;
            // 
            // txtPrjSorumlu
            // 
            this.txtPrjSorumlu.Location = new System.Drawing.Point(234, 291);
            this.txtPrjSorumlu.Name = "txtPrjSorumlu";
            this.txtPrjSorumlu.Size = new System.Drawing.Size(136, 21);
            this.txtPrjSorumlu.TabIndex = 38;
            // 
            // lblPrjSorumlu
            // 
            this.lblPrjSorumlu.AutoSize = true;
            this.lblPrjSorumlu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPrjSorumlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrjSorumlu.Location = new System.Drawing.Point(84, 295);
            this.lblPrjSorumlu.Name = "lblPrjSorumlu";
            this.lblPrjSorumlu.Size = new System.Drawing.Size(129, 16);
            this.lblPrjSorumlu.TabIndex = 37;
            this.lblPrjSorumlu.Text = "Proje Sorumlusu :";
            // 
            // chbDone
            // 
            this.chbDone.AutoSize = true;
            this.chbDone.BackColor = System.Drawing.Color.LightSteelBlue;
            this.chbDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbDone.Location = new System.Drawing.Point(404, 361);
            this.chbDone.Name = "chbDone";
            this.chbDone.Size = new System.Drawing.Size(60, 19);
            this.chbDone.TabIndex = 36;
            this.chbDone.Text = "Done";
            this.chbDone.UseVisualStyleBackColor = false;
            // 
            // chbInProgress
            // 
            this.chbInProgress.AutoSize = true;
            this.chbInProgress.BackColor = System.Drawing.Color.LightSteelBlue;
            this.chbInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbInProgress.Location = new System.Drawing.Point(238, 361);
            this.chbInProgress.Name = "chbInProgress";
            this.chbInProgress.Size = new System.Drawing.Size(99, 19);
            this.chbInProgress.TabIndex = 35;
            this.chbInProgress.Text = "In Progress";
            this.chbInProgress.UseVisualStyleBackColor = false;
            // 
            // chbNotStarted
            // 
            this.chbNotStarted.AutoSize = true;
            this.chbNotStarted.BackColor = System.Drawing.Color.LightSteelBlue;
            this.chbNotStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbNotStarted.Location = new System.Drawing.Point(104, 361);
            this.chbNotStarted.Name = "chbNotStarted";
            this.chbNotStarted.Size = new System.Drawing.Size(98, 19);
            this.chbNotStarted.TabIndex = 34;
            this.chbNotStarted.Text = "Not Started";
            this.chbNotStarted.UseVisualStyleBackColor = false;
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblKonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKonu.Location = new System.Drawing.Point(462, 23);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(50, 16);
            this.lblKonu.TabIndex = 33;
            this.lblKonu.Text = "Konu :";
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitisTarihi.Location = new System.Drawing.Point(85, 126);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(90, 16);
            this.lblBitisTarihi.TabIndex = 32;
            this.lblBitisTarihi.Text = "Bitiş Tarihi :";
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblBaslangicTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(85, 74);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(129, 16);
            this.lblBaslangicTarihi.TabIndex = 31;
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi :";
            // 
            // lblYazarAdi
            // 
            this.lblYazarAdi.AutoSize = true;
            this.lblYazarAdi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblYazarAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazarAdi.Location = new System.Drawing.Point(85, 27);
            this.lblYazarAdi.Name = "lblYazarAdi";
            this.lblYazarAdi.Size = new System.Drawing.Size(83, 16);
            this.lblYazarAdi.TabIndex = 30;
            this.lblYazarAdi.Text = "Yazar Adı :";
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(234, 23);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(136, 21);
            this.txtYazarAdi.TabIndex = 27;
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.BackColor = System.Drawing.Color.Silver;
            this.btnTaskEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaskEkle.Location = new System.Drawing.Point(404, 418);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(161, 45);
            this.btnTaskEkle.TabIndex = 26;
            this.btnTaskEkle.Text = "TASK EKLE";
            this.btnTaskEkle.UseVisualStyleBackColor = false;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(561, 273);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(202, 105);
            this.txtTask.TabIndex = 25;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTask.Location = new System.Drawing.Point(463, 285);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(51, 16);
            this.lblTask.TabIndex = 24;
            this.lblTask.Text = "Task :";
            // 
            // btnStoriesEkle
            // 
            this.btnStoriesEkle.BackColor = System.Drawing.Color.Silver;
            this.btnStoriesEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStoriesEkle.Location = new System.Drawing.Point(404, 173);
            this.btnStoriesEkle.Name = "btnStoriesEkle";
            this.btnStoriesEkle.Size = new System.Drawing.Size(161, 48);
            this.btnStoriesEkle.TabIndex = 23;
            this.btnStoriesEkle.Text = "STORIES EKLE";
            this.btnStoriesEkle.UseVisualStyleBackColor = false;
            this.btnStoriesEkle.Click += new System.EventHandler(this.btnStoriesEkle_Click);
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(561, 23);
            this.txtKonu.Multiline = true;
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(202, 95);
            this.txtKonu.TabIndex = 22;
            // 
            // tbpBoard
            // 
            this.tbpBoard.Controls.Add(this.pnlinProgress);
            this.tbpBoard.Controls.Add(this.pnlNotStarted);
            this.tbpBoard.Controls.Add(this.pnlDone);
            this.tbpBoard.Controls.Add(this.pnlStories);
            this.tbpBoard.Location = new System.Drawing.Point(4, 24);
            this.tbpBoard.Name = "tbpBoard";
            this.tbpBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBoard.Size = new System.Drawing.Size(944, 500);
            this.tbpBoard.TabIndex = 1;
            this.tbpBoard.Text = "Board";
            this.tbpBoard.UseVisualStyleBackColor = true;
            // 
            // pnlinProgress
            // 
            this.pnlinProgress.AutoScroll = true;
            this.pnlinProgress.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlinProgress.Controls.Add(this.label3);
            this.pnlinProgress.Location = new System.Drawing.Point(464, 16);
            this.pnlinProgress.Name = "pnlinProgress";
            this.pnlinProgress.Size = new System.Drawing.Size(239, 458);
            this.pnlinProgress.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "IN PROGRESS";
            // 
            // pnlNotStarted
            // 
            this.pnlNotStarted.AutoScroll = true;
            this.pnlNotStarted.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlNotStarted.Controls.Add(this.label4);
            this.pnlNotStarted.Location = new System.Drawing.Point(224, 16);
            this.pnlNotStarted.Name = "pnlNotStarted";
            this.pnlNotStarted.Size = new System.Drawing.Size(237, 458);
            this.pnlNotStarted.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "NOT STARTED";
            // 
            // pnlDone
            // 
            this.pnlDone.AutoScroll = true;
            this.pnlDone.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlDone.Controls.Add(this.label5);
            this.pnlDone.Location = new System.Drawing.Point(706, 16);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(232, 458);
            this.pnlDone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "DONE";
            // 
            // pnlStories
            // 
            this.pnlStories.AutoScroll = true;
            this.pnlStories.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlStories.Controls.Add(this.label6);
            this.pnlStories.Location = new System.Drawing.Point(3, 16);
            this.pnlStories.Name = "pnlStories";
            this.pnlStories.Size = new System.Drawing.Size(218, 458);
            this.pnlStories.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "STORIES";
            // 
            // ScrumBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 567);
            this.Controls.Add(this.tabControl1);
            this.Name = "ScrumBoard";
            this.Text = "SCRUM BOARD";
            this.Load += new System.EventHandler(this.ScrumBoard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpProjeEkle.ResumeLayout(false);
            this.tbpProjeEkle.PerformLayout();
            this.tbpBoard.ResumeLayout(false);
            this.pnlinProgress.ResumeLayout(false);
            this.pnlinProgress.PerformLayout();
            this.pnlNotStarted.ResumeLayout(false);
            this.pnlNotStarted.PerformLayout();
            this.pnlDone.ResumeLayout(false);
            this.pnlDone.PerformLayout();
            this.pnlStories.ResumeLayout(false);
            this.pnlStories.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpProjeEkle;
        private System.Windows.Forms.TabPage tbpBoard;
        private System.Windows.Forms.Panel pnlinProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlNotStarted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlStories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.Label lblYazarAdi;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.Button btnTaskEkle;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Button btnStoriesEkle;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.CheckBox chbNotStarted;
        private System.Windows.Forms.CheckBox chbDone;
        private System.Windows.Forms.CheckBox chbInProgress;
        private System.Windows.Forms.TextBox txtPrjSorumlu;
        private System.Windows.Forms.Label lblPrjSorumlu;
        private System.Windows.Forms.DateTimePicker dtBitisTarihi;
        private System.Windows.Forms.DateTimePicker dtBaslangicTarihi;
    }
}

