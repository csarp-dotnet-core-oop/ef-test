using EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Repo
{
    class ParentRepo
    {
        List<Parent> parents;

        public List<Parent> Parents { get => parents; set => parents = value; }

        public ParentRepo()
        {
            parents = new List<Parent>();
            parents.Add(new Parent(1, "Kis Feri", true));
            parents.Add(new Parent(2, "Nagy János", false));
            parents.Add(new Parent(3, "Nagy Olga", true));
            parents.Add(new Parent(4, "Kis Szonja", true));
            parents.Add(new Parent(5, "Péter Ulrich", false));
            parents.Add(new Parent(6, "Kovács Richárd", true));
            parents.Add(new Parent(7, "Szántó Aliz", true));
            parents.Add(new Parent(8, "Kovács Nelli", false));
            parents.Add(new Parent(9, "Szántó Margit", true));
            parents.Add(new Parent(10, "Pék Fanni", true));
        }
    }
}
