using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keythi.Prototipos.Ejercicios01.DatosDeUnaPersona
{
    internal class DatosDeUnaPersonaModelo
    {
        private List<Persona> personas = new(); 

        internal string IngresarPersona(Persona persona)
            // Recibe persona como parametro
        {
            // Validar Documento (DNI)
            if (persona.Dni < 1000000 || persona.Dni > 99999999)
            {
                return "El documento debe tener entre 7-8 dígitos";
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

            // no quiero DNI repetidos
            foreach(var personaGuardada in personas)
            {
                if(personaGuardada.Dni == persona.Dni)
                {
                    return $"Ya se ha ingresado una persona con DNI: {persona.Dni}";
                }
            }
            
            // guardo datos en una lista
            personas.Add(persona);

            // Si todo es válido, puedes retornar null o una cadena vacía
            return null; // Para indicar todo ok
            // podria poner return "Hay un problema con la persona ingresada"
        }
    }
}
