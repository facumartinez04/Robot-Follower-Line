using BLL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations.States
{
    internal class AdelanteState : IEstadoRobot
    {
        public void ManejarMovimiento(Robot robot)
        {
            robot.MotorIzquierdo.Potencia = 100;
            robot.MotorIzquierdo.Direccion = "🡩";
            robot.MotorDerecho.Potencia = 100;
            robot.MotorDerecho.Direccion = "🡩";
            throw new Exception("Robot avanza hacia adelante.");
        }
    }
}
