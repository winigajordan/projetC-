using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCom.dto
{
    public class CommandeDto
    {
        private int id;
        private string reference;
        private string etat;
        private DateTime date;
        private Client cmdUder;


        public int Id { get => id; set => id = value; }
        public string Reference { get => reference ; set => reference = value; }
        public string Etat { get => etat; set => etat = value; }
        public DateTime Date { get => date; set => date = value; }
        public Client CmdUser { get => cmdUder; set => cmdUder = value; }
        


    }
}
