using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseTrip
{
    public partial class Form1 : Form
    {
        //Deneme barış commit
        public Form1()
        {
            InitializeComponent();
        }
        //Deneme Commit
        public int oyunTahtasiBuyuklugu = 0;
        public int count=0;
        DateTime baslangic = new DateTime();
        private void btnOyna_Click(object sender, EventArgs e)
        {
            count = 0;
            lblTebrik.Text = "";
            if (rdBes.Checked)
                oyunTahtasiBuyuklugu = 5;
            else if (rdAlti.Checked)
                oyunTahtasiBuyuklugu = 6;
            else if (rdYedi.Checked)
                oyunTahtasiBuyuklugu = 7;
            else if (rdSekiz.Checked)
                oyunTahtasiBuyuklugu = 8;
            else if (rdDokuz.Checked)
                oyunTahtasiBuyuklugu = 9;
            else
                throw new Exception("Seçtiğinizden emin olun...");
            grdOyun.Enabled = true;
            grdOyun.Rows.Clear();
            grdOyun.Columns.Clear();
            grdOyun.Size = new Size(oyunTahtasiBuyuklugu * 50, oyunTahtasiBuyuklugu * 50);
            for (int i = 0; i < oyunTahtasiBuyuklugu; i++)
            {
                grdOyun.Columns.Add(null, null);
                DataGridViewColumn Column = grdOyun.Columns[i];
                Column.Width = 40;
            }
            for (int j = 0; j < oyunTahtasiBuyuklugu-1; j++)
            {
                grdOyun.Rows.Add(null, null);
                DataGridViewRow Row = grdOyun.Rows[j];
                Row.Height = 40;
            }

        }
        public void GridClick(object sender,DataGridViewCellEventArgs e)
        {
            int SelectedRow = grdOyun.CurrentCell.RowIndex;
            int SelectedColumn = grdOyun.CurrentCell.ColumnIndex;
            

            if (grdOyun.Rows[SelectedRow].Cells[SelectedColumn].Style.BackColor == Color.Yellow||count==0)
            {
                if(count==0)
                    baslangic = DateTime.Now;

                lblZaman.Text = (DateTime.Now - baslangic).ToString();
                for (int i = 0; i < oyunTahtasiBuyuklugu; i++)
                {
                    for (int j = 0; j < oyunTahtasiBuyuklugu; j++)
                    {
                        if (grdOyun.Rows[i].Cells[j].Style.BackColor != Color.Purple)
                            grdOyun.Rows[i].Cells[j].Style.BackColor = Color.White;

                    }

                }
                count++;
                grdOyun.Rows[grdOyun.CurrentCell.RowIndex].Cells[grdOyun.CurrentCell.ColumnIndex].Value = count;
                grdOyun.Rows[grdOyun.CurrentCell.RowIndex].Cells[grdOyun.CurrentCell.ColumnIndex].Style.BackColor = Color.Purple;
                
                if (SelectedRow+2<oyunTahtasiBuyuklugu&&SelectedColumn+1<oyunTahtasiBuyuklugu&& grdOyun.Rows[SelectedRow+2].Cells[SelectedColumn+1].Style.BackColor!=Color.Purple)
                    grdOyun.Rows[SelectedRow + 2].Cells[SelectedColumn + 1].Style.BackColor = Color.Yellow;
                if (SelectedRow + 2<oyunTahtasiBuyuklugu&&0<=SelectedColumn - 1 && grdOyun.Rows[SelectedRow+2].Cells[SelectedColumn-1].Style.BackColor != Color.Purple)
                    grdOyun.Rows[SelectedRow + 2].Cells[SelectedColumn -1].Style.BackColor = Color.Yellow;
                if (SelectedRow - 2>=0&&SelectedColumn + 1<oyunTahtasiBuyuklugu && grdOyun.Rows[SelectedRow-2].Cells[SelectedColumn+1].Style.BackColor != Color.Purple)
                    grdOyun.Rows[SelectedRow - 2].Cells[SelectedColumn + 1].Style.BackColor = Color.Yellow;
                if (SelectedRow - 2>=0&&SelectedColumn - 1>=0 && grdOyun.Rows[SelectedRow-2].Cells[SelectedColumn-1].Style.BackColor != Color.Purple)
                    grdOyun.Rows[SelectedRow -2].Cells[SelectedColumn -1].Style.BackColor = Color.Yellow;
                if (SelectedRow +1<oyunTahtasiBuyuklugu&&SelectedColumn + 2<oyunTahtasiBuyuklugu && grdOyun.Rows[SelectedRow+1].Cells[SelectedColumn+2].Style.BackColor != Color.Purple)
                    grdOyun.Rows[SelectedRow + 1].Cells[SelectedColumn + 2].Style.BackColor = Color.Yellow;
                if (SelectedRow + 1<oyunTahtasiBuyuklugu&&SelectedColumn -2>=0 && grdOyun.Rows[SelectedRow+1].Cells[SelectedColumn-2].Style.BackColor != Color.Purple)
                    grdOyun.Rows[SelectedRow + 1].Cells[SelectedColumn -2].Style.BackColor = Color.Yellow;
                if (SelectedRow -1>=0&&SelectedColumn + 2<oyunTahtasiBuyuklugu && grdOyun.Rows[SelectedRow-1].Cells[SelectedColumn+2].Style.BackColor != Color.Purple)
                    grdOyun.Rows[SelectedRow -1].Cells[SelectedColumn + 2].Style.BackColor = Color.Yellow;
                if (SelectedRow -1>=0&&SelectedColumn -2>=0 && grdOyun.Rows[SelectedRow-1].Cells[SelectedColumn-2].Style.BackColor != Color.Purple)
                    grdOyun.Rows[SelectedRow -1].Cells[SelectedColumn -2].Style.BackColor = Color.Yellow;
            }
            if(grdOyun.Rows[SelectedRow].Cells[SelectedColumn].Style.BackColor == Color.Yellow)
            {
                grdOyun.Rows[SelectedRow].Cells[SelectedColumn].Value = count;
                grdOyun.Rows[SelectedRow].Cells[SelectedColumn].Style.BackColor = Color.Purple;
            }
            lblPuan.Text = count.ToString();
            if (count == oyunTahtasiBuyuklugu * oyunTahtasiBuyuklugu)
            {
                lblTebrik.ForeColor = Color.Red;
                lblTebrik.Text = "Tebrikler kazandınız!!! :)";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
