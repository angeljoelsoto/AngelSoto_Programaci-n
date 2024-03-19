 using System; 
 
namespace Clases
{
    public class Persona  // se le denomina el tipo de datos 
    {
        //ATRIBUTOS 
        private String _nombre;
        private int _edad; 
        private double _altura; 

        //DOS CONTRUCTORES UNO VACIO Y UNO QUE LLENE LOS DATOS DE ENTRADA 

        //CONTRUCTOR VACIO
        public Persona()
        {

        }

        //CONTRUCTOR 
        public  Persona(string nombre, int edad, double altura)
        {
            nombre = _nombre;
            edad = _edad;
            altura = _altura;

        }

        public void set_nombre(string nombre)
        {
            nombre = _nombre; 
        }
    }
 
}