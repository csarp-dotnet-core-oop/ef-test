using EF.Context;
using EF.Models;
using EF.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Services
{
    public class SubjectService
    {
        private RepositoryWrapper _repositoryWrapper;

        public SubjectService() 
        {
            _repositoryWrapper= new RepositoryWrapper();
        }

        public List<Subject> GetAll()
        {
            return _repositoryWrapper.SubjectRepo.GetAll().ToList();
        }
    }
}
