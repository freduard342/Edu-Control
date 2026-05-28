using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using System.Windows.Controls;

namespace CapaPresentacion
{
    public partial class RolesForm : Form
    {
        private readonly UsuarioBll _bll = new UsuarioBll();
        private readonly BindingSource _bs = new BindingSource();
        private int idUsuarioSeleccionado = 0;

        public RolesForm()
        {
            InitializeComponent();
            dgvRoles.AutoGenerateColumns = true;
            dgvRoles.DataSource = _bs;
            CargarDatos();
            CargarRoles();
        }

        private void CargarDatos()
        {
            try
            {
                var lista = _bll.GetAll()?.ToList() ?? Enumerable.Empty<UsuarioDto>();
                _bs.DataSource = lista;
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvRoles.Columns["IdUsuario"].Visible = false;
            dgvRoles.Columns["IdRol"].Visible = false;
        }

        private void LimpiarCampos()
        {
            idUsuarioSeleccionado = 0;

            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;

            dgvRoles.ClearSelection();
        }

        private void CargarRoles()
        {
            cbRol.Items.Clear();

            cbRol.Items.Add(new ComboBoxItem("Administrador", 1));
            cbRol.Items.Add(new ComboBoxItem("Docente", 2));

            cbRol.DisplayMember = "Text";
            cbRol.ValueMember = "Value";

            cbRol.SelectedIndex = 0;
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e) => CargarDatos();

        private void btnNuevo_Click(object sender, EventArgs e) => LimpiarCampos();

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txtContraseña.Text))
                {
                    MessageBox.Show("Complete todos los campos.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                UsuarioDto dto = new UsuarioDto()
                {
                    NombreUsuario = txtUsuario.Text.Trim(),
                    Contrasena = txtContraseña.Text.Trim(),
                    IdRol = ((ComboBoxItem)cbRol.SelectedItem).Value
                };

                var ok = _bll.Add(dto);

                MessageBox.Show(ok
                    ? "Usuario creado correctamente."
                    : "No se pudo crear el usuario.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (ok)
                    CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idUsuarioSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un usuario.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txtContraseña.Text))
                {
                    MessageBox.Show("Complete todos los campos.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                UsuarioDto dto = new UsuarioDto()
                {
                    IdUsuario = idUsuarioSeleccionado,
                    NombreUsuario = txtUsuario.Text.Trim(),
                    Contrasena = txtContraseña.Text.Trim(),
                    IdRol = ((ComboBoxItem)cbRol.SelectedItem).Value
                };

                var ok = _bll.Update(dto);

                MessageBox.Show(ok
                    ? "Usuario actualizado correctamente."
                    : "No se pudo actualizar el usuario.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (ok)
                    CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idUsuarioSeleccionado == 0)
                {
                    MessageBox.Show(
                        "Seleccione un usuario.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                var r = MessageBox.Show(
                    "La eliminación es lógica (desactivará el usuario). ¿Desea continuar?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (r != DialogResult.Yes)
                    return;

                var ok = _bll.Delete(idUsuarioSeleccionado);

                MessageBox.Show(
                    ok ? "Usuario desactivado correctamente."
                       : "No se pudo desactivar el usuario.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (ok)
                    CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al eliminar: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvRoles_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoles.CurrentRow == null)
            {
                LimpiarCampos();
                return;
            }

            if (dgvRoles.CurrentRow.DataBoundItem is UsuarioDto usuario)
            {
                idUsuarioSeleccionado = usuario.IdUsuario;

                txtUsuario.Text = usuario.NombreUsuario;
                txtContraseña.Text = usuario.Contrasena;

                foreach (ComboBoxItem item in cbRol.Items)
                {
                    if (item.Value == usuario.IdRol)
                    {
                        cbRol.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void RolesForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}