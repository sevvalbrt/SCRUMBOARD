using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ScrumTableÖdev
{
    public partial class ScrumBoard : Form
    {
        Panel[] panels;
        private Point p;
        public ScrumBoard()
        {
            InitializeComponent();

            panels = new Panel[] { pnlStories, pnlDone, pnlinProgress, pnlNotStarted };


            pnlStories.AllowDrop = true;
            pnlDone.AllowDrop = true;
            pnlinProgress.AllowDrop = true;
            pnlNotStarted.AllowDrop = true;

            pnlStories.DragEnter += panel_DragEnter;
            pnlDone.DragEnter += panel_DragEnter;
            pnlinProgress.DragEnter += panel_DragEnter;
            pnlNotStarted.DragEnter += panel_DragEnter;

            pnlStories.DragDrop += panel_DragDrop;
            pnlDone.DragDrop += panel_DragDrop;
            pnlinProgress.DragDrop += panel_DragDrop;
            pnlNotStarted.DragDrop += panel_DragDrop;
        }
        int sayac1 = 0, sayac2 = 0, sayac3 = 0;
        Random random = new Random();
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\barut\source\repos\ScrumTableÖdev\Bilgiler.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        void panel_DragEnter(object sender, DragEventArgs e)
        {
          e.Effect  = DragDropEffects.All;
        }
        void panel_DragDrop(object sender, DragEventArgs e)
        {
            Panel pnl = sender as Panel;
            Label lbl= e.Data.GetData(typeof(Label)) as Label;
            lbl.Location = pnl.PointToClient(new Point(e.X, e.Y));
            pnl.Controls.Add(lbl);
        }
        void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            p = e.Location;
            if (e.Button == MouseButtons.Left)
                DoDragDrop(sender, DragDropEffects.All);
        }

        private void tbpProjeEkle_Click(object sender, EventArgs e)
        {

        }

        private void ScrumBoard_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(pnlDone, true);
            ControlExtension.Draggable(pnlinProgress, true);
            ControlExtension.Draggable(pnlNotStarted, true);
        }

        private void btnStoriesEkle_Click(object sender, EventArgs e)
        {
            if (txtYazarAdi.Text != "" && dtBaslangicTarihi.Text != "" && dtBitisTarihi.Text != "" && txtKonu.Text != "")
            {
                komut.Connection = baglanti;
                komut.CommandText = " INSERT INTO BilgiEkle(YazarAdi,BaslangicTarihi,BitisTarihi,Konu) VALUES ('" + txtYazarAdi.Text + "','" + dtBaslangicTarihi.Text + "','" + dtBitisTarihi.Text + "','" + txtKonu.Text + "')";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt yapıldı");
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız");
            }

            Label label1= new Label();
            label1.Size = new System.Drawing.Size(100, 20);
            label1.Width = 200;
            label1.Height = 100;
            label1.Location = new System.Drawing.Point(10, 105 + 105 * sayac1++);
            label1.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            pnlStories.Controls.Add(label1);
            txtYazarAdi.Text = "";
            dtBaslangicTarihi.Text = "";
            dtBitisTarihi.Text = "";
            txtKonu.Text = "";
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT YazarAdi,BaslangicTarihi,BitisTarihi,Konu FROM BilgiEkle", baglanti);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = dr["YazarAdi"].ToString() + Environment.NewLine + dr["BaslangicTarihi"].ToString() + Environment.NewLine + dr["BitisTarihi"].ToString() + Environment.NewLine + dr["Konu"].ToString();

            }
            baglanti.Close();

        }

        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            if (txtTask.Text !=""  && txtPrjSorumlu.Text != "")
            {
                komut.Connection = baglanti;
                komut.CommandText = " INSERT INTO BilgiEkle(Task,ProjeSorumlusu) VALUES ('" + txtTask.Text + "','" + txtPrjSorumlu.Text + "')";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt yapıldı");
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız");
            }

            lblTask = new Label();
            lblTask.Size = new System.Drawing.Size(100, 20);
            lblTask.Width = 150;
            lblTask.Height = 100;
            
            lblTask.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            if(chbNotStarted.Checked==true)
            {
                lblTask.Location = new System.Drawing.Point(5, 55 + 55 * sayac1++);
                pnlNotStarted.Controls.Add(lblTask);
                this.lblTask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
                chbNotStarted.Checked = false;
            }
            else if(chbInProgress.Checked==true)
            {
                lblTask.Location = new System.Drawing.Point(5, 55 + 55 * sayac2++);
                pnlinProgress.Controls.Add(lblTask);
              this.lblTask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
                chbInProgress.Checked = false;
            }
            else if (chbDone.Checked == true)
            {
                lblTask.Location = new System.Drawing.Point(5, 55 + 55 * sayac3++);
                pnlDone.Controls.Add(lblTask);
                this.lblTask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
                chbDone.Checked = false;
            }
            else
            {
                MessageBox.Show("Seçim Yapınız");
            }
            txtTask.Text = "";
            txtPrjSorumlu.Text = "";
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Task,ProjeSorumlusu FROM BilgiEkle", baglanti);
            OleDbDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                lblTask.Text = dr2["ProjeSorumlusu"].ToString() + Environment.NewLine + dr2["Task"].ToString();

            }
            baglanti.Close();
        }
        

    }
}
