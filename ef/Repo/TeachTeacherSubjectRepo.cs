using EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Repo
{
    public class TeachTeacherSubjectRepo
    {
        private List<TeachTeaherSubject> teachings;

        public List<TeachTeaherSubject> Teachings { get => teachings; set => teachings = value; }

        public TeachTeacherSubjectRepo()
        {
            teachings = new List<TeachTeaherSubject>();
            teachings.Add(new TeachTeaherSubject(1, 1));
            teachings.Add(new TeachTeaherSubject(1, 2));
            teachings.Add(new TeachTeaherSubject(1, 7));
            teachings.Add(new TeachTeaherSubject(2, 3));
            teachings.Add(new TeachTeaherSubject(2, 4));
            teachings.Add(new TeachTeaherSubject(2, 10));
            teachings.Add(new TeachTeaherSubject(3, 8));
            teachings.Add(new TeachTeaherSubject(4, 2));
            teachings.Add(new TeachTeaherSubject(4, 2));
            teachings.Add(new TeachTeaherSubject(5, 1));
            teachings.Add(new TeachTeaherSubject(5, 8));
            teachings.Add(new TeachTeaherSubject(5, 2));
            teachings.Add(new TeachTeaherSubject(6, 1));
            teachings.Add(new TeachTeaherSubject(6, 2));
            teachings.Add(new TeachTeaherSubject(6, 7));
            teachings.Add(new TeachTeaherSubject(7, 8));
            teachings.Add(new TeachTeaherSubject(8, 10));
            teachings.Add(new TeachTeaherSubject(8, 9));
            teachings.Add(new TeachTeaherSubject(8, 3));
            teachings.Add(new TeachTeaherSubject(9, 1));
            teachings.Add(new TeachTeaherSubject(9, 7));
            teachings.Add(new TeachTeaherSubject(9, 4));
            teachings.Add(new TeachTeaherSubject(10, 3));
            teachings.Add(new TeachTeaherSubject(10, 4));
            teachings.Add(new TeachTeaherSubject(10, 1));
            teachings.Add(new TeachTeaherSubject(10, 8));
        }       
    }
}


