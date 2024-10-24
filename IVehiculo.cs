using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_con_Ventanas
{
    public interface IVehiculo
    {
        string Marca { get; }
        string Modelo { get; }
        int Año { get; }
        string ToString();
    }
    public class Automovil : IVehiculo
    {
        public string Marca { get; }
        public string Modelo { get; }
        public int Año { get; }
        public int Puertas { get; }

        public Automovil(string marca, string modelo, int año, int puertas)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Puertas = puertas;
        }

        public override string ToString() =>
            $"Automóvil: {Marca} {Modelo} ({Año}), Puertas: {Puertas}";
    }
    public class Motocicleta : IVehiculo
    {
        public string Marca { get; }
        public string Modelo { get; }
        public int Año { get; }
        public bool TieneSidecar { get; }

        public Motocicleta(string marca, string modelo, int año, bool tieneSidecar)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            TieneSidecar = tieneSidecar;
        }

        public override string ToString() =>
            $"Motocicleta: {Marca} {Modelo} ({Año}), Sidecar: {TieneSidecar}";
    }
    public class Bicicleta : IVehiculo
    {
        public string Marca { get; }
        public string Modelo { get; }
        public int Año { get; }
        public string Tipo { get; }

        public Bicicleta(string marca, string modelo, int año, string tipo)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Tipo = tipo;
        }

        public override string ToString() =>
            $"Bicicleta: {Marca} {Modelo} ({Año}), Tipo: {Tipo}";
    }
}