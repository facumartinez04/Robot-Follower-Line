using BLL.Implementations;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_TD
{
    public partial class Form1 : Form
    {



        Sensor sensor1 = new Sensor(true);
        Sensor sensor2 = new Sensor(false);
        Motor motorIzquierdo = new Motor(0,"");
        Motor motorDerecho = new Motor(0, "");
        Parlante parlante = new Parlante();
        Robot robot;
        RobotBLL _robot;



        public Form1()
        {
            InitializeComponent();
            robot = new Robot(sensor1, sensor2, motorIzquierdo, motorDerecho, parlante);
            _robot = new RobotBLL(robot);
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            try
            {
                sensor1.Valor = true;
                sensor2.Valor = true;
                Sensores();
                _robot.EvaluarMovimiento();
            }catch(Exception ex)
            {
                Sensores();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            try
            {
                sensor1.Valor = true;
                sensor2.Valor = false;
                Sensores();
                _robot.EvaluarMovimiento();


            }
            catch (Exception ex)
            {

                Sensores();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            try
            {
                sensor1.Valor = false;
                sensor2.Valor = true;
                Sensores();
                _robot.EvaluarMovimiento();



            }
            catch (Exception ex)
            {
                Sensores();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            try
            {
                sensor1.Valor = false;
                sensor2.Valor = false;
                Sensores();
                _robot.EvaluarMovimiento();
                
            }
            catch (Exception ex)
            {
                Sensores();
                MessageBox.Show(ex.Message);
            }
        }



        private void Sensores()
        {


            lblmotorder.Text = motorDerecho.Direccion.ToString();
            lblmotorizq.Text = motorIzquierdo.Direccion.ToString();

            txtPorcentajeIzq.Text = motorIzquierdo.Potencia.ToString() + "%";
            txtPorcentajeDer.Text = motorDerecho.Potencia.ToString() + "%";


            if (sensor1.Valor == false && sensor2.Valor == false)
            {
                panelsensor1.BackColor = Color.Orange;
                txtsensor1estado.Text = "Fuera de linea";

                panelsensor2.BackColor = Color.Orange;
                txtsensor2estado.Text = "Fuera de linea";
                return;
            }

            if (!sensor1.Valor)
            {
                panelsensor1.BackColor = Color.Red;
                txtsensor1estado .Text = "Fuera de linea";
            }
            else
            {
                panelsensor1.BackColor = Color.Green;
                txtsensor1estado.Text = "En la linea";
            }

            if (!sensor2.Valor)
            {
                panelsensor2.BackColor = Color.Red;
                txtsensor2estado.Text = "Fuera de linea";
            }
            else
            {
                motorDerecho.Potencia = 100;
                
                panelsensor2.BackColor = Color.Green;
                txtsensor2estado.Text = "En la linea";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtsensor1estado.Text = "";
            txtsensor2estado.Text = "";
        }
    }
}
