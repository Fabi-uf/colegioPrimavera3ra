using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;

namespace colegioPrimavera3ra.Controllers
{
    public class Alumno
        {
            public int Id { get; set; }

            [Required]
            public required string Nombre { get; set; }

            [Required]
            public int Edad { get; set; }

            [Required]
            public required string Curso { get; set; }
        }
    }
