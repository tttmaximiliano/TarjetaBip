using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaBip {
    class ClaseEstatica {

        public ClaseEstatica() { }

        private static int[] Valor_Dia = { 700, 720, 750, 710, 760, 690, 680 };

        private static int[,] VALOR_HORARIOS = {
           {6, 9, 120 },
           {9, 18, 150 },
           {18, 21, 100 }
        };
        public int ValorPasaje() {

           //hora actual
           Int32 hora = DateTime.Now.Hour;

            //dia de la semana en numero 1 al 7
            int dia = (int)DateTime.Now.DayOfWeek;
            int costo_dia = Valor_Dia[dia];

            int costo_total = 0;
            int costo_hora;

            if (hora >= VALOR_HORARIOS[0, 0] || hora <= VALOR_HORARIOS[0, 1]) {

                costo_hora = VALOR_HORARIOS[0,2];
                costo_total = costo_dia + costo_hora;

            } else if (hora >= VALOR_HORARIOS[1, 0] || hora <= VALOR_HORARIOS[1, 1]) {

                costo_hora = VALOR_HORARIOS[1, 2];
                costo_total = costo_dia + costo_hora;

            } else if(hora >= VALOR_HORARIOS[2, 0] || hora <= VALOR_HORARIOS[2, 1]) {

                costo_hora = VALOR_HORARIOS[2, 2];
                costo_total = costo_dia + costo_hora; 
            }
            return costo_total;
        }
    }
}
