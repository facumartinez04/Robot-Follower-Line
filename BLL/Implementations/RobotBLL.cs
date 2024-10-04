using BLL.Implementations.States;
using BLL.Interfaces;
using Dao.Factory;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class RobotBLL
    {
        private IEstadoRobot _estadoActual;
        private readonly Robot _robot;

        public RobotBLL(Robot robot)
        {
            _robot = robot;
        }

        public Robot GetEstado()
        {
            return _robot;
             
        }

        public void SetEstado(IEstadoRobot nuevoEstado)
        {
            _estadoActual = nuevoEstado;
        }

        public void EjecutarMovimiento()
        {

            MisionBLL.Current.GuardarMision(new Mision(DateTime.Now, _robot.Sensor1.Valor, _robot.Sensor2.Valor));
            _estadoActual?.ManejarMovimiento(_robot);
        }

        public void EvaluarMovimiento()
        {
            if (_robot.Sensor1.Valor && _robot.Sensor2.Valor)
            {
                SetEstado(new AdelanteState());

            }
            else if (!_robot.Sensor1.Valor && _robot.Sensor2.Valor)
            {
                SetEstado(new GiroDerechaState());

            }
            else if (_robot.Sensor1.Valor && !_robot.Sensor2.Valor)
            {
                SetEstado(new GiroIzquierdaState());
            }
            else
            {
                SetEstado(new AtrasState());
            }

            EjecutarMovimiento();
        }


   



    }
}
