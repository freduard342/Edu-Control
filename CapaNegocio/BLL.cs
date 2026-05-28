using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.EstudianteDal;

namespace CapaNegocio
{
    public class RolBll
    {
        private readonly RolDal _dal = new RolDal();
        public IEnumerable<RolDto> GetAll() => _dal.Mostrar();
        public bool Add(string nombre) => _dal.Insertar(nombre) > 0;
        public bool Update(RolDto r) => _dal.Actualizar(r.IdRol, r.NombreRol) > 0;
        public bool Delete(int id) => _dal.Eliminar(id) > 0;
    }

    public class UsuarioBll
    {
        private readonly UsuarioDal _dal = new UsuarioDal();
        public IEnumerable<UsuarioDto> GetAll() => _dal.Mostrar();
        public bool Add(UsuarioDto u) => _dal.Insertar(u) > 0;
        public bool Update(UsuarioDto u) => _dal.Actualizar(u) > 0;
        public bool Delete(int id) => _dal.Eliminar(id) > 0;
    }

    public class MaestroBll
    {
        private readonly MaestroDal _dal = new MaestroDal();
        public IEnumerable<MaestroDto> GetAll() => _dal.Mostrar();
        public bool Add(MaestroDto m) => _dal.Insertar(m) > 0;
        public bool Update(MaestroDto m) => _dal.Actualizar(m) > 0;
        public bool Delete(int id) => _dal.Eliminar(id) > 0;
    }

    public class EstudianteBll
    {
        private readonly EstudianteDal _dal = new EstudianteDal();
        public IEnumerable<EstudianteDto> GetAll() => _dal.Mostrar();
        public bool Add(EstudianteDto e) => _dal.Insertar(e) > 0;
        public bool Update(EstudianteDto e) => _dal.Actualizar(e) > 0;
        public bool Delete(int id) => _dal.Eliminar(id) > 0;
        public DateTime Fecha_Ingreso { get; set; }
    }

    public class CursoBll
    {
        private readonly CursoDal _dal = new CursoDal();
        public IEnumerable<CursoDto> GetAll() => _dal.Mostrar();
        public bool Add(CursoDto c) => _dal.Insertar(c) > 0;
        public bool Update(CursoDto c) => _dal.Actualizar(c) > 0;
        public bool Delete(int id) => _dal.Eliminar(id) > 0;
    }

    public class AsignaturaBll
    {
        private readonly AsignaturaDal _dal = new AsignaturaDal();
        public IEnumerable<AsignaturaDto> GetAll() => _dal.Mostrar();
        public bool Add(AsignaturaDto a) => _dal.Insertar(a) > 0;
        public bool Update(AsignaturaDto a) => _dal.Actualizar(a) > 0;
        public bool Delete(int id) => _dal.Eliminar(id) > 0;
    }

    public class MatriculaBll
    {
        private readonly MatriculaDal _dal = new MatriculaDal();
        public IEnumerable<MatriculaDto> GetAll() => _dal.Mostrar();
        public bool Add(MatriculaDto m) => _dal.Insertar(m) > 0;
        public bool Update(MatriculaDto m) => _dal.Actualizar(m) > 0;
        public bool Delete(int id) => _dal.Eliminar(id) > 0;
    }

    public class HorarioBll
    {
        private readonly HorarioDal _dal = new HorarioDal();
        public IEnumerable<HorarioDto> GetAll() => _dal.Mostrar();
        public bool Add(HorarioDto h) => _dal.Insertar(h) > 0;
        public bool Update(HorarioDto h) => _dal.Actualizar(h) > 0;
        public bool Delete(int id) => _dal.Eliminar(id) > 0;
    }

    public class CalificacionBll
    {
        private readonly CalificacionDal _dal = new CalificacionDal();
        public IEnumerable<CalificacionDto> GetAll() => _dal.Mostrar();
        public bool Add(CalificacionDto c) => _dal.Insertar(c) > 0;
        public bool Update(CalificacionDto c) => _dal.Actualizar(c) > 0;
        public bool Delete(int id) => _dal.Eliminar(id) > 0;
    }

    public class BoletinBll
    {
        private readonly BoletinDal _dal =
            new BoletinDal();

        
        public DataTable CargarCursos()
        {
            return _dal.CargarCursos();
        }


        public DataTable CargarEstudiantePorCurso(int idCurso)
        {
            return _dal.CargarEstudiantePorCurso(idCurso);
        }
        
        public DataTable BoletinEstudiante(int idCurso, int idEstudiante)
        {
            return _dal.BoletinEstudiante(idCurso, idEstudiante);
        }
    }
}
