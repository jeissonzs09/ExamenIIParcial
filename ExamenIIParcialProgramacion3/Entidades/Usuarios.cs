﻿using System;

namespace Entidades
{
    public class Usuarios
    {
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Rol { get; set; }
        public bool EstaActivo { get; set; }

        public Usuarios()
        {
        }

        public Usuarios(string codigoUsuario, string nombre, string contraseña, string correo, DateTime fechaCreacion, string rol, bool estaActivo)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contraseña = contraseña;
            Correo = correo;
            FechaCreacion = fechaCreacion;
            Rol = rol;
            EstaActivo = estaActivo;
        }
    }
}
