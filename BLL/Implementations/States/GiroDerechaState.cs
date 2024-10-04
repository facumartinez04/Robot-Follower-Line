using BLL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations.States
{
    internal class GiroDerechaState : IEstadoRobot
    {
        public void ManejarMovimiento(Robot robot)
        {
            robot.MotorIzquierdo.Potencia = 50;
            robot.MotorIzquierdo.Direccion = "🡩";
            robot.MotorDerecho.Potencia = 50;
            robot.MotorDerecho.Direccion = "🡫";
            throw new Exception("Robot gira a la derecha.");
        }
 
    }
}
