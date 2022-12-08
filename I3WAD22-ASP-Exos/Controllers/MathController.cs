using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace I3WAD22_ASP_Exos.Controllers
{
    public class MathController : Controller
    {
        [Route("Math/{nombre}/auCarre")]
        [Route("Math/Carre/{nombre}")]
        public int Carre(int nombre)
        {
            return nombre * nombre;
        }

        [Route("Math/Multiple/{nombre}")]
        [Route("Math/Table/{nombre}")]
        public string Multiple(int nombre)
        {
            string result = "";

            for (int i = 1; i <= 10; i++)
            {
                result += $"{nombre} X {i} = {nombre*i}\n";
            }

            return result;
        }

        [Route("Math/Division/{nombre1?}/{nombre2?}")]
        [Route("Math/{nombre1}/divisePar/{nombre2}")]
        public string Division(int nombre1, int nombre2)
        {
            if(nombre2 != 0) return (nombre1 / (double)nombre2).ToString();
            return "Attention, division par 0 impossible.";
        }
    }
}
