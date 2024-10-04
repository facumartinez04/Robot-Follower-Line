using BLL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL.Implementations.States
{
    public class AtrasState : IEstadoRobot
    {
        public void ManejarMovimiento(Robot robot)
        {
            robot.MotorIzquierdo.Potencia = 50;
            robot.MotorIzquierdo.Direccion = "🡫";
            robot.MotorDerecho.Potencia = 50;
            robot.MotorDerecho.Direccion = "🡫";
            robot.Parlante.EmitirSonido();
            throw new Exception("Robot se mueve hacia atrás.");

        }
    }
}
