﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public interface ICasillaDAO
    {
        bool NombreExistente(string pNombre, int idCuenta);
        List<string> ListaNombres(int idCuenta);
        int BuscarId(string pNombre, int pIdUsuario);
        string BuscarDireccion(string pNombre, int pIdUsuario);
        string BuscarContraseña(string pNombre,int pIdUsuario);
        void Agregar(CasillaCorreo pCasilla, int pServicio, int pUsuario);
        void Modificar(CasillaCorreo pCasilla, int pIDUsuario);
        void Eliminar(string pNombreCasilla, int pIDUsaruio);
        int ObtenerIdServicio(int idCasilla);
    }
}
