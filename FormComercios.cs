using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ecommercetp1
{
    public partial class FormComercios : Form
    {
        public FormComercios()
        {
            InitializeComponent();
            CargarComercios();
        }

        // 🔄 1. MOSTRAR COMERCIOS
        private void CargarComercios()
        {
            string query = "SELECT Id_Comercios, Nombre_Comercio, Rubro, Email, Telefono, Plan, Fecha FROM comercios";
            try
            {
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    var adapter = new MySqlDataAdapter(query, conn);
                    var tabla = new DataTable();
                    adapter.Fill(tabla);

                    DGV_Comercios.DataSource = tabla;

                    // 🔥 AGREGA ESTA LÍNEA ACÁ ABAJO:
                    DGV_Comercios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        // ➕ 2. AGREGAR
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_NC.Text))
            {
                MessageBox.Show("El nombre del comercio es obligatorio.");
                return;
            }

            string query = @"INSERT INTO comercios (Nombre_Comercio, Rubro, Email, Telefono, Plan, Fecha) 
                            VALUES (@nombre, @rubro, @email, @telefono, @plan, @fecha)";

            try
            {
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txt_NC.Text);
                        cmd.Parameters.AddWithValue("@rubro", txt_Rubro.Text);
                        cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                        cmd.Parameters.AddWithValue("@telefono", txt_Telefono.Text);
                        cmd.Parameters.AddWithValue("@plan", txt_Plan.Text);

                        // Si dejas la fecha vacía, le manda la de hoy por defecto
                        if (DateTime.TryParse(txt_Fecha.Text, out DateTime fechaParseada))
                        {
                            cmd.Parameters.AddWithValue("@fecha", fechaParseada.ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd")); // Si está vacío o mal escrito, clava la fecha de hoy
                        }
                    }
                }
                MessageBox.Show("¡Comercio registrado con éxito!");
                CargarComercios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        // 📝 3. MODIFICAR
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IDC.Text))
            {
                MessageBox.Show("Ingrese el ID_Comercios que desea modificar.");
                return;
            }

            string query = @"UPDATE comercios 
                    SET Nombre_Comercio = @nombre, Rubro = @rubro, Email = @email, Telefono = @telefono, Plan = @plan, Fecha = @fecha 
                    WHERE Id_Comercios = @id";

            try
            {
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", txt_IDC.Text);
                        cmd.Parameters.AddWithValue("@nombre", txt_NC.Text);
                        cmd.Parameters.AddWithValue("@rubro", txt_Rubro.Text);
                        cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                        cmd.Parameters.AddWithValue("@telefono", txt_Telefono.Text);
                        cmd.Parameters.AddWithValue("@plan", txt_Plan.Text);

                        // 🔥 AQUÍ ENTRÓ EL REEMPLAZO DE LA FECHA:
                        if (DateTime.TryParse(txt_Fecha.Text, out DateTime fechaModificada))
                        {
                            cmd.Parameters.AddWithValue("@fecha", fechaModificada.ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"));
                        }

                        int filas = cmd.ExecuteNonQuery();
                        if (filas > 0) MessageBox.Show("¡Comercio modificado!");
                        else MessageBox.Show("No se encontró ese ID.");
                    }
                }
                CargarComercios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        // ❌ 4. ELIMINAR
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IDC.Text))
            {
                MessageBox.Show("Ingrese el ID_Comercios a eliminar.");
                return;
            }

            string query = "DELETE FROM comercios WHERE Id_Comercios = @id";

            try
            {
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", txt_IDC.Text);
                        int filas = cmd.ExecuteNonQuery();
                        if (filas > 0) MessageBox.Show("¡Comercio eliminado con éxito!");
                        else MessageBox.Show("ID no encontrado.");
                    }
                }
                CargarComercios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        // 🔍 5. BUSCAR
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string query;
            bool buscaPorId = !string.IsNullOrEmpty(txt_IDC.Text);

            // Si hay algo en el campo ID, busca por ID exacta. Si no, busca por Nombre.
            if (buscaPorId)
            {
                query = "SELECT * FROM comercios WHERE Id_Comercios = @id";
            }
            else
            {
                query = "SELECT * FROM comercios WHERE Nombre_Comercio LIKE @buscar";
            }

            try
            {
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        if (buscaPorId)
                        {
                            cmd.Parameters.AddWithValue("@id", txt_IDC.Text);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@buscar", "%" + txt_NC.Text + "%");
                        }

                        var adapter = new MySqlDataAdapter(cmd);
                        var tabla = new DataTable();
                        adapter.Fill(tabla);
                        DGV_Comercios.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txt_IDC.Clear();
            txt_NC.Clear();
            txt_Rubro.Clear();
            txt_Email.Clear();
            txt_Telefono.Clear();
            txt_Plan.Clear();
            txt_Fecha.Clear();
        }

        private void DGV_Comercios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que el clic sea en una fila válida y no en la cabecera
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGV_Comercios.Rows[e.RowIndex];

                // Pasamos el contenido de cada columna a su respectivo TextBox
                txt_IDC.Text = fila.Cells["Id_Comercios"].Value.ToString();
                txt_NC.Text = fila.Cells["Nombre_Comercio"].Value.ToString();
                txt_Rubro.Text = fila.Cells["Rubro"].Value.ToString();
                txt_Email.Text = fila.Cells["Email"].Value.ToString();
                txt_Telefono.Text = fila.Cells["Telefono"].Value.ToString();
                txt_Plan.Text = fila.Cells["Plan"].Value.ToString();

                // Para la fecha, le quitamos la hora si es que la trae para que no falle el formato
                if (fila.Cells["Fecha"].Value != DBNull.Value)
                {
                    DateTime fecha = Convert.ToDateTime(fila.Cells["Fecha"].Value);
                    txt_Fecha.Text = fecha.ToString("dd/MM/yyyy");
                }
                else
                {
                    txt_Fecha.Clear();
                }
            }
        }
    }
}
