﻿using System;
using System.Collections.Generic;


namespace Team2.Models
{
  
    public partial class NivOrg 
    {

        public NivOrg()
        {

            trabajadores = new HashSet<Trabajadores>();
        }

        //Atributos del modelo NivOrg
        public string Camino { get; set; }
        public string CategNivel { get; set; }
        public string DNivel { get; set; }
        public string EsPuesto { get; set; }
        public DateTime FCreacion { get; set; }
        public DateTime? FInhabilitacion { get; set; }
        public DateTime Gcrowver { get; set; }
        public string IcoRes { get; set; }
        public int Id { get; set; }
        public string IdEmpresa { get; set; }
        public string IdNivel { get; set; }
        public string IdNivelHijo { get; set; }
        public string IdNivelPadre { get; set; }
        public string IdOrganig { get; set; }
        public string IdPuesto { get; set; }
        public string IdentNivel { get; set; }
        public string N1 { get; set; }
        public string N10 { get; set; }
        public string N2 { get; set; }
        public string N3 { get; set; }
        public string N4 { get; set; }
        public string N5 { get; set; }
        public string N6 { get; set; }
        public string N7 { get; set; }
        public string N8 { get; set; }
        public string N9 { get; set; }
        public int? Nivel { get; set; }
        public int OrganigId { get; set; }
        public string TResponsable { get; set; }

        public virtual ICollection<Trabajadores> trabajadores { get; set; }
    }
}
