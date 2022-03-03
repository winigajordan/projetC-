using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCom.dto
{
    public class LivraisonDto
    {
        private int id;
        private string reference;
        private DateTime Xdate;
        private Commande cmd;
        private double prix;

        public int Id { get => id; set => id = value; }
        public double Prix { get => prix; set => prix = value; }
        public string Reference { get => reference ; set => reference = value; }
        public DateTime DateX { get => Xdate; set => Xdate = value; }
        public Commande Commande { get => cmd; set => cmd = value; }


    }
}
