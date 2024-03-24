﻿using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class VentasDAL
    {
        Tienda_DbContext _db;

        public int Guardar(Venta venta, int id, bool actualizando = false)
        {
            _db = new Tienda_DbContext();
            int resultado;

            if (actualizando)
            {
                _db.Entry(venta).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
            else
            {
                _db.Ventas.Add(venta);
                _db.SaveChanges();
                
            }
            resultado = venta.VentaId;

            return resultado;
        }

        public List<Venta> Lista()
        {
            _db = new Tienda_DbContext();

            return _db.Ventas.ToList();
        }
    }
}