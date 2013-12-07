﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using proyecto_w.ABM_Afiliado;
using proyecto_w.ABM_Rol;
using proyecto_w.ABM_Profesional;
using proyecto_w.Compra_de_Bono;
using proyecto_w.Registro_de_Llegada;
using proyecto_w.Cancelar_Atencion;
using proyecto_w.Registrar_Agenda;
using proyecto_w.Listado_Estadistico;
using proyecto_w.Registro_Resultado_Atencion;

namespace proyecto_w
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }

        public void setFunctions(List<String> functionList)
        {
            //TODO: Hacer visible los botones en base a las funcionabilidades que tengo en la 
            System.Console.Write(functionList.ToString());
            if (functionList.IndexOf("ABM_AFILIADO") != -1) btnABMAfiliado.Show();
            if (functionList.IndexOf("ABM_ROL") != -1) btnABMRol.Show();
            if (functionList.IndexOf("ABM_PROFESIONAL") != -1) btnABMProfesional.Show();
        }

        //private void btnABMAfiliado_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    frmABMAfiliado afiliadoForm = new frmABMAfiliado();
        //    afiliadoForm.ShowDialog();
        //    this.Show();
        //}

        private void btnABMAfiliado_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmABMAfiliado afiliadoForm = new frmABMAfiliado();
            afiliadoForm.ShowDialog();
            this.Show();
        }

        private void btnABMRol_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmABMRol rolForm = new frmABMRol();
            rolForm.ShowDialog();
            this.Show();
        }

        private void btnABMProfesional_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmABMProfesional profesionalForm = new frmABMProfesional();
            profesionalForm.ShowDialog();
            this.Show();

        }

        private void btnCompraDeBono_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmCompra_de_Bono compraBonoForm = new frmCompra_de_Bono();
            compraBonoForm.ShowDialog();
            this.Show();
        }

        private void btnRegistrarLlegada_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarLlegada llegadaForm = new frmRegistrarLlegada();
            llegadaForm.ShowDialog();
            this.Show();

        }

        private void btnCancelarAtencion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelarAtencion cancelarAtencionForm = new frmCancelarAtencion();
            cancelarAtencionForm.ShowDialog();
            this.Show();
        }

        private void btnRegistrarAgenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarAgenda registrarAgendaForm = new frmRegistrarAgenda();
            registrarAgendaForm.ShowDialog();
            this.Show();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadoEstadisticoForm Listadofrom = new ListadoEstadisticoForm();
            Listadofrom.ShowDialog();
            this.Show();
        }

        private void btnRegistroResultadoAtencion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Resultado_Atencion_Form regiResulAtenForm = new Registro_Resultado_Atencion_Form();
            regiResulAtenForm.ShowDialog();
            this.Show();
        }

    }
}
