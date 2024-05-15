﻿using Business.Interfaces;
using Core.ModelsView;
using Infraestrucuta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class PersonaServices : IPerfilServices
    {
        private readonly Desarrollo_plataformasContext _dbcontext;

        public PersonaServices() { }

        public PersonaServices(Desarrollo_plataformasContext dbcontext)
        {
            _dbcontext = dbcontext;
        }


        public List<PersonaView> ConsultarServicios()
        {
            List<PersonaView> listaPersonaView = new List<PersonaView>();
            var listServicios = _dbcontext.Personas.ToList();

            if (listServicios != null)
            {
                foreach (var item in listServicios)
                {
                    PersonaView PersonaView = new PersonaView()
                    {
                        PersonaId = item.PersonaId,
                        Apellido = item.Apellido,
                        Nombre = item.Nombre,
                        CorreoElectronico = item.CorreoElectronico,
                    };
                    listaPersonaView.Add(PersonaView);
                }
            }

            return listaPersonaView;
        }

        public PersonaView buscarid(int id)
        {
            var Persona = _dbcontext.Personas.Find(id);
            if (Persona == null)
            {
                return null;
            }
            PersonaView PersonaView = new PersonaView()
            {
                PersonaId = Persona.PersonaId,
                Apellido = Persona.Apellido,
                Nombre = Persona.Nombre,
                CorreoElectronico = Persona.CorreoElectronico,
            };
             return PersonaView;
        }

        public Persona EliminarPorId(int id)
        {
            
            var persona = _dbcontext.Personas.Find(id);

            if (persona == null)
            {
                return null;
            }
            _dbcontext.Personas.Remove(persona);
            _dbcontext.SaveChanges();
             return persona; 

        }

        public Persona ActualizarP(int id, PersonaView personaView)
        {
            var persona = _dbcontext.Personas.Find(id);

            if(persona != null)
            {
                persona.Nombre = personaView.Nombre;
                persona.Apellido = personaView.Apellido;
                persona.CorreoElectronico = personaView.CorreoElectronico;
                _dbcontext.SaveChanges();
                return persona;
            }

            return null;
            
        }

        public Persona AgregarP(int id, PersonaView personaView)
        {
            var personaR = _dbcontext.Personas.Find(id);

            if(personaR != null)
            {
                return null;
            }
            var Cpersona = new Persona
            {
                PersonaId = personaView.PersonaId,
                Nombre = personaView.Nombre,
                Apellido = personaView.Apellido,
                CorreoElectronico = personaView.CorreoElectronico,
            };
            _dbcontext.Personas.Add(Cpersona);
            _dbcontext.SaveChanges();
            return personaR;

        }

    }
      
}
