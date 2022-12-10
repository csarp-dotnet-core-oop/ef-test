using EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Repo
{
    public class TeacherRepo
    {
        List<Teacher> teachers;

        public List<Teacher> Teachers { get => teachers; set => teachers = value; }

        public TeacherRepo()
        {
            teachers = new List<Teacher>();
            teachers.Add(new Teacher(1, "Feldolgozó Feri", true,false));
            teachers.Add(new Teacher(2, "Jegyölő János", false, false));
            teachers.Add(new Teacher(3, "Olvasó Olga", true, true));
            teachers.Add(new Teacher(4, "Számoló Szonja", true,true));
            teachers.Add(new Teacher(5, "Utazó Ulrich", false, false));
            teachers.Add(new Teacher(6, "Részeg Richárd", true, false));
            teachers.Add(new Teacher(7, "Álmodozó Aliz", true, true));
            teachers.Add(new Teacher(8, "Nagy Nelli", false, true));
            teachers.Add(new Teacher(9, "Megértő Margit", true, true));
            teachers.Add(new Teacher(10, "Fuldokló Fanni", true, true));
        }
    }
}
