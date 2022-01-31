using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.DTOs
{
    public class PeliculaDetallesDTO : PeliculaDTO
    {
        public List<PeliculaDTO> Generos { get; set; }
        public List<ActorPeliculasCeacionDTO> Actores { get; set; }
    }
}
