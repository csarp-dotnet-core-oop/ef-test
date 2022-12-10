using EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Repo
{
    public class SubjectRepo
    {
        private List<Subject> subjects;

        public List<Subject> Subjects { get => subjects; set => subjects = value; }

        public SubjectRepo()
        {
            subjects = new List<Subject>();
            subjects.Add(new Subject(1, "Matematika"));
            subjects.Add(new Subject(2, "Magyar nyelv"));
            subjects.Add(new Subject(3, "Irodalom"));
            subjects.Add(new Subject(4, "Angol nyelv"));
            subjects.Add(new Subject(5, "Német nyelv"));
            subjects.Add(new Subject(6, "Történelem"));
            subjects.Add(new Subject(7, "Rajz"));
            subjects.Add(new Subject(8, "Testnevelés"));
            subjects.Add(new Subject(9, "Fizika"));
            subjects.Add(new Subject(10, "Kémia"));
        }
    }
}

