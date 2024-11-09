using Recuperativa;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EvaluaciónRecuperativa
{
    public partial class Productos : Form
    {
        // Lista de productos
        private List<Producto> productos = new List<Producto>();
        private int siguienteId = 1;  // Para asignar ID autogenerado

        public Productos()
        {
            InitializeComponent();
        }

        // Método para agregar un producto
        private void button_agregar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número positivo.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero no negativo.");
                return;
            }

            // Crear un nuevo producto con ID autogenerado
            Producto nuevoProducto = new Producto()
            {
                ID = siguienteId++,  // Asignar un ID único y autoincrementable
                Nombre = txtNombre.Text,
                Precio = precio,
                Cantidad = cantidad,
                Descripcion = txtDescripcion.Text
            };

            // Agregar producto a la lista
            productos.Add(nuevoProducto);
            MessageBox.Show("Producto agregado exitosamente.");

            // Limpiar campos y actualizar listado
            LimpiarCampos();
            ActualizarListadoProductos();
        }

        // Actualizar el DataGridView con los productos
        private void ActualizarListadoProductos()
        {
            dgvProductos.DataSource = null;  // Limpiar la fuente de datos actual
            dgvProductos.DataSource = productos;  // Asignar la lista actualizada de productos
        }

        // Método para limpiar los campos de texto
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtDescripcion.Clear();
        }
        // Este método se ejecuta cuando cambia la selección en el DataGridView
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay filas seleccionadas en el DataGridView
            if (dgvProductos.SelectedRows.Count > 0)
            {
                // Obtener el producto seleccionado de la fila
                var productoSeleccionado = dgvProductos.SelectedRows[0].DataBoundItem as Producto;

                // Si el producto seleccionado no es nulo, llenar los campos con los datos del producto
                if (productoSeleccionado != null)
                {
                    txtNombre.Text = productoSeleccionado.Nombre; 
                    txtPrecio.Text = productoSeleccionado.Precio.ToString(); 
                    txtCantidad.Text = productoSeleccionado.Cantidad.ToString();  
                    txtDescripcion.Text = productoSeleccionado.Descripcion;  
                }
            }
        }

        // Este método se ejecuta cuando se hace clic en el botón de "Actualizar"
        private void button_actualizar_Click(object sender, EventArgs e)
        {
            // Validación: Verificar que el nombre no esté vacío
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío."); 
                return; 
            }

            // Validación: Verificar que el precio sea un número positivo
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número positivo."); 
                return; 
            }

            // Validación: Verificar que la cantidad sea un número entero no negativo
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero no negativo.");  
                return;  
            }

            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvProductos.SelectedRows.Count > 0)
            {
                // Obtener el producto seleccionado de la fila
                var productoSeleccionado = dgvProductos.SelectedRows[0].DataBoundItem as Producto;

                // Si el producto seleccionado no es nulo, actualizar sus datos con los valores del formulario
                if (productoSeleccionado != null)
                {
                    productoSeleccionado.Nombre = txtNombre.Text;
                    productoSeleccionado.Precio = precio; 
                    productoSeleccionado.Cantidad = cantidad; 
                    productoSeleccionado.Descripcion = txtDescripcion.Text; 

                    MessageBox.Show("Producto actualizado exitosamente");  

                    LimpiarCampos();
                    ActualizarListadoProductos();  
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para actualizar");  
            }
        }

        private void button_eliminar_Click_1(object sender, EventArgs e)
        {
            // Verificamos si se ha seleccionado alguna fila en el DataGridView
            if (dgvProductos.SelectedRows.Count > 0)
            {
                // Obtenemos el producto seleccionado de la fila en el DataGridView
                var productoSeleccionado = dgvProductos.SelectedRows[0].DataBoundItem as Producto;

                // Verificamos si el producto seleccionado no es nulo
                if (productoSeleccionado != null)
                {
                    // Mostramos un cuadro de diálogo pidiendo confirmación para eliminar el producto
                    DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este producto?",
                                                          "Confirmación", MessageBoxButtons.YesNo);

                    // Si el usuario elige "Sí", procedemos a eliminar el producto
                    if (result == DialogResult.Yes)
                    {
                        // Eliminamos el producto de la lista
                        productos.Remove(productoSeleccionado);

                        // Mostramos un mensaje de éxito
                        MessageBox.Show("Producto eliminado exitosamente.");

                        // Actualizamos el DataGridView para reflejar los cambios
                        ActualizarListadoProductos();
                    }
                }
            }
            else
            {
                // Si no se ha seleccionado ningún producto, mostramos un mensaje de error
                MessageBox.Show("Selecciona un producto para eliminar.");
            }
        }
    }
}

