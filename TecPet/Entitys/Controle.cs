﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecPet.Entitys
{
    class Controle
    {

        public  DateTime Agendamento { get; set; }
        public bool? Motor { get; set; }
        public float NivelRecipiente { get; set; }
        public List<string> Relatorio { get; set; }

        public Controle(DateTime agendamento, bool? motor, float nivelRecipiente)
        {
            Agendamento = agendamento;
            Motor = motor;
            NivelRecipiente = nivelRecipiente;                 

        }



    }
}
