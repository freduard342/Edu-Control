using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class RolDto
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
    }

    public class UsuarioDto
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public int IdRol { get; set; }
    }

    public class MaestroDto
    {
        public int IdMaestro { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public int IdUsuario { get; set; }
    }

    public class EstudianteDto
    {
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NombrePadres { get; set; }
        public string TelefonoPadre { get; set; }
        public object FechaIngreso { get; set; }
    }

    public class CursoDto
    {
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public string Nivel { get; set; }
        public string Tanda { get; set; }
        public int IdMaestro { get; set; }
    }

    public class AsignaturaDto
    {
        public int IdAsignatura { get; set; }
        public string NombreAsignatura { get; set; }
    }

    public class MatriculaDto
    {
        public int IdMatricula { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdEstudiante { get; set; }
        public int IdCurso { get; set; }
    }

    public class HorarioDto
    {
        public int IdHorario { get; set; }
        public string Aula { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string Dia { get; set; }
        public int IdAsignatura { get; set; }
        public int IdCurso { get; set; }
    }

    public class CalificacionDto
    {
        public int IdCalificacion { get; set; }
        public decimal P1 { get; set; }
        public decimal P2 { get; set; }
        public decimal P3 { get; set; }
        public decimal P4 { get; set; }
        public int IdAsignatura { get; set; }
        public int IdMaestro { get; set; }
        public int IdMatricula { get; set; }
    }
}
