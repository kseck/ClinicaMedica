﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FrmConsultorioConsultar : Form
    {
        public FrmConsultorioConsultar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmConsultorioConsultarcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.TB_Consultorio' table. You can move, or remove it, as needed.
            this.tB_ConsultorioTableAdapter.Fill(this.clinicaMedicaBDDataSet.TB_Consultorio);
            // TODO: This line of code loads data into the 'clinicaMedicaBDDataSet.ConsultorioExame' table. You can move, or remove it, as needed.
            this.consultorioExameTableAdapter.Fill(this.clinicaMedicaBDDataSet.ConsultorioExame);

        }
    }
}