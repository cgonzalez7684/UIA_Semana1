using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Producto : Articulo, ICalculos   //Heredar
    {
       
        public int Tipo { get; set; }
        public DateTime? FechaRegistro { get; set; }  //Declarar una propiedad Nullable

        public int Cantidad { get; set; }
        public double Costo { get; set; }
        public double MontoIVA { get; set; }  
        
        public double TotalCosto { get; set; }
       

        public void CalcularIVA() //Estamos implementando la interfaz ICalculos el metodo CalcularIVA()
        {
            double Calculo = this.Costo * (this.PorcentajeIVA/100);            
            this.MontoIVA = Calculo;
        }

        public double CalcularTotal()
        {
            return (this.Costo + this.MontoIVA) * this.Cantidad;
        }

        
        public Producto()
        {
            this.PorcentajeIVA = 0;
        }

        public Producto(double Porcentaje)  //Sobrecarga de metodo constructor
        {
            this.PorcentajeIVA = Porcentaje;    //Utilizacion de propiedad protegida
        }
    }
}
