using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;

namespace colegioPrimavera3ra.Controllers
{
    internal class ApplicationDbContext
    {
        public required object Alumnos { get; internal set; }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }

        internal object Entry(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}