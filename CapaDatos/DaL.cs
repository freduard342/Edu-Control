using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class RolDal
    {
        public IEnumerable<RolDto> Mostrar()
        {
            var lista = new List<RolDto>();
            var conexion = new Conexion();
            try
            {
                conexion.AbrirConexion();
                using (var cmd = new SqlCommand("SP_MostrarRol", conexion.cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new RolDto
                            {
                                IdRol = Convert.ToInt32(r["Id_Rol"]),
                                NombreRol = r["Nombre_Rol"].ToString()
                            });
                        }
                    }
                }
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return lista;
        }

        public int Insertar(string nombreRol)
        {
            var conexion = new Conexion();
            try
            {
                conexion.AbrirConexion();
                using (var cmd = new SqlCommand("SP_InsertarRol", conexion.cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre_Rol", nombreRol ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery();
                }
            }
            finally { conexion.CerrarConexion(); }
        }

        public int Actualizar(int id, string nombreRol)
        {
            var conexion = new Conexion();
            try
            {
                conexion.AbrirConexion();
                using (var cmd = new SqlCommand("SP_ActualizarRol", conexion.cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Rol", id);
                    cmd.Parameters.AddWithValue("@Nombre_Rol", nombreRol ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery();
                }
            }
            finally { conexion.CerrarConexion(); }
        }

        // Eliminación lógica
        public int Eliminar(int id)
        {
            var conexion = new Conexion();
            try
            {
                conexion.AbrirConexion();
                using (var cmd = new SqlCommand("SP_DesactivarRol", conexion.cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Rol", id);
                    return cmd.ExecuteNonQuery();
                }
            }
            finally { conexion.CerrarConexion(); }
        }
    }

    public class UsuarioDal
    {
        public IEnumerable<UsuarioDto> Mostrar()
        {
            var lista = new List<UsuarioDto>();
            var conexion = new Conexion();
            try
            {
                conexion.AbrirConexion();
                using (var cmd = new SqlCommand("SP_MostrarUsuario", conexion.cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new UsuarioDto
                            {
                                IdUsuario = Convert.ToInt32(r["Id_Usuario"]),
                                NombreUsuario = r["Nombre_Usuario"].ToString(),
                                Contrasena = r["Contraseña"].ToString(),
                                IdRol = Convert.ToInt32(r["Id_Rol"])
                            });
                        }
                    }
                }
            }
            finally { conexion.CerrarConexion(); }
            return lista;
        }

        public int Insertar(UsuarioDto u)
        {
            var conexion = new Conexion();
            try
            {
                conexion.AbrirConexion();
                using (var cmd = new SqlCommand("SP_InsertarUsuario", conexion.cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre_Usuario", u.NombreUsuario ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Contraseña", u.Contrasena ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Id_Rol", u.IdRol);
                    return cmd.ExecuteNonQuery();
                }
            }
            finally { conexion.CerrarConexion(); }
        }

        public int Actualizar(UsuarioDto u)
        {
            var conexion = new Conexion();
            try
            {
                conexion.AbrirConexion();
                using (var cmd = new SqlCommand("SP_ActualizarUsuario", conexion.cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Usuario", u.IdUsuario);
                    cmd.Parameters.AddWithValue("@Nombre_Usuario", u.NombreUsuario ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Contraseña", u.Contrasena ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Id_Rol", u.IdRol);
                    return cmd.ExecuteNonQuery();
                }
            }
            finally { conexion.CerrarConexion(); }
        }

        public int Eliminar(int id)
        {
            var conexion = new Conexion();
            try
            {
                conexion.AbrirConexion();
                using (var cmd = new SqlCommand("SP_EliminarUsuario", conexion.cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Usuario", id);
                    return cmd.ExecuteNonQuery();
                }
            }
            finally { conexion.CerrarConexion(); }
        }
    }

    public class MaestroDal
    {
        public IEnumerable<MaestroDto> Mostrar()
        {
            var lista = new List<MaestroDto>();
            var conexion = new Conexion();
            try
            {
                conexion.AbrirConexion();
                using (var cmd = new SqlCommand("SP_MostrarMaestro", conexion.cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new MaestroDto
                            {
                                IdMaestro = Convert.ToInt32(r["Id_Maestro"]),
                                Nombre = r["Nombre"].ToString(),
                                Apellido = r["Apellido"].ToString(),
                                Telefono = r["Telefono"].ToString(),
                                IdUsuario = Convert.ToInt32(r["Id_Usuario"])
                            });
                        }
                    }
                }
            }
            finally { conexion.CerrarConexion(); }
            return lista;
        }

        public int Insertar(MaestroDto m)
        {
            var conexion = new Conexion();
            try
            {
                conexion.AbrirConexion();
                using (var cmd = new SqlCommand("SP_InsertarMaestro", conexion.cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", m.Nombre ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Apellido", m.Apellido ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Telefono", m.Telefono ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Id_Usuario", m.IdUsuario);
                    return cmd.ExecuteNonQuery();
                }
            }
            finally { conexion.CerrarConexion(); }
        }

        public int Actualizar(MaestroDto m)
        {
            var conexion = new Conexion();
            try
            {
                conexion.AbrirConexion();
                using (var cmd = new SqlCommand("SP_ActualizarMaestro", conexion.cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Maestro", m.IdMaestro);
                    cmd.Parameters.AddWithValue("@Nombre", m.Nombre ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Apellido", m.Apellido ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Telefono", m.Telefono ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Id_Usuario", m.IdUsuario);
                    return cmd.ExecuteNonQuery();
                }
            }
            finally { conexion.CerrarConexion(); }
        }

        public int Eliminar(int id)
        {
            var conexion = new Conexion();
            try
            {
                conexion.AbrirConexion();
                using (var cmd = new SqlCommand("SP_DesactivarMaestro", conexion.cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Maestro", id);
                    return cmd.ExecuteNonQuery();
                }
            }
            finally { conexion.CerrarConexion(); }
        }
    }

    public class EstudianteDal
    {
        public IEnumerable<EstudianteDto> Mostrar()
        {
            var lista = new List<EstudianteDto>();
            var conexion = new Conexion();
            try
            {
                conexion.AbrirConexion();
                using (var cmd = new SqlCommand("SP_MostrarEstudiante", conexion.cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            lista.Add(new EstudianteDto
                            {
                                IdEstudiante = Convert.ToInt32(r["Id_Estudiante"]),
                                Nombre = r["Nombre"].ToString(),
                                Apellido = r["Apellido"].ToString(),
                                Direccion = r["Direccion"].ToString(),
                                Genero = r["Genero"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(r["Fecha_Nacimiento"]),
                                NombrePadres = r["Nombre_Padres"].ToString(),
                                TelefonoPadre = r["Telefono_Padre"].ToString()

                            });
                        }
                    }
                }
            }
            finally { conexion.CerrarConexion(); }
            return lista;
        }

        public int Insertar(EstudianteDto e)
        {
            var conexion = new Conexion();
            try
            {
                conexion.AbrirConexion();
                using (var cmd = new SqlCommand("SP_InsertarEstudiante", conexion.cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", e.Nombre ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Apellido", e.Apellido ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Direccion", e.Direccion ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Genero", e.Genero ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fecha_Nacimiento", e.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Nombre_Padres", e.NombrePadres ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Telefono_Padre", e.TelefonoPadre ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fecha_Ingreso", e.FechaIngreso);
                    return cmd.ExecuteNonQuery();
                }
            }
            finally { conexion.CerrarConexion(); }
        }

        public int Actualizar(EstudianteDto e)
        {
            var conexion = new Conexion();
            try
            {
                conexion.AbrirConexion();
                using (var cmd = new SqlCommand("SP_ActualizarEstudiante", conexion.cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Estudiante", e.IdEstudiante);
                    cmd.Parameters.AddWithValue("@Nombre", e.Nombre ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Apellido", e.Apellido ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Direccion", e.Direccion ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Genero", e.Genero ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fecha_Nacimiento", e.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Nombre_Padres", e.NombrePadres ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Telefono_Padre", e.TelefonoPadre ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fecha_Ingreso", e.FechaIngreso);
                    return cmd.ExecuteNonQuery();
                }
            }
            finally { conexion.CerrarConexion(); }
        }

        public int Eliminar(int id)
        {
            var conexion = new Conexion();

            try
            {
                conexion.AbrirConexion();

                using (var cmd =
                    new SqlCommand(
                        "SP_EliminarEstudiante",
                        conexion.cn))
                {
                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@Id_Estudiante",
                        id);

                    return cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public class CursoDal
        {
            public IEnumerable<CursoDto> Mostrar()
            {
                var lista = new List<CursoDto>();
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_MostrarCurso", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (var r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                lista.Add(new CursoDto
                                {
                                    IdCurso = Convert.ToInt32(r["Id_Curso"]),
                                    NombreCurso = r["Nombre_Curso"].ToString(),
                                    Nivel = r["Nivel"].ToString(),
                                    Tanda = r["Tanda"].ToString(),
                                    IdMaestro = Convert.ToInt32(r["Id_Maestro"])
                                });
                            }
                        }
                    }
                }
                finally { conexion.CerrarConexion(); }
                return lista;
            }

            public int Insertar(CursoDto c)
            {
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_InsertarCurso", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre_Curso", c.NombreCurso ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Nivel", c.Nivel ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Tanda", c.Tanda ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Id_Maestro", c.IdMaestro);
                        return cmd.ExecuteNonQuery();
                    }
                }
                finally { conexion.CerrarConexion(); }
            }

            public int Actualizar(CursoDto c)
            {
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_ActualizarCurso", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Curso", c.IdCurso);
                        cmd.Parameters.AddWithValue("@Nombre_Curso", c.NombreCurso ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Nivel", c.Nivel ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Tanda", c.Tanda ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Id_Maestro", c.IdMaestro);
                        return cmd.ExecuteNonQuery();
                    }
                }
                finally { conexion.CerrarConexion(); }
            }

            public int Eliminar(int id)
            {
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_DesactivarCurso", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Curso", id);
                        return cmd.ExecuteNonQuery();
                    }
                }
                finally { conexion.CerrarConexion(); }
            }
        }

        public class AsignaturaDal
        {
            public IEnumerable<AsignaturaDto> Mostrar()
            {
                var lista = new List<AsignaturaDto>();
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_MostrarAsignatura", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (var r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                lista.Add(new AsignaturaDto
                                {
                                    IdAsignatura = Convert.ToInt32(r["Id_Asignatura"]),
                                    NombreAsignatura = r["Nombre_Asignatura"].ToString()
                                });
                            }
                        }
                    }
                }
                finally { conexion.CerrarConexion(); }
                return lista;
            }

            public int Insertar(AsignaturaDto a)
            {
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_InsertarAsignatura", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre_Asignatura", a.NombreAsignatura ?? (object)DBNull.Value);
                        return cmd.ExecuteNonQuery();
                    }
                }
                finally { conexion.CerrarConexion(); }
            }

            public int Actualizar(AsignaturaDto a)
            {
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_ActualizarAsignatura", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Asignatura", a.IdAsignatura);
                        cmd.Parameters.AddWithValue("@Nombre_Asignatura", a.NombreAsignatura ?? (object)DBNull.Value);
                        return cmd.ExecuteNonQuery();
                    }
                }
                finally { conexion.CerrarConexion(); }
            }

            public int Eliminar(int id)
            {
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_DesactivarAsignatura", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Asignatura", id);
                        return cmd.ExecuteNonQuery();
                    }
                }
                finally { conexion.CerrarConexion(); }
            }
        }

        public class MatriculaDal
        {
            public IEnumerable<MatriculaDto> Mostrar()
            {
                var lista = new List<MatriculaDto>();
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_MostrarMatricula", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (var r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                lista.Add(new MatriculaDto
                                {
                                    IdMatricula = Convert.ToInt32(r["Id_Matricula"]),
                                    FechaIngreso = Convert.ToDateTime(r["Fecha_Ingreso"]),
                                    IdEstudiante = Convert.ToInt32(r["Id_Estudiante"]),
                                    IdCurso = Convert.ToInt32(r["Id_Curso"])
                                });
                            }
                        }
                    }
                }
                finally { conexion.CerrarConexion(); }
                return lista;
            }

            public int Insertar(MatriculaDto m)
            {
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_InsertarMatricula", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Fecha_Ingreso", m.FechaIngreso);
                        cmd.Parameters.AddWithValue("@Id_Estudiante", m.IdEstudiante);
                        cmd.Parameters.AddWithValue("@Id_Curso", m.IdCurso);
                        return cmd.ExecuteNonQuery();
                    }
                }
                finally { conexion.CerrarConexion(); }
            }

            public int Actualizar(MatriculaDto m)
            {
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_ActualizarMatricula", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Matricula", m.IdMatricula);
                        cmd.Parameters.AddWithValue("@Fecha_Ingreso", m.FechaIngreso);
                        cmd.Parameters.AddWithValue("@Id_Estudiante", m.IdEstudiante);
                        cmd.Parameters.AddWithValue("@Id_Curso", m.IdCurso);
                        return cmd.ExecuteNonQuery();
                    }
                }
                finally { conexion.CerrarConexion(); }
            }

            public int Eliminar(int id)
            {
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_DesactivarMatricula", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Matricula", id);
                        return cmd.ExecuteNonQuery();
                    }
                }
                finally { conexion.CerrarConexion(); }
            }
        }

        public class HorarioDal
        {
            public IEnumerable<HorarioDto> Mostrar()
            {
                var lista = new List<HorarioDto>();
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_MostrarHorario", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (var r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                lista.Add(new HorarioDto
                                {
                                    IdHorario = Convert.ToInt32(r["Id_Horario"]),
                                    Aula = r["Aula"].ToString(),
                                    HoraInicio = (TimeSpan)r["Hora_Inicio"],
                                    HoraFin = (TimeSpan)r["Hora_Fin"],
                                    Dia = r["Dia"].ToString(),
                                    IdAsignatura = Convert.ToInt32(r["Id_Asignatura"]),
                                    IdCurso = Convert.ToInt32(r["Id_Curso"])
                                });
                            }
                        }
                    }
                }
                finally { conexion.CerrarConexion(); }
                return lista;
            }

            public int Insertar(HorarioDto h)
            {
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_InsertarHorario", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Aula", h.Aula ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Hora_Inicio", h.HoraInicio);
                        cmd.Parameters.AddWithValue("@Hora_Fin", h.HoraFin);
                        cmd.Parameters.AddWithValue("@Dia", h.Dia ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Id_Asignatura", h.IdAsignatura);
                        cmd.Parameters.AddWithValue("@Id_Curso", h.IdCurso);
                        return cmd.ExecuteNonQuery();
                    }
                }
                finally { conexion.CerrarConexion(); }
            }

            public int Actualizar(HorarioDto h)
            {
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_ActualizarHorario", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Horario", h.IdHorario);
                        cmd.Parameters.AddWithValue("@Aula", h.Aula ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Hora_Inicio", h.HoraInicio);
                        cmd.Parameters.AddWithValue("@Hora_Fin", h.HoraFin);
                        cmd.Parameters.AddWithValue("@Dia", h.Dia ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Id_Asignatura", h.IdAsignatura);
                        cmd.Parameters.AddWithValue("@Id_Curso", h.IdCurso);
                        return cmd.ExecuteNonQuery();
                    }
                }
                finally { conexion.CerrarConexion(); }
            }

            public int Eliminar(int id)
            {
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_DesactivarHorario", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Horario", id);
                        return cmd.ExecuteNonQuery();
                    }
                }
                finally { conexion.CerrarConexion(); }
            }
        }

        public class CalificacionDal
        {
            public IEnumerable<CalificacionDto> Mostrar()
            {
                var lista = new List<CalificacionDto>();
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_MostrarCalificacion", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (var r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                lista.Add(new CalificacionDto
                                {
                                    IdCalificacion = Convert.ToInt32(r["Id_Calificacion"]),
                                    P1 = Convert.ToDecimal(r["P1"]),
                                    P2 = Convert.ToDecimal(r["P2"]),
                                    P3 = Convert.ToDecimal(r["P3"]),
                                    P4 = Convert.ToDecimal(r["P4"]),
                                    IdAsignatura = Convert.ToInt32(r["Id_Asignatura"]),
                                    IdMaestro = Convert.ToInt32(r["Id_Maestro"]),
                                    IdMatricula = Convert.ToInt32(r["Id_Matricula"])
                                });
                            }
                        }
                    }
                }
                finally { conexion.CerrarConexion(); }
                return lista;
            }

            public int Insertar(CalificacionDto c)
            {
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_InsertarCalificacion", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@P1", c.P1);
                        cmd.Parameters.AddWithValue("@P2", c.P2);
                        cmd.Parameters.AddWithValue("@P3", c.P3);
                        cmd.Parameters.AddWithValue("@P4", c.P4);
                        cmd.Parameters.AddWithValue("@Id_Asignatura", c.IdAsignatura);
                        cmd.Parameters.AddWithValue("@Id_Maestro", c.IdMaestro);
                        cmd.Parameters.AddWithValue("@Id_Matricula", c.IdMatricula);
                        return cmd.ExecuteNonQuery();
                    }
                }
                finally { conexion.CerrarConexion(); }
            }

            public int Actualizar(CalificacionDto c)
            {
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_ActualizarCalificacion", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Calificacion", c.IdCalificacion);
                        cmd.Parameters.AddWithValue("@P1", c.P1);
                        cmd.Parameters.AddWithValue("@P2", c.P2);
                        cmd.Parameters.AddWithValue("@P3", c.P3);
                        cmd.Parameters.AddWithValue("@P4", c.P4);
                        cmd.Parameters.AddWithValue("@Id_Asignatura", c.IdAsignatura);
                        cmd.Parameters.AddWithValue("@Id_Maestro", c.IdMaestro);
                        cmd.Parameters.AddWithValue("@Id_Matricula", c.IdMatricula);
                        return cmd.ExecuteNonQuery();
                    }
                }
                finally { conexion.CerrarConexion(); }
            }

            public int Eliminar(int id)
            {
                var conexion = new Conexion();
                try
                {
                    conexion.AbrirConexion();
                    using (var cmd = new SqlCommand("SP_DesactivarCalificacion", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id_Calificacion", id);
                        return cmd.ExecuteNonQuery();
                    }
                }
                finally { conexion.CerrarConexion(); }
            }
        }
        public class BoletinDal
        {
            public DataTable CargarCursos()
            {
                var conexion = new Conexion();

                try
                {
                    conexion.AbrirConexion();

                    using (var cmd = new SqlCommand("SP_CargarCursosBoletin", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (var da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }

            public DataTable CargarEstudiantePorCurso(int idCurso)
            {
                var conexion = new Conexion();

                try
                {
                    conexion.AbrirConexion();

                    using (var cmd = new SqlCommand("SP_CargarEstudiantesPorCurso", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id_Curso", idCurso);

                        using (var da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }

            public DataTable BoletinEstudiante(int idCurso, int idEstudiante)
            {
                var conexion = new Conexion();

                try
                {
                    conexion.AbrirConexion();

                    using (var cmd = new SqlCommand("SP_BoletinEstudiante", conexion.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id_Curso", idCurso);
                        cmd.Parameters.AddWithValue("@Id_Estudiante", idEstudiante);

                        using (var da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
        }
    }
}
