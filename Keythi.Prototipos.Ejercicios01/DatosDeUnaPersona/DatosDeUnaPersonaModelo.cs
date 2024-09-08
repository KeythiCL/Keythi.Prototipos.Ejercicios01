using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keythi.Prototipos.Ejercicios01.DatosDeUnaPersona
{
    internal class DatosDeUnaPersonaModelo
    {
        internal string IngresarPersona(Persona persona)
        {
            // Validar Documento (DNI)
            if (persona.Dni < 1000000 || persona.Dni > 99999999)
            {
                return "El documento debe tener entre 7 y 8 dígitos";
            }

            // Validar Nombre
            if (string.IsNullOrWhiteSpace(persona.Nombre))
            {
                return "El nombre es requerido";
            }
            if (persona.Nombre.Length > 50)
            {
                return "El nombre debe tener máximo 50 caracteres";
            }

            // Validar Apellido
            if (string.IsNullOrWhiteSpace(persona.Apellido))
            {
                return "El apellido es requerido";
            }
            if (persona.Apellido.Length > 50)
            {
                return "El apellido debe tener máximo 50 caracteres";
            }

            // Validar Fecha de Nacimiento
            if (persona.FechaNacimiento >= DateTime.Now)
            {
                return "La fecha de nacimiento debe ser menor a la fecha actual";
            }

            // Si todo es válido, puedes retornar null o una cadena vacía
            return null;
        }
    }
}
