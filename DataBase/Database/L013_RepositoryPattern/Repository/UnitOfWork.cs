using L013_RepositoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L013_RepositoryPattern.Repository;

internal class UnitOfWork : IUnitOfWork
{
    public IMovieRepository Movies { get; private set; }

    private readonly MovieContext context;

    public UnitOfWork(MovieContext context)
    {
        this.context = context;
        Movies = new MovieRepository(context);
    }



    public int Commit()
    {
        return context.SaveChanges();
    }

    public void Dispose()
    {
        context.Dispose();
    }
}
