﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaNet
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor();
            profesor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alumnos alumnos = new Alumnos();
            alumnos.Show();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        private void button5_Click(object sender, EventArgs e)
        {
            Especialidad esp = new Especialidad();
            esp.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Planes planes = new Planes();
            Comision comisiones = new Comision();
            comisiones.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Plan planes = new Plan();
            planes.Show();
        }
    }
}
