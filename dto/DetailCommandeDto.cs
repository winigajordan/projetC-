using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCom.dto
{
    public class DetailCommandeDto
    {
        private int id;
        private string libelle;
        private int qte;
        private double prix;
        private DetailCommande details;

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public int Qte { get => qte; set => qte = value; }
        public double Prix { get => prix; set => prix = value; }
        public DetailCommande Details { get => details; set => details = value; }




    }
}
