using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace App1
{

    public enum TipoArticulo { Alimento, Entretenimiento, Ferreteria };
    public partial class Form1 : Form
    {

        List<Producto> ListadoProductos;

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

              

        Producto CrearProducto()
        {
            Producto objProducto;

            if (ChkCambiarIVA.Checked)
            {
                objProducto = new Producto(Convert.ToDouble(TxtIva.Text));
            }
            else
            {
                objProducto = new Producto();
            }
             
            objProducto.IdArticulo = TxtIdArticulo.Text;
            objProducto.NomArticulo = TxtNomArticulo.Text;
            objProducto.Tipo = CmbTipoArticulo.SelectedIndex;
            objProducto.FechaRegistro = DtRegistro.Value;            
            objProducto.Costo = Convert.ToDouble(TxtCosto.Text);
            objProducto.Cantidad = Convert.ToInt32(TxtCantidad.Text);            
            objProducto.CalcularIVA();
            objProducto.TotalCosto = objProducto.CalcularTotal();         
            
            return objProducto;
        }

        void LimpiarControles()
        {
            TxtIdArticulo.Text = "";
            TxtNomArticulo.Text = "";
            CmbTipoArticulo.SelectedIndex = 0;
            DtRegistro.Value = DateTime.Now;
            TxtCosto.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
            TxtIva.Text = "0";
            ChkCambiarIVA.Checked = false;
        }

       


        private void Form1_Load(object sender, EventArgs e)
        {
            if (!ChkCambiarIVA.Checked)
            {
                TxtIva.Enabled = false;
            }

            ListadoProductos = new List<Producto>();
            DgProductos.DataSource = ListadoProductos;
            CmbTipoArticulo.SelectedIndex = 0;
            DtRegistro.Value = DateTime.Now;


        }

        private void ChkCambiarIVA_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChkCambiarIVA.Checked)
            {
                TxtIva.Enabled = false;
                TxtIva.Text = "0";
            }
            else
            {
                TxtIva.Enabled = true;
                TxtIva.Text = string.Empty;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Producto objProdGuardar = CrearProducto();
            ListadoProductos.Add(objProdGuardar);
            //DgProductos.DataSource = null;
            DgProductos.DataSource = ListadoProductos.ToList();

            LimpiarControles();
        }
    }
}
