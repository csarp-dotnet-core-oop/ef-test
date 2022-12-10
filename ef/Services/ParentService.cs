using EF.Models;
using EF.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Services
{
    class ParentService
    {
        private ParentRepo parentRepo;

        public ParentService()
        {
            parentRepo = new ParentRepo();
        }

        public void ParentWomanLinq()
        {
            //IEnumerable<Parent> parent= from 
        }

        public void ParantWomanLambda()
        {
            //List<Parent> parent=parentRepo.Parents
        }
    }
}
