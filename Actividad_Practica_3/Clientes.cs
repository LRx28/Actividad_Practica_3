using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;



namespace Actividad_Practica_3;

public partial class Clientes : Form
{
    public Clientes()
    {
        InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void btn_Cargar_Click(object sender, EventArgs e)
    {

        string connectionString = @"Data Source=LR;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string queryClientes = "SELECT * FROM Clientes;";

            using (SqlCommand cmd = new SqlCommand(queryClientes, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv_Mostrar.DataSource = dt;
                }
            }

            connection.Close();

        }
    }

    private void btn_Agregar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txt_Nombre.Text))
        {
            MessageBox.Show("Nombre incorrecto o vacio.");
            return;
        }

        if (string.IsNullOrEmpty(txt_Telefono.Text))
        {
            MessageBox.Show("Telefono incorrecto o vacio.");
            return;
        }

        if (string.IsNullOrEmpty(txt_Correo.Text))
        {
            MessageBox.Show("Correo electronico incorrecto o vacio.");
            return;
        }

        if (string.IsNullOrEmpty(txt_Direccion.Text))
        {
            MessageBox.Show("Direccion incorrecta o vacia.");
            return;
        }

        string connectionString = @"Data Source=LR;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string queryInsertarClientes = @"INSERT INTO Clientes (Nombre, Telefono, Correo, Direccion)" +
                " VALUES ('" + txt_Nombre.Text + "','" + txt_Telefono.Text + "' , '" + txt_Correo.Text + "', '" + txt_Direccion.Text + "'";

            using (SqlCommand cmd = new SqlCommand(queryInsertarClientes, connection))
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Se ha insertado al cliente en la base de datos correctamente.");
                }

            }

            connection.Close();
        }

    }

    private void btn_Eliminar_Click(object sender, EventArgs e)
    {

    }
}


