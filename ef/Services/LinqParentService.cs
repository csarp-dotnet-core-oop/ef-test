using EF.Models;
using EF.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Services
{
    class LinqParentService
    {
        private ParentRepo parentRepo;

        public LinqParentService()
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
