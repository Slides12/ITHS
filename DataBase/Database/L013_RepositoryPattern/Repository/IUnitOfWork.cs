using L013_RepositoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L013_RepositoryPattern.Repository;

internal interface IUnitOfWork : IDisposable
{

    IMovieRepository Movies { get; }
    int Commit();

}
