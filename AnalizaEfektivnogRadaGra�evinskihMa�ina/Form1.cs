using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnalizaEfektivnogRadaGrađevinskihMašina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mniUnosKalendar_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            frmKalendar profesorForm = new frmKalendar();
            profesorForm.MdiParent = this;
            profesorForm.WindowState = FormWindowState.Maximized;
            profesorForm.ControlBox = false;
            profesorForm.Show();
        }

        private void mniUnosMasina_Click(object sender, EventArgs e)
        {
            List<Kalendar> kalendarList = Kalendar.ucitajKalendar();
            if (kalendarList.Count != 0)
            {
                CloseAllForms();
                frmMasine profesorForm = new frmMasine();
                profesorForm.MdiParent = this;
                profesorForm.WindowState = FormWindowState.Maximized;
                profesorForm.ControlBox = false;
                profesorForm.Show();
            }
            else { MessageBox.Show("Nije unet kalendar!"); }
        }

        private void mniUnosPomocnaMasina_Click(object sender, EventArgs e)
        {
            List<Kalendar> kalendarList = Kalendar.ucitajKalendar();
            if (kalendarList.Count != 0)
            {
                CloseAllForms();
                frmPomocneMasine profesorForm = new frmPomocneMasine();
                profesorForm.MdiParent = this;
                profesorForm.WindowState = FormWindowState.Maximized;
                profesorForm.ControlBox = false;
                profesorForm.Show();
            }
            else { MessageBox.Show("Nije unet kalendar!"); }
        }

        private void mniUnosPosao_Click(object sender, EventArgs e)
        {
            List<Masina> masinaList = Masina.ucitajMasine();
            if (masinaList.Count != 0)
            {
                CloseAllForms();
                frmPosaoPocetna profesorForm = new frmPosaoPocetna();
                profesorForm.MdiParent = this;
                profesorForm.WindowState = FormWindowState.Maximized;
                profesorForm.ControlBox = false;
                profesorForm.Show();
            }
            else { MessageBox.Show("Nemate podataka!"); }
        }

        private void mniPregledKalendar_Click(object sender, EventArgs e)
        {
            List<Kalendar> kalendarList = Kalendar.ucitajKalendar();
            if (kalendarList.Count != 0)
            {
                CloseAllForms();
                frmIzvestajKalendar profesorForm = new frmIzvestajKalendar();
                profesorForm.MdiParent = this;
                profesorForm.WindowState = FormWindowState.Maximized;
                profesorForm.ControlBox = false;
                profesorForm.Show();
            }
            else { MessageBox.Show("Nije unet kalendar!"); }
        }

        private void mniPregledPoslovi_Click(object sender, EventArgs e)
        {
            List<Posao> posaoList = Posao.ucitajPoslove();
            if (posaoList.Count != 0)
            {
                CloseAllForms();
                frmIzvestajPosao profesorForm = new frmIzvestajPosao();
                profesorForm.MdiParent = this;
                profesorForm.WindowState = FormWindowState.Maximized;
                profesorForm.ControlBox = false;
                profesorForm.Show();
            }
            else { MessageBox.Show("Nemate nijedan posao za pregled!"); }
        }

        public void pokreniPosaoPocetna()
        {
            CloseAllForms();
            frmPosaoPocetna profesorForm = new frmPosaoPocetna();
            profesorForm.MdiParent = this;
            profesorForm.WindowState = FormWindowState.Maximized;
            profesorForm.ControlBox = false;
            profesorForm.Show();
        }

        public void pokreniPosaoZavrsna(VrstaPoslaZaPosao vpp)
        {
            CloseAllForms();
            frmPosaoZavrsna profesorForm = new frmPosaoZavrsna(vpp);
            profesorForm.MdiParent = this;
            profesorForm.WindowState = FormWindowState.Maximized;
            profesorForm.ControlBox = false;
            profesorForm.Show();
        }

        private void mniPocetna_Click(object sender, EventArgs e)
        {
            CloseAllForms();
        }

        private void CloseAllForms()
        {
            Form[] formToClose = null;
            int i = 1;
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    Array.Resize(ref formToClose, i);
                    formToClose[i - 1] = form;
                    i++;
                }
            }
            if (formToClose != null)
                for (int j = 0; j < formToClose.Length; j++)
                    formToClose[j].Dispose();
        }
    }
}
